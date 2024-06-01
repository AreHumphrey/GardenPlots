using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GardenPlotsDB
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=GardenPlotsDB;Uid=root;Pwd=root_password;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDataGrids();
        }

        private void LoadComboBoxes()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Load СадовоеОбщество
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT код, название FROM СадовоеОбщество", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboBoxСадовоеОбщество.DataSource = table;
                comboBoxСадовоеОбщество.DisplayMember = "название";
                comboBoxСадовоеОбщество.ValueMember = "код";

                comboBoxУчасток.DataSource = table;
                comboBoxУчасток.DisplayMember = "название";
                comboBoxУчасток.ValueMember = "код";

                // Load ТипРельефа
                adapter = new MySqlDataAdapter("SELECT код, типРельефа FROM ТипРельефа", connection);
                table = new DataTable();
                adapter.Fill(table);
                comboBoxТипРельефа.DataSource = table;
                comboBoxТипРельефа.DisplayMember = "типРельефа";
                comboBoxТипРельефа.ValueMember = "код";

                // Load ТипПочвы
                adapter = new MySqlDataAdapter("SELECT код, типПочвы FROM ТипПочвы", connection);
                table = new DataTable();
                adapter.Fill(table);
                comboBoxТипПочвы.DataSource = table;
                comboBoxТипПочвы.DisplayMember = "типПочвы";
                comboBoxТипПочвы.ValueMember = "код";

                // Load ВладелецУчастка
                adapter = new MySqlDataAdapter("SELECT код, CONCAT(фамилия, ' ', имя) AS ФИО FROM ВладелецУчастка", connection);
                table = new DataTable();
                adapter.Fill(table);
                comboBoxВладелец.DataSource = table;
                comboBoxВладелец.DisplayMember = "ФИО";
                comboBoxВладелец.ValueMember = "код";
            }
        }

        private void LoadDataGrids()
        {
            LoadВладельцы();
            LoadСадовоеОбщество();
            LoadТипПочвы();
            LoadТипРельефа();
            LoadУчасток();
        }

        private void LoadВладельцы()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ВладелецУчастка", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewВладельцы.DataSource = table;
                comboBoxВладельцы.DataSource = table;
                comboBoxВладельцы.DisplayMember = "фамилия";
                comboBoxВладельцы.ValueMember = "код";
            }
        }

        private void LoadДоговоры(int владелецId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM Договор WHERE кодВладелецУчастка = {владелецId}", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewДоговоры.DataSource = table;
                comboBoxДоговоры.DataSource = table;
                comboBoxДоговоры.DisplayMember = "номерДоговора";
                comboBoxДоговоры.ValueMember = "номерДоговора";
            }
        }

        private void LoadПлатежи(int договорId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter($"SELECT * FROM Платеж WHERE кодДоговора = {договорId}", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewПлатежи.DataSource = table;
            }
        }

        private void LoadСадовоеОбщество()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM СадовоеОбщество", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewСадовоеОбщество.DataSource = table;
            }
        }

        private void LoadТипПочвы()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ТипПочвы", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewТипПочвы.DataSource = table;
            }
        }

        private void LoadТипРельефа()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ТипРельефа", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewТипРельефа.DataSource = table;
            }
        }

        private void LoadУчасток()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Участок", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewУчасток.DataSource = table;
            }
        }

        private void buttonSaveСадовоеОбщество_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO СадовоеОбщество (председатель, название) VALUES (@председатель, @название)", connection);
                command.Parameters.AddWithValue("@председатель", textBoxПредседатель.Text);
                command.Parameters.AddWithValue("@название", textBoxНазвание.Text);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Садовое общество сохранено!");
            LoadComboBoxes();
            LoadСадовоеОбщество();
        }

        private void buttonSaveТипРельефа_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO ТипРельефа (типРельефа) VALUES (@типРельефа)", connection);
                command.Parameters.AddWithValue("@типРельефа", textBoxТипРельефа.Text);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Тип рельефа сохранен!");
            LoadComboBoxes();
            LoadТипРельефа();
        }

        private void buttonSaveТипПочвы_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO ТипПочвы (типПочвы) VALUES (@типПочвы)", connection);
                command.Parameters.AddWithValue("@типПочвы", textBoxТипПочвы.Text);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Тип почвы сохранен!");
            LoadComboBoxes();
            LoadТипПочвы();
        }

        private void buttonSaveВладелецУчастка_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO ВладелецУчастка (фамилия, имя, адрес, номерТелефона) VALUES (@фамилия, @имя, @адрес, @номерТелефона)", connection);
                command.Parameters.AddWithValue("@фамилия", textBoxФамилия.Text);
                command.Parameters.AddWithValue("@имя", textBoxИмя.Text);
                command.Parameters.AddWithValue("@адрес", textBoxАдрес.Text);
                command.Parameters.AddWithValue("@номерТелефона", textBoxНомерТелефона.Text);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Владелец участка сохранен!");
            LoadComboBoxes();
            LoadВладельцы();
        }

        private void buttonSaveУчасток_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO Участок (площадь, статусУчастка, кодСадовоеОбщество, кодТипРельефа, кодТипПочвы) VALUES (@площадь, @статусУчастка, @кодСадовоеОбщество, @кодТипРельефа, @кодТипПочвы)", connection);
                command.Parameters.AddWithValue("@площадь", textBoxПлощадь.Text);
                command.Parameters.AddWithValue("@статусУчастка", comboBoxСтатусУчастка.Text);
                command.Parameters.AddWithValue("@кодСадовоеОбщество", comboBoxСадовоеОбщество.SelectedValue);
                command.Parameters.AddWithValue("@кодТипРельефа", comboBoxТипРельефа.SelectedValue);
                command.Parameters.AddWithValue("@кодТипПочвы", comboBoxТипПочвы.SelectedValue);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Участок сохранен!");
            LoadComboBoxes();
            LoadУчасток();
        }

        private void buttonSaveДоговор_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO Договор (датаНачала, датаОкончания, кодУчастка, кодВладелецУчастка) VALUES (@датаНачала, @датаОкончания, @кодУчастка, @кодВладелецУчастка)", connection);
                command.Parameters.AddWithValue("@датаНачала", dateTimePickerДатаНачала.Value);
                command.Parameters.AddWithValue("@датаОкончания", dateTimePickerДатаОкончания.Value);
                command.Parameters.AddWithValue("@кодУчастка", comboBoxУчасток.SelectedValue);
                command.Parameters.AddWithValue("@кодВладелецУчастка", comboBoxВладелец.SelectedValue);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Договор сохранен!");
            LoadComboBoxes();
            LoadДоговоры(Convert.ToInt32(comboBoxВладелец.SelectedValue));
        }

        private void buttonSaveПлатеж_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO Платеж (сумма, датаОплаты, кодДоговора) VALUES (@сумма, @датаОплаты, @кодДоговора)", connection);
                command.Parameters.AddWithValue("@сумма", textBoxСумма.Text);
                command.Parameters.AddWithValue("@датаОплаты", dateTimePickerДатаОплаты.Value);
                command.Parameters.AddWithValue("@кодДоговора", comboBoxДоговор.SelectedValue);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Платеж сохранен!");
            LoadComboBoxes();
            LoadПлатежи(Convert.ToInt32(comboBoxДоговор.SelectedValue));
        }

        private void dataGridViewВладельцы_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewВладельцы.SelectedRows.Count > 0)
            {
                int владелецId = Convert.ToInt32(dataGridViewВладельцы.SelectedRows[0].Cells["код"].Value);
                LoadДоговоры(владелецId);
            }
        }

        private void dataGridViewДоговоры_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewДоговоры.SelectedRows.Count > 0)
            {
                int договорId = Convert.ToInt32(dataGridViewДоговоры.SelectedRows[0].Cells["номерДоговора"].Value);
                LoadПлатежи(договорId);
            }
        }

        private void comboBoxВладельцы_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxВладельцы.SelectedItem is DataRowView dataRowView)
            {
                int владелецId = Convert.ToInt32(dataRowView["код"]);
                LoadДоговоры(владелецId);
            }
        }

        private void comboBoxДоговоры_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxДоговоры.SelectedItem is DataRowView dataRowView)
            {
                int договорId = Convert.ToInt32(dataRowView["номерДоговора"]);
                LoadПлатежи(договорId);
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = System.Drawing.Color.Gray;
                switch (textBox.Name)
                {
                    case "textBoxПредседатель":
                        textBox.Text = "Председатель";
                        break;
                    case "textBoxНазвание":
                        textBox.Text = "Название";
                        break;
                    case "textBoxТипРельефа":
                        textBox.Text = "Тип Рельефа";
                        break;
                    case "textBoxТипПочвы":
                        textBox.Text = "Тип Почвы";
                        break;
                    case "textBoxФамилия":
                        textBox.Text = "Фамилия";
                        break;
                    case "textBoxИмя":
                        textBox.Text = "Имя";
                        break;
                    case "textBoxАдрес":
                        textBox.Text = "Адрес";
                        break;
                    case "textBoxНомерТелефона":
                        textBox.Text = "Номер Телефона";
                        break;
                    case "textBoxПлощадь":
                        textBox.Text = "Площадь";
                        break;
                    case "textBoxСумма":
                        textBox.Text = "Сумма";
                        break;
                }
            }
        }

        private void dataGridViewВладельцы_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataGridViewRow row = dataGridViewВладельцы.Rows[e.RowIndex];
                    int код = Convert.ToInt32(row.Cells["код"].Value);
                    string фамилия = row.Cells["фамилия"].Value.ToString();
                    string имя = row.Cells["имя"].Value.ToString();
                    string адрес = row.Cells["адрес"].Value.ToString();
                    string номерТелефона = row.Cells["номерТелефона"].Value.ToString();
                    MySqlCommand command = new MySqlCommand("UPDATE ВладелецУчастка SET фамилия = @фамилия, имя = @имя, адрес = @адрес, номерТелефона = @номерТелефона WHERE код = @код", connection);
                    command.Parameters.AddWithValue("@код", код);
                    command.Parameters.AddWithValue("@фамилия", фамилия);
                    command.Parameters.AddWithValue("@имя", имя);
                    command.Parameters.AddWithValue("@адрес", адрес);
                    command.Parameters.AddWithValue("@номерТелефона", номерТелефона);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewДоговоры_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataGridViewRow row = dataGridViewДоговоры.Rows[e.RowIndex];
                    int номерДоговора = Convert.ToInt32(row.Cells["номерДоговора"].Value);
                    DateTime датаНачала = Convert.ToDateTime(row.Cells["датаНачала"].Value);
                    DateTime датаОкончания = Convert.ToDateTime(row.Cells["датаОкончания"].Value);
                    int кодУчастка = Convert.ToInt32(row.Cells["кодУчастка"].Value);
                    int кодВладелецУчастка = Convert.ToInt32(row.Cells["кодВладелецУчастка"].Value);
                    MySqlCommand command = new MySqlCommand("UPDATE Договор SET датаНачала = @датаНачала, датаОкончания = @датаОкончания, кодУчастка = @кодУчастка, кодВладелецУчастка = @кодВладелецУчастка WHERE номерДоговора = @номерДоговора", connection);
                    command.Parameters.AddWithValue("@номерДоговора", номерДоговора);
                    command.Parameters.AddWithValue("@датаНачала", датаНачала);
                    command.Parameters.AddWithValue("@датаОкончания", датаОкончания);
                    command.Parameters.AddWithValue("@кодУчастка", кодУчастка);
                    command.Parameters.AddWithValue("@кодВладелецУчастка", кодВладелецУчастка);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewПлатежи_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataGridViewRow row = dataGridViewПлатежи.Rows[e.RowIndex];
                    int кодПлатежа = Convert.ToInt32(row.Cells["кодПлатежа"].Value);
                    decimal сумма = Convert.ToDecimal(row.Cells["сумма"].Value);
                    DateTime датаОплаты = Convert.ToDateTime(row.Cells["датаОплаты"].Value);
                    int кодДоговора = Convert.ToInt32(row.Cells["кодДоговора"].Value);
                    MySqlCommand command = new MySqlCommand("UPDATE Платеж SET сумма = @сумма, датаОплаты = @датаОплаты, кодДоговора = @кодДоговора WHERE кодПлатежа = @кодПлатежа", connection);
                    command.Parameters.AddWithValue("@кодПлатежа", кодПлатежа);
                    command.Parameters.AddWithValue("@сумма", сумма);
                    command.Parameters.AddWithValue("@датаОплаты", датаОплаты);
                    command.Parameters.AddWithValue("@кодДоговора", кодДоговора);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewСадовоеОбщество_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataGridViewRow row = dataGridViewСадовоеОбщество.Rows[e.RowIndex];
                    int код = Convert.ToInt32(row.Cells["код"].Value);
                    string председатель = row.Cells["председатель"].Value.ToString();
                    string название = row.Cells["название"].Value.ToString();
                    MySqlCommand command = new MySqlCommand("UPDATE СадовоеОбщество SET председатель = @председатель, название = @название WHERE код = @код", connection);
                    command.Parameters.AddWithValue("@код", код);
                    command.Parameters.AddWithValue("@председатель", председатель);
                    command.Parameters.AddWithValue("@название", название);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewТипПочвы_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataGridViewRow row = dataGridViewТипПочвы.Rows[e.RowIndex];
                    int код = Convert.ToInt32(row.Cells["код"].Value);
                    string типПочвы = row.Cells["типПочвы"].Value.ToString();
                    MySqlCommand command = new MySqlCommand("UPDATE ТипПочвы SET типПочвы = @типПочвы WHERE код = @код", connection);
                    command.Parameters.AddWithValue("@код", код);
                    command.Parameters.AddWithValue("@типПочвы", типПочвы);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewТипРельефа_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataGridViewRow row = dataGridViewТипРельефа.Rows[e.RowIndex];
                    int код = Convert.ToInt32(row.Cells["код"].Value);
                    string типРельефа = row.Cells["типРельефа"].Value.ToString();
                    MySqlCommand command = new MySqlCommand("UPDATE ТипРельефа SET типРельефа = @типРельефа WHERE код = @код", connection);
                    command.Parameters.AddWithValue("@код", код);
                    command.Parameters.AddWithValue("@типРельефа", типРельефа);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewУчасток_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    DataGridViewRow row = dataGridViewУчасток.Rows[e.RowIndex];
                    int код = Convert.ToInt32(row.Cells["код"].Value);
                    decimal площадь = Convert.ToDecimal(row.Cells["площадь"].Value);
                    string статусУчастка = row.Cells["статусУчастка"].Value.ToString();
                    int кодСадовоеОбщество = Convert.ToInt32(row.Cells["кодСадовоеОбщество"].Value);
                    int кодТипРельефа = Convert.ToInt32(row.Cells["кодТипРельефа"].Value);
                    int кодТипПочвы = Convert.ToInt32(row.Cells["кодТипПочвы"].Value);
                    MySqlCommand command = new MySqlCommand("UPDATE Участок SET площадь = @площадь, статусУчастка = @статусУчастка, кодСадовоеОбщество = @кодСадовоеОбщество, кодТипРельефа = @кодТипРельефа, кодТипПочвы = @кодТипПочвы WHERE код = @код", connection);
                    command.Parameters.AddWithValue("@код", код);
                    command.Parameters.AddWithValue("@площадь", площадь);
                    command.Parameters.AddWithValue("@статусУчастка", статусУчастка);
                    command.Parameters.AddWithValue("@кодСадовоеОбщество", кодСадовоеОбщество);
                    command.Parameters.AddWithValue("@кодТипРельефа", кодТипРельефа);
                    command.Parameters.AddWithValue("@кодТипПочвы", кодТипПочвы);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
