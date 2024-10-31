import java.util.*;

public class V11 {
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

        // ArrayList operations
        ArrayList<Integer> list = new ArrayList<>();
        for (int num : array) {
            list.add(num);
        }
        list.add(10);  // Add element
        list.remove(0);  // Remove element
        list.set(1, 20);  // Replace element
        Collections.sort(list);  // Sort list
        System.out.println("Sorted ArrayList: " + list);

        try {
            // NullPointerException
            String str = null;
            System.out.println(str.length());  // This will throw NullPointerException
        } catch (NullPointerException e) {
            System.out.println("Error: Null pointer exception.");
        }
    }
}
