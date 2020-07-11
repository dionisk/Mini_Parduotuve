namespace Mini_Parduotuve
{
    partial class AddToBasketForm
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
            this.button_AtsauktiPrekesPridejimaIKrepseli = new System.Windows.Forms.Button();
            this.button_PridetiIKrepseli = new System.Windows.Forms.Button();
            this.label_PrekesPasirinkimas = new System.Windows.Forms.Label();
            this.comboBox_PrekiuSarasas = new System.Windows.Forms.ComboBox();
            this.label_PasirinktosPrekesKaina = new System.Windows.Forms.Label();
            this.textBox_PasirinktosPrekesKaina = new System.Windows.Forms.TextBox();
            this.label_PasirinktosPrekesVienetuSk = new System.Windows.Forms.Label();
            this.numericUpDown_PasirinktosPrekesVienetuSk = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PasirinktosPrekesVienetuSk)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AtsauktiPrekesPridejimaIKrepseli
            // 
            this.button_AtsauktiPrekesPridejimaIKrepseli.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_AtsauktiPrekesPridejimaIKrepseli.Location = new System.Drawing.Point(235, 175);
            this.button_AtsauktiPrekesPridejimaIKrepseli.Name = "button_AtsauktiPrekesPridejimaIKrepseli";
            this.button_AtsauktiPrekesPridejimaIKrepseli.Size = new System.Drawing.Size(75, 23);
            this.button_AtsauktiPrekesPridejimaIKrepseli.TabIndex = 0;
            this.button_AtsauktiPrekesPridejimaIKrepseli.Text = "Atšaukti";
            this.button_AtsauktiPrekesPridejimaIKrepseli.UseVisualStyleBackColor = true;
            this.button_AtsauktiPrekesPridejimaIKrepseli.Click += new System.EventHandler(this.button_AtsauktiPrekesPridejimaIKrepseli_Click);
            // 
            // button_PridetiIKrepseli
            // 
            this.button_PridetiIKrepseli.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_PridetiIKrepseli.Location = new System.Drawing.Point(147, 175);
            this.button_PridetiIKrepseli.Name = "button_PridetiIKrepseli";
            this.button_PridetiIKrepseli.Size = new System.Drawing.Size(75, 23);
            this.button_PridetiIKrepseli.TabIndex = 1;
            this.button_PridetiIKrepseli.Text = "Pridėti";
            this.button_PridetiIKrepseli.UseVisualStyleBackColor = true;
            this.button_PridetiIKrepseli.Click += new System.EventHandler(this.button_PridetiIKrepseli_Click);
            // 
            // label_PrekesPasirinkimas
            // 
            this.label_PrekesPasirinkimas.AutoSize = true;
            this.label_PrekesPasirinkimas.Location = new System.Drawing.Point(13, 39);
            this.label_PrekesPasirinkimas.Name = "label_PrekesPasirinkimas";
            this.label_PrekesPasirinkimas.Size = new System.Drawing.Size(88, 13);
            this.label_PrekesPasirinkimas.TabIndex = 2;
            this.label_PrekesPasirinkimas.Text = "Pasirinkite prekę:";
            // 
            // comboBox_PrekiuSarasas
            // 
            this.comboBox_PrekiuSarasas.FormattingEnabled = true;
            this.comboBox_PrekiuSarasas.Location = new System.Drawing.Point(164, 39);
            this.comboBox_PrekiuSarasas.Name = "comboBox_PrekiuSarasas";
            this.comboBox_PrekiuSarasas.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PrekiuSarasas.TabIndex = 3;
            this.comboBox_PrekiuSarasas.SelectedIndexChanged += new System.EventHandler(this.comboBox_PrekiuSarasas_SelectedIndexChanged);
            // 
            // label_PasirinktosPrekesKaina
            // 
            this.label_PasirinktosPrekesKaina.AutoSize = true;
            this.label_PasirinktosPrekesKaina.Location = new System.Drawing.Point(16, 84);
            this.label_PasirinktosPrekesKaina.Name = "label_PasirinktosPrekesKaina";
            this.label_PasirinktosPrekesKaina.Size = new System.Drawing.Size(163, 13);
            this.label_PasirinktosPrekesKaina.TabIndex = 4;
            this.label_PasirinktosPrekesKaina.Text = "Pasirinktos prekės vieneto kaina:";
            // 
            // textBox_PasirinktosPrekesKaina
            // 
            this.textBox_PasirinktosPrekesKaina.Enabled = false;
            this.textBox_PasirinktosPrekesKaina.Location = new System.Drawing.Point(185, 81);
            this.textBox_PasirinktosPrekesKaina.Name = "textBox_PasirinktosPrekesKaina";
            this.textBox_PasirinktosPrekesKaina.Size = new System.Drawing.Size(100, 20);
            this.textBox_PasirinktosPrekesKaina.TabIndex = 5;
            // 
            // label_PasirinktosPrekesVienetuSk
            // 
            this.label_PasirinktosPrekesVienetuSk.AutoSize = true;
            this.label_PasirinktosPrekesVienetuSk.Location = new System.Drawing.Point(16, 130);
            this.label_PasirinktosPrekesVienetuSk.Name = "label_PasirinktosPrekesVienetuSk";
            this.label_PasirinktosPrekesVienetuSk.Size = new System.Drawing.Size(148, 13);
            this.label_PasirinktosPrekesVienetuSk.TabIndex = 6;
            this.label_PasirinktosPrekesVienetuSk.Text = "Kiek prekės vienetų renkatės:";
            // 
            // numericUpDown_PasirinktosPrekesVienetuSk
            // 
            this.numericUpDown_PasirinktosPrekesVienetuSk.Location = new System.Drawing.Point(185, 128);
            this.numericUpDown_PasirinktosPrekesVienetuSk.Name = "numericUpDown_PasirinktosPrekesVienetuSk";
            this.numericUpDown_PasirinktosPrekesVienetuSk.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_PasirinktosPrekesVienetuSk.TabIndex = 7;
            this.numericUpDown_PasirinktosPrekesVienetuSk.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddToBasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 219);
            this.Controls.Add(this.numericUpDown_PasirinktosPrekesVienetuSk);
            this.Controls.Add(this.label_PasirinktosPrekesVienetuSk);
            this.Controls.Add(this.textBox_PasirinktosPrekesKaina);
            this.Controls.Add(this.label_PasirinktosPrekesKaina);
            this.Controls.Add(this.comboBox_PrekiuSarasas);
            this.Controls.Add(this.label_PrekesPasirinkimas);
            this.Controls.Add(this.button_PridetiIKrepseli);
            this.Controls.Add(this.button_AtsauktiPrekesPridejimaIKrepseli);
            this.Name = "AddToBasketForm";
            this.Text = "Prekės pridėjimas į krepšelį";
            this.Load += new System.EventHandler(this.AddToBasketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PasirinktosPrekesVienetuSk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AtsauktiPrekesPridejimaIKrepseli;
        private System.Windows.Forms.Button button_PridetiIKrepseli;
        private System.Windows.Forms.Label label_PrekesPasirinkimas;
        private System.Windows.Forms.ComboBox comboBox_PrekiuSarasas;
        private System.Windows.Forms.Label label_PasirinktosPrekesKaina;
        private System.Windows.Forms.TextBox textBox_PasirinktosPrekesKaina;
        private System.Windows.Forms.Label label_PasirinktosPrekesVienetuSk;
        private System.Windows.Forms.NumericUpDown numericUpDown_PasirinktosPrekesVienetuSk;
    }
}