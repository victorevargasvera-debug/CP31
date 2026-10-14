using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002E9 RID: 745
	[global::System.Serializable]
	internal class CheckBox : global::DevAge.Drawing.VisualElements.CheckBoxBase
	{
		// Token: 0x060023DA RID: 9178 RVA: 0x0007D62C File Offset: 0x0007B82C
		public CheckBox()
		{
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x0007D634 File Offset: 0x0007B834
		public CheckBox(global::DevAge.Drawing.VisualElements.CheckBox other) : base(other)
		{
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0007D640 File Offset: 0x0007B840
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.CheckBox(this);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0007D648 File Offset: 0x0007B848
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			global::System.Windows.Forms.ButtonState buttonState;
			if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Disabled)
			{
				buttonState = global::System.Windows.Forms.ButtonState.Inactive;
			}
			else if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Pressed)
			{
				buttonState = global::System.Windows.Forms.ButtonState.Pushed;
			}
			else if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Hot)
			{
				buttonState = global::System.Windows.Forms.ButtonState.Normal;
			}
			else
			{
				buttonState = global::System.Windows.Forms.ButtonState.Normal;
			}
			if (this.CheckBoxState == global::DevAge.Drawing.CheckBoxState.Checked)
			{
				buttonState |= global::System.Windows.Forms.ButtonState.Checked;
			}
			global::System.Windows.Forms.ControlPaint.DrawCheckBox(graphics.Graphics, global::System.Drawing.Rectangle.Round(area), buttonState);
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0007D6C4 File Offset: 0x0007B8C4
		protected override global::System.Drawing.SizeF OnMeasureContent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF maxSize)
		{
			return new global::System.Drawing.SizeF(16f, 16f);
		}
	}
}
