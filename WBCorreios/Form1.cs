using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBCorreios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtBuscar_Click_1(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(TbCep.Text);
                    TbEndereco.Text = resultado.end;
                    complemento.Text = resultado.complemento2;
                    TbComplemento2.Text = resultado.complemento2;
                    TbCidade.Text = resultado.cidade;
                    TbBairro.Text = resultado.bairro;
                    TbEstado.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        //        Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click


        //            Using WS = New WSCorreios.AtendeClienteClient()
        //                Try


        //                    Dim Resultado = WS.consultaCEP(TbCEP.Text)


        //                    TbEndereco.Text = Resultado.[end]


        //                    TbComplemento.Text = Resultado.complemento


        //                    TbComplemento2.Text = Resultado.complemento2


        //                    TbCidade.Text = Resultado.cidade


        //                    TbBairro.Text = Resultado.bairro


        //                    TbEstado.Text = Resultado.uf


        //                Catch Ex As Exception


        //                    MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        //        End Try
        //    End Using
        //End Sub

    }
}
