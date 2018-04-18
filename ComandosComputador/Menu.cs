using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DesligaNaMarra
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executa evendo do click no btnSuspende do Formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuspende_Click(object sender, EventArgs e)
        {
            InformacaoDeStart Start = new InformacaoDeStart();
            try
            {
                Start.ExecutaComando("powercfg", "-h off");
                Start.ExecutaComando(Environment.GetEnvironmentVariable("SystemRoot") + "\\system32\\rundll32.exe", "powrprof.dll,SetSuspendState");
                Start.ExecutaComando("powercfg", "-h on");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString(), "Ocorreu um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Executa evendo do click no btnHiberna do Formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHiberna_Click(object sender, EventArgs e)
        {
            InformacaoDeStart Start = new InformacaoDeStart();
            try
            {
                Start.ExecutaComando("powercfg", "-h on");
                Start.ExecutaComando(Environment.GetEnvironmentVariable("SystemRoot") + "\\system32\\rundll32.exe", "powrprof.dll,SetSuspendState");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString(), "Ocorreu um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Executa evendo do click no btnBloqueia do Formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBloqueia_Click(object sender, EventArgs e)
        {
            InformacaoDeStart Start = new InformacaoDeStart();
            try
            {
                Start.ExecutaComando(Environment.GetEnvironmentVariable("SystemRoot") + "\\system32\\rundll32.exe", "user32.dll,LockWorkStation");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString(), "Ocorreu um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Executa evendo do click no btnReinicia do Formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReinicia_Click(object sender, EventArgs e)
        {
            InformacaoDeStart Start = new InformacaoDeStart();
            try
            {
                Start.ExecutaComando(Environment.GetEnvironmentVariable("SystemRoot") + "\\system32\\shutdown.exe", "-r -t 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString(), "Ocorreu um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Executa evendo do click no btnDesligar do Formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesligar_Click(object sender, EventArgs e)
        {
            InformacaoDeStart Start = new InformacaoDeStart();
            try
            {
                Start.ExecutaComando(Environment.GetEnvironmentVariable("SystemRoot") + "\\system32\\shutdown.exe", "-s -t 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString(), "Ocorreu um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
