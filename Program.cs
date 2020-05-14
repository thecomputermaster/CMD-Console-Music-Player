using System;
using System.IO;
using System.Media;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! I will allow you to listen to Music via the Windows Command Line!");

            Console.WriteLine("");

            Console.WriteLine("Please note that as of now, I can only play WAV files. This is operating system restrcited.");

            Console.WriteLine("");

            Console.WriteLine("Program (C) 2020 keifmeister. Give credit where credit is due.");

            Console.WriteLine("");

            Console.WriteLine("Press 1 to drag and drop a wav file to play, or 2 to enter the directry manually.");
           int input_1 = Convert.ToInt32(Console.ReadLine());

            string input_2 = Convert.ToString(Console.ReadLine());

            int aaction = input_1;

            switch (aaction)
            {

                case 1:

            SoundPlayer sPlayerq = new SoundPlayer();
            sPlayerq.SoundLocation = input_2;
            sPlayerq.PlaySync();
                    break;

                case 2:

                    try
                    {
                        string searchQuery = input_2;
                        string folderName = @"C:\";

                        var directory = new DirectoryInfo(folderName);

                        var directories = directory.GetDirectories(searchQuery, SearchOption.AllDirectories);
                        var files = directory.GetFiles(searchQuery, SearchOption.AllDirectories);

                        foreach (var d in directories)
                        {
                            Console.WriteLine(d);
                        }

                        foreach (var f in files)
                        {
                            Console.WriteLine(f);
                        }
                    }
                    catch (Exception e)
                    {
                        //
                    }
                    SoundPlayer sPlayer2 = new SoundPlayer();
                    sPlayer2.SoundLocation = input_2;
                        sPlayer2.PlaySync();
                    
                    break;
            }
        }



    }
}