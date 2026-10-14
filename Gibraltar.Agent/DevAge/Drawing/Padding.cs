using System;
using System.Drawing;

namespace DevAge.Drawing
{
	// Token: 0x02000332 RID: 818
	[global::System.Serializable]
	internal struct Padding
	{
		// Token: 0x06002673 RID: 9843 RVA: 0x0008530C File Offset: 0x0008350C
		public Padding(float all)
		{
			this.Left = all;
			this.Right = all;
			this.Top = all;
			this.Bottom = all;
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x0008532C File Offset: 0x0008352C
		public Padding(float left, float right, float top, float bottom)
		{
			this.Left = left;
			this.Right = right;
			this.Top = top;
			this.Bottom = bottom;
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x0008534C File Offset: 0x0008354C
		public bool IsEmpty
		{
			get
			{
				return this.Left == 0f && this.Right == 0f && this.Top == 0f && this.Bottom == 0f;
			}
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x0008539C File Offset: 0x0008359C
		public global::System.Drawing.RectangleF GetContentRectangle(global::System.Drawing.RectangleF backGroundArea)
		{
			if (this.IsEmpty)
			{
				return backGroundArea;
			}
			return new global::System.Drawing.RectangleF(backGroundArea.X + this.Left, backGroundArea.Y + this.Top, backGroundArea.Width - (this.Left + this.Right), backGroundArea.Height - (this.Top + this.Bottom));
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00085408 File Offset: 0x00083608
		public global::System.Drawing.SizeF GetExtent(global::System.Drawing.SizeF contentSize)
		{
			if (this.IsEmpty)
			{
				return contentSize;
			}
			return new global::System.Drawing.SizeF(contentSize.Width + (this.Left + this.Right), contentSize.Height + (this.Top + this.Bottom));
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00085458 File Offset: 0x00083658
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Left:",
				this.Left.ToString(),
				",Right:",
				this.Right.ToString(),
				",Top:",
				this.Top.ToString(),
				",Bottom:",
				this.Bottom.ToString()
			});
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000854F0 File Offset: 0x000836F0
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
			global::DevAge.Drawing.Padding padding = (global::DevAge.Drawing.Padding)obj;
			return padding.Top == this.Top && padding.Bottom == this.Bottom && padding.Right == this.Right && padding.Left == this.Left;
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00085578 File Offset: 0x00083778
		public override int GetHashCode()
		{
			return this.Top.GetHashCode();
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00085588 File Offset: 0x00083788
		public static bool operator ==(global::DevAge.Drawing.Padding a, global::DevAge.Drawing.Padding b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x000855A0 File Offset: 0x000837A0
		public static bool operator !=(global::DevAge.Drawing.Padding a, global::DevAge.Drawing.Padding b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04000D91 RID: 3473
		public static readonly global::DevAge.Drawing.Padding Empty = default(global::DevAge.Drawing.Padding);

		// Token: 0x04000D92 RID: 3474
		public float Left;

		// Token: 0x04000D93 RID: 3475
		public float Right;

		// Token: 0x04000D94 RID: 3476
		public float Top;

		// Token: 0x04000D95 RID: 3477
		public float Bottom;
	}
}
