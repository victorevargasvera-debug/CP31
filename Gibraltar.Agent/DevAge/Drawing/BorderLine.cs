using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevAge.Drawing
{
	// Token: 0x020002EF RID: 751
	[global::System.Serializable]
	internal struct BorderLine
	{
		// Token: 0x06002425 RID: 9253 RVA: 0x0007DD10 File Offset: 0x0007BF10
		public BorderLine(global::System.Drawing.Color p_Color)
		{
			this.Color = p_Color;
			this.Width = 1f;
			this.DashStyle = global::System.Drawing.Drawing2D.DashStyle.Solid;
			this.Padding = 0f;
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0007DD38 File Offset: 0x0007BF38
		public BorderLine(global::System.Drawing.Color p_Color, float p_Width)
		{
			this.Width = p_Width;
			this.Color = p_Color;
			this.DashStyle = global::System.Drawing.Drawing2D.DashStyle.Solid;
			this.Padding = 0f;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x0007DD5C File Offset: 0x0007BF5C
		public BorderLine(global::System.Drawing.Color p_Color, float p_Width, global::System.Drawing.Drawing2D.DashStyle dashStyle)
		{
			this.Width = p_Width;
			this.Color = p_Color;
			this.DashStyle = dashStyle;
			this.Padding = 0f;
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x0007DD80 File Offset: 0x0007BF80
		public BorderLine(global::System.Drawing.Color p_Color, float p_Width, global::System.Drawing.Drawing2D.DashStyle dashStyle, float padding)
		{
			this.Width = p_Width;
			this.Color = p_Color;
			this.DashStyle = dashStyle;
			this.Padding = padding;
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
		private bool ShouldSerializeColor()
		{
			return !this.Color.IsEmpty;
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0007DDB0 File Offset: 0x0007BFB0
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.Color.ToString(),
				", Width= ",
				this.Width.ToString(),
				", DashStyle= ",
				this.DashStyle.ToString()
			});
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0007DE28 File Offset: 0x0007C028
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
			global::DevAge.Drawing.BorderLine borderLine = (global::DevAge.Drawing.BorderLine)obj;
			return borderLine.Width == this.Width && borderLine.Color == this.Color && borderLine.DashStyle == this.DashStyle && borderLine.Padding == this.Padding;
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0007DEB8 File Offset: 0x0007C0B8
		public override int GetHashCode()
		{
			return this.Color.GetHashCode();
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0007DECC File Offset: 0x0007C0CC
		public static bool operator ==(global::DevAge.Drawing.BorderLine a, global::DevAge.Drawing.BorderLine b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0007DEE4 File Offset: 0x0007C0E4
		public static bool operator !=(global::DevAge.Drawing.BorderLine a, global::DevAge.Drawing.BorderLine b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04000CBA RID: 3258
		public static readonly global::DevAge.Drawing.BorderLine NoBorder = new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.White, 0f);

		// Token: 0x04000CBB RID: 3259
		public static readonly global::DevAge.Drawing.BorderLine Black1Width = new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Black, 1f);

		// Token: 0x04000CBC RID: 3260
		[global::System.ComponentModel.DefaultValue(0)]
		public float Width;

		// Token: 0x04000CBD RID: 3261
		public global::System.Drawing.Color Color;

		// Token: 0x04000CBE RID: 3262
		[global::System.ComponentModel.DefaultValue(global::System.Drawing.Drawing2D.DashStyle.Solid)]
		public global::System.Drawing.Drawing2D.DashStyle DashStyle;

		// Token: 0x04000CBF RID: 3263
		[global::System.ComponentModel.DefaultValue(0)]
		public float Padding;
	}
}
