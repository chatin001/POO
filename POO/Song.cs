using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Song
    {

        private string album;
        public string PublicAlbum 
        {
            get { return album; }
            set { album = value; }
        }


        private string title;
        public string PublicTitle
        {
            get { return title; }
            set { title = value; }
        }


        private string description ;
        public string PublicDescription
        {
            get { return description; }
            set { description = value; }
        }

        private string genre;
        public string PublicGenre
           {
            get { return genre; }
            set { genre = value; }
        }


        public Song(string album,string title, string description, string genre) 
        {
            PublicAlbum = album;
            PublicTitle  = title;
            PublicDescription = description;
            PublicGenre = genre;
        }

       
        public string GetAlbum()
            { return PublicAlbum; }

        public void SetAlbum(string album)
        { 
            
            this.PublicAlbum = album; }

        public string GetTitle()
        { return PublicTitle; }

        public void SetTitle(string title)
        {

            this.PublicTitle = title;
        }

        public string GetDescription()
        { return PublicDescription; }

        public void SetDescription(string description)
        {

            this.PublicDescription = description;
        }


        public string GetGenre()
        { return PublicGenre; }

        public void SetGenre(string genre)
        {

            this.PublicGenre = genre;
        }

    }
}
