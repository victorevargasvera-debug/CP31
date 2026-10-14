using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002D6 RID: 726
	internal class ColorPicker : global::DevAge.Windows.Forms.EditableControlBase
	{
		// Token: 0x06002351 RID: 9041 RVA: 0x0007BD0C File Offset: 0x00079F0C
		public ColorPicker()
		{
			this.InitializeComponent();
			this.SelectedColor = global::System.Drawing.Color.Black;
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x0007BD28 File Offset: 0x00079F28
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x0007BD50 File Offset: 0x00079F50
		// (set) Token: 0x06002354 RID: 9044 RVA: 0x0007BD60 File Offset: 0x00079F60
		public virtual global::System.Drawing.Color SelectedColor
		{
			get
			{
				return this.panelColor.BackColor;
			}
			set
			{
				this.panelColor.BackColor = value;
			}
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x0007BD70 File Offset: 0x00079F70
		private void InitializeComponent()
		{
			this.labelColor = new global::System.Windows.Forms.Label();
			this.panelColor = new global::System.Windows.Forms.Panel();
			this.btBrowse = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.labelColor.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.labelColor.BackColor = global::System.Drawing.SystemColors.Window;
			this.labelColor.Location = new global::System.Drawing.Point(28, 2);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new global::System.Drawing.Size(80, 16);
			this.labelColor.TabIndex = 2;
			this.labelColor.Text = "Black";
			this.labelColor.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.panelColor.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.panelColor.BackColor = global::System.Drawing.Color.Black;
			this.panelColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelColor.Location = new global::System.Drawing.Point(2, 2);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new global::System.Drawing.Size(20, 16);
			this.panelColor.TabIndex = 1;
			this.panelColor.BackColorChanged += this.panelColor_BackColorChanged;
			this.btBrowse.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btBrowse.BackColor = global::System.Drawing.SystemColors.Control;
			this.btBrowse.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.btBrowse.Location = new global::System.Drawing.Point(110, 2);
			this.btBrowse.Name = "btBrowse";
			this.btBrowse.Size = new global::System.Drawing.Size(24, 16);
			this.btBrowse.TabIndex = 0;
			this.btBrowse.Text = "...";
			this.btBrowse.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.btBrowse.Click += this.btBrowse_Click;
			base.Controls.Add(this.panelColor);
			base.Controls.Add(this.labelColor);
			base.Controls.Add(this.btBrowse);
			base.Name = "ColorPicker";
			base.Size = new global::System.Drawing.Size(136, 20);
			base.ResumeLayout(false);
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0007BFA0 File Offset: 0x0007A1A0
		private void panelColor_BackColorChanged(object sender, global::System.EventArgs e)
		{
			this.labelColor.Text = this.panelColor.BackColor.Name;
			if (this.SelectedColorChanged != null)
			{
				this.SelectedColorChanged(this, e);
			}
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0007BFE8 File Offset: 0x0007A1E8
		private void btBrowse_Click(object sender, global::System.EventArgs e)
		{
			try
			{
				using (global::System.Windows.Forms.ColorDialog colorDialog = new global::System.Windows.Forms.ColorDialog())
				{
					colorDialog.Color = this.SelectedColor;
					if (colorDialog.ShowDialog(this) == global::System.Windows.Forms.DialogResult.OK)
					{
						this.SelectedColor = colorDialog.Color;
					}
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x0007C05C File Offset: 0x0007A25C
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x0007C06C File Offset: 0x0007A26C
		public new global::System.Drawing.Color ForeColor
		{
			get
			{
				return this.labelColor.ForeColor;
			}
			set
			{
				this.labelColor.ForeColor = value;
			}
		}

		// Token: 0x1400009A RID: 154
		// (add) Token: 0x0600235A RID: 9050 RVA: 0x0007C07C File Offset: 0x0007A27C
		// (remove) Token: 0x0600235B RID: 9051 RVA: 0x0007C098 File Offset: 0x0007A298
		public event global::System.EventHandler SelectedColorChanged;

		// Token: 0x04000C94 RID: 3220
		private global::System.Windows.Forms.Button btBrowse;

		// Token: 0x04000C95 RID: 3221
		private global::System.Windows.Forms.Panel panelColor;

		// Token: 0x04000C96 RID: 3222
		private global::System.Windows.Forms.Label labelColor;

		// Token: 0x04000C97 RID: 3223
		private global::System.ComponentModel.Container components;
	}
}
