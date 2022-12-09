using System;

class Program {
    static void Main(string[] args) {
      int n1;
        Console.WriteLine("escreva um número");
          n1 = int.Parse(Console.ReadLine());
      Console.Clear();
      Calculo(n1);
    }
  static void Calculo(int num){
    int i;
    for(i = 0; i <= 10; i++){
      int resultado = num * i;
      Console.WriteLine("{0} x {1} = {2}", num, i, resultado);
    }
  }
}