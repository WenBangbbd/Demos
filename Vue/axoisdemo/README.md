# axoisdemo

## Project setup
```
yarn install
```

### Compiles and hot-reloads for development
```
yarn serve
```

### Compiles and minifies for production
```
yarn build
```

### Lints and fixes files
```
yarn lint
```

### Customize configuration
See [Configuration Reference](https://cli.vuejs.org/config/).

### 首先安装
yarn add axios
npm i axios

### 静态使用
1.直接在组件中引入axios即可，import axios from "axios";
2.使用其静态方法即可

### 全局变量
1. 使用vue-axios安全插件https://www.npmjs.com/package/vue-axios
2. 安装yarn add vue-axios
3. 在main.js中引入vue-axios以及axios
4. 安装axios在app实例上
5. 提供全局变量 app.provide('axios', app.config.globalProperties.axios)
6. 在steup中需要 const axios=inject('key')来获取变量，在method中就可以用this.axios来获取
#### 封装api
1.在api中创建js文件

### 跨域问题
1. 设置axios的baseurl为'api'，用于标记替换，看mian.js中
2. 在根目录下创建vue.config.js文件
3. 在文件中输入代理设置
