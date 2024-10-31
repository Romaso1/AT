import java.util.*;

public class V14 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Array Sum
        System.out.print("Enter the size of the array: ");
        int size = scanner.nextInt();
        int[] array = new int[size];
        System.out.println("Enter the elements of the array:");
        for (int i = 0; i < size; i++) {
            array[i] = scanner.nextInt();
        }

        int sum = 0;
        for (int num : array) {
            sum += num;
        }
        System.out.println("Sum of the array: " + sum);

        // LinkedList operations
        LinkedList<Integer> list = new LinkedList<>();
        for (int num : array) {
            list.add(num);
        }
        list.addFirst(50);   // Add to beginning
        list.addLast(60);    // Add to end
        list.removeFirst();  // Remove first element
        list.removeLast();   // Remove last element
        Collections.reverse(list);  // Reverse list
        System.out.println("Reversed LinkedList: " + list);

        try {
            // NumberFormatException
            String invalidNumber = "abc";
            int num = Integer.parseInt(invalidNumber);  // Invalid number format
        } catch (NumberFormatException e) {
            System.out.println("Error: Invalid number format.");
        }
    }
}
