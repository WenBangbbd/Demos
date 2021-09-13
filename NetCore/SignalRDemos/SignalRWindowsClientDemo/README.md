### 创建客户端
1. 安装包 Microsoft.AspNetCore.SignalR.Client
2. 连接
``` C#
var connection = new HubConnectionBuilder()
                  .WithUrl("http://localhost:5000/chathub")
                  .Build();
```
3. 定义接受事件
``` C#
connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                txtMessages.AppendText(user+":"+message);
            });
```
4. 连接，注意按钮事件要改为async 方法才行
``` C#
 await connection.StartAsync();
```
5.发送数据，
``` C#
await connection.InvokeAsync("SendMessage", txtUser.Text, txtMessage.Text); 
```