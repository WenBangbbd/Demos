## 反向代理
1. 一般代理分为正向代理和反向代理
2. 正向指内部网络访问外部网络，在中间架设的一层代理，该代理用于管理流量，控制访问，监控访问，解决上网慢等问题
3. 反向代理指外部网络访问内部网络，在网络间架设的一层代理，用于负载均衡等业务。
4. 反向代理常用ngix来完成
### nginx
#### 基础
1. [安装](http://nginx.org/en/download.html)
2. 启动，直接双击.exe文件，或者start nginx
3. 查看启动，访问地址localhost:port
4. 如果启动不成功，可能是端口被占用，conf=>nginx.conf=>port修改即可
5. 重启  nginx -s reload
6. 关闭  nginx -s stop(快速)/ nginx -s quit(有序),
#### 配置
1. 分为全局块，event块，http块
#### nginx 反向代理配置
1. 配置单个转发
``` json
server {
        listen       9090; //监听端口
        server_name  localhost;//监听主机

        location / {//匹配的uri
	        proxy_pass http://localhost:6001;//替换主机端口
        }
    }
```