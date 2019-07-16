using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WateringPlan
{
    public class Culture
    {
        private DateTime _endWateringTime;

        public string Name { get; set; }
        public DateTime StartWateringDate { get; set; }
        public int FrequencyWateringInDay { get; set; }
        public double WaterNeededInLitres { get; set; }
        public double RootingDepthInCm { get; set; }

        public DateTime EndWateringDate
        {
            get
            {
                return _endWateringTime;
            }
            set
            {
                if(value < StartWateringDate)
                {
                    return;
                }
                else
                {
                    _endWateringTime = value;
                }
            }
        }

        public void ShowAll ()
        {
            Console.WriteLine($"Имя культуры - {Name}");
            Console.WriteLine($"Дата начала полива - {StartWateringDate}");
            Console.WriteLine($"Дата конца полива - {EndWateringDate}");
            Console.WriteLine($"Частота полива в день - {FrequencyWateringInDay}");
            Console.WriteLine($"Воды нужно в литрах - {WaterNeededInLitres}");
            Console.WriteLine($"Глубина полива в см - {RootingDepthInCm}");
        }
        public void Delete ()
        {
            Name = "";
            WaterNeededInLitres = 0;
            RootingDepthInCm = 0;
        }
    }
}
