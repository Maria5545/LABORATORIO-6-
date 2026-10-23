using System;

// Desafio
public static class Desafio
{
    public static Pilha ordenaPilha(Pilha p)
    {
        Pilha aux = new Pilha(p.tamanho());
        while (!p.vazia())
        {
            int t = p.desempilha();
            while (!aux.vazia() && aux.consultaTopo() > t)
                p.empilha(aux.desempilha());
            aux.empilha(t);
        }
        return aux; 
    }

    public static void Executar()
    {
        Console.WriteLine("== Desafio ==");
        Pilha d = new Pilha(6);
        foreach (int x in new int[] { 4, 9, 1, 7, 3, 8 }) d.empilha(x);
        ordenaPilha(d).mostra();                  
    }
}