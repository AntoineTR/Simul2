namespace eq6_Simulation2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbConversation = new System.Windows.Forms.GroupBox();
            this.lblCnv1 = new System.Windows.Forms.Label();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.lblCnv2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomEntreprise = new System.Windows.Forms.Label();
            this.grpSatisfaction = new System.Windows.Forms.GroupBox();
            this.btnSatisfait = new System.Windows.Forms.Button();
            this.btnNonSatisfait = new System.Windows.Forms.Button();
            this.btnPasRepondu = new System.Windows.Forms.Button();
            this.btnNeVeuxPas = new System.Windows.Forms.Button();
            this.lblF1 = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.lblF3 = new System.Windows.Forms.Label();
            this.lblF4 = new System.Windows.Forms.Label();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbConversation.SuspendLayout();
            this.grpSatisfaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSuivant);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.grpSatisfaction);
            this.panel1.Controls.Add(this.grbConversation);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 623);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(14, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // grbConversation
            // 
            this.grbConversation.Controls.Add(this.lblNomEntreprise);
            this.grbConversation.Controls.Add(this.label1);
            this.grbConversation.Controls.Add(this.lblCnv2);
            this.grbConversation.Controls.Add(this.lblNomClient);
            this.grbConversation.Controls.Add(this.lblCnv1);
            this.grbConversation.Location = new System.Drawing.Point(20, 66);
            this.grbConversation.Name = "grbConversation";
            this.grbConversation.Size = new System.Drawing.Size(584, 134);
            this.grbConversation.TabIndex = 1;
            this.grbConversation.TabStop = false;
            this.grbConversation.Text = "Conversation avec le consommateur";
            // 
            // lblCnv1
            // 
            this.lblCnv1.AutoSize = true;
            this.lblCnv1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnv1.Location = new System.Drawing.Point(7, 20);
            this.lblCnv1.Name = "lblCnv1";
            this.lblCnv1.Size = new System.Drawing.Size(96, 18);
            this.lblCnv1.TabIndex = 0;
            this.lblCnv1.Text = "Bonjour M.";
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.Location = new System.Drawing.Point(99, 20);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(0, 18);
            this.lblNomClient.TabIndex = 1;
            // 
            // lblCnv2
            // 
            this.lblCnv2.AutoSize = true;
            this.lblCnv2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnv2.Location = new System.Drawing.Point(7, 38);
            this.lblCnv2.Name = "lblCnv2";
            this.lblCnv2.Size = new System.Drawing.Size(567, 18);
            this.lblCnv2.TabIndex = 2;
            this.lblCnv2.Text = "J\'appel de la part de Baboubine pour effectuer un sondage à propos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "de votre achat chez";
            // 
            // lblNomEntreprise
            // 
            this.lblNomEntreprise.AutoSize = true;
            this.lblNomEntreprise.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEntreprise.Location = new System.Drawing.Point(180, 60);
            this.lblNomEntreprise.Name = "lblNomEntreprise";
            this.lblNomEntreprise.Size = new System.Drawing.Size(0, 18);
            this.lblNomEntreprise.TabIndex = 4;
            // 
            // grpSatisfaction
            // 
            this.grpSatisfaction.Controls.Add(this.rtbCommentaire);
            this.grpSatisfaction.Controls.Add(this.lblF4);
            this.grpSatisfaction.Controls.Add(this.lblF3);
            this.grpSatisfaction.Controls.Add(this.lblF2);
            this.grpSatisfaction.Controls.Add(this.lblF1);
            this.grpSatisfaction.Controls.Add(this.btnNeVeuxPas);
            this.grpSatisfaction.Controls.Add(this.btnPasRepondu);
            this.grpSatisfaction.Controls.Add(this.btnNonSatisfait);
            this.grpSatisfaction.Controls.Add(this.btnSatisfait);
            this.grpSatisfaction.Location = new System.Drawing.Point(20, 207);
            this.grpSatisfaction.Name = "grpSatisfaction";
            this.grpSatisfaction.Size = new System.Drawing.Size(584, 311);
            this.grpSatisfaction.TabIndex = 2;
            this.grpSatisfaction.TabStop = false;
            this.grpSatisfaction.Text = "Satisfaction du consommateur";
            // 
            // btnSatisfait
            // 
            this.btnSatisfait.Location = new System.Drawing.Point(7, 20);
            this.btnSatisfait.Name = "btnSatisfait";
            this.btnSatisfait.Size = new System.Drawing.Size(127, 127);
            this.btnSatisfait.TabIndex = 0;
            this.btnSatisfait.Text = "button1";
            this.btnSatisfait.UseVisualStyleBackColor = true;
            // 
            // btnNonSatisfait
            // 
            this.btnNonSatisfait.Location = new System.Drawing.Point(154, 20);
            this.btnNonSatisfait.Name = "btnNonSatisfait";
            this.btnNonSatisfait.Size = new System.Drawing.Size(127, 127);
            this.btnNonSatisfait.TabIndex = 1;
            this.btnNonSatisfait.Text = "button1";
            this.btnNonSatisfait.UseVisualStyleBackColor = true;
            // 
            // btnPasRepondu
            // 
            this.btnPasRepondu.Location = new System.Drawing.Point(301, 20);
            this.btnPasRepondu.Name = "btnPasRepondu";
            this.btnPasRepondu.Size = new System.Drawing.Size(127, 127);
            this.btnPasRepondu.TabIndex = 2;
            this.btnPasRepondu.Text = "button1";
            this.btnPasRepondu.UseVisualStyleBackColor = true;
            // 
            // btnNeVeuxPas
            // 
            this.btnNeVeuxPas.Location = new System.Drawing.Point(447, 19);
            this.btnNeVeuxPas.Name = "btnNeVeuxPas";
            this.btnNeVeuxPas.Size = new System.Drawing.Size(127, 127);
            this.btnNeVeuxPas.TabIndex = 3;
            this.btnNeVeuxPas.Text = "button1";
            this.btnNeVeuxPas.UseVisualStyleBackColor = true;
            // 
            // lblF1
            // 
            this.lblF1.AutoSize = true;
            this.lblF1.Location = new System.Drawing.Point(62, 150);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(19, 13);
            this.lblF1.TabIndex = 4;
            this.lblF1.Text = "F1";
            // 
            // lblF2
            // 
            this.lblF2.AutoSize = true;
            this.lblF2.Location = new System.Drawing.Point(208, 150);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(19, 13);
            this.lblF2.TabIndex = 5;
            this.lblF2.Text = "F3";
            // 
            // lblF3
            // 
            this.lblF3.AutoSize = true;
            this.lblF3.Location = new System.Drawing.Point(355, 150);
            this.lblF3.Name = "lblF3";
            this.lblF3.Size = new System.Drawing.Size(19, 13);
            this.lblF3.TabIndex = 6;
            this.lblF3.Text = "F3";
            // 
            // lblF4
            // 
            this.lblF4.AutoSize = true;
            this.lblF4.Location = new System.Drawing.Point(501, 149);
            this.lblF4.Name = "lblF4";
            this.lblF4.Size = new System.Drawing.Size(19, 13);
            this.lblF4.TabIndex = 7;
            this.lblF4.Text = "F4";
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Location = new System.Drawing.Point(10, 178);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(563, 120);
            this.rtbCommentaire.TabIndex = 8;
            this.rtbCommentaire.Text = "";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(30, 536);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(63, 63);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "button1";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(111, 536);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(482, 63);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = "button1";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 649);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbConversation.ResumeLayout(false);
            this.grbConversation.PerformLayout();
            this.grpSatisfaction.ResumeLayout(false);
            this.grpSatisfaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbConversation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCnv2;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Label lblCnv1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNomEntreprise;
        private System.Windows.Forms.GroupBox grpSatisfaction;
        private System.Windows.Forms.Button btnNonSatisfait;
        private System.Windows.Forms.Button btnSatisfait;
        private System.Windows.Forms.Button btnPasRepondu;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.Label lblF4;
        private System.Windows.Forms.Label lblF3;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Button btnNeVeuxPas;
    }
}

