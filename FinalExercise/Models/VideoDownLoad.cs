using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace FinalExercise.Models
{
    internal class VideoDownLoad : ICommand
    {
        public string FilePath { get; set; }
        public VideoDownLoad(string outputFilePath)
        {
            FilePath = outputFilePath;
        }
        
        public async Task Execute(string videoURL)
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(videoURL);
            //var videoStreamInfo = video.Streams.First(s => s.Container == Container.Mp4);

           Console.WriteLine(Environment.NewLine+"Здесь должно быть скачивание видео...");


        }
    }
}
