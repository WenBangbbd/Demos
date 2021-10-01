import java.lang.reflect.InvocationHandler;
import java.lang.reflect.Method;
import java.lang.reflect.Proxy;

public class DynamicProxy implements InvocationHandler {

    private ITarget _target = null;

    public ITarget getProxy(Target target) {
        _target = target;
        var proxy = (ITarget) Proxy.newProxyInstance(target.getClass().getClassLoader(), target.getClass().getInterfaces(), this);
        return proxy;
    }

    @Override
    public Object invoke(Object proxy, Method method, Object[] args) throws Throwable {
        System.out.println("in invoke.............");

        System.out.println("method:" + method);
        if (args != null) {
            for (var arg : args) {
                System.out.println(arg);
            }
        }
        method.invoke(_target,args);
        System.out.println("out invoke.............");
        return null;
    }
}
