using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperUtility
{
    public class Mapper
    {
        public Mapper()
        {

        }

        static Mapper()
        {

        }

        public void Map<T1, T2>(T1 first, T2 second) 
            where T1:IEnumerable<T1>
            where T2:IComparable<T2>
        {
            
        }
    }
}
