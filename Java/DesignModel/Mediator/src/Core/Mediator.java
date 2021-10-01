package Core;

public class Mediator implements IMediator {

    private DisplayDevice _displayDevice;
    private SundDevice _sundDevice;
    private Cpu _cpu;

    public void set_displayDevice(DisplayDevice displayDevice) {
        this._displayDevice = displayDevice;
    }

    public void set_sundDevice(SundDevice _sundDevice) {
        this._sundDevice = _sundDevice;
    }

    public void set_cpu(Cpu _cpu) {
        this._cpu = _cpu;
    }


    @Override
    public void readData(CDDevivce cdDevivce) {
        var data = cdDevivce.getData();
        var media = _cpu.cumulate(data);
        _displayDevice.display(media.getDisplay());
        _sundDevice.sund(media.getSund());
    }
}
