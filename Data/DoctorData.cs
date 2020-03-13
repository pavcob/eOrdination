using eOrdination.Entity;
using eOrdination.Log;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace eOrdination.Data
{
    public class DoctorData :BaseData
    {

        public SqlConnection sqlConnection;
        public SqlDataReader dataReader;

        public DoctorData()
        {
          
        }
        public DoctorEntity GetDoctorById(int doctorId)
        {
          
            try
            {
                DoctorEntity doctor = new DoctorEntity();

                CreateSqlCommandSP("GetDoctorById");
                AddParameterInt("@id", doctorId);
                dataReader = ExecuteReader();
                if (dataReader.Read())
                {
                    doctor.id = dataReader.GetInt32(0);
                    doctor.idOrdination = dataReader.GetInt32(1);
                    doctor.name = dataReader.GetString(2);
                    doctor.lastName = dataReader.GetString(3);
                    
                }
                return doctor;
            }
            catch (Exception exc)
            {
                
                throw exc;
            }
            finally
            { 
                CloseConnection();
            }

            return null;
        }

        public List<DoctorEntity> GetAllDoctors()
        {

            CreateSqlCommandSP("GetAllDoctors");
            dataReader = ExecuteReader();
            List<DoctorEntity> listDoctors = new List<DoctorEntity>();
            while (dataReader.Read())
            {
                DoctorEntity doctor = new DoctorEntity();
                doctor.id = dataReader.GetInt32(0);
                doctor.idOrdination = dataReader.GetInt32(1);
                doctor.name = dataReader.GetString(2);
                doctor.lastName = dataReader.GetString(3);

                listDoctors.Add(doctor);
            }

            return listDoctors;
        }
       
        public void UpdateDoctorsName(DoctorEntity doctor)
        {
            CreateSqlCommandSP("UpdateDoctorsName");
            AddParameterInt("@id", doctor.id);
            AddParameterString("@name", doctor.name);
            dataReader = ExecuteReader();
        }

        public void InsertIntoDoctor(DoctorEntity doctor)
        {
            CreateSqlCommandSP("InsertIntoDoctor");
            
            AddParameterString("@name", doctor.name);
            AddParameterString("@lastName", doctor.lastName);
            AddParameterInt("@idOrdination", doctor.idOrdination);
            dataReader = ExecuteReader();
        }

        public void DeleteDoctorById(DoctorEntity doctor)
        {
            CreateSqlCommandSP("DeleteDoctorById");
            AddParameterInt("@id", doctor.id);
            dataReader = ExecuteReader();
        }
    }     
}
