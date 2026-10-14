using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200021D RID: 541
	public class SimpleLookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
	{
		// Token: 0x060015C1 RID: 5569 RVA: 0x00066CC0 File Offset: 0x00064EC0
		private static global::Org.BouncyCastle.Math.EC.ECPoint[] Copy(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint[] result = new global::Org.BouncyCastle.Math.EC.ECPoint[len];
			for (int i = 0; i < len; i++)
			{
				result[i] = points[off + i];
			}
			return result;
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00066CE9 File Offset: 0x00064EE9
		public SimpleLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			this.points = global::Org.BouncyCastle.Math.EC.SimpleLookupTable.Copy(points, off, len);
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00066CFF File Offset: 0x00064EFF
		public override int Size
		{
			get
			{
				return this.points.Length;
			}
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00066D09 File Offset: 0x00064F09
		public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
		{
			throw new global::System.NotSupportedException("Constant-time lookup not supported");
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00066D15 File Offset: 0x00064F15
		public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
		{
			return this.points[index];
		}

		// Token: 0x04000974 RID: 2420
		private readonly global::Org.BouncyCastle.Math.EC.ECPoint[] points;
	}
}
