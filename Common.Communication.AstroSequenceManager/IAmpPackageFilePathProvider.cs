using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public interface IAmpPackageFilePathProvider
	{
		// Token: 0x0600001F RID: 31
		string GetPackageFilePath(global::Motorola.Common.Communication.Pba.PbaObject pba);
	}
}
