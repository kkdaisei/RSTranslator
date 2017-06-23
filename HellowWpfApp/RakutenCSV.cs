using System;

public class RakutenCSV
{
    public string invoiceString { get; set; }
    public string productName { get; set; }
    public string orderName1 { get; set; }
    public string orderName2 { get; set; }
    public string orderZip1 { get; set; }
    public string orderZip2 { get; set; }
    public string orderAddress1 { get; set; }
    public string orderAddress2 { get; set; }
    public string orderAddress3 { get; set; }
    public string orderTelephone1 { get; set; }
    public string orderTelephone2 { get; set; }
    public string orderTelephone3 { get; set; }
    public string receiverName1 { get; set; }
    public string receiverName2 { get; set; }
    public string receiverZip1 { get; set; }
    public string receiverZip2 { get; set; }
    public string receiverAddress1 { get; set; }
    public string receiverAddress2 { get; set; }
    public string receiverAddress3 { get; set; }
    public string receiverTelephone1 { get; set; }
    public string receiverTelephone2 { get; set; }
    public string receiverTelephone3 { get; set; }
    public string payment { get; set; }
    public string delivery { get; set; }
    public string yearOfDelivery { get; set; }
    public string monthOfDelivery { get; set; }
    public string dayOfDelivery { get; set; }
    public string timeOfDelivery { get; set; }
    public string typeOfDelivery { get; set; }
}

class RakutenCSVMapper : CsvHelper.Configuration.CsvClassMap<RakutenCSV>
{
    public RakutenCSVMapper()
    {
        Map(x => x.invoiceString).Index(0);
        Map(x => x.productName).Index(1);
        Map(x => x.orderName1).Index(2);
        Map(x => x.orderName2).Index(3);
        Map(x => x.orderZip1).Index(4);
        Map(x => x.orderZip2).Index(5);
        Map(x => x.orderAddress1).Index(6);
        Map(x => x.orderAddress2).Index(7);
        Map(x => x.orderAddress3).Index(8);
        Map(x => x.orderTelephone1).Index(9);
        Map(x => x.orderTelephone2).Index(10);
        Map(x => x.orderTelephone3).Index(11);
        Map(x => x.receiverName1).Index(12);
        Map(x => x.receiverName2).Index(13);
        Map(x => x.receiverZip1).Index(14);
        Map(x => x.receiverZip2).Index(15);
        Map(x => x.receiverAddress1).Index(16);
        Map(x => x.receiverAddress2).Index(17);
        Map(x => x.receiverAddress3).Index(18);
        Map(x => x.receiverTelephone1).Index(19);
        Map(x => x.receiverTelephone2).Index(20);
        Map(x => x.receiverTelephone3).Index(21);
        Map(x => x.payment).Index(22);
        Map(x => x.delivery).Index(23);
        Map(x => x.yearOfDelivery).Index(24);
        Map(x => x.monthOfDelivery).Index(25);
        Map(x => x.dayOfDelivery).Index(26);
        Map(x => x.timeOfDelivery).Index(27);
        Map(x => x.typeOfDelivery).Index(28);
    }
}