import samplefactory.CarFactory;
import samplefactory.CarType;

public class Client {
    public static void main(String[] args) throws Exception {
        System.out.println("hello");
        var car = CarFactory.createCar("Benci");
        car.Run();
        var car2 = CarFactory.createCare(CarType.BenTian);
        car2.Run();
    }
}
