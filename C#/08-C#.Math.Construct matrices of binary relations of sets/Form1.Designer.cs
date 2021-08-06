namespace WindowsFormsApp1
{
    partial class Form1
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
            this.labelSetA = new System.Windows.Forms.Label();
            this.textBoxSetA = new System.Windows.Forms.TextBox();
            this.textBoxSetB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonToBuild = new System.Windows.Forms.Button();
            this.dataGridMatrix = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSetA
            // 
            this.labelSetA.AutoSize = true;
            this.labelSetA.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetA.ForeColor = System.Drawing.Color.Black;
            this.labelSetA.Location = new System.Drawing.Point(19, 423);
            this.labelSetA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSetA.Name = "labelSetA";
            this.labelSetA.Size = new System.Drawing.Size(185, 29);
            this.labelSetA.TabIndex = 0;
            this.labelSetA.Text = "Множина А = {";
            // 
            // textBoxSetA
            // 
            this.textBoxSetA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSetA.Location = new System.Drawing.Point(215, 422);
            this.textBoxSetA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSetA.Name = "textBoxSetA";
            this.textBoxSetA.Size = new System.Drawing.Size(347, 34);
            this.textBoxSetA.TabIndex = 2;
            this.textBoxSetA.TextChanged += new System.EventHandler(this.textBoxSetA_TextChanged);
            // 
            // textBoxSetB
            // 
            this.textBoxSetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSetB.Location = new System.Drawing.Point(215, 485);
            this.textBoxSetB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSetB.Name = "textBoxSetB";
            this.textBoxSetB.Size = new System.Drawing.Size(347, 34);
            this.textBoxSetB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(571, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "}";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonToBuild
            // 
            this.buttonToBuild.BackColor = System.Drawing.Color.White;
            this.buttonToBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToBuild.ForeColor = System.Drawing.Color.Black;
            this.buttonToBuild.Location = new System.Drawing.Point(719, 422);
            this.buttonToBuild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToBuild.Name = "buttonToBuild";
            this.buttonToBuild.Size = new System.Drawing.Size(187, 46);
            this.buttonToBuild.TabIndex = 6;
            this.buttonToBuild.Text = "Відповідь";
            this.buttonToBuild.UseVisualStyleBackColor = false;
            this.buttonToBuild.Click += new System.EventHandler(this.ButtonToBuild_Click);
            // 
            // dataGridMatrix
            // 
            this.dataGridMatrix.AllowUserToAddRows = false;
            this.dataGridMatrix.AllowUserToDeleteRows = false;
            this.dataGridMatrix.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrix.Location = new System.Drawing.Point(31, 33);
            this.dataGridMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridMatrix.Name = "dataGridMatrix";
            this.dataGridMatrix.ReadOnly = true;
            this.dataGridMatrix.RowHeadersWidth = 51;
            this.dataGridMatrix.Size = new System.Drawing.Size(1212, 319);
            this.dataGridMatrix.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 485);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Множина B = {";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(571, 490);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "}";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridMatrix);
            this.Controls.Add(this.buttonToBuild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSetB);
            this.Controls.Add(this.textBoxSetA);
            this.Controls.Add(this.labelSetA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSetA;
        private System.Windows.Forms.TextBox textBoxSetA;
        private System.Windows.Forms.TextBox textBoxSetB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonToBuild;
        private System.Windows.Forms.DataGridView dataGridMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

