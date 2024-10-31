import java.util.*;

public class V2 {
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
        LinkedList<Integer> result = new LinkedList<>();
        for (int num : array2) {
            if (set1.contains(num)) {
                result.add(num);
            }
        }

        // LinkedList operations
        result.addFirst(0);  // Add to beginning
        result.addLast(10);   // Add to end
        result.removeFirst(); // Remove first element
        result.removeLast();  // Remove last element

        System.out.println("LinkedList in reverse order: ");
        ListIterator<Integer> it = result.listIterator(result.size());
        while (it.hasPrevious()) {
            System.out.println(it.previous());
        }

        try {
            // ArithmeticException
            int a = 10, b = 0;
            System.out.println(a / b); // Division by zero
        } catch (ArithmeticException e) {
            System.out.println("Error: Division by zero is not allowed.");
        }
    }
}
