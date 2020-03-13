using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Entity
{
    public class OrdinationEntity
    {
        public int id { get; set; }

        public string speciality { get; set; }

        public OrdinationEntity(int id, string speciality)
        {
            this.id = id;
            this.speciality = speciality;
        }

        public OrdinationEntity()
        {

        }

        public OrdinationEntity(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return id + " " + speciality;
        }



    }
}
