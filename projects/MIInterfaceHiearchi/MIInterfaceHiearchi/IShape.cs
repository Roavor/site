using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHiearchi
{
    interface IShape: IDrawable,IGrintable
    {
        int GetNumberOfSites();
    }
}
