// En Movielibrary.cs
using static MovieLibrary.SistemaReservas;
using System.Collections.Generic;

namespace MovieLibrary
{
    internal class Movielibrary
    {
        private List<Pelicula> peliculas;

        
        public void AgregarPelicula(Pelicula nuevaPelicula)
        {
            peliculas.Add(nuevaPelicula);
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return peliculas;
        }
    }
}
