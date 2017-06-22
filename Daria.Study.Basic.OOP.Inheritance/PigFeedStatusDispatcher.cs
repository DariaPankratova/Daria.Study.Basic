using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP.Inheritance
{
    class PigFeedStatusDispatcher : IFeedStatusDispatcher
    {
        public FeedStatus GetStatus()
        {
            return CheckTime() ?
                FeedStatus.Hungry :
                FeedStatus.Full;
        }

        private bool CheckTime()
        {
            return true;
        }

    }
}
