namespace LABS_2_PR
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
            button2 = new Button();
            btnShowObjects = new Button();
            panelCreateObject = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            textBox7 = new TextBox();
            txtAdminPosition = new TextBox();
            textBox4 = new TextBox();
            txtAdminSubordinates = new TextBox();
            textBox8 = new TextBox();
            txtAdminResponsibilities = new TextBox();
            textBox9 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnSaveObject = new Button();
            panelCreateObject.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(465, 367);
            button2.Name = "button2";
            button2.Size = new Size(147, 71);
            button2.TabIndex = 1;
            button2.Text = "Найти объект";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnShowObjects
            // 
            btnShowObjects.Location = new Point(312, 367);
            btnShowObjects.Name = "btnShowObjects";
            btnShowObjects.Size = new Size(147, 71);
            btnShowObjects.TabIndex = 2;
            btnShowObjects.Text = "Показать объекты";
            btnShowObjects.UseVisualStyleBackColor = true;
            // 
            // panelCreateObject
            // 
            panelCreateObject.Controls.Add(label4);
            panelCreateObject.Controls.Add(label3);
            panelCreateObject.Controls.Add(label2);
            panelCreateObject.Controls.Add(label1);
            panelCreateObject.Controls.Add(button3);
            panelCreateObject.Controls.Add(textBox7);
            panelCreateObject.Controls.Add(txtAdminPosition);
            panelCreateObject.Controls.Add(textBox4);
            panelCreateObject.Controls.Add(txtAdminSubordinates);
            panelCreateObject.Controls.Add(textBox8);
            panelCreateObject.Controls.Add(txtAdminResponsibilities);
            panelCreateObject.Controls.Add(textBox9);
            panelCreateObject.Controls.Add(textBox5);
            panelCreateObject.Controls.Add(textBox3);
            panelCreateObject.Controls.Add(textBox6);
            panelCreateObject.Controls.Add(textBox2);
            panelCreateObject.Controls.Add(textBox1);
            panelCreateObject.Location = new Point(12, 49);
            panelCreateObject.Name = "panelCreateObject";
            panelCreateObject.Size = new Size(762, 298);
            panelCreateObject.TabIndex = 3;
            panelCreateObject.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 9;
            label4.Text = "Инженер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Кадры";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "Работник";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 6;
            label1.Text = "Администрация";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(319, 192);
            button3.Name = "button3";
            button3.Size = new Size(118, 46);
            button3.TabIndex = 3;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(659, 29);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 5;
            // 
            // txtAdminPosition
            // 
            txtAdminPosition.Location = new Point(54, 29);
            txtAdminPosition.Name = "txtAdminPosition";
            txtAdminPosition.Size = new Size(100, 23);
            txtAdminPosition.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(427, 29);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // txtAdminSubordinates
            // 
            txtAdminSubordinates.Location = new Point(54, 87);
            txtAdminSubordinates.Name = "txtAdminSubordinates";
            txtAdminSubordinates.Size = new Size(100, 23);
            txtAdminSubordinates.TabIndex = 4;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(659, 87);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 4;
            // 
            // txtAdminResponsibilities
            // 
            txtAdminResponsibilities.Location = new Point(54, 58);
            txtAdminResponsibilities.Name = "txtAdminResponsibilities";
            txtAdminResponsibilities.Size = new Size(100, 23);
            txtAdminResponsibilities.TabIndex = 3;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(659, 58);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(427, 87);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(234, 29);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(427, 58);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 3;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // btnSaveObject
            // 
            btnSaveObject.Location = new Point(159, 367);
            btnSaveObject.Name = "btnSaveObject";
            btnSaveObject.Size = new Size(147, 71);
            btnSaveObject.TabIndex = 6;
            btnSaveObject.Text = "Создать объекты";
            btnSaveObject.UseVisualStyleBackColor = true;
            btnSaveObject.Click += btnCreateObject_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnShowObjects);
            Controls.Add(panelCreateObject);
            Controls.Add(btnSaveObject);
            Name = "Form1";
            Text = "LABS_2";
            panelCreateObject.ResumeLayout(false);
            panelCreateObject.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button btnShowObjects;
        private Panel panelCreateObject;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button button3;
        private TextBox txtAdminPosition;
        private TextBox txtAdminSubordinates;
        private TextBox txtAdminResponsibilities;
        private Button btnSaveObject;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
