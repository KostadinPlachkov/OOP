
public class Person {
    private String firstName;
    private String lastName;
    private Integer age;
    private double salary;


    public Person(String firstName, String lastName, Integer age, Double salary) {
        this.setFirstName(firstName);
        this.setLastName(lastName);
        this.setAge(age);
        this.setSalary(salary);
    }

    public Double getSalary() {
        return salary;
    }

    private void setSalary(double salary) {
        if (salary < 460) {
            throw new IllegalArgumentException
                    ("Salary cannot be less than 460 lv");
        }
        this.salary = salary;
    }

    public String getFirstName() {
        return firstName;
    }

    private void setFirstName(String firstName) {
        if (firstName.length() < 3) {
            throw new IllegalArgumentException("First name cannot be less than 3 characters");
        }
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    private void setLastName(String lastName) {
        if (lastName.length() < 3) {
            throw new IllegalArgumentException("Last name cannot be less than 3 characters");
        }
        this.lastName = lastName;
    }

    public Integer getAge() {
        return age;
    }

    private void setAge(Integer age) {
        if (age < 1) {
            throw new IllegalArgumentException("Age cannot be less than 1");
        }
        this.age = age;
    }

    @Override
    public String toString() {
        return String.format("%s %s is %d years old, with salary: %.2f",this.getFirstName(), this.getLastName(), this.getAge(), this.getSalary());
    }

    public void increaseSalary(Double amount) {
        if (this.getAge() < 30) {
            this.salary += this.salary * amount / 200;
        }
        else {
            this.salary += this.salary * amount / 100;
        }
    }

}
