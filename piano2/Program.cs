namespace piano2
{
    namespace piano
    {
        internal class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("выберите октаву\n F1 - первая октава \n F2 - вторая октава \n F3 - третья октава \n для смены октавы нажмите Escape один раз \n Для выхода из программы нажмите Escape два раза");
                ConsoleKeyInfo clavisha = Console.ReadKey();
                do
                {

                    if (clavisha.Key == ConsoleKey.F1)
                    {
                        oktava_1();
                    }
                    if (clavisha.Key == ConsoleKey.F2)
                    {
                        oktava_2();
                    }
                    if (clavisha.Key == ConsoleKey.F3)
                    {
                        oktava_3();
                    }
                    Console.WriteLine("Выберите октаву\n F1 - первая октава \n F2 - вторая октава \n F3 - третья октава \n Для выхода из программы нажмите Escape");
                    ConsoleKeyInfo clavisha_2 = Console.ReadKey();
                    clavisha = clavisha_2;

                } while (clavisha.Key != ConsoleKey.Escape);

                static void oktava_1() // по значениям это 4 октава
                {
                    int[] oktava = new int[] { 2000, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                    Console.WriteLine("Вы выбрали 1 октаву");
                    ConsoleKeyInfo clavisha_1 = Console.ReadKey();
                    do
                    {
                        if (clavisha_1.Key == ConsoleKey.A)
                        {
                            Console.Clear();
                            Console.Beep(100, 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.S)
                        {
                            Console.Clear();
                            Console.Beep(oktava[2], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.D)
                        {
                            Console.Clear();
                            Console.Beep(oktava[4], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.F)
                        {
                            Console.Clear();
                            Console.Beep(oktava[5], 200);
                        }
                        if
                        (clavisha_1.Key == ConsoleKey.G)
                        {
                            Console.Clear();
                            Console.Beep(oktava[7], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.H)
                        {
                            Console.Clear();
                            Console.Beep(oktava[9], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                            Console.Beep(oktava[11], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.Q)
                        {
                            Console.Clear();
                            Console.Beep(oktava[1], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.W)
                        {
                            Console.Clear();
                            Console.Beep(oktava[3], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.E)
                        {
                            Console.Clear();
                            Console.Beep(oktava[6], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.R)
                        {
                            Console.Clear();
                            Console.Beep(oktava[8], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.T)
                        {
                            Console.Clear();
                            Console.Beep(oktava[10], 200);
                        }
                        ConsoleKeyInfo clavisha_2 = Console.ReadKey();
                        clavisha_1 = clavisha_2;
                    } while (clavisha_1.Key != ConsoleKey.Escape);
                }
                //все черные клавиши
                static void oktava_2() // по значениям это 5 октава
                {
                    int[] oktava = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                    Console.WriteLine("вы выбрали 2 октаву");
                    ConsoleKeyInfo clavisha_1 = Console.ReadKey();
                    do
                    {
                        if (clavisha_1.Key == ConsoleKey.A)
                        {
                            Console.Clear();
                            Console.Beep(oktava[0], 300);
                        }
                        if (clavisha_1.Key == ConsoleKey.S)
                        {
                            Console.Clear();
                            Console.Beep(oktava[2], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.D)
                        {
                            Console.Clear();
                            Console.Beep(oktava[4], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.F)
                        {
                            Console.Clear();
                            Console.Beep(oktava[5], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.G)
                        {
                            Console.Clear();
                            Console.Beep(oktava[7], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.H)
                        {
                            Console.Clear();
                            Console.Beep(oktava[9], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                            Console.Beep(oktava[11], 200);
                        }
                        //все белые
                        if (clavisha_1.Key == ConsoleKey.Q)
                        {
                            Console.Clear();
                            Console.Beep(oktava[1], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.W)
                        {
                            Console.Clear();
                            Console.Beep(oktava[3], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.E)
                        {
                            Console.Clear();
                            Console.Beep(oktava[6], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.R)
                        {
                            Console.Clear();
                            Console.Beep(oktava[8], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.T)
                        {
                            Console.Clear();
                            Console.Beep(oktava[10], 200);
                        }
                        ConsoleKeyInfo clavisha_2 =
                        Console.ReadKey();
                        clavisha_1 = clavisha_2;
                        //все черные клавиши
                    } while (clavisha_1.Key != ConsoleKey.Escape);
                }
                static void oktava_3() // по значениям это 6 октава
                {
                    int[] oktava1 = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                    Console.WriteLine("вы выбрали 3 октаву");
                    ConsoleKeyInfo clavisha_1 = Console.ReadKey();
                    do
                    {
                        if (clavisha_1.Key == ConsoleKey.A)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[0], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.S)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[2], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.D)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[4], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.F)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[5], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.G)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[7], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.H)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[9], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.J)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[11], 200);
                        }
                        //все белые
                        if (clavisha_1.Key == ConsoleKey.Q)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[1], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.W)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[3], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.E)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[6], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.R)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[8], 200);
                        }
                        if (clavisha_1.Key == ConsoleKey.T)
                        {
                            Console.Clear();
                            Console.Beep(oktava1[10], 200);
                        }
                        ConsoleKeyInfo clavisha_2 = Console.ReadKey();
                        clavisha_1 = clavisha_2;
                        //все черные клавиши
                    } while (clavisha_1.Key != ConsoleKey.Escape);
                }
            }

        }
    }
}