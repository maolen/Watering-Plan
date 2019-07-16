using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WateringPlan
{
    public class Country
    {
        public string Name { get; set; }
        public List<Field> fields = new List<Field>();

        public void Delete()
        {
            Name = "";
            fields.Clear();
        }
    }
}
