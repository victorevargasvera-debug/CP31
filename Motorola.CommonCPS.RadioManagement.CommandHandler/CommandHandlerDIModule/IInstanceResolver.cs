using System;

namespace Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule
{
	// Token: 0x02000009 RID: 9
	public interface IInstanceResolver
	{
		// Token: 0x06000023 RID: 35
		T Resolve<T>() where T : class;
	}
}
