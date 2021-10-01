package factory;

public abstract class AccountOperator implements IAccountOperator{
    @Override
    public void Operate() {
        System.out.println("开始执行");
        var command=CreateCommand();
        command.Excute();
        System.out.println("执行完毕");
    }

    protected  abstract  ICommond CreateCommand();
}

