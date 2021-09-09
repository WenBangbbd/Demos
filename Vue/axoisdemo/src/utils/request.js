import axios from "axios"

const request=axios.create({
    baseURL:'/api',
    timeout:6000
})

request.interceptors.response.use(response=>response.data);


export{
    request 
}