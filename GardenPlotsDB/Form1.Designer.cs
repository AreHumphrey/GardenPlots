namespace GardenPlotsDB
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAddData = new System.Windows.Forms.TabPage();
            this.tabPageViewData = new System.Windows.Forms.TabPage();

            // Add data controls
            this.groupBoxСадовоеОбщество = new System.Windows.Forms.GroupBox();
            this.textBoxПредседатель = new System.Windows.Forms.TextBox();
            this.textBoxНазвание = new System.Windows.Forms.TextBox();
            this.buttonSaveСадовоеОбщество = new System.Windows.Forms.Button();

            this.groupBoxТипРельефа = new System.Windows.Forms.GroupBox();
            this.textBoxТипРельефа = new System.Windows.Forms.TextBox();
            this.buttonSaveТипРельефа = new System.Windows.Forms.Button();

            this.groupBoxТипПочвы = new System.Windows.Forms.GroupBox();
            this.textBoxТипПочвы = new System.Windows.Forms.TextBox();
            this.buttonSaveТипПочвы = new System.Windows.Forms.Button();

            this.groupBoxВладелецУчастка = new System.Windows.Forms.GroupBox();
            this.textBoxФамилия = new System.Windows.Forms.TextBox();
            this.textBoxИмя = new System.Windows.Forms.TextBox();
            this.textBoxАдрес = new System.Windows.Forms.TextBox();
            this.textBoxНомерТелефона = new System.Windows.Forms.TextBox();
            this.buttonSaveВладелецУчастка = new System.Windows.Forms.Button();

            this.groupBoxУчасток = new System.Windows.Forms.GroupBox();
            this.comboBoxСадовоеОбщество = new System.Windows.Forms.ComboBox();
            this.comboBoxТипРельефа = new System.Windows.Forms.ComboBox();
            this.comboBoxТипПочвы = new System.Windows.Forms.ComboBox();
            this.textBoxПлощадь = new System.Windows.Forms.TextBox();
            this.comboBoxСтатусУчастка = new System.Windows.Forms.ComboBox();
            this.buttonSaveУчасток = new System.Windows.Forms.Button();

            this.groupBoxДоговор = new System.Windows.Forms.GroupBox();
            this.comboBoxУчасток = new System.Windows.Forms.ComboBox();
            this.comboBoxВладелец = new System.Windows.Forms.ComboBox();
            this.dateTimePickerДатаНачала = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerДатаОкончания = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveДоговор = new System.Windows.Forms.Button();

            this.groupBoxПлатеж = new System.Windows.Forms.GroupBox();
            this.comboBoxДоговор = new System.Windows.Forms.ComboBox();
            this.textBoxСумма = new System.Windows.Forms.TextBox();
            this.dateTimePickerДатаОплаты = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveПлатеж = new System.Windows.Forms.Button();

            // View data controls
            this.dataGridViewВладельцы = new System.Windows.Forms.DataGridView();
            this.dataGridViewДоговоры = new System.Windows.Forms.DataGridView();
            this.dataGridViewПлатежи = new System.Windows.Forms.DataGridView();
            this.dataGridViewСадовоеОбщество = new System.Windows.Forms.DataGridView();
            this.dataGridViewТипПочвы = new System.Windows.Forms.DataGridView();
            this.dataGridViewТипРельефа = new System.Windows.Forms.DataGridView();
            this.dataGridViewУчасток = new System.Windows.Forms.DataGridView();

            this.comboBoxВладельцы = new System.Windows.Forms.ComboBox();
            this.comboBoxДоговоры = new System.Windows.Forms.ComboBox();

            this.tabControl.SuspendLayout();
            this.tabPageAddData.SuspendLayout();
            this.tabPageViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewВладельцы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewДоговоры)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewПлатежи)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСадовоеОбщество)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТипПочвы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТипРельефа)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewУчасток)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageAddData);
            this.tabControl.Controls.Add(this.tabPageViewData);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(960, 537);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageAddData
            // 
            this.tabPageAddData.Controls.Add(this.groupBoxСадовоеОбщество);
            this.tabPageAddData.Controls.Add(this.groupBoxТипРельефа);
            this.tabPageAddData.Controls.Add(this.groupBoxТипПочвы);
            this.tabPageAddData.Controls.Add(this.groupBoxВладелецУчастка);
            this.tabPageAddData.Controls.Add(this.groupBoxУчасток);
            this.tabPageAddData.Controls.Add(this.groupBoxДоговор);
            this.tabPageAddData.Controls.Add(this.groupBoxПлатеж);
            this.tabPageAddData.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddData.Name = "tabPageAddData";
            this.tabPageAddData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddData.Size = new System.Drawing.Size(952, 511);
            this.tabPageAddData.TabIndex = 0;
            this.tabPageAddData.Text = "Добавление данных";
            this.tabPageAddData.UseVisualStyleBackColor = true;
            // 
            // tabPageViewData
            // 
            this.tabPageViewData.Controls.Add(this.comboBoxВладельцы);
            this.tabPageViewData.Controls.Add(this.comboBoxДоговоры);
            this.tabPageViewData.Controls.Add(this.dataGridViewВладельцы);
            this.tabPageViewData.Controls.Add(this.dataGridViewДоговоры);
            this.tabPageViewData.Controls.Add(this.dataGridViewПлатежи);
            this.tabPageViewData.Controls.Add(this.dataGridViewСадовоеОбщество);
            this.tabPageViewData.Controls.Add(this.dataGridViewТипПочвы);
            this.tabPageViewData.Controls.Add(this.dataGridViewТипРельефа);
            this.tabPageViewData.Controls.Add(this.dataGridViewУчасток);
            this.tabPageViewData.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewData.Name = "tabPageViewData";
            this.tabPageViewData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewData.Size = new System.Drawing.Size(952, 511);
            this.tabPageViewData.TabIndex = 1;
            this.tabPageViewData.Text = "Просмотр и изменение данных";
            this.tabPageViewData.UseVisualStyleBackColor = true;
            // 
            // groupBoxСадовоеОбщество
            // 
            this.groupBoxСадовоеОбщество.Controls.Add(this.textBoxПредседатель);
            this.groupBoxСадовоеОбщество.Controls.Add(this.textBoxНазвание);
            this.groupBoxСадовоеОбщество.Controls.Add(this.buttonSaveСадовоеОбщество);
            this.groupBoxСадовоеОбщество.Location = new System.Drawing.Point(20, 20);
            this.groupBoxСадовоеОбщество.Name = "groupBoxСадовоеОбщество";
            this.groupBoxСадовоеОбщество.Size = new System.Drawing.Size(200, 130);
            this.groupBoxСадовоеОбщество.TabIndex = 0;
            this.groupBoxСадовоеОбщество.TabStop = false;
            this.groupBoxСадовоеОбщество.Text = "Садовое Общество";
            // 
            // textBoxПредседатель
            // 
            this.textBoxПредседатель.Location = new System.Drawing.Point(10, 30);
            this.textBoxПредседатель.Name = "textBoxПредседатель";
            this.textBoxПредседатель.Size = new System.Drawing.Size(180, 20);
            this.textBoxПредседатель.TabIndex = 1;
            this.textBoxПредседатель.Text = "Председатель";
            this.textBoxПредседатель.ForeColor = System.Drawing.Color.Gray;
            this.textBoxПредседатель.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxПредседатель.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxНазвание
            // 
            this.textBoxНазвание.Location = new System.Drawing.Point(10, 60);
            this.textBoxНазвание.Name = "textBoxНазвание";
            this.textBoxНазвание.Size = new System.Drawing.Size(180, 20);
            this.textBoxНазвание.TabIndex = 2;
            this.textBoxНазвание.Text = "Название";
            this.textBoxНазвание.ForeColor = System.Drawing.Color.Gray;
            this.textBoxНазвание.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxНазвание.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // buttonSaveСадовоеОбщество
            // 
            this.buttonSaveСадовоеОбщество.Location = new System.Drawing.Point(10, 90);
            this.buttonSaveСадовоеОбщество.Name = "buttonSaveСадовоеОбщество";
            this.buttonSaveСадовоеОбщество.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveСадовоеОбщество.TabIndex = 3;
            this.buttonSaveСадовоеОбщество.Text = "Сохранить";
            this.buttonSaveСадовоеОбщество.UseVisualStyleBackColor = true;
            this.buttonSaveСадовоеОбщество.Click += new System.EventHandler(this.buttonSaveСадовоеОбщество_Click);
            // 
            // groupBoxТипРельефа
            // 
            this.groupBoxТипРельефа.Controls.Add(this.textBoxТипРельефа);
            this.groupBoxТипРельефа.Controls.Add(this.buttonSaveТипРельефа);
            this.groupBoxТипРельефа.Location = new System.Drawing.Point(240, 20);
            this.groupBoxТипРельефа.Name = "groupBoxТипРельефа";
            this.groupBoxТипРельефа.Size = new System.Drawing.Size(200, 100);
            this.groupBoxТипРельефа.TabIndex = 4;
            this.groupBoxТипРельефа.TabStop = false;
            this.groupBoxТипРельефа.Text = "Тип Рельефа";
            // 
            // textBoxТипРельефа
            // 
            this.textBoxТипРельефа.Location = new System.Drawing.Point(10, 30);
            this.textBoxТипРельефа.Name = "textBoxТипРельефа";
            this.textBoxТипРельефа.Size = new System.Drawing.Size(180, 20);
            this.textBoxТипРельефа.TabIndex = 1;
            this.textBoxТипРельефа.Text = "Тип Рельефа";
            this.textBoxТипРельефа.ForeColor = System.Drawing.Color.Gray;
            this.textBoxТипРельефа.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxТипРельефа.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // buttonSaveТипРельефа
            // 
            this.buttonSaveТипРельефа.Location = new System.Drawing.Point(10, 60);
            this.buttonSaveТипРельефа.Name = "buttonSaveТипРельефа";
            this.buttonSaveТипРельефа.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveТипРельефа.TabIndex = 2;
            this.buttonSaveТипРельефа.Text = "Сохранить";
            this.buttonSaveТипРельефа.UseVisualStyleBackColor = true;
            this.buttonSaveТипРельефа.Click += new System.EventHandler(this.buttonSaveТипРельефа_Click);
            // 
            // groupBoxТипПочвы
            // 
            this.groupBoxТипПочвы.Controls.Add(this.textBoxТипПочвы);
            this.groupBoxТипПочвы.Controls.Add(this.buttonSaveТипПочвы);
            this.groupBoxТипПочвы.Location = new System.Drawing.Point(460, 20);
            this.groupBoxТипПочвы.Name = "groupBoxТипПочвы";
            this.groupBoxТипПочвы.Size = new System.Drawing.Size(200, 100);
            this.groupBoxТипПочвы.TabIndex = 5;
            this.groupBoxТипПочвы.TabStop = false;
            this.groupBoxТипПочвы.Text = "Тип Почвы";
            // 
            // textBoxТипПочвы
            // 
            this.textBoxТипПочвы.Location = new System.Drawing.Point(10, 30);
            this.textBoxТипПочвы.Name = "textBoxТипПочвы";
            this.textBoxТипПочвы.Size = new System.Drawing.Size(180, 20);
            this.textBoxТипПочвы.TabIndex = 1;
            this.textBoxТипПочвы.Text = "Тип Почвы";
            this.textBoxТипПочвы.ForeColor = System.Drawing.Color.Gray;
            this.textBoxТипПочвы.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxТипПочвы.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // buttonSaveТипПочвы
            // 
            this.buttonSaveТипПочвы.Location = new System.Drawing.Point(10, 60);
            this.buttonSaveТипПочвы.Name = "buttonSaveТипПочвы";
            this.buttonSaveТипПочвы.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveТипПочвы.TabIndex = 2;
            this.buttonSaveТипПочвы.Text = "Сохранить";
            this.buttonSaveТипПочвы.UseVisualStyleBackColor = true;
            this.buttonSaveТипПочвы.Click += new System.EventHandler(this.buttonSaveТипПочвы_Click);
            // 
            // groupBoxВладелецУчастка
            // 
            this.groupBoxВладелецУчастка.Controls.Add(this.textBoxФамилия);
            this.groupBoxВладелецУчастка.Controls.Add(this.textBoxИмя);
            this.groupBoxВладелецУчастка.Controls.Add(this.textBoxАдрес);
            this.groupBoxВладелецУчастка.Controls.Add(this.textBoxНомерТелефона);
            this.groupBoxВладелецУчастка.Controls.Add(this.buttonSaveВладелецУчастка);
            this.groupBoxВладелецУчастка.Location = new System.Drawing.Point(20, 160);
            this.groupBoxВладелецУчастка.Name = "groupBoxВладелецУчастка";
            this.groupBoxВладелецУчастка.Size = new System.Drawing.Size(200, 180);
            this.groupBoxВладелецУчастка.TabIndex = 6;
            this.groupBoxВладелецУчастка.TabStop = false;
            this.groupBoxВладелецУчастка.Text = "Владелец Участка";
            // 
            // textBoxФамилия
            // 
            this.textBoxФамилия.Location = new System.Drawing.Point(10, 30);
            this.textBoxФамилия.Name = "textBoxФамилия";
            this.textBoxФамилия.Size = new System.Drawing.Size(180, 20);
            this.textBoxФамилия.TabIndex = 1;
            this.textBoxФамилия.Text = "Фамилия";
            this.textBoxФамилия.ForeColor = System.Drawing.Color.Gray;
            this.textBoxФамилия.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxФамилия.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxИмя
            // 
            this.textBoxИмя.Location = new System.Drawing.Point(10, 60);
            this.textBoxИмя.Name = "textBoxИмя";
            this.textBoxИмя.Size = new System.Drawing.Size(180, 20);
            this.textBoxИмя.TabIndex = 2;
            this.textBoxИмя.Text = "Имя";
            this.textBoxИмя.ForeColor = System.Drawing.Color.Gray;
            this.textBoxИмя.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxИмя.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxАдрес
            // 
            this.textBoxАдрес.Location = new System.Drawing.Point(10, 90);
            this.textBoxАдрес.Name = "textBoxАдрес";
            this.textBoxАдрес.Size = new System.Drawing.Size(180, 20);
            this.textBoxАдрес.TabIndex = 3;
            this.textBoxАдрес.Text = "Адрес";
            this.textBoxАдрес.ForeColor = System.Drawing.Color.Gray;
            this.textBoxАдрес.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxАдрес.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxНомерТелефона
            // 
            this.textBoxНомерТелефона.Location = new System.Drawing.Point(10, 120);
            this.textBoxНомерТелефона.Name = "textBoxНомерТелефона";
            this.textBoxНомерТелефона.Size = new System.Drawing.Size(180, 20);
            this.textBoxНомерТелефона.TabIndex = 4;
            this.textBoxНомерТелефона.Text = "Номер Телефона";
            this.textBoxНомерТелефона.ForeColor = System.Drawing.Color.Gray;
            this.textBoxНомерТелефона.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxНомерТелефона.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // buttonSaveВладелецУчастка
            // 
            this.buttonSaveВладелецУчастка.Location = new System.Drawing.Point(10, 150);
            this.buttonSaveВладелецУчастка.Name = "buttonSaveВладелецУчастка";
            this.buttonSaveВладелецУчастка.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveВладелецУчастка.TabIndex = 5;
            this.buttonSaveВладелецУчастка.Text = "Сохранить";
            this.buttonSaveВладелецУчастка.UseVisualStyleBackColor = true;
            this.buttonSaveВладелецУчастка.Click += new System.EventHandler(this.buttonSaveВладелецУчастка_Click);
            // 
            // groupBoxУчасток
            // 
            this.groupBoxУчасток.Controls.Add(this.comboBoxСадовоеОбщество);
            this.groupBoxУчасток.Controls.Add(this.comboBoxТипРельефа);
            this.groupBoxУчасток.Controls.Add(this.comboBoxТипПочвы);
            this.groupBoxУчасток.Controls.Add(this.textBoxПлощадь);
            this.groupBoxУчасток.Controls.Add(this.comboBoxСтатусУчастка);
            this.groupBoxУчасток.Controls.Add(this.buttonSaveУчасток);
            this.groupBoxУчасток.Location = new System.Drawing.Point(240, 160);
            this.groupBoxУчасток.Name = "groupBoxУчасток";
            this.groupBoxУчасток.Size = new System.Drawing.Size(200, 220);
            this.groupBoxУчасток.TabIndex = 7;
            this.groupBoxУчасток.TabStop = false;
            this.groupBoxУчасток.Text = "Участок";
            // 
            // comboBoxСадовоеОбщество
            // 
            this.comboBoxСадовоеОбщество.FormattingEnabled = true;
            this.comboBoxСадовоеОбщество.Location = new System.Drawing.Point(10, 30);
            this.comboBoxСадовоеОбщество.Name = "comboBoxСадовоеОбщество";
            this.comboBoxСадовоеОбщество.Size = new System.Drawing.Size(180, 21);
            this.comboBoxСадовоеОбщество.TabIndex = 1;
            // 
            // comboBoxТипРельефа
            // 
            this.comboBoxТипРельефа.FormattingEnabled = true;
            this.comboBoxТипРельефа.Location = new System.Drawing.Point(10, 60);
            this.comboBoxТипРельефа.Name = "comboBoxТипРельефа";
            this.comboBoxТипРельефа.Size = new System.Drawing.Size(180, 21);
            this.comboBoxТипРельефа.TabIndex = 2;
            // 
            // comboBoxТипПочвы
            // 
            this.comboBoxТипПочвы.FormattingEnabled = true;
            this.comboBoxТипПочвы.Location = new System.Drawing.Point(10, 90);
            this.comboBoxТипПочвы.Name = "comboBoxТипПочвы";
            this.comboBoxТипПочвы.Size = new System.Drawing.Size(180, 21);
            this.comboBoxТипПочвы.TabIndex = 3;
            // 
            // textBoxПлощадь
            // 
            this.textBoxПлощадь.Location = new System.Drawing.Point(10, 120);
            this.textBoxПлощадь.Name = "textBoxПлощадь";
            this.textBoxПлощадь.Size = new System.Drawing.Size(180, 20);
            this.textBoxПлощадь.TabIndex = 4;
            this.textBoxПлощадь.Text = "Площадь";
            this.textBoxПлощадь.ForeColor = System.Drawing.Color.Gray;
            this.textBoxПлощадь.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxПлощадь.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // comboBoxСтатусУчастка
            // 
            this.comboBoxСтатусУчастка.FormattingEnabled = true;
            this.comboBoxСтатусУчастка.Items.AddRange(new object[] {
            "свободен",
            "продан",
            "арендован"});
            this.comboBoxСтатусУчастка.Location = new System.Drawing.Point(10, 150);
            this.comboBoxСтатусУчастка.Name = "comboBoxСтатусУчастка";
            this.comboBoxСтатусУчастка.Size = new System.Drawing.Size(180, 21);
            this.comboBoxСтатусУчастка.TabIndex = 5;
            // 
            // buttonSaveУчасток
            // 
            this.buttonSaveУчасток.Location = new System.Drawing.Point(10, 180);
            this.buttonSaveУчасток.Name = "buttonSaveУчасток";
            this.buttonSaveУчасток.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveУчасток.TabIndex = 6;
            this.buttonSaveУчасток.Text = "Сохранить";
            this.buttonSaveУчасток.UseVisualStyleBackColor = true;
            this.buttonSaveУчасток.Click += new System.EventHandler(this.buttonSaveУчасток_Click);
            // 
            // groupBoxДоговор
            // 
            this.groupBoxДоговор.Controls.Add(this.comboBoxУчасток);
            this.groupBoxДоговор.Controls.Add(this.comboBoxВладелец);
            this.groupBoxДоговор.Controls.Add(this.dateTimePickerДатаНачала);
            this.groupBoxДоговор.Controls.Add(this.dateTimePickerДатаОкончания);
            this.groupBoxДоговор.Controls.Add(this.buttonSaveДоговор);
            this.groupBoxДоговор.Location = new System.Drawing.Point(460, 160);
            this.groupBoxДоговор.Name = "groupBoxДоговор";
            this.groupBoxДоговор.Size = new System.Drawing.Size(200, 220);
            this.groupBoxДоговор.TabIndex = 8;
            this.groupBoxДоговор.TabStop = false;
            this.groupBoxДоговор.Text = "Договор";
            // 
            // comboBoxУчасток
            // 
            this.comboBoxУчасток.FormattingEnabled = true;
            this.comboBoxУчасток.Location = new System.Drawing.Point(10, 30);
            this.comboBoxУчасток.Name = "comboBoxУчасток";
            this.comboBoxУчасток.Size = new System.Drawing.Size(180, 21);
            this.comboBoxУчасток.TabIndex = 1;
            // 
            // comboBoxВладелец
            // 
            this.comboBoxВладелец.FormattingEnabled = true;
            this.comboBoxВладелец.Location = new System.Drawing.Point(10, 60);
            this.comboBoxВладелец.Name = "comboBoxВладелец";
            this.comboBoxВладелец.Size = new System.Drawing.Size(180, 21);
            this.comboBoxВладелец.TabIndex = 2;
            // 
            // dateTimePickerДатаНачала
            // 
            this.dateTimePickerДатаНачала.Location = new System.Drawing.Point(10, 90);
            this.dateTimePickerДатаНачала.Name = "dateTimePickerДатаНачала";
            this.dateTimePickerДатаНачала.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerДатаНачала.TabIndex = 3;
            // 
            // dateTimePickerДатаОкончания
            // 
            this.dateTimePickerДатаОкончания.Location = new System.Drawing.Point(10, 120);
            this.dateTimePickerДатаОкончания.Name = "dateTimePickerДатаОкончания";
            this.dateTimePickerДатаОкончания.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerДатаОкончания.TabIndex = 4;
            // 
            // buttonSaveДоговор
            // 
            this.buttonSaveДоговор.Location = new System.Drawing.Point(10, 150);
            this.buttonSaveДоговор.Name = "buttonSaveДоговор";
            this.buttonSaveДоговор.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveДоговор.TabIndex = 5;
            this.buttonSaveДоговор.Text = "Сохранить";
            this.buttonSaveДоговор.UseVisualStyleBackColor = true;
            this.buttonSaveДоговор.Click += new System.EventHandler(this.buttonSaveДоговор_Click);
            // 
            // groupBoxПлатеж
            // 
            this.groupBoxПлатеж.Controls.Add(this.comboBoxДоговор);
            this.groupBoxПлатеж.Controls.Add(this.textBoxСумма);
            this.groupBoxПлатеж.Controls.Add(this.dateTimePickerДатаОплаты);
            this.groupBoxПлатеж.Controls.Add(this.buttonSaveПлатеж);
            this.groupBoxПлатеж.Location = new System.Drawing.Point(20, 400);
            this.groupBoxПлатеж.Name = "groupBoxПлатеж";
            this.groupBoxПлатеж.Size = new System.Drawing.Size(200, 160);
            this.groupBoxПлатеж.TabIndex = 9;
            this.groupBoxПлатеж.TabStop = false;
            this.groupBoxПлатеж.Text = "Платеж";
            // 
            // comboBoxДоговор
            // 
            this.comboBoxДоговор.FormattingEnabled = true;
            this.comboBoxДоговор.Location = new System.Drawing.Point(10, 30);
            this.comboBoxДоговор.Name = "comboBoxДоговор";
            this.comboBoxДоговор.Size = new System.Drawing.Size(180, 21);
            this.comboBoxДоговор.TabIndex = 1;
            // 
            // textBoxСумма
            // 
            this.textBoxСумма.Location = new System.Drawing.Point(10, 60);
            this.textBoxСумма.Name = "textBoxСумма";
            this.textBoxСумма.Size = new System.Drawing.Size(180, 20);
            this.textBoxСумма.TabIndex = 2;
            this.textBoxСумма.Text = "Сумма";
            this.textBoxСумма.ForeColor = System.Drawing.Color.Gray;
            this.textBoxСумма.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBoxСумма.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // dateTimePickerДатаОплаты
            // 
            this.dateTimePickerДатаОплаты.Location = new System.Drawing.Point(10, 90);
            this.dateTimePickerДатаОплаты.Name = "dateTimePickerДатаОплаты";
            this.dateTimePickerДатаОплаты.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerДатаОплаты.TabIndex = 3;
            // 
            // buttonSaveПлатеж
            // 
            this.buttonSaveПлатеж.Location = new System.Drawing.Point(10, 120);
            this.buttonSaveПлатеж.Name = "buttonSaveПлатеж";
            this.buttonSaveПлатеж.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveПлатеж.TabIndex = 4;
            this.buttonSaveПлатеж.Text = "Сохранить";
            this.buttonSaveПлатеж.UseVisualStyleBackColor = true;
            this.buttonSaveПлатеж.Click += new System.EventHandler(this.buttonSaveПлатеж_Click);
            // 
            // dataGridViewВладельцы
            // 
            this.dataGridViewВладельцы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewВладельцы.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewВладельцы.Name = "dataGridViewВладельцы";
            this.dataGridViewВладельцы.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewВладельцы.TabIndex = 6;
            this.dataGridViewВладельцы.SelectionChanged += new System.EventHandler(this.dataGridViewВладельцы_SelectionChanged);
            this.dataGridViewВладельцы.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewВладельцы_CellValueChanged);
            // 
            // dataGridViewДоговоры
            // 
            this.dataGridViewДоговоры.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewДоговоры.Location = new System.Drawing.Point(20, 180);
            this.dataGridViewДоговоры.Name = "dataGridViewДоговоры";
            this.dataGridViewДоговоры.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewДоговоры.TabIndex = 7;
            this.dataGridViewДоговоры.SelectionChanged += new System.EventHandler(this.dataGridViewДоговоры_SelectionChanged);
            this.dataGridViewДоговоры.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewДоговоры_CellValueChanged);
            // 
            // dataGridViewПлатежи
            // 
            this.dataGridViewПлатежи.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewПлатежи.Location = new System.Drawing.Point(20, 340);
            this.dataGridViewПлатежи.Name = "dataGridViewПлатежи";
            this.dataGridViewПлатежи.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewПлатежи.TabIndex = 8;
            this.dataGridViewПлатежи.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewПлатежи_CellValueChanged);
            // 
            // dataGridViewСадовоеОбщество
            // 
            this.dataGridViewСадовоеОбщество.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewСадовоеОбщество.Location = new System.Drawing.Point(440, 20);
            this.dataGridViewСадовоеОбщество.Name = "dataGridViewСадовоеОбщество";
            this.dataGridViewСадовоеОбщество.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewСадовоеОбщество.TabIndex = 9;
            this.dataGridViewСадовоеОбщество.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewСадовоеОбщество_CellValueChanged);
            // 
            // dataGridViewТипПочвы
            // 
            this.dataGridViewТипПочвы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewТипПочвы.Location = new System.Drawing.Point(440, 180);
            this.dataGridViewТипПочвы.Name = "dataGridViewТипПочвы";
            this.dataGridViewТипПочвы.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewТипПочвы.TabIndex = 10;
            this.dataGridViewТипПочвы.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewТипПочвы_CellValueChanged);
            // 
            // dataGridViewТипРельефа
            // 
            this.dataGridViewТипРельефа.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewТипРельефа.Location = new System.Drawing.Point(440, 340);
            this.dataGridViewТипРельефа.Name = "dataGridViewТипРельефа";
            this.dataGridViewТипРельефа.Size = new System.Drawing.Size(400, 150);
            this.dataGridViewТипРельефа.TabIndex = 11;
            this.dataGridViewТипРельефа.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewТипРельефа_CellValueChanged);
            // 
            // dataGridViewУчасток
            // 
            this.dataGridViewУчасток.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewУчасток.Location = new System.Drawing.Point(20, 500);
            this.dataGridViewУчасток.Name = "dataGridViewУчасток";
            this.dataGridViewУчасток.Size = new System.Drawing.Size(820, 150);
            this.dataGridViewУчасток.TabIndex = 12;
            this.dataGridViewУчасток.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewУчасток_CellValueChanged);
            // 
            // comboBoxВладельцы
            // 
            this.comboBoxВладельцы.FormattingEnabled = true;
            this.comboBoxВладельцы.Location = new System.Drawing.Point(860, 20);
            this.comboBoxВладельцы.Name = "comboBoxВладельцы";
            this.comboBoxВладельцы.Size = new System.Drawing.Size(80, 21);
            this.comboBoxВладельцы.TabIndex = 13;
            this.comboBoxВладельцы.SelectedIndexChanged += new System.EventHandler(this.comboBoxВладельцы_SelectedIndexChanged);
            // 
            // comboBoxДоговоры
            // 
            this.comboBoxДоговоры.FormattingEnabled = true;
            this.comboBoxДоговоры.Location = new System.Drawing.Point(860, 180);
            this.comboBoxДоговоры.Name = "comboBoxДоговоры";
            this.comboBoxДоговоры.Size = new System.Drawing.Size(80, 21);
            this.comboBoxДоговоры.TabIndex = 14;
            this.comboBoxДоговоры.SelectedIndexChanged += new System.EventHandler(this.comboBoxДоговоры_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageAddData.ResumeLayout(false);
            this.tabPageViewData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewВладельцы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewДоговоры)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewПлатежи)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСадовоеОбщество)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТипПочвы)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТипРельефа)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewУчасток)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddData;
        private System.Windows.Forms.TabPage tabPageViewData;
        private System.Windows.Forms.GroupBox groupBoxСадовоеОбщество;
        private System.Windows.Forms.TextBox textBoxПредседатель;
        private System.Windows.Forms.TextBox textBoxНазвание;
        private System.Windows.Forms.Button buttonSaveСадовоеОбщество;
        private System.Windows.Forms.GroupBox groupBoxТипРельефа;
        private System.Windows.Forms.TextBox textBoxТипРельефа;
        private System.Windows.Forms.Button buttonSaveТипРельефа;
        private System.Windows.Forms.GroupBox groupBoxТипПочвы;
        private System.Windows.Forms.TextBox textBoxТипПочвы;
        private System.Windows.Forms.Button buttonSaveТипПочвы;
        private System.Windows.Forms.GroupBox groupBoxВладелецУчастка;
        private System.Windows.Forms.TextBox textBoxФамилия;
        private System.Windows.Forms.TextBox textBoxИмя;
        private System.Windows.Forms.TextBox textBoxАдрес;
        private System.Windows.Forms.TextBox textBoxНомерТелефона;
        private System.Windows.Forms.Button buttonSaveВладелецУчастка;
        private System.Windows.Forms.GroupBox groupBoxУчасток;
        private System.Windows.Forms.ComboBox comboBoxСадовоеОбщество;
        private System.Windows.Forms.ComboBox comboBoxТипРельефа;
        private System.Windows.Forms.ComboBox comboBoxТипПочвы;
        private System.Windows.Forms.TextBox textBoxПлощадь;
        private System.Windows.Forms.ComboBox comboBoxСтатусУчастка;
        private System.Windows.Forms.Button buttonSaveУчасток;
        private System.Windows.Forms.GroupBox groupBoxДоговор;
        private System.Windows.Forms.ComboBox comboBoxУчасток;
        private System.Windows.Forms.ComboBox comboBoxВладелец;
        private System.Windows.Forms.DateTimePicker dateTimePickerДатаНачала;
        private System.Windows.Forms.DateTimePicker dateTimePickerДатаОкончания;
        private System.Windows.Forms.Button buttonSaveДоговор;
        private System.Windows.Forms.GroupBox groupBoxПлатеж;
        private System.Windows.Forms.ComboBox comboBoxДоговор;
        private System.Windows.Forms.TextBox textBoxСумма;
        private System.Windows.Forms.DateTimePicker dateTimePickerДатаОплаты;
        private System.Windows.Forms.Button buttonSaveПлатеж;
        private System.Windows.Forms.DataGridView dataGridViewВладельцы;
        private System.Windows.Forms.DataGridView dataGridViewДоговоры;
        private System.Windows.Forms.DataGridView dataGridViewПлатежи;
        private System.Windows.Forms.DataGridView dataGridViewСадовоеОбщество;
        private System.Windows.Forms.DataGridView dataGridViewТипПочвы;
        private System.Windows.Forms.DataGridView dataGridViewТипРельефа;
        private System.Windows.Forms.DataGridView dataGridViewУчасток;
        private System.Windows.Forms.ComboBox comboBoxВладельцы;
        private System.Windows.Forms.ComboBox comboBoxДоговоры;

        #endregion
    }
}
