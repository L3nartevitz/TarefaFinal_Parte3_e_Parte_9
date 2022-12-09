using System;

class Program {
    static void Main(string[] args) {
      int i;
        Console.WriteLine("escreva sua idade");
          i = int.Parse(Console.ReadLine());
          idade(i);
    }
  static void idade(int idade){
    if(idade >=18){
      Console.WriteLine("você é maior de idade");
    }
  else{
    Console.WriteLine("você não é maior de idade");
    }
  }
}
