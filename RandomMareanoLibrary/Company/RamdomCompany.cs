using System;

namespace RandomMareanoLibrary.Company
{
   public class RamdomCompany
   {
      private string cnpj { get; set; } 


      public RamdomCompany()
      {
         
      }

      public string CNPJ
      {
         get
         {
            SetCNPJ();
            return cnpj;
         }
      }
      public string CNPJFormat
      {
         get
         {
            SetCNPJ();
            return FormatCNPJ(cnpj);
         }
      }

      //public string Name
      //{
      //   get
      //   {

      //   }
      //}


      private void SetCNPJ()
      {
         if (cnpj == null)
         {
            RamdomCNPJ ramdomCNPJ = new RamdomCNPJ();
            cnpj = ramdomCNPJ.createCNPJ();
         }
      }

      private string FormatCNPJ(string CNPJ)
      {
         return Convert.ToUInt64(CNPJ).ToString(@"00\.000\.000\/0000\-00");
      }


   }
}
