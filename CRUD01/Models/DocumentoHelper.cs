using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CRUD01.Models {
    public class DocumentoHelper {
        
        private string _ligacaoBD = "";

        public DocumentoHelper(string strConexao) {
            _ligacaoBD = strConexao;
        }


        public List<Documento> getList() {
            DataTable dtDocumentos = new DataTable();
            List<Documento> listaSaida = new List<Documento>();
            SqlDataAdapter telefone = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();
            SqlConnection conexao = new SqlConnection(_ligacaoBD);
            telefone.SelectCommand = comando;
            string sqlInstrucao = "	SELECT tblDocumento.uid, uidTipo, tblAuxTipoDocumento.designacao AS [nomeTipo], " +
                                   " tblDocumento.designacao, dtPublicacao, estado " + 
                                   " FROM tblDocumento INNER JOIN tblAuxTipoDocumento ON " +
                                   " tblDocumento.uidTipo = tblAuxTipoDocumento.uid";
            comando.CommandText = sqlInstrucao;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexao;
            telefone.Fill(dtDocumentos);
            conexao.Close();
            conexao.Dispose();
            foreach (DataRow linha in dtDocumentos.Rows) {
                Documento l = new Documento();
                l.uid = Guid.Parse(linha["uid"].ToString());
                l.uidTipo = Guid.Parse(linha["uidTipo"].ToString());
                l.designacao = linha["designacao"].ToString();
                l.dtPublicacao = Convert.ToDateTime(linha["dtPublicacao"]);
                l.estado = Convert.ToByte(linha["estado"]);
                l.lstNomeTipoDocumento = linha["nomeTipo"].ToString();
                listaSaida.Add(l);
            }
            return listaSaida;
        }
    }
}
