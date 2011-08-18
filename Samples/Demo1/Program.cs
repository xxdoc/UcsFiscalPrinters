using UcsFiscalPrinters;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceProtocol fp = (IDeviceProtocol)new cZekaProtocol();
            fp.Init("COM1");
            fp.StartReceipt(UcsFiscalReceiptTypeEnum.ucsFscRetFiscal, "1", "Operator", "0");
            fp.AddPLU("Product 1", 1.23, 5, 2);
            fp.AddPayment(UcsFiscalPaymentTypeEnum.ucsFscPmtCash, "Cash", 5);
            fp.EndReceipt();
        }
    }
}
