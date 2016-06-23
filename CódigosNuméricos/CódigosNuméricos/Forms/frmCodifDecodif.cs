using CódigosNuméricos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CódigosNuméricos.Forms
{
    public partial class frmCodifDecodif : Form
    {
        public frmCodifDecodif()
        {
            InitializeComponent();
        }

        private void frmCodifDecodif_Load(object sender, EventArgs e)
        {
            rbtCodificar.Checked = true;
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            if (rbtBCD.Checked)
                resultadoBCD();
            else
            {
                if (rbtExcess.Checked)
                    resultadoExcess();
                else
                {
                    if (rbtAyken.Checked)
                        resultadoAyken();
                    else
                    {
                        if (rbtJohnson.Checked)
                            resultadoJohnson();
                        else
                        {
                            if (rbtGray.Checked)
                                resultadoGray();
                            else
                            {
                                if (rbtEntre.Checked)
                                    resultadoEntre();
                                else
                                {
                                    if (rbtKappa.Checked)
                                        resultadoKappa();
                                }
                            }
                        }
                    }
                }
            }

        }

        private void resultadoBCD()
        {
            BCD8421 bcd = new BCD8421();
            if (rbtCodificar.Checked)
                lblValor.Text = Function.codificar(txtValor.Text, bcd.dicValores);
            else
                lblValor.Text = Function.decodificar(txtValor.Text, bcd.dicValores, 4);
        }

        private void resultadoExcess()
        {
            Excess3 excess = new Excess3();
            if (rbtCodificar.Checked)
                lblValor.Text = Function.codificar(txtValor.Text, excess.dicValores);
            else
                lblValor.Text = Function.decodificar(txtValor.Text, excess.dicValores, 4);
        }

        private void resultadoAyken()
        {
            Ayken ayken = new Ayken();
            if (rbtCodificar.Checked)
                lblValor.Text = Function.codificar(txtValor.Text, ayken.dicValores);
            else
                lblValor.Text = Function.decodificar(txtValor.Text, ayken.dicValores, 4);
        }

        private void resultadoJohnson()
        {
            Johnson john = new Johnson();
            if (rbtCodificar.Checked)
                lblValor.Text = Function.codificar(txtValor.Text, john.dicValores);
            else
                lblValor.Text = Function.decodificar(txtValor.Text, john.dicValores, 5);
        }

        private void resultadoGray()
        {
            Gray gray = new Gray();
            if (rbtCodificar.Checked)
                lblValor.Text = Function.codificar(txtValor.Text, gray.dicValores);
            else
                lblValor.Text = Function.decodificar(txtValor.Text, gray.dicValores, 4);
        }

        private void resultadoKappa()
        {
            Kappa kappa = new Kappa();
            if (rbtCodificar.Checked)
                lblValor.Text = Function.codificar(txtValor.Text, kappa.dicValores);
            else
                lblValor.Text = Function.decodificar(txtValor.Text, kappa.dicValores, 5);
        }

        private void resultadoEntre()
        {
            Entre entre = new Entre();
            if (rbtCodificar.Checked)
                lblValor.Text = Function.codificar(txtValor.Text, entre.dicValores);
            else
                lblValor.Text = Function.decodificar(txtValor.Text, entre.dicValores, 5);
        }

        private void rbtCodificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodificar.Checked)
                lblTexto.Text = "Valor Codificado: ";
            else
            {
                lblTexto.Text = "Valor Decodificado: ";
            }
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }
    }
}
