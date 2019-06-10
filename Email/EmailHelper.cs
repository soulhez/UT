using System;
using Core;

namespace UT.Email
{
    public class EmailHelper : ISendable
    {
        public void Send(string message)
        {
            Console.Write("Frome email: " + message);
        }
    }
}
