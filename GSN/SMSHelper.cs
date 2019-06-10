using Core;
using System;

namespace GSN
{
    public class SMSHelper : ISendable
    {
        public void Send(string message)
        {
            Console.WriteLine("Frome SMS: " + message);
        }
    }
}
