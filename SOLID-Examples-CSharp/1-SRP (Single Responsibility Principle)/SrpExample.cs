namespace SOLID_Examples_CSharp.SRP
{
    public class SrpExample
    {
        // A classe Invoice só tem uma responsabilidade: lidar com as faturas
        public class Invoice
        {
            public void CalculateTotal()
            {
                // Código para calcular o total da fatura
            }
        }

        // A classe InvoicePrinter só tem uma responsabilidade: imprimir faturas
        public class InvoicePrinter
        {
            public void PrintInvoice(Invoice invoice)
            {
                // Código para imprimir a fatura
            }
        }

        // A classe InvoiceRepository só tem uma responsabilidade: salvar faturas
        public class InvoiceRepository
        {
            public void Save(Invoice invoice)
            {
                // Código para salvar a fatura no banco de dados
            }
        }
    }
}
