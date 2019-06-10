using Core;

namespace MessageService
{
    public class GreetMessageService
    {
        ISendable greetTool;

        public GreetMessageService(ISendable sendtool)
        {
            greetTool = sendtool;
        }

        public void Greet(string message)
        {
            greetTool.Send(message);
        }
    }
}
