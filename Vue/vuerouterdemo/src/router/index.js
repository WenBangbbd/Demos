import {createRouter,createWebHashHistory} from 'vue-router'
import Hom from '../components/Home'

const routes=[
    {
        path:'',
        redirect:'/home'
    },
    {
        path:'/home',
        component:Hom
    }
]
export default createRouter({
    history:createWebHashHistory(),
    routes
})