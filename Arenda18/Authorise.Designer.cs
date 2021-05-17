
namespace Arenda18
{
    partial class Authorise
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorise));
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.BackColor = System.Drawing.SystemColors.Control;
            логинLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            логинLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            логинLabel.Location = new System.Drawing.Point(25, 138);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(73, 22);
            логинLabel.TabIndex = 3;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.BackColor = System.Drawing.SystemColors.Control;
            парольLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            парольLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            парольLabel.Location = new System.Drawing.Point(25, 194);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(90, 22);
            парольLabel.TabIndex = 7;
            парольLabel.Text = "Пароль:";
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Логин", true));
            this.логинTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.логинTextBox.Location = new System.Drawing.Point(132, 138);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(190, 29);
            this.логинTextBox.TabIndex = 4;
            this.логинTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.логинTextBox_KeyPress);
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataSource = typeof(Arenda18.Сотрудники);
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "Пароль", true));
            this.парольTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.парольTextBox.Location = new System.Drawing.Point(132, 194);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(190, 29);
            this.парольTextBox.TabIndex = 8;
            this.парольTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.парольTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(128)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Авторизация";
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(133)))), ((int)(((byte)(86)))), ((int)(((byte)(106)))));
            this.Enter.Location = new System.Drawing.Point(16, 265);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(119, 45);
            this.Enter.TabIndex = 16;
            this.Enter.Text = "Войти";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 100);
            this.panel1.TabIndex = 17;
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
            // Authorise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Name = "Authorise";
            this.Text = "Форма авторизации";
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

