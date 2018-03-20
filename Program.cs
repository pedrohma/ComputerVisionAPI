using System;

namespace ComputerVisionAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path to an image you wish to analzye for landmarks: ");
            string imageFilePath = Console.ReadLine();

            AnalysisRequest.MakeAnalysisRequest(imageFilePath);

            Console.WriteLine("\nPlease wait a moment for the results to appear. Then, press Enter to exit ...\n");
            Console.ReadLine();
        }
    }
}
