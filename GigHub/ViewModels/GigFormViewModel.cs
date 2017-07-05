namespace GigHub.ViewModels
{
    using GigHub.Models;
    using System.Collections.Generic;
    using System;

    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public DateTime DateTime {
            get {
                return System.DateTime.Parse(string.Format("{0} {1}", Date, Time));
            }
        }

        public IEnumerable<Genre> Genres;
    }
}