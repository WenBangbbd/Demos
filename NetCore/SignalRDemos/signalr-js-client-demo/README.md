# signalr-js-client-demo

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

### 使用signalr
1. 安装包 npm install @microsoft/signalr
2. 引用 import * as signalR from "@microsoft/signalr";
3. 其他配置详见 CDNSignalR.vue即可
4. 跨域配置，在服务端配置注意:  
+ 配置允许域时，需要设置为http://localhost:8080 不要/
+ 如果配置了httsredirect则需要使用https的地址
