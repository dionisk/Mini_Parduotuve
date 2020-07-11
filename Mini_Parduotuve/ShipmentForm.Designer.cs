namespace Mini_Parduotuve
{
    partial class ShipmentForm
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
            this.radioButton_PerPasta = new System.Windows.Forms.RadioButton();
            this.label_PristatymoBudas = new System.Windows.Forms.Label();
            this.radioButton_PerKurjerius = new System.Windows.Forms.RadioButton();
            this.radioButton_IPastomata = new System.Windows.Forms.RadioButton();
            this.radioButton_TarptautinisSiuntimas = new System.Windows.Forms.RadioButton();
            this.button_Atsaukti = new System.Windows.Forms.Button();
            this.button_Formuoti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_PerPasta
            // 
            this.radioButton_PerPasta.AutoSize = true;
            this.radioButton_PerPasta.Location = new System.Drawing.Point(16, 41);
            this.radioButton_PerPasta.Name = "radioButton_PerPasta";
            this.radioButton_PerPasta.Size = new System.Drawing.Size(70, 17);
            this.radioButton_PerPasta.TabIndex = 0;
            this.radioButton_PerPasta.TabStop = true;
            this.radioButton_PerPasta.Text = "Per paštą";
            this.radioButton_PerPasta.UseVisualStyleBackColor = true;
            // 
            // label_PristatymoBudas
            // 
            this.label_PristatymoBudas.AutoSize = true;
            this.label_PristatymoBudas.Location = new System.Drawing.Point(13, 13);
            this.label_PristatymoBudas.Name = "label_PristatymoBudas";
            this.label_PristatymoBudas.Size = new System.Drawing.Size(135, 13);
            this.label_PristatymoBudas.TabIndex = 1;
            this.label_PristatymoBudas.Text = "Pasirinkite pristatymo būdą:";
            // 
            // radioButton_PerKurjerius
            // 
            this.radioButton_PerKurjerius.AutoSize = true;
            this.radioButton_PerKurjerius.Location = new System.Drawing.Point(16, 74);
            this.radioButton_PerKurjerius.Name = "radioButton_PerKurjerius";
            this.radioButton_PerKurjerius.Size = new System.Drawing.Size(83, 17);
            this.radioButton_PerKurjerius.TabIndex = 2;
            this.radioButton_PerKurjerius.TabStop = true;
            this.radioButton_PerKurjerius.Text = "Per kurjerius";
            this.radioButton_PerKurjerius.UseVisualStyleBackColor = true;
            // 
            // radioButton_IPastomata
            // 
            this.radioButton_IPastomata.AutoSize = true;
            this.radioButton_IPastomata.Location = new System.Drawing.Point(16, 108);
            this.radioButton_IPastomata.Name = "radioButton_IPastomata";
            this.radioButton_IPastomata.Size = new System.Drawing.Size(80, 17);
            this.radioButton_IPastomata.TabIndex = 3;
            this.radioButton_IPastomata.TabStop = true;
            this.radioButton_IPastomata.Text = "Į paštomatą";
            this.radioButton_IPastomata.UseVisualStyleBackColor = true;
            // 
            // radioButton_TarptautinisSiuntimas
            // 
            this.radioButton_TarptautinisSiuntimas.AutoSize = true;
            this.radioButton_TarptautinisSiuntimas.Location = new System.Drawing.Point(16, 141);
            this.radioButton_TarptautinisSiuntimas.Name = "radioButton_TarptautinisSiuntimas";
            this.radioButton_TarptautinisSiuntimas.Size = new System.Drawing.Size(126, 17);
            this.radioButton_TarptautinisSiuntimas.TabIndex = 4;
            this.radioButton_TarptautinisSiuntimas.TabStop = true;
            this.radioButton_TarptautinisSiuntimas.Text = "Tarptautinis siuntimas";
            this.radioButton_TarptautinisSiuntimas.UseVisualStyleBackColor = true;
            // 
            // button_Atsaukti
            // 
            this.button_Atsaukti.Location = new System.Drawing.Point(251, 146);
            this.button_Atsaukti.Name = "button_Atsaukti";
            this.button_Atsaukti.Size = new System.Drawing.Size(75, 23);
            this.button_Atsaukti.TabIndex = 5;
            this.button_Atsaukti.Text = "Atšaukti";
            this.button_Atsaukti.UseVisualStyleBackColor = true;
            this.button_Atsaukti.Click += new System.EventHandler(this.button_Atsaukti_Click);
            // 
            // button_Formuoti
            // 
            this.button_Formuoti.Location = new System.Drawing.Point(251, 108);
            this.button_Formuoti.Name = "button_Formuoti";
            this.button_Formuoti.Size = new System.Drawing.Size(75, 23);
            this.button_Formuoti.TabIndex = 6;
            this.button_Formuoti.Text = "Formuoti";
            this.button_Formuoti.UseVisualStyleBackColor = true;
            this.button_Formuoti.Click += new System.EventHandler(this.button_Formuoti_Click);
            // 
            // ShipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 186);
            this.Controls.Add(this.button_Formuoti);
            this.Controls.Add(this.button_Atsaukti);
            this.Controls.Add(this.radioButton_TarptautinisSiuntimas);
            this.Controls.Add(this.radioButton_IPastomata);
            this.Controls.Add(this.radioButton_PerKurjerius);
            this.Controls.Add(this.label_PristatymoBudas);
            this.Controls.Add(this.radioButton_PerPasta);
            this.Name = "ShipmentForm";
            this.Text = "Siuntos formavimas";
            this.Load += new System.EventHandler(this.ShipmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_PerPasta;
        private System.Windows.Forms.Label label_PristatymoBudas;
        private System.Windows.Forms.RadioButton radioButton_PerKurjerius;
        private System.Windows.Forms.RadioButton radioButton_IPastomata;
        private System.Windows.Forms.RadioButton radioButton_TarptautinisSiuntimas;
        private System.Windows.Forms.Button button_Atsaukti;
        private System.Windows.Forms.Button button_Formuoti;
    }
}