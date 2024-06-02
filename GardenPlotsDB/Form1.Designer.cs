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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageAddData = new System.Windows.Forms.TabPage();
            this.groupBoxСадовоеОбщество = new System.Windows.Forms.GroupBox();
            this.labelСадовоеОбществоПредседатель = new System.Windows.Forms.Label();
            this.labelСадовоеОбществоНазвание = new System.Windows.Forms.Label();
            this.textBoxСадовоеОбществоПредседатель = new System.Windows.Forms.TextBox();
            this.textBoxСадовоеОбществоНазвание = new System.Windows.Forms.TextBox();
            this.buttonSaveСадовоеОбщество = new System.Windows.Forms.Button();
            this.groupBoxТипРельефа = new System.Windows.Forms.GroupBox();
            this.labelТипРельефаНазвание = new System.Windows.Forms.Label();
            this.textBoxТипРельефаНазвание = new System.Windows.Forms.TextBox();
            this.buttonSaveТипРельефа = new System.Windows.Forms.Button();
            this.groupBoxТипПочвы = new System.Windows.Forms.GroupBox();
            this.labelТипПочвыНазвание = new System.Windows.Forms.Label();
            this.textBoxТипПочвыНазвание = new System.Windows.Forms.TextBox();
            this.buttonSaveТипПочвы = new System.Windows.Forms.Button();
            this.groupBoxВладелецУчастка = new System.Windows.Forms.GroupBox();
            this.labelВладелецФамилия = new System.Windows.Forms.Label();
            this.labelВладелецИмя = new System.Windows.Forms.Label();
            this.labelВладелецАдрес = new System.Windows.Forms.Label();
            this.labelВладелецНомерТелефона = new System.Windows.Forms.Label();
            this.textBoxВладелецФамилия = new System.Windows.Forms.TextBox();
            this.textBoxВладелецИмя = new System.Windows.Forms.TextBox();
            this.textBoxВладелецАдрес = new System.Windows.Forms.TextBox();
            this.textBoxВладелецНомерТелефона = new System.Windows.Forms.TextBox();
            this.buttonSaveВладелецУчастка = new System.Windows.Forms.Button();
            this.groupBoxУчасток = new System.Windows.Forms.GroupBox();
            this.labelУчастокСадовоеОбщество = new System.Windows.Forms.Label();
            this.labelУчастокТипРельефа = new System.Windows.Forms.Label();
            this.labelУчастокТипПочвы = new System.Windows.Forms.Label();
            this.labelУчастокПлощадь = new System.Windows.Forms.Label();
            this.labelУчастокСтатус = new System.Windows.Forms.Label();
            this.comboBoxУчастокСадовоеОбщество = new System.Windows.Forms.ComboBox();
            this.comboBoxУчастокТипРельефа = new System.Windows.Forms.ComboBox();
            this.comboBoxУчастокТипПочвы = new System.Windows.Forms.ComboBox();
            this.textBoxУчастокПлощадь = new System.Windows.Forms.TextBox();
            this.comboBoxУчастокСтатус = new System.Windows.Forms.ComboBox();
            this.buttonSaveУчасток = new System.Windows.Forms.Button();
            this.groupBoxДоговор = new System.Windows.Forms.GroupBox();
            this.labelДоговорУчасток = new System.Windows.Forms.Label();
            this.labelДоговорВладелец = new System.Windows.Forms.Label();
            this.labelДоговорДатаНачала = new System.Windows.Forms.Label();
            this.labelДоговорДатаОкончания = new System.Windows.Forms.Label();
            this.comboBoxДоговорУчасток = new System.Windows.Forms.ComboBox();
            this.comboBoxДоговорВладелец = new System.Windows.Forms.ComboBox();
            this.dateTimePickerДоговорДатаНачала = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerДоговорДатаОкончания = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveДоговор = new System.Windows.Forms.Button();
            this.groupBoxПлатеж = new System.Windows.Forms.GroupBox();
            this.labelПлатежДоговор = new System.Windows.Forms.Label();
            this.labelПлатежСумма = new System.Windows.Forms.Label();
            this.labelПлатежДатаОплаты = new System.Windows.Forms.Label();
            this.comboBoxПлатежДоговор = new System.Windows.Forms.ComboBox();
            this.textBoxПлатежСумма = new System.Windows.Forms.TextBox();
            this.dateTimePickerПлатежДатаОплаты = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveПлатеж = new System.Windows.Forms.Button();
            this.tabPageViewData = new System.Windows.Forms.TabPage();
            this.comboBoxВладельцы = new System.Windows.Forms.ComboBox();
            this.dataGridViewВладельцы = new System.Windows.Forms.DataGridView();
            this.dataGridViewДоговоры = new System.Windows.Forms.DataGridView();
            this.dataGridViewПлатежи = new System.Windows.Forms.DataGridView();
            this.dataGridViewСадовоеОбщество = new System.Windows.Forms.DataGridView();
            this.dataGridViewТипПочвы = new System.Windows.Forms.DataGridView();
            this.dataGridViewТипРельефа = new System.Windows.Forms.DataGridView();
            this.dataGridViewУчасток = new System.Windows.Forms.DataGridView();
            this.comboBoxДоговоры = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPageAddData.SuspendLayout();
            this.groupBoxСадовоеОбщество.SuspendLayout();
            this.groupBoxТипРельефа.SuspendLayout();
            this.groupBoxТипПочвы.SuspendLayout();
            this.groupBoxВладелецУчастка.SuspendLayout();
            this.groupBoxУчасток.SuspendLayout();
            this.groupBoxДоговор.SuspendLayout();
            this.groupBoxПлатеж.SuspendLayout();
            this.tabPageViewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewВладельцы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewДоговоры)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewПлатежи)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewСадовоеОбщество)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТипПочвы)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТипРельефа)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewУчасток)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.tabControl.Controls.Add(this.tabPageAddData);
            this.tabControl.Controls.Add(this.tabPageViewData);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1297, 685);
            this.tabControl.TabIndex = 0;
            
            
            
            this.tabPageAddData.Controls.Add(this.groupBoxСадовоеОбщество);
            this.tabPageAddData.Controls.Add(this.groupBoxТипРельефа);
            this.tabPageAddData.Controls.Add(this.groupBoxТипПочвы);
            this.tabPageAddData.Controls.Add(this.groupBoxВладелецУчастка);
            this.tabPageAddData.Controls.Add(this.groupBoxУчасток);
            this.tabPageAddData.Controls.Add(this.groupBoxДоговор);
            this.tabPageAddData.Controls.Add(this.groupBoxПлатеж);
            this.tabPageAddData.Location = new System.Drawing.Point(4, 25);
            this.tabPageAddData.Name = "tabPageAddData";
            this.tabPageAddData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddData.Size = new System.Drawing.Size(1289, 656);
            this.tabPageAddData.TabIndex = 0;
            this.tabPageAddData.Text = "Добавление данных";
            this.tabPageAddData.UseVisualStyleBackColor = true;
            
            
            
            this.groupBoxСадовоеОбщество.Controls.Add(this.labelСадовоеОбществоПредседатель);
            this.groupBoxСадовоеОбщество.Controls.Add(this.labelСадовоеОбществоНазвание);
            this.groupBoxСадовоеОбщество.Controls.Add(this.textBoxСадовоеОбществоПредседатель);
            this.groupBoxСадовоеОбщество.Controls.Add(this.textBoxСадовоеОбществоНазвание);
            this.groupBoxСадовоеОбщество.Controls.Add(this.buttonSaveСадовоеОбщество);
            this.groupBoxСадовоеОбщество.Location = new System.Drawing.Point(79, 366);
            this.groupBoxСадовоеОбщество.Name = "groupBoxСадовоеОбщество";
            this.groupBoxСадовоеОбщество.Size = new System.Drawing.Size(200, 150);
            this.groupBoxСадовоеОбщество.TabIndex = 0;
            this.groupBoxСадовоеОбщество.TabStop = false;
            this.groupBoxСадовоеОбщество.Text = "Садовое Общество";
            
            
            
            this.labelСадовоеОбществоПредседатель.AutoSize = true;
            this.labelСадовоеОбществоПредседатель.Location = new System.Drawing.Point(10, 20);
            this.labelСадовоеОбществоПредседатель.Name = "labelСадовоеОбществоПредседатель";
            this.labelСадовоеОбществоПредседатель.Size = new System.Drawing.Size(103, 17);
            this.labelСадовоеОбществоПредседатель.TabIndex = 1;
            this.labelСадовоеОбществоПредседатель.Text = "Председатель";
            
            
            
            this.labelСадовоеОбществоНазвание.AutoSize = true;
            this.labelСадовоеОбществоНазвание.Location = new System.Drawing.Point(10, 60);
            this.labelСадовоеОбществоНазвание.Name = "labelСадовоеОбществоНазвание";
            this.labelСадовоеОбществоНазвание.Size = new System.Drawing.Size(72, 17);
            this.labelСадовоеОбществоНазвание.TabIndex = 2;
            this.labelСадовоеОбществоНазвание.Text = "Название";
            
            
            
            this.textBoxСадовоеОбществоПредседатель.Location = new System.Drawing.Point(10, 35);
            this.textBoxСадовоеОбществоПредседатель.Name = "textBoxСадовоеОбществоПредседатель";
            this.textBoxСадовоеОбществоПредседатель.Size = new System.Drawing.Size(180, 22);
            this.textBoxСадовоеОбществоПредседатель.TabIndex = 3;
            
            
            
            this.textBoxСадовоеОбществоНазвание.Location = new System.Drawing.Point(10, 75);
            this.textBoxСадовоеОбществоНазвание.Name = "textBoxСадовоеОбществоНазвание";
            this.textBoxСадовоеОбществоНазвание.Size = new System.Drawing.Size(180, 22);
            this.textBoxСадовоеОбществоНазвание.TabIndex = 4;
            
            
            
            this.buttonSaveСадовоеОбщество.Location = new System.Drawing.Point(10, 110);
            this.buttonSaveСадовоеОбщество.Name = "buttonSaveСадовоеОбщество";
            this.buttonSaveСадовоеОбщество.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveСадовоеОбщество.TabIndex = 5;
            this.buttonSaveСадовоеОбщество.Text = "Сохранить";
            this.buttonSaveСадовоеОбщество.UseVisualStyleBackColor = true;
            this.buttonSaveСадовоеОбщество.Click += new System.EventHandler(this.buttonSaveСадовоеОбщество_Click);
            
            
            
            this.groupBoxТипРельефа.Controls.Add(this.labelТипРельефаНазвание);
            this.groupBoxТипРельефа.Controls.Add(this.textBoxТипРельефаНазвание);
            this.groupBoxТипРельефа.Controls.Add(this.buttonSaveТипРельефа);
            this.groupBoxТипРельефа.Location = new System.Drawing.Point(653, 366);
            this.groupBoxТипРельефа.Name = "groupBoxТипРельефа";
            this.groupBoxТипРельефа.Size = new System.Drawing.Size(200, 150);
            this.groupBoxТипРельефа.TabIndex = 1;
            this.groupBoxТипРельефа.TabStop = false;
            this.groupBoxТипРельефа.Text = "Тип Рельефа";
           
            
            
            this.labelТипРельефаНазвание.AutoSize = true;
            this.labelТипРельефаНазвание.Location = new System.Drawing.Point(10, 20);
            this.labelТипРельефаНазвание.Name = "labelТипРельефаНазвание";
            this.labelТипРельефаНазвание.Size = new System.Drawing.Size(72, 17);
            this.labelТипРельефаНазвание.TabIndex = 1;
            this.labelТипРельефаНазвание.Text = "Название";
            
            
            
            this.textBoxТипРельефаНазвание.Location = new System.Drawing.Point(10, 35);
            this.textBoxТипРельефаНазвание.Name = "textBoxТипРельефаНазвание";
            this.textBoxТипРельефаНазвание.Size = new System.Drawing.Size(180, 22);
            this.textBoxТипРельефаНазвание.TabIndex = 3;
            
            
            
            this.buttonSaveТипРельефа.Location = new System.Drawing.Point(10, 110);
            this.buttonSaveТипРельефа.Name = "buttonSaveТипРельефа";
            this.buttonSaveТипРельефа.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveТипРельефа.TabIndex = 5;
            this.buttonSaveТипРельефа.Text = "Сохранить";
            this.buttonSaveТипРельефа.UseVisualStyleBackColor = true;
            this.buttonSaveТипРельефа.Click += new System.EventHandler(this.buttonSaveТипРельефа_Click);
            
            
            
            this.groupBoxТипПочвы.Controls.Add(this.labelТипПочвыНазвание);
            this.groupBoxТипПочвы.Controls.Add(this.textBoxТипПочвыНазвание);
            this.groupBoxТипПочвы.Controls.Add(this.buttonSaveТипПочвы);
            this.groupBoxТипПочвы.Location = new System.Drawing.Point(367, 366);
            this.groupBoxТипПочвы.Name = "groupBoxТипПочвы";
            this.groupBoxТипПочвы.Size = new System.Drawing.Size(200, 150);
            this.groupBoxТипПочвы.TabIndex = 2;
            this.groupBoxТипПочвы.TabStop = false;
            this.groupBoxТипПочвы.Text = "Тип Почвы";
           
            
            
            this.labelТипПочвыНазвание.AutoSize = true;
            this.labelТипПочвыНазвание.Location = new System.Drawing.Point(10, 20);
            this.labelТипПочвыНазвание.Name = "labelТипПочвыНазвание";
            this.labelТипПочвыНазвание.Size = new System.Drawing.Size(72, 17);
            this.labelТипПочвыНазвание.TabIndex = 1;
            this.labelТипПочвыНазвание.Text = "Название";
           
            
            
            this.textBoxТипПочвыНазвание.Location = new System.Drawing.Point(10, 35);
            this.textBoxТипПочвыНазвание.Name = "textBoxТипПочвыНазвание";
            this.textBoxТипПочвыНазвание.Size = new System.Drawing.Size(180, 22);
            this.textBoxТипПочвыНазвание.TabIndex = 3;
            
            
            
            this.buttonSaveТипПочвы.Location = new System.Drawing.Point(10, 110);
            this.buttonSaveТипПочвы.Name = "buttonSaveТипПочвы";
            this.buttonSaveТипПочвы.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveТипПочвы.TabIndex = 5;
            this.buttonSaveТипПочвы.Text = "Сохранить";
            this.buttonSaveТипПочвы.UseVisualStyleBackColor = true;
            this.buttonSaveТипПочвы.Click += new System.EventHandler(this.buttonSaveТипПочвы_Click);
           
            
            
            this.groupBoxВладелецУчастка.Controls.Add(this.labelВладелецФамилия);
            this.groupBoxВладелецУчастка.Controls.Add(this.labelВладелецИмя);
            this.groupBoxВладелецУчастка.Controls.Add(this.labelВладелецАдрес);
            this.groupBoxВладелецУчастка.Controls.Add(this.labelВладелецНомерТелефона);
            this.groupBoxВладелецУчастка.Controls.Add(this.textBoxВладелецФамилия);
            this.groupBoxВладелецУчастка.Controls.Add(this.textBoxВладелецИмя);
            this.groupBoxВладелецУчастка.Controls.Add(this.textBoxВладелецАдрес);
            this.groupBoxВладелецУчастка.Controls.Add(this.textBoxВладелецНомерТелефона);
            this.groupBoxВладелецУчастка.Controls.Add(this.buttonSaveВладелецУчастка);
            this.groupBoxВладелецУчастка.Location = new System.Drawing.Point(367, 20);
            this.groupBoxВладелецУчастка.Name = "groupBoxВладелецУчастка";
            this.groupBoxВладелецУчастка.Size = new System.Drawing.Size(200, 229);
            this.groupBoxВладелецУчастка.TabIndex = 3;
            this.groupBoxВладелецУчастка.TabStop = false;
            this.groupBoxВладелецУчастка.Text = "Владелец Участка";
            
            
            
            this.labelВладелецФамилия.AutoSize = true;
            this.labelВладелецФамилия.Location = new System.Drawing.Point(10, 20);
            this.labelВладелецФамилия.Name = "labelВладелецФамилия";
            this.labelВладелецФамилия.Size = new System.Drawing.Size(70, 17);
            this.labelВладелецФамилия.TabIndex = 1;
            this.labelВладелецФамилия.Text = "Фамилия";
            
            
            
            this.labelВладелецИмя.AutoSize = true;
            this.labelВладелецИмя.Location = new System.Drawing.Point(10, 60);
            this.labelВладелецИмя.Name = "labelВладелецИмя";
            this.labelВладелецИмя.Size = new System.Drawing.Size(35, 17);
            this.labelВладелецИмя.TabIndex = 2;
            this.labelВладелецИмя.Text = "Имя";
            
            
            
            this.labelВладелецАдрес.AutoSize = true;
            this.labelВладелецАдрес.Location = new System.Drawing.Point(10, 100);
            this.labelВладелецАдрес.Name = "labelВладелецАдрес";
            this.labelВладелецАдрес.Size = new System.Drawing.Size(48, 17);
            this.labelВладелецАдрес.TabIndex = 3;
            this.labelВладелецАдрес.Text = "Адрес";
            
            
            
            this.labelВладелецНомерТелефона.AutoSize = true;
            this.labelВладелецНомерТелефона.Location = new System.Drawing.Point(10, 140);
            this.labelВладелецНомерТелефона.Name = "labelВладелецНомерТелефона";
            this.labelВладелецНомерТелефона.Size = new System.Drawing.Size(123, 17);
            this.labelВладелецНомерТелефона.TabIndex = 4;
            this.labelВладелецНомерТелефона.Text = "Номер Телефона";
            
            
            
            this.textBoxВладелецФамилия.Location = new System.Drawing.Point(10, 35);
            this.textBoxВладелецФамилия.Name = "textBoxВладелецФамилия";
            this.textBoxВладелецФамилия.Size = new System.Drawing.Size(180, 22);
            this.textBoxВладелецФамилия.TabIndex = 5;
            
            
            
            this.textBoxВладелецИмя.Location = new System.Drawing.Point(10, 75);
            this.textBoxВладелецИмя.Name = "textBoxВладелецИмя";
            this.textBoxВладелецИмя.Size = new System.Drawing.Size(180, 22);
            this.textBoxВладелецИмя.TabIndex = 6;
            
            
            
            this.textBoxВладелецАдрес.Location = new System.Drawing.Point(10, 115);
            this.textBoxВладелецАдрес.Name = "textBoxВладелецАдрес";
            this.textBoxВладелецАдрес.Size = new System.Drawing.Size(180, 22);
            this.textBoxВладелецАдрес.TabIndex = 7;
            
            
            
            this.textBoxВладелецНомерТелефона.Location = new System.Drawing.Point(10, 155);
            this.textBoxВладелецНомерТелефона.Name = "textBoxВладелецНомерТелефона";
            this.textBoxВладелецНомерТелефона.Size = new System.Drawing.Size(180, 22);
            this.textBoxВладелецНомерТелефона.TabIndex = 8;
            
            
            
            this.buttonSaveВладелецУчастка.Location = new System.Drawing.Point(10, 190);
            this.buttonSaveВладелецУчастка.Name = "buttonSaveВладелецУчастка";
            this.buttonSaveВладелецУчастка.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveВладелецУчастка.TabIndex = 9;
            this.buttonSaveВладелецУчастка.Text = "Сохранить";
            this.buttonSaveВладелецУчастка.UseVisualStyleBackColor = true;
            this.buttonSaveВладелецУчастка.Click += new System.EventHandler(this.buttonSaveВладелецУчастка_Click);
            
            
            
            this.groupBoxУчасток.Controls.Add(this.labelУчастокСадовоеОбщество);
            this.groupBoxУчасток.Controls.Add(this.labelУчастокТипРельефа);
            this.groupBoxУчасток.Controls.Add(this.labelУчастокТипПочвы);
            this.groupBoxУчасток.Controls.Add(this.labelУчастокПлощадь);
            this.groupBoxУчасток.Controls.Add(this.labelУчастокСтатус);
            this.groupBoxУчасток.Controls.Add(this.comboBoxУчастокСадовоеОбщество);
            this.groupBoxУчасток.Controls.Add(this.comboBoxУчастокТипРельефа);
            this.groupBoxУчасток.Controls.Add(this.comboBoxУчастокТипПочвы);
            this.groupBoxУчасток.Controls.Add(this.textBoxУчастокПлощадь);
            this.groupBoxУчасток.Controls.Add(this.comboBoxУчастокСтатус);
            this.groupBoxУчасток.Controls.Add(this.buttonSaveУчасток);
            this.groupBoxУчасток.Location = new System.Drawing.Point(79, 20);
            this.groupBoxУчасток.Name = "groupBoxУчасток";
            this.groupBoxУчасток.Size = new System.Drawing.Size(200, 270);
            this.groupBoxУчасток.TabIndex = 4;
            this.groupBoxУчасток.TabStop = false;
            this.groupBoxУчасток.Text = "Участок";
            
            
            
            this.labelУчастокСадовоеОбщество.AutoSize = true;
            this.labelУчастокСадовоеОбщество.Location = new System.Drawing.Point(10, 20);
            this.labelУчастокСадовоеОбщество.Name = "labelУчастокСадовоеОбщество";
            this.labelУчастокСадовоеОбщество.Size = new System.Drawing.Size(135, 17);
            this.labelУчастокСадовоеОбщество.TabIndex = 1;
            this.labelУчастокСадовоеОбщество.Text = "Садовое Общество";
            
            
            
            this.labelУчастокТипРельефа.AutoSize = true;
            this.labelУчастокТипРельефа.Location = new System.Drawing.Point(10, 60);
            this.labelУчастокТипРельефа.Name = "labelУчастокТипРельефа";
            this.labelУчастокТипРельефа.Size = new System.Drawing.Size(96, 17);
            this.labelУчастокТипРельефа.TabIndex = 2;
            this.labelУчастокТипРельефа.Text = "Тип Рельефа";
            
            
            
            this.labelУчастокТипПочвы.AutoSize = true;
            this.labelУчастокТипПочвы.Location = new System.Drawing.Point(10, 100);
            this.labelУчастокТипПочвы.Name = "labelУчастокТипПочвы";
            this.labelУчастокТипПочвы.Size = new System.Drawing.Size(80, 17);
            this.labelУчастокТипПочвы.TabIndex = 3;
            this.labelУчастокТипПочвы.Text = "Тип Почвы";
            
            
            
            this.labelУчастокПлощадь.AutoSize = true;
            this.labelУчастокПлощадь.Location = new System.Drawing.Point(10, 140);
            this.labelУчастокПлощадь.Name = "labelУчастокПлощадь";
            this.labelУчастокПлощадь.Size = new System.Drawing.Size(68, 17);
            this.labelУчастокПлощадь.TabIndex = 4;
            this.labelУчастокПлощадь.Text = "Площадь";
            
            
            
            this.labelУчастокСтатус.AutoSize = true;
            this.labelУчастокСтатус.Location = new System.Drawing.Point(10, 180);
            this.labelУчастокСтатус.Name = "labelУчастокСтатус";
            this.labelУчастокСтатус.Size = new System.Drawing.Size(53, 17);
            this.labelУчастокСтатус.TabIndex = 5;
            this.labelУчастокСтатус.Text = "Статус";
            
            
            
            this.comboBoxУчастокСадовоеОбщество.FormattingEnabled = true;
            this.comboBoxУчастокСадовоеОбщество.Location = new System.Drawing.Point(10, 35);
            this.comboBoxУчастокСадовоеОбщество.Name = "comboBoxУчастокСадовоеОбщество";
            this.comboBoxУчастокСадовоеОбщество.Size = new System.Drawing.Size(180, 24);
            this.comboBoxУчастокСадовоеОбщество.TabIndex = 6;
            
            
            
            this.comboBoxУчастокТипРельефа.FormattingEnabled = true;
            this.comboBoxУчастокТипРельефа.Location = new System.Drawing.Point(10, 75);
            this.comboBoxУчастокТипРельефа.Name = "comboBoxУчастокТипРельефа";
            this.comboBoxУчастокТипРельефа.Size = new System.Drawing.Size(180, 24);
            this.comboBoxУчастокТипРельефа.TabIndex = 7;
            
            
            
            this.comboBoxУчастокТипПочвы.FormattingEnabled = true;
            this.comboBoxУчастокТипПочвы.Location = new System.Drawing.Point(10, 115);
            this.comboBoxУчастокТипПочвы.Name = "comboBoxУчастокТипПочвы";
            this.comboBoxУчастокТипПочвы.Size = new System.Drawing.Size(180, 24);
            this.comboBoxУчастокТипПочвы.TabIndex = 8;
            
            
            
            this.textBoxУчастокПлощадь.Location = new System.Drawing.Point(10, 155);
            this.textBoxУчастокПлощадь.Name = "textBoxУчастокПлощадь";
            this.textBoxУчастокПлощадь.Size = new System.Drawing.Size(180, 22);
            this.textBoxУчастокПлощадь.TabIndex = 9;
            
            
            
            this.comboBoxУчастокСтатус.FormattingEnabled = true;
            this.comboBoxУчастокСтатус.Location = new System.Drawing.Point(10, 195);
            this.comboBoxУчастокСтатус.Name = "comboBoxУчастокСтатус";
            this.comboBoxУчастокСтатус.Size = new System.Drawing.Size(180, 24);
            this.comboBoxУчастокСтатус.TabIndex = 10;
            
            
            
            this.buttonSaveУчасток.Location = new System.Drawing.Point(10, 230);
            this.buttonSaveУчасток.Name = "buttonSaveУчасток";
            this.buttonSaveУчасток.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveУчасток.TabIndex = 11;
            this.buttonSaveУчасток.Text = "Сохранить";
            this.buttonSaveУчасток.UseVisualStyleBackColor = true;
            this.buttonSaveУчасток.Click += new System.EventHandler(this.buttonSaveУчасток_Click);
            
            
            
            this.groupBoxДоговор.Controls.Add(this.labelДоговорУчасток);
            this.groupBoxДоговор.Controls.Add(this.labelДоговорВладелец);
            this.groupBoxДоговор.Controls.Add(this.labelДоговорДатаНачала);
            this.groupBoxДоговор.Controls.Add(this.labelДоговорДатаОкончания);
            this.groupBoxДоговор.Controls.Add(this.comboBoxДоговорУчасток);
            this.groupBoxДоговор.Controls.Add(this.comboBoxДоговорВладелец);
            this.groupBoxДоговор.Controls.Add(this.dateTimePickerДоговорДатаНачала);
            this.groupBoxДоговор.Controls.Add(this.dateTimePickerДоговорДатаОкончания);
            this.groupBoxДоговор.Controls.Add(this.buttonSaveДоговор);
            this.groupBoxДоговор.Location = new System.Drawing.Point(643, 20);
            this.groupBoxДоговор.Name = "groupBoxДоговор";
            this.groupBoxДоговор.Size = new System.Drawing.Size(200, 270);
            this.groupBoxДоговор.TabIndex = 5;
            this.groupBoxДоговор.TabStop = false;
            this.groupBoxДоговор.Text = "Договор";
            
            
            
            this.labelДоговорУчасток.AutoSize = true;
            this.labelДоговорУчасток.Location = new System.Drawing.Point(10, 20);
            this.labelДоговорУчасток.Name = "labelДоговорУчасток";
            this.labelДоговорУчасток.Size = new System.Drawing.Size(62, 17);
            this.labelДоговорУчасток.TabIndex = 1;
            this.labelДоговорУчасток.Text = "Участок";
            
            
            
            this.labelДоговорВладелец.AutoSize = true;
            this.labelДоговорВладелец.Location = new System.Drawing.Point(10, 60);
            this.labelДоговорВладелец.Name = "labelДоговорВладелец";
            this.labelДоговорВладелец.Size = new System.Drawing.Size(73, 17);
            this.labelДоговорВладелец.TabIndex = 2;
            this.labelДоговорВладелец.Text = "Владелец";
            
            
            
            this.labelДоговорДатаНачала.AutoSize = true;
            this.labelДоговорДатаНачала.Location = new System.Drawing.Point(10, 100);
            this.labelДоговорДатаНачала.Name = "labelДоговорДатаНачала";
            this.labelДоговорДатаНачала.Size = new System.Drawing.Size(96, 17);
            this.labelДоговорДатаНачала.TabIndex = 3;
            this.labelДоговорДатаНачала.Text = "Дата Начала";
            
            
            
            this.labelДоговорДатаОкончания.AutoSize = true;
            this.labelДоговорДатаОкончания.Location = new System.Drawing.Point(10, 140);
            this.labelДоговорДатаОкончания.Name = "labelДоговорДатаОкончания";
            this.labelДоговорДатаОкончания.Size = new System.Drawing.Size(120, 17);
            this.labelДоговорДатаОкончания.TabIndex = 4;
            this.labelДоговорДатаОкончания.Text = "Дата Окончания";
            
            
            
            this.comboBoxДоговорУчасток.FormattingEnabled = true;
            this.comboBoxДоговорУчасток.Location = new System.Drawing.Point(10, 35);
            this.comboBoxДоговорУчасток.Name = "comboBoxДоговорУчасток";
            this.comboBoxДоговорУчасток.Size = new System.Drawing.Size(180, 24);
            this.comboBoxДоговорУчасток.TabIndex = 5;
            
            
            
            this.comboBoxДоговорВладелец.FormattingEnabled = true;
            this.comboBoxДоговорВладелец.Location = new System.Drawing.Point(10, 75);
            this.comboBoxДоговорВладелец.Name = "comboBoxДоговорВладелец";
            this.comboBoxДоговорВладелец.Size = new System.Drawing.Size(180, 24);
            this.comboBoxДоговорВладелец.TabIndex = 6;
            
            
            
            this.dateTimePickerДоговорДатаНачала.Location = new System.Drawing.Point(10, 115);
            this.dateTimePickerДоговорДатаНачала.Name = "dateTimePickerДоговорДатаНачала";
            this.dateTimePickerДоговорДатаНачала.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerДоговорДатаНачала.TabIndex = 7;
            
            
            
            this.dateTimePickerДоговорДатаОкончания.Location = new System.Drawing.Point(10, 155);
            this.dateTimePickerДоговорДатаОкончания.Name = "dateTimePickerДоговорДатаОкончания";
            this.dateTimePickerДоговорДатаОкончания.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerДоговорДатаОкончания.TabIndex = 8;
            
            
            
            this.buttonSaveДоговор.Location = new System.Drawing.Point(10, 190);
            this.buttonSaveДоговор.Name = "buttonSaveДоговор";
            this.buttonSaveДоговор.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveДоговор.TabIndex = 9;
            this.buttonSaveДоговор.Text = "Сохранить";
            this.buttonSaveДоговор.UseVisualStyleBackColor = true;
            this.buttonSaveДоговор.Click += new System.EventHandler(this.buttonSaveДоговор_Click);
            
            
            
            this.groupBoxПлатеж.Controls.Add(this.labelПлатежДоговор);
            this.groupBoxПлатеж.Controls.Add(this.labelПлатежСумма);
            this.groupBoxПлатеж.Controls.Add(this.labelПлатежДатаОплаты);
            this.groupBoxПлатеж.Controls.Add(this.comboBoxПлатежДоговор);
            this.groupBoxПлатеж.Controls.Add(this.textBoxПлатежСумма);
            this.groupBoxПлатеж.Controls.Add(this.dateTimePickerПлатежДатаОплаты);
            this.groupBoxПлатеж.Controls.Add(this.buttonSaveПлатеж);
            this.groupBoxПлатеж.Location = new System.Drawing.Point(915, 20);
            this.groupBoxПлатеж.Name = "groupBoxПлатеж";
            this.groupBoxПлатеж.Size = new System.Drawing.Size(200, 270);
            this.groupBoxПлатеж.TabIndex = 6;
            this.groupBoxПлатеж.TabStop = false;
            this.groupBoxПлатеж.Text = "Платеж";
            
            
            
            this.labelПлатежДоговор.AutoSize = true;
            this.labelПлатежДоговор.Location = new System.Drawing.Point(10, 20);
            this.labelПлатежДоговор.Name = "labelПлатежДоговор";
            this.labelПлатежДоговор.Size = new System.Drawing.Size(63, 17);
            this.labelПлатежДоговор.TabIndex = 1;
            this.labelПлатежДоговор.Text = "Договор";
            
            
            
            this.labelПлатежСумма.AutoSize = true;
            this.labelПлатежСумма.Location = new System.Drawing.Point(10, 60);
            this.labelПлатежСумма.Name = "labelПлатежСумма";
            this.labelПлатежСумма.Size = new System.Drawing.Size(50, 17);
            this.labelПлатежСумма.TabIndex = 2;
            this.labelПлатежСумма.Text = "Сумма";
            
            
            
            this.labelПлатежДатаОплаты.AutoSize = true;
            this.labelПлатежДатаОплаты.Location = new System.Drawing.Point(10, 100);
            this.labelПлатежДатаОплаты.Name = "labelПлатежДатаОплаты";
            this.labelПлатежДатаОплаты.Size = new System.Drawing.Size(98, 17);
            this.labelПлатежДатаОплаты.TabIndex = 3;
            this.labelПлатежДатаОплаты.Text = "Дата Оплаты";
            
            
            
            this.comboBoxПлатежДоговор.FormattingEnabled = true;
            this.comboBoxПлатежДоговор.Location = new System.Drawing.Point(10, 35);
            this.comboBoxПлатежДоговор.Name = "comboBoxПлатежДоговор";
            this.comboBoxПлатежДоговор.Size = new System.Drawing.Size(180, 24);
            this.comboBoxПлатежДоговор.TabIndex = 4;
            
            
            
            this.textBoxПлатежСумма.Location = new System.Drawing.Point(10, 75);
            this.textBoxПлатежСумма.Name = "textBoxПлатежСумма";
            this.textBoxПлатежСумма.Size = new System.Drawing.Size(180, 22);
            this.textBoxПлатежСумма.TabIndex = 5;
            
            
            
            this.dateTimePickerПлатежДатаОплаты.Location = new System.Drawing.Point(10, 115);
            this.dateTimePickerПлатежДатаОплаты.Name = "dateTimePickerПлатежДатаОплаты";
            this.dateTimePickerПлатежДатаОплаты.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerПлатежДатаОплаты.TabIndex = 6;
            
            
            
            this.buttonSaveПлатеж.Location = new System.Drawing.Point(10, 150);
            this.buttonSaveПлатеж.Name = "buttonSaveПлатеж";
            this.buttonSaveПлатеж.Size = new System.Drawing.Size(180, 23);
            this.buttonSaveПлатеж.TabIndex = 7;
            this.buttonSaveПлатеж.Text = "Сохранить";
            this.buttonSaveПлатеж.UseVisualStyleBackColor = true;
            this.buttonSaveПлатеж.Click += new System.EventHandler(this.buttonSaveПлатеж_Click);
            
            
            
            this.tabPageViewData.Controls.Add(this.comboBoxВладельцы);
            this.tabPageViewData.Controls.Add(this.comboBoxДоговоры);
            this.tabPageViewData.Controls.Add(this.dataGridViewВладельцы);
            this.tabPageViewData.Controls.Add(this.dataGridViewДоговоры);
            this.tabPageViewData.Controls.Add(this.dataGridViewПлатежи);
            this.tabPageViewData.Controls.Add(this.dataGridViewСадовоеОбщество);
            this.tabPageViewData.Controls.Add(this.dataGridViewТипПочвы);
            this.tabPageViewData.Controls.Add(this.dataGridViewТипРельефа);
            this.tabPageViewData.Controls.Add(this.dataGridViewУчасток);
            this.tabPageViewData.Location = new System.Drawing.Point(4, 25);
            this.tabPageViewData.Name = "tabPageViewData";
            this.tabPageViewData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewData.Size = new System.Drawing.Size(1289, 656);
            this.tabPageViewData.TabIndex = 1;
            this.tabPageViewData.Text = "Просмотр и изменение данных";
            this.tabPageViewData.UseVisualStyleBackColor = true;
            this.tabPageViewData.Click += new System.EventHandler(this.tabPageViewData_Click);
            
            
            
            this.comboBoxВладельцы.FormattingEnabled = true;
            this.comboBoxВладельцы.Location = new System.Drawing.Point(10, 670);
            this.comboBoxВладельцы.Name = "comboBoxВладельцы";
            this.comboBoxВладельцы.Size = new System.Drawing.Size(300, 24);
            this.comboBoxВладельцы.TabIndex = 7;
            this.comboBoxВладельцы.SelectedIndexChanged += new System.EventHandler(this.comboBoxВладельцы_SelectedIndexChanged);
            
            
            
            this.dataGridViewВладельцы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewВладельцы.Location = new System.Drawing.Point(10, 20);
            this.dataGridViewВладельцы.Name = "dataGridViewВладельцы";
            this.dataGridViewВладельцы.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewВладельцы.TabIndex = 0;
            this.dataGridViewВладельцы.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewВладельцы_CellValueChanged);
            this.dataGridViewВладельцы.SelectionChanged += new System.EventHandler(this.dataGridViewВладельцы_SelectionChanged);
            
            
            
            this.dataGridViewДоговоры.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewДоговоры.Location = new System.Drawing.Point(10, 234);
            this.dataGridViewДоговоры.Name = "dataGridViewДоговоры";
            this.dataGridViewДоговоры.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewДоговоры.TabIndex = 1;
            this.dataGridViewДоговоры.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewДоговоры_CellValueChanged);
            this.dataGridViewДоговоры.SelectionChanged += new System.EventHandler(this.dataGridViewДоговоры_SelectionChanged);
            
            
            
            this.dataGridViewПлатежи.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewПлатежи.Location = new System.Drawing.Point(445, 234);
            this.dataGridViewПлатежи.Name = "dataGridViewПлатежи";
            this.dataGridViewПлатежи.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewПлатежи.TabIndex = 2;
            this.dataGridViewПлатежи.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewПлатежи_CellValueChanged);
            
            
            
            this.dataGridViewСадовоеОбщество.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewСадовоеОбщество.Location = new System.Drawing.Point(445, 20);
            this.dataGridViewСадовоеОбщество.Name = "dataGridViewСадовоеОбщество";
            this.dataGridViewСадовоеОбщество.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewСадовоеОбщество.TabIndex = 3;
            this.dataGridViewСадовоеОбщество.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewСадовоеОбщество_CellValueChanged);
           
            
            
            this.dataGridViewТипПочвы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewТипПочвы.Location = new System.Drawing.Point(873, 20);
            this.dataGridViewТипПочвы.Name = "dataGridViewТипПочвы";
            this.dataGridViewТипПочвы.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewТипПочвы.TabIndex = 4;
            this.dataGridViewТипПочвы.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewТипПочвы_CellValueChanged);
            
            
            
            this.dataGridViewТипРельефа.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewТипРельефа.Location = new System.Drawing.Point(873, 234);
            this.dataGridViewТипРельефа.Name = "dataGridViewТипРельефа";
            this.dataGridViewТипРельефа.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewТипРельефа.TabIndex = 5;
            this.dataGridViewТипРельефа.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewТипРельефа_CellValueChanged);
            
            
            
            this.dataGridViewУчасток.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewУчасток.Location = new System.Drawing.Point(351, 450);
            this.dataGridViewУчасток.Name = "dataGridViewУчасток";
            this.dataGridViewУчасток.Size = new System.Drawing.Size(610, 200);
            this.dataGridViewУчасток.TabIndex = 6;
            this.dataGridViewУчасток.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewУчасток_CellValueChanged);
            
            
            
            this.comboBoxДоговоры.FormattingEnabled = true;
            this.comboBoxДоговоры.Location = new System.Drawing.Point(320, 670);
            this.comboBoxДоговоры.Name = "comboBoxДоговоры";
            this.comboBoxДоговоры.Size = new System.Drawing.Size(300, 24);
            this.comboBoxДоговоры.TabIndex = 8;
            this.comboBoxДоговоры.SelectedIndexChanged += new System.EventHandler(this.comboBoxДоговоры_SelectedIndexChanged);
            
            
            
            this.ClientSize = new System.Drawing.Size(1328, 761);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Garden Plots DB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageAddData.ResumeLayout(false);
            this.groupBoxСадовоеОбщество.ResumeLayout(false);
            this.groupBoxСадовоеОбщество.PerformLayout();
            this.groupBoxТипРельефа.ResumeLayout(false);
            this.groupBoxТипРельефа.PerformLayout();
            this.groupBoxТипПочвы.ResumeLayout(false);
            this.groupBoxТипПочвы.PerformLayout();
            this.groupBoxВладелецУчастка.ResumeLayout(false);
            this.groupBoxВладелецУчастка.PerformLayout();
            this.groupBoxУчасток.ResumeLayout(false);
            this.groupBoxУчасток.PerformLayout();
            this.groupBoxДоговор.ResumeLayout(false);
            this.groupBoxДоговор.PerformLayout();
            this.groupBoxПлатеж.ResumeLayout(false);
            this.groupBoxПлатеж.PerformLayout();
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

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageAddData;
        private System.Windows.Forms.TabPage tabPageViewData;
        private System.Windows.Forms.GroupBox groupBoxСадовоеОбщество;
        private System.Windows.Forms.Label labelСадовоеОбществоПредседатель;
        private System.Windows.Forms.Label labelСадовоеОбществоНазвание;
        private System.Windows.Forms.TextBox textBoxСадовоеОбществоПредседатель;
        private System.Windows.Forms.TextBox textBoxСадовоеОбществоНазвание;
        private System.Windows.Forms.Button buttonSaveСадовоеОбщество;
        private System.Windows.Forms.GroupBox groupBoxТипРельефа;
        private System.Windows.Forms.Label labelТипРельефаНазвание;
        private System.Windows.Forms.TextBox textBoxТипРельефаНазвание;
        private System.Windows.Forms.Button buttonSaveТипРельефа;
        private System.Windows.Forms.GroupBox groupBoxТипПочвы;
        private System.Windows.Forms.Label labelТипПочвыНазвание;
        private System.Windows.Forms.TextBox textBoxТипПочвыНазвание;
        private System.Windows.Forms.Button buttonSaveТипПочвы;
        private System.Windows.Forms.GroupBox groupBoxВладелецУчастка;
        private System.Windows.Forms.Label labelВладелецФамилия;
        private System.Windows.Forms.Label labelВладелецИмя;
        private System.Windows.Forms.Label labelВладелецАдрес;
        private System.Windows.Forms.Label labelВладелецНомерТелефона;
        private System.Windows.Forms.TextBox textBoxВладелецФамилия;
        private System.Windows.Forms.TextBox textBoxВладелецИмя;
        private System.Windows.Forms.TextBox textBoxВладелецАдрес;
        private System.Windows.Forms.TextBox textBoxВладелецНомерТелефона;
        private System.Windows.Forms.Button buttonSaveВладелецУчастка;
        private System.Windows.Forms.GroupBox groupBoxУчасток;
        private System.Windows.Forms.Label labelУчастокСадовоеОбщество;
        private System.Windows.Forms.Label labelУчастокТипРельефа;
        private System.Windows.Forms.Label labelУчастокТипПочвы;
        private System.Windows.Forms.Label labelУчастокПлощадь;
        private System.Windows.Forms.Label labelУчастокСтатус;
        private System.Windows.Forms.ComboBox comboBoxУчастокСадовоеОбщество;
        private System.Windows.Forms.ComboBox comboBoxУчастокТипРельефа;
        private System.Windows.Forms.ComboBox comboBoxУчастокТипПочвы;
        private System.Windows.Forms.TextBox textBoxУчастокПлощадь;
        private System.Windows.Forms.ComboBox comboBoxУчастокСтатус;
        private System.Windows.Forms.Button buttonSaveУчасток;
        private System.Windows.Forms.GroupBox groupBoxДоговор;
        private System.Windows.Forms.Label labelДоговорУчасток;
        private System.Windows.Forms.Label labelДоговорВладелец;
        private System.Windows.Forms.Label labelДоговорДатаНачала;
        private System.Windows.Forms.Label labelДоговорДатаОкончания;
        private System.Windows.Forms.ComboBox comboBoxДоговорУчасток;
        private System.Windows.Forms.ComboBox comboBoxДоговорВладелец;
        private System.Windows.Forms.DateTimePicker dateTimePickerДоговорДатаНачала;
        private System.Windows.Forms.DateTimePicker dateTimePickerДоговорДатаОкончания;
        private System.Windows.Forms.Button buttonSaveДоговор;
        private System.Windows.Forms.GroupBox groupBoxПлатеж;
        private System.Windows.Forms.Label labelПлатежДоговор;
        private System.Windows.Forms.Label labelПлатежСумма;
        private System.Windows.Forms.Label labelПлатежДатаОплаты;
        private System.Windows.Forms.ComboBox comboBoxПлатежДоговор;
        private System.Windows.Forms.TextBox textBoxПлатежСумма;
        private System.Windows.Forms.DateTimePicker dateTimePickerПлатежДатаОплаты;
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
    }
}
