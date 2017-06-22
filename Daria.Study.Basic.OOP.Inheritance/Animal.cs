using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP.Inheritance
{
    public abstract class Animal : IFeedable
    {
        public abstract FeedStatus FeedStatus { get; }

        public abstract void Feed();


    }
}
