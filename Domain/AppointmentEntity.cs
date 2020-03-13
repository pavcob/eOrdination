using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Entity
{
    public class AppointmentEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        public int IdOrdination { get; set; }
        public int IdMedicalReport { get; set; }

        public AppointmentEntity(int id, int idPatient, int idDoctor, int idOrdination, int idMedicalReport, DateTime date)
        {
            this.Id = id;
            this.IdPatient = idPatient;
            this.IdDoctor = idDoctor;
            this.IdOrdination = idOrdination;
            this.IdMedicalReport = idMedicalReport;
            this.Date = date;
        }
        public AppointmentEntity(int idPatient, int idDoctor, int idOrdination, int idMedicalReport, DateTime date)
        {
            
            this.IdPatient = idPatient;
            this.IdDoctor = idDoctor;
            this.IdOrdination = idOrdination;
            this.IdMedicalReport = idMedicalReport;
            this.Date = date;
        }

        public AppointmentEntity()
        {

        }

        public override string ToString()
        {
            return Id.ToString() + " " + IdPatient.ToString() + " " + IdDoctor.ToString() + " " + IdOrdination.ToString() + " " + IdMedicalReport.ToString()+ " " + Date.ToString();
        }


    }
}
