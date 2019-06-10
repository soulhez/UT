
using Core;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace LogicController
{
    public abstract class SendToolFactory
    {
        public static ISendable GetInstance()
        {
            try
            {
                Assembly assembly = Assembly.LoadFile(GetAssembly());
                ISendable sender = assembly.CreateInstance(GetObjectType()) as ISendable;
                return sender;
            }
            catch (Exception ex)
            {
                Console.WriteLine("程序运行失误！错误信息为：{0}", ex);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key != null)
                {
                    Environment.Exit(0);
                }
                return null;
            }
        }

        private static string GetAssembly()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigurationManager.AppSettings["Assembly"]);
        }

        private static string GetObjectType()
        {
            return ConfigurationManager.AppSettings["Type"];
        }
    }
}
