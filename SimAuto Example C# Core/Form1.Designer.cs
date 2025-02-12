namespace SimAuto_Example
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
            btnConnect = new System.Windows.Forms.Button();
            btnDisconnect = new System.Windows.Forms.Button();
            textCaseFileName = new System.Windows.Forms.TextBox();
            btnOpenCase = new System.Windows.Forms.Button();
            btnCloseCase = new System.Windows.Forms.Button();
            btnGetGenParams = new System.Windows.Forms.Button();
            btnOPF = new System.Windows.Forms.Button();
            btnScaleCase = new System.Windows.Forms.Button();
            btnSendGenToExcel = new System.Windows.Forms.Button();
            gbOperations = new System.Windows.Forms.GroupBox();
            textLog = new System.Windows.Forms.TextBox();
            gbOperations.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(14, 14);
            btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(88, 27);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Enabled = false;
            btnDisconnect.Location = new System.Drawing.Point(108, 14);
            btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(88, 27);
            btnDisconnect.TabIndex = 1;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // textCaseFileName
            // 
            textCaseFileName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textCaseFileName.Location = new System.Drawing.Point(7, 24);
            textCaseFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textCaseFileName.Name = "textCaseFileName";
            textCaseFileName.Size = new System.Drawing.Size(584, 23);
            textCaseFileName.TabIndex = 2;
            textCaseFileName.Text = "C:\\Program Files (x86)\\PowerWorld\\Simulator15\\Sample Cases\\B7OPF.pwb";
            // 
            // btnOpenCase
            // 
            btnOpenCase.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOpenCase.Location = new System.Drawing.Point(598, 22);
            btnOpenCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOpenCase.Name = "btnOpenCase";
            btnOpenCase.Size = new System.Drawing.Size(88, 27);
            btnOpenCase.TabIndex = 3;
            btnOpenCase.Text = "Open Case";
            btnOpenCase.UseVisualStyleBackColor = true;
            btnOpenCase.Click += btnOpenCase_Click;
            // 
            // btnCloseCase
            // 
            btnCloseCase.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnCloseCase.Enabled = false;
            btnCloseCase.Location = new System.Drawing.Point(693, 22);
            btnCloseCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCloseCase.Name = "btnCloseCase";
            btnCloseCase.Size = new System.Drawing.Size(88, 27);
            btnCloseCase.TabIndex = 4;
            btnCloseCase.Text = "Close Case";
            btnCloseCase.UseVisualStyleBackColor = true;
            btnCloseCase.Click += btnCloseCase_Click;
            // 
            // btnGetGenParams
            // 
            btnGetGenParams.Enabled = false;
            btnGetGenParams.Location = new System.Drawing.Point(7, 55);
            btnGetGenParams.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGetGenParams.Name = "btnGetGenParams";
            btnGetGenParams.Size = new System.Drawing.Size(175, 27);
            btnGetGenParams.TabIndex = 5;
            btnGetGenParams.Text = "Get Gen Parameters";
            btnGetGenParams.UseVisualStyleBackColor = true;
            btnGetGenParams.Click += btnGetGenParams_Click;
            // 
            // btnOPF
            // 
            btnOPF.Enabled = false;
            btnOPF.Location = new System.Drawing.Point(7, 89);
            btnOPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOPF.Name = "btnOPF";
            btnOPF.Size = new System.Drawing.Size(175, 27);
            btnOPF.TabIndex = 6;
            btnOPF.Text = "OPF";
            btnOPF.UseVisualStyleBackColor = true;
            btnOPF.Click += btnOPF_Click;
            // 
            // btnScaleCase
            // 
            btnScaleCase.Enabled = false;
            btnScaleCase.Location = new System.Drawing.Point(7, 122);
            btnScaleCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnScaleCase.Name = "btnScaleCase";
            btnScaleCase.Size = new System.Drawing.Size(175, 27);
            btnScaleCase.TabIndex = 7;
            btnScaleCase.Text = "Scale Case";
            btnScaleCase.UseVisualStyleBackColor = true;
            btnScaleCase.Click += btnScaleCase_Click;
            // 
            // btnSendGenToExcel
            // 
            btnSendGenToExcel.Enabled = false;
            btnSendGenToExcel.Location = new System.Drawing.Point(7, 156);
            btnSendGenToExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSendGenToExcel.Name = "btnSendGenToExcel";
            btnSendGenToExcel.Size = new System.Drawing.Size(175, 27);
            btnSendGenToExcel.TabIndex = 8;
            btnSendGenToExcel.Text = "Send Gen Info to Excel";
            btnSendGenToExcel.UseVisualStyleBackColor = true;
            btnSendGenToExcel.Click += btnSendGenToExcel_Click;
            // 
            // gbOperations
            // 
            gbOperations.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gbOperations.Controls.Add(textLog);
            gbOperations.Controls.Add(textCaseFileName);
            gbOperations.Controls.Add(btnSendGenToExcel);
            gbOperations.Controls.Add(btnOpenCase);
            gbOperations.Controls.Add(btnScaleCase);
            gbOperations.Controls.Add(btnCloseCase);
            gbOperations.Controls.Add(btnOPF);
            gbOperations.Controls.Add(btnGetGenParams);
            gbOperations.Enabled = false;
            gbOperations.Location = new System.Drawing.Point(14, 47);
            gbOperations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbOperations.Name = "gbOperations";
            gbOperations.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbOperations.Size = new System.Drawing.Size(788, 383);
            gbOperations.TabIndex = 9;
            gbOperations.TabStop = false;
            gbOperations.Text = "Operations";
            // 
            // textLog
            // 
            textLog.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textLog.Location = new System.Drawing.Point(189, 58);
            textLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textLog.Multiline = true;
            textLog.Name = "textLog";
            textLog.ReadOnly = true;
            textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textLog.Size = new System.Drawing.Size(591, 318);
            textLog.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(816, 444);
            Controls.Add(gbOperations);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            gbOperations.ResumeLayout(false);
            gbOperations.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox textCaseFileName;
        private System.Windows.Forms.Button btnOpenCase;
        private System.Windows.Forms.Button btnCloseCase;
        private System.Windows.Forms.Button btnGetGenParams;
        private System.Windows.Forms.Button btnOPF;
        private System.Windows.Forms.Button btnScaleCase;
        private System.Windows.Forms.Button btnSendGenToExcel;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.TextBox textLog;
    }
}

