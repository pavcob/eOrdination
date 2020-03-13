
using Domain;
using eOrdination.Buisness;
using eOrdination.Entity;
using System;
using System.Collections.Generic;

namespace eOrdination
{
     class Program
     {

     
        static void Main(string[] args)
        {
            PatientBuisness buisness = new PatientBuisness();


            List<PatientEntity> list = new List<PatientEntity>();

          
            list = buisness.GetAllPatients();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]); 

            }

            Console.ReadLine();
            
        }

        private static void ShowAllDoctors()
        {
            DoctorBuisness doc = new DoctorBuisness();
            List< DoctorEntity> doctors = doc.GetAllDoctors();
            foreach (DoctorEntity doctor in doctors)
            {
                Console.WriteLine(doctor.ToString());
            }
        }
    }
}
