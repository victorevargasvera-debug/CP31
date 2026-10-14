using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002ED RID: 749
	[global::System.Serializable]
	internal class DropDownButton : global::DevAge.Drawing.VisualElements.DropDownButtonBase
	{
		// Token: 0x06002417 RID: 9239 RVA: 0x0007DB44 File Offset: 0x0007BD44
		public DropDownButton()
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x0007DB4C File Offset: 0x0007BD4C
		public DropDownButton(global::DevAge.Drawing.VisualElements.DropDownButton other) : base(other)
		{
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x0007DB58 File Offset: 0x0007BD58
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.DropDownButton(this);
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0007DB60 File Offset: 0x0007BD60
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			global::System.Windows.Forms.ButtonState state;
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Disabled)
			{
				state = global::System.Windows.Forms.ButtonState.Inactive;
			}
			else if (this.Style == global::DevAge.Drawing.ButtonStyle.Pressed)
			{
				state = global::System.Windows.Forms.ButtonState.Pushed;
			}
			else if (this.Style == global::DevAge.Drawing.ButtonStyle.Hot)
			{
				state = global::System.Windows.Forms.ButtonState.Normal;
			}
			else
			{
				state = global::System.Windows.Forms.ButtonState.Normal;
			}
			global::System.Windows.Forms.ControlPaint.DrawComboButton(graphics.Graphics, global::System.Drawing.Rectangle.Round(area), state);
			if (this.Style == global::DevAge.Drawing.ButtonStyle.NormalDefault)
			{
				graphics.Graphics.DrawRectangle(global::System.Drawing.Pens.Black, global::System.Drawing.Rectangle.Round(area));
			}
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Focus)
			{
				using (new global::DevAge.Drawing.MeasureHelper(graphics))
				{
					global::System.Windows.Forms.ControlPaint.DrawFocusRectangle(graphics.Graphics, global::System.Drawing.Rectangle.Round(area));
				}
			}
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0007DC2C File Offset: 0x0007BE2C
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			return new global::System.Drawing.SizeF(16f, 16f);
		}
	}
}
