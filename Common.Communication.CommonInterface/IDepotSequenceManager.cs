using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000014 RID: 20
	public interface IDepotSequenceManager
	{
		// Token: 0x06000054 RID: 84
		void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID);

		// Token: 0x06000055 RID: 85
		void DepotForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID);

		// Token: 0x06000056 RID: 86
		void UpdateSerialNumber(string serialNumber);

		// Token: 0x06000057 RID: 87
		void FactoryReset();

		// Token: 0x06000058 RID: 88
		void UnkillRadio(byte[] authenticationValue);

		// Token: 0x06000059 RID: 89
		byte[] ReadUnkillChallengeValue();

		// Token: 0x0600005A RID: 90
		void UpdateIMEType(byte ime);

		// Token: 0x0600005B RID: 91
		void UpdateDateCode(byte[] datecode, ushort source);

		// Token: 0x0600005C RID: 92
		void CBIProgramme();
	}
}
