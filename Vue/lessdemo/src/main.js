import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import Ant from 'ant-design-vue'
import Less from 'less'

createApp(App)
.use(Ant)
.use(router)
.use(Less)
.mount('#app')
