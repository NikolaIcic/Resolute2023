int[] niz = new int[] { 1, 4, 15, 9, 12, 5, 2 };

void Fun1(int[] n)
{
    foreach (int i in n)
        Console.WriteLine(i);
}

int Fun2(int[] n)
{
    int max = 0;
    foreach (int i in n)
    {
        if (i > max)
            max = i;
    }
    return max;
}

int[] Fun3(int[] n, int x)
{
    for (int i = 0; i < n.Length; i++)
    {
        n[i] = n[i] + x;
    }
    return n;
}

int[] Fun32(int[] n, int a, int b)
{
    for (int i = 0; i < n.Length; i++)
    {
        if (i % 2 == 0)
            n[i] = n[i] + a;
        else
            n[i] = n[i] + b;
    }
    return n;
}

int[] res = Fun32(niz,2,0);

Fun1(res);

string[] str = new string[] { "Nikola", "icic", "123", "icic" };

bool Dom6(string[] niz)
{
    for(int i=0;i<niz.Length;i++)
    {
        for(int j=i+1;j<niz.Length;j++)
        {
            if (niz[j] == niz[i])
                return true;
        }
    }
    return false;
}

Console.ReadKey();

