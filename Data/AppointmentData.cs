using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace eOrdination.Data
{
    public class AppointmentData : BaseData
    {
        public SqlDataReader dataReader;

        public List<AppointmentEntity> GetAllAppointments()
        {
            List<AppointmentEntity> appointments = new List<AppointmentEntity>();
            CreateSqlCommandSP("GetAllAppointments");
            dataReader = ExecuteReader();
            while (dataReader.Read())
            {
                AppointmentEntity appointment = new AppointmentEntity();
                appointment.Id = dataReader.GetInt32(0);
                appointment.IdPatient = dataReader.GetInt32(1);
                appointment.IdDoctor = dataReader.GetInt32(2);
                appointment.IdOrdination = dataReader.GetInt32(3);
                appointment.IdMedicalReport = dataReader.GetInt32(4);
                appointment.Date = dataReader.GetDateTime(5);

                appointments.Add(appointment);

            }

            return appointments;
        }

        
        public AppointmentEntity GetAppointmentById(int id)
        {
            AppointmentEntity appointment = new AppointmentEntity();
            CreateSqlCommandSP("GetAppointmentById");
            AddParameterInt("@id", id);
            dataReader = ExecuteReader();

            if (dataReader.Read())
            {
                appointment.Id = dataReader.GetInt32(0);
                appointment.IdPatient = dataReader.GetInt32(1);
                appointment.IdDoctor = dataReader.GetInt32(2);
                appointment.IdOrdination = dataReader.GetInt32(3);
                appointment.IdMedicalReport = dataReader.GetInt32(4);
                appointment.Date = dataReader.GetDateTime(5);
            }
            return appointment;
        }
        public void InsertIntoAppointment(AppointmentEntity appointment)
        {
            CreateSqlCommandSP("InsertIntoAppointment");
            AddParameterInt("@idPatient", appointment.IdPatient);
            AddParameterInt("@idDoctor", appointment.IdDoctor);
            AddParameterInt("@idOrdination", appointment.IdOrdination);
            AddParameterInt("@idMedicalReport", appointment.IdMedicalReport);
            AddParameterDateTime("@date", appointment.Date);

            dataReader = ExecuteReader();

        }

        public void DeleteAppointmentById(int id)
        {
            CreateSqlCommandSP("DeleteAppointmentById");
            AddParameterInt("@id", id);
            dataReader = ExecuteReader();


        }

    }
}
