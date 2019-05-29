using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AdminService
{
    /// <summary>
    /// Summary description for AdminService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AdminService : System.Web.Services.WebService
    {

        LicenciaturaDBEntities1 lic = new LicenciaturaDBEntities1();// conexao a tabela de licenciatura
        MestradoDBEntities1 mest = new MestradoDBEntities1();// conexao a tabela de mestrado
        DoutoramentoDBEntities doc = new DoutoramentoDBEntities();// conexao a tabela de doutoramento

        [WebMethod]
        public List<Main> getAlunosL()
        {
            var studentList = lic.Mains.SqlQuery("Select * from Main").ToList<Main>();// query simples para conseguir info de alunos de licenciatura
            return studentList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasL()
        {
            var cadeiraList = lic.Cadeiras.SqlQuery("Select * from Cadeiras").ToList<Cadeira>();// query simples para conseguir info de cadeiras de licenciatura
            return cadeiraList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasAlunoL(int numero)
        {
            using (LicenciaturaDBEntities1 objDataContext = new LicenciaturaDBEntities1())// query simples para conseguir info de cadeiras de um aluno de licenciatura usando o seu numero
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
            using (LicenciaturaDBEntities1 objDataContext = new LicenciaturaDBEntities1())
            {
                Main objAluno = new Main();
                // campos a preencher para o insert
                objAluno.Nome = nome;
                objAluno.NumeroAluno = numero;

                objDataContext.Mains.Add(objAluno);
                //executa o comando e faz as alteracoes a base de dados 

                return objDataContext.SaveChanges();

            };
        }

        [WebMethod]
        public int addCadeiraL(string nomeCadeira, int numero, int notaFinal, int numCadeira)
        {
            using (LicenciaturaDBEntities1 objDataContext = new LicenciaturaDBEntities1())
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
            var studentList = mest.Mains.SqlQuery("Select * from Main").ToList<Main>();// query simples para conseguir info de alunos de mestrado
            return studentList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasM()
        {
            var cadeiraList = mest.Cadeiras.SqlQuery("Select * from Cadeiras").ToList<Cadeira>();// query simples para conseguir info de cadeiras de mestrado
            return cadeiraList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasAlunoM(int numero)
        {
            using (MestradoDBEntities1 objDataContext = new MestradoDBEntities1())
            {
                var result = from c in objDataContext.Cadeiras // query simples para conseguir info de cadeiras de um aluno de mestrado usando o seu numero
                             where c.NumeroAluno == numero
                             select c;

                List<Cadeira> lstEmployee = result.ToList();
                return lstEmployee;
            };
        }

        [WebMethod]
        public int addAlunoM(string nome, int numero)
        {
            using (MestradoDBEntities1 objDataContext = new MestradoDBEntities1())
            {
                Main objAluno = new Main();
                // campos a preencher para o insert
                objAluno.Nome = nome;
                objAluno.NumeroAluno = numero;

                objDataContext.Mains.Add(objAluno);
                //executa o comando e faz as alteracoes a base de dados 

                return objDataContext.SaveChanges();

            };
        }

        [WebMethod]
        public int addCadeiraM(string nomeCadeira, int numero, int notaFinal, int numCadeira)
        {
            using (MestradoDBEntities1 objDataContext = new MestradoDBEntities1())
            {
                Cadeira objCadeira = new Cadeira();
                // campos a preencher para o insert
                objCadeira.NomeCadeira = nomeCadeira;
                objCadeira.NumeroAluno = numero;
                objCadeira.NotaFinal = notaFinal;
                objCadeira.CodCadeira = numCadeira;

                objDataContext.Cadeiras.Add(objCadeira);
                //executa o comando e faz as alteracoes a base de dados 
                return objDataContext.SaveChanges();


            };
        }


        [WebMethod]
        public List<Main> getAlunosD()
        {
            var studentList = doc.Mains.SqlQuery("Select * from Main").ToList<Main>();// query simples para conseguir info de alunos de mestrado
            return studentList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasD()
        {
            var cadeiraList = doc.Cadeiras.SqlQuery("Select * from Cadeiras").ToList<Cadeira>();// query simples para conseguir info de cadeiras de doutoramento
            return cadeiraList;
        }

        [WebMethod]
        public List<Cadeira> getCadeirasAlunoD(int numero)
        {
            using (DoutoramentoDBEntities objDataContext = new DoutoramentoDBEntities())
            {
                var result = from c in objDataContext.Cadeiras // query simples para conseguir info de cadeiras de um aluno de doutoramento usando o seu numero
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
                // campos a preencher para o insert
                objAluno.Nome = nome;
                objAluno.NumeroAluno = numero;

                objDataContext.Mains.Add(objAluno);
                //executa o comando e faz as alteracoes a base de dados

                return objDataContext.SaveChanges();

            };
        }

        [WebMethod]
        public int addCadeiraD(string nomeCadeira, int numero, int notaFinal, int numCadeira)
        {
            using (DoutoramentoDBEntities objDataContext = new DoutoramentoDBEntities())
            {
                Cadeira objCadeira = new Cadeira();
                // campos a preencher para o insert
                objCadeira.NomeCadeira = nomeCadeira;
                objCadeira.NumeroAluno = numero;
                objCadeira.NotaFinal = notaFinal;
                objCadeira.CodCadeira = numCadeira;

                objDataContext.Cadeiras.Add(objCadeira);
                //executa o comando e faz as alteracoes a base de dados
                return objDataContext.SaveChanges();


            };
        }
    }
}
