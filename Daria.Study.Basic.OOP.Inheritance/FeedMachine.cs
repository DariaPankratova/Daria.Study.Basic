using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP.Inheritance
{
    class FeedMachine
    {
        private IFeedStatusDispatcher _feedStatusDispatcher;
        public bool Ready { get; set; } = true;

        //композиция с интерфейсом IFeedStatusDispatcher
        public FeedMachine(IFeedStatusDispatcher feedStatusDispatcher)
        {
            _feedStatusDispatcher = feedStatusDispatcher;
        }
        //Паттерн: шаблонный метод (template method)
        public void Feed()
        {
            if (_feedStatusDispatcher.GetStatus() == FeedStatus.Hungry)
            {
                PerformFeeding();
            }
            Ready = true;
        }
        protected virtual void PerformFeeding()
        {
            Ready = false;
        }

    }
}
