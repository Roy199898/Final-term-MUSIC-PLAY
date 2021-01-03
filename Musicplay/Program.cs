using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****MUSIC PLAY SOFTWARE****");
            Phone a1 = new Phone("Let Me down Slowly", "Alec Benjamin", 2018, 177);
            a1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("****Change the  title****");
            a1.changeTitle("Let Me down Slowly");
            a1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("***SWITCH ON CALL****");
            a1.switchs(true);
            Console.WriteLine();

            Console.WriteLine("&&&MUSIC PLAY ON CALL&&&");
            a1.play(true);
            Console.WriteLine();
            Console.WriteLine("*** SET VOULME WITH LOUDNESS 5***");
            a1.setVolume(5);
            Phone a2 = new Phone("Halsey", "Halsey", 2018, 240);
            Phone a3 = new Phone("Jontrona ", "Mohon Sharif ", 2019, 289);
            Phone a4 = new Phone("Ami Amar Moto", "Pritom Hasan ", 2018, 220);
            Phone a5 = new Phone("Ondho Hoye Jaao", "Amit", 2020, 240);
            Phone a6 = new Phone("Kuch To Hai ", "Arman Malik", 2016, 240);
            Phone list = new Phone();
            list.AddMusicFile(a1, a2, a3, a4, a5, a6);
            Console.WriteLine();
            Console.WriteLine("**NEXT MUSIC INFORMATION***");
            list.playNext();
            Console.WriteLine();
            Console.WriteLine("&&&& Previous Music INFO&&&&");
            list.playPrevious();
            Console.WriteLine();
            Console.WriteLine("****MUSIC LIST***");
            list.ShowAllMusicFile();






        }
    }
}
