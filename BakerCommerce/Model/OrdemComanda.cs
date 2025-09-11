using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerCommerce.Model
{
    internal class OrdemComanda
    {
        public int Id { get; set; }
        public int IdFicha { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public int IdResp { get; set; }
        public DateTime DataAdic {get; set; }
        public bool Situacao { get; set; }


        // Listar (SELECT na view_ficha)3
        public DataTable Listar()
        {
            string comando = "SELECT * FROM viw_fichas";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;


            
        }

        // Cadastrar (insert na ordens_comandas)
        public bool Cadastrar()
        {

            string comando = "INSERT INTO ordens_comandas (id_ficha, id_produto, quantidade, id_resp) VALUES " +
                "(@id_ficha, @id_produto, @quantidade, @id_resp)";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@id_ficha", IdFicha);
            cmd.Parameters.AddWithValue("@id_produto", IdProduto);
            cmd.Parameters.AddWithValue("@quantidade", Quantidade);
            cmd.Parameters.AddWithValue("@id_resp", IdResp);
            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {

                    conexaoBD.Desconectar(con);
                    return false;

                }

                else
                {
                    conexaoBD.Desconectar(con);
                    return true;

                }

            }
            catch
            {

                conexaoBD.Desconectar(con);
                return false;

            }
        }
    }
}      
