using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public int Year { get; set; }
        public List<Actor> Actors { get; set; }
        public string Category { get; set; }
    }

    public class Actor
    {
        public string Name { get; set; }
    }
}