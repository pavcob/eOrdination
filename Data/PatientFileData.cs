using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace eOrdination.Data
{
    public class PatientFileData : BaseData
    {

        
        public SqlDataReader dataReader;

        public PatientFileData()
        {
            
        }

        public void InsertIntoPatientFile(PatientFileEntity patientFile)
        {
            CreateSqlCommandSP("InsertIntoPatientFile");
            AddParameterInt("@idMedicalReport", patientFile.idMedicalReport);

            dataReader = ExecuteReader();


        }


    }
}
