using System;

namespace Infragistics
{
	// Token: 0x020000E7 RID: 231
	public interface IProvideCustomObjectPersistence
	{
		// Token: 0x06000845 RID: 2117
		object SaveObject();

		// Token: 0x06000846 RID: 2118
		void LoadObject(object data);
	}
}
