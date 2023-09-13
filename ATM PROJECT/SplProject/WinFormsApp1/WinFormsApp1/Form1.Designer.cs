namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            inventoryname1 = new DataGridView();
            newbutton = new Button();
            master1 = new Button();
            master3 = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryname1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(457, 27);
            label1.Name = "label1";
            label1.Size = new Size(345, 44);
            label1.TabIndex = 0;
            label1.Text = "inventory model";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // inventoryname1
            // 
            inventoryname1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryname1.Location = new Point(7, 141);
            inventoryname1.Name = "inventoryname1";
            inventoryname1.RowHeadersWidth = 62;
            inventoryname1.RowTemplate.Height = 33;
            inventoryname1.Size = new Size(1380, 458);
            inventoryname1.TabIndex = 2;
            inventoryname1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // newbutton
            // 
            newbutton.Location = new Point(53, 150);
            newbutton.Name = "newbutton";
            newbutton.Size = new Size(148, 43);
            newbutton.TabIndex = 3;
            newbutton.Text = "add";
            newbutton.UseVisualStyleBackColor = true;
            newbutton.Click += newbutton_Click;
            // 
            // master1
            // 
            master1.Location = new Point(330, 150);
            master1.Name = "master1";
            master1.Size = new Size(148, 43);
            master1.TabIndex = 4;
            master1.Text = "save";
            master1.UseVisualStyleBackColor = true;
            master1.Click += button1_Click;
            // 
            // master3
            // 
            master3.Location = new Point(710, 150);
            master3.Name = "master3";
            master3.Size = new Size(148, 43);
            master3.TabIndex = 6;
            master3.Text = "delete";
            master3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1423, 611);
            Controls.Add(master3);
            Controls.Add(master1);
            Controls.Add(newbutton);
            Controls.Add(inventoryname1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = Color.CornflowerBlue;
            Name = "Form1";
            Text = "InventoryBackground";
            ((System.ComponentModel.ISupportInitialize)inventoryname1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView inventoryname1;
        private Button newbutton;
        private Button master1;
        private Button master3;
    }
}