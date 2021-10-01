public class PersonBuilder {

    private final String _name;
    private final Integer _age;
    private String _address;

    public PersonBuilder(Integer age, String name) {
        _age = age;
        _name = name;
    }

    public Person Build() {
        var person = new Person();
        person.setName(_name);
        person.setAge(_age);
        person.setAddress(_address);
        return person;
    }

    public PersonBuilder setAddress(String address) {
        _address = address;
        return this;
    }
}
