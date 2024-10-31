import java.util.*;

public class V9 {
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
        LinkedList<Integer> resultList = new LinkedList<>();
        for (int num : array2) {
            if (set1.contains(num)) {
                resultList.add(num);
            }
        }

        // LinkedList operations
        resultList.addFirst(100);  // Add to beginning
        resultList.addLast(200);   // Add to end
        resultList.removeFirst();  // Remove first element
        resultList.removeLast();   // Remove last element
        Collections.reverse(resultList);  // Reverse list
        System.out.println("Reversed LinkedList: " + resultList);

        try {
            // ClassCastException
            Object obj = "This is a string";
            Integer num = (Integer) obj;  // Invalid casting
        } catch (ClassCastException e) {
            System.out.println("Error: Invalid type casting.");
        }
    }
}
