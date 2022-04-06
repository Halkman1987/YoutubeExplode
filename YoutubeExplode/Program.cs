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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вставьте url-адресс видеоролика в формате :\n https://www.youtube.com/.......");
            string videoUrl = Console.ReadLine();
            Console.WriteLine("Введите имя видеоролика :");
            string VidName = Console.ReadLine();
            string rootdir = @"D:\you";
            string outputFilePath = Path.Combine(rootdir, VidName +".mp4");

            PultButton pultButton = new PultButton();
            
            YoutubeClient youtubeClient = new YoutubeClient();
            
            Downloadvideo downloadvideo = new Downloadvideo(youtubeClient, videoUrl, outputFilePath);
            
            pultButton.ChangeCommand(downloadvideo);
            pultButton.InfoVideo();
            Console.WriteLine("Нажмем для скачивания");
            Console.ReadKey();
            Console.WriteLine("Начинается загрузка видеофайла");
            pultButton.DownLoadVideo();
            
            Console.ReadKey();
            Console.WriteLine($"Ваш видеоролик находится в {outputFilePath}");
        }
    }
}