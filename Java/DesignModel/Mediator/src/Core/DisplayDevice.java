package Core;

public class DisplayDevice extends  Device{

    public DisplayDevice(Mediator mediator) {
        super(mediator);
        mediator.set_displayDevice(this);
    }

    public void display(String display) {
        System.out.println("开始显示："+display);
    }
}


