using System;

namespace NLog.Config
{
	// Token: 0x02000161 RID: 353
	internal interface IFactory
	{
		// Token: 0x06000F6A RID: 3946
		void Clear();

		// Token: 0x06000F6B RID: 3947
		void ScanTypes(global::System.Type[] types, string prefix);

		// Token: 0x06000F6C RID: 3948
		void RegisterType(global::System.Type type, string itemNamePrefix);
	}
}
