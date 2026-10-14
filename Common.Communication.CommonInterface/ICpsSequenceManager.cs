using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public interface ICpsSequenceManager : global::Motorola.Common.Communication.ISequenceManager, global::Motorola.Common.Communication.IFwdl, global::Motorola.Common.Communication.IUpdatesMacAddress, global::Motorola.Common.Communication.IRadioParamSupport, global::Motorola.Common.Communication.IQueryRadioStatus, global::Motorola.Common.Communication.IIshBlockSupport, global::Motorola.Common.Communication.IDifferentialWritable, global::Motorola.Common.Communication.ILanguagePackSupport
	{
		// Token: 0x06000030 RID: 48
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo();

		// Token: 0x06000031 RID: 49
		void WriteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData);

		// Token: 0x06000032 RID: 50
		void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.Pba.LanguagePackData langPackData);

		// Token: 0x06000033 RID: 51
		void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode);

		// Token: 0x06000034 RID: 52
		void SendFPGAErase(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x06000035 RID: 53
		void SendFPGAReset(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType);

		// Token: 0x06000036 RID: 54
		global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(string password);

		// Token: 0x06000037 RID: 55
		void EnableFeature(string fwVersion, string serialNumber, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs);

		// Token: 0x06000038 RID: 56
		string ReadHashInputAndValidate(global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList);

		// Token: 0x06000039 RID: 57
		bool ResetPassword(byte[] resetBytes);
	}
}
