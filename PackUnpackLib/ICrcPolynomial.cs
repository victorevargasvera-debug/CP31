using System;

namespace Motorola.Acp.PackUnpack
{
	// Token: 0x02000007 RID: 7
	public interface ICrcPolynomial
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8
		int Value { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9
		int Length { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10
		string Description { get; }
	}
}
