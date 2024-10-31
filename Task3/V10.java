import java.util.*;

public class V10 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Array Rotation
        System.out.print("Enter the size of the array: ");
        int size = scanner.nextInt();
        int[] array = new int[size];
        System.out.println("Enter the elements of the array:");
        for (int i = 0; i < size; i++) {
            array[i] = scanner.nextInt();
        }

        System.out.print("Enter the number of positions to rotate: ");
        int positions = scanner.nextInt();
        int[] rotatedArray = new int[size];
        for (int i = 0; i < size; i++) {
            rotatedArray[(i + positions) % size] = array[i];
        }
        System.out.println("Rotated array: " + Arrays.toString(rotatedArray));

        // LinkedList operations
        LinkedList<Integer> list = new LinkedList<>();
        for (int num : rotatedArray) {
            list.add(num);
        }
        list.addFirst(100);  // Add to beginning
        list.addLast(200);   // Add to end
        list.removeFirst();  // Remove first element
        list.removeLast();   // Remove last element
        Collections.reverse(list);  // Reverse list
        System.out.println("Reversed LinkedList: " + list);

        try {
            // NumberFormatException
            String invalidNumber = "invalid";
            int num = Integer.parseInt(invalidNumber);  // Invalid number format
        } catch (NumberFormatException e) {
            System.out.println("Error: Invalid number format.");
        }
    }
}
