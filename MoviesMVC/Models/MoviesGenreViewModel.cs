﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace MoviesMVC.Models
{
    public class MoviesGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
