### 创建中心
#### 非强类型
1. 创建集线器ChatHub:Hub
2. 配置服务 services.AddSignalR();
3.   app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chathub");
            });
4. 启动即可，连接地址为http://localhost:5000/chathub
#### 强类型
1. 创建集线器 ChatHub:Hub<IChatClient>
2. IChatClient中定义客户端方法
3. 服务中使用时需要使用上下文IHubContext<THub,IChatClient>
### 创建客户端
[创建windows客户端](../SignalRWindowsClientDemo/README.md)
### 创建非跨域Web客户端
1.wwwroot的localsignar即可
### 创建跨域Web客户端
[创建web客户端](../signalr-js-client-demo/README.md)
