using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Tsp;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x02000079 RID: 121
	public class GenTimeAccuracy
	{
		// Token: 0x060004D8 RID: 1240 RVA: 0x000164B2 File Offset: 0x000146B2
		public GenTimeAccuracy(global::Org.BouncyCastle.Asn1.Tsp.Accuracy accuracy)
		{
			this.accuracy = accuracy;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x000164C1 File Offset: 0x000146C1
		public int Seconds
		{
			get
			{
				return this.GetTimeComponent(this.accuracy.Seconds);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x000164D4 File Offset: 0x000146D4
		public int Millis
		{
			get
			{
				return this.GetTimeComponent(this.accuracy.Millis);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000164E7 File Offset: 0x000146E7
		public int Micros
		{
			get
			{
				return this.GetTimeComponent(this.accuracy.Micros);
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000164FA File Offset: 0x000146FA
		private int GetTimeComponent(global::Org.BouncyCastle.Asn1.DerInteger time)
		{
			if (time != null)
			{
				return time.IntValueExact;
			}
			return 0;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00016508 File Offset: 0x00014708
		public override string ToString()
		{
			return this.Seconds.ToString() + "." + this.Millis.ToString("000") + this.Micros.ToString("000");
		}

		// Token: 0x040002A8 RID: 680
		private global::Org.BouncyCastle.Asn1.Tsp.Accuracy accuracy;
	}
}
