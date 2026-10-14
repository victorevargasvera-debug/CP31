using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevAge.Drawing
{
	// Token: 0x02000329 RID: 809
	[global::System.Serializable]
	internal struct RoundedRectangle
	{
		// Token: 0x06002637 RID: 9783 RVA: 0x000845E0 File Offset: 0x000827E0
		public RoundedRectangle(global::System.Drawing.Rectangle rect, double roundValue)
		{
			this.mRectangle = rect;
			this.mRoundValue = roundValue;
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x000845F0 File Offset: 0x000827F0
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x000845F8 File Offset: 0x000827F8
		public global::System.Drawing.Rectangle Rectangle
		{
			get
			{
				return this.mRectangle;
			}
			set
			{
				this.mRectangle = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x00084604 File Offset: 0x00082804
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x0008460C File Offset: 0x0008280C
		public double RoundValue
		{
			get
			{
				return this.mRoundValue;
			}
			set
			{
				if (this.mRoundValue < 0.0 || this.mRoundValue > 1.0)
				{
					throw new global::System.ApplicationException("Invalid value, must be a value from 0 to 1");
				}
				this.mRoundValue = value;
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00084648 File Offset: 0x00082848
		public global::System.Drawing.Drawing2D.GraphicsPath ToGraphicsPath()
		{
			if (this.mRectangle.IsEmpty)
			{
				return new global::System.Drawing.Drawing2D.GraphicsPath();
			}
			global::System.Drawing.Drawing2D.GraphicsPath graphicsPath = new global::System.Drawing.Drawing2D.GraphicsPath();
			if (this.mRoundValue == 0.0)
			{
				graphicsPath.AddRectangle(this.mRectangle);
			}
			else
			{
				int x = this.mRectangle.X;
				int y = this.mRectangle.Y;
				int num;
				int num2;
				if (this.mRectangle.Height < this.mRectangle.Width)
				{
					num = (int)((double)this.mRectangle.Height * this.mRoundValue);
					num2 = num * 2;
				}
				else
				{
					num = (int)((double)this.mRectangle.Width * this.mRoundValue);
					num2 = num * 2;
				}
				graphicsPath.AddLine(num + x, y, this.mRectangle.Width - num + x, y);
				graphicsPath.AddArc(this.mRectangle.Width - num2 + x, y, num2, num2, 270f, 90f);
				graphicsPath.AddLine(this.mRectangle.Width + x, num + y, this.mRectangle.Width + x, this.mRectangle.Height - num + y);
				graphicsPath.AddArc(this.mRectangle.Width - num2 + x, this.mRectangle.Height - num2 + y, num2, num2, 0f, 90f);
				graphicsPath.AddLine(this.mRectangle.Width - num + x, this.mRectangle.Height + y, num + x, this.mRectangle.Height + y);
				graphicsPath.AddArc(x, this.mRectangle.Height - num2 + y, num2, num2, 90f, 90f);
				graphicsPath.AddLine(x, this.mRectangle.Height - num + y, x, num + y);
				graphicsPath.AddArc(x, y, num2, num2, 180f, 90f);
			}
			return graphicsPath;
		}

		// Token: 0x04000D73 RID: 3443
		private global::System.Drawing.Rectangle mRectangle;

		// Token: 0x04000D74 RID: 3444
		private double mRoundValue;
	}
}
