package samplefactory;

public class CarFactory {
    public static ICare createCar(String carType) throws Exception {
        switch (carType)
        {
            case "BenTian":
                return new BenTian();
            case "ChangAn":
                return new  ChangAn();
            case "Benci":
                return new Benci();
            default:
                throw new Exception("没有实现的类型"+carType);
        }
    }
    public static  ICare createCare(CarType carType) throws Exception {
        switch (carType)
        {
            case Benci:
                return new Benci();
            case ChangAn:
                return new ChangAn();
            case BenTian:
                return new BenTian();
            default:
                throw new Exception("没有实现的类型"+carType.toString());

        }
    }
}

