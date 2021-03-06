﻿using System.Collections.Generic;
using System.Xml.Serialization;
using VideoConvert.Core.Helpers.TheMovieDB;

namespace VideoConvert.Core.Helpers
{
    [XmlRoot("movie")]
    public class MovieEntry
    {
        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("originaltitle")]
        public string OriginalTitle { get; set; }

        [XmlElement("sorttitle")]
        public string SortTitle { get; set; }

        [XmlElement("rating", typeof(float))]
        public float Rating { get; set; }

        [XmlElement("epbookmark", typeof(float))]
        public float EpBookmark { get; set; }

        [XmlElement("year", typeof(int))]
        public int Year { get; set; }

        [XmlElement("top250", typeof(int))]
        public int Top250 { get; set; }

        [XmlElement("votes", typeof(int))]
        public int Votes { get; set; }

        [XmlElement("outline")]
        public string Outline { get; set; }

        [XmlElement("plot")]
        public string Plot { get; set; }

        [XmlElement("tagline")]
        public string Tagline { get; set; }

        [XmlElement("runtime", typeof(int))]
        public int Runtime { get; set; }

        [XmlElement("thumb")]
        public List<MovieDBPosterImage> PosterImages { get; set; }

        [XmlArray("fanart")]
        [XmlArrayItem("thumb")]
        public List<MovieDBImageInfo> FanartImages { get; set; }

        [XmlElement("mpaa")]
        public string MPAARating { get; set; }

        [XmlElement("playcount", typeof(int))]
        public int PlayCount { get; set; }

        [XmlElement("lastplayed")]
        public string LastPlayed { get; set; }

        [XmlElement("id")]
        public string ImdbID { get; set; }

        [XmlElement("genre")]
        public List<string> Genres { get; set; }

        [XmlElement("country")]
        public List<string> Countries { get; set; }

        [XmlElement("set")]
        public List<string> SetNames { get; set; }

        [XmlElement("credits")]
        public List<string> Writers { get; set; }

        [XmlElement("director")]
        public List<string> Directors { get; set; }

        [XmlElement("premiered")]
        public string Premiered { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("aired")]
        public string Aired { get; set; }

        [XmlElement("studio")]
        public List<string> Studios { get; set; }

        [XmlElement("trailer")]
        public string Trailer { get; set; }

        [XmlElement("actor")]
        public List<MovieDBCast> Casts { get; set; }

        [XmlElement("dateadded")]
        public string DateAdded { get; set; }
    }
}
