import { createApp } from 'vue'
import App from './App.vue'
import Ant from 'ant-design-vue'
import 'ant-design-vue/dist/antd.css'
import axios from "axios";
import VueAxios from 'vue-axios';

const app=createApp(App);
//在给定的url前面加/api
axios.defaults.baseURL='/api'

app.use(VueAxios,axios);
app.provide('axios', app.config.globalProperties.axios)
app.use(Ant).mount('#app');
