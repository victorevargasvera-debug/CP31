using System;

namespace Motorola.CommonCPS.RadioManagement.CommonBase
{
	// Token: 0x0200000A RID: 10
	public interface IResource
	{
		// Token: 0x0600003E RID: 62
		string GetStringByResourceID(string resourceID, string[] args = null);

		// Token: 0x0600003F RID: 63
		string GetStringByErrorAndResourceID(string resourceID, string[] args = null);
	}
}
