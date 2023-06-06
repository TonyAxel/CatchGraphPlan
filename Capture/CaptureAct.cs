using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.PM;



namespace CatchGraphPlan.Capture
{
    public class CaptureAct
    {
        public int number_id;
        public int dogs_count;
        public int cats_count;
        public int animals_count;
        public DateTime capture_Date;
        public string capture_goal;
        public Company company;
        public CaptureMunicipalContract captureMunicipalContract;
        public string file;

        public CaptureAct() { }
        public CaptureAct(int id) {
            this.number_id = id;
        }
        public CaptureAct(int id, string file)
        {
            this.number_id = id;
            this.file = file;
        }
        public CaptureAct(int number_id, int dogs_count, int cats_count, int animals_count, DateTime capture_Date, string capture_goal, Company company, CaptureMunicipalContract captureMunicipalContract, string file = null)
        {
            this.number_id = number_id;
            this.dogs_count = dogs_count;
            this.cats_count = cats_count;
            this.animals_count = animals_count;
            this.capture_Date = capture_Date;
            this.capture_goal = capture_goal;
            this.company = company;
            this.captureMunicipalContract = captureMunicipalContract;
            this.file = file;
        }



    }
}
