using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000D1 RID: 209
	internal class UICommandLink : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x00013084 File Offset: 0x00011284
		public UICommandLink()
		{
			this.InitializeComponent();
			this.m_ShowHighlight = true;
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0001309C File Offset: 0x0001129C
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x000130AC File Offset: 0x000112AC
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Description("The text label of the button")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Always)]
		public string Label
		{
			get
			{
				return this.btnCommand.Text;
			}
			set
			{
				this.btnCommand.Text = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x000130BC File Offset: 0x000112BC
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x000130C4 File Offset: 0x000112C4
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Description("Hides the colored border highlight")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Always)]
		public bool ShowHighlight
		{
			get
			{
				return this.m_ShowHighlight;
			}
			set
			{
				this.m_ShowHighlight = value;
				this.btnCommand.FlatAppearance.BorderSize = (this.m_ShowHighlight ? 1 : 0);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x000130F0 File Offset: 0x000112F0
		private void btnCommand_MouseEnter(object sender, global::System.EventArgs e)
		{
			this.btnCommand.ImageKey = "arrow_highlight";
			if (this.m_ShowHighlight)
			{
				this.btnCommand.FlatAppearance.BorderColor = global::System.Drawing.Color.Turquoise;
				this.btnCommand.FlatAppearance.BorderSize = 1;
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00013144 File Offset: 0x00011344
		private void btnCommand_MouseLeave(object sender, global::System.EventArgs e)
		{
			this.btnCommand.ImageKey = "arrow";
			if (this.m_ShowHighlight)
			{
				this.btnCommand.FlatAppearance.BorderColor = global::System.Drawing.SystemColors.Window;
				this.btnCommand.FlatAppearance.BorderSize = 1;
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00013198 File Offset: 0x00011398
		private void btnCommand_Click(object sender, global::System.EventArgs e)
		{
			if (this.m_ShowHighlight)
			{
				this.btnCommand.FlatAppearance.BorderSize = 1;
			}
			base.OnClick(new global::System.EventArgs());
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000131C4 File Offset: 0x000113C4
		private void btnCommand_MouseDown(object sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			if (this.m_ShowHighlight)
			{
				this.btnCommand.FlatAppearance.BorderSize = 2;
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000131E4 File Offset: 0x000113E4
		private void btnCommand_MouseUp(object sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			if (this.m_ShowHighlight)
			{
				this.btnCommand.FlatAppearance.BorderSize = 1;
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00013204 File Offset: 0x00011404
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0001322C File Offset: 0x0001142C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gibraltar.Windows.UI.UICommandLink));
			this.btnCommand = new global::System.Windows.Forms.Button();
			this.vistaEmulationImages = new global::System.Windows.Forms.ImageList();
			base.SuspendLayout();
			this.btnCommand.BackColor = global::System.Drawing.Color.Transparent;
			this.btnCommand.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.btnCommand.FlatAppearance.BorderColor = global::System.Drawing.Color.White;
			this.btnCommand.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Transparent;
			this.btnCommand.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.btnCommand.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnCommand.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCommand.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCommand.ImageKey = "arrow";
			this.btnCommand.ImageList = this.vistaEmulationImages;
			this.btnCommand.Location = new global::System.Drawing.Point(0, 0);
			this.btnCommand.Margin = new global::System.Windows.Forms.Padding(0);
			this.btnCommand.Name = "btnCommand";
			this.btnCommand.Padding = new global::System.Windows.Forms.Padding(2, 6, 4, 6);
			this.btnCommand.Size = new global::System.Drawing.Size(199, 42);
			this.btnCommand.TabIndex = 26;
			this.btnCommand.Text = "btnCommandText";
			this.btnCommand.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCommand.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCommand.UseVisualStyleBackColor = false;
			this.btnCommand.Click += this.btnCommand_Click;
			this.btnCommand.MouseDown += this.btnCommand_MouseDown;
			this.btnCommand.MouseEnter += this.btnCommand_MouseEnter;
			this.btnCommand.MouseLeave += this.btnCommand_MouseLeave;
			this.btnCommand.MouseUp += this.btnCommand_MouseUp;
			this.vistaEmulationImages.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("vistaEmulationImages.ImageStream");
			this.vistaEmulationImages.TransparentColor = global::System.Drawing.Color.Transparent;
			this.vistaEmulationImages.Images.SetKeyName(0, "arrow");
			this.vistaEmulationImages.Images.SetKeyName(1, "arrow_highlight");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Transparent;
			base.Controls.Add(this.btnCommand);
			base.Margin = new global::System.Windows.Forms.Padding(3, 1, 3, 1);
			base.Name = "UICommandLink";
			base.Size = new global::System.Drawing.Size(199, 42);
			base.ResumeLayout(false);
		}

		// Token: 0x040001E2 RID: 482
		private bool m_ShowHighlight;

		// Token: 0x040001E3 RID: 483
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001E4 RID: 484
		private global::System.Windows.Forms.Button btnCommand;

		// Token: 0x040001E5 RID: 485
		private global::System.Windows.Forms.ImageList vistaEmulationImages;
	}
}
