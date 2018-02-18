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
            this.Btn_exit = new System.Windows.Forms.Button();
            this.rBtn_PKW = new System.Windows.Forms.RadioButton();
            this.rBtn_Moped = new System.Windows.Forms.RadioButton();
            this.rBtn_Beifahrer = new System.Windows.Forms.RadioButton();
            this.lbl_Calcbasics = new System.Windows.Forms.Label();
            this.rBtn_Rad = new System.Windows.Forms.RadioButton();
            this.Btn_Info = new System.Windows.Forms.Button();
            this.lbl_kmvorher = new System.Windows.Forms.Label();
            this.lbl_kmnacher = new System.Windows.Forms.Label();
            this.Fillin_start = new System.Windows.Forms.TextBox();
            this.Fillin_end = new System.Windows.Forms.TextBox();
            this.lbl_gefahrenekm = new System.Windows.Forms.Label();
            this.tBox_km = new System.Windows.Forms.TextBox();
            this.Btn_AddFahrt = new System.Windows.Forms.Button();
            this.Btn_CalcEur = new System.Windows.Forms.Button();
            this.lbl_kmEur = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.Red;
            this.Btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit.ForeColor = System.Drawing.Color.White;
            this.Btn_exit.Location = new System.Drawing.Point(755, 12);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(47, 43);
            this.Btn_exit.TabIndex = 0;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // rBtn_PKW
            // 
            this.rBtn_PKW.AutoSize = true;
            this.rBtn_PKW.Checked = true;
            this.rBtn_PKW.Location = new System.Drawing.Point(192, 64);
            this.rBtn_PKW.Name = "rBtn_PKW";
            this.rBtn_PKW.Size = new System.Drawing.Size(50, 17);
            this.rBtn_PKW.TabIndex = 1;
            this.rBtn_PKW.TabStop = true;
            this.rBtn_PKW.Text = "PKW";
            this.rBtn_PKW.UseVisualStyleBackColor = true;
            // 
            // rBtn_Moped
            // 
            this.rBtn_Moped.AutoSize = true;
            this.rBtn_Moped.Location = new System.Drawing.Point(248, 64);
            this.rBtn_Moped.Name = "rBtn_Moped";
            this.rBtn_Moped.Size = new System.Drawing.Size(138, 17);
            this.rBtn_Moped.TabIndex = 2;
            this.rBtn_Moped.Text = "Motorrad / Motorfahrrad";
            this.rBtn_Moped.UseVisualStyleBackColor = true;
            // 
            // rBtn_Beifahrer
            // 
            this.rBtn_Beifahrer.AutoSize = true;
            this.rBtn_Beifahrer.Location = new System.Drawing.Point(392, 64);
            this.rBtn_Beifahrer.Name = "rBtn_Beifahrer";
            this.rBtn_Beifahrer.Size = new System.Drawing.Size(67, 17);
            this.rBtn_Beifahrer.TabIndex = 3;
            this.rBtn_Beifahrer.Text = "Beifahrer";
            this.rBtn_Beifahrer.UseVisualStyleBackColor = true;
            // 
            // lbl_Calcbasics
            // 
            this.lbl_Calcbasics.AutoSize = true;
            this.lbl_Calcbasics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calcbasics.Location = new System.Drawing.Point(273, 35);
            this.lbl_Calcbasics.Name = "lbl_Calcbasics";
            this.lbl_Calcbasics.Size = new System.Drawing.Size(186, 20);
            this.lbl_Calcbasics.TabIndex = 4;
            this.lbl_Calcbasics.Text = "Berechnungsgrundlage:";
            this.lbl_Calcbasics.Click += new System.EventHandler(this.lbl_Calcbasics_Click);
            // 
            // rBtn_Rad
            // 
            this.rBtn_Rad.AutoSize = true;
            this.rBtn_Rad.Location = new System.Drawing.Point(465, 64);
            this.rBtn_Rad.Name = "rBtn_Rad";
            this.rBtn_Rad.Size = new System.Drawing.Size(61, 17);
            this.rBtn_Rad.TabIndex = 5;
            this.rBtn_Rad.Text = "Fahrrad";
            this.rBtn_Rad.UseVisualStyleBackColor = true;
            // 
            // Btn_Info
            // 
            this.Btn_Info.BackColor = System.Drawing.Color.White;
            this.Btn_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Info.ForeColor = System.Drawing.Color.Black;
            this.Btn_Info.Location = new System.Drawing.Point(12, 12);
            this.Btn_Info.Name = "Btn_Info";
            this.Btn_Info.Size = new System.Drawing.Size(47, 43);
            this.Btn_Info.TabIndex = 6;
            this.Btn_Info.Text = "Info";
            this.Btn_Info.UseVisualStyleBackColor = false;
            this.Btn_Info.Click += new System.EventHandler(this.Btn_Info_Click);
            // 
            // lbl_kmvorher
            // 
            this.lbl_kmvorher.AutoSize = true;
            this.lbl_kmvorher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kmvorher.Location = new System.Drawing.Point(57, 153);
            this.lbl_kmvorher.Name = "lbl_kmvorher";
            this.lbl_kmvorher.Size = new System.Drawing.Size(151, 17);
            this.lbl_kmvorher.TabIndex = 7;
            this.lbl_kmvorher.Text = "Kilometerstand vorher:";
            // 
            // lbl_kmnacher
            // 
            this.lbl_kmnacher.AutoSize = true;
            this.lbl_kmnacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kmnacher.Location = new System.Drawing.Point(54, 239);
            this.lbl_kmnacher.Name = "lbl_kmnacher";
            this.lbl_kmnacher.Size = new System.Drawing.Size(154, 17);
            this.lbl_kmnacher.TabIndex = 8;
            this.lbl_kmnacher.Text = "Kilometerstand nacher:";
            // 
            // Fillin_start
            // 
            this.Fillin_start.Location = new System.Drawing.Point(60, 176);
            this.Fillin_start.Name = "Fillin_start";
            this.Fillin_start.Size = new System.Drawing.Size(100, 20);
            this.Fillin_start.TabIndex = 9;
            // 
            // Fillin_end
            // 
            this.Fillin_end.Location = new System.Drawing.Point(57, 262);
            this.Fillin_end.Name = "Fillin_end";
            this.Fillin_end.Size = new System.Drawing.Size(100, 20);
            this.Fillin_end.TabIndex = 10;
            // 
            // lbl_gefahrenekm
            // 
            this.lbl_gefahrenekm.AutoSize = true;
            this.lbl_gefahrenekm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gefahrenekm.Location = new System.Drawing.Point(245, 153);
            this.lbl_gefahrenekm.Name = "lbl_gefahrenekm";
            this.lbl_gefahrenekm.Size = new System.Drawing.Size(99, 17);
            this.lbl_gefahrenekm.TabIndex = 11;
            this.lbl_gefahrenekm.Text = "gefahrene km:";
            // 
            // tBox_km
            // 
            this.tBox_km.Location = new System.Drawing.Point(248, 176);
            this.tBox_km.Name = "tBox_km";
            this.tBox_km.ReadOnly = true;
            this.tBox_km.Size = new System.Drawing.Size(100, 20);
            this.tBox_km.TabIndex = 12;
            // 
            // Btn_AddFahrt
            // 
            this.Btn_AddFahrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_AddFahrt.ForeColor = System.Drawing.Color.White;
            this.Btn_AddFahrt.Location = new System.Drawing.Point(248, 239);
            this.Btn_AddFahrt.Name = "Btn_AddFahrt";
            this.Btn_AddFahrt.Size = new System.Drawing.Size(100, 34);
            this.Btn_AddFahrt.TabIndex = 13;
            this.Btn_AddFahrt.Text = "Fahrt buchen";
            this.Btn_AddFahrt.UseVisualStyleBackColor = false;
            this.Btn_AddFahrt.Click += new System.EventHandler(this.Btn_AddFahrt_Click);
            // 
            // Btn_CalcEur
            // 
            this.Btn_CalcEur.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CalcEur.Location = new System.Drawing.Point(625, 254);
            this.Btn_CalcEur.Name = "Btn_CalcEur";
            this.Btn_CalcEur.Size = new System.Drawing.Size(100, 34);
            this.Btn_CalcEur.TabIndex = 14;
            this.Btn_CalcEur.Text = "Fahrtgeld brechnen";
            this.Btn_CalcEur.UseVisualStyleBackColor = false;
            this.Btn_CalcEur.Click += new System.EventHandler(this.Btn_CalcEur_Click);
            // 
            // lbl_kmEur
            // 
            this.lbl_kmEur.AutoSize = true;
            this.lbl_kmEur.Location = new System.Drawing.Point(536, 306);
            this.lbl_kmEur.Name = "lbl_kmEur";
            this.lbl_kmEur.Size = new System.Drawing.Size(0, 13);
            this.lbl_kmEur.TabIndex = 15;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(60, 330);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reset.TabIndex = 16;
            this.Btn_Reset.Text = "Btn_Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 365);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.lbl_kmEur);
            this.Controls.Add(this.Btn_CalcEur);
            this.Controls.Add(this.Btn_AddFahrt);
            this.Controls.Add(this.tBox_km);
            this.Controls.Add(this.lbl_gefahrenekm);
            this.Controls.Add(this.Fillin_end);
            this.Controls.Add(this.Fillin_start);
            this.Controls.Add(this.lbl_kmnacher);
            this.Controls.Add(this.lbl_kmvorher);
            this.Controls.Add(this.Btn_Info);
            this.Controls.Add(this.rBtn_Rad);
            this.Controls.Add(this.lbl_Calcbasics);
            this.Controls.Add(this.rBtn_Beifahrer);
            this.Controls.Add(this.rBtn_Moped);
            this.Controls.Add(this.rBtn_PKW);
            this.Controls.Add(this.Btn_exit);
            this.Name = "Form1";
            this.Text = "Fahrtenbuch_MLO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.RadioButton rBtn_PKW;
        private System.Windows.Forms.RadioButton rBtn_Moped;
        private System.Windows.Forms.RadioButton rBtn_Beifahrer;
        private System.Windows.Forms.Label lbl_Calcbasics;
        private System.Windows.Forms.RadioButton rBtn_Rad;
        private System.Windows.Forms.Button Btn_Info;
        private System.Windows.Forms.Label lbl_kmvorher;
        private System.Windows.Forms.Label lbl_kmnacher;
        private System.Windows.Forms.TextBox Fillin_start;
        private System.Windows.Forms.TextBox Fillin_end;
        private System.Windows.Forms.Label lbl_gefahrenekm;
        private System.Windows.Forms.Button Btn_AddFahrt;
        private System.Windows.Forms.Button Btn_CalcEur;
        private System.Windows.Forms.TextBox tBox_km;
        private System.Windows.Forms.Label lbl_kmEur;
        private System.Windows.Forms.Button Btn_Reset;
    }
}

