﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogginginAspDOTNET.Service
{
    public class UserNLog
    {
        public void DoneWork(ILogger logger = null)
        {
            try
            {
                var data = "hello";
                logger.Info("hello from function");
                throw new Exception("hello");
            }
            catch (Exception ex)
            {
                throw new Exception("there is an error");
                //logger.Error(ex);
            }

        }
        // Chnage Branch code ..
        public void ChangeData()
        {
            Console.WriteLine("this is change data");
            // here we will create one branch changeService.
        }
        

        public void ImplementLOg()
        {
            Console.WriteLine("this is implement log ");
        }

        public void ChangeService()
        {
            Console.WriteLine("this is change service");
        }
    }
}