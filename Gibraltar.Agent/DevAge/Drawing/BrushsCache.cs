using System;
using System.Collections.Generic;
using System.Drawing;

namespace DevAge.Drawing
{
	// Token: 0x020002E5 RID: 741
	internal class BrushsCache : global::System.IDisposable
	{
		// Token: 0x060023B1 RID: 9137 RVA: 0x0007C96C File Offset: 0x0007AB6C
		public BrushsCache(int maxCapacity)
		{
			this.mList = new global::System.Drawing.SolidBrush[maxCapacity];
			this.mKeys = new global::System.Drawing.Color[maxCapacity];
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0007C998 File Offset: 0x0007AB98
		public global::System.Drawing.SolidBrush GetBrush(global::System.Drawing.Color color)
		{
			for (int i = 0; i < this.mList.Length; i++)
			{
				if (this.mList[i] == null)
				{
					global::System.Drawing.SolidBrush solidBrush = new global::System.Drawing.SolidBrush(color);
					this.mList[i] = solidBrush;
					this.mKeys[i] = color;
					return solidBrush;
				}
				if (this.mKeys[i].Equals(color))
				{
					return this.mList[i];
				}
			}
			global::System.Drawing.SolidBrush solidBrush2 = new global::System.Drawing.SolidBrush(color);
			this.mNonCachedList.Add(solidBrush2);
			return solidBrush2;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0007CA3C File Offset: 0x0007AC3C
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
			foreach (global::System.Drawing.SolidBrush solidBrush in this.mNonCachedList)
			{
				solidBrush.Dispose();
			}
		}

		// Token: 0x04000CA9 RID: 3241
		private global::System.Drawing.SolidBrush[] mList;

		// Token: 0x04000CAA RID: 3242
		private global::System.Drawing.Color[] mKeys;

		// Token: 0x04000CAB RID: 3243
		private global::System.Collections.Generic.List<global::System.Drawing.SolidBrush> mNonCachedList = new global::System.Collections.Generic.List<global::System.Drawing.SolidBrush>();
	}
}
