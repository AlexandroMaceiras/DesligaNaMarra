namespace DesligaNaMarra
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnSuspende = new System.Windows.Forms.Button();
            this.btnHiberna = new System.Windows.Forms.Button();
            this.btnBloqueia = new System.Windows.Forms.Button();
            this.btnReinicia = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuspende
            // 
            resources.ApplyResources(this.btnSuspende, "btnSuspende");
            this.btnSuspende.Name = "btnSuspende";
            this.btnSuspende.UseVisualStyleBackColor = true;
            this.btnSuspende.Click += new System.EventHandler(this.btnSuspende_Click);
            // 
            // btnHiberna
            // 
            resources.ApplyResources(this.btnHiberna, "btnHiberna");
            this.btnHiberna.Name = "btnHiberna";
            this.btnHiberna.UseVisualStyleBackColor = true;
            this.btnHiberna.Click += new System.EventHandler(this.btnHiberna_Click);
            // 
            // btnBloqueia
            // 
            resources.ApplyResources(this.btnBloqueia, "btnBloqueia");
            this.btnBloqueia.Name = "btnBloqueia";
            this.btnBloqueia.UseVisualStyleBackColor = true;
            this.btnBloqueia.Click += new System.EventHandler(this.btnBloqueia_Click);
            // 
            // btnReinicia
            // 
            resources.ApplyResources(this.btnReinicia, "btnReinicia");
            this.btnReinicia.Name = "btnReinicia";
            this.btnReinicia.UseVisualStyleBackColor = true;
            this.btnReinicia.UseWaitCursor = true;
            this.btnReinicia.Click += new System.EventHandler(this.btnReinicia_Click);
            // 
            // btnDesligar
            // 
            resources.ApplyResources(this.btnDesligar, "btnDesligar");
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.UseWaitCursor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuspende);
            this.groupBox1.Controls.Add(this.btnHiberna);
            this.groupBox1.Controls.Add(this.btnBloqueia);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReinicia);
            this.groupBox2.Controls.Add(this.btnDesligar);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.UseWaitCursor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Menu";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuspende;
        private System.Windows.Forms.Button btnHiberna;
        private System.Windows.Forms.Button btnBloqueia;
        private System.Windows.Forms.Button btnReinicia;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

