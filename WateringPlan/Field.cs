using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WateringPlan
{
    public class Field
    {
        public string Name { get; set; }
        private double _area;
        public List<Culture> cultures = new List<Culture>();
        public double Area { get; set; }

        public void Delete()
        {
            Name = "";
            Area = 0.0;
            cultures.Clear();
        }
    }
}
