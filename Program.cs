using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            if (!Directory.Exists(string.Format(@"{0}\Hai", path)))
            {
                Directory.CreateDirectory(string.Format(@"{0}\Hai", path));
            }

            string[] lolis = Directory.GetFiles(path);



            List<string> Tags = new List<string>
            {
                "yuri",
                "neko"
            };

            string TagsIn = Console.ReadLine();
            List<string> TagsInList = TagsIn.Split(',').ToList();

            List<string> Verifiedtags = new List<string>();
            List<string> UnVerifiedtags = new List<string>();
            foreach (string hai in TagsInList)
            {
                string hai2 = hai.Trim();
                hai2 = hai2.ToLower();
                if (Tags.Contains(hai2))
                {
                    Verifiedtags.Add(hai2);
                }
                else
                {
                    UnVerifiedtags.Add(hai2);
                }
            }
            Console.WriteLine("Known Tags:");
            foreach (string vertag in Verifiedtags)
            {
                Console.WriteLine(vertag);
            }

            Console.WriteLine("UnKnown Tags:");
            foreach (string unvertag in UnVerifiedtags)
            {
                Console.WriteLine(unvertag);
            }

            public class Dsadrfadsf

            {

            }

            Console.ReadKey();
            Console.WriteLine(path);
            foreach (string loli in lolis)
            {
                Console.WriteLine(loli);
                if (Path.GetExtension(loli) == ".png" || Path.GetExtension(loli) == ".jpg")
                {

                    // File.Delete(loli);
                    Console.WriteLine("Horse2");
                    Console.WriteLine("Loli {0}", loli);
                    File.Move(loli, string.Format(@"{0}\Hai\1.png", path));
                }
            }

            string e = Console.ReadLine();
            Console.WriteLine(e);
            Console.ReadKey();
            if(true)
            { }
        }
    }
}
