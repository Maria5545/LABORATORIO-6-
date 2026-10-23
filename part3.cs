using System;

// Parte 3
public static class Parte3
{
    public static string inverte(string s)
    {
        Pilha p = new Pilha(s.Length);
        foreach (char c in s) p.empilha(c);

        char[] r = new char[s.Length];
        int i = 0;
        while (!p.vazia()) r[i++] = (char)p.desempilha();
        return new string(r);
    }

    public static bool balanceado(string expr)
    {
        Pilha p = new Pilha(expr.Length);
        foreach (char c in expr)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                p.empilha(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (p.vazia()) return false; 
                char abre = (char)p.desempilha();
                if ((c == ')' && abre != '(') ||
                    (c == ']' && abre != '[') ||
                    (c == '}' && abre != '{'))
                    return false;
            }
        }
        return p.vazia(); 
    }

    public static void Executar()
    {
        Console.WriteLine("== Parte 3 ==");
        Console.WriteLine(inverte("PUCMINAS")); 
        string[] testes = { "(a+b)*[c-d]", "{[()]}", "((a)", "a+b)", "([)]" };
        foreach (string t in testes)
            Console.WriteLine(t + " -> " + balanceado(t).ToString().ToLower());
    }
}