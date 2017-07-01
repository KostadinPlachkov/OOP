
public class Circle extends Shape {

    private Double radius;

    public Double getRadius() {
        return radius;
    }

    public void setRadius(Double radius) {
        this.radius = radius;
    }

    public Circle(Double radius) {
        this.radius = radius;
    }

    @Override
    public Double perimeter() {
        return 2 * Math.PI * getRadius();
    }

    @Override
    public Double area() {
        return Math.PI * Math.pow(getRadius(), 2);
    }

    @Override
    public String toString() {
        return "Circle";
    }
}
