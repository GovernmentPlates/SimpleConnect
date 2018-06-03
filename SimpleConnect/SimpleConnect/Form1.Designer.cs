namespace SimpleConnect
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
			this.btnConnectVPN = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.viewPublicIP = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConnectVPN
			// 
			this.btnConnectVPN.Location = new System.Drawing.Point(12, 12);
			this.btnConnectVPN.Name = "btnConnectVPN";
			this.btnConnectVPN.Size = new System.Drawing.Size(244, 31);
			this.btnConnectVPN.TabIndex = 0;
			this.btnConnectVPN.Text = "Connect";
			this.btnConnectVPN.UseVisualStyleBackColor = true;
			this.btnConnectVPN.Click += new System.EventHandler(this.btnConnectVPN_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Public I.P Address:";
			// 
			// viewPublicIP
			// 
			this.viewPublicIP.AutoSize = true;
			this.viewPublicIP.Location = new System.Drawing.Point(102, 55);
			this.viewPublicIP.Name = "viewPublicIP";
			this.viewPublicIP.Size = new System.Drawing.Size(40, 13);
			this.viewPublicIP.TabIndex = 2;
			this.viewPublicIP.Text = "0.0.0.0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 80);
			this.Controls.Add(this.viewPublicIP);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnConnectVPN);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "SimpleConnect";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConnectVPN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label viewPublicIP;
	}
}

