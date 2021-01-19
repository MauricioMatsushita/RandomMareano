using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMareanoLibrary
{
   class Algorithm
   {
      internal int Mod11Digit(List<nint> value, int limiteDaMultiplicacao)
      {
         int Sum = 0;
         
         for (int i = value.Count - 1, Multiplier = 2; i >= 0; i--)
         {
            Sum += (int)value[i] * Multiplier;

            if (++Multiplier > limiteDaMultiplicacao) Multiplier = 2;
         }

         var Validator = (11 - (Sum % 11));
         if (Validator > 9)
            return 0;
         return Validator;
      }

      internal int Mod11Digit(List<nint> value)
      {
         return Mod11Digit(value, 9);
      }
   }
}
