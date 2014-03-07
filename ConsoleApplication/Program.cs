using System;
using Vtex.Billing.Core.Data;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            OMSData data = new OMSData(Guid.NewGuid(), 10);
            string s = data.AccountName;
            
            //Testando <inicio>
            DenyBook denyBook = new DenyBook();

            BillingAccountManager billingAccountManager = BillingAccountManager.Instance;

            billingAccountManager.Warmup();
            
    
            if (denyBook.DeniedList.Contains("teste"))
            {
                System.Console.WriteLine("Negado");
            }
            else
            {
                System.Console.WriteLine("Permitido");
            }
            

            foreach(string item in denyBook.DeniedList)
            {
                Console.WriteLine(item);
            }

            System.Console.ReadLine();
            //Tesando <fim>
         
        }
    }
}
