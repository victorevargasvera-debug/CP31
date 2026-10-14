using System;
using System.ComponentModel;
using System.Drawing;

namespace DevAge.Drawing
{
	// Token: 0x020002FA RID: 762
	[global::System.Serializable]
	internal class AnchorArea : global::System.ICloneable, global::System.IComparable
	{
		// Token: 0x0600246A RID: 9322 RVA: 0x0007EA28 File Offset: 0x0007CC28
		public AnchorArea()
		{
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0007EA5C File Offset: 0x0007CC5C
		public AnchorArea(float left, float top, float right, float bottom, bool center, bool middle)
		{
			this.Left = left;
			this.Top = top;
			this.Right = right;
			this.Bottom = bottom;
			this.Center = center;
			this.Middle = middle;
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0007EACC File Offset: 0x0007CCCC
		public AnchorArea(global::DevAge.Drawing.AnchorArea other)
		{
			this.Right = other.Right;
			this.Left = other.Left;
			this.Bottom = other.Bottom;
			this.Top = other.Top;
			this.Center = other.Center;
			this.Middle = other.Middle;
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0007EB58 File Offset: 0x0007CD58
		public AnchorArea(global::DevAge.Drawing.ContentAlignment aligment, bool stretch)
		{
			if (global::DevAge.Drawing.Utilities.IsBottom(aligment) || stretch)
			{
				this.Bottom = 0f;
			}
			if (global::DevAge.Drawing.Utilities.IsLeft(aligment) || stretch)
			{
				this.Left = 0f;
			}
			if (global::DevAge.Drawing.Utilities.IsRight(aligment) || stretch)
			{
				this.Right = 0f;
			}
			if (global::DevAge.Drawing.Utilities.IsTop(aligment) || stretch)
			{
				this.Top = 0f;
			}
			if (global::DevAge.Drawing.Utilities.IsCenter(aligment) && !stretch)
			{
				this.Center = true;
			}
			if (global::DevAge.Drawing.Utilities.IsMiddle(aligment) && !stretch)
			{
				this.Middle = true;
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x0007EC3C File Offset: 0x0007CE3C
		public static global::DevAge.Drawing.AnchorArea Empty
		{
			get
			{
				return new global::DevAge.Drawing.AnchorArea();
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x0007EC44 File Offset: 0x0007CE44
		public bool IsEmpty
		{
			get
			{
				return !this.HasRight && !this.HasLeft && !this.HasTop && !this.HasBottom && !this.Middle && !this.Center;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x0007EC98 File Offset: 0x0007CE98
		public bool HasRight
		{
			get
			{
				return !float.IsNaN(this.Right);
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x0007ECA8 File Offset: 0x0007CEA8
		public bool HasLeft
		{
			get
			{
				return !float.IsNaN(this.Left);
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x0007ECB8 File Offset: 0x0007CEB8
		public bool HasTop
		{
			get
			{
				return !float.IsNaN(this.Top);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x0007ECC8 File Offset: 0x0007CEC8
		public bool HasBottom
		{
			get
			{
				return !float.IsNaN(this.Bottom);
			}
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x0007ECD8 File Offset: 0x0007CED8
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Top ",
				this.Top.ToString(),
				", Bottom ",
				this.Bottom.ToString(),
				", Right ",
				this.Right.ToString(),
				", Left ",
				this.Left.ToString()
			});
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x0007ED70 File Offset: 0x0007CF70
		public override int GetHashCode()
		{
			return (int)(this.Top + this.Bottom + this.Left + this.Right);
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0007ED90 File Offset: 0x0007CF90
		public override bool Equals(object obj)
		{
			return this.CompareTo(obj) == 0;
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x0007ED9C File Offset: 0x0007CF9C
		public object Clone()
		{
			return new global::DevAge.Drawing.AnchorArea(this);
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x0007EDA4 File Offset: 0x0007CFA4
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is global::DevAge.Drawing.AnchorArea))
			{
				throw new global::System.ArgumentException("Invalid object, AnchorArea expected");
			}
			global::DevAge.Drawing.AnchorArea anchorArea = (global::DevAge.Drawing.AnchorArea)obj;
			int num = this.Top.CompareTo(anchorArea.Top);
			int num2 = this.Bottom.CompareTo(anchorArea.Bottom);
			int num3 = this.Left.CompareTo(anchorArea.Left);
			int num4 = this.Right.CompareTo(anchorArea.Right);
			int num5 = this.Center.CompareTo(anchorArea.Center);
			int num6 = this.Middle.CompareTo(anchorArea.Middle);
			if (num > 1)
			{
				return 1;
			}
			if (num < 1)
			{
				return -1;
			}
			if (num2 > 1)
			{
				return 1;
			}
			if (num2 < 1)
			{
				return -1;
			}
			if (num4 > 1)
			{
				return 1;
			}
			if (num4 < 1)
			{
				return -1;
			}
			if (num3 > 1)
			{
				return 1;
			}
			if (num3 < 1)
			{
				return -1;
			}
			if (num5 > 1)
			{
				return 1;
			}
			if (num5 < 1)
			{
				return -1;
			}
			if (num6 > 1)
			{
				return 1;
			}
			if (num6 < 1)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0007EEBC File Offset: 0x0007D0BC
		public static bool operator ==(global::DevAge.Drawing.AnchorArea a, global::DevAge.Drawing.AnchorArea b)
		{
			return object.ReferenceEquals(a, b) || (a != null && b != null && a.Equals(b));
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0007EEE4 File Offset: 0x0007D0E4
		public static bool operator !=(global::DevAge.Drawing.AnchorArea a, global::DevAge.Drawing.AnchorArea b)
		{
			return !(a == b);
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0007EEF0 File Offset: 0x0007D0F0
		public static global::System.Drawing.RectangleF CalculateArea(global::System.Drawing.RectangleF area, global::System.Drawing.SizeF content, global::DevAge.Drawing.AnchorArea anchor)
		{
			if (anchor.IsEmpty)
			{
				return area;
			}
			global::System.Drawing.RectangleF result = default(global::System.Drawing.RectangleF);
			if (anchor.Center)
			{
				result.X = area.X + area.Width / 2f - content.Width / 2f;
				result.Width = content.Width;
			}
			else if (anchor.HasLeft && anchor.HasRight)
			{
				result.X = area.Left + anchor.Left;
				result.Width = area.Width - (anchor.Left + anchor.Right);
			}
			else if (anchor.HasLeft)
			{
				result.X = area.Left + anchor.Left;
				result.Width = content.Width;
			}
			else if (anchor.HasRight)
			{
				result.X = area.Right - content.Width - anchor.Right;
				result.Width = content.Width;
			}
			else
			{
				result.X = area.Left;
				result.Width = content.Width;
			}
			if (anchor.Middle)
			{
				result.Y = area.Y + area.Height / 2f - content.Height / 2f;
				result.Height = content.Height;
			}
			else if (anchor.HasTop && anchor.HasBottom)
			{
				result.Y = area.Top + anchor.Top;
				result.Height = area.Height - (anchor.Top + anchor.Bottom);
			}
			else if (anchor.HasTop)
			{
				result.Y = area.Top + anchor.Top;
				result.Height = content.Height;
			}
			else if (anchor.HasBottom)
			{
				result.Y = area.Bottom - content.Height - anchor.Bottom;
				result.Height = content.Height;
			}
			else
			{
				result.Y = area.Top;
				result.Height = content.Height;
			}
			result.Intersect(area);
			return result;
		}

		// Token: 0x04000CCD RID: 3277
		[global::System.ComponentModel.DefaultValue(float.NaN)]
		public float Right = float.NaN;

		// Token: 0x04000CCE RID: 3278
		[global::System.ComponentModel.DefaultValue(float.NaN)]
		public float Left = float.NaN;

		// Token: 0x04000CCF RID: 3279
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Center;

		// Token: 0x04000CD0 RID: 3280
		[global::System.ComponentModel.DefaultValue(float.NaN)]
		public float Top = float.NaN;

		// Token: 0x04000CD1 RID: 3281
		[global::System.ComponentModel.DefaultValue(float.NaN)]
		public float Bottom = float.NaN;

		// Token: 0x04000CD2 RID: 3282
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Middle;
	}
}
