using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Storage<T> where T :IStorable
    {
        public List<T> Bin { get; set; } = new List<T>();

        
    }
}
