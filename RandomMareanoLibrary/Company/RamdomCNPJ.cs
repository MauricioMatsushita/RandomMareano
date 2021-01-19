using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RandomMareanoLibrary.Company
{
   public class RamdomCNPJ
   {


      public RamdomCNPJ()
      {

      }


      public string createCNPJ()
      {
         List<nint> cnpj = new List<nint>(14);
         for (var i = 1; i <= 8; i++)
         {
            cnpj.Add(RandomNumberGenerator.GetInt32(0, 9));
         }
         cnpj.Add(0);
         cnpj.Add(0);
         cnpj.Add(0);
         cnpj.Add(RandomNumberGenerator.GetInt32(0, 9));
         Algorithm algorithm = new Algorithm();
         cnpj.Add(algorithm.Mod11Digit(cnpj));
         cnpj.Add(algorithm.Mod11Digit(cnpj));

         return cnpj.Select(p => p.ToString()).Aggregate((p, a) => string.Concat(p, a));
      }

      
   }
}
