global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        string fileName = @"C:\XAMLPixels.txt";

        Console.WriteLine("*File will be created in C:\\XAMLPixels.txt*");
        Console.WriteLine("How many pixels would you like to create? (MUST BE A NUMBER!!)");
        int PXNum = Convert.ToInt32(Console.ReadLine());

        try
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = File.CreateText(fileName))
            {
                int pxadd = 0;
                do
                {
                    pxadd++;
                    sw.WriteLine("<Rectangle x:Name=\"P" + pxadd + "\" Height=\"10\" Width=\"10\" Fill=\"Black\"/>");
                } while (pxadd <= PXNum);
            }
        }
        catch (Exception Ex)
        {
            Console.WriteLine(Ex.ToString());
        }
    }
}
