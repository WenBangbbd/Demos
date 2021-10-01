public class  Target implements  ITarget{

    @Override
    public void doSomthing() {
        System.out.println("doSomthing");
    }

    @Override
    public void write(String str) {
        System.out.println("write:"+str);
    }

    @Override
    public void write(String str, Integer in) {
        System.out.println("write:"+str+in);
    }

    @Override
    public String getSomthing(String str, Integer in) {
        System.out.println("getSomthing:"+str+in);
        return str+in;
    }
}
