using System;
using System.Linq;

namespace TestHackerRank
{
    static class BasicTests
    {
        static void Main()
        {
            Console.WriteLine("Test 1: Sales by Match");
            var testOneResult = SockMerchant(100, new[] {
            44, 55, 11, 15, 4, 72, 26, 91, 80, 14, 43, 78, 70, 75, 36, 83, 78, 91, 17, 17, 54, 65, 60, 21, 58, 98, 87, 45, 75, 97, 81, 18, 51, 43, 84, 54, 66, 10, 44, 45, 23, 38, 22, 44, 65, 9, 78, 42, 100, 94, 58, 5, 11, 69, 26, 20, 19, 64, 64, 93, 60, 96, 10, 10, 39, 94, 15, 4, 3, 10, 1, 77, 48, 74, 20, 12, 83, 97, 5, 82, 43, 15, 86, 5, 35, 63, 24, 53, 27, 87, 45, 38, 34, 7, 48, 24, 100, 14, 80, 54 });
            Console.WriteLine($"Result: {testOneResult}");
            Console.WriteLine("Test 2: Counting Valleys");
            var testTwoResult = CountingValleys(12, "DDUUDDUDUUUD");
            Console.WriteLine($"Result: {testTwoResult}");
            Console.WriteLine("Test 3: Jumping on the clouds");
            var testThreeResult = JumpingOnClouds(new[] { 0, 0, 0, 0, 1, 0 });
            Console.WriteLine($"Result: {testThreeResult}");
            Console.ReadKey();
        }

        static int SockMerchant(int n, int[] ar)
        {
            var pairs = 0;
            var numList = ar.ToList();
            for (var i = 0; i < ar.Length; i++)
            {
                if (numList.Count == 0)
                    break;
                var num = ar[i];
                var matches = numList.Where(x => x == num).Count();
                if (matches >= 2)
                {
                    var pairMatch = matches / 2;
                    pairs += pairMatch;
                }
                numList.RemoveAll(x => x == num);
            }
            return pairs;
        }

        static int CountingValleys(int steps, string path)
        {
            var numberOfValleys = 0;
            int altitud = 0;

            var pathSteps = path.Select(p => p);
            foreach (var hikerStep in pathSteps)
            {
                switch (hikerStep)
                {
                    case 'D':
                        altitud--;
                        break;
                    case 'U':
                        altitud++;
                        if (altitud == 0)
                            numberOfValleys++;
                        break;
                    default:
                        break;
                }
            }
            return numberOfValleys;
        }

        static int JumpingOnClouds(int[] c)
        {
            var jumps = 0;
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (c[i] == 0)
                    i++; //Make double jump
                jumps++;
            }
            return jumps;
        }

    }
}
