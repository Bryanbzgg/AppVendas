namespace AppVendas.Models
{
    public class Venda
    {
        public Guid VendaID { get; set; }
        public string VendaName { get; set; }
        public int NotaFiscal { get; set; }
        public DateTime DataVenda { get; set; }
        public double? TotalVenda { get; set; }

        //referencia para a model cliente 

        public Guid ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
