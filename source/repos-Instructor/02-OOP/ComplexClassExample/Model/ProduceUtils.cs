using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClassExample.Model
{
    public class ProduceUtils
    {
        public static double GetItemWeight(Produce item)
        {
            return item.Weight * item.Quantity;
        }

        public static double GetTotalWeight(List<Produce> produces)
        {
            double result = 0.0;
            foreach (var item in produces)
            {
                result += GetItemWeight(item);
            }
            return result;
        }

    }
}
