using FinalExercise.Models;

namespace FinalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите ссылку: ");
                string? videoURL=Console.ReadLine();

                if (IsURL(videoURL))
                {
                    if (IsYoutubeURL(videoURL))
                    {
                        var description = new VideoDescription();
                        var download = new VideoDownLoad();

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
