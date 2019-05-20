using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AdminServiceBackup
{
    /// <summary>
    /// Summary description for AdminServiceBackup
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AdminServiceBackup : System.Web.Services.WebService
    {

        LicenciaturaDBEntities lic = new LicenciaturaDBEntities();
        MestradoDBEntities mest = new MestradoDBEntities();
        DoutoramentoDBEntities doc = new DoutoramentoDBEntities();

        [WebMethod]
        public List<Main> getAlunosL()
        {
            var studentList = lic.Mains.SqlQuery("Select * from Main").ToList<Main>();
            return studentList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasL()
        {
            var cadeiraList = lic.Cadeiras.SqlQuery("Select * from Cadeiras").ToList<Cadeira>();
            return cadeiraList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasAlunoL(int numero)
        {
            using (LicenciaturaDBEntities objDataContext = new LicenciaturaDBEntities())
            {
                var result = from c in objDataContext.Cadeiras
                             where c.NumeroAluno == numero
                             select c;

                List<Cadeira> lstEmployee = result.ToList();
                return lstEmployee;
            };
        }

        [WebMethod]
        public int addAlunoL(string nome, int numero)
        {
            using (LicenciaturaDBEntities objDataContext = new LicenciaturaDBEntities())
            {
                Main objAluno = new Main();
                // fields to be insert
                objAluno.Nome = nome;
                objAluno.NumeroAluno = numero;

                objDataContext.Mains.Add(objAluno);
                // executes the commands to implement the changes to the database

                return objDataContext.SaveChanges();

            };
        }

        [WebMethod]
        public int addCadeiraL(string nomeCadeira, int numero, int notaFinal, int numCadeira)
        {
            using (LicenciaturaDBEntities objDataContext = new LicenciaturaDBEntities())
            {
                Cadeira objCadeira = new Cadeira();
                // fields to be insert
                objCadeira.NomeCadeira = nomeCadeira;
                objCadeira.NumeroAluno = numero;
                objCadeira.NotaFinal = notaFinal;
                objCadeira.CodCadeira = numCadeira;

                objDataContext.Cadeiras.Add(objCadeira);
                // executes the commands to implement the changes to the database
                return objDataContext.SaveChanges();


            };
        }


        [WebMethod]
        public List<Main> getAlunosM()
        {
            var studentList = mest.Mains.SqlQuery("Select * from Main").ToList<Main>();
            return studentList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasM()
        {
            var cadeiraList = mest.Cadeiras.SqlQuery("Select * from Cadeiras").ToList<Cadeira>();
            return cadeiraList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasAlunoM(int numero)
        {
            using (MestradoDBEntities objDataContext = new MestradoDBEntities())
            {
                var result = from c in objDataContext.Cadeiras
                             where c.NumeroAluno == numero
                             select c;

                List<Cadeira> lstEmployee = result.ToList();
                return lstEmployee;
            };
        }

        [WebMethod]
        public int addAlunoM(string nome, int numero)
        {
            using (MestradoDBEntities objDataContext = new MestradoDBEntities())
            {
                Main objAluno = new Main();
                // fields to be insert
                objAluno.Nome = nome;
                objAluno.NumeroAluno = numero;

                objDataContext.Mains.Add(objAluno);
                // executes the commands to implement the changes to the database

                return objDataContext.SaveChanges();

            };
        }

        [WebMethod]
        public int addCadeiraM(string nomeCadeira, int numero, int notaFinal, int numCadeira)
        {
            using (MestradoDBEntities objDataContext = new MestradoDBEntities())
            {
                Cadeira objCadeira = new Cadeira();
                // fields to be insert
                objCadeira.NomeCadeira = nomeCadeira;
                objCadeira.NumeroAluno = numero;
                objCadeira.NotaFinal = notaFinal;
                objCadeira.CodCadeira = numCadeira;

                objDataContext.Cadeiras.Add(objCadeira);
                // executes the commands to implement the changes to the database
                return objDataContext.SaveChanges();


            };
        }


        [WebMethod]
        public List<Main> getAlunosD()
        {
            var studentList = doc.Mains.SqlQuery("Select * from Main").ToList<Main>();
            return studentList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasD()
        {
            var cadeiraList = doc.Cadeiras.SqlQuery("Select * from Cadeiras").ToList<Cadeira>();
            return cadeiraList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasAlunoD(int numero)
        {
            using (DoutoramentoDBEntities objDataContext = new DoutoramentoDBEntities())
            {
                var result = from c in objDataContext.Cadeiras
                             where c.NumeroAluno == numero
                             select c;

                List<Cadeira> lstEmployee = result.ToList();
                return lstEmployee;
            };
        }

        [WebMethod]
        public int addAlunoD(string nome, int numero)
        {
            using (DoutoramentoDBEntities objDataContext = new DoutoramentoDBEntities())
            {
                Main objAluno = new Main();
                // fields to be insert
                objAluno.Nome = nome;
                objAluno.NumeroAluno = numero;

                objDataContext.Mains.Add(objAluno);
                // executes the commands to implement the changes to the database

                return objDataContext.SaveChanges();

            };
        }

        [WebMethod]
        public int addCadeiraD(string nomeCadeira, int numero, int notaFinal, int numCadeira)
        {
            using (DoutoramentoDBEntities objDataContext = new DoutoramentoDBEntities())
            {
                Cadeira objCadeira = new Cadeira();
                // fields to be insert
                objCadeira.NomeCadeira = nomeCadeira;
                objCadeira.NumeroAluno = numero;
                objCadeira.NotaFinal = notaFinal;
                objCadeira.CodCadeira = numCadeira;

                objDataContext.Cadeiras.Add(objCadeira);
                // executes the commands to implement the changes to the database
                return objDataContext.SaveChanges();


            };
        }
    }
}
