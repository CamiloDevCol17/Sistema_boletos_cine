// En SistemaReservas.cs
using System.Collections.Generic;

namespace MovieLibrary
{
    internal class SistemaReservas
    {
        private Dictionary<string, Pelicula> peliculas;

        public SistemaReservas()
        {
            peliculas = new Dictionary<string, Pelicula>();
        }

        public void AgregarPelicula(Pelicula nuevaPelicula)
        {
            peliculas.Add(nuevaPelicula.Titulo, nuevaPelicula);
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>(peliculas.Values);
        }

        public class Pelicula
        {
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public List<string> Horarios { get; set; } = new List<string>();

            public override string ToString()
            {
                return Titulo; // Esto define cómo se muestra la película en un control ComboBox, por ejemplo.
            }
        }
    }
}
