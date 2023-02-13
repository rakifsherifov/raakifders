using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            byte opt = 0;
            do

            {

                Console.WriteLine("1. Qrup elave et");
                Console.WriteLine("2. Bütün qruplara bax");
                Console.WriteLine("3. Verilmiş point aralığındaki qruplara bax");
                Console.WriteLine("4. Verilmiş nömrəsi qrupa bax");
                Console.WriteLine("5. Verilmiş qruplar üzrə axtarış et");
                Console.WriteLine("0 . Menudan cıx");

                var option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        break;

                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (opt!=0);
        }
    }
}
