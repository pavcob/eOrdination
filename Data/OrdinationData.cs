using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace eOrdination.Data
{
    public class OrdinationData : BaseData
    {
        public SqlDataReader dataReader;

        public OrdinationData()
        {
        }


        
        public OrdinationEntity GetOrdinationById(int id)
        {
            CreateSqlCommandSP("GetOrdinationById");
            AddParameterInt("@id", id);
            
            dataReader = ExecuteReader();

            OrdinationEntity ordination = new OrdinationEntity();

            if (dataReader.Read())
            {
                ordination.id = dataReader.GetInt32(0);
                ordination.speciality = dataReader.GetString(1);
            }

            return ordination;
        }

       
        public List<OrdinationEntity> GetAllOrdinations()
        {
            CreateSqlCommandSP("GetAllOrdinations");

            dataReader = ExecuteReader();

            
            List<OrdinationEntity> listOrdinations = new List<OrdinationEntity>();
            
            while (dataReader.Read())
            {
                OrdinationEntity ordination = new OrdinationEntity();
                ordination.id = dataReader.GetInt32(0);
                ordination.speciality = dataReader.GetString(1);
                listOrdinations.Add(ordination);
            }
            return listOrdinations;
        }

        public OrdinationEntity UpdateOrdinationById(OrdinationEntity ordination)
        {
            CreateSqlCommandSP("UpdateOrdinationById");
            AddParameterInt("@id", ordination.id);
            AddParameterString("@speciality", ordination.speciality);
            OrdinationEntity ordination2 = new OrdinationEntity(); 

            dataReader = ExecuteReader();
            if (dataReader.Read())
            {
                ordination2.id = dataReader.GetInt32(0);
                ordination2.speciality = dataReader.GetString(1);
            }

            return ordination2;
        }

        public void InsertIntoOrdination(string speciality)
        {
            CreateSqlCommandSP("InsertIntoOrdination");
            AddParameterString("@speciality", speciality);
            
            dataReader = ExecuteReader();

        }

        public void DeleteOrdinationById(OrdinationEntity ordination)
        {
            CreateSqlCommandSP("DeleteOrdinationById");
            AddParameterInt("@id", ordination.id);
            dataReader = ExecuteReader();

        }

    }
}
