
//全局变量的方式
// import { createApp } from 'vue'
// import App from './App.vue'
// import Ant from 'ant-design-vue'
// import 'ant-design-vue/dist/antd.css'
// import axios from "axios";
// import VueAxios from 'vue-axios';



// const app=createApp(App);
// //在给定的url前面加/api
// axios.defaults.baseURL='/api'
// //安装插件
// app.use(VueAxios,axios);
// //提供全局变量
// app.provide('axios', app.config.globalProperties.axios)
// app.use(Ant).mount('#app');

import { createApp } from "@vue/runtime-dom";
import App from './App.vue';
import Ant from 'ant-design-vue'
import 'ant-design-vue/dist/antd.css'
//配置文件的方式
createApp(App)
.use(Ant)
.mount('#app');