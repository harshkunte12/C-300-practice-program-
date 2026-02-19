using System arrays;
class Program {
    static void Main() {
        int[] arr = {5,2,8,1};
        Array.Sort(arr);
        Console.WriteLine("Sorted 1D: " + string.Join(",",arr));

        int[,] mat = {{1,2},{3,4}};
        Console.WriteLine("2D Array:");
        for(int i=0;i<2;i++){
            for(int j=0;j<2;j++)
                Console.Write(mat[i,j]+" ");
            Console.WriteLine();
        }

        int search=8;
        int idx=Array.IndexOf(arr,search);
        Console.WriteLine(idx>=0 ? "Found at "+idx : "Not Found");
    }
}