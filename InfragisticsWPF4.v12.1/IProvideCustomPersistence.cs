using System;

namespace Infragistics
{
	// Token: 0x020000C7 RID: 199
	public interface IProvideCustomPersistence
	{
		// Token: 0x06000741 RID: 1857
		string Save();

		// Token: 0x06000742 RID: 1858
		void Load(object owner, string value);
	}
}
