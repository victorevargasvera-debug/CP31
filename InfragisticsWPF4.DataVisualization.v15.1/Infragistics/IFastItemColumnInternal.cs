using System;

namespace Infragistics
{
	// Token: 0x02000034 RID: 52
	internal interface IFastItemColumnInternal
	{
		// Token: 0x060002DA RID: 730
		bool Reset();

		// Token: 0x060002DB RID: 731
		bool InsertRange(int position, int count);

		// Token: 0x060002DC RID: 732
		bool RemoveRange(int position, int count);

		// Token: 0x060002DD RID: 733
		bool ReplaceRange(int position, int count);
	}
}
