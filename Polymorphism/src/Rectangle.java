
public class Rectangle extends Shape{
    private Double height;
    private Double width;

    public Rectangle(Double height, Double width) {
        this.height = height;
        this.width = width;
    }


    @Override
    public Double perimeter() {
        return (this.height + this.width) * 2;
    }

    @Override
    public Double area() {
        return this.width * this.height;
    }

    @Override
    public String toString() {
        return "Rectangle";
    }
}

