public class Produto
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public double Precoaqui { get; set; }
    public double Lucro { get; set; }
    public double Precovenda { get; set; }

    public Produto() { }
    public Produto (string codigo, string descricao, double precoaqui, double lucro, double precovenda)
    {
       this.Codigo = codigo;
       this.Descricao = descricao;
       this.Precoaqui = precoaqui;
       this. Lucro = lucro;
       this.Precovenda = precovenda;
    }
}