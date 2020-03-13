using eOrdination.Data;
using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Buisness
{
    public class DoctorBuisness
    {

        public DoctorData data = new DoctorData();

        public DoctorEntity GetDoctorById(int doctorId)
        {
            return data.GetDoctorById(doctorId);
        }


        public List<DoctorEntity> GetAllDoctors()
        {
            return data.GetAllDoctors();
        }

        public void UpdateDoctorsName(DoctorEntity doctor)
        {
            data.UpdateDoctorsName(doctor);
        }

        public void InsertIntoDoctor(DoctorEntity doctor)
        {
            data.InsertIntoDoctor(doctor);
        }

        public void DeleteDoctorById(DoctorEntity doctor)
        {
            data.DeleteDoctorById(doctor);
        }
    }
}
