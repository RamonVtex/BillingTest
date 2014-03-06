using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtex.Billing.Core.Data
{

    public class DenyBook
    {
        private List<string> deniedList;
        public List<string> DeniedList 
         {
           get{return deniedList;}
           private set { deniedList = value; }
         }

        //Constructor 
        public DenyBook()
        {
            this.DeniedList = new List<string>();
            UnchangeableRules();

                       
        }

        private void UnchangeableRules()
        {
            DeniedList.Add("ambienteqa");
            DeniedList.Add("basedevmkp");
            DeniedList.Add("walmartv5");
            DeniedList.Add("automacaoqa");
            DeniedList.Add("personalhomolog");
            DeniedList.Add("vtexbeta");
            DeniedList.Add("walteste");
        }

//        public string ConsultOnDeniedList(string accountName)

//        {

//            throw new NotImplementedException();
//        }

//        public void InsertOnDeniedList(string accountName)
//        {
//            //throw new NotImplementedException();
            
//            deniedList.Add(accountName);
            
//        }
        
//        public void DeleteOnDeniedList(string accountName)
//        {
//            throw new NotImplementedException();
//        }
                   

    }
}
