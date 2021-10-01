package face;

public class MyBank implements  IBank{

    @Override
    public void creatAccount() {
        var step1=new Step1();
        var step2=new Step2();
        step1.doIt();
        step2.doIt();
    }
}
