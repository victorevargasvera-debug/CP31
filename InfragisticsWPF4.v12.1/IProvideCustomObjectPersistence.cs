using System;

namespace Infragistics
{
	// Token: 0x020000C9 RID: 201
	public interface IProvideCustomObjectPersistence
	{
		// Token: 0x06000745 RID: 1861
		object SaveObject();

		// Token: 0x06000746 RID: 1862
		void LoadObject(object data);
	}
}
