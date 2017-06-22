using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.OOP.Inheritance
{
    public interface IFeedable
    {
        void Feed();
        FeedStatus FeedStatus { get; }
    }
}
