using System;

namespace NPOI.Util.ArrayExtensions
{
	// Token: 0x02000297 RID: 663
	internal class ArrayTraverse
	{
		// Token: 0x0600122D RID: 4653 RVA: 0x000365A4 File Offset: 0x000347A4
		public ArrayTraverse(global::System.Array array)
		{
			this.maxLengths = new int[array.Rank];
			for (int i = 0; i < array.Rank; i++)
			{
				this.maxLengths[i] = array.GetLength(i) - 1;
			}
			this.Position = new int[array.Rank];
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000365FC File Offset: 0x000347FC
		public bool Step()
		{
			for (int i = 0; i < this.Position.Length; i++)
			{
				if (this.Position[i] < this.maxLengths[i])
				{
					this.Position[i]++;
					for (int j = 0; j < i; j++)
					{
						this.Position[j] = 0;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000783 RID: 1923
		public int[] Position;

		// Token: 0x04000784 RID: 1924
		private int[] maxLengths;
	}
}
