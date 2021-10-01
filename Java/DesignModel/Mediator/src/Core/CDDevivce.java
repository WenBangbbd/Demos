package Core;

public class CDDevivce extends Device{

    public CDDevivce(Mediator mediator) {
        super(mediator);
    }

    public void ReadData(){
        _mediator.readData(this);
    }

    public String getData() {
        return "sund:123;screen:234";
    }
}

