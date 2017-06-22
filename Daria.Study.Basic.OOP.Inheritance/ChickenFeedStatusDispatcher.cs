using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP.Inheritance
{
    class ChickenFeedStatusDispatcher : IFeedStatusDispatcher
    {
        private bool CheckFeeder()
        {
            return true;
        }
        private bool CheckChickens()
        {
            return true;
        }

        public FeedStatus GetStatus()
        {
            return CheckFeeder() && CheckChickens() ?
                FeedStatus.Hungry :
                FeedStatus.Full;
        }

    }
}
