using System;

class Program {
    static void Main(string[] args) 
    {
      string opcao = "0";
      const int vagas = 20;
      Auto[] vaga = new Auto[vagas];
      int total = 0;
      int erase;
      do
      {
        opcao = Menu();
        if(opcao == "1")
        {
          Console.Clear();
          autoEntrada(vaga,total);
          total++;;
        }
        else if (opcao == "2")
        {
          Console.Clear();
          autoConsulta(vaga,total);
        }
        else if (opcao == "3")
        {
          Console.Clear();
          autoConsulta(vaga,total);
          Console.WriteLine("digite a vaga em que o registro se encontra para registrar a SAÍDA");
          erase = int.Parse(Console.ReadLine());
          autoSaida(vaga,erase,total);
          total++;
        }
      } while (opcao != "0");

    }
  
public struct Auto
{
      public string modelo;
      public string ano;
      public string cor;
      public string placa;
}
      static void autoEntrada(Auto[] at, int total)
      {
        Console.WriteLine("Registrando entrada: ");
        Console.Write("Informe o modelo do veículo: ");
          at[total].modelo = Console.ReadLine();
        Console.Write("Informe o ano do veículo: ");
          at[total].ano = Console.ReadLine();
        Console.Write("Informe a cor do veículo: ");
          at[total].cor = Console.ReadLine();
        Console.Write("Informe a cor do veículo: ");
          at[total].placa = Console.ReadLine();
      }
      static void autoConsulta(Auto[] at, int total)
      {
        int x;
        Console.WriteLine("Automoveis Cadastrados: ");
          Console.WriteLine("Vaga \t\tModelo \tAno\t\tCor\t\tPlaca");
        for(x = 0; x < total; x++){          Console.WriteLine("0{0}\t\t\t\b{1}\t\t\t\b{2}\t\t\b{3}\t\t\b[4}"; x + 1; at[x].modelo; at[x].ano; at[x].cor; at[x].placa)
        }
      }
                      
    static void autoSaida(Auto[] at, int erase, int total){
      int x;
      for(x = erase - 1; x < total; x++)
      {
        at[x] = at[x + 1];
      }
      Console.WriteLine("Saída do veículo autorizada.");
}
    static string Menu(){
      string opcao;
      Console.WriteLine("Menu do Sistema:\n1 - REGISTRAR ENTRADA\n2 - CONSULTAR VEÍCULO\n3 - SAÍDA\n0 - SAIR");
      opcao = Console.ReadLine();
      return opcao;
    }
  }