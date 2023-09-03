using LogginginAspDOTNET.Service;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LogginginAspDOTNET.Controllers
{
    [RoutePrefix("students")]
    public class ValuesController : ApiController
    {
        // GET api/values
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        [HttpGet]
        [Route("tech/student")]
        public IEnumerable<string> Get()
        {
            logger.Info("\n-------------Logging Started----------\n");
            try
            {
                UserNLog usenlog = new UserNLog();
                usenlog.DoneWork(logger);
                logger.Info("Hell You have visited the Index view" + Environment.UserName + Environment.MachineName);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                logger.Info("\n----------logging end--------------\n");
            }
            return new string[] { "value1", "value2" };
        }


    }
}
