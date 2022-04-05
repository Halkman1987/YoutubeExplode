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
            Console.WriteLine("Вставьте адресс");
            string videoUrl = Console.ReadLine();
            // = "https://www.youtube.com/watch?v=AsNtJQK3Q90";
            string outputFilePath = @"D:\you";
            
            PultButton pultButton = new PultButton();
            
            YoutubeClient youtubeClient = new YoutubeClient();
            
            Downloadvideo downloadvideo = new Downloadvideo(youtubeClient, videoUrl, outputFilePath);
            
            pultButton.ChangeCommand(downloadvideo);
            pultButton.InfoVideo();
            Console.WriteLine("Нажмем для скачивания");
            Console.ReadKey();
            
            pultButton.DownLoadVideo();
            Console.ReadKey();
        }
    }
}