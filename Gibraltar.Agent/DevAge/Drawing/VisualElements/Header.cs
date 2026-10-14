using System;
using System.Drawing;

namespace DevAge.Drawing.VisualElements
{
	// Token: 0x02000308 RID: 776
	[global::System.Serializable]
	internal class Header : global::DevAge.Drawing.VisualElements.HeaderBase
	{
		// Token: 0x060024FD RID: 9469 RVA: 0x00081628 File Offset: 0x0007F828
		public Header() : this(45f)
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00081638 File Offset: 0x0007F838
		public Header(float gradientAngle)
		{
			this.mGradientAngle = 45f;
			this.mBackgroundColorStyle = global::DevAge.Drawing.BackgroundColorStyle.Linear;
			base..ctor();
			this.GradientAngle = gradientAngle;
			this.mBackground = new global::DevAge.Drawing.VisualElements.BackgroundLinearGradient(global::System.Drawing.Color.Empty, global::System.Drawing.Color.Empty, this.GradientAngle);
			this.BackColor = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Control);
			global::System.Drawing.Color p_Color = global::DevAge.Drawing.Utilities.CalculateLightDarkColor(this.BackColor, -0.2f);
			global::DevAge.Drawing.BorderLine borderLine = new global::DevAge.Drawing.BorderLine(p_Color, 1f);
			this.mBorder = new global::DevAge.Drawing.RectangleBorder(borderLine, borderLine);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000816BC File Offset: 0x0007F8BC
		public Header(global::DevAge.Drawing.VisualElements.Header other)
		{
			this.mGradientAngle = 45f;
			this.mBackgroundColorStyle = global::DevAge.Drawing.BackgroundColorStyle.Linear;
			base..ctor(other);
			this.BackColor = other.BackColor;
			this.Border = other.Border;
			this.GradientAngle = other.GradientAngle;
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x0008170C File Offset: 0x0007F90C
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x00081714 File Offset: 0x0007F914
		public global::System.Drawing.Color BackColor
		{
			get
			{
				return this.mBackColor;
			}
			set
			{
				this.mBackColor = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x00081720 File Offset: 0x0007F920
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x00081728 File Offset: 0x0007F928
		public global::DevAge.Drawing.RectangleBorder Border
		{
			get
			{
				return this.mBorder;
			}
			set
			{
				this.mBorder = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x00081734 File Offset: 0x0007F934
		// (set) Token: 0x06002505 RID: 9477 RVA: 0x0008173C File Offset: 0x0007F93C
		public float GradientAngle
		{
			get
			{
				return this.mGradientAngle;
			}
			set
			{
				this.mGradientAngle = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x00081748 File Offset: 0x0007F948
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x00081750 File Offset: 0x0007F950
		public global::DevAge.Drawing.BackgroundColorStyle BackgroundColorStyle
		{
			get
			{
				return this.mBackgroundColorStyle;
			}
			set
			{
				this.mBackgroundColorStyle = value;
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0008175C File Offset: 0x0007F95C
		public override object Clone()
		{
			return new global::DevAge.Drawing.VisualElements.Header(this);
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x00081764 File Offset: 0x0007F964
		public override global::System.Drawing.RectangleF GetBackgroundContentRectangle(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea = this.mBorder.GetContentRectangle(backGroundArea);
			return base.GetBackgroundContentRectangle(measure, backGroundArea);
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0008177C File Offset: 0x0007F97C
		public override global::System.Drawing.SizeF GetBackgroundExtent(global::DevAge.Drawing.MeasureHelper measure, global::System.Drawing.SizeF contentSize)
		{
			global::System.Drawing.SizeF backgroundExtent = base.GetBackgroundExtent(measure, contentSize);
			return this.mBorder.GetExtent(contentSize);
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000817A4 File Offset: 0x0007F9A4
		protected override void OnDraw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			this.OnDrawBackground(graphics, area);
			this.OnDrawBorder(graphics, area);
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000817B8 File Offset: 0x0007F9B8
		protected virtual void OnDrawBorder(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			this.mBorder.Draw(graphics, area);
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000817C8 File Offset: 0x0007F9C8
		protected virtual void OnDrawBackground(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF area)
		{
			global::System.Drawing.Color color = global::DevAge.Drawing.Utilities.CalculateLightDarkColor(this.BackColor, -0.2f);
			global::System.Drawing.Color color2 = global::DevAge.Drawing.Utilities.CalculateLightDarkColor(this.BackColor, 0.5f);
			global::System.Drawing.Color color3 = global::DevAge.Drawing.Utilities.CalculateMiddleColor(global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Highlight), color2);
			if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Hot)
			{
				this.mBackground.FirstColor = color3;
				this.mBackground.SecondColor = color3;
			}
			else if (this.Style == global::DevAge.Drawing.ControlDrawStyle.Pressed)
			{
				this.mBackground.FirstColor = color;
				this.mBackground.SecondColor = color2;
			}
			else if (this.BackgroundColorStyle == global::DevAge.Drawing.BackgroundColorStyle.Linear)
			{
				this.mBackground.FirstColor = color2;
				this.mBackground.SecondColor = color;
			}
			else if (this.BackgroundColorStyle == global::DevAge.Drawing.BackgroundColorStyle.Solid)
			{
				this.mBackground.FirstColor = this.BackColor;
				this.mBackground.SecondColor = this.BackColor;
			}
			else
			{
				this.mBackground.FirstColor = global::System.Drawing.Color.Empty;
				this.mBackground.SecondColor = global::System.Drawing.Color.Empty;
			}
			this.mBackground.Angle = this.GradientAngle;
			this.mBackground.Draw(graphics, area);
		}

		// Token: 0x04000CE9 RID: 3305
		private global::System.Drawing.Color mBackColor;

		// Token: 0x04000CEA RID: 3306
		private global::DevAge.Drawing.RectangleBorder mBorder;

		// Token: 0x04000CEB RID: 3307
		private float mGradientAngle;

		// Token: 0x04000CEC RID: 3308
		private global::DevAge.Drawing.BackgroundColorStyle mBackgroundColorStyle;

		// Token: 0x04000CED RID: 3309
		private global::DevAge.Drawing.VisualElements.BackgroundLinearGradient mBackground;
	}
}
