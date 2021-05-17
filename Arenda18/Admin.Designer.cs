
namespace Arenda18
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_СотрудникаLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label рольLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label фотоLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.Label номерLabel;
            this.iD_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.рольTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.фотоPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.номерMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            iD_СотрудникаLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            рольLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            фотоLabel = new System.Windows.Forms.Label();
            номерLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_СотрудникаLabel
            // 
            iD_СотрудникаLabel.AutoSize = true;
            iD_СотрудникаLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_СотрудникаLabel.Location = new System.Drawing.Point(36, 116);
            iD_СотрудникаLabel.Name = "iD_СотрудникаLabel";
            iD_СотрудникаLabel.Size = new System.Drawing.Size(155, 22);
            iD_СотрудникаLabel.TabIndex = 1;
            iD_СотрудникаLabel.Text = "ID Сотрудника:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            логинLabel.Location = new System.Drawing.Point(36, 164);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(73, 22);
            логинLabel.TabIndex = 3;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            парольLabel.Location = new System.Drawing.Point(36, 265);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(90, 22);
            парольLabel.TabIndex = 7;
            парольLabel.Text = "Пароль:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            полLabel.Location = new System.Drawing.Point(36, 314);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(55, 22);
            полLabel.TabIndex = 9;
            полLabel.Text = "Пол:";
            // 
            // рольLabel
            // 
            рольLabel.AutoSize = true;
            рольLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            рольLabel.Location = new System.Drawing.Point(36, 361);
            рольLabel.Name = "рольLabel";
            рольLabel.Size = new System.Drawing.Size(66, 22);
            рольLabel.TabIndex = 11;
            рольLabel.Text = "Роль:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИОLabel.Location = new System.Drawing.Point(36, 408);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(62, 22);
            фИОLabel.TabIndex = 13;
            фИОLabel.Text = "ФИО:";
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фотоLabel.Location = new System.Drawing.Point(642, 108);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(56, 23);
            фотоLabel.TabIndex = 15;
            фотоLabel.Text = "Фото:";
            // 
            // iD_СотрудникаTextBox
            // 
            this.iD_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ID_Сотрудника", true));
            this.iD_СотрудникаTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_СотрудникаTextBox.Location = new System.Drawing.Point(208, 113);
            this.iD_СотрудникаTextBox.Name = "iD_СотрудникаTextBox";
            this.iD_СотрудникаTextBox.Size = new System.Drawing.Size(100, 29);
            this.iD_СотрудникаTextBox.TabIndex = 2;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataSource = typeof(Arenda18.Сотрудники);
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Логин", true));
            this.логинTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.логинTextBox.Location = new System.Drawing.Point(208, 161);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(100, 29);
            this.логинTextBox.TabIndex = 4;
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пароль", true));
            this.парольTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.парольTextBox.Location = new System.Drawing.Point(208, 262);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(100, 29);
            this.парольTextBox.TabIndex = 8;
            // 
            // рольTextBox
            // 
            this.рольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Роль", true));
            this.рольTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.рольTextBox.Location = new System.Drawing.Point(208, 358);
            this.рольTextBox.Name = "рольTextBox";
            this.рольTextBox.Size = new System.Drawing.Size(100, 29);
            this.рольTextBox.TabIndex = 12;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИОTextBox.Location = new System.Drawing.Point(208, 405);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 29);
            this.фИОTextBox.TabIndex = 14;
            // 
            // фотоPictureBox
            // 
            this.фотоPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.сотрудникиBindingSource, "Фото", true));
            this.фотоPictureBox.Location = new System.Drawing.Point(612, 134);
            this.фотоPictureBox.Name = "фотоPictureBox";
            this.фотоPictureBox.Size = new System.Drawing.Size(151, 144);
            this.фотоPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.фотоPictureBox.TabIndex = 16;
            this.фотоPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 100);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(325, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Регистрация новых сотрудников";
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.Register.Location = new System.Drawing.Point(52, 455);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(208, 46);
            this.Register.TabIndex = 19;
            this.Register.Text = "Зарегистрировать";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Photo
            // 
            this.Photo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Photo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.Photo.Location = new System.Drawing.Point(575, 290);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(208, 46);
            this.Photo.TabIndex = 20;
            this.Photo.Text = "Выбрать";
            this.Photo.UseVisualStyleBackColor = true;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.сотрудникиBindingSource, "Пол", true));
            this.comboBox1.DataSource = this.сотрудникиBindingSource;
            this.comboBox1.DisplayMember = "Пол";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "Пол";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.button1.Location = new System.Drawing.Point(368, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // номерLabel
            // 
            номерLabel.AutoSize = true;
            номерLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номерLabel.Location = new System.Drawing.Point(36, 216);
            номерLabel.Name = "номерLabel";
            номерLabel.Size = new System.Drawing.Size(80, 24);
            номерLabel.TabIndex = 23;
            номерLabel.Text = "Номер:";
            // 
            // номерMaskedTextBox
            // 
            this.номерMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Номер", true));
            this.номерMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номерMaskedTextBox.Location = new System.Drawing.Point(208, 213);
            this.номерMaskedTextBox.Name = "номерMaskedTextBox";
            this.номерMaskedTextBox.Size = new System.Drawing.Size(100, 29);
            this.номерMaskedTextBox.TabIndex = 24;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 559);
            this.Controls.Add(номерLabel);
            this.Controls.Add(this.номерMaskedTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.panel1);
            this.Controls.Add(фотоLabel);
            this.Controls.Add(this.фотоPictureBox);
            this.Controls.Add(iD_СотрудникаLabel);
            this.Controls.Add(this.iD_СотрудникаTextBox);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(полLabel);
            this.Controls.Add(рольLabel);
            this.Controls.Add(this.рольTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.TextBox iD_СотрудникаTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.TextBox рольTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.PictureBox фотоPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Photo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox номерMaskedTextBox;
    }
}