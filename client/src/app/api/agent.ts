import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from "react-toastify";
import { PaginatedResponse } from "../models/pagination";


const sleep = () => new Promise(resolve => setTimeout(resolve, 500));

axios.defaults.baseURL = 'http://localhost:5000/api/';
axios.defaults.withCredentials = true;

const responseBody = (response: AxiosResponse) => response.data;

// # # # # #
interface ResponseData {
    data: {
        title: string;
        status: number;
        errors?: Object;
    };
    status: number;
}


// # # # # #

axios.interceptors.response.use(async (response) => {
    await sleep();
    const pagination = response.headers['pagination'];
    if (pagination) {
        response.data = new PaginatedResponse(response.data, JSON.parse(pagination));
        return response;
    }
    return await response;
}, async (error: AxiosError) => {
    console.log('--interceptor-- tarafından yakalandı!')
    const { data, status } = await error.response as ResponseData;

    switch (status) {
        case 401:
            toast.error(data.title);
            break;
        case 400:
            if (!!data.errors) {
                const modelStateErrors: string[] = [];
                for (const key in data.errors) {
                    // @ts-ignore
                    if (data.errors[key]) modelStateErrors.push(data.errors[key]);
                }
                throw modelStateErrors.flat();
            }
            toast.error(data.title);
            break;
        case 404:
            toast.error(data.title);
            break;
        case 500:
            toast.error(data.title  );
            break;
        default:
            break;
    }
    return Promise.reject(error.response);
})

// GET, POST, PUT, DELETE
const requests = {
    get: (url: string, params?: URLSearchParams) => axios.get(url, {params}).then(responseBody),
    post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
    put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
    delete: (url: string) => axios.delete(url).then(responseBody),
}

// methods objects for requests for catalog
const Catalog = {
    list: (params: URLSearchParams) => requests.get('products', params),
    details: (id: number) => requests.get(`products/${id}`),
    fetchFilters: () => requests.get('products/filters')
}

// errors mappings
const TestErrors = {
    get400Error: () => requests.get('ErrorHandling/bad-request'),
    get401Error: () => requests.get('ErrorHandling/unauthorised'),
    get404Error: () => requests.get('ErrorHandling/not-found'),
    get500Error: () => requests.get('ErrorHandling/server-error'),
    getValidationError: () => requests.get('ErrorHandling/validation-error'),
}

const Basket = {
    get: () => requests.get('basket'),
    addItem: (productId: number, quantity = 1) => requests.post(`basket?productId=${productId}&quantity=${quantity}`, {}),
    removeItem: (productId: number, quantity = 1) => requests.delete(`basket?productId=${productId}&quantity=${quantity}`)
}

const agent = { Catalog, TestErrors, Basket };

export default agent;