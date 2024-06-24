using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace FinalExercise.Models
{
    internal class VideoDescription : ICommand
    {
        public async Task Execute(string videoURL)
        {
            var youtube = new YoutubeClient();
            var video= youtube.Videos.GetAsync(videoURL).Result;

            Console.WriteLine($"Название: {video.Title}{Environment.NewLine}Описание: {video.Description}");
        }
    }
}
