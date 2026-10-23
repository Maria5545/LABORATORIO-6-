using System;

// Parte 4
public static class Parte4
{
    public static int[] bubblePilhas(int[] v, out int comparacoes)
    {
        int n = v.Length;
        comparacoes = 0;
        Pilha A = new Pilha(n);
        Pilha B = new Pilha(n);
        Pilha R = new Pilha(n);

        for (int i = 0; i < n; i++) A.empilha(v[i]);

        for (int restantes = n; restantes >= 1; restantes--)
        {
            int carry = A.desempilha();
            for (int k = 0; k < restantes - 1; k++)
            {
                int x = A.desempilha();
                comparacoes++;
                if (carry > x)
                {
                    B.empilha(x);          
                }
                else
                {
                    B.empilha(carry);
                    carry = x;             
                }
            }
            R.empilha(carry);              

            Pilha tmp = A; A = B; B = tmp; 
        }

        int[] saida = new int[n];
        for (int i = 0; i < n; i++) saida[i] = R.desempilha();
        return saida;
    }

    static void imprime(int[] v)
    {
        Console.WriteLine("[" + string.Join(", ", v) + "]");
    }

    public static void Executar()
    {
        Console.WriteLine("== Parte 4 ==");
        int comp;
        imprime(bubblePilhas(new int[] { 5, 2, 9, 1, 7 }, out comp));
        Console.WriteLine("Comparações: " + comp);   
        imprime(bubblePilhas(new int[] { 1, 2, 3, 4, 5 }, out comp));
        Console.WriteLine("Comparações: " + comp);   
    }
}