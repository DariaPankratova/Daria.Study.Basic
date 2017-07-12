﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daria.Study.Basic.StartPractice
{
    class FractionalArrayAgentOperationsManager : ArrayAgentOperationsManager
    {
        public FractionalArrayAgentOperationsManager(IArrayAgent arrayAgent) : base(arrayAgent)
        {
        }

        protected override decimal PerformDivision(int firstElement, int secondElement)
        {
            return (decimal)firstElement / secondElement;
        }
    }
}
