using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace forbidden_hosts
{
    class Solution
    {
        public static int[] solution(string[] A, string[] B)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < A.Length; i++) {
                result.Add(i);
                for (int j = 0; j < B.Length; j++) {
                    if (A[i].Contains(B[j])) { result.Remove(i); break; }
                }
                
            }
            int[] L = result.ToArray();
            return L;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch SW = new Stopwatch();
            // Немного изменённые данные из примера с дублирующимися элементами (мало ли)
            string[] A = new string[] { "unlock.microvirus.md", "visitwar.com", "visitwar.com", "visitwar.de", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" };
            string[] B = new string[] { "microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us" };
            SW.Start();
            int[] res = Solution.solution(A, B);
            SW.Stop();
            Console.WriteLine("Массив: {0}", String.Join(", ", res));
            Console.WriteLine("Миллисекунд: " + Convert.ToString(SW.Elapsed.Milliseconds));
            Console.Write("Секунд: " + Convert.ToString(SW.Elapsed.Seconds));
        }
    }
}
