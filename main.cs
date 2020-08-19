using System;

public class Program{

 static int Conta(int n1, int n2) {

  int Total = n1 + n2;
   return Total; 
 }


    public static void Main () {
      int n1,n2,Total;
 
    Console.Write("Digite o número 1>> ");
      n1 = int.Parse(Console.ReadLine());
    Console.Write("Digite 0 número 2>> ");
      n2 = int.Parse(Console.ReadLine());

       Total = Conta(n1, n2);

    Console.WriteLine($"A soma é {Total}");
  }
}