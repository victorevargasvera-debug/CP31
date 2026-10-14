using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003EE RID: 1006
	public class Gost3410ValidationParameters
	{
		// Token: 0x06002803 RID: 10243 RVA: 0x000AC132 File Offset: 0x000AA332
		public Gost3410ValidationParameters(int x0, int c)
		{
			this.x0 = x0;
			this.c = c;
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000AC148 File Offset: 0x000AA348
		public Gost3410ValidationParameters(long x0L, long cL)
		{
			this.x0L = x0L;
			this.cL = cL;
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x000AC15E File Offset: 0x000AA35E
		public int C
		{
			get
			{
				return this.c;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x000AC166 File Offset: 0x000AA366
		public int X0
		{
			get
			{
				return this.x0;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x000AC16E File Offset: 0x000AA36E
		public long CL
		{
			get
			{
				return this.cL;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x000AC176 File Offset: 0x000AA376
		public long X0L
		{
			get
			{
				return this.x0L;
			}
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000AC180 File Offset: 0x000AA380
		public override bool Equals(object obj)
		{
			global::Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters;
			return other != null && other.c == this.c && other.x0 == this.x0 && other.cL == this.cL && other.x0L == this.x0L;
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000AC1D1 File Offset: 0x000AA3D1
		public override int GetHashCode()
		{
			return this.c.GetHashCode() ^ this.x0.GetHashCode() ^ this.cL.GetHashCode() ^ this.x0L.GetHashCode();
		}

		// Token: 0x04001030 RID: 4144
		private int x0;

		// Token: 0x04001031 RID: 4145
		private int c;

		// Token: 0x04001032 RID: 4146
		private long x0L;

		// Token: 0x04001033 RID: 4147
		private long cL;
	}
}
