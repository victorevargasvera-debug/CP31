using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000013 RID: 19
	public interface ICpsSequenceManagerHelper
	{
		// Token: 0x06000050 RID: 80
		global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID);

		// Token: 0x06000051 RID: 81
		global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID);

		// Token: 0x06000052 RID: 82
		void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation);

		// Token: 0x06000053 RID: 83
		void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy);
	}
}
