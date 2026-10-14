using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public interface ISequenceManager
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003A RID: 58
		// (set) Token: 0x0600003B RID: 59
		global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003C RID: 60
		// (set) Token: 0x0600003D RID: 61
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo { get; set; }

		// Token: 0x0600003E RID: 62
		global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionId);

		// Token: 0x0600003F RID: 63
		global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, string pcrNewPassword, bool hostedDepotOperation, int? userDefersAllowed = null);

		// Token: 0x06000040 RID: 64
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo();

		// Token: 0x06000041 RID: 65
		global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo();

		// Token: 0x06000042 RID: 66
		bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID);

		// Token: 0x06000043 RID: 67
		void OpenSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation);

		// Token: 0x06000044 RID: 68
		void CloseSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy);
	}
}
