public class Client {
    public static void main(String[] args) {
        var target=new Target();
        var proxy=new DynamicProxy();
       var targetProxy= proxy.getProxy(target);
       targetProxy.doSomthing();
       targetProxy.getSomthing("123",111);
       targetProxy.write("111",12);
       targetProxy.write("1111");
    }
}
