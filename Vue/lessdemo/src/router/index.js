import { createRouter, createWebHistory } from 'vue-router'
import UserLayout from '../layout/UserLayout'

const routes = [
    {
        path: '',
        component: UserLayout
    }
];

export default createRouter({
    history: createWebHistory(),
    routes
});