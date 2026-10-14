using System;

namespace Infragistics
{
	// Token: 0x020000E4 RID: 228
	public interface IProvideCustomPersistence
	{
		// Token: 0x0600083F RID: 2111
		string Save();

		// Token: 0x06000840 RID: 2112
		void Load(object owner, string value);
	}
}
