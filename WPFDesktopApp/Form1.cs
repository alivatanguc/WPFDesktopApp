using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFDesktopApp
{
    public partial class Form1 : Form
    {
        public DataTable dt { get; set; }

        public Form1()
        {

            InitializeComponent();

        }
     


        //burda browser adlı butonun işlemleri var
        private void BtnBrowswer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse Text File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                Helper.file = textBox1.Text;
                dataGridView1.DataSource = Helper.DataTableFromTextFile(textBox1.Text);
            }
            //burda edit delete butonlarının tüm sütun boyunca var olmasını sağladım
            DataGridViewButtonColumn editbutton = new DataGridViewButtonColumn();
            editbutton.FlatStyle = FlatStyle.Popup;
            editbutton.HeaderText = "EDIT";
            editbutton.Name = "EDIT";
            editbutton.UseColumnTextForButtonValue = true;
            editbutton.Text = "EDIT";
            editbutton.Width = 45;
            dataGridView1.Columns.Add(editbutton);
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();
            deletebutton.FlatStyle = FlatStyle.Popup;
            deletebutton.HeaderText = "DELETE";
            deletebutton.Name = "DELETE";
            deletebutton.UseColumnTextForButtonValue = true;
            deletebutton.Text = "DELETE";
            deletebutton.Width = 45;
            dataGridView1.Columns.Add(deletebutton);

            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;


        }
        //burda edit ve delete butonlarına basıldıklatan sonra gelen mesajı tasarladım
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].HeaderText == "DELETE")
            {
                MessageBox.Show("Are you sure on delete");
                foreach(DataGridViewCell oneCell in dataGridView1.SelectedCells)
                {
                    if(oneCell.Selected)
                        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
                }
                MessageBox.Show("Removing is successfully");
            }
            if(dataGridView1.Columns[e.ColumnIndex].HeaderText == "EDIT")
            {
                MessageBox.Show("Are you sure on edit");
                for(int item = 0; item < dataGridView1.Rows.Count - 1; item++)
                {

                }
                MessageBox.Show("Updating  is successfully");
            }
        }
        private void UP_Click(object sender, EventArgs e)
        {

          

            DataGridView dgv = dataGridView1;
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataRow drToAdd = dataTable.NewRow();
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
            drToAdd.ItemArray = dataTable.Rows[rowIndex].ItemArray;
            if(dgv != null && dgv.SelectedRows.Count > 0)
            {
                dataTable.Rows.RemoveAt(rowIndex);
                dataTable.Rows.InsertAt(drToAdd, rowIndex - 1);
                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
           

          
           
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataRow drToAdd = dataTable.NewRow();
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
            drToAdd.ItemArray = dataTable.Rows[rowIndex].ItemArray;
            if(dgv != null && dgv.SelectedRows.Count > 0)
            {
                dataTable.Rows.RemoveAt(rowIndex);
                dataTable.Rows.InsertAt(drToAdd, rowIndex + 1);
                dgv.ClearSelection();
                dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
        }

        private void EXPORTJSON_Click(object sender, EventArgs e)
        {

          

            List<Model> JsonModel = new List<Model>();


            try
            {

                for(int r = 0; r <= dataGridView1.Rows.Count - 2; r++)
                {

                   

                    List<object> myObj = new List<object>();

                    for(int c = 0; c <= dataGridView1.Columns.Count - 3; c++)
                    {
                      
                        myObj.Add(dataGridView1.Rows[r].Cells[c].Value);


                    }

                    JsonModel.Add(new Model()
                    {
                        Id = myObj[0].ToString(),
                        Company = myObj[1].ToString(),
                        Department = myObj[2].ToString(),
                        Person = myObj[3].ToString(),

                    });


                    
                }



                var myJson = JsonConvert.SerializeObject(JsonModel);



                //var şlkjfsdlkş = JsonConvert.DeserializeObject<List<Model>>(myJson);



                File.WriteAllText(@"C:\Users\Profen\Desktop\fghng.json", myJson);
                MessageBox.Show("Text file convert to Json file");



            }
            catch
            {

            }
        }
        public string BeautiyJson(string dt)
        {
            JToken parseJson = JToken.Parse(dt);

            return parseJson.ToString(Formatting.Indented);
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            {
                
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Profen\Desktop\rr.txt");
                try
                {

                    for(int i = 0; i < dataGridView1.Columns.Count - 2; i++)
                    {
                        file.Write(dataGridView1.Columns[i].Name);
                        if(i != dataGridView1.Columns.Count - 3)
                        {

                            file.Write(",");
                        }
                    }


                    file.Write("\n");

                    string sLine = "";

                  

                    for(int r = 0; r <= dataGridView1.Rows.Count - 2; r++)
                    {
                        for(int c = 0; c <= dataGridView1.Columns.Count - 3; c++)
                        {
                            sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                            if(c != dataGridView1.Columns.Count - 3)
                            {

                                sLine = sLine + ","; 
                            }
                       

                        }
                        
                        file.WriteLine(sLine);
                       
                        sLine = "";
                    }
                    List<Model> JsonModel = new List<Model>();
                    

                  


                   

                    file.Close();
                    System.Windows.Forms.MessageBox.Show("SAVİNG  COMPLETE.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(System.Exception err)
                {
                    System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    file.Close();
                }
            }
        }


     
      
    }
}
 