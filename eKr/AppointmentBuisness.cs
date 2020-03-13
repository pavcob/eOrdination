using eOrdination.Data;
using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Buisness
{
    public class AppointmentBuisness
    {

        public AppointmentData data = new AppointmentData();

        public List<AppointmentEntity> GetAllAppointments()
        {
            return data.GetAllAppointments();

        }

        public AppointmentEntity GetAppointmentById(int id)
        {
            return data.GetAppointmentById(id);
        }
        
        public void InsertIntoAppointment(AppointmentEntity appointment)
        {
            data.InsertIntoAppointment(appointment);
        }

        public void DeleteAppointmentById(int id)
        {
            data.DeleteAppointmentById(id);

        }
    }
}
