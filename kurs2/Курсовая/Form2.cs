using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style; 


namespace Курсовая
{
	public partial class Form2 : MaterialForm
	{
		bool Поиск = false;
		bool редактировать = false;

		public Form2()
		{
			InitializeComponent();
			MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
		
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme
				(
				Primary.Amber600,
				Primary.Grey800,
				Primary.Amber900,
				Accent.LightGreen400,
				TextShade.BLACK
				);

		}

		private void Form2_Load(object sender, EventArgs e)
		{
            /*// TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Товары_на_складе". При необходимости она может быть перемещена или удалена.
            this.товары_на_складеTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Товары_на_складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Склады". При необходимости она может быть перемещена или удалена.
            this.складыTableAdapter1.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Склады);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ip521_11_Ivakov_Курсовая1DataSet.Категории_товаров". При необходимости она может быть перемещена или удалена.
            this.категории_товаровTableAdapter.Fill(this._ip521_11_Ivakov_Курсовая1DataSet.Категории_товаров);
           */
			Size = new Size(774, 487);
			groupBox3.Visible = false;

			if (Form1.Who == "Работник")
			{
				
				this.Text = "БД Работник";
				tabControl2.Visible = true;
				
				

				
				dataGridView6.Visible = false;
				dataGridView7.Visible = false;
				
				toolStripButton5.Visible = false;
				
			}
			else
			if (Form1.Who == "Администратор")
			{
				//tabControl1.Visible = true;
				//tabControl2.Visible = false;
				this.Text = "БД Администратор";
				label1.Visible = false;
				label2.Visible = false;
                tabControl1.Visible = true;


            }
			
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			Form1 a = new Form1();
			a.Show();
			Hide();

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//клиентыBindingSource.AddNew();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			категориитоваровBindingSource.EndEdit();
			категории_товаровTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

           
            товарыBindingSource.EndEdit();
			товарыTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			поставкиBindingSource.EndEdit();
			поставкиTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			складыBindingSource1.EndEdit();
			складыTableAdapter1.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			товарынаскладеBindingSource.EndEdit();
			товары_на_складеTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			поставщикиBindingSource.EndEdit();
			поставщикиTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			this.Validate();
			this.категориитоваровBindingSource.EndEdit();
			this.категории_товаровTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Категории_товаров);

			this.Validate();
			this.товарыBindingSource.EndEdit();
			this.товарыTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Товары);

			this.Validate();
			this.поставкиBindingSource.EndEdit();
			this.поставкиTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Поставки);

			this.Validate();
			this.складыBindingSource1.EndEdit();
			this.складыTableAdapter1.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Склады);

			this.Validate();
			this.товарынаскладеBindingSource.EndEdit();
			this.товары_на_складеTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Товары_на_складе);

			this.Validate();
			this.поставщикиBindingSource.EndEdit();
			this.поставщикиTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Поставщики);


		}
		private void tabPage3_Click(object sender, EventArgs e)
		{
			
		}

		private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
            string columnName = textBox1.Text;
            string filterValue = textBox2.Text;
            string a = comboBox1.Text;
			if (radioButton3.Checked == true)
			{

				switch (a)
				{
                    case "Категории_товаров":
                        категориитоваровBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                        break;
                    case "Товары":
                        товарыBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                        break;
                    case "Поставки":
                        поставкиBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                        break;
                    case "Склады":
                        складыBindingSource1.Filter = GetFilterExpression(columnName, filterValue);
                        break;
                    case "Товары_на_складе":
                        товарынаскладеBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                        break;
                    case "Поставщики":
                        поставщикиBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                        break;
                    default:
                        MessageBox.Show("Таблица не найдена", "Ошибка");
                        break;
                }
			}
			else
			{

				if (radioButton2.Checked == false)
				{
					switch (a)
					{
                        case "Категории_товаров":
                            категориитоваровBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Товары":
                            товарыBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Поставки":
                            поставкиBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Склады":
                            складыBindingSource1.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Товары_на_складе":
                            товарынаскладеBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Поставщики":
                            поставщикиBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        default:
                            MessageBox.Show("Таблица не найдена", "Ошибка");
                            break;
                    }



				}
				else
				{
					switch (a)
					{
                        case "Категории_товаров":
                            категориитоваровBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Товары":
                            товарыBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Поставки":
                            поставкиBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Склады":
                            складыBindingSource1.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Товары_на_складе":
                            товарынаскладеBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        case "Поставщики":
                            поставщикиBindingSource.Filter = GetFilterExpression(columnName, filterValue);
                            break;
                        default:
                            MessageBox.Show("Таблица не найдена", "Ошибка");
                            break;
                    }
				}
			}
		}
        private string GetFilterExpression(string columnName, string filterValue)
        {
            // Check if the filter value is numeric
            if (double.TryParse(filterValue, out _))
            {
                // If numeric, use different comparison
                return $"{columnName} = {filterValue}";
            }
            else
            {
                // If not numeric, use LIKE comparison
                return $"{columnName} LIKE '{filterValue}'";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
		{
			if (radioButton3.Checked == false)
			{
				groupBox2.Visible = true;
			}else groupBox2.Visible = false;

			if (Поиск == true & редактировать == true)
			{
				
				Size = new Size(774, 600);
				groupBox3.Visible = true;
				groupBox4.Visible = true;
			}
			else if (Поиск == true)
			{
				Size = new Size(734, 583);
				groupBox3.Size=new Size(622, 125);
				groupBox3.Visible = true;
				groupBox4.Visible = false;
			}

			else if (редактировать == true)
			{
				
				Size = new Size(774, 600);
				groupBox3.Visible = false;
				groupBox4.Visible = true;
			}
			else 
			{
				
				Size = new Size(774, 487);
				groupBox3.Visible = false;
				groupBox4.Visible = false;
			}
		}
        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
			if (Поиск == true)
			{
				Поиск = false;
			}
			else Поиск = true;
		}

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
			if (редактировать == true)
			{
				редактировать = false;
			}
			else редактировать = true;
		}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
			//fd
        }
		

        private void button3_Click_1(object sender, EventArgs e)
        {
			товарыBindingSource.Filter = string.Empty;
			категориитоваровBindingSource.Filter = string.Empty;
			складыBindingSource1.Filter = string.Empty;
			поставщикиBindingSource.Filter = string.Empty;
			товарынаскладеBindingSource.Filter = string.Empty;
			поставкиBindingSource.Filter = string.Empty;
			textBox1.Clear();
			textBox2.Clear();
		
			


		}

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
			
			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("Нет данных для экспорта.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Показываем диалог сохранения файла
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "xml файл (*.xml)|*.xml";
			saveFileDialog.Title = "Сохранить xml файл";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
                // Вызываем метод для экспорта в xml
                exportToExcel(dataGridView1, saveFileDialog.FileName);
				MessageBox.Show("Данные успешно экспортированы в xml!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}
        private void exportToExcel(DataGridView dataGridView, string filepath)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    for (int column = 0; column < dataGridView.ColumnCount; column++)
                    {
                        worksheet.Cells[1, column + 1].Value = dataGridView.Columns[column].HeaderText;
                    }

                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int column = 0; column < dataGridView.ColumnCount; column++)
                        {
                            worksheet.Cells[row + 2, column + 1].Value = dataGridView.Rows[row].Cells[column].Value;
                        }
                    }
                    using (ExcelRange range = worksheet.Cells[1, 1, dataGridView.Rows.Count + 1, dataGridView.ColumnCount])
                    {
                        range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        range.AutoFitColumns();
                    }
                    FileInfo excelFile = new FileInfo(filepath);
                    excelPackage.SaveAs(excelFile);
                }
            }
            catch
            {
                MessageBox.Show("При экспорте таблицы произошла ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
			
		}

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
			this.Validate();
			this.поставщикиBindingSource.EndEdit();
			this.поставщикиTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Поставщики);



		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void таблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
		
			
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void представленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
			категориитоваровBindingSource.EndEdit();
			категории_товаровTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);


			товарыBindingSource.EndEdit();
			товарыTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			поставкиBindingSource.EndEdit();
			поставкиTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			складыBindingSource1.EndEdit();
			складыTableAdapter1.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			товарынаскладеBindingSource.EndEdit();
			товары_на_складеTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			поставщикиBindingSource.EndEdit();
			поставщикиTableAdapter.Update(_ip521_11_Ivakov_Курсовая1DataSet);

			this.Validate();
			this.категориитоваровBindingSource.EndEdit();
			this.категории_товаровTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Категории_товаров);

			this.Validate();
			this.товарыBindingSource.EndEdit();
			this.товарыTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Товары);

			this.Validate();
			this.поставкиBindingSource.EndEdit();
			this.поставкиTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Поставки);

			this.Validate();
			this.складыBindingSource1.EndEdit();
			this.складыTableAdapter1.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Склады);

			this.Validate();
			this.товарынаскладеBindingSource.EndEdit();
			this.товары_на_складеTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Товары_на_складе);

			this.Validate();
			this.поставщикиBindingSource.EndEdit();
			this.поставщикиTableAdapter.Update(this._ip521_11_Ivakov_Курсовая1DataSet.Поставщики);
		}

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}

        private void экспортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void категориитоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
			
        }
    }
}
