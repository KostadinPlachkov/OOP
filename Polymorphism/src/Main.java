import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        Square square = new Square(5.0);
        Rectangle rectangle = new Rectangle(5.0, 2.0);
        Circle circle = new Circle(5.0);

        List<Shape> shapes = new ArrayList<>();
        shapes.add(square);
        shapes.add(rectangle);
        shapes.add(circle);

        Double totalArea = 0.0;
        Double totalPerimeter = 0.0;
        for (Shape shape: shapes) {
            totalArea += shape.area();
            totalPerimeter += shape.perimeter();
            System.out.format("%s area %f\n", shape, shape.area());
            System.out.format("%s perimeter %f\n", shape, shape.perimeter());
        }

        System.out.println("Total area: " + totalArea);
        System.out.println("Total perimeter: " + totalPerimeter);
    }
}
