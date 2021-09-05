using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
        /*
        No se cumple con el principio SRP ya que esta clase tiene mas de un motivo para cambiar,
        el método AlmacenarLibro puede cambiar dependiendo de las necesidades del usario, ej: Se podría agregar un edificio
        como parámetro, entonces ya se estaría modificando la misma, o quizás se requiere almacenar el libro en forma virtual,
        por lo tanto, existe más de un motivo para cambiar la clase.
        Por otra parte es una responsabilidad que no le corresponde a la clase libro, saber donde está almacenado,
        sino que a otra clase como puede ser "Almacenar", que le corresponde saber que libro es.
        */

    }
}
