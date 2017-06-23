using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWpfApp
{
    public class Translator
    {
        RakutenCSV rakuten;

        public Translator(RakutenCSV rakutenCSV)
        {
            rakuten = rakutenCSV;
        }

        public SagawaCVS toSagawa()
        {
            var sagawa = new SagawaCVS();

            sagawa.receiverTelephone = Utility.rakutenRecieverTelephone(rakuten);
            sagawa.receiverZip = rakuten.receiverZip1 + "-" + rakuten.receiverZip2;
            sagawa.receiverAddress1 = rakuten.receiverAddress1 + rakuten.receiverAddress2;
            sagawa.receiverAddress2 = rakuten.receiverAddress3;
            sagawa.receiverName1 = rakuten.receiverName1 + "　" + rakuten.receiverName2;

            // sagawa.manageNumber = ???

            var fixedProductName = rakuten.productName.toWide().RemoveIgnoreWords();
            sagawa.productName1 = fixedProductName.first16Note();
            sagawa.productName2 = fixedProductName.second16Note();
            sagawa.productName3 = fixedProductName.third16Note();
            sagawa.productName4 = fixedProductName.fourth16Note();
            sagawa.productName5 = fixedProductName.fifth16Note();


            if (isDiffrentDelivery(rakuten))
            {
                sagawa.clientTelephone = Utility.rakutenClientTelephone(rakuten);
                sagawa.clientZip = rakuten.orderZip1 + "-" + rakuten.orderZip2;
                sagawa.clientAddress1 = rakuten.orderAddress1 + rakuten.orderAddress2;
                sagawa.clientAddress2 = rakuten.orderAddress3;
                sagawa.clientName1 = rakuten.orderName1 + "　" + rakuten.orderName2;

            }
            return sagawa;
        }

        public Boolean isDiffrentDelivery(RakutenCSV rakuten)
        {
            if (rakuten.receiverTelephone1 != rakuten.orderTelephone1) { return true; }
            if (rakuten.receiverTelephone2 != rakuten.orderTelephone2) { return true; }
            if (rakuten.receiverTelephone3 != rakuten.orderTelephone3) { return true; }
            if (rakuten.receiverZip1 != rakuten.orderZip1) { return true; }
            if (rakuten.receiverZip2 != rakuten.orderZip2) { return true; }
            if (rakuten.receiverAddress1 != rakuten.orderAddress1) { return true; }
            if (rakuten.receiverAddress2 != rakuten.orderAddress2) { return true; }
            if (rakuten.receiverAddress3 != rakuten.orderAddress3) { return true; }
            if (rakuten.receiverName1 != rakuten.orderName1) { return true; }
            if (rakuten.receiverName2 != rakuten.orderName2) { return true; }

            return false;
        }
    }
}
