using Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class FornecedorRepository
    {
        public string Insert(Fornecedor fornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                MySqlCommand SqlCmd = new MySqlCommand
                {
                    Connection = Connection.SqlCon,
                    CommandText = "INSERT INTO fornecedor (tipoPessoa, cpf_cnpj, razao_social, rua, numero, bairro, cidade, complemento, cep, telefone, celular, email, nome) VALUES (@pTipoPessoa, @pCpf_cnpj, @pRazao_social, @pRua, @pNumero, @pBairro, @pCidade, @pComplemento, @pCep, @pTelefone,@pCelular, @pEmail) ",
                    CommandType = CommandType.Text
                };
                SqlCmd.Parameters.AddWithValue("pNome", fornecedor.Nome);
                SqlCmd.Parameters.AddWithValue("pEmail", fornecedor.Email);
                SqlCmd.Parameters.AddWithValue("pTipoPessoa", fornecedor.tipoPessoa);
                SqlCmd.Parameters.AddWithValue("pCpf_cnpj", fornecedor.cpf_cnpj);
                SqlCmd.Parameters.AddWithValue("pRazao_social", fornecedor.razaoSocial);
                SqlCmd.Parameters.AddWithValue("pRua", fornecedor.rua);
                SqlCmd.Parameters.AddWithValue("pNumero", fornecedor.numero);
                SqlCmd.Parameters.AddWithValue("pBairro", fornecedor.bairro);
                SqlCmd.Parameters.AddWithValue("pCidade", fornecedor.cidade);
                SqlCmd.Parameters.AddWithValue("pComplemento", fornecedor.complemento);
                SqlCmd.Parameters.AddWithValue("pCep", fornecedor.cep);
                SqlCmd.Parameters.AddWithValue("pTelefone", fornecedor.telefone);
                SqlCmd.Parameters.AddWithValue("pCelular", fornecedor.celular);
               

                //executa o stored procedure
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }

            return resp;
        }

        public string Update(Fornecedor fornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("UPDATE fornecedor SET " +
                                    " email = @pEmail, tipoPessoa = @pTipoPessoa, cpf_cnpj = @pcpf_cnpj, razao_social= @pRazao_social, rua = @pRua, numero = @pNumero, bairro = @pBairro, cidade = @pCidade, complemento = @pComplemento, cep = @pCep, telefone = @pTelefone, celular = @pCelular, email = @pEmail, nome = @pNome " + 
                                    "WHERE id = @pId ");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pNome", fornecedor.Nome);
                SqlCmd.Parameters.AddWithValue("pEmail", fornecedor.Email);
                SqlCmd.Parameters.AddWithValue("pTipoPessoa", fornecedor.tipoPessoa);
                SqlCmd.Parameters.AddWithValue("pCpf_cnpj", fornecedor.cpf_cnpj);
                SqlCmd.Parameters.AddWithValue("pRazao_social", fornecedor.razaoSocial);
                SqlCmd.Parameters.AddWithValue("pRua", fornecedor.rua);
                SqlCmd.Parameters.AddWithValue("pNumero", fornecedor.numero);
                SqlCmd.Parameters.AddWithValue("pBairro", fornecedor.bairro);
                SqlCmd.Parameters.AddWithValue("pCidade", fornecedor.cidade);
                SqlCmd.Parameters.AddWithValue("pComplemento", fornecedor.complemento);
                SqlCmd.Parameters.AddWithValue("pCep", fornecedor.cep);
                SqlCmd.Parameters.AddWithValue("pTelefone", fornecedor.telefone);
                SqlCmd.Parameters.AddWithValue("pCelular", fornecedor.celular);

                //executa o stored procedure
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;
        }

        public string Remove(int idFornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("DELETE FROM fornecedor " +
                                    "WHERE id = @pId ");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pId", idFornecedor);

                //executa o stored procedure
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;
        }

        public DataTable getAll()
        {
            DataTable DtResultado = new DataTable("fornecedor");
            try
            {
                Connection.getConnection();
                String sqlSelect = "select * from fornecedor";

                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = Connection.SqlCon;
                SqlCmd.CommandText = sqlSelect;
                SqlCmd.CommandType = CommandType.Text;
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable filterByName(string pNome)
        {
            DataTable DtResultado = new DataTable("fornecedor");
            string selectSql;
            try
            {
                Connection.getConnection();
                if (!string.IsNullOrEmpty(pNome))
                {
                    selectSql = String.Format("SELECT * FROM fornecedor WHERE nome LIKE @pNome");
                    pNome = '%' + pNome + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM fornecedor");
                }
                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Connection.SqlCon);
                if (!string.IsNullOrEmpty(pNome))
                    SqlCmd.Parameters.AddWithValue("pNome", pNome);
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

    }
}


