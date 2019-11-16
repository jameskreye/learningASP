using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservice.asmx
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Name = "Guru99 Web Service")]
    public class TutorialService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetTutorialService(int TutoriallD)
        {
            string TutorialName = "Web Services";
            return TutorialName;
        }
    }
}
