using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PatientEntity
    {

        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int idPatientFile { get; set; }

        public PatientEntity(int id, string name, string lastName, int idPatientFile)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.idPatientFile = idPatientFile;
        }

        public PatientEntity()
        {
           
        }

        public PatientEntity(int id)
        {
            this.id = id;
        }

        

        public PatientEntity(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public PatientEntity(string name, string lastName, int idPatientFile)
        {
        
            this.name = name;
            this.lastName = lastName;
            this.idPatientFile = idPatientFile;
        }

        public override string ToString()
        {
            return id + " " + name + " " + lastName + " " + idPatientFile;
        }

    }
}
