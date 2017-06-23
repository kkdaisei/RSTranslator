using System;

namespace HellowWpfApp
{
    public class SagawaCVS
    {
        public string addressCode { get; set; }
        public string receiverTelephone { get; set; }
        public string receiverZip { get; set; }
        public string receiverAddress1 { get; set; }
        public string receiverAddress2 { get; set; }
        public string receiverAddress3 { get; set; }
        public string receiverName1 { get; set; }
        public string receiverName2 { get; set; }
        public string manageNumber { get; set; }
        public string customerCode { get; set; }
        public string depertment { get; set; }
        public string customerTelephone { get; set; }
        public string clientTelephone { get; set; }
        public string clientZip { get; set; }
        public string clientAddress1 { get; set; }
        public string clientAddress2 { get; set; }
        public string clientName1 { get; set; }
        public string clientName2 { get; set; }
        public string boxTypeCode { get; set; }
        public string productName1 { get; set; }
        public string productName2 { get; set; }
        public string productName3 { get; set; }
        public string productName4 { get; set; }
        public string productName5 { get; set; }
        public string numberOfBox { get; set; }
        public string deliveryType1 { get; set; }
        public string deliveryType2 { get; set; }
        public string dateOfDeluvery { get; set; }
        public string timeOfDelivery1 { get; set; }
        public string timeOfDelivery2 { get; set; }
        public string deliveryAmount { get; set; }
        public string consomptionTax { get; set; }
        public string paymentType { get; set; }
        public string insuranceAmount { get; set; }
        public string displaysInsrance { get; set; }
        public string seal1 { get; set; }
        public string seal2 { get; set; }
        public string seal3 { get; set; }
        public string officeStop { get; set; }
        public string SRC { get; set; }
        public string officeCode { get; set; }
        public string prepayment { get; set; }

        public SagawaCVS()
        {
            addressCode = "";

            receiverAddress3 = "";

            customerCode = "193303400010";
            depertment = "";
            customerTelephone = "0799-32-0118";
//            clientTelephone = "0799-32-0118";
//            clientZip = "656-1312";
//            clientAddress1 = "兵庫県洲本市";
//            clientAddress2 = "五色町鮎原吉田1208-2";
//            clientName1 = "RIO";
//            clientName2 = "莉緒小舗";
            boxTypeCode = "004";
            numberOfBox = "001";
            deliveryType1 = "000";
            deliveryType2 = "001";
            dateOfDeluvery = "";
            timeOfDelivery1 = "";
            timeOfDelivery2 = "";
            deliveryAmount = "";
            consomptionTax = "";
            paymentType = "0";
            insuranceAmount = "0";
            displaysInsrance = "0";


            officeStop = "0";
            SRC = "0";
            officeCode = "3013";
            prepayment = "1";
        }
    }

    class SagawaCSVMapper : CsvHelper.Configuration.CsvClassMap<SagawaCVS>
    {
        public SagawaCSVMapper()
        {
            Map(m => m.addressCode).Index(0).Default("");
            Map(m => m.receiverTelephone).Index(1);
            Map(m => m.receiverZip).Index(2);
            Map(m => m.receiverAddress1).Index(3);
            Map(m => m.receiverAddress2).Index(4);
            Map(m => m.receiverAddress3).Index(5).Default("");
            Map(m => m.receiverName1).Index(6);
            Map(m => m.receiverName2).Index(7);
            Map(m => m.manageNumber).Index(8);
            Map(m => m.customerCode).Index(9).Default("193303400010");
            Map(m => m.depertment).Index(10).Default("");
            Map(m => m.customerTelephone).Index(11);
            Map(m => m.clientTelephone).Index(12).Default("");
            Map(m => m.clientZip).Index(13).Default("");
            Map(m => m.clientAddress1).Index(14).Default("");
            Map(m => m.clientAddress2).Index(15).Default("");
            Map(m => m.clientName1).Index(16).Default("");
            Map(m => m.clientName2).Index(17).Default("");
            Map(m => m.boxTypeCode).Index(18).Default("004");
            Map(m => m.productName1).Index(19);
            Map(m => m.productName2).Index(20);
            Map(m => m.productName3).Index(21);
            Map(m => m.productName4).Index(22);
            Map(m => m.productName5).Index(23);
            Map(m => m.numberOfBox).Index(24).Default("001");
            Map(m => m.deliveryType1).Index(25).Default("000");
            Map(m => m.deliveryType2).Index(26).Default("001");
            Map(m => m.dateOfDeluvery).Index(27).Default("");
            Map(m => m.timeOfDelivery1).Index(28).Default("");
            Map(m => m.timeOfDelivery2).Index(29).Default("");
            Map(m => m.deliveryAmount).Index(30).Default("");
            Map(m => m.consomptionTax).Index(31).Default("");
            Map(m => m.paymentType).Index(32).Default("0");
            Map(m => m.insuranceAmount).Index(33).Default("0");
            Map(m => m.displaysInsrance).Index(34).Default("0");
            Map(m => m.seal1).Index(35).Default("");
            Map(m => m.seal2).Index(36).Default("");
            Map(m => m.seal3).Index(37).Default("");
            Map(m => m.officeStop).Index(38).Default("0");
            Map(m => m.SRC).Index(39).Default("0");
            Map(m => m.officeCode).Index(40).Default("3013");
            Map(m => m.prepayment).Index(41).Default("1");
        }
    }
}
