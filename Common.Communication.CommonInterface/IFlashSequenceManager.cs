using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000015 RID: 21
	public interface IFlashSequenceManager : global::Motorola.Common.Communication.IUpdatesDeviceForFlash
	{
		// Token: 0x0600005D RID: 93
		bool WriteRamdownloader(string filepath);

		// Token: 0x0600005E RID: 94
		global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images);

		// Token: 0x0600005F RID: 95
		void PreUpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, bool hostedDepotOperation);
	}
}
