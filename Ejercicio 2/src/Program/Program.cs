using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc1 = new Doctor("Armand");
            Paciente pac1 = new Paciente("Steven Jhonson", "986782342", "5555-555-555");
            Consulta con1 = new Consulta("Wall Street", DateTime.Now, "123");

            Doctor doc2 = new Doctor("Diego");
            Paciente pac2 = new Paciente("Ralf Manson", "", "5555-555-554");
            Consulta con2 = new Consulta("Queen Streett", DateTime.Now, "1234");

            string appointmentResult = AppointmentService.CreateAppointment(pac1, doc1, con1);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(pac2, doc2, con2);
            Console.WriteLine(appointmentResult2);

            
        }
    }
}
