using System;

namespace AcpASKLib
{
	// Token: 0x0200002B RID: 43
	public interface ISystemKeyMgr
	{
		// Token: 0x0600013C RID: 316
		bool IsUnLimitedASKLoaded(int sysId, byte uKeyTpe, bool bSearchWriteProtectOnly);
	}
}
