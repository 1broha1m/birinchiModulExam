class Program
{
    static void Main()
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~1-Savol~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        List<int> list = new List<int>();
        Console.Write("Nechta son kiritasiz: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}-sonni kiriting: ");
            int son = int.Parse(Console.ReadLine());
            list.Add(son);
        }
        Tekshir(list);


        Console.WriteLine();


        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~2-Savol~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine();

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~3-Savol~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine(ThreeText("Salom"));
        Console.WriteLine(ThreeText("Salomlarrrrrr"));
        Console.WriteLine(ThreeText("Davay"));


        Console.WriteLine();


        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~4-Savol~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine(Three("Salom"));
        Console.WriteLine(Three("PDP Salom"));
        Console.WriteLine(Three("Pdp Salom"));

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~5-Savol~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~6-Savol~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        List<int> list6 = new List<int>();
        Console.Write("Nechta son kiritasiz: ");
        int x = int.Parse(Console.ReadLine());
        for (int i = 0; i < x; i++)
        {
            Console.Write($"{i + 1}-sonni kiriting: ");
            int son6 = int.Parse(Console.ReadLine());
            list6.Add(son6);
        }
        SixQuestion(list6);


    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~1-Savol~~~~~~~~~~~~~~~~~~
    static void Tekshir(List<int> sonlar)
    {
        var Count = 0;
        foreach (int x in sonlar)
        {
            if (x % 2 == 0)
            {
                Count++;
            }
        }
        Console.WriteLine($"Jami juft sonlar {Count} ta");
    }

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~2-Savol~~~~~~~~~~~~~~~~~~

    static bool SecondQuestion(List<string> text2)
    {
        foreach (string s in text2)
        {
            if (s.Length <= 5)
            {
                return false;
            }
        }
        return true;
    }


    //~~~~~~~~~~~~~~~~~~~~~~~~~~~3-Savol~~~~~~~~~~~~~~~~~~
    static string ThreeText(string text3)
    {
        var res = text3.Substring(0, 3);
        return res;
    }


    //~~~~~~~~~~~~~~~~~~~~~~~~~~~4-Savol~~~~~~~~~~~~~~~~~~
    static bool Three(string text)
    {

        if (text[0] == 'P' && text[1] == 'D' && text[2] == 'P')
        {
            return true;
        }

        return false;
    }
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~5-Savol~~~~~~~~~~~~~~~~~~


    //~~~~~~~~~~~~~~~~~~~~~~~~~~~6-Savol~~~~~~~~~~~~~~~~~~
    static void SixQuestion(List<int> nums)
    {
        var total = nums[0] + nums[1];
        Console.WriteLine($"Listning 1 va 2 elementlar yigindisi : {total} ga teng");
    }
}
