string[,] mas = new string[9, 4];
int k = -1;
while (true)
{
    Console.WriteLine("Что необходимо сделать?");
    Console.WriteLine("[1] Добавить задачу");
    Console.WriteLine("[2] Удалить задачу");
    Console.WriteLine("[3] Перезаписать задачу");
    Console.WriteLine("[4] Вывести список");
    Console.WriteLine("[5] Поиск задачи");
    int i = int.Parse(Console.ReadLine()!);

    switch (i)
    {
        case 1:
            {
                k++; if (k < 9)
                {
                    Console.Write("Введите название:");
                    mas[k, 0] = Console.ReadLine()!;

                    Console.Write("Введите дату:");
                    mas[k, 1] = Console.ReadLine()!;

                    Console.Write("Введите время:");
                    mas[k, 2] = Console.ReadLine()!;

                    Console.Write("Введите приоритет:");
                    mas[k, 3] = Console.ReadLine()!;
                }
                else
                {
                    Console.WriteLine("Нет свободных мест");
                }
            }
            break;
        case 2:
            {
                Console.Write("Введите номер задачи:");
                int n = int.Parse(Console.ReadLine()!);
                mas[n - 1, 0] = null!;
                mas[n - 1, 1] = null!;
                mas[n - 1, 2] = null!;
                mas[n - 1, 3] = null!;
            }
            break;
        case 3:
            {
                Console.Write("Введите номер задачи:");
                int n = int.Parse(Console.ReadLine()!);

                Console.Write("Введите название:"); string ev = Console.ReadLine()!;
                if (ev.Length != 0) mas[n - 1, 0] = ev;

                Console.Write("Введите дату:"); string data = Console.ReadLine()!;
                if (data.Length != 0) mas[n - 1, 1] = data;

                Console.Write("Введите время:"); string time = Console.ReadLine()!;
                if (time.Length != 0) mas[n - 1, 2] = time;

                Console.Write("Введите приоритет:"); string pr = Console.ReadLine()!;
                if (pr.Length != 0) mas[n - 1, 3] = pr;
            }
            break;
        case 4:
            {
                for (int j = 0; j < mas.GetUpperBound(0) + 1; j++)
                {
                    bool isTrue = false; for (int l = 0; l < mas.GetUpperBound(1) + 1; l++)
                    {
                        if (mas[j, l] != null)
                        {
                            Console.Write(mas[j, l] + " ");
                            isTrue = true;
                        }
                    }
                    if (isTrue) Console.WriteLine();
                }
            }
            break;

        case 5:
            {
                Console.Write("Введите название задачи: ");
                string my_task = Console.ReadLine()!;

                if (my_task == mas[k, 0]) Console.Write(mas.indexOf(k));

                else Console.WriteLine("Такой задачи нет");

            }
            break;
    }
}
