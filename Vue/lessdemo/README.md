# lessdemo

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

### 引入ant-design-vue
yarn add ant-design-vue@next
在main.js中导入ant=>app.use(ant)
在main.js中导入样式，import "ant-design-vue/dist/antd.css";
在使用ant时，要注意其class和标签名称可能不一致，要注意看文档
### 使用ant-design-vue/icon
yarn add @ant-desgin/icons-vue
在组件中引入对应的icon
使用情况见icontest.vue
### 引入less
yarn add global less less-loader
注意要选择版本，否则会报错
+ "less": "^4.1.1",
+ "less-loader": "^5.0.0",

