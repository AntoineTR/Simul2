namespace eq6_Simulation2
{
    partial class CallsListToBegin
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
            this.lsvSurveys = new System.Windows.Forms.ListView();
            this.Compagnie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateDebut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBeginCalls = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvSurveys
            // 
            this.lsvSurveys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Compagnie,
            this.DateDebut,
            this.DateFin});
            this.lsvSurveys.Enabled = false;
            this.lsvSurveys.Location = new System.Drawing.Point(14, 24);
            this.lsvSurveys.Name = "lsvSurveys";
            this.lsvSurveys.Size = new System.Drawing.Size(575, 432);
            this.lsvSurveys.TabIndex = 0;
            this.lsvSurveys.UseCompatibleStateImageBehavior = false;
            this.lsvSurveys.View = System.Windows.Forms.View.Details;
            // 
            // Compagnie
            // 
            this.Compagnie.Text = "Compagnie";
            this.Compagnie.Width = 266;
            // 
            // DateDebut
            // 
            this.DateDebut.Text = "Date Début";
            this.DateDebut.Width = 156;
            // 
            // DateFin
            // 
            this.DateFin.Text = "Date Fin";
            this.DateFin.Width = 148;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(14, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 35);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Bonjour, {nom de l\'employé}";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvSurveys);
            this.groupBox1.Location = new System.Drawing.Point(14, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 474);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des sondages";
            // 
            // btnBeginCalls
            // 
            this.btnBeginCalls.BackColor = System.Drawing.Color.White;
            this.btnBeginCalls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginCalls.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginCalls.Location = new System.Drawing.Point(201, 559);
            this.btnBeginCalls.Name = "btnBeginCalls";
            this.btnBeginCalls.Size = new System.Drawing.Size(411, 56);
            this.btnBeginCalls.TabIndex = 6;
            this.btnBeginCalls.Text = "Commencer les appels";
            this.btnBeginCalls.UseVisualStyleBackColor = false;
            this.btnBeginCalls.Click += new System.EventHandler(this.btnBeginCalls_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(14, 559);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 56);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Quitter";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnBeginCalls);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 629);
            this.panel1.TabIndex = 8;
            // 
            // CallsListToBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 650);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(661, 688);
            this.Name = "CallsListToBegin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Commencer les appels";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CallsListToBegin_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvSurveys;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader Compagnie;
        private System.Windows.Forms.ColumnHeader DateDebut;
        private System.Windows.Forms.ColumnHeader DateFin;
        private System.Windows.Forms.Button btnBeginCalls;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}