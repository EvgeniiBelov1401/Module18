using FinalExercise.Models;

namespace FinalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //string videoURL = "https://www.youtube.com/watch?v=anK6bt9wvmk";
                

                Console.Write("Введите ссылку: ");
                string videoURL=Console.ReadLine();

                if (IsURL(videoURL))
                {
                    if (IsYoutubeURL(videoURL))
                    {
                        string outputFilePath = @"D:\Programming\Skillfactory\C#_projects\Module18\Repository\FinalExercise\bin\Debug\net8.0";
                        var description = new VideoDescription();
                        var download = new VideoDownLoad(outputFilePath);

                        var client = new Client(description, videoURL);
                        client.Run();

                        client = new Client(download, videoURL);
                        client.Run();
                    }
                    else
                    {
                        Console.WriteLine("Это не ссылка на YouTube...");
                    }
                }
                else
                {
                    Console.WriteLine("Это не ссылка...");
                }
              
                Console.ReadLine();
                Console.Clear();
            }  
            
            static bool IsURL(string url)
            {
                try
                {
                    new Uri(url);
                    return true;
                }
                catch(UriFormatException)
                {
                    return false;
                }
            }
           static bool IsYoutubeURL(string url)
            {
                if (url.StartsWith("https://www.youtube.com"))
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            }
        }
    }
}
