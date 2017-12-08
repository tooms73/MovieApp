using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using MovieApp.Models;
using Newtonsoft.Json;

namespace MovieApp.Assets
{
    public static class JsonFile
    {
        public static List<Movie> LoadJson()
        {
            var path = HttpContext.Current.Server.MapPath("~/Assets/movies.json");
            using (StreamReader r = new StreamReader(path))
            {
                try
                {
                    var json = r.ReadToEnd();
                    var movies = JsonConvert.DeserializeObject<List<Movie>>(json);
                    return movies;
                }
                catch (Exception e)
                {
                    //register error
                    return null;
                }
            }
        }
    }
}