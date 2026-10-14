using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevAge.Drawing
{
	// Token: 0x020002F9 RID: 761
	internal class PensCache : global::System.IDisposable
	{
		// Token: 0x06002467 RID: 9319 RVA: 0x0007E884 File Offset: 0x0007CA84
		public PensCache(int maxCapacity)
		{
			this.mList = new global::System.Drawing.Pen[maxCapacity];
			this.mKeys = new global::DevAge.Drawing.PensCache.PenKey[maxCapacity];
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0007E8B0 File Offset: 0x0007CAB0
		public global::System.Drawing.Pen GetPen(global::System.Drawing.Color color, float width, global::System.Drawing.Drawing2D.DashStyle style)
		{
			global::DevAge.Drawing.PensCache.PenKey penKey;
			penKey.Color = color;
			penKey.Width = width;
			penKey.Style = style;
			for (int i = 0; i < this.mList.Length; i++)
			{
				if (this.mList[i] == null)
				{
					global::System.Drawing.Pen pen = new global::System.Drawing.Pen(color, width);
					if (pen.DashStyle != style)
					{
						pen.DashStyle = style;
					}
					this.mList[i] = pen;
					this.mKeys[i] = penKey;
					return pen;
				}
				if (this.mKeys[i].Equals(penKey))
				{
					return this.mList[i];
				}
			}
			global::System.Drawing.Pen pen2 = new global::System.Drawing.Pen(color, width);
			if (pen2.DashStyle != style)
			{
				pen2.DashStyle = style;
			}
			this.mNonCachedList.Add(pen2);
			return pen2;
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0007E988 File Offset: 0x0007CB88
		public void Dispose()
		{
			for (int i = 0; i < this.mList.Length; i++)
			{
				if (this.mList[i] != null)
				{
					this.mList[i].Dispose();
					this.mList[i] = null;
				}
			}
			foreach (global::System.Drawing.Pen pen in this.mNonCachedList)
			{
				pen.Dispose();
			}
		}

		// Token: 0x04000CCA RID: 3274
		private global::System.Drawing.Pen[] mList;

		// Token: 0x04000CCB RID: 3275
		private global::DevAge.Drawing.PensCache.PenKey[] mKeys;

		// Token: 0x04000CCC RID: 3276
		private global::System.Collections.Generic.List<global::System.Drawing.Pen> mNonCachedList = new global::System.Collections.Generic.List<global::System.Drawing.Pen>();

		// Token: 0x020004C2 RID: 1218
		private struct PenKey : global::System.IEquatable<global::DevAge.Drawing.PensCache.PenKey>
		{
			// Token: 0x06003407 RID: 13319 RVA: 0x000BB748 File Offset: 0x000B9948
			public bool Equals(global::DevAge.Drawing.PensCache.PenKey other)
			{
				return other.Color == this.Color && other.Style == this.Style && other.Width == this.Width;
			}

			// Token: 0x040013B4 RID: 5044
			public global::System.Drawing.Color Color;

			// Token: 0x040013B5 RID: 5045
			public global::System.Drawing.Drawing2D.DashStyle Style;

			// Token: 0x040013B6 RID: 5046
			public float Width;
		}
	}
}
