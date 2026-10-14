using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002E3 RID: 739
	[global::System.Serializable]
	internal class DropDownButtonThemed : global::DevAge.Drawing.VisualElements.DropDownButtonBase
	{
		// Token: 0x060023A2 RID: 9122 RVA: 0x0007C61C File Offset: 0x0007A81C
		public DropDownButtonThemed()
		{
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0007C630 File Offset: 0x0007A830
		public DropDownButtonThemed(global::DevAge.Drawing.VisualElements.DropDownButtonThemed other) : base(other)
		{
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0007C644 File Offset: 0x0007A844
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.DropDownButtonThemed(this);
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060023A5 RID: 9125 RVA: 0x0007C64C File Offset: 0x0007A84C
		// (set) Token: 0x060023A6 RID: 9126 RVA: 0x0007C654 File Offset: 0x0007A854
		public override global::DevAge.Drawing.ButtonStyle Style
		{
			get
			{
				return base.Style;
			}
			set
			{
				base.Style = value;
				this.mStandardButton.Style = value;
			}
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0007C66C File Offset: 0x0007A86C
		protected global::System.Windows.Forms.VisualStyles.VisualStyleElement GetBackgroundElement()
		{
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Hot)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.ComboBox.DropDownButton.Hot;
			}
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Pressed)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.ComboBox.DropDownButton.Pressed;
			}
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Disabled)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.ComboBox.DropDownButton.Disabled;
			}
			return global::System.Windows.Forms.VisualStyles.VisualStyleElement.ComboBox.DropDownButton.Normal;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0007C6AC File Offset: 0x0007A8AC
		protected global::System.Windows.Forms.VisualStyles.VisualStyleRenderer GetRenderer(global::System.Windows.Forms.VisualStyles.VisualStyleElement element)
		{
			return new global::System.Windows.Forms.VisualStyles.VisualStyleRenderer(element);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0007C6B4 File Offset: 0x0007A8B4
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				this.GetRenderer(this.GetBackgroundElement()).DrawBackground(graphics.Graphics, global::System.Drawing.Rectangle.Round(area));
				if (this.Style != global::DevAge.Drawing.ButtonStyle.Focus)
				{
					return;
				}
				using (new global::DevAge.Drawing.MeasureHelper(graphics))
				{
					global::System.Windows.Forms.ControlPaint.DrawFocusRectangle(graphics.Graphics, global::System.Drawing.Rectangle.Round(area));
					return;
				}
			}
			this.mStandardButton.Draw(graphics, area);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0007C74C File Offset: 0x0007A94C
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				return this.GetRenderer(this.GetBackgroundElement()).GetPartSize(measure.Graphics, global::System.Windows.Forms.VisualStyles.ThemeSizeType.True);
			}
			return this.mStandardButton.Measure(measure, global::System.Drawing.Size.Empty, maxSize);
		}

		// Token: 0x04000CA8 RID: 3240
		private global::DevAge.Drawing.VisualElements.DropDownButton mStandardButton = new global::DevAge.Drawing.VisualElements.DropDownButton();
	}
}
