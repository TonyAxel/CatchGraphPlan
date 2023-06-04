using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatchGraphPlan.PM;

namespace CatchGraphPlan.Capture
{
    public class CaptureAnimalCard
    {
        public int id;
        public string animal_category;
        public string gender;
        public string size;
        public string hair;
        public string hair_color;
        public string ears;
        public string tail;
        public string special_signs;
        public string identification_label;
        public int electronic_chip_number;
        public Municipality municipality;
        public CaptureAct captureAct;

        public CaptureAnimalCard() { }
        public CaptureAnimalCard(int id, string animal_category, string gender, string size, string hair, string hair_color, string ears, string tail, string special_signs, string identification_label, int electronic_chip_number, Municipality municipality, CaptureAct captureAct ) {
            this.id = id;
            this.animal_category = animal_category;
            this.gender = gender;
            this.size = size;
            this.hair = hair;
            this.hair_color = hair_color;
            this.ears = ears;
            this.tail = tail;
            this.special_signs = special_signs;
            this.identification_label = identification_label;
            this.electronic_chip_number = electronic_chip_number;
            this.municipality = municipality;
            this.captureAct = captureAct;
        }
    }
}
