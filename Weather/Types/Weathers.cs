using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Types
{
    public abstract class Weathers
    {
        protected float _temperature;

        protected abstract string GetInformation();
    }
}
