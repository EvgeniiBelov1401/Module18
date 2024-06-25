using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

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

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoURL);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");

            Console.WriteLine($"Видео будет скачано в папку{Environment.NewLine}{FilePath}");
        }
    }
}
