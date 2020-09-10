public class CalculatorPedido
{
    public decimal GetValueToPay(List<ItemPedido>lstItemPedido){
        var maria = 0.010;
        var jose = 0.005m;
        
        var discount = lstItemPedido.Count() > 1 ? maria : jose;

        var total = total - (total * desconto); 
    }
}