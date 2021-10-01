import factory.InnerOperator;
import factory.OuterOperator;

public class Client {
    public static void main(String[] args) {
        var operator1=new InnerOperator();
        var operator2=new OuterOperator(0);
        var operator3=new OuterOperator(1);
        operator1.Operate();
        operator2.Operate();
        operator3.Operate();

    }
}
