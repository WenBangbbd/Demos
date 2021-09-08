import axios from "axios"
import { VueAxios } from "./axios";

const request=axios.create({
    baseURL:'http"//localhost:8083',
    timeout:6000
})

request.interceptors.response.use(response=>response.data);

const installer={
    vm:{},
    install(Vue){
        Vue.use(VueAxios,request)
    }
}

export{
    installer as VueAxios,
    request 
}