int[] Spisok = new int[10];
for (int i = 0; i < Spisok.Length; i++)
{
    Spisok[i] = 0;
}

while (true)
{
    Console.WriteLine();
    Console.WriteLine("0 - выйти");
    Console.WriteLine("1 - добавить значение в список уникальных элементов");
    Console.WriteLine("2 - удалить значение из списка");
    Console.WriteLine("3 - распечатать список");
    int s = Convert.ToInt32(Console.ReadLine());
    if (s == 0)
    { 
        break; 
    }
    int x = 1;
    int y = 0;
    switch (s)
    {
        case 1:
            {
                Console.WriteLine("Введите значение, которое хотите добавить");
                for (int i = 0; i < Spisok.Length ; i++)
                {
                    if (Spisok[i] == 0)
                    {
                        Spisok[i] = Convert.ToInt32(Console.ReadLine());
                        y += 1;
                        break;
                    }
                    if (y == 0)
                    {
                        Console.WriteLine("Список заполнен");
                        break;
                    }
                }
                break;
            }
        case 2:
            {
                Console.WriteLine("Введите значение, которое хотите удалить");
                x = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Spisok.Length; i++)
                {
                    if (Spisok[i] == x)
                    {
                        Spisok[i] = 0;
                        y += 1;
                    }
                }
                if (y == 0)
                {
                    Console.WriteLine("в списке нет данного значения");
                }
                break;
            }
        case 3:
            {
                Console.WriteLine();
                foreach (int i in Spisok)
                {
                    Console.Write(i);
                }
                break;
            }
    }
}
