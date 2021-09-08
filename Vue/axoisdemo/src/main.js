import { createApp } from 'vue'
import App from './App.vue'
import Ant from 'ant-design-vue'
import 'ant-design-vue/dist/antd.css'
import axios from "axios";


const app=createApp(App);
app.prototype.$axios=axios;
app.use(Ant).mount('#app');

