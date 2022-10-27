using System;
/*Construa um algoritmo que, dada a idade de um nadador (ID), classifique-o em uma das seguintes categorias e apresente a categoria:
Idade (ID) Categoria
5 até 7 anos Infantil A
8 até 10 anos Infantil B
11 até 13 anos Juvenil A
14 até 17 anos Juvenil B
Acima de 18 anos Adulto*/
class Program {
  public static void Main (string[] args) {
    int ID ;
    Console.Write ("Digite a idade do nadador: ");
    ID=int.Parse(Console.ReadLine()); 

    if(ID>=5&&ID<=7) 
       Console.WriteLine("Categoria: Infantil A");
    
    if (ID>=8&&ID<=10) 
       Console.WriteLine("Categoria: Infantil B");
    
    if (ID>=11&&ID<=13) 
       Console.WriteLine("Categoria: Juvenil A");
    
    if (ID>=14&&ID<=17) 
       Console.WriteLine("Categoria: Juvenil B");
    
    if (ID>=18) 
       Console.WriteLine("Categoria: Adulto");
    
  }
}