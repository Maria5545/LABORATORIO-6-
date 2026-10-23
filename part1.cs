using System;

//
public static class Parte1
{
    public static void Executar()
    {
        Console.WriteLine("== Parte 1 ==");
        Pilha p = new Pilha(5);
        p.empilha(1); p.empilha(3); p.empilha(5); p.empilha(7);
        p.mostra();                               
        Console.WriteLine(p.desempilha());        
        Console.WriteLine(p.consultaTopo());      
        p.empilha(8); p.empilha(9);
        p.mostra();                               
        Console.WriteLine(p.cheia());            
        try { p.empilha(2); }
        catch (Exception e) { Console.WriteLine(e.Message); } 

        Console.WriteLine("== Parte 2 (conferência) ==");
        Pilha q = new Pilha(4);
        q.empilha(10); q.empilha(20); q.desempilha();
        q.empilha(30); q.empilha(40); q.desempilha(); q.desempilha();
        q.empilha(50);
        q.mostra();                               
        Console.WriteLine(q.tamanho());           
    }
}