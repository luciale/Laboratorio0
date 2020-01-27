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



        // GET: api/Peli
        [HttpGet]
        // para recibir dato
        // [Route("{id?}")]
        public IEnumerable<Pelicula> Get()
        {
        
            if(Datacs.Instance.lista_peliculas.Count >10)
            {
                int con = Datacs.Instance.lista_peliculas.Count;
                List<Pelicula> lis = new List<Pelicula>();
                for(int x =0; x < 10; x++)
                {
                    lis.Add(Datacs.Instance.lista_peliculas[con - x]);

                }
                return lis;



            }
            else
            {
                return Datacs.Instance.lista_peliculas;
            }

           
        }

        

        // POST: api/Peli
        [HttpPost]
        public void Post([FromBody] string nombre, string  director,int año)
        {
            Pelicula peli = new Pelicula();
            peli.nombre = nombre;
            peli.director = director;
            peli.año = año;
            Datacs.Instance.lista_peliculas.Add(peli);
        }

    }
}
