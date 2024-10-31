import java.util.*;

public class V1 {
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

        // HashSet operations
        HashSet<Double> set = new HashSet<>();
        for (int num : array) {
            set.add((double) num);
        }

        set.add(10.5);  // Add element
        set.remove(2.0); // Remove element
        if (set.contains(5.0)) {  // Check if element exists
            set.remove(5.0);
        }
        System.out.println("HashSet: " + set);

        try {
            // ArrayIndexOutOfBoundsException
            System.out.println(array[array.length]); // Trying to access out-of-bounds index
        } catch (ArrayIndexOutOfBoundsException e) {
            System.out.println("Error: Attempted to access invalid index.");
        }
    }
}
