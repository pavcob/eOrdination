using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdination.Entity
{
    public class MedicalReportEntity
    {

        public int id { get; set; }
        public string report { get; set; }

        public MedicalReportEntity(int id, string report)
        {
            this.id = id;
            this.report = report;
        }

        public MedicalReportEntity()
        {

        }

        public MedicalReportEntity(int id)
        {
            this.id = id;
        }

        public MedicalReportEntity(string report)
        {
            this.report = report;
        }

        public override string ToString()
        {
            return id + " " + report;
        }
    }
}
