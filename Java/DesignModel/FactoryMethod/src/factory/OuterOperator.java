package factory;

public class OuterOperator extends AccountOperator{

    private int _type;
    public OuterOperator(int type) {
        _type=type;
    }

    @Override
    protected ICommond CreateCommand() {
        if(_type==0)
        {
            return new Transaction();
        }
        else {
            return new Recharge();
        }
    }
}
