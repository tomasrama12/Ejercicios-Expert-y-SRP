using System;
using System.Text;


namespace Library
{
    public class Consulta
    {
        public string AppoinmentPlace {get; set;}
        public DateTime Time {get; set;}
        public string Identificador {get; set;}


        public Consulta(string place, DateTime time, string identificador)
        {
            this.AppoinmentPlace = place;
            this.Time = time;
            this.Identificador = identificador;

        }




        






    }
}