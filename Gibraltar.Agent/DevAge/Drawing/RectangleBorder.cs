using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevAge.Drawing
{
	// Token: 0x02000306 RID: 774
	[global::System.Serializable]
	internal struct RectangleBorder : global::DevAge.Drawing.IBorder, global::System.ICloneable
	{
		// Token: 0x060024E0 RID: 9440 RVA: 0x00080800 File Offset: 0x0007EA00
		public RectangleBorder(global::DevAge.Drawing.BorderLine p_Border)
		{
			this.Top = p_Border;
			this.Bottom = p_Border;
			this.Left = p_Border;
			this.Right = p_Border;
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00080820 File Offset: 0x0007EA20
		public RectangleBorder(global::DevAge.Drawing.BorderLine p_Right, global::DevAge.Drawing.BorderLine p_Bottom)
		{
			this.Right = p_Right;
			this.Bottom = p_Bottom;
			this.Top = new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.White, 0f);
			this.Left = new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.White, 0f);
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0008085C File Offset: 0x0007EA5C
		public RectangleBorder(global::DevAge.Drawing.BorderLine p_Top, global::DevAge.Drawing.BorderLine p_Bottom, global::DevAge.Drawing.BorderLine p_Left, global::DevAge.Drawing.BorderLine p_Right)
		{
			this.Top = p_Top;
			this.Bottom = p_Bottom;
			this.Left = p_Left;
			this.Right = p_Right;
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0008087C File Offset: 0x0007EA7C
		public global::DevAge.Drawing.RectangleBorder SetColor(global::System.Drawing.Color p_Color)
		{
			this.Top = new global::DevAge.Drawing.BorderLine(p_Color, this.Top.Width, this.Top.DashStyle, this.Top.Padding);
			this.Bottom = new global::DevAge.Drawing.BorderLine(p_Color, this.Bottom.Width, this.Bottom.DashStyle, this.Bottom.Padding);
			this.Left = new global::DevAge.Drawing.BorderLine(p_Color, this.Left.Width, this.Left.DashStyle, this.Left.Padding);
			this.Right = new global::DevAge.Drawing.BorderLine(p_Color, this.Right.Width, this.Right.DashStyle, this.Right.Padding);
			return this;
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00080948 File Offset: 0x0007EB48
		public global::DevAge.Drawing.RectangleBorder SetDashStyle(global::System.Drawing.Drawing2D.DashStyle dashStyle)
		{
			this.Top = new global::DevAge.Drawing.BorderLine(this.Top.Color, this.Top.Width, dashStyle, this.Top.Padding);
			this.Bottom = new global::DevAge.Drawing.BorderLine(this.Bottom.Color, this.Bottom.Width, dashStyle, this.Bottom.Padding);
			this.Left = new global::DevAge.Drawing.BorderLine(this.Left.Color, this.Left.Width, dashStyle, this.Left.Padding);
			this.Right = new global::DevAge.Drawing.BorderLine(this.Right.Color, this.Right.Width, dashStyle, this.Right.Padding);
			return this;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00080A14 File Offset: 0x0007EC14
		public global::DevAge.Drawing.RectangleBorder SetWidth(int p_Width)
		{
			this.Top = new global::DevAge.Drawing.BorderLine(this.Top.Color, (float)p_Width, this.Top.DashStyle, this.Top.Padding);
			this.Bottom = new global::DevAge.Drawing.BorderLine(this.Bottom.Color, (float)p_Width, this.Bottom.DashStyle, this.Bottom.Padding);
			this.Left = new global::DevAge.Drawing.BorderLine(this.Left.Color, (float)p_Width, this.Left.DashStyle, this.Left.Padding);
			this.Right = new global::DevAge.Drawing.BorderLine(this.Right.Color, (float)p_Width, this.Right.DashStyle, this.Right.Padding);
			return this;
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00080AE4 File Offset: 0x0007ECE4
		public global::DevAge.Drawing.RectangleBorder SetPadding(int padding)
		{
			this.Top = new global::DevAge.Drawing.BorderLine(this.Top.Color, this.Top.Width, this.Top.DashStyle, (float)padding);
			this.Bottom = new global::DevAge.Drawing.BorderLine(this.Bottom.Color, this.Bottom.Width, this.Bottom.DashStyle, (float)padding);
			this.Left = new global::DevAge.Drawing.BorderLine(this.Left.Color, this.Left.Width, this.Left.DashStyle, (float)padding);
			this.Right = new global::DevAge.Drawing.BorderLine(this.Right.Color, this.Right.Width, this.Right.DashStyle, (float)padding);
			return this;
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00080BB4 File Offset: 0x0007EDB4
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Top:",
				this.Top.ToString(),
				" Bottom:",
				this.Bottom.ToString(),
				" Left:",
				this.Left.ToString(),
				" Right:",
				this.Right.ToString()
			});
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00080C64 File Offset: 0x0007EE64
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != base.GetType())
			{
				return false;
			}
			global::DevAge.Drawing.RectangleBorder rectangleBorder = (global::DevAge.Drawing.RectangleBorder)obj;
			return rectangleBorder.Left == this.Left && rectangleBorder.Bottom == this.Bottom && rectangleBorder.Top == this.Top && rectangleBorder.Right == this.Right;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00080D00 File Offset: 0x0007EF00
		public override int GetHashCode()
		{
			return this.Left.GetHashCode();
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00080D14 File Offset: 0x0007EF14
		public static bool operator ==(global::DevAge.Drawing.RectangleBorder a, global::DevAge.Drawing.RectangleBorder b)
		{
			return a.Equals(b);
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00080D2C File Offset: 0x0007EF2C
		public static bool operator !=(global::DevAge.Drawing.RectangleBorder a, global::DevAge.Drawing.RectangleBorder b)
		{
			return !a.Equals(b);
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00080D44 File Offset: 0x0007EF44
		public static global::DevAge.Drawing.RectangleBorder CreateInsetBorder(int p_width, global::System.Drawing.Color p_ShadowColor, global::System.Drawing.Color p_LightColor)
		{
			return new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.White))
			{
				Top = new global::DevAge.Drawing.BorderLine(p_ShadowColor, (float)p_width),
				Left = new global::DevAge.Drawing.BorderLine(p_ShadowColor, (float)p_width),
				Bottom = new global::DevAge.Drawing.BorderLine(p_LightColor, (float)p_width),
				Right = new global::DevAge.Drawing.BorderLine(p_LightColor, (float)p_width)
			};
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00080DA4 File Offset: 0x0007EFA4
		public static global::DevAge.Drawing.RectangleBorder CreateRaisedBorder(int p_width, global::System.Drawing.Color p_ShadowColor, global::System.Drawing.Color p_LightColor)
		{
			return new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.White))
			{
				Top = new global::DevAge.Drawing.BorderLine(p_LightColor, (float)p_width),
				Left = new global::DevAge.Drawing.BorderLine(p_LightColor, (float)p_width),
				Bottom = new global::DevAge.Drawing.BorderLine(p_ShadowColor, (float)p_width),
				Right = new global::DevAge.Drawing.BorderLine(p_ShadowColor, (float)p_width)
			};
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00080E04 File Offset: 0x0007F004
		public global::System.Drawing.RectangleF GetContentRectangle(global::System.Drawing.RectangleF backGroundArea)
		{
			backGroundArea.Y += this.Top.Width + this.Top.Padding;
			backGroundArea.X += this.Left.Width + this.Left.Padding;
			backGroundArea.Width -= this.Left.Width + this.Right.Width + this.Left.Padding + this.Right.Padding;
			backGroundArea.Height -= this.Top.Width + this.Bottom.Width + this.Top.Padding + this.Bottom.Padding;
			return backGroundArea;
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00080EDC File Offset: 0x0007F0DC
		public global::System.Drawing.SizeF GetExtent(global::System.Drawing.SizeF contentSize)
		{
			contentSize.Width += this.Left.Width + this.Right.Width + this.Left.Padding + this.Right.Padding;
			contentSize.Height += this.Top.Width + this.Bottom.Width + this.Top.Padding + this.Bottom.Padding;
			return contentSize;
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00080F68 File Offset: 0x0007F168
		public void Draw(global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.RectangleF rectangle)
		{
			global::DevAge.Drawing.RectangleBorder rectangleBorder = this;
			rectangle = new global::System.Drawing.RectangleF(rectangle.X + this.Left.Padding, rectangle.Y + this.Top.Padding, rectangle.Width - (this.Left.Padding + this.Right.Padding), rectangle.Height - (this.Top.Padding + this.Bottom.Padding));
			if (rectangle.Width <= 0f || rectangle.Height <= 0f)
			{
				return;
			}
			global::DevAge.Drawing.PensCache pensCache = graphics.PensCache;
			if (rectangleBorder.Left.Width > 0f)
			{
				global::System.Drawing.Pen pen = pensCache.GetPen(rectangleBorder.Left.Color, rectangleBorder.Left.Width, rectangleBorder.Left.DashStyle);
				float x;
				float y;
				if (rectangleBorder.Left.Width > 1f)
				{
					x = rectangle.X + rectangleBorder.Left.Width / 2f;
					y = rectangle.Bottom;
				}
				else
				{
					x = rectangle.X;
					y = rectangle.Bottom - 1f;
				}
				graphics.Graphics.DrawLine(pen, new global::System.Drawing.PointF(x, rectangle.Y), new global::System.Drawing.PointF(x, y));
			}
			if (rectangleBorder.Right.Width > 0f)
			{
				global::System.Drawing.Pen pen2 = pensCache.GetPen(rectangleBorder.Right.Color, rectangleBorder.Right.Width, rectangleBorder.Right.DashStyle);
				float x2;
				float y2;
				if (rectangleBorder.Right.Width > 1f)
				{
					x2 = rectangle.Right - rectangleBorder.Right.Width / 2f;
					y2 = rectangle.Bottom;
				}
				else
				{
					x2 = rectangle.Right - 1f;
					y2 = rectangle.Bottom - 1f;
				}
				graphics.Graphics.DrawLine(pen2, new global::System.Drawing.PointF(x2, rectangle.Y), new global::System.Drawing.PointF(x2, y2));
			}
			if (rectangleBorder.Top.Width > 0f)
			{
				global::System.Drawing.Pen pen3 = pensCache.GetPen(rectangleBorder.Top.Color, rectangleBorder.Top.Width, rectangleBorder.Top.DashStyle);
				float y3;
				float x3;
				if (rectangleBorder.Top.Width > 1f)
				{
					y3 = rectangle.Y + rectangleBorder.Top.Width / 2f;
					x3 = rectangle.Right;
				}
				else
				{
					y3 = rectangle.Y;
					x3 = rectangle.Right - 1f;
				}
				graphics.Graphics.DrawLine(pen3, new global::System.Drawing.PointF(rectangle.X, y3), new global::System.Drawing.PointF(x3, y3));
			}
			if (rectangleBorder.Bottom.Width > 0f)
			{
				global::System.Drawing.Pen pen4 = pensCache.GetPen(rectangleBorder.Bottom.Color, rectangleBorder.Bottom.Width, rectangleBorder.Bottom.DashStyle);
				float y4;
				float x4;
				if (rectangleBorder.Bottom.Width > 1f)
				{
					y4 = rectangle.Bottom - rectangleBorder.Bottom.Width / 2f;
					x4 = rectangle.Right;
				}
				else
				{
					y4 = rectangle.Bottom - 1f;
					x4 = rectangle.Right - 1f;
				}
				graphics.Graphics.DrawLine(pen4, new global::System.Drawing.PointF(rectangle.X, y4), new global::System.Drawing.PointF(x4, y4));
			}
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00081314 File Offset: 0x0007F514
		public global::DevAge.Drawing.RectanglePartType GetPointPartType(global::System.Drawing.RectangleF area, global::System.Drawing.PointF point, out float distanceFromBorder)
		{
			if (!area.Contains(point))
			{
				distanceFromBorder = -1f;
				return global::DevAge.Drawing.RectanglePartType.None;
			}
			global::System.Drawing.RectangleF contentRectangle = this.GetContentRectangle(area);
			if (contentRectangle.Contains(point))
			{
				distanceFromBorder = -1f;
				return global::DevAge.Drawing.RectanglePartType.ContentArea;
			}
			if (point.X >= area.Left && point.X < contentRectangle.Left)
			{
				distanceFromBorder = point.X - area.Left;
				return global::DevAge.Drawing.RectanglePartType.LeftBorder;
			}
			if (point.X < area.Right && point.X >= contentRectangle.Right)
			{
				distanceFromBorder = area.Right - point.X;
				return global::DevAge.Drawing.RectanglePartType.RightBorder;
			}
			if (point.Y >= area.Top && point.Y < contentRectangle.Top)
			{
				distanceFromBorder = point.Y - area.Top;
				return global::DevAge.Drawing.RectanglePartType.TopBorder;
			}
			if (point.Y < area.Bottom && point.Y >= contentRectangle.Bottom)
			{
				distanceFromBorder = area.Bottom - point.Y;
				return global::DevAge.Drawing.RectanglePartType.BottomBorder;
			}
			distanceFromBorder = -1f;
			return global::DevAge.Drawing.RectanglePartType.None;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00081448 File Offset: 0x0007F648
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x04000CE2 RID: 3298
		public static readonly global::DevAge.Drawing.RectangleBorder NoBorder = new global::DevAge.Drawing.RectangleBorder(global::DevAge.Drawing.BorderLine.NoBorder);

		// Token: 0x04000CE3 RID: 3299
		public static readonly global::DevAge.Drawing.RectangleBorder RectangleBlack1Width = new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Black, 1f));

		// Token: 0x04000CE4 RID: 3300
		public global::DevAge.Drawing.BorderLine Top;

		// Token: 0x04000CE5 RID: 3301
		public global::DevAge.Drawing.BorderLine Bottom;

		// Token: 0x04000CE6 RID: 3302
		public global::DevAge.Drawing.BorderLine Left;

		// Token: 0x04000CE7 RID: 3303
		public global::DevAge.Drawing.BorderLine Right;
	}
}
