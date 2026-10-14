using System;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001EE RID: 494
	internal abstract class Bits
	{
		// Token: 0x06001284 RID: 4740 RVA: 0x00053CC0 File Offset: 0x00051EC0
		internal static uint BitPermuteStep(uint x, uint m, int s)
		{
			uint num = (x ^ x >> s) & m;
			return num ^ num << s ^ x;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00053CD5 File Offset: 0x00051ED5
		internal static ulong BitPermuteStep(ulong x, ulong m, int s)
		{
			ulong num = (x ^ x >> s) & m;
			return num ^ num << s ^ x;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00053CEA File Offset: 0x00051EEA
		internal static uint BitPermuteStepSimple(uint x, uint m, int s)
		{
			return (x & m) << s | (x >> s & m);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00053CFD File Offset: 0x00051EFD
		internal static ulong BitPermuteStepSimple(ulong x, ulong m, int s)
		{
			return (x & m) << s | (x >> s & m);
		}
	}
}
