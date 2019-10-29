namespace MarketClientForms
{
    partial class ProductForm
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
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.controlTextBox = new ClassLibraryControlInput.ControlTextBox();
            this.controlComboListBox = new ClassLibraryControlSelected.ControlComboListBox();
            this.controlDataGridView1 = new ClassLibraryControlOut.ControlDataGridView();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(12, 132);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(96, 23);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Сменить товар";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите сумму:";
            // 
            // controlTextBox
            // 
            this.controlTextBox.Location = new System.Drawing.Point(233, 28);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Size = new System.Drawing.Size(198, 28);
            this.controlTextBox.TabIndex = 3;
            // 
            // controlComboListBox
            // 
            this.controlComboListBox.Location = new System.Drawing.Point(12, 12);
            this.controlComboListBox.Name = "controlComboListBox";
            this.controlComboListBox.SelectedIndex = 0;
            this.controlComboListBox.Size = new System.Drawing.Size(215, 114);
            this.controlComboListBox.TabIndex = 1;
            this.controlComboListBox.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected_ComboBoxSelectedElementChange);
            // 
            // controlDataGridView1
            // 
            this.controlDataGridView1.Location = new System.Drawing.Point(232, 59);
            this.controlDataGridView1.Name = "controlDataGridView1";
            this.controlDataGridView1.Size = new System.Drawing.Size(250, 166);
            this.controlDataGridView1.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 237);
            this.Controls.Add(this.controlDataGridView1);
            this.Controls.Add(this.controlTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlComboListBox);
            this.Controls.Add(this.buttonChange);
            this.Name = "ProductForm";
            this.Text = "Тестовая форма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChange;
        private ClassLibraryControlSelected.ControlComboListBox controlComboListBox;
        private System.Windows.Forms.Label label1;
        private ClassLibraryControlInput.ControlTextBox controlTextBox;
        private ClassLibraryControlOut.ControlDataGridView controlDataGridView1;
    }
}

