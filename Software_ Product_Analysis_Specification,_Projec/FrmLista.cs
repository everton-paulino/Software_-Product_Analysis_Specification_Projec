using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software__Product_Analysis_Specification__Projec
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = new Lista();

            lista.InicioCurso = "01/03/2024";
            lista.FimCurso = "02/03/2024";
            lista.TemadoCurso = "NR 05 - CIPA";
            lista.RazaoSocial = "Acácio ME";
            lista.NomeFuncionario = "João Batista da Silva";
            lista.CPFFuncionario = "236.369.369.89";
            lista.Ocupacao = "Ajudante Geral";
            lista.NomeInstrutor = "Sebastião Maia";
            lista.DocumentoInstrutor = "05848-SP";
            lista.TipoDocumentoInstrutor = "CREA";

            var collectionListas = Conn.AbrirColecaoListas();

            collectionListas.InsertOne(lista);

        }
    }
}
