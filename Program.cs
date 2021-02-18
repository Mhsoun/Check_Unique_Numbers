using System;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int x = 1; x <= n; x++)
        {
            string g = Console.ReadLine();
            string codes = Console.ReadLine();
            string[] split = codes.Split(new char[] { ' ' }, StringSplitOptions.None);
            int[] a = Array.ConvertAll(split, s => int.Parse(s));

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        a[i] = 0;
                        a[j] = 0;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    Console.WriteLine("Case #" + x + ": " + a[i]);

                }
            }
        }
    }
}
