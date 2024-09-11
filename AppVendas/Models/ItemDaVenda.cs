namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }

        //relacionamento com a tabela vendas 
        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }

        //relacionamento com a tabela produtos
        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public double QtdadeVendida { get; set; }
        public double ValorTotalDoItem { get; set; }
    }
}
