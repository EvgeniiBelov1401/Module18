using FinalExercise.Models;

namespace FinalExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string videoURL = "https://www.youtube.com/watch?v=anK6bt9wvmk";
            string outputFilePath = @"D:\Programming\Skillfactory\C#_projects\Module18\Repository\FinalExercise\bin\Debug\net8.0";

            var description=new VideoDescription();
            var download = new VideoDownLoad(outputFilePath);
            
            var client = new Client(description,videoURL);
            client.Run();
            
            client=new Client(download,videoURL);
            client.Run();
        }
    }
}
