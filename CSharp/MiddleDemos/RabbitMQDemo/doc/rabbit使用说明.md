### rabbit使用说明
#### docker中启动rabbitmq
1. 执行命令
run -d --hostname my-rabbit --name some-rabbit -p 15672:15672 -p 5672:5672 -e RABBITMQ_DEFAULT_USER=admin -e RABBITMQ_DEFAULT_PASS=admin  rabbitmq:3-management
	+ 15672是web管理平台的端口，暴露出来才能登录网页
	+ 5672是用于客户端使用，代码链接时需要用这个端口
	+ -e 时用户名和密码
	+ rabbitmq:3-management，标签带management的才有web管理平台
2. nuget中安装rabbitmq.client
3. 抽象
	1.队列
		Name，队列名称
		Durable，队列是否持久化，持久化后重启rabbitmq后队列仍然存在
		Exclusive，独占，只被一个连接（connection）使用，而且当连接关闭后队列即被删除
		Auto-delete,当最后一个消费者退订后即被删除
		Arguments（一些消息代理用他来完成类似与TTL的某些额外功能）
		队列中的消息只能够被消费者消费一次
	2.消费者
		必须定义消费者应答策略，否则接受不到消息,并且queue是要接受的队列的名称，错误也接受不到消息
		channel.BasicConsume(queue:"confirm",autoAck:false,consumer: consumer);
		自动确认
			autoAck，true
			收到就应答
		手动确认
			可以自定义确认时机，一般选择在正确处理完数据后才确认
			autoAck,false，
			处理数据会已知处理，但是不应答，队列不会删除数据
			如果消费者断掉，没有应答的所有数据都重新进入队列，提供给其他消费者消费
			手动确认命令：channel.BasicAck(deliveryTag:e.DeliveryTag,multiple:false);
			multple表示不批量确认
			默认30分钟的上限
	3.生产者
		选择发布确认模式，  channel.ConfirmSelect();
		等待所有消息发布成功， channel.WaitForConfirms();
	4.交换机
		交换机和队列通过routingkey绑定在一起
		扇出交换机，
			广播发送消息给队列,一个交换机对一个routekey,一个routekey对多个队列
		直接交换机
			一个交换机对多个routekey，routekey和队列多对多
