namespace Mini_Parduotuve
{
    partial class BasketReviewForm
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
            this.dataGridView_PasirinktosPrekes = new System.Windows.Forms.DataGridView();
            this.label_PasirinktosPrekes = new System.Windows.Forms.Label();
            this.label_ApsipirkimoSuma = new System.Windows.Forms.Label();
            this.ApsipirkimoSuma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PasirinktosPrekes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_PasirinktosPrekes
            // 
            this.dataGridView_PasirinktosPrekes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PasirinktosPrekes.Location = new System.Drawing.Point(33, 69);
            this.dataGridView_PasirinktosPrekes.Name = "dataGridView_PasirinktosPrekes";
            this.dataGridView_PasirinktosPrekes.Size = new System.Drawing.Size(240, 242);
            this.dataGridView_PasirinktosPrekes.TabIndex = 0;
            // 
            // label_PasirinktosPrekes
            // 
            this.label_PasirinktosPrekes.AutoSize = true;
            this.label_PasirinktosPrekes.Location = new System.Drawing.Point(33, 25);
            this.label_PasirinktosPrekes.Name = "label_PasirinktosPrekes";
            this.label_PasirinktosPrekes.Size = new System.Drawing.Size(127, 13);
            this.label_PasirinktosPrekes.TabIndex = 1;
            this.label_PasirinktosPrekes.Text = "Pasirinktų prekių sąrašas:";
            // 
            // label_ApsipirkimoSuma
            // 
            this.label_ApsipirkimoSuma.AutoSize = true;
            this.label_ApsipirkimoSuma.Location = new System.Drawing.Point(33, 348);
            this.label_ApsipirkimoSuma.Name = "label_ApsipirkimoSuma";
            this.label_ApsipirkimoSuma.Size = new System.Drawing.Size(127, 13);
            this.label_ApsipirkimoSuma.TabIndex = 2;
            this.label_ApsipirkimoSuma.Text = "Bendra apsipirkimo suma:";
            // 
            // ApsipirkimoSuma
            // 
            this.ApsipirkimoSuma.AutoSize = true;
            this.ApsipirkimoSuma.Location = new System.Drawing.Point(167, 348);
            this.ApsipirkimoSuma.Name = "ApsipirkimoSuma";
            this.ApsipirkimoSuma.Size = new System.Drawing.Size(13, 13);
            this.ApsipirkimoSuma.TabIndex = 3;
            this.ApsipirkimoSuma.Text = "0";
            // 
            // BasketReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.ApsipirkimoSuma);
            this.Controls.Add(this.label_ApsipirkimoSuma);
            this.Controls.Add(this.label_PasirinktosPrekes);
            this.Controls.Add(this.dataGridView_PasirinktosPrekes);
            this.Name = "BasketReviewForm";
            this.Text = "Pirkinių sąrašas";
            this.Load += new System.EventHandler(this.BasketReviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PasirinktosPrekes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_PasirinktosPrekes;
        private System.Windows.Forms.Label label_PasirinktosPrekes;
        private System.Windows.Forms.Label label_ApsipirkimoSuma;
        private System.Windows.Forms.Label ApsipirkimoSuma;
    }
}