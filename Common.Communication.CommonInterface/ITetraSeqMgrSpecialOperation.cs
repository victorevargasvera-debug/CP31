using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001D RID: 29
	public interface ITetraSeqMgrSpecialOperation : global::System.IDisposable
	{
		// Token: 0x060000CE RID: 206
		void SwitchModeNoWait(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode);

		// Token: 0x060000CF RID: 207
		void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer);

		// Token: 0x060000D0 RID: 208
		void WriteSoftware(string swPath, bool bResetProgress = true);

		// Token: 0x060000D1 RID: 209
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks();

		// Token: 0x060000D2 RID: 210
		byte[] ReadCPData(string blockID, uint offset, ushort size);

		// Token: 0x060000D3 RID: 211
		bool IsLLPAvailable();

		// Token: 0x060000D4 RID: 212
		bool TurnOffRadio();

		// Token: 0x060000D5 RID: 213
		void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool bResetProgress = true);

		// Token: 0x060000D6 RID: 214
		void EraseRadioFromTo(uint startAddress, uint size, bool bForceErase = false);

		// Token: 0x060000D7 RID: 215
		global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageWithProgressUpdate(string address, uint size);

		// Token: 0x060000D8 RID: 216
		void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage, bool bResetProgress = false);

		// Token: 0x060000D9 RID: 217
		global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType);

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000DA RID: 218
		// (set) Token: 0x060000DB RID: 219
		string CpuID { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000DC RID: 220
		// (set) Token: 0x060000DD RID: 221
		global::Motorola.Common.Communication.IRadioProfile Profile { get; set; }

		// Token: 0x060000DE RID: 222
		void Invalidate(bool onlyCPInfo);

		// Token: 0x060000DF RID: 223
		void EraseRadio(global::System.Collections.Generic.List<string> sections);

		// Token: 0x060000E0 RID: 224
		void WaitForCancelReading();
	}
}
