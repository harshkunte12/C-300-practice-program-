using System transposematrix;
class Program {
    static void Main() {
        int[,] A = {{1,2,3},{4,5,6}};
        int[,] T = new int[3,2];

        for(int i=0;i<2;i++) {
            for(int j=0;j<3;j++) {
                T[j,i] = A[i,j];
            }
        }

        Console.WriteLine("Transpose of Matrix:");
        for(int i=0;i<3;i++) {
            for(int j=0;j<2;j++) {
                Console.Write(T[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}