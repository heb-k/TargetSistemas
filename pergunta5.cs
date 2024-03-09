using System;

class Program {
  public static void Main (string[] args) {

	  string ori = "Bom dia mundo!";
    string inv = "";

    for(int i= ori.Length-1; i >= 0; i--){
        inv += ori[i];
    }

    Console.WriteLine("String original:" + ori);
    Console.WriteLine("String invertida:" + inv);
  }
}
