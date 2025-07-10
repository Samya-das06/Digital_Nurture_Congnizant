//Factory Pattern 

interface Shape {
    void draw();
}
class Circle implements Shape {
    public void draw() {
        System.out.println("Drawing a Circle");
    }
}
class Square implements Shape {
    public void draw() {
        System.out.println("Drawing a Square");
    }
}
class Rectangle implements Shape {
    public void draw() {
        System.out.println("Drawing a Rectangle");
    }
}
class ShapeFactory {
    public Shape createShape(String type) {
        if (type == null) {
            return null;
        }
        switch (type.toLowerCase()) {
            case "circle":
                return new Circle();
            case "square":
                return new Square();
            case "rectangle":
                return new Rectangle();
            default:
                throw new IllegalArgumentException("Unknown shape type: " + type);
        }
    }
}

public class factorypatten {
    public static void main(String[] args) {
        ShapeFactory factory = new ShapeFactory();

        Shape shape1 = factory.createShape("circle");
        shape1.draw();  

        Shape shape2 = factory.createShape("square");
        shape2.draw();  

        Shape shape3 = factory.createShape("rectangle");
        shape3.draw();  
    }
}