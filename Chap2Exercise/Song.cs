using System;
namespace Chap2Exercise
{
    public class Song
    {
        public Song (string title, string aritistName, int length)
        {
            this.Title = title;
            this.ArtistName = aritistName;
            this.Length = length;
        }

        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        public string getPlayTime()
        {
            var minute = Math.Floor((double)this.Length / 60);
            var restSecond = (this.Length - minute * 60);

            return $"{minute}:{restSecond}";
        }
    }
}
