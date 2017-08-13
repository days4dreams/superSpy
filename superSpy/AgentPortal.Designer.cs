namespace superSpy
{
    partial class AgentPortal
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
            this.labelIntro = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAgentName = new System.Windows.Forms.Label();
            this.labelAlias = new System.Windows.Forms.Label();
            this.labelRealNameOutput = new System.Windows.Forms.Label();
            this.labelAliasOutput = new System.Windows.Forms.Label();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIntro
            // 
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntro.Location = new System.Drawing.Point(23, 9);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(516, 23);
            this.labelIntro.TabIndex = 0;
            this.labelIntro.Text = "Secret Agent Access Portal";
            this.labelIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(110, 111);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(352, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelInstruction
            // 
            this.labelInstruction.Location = new System.Drawing.Point(23, 32);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(516, 58);
            this.labelInstruction.TabIndex = 2;
            this.labelInstruction.Text = "Enter your Agent Password to see details on who is on duty.\r\nCorrect Passwords wi" +
    "ll reveal Agent\'s Real Name, incorrect Passwords will reveal an Alias.";
            this.labelInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInstruction.Click += new System.EventHandler(this.labelInstruction_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(48, 114);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelAgentName
            // 
            this.labelAgentName.AutoSize = true;
            this.labelAgentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgentName.Location = new System.Drawing.Point(31, 187);
            this.labelAgentName.Name = "labelAgentName";
            this.labelAgentName.Size = new System.Drawing.Size(80, 13);
            this.labelAgentName.TabIndex = 4;
            this.labelAgentName.Text = "Agent Name:";
            // 
            // labelAlias
            // 
            this.labelAlias.AutoSize = true;
            this.labelAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlias.Location = new System.Drawing.Point(67, 187);
            this.labelAlias.Name = "labelAlias";
            this.labelAlias.Size = new System.Drawing.Size(0, 13);
            this.labelAlias.TabIndex = 5;
            // 
            // labelRealNameOutput
            // 
            this.labelRealNameOutput.AutoSize = true;
            this.labelRealNameOutput.Location = new System.Drawing.Point(117, 187);
            this.labelRealNameOutput.Name = "labelRealNameOutput";
            this.labelRealNameOutput.Size = new System.Drawing.Size(0, 13);
            this.labelRealNameOutput.TabIndex = 6;
            // 
            // labelAliasOutput
            // 
            this.labelAliasOutput.AutoSize = true;
            this.labelAliasOutput.Location = new System.Drawing.Point(111, 187);
            this.labelAliasOutput.Name = "labelAliasOutput";
            this.labelAliasOutput.Size = new System.Drawing.Size(0, 13);
            this.labelAliasOutput.TabIndex = 7;
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(318, 146);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(144, 25);
            this.buttonRequest.TabIndex = 8;
            this.buttonRequest.Text = "Request Information";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(569, 221);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.labelAliasOutput);
            this.Controls.Add(this.labelRealNameOutput);
            this.Controls.Add(this.labelAlias);
            this.Controls.Add(this.labelAgentName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelIntro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "The CIA Agent Portal: Top Secret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAgentName;
        private System.Windows.Forms.Label labelAlias;
        private System.Windows.Forms.Label labelRealNameOutput;
        private System.Windows.Forms.Label labelAliasOutput;
        private System.Windows.Forms.Button buttonRequest;
    }
}

