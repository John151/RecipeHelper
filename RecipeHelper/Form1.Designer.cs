namespace RecipeHelper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtMililitres = new System.Windows.Forms.TextBox();
            this.btnTempConvert = new System.Windows.Forms.Button();
            this.btnVolumeConvert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCups = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mililitres";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(84, 54);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 2;
            // 
            // txtMililitres
            // 
            this.txtMililitres.Location = new System.Drawing.Point(299, 54);
            this.txtMililitres.Name = "txtMililitres";
            this.txtMililitres.Size = new System.Drawing.Size(100, 20);
            this.txtMililitres.TabIndex = 3;
            // 
            // btnTempConvert
            // 
            this.btnTempConvert.Location = new System.Drawing.Point(84, 103);
            this.btnTempConvert.Name = "btnTempConvert";
            this.btnTempConvert.Size = new System.Drawing.Size(76, 37);
            this.btnTempConvert.TabIndex = 4;
            this.btnTempConvert.Text = "Convert to Fahrenheit";
            this.btnTempConvert.UseVisualStyleBackColor = true;
            this.btnTempConvert.Click += new System.EventHandler(this.btnTempConvert_Click);
            // 
            // btnVolumeConvert
            // 
            this.btnVolumeConvert.Location = new System.Drawing.Point(299, 103);
            this.btnVolumeConvert.Name = "btnVolumeConvert";
            this.btnVolumeConvert.Size = new System.Drawing.Size(82, 37);
            this.btnVolumeConvert.TabIndex = 5;
            this.btnVolumeConvert.Text = "Convert to Cups";
            this.btnVolumeConvert.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fahrenheit";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(84, 179);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.ReadOnly = true;
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cups";
            // 
            // txtCups
            // 
            this.txtCups.Location = new System.Drawing.Point(299, 182);
            this.txtCups.Name = "txtCups";
            this.txtCups.ReadOnly = true;
            this.txtCups.Size = new System.Drawing.Size(100, 20);
            this.txtCups.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 260);
            this.Controls.Add(this.txtCups);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolumeConvert);
            this.Controls.Add(this.btnTempConvert);
            this.Controls.Add(this.txtMililitres);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Recipe Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtMililitres;
        private System.Windows.Forms.Button btnTempConvert;
        private System.Windows.Forms.Button btnVolumeConvert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCups;
    }
}

