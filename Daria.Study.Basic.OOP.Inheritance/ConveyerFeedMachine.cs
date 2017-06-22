using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP.Inheritance
{
    class ConveyerFeedMachine : FeedMachine
    {
        public ConveyerFeedMachine(IFeedStatusDispatcher feedStatusDispatcher) : base(feedStatusDispatcher){ }
        protected override void PerformFeeding()
        {
            base.PerformFeeding();
            TakeFood();
            MoveConveyer();
        }
        private void TakeFood()
        {
            //Забрать еду из контейнера и пометсить на конвейер
        }
        private void MoveConveyer()
        {
            //Прокрутить конвейер
        }
    }
}
