int n, k, pos, newpos;
List<int> mouse = new List<int>();
List<int> whiteMouse = new List<int>();

Console.WriteLine("Количество мышей");
n = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Позиция белой мыши");
pos = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Какую по счету мышь съедать?");
k = Convert.ToInt32(Console.ReadLine()) - 1;

for (int i = 0; i < n; i++)
{

    for (int j = 0; j <= n; i++)
    {
        if (i == pos)
        {
            whiteMouse.Add(1);
        }
        else
        {
            whiteMouse.Add(0);
        }
    }

    newpos = i + k;
    if (newpos >= whiteMouse.Count)
    {
        while (newpos >= whiteMouse.Count)
        {
            newpos -= whiteMouse.Count;
        }
    }
    whiteMouse.RemoveAt(newpos);

    while (whiteMouse.Count > 1)
    {
        newpos += (k + 1 - (mouse.Count - whiteMouse.Count));

        if (newpos >= whiteMouse.Count)
        {
            while (newpos >= whiteMouse.Count)
            {
                newpos -= whiteMouse.Count;
            }
        }

        whiteMouse.RemoveAt(newpos);
    }

    if (whiteMouse[0] == 1)
    {
        Console.WriteLine(i);
        break;
    }
}