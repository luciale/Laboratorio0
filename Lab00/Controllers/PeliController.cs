using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Lab00.Controllers
{ 
     
    [Route("api/[controller]")]
    [ApiController]
    public class PeliController : ControllerBase
    {
        List<Pelicula> pel = new List<Pelicula>();
        Pelicula peli = new Pelicula();


        // GET: api/Peli
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string[] res = new string[10];
            if (pel.Count() >= 10)
            {
                int x = pel.Count()-1;
                for (int y=0; y<10; y++) {
                    res[y] =pel[x].nombre;
                    x--;
                }
            }


            return res;
        }

        

        // POST: api/Peli
        [HttpPost]
        public void Post([FromBody] string nombre, string director, int año)
        {
            peli.nombre = nombre;
            peli.director = director;
            peli.año = año;
            pel.Add(peli);
        }

    }
}
