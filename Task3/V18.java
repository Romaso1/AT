import java.util.*;

public class V18 {
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

        // HashMap operations
        HashMap<Integer, Integer> map = new HashMap<>();
        for (int i = 0; i < array.length; i++) {
            map.put(i, array[i]);
        }

        map.put(10, 100);   // Add key-value pair
        map.remove(1);      // Remove key-value pair
        System.out.println("Check if key 2 exists: " + map.containsKey(2));
        System.out.println("Value associated with key 3: " + map.get(3));
        System.out.println("HashMap: " + map);

        try {
            // ArrayIndexOutOfBoundsException
            System.out.println(array[size]);  // Access out of bounds
        } catch (ArrayIndexOutOfBoundsException e) {
            System.out.println("Error: Accessing array element out of bounds.");
        }
    }
}
