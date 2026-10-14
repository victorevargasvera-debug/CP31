using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002E4 RID: 740
	[global::System.Serializable]
	internal class Button : global::DevAge.Drawing.VisualElements.ButtonBase
	{
		// Token: 0x060023AB RID: 9131 RVA: 0x0007C7AC File Offset: 0x0007A9AC
		public Button()
		{
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0007C7B4 File Offset: 0x0007A9B4
		public Button(global::DevAge.Drawing.VisualElements.Button other) : base(other)
		{
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x0007C7C0 File Offset: 0x0007A9C0
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.Button(this);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x0007C7C8 File Offset: 0x0007A9C8
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			base.OnDraw(graphics, area);
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
			global::System.Windows.Forms.ControlPaint.DrawButton(graphics.Graphics, global::System.Drawing.Rectangle.Round(area), state);
			if (this.Style == global::DevAge.Drawing.ButtonStyle.NormalDefault)
			{
				graphics.Graphics.DrawRectangle(global::System.Drawing.Pens.Black, global::System.Drawing.Rectangle.Round(area));
			}
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Focus)
			{
				using (global::DevAge.Drawing.MeasureHelper measureHelper = new global::DevAge.Drawing.MeasureHelper(graphics))
				{
					global::System.Windows.Forms.ControlPaint.DrawFocusRectangle(graphics.Graphics, global::System.Drawing.Rectangle.Round(this.GetBackgroundContentRectangle(measureHelper, area)));
				}
			}
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0007C8A4 File Offset: 0x0007AAA4
		public override global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea = base.GetBackgroundContentRectangle(measure, backGroundArea);
			if (backGroundArea.Width > 4f)
			{
				backGroundArea.X += 2f;
				backGroundArea.Width -= 4f;
			}
			if (backGroundArea.Height > 4f)
			{
				backGroundArea.Y += 2f;
				backGroundArea.Height -= 4f;
			}
			return backGroundArea;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0007C930 File Offset: 0x0007AB30
		public override global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			contentSize = new global::System.Drawing.SizeF(contentSize.Width + 4f, contentSize.Height + 4f);
			return base.GetBackgroundExtent(measure, contentSize);
		}
	}
}
