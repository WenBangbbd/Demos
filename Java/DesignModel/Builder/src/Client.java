public class Client {

    public static void main(String[] args) {
        var builder = new PersonBuilder(1, "12");
        builder.setAddress("ss");
        var person = builder.Build();
    }

}
