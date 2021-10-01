package Core;

public abstract   class Device {
    protected Mediator _mediator;

    public Device(Mediator mediator) {
        _mediator = mediator;
    }
}


