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
            string outputFilePath = @"D:\you";
            string videoUrl = "https://www.youtube.com/shorts/IuComoRuoM0";


            YoutubeClient youtubeClient = new YoutubeClient();

            Downloadvideo downloadvideo = new Downloadvideo(youtubeClient, videoUrl, outputFilePath);
            downloadvideo.Runn();
            downloadvideo.DownVidAsync();
            Console.ReadKey();
        }
    }
}