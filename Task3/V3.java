import java.util.*;

public class V3 {
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
        ArrayList<Integer> result = new ArrayList<>();
        for (int num : array2) {
            if (set1.contains(num)) {
                result.add(num);
            }
        }

        // ArrayList operations
        result.add(100);  // Add to end
        result.remove(0); // Remove element
        result.set(0, 50);  // Replace element
        Collections.sort(result);  // Sort in alphabetical order

        System.out.println("ArrayList: " + result);

        try {
            // ClassCastException
            Object x = new String("Hello");
            Integer y = (Integer) x;  // Trying to cast String to Integer
        } catch (ClassCastException e) {
            System.out.println("Error: Attempted an invalid type cast.");
        }
    }
}
