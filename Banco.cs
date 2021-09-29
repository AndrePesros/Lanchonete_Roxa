using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace Sistemalanchonete
{
    class Banco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public Banco() { }

        public Banco(int id, string nome, string telefone, string senha)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Senha = senha;
        }

        

        public bool SalvarDados(List<Banco> lista, string path)
        {
            var strJson = JsonConvert.SerializeObject(lista, Formatting.Indented);
            return SalvarArquivo(strJson, path);
        }

        public static Banco ListarClient(string path)
        {
            var strJson = OpenFileCliente(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<Banco>(strJson);
            }
            else
            {
                var cliente = new Banco();
                cliente.Nome = strJson;
                return cliente;
            }
        }

        public static List<Banco> carregarCliente(string path)
        {
            var strJson = OpenFileCliente(path);
            if (strJson.Substring(0, 5) != "Falha")
            {
                return JsonConvert.DeserializeObject<List<Banco>>(strJson);
            }
            else
            {
                var listClientes = new List<Banco>();
                var dados = new Banco();
                dados.Nome = strJson;
                listClientes.Add(dados);
                dados.Nome = strJson;
                return listClientes;
            }
        }

        private bool SalvarArquivo(string strJson, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(strJson);
                }

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha", ex.Message);
            }

            return false;
        }

        private static string OpenFileCliente(string path)
        {
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(path))
                {
                    strJson = sr.ReadToEnd();
                }

                return strJson;
            }
            catch (Exception ex)
            {

                return "Falha" + ex.Message;
            }
        }

    }


}

