﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.restcomm.connect.sdk.dotnet;

namespace SMSExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Login 
            Account akount = new Account("your sid here", "your authtoken here", "https://cloud.restcomm.com/restcomm/2012-04-24/");
            var SMSlist=akount.GetSMSList().Search();
            foreach(SMS sms in SMSlist)
            {
                Console.WriteLine(sms.Properties.body);
            }
            akount.SendSMS("from", "to", "Test Message").send();
            Console.ReadLine();
        }
    }
}