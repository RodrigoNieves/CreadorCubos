using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreaCubo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'karelotitlanUsuarioProblema.UsuarioProblema' table. You can move, or remove it, as needed.
           // this.usuarioProblemaTableAdapter.Fill(this.karelotitlanUsuarioProblema.UsuarioProblema);

        }
        String cadenaDeConexion ="Data Source=RODRIGOASUS-PC\\SQLEXPRESS;Initial Catalog=Karelotitlan;Integrated Security=True";
        //String cadenaDeConexion = "Data Source=CICPC;Initial Catalog=Karelotitlan;Integrated Security=True";
        String esquema = "Karelotitlan";
        List<String> TodosLosCampos;
        List<String> tipos;
        private void buttonObtenInfo_Click(object sender, EventArgs e)
        {
            DBConnection myDB = new DBConnection(cadenaDeConexion);
            myDB.connect();
            DataTable dt = myDB.ejecutaQuery(textBoxQuery.Text);
            dataGridViewQuery.DataSource = dt;
            tipos = new List<String>();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                switch (dt.Columns[i].DataType.ToString()) { 
                    case "System.Int32":
                        tipos.Add("int");
                        break;
                    case "System.Int64":
                        tipos.Add("bigint");
                        break;
                    case "System.String":
                        tipos.Add("varchar(500)");
                        break;
                    case "System.Byte[]":
                        tipos.Add("varbinary(50)");
                        break;
                    case "System.Int16":
                        tipos.Add("smallint");
                        break;
                    case "System.Boolean":
                        tipos.Add("bit");
                        break;
                    default:
                        MessageBox.Show("No encontrado " + dt.Columns[i].DataType.ToString());
                        tipos.Add("varchar(500)");
                        break;

                }
            }
            checkedListBoxColumna.Items.Clear();
            checkedListBoxResumen.Items.Clear();
            TodosLosCampos = new List<string>();
            foreach(DataGridViewColumn column  in dataGridViewQuery.Columns){
                checkedListBoxColumna.Items.Add(column.Name);
                checkedListBoxResumen.Items.Add(column.Name);
                TodosLosCampos.Add(column.Name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> campos = new List<String>();
            List<String> t = new List<String>();
            foreach (int check in checkedListBoxColumna.CheckedIndices)
            {
                
                campos.Add(checkedListBoxColumna.Items[check].ToString());
                t.Add(tipos[check].ToString());
            }
            tipoFuncion tf;
            switch(comboBox2.Text){
                case "Contador":
                    tf = tipoFuncion.cont;
                    break;
                case "Suma":
                    tf = tipoFuncion.suma;
                    break;
                case "Minimo":
                    tf = tipoFuncion.min;
                    break;
                case "Maximo":
                    tf = tipoFuncion.max;
                    break;
                case "Promedio":
                    tf = tipoFuncion.avg;
                    break;
                default:
                    MessageBox.Show("Operacion no valida");
                    tf = tipoFuncion.cont;
                    break;
            }
            String res;
            if (tf == tipoFuncion.cont)
            {
                res = "";
            }
            else
            {
                res = checkedListBoxResumen.CheckedItems[0].ToString();
            }
            CreadorDeCubos cc = new CreadorDeCubos(cadenaDeConexion, esquema, campos, t, tf, res, textBoxQuery.Text,tipos,TodosLosCampos);
            cc.creaTabla();
            cc.creaCubexeles();


            DBConnection myDB = new DBConnection(cadenaDeConexion);
            myDB.connect();
            DataTable dt = myDB.ejecutaQuery("select * from " + esquema+".dbo.cube");
            dataGridViewCubo.DataSource = dt;


            MessageBox.Show("Terminado");

        }
    }
}
