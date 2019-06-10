using Core;
using System;

namespace Wechat
{
    public class WechatHelper : ISendable
    {
        public void Send(string message)
        {
            Console.WriteLine("Frome wechat: " + message);
        }
    }
}
