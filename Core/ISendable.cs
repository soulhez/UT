namespace Core
{
    public interface ISendable
    {
        void Send(string message);
    }
    public interface IReceiveable
    {
        void Receive(string message);
    }
}
