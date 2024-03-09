/*OBS: PROGRAMA LIMITADO A RECONHECER SOMENTE OS PRIMEIROS 23 TERMOS DA SEQUENCIA, PARA NÃO FICAR MUITO PESADO.*/
using System;

class Program {
  public static void Main (string[] args) {

	int n = 0;
	Console.WriteLine("DIGITE UM NUMERO INTEIRO:");
	n=int.Parse(Console.ReadLine());
	int n1 = 5*n*n+4, n2 = 5*n*n-4;
	double a = Math.Truncate(Math.Sqrt(n1)), b =Math.Truncate(Math.Sqrt(n2));
		
	if(a*a==n1 || b*b==n2){
		Console.WriteLine("faz parte do fibonacci");
	}
	else{
		  Console.WriteLine("n faz parte do fibonacci");
	}
  }
}
