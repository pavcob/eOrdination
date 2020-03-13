using eOrdination.Data;
using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Buisness
{
    public class PatientFileBuisness
    {
        public PatientFileData data = new PatientFileData();

        public void InsertIntoPatientFile(PatientFileEntity patientFile)
        {
            data.InsertIntoPatientFile(patientFile);
        }
    }
}
