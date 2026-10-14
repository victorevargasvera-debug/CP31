using System;

namespace DevAge.Text.FixedLength
{
	// Token: 0x020002AF RID: 687
	internal interface IField
	{
		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002213 RID: 8723
		string RegularExpressionPattern { get; }

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002214 RID: 8724
		int Index { get; }

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002215 RID: 8725
		string Name { get; }

		// Token: 0x06002216 RID: 8726
		string ValueToString(object val);

		// Token: 0x06002217 RID: 8727
		object StringToValue(string str);
	}
}
