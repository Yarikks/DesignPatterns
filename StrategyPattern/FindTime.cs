using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FindTime
    {
        private IWay way;

        public FindTime() { }

        public FindTime(IWay _way)
        {
            way = _way;
        }

        public void SetWay(IWay _way)
        {
            way = _way;
        }

        public void Find(int dist)
        {
            way.ThisWay(dist);
        }
    }
}
