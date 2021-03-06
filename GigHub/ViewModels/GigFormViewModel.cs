﻿namespace GigHub.ViewModels
{
    using GigHub.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }
        
        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres;

        public DateTime GetDateTime ()
        {
            return System.DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}