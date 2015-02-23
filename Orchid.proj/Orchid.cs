using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orchid.proj
{
    public class Orchid
    {
        private string nextWatering;
        private string nextFertilizing;
        private string careInfo;

        Orchid orchid;

        public Orchid() { }

        public Orchid(string nextWatering, string nextFertilizing, string careInfo)
        {
            this.NextWatering = nextWatering;
            this.NextFertilizing = nextFertilizing;
            this.CareInfo = careInfo;
        }

        public string NextWatering
        {
            get
            {
                return nextWatering;
            }
            set
            {
                nextWatering = value;
            }
        }

        public string NextFertilizing 
        {
            get
            {
                return nextFertilizing;
            }
            set
            {
                nextFertilizing = value;
            }
        }

        public string CareInfo
        {
            get
            {
                return careInfo;
            }
            set
            {
                careInfo = value;
            }
        }

        public string GetNextFertilizing(string sep)
        {
            return NextFertilizing;
        }

        public string GetNextWatering(string sep)
        {
            return NextWatering;
        }

        public string GetCareInfo(string sep)
        {
            return CareInfo;
        }

        public void Save()
        {            
            OrchidDB.SaveOrchid(orchid);
        }
    }
}
