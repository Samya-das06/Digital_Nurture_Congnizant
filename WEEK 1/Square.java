//Singleton design

public class Square{
    private static Square instance;
    private int side;
    private Square(int side) {
        this.side = side;
    }
    public static Square getInstance(int side) {
        if (instance == null) {
            instance = new Square(side);
        }
        return instance;
    }
    public int getArea() {
        return side * side;
    }
    public int getSide() {
        return side;
    }
    public void setSide(int side) {
        this.side = side;
    }
    public static void main(String[] args) {
        Square square1 = Square.getInstance(5);
        System.out.println("Square1 side: " + square1.getSide());    
        System.out.println("Square1 area: " + square1.getArea());        
        Square square2 = Square.getInstance(10);
        System.out.println("Square2 side: " + square2.getSide());        
        System.out.println("Square2 area: " + square2.getArea());        
        System.out.println("square1 == square2? " + (square1 == square2)); 
    }
}