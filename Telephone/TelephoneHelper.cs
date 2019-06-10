using System;
using Core;

namespace Telephone
{
    public class TelephoneHelper : ISendable
    {
        public void Send(string message)
        {
            Console.Write("Frome telephone: " + message);
        }
    }
}
