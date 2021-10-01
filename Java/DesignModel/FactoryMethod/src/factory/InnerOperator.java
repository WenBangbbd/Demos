package factory;

public class InnerOperator extends  AccountOperator{

    @Override
    protected ICommond CreateCommand() {
        return new Transaction();
    }
}
