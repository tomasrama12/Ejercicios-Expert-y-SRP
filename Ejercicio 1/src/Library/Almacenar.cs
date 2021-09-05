using System;

namespace SRP
{
    public class Almacenar
    {
        public Libro LibroAlmacenado {get; set;}
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Almacenar(String sector, String estante, Libro libroAlmacenado)
        {
            this.LibroAlmacenado = libroAlmacenado;
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
        

    }
}