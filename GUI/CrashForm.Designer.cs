﻿namespace HMonZ.GUI {
  partial class CrashForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.sendButton = new System.Windows.Forms.Button();
      this.exitButton = new System.Windows.Forms.Button();
      this.commentTextBox = new System.Windows.Forms.TextBox();
      this.titleLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.commentPanel = new System.Windows.Forms.Panel();
      this.reportPanel = new System.Windows.Forms.Panel();
      this.reportTextBox = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.emailTextBox = new System.Windows.Forms.TextBox();
      this.commentPanel.SuspendLayout();
      this.reportPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // sendButton
      // 
      this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.sendButton.Location = new System.Drawing.Point(449, 469);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(75, 23);
      this.sendButton.TabIndex = 2;
      this.sendButton.Text = "Send";
      this.sendButton.UseVisualStyleBackColor = true;
      this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
      // 
      // exitButton
      // 
      this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.exitButton.Location = new System.Drawing.Point(530, 469);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(75, 23);
      this.exitButton.TabIndex = 3;
      this.exitButton.Text = "Exit";
      this.exitButton.UseVisualStyleBackColor = true;
      // 
      // commentTextBox
      // 
      this.commentTextBox.AcceptsReturn = true;
      this.commentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.commentTextBox.Location = new System.Drawing.Point(4, 4);
      this.commentTextBox.Multiline = true;
      this.commentTextBox.Name = "commentTextBox";
      this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.commentTextBox.Size = new System.Drawing.Size(586, 77);
      this.commentTextBox.TabIndex = 1;
      // 
      // titleLabel
      // 
      this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.titleLabel.BackColor = System.Drawing.SystemColors.Window;
      this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titleLabel.Location = new System.Drawing.Point(-1, -1);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Padding = new System.Windows.Forms.Padding(10);
      this.titleLabel.Size = new System.Drawing.Size(619, 52);
      this.titleLabel.TabIndex = 4;
      this.titleLabel.Text = "HMonZ has encountered a problem and needs to close. We are sorry " +
          "for the inconvenience.";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoEllipsis = true;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 63);
      this.label3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 8);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(571, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "To help diagnose and fix the problem, you can send a crash report. The following " +
          "report has been created automatically:";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoEllipsis = true;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 347);
      this.label1.Margin = new System.Windows.Forms.Padding(3, 12, 3, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(279, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "You can add additional information to the report (optional):";
      // 
      // commentPanel
      // 
      this.commentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.commentPanel.BackColor = System.Drawing.SystemColors.Window;
      this.commentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.commentPanel.Controls.Add(this.commentTextBox);
      this.commentPanel.Location = new System.Drawing.Point(12, 371);
      this.commentPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
      this.commentPanel.Name = "commentPanel";
      this.commentPanel.Padding = new System.Windows.Forms.Padding(4, 4, 1, 4);
      this.commentPanel.Size = new System.Drawing.Size(593, 87);
      this.commentPanel.TabIndex = 1;
      this.commentPanel.TabStop = true;
      // 
      // reportPanel
      // 
      this.reportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.reportPanel.BackColor = System.Drawing.SystemColors.Window;
      this.reportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.reportPanel.Controls.Add(this.reportTextBox);
      this.reportPanel.Controls.Add(this.textBox1);
      this.reportPanel.Location = new System.Drawing.Point(12, 87);
      this.reportPanel.Name = "reportPanel";
      this.reportPanel.Padding = new System.Windows.Forms.Padding(4, 4, 1, 4);
      this.reportPanel.Size = new System.Drawing.Size(593, 212);
      this.reportPanel.TabIndex = 8;
      // 
      // reportTextBox
      // 
      this.reportTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.reportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.reportTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.reportTextBox.Location = new System.Drawing.Point(4, 4);
      this.reportTextBox.Multiline = true;
      this.reportTextBox.Name = "reportTextBox";
      this.reportTextBox.ReadOnly = true;
      this.reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.reportTextBox.Size = new System.Drawing.Size(586, 202);
      this.reportTextBox.TabIndex = 9;
      this.reportTextBox.TabStop = false;
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(4, 4);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(586, 202);
      this.textBox1.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoEllipsis = true;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 318);
      this.label2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(171, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Enter your email address (optional):";
      // 
      // emailTextBox
      // 
      this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emailTextBox.Location = new System.Drawing.Point(188, 315);
      this.emailTextBox.Name = "emailTextBox";
      this.emailTextBox.Size = new System.Drawing.Size(417, 20);
      this.emailTextBox.TabIndex = 0;
      // 
      // CrashReportForm
      // 
      this.AcceptButton = this.sendButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.exitButton;
      this.ClientSize = new System.Drawing.Size(617, 504);
      this.ControlBox = false;
      this.Controls.Add(this.emailTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.reportPanel);
      this.Controls.Add(this.commentPanel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.titleLabel);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.sendButton);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CrashReportForm";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "HMonZ";
      this.commentPanel.ResumeLayout(false);
      this.commentPanel.PerformLayout();
      this.reportPanel.ResumeLayout(false);
      this.reportPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button sendButton;
    private System.Windows.Forms.Button exitButton;
    private System.Windows.Forms.TextBox commentTextBox;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel commentPanel;
    private System.Windows.Forms.Panel reportPanel;
    private System.Windows.Forms.TextBox reportTextBox;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox emailTextBox;
  }
}