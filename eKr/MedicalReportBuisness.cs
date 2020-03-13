using eOrdination.Data;
using eOrdination.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Buisness
{
    public class MedicalReportBuisness
    {
        public MedicalReportData data = new MedicalReportData();
        public MedicalReportEntity GetReportById(MedicalReportEntity report)
        {
            return data.GetReportById(report);
        }

        public List<MedicalReportEntity> GetAllReports()
        {
            return data.GetAllReports();
        }

        public void UpdateMedicalReportById(MedicalReportEntity report)
        {
            data.UpdateMedicalReportById(report);
        }
     
        
        public void InsertIntoMedicalReport(MedicalReportEntity report)
        {
            data.InsertIntoMedicalReport(report);
        }

        public void DeleteMedicalReportById(int id)
        {
            data.DeleteMedicalReportById(id);
        }
    }
}
