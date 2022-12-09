using System;

class Program {
    static void Main(string[] args) {
      int A, B;
        Console.WriteLine("Indique o valor de A");
          A = int.Parse(Console.ReadLine());
        Console.WriteLine("Indique o valor de B");
          B = int.Parse(Console.ReadLine()); 
      int n1= A;
        n1= B;
        Vice(B,A);
    }
  static void Vice(int num1, int num2){
    Console.WriteLine("\nnumeros invertidos:\n");
    Console.WriteLine("o número de A = {0}\n0 número de B = {1}", num1, num2);
  }
}