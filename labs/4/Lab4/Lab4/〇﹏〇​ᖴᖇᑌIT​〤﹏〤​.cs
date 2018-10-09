using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Lab4
{

    /**
     * A class that gives you random fruit.
     */
    public class 〇﹏〇​ᖴᖇᑌIT​〤﹏〤​
    {
        /**
         * Where's the fruit???
         */
        public static string DATA_PATH = "~/App_Data/fruits.txt";

        /**
         * Fruit storage.
         */
        public ArrayList fruits = new ArrayList();

        /**
         * Read in fruit from `filepath`.
         */
        public 〇﹏〇​ᖴᖇᑌIT​〤﹏〤​(string filepath)
        {
            Console.WriteLine("Reading in fruits from " + filepath);

            using (var fs = new FileStream(filepath, FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        fruits.Add(line);
                    }
                }
            }
        }

        /**
         * Give me a random fruit from our fruit storage.
         */
        public string ЯΛПDӨMFЯЦIƬ()
        {
            int x = new Random().Next(0, maxValue: fruits.Count);
            return fruits[x] as string;
        }
    }
}