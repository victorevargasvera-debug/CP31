using System;

namespace Autofac.Core
{
	// Token: 0x0200006A RID: 106
	public interface IDisposer : global::System.IDisposable
	{
		// Token: 0x0600028A RID: 650
		void AddInstanceForDisposal(global::System.IDisposable instance);
	}
}
