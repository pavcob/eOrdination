using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace eOrdination.Data
{
    public class MedicalReportData : BaseData
    {
        public SqlDataReader dataReader;

        public MedicalReportData()
        {
          
        }

        public MedicalReportEntity GetReportById(MedicalReportEntity report)
        {
            CreateSqlCommandSP("GetReportById");
            AddParameterInt("@id", report.id);
            dataReader = ExecuteReader();

            if (dataReader.Read())
            {
                report.id = dataReader.GetInt32(0);
                report.report = dataReader.GetString(1);
            }
            return report;
        }

        public List<MedicalReportEntity> GetAllReports()
        {
            CreateSqlCommandSP("GetAllReports");
            dataReader = ExecuteReader();
            List<MedicalReportEntity> listReports = new List<MedicalReportEntity>();

            while (dataReader.Read())
            {
                MedicalReportEntity report = new MedicalReportEntity();
                
                report.id = dataReader.GetInt32(0);
                report.report = dataReader.GetString(1);

                listReports.Add(report);

            }

            return listReports;
        }

        public void UpdateMedicalReportById(MedicalReportEntity report)
        {
            CreateSqlCommandSP("UpdateMedicalReportById"); 
            AddParameterInt("@id", report.id);
            AddParameterString("@report", report.report);
            
            dataReader = ExecuteReader();

        }

        public void InsertIntoMedicalReport(MedicalReportEntity report)
        {
            CreateSqlCommandSP("InsertIntoMedicalReport");
            AddParameterString("@report", report.report);

            dataReader = ExecuteReader();

        }

        public void DeleteMedicalReportById(int id)
        {
            CreateSqlCommandSP("DeleteMedicalReportById");
            AddParameterInt("@id", id);
            dataReader = ExecuteReader();
        }
    }
}
