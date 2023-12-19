int[] niz = new int[] { 1, 4, 15, 9, 12, 5, 2,8, 15, 20 };

//Ovde dodajem svoj komentar.

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

int Fun21(int[] n)
{
    int min = n[0];
    foreach (int i in n)
    {
        if (i < min)
            min = i;
    }
    return min;
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

void Funkcija()
{

}

Console.ReadKey();