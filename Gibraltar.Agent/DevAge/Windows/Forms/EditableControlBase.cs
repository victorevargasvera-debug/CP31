using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002C9 RID: 713
	internal class EditableControlBase : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060022E4 RID: 8932 RVA: 0x0007A9D8 File Offset: 0x00078BD8
		public EditableControlBase()
		{
			this.InitializeComponent();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserMouse, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, false);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.ResizeRedraw, true);
			this.BackColor = global::DevAge.Windows.Forms.EditableControlBase.DefaultColor;
			this.mContainer.Background = this.mBackground;
			this.mContainer.Border = this.mEditablePanel;
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0007AA84 File Offset: 0x00078C84
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0007AAAC File Offset: 0x00078CAC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x0007AABC File Offset: 0x00078CBC
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			using (global::DevAge.Drawing.GraphicsCache graphicsCache = new global::DevAge.Drawing.GraphicsCache(e.Graphics, e.ClipRectangle))
			{
				this.mEditablePanel.Draw(graphicsCache, base.ClientRectangle);
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0007AB1C File Offset: 0x00078D1C
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0007AB24 File Offset: 0x00078D24
		[global::System.ComponentModel.DefaultValue(typeof(global::System.Drawing.Color), "Window")]
		public new global::System.Drawing.Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				this.mBackground.BackColor = value;
				base.BackColor = value;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x0007AB3C File Offset: 0x00078D3C
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x0007AB4C File Offset: 0x00078D4C
		[global::System.ComponentModel.DefaultValue(global::DevAge.Drawing.BorderStyle.System)]
		public new global::DevAge.Drawing.BorderStyle BorderStyle
		{
			get
			{
				return this.mEditablePanel.BorderStyle;
			}
			set
			{
				this.mEditablePanel.BorderStyle = value;
				this.OnBorderStyleChanged(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0007AB68 File Offset: 0x00078D68
		protected virtual void OnBorderStyleChanged(global::System.EventArgs e)
		{
			base.Invalidate();
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x0007AB70 File Offset: 0x00078D70
		public override global::System.Drawing.Rectangle DisplayRectangle
		{
			get
			{
				global::System.Drawing.Rectangle result;
				using (global::DevAge.Drawing.MeasureHelper measureHelper = new global::DevAge.Drawing.MeasureHelper(this))
				{
					result = global::System.Drawing.Rectangle.Round(this.mContainer.GetContentRectangle(measureHelper, base.DisplayRectangle));
				}
				return result;
			}
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0007ABC4 File Offset: 0x00078DC4
		protected void SetContentAndButtonLocation(global::System.Windows.Forms.Control content, global::System.Windows.Forms.Control rightButton)
		{
			global::System.Drawing.Rectangle displayRectangle = this.DisplayRectangle;
			rightButton.Bounds = new global::System.Drawing.Rectangle(displayRectangle.Right - 18, displayRectangle.Y, 18, displayRectangle.Height);
			int width = rightButton.Location.X - this.DisplayRectangle.X;
			content.Bounds = new global::System.Drawing.Rectangle(displayRectangle.Location, new global::System.Drawing.Size(width, displayRectangle.Height));
		}

		// Token: 0x04000C7F RID: 3199
		private global::System.ComponentModel.Container components;

		// Token: 0x04000C80 RID: 3200
		private global::DevAge.Drawing.VisualElements.Container mContainer = new global::DevAge.Drawing.VisualElements.Container();

		// Token: 0x04000C81 RID: 3201
		private global::DevAge.Drawing.VisualElements.EditablePanelThemed mEditablePanel = new global::DevAge.Drawing.VisualElements.EditablePanelThemed();

		// Token: 0x04000C82 RID: 3202
		private global::DevAge.Drawing.VisualElements.BackgroundSolid mBackground = new global::DevAge.Drawing.VisualElements.BackgroundSolid();

		// Token: 0x04000C83 RID: 3203
		private static readonly global::System.Drawing.Color DefaultColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Window);
	}
}
