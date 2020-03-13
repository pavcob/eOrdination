using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace eOrdination.Data
{
    public class PatientData : BaseData
    {

       
        public SqlDataReader dataReader;

        public PatientData()
        {
           
        }

        public void InsertIntoPatientt(PatientEntity patient)
        {
            CreateSqlCommandSP("InsertIntoPatient");
            AddParameterString("@name", patient.name);
            AddParameterString("@lastName", patient.lastName);
            AddParameterInt("@idPatientFile", patient.idPatientFile);

            dataReader = ExecuteReader(); //izvrsi mi ovo

        }




        public PatientEntity GetPatientById(PatientEntity patient)
        {

            CreateSqlCommandSP("GetPatientById");
            AddParameterInt("@id", patient.id);
            dataReader = ExecuteReader();

            if (dataReader.Read())
            {

                patient.id = dataReader.GetInt32(0);
                patient.name = dataReader.GetString(1);
                patient.lastName = dataReader.GetString(2);
                patient.idPatientFile = dataReader.GetInt32(3);

            }
            return patient;
        }

        public List<PatientEntity> GetAllPatients()
        {
            List<PatientEntity> listPatients = new List<PatientEntity>();
            
            
            CreateSqlCommandSP("GetAllPatients");
           
            dataReader = ExecuteReader();

            while (dataReader.Read())
            {
                PatientEntity patient = new PatientEntity();
                patient.id = dataReader.GetInt32(0);
                patient.name = dataReader.GetString(1);
                patient.lastName = dataReader.GetString(2);
                patient.idPatientFile = dataReader.GetInt32(3);
                listPatients.Add(patient);
            }
            return listPatients;
        }

        public PatientEntity UpdatePatientById(PatientEntity patient)
        {

            CreateSqlCommandSP("UpdatePatientById");
            AddParameterInt("@id", patient.id);
            AddParameterString("@name", patient.name);
            AddParameterString("@lastName", patient.lastName);
            AddParameterInt("@idPatientFile", patient.idPatientFile);

            dataReader = ExecuteReader();

            if (dataReader.Read())
            {
                patient.id = Convert.ToInt32(dataReader["id"]);
                patient.name = dataReader.GetString(1);
                patient.lastName = dataReader.GetString(2);
                patient.idPatientFile = dataReader.GetInt32(3);
            }
            return patient;
        }

        public void InsertIntoPatient(PatientEntity patient)
        {
            CreateSqlCommandSP("InsertIntoPatient");
            //name,lastname, idPatientfile
            AddParameterString("@name", patient.name);
            AddParameterString("@lastName", patient.lastName);
            AddParameterInt("@idPatientFile", patient.idPatientFile);

            dataReader = ExecuteReader();

        }

        public void DeletePatientById(int id)
        {
            CreateSqlCommandSP("DeletePatientById");

            AddParameterInt("@id", id);
            dataReader = ExecuteReader();
        }

    }
}


