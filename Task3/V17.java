import java.util.*;

public class V17 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Input for first array
        System.out.print("Enter the size of the first array: ");
        int size1 = scanner.nextInt();
        int[] array1 = new int[size1];
        System.out.println("Enter the elements of the first array:");
        for (int i = 0; i < size1; i++) {
            array1[i] = scanner.nextInt();
        }

        // Input for second array
        System.out.print("Enter the size of the second array: ");
        int size2 = scanner.nextInt();
        int[] array2 = new int[size2];
        System.out.println("Enter the elements of the second array:");
        for (int i = 0; i < size2; i++) {
            array2[i] = scanner.nextInt();
        }

        // Find intersection
        Set<Integer> set1 = new HashSet<>();
        for (int num : array1) {
            set1.add(num);
        }
        HashMap<Integer, Integer> resultMap = new HashMap<>();
        for (int num : array2) {
            if (set1.contains(num)) {
                resultMap.put(num, num * 2);  // Example key-value logic
            }
        }

        // HashMap operations
        resultMap.put(100, 200);  // Add key-value pair
        resultMap.remove(1);      // Remove key-value pair
        System.out.println("Check if key 2 exists: " + resultMap.containsKey(2));
        System.out.println("Value associated with key 3: " + resultMap.get(3));
        System.out.println("HashMap: " + resultMap);

        try {
            // NumberFormatException
            String invalidNumber = "abc";
            int num = Integer.parseInt(invalidNumber);  // Invalid number format
        } catch (NumberFormatException e) {
            System.out.println("Error: Invalid number format.");
        }
    }
}
