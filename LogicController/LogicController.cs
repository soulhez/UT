using Core;
using GSN;
using MessageService;
using System;
using Telephone;
using UT.Email;
using Wechat;

namespace LogicController
{
    class LogicController
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------------------------------");
            string message = "新年快乐！ 过节费5000.";
            ISendable greetTool = SendToolFactory.GetInstance();
            GreetMessageService service = new GreetMessageService(greetTool);
            service.Greet(message);
            Console.WriteLine("\n----------------------------------");
            Console.ReadKey();
        }
    }
}
