using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Entity
{
    public class DoctorEntity
    {
        public int id { get; set; }
        public int idOrdination { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public DoctorEntity(int id, int idOrdination, string name, string lastName)
        {
            this.id = id;
            this.idOrdination = idOrdination;
            this.name = name;
            this.lastName = lastName;
                
        }

        public DoctorEntity()
        {

        }

        public DoctorEntity(int id)
        {
            this.id = id;
        }

        public DoctorEntity(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return id + " " + idOrdination + " " + name + " " + lastName;
        }

        public DoctorEntity(int idOrdination, string name, string lastName)
        {
            this.idOrdination = idOrdination;
            this.name = name;
            this.lastName = lastName;

        }

    }
}
