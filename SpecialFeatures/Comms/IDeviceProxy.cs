using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000162 RID: 354
	public interface IDeviceProxy : global::System.IDisposable
	{
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060011E7 RID: 4583
		bool CurrentRadioIsConnected { get; }

		// Token: 0x060011E8 RID: 4584
		global::Motorola.Common.Communication.Pba.PbaObject Read(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator);

		// Token: 0x060011E9 RID: 4585
		bool Write(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null);

		// Token: 0x060011EA RID: 4586
		global::SpecialFeatures.Comms.RadioParams ReadExtendedDeviceInfo();

		// Token: 0x060011EB RID: 4587
		bool ResetPassword(byte[] passwordResetFileContent);

		// Token: 0x060011EC RID: 4588
		global::Motorola.Common.Communication.Pba.PbaObject ReadBlock(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> blockList, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null);

		// Token: 0x060011ED RID: 4589
		void UpdateDevice(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null);

		// Token: 0x060011EE RID: 4590
		void ValidateUpdate(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null);

		// Token: 0x060011EF RID: 4591
		bool CBIProgram(global::SpecialFeatures.Comms.RadioParams radioPara);

		// Token: 0x060011F0 RID: 4592
		bool UpdateSN(global::SpecialFeatures.Comms.RadioParams radioPara, string serialNumber);

		// Token: 0x060011F1 RID: 4593
		bool ForceWrite(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null);

		// Token: 0x060011F2 RID: 4594
		void WriteLanguagePack(global::SpecialFeatures.Comms.RadioParams radioParam, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null);

		// Token: 0x060011F3 RID: 4595
		bool LoadTxmCertificate(global::SpecialFeatures.Comms.RadioParams radioParam, string path);

		// Token: 0x060011F4 RID: 4596
		string QueryTxmCertificate(global::SpecialFeatures.Comms.RadioParams radioParam, string path);
	}
}
