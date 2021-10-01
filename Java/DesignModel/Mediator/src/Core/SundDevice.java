package Core;

public class SundDevice extends  Device{

    public SundDevice(Mediator mediator) {
        super(mediator);
        mediator.set_sundDevice(this);
    }

    public void sund(String sund) {
        System.out.println("开始声音播放:"+sund);
    }
}
