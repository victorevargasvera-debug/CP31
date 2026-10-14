using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001C RID: 28
	public interface ITetraDevSpecialOperation : global::System.IDisposable
	{
		// Token: 0x060000CA RID: 202
		void WriteSoftware(string swFilePath);

		// Token: 0x060000CB RID: 203
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks();

		// Token: 0x060000CC RID: 204
		byte[] ReadCPData(string blockID, uint offset, ushort size);

		// Token: 0x060000CD RID: 205
		void GeneralOperation(global::Motorola.Common.Communication.Pba.PbaObject pbaObj);
	}
}
