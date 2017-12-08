using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieApp.Assets;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MoviesController : ApiController
    {
        // GET: api/Movies
        public IHttpActionResult Get()
        {
            var movies = JsonFile.LoadJson();
            if (movies != null)
                return Ok(movies);

            return NotFound();
        }

        // GET: api/Movies/5
        public IHttpActionResult Get(int id)
        {
            var movies = JsonFile.LoadJson();

            if (movies != null)
            {
                var movie = movies.Find(m => m.Id == id);
                if (movie != null)
                    return Ok(movie);
            }

            return NotFound();
        }

        // POST: api/Movies
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Movies/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Movies/5
        public void Delete(int id)
        {
        }
    }
}
