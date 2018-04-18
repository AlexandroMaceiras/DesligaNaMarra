using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DesligaNaMarra
{
    public class InformacaoDeStart
    {
        /// <summary>
        /// Com os parâmetros informados executa Comandos ou Aplicações em DOS.
        /// </summary>
        /// <param name="nome">Nome do Comando ou Aplicação</param>
        /// <param name="parametros"></param>
        public void ExecutaComando(string nome, string parametros)
        {
            // Usando o StartInfo pra informar parâmetros do command antes de executar o comando.
            ProcessStartInfo startInfo = new ProcessStartInfo();

            try
            {
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = nome;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = parametros;

                //// Inicia O processo especificado assima.
                //// Chama WaitForExit executa esperando o final.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
