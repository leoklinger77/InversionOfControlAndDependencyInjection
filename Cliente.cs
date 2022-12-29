namespace IoC
{
    public interface ICliente
    {
        List<Guid> GetAllOrder();
    }
    public class Cliente : ICliente
    {
        private IPedido _pedido;
        public Cliente(IPedido pedido)
        {
            _pedido = pedido;
        }

        public List<Guid> GetAllOrder()
        {
            return _pedido.GetAlls();
        }
    }
}
