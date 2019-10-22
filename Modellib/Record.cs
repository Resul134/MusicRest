using System;
using System.Collections.Generic;
using System.Text;

namespace Modellib
{
    public class Record
    {
        private string _title;
        private string _artist;
        private double _duration;
        private int _yearOfPublication;
        private int _id;


        public Record(string title, string artist, double duration, int yearOfPublication, int id)
        {
            _title = title;
            _artist = artist;
            _duration = duration;
            _yearOfPublication = yearOfPublication;
            _id = id;
        }

        public int YearOfPublication
        {
            get { return _yearOfPublication; }
            set { _yearOfPublication = value; }
        }

        public double Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }


           
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return $"{nameof(YearOfPublication)}: {YearOfPublication}, {nameof(Duration)}: {Duration}, {nameof(Artist)}: {Artist}, {nameof(Title)}: {Title}";
        }
    }
}
