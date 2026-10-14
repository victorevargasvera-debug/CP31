using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000204 RID: 516
	public abstract class AbstractECLookupTable : global::Org.BouncyCastle.Math.EC.ECLookupTable
	{
		// Token: 0x06001436 RID: 5174
		public abstract global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index);

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06001437 RID: 5175
		public abstract int Size { get; }

		// Token: 0x06001438 RID: 5176 RVA: 0x0005F6F1 File Offset: 0x0005D8F1
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
		{
			return this.Lookup(index);
		}
	}
}
