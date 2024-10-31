import java.util.*;

public class V12 {
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

        // TreeMap operations
        TreeMap<Integer, Integer> map = new TreeMap<>();
        for (int i = 0; i < array.length; i++) {
            map.put(i, array[i]);
        }

        map.put(10, 100);   // Add key-value pair
        map.remove(1);      // Remove key-value pair
        System.out.println("Check if key 2 exists: " + map.containsKey(2));
        System.out.println("Value associated with key 3: " + map.get(3));
        System.out.println("TreeMap: " + map);

        try {
            // NullPointerException
            String str = null;
            System.out.println(str.length());  // This will throw NullPointerException
        } catch (NullPointerException e) {
            System.out.println("Error: Null pointer exception.");
        }
    }
}
