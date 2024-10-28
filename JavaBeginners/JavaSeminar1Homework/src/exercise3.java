//3) Реализовать простой калькулятор
import java.util.Scanner;
public class exercise3 {
    public static void main(String[] args) {
        boolean flag = true;
        do {

            Scanner iScanner = new Scanner(System.in);
            System.out.println("Please, enter first number: ");
            float a = iScanner.nextFloat();

            System.out.println("Please, enter second number: ");
            float b = iScanner.nextFloat();

            System.out.println("Please, enter needed operation(+, -, *, /): ");
            String op = iScanner.next();

            switch (op) {
                case "+":
                    flag = false;
                    System.out.println(a + b);
                    break;
                case "-":
                    flag = false;
                    System.out.println(a - b);
                    break;
                case "/":
                    flag = false;
                    System.out.printf("%.2f", a / b);
                    break;
                case "*":
                    flag = false;
                    System.out.println(a * b);
                    break;
                default:
                    System.out.println("No such operation! Try again!");
                    break;
            }
        } while (flag);
    }

}
