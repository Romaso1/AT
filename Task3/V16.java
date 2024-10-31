import java.util.*;

public class V16 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Array Reverse
        System.out.print("Enter the size of the array: ");
        int size = scanner.nextInt();
        int[] array = new int[size];
        System.out.println("Enter the elements of the array:");
        for (int i = 0; i < size; i++) {
            array[i] = scanner.nextInt();
        }

        // Reverse the array
        for (int i = 0; i < size / 2; i++) {
            int temp = array[i];
            array[i] = array[size - 1 - i];
            array[size - 1 - i] = temp;
        }
        System.out.println("Reversed array: " + Arrays.toString(array));

        // ArrayList operations
        ArrayList<Integer> list = new ArrayList<>();
        for (int num : array) {
            list.add(num);
        }
        list.add(15);   // Add element
        list.remove(0);  // Remove element
        list.set(2, 25);  // Replace element
        Collections.sort(list);  // Sort list
        System.out.println("Sorted ArrayList: " + list);

        try {
            // ArithmeticException
            int a = 100, b = 0;
            System.out.println(a / b);  // Division by zero
        } catch (ArithmeticException e) {
            System.out.println("Error: Division by zero.");
        }
    }
}
