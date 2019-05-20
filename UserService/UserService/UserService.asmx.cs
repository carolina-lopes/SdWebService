using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UserService
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {
        LicenciaturaDBEntities1 lic = new LicenciaturaDBEntities1();
        MestradoDBEntities mest = new MestradoDBEntities();
        DoutoramentoDBEntities doc = new DoutoramentoDBEntities();

        [WebMethod(EnableSession = true)]
        public List<Cadeira> getCadeiras(int num)
        {
            using (LicenciaturaDBEntities1 objDataContext = new LicenciaturaDBEntities1())
            {
                var result = from c in objDataContext.Cadeiras
                             where c.NumeroAluno == num
                             select c;

                List<Cadeira> lstEmployee = result.ToList();
                return lstEmployee;
            };

        }

        [WebMethod(EnableSession = true)]
        public Main getUser(string nome)
        {
            return lic.Mains.Single(x => x.Nome == nome);
        }

        [WebMethod(EnableSession = true)]
        public List<Cadeira> getCadeirasM(int num)
        {
            using (MestradoDBEntities objDataContext = new MestradoDBEntities())
            {
                var result = from c in objDataContext.Cadeiras
                             where c.NumeroAluno == num
                             select c;

                List<Cadeira> lstEmployee = result.ToList();
                return lstEmployee;
            };

        }

        [WebMethod(EnableSession = true)]
        public Main getUserM(string nome)
        {
            return mest.Mains.Single(x => x.Nome == nome);
        }


        [WebMethod(EnableSession = true)]
        public List<Cadeira> getCadeirasD(int num)
        {
            using(DoutoramentoDBEntities objDataContext = new DoutoramentoDBEntities())
            {
                var result = from c in objDataContext.Cadeiras
                             where c.NumeroAluno == num
                             select c;

                List<Cadeira> lstEmployee = result.ToList();
                return lstEmployee;
            };

        }

        [WebMethod(EnableSession = true)]
        public Main getUserD(string nome)
        {
            return doc.Mains.Single(x => x.Nome == nome);
        }
    }
}
