using eOrdination.Data;
using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Buisness
{
    public class OrdinationBuisness
    {
        OrdinationData data = new OrdinationData();

        public OrdinationEntity GetOrdinationById(int id)
        {           
            return data.GetOrdinationById(id);           
        }
        public List<OrdinationEntity> GetAllOrdinations()
        {
            return data.GetAllOrdinations();
        }

        public OrdinationEntity UpdateOrdinationById(OrdinationEntity ordination)
        {
            return data.UpdateOrdinationById(ordination);
        }

        public void InsertIntoOrdination(string speciality)
        {
            data.InsertIntoOrdination(speciality);
        }

        public void DeleteOrdinationById(OrdinationEntity ordination)
        {
            data.DeleteOrdinationById(ordination);

        }
    }
}
