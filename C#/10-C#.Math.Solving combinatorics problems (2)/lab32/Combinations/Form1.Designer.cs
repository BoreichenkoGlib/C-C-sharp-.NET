namespace Combinations
{
    partial class Form1
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
            this.buttonResult = new System.Windows.Forms.Button();
            this.comboBoxCombination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxKArr = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.labelNk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(505, 344);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(145, 39);
            this.buttonResult.TabIndex = 0;
            this.buttonResult.Text = "Розв`язати";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // comboBoxCombination
            // 
            this.comboBoxCombination.FormattingEnabled = true;
            this.comboBoxCombination.Items.AddRange(new object[] {
            "Розміщення з повторенням",
            "Розміщення без повторень",
            "Сполучення без повтореннь",
            "Сполучення з повторенням",
            "Перестановки без повтореннь",
            "Перестановки з повторенням"});
            this.comboBoxCombination.Location = new System.Drawing.Point(280, 84);
            this.comboBoxCombination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCombination.Name = "comboBoxCombination";
            this.comboBoxCombination.Size = new System.Drawing.Size(253, 21);
            this.comboBoxCombination.TabIndex = 1;
            this.comboBoxCombination.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxCombination_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Виберіть комбінацію:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введіть n:";
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.Location = new System.Drawing.Point(61, 261);
            this.labelK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(86, 20);
            this.labelK.TabIndex = 4;
            this.labelK.Text = "Введіть k:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Відповідь:";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(280, 177);
            this.numericUpDownN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(138, 20);
            this.numericUpDownN.TabIndex = 6;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Location = new System.Drawing.Point(280, 261);
            this.numericUpDownK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(138, 20);
            this.numericUpDownK.TabIndex = 7;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(280, 357);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(139, 20);
            this.textBoxResult.TabIndex = 8;
            // 
            // textBoxKArr
            // 
            this.textBoxKArr.Location = new System.Drawing.Point(280, 260);
            this.textBoxKArr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKArr.Name = "textBoxKArr";
            this.textBoxKArr.Size = new System.Drawing.Size(139, 20);
            this.textBoxKArr.TabIndex = 9;
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Location = new System.Drawing.Point(505, 152);
            this.pictureBoxFormula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(295, 157);
            this.pictureBoxFormula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula.TabIndex = 10;
            this.pictureBoxFormula.TabStop = false;
            // 
            // labelNk
            // 
            this.labelNk.AutoSize = true;
            this.labelNk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNk.Location = new System.Drawing.Point(61, 261);
            this.labelNk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNk.Name = "labelNk";
            this.labelNk.Size = new System.Drawing.Size(155, 20);
            this.labelNk.TabIndex = 11;
            this.labelNk.Text = "Введіть n1,n2 ... nk:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 478);
            this.Controls.Add(this.labelNk);
            this.Controls.Add(this.pictureBoxFormula);
            this.Controls.Add(this.textBoxKArr);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.numericUpDownK);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCombination);
            this.Controls.Add(this.buttonResult);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.ComboBox comboBoxCombination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxKArr;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.Label labelNk;
    }
}

