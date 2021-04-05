using System;
using System.Collections;

namespace Iterator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Artists artists = new Artists();

            foreach (string art in artists)
            {
                Console.Write(art + " ");
            }

            Console.ReadKey();
        }

        public class Artists : IEnumerable
        {
            private string[] artists = { "Lorde", "Lana", "Billy", "H&J", "RB", "Disclouse" };

            public IEnumerator GetEnumerator()
            {
                for (int index = 0; index < artists.Length; index++)
                {
                    yield return $"{artists[index]},";
                }
            }
        }
    }
}