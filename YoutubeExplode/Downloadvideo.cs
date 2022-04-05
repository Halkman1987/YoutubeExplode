using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YoutubeExplode
{
    class Downloadvideo : Command
    {
        YoutubeClient _youtubeClient;
        public string _videoUrl;
        public string _outputFilePath;
        public Downloadvideo(YoutubeClient youtubeClient, string videoUrl, string outputFilePath)
        {
            _youtubeClient = youtubeClient;
            _videoUrl = videoUrl;
            _outputFilePath = outputFilePath;
        }
        async override public Task RunInfo()
        {
            var description = await _youtubeClient.Videos.GetAsync(_videoUrl);
            var title = description.Title;
            var author = description.Author.Title;
            var duration = description.Duration;
            Console.WriteLine($"\nПолучена информация: \n" +
                $"Название: \t{title}\n" +
                $"Автор: \t{author}\n" +
                $"Длительность: \t{duration}");
        }
        async override public Task RunDownload()
        {
            var description = await _youtubeClient.Videos.GetAsync(_videoUrl);
            await _youtubeClient.Videos.DownloadAsync(_videoUrl, _outputFilePath);
            string fileneame = DateTime.Now.ToShortDateString() + "_" + description.Title.Split(' ')[0] + ".mp4";

            await _youtubeClient.Videos.DownloadAsync(_videoUrl, fileneame,  builder => builder.SetPreset(ConversionPreset.UltraFast));
            
            Console.WriteLine("  Выбранное видео полностью загруженно !\n Поздравляем!!!");
        }
    }

}
