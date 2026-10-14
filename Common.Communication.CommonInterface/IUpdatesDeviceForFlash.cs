using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000016 RID: 22
	public interface IUpdatesDeviceForFlash
	{
		// Token: 0x06000060 RID: 96
		void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, bool hostedDepotOperation, int? userDefersAllowed = null);

		// Token: 0x06000061 RID: 97
		void ValidateUpdate();
	}
}
