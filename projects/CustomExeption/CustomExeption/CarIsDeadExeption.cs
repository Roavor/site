using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExeption
{
    [Serializable]
    class CarIsDeadExeption : ApplicationException
    {
        public CarIsDeadExeption() { }

        public CarIsDeadExeption(string message): base (message) { }
        public CarIsDeadExeption(string message, System.Exception inner)
           : base(message, inner)
        { }
          protected CarIsDeadExeption (System.Runtime.Serialization.SerializationInfo info,System.Runtime.Serialization.StreamingContext context)
        : base (info,context)
        { }
    }
}
