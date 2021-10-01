import Core.*;

public class Client {
    public static void main(String[] args) {
        var me=new Mediator();
        var cpu=new Cpu(me);
        var display=new DisplayDevice(me);
        var cd=new CDDevivce(me);
        var sund=new SundDevice(me);

        cd.ReadData();
    }
}
