using System.ComponentModel;

namespace Repair {
	partial class RootForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.btnLoadTemplate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLoadTemplate
			// 
			this.btnLoadTemplate.Location = new System.Drawing.Point(14, 15);
			this.btnLoadTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnLoadTemplate.Name = "btnLoadTemplate";
			this.btnLoadTemplate.Size = new System.Drawing.Size(164, 38);
			this.btnLoadTemplate.TabIndex = 0;
			this.btnLoadTemplate.Text = "Открыть документ";
			this.btnLoadTemplate.UseVisualStyleBackColor = true;
			// 
			// RootForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(934, 553);
			this.Controls.Add(this.btnLoadTemplate);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "RootForm";
			this.Text = "RootForm";
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnLoadTemplate;

		#endregion
	}
}