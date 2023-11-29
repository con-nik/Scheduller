using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduller.Logic
{
    internal interface ITransform
    {
        string[] Transform(string[] inputCode);
    }
}
