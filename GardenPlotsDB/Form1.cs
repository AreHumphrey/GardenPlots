using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GardenPlotsDB
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=GardenPlotsDB;User ID=root;Password=root_password;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Load Садовое Общество
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM СадовоеОбщество", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewСадовоеОбщество.DataSource = table;

                // Load Тип Рельефа
                adapter = new MySqlDataAdapter("SELECT * FROM ТипРельефа", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewТипРельефа.DataSource = table;

                // Load Тип Почвы
                adapter = new MySqlDataAdapter("SELECT * FROM ТипПочвы", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewТипПочвы.DataSource = table;

                // Load Владелец Участка
                adapter = new MySqlDataAdapter("SELECT * FROM ВладелецУчастка", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewВладельцы.DataSource = table;

                // Load Участок
                adapter = new MySqlDataAdapter("SELECT * FROM Участок", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewУчасток.DataSource = table;

                // Load Договор
                adapter = new MySqlDataAdapter("SELECT * FROM Договор", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewДоговоры.DataSource = table;

                // Load Платеж
                adapter = new MySqlDataAdapter("SELECT * FROM Платеж", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewПлатежи.DataSource = table;

                // Load ComboBox items
                comboBoxУчастокСадовоеОбщество.DataSource = dataGridViewСадовоеОбщество.DataSource;
                comboBoxУчастокСадовоеОбщество.DisplayMember = "название";
                comboBoxУчастокСадовоеОбщество.ValueMember = "код";

                comboBoxУчастокТипРельефа.DataSource = dataGridViewТипРельефа.DataSource;
                comboBoxУчастокТипРельефа.DisplayMember = "типРельефа";
                comboBoxУчастокТипРельефа.ValueMember = "код";

                comboBoxУчастокТипПочвы.DataSource = dataGridViewТипПочвы.DataSource;
                comboBoxУчастокТипПочвы.DisplayMember = "типПочвы";
                comboBoxУчастокТипПочвы.ValueMember = "код";

                comboBoxДоговорУчасток.DataSource = dataGridViewУчасток.DataSource;
                comboBoxДоговорУчасток.DisplayMember = "код";
                comboBoxДоговорУчасток.ValueMember = "код";

                comboBoxДоговорВладелец.DataSource = dataGridViewВладельцы.DataSource;
                comboBoxДоговорВладелец.DisplayMember = "фамилия";
                comboBoxДоговорВладелец.ValueMember = "код";

                comboBoxПлатежДоговор.DataSource = dataGridViewДоговоры.DataSource;
                comboBoxПлатежДоговор.DisplayMember = "номерДоговора";
                comboBoxПлатежДоговор.ValueMember = "номерДоговора";

                comboBoxВладельцы.DataSource = dataGridViewВладельцы.DataSource;
                comboBoxВладельцы.DisplayMember = "фамилия";
                comboBoxВладельцы.ValueMember = "код";

                comboBoxДоговоры.DataSource = dataGridViewДоговоры.DataSource;
                comboBoxДоговоры.DisplayMember = "номерДоговора";
                comboBoxДоговоры.ValueMember = "номерДоговора";
            }
        }

        private void buttonSaveСадовоеОбщество_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO СадовоеОбщество (председатель, название) VALUES (@председатель, @название)", connection);
                command.Parameters.AddWithValue("@председатель", textBoxСадовоеОбществоПредседатель.Text);
                command.Parameters.AddWithValue("@название", textBoxСадовоеОбществоНазвание.Text);
                command.ExecuteNonQuery();
                LoadData();
            }
        }

        private void buttonSaveТипРельефа_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO ТипРельефа (типРельефа) VALUES (@типРельефа)", connection);
                command.Parameters.AddWithValue("@типРельефа", textBoxТипРельефаНазвание.Text);
                command.ExecuteNonQuery();
                LoadData();
            }
        }

        private void buttonSaveТипПочвы_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO ТипПочвы (типПочвы) VALUES (@типПочвы)", connection);
                command.Parameters.AddWithValue("@типПочвы", textBoxТипПочвыНазвание.Text);
                command.ExecuteNonQuery();
                LoadData();
            }
        }

        private void buttonSaveВладелецУчастка_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO ВладелецУчастка (фамилия, имя, адрес, номерТелефона) VALUES (@фамилия, @имя, @адрес, @номерТелефона)", connection);
                command.Parameters.AddWithValue("@фамилия", textBoxВладелецФамилия.Text);
                command.Parameters.AddWithValue("@имя", textBoxВладелецИмя.Text);
                command.Parameters.AddWithValue("@адрес", textBoxВладелецАдрес.Text);
                command.Parameters.AddWithValue("@номерТелефона", textBoxВладелецНомерТелефона.Text);
                command.ExecuteNonQuery();
                LoadData();
            }
        }

        private void buttonSaveУчасток_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO Участок (площадь, статусУчастка, кодСадовоеОбщество, кодТипРельефа, кодТипПочвы) VALUES (@площадь, @статусУчастка, @кодСадовоеОбщество, @кодТипРельефа, @кодТипПочвы)", connection);
                command.Parameters.AddWithValue("@площадь", textBoxУчастокПлощадь.Text);
                command.Parameters.AddWithValue("@статусУчастка", comboBoxУчастокСтатус.Text);
                command.Parameters.AddWithValue("@кодСадовоеОбщество", comboBoxУчастокСадовоеОбщество.SelectedValue);
                command.Parameters.AddWithValue("@кодТипРельефа", comboBoxУчастокТипРельефа.SelectedValue);
                command.Parameters.AddWithValue("@кодТипПочвы", comboBoxУчастокТипПочвы.SelectedValue);
                command.ExecuteNonQuery();
                LoadData();
            }
        }

        private void buttonSaveДоговор_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO Договор (датаНачала, датаОкончания, кодУчастка, кодВладелецУчастка) VALUES (@датаНачала, @датаОкончания, @кодУчастка, @кодВладелецУчастка)", connection);
                command.Parameters.AddWithValue("@датаНачала", dateTimePickerДоговорДатаНачала.Value);
                command.Parameters.AddWithValue("@датаОкончания", dateTimePickerДоговорДатаОкончания.Value);
                command.Parameters.AddWithValue("@кодУчастка", comboBoxДоговорУчасток.SelectedValue);
                command.Parameters.AddWithValue("@кодВладелецУчастка", comboBoxДоговорВладелец.SelectedValue);
                command.ExecuteNonQuery();
                LoadData();
            }
        }

        private void buttonSaveПлатеж_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO Платеж (сумма, датаОплаты, кодДоговора) VALUES (@сумма, @датаОплаты, @кодДоговора)", connection);
                command.Parameters.AddWithValue("@сумма", textBoxПлатежСумма.Text);
                command.Parameters.AddWithValue("@датаОплаты", dateTimePickerПлатежДатаОплаты.Value);
                command.Parameters.AddWithValue("@кодДоговора", comboBoxПлатежДоговор.SelectedValue);
                command.ExecuteNonQuery();
                LoadData();
            }
        }

        private void comboBoxВладельцы_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxВладельцы.SelectedValue != null)
            {
                int владелецId = Convert.ToInt32(comboBoxВладельцы.SelectedValue);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Договор WHERE кодВладелецУчастка = @кодВладелецУчастка", connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@кодВладелецУчастка", владелецId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewДоговоры.DataSource = table;
                }
            }
        }

        private void comboBoxДоговоры_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxДоговоры.SelectedValue != null)
            {
                int договорId = Convert.ToInt32(comboBoxДоговоры.SelectedValue);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Платеж WHERE кодДоговора = @кодДоговора", connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@кодДоговора", договорId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewПлатежи.DataSource = table;
                }
            }
        }

        private void dataGridViewВладельцы_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewВладельцы.CurrentRow != null)
            {
                int владелецId = Convert.ToInt32(dataGridViewВладельцы.CurrentRow.Cells["код"].Value);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Договор WHERE кодВладелецУчастка = @кодВладелецУчастка", connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@кодВладелецУчастка", владелецId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewДоговоры.DataSource = table;
                }
            }
        }

        private void dataGridViewДоговоры_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewДоговоры.CurrentRow != null)
            {
                int договорId = Convert.ToInt32(dataGridViewДоговоры.CurrentRow.Cells["номерДоговора"].Value);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Платеж WHERE кодДоговора = @кодДоговора", connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@кодДоговора", договорId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewПлатежи.DataSource = table;
                }
            }
        }

        private void dataGridViewВладельцы_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData(dataGridViewВладельцы, "ВладелецУчастка");
        }

        private void dataGridViewДоговоры_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData(dataGridViewДоговоры, "Договор");
        }

        private void dataGridViewПлатежи_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData(dataGridViewПлатежи, "Платеж");
        }

        private void dataGridViewСадовоеОбщество_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData(dataGridViewСадовоеОбщество, "СадовоеОбщество");
        }

        private void dataGridViewТипПочвы_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData(dataGridViewТипПочвы, "ТипПочвы");
        }

        private void dataGridViewТипРельефа_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData(dataGridViewТипРельефа, "ТипРельефа");
        }

        private void dataGridViewУчасток_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateData(dataGridViewУчасток, "Участок");
        }

        private void UpdateData(DataGridView dataGridView, string tableName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                MySqlTransaction transaction = connection.BeginTransaction();
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;
                        command.CommandText = $"REPLACE INTO {tableName} VALUES (@values)";
                        command.Parameters.Clear();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            command.Parameters.AddWithValue("@values", cell.Value);
                        }
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {
                        // Handle any errors that may have occurred on the server that would cause the rollback to fail.
                    }
                    MessageBox.Show($"Error updating {tableName}: {ex.Message}");
                }
            }
        }

        private void tabPageViewData_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void dataGridViewТипПочвы_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
