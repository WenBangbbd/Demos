package Core;

public class  Cpu extends Device{

    public Cpu(Mediator mediator) {
        super(mediator);
        mediator.set_cpu(this);
    }

    public MediaData cumulate(String data) {
        if (data == null)
            return null;
        var datas = data.split(";|:");
        if (datas.length != 4)
            return null;
        var media=new MediaData();
        media.setSund(datas[1]);
        media.setDisplay(datas[3]);
        return  media;
    }
}

