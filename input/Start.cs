using System;

namespace ComputerVisionAPI
{
    class Start
    {
        public static void AnalyseImage()
        {
            try
            {
                Console.Write("Enter the path to an image you wish to analzye for landmarks: ");
                string imageFilePath = Console.ReadLine();
                Helper.analyzePath(imageFilePath);

                Console.Write("Enter the outputs you want to see separated by comma (Categories, Description, Color, ImageType, Tags, Adult, Faces): ");
                string parameters = Console.ReadLine();
                Helper.analyzeInput(parameters);

                AnalysisRequest.MakeAnalysisRequest(imageFilePath, parameters);

                Console.WriteLine("\nPlease wait a moment for the results to appear. Then, press Enter to exit ...\n");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
