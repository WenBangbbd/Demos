# vuerouterdemo

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

### 创建项目
vue create demoname
### 安装vue-router
cd demoname
yarn add vue-router@4
npm i vue-router@4
### 创建路由器
src =>创建router文件夹=>创建index.js
引入vue-router,生成router，然后导出,详情看文件
### 创建组件
在components中创建组件，然后配置到routes中
### 在main中引入router
引入router/index中的router，然后使用use引入vue
