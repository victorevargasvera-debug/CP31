using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x020002D4 RID: 724
	[global::System.Serializable]
	internal class ButtonThemed : global::DevAge.Drawing.VisualElements.ButtonBase
	{
		// Token: 0x06002343 RID: 9027 RVA: 0x0007B7A8 File Offset: 0x000799A8
		public ButtonThemed()
		{
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0007B7BC File Offset: 0x000799BC
		public ButtonThemed(global::DevAge.Drawing.VisualElements.ButtonThemed other) : base(other)
		{
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0007B7D0 File Offset: 0x000799D0
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.ButtonThemed(this);
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x0007B7D8 File Offset: 0x000799D8
		// (set) Token: 0x06002347 RID: 9031 RVA: 0x0007B7E0 File Offset: 0x000799E0
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

		// Token: 0x06002348 RID: 9032 RVA: 0x0007B7F8 File Offset: 0x000799F8
		protected global::System.Windows.Forms.VisualStyles.VisualStyleElement GetBackgroundElement()
		{
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Hot)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.PushButton.Hot;
			}
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Pressed)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.PushButton.Pressed;
			}
			if (this.Style == global::DevAge.Drawing.ButtonStyle.Disabled)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.PushButton.Disabled;
			}
			if (this.Style == global::DevAge.Drawing.ButtonStyle.NormalDefault)
			{
				return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.PushButton.Default;
			}
			return global::System.Windows.Forms.VisualStyles.VisualStyleElement.Button.PushButton.Normal;
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0007B858 File Offset: 0x00079A58
		protected global::System.Windows.Forms.VisualStyles.VisualStyleRenderer GetRenderer(global::System.Windows.Forms.VisualStyles.VisualStyleElement element)
		{
			return new global::System.Windows.Forms.VisualStyles.VisualStyleRenderer(element);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0007B860 File Offset: 0x00079A60
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			base.OnDraw(graphics, area);
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				this.GetRenderer(this.GetBackgroundElement()).DrawBackground(graphics.Graphics, global::System.Drawing.Rectangle.Round(area));
				if (this.Style != global::DevAge.Drawing.ButtonStyle.Focus)
				{
					return;
				}
				using (global::DevAge.Drawing.MeasureHelper measureHelper = new global::DevAge.Drawing.MeasureHelper(graphics))
				{
					global::System.Windows.Forms.ControlPaint.DrawFocusRectangle(graphics.Graphics, global::System.Drawing.Rectangle.Round(this.GetBackgroundContentRectangle(measureHelper, area)));
					return;
				}
			}
			this.mStandardButton.Draw(graphics, area);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0007B908 File Offset: 0x00079B08
		public override global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea = base.GetBackgroundContentRectangle(measure, backGroundArea);
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				return this.GetRenderer(this.GetBackgroundElement()).GetBackgroundContentRectangle(measure.Graphics, global::System.Drawing.Rectangle.Round(backGroundArea));
			}
			return this.mStandardButton.GetBackgroundContentRectangle(measure, backGroundArea);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0007B970 File Offset: 0x00079B70
		public override global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			if (global::System.Windows.Forms.Application.RenderWithVisualStyles && global::System.Windows.Forms.VisualStyles.VisualStyleRenderer.IsElementDefined(this.GetBackgroundElement()))
			{
				global::System.Drawing.Rectangle contentBounds = new global::System.Drawing.Rectangle(new global::System.Drawing.Point(0, 0), global::System.Drawing.Size.Ceiling(contentSize));
				contentSize = this.GetRenderer(this.GetBackgroundElement()).GetBackgroundExtent(measure.Graphics, contentBounds).Size;
			}
			else
			{
				contentSize = this.mStandardButton.GetBackgroundExtent(measure, contentSize);
			}
			return base.GetBackgroundExtent(measure, contentSize);
		}

		// Token: 0x04000C92 RID: 3218
		private global::DevAge.Drawing.VisualElements.Button mStandardButton = new global::DevAge.Drawing.VisualElements.Button();
	}
}
