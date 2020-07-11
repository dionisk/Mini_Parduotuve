namespace Mini_Parduotuve
{
    partial class Main_Form
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
            this.button_RinktisPrekesIKrepseli = new System.Windows.Forms.Button();
            this.dataGridView_PrekiuKatalogas = new System.Windows.Forms.DataGridView();
            this.label_PrekiuKatalogas = new System.Windows.Forms.Label();
            this.button_PatikrintiPirkiniuKrepseli = new System.Windows.Forms.Button();
            this.button_FormuotiSiunta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrekiuKatalogas)).BeginInit();
            this.SuspendLayout();
            // 
            // button_RinktisPrekesIKrepseli
            // 
            this.button_RinktisPrekesIKrepseli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RinktisPrekesIKrepseli.Location = new System.Drawing.Point(632, 23);
            this.button_RinktisPrekesIKrepseli.Name = "button_RinktisPrekesIKrepseli";
            this.button_RinktisPrekesIKrepseli.Size = new System.Drawing.Size(134, 23);
            this.button_RinktisPrekesIKrepseli.TabIndex = 0;
            this.button_RinktisPrekesIKrepseli.Text = "Pridėti prekę į krepšelį";
            this.button_RinktisPrekesIKrepseli.UseVisualStyleBackColor = true;
            this.button_RinktisPrekesIKrepseli.Click += new System.EventHandler(this.button_RinktisPrekesIKrepseli_Click);
            // 
            // dataGridView_PrekiuKatalogas
            // 
            this.dataGridView_PrekiuKatalogas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PrekiuKatalogas.Location = new System.Drawing.Point(77, 74);
            this.dataGridView_PrekiuKatalogas.Name = "dataGridView_PrekiuKatalogas";
            this.dataGridView_PrekiuKatalogas.Size = new System.Drawing.Size(240, 263);
            this.dataGridView_PrekiuKatalogas.TabIndex = 1;
            // 
            // label_PrekiuKatalogas
            // 
            this.label_PrekiuKatalogas.AutoSize = true;
            this.label_PrekiuKatalogas.Location = new System.Drawing.Point(74, 45);
            this.label_PrekiuKatalogas.Name = "label_PrekiuKatalogas";
            this.label_PrekiuKatalogas.Size = new System.Drawing.Size(86, 13);
            this.label_PrekiuKatalogas.TabIndex = 2;
            this.label_PrekiuKatalogas.Text = "Prekių katalogas";
            // 
            // button_PatikrintiPirkiniuKrepseli
            // 
            this.button_PatikrintiPirkiniuKrepseli.Location = new System.Drawing.Point(632, 74);
            this.button_PatikrintiPirkiniuKrepseli.Name = "button_PatikrintiPirkiniuKrepseli";
            this.button_PatikrintiPirkiniuKrepseli.Size = new System.Drawing.Size(134, 23);
            this.button_PatikrintiPirkiniuKrepseli.TabIndex = 3;
            this.button_PatikrintiPirkiniuKrepseli.Text = "Patikrinti pirkinių krepšelį";
            this.button_PatikrintiPirkiniuKrepseli.UseVisualStyleBackColor = true;
            this.button_PatikrintiPirkiniuKrepseli.Click += new System.EventHandler(this.button_PatikrintiPirkiniuKrepseli_Click);
            // 
            // button_FormuotiSiunta
            // 
            this.button_FormuotiSiunta.Location = new System.Drawing.Point(632, 126);
            this.button_FormuotiSiunta.Name = "button_FormuotiSiunta";
            this.button_FormuotiSiunta.Size = new System.Drawing.Size(134, 23);
            this.button_FormuotiSiunta.TabIndex = 4;
            this.button_FormuotiSiunta.Text = "Formuoti siuntą";
            this.button_FormuotiSiunta.UseVisualStyleBackColor = true;
            this.button_FormuotiSiunta.Click += new System.EventHandler(this.button_FormuotiSiunta_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_FormuotiSiunta);
            this.Controls.Add(this.button_PatikrintiPirkiniuKrepseli);
            this.Controls.Add(this.label_PrekiuKatalogas);
            this.Controls.Add(this.dataGridView_PrekiuKatalogas);
            this.Controls.Add(this.button_RinktisPrekesIKrepseli);
            this.Name = "Main_Form";
            this.Text = "Pagrindinis langas";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrekiuKatalogas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_RinktisPrekesIKrepseli;
        private System.Windows.Forms.DataGridView dataGridView_PrekiuKatalogas;
        private System.Windows.Forms.Label label_PrekiuKatalogas;
        private System.Windows.Forms.Button button_PatikrintiPirkiniuKrepseli;
        private System.Windows.Forms.Button button_FormuotiSiunta;
    }
}

