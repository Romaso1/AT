import java.util.*;

public class V6 {
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
        HashSet<Double> resultSet = new HashSet<>();
        for (int num : array2) {
            if (set1.contains(num)) {
                resultSet.add((double) num);
            }
        }

        // HashSet operations
        resultSet.add(5.5);  // Add element
        resultSet.remove(2.0);  // Remove element
        System.out.println("HashSet: " + resultSet);

        try {
            // NumberFormatException
            String invalidNumber = "invalid";
            double num = Double.parseDouble(invalidNumber);  // Invalid format
        } catch (NumberFormatException e) {
            System.out.println("Error: Invalid number format.");
        }
    }
}
