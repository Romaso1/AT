import java.util.*;

public class V15 {
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

        // ArrayList operations
        ArrayList<Integer> list = new ArrayList<>();
        for (int num : rotatedArray) {
            list.add(num);
        }
        list.add(300);  // Add element
        list.remove(0);  // Remove element
        list.set(1, 400);  // Replace element
        Collections.sort(list);  // Sort list
        System.out.println("Sorted ArrayList: " + list);

        try {
            // NumberFormatException
            String invalidNumber = "xyz";
            int num = Integer.parseInt(invalidNumber);  // Invalid number format
        } catch (NumberFormatException e) {
            System.out.println("Error: Invalid number format.");
        }
    }
}
