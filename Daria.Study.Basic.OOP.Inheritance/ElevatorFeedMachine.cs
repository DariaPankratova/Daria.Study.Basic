using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP.Inheritance
{
    class ElevatorFeedMachine : FeedMachine
    {
        public ElevatorFeedMachine(IFeedStatusDispatcher feedStatusDispatcher) : base(feedStatusDispatcher)
        {
        }

        protected override void PerformFeeding()
        {
            base.PerformFeeding();
            PourGrains();
        }
        private void PourGrains()
        {
            //насыпать зерно из емкости в кормушку
        }
    }
}
