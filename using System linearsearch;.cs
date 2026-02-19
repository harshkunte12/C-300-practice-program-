using System linearsearch;
class Program {
    static void Main() {
        int[] arr = {10,20,30,40};
        int search = 30;
        bool found = false;

        // Search element in array
        for(int i=0; i<arr.Length; i++) {
            if(arr[i] == search) {
                Console.WriteLine("Found at index " + i);
                found = true;
                break;
            }
        }
        if(!found) Console.WriteLine("Not Found");
    }
}