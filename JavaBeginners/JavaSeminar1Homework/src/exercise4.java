
/* 4) (дополнительное задание) Задано уравнение вида q + w = e, q, w, e >= 0.
Некоторые цифры могут быть заменены знаком вопроса, например, 2? + ?5 = 69.
 Требуется восстановить
выражение до верного равенства. Предложить хотя бы одно решение или сообщить, что его нет.
*/
import java.util.Scanner;
import java.util.Arrays;

public class exercise4 {
    public static void main(String[] args) {
        System.out.println("Please, enter your equation: ");
        Scanner scanner = new Scanner(System.in);
        String equation = scanner.nextLine();

        String[] temp = equation.split(" ");
        int num1;
        int num2;
        int num3;
        int count = 0;
        String[] result = new String[1000];
        int index = 0;
        if (temp[0].contains("?")) {
            num1 = 0;
        } else {
            num1 = Integer.parseInt(temp[0]);
        }

        if (temp[2].contains("?")) {
            num2 = 0;
        } else {
            num2 = Integer.parseInt(temp[2]);
        }
        if (temp[4].contains("?")) {
            num3 = 0;
        } else {
            num3 = Integer.parseInt(temp[4]);
        }

        for (int i = 0; i < 10; i++) {
            String str1 = String.format("%d", i);
            String replFirst = temp[0].replace('?', str1.charAt(0));
            num1 = Integer.valueOf(replFirst);

            for (int j = 0; j < 10; j++) {
                String str2 = String.format("%d", j);
                String replSecond = temp[2].replace('?', str2.charAt(0));
                num2 = Integer.valueOf(replSecond);

                for (int k = 0; k < 10; k++) {

                    String str3 = String.format("%d", k);
                    String replThird = temp[4].replace('?', str3.charAt(0));

                    num3 = Integer.parseInt(replThird);
                    if (num1 + num2 == num3) {
                        String answer =  String.format("%d + %d = %d", num1, num2, num3);
                        int indexRes = java.util.Arrays.asList(result).indexOf(answer);
                        if(indexRes==-1) {
                            result[index] = answer;
                            index += 1;
//                            System.out.printf("%d + %d = %d\n", num1, num2, num3);
                            count += 1;
                        }
                    }

                }
            }

        }
        if(count==0) {
            System.out.println("There isn't decision of your equation");
        } else {
            for (int i = 0; i < result.length ; i++) {
                if(result[i]!=null) System.out.println(result[i]);
            }

        }
    }
}
