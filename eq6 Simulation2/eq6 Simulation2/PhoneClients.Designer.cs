namespace eq6_Simulation2
{
    partial class PhoneClients
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneClients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.grpSatisfaction = new System.Windows.Forms.GroupBox();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.lblF4 = new System.Windows.Forms.Label();
            this.lblF3 = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.lblF1 = new System.Windows.Forms.Label();
            this.btnNoAnswer = new System.Windows.Forms.Button();
            this.btnNeutral = new System.Windows.Forms.Button();
            this.btnUnhappy = new System.Windows.Forms.Button();
            this.btnHappy = new System.Windows.Forms.Button();
            this.grbConversation = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrCall = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.grpSatisfaction.SuspendLayout();
            this.grbConversation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.lblLang);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.grpSatisfaction);
            this.panel1.Controls.Add(this.grbConversation);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 625);
            this.panel1.TabIndex = 0;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(584, 612);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 8;
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(2, 612);
            this.lblLang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(0, 13);
            this.lblLang.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(111, 536);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(482, 63);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next client";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(30, 536);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(63, 63);
            this.btnPause.TabIndex = 6;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // grpSatisfaction
            // 
            this.grpSatisfaction.Controls.Add(this.rtbComment);
            this.grpSatisfaction.Controls.Add(this.lblF4);
            this.grpSatisfaction.Controls.Add(this.lblF3);
            this.grpSatisfaction.Controls.Add(this.lblF2);
            this.grpSatisfaction.Controls.Add(this.lblF1);
            this.grpSatisfaction.Controls.Add(this.btnNoAnswer);
            this.grpSatisfaction.Controls.Add(this.btnNeutral);
            this.grpSatisfaction.Controls.Add(this.btnUnhappy);
            this.grpSatisfaction.Controls.Add(this.btnHappy);
            this.grpSatisfaction.Location = new System.Drawing.Point(20, 207);
            this.grpSatisfaction.Name = "grpSatisfaction";
            this.grpSatisfaction.Size = new System.Drawing.Size(584, 311);
            this.grpSatisfaction.TabIndex = 2;
            this.grpSatisfaction.TabStop = false;
            this.grpSatisfaction.Text = "Satisfaction du consommateur";
            // 
            // rtbComment
            // 
            this.rtbComment.Enabled = false;
            this.rtbComment.Location = new System.Drawing.Point(10, 178);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(563, 120);
            this.rtbComment.TabIndex = 7;
            this.rtbComment.Text = "";
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
            // lblF3
            // 
            this.lblF3.AutoSize = true;
            this.lblF3.Location = new System.Drawing.Point(355, 150);
            this.lblF3.Name = "lblF3";
            this.lblF3.Size = new System.Drawing.Size(19, 13);
            this.lblF3.TabIndex = 6;
            this.lblF3.Text = "F3";
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
            // lblF1
            // 
            this.lblF1.AutoSize = true;
            this.lblF1.Location = new System.Drawing.Point(62, 150);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(19, 13);
            this.lblF1.TabIndex = 4;
            this.lblF1.Text = "F1";
            // 
            // btnNoAnswer
            // 
            this.btnNoAnswer.BackColor = System.Drawing.Color.White;
            this.btnNoAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNoAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoAnswer.Image = ((System.Drawing.Image)(resources.GetObject("btnNoAnswer.Image")));
            this.btnNoAnswer.Location = new System.Drawing.Point(447, 19);
            this.btnNoAnswer.Name = "btnNoAnswer";
            this.btnNoAnswer.Size = new System.Drawing.Size(127, 127);
            this.btnNoAnswer.TabIndex = 4;
            this.btnNoAnswer.UseVisualStyleBackColor = false;
            this.btnNoAnswer.Click += new System.EventHandler(this.btnSelected);
            // 
            // btnNeutral
            // 
            this.btnNeutral.BackColor = System.Drawing.Color.White;
            this.btnNeutral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNeutral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNeutral.Image = ((System.Drawing.Image)(resources.GetObject("btnNeutral.Image")));
            this.btnNeutral.Location = new System.Drawing.Point(301, 20);
            this.btnNeutral.Name = "btnNeutral";
            this.btnNeutral.Size = new System.Drawing.Size(127, 127);
            this.btnNeutral.TabIndex = 3;
            this.btnNeutral.UseVisualStyleBackColor = false;
            this.btnNeutral.Click += new System.EventHandler(this.btnSelected);
            // 
            // btnUnhappy
            // 
            this.btnUnhappy.BackColor = System.Drawing.Color.White;
            this.btnUnhappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUnhappy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnhappy.Image = ((System.Drawing.Image)(resources.GetObject("btnUnhappy.Image")));
            this.btnUnhappy.Location = new System.Drawing.Point(154, 20);
            this.btnUnhappy.Name = "btnUnhappy";
            this.btnUnhappy.Size = new System.Drawing.Size(127, 127);
            this.btnUnhappy.TabIndex = 2;
            this.btnUnhappy.UseVisualStyleBackColor = false;
            this.btnUnhappy.Click += new System.EventHandler(this.btnUnhappy_Click);
            // 
            // btnHappy
            // 
            this.btnHappy.BackColor = System.Drawing.Color.White;
            this.btnHappy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHappy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHappy.Image = ((System.Drawing.Image)(resources.GetObject("btnHappy.Image")));
            this.btnHappy.Location = new System.Drawing.Point(7, 20);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(127, 127);
            this.btnHappy.TabIndex = 1;
            this.btnHappy.UseVisualStyleBackColor = false;
            this.btnHappy.Click += new System.EventHandler(this.btnSelected);
            // 
            // grbConversation
            // 
            this.grbConversation.Controls.Add(this.txtText);
            this.grbConversation.Location = new System.Drawing.Point(20, 66);
            this.grbConversation.Name = "grbConversation";
            this.grbConversation.Size = new System.Drawing.Size(584, 134);
            this.grbConversation.TabIndex = 1;
            this.grbConversation.TabStop = false;
            this.grbConversation.Text = "Conversation avec le consommateur";
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(7, 20);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(566, 100);
            this.txtText.TabIndex = 0;
            this.txtText.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(14, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "{nom du client}";
            // 
            // tmrCall
            // 
            this.tmrCall.Interval = 1000;
            this.tmrCall.Tick += new System.EventHandler(this.tmrAppel_Tick);
            // 
            // PhoneClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 645);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(656, 620);
            this.Name = "PhoneClients";
            this.Text = "{nom du client}";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpSatisfaction.ResumeLayout(false);
            this.grpSatisfaction.PerformLayout();
            this.grbConversation.ResumeLayout(false);
            this.grbConversation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbConversation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSatisfaction;
        private System.Windows.Forms.Button btnUnhappy;
        private System.Windows.Forms.Button btnHappy;
        private System.Windows.Forms.Button btnNeutral;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.Label lblF4;
        private System.Windows.Forms.Label lblF3;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Button btnNoAnswer;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Timer tmrCall;
    }
}

