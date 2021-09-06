using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {


        public static string CreateAppointment(Paciente paciente, Doctor doctor, Consulta consulta)
        {
            return Validaciones.validar(paciente, doctor, consulta);
        }

        
    }
}
