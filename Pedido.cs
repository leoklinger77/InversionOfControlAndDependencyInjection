namespace IoC
{
    public interface IPedido
    {
        void Get();
        List<Guid> GetAlls();
    }

    public class Pedido : IPedido
    {
        public void Get()
        {
        }

        public List<Guid> GetAlls()
        {
            return new List<Guid>() { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
        }
    }
}
