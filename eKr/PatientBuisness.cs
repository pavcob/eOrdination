
using Domain;
using eOrdination.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Buisness
{
    public class PatientBuisness
    {
        public PatientData data = new PatientData();
 
        public void InsertIntoPatientt(PatientEntity patient)
        {

            data.InsertIntoPatientt(patient);


        }


        public PatientEntity GetPatientById(PatientEntity patient)
        { 
            return data.GetPatientById(patient);

        }

        public List<PatientEntity> GetAllPatients()
        { 
            return data.GetAllPatients();
        }

        public PatientEntity UpdatePatientById(PatientEntity patient)
        {
            return data.UpdatePatientById(patient);
        }

        public void InsertIntoPatient(PatientEntity patient)
        {
            data.InsertIntoPatient(patient);
        }

        public void DeletePatientById(int id)
        {
            data.DeletePatientById(id);
        }
    }
}
