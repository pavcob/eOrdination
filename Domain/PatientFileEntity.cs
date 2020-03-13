using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Entity
{
    public class PatientFileEntity
    {

        public int id { get; set; }

        public int idMedicalReport { get; set; }

        public PatientFileEntity(int id, int idMedicalReport)
        {
            this.id = id;
            this.idMedicalReport = idMedicalReport;
        }

        public PatientFileEntity(MedicalReportEntity medicalReport)
        {

        }


        public PatientFileEntity()
        {

        }

        public PatientFileEntity(int idMedicalReport)
        {
            this.idMedicalReport = idMedicalReport;
                
        }
    }
}
