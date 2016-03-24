namespace Trocomatic {
	partial class UxMainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxMainForm));
			this.UxLblPaidValue = new System.Windows.Forms.Label();
			this.UxLblProductValue = new System.Windows.Forms.Label();
			this.UxTbxPaidValue = new System.Windows.Forms.TextBox();
			this.UxTbxProductValue = new System.Windows.Forms.TextBox();
			this.UxBtnOk = new System.Windows.Forms.Button();
			this.UxBtnCancel = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.UxTbxChangeResult = new System.Windows.Forms.TextBox();
			this.UxLblChange = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// UxLblPaidValue
			// 
			this.UxLblPaidValue.AutoSize = true;
			this.UxLblPaidValue.Location = new System.Drawing.Point(111, 10);
			this.UxLblPaidValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UxLblPaidValue.Name = "UxLblPaidValue";
			this.UxLblPaidValue.Size = new System.Drawing.Size(61, 13);
			this.UxLblPaidValue.TabIndex = 0;
			this.UxLblPaidValue.Text = "Valor pago:";
			// 
			// UxLblProductValue
			// 
			this.UxLblProductValue.AutoSize = true;
			this.UxLblProductValue.Location = new System.Drawing.Point(111, 41);
			this.UxLblProductValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UxLblProductValue.Name = "UxLblProductValue";
			this.UxLblProductValue.Size = new System.Drawing.Size(88, 13);
			this.UxLblProductValue.TabIndex = 1;
			this.UxLblProductValue.Text = "Valor do produto:";
			// 
			// UxTbxPaidValue
			// 
			this.UxTbxPaidValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UxTbxPaidValue.Location = new System.Drawing.Point(198, 8);
			this.UxTbxPaidValue.Margin = new System.Windows.Forms.Padding(2);
			this.UxTbxPaidValue.Name = "UxTbxPaidValue";
			this.UxTbxPaidValue.Size = new System.Drawing.Size(97, 20);
			this.UxTbxPaidValue.TabIndex = 2;
			// 
			// UxTbxProductValue
			// 
			this.UxTbxProductValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UxTbxProductValue.Location = new System.Drawing.Point(198, 39);
			this.UxTbxProductValue.Margin = new System.Windows.Forms.Padding(2);
			this.UxTbxProductValue.Name = "UxTbxProductValue";
			this.UxTbxProductValue.Size = new System.Drawing.Size(97, 20);
			this.UxTbxProductValue.TabIndex = 3;
			// 
			// UxBtnOk
			// 
			this.UxBtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UxBtnOk.Location = new System.Drawing.Point(150, 84);
			this.UxBtnOk.Margin = new System.Windows.Forms.Padding(2);
			this.UxBtnOk.Name = "UxBtnOk";
			this.UxBtnOk.Size = new System.Drawing.Size(67, 26);
			this.UxBtnOk.TabIndex = 4;
			this.UxBtnOk.Text = "Ok";
			this.UxBtnOk.UseVisualStyleBackColor = true;
			this.UxBtnOk.Click += new System.EventHandler(this.UxBtnOk_Click);
			// 
			// UxBtnCancel
			// 
			this.UxBtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.UxBtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.UxBtnCancel.Location = new System.Drawing.Point(227, 84);
			this.UxBtnCancel.Margin = new System.Windows.Forms.Padding(2);
			this.UxBtnCancel.Name = "UxBtnCancel";
			this.UxBtnCancel.Size = new System.Drawing.Size(67, 26);
			this.UxBtnCancel.TabIndex = 5;
			this.UxBtnCancel.Text = "Cancel";
			this.UxBtnCancel.UseVisualStyleBackColor = true;
			this.UxBtnCancel.Click += new System.EventHandler(this.UxBtnCancel_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Trocomatic.Properties.Resources._018_vending_machine_cola_soda_512;
			this.pictureBox1.Location = new System.Drawing.Point(8, 4);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(88, 107);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// UxTbxChangeResult
			// 
			this.UxTbxChangeResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UxTbxChangeResult.Location = new System.Drawing.Point(8, 139);
			this.UxTbxChangeResult.Margin = new System.Windows.Forms.Padding(2);
			this.UxTbxChangeResult.Multiline = true;
			this.UxTbxChangeResult.Name = "UxTbxChangeResult";
			this.UxTbxChangeResult.ReadOnly = true;
			this.UxTbxChangeResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.UxTbxChangeResult.Size = new System.Drawing.Size(287, 54);
			this.UxTbxChangeResult.TabIndex = 7;
			// 
			// UxLblChange
			// 
			this.UxLblChange.AutoSize = true;
			this.UxLblChange.Location = new System.Drawing.Point(8, 124);
			this.UxLblChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UxLblChange.Name = "UxLblChange";
			this.UxLblChange.Size = new System.Drawing.Size(38, 13);
			this.UxLblChange.TabIndex = 8;
			this.UxLblChange.Text = "Troco:";
			// 
			// UxMainForm
			// 
			this.AcceptButton = this.UxBtnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.UxBtnCancel;
			this.ClientSize = new System.Drawing.Size(305, 200);
			this.Controls.Add(this.UxLblChange);
			this.Controls.Add(this.UxTbxChangeResult);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.UxBtnCancel);
			this.Controls.Add(this.UxBtnOk);
			this.Controls.Add(this.UxTbxProductValue);
			this.Controls.Add(this.UxTbxPaidValue);
			this.Controls.Add(this.UxLblProductValue);
			this.Controls.Add(this.UxLblPaidValue);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UxMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Trocomatic";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UxLblPaidValue;
		private System.Windows.Forms.Label UxLblProductValue;
		private System.Windows.Forms.TextBox UxTbxPaidValue;
		private System.Windows.Forms.TextBox UxTbxProductValue;
		private System.Windows.Forms.Button UxBtnOk;
		private System.Windows.Forms.Button UxBtnCancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox UxTbxChangeResult;
		private System.Windows.Forms.Label UxLblChange;
	}
}

