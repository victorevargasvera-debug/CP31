using System;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200001A RID: 26
	public interface ICommandImplementation
	{
		// Token: 0x0600017B RID: 379
		object Execute(params object[] paras);

		// Token: 0x0600017C RID: 380
		bool CanExecute(params object[] paras);
	}
}
