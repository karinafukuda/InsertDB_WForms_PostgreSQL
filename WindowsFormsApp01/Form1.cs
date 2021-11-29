using System;
using System.Windows.Forms;
using Npgsql;


namespace WindowsFormsApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = Conexao.Abrir();
            cmd.CommandText = "insert into cargo ( nome, usuario_alteracao, ativo) values ('" + Cargo.Text + "','" + UsuarioAlteracao.Text + "','" + CheckBox.Checked + "')";
            cmd.ExecuteNonQuery(); //grava registros na tela
            cmd.Connection.Close();
            MessageBox.Show("Cargo " + Cargo.Text + " cadastrado com sucesso!");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
                CheckBox.Checked = true;
        }

    }
}
