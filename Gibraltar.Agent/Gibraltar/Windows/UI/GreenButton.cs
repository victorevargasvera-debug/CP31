using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000CF RID: 207
	[global::System.ComponentModel.DefaultEvent("Click")]
	internal class GreenButton : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x00012DA0 File Offset: 0x00010FA0
		public GreenButton()
		{
			this.InitializeComponent();
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00012DB0 File Offset: 0x00010FB0
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00012DC0 File Offset: 0x00010FC0
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
		public override string Text
		{
			get
			{
				return this.btnInternalButton.Text;
			}
			set
			{
				this.btnInternalButton.Text = value;
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00012DD0 File Offset: 0x00010FD0
		protected override void OnForeColorChanged(global::System.EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.btnInternalButton.ForeColor = this.ForeColor;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00012DEC File Offset: 0x00010FEC
		private void btnInternalButton_Click(object sender, global::System.EventArgs e)
		{
			this.OnClick(e);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00012DF8 File Offset: 0x00010FF8
		private void GreenButton_MouseEnter(object sender, global::System.EventArgs e)
		{
			this.btnInternalButton.BackgroundImage = global::Gibraltar.Windows.UI.FancyButtons.green_button_highlight;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00012E0C File Offset: 0x0001100C
		private void GreenButton_MouseLeave(object sender, global::System.EventArgs e)
		{
			this.btnInternalButton.BackgroundImage = global::Gibraltar.Windows.UI.FancyButtons.green_button;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00012E20 File Offset: 0x00011020
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00012E48 File Offset: 0x00011048
		private void InitializeComponent()
		{
			this.btnInternalButton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.btnInternalButton.BackgroundImage = global::Gibraltar.Windows.UI.FancyButtons.green_button;
			this.btnInternalButton.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnInternalButton.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnInternalButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnInternalButton.ForeColor = global::System.Drawing.Color.White;
			this.btnInternalButton.Location = new global::System.Drawing.Point(0, 0);
			this.btnInternalButton.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnInternalButton.Name = "btnInternalButton";
			this.btnInternalButton.Size = new global::System.Drawing.Size(99, 36);
			this.btnInternalButton.TabIndex = 0;
			this.btnInternalButton.Text = "button1";
			this.btnInternalButton.UseVisualStyleBackColor = false;
			this.btnInternalButton.MouseLeave += this.GreenButton_MouseLeave;
			this.btnInternalButton.Click += this.btnInternalButton_Click;
			this.btnInternalButton.MouseEnter += this.GreenButton_MouseEnter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.btnInternalButton);
			base.Name = "GreenButton";
			base.Size = new global::System.Drawing.Size(99, 36);
			base.ResumeLayout(false);
		}

		// Token: 0x040001DE RID: 478
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001DF RID: 479
		private global::System.Windows.Forms.Button btnInternalButton;
	}
}
