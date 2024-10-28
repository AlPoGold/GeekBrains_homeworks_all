// 1) Вычислить n-ое треугольного число (сумма чисел от 1 до n), n! (произведение чисел от 1 до n)

import java.util.Scanner;
public class exercise1 {
    public static void main(String[] args) {
        System.out.println("Please, enter your number: ");
        Scanner iScanner = new Scanner(System.in);
        int n = iScanner.nextInt();

        int numberSquare = (n +1)* n /2;
        int factorialResult = 1;
        for (int i = 1; i <= n ; i++) {
            factorialResult*=i;

        }

        System.out.println("Triangular number is " + numberSquare);


        System.out.println("The facorial of "+ n +" is " + factorialResult);



    }
}