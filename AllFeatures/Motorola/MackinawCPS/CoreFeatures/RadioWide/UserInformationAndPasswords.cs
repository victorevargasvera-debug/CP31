using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000194 RID: 404
	[global::System.Serializable]
	public class UserInformationAndPasswords : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06004285 RID: 17029 RVA: 0x003E057C File Offset: 0x003DE77C
		public UserInformationAndPasswords(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x003E0598 File Offset: 0x003DE798
		protected UserInformationAndPasswords(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x003E05B0 File Offset: 0x003DE7B0
		public override void Init()
		{
			int a_ = 19;
			short num = (short)924813914;
			short num2 = num;
			num = (short)146508378;
			switch (num2 == num)
			{
			}
			num = (short)1551892481;
			if (num != 0)
			{
			}
			num = (short)1125187584;
			short num3 = num;
			num = (short)1256062976;
			if (num != 0)
			{
			}
			this.radWideUserInformationandPasswordsPIN_A8705 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䠗匙创䄝感ᨡጣᘥᴧ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONPIN, 4);
			this.radWideUserInformationandPasswordsPIN_A8705.IgnoreOnCompare = true;
			this.radWideUserInformationandPasswordsPIN_A8705.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideUserInformationandPasswordsPIN_A8705.DataTransferOrder = -1;
			this.radWideUserInformationandPasswordsProtectedZonePassword_A8766 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䠗栙猛樝䔟䄡倣䌥䰧瀩䌫䀭唯戱唳䔵䬷䴹医䰽␿ᵁՃ繅罇籉穋", a_), global::CommonResources.AcgResources.ID_ZONEPROTECTIONPROTECTEDZONEPASSWORD, 8);
			this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.IgnoreOnCompare = true;
			this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.IsMasked = true;
			this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.DataTransferOrder = -1;
			this.radWideUserInformationandPasswordsRadioAliasEnable_A8830 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䨗笙砛眝伟挡䠣伥䤧天椫䀭儯倱堳匵朷笹лؽ猿牁", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONRADIOALIASENABLE);
			this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.DataTransferOrder = 15;
			this.radWideUserInformationandPasswordsRadioLock_A8836 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䨗笙砛眝伟渡䬣䔥䌧甩洫ᘭ࠯ıȳ", a_), global::CommonResources.AcgResources.ID_RADIOLOCKENABLE);
			this.radWideUserInformationandPasswordsRadioLock_A8836.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsRadioLock_A8836.DataTransferOrder = 4;
			this.radWideUserInformationandPasswordsSoftIDUsername_A9169 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("龎ﳛﻝ샟싡쓣웥죧쫩쳫컭탯틱퓳훵\ud8f7\udaf9", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UnpackNonListStringStripBlanksAndpackStringToMaxLength8AsChars(this), this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䬗甙稛樝椟昡焣唥䴧堩䈫伭崯圱欳眵ķହ਻ܽ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONSOFTIDUSERNAME);
			this.radWideUserInformationandPasswordsSoftIDUsername_A9169.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideUserInformationandPasswordsSoftIDUsername_A9169.DataTransferOrder = 92;
			this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都䇿氁怃嘅椇礉缋礍缏怑瀓攕䰗笙缛樝䤟䄡䔣䨥愧䐩䐫䜭刯嬱䀳猵嘷夹医娽┿ቁ╃㕅㭇㵉⍋㱍㑏൑ᕓ敕汗楙敛歝", a_), global::CommonResources.AcgResources.ID_TACTICALINHIBITENCODEPASSWORD, 8);
			this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.IgnoreOnCompare = true;
			this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.IsMasked = true;
			this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.DataTransferOrder = -1;
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都䇿氁怃嘅椇礉缋礍缏怑瀓攕䰗笙缛樝䤟䄡䔣䨥愧䐩䐫䜭刯嬱䀳猵嘷嬹帻刽┿ᵁՃ畅籇繉籋筍", a_), global::CommonResources.AcgResources.ID_TACTICALINHIBITENABLE);
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.DataTransferOrder = 12;
			this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䬗甙稛樝椟昡焣唥䴧堩䈫伭崯圱瀳張䬷䨹倻弽㤿ᙁ⅃㹅㱇᥉╋㑍㕏൑ᕓ摕歗湙楛浝", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONSOFTIDUSERNAMEDISPLAYTEXTSIZE, 0, 255, null, null, 0, 1);
			this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.DataTransferOrder = 1;
			this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.ShowHexValue = false;
			this.radWideUserinfoPassRequiredForGunlock_A36531 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧菩苫裭鿯ꋱ闳藵请꣹駻追痿欁瘃挅氇䰉挋簍圏朑稓稕眗礙眛䄝感ᄡሣጥᬧᬩ", a_), global::CommonResources.AcgResources.ID_PASSWORDREQUIREDFORGUNLOCK);
			this.radWideUserinfoPassRequiredForGunlock_A36531.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserinfoPassRequiredForGunlock_A36531.DataTransferOrder = 144;
			this.radWideUserinfoPassRequiredForLightbar_A36532 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧菩苫裭鿯ꋱ闳藵请꣹駻追痿欁瘃挅氇䰉挋簍小笑猓縕気砙紛氝缟挡ᜣဥᴧᤩḫ", a_), global::CommonResources.AcgResources.ID_PASSWORDREQUIREDFORLIGHTBAR);
			this.radWideUserinfoPassRequiredForLightbar_A36532.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserinfoPassRequiredForLightbar_A36532.DataTransferOrder = 145;
			this.radWideUserinfoPassRequiredForSiren_A36533 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧菩苫裭鿯ꋱ闳藵请꣹駻追痿欁瘃挅氇䰉挋簍䌏笑易猕瘗䔙崛ⴝᘟᜡᜣᔥ", a_), global::CommonResources.AcgResources.ID_PASSWORDREQUIREDFORSIREN);
			this.radWideUserinfoPassRequiredForSiren_A36533.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserinfoPassRequiredForSiren_A36533.DataTransferOrder = 146;
			this.radWideUserInformationandPasswordsUnlockPassword_A8690 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䴗琙瀛焝䌟䤡琣䜥嬧天嬫䄭䈯嘱欳眵7హԻ฽", a_), global::CommonResources.AcgResources.ID_RADIOLOCKUNLOCKPASSWORD, 10);
			this.radWideUserInformationandPasswordsUnlockPassword_A8690.IgnoreOnCompare = true;
			this.radWideUserInformationandPasswordsUnlockPassword_A8690.IsMasked = true;
			this.radWideUserInformationandPasswordsUnlockPassword_A8690.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsUnlockPassword_A8690.DataTransferOrder = -1;
			this.radWideUserInformationandPasswordsMandatoryPassword_A8461 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕唗笙爛稝䄟嘡䬣吥儧稩䴫崭䌯䔱嬳䐵尷改紻ؽ琿瑁畃", a_), global::CommonResources.AcgResources.ID_RADIOLOCKMANDATORYPASSWORD);
			this.radWideUserInformationandPasswordsMandatoryPassword_A8461.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsMandatoryPassword_A8461.DataTransferOrder = 108;
			this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䬗缙缛欝刟䜡氣䜥娧丩嬫伭䈯圱申䌵䰷唹瀻儽✿⭁⩃᥅े絉祋繍桏", a_), global::CommonResources.AcgResources.ID_SECUREHARDWAREAUTOLOGIN);
			this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.DataTransferOrder = 110;
			this.radWideUserInformationandPasswordsRadioAlias_A8829 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䨗笙砛眝伟挡䠣伥䤧天猫漭࠯਱س༵", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONRADIOALIAS, 14);
			this.radWideUserInformationandPasswordsRadioAlias_A8829.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsRadioAlias_A8829.DataTransferOrder = 115;
			this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕唗笙搛眝䴟圡䤣瘥䤧天弫夭弯䀱倳稵崷吹嬻䨽⠿ᵁՃ繅籇絉筋", a_), global::CommonResources.AcgResources.ID_RADIOLOCKMAXIMUMPASSWORDLENGTH, 1, 10, null, null, 0, 1);
			this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.DataTransferOrder = 8;
			this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.ShowHexValue = false;
			this.radWideUserInformationandPINPassword_41303 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("铕鷛헟폡폣꟥탧\udee9\udaeb\udbed샯엱냳쿵쇷짹췻컽ㇿ䘁㄃㔅㰇㼉伋䬍唏ℑ唓吕嬗尙夛⬝ᘟᘡᰣ搥椧ጩᨫᬭ瘯਱申ܵื笹༻笽ؿŁ݃瑅็౉罋繍捏ᑑᙓ潕ᵗὙὛ歝剟偡卣≥偧Ⱪ填坭䥯䕱㕳㍵㵷䩹佻㽽둿랁랃뎅뢇벉즋좍펏ꞑ", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.EncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅䄇䐉尋漍挏愑挓礕樗縙䌛⨝ᄟᄡᐣᔥ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONPINPASSWORD);
			this.radWideUserInformationandPINPassword_41303.IgnoreOnCompare = true;
			this.radWideUserInformationandPINPassword_41303.IsMasked = true;
			this.radWideUserInformationandPINPassword_41303.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPINPassword_41303.DataTransferOrder = -1;
			this.radWideUserInformationandPINPasswordPart2_41304 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅䄇䐉尋漍挏愑挓礕樗縙䰛缝刟嘡ᘣ礥ᰧᬩἫḭЯ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONPINPASSWORDPART2, 16);
			this.radWideUserInformationandPINPasswordPart2_41304.IgnoreOnCompare = true;
			this.radWideUserInformationandPINPasswordPart2_41304.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideUserInformationandPINPasswordPart2_41304.DataTransferOrder = -1;
			this.radWideUserInformationandUserLoginUnitIDEnable_41305 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃包笇漉縋䈍缏甑紓砕䴗琙甛樝椟昡愣䠥䤧䠩䀫䬭漯رԳԵ࠷༹", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONUSERLOGINUNITIDENABLE);
			this.radWideUserInformationandUserLoginUnitIDEnable_41305.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandUserLoginUnitIDEnable_41305.DataTransferOrder = 200;
			this.radWideUserInformationandUserLoginUnitID_41306 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃包笇漉縋䈍缏甑紓砕䴗琙甛樝椟昡笣ሥᤧᤩᰫᠭ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONUSERLOGINUNITID, 20);
			this.radWideUserInformationandUserLoginUnitID_41306.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandUserLoginUnitID_41306.DataTransferOrder = 202;
			this.radWideUserInformationandCachedCredentialsUserLoginMode_41307 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃䔅椇椉搋欍琏儑易猕簗缙爛樝䤟䌡䠣唥紧天䤫尭簯崱匳張嘷眹医娽┿ᵁ灃睅筇穉筋", a_), global::CommonResources.AcgResources.ID_CACHEDCREDENTIALSUSERLOGINMODE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideUserInformationandCachedCredentialsUserLoginMode_41307LovStrs);
			this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.DataTransferOrder = 205;
			this.radWideUserInformationandUserLoginUnitIDTextSize_41309 = new global::AcpBusinessLayer.AcpField<int>(20, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃包笇漉縋䈍缏甑紓砕䴗琙甛樝椟昡瀣䌥倧帩缫䜭䨯圱欳ȵषह఻ܽ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONUSERLOGINUNITIDTEXTSIZE);
			this.radWideUserInformationandUserLoginUnitIDTextSize_41309.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideUserInformationandUserLoginUnitIDTextSize_41309.DataTransferOrder = 201;
			this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䨗笙砛眝伟渡䬣䔥䌧欩堫娭唯弱䐳䈵䬷笹倻刽⼿㕁⅃≅ᝇ୉罋筍桏恑", a_), global::CommonResources.AcgResources.ID_RADIOLOCKATTEMPTSALLOWED, 3, 15, null, null, 0, 1);
			this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.DataTransferOrder = 501;
			this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.ShowHexValue = false;
			this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䨗笙砛眝伟渡䬣䔥䌧砩䴫䨭夯崱紳堵倷匹帻圽㐿ു⩃Ʌⵇ⭉⡋≍㽏ㅑ㽓ॕᥗ楙楛晝呟", a_), global::CommonResources.AcgResources.ID_RADIOLOCKRADIOINHIBITONDEADLOCK);
			this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.DataTransferOrder = 502;
			this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䨗笙砛眝伟渡䬣䔥䌧氩䌫尭匯圱眳帵夷吹嬻嬽ဿ⍁㝃㕅㽇╉㹋⩍ཏፑ杓捕恗楙", a_), global::CommonResources.AcgResources.ID_RADIOLOCKFORCECHANGEPASSWORD);
			this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.DataTransferOrder = 503;
			this.radWideConventionalDynamicIDWithPassword_A43705 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꇡ诣裥黧迩苫髭駯鷱髳韵铷뻹藻都懿漁洃攅䄇三嬋服搏稑䐓眕欗椙欛焝刟䘡笣朥ᰧᤩᬫḭԯ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALDYNAMICIDWITHPASSWORD, 8);
			this.radWideConventionalDynamicIDWithPassword_A43705.IgnoreOnCompare = true;
			this.radWideConventionalDynamicIDWithPassword_A43705.IsMasked = true;
			this.radWideConventionalDynamicIDWithPassword_A43705.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideConventionalDynamicIDWithPassword_A43705.DataTransferOrder = -1;
			this.radWideUserInformationandPasswordsTacticalServiceEncodePassword = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䰗笙缛樝䤟䄡䔣䨥笧伩師堭夯儱儳猵嘷夹医娽┿ቁ╃㕅㭇㵉⍋㱍㑏", a_), global::CommonResources.AcgResources.ID_TACTICALSERVICESENCODEPASSWORD, 8);
			this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.IgnoreOnCompare = true;
			this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.IsMasked = true;
			this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.DataTransferOrder = -1;
			this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟럡韣菥髧ꏩ苫裭鿯胱駳韵賷鏹鏻都懿氁怃嘅椇礉缋礍缏怑瀓攕䴗椙礛氝氟䴡䌣伥䘧欩夫娭堯圱娳䈵儷夹崻䨽⤿ⵁ⩃ቅㅇ㩉⥋ᅍᅏ晑恓潕橗汙", a_), global::CommonResources.AcgResources.ID_USERLOGINAUTHENTICATIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926LovStrs);
			this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.DataTransferOrder = 75;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臓ꗕ뷗꣙ﳛ韝軟蓡诣铥藧诩飫蟭鿯鳱퓳韵雷黹\udcfb껽懿焁眃焅朇砉栋納", a_);
			base.Id = 10102;
			base.UIName = global::CommonResources.AcgResources.ID_USERINFORMATIONANDPASSWORDS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x003E0E38 File Offset: 0x003DF038
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)1341849604;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴뛶韸鿺근黾爀瀂爄栆笈漊縌嬎瀐瀒愔縖稘稚焜嘞传䬢䰤䔦䀨弪栬䄮到尲儴制椸娺丼䰾㙀ⱂ㝄⍆ᙈ੊繌筎扐橒恔", a_)))
					{
						num = (short)983957570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_497;
				case 1:
					goto IL_107A;
				case 2:
					goto IL_DC0;
				case 3:
					num = (short)1915813911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_18E;
					}
					continue;
				case 5:
					this.radWideUserinfoPassRequiredForLightbar_A36532 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞裠跢菤裦맨諪黬鳮ꏰ雲蓴苶郸觺飼鯾䜀氂眄䬆怈氊攌笎猐爒朔䠖堘⠚⬜⨞ሠᄢ", a_), global::CommonResources.AcgResources.ID_PASSWORDREQUIREDFORLIGHTBAR);
					this.radWideUserinfoPassRequiredForLightbar_A36532.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserinfoPassRequiredForLightbar_A36532.DataTransferOrder = 145;
					num = (short)599851081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.radWideUserInformationandPasswordsTacticalServiceEncodePassword = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌嬎瀐瀒愔縖稘稚焜䰞䐠儢匤並䨨个栬䄮到尲儴制椸娺丼䰾㙀ⱂ㝄⍆", a_), global::CommonResources.AcgResources.ID_TACTICALSERVICESENCODEPASSWORD, 8);
					this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.IgnoreOnCompare = true;
					this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.IsMasked = true;
					this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.DataTransferOrder = -1;
					num = (short)180420664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근뛾伀匂搄理稈簊戌紎甐䌒琔攖洘⤚䈜⬞ဠဢᔤጦ", a_)))
					{
						num = (short)1780613133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_107A;
				case 8:
					this.radWideUserInformationandPasswordsProtectedZonePassword_A8766 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌弎挐簒愔爖稘漚砜笞笠䰢䬤䈦礨䨪帬尮䘰尲䜴匶昸稺Լ࠾着畂", a_), global::CommonResources.AcgResources.ID_ZONEPROTECTIONPROTECTEDZONEPASSWORD, 8);
					this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.IgnoreOnCompare = true;
					this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.IsMasked = true;
					this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.DataTransferOrder = -1;
					num = (short)364249090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌娎成瘒朔嬖瘘簚琜焞怠嘢儤伦䰨䔪夬䘮到刲䄴帶嘸唺椼䘾ㅀ♂ᩄن絈罊瑌絎材", a_)))
					{
						num = (short)1036976183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15BA;
				case 10:
					goto IL_448;
				case 11:
					this.radWideUserInformationandPasswordsSoftIDUsername_A9169 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("律ﯚ﷜￞쇠쏢엤쟦짨쯪췬쿮퇰", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UnpackNonListStringStripBlanksAndpackStringToMaxLength8AsChars(this), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌導縐甒愔帖崘业渜稞匠䴢䐤䨦䰨琪氬ᘮ0Բఴ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONSOFTIDUSERNAME);
					this.radWideUserInformationandPasswordsSoftIDUsername_A9169.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideUserInformationandPasswordsSoftIDUsername_A9169.DataTransferOrder = 92;
					num = (short)1306591286;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌導縐甒愔帖崘业渜稞匠䴢䐤䨦䰨漪䐬尮䄰弲吴丶洸帺䔼䬾ቀ⩂㽄≆ᙈ੊罌籎敐晒晔", a_)))
					{
						num = (short)868220962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A58;
				case 13:
					this.radWideUserInformationandPINPasswordPart2_41304 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근뛾伀匂搄理稈簊戌紎甐䌒琔攖洘⤚䈜⬞ဠဢᔤጦ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONPINPASSWORDPART2, 16);
					this.radWideUserInformationandPINPasswordPart2_41304.IgnoreOnCompare = true;
					this.radWideUserInformationandPINPasswordPart2_41304.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideUserInformationandPINPasswordPart2_41304.DataTransferOrder = -1;
					num = (short)261029889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌䈎瀐紒焔瘖洘琚漜昞焠䈢嘤否帨䐪弬䬮渰爲ഴ̶༸਺", a_)))
					{
						num = (short)1342308434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1521;
				case 15:
					goto IL_141C;
				case 16:
				{
					num = (short)1133989015;
					short num3 = num;
					num = (short)1946438807;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_144C;
					default:
						num = (short)1774125056;
						if (num != 0)
						{
						}
						this.radWideUserInformationandPasswordsUnlockPassword_A8690 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌娎缐缒稔琖爘䬚簜氞删吢䨤唦䴨琪氬ᜮܰਲԴ", a_), global::CommonResources.AcgResources.ID_RADIOLOCKUNLOCKPASSWORD, 10);
						this.radWideUserInformationandPasswordsUnlockPassword_A8690.IgnoreOnCompare = true;
						this.radWideUserInformationandPasswordsUnlockPassword_A8690.IsMasked = true;
						this.radWideUserInformationandPasswordsUnlockPassword_A8690.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.radWideUserInformationandPasswordsUnlockPassword_A8690.DataTransferOrder = -1;
						num = (short)444399635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 17:
					this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖唘琚縜琞朠䰢圤䐦䰨株䔬丮弰吲倴朶堸䠺丼䠾⹀ㅂ⅄ᡆࡈ硊硌睎扐", a_), global::CommonResources.AcgResources.ID_RADIOLOCKFORCECHANGEPASSWORD);
					this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.DataTransferOrder = 503;
					num = (short)1666187303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌䈎瀐欒簔稖氘瘚䴜縞删倢判䠦嬨伪愬䨮弰吲䄴弶昸稺Լା癀瑂", a_)))
					{
						num = (short)1188626501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14D4;
				case 19:
					goto IL_CFB;
				case 20:
					this.radWideUserInformationandPasswordsRadioLock_A8836 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖唘琚縜琞縠戢ᴤἦᨨᴪ", a_), global::CommonResources.AcgResources.ID_RADIOLOCKENABLE);
					this.radWideUserInformationandPasswordsRadioLock_A8836.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsRadioLock_A8836.DataTransferOrder = 4;
					num = (short)13959235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.radWideUserInformationandUserLoginUnitIDEnable_41305 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺꣼賾搀焂䤄栆済戊挌娎缐稒愔帖崘帚猜縞䌠伢䀤砦ᴨᨪḬἮа", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONUSERLOGINUNITIDENABLE);
					this.radWideUserInformationandUserLoginUnitIDEnable_41305.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandUserLoginUnitIDEnable_41305.DataTransferOrder = 200;
					num = (short)1231683633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_EC0;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌弎堐崒䨔嘖℘Ⱊⴜ⨞", a_)))
					{
						num = (short)458293307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_141C;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌導琐瀒怔攖簘匚簜洞䔠吢䐤唦䰨横堬嬮帰缲娴倶倸唺戼績癀療畄罆", a_)))
					{
						num = (short)2048655423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135A;
				case 25:
					goto IL_13CF;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞裠跢菤裦맨諪黬鳮ꏰ雲蓴苶郸觺飼鯾䜀氂眄䬆怈氊攌笎猐爒朔䠖堘⠚⬜⨞ሠᄢ", a_)))
					{
						num = (short)387842053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C62;
				case 27:
					goto IL_14CF;
				case 28:
					goto IL_1178;
				case 29:
					this.radWideUserInformationandPasswordsRadioAliasEnable_A8830 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖堘眚琜縞删昢䬤䘦䬨䜪䠬瀮瀰ଲഴжस", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONRADIOALIASENABLE);
					this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.DataTransferOrder = 15;
					num = (short)2104950862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞裠跢菤裦맨諪黬鳮ꏰ雲蓴苶郸觺飼鯾䜀氂眄吆怈礊栌愎丐划☔№Ⱈ⠚⸜", a_)))
					{
						num = (short)678625320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_843;
				case 31:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖唘琚縜琞朠䰢圤䐦䰨株䔬丮弰吲倴朶堸䠺丼䠾⹀ㅂ⅄ᡆࡈ硊硌睎扐", a_)))
					{
						num = (short)1136984081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D72;
				case 32:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌導縐甒愔帖崘业渜稞匠䴢䐤䨦䰨琪氬ᘮ0Բఴ", a_)))
					{
						num = (short)1861746699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌嬎瀐瀒愔縖稘稚焜䰞䐠儢匤並䨨个栬䄮到尲儴制椸娺丼䰾㙀ⱂ㝄⍆", a_)))
					{
						num = (short)940376070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_533;
				case 34:
					this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453 = new global::AcpBusinessLayer.AcpSimpleRangeField(8, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌導縐甒愔帖崘业渜稞匠䴢䐤䨦䰨漪䐬尮䄰弲吴丶洸帺䔼䬾ቀ⩂㽄≆ᙈ੊罌籎敐晒晔", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONSOFTIDUSERNAMEDISPLAYTEXTSIZE, null, null, 0, 1);
					this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.DataTransferOrder = 1;
					this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.ShowHexValue = false;
					num = (short)1959985209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					this.radWideUserInformationandPINPassword_41303 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("流迌ﳎ鋒鳜헠헢탤ퟦ\udee8꿪퓬훮싰싲열웶뷸컺컼쯾㐀䀂䀄䈆㨈䨊伌䰎圐嘒—№ⴘ⌚弜帞ᠠᔢဤ愦ᄨ横ᰬ᤮瀰2瀴然稸砺༼社݀灂畄瑆཈ॊ瑌੎ᑐၒ恔敖歘汚ᥜ杞❠坢層幦幨⩪⡬⩮䅰䁲㑴䍶䱸䡺䡼佾란욂쎄쒆번", a_), new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.EncryptDecryptConverter(), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근뛾伀匂搄理稈簊戌紎甐䰒℔☖⨘⬚⸜", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONPINPASSWORD);
					this.radWideUserInformationandPINPassword_41303.IgnoreOnCompare = true;
					this.radWideUserInformationandPINPassword_41303.IsMasked = true;
					this.radWideUserInformationandPINPassword_41303.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPINPassword_41303.DataTransferOrder = -1;
					num = (short)83230745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺꣼賾搀焂䤄栆済戊挌娎缐稒愔帖崘䐚⤜⸞ሠጢጤ", a_)))
					{
						num = (short)1918435371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1178;
				case 37:
					this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖唘琚縜琞怠圢儤䈦䐨嬪夬尮瀰弲头堶丸帺夼怾@灂灄罆筈", a_), global::CommonResources.AcgResources.ID_RADIOLOCKATTEMPTSALLOWED, null, null, 0, 1);
					this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.DataTransferOrder = 501;
					this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.ShowHexValue = false;
					num = (short)785973322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_6EB;
				case 39:
					goto IL_D72;
				case 40:
					this.radWideUserinfoPassRequiredForSiren_A36533 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞裠跢菤裦맨諪黬鳮ꏰ雲蓴苶郸觺飼鯾䜀氂眄吆怈礊栌愎丐划☔№Ⱈ⠚⸜", a_), global::CommonResources.AcgResources.ID_PASSWORDREQUIREDFORSIREN);
					this.radWideUserinfoPassRequiredForSiren_A36533.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserinfoPassRequiredForSiren_A36533.DataTransferOrder = 146;
					num = (short)863764521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					goto IL_843;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖唘琚縜琞縠戢ᴤἦᨨᴪ", a_)))
					{
						num = (short)1129447444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1291;
				case 43:
					this.radWideUserInformationandUserLoginUnitID_41306 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺꣼賾搀焂䤄栆済戊挌娎缐稒愔帖崘䐚⤜⸞ሠጢጤ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONUSERLOGINUNITID, 20);
					this.radWideUserInformationandUserLoginUnitID_41306.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandUserLoginUnitID_41306.DataTransferOrder = 202;
					num = (short)227409948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					num = (short)1290993665;
					if (num != 0)
					{
					}
					this.radWideUserInformationandPasswordsRadioAlias_A8829 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖堘眚琜縞删簢搤ἦᄨᤪᐬ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONRADIOALIAS, 14);
					this.radWideUserInformationandPasswordsRadioAlias_A8829.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsRadioAlias_A8829.DataTransferOrder = 115;
					num = (short)1280442378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 45:
					goto IL_CAE;
				case 46:
					goto IL_497;
				case 47:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖高듚돜꧞蓠跢釤軦蛨藪賬菮뗰諲鯴零铸鋺黼뛾䔀吂氄猆愈嬊氌簎成搒稔攖紘䐚尜⬞ሠᐢᔤሦ", a_)))
					{
						num = (short)1289289788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E72;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴뛶韸鿺근黾爀瀂爄栆笈漊縌嬎瀐瀒愔縖稘稚焜嘞传䬢䰤䔦䀨弪栬䄮倰儲头制昸稺฼ା畀獂灄", a_)))
					{
						num = (short)1211039820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6EB;
				case 49:
					goto IL_156E;
				case 50:
					num = (short)112590932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖堘眚琜縞删昢䬤䘦䬨䜪䠬瀮瀰ଲഴжस", a_)))
					{
						num = (short)1545076765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32F;
				case 52:
					this.radWideUserInformationandCachedCredentialsUserLoginMode_41307 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺뻼黾戀欂怄挆䨈礊栌欎琐紒愔縖砘眚渜䨞删䘢圤欦䘨䰪䐬䄮簰尲儴制昸༺఼ా煀瑂", a_), global::CommonResources.AcgResources.ID_CACHEDCREDENTIALSUSERLOGINMODE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideUserInformationandCachedCredentialsUserLoginMode_41307LovStrs);
					this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.DataTransferOrder = 205;
					num = (short)1330577453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
					goto IL_1521;
				case 54:
					goto IL_279;
				case 55:
					this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926LovStrs), this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌娎成瘒朔嬖瘘簚琜焞怠嘢儤伦䰨䔪夬䘮到刲䄴帶嘸唺椼䘾ㅀ♂ᩄن絈罊瑌絎材", a_), global::CommonResources.AcgResources.ID_USERLOGINAUTHENTICATIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926LovStrs);
					this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.DataTransferOrder = 75;
					num = (short)604700699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					goto IL_533;
				case 57:
					goto IL_A58;
				case 58:
					this.radWideUserInformationandUserLoginUnitIDTextSize_41309 = new global::AcpBusinessLayer.AcpField<int>(20, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺꣼賾搀焂䤄栆済戊挌娎缐稒愔帖崘会砜朞唠瀢䰤崦䰨琪᤬ḮȰ̲ఴ", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONUSERLOGINUNITIDTEXTSIZE);
					this.radWideUserInformationandUserLoginUnitIDTextSize_41309.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideUserInformationandUserLoginUnitIDTextSize_41309.DataTransferOrder = 201;
					num = (short)489947198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
					this.radWideUserInformationandPasswordsPIN_A8705 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌弎堐崒䨔嘖℘Ⱊⴜ⨞", a_), global::CommonResources.AcgResources.ID_USERINFORMATIONPIN, 4);
					this.radWideUserInformationandPasswordsPIN_A8705.IgnoreOnCompare = true;
					this.radWideUserInformationandPasswordsPIN_A8705.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideUserInformationandPasswordsPIN_A8705.DataTransferOrder = -1;
					num = (short)1122959375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					this.radWideConventionalDynamicIDWithPassword_A43705 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖高듚돜꧞蓠跢釤軦蛨藪賬菮뗰諲鯴零铸鋺黼뛾䔀吂氄猆愈嬊氌簎成搒稔攖紘䐚尜⬞ሠᐢᔤሦ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALDYNAMICIDWITHPASSWORD, 8);
					this.radWideConventionalDynamicIDWithPassword_A43705.IgnoreOnCompare = true;
					this.radWideConventionalDynamicIDWithPassword_A43705.IsMasked = true;
					this.radWideConventionalDynamicIDWithPassword_A43705.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideConventionalDynamicIDWithPassword_A43705.DataTransferOrder = -1;
					num = (short)1188560968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 61:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺꣼賾搀焂䤄栆済戊挌娎缐稒愔帖崘会砜朞唠瀢䰤崦䰨琪᤬ḮȰ̲ఴ", a_)))
					{
						num = (short)1314717754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A0C;
				case 62:
					goto IL_A0C;
				case 63:
					this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌導琐瀒怔攖簘匚簜洞䔠吢䐤唦䰨横堬嬮帰缲娴倶倸唺戼績癀療畄罆", a_), global::CommonResources.AcgResources.ID_SECUREHARDWAREAUTOLOGIN);
					this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.DataTransferOrder = 110;
					num = (short)1064894547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 64:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺뻼黾戀欂怄挆䨈礊栌欎琐紒愔縖砘眚渜䨞删䘢圤欦䘨䰪䐬䄮簰尲儴制昸༺఼ా煀瑂", a_)))
					{
						num = (short)314179636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CAE;
				case 65:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖堘眚琜縞删簢搤ἦᄨᤪᐬ", a_)))
					{
						num = (short)341835820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_448;
				case 66:
					this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴뛶韸鿺근黾爀瀂爄栆笈漊縌嬎瀐瀒愔縖稘稚焜嘞传䬢䰤䔦䀨弪栬䄮到尲儴制椸娺丼䰾㙀ⱂ㝄⍆ᙈ੊繌筎扐橒恔", a_), global::CommonResources.AcgResources.ID_TACTICALINHIBITENCODEPASSWORD, 8);
					this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.IgnoreOnCompare = true;
					this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.IsMasked = true;
					this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.DataTransferOrder = -1;
					num = (short)1948647470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 67:
					goto IL_1291;
				case 68:
					this.radWideUserinfoPassRequiredForGunlock_A36531 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞裠跢菤裦맨諪黬鳮ꏰ雲蓴苶郸觺飼鯾䜀氂眄䀆簈攊愌怎爐砒䨔嘖⨘ⴚ⠜Ⱎဠ", a_), global::CommonResources.AcgResources.ID_PASSWORDREQUIREDFORGUNLOCK);
					this.radWideUserinfoPassRequiredForGunlock_A36531.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserinfoPassRequiredForGunlock_A36531.DataTransferOrder = 144;
					num = (short)1042612246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 69:
					this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477 = new global::AcpBusinessLayer.AcpSimpleRangeField(10, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌䈎瀐欒簔稖氘瘚䴜縞删倢判䠦嬨伪愬䨮弰吲䄴弶昸稺Լା癀瑂", a_), global::CommonResources.AcgResources.ID_RADIOLOCKMAXIMUMPASSWORDLENGTH, null, null, 0, 1);
					this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.DataTransferOrder = 8;
					this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.ShowHexValue = false;
					num = (short)1344536661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 70:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖唘琚縜琞猠䈢䄤並䘨截䌬䜮堰儲尴䌶瘸唺礼娾⁀❂⥄⡆⩈⁊ቌ๎扐晒浔捖", a_)))
					{
						num = (short)524943435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4E4;
				case 71:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺꣼賾搀焂䤄栆済戊挌娎缐稒愔帖崘帚猜縞䌠伢䀤砦ᴨᨪḬἮа", a_)))
					{
						num = (short)2145648661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_156E;
				case 72:
					goto IL_E72;
				case 73:
					goto IL_C62;
				case 74:
					goto IL_F63;
				case 75:
					this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖唘琚縜琞猠䈢䄤並䘨截䌬䜮堰儲尴䌶瘸唺礼娾⁀❂⥄⡆⩈⁊ቌ๎扐晒浔捖", a_), global::CommonResources.AcgResources.ID_RADIOLOCKRADIOINHIBITONDEADLOCK);
					this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.DataTransferOrder = 502;
					num = (short)204144721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 76:
					this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴뛶韸鿺근黾爀瀂爄栆笈漊縌嬎瀐瀒愔縖稘稚焜嘞传䬢䰤䔦䀨弪栬䄮倰儲头制昸稺฼ା畀獂灄", a_), global::CommonResources.AcgResources.ID_TACTICALINHIBITENABLE);
					this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.DataTransferOrder = 12;
					num = (short)188088358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 77:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌娎缐缒稔琖爘䬚簜氞删吢䨤唦䴨琪氬ᜮܰਲԴ", a_)))
					{
						num = (short)1657012240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CFB;
				case 78:
					goto IL_32F;
				case 79:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근뛾伀匂搄理稈簊戌紎甐䰒℔☖⨘⬚⸜", a_)))
					{
						num = (short)1686306851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13CF;
				case 80:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌弎挐簒愔爖稘漚砜笞笠䰢䬤䈦礨䨪帬尮䘰尲䜴匶昸稺Լ࠾着畂", a_)))
					{
						goto IL_144C;
					}
					goto IL_DC0;
				case 81:
					goto IL_4E4;
				case 82:
				{
					num = (short)202506240;
					short num4 = num;
					this.radWideUserInformationandPasswordsMandatoryPassword_A8461 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌䈎瀐紒焔瘖洘琚漜昞焠䈢嘤否帨䐪弬䬮渰爲ഴ̶༸਺", a_), global::CommonResources.AcgResources.ID_RADIOLOCKMANDATORYPASSWORD);
					this.radWideUserInformationandPasswordsMandatoryPassword_A8461.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideUserInformationandPasswordsMandatoryPassword_A8461.DataTransferOrder = 108;
					num = (short)65470517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 83:
					goto IL_135A;
				case 84:
					if (producerFields != null)
					{
						num = (short)364707843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15BA;
				case 85:
					goto IL_14D4;
				case 86:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞裠跢菤裦맨諪黬鳮ꏰ雲蓴苶郸觺飼鯾䜀氂眄䀆簈攊愌怎爐砒䨔嘖⨘ⴚ⠜Ⱎဠ", a_)))
					{
						num = (short)1191444548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC0;
				case 87:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ蛐뫒뇔닖賘꣚룜귞꣠跢菤裦鯨蛪賬鯮飰鳲鯴零韸鿺근黾爀瀂爄栆笈漊縌崎瀐眒簔砖唘琚縜琞怠圢儤䈦䐨嬪夬尮瀰弲头堶丸帺夼怾@灂灄罆筈", a_)))
					{
						num = (short)1049231397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F63;
				}
				IL_18E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1218314290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_279:
				num = (short)289341440;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32F:
				num = (short)1284112426;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_448:
				num = (short)1807417362;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_497:
				num = (short)1134231600;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4E4:
				num = (short)51249183;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_533:
				num = (short)1568604169;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6EB:
				num = (short)2086469644;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_843:
				num = (short)394854477;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A0C:
				num = (short)1090846807;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A58:
				num = (short)1535770710;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C62:
				num = (short)1547894814;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CAE:
				num = (short)686358589;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CFB:
				num = (short)136708110;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D72:
				num = (short)511508527;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DC0:
				num = (short)1954283571;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E72:
				num = (short)9371681;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC0:
				num = (short)1475084314;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F63:
				num = (short)543555654;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_107A:
				num = (short)770310215;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1178:
				num = (short)134086720;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1291:
				num = (short)1444216864;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_135A:
				num = (short)1612185665;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13CF:
				num = (short)1809252359;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_141C:
				num = (short)864354384;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_144C:
				num = (short)2115305480;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14D4:
				num = (short)1467088975;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1521:
				num = (short)901906456;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_156E:
				num = (short)1532231716;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14CF:
			IL_15BA:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黊뻌꫎ꏐ鳔맖뿘듚꿜닞胠韢賤裦蟨쯪賬臮闰폲ꗴ零諸裺諼郾猀朂瘄", a_);
			base.Id = 10102;
			base.UIName = global::CommonResources.AcgResources.ID_USERINFORMATIONANDPASSWORDS;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x003E2430 File Offset: 0x003E0630
		public override void PopulateReferences()
		{
			short num = (short)221458538;
			short num2 = num;
			num = (short)298266730;
			switch (num2 == num)
			{
			}
			num = (short)5898240;
			short num3 = num;
			num = (short)232587265;
			if (num != 0)
			{
			}
			num = (short)366084096;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x003E24DC File Offset: 0x003E06DC
		public override void DropReferences()
		{
			short num = (short)220442991;
			short num2 = num;
			num = (short)813609327;
			switch (num2 == num)
			{
			}
			num = (short)1401946112;
			short num3 = num;
			num = (short)108789761;
			if (num != 0)
			{
			}
			num = (short)251265024;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x003E2588 File Offset: 0x003E0788
		public override void SetConstraints()
		{
			short num = (short)655063938;
			short num2 = num;
			num = (short)337345410;
			switch (num2 == num)
			{
			}
			num = (short)2124087296;
			short num3 = num;
			num = (short)1895956481;
			if (num != 0)
			{
			}
			num = (short)238092288;
			if (num != 0)
			{
			}
			this.radWideUserInformationandPasswordsPIN_A8705.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnFalse);
			this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConProtectedZonePasswordCannotBeEmptyIfFPPEnabledValid);
			this.radWideUserInformationandPasswordsRadioLock_A8836.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRadWideRadioLockIsApp);
			this.radWideUserInformationandPasswordsRadioLock_A8836.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTacticalInhibitEnabledForRadioLock);
			this.RadWideUserInformationandPasswordsRadioLock_A8836.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conEnableRadioLockValueSetter);
			this.radWideUserInformationandPasswordsSoftIDUsername_A9169.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConSoftIDUsernameTextSizeValid);
			this.radWideUserInformationandPasswordsSoftIDUsername_A9169.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.radWideUserInformationandPasswordsSoftIDUsername_A9169.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conNonEditableWhenOpenFromRMC);
			this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTacticalInhibitEnabled);
			this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConEncodePasswordLength);
			this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnFalse);
			this.radWideUserinfoPassRequiredForGunlock_A36531.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conRadLockisEnForPasswordRequired);
			this.radWideUserinfoPassRequiredForLightbar_A36532.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conRadLockisEnForPasswordRequired);
			this.radWideUserinfoPassRequiredForSiren_A36533.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conRadLockisEnForPasswordRequired);
			this.radWideUserInformationandPasswordsUnlockPassword_A8690.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conRadLockisEnAndSecOperIsDisOrSecOperIsADP);
			this.radWideUserInformationandPasswordsUnlockPassword_A8690.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conSetRadioLockPasswordValidity);
			this.radWideUserInformationandPasswordsMandatoryPassword_A8461.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conRadLockisEnAndSecOperIsDisOrSecOperIsADP);
			this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conSecHwForMobAndSecHwAndRadLockIsEnAndTacticalInhIsDisForPor);
			this.radWideUserInformationandPasswordsRadioAlias_A8829.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDependOnRadWideMultiRadSysAndRadWideHhchCapblAndRadWideRadioIdAliasEn);
			this.radWideUserInformationandPasswordsRadioAlias_A8829.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.radWideUserInformationandPasswordsRadioAlias_A8829.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conNonEditableWhenOpenFromRMC);
			this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conRadLockisEnAndSecOperIsDisOrSecOperIsADP);
			this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conSetRadioLockPasswordLengthBasedOnPCIValidity);
			this.radWideUserInformationandPINPassword_41303.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conPINPasswordInputValidity);
			this.radWideUserInformationandPINPassword_41303.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.radWideUserInformationandPINPassword_41303.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conNonEditableWhenOpenFromRMC);
			this.radWideUserInformationandPINPassword_41303.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conPINPasswordValueSetter);
			this.radWideUserInformationandPINPasswordPart2_41304.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conReturnFalse);
			this.radWideUserInformationandUserLoginUnitID_41306.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsUerLoginUnitIDApplicable);
			this.radWideUserInformationandUserLoginUnitID_41306.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsUserLoginUnitIDValid);
			this.radWideUserInformationandUserLoginUnitID_41306.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConInvisibleWhenOpenfromRMC);
			this.radWideUserInformationandUserLoginUnitID_41306.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIsUerLoginUnitIDEditable);
			this.radWideUserInformationandUserLoginUnitIDTextSize_41309.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideConventionalDynamicIDWithPassword_A43705.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConDynamicIDIsEnableInAnyConvSystem);
			this.RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conEnableRadioLockAttemptsAllowed);
			this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conEnableRadioLockRadioInhibitOnDeadlock);
			this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.conEnableForceChangePassword);
			this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConTacticalServiceEncodePasswordIsApplicable);
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x003E29B0 File Offset: 0x003E0BB0
		public override void SetupDependencies()
		{
			short num = (short)1544093696;
			short num2 = num;
			num = (short)1652542658;
			short num3 = num;
			num = (short)341101762;
			switch (num3 == num)
			{
			}
			num = (short)1413021697;
			if (num != 0)
			{
			}
			num = (short)873267200;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			radioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radWideUserInformationandPasswordsRadioLock_A8836);
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.radWideUserInformationandPasswordsRadioLock_A8836);
			this.RefRadioInformation.General.RadInfoGeneralModelNumber_A8539.AddDependentObject(this.radWideUserInformationandPasswordsRadioLock_A8836);
			this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.AddDependentObject(this.radWideUserInformationandPasswordsSoftIDUsername_A9169);
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395);
			this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.AddDependentObject(this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395);
			this.radWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radWideUserinfoPassRequiredForGunlock_A36531);
			this.radWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radWideUserinfoPassRequiredForLightbar_A36532);
			this.radWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radWideUserinfoPassRequiredForSiren_A36533);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.radWideUserInformationandPasswordsUnlockPassword_A8690);
			this.radWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radWideUserInformationandPasswordsUnlockPassword_A8690);
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.radWideUserInformationandPasswordsUnlockPassword_A8690);
			this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.AddDependentObject(this.radWideUserInformationandPasswordsUnlockPassword_A8690);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.radWideUserInformationandPasswordsMandatoryPassword_A8461);
			this.radWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radWideUserInformationandPasswordsMandatoryPassword_A8461);
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.radWideUserInformationandPasswordsMandatoryPassword_A8461);
			this.radWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508);
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508);
			this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.AddDependentObject(this.radWideUserInformationandPasswordsRadioAlias_A8829);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477);
			this.radWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477);
			this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.AddDependentObject(this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477);
			radioWide.Labtool.TEN_DIGIT_RL_PSWD_capable_43711.AddDependentObject(this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477);
			this.radWideUserInformationandUserLoginUnitIDTextSize_41309.AddDependentObject(this.radWideUserInformationandUserLoginUnitID_41306);
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x003E2C64 File Offset: 0x003E0E64
		public bool HasDiffs
		{
			get
			{
				short num = (short)1340342272;
				short num2 = num;
				num = (short)1997433147;
				short num3 = num;
				num = (short)1683450171;
				switch (num3 == num)
				{
				}
				num = (short)712835072;
				if (num != 0)
				{
				}
				num = (short)1363345409;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x003E2D14 File Offset: 0x003E0F14
		// (set) Token: 0x0600428F RID: 17039 RVA: 0x003E2DC8 File Offset: 0x003E0FC8
		public string RadWideUserInformationandPasswordsPIN_A8705Value
		{
			get
			{
				short num = (short)1491795968;
				short num2 = num;
				num = (short)2136276993;
				if (num != 0)
				{
				}
				num = (short)1440788693;
				short num3 = num;
				num = (short)951103701;
				switch (num3 == num)
				{
				}
				num = (short)1069809664;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.Value;
			}
			set
			{
				short num = (short)332791808;
				short num2 = num;
				num = (short)864291746;
				short num3 = num;
				num = (short)703597474;
				switch (num3 == num)
				{
				}
				num = (short)1849884673;
				if (num != 0)
				{
				}
				num = (short)1984757760;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsPIN_A8705.Value = value;
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x003E2E80 File Offset: 0x003E1080
		public global::AcpBusinessLayer.AcpField<string> RadWideUserInformationandPasswordsPIN_A8705
		{
			get
			{
				short num = (short)857276416;
				short num2 = num;
				num = (short)776033826;
				short num3 = num;
				num = (short)160847394;
				switch (num3 == num)
				{
				}
				num = (short)979828737;
				if (num != 0)
				{
				}
				num = (short)726335488;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705;
			}
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x003E2F30 File Offset: 0x003E1130
		// (set) Token: 0x06004292 RID: 17042 RVA: 0x003E2FE8 File Offset: 0x003E11E8
		public string RadWideUserInformationandPasswordsPIN_A8705_UIValue
		{
			get
			{
				short num = (short)378667008;
				short num2 = num;
				num = (short)755259079;
				short num3 = num;
				num = (short)797267655;
				switch (num3 == num)
				{
				}
				num = (short)938803201;
				if (num != 0)
				{
				}
				num = (short)438697984;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.Value;
			}
			set
			{
				short num = (short)831258624;
				short num2 = num;
				num = (short)1525951442;
				short num3 = num;
				num = (short)1820273618;
				switch (num3 == num)
				{
				}
				num = (short)944832513;
				if (num != 0)
				{
				}
				num = (short)1266941952;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsPIN_A8705.Value = value;
			}
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06004293 RID: 17043 RVA: 0x003E309C File Offset: 0x003E129C
		// (set) Token: 0x06004294 RID: 17044 RVA: 0x003E314C File Offset: 0x003E134C
		public bool RadWideUserInformationandPasswordsPIN_A8705_Applicable
		{
			get
			{
				short num = (short)1868300288;
				short num2 = num;
				num = (short)356900205;
				short num3 = num;
				num = (short)775478637;
				switch (num3 == num)
				{
				}
				num = (short)1111949313;
				if (num != 0)
				{
				}
				num = (short)1964638208;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.Applicable;
			}
			set
			{
				short num = (short)1894514688;
				short num2 = num;
				num = (short)1172419962;
				short num3 = num;
				num = (short)1004254586;
				switch (num3 == num)
				{
				}
				num = (short)1800863744;
				if (num != 0)
				{
				}
				num = (short)669515777;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsPIN_A8705.Applicable = value;
			}
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06004295 RID: 17045 RVA: 0x003E3204 File Offset: 0x003E1404
		// (set) Token: 0x06004296 RID: 17046 RVA: 0x003E32BC File Offset: 0x003E14BC
		public bool RadWideUserInformationandPasswordsPIN_A8705_Valid
		{
			get
			{
				short num = (short)1052508160;
				short num2 = num;
				num = (short)1929892189;
				short num3 = num;
				num = (short)138662237;
				switch (num3 == num)
				{
				}
				num = (short)1402470400;
				if (num != 0)
				{
				}
				num = (short)1324548097;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.Valid;
			}
			set
			{
				short num = (short)268435456;
				short num2 = num;
				num = (short)1669641817;
				short num3 = num;
				num = (short)2104276569;
				switch (num3 == num)
				{
				}
				num = (short)1486159873;
				if (num != 0)
				{
				}
				num = (short)1745027072;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsPIN_A8705.Valid = value;
			}
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06004297 RID: 17047 RVA: 0x003E3374 File Offset: 0x003E1574
		// (set) Token: 0x06004298 RID: 17048 RVA: 0x003E3428 File Offset: 0x003E1628
		public bool RadWideUserInformationandPasswordsPIN_A8705_Visible
		{
			get
			{
				short num = (short)850264064;
				short num2 = num;
				num = (short)1824597289;
				short num3 = num;
				num = (short)26092841;
				switch (num3 == num)
				{
				}
				num = (short)61472769;
				if (num != 0)
				{
				}
				num = (short)1707933696;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.Visible;
			}
			set
			{
				short num = (short)8716288;
				short num2 = num;
				num = (short)229350001;
				short num3 = num;
				num = (short)156736113;
				switch (num3 == num)
				{
				}
				num = (short)1018232832;
				if (num != 0)
				{
				}
				num = (short)469172225;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsPIN_A8705.Visible = value;
			}
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x06004299 RID: 17049 RVA: 0x003E34DC File Offset: 0x003E16DC
		// (set) Token: 0x0600429A RID: 17050 RVA: 0x003E3590 File Offset: 0x003E1790
		public bool RadWideUserInformationandPasswordsPIN_A8705_Editable
		{
			get
			{
				short num = (short)1779040256;
				short num2 = num;
				num = (short)1905023764;
				short num3 = num;
				num = (short)1284594452;
				switch (num3 == num)
				{
				}
				num = (short)1083834368;
				if (num != 0)
				{
				}
				num = (short)1190002689;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.Editable;
			}
			set
			{
				short num = (short)422117376;
				short num2 = num;
				num = (short)556625656;
				short num3 = num;
				num = (short)539782904;
				switch (num3 == num)
				{
				}
				num = (short)765984768;
				if (num != 0)
				{
				}
				num = (short)75759617;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsPIN_A8705.Editable = value;
			}
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0600429B RID: 17051 RVA: 0x003E364C File Offset: 0x003E184C
		internal string RadWideUserInformationandPasswordsPIN_A8705_UILabel
		{
			get
			{
				short num = (short)2086535168;
				short num2 = num;
				num = (short)1153681595;
				short num3 = num;
				num = (short)192661691;
				switch (num3 == num)
				{
				}
				num = (short)1963065344;
				if (num != 0)
				{
				}
				num = (short)951910401;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.UIName;
			}
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0600429C RID: 17052 RVA: 0x003E3704 File Offset: 0x003E1904
		// (set) Token: 0x0600429D RID: 17053 RVA: 0x003E37B8 File Offset: 0x003E19B8
		internal bool RadWideUserInformationandPasswordsPIN_A8705_HiddenStatic
		{
			get
			{
				short num = (short)93650944;
				short num2 = num;
				num = (short)1255140844;
				short num3 = num;
				num = (short)243789292;
				switch (num3 == num)
				{
				}
				num = (short)798818305;
				if (num != 0)
				{
				}
				num = (short)1914241024;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.HiddenStatic;
			}
			set
			{
				short num = (short)1249181696;
				short num2 = num;
				num = (short)2076879033;
				short num3 = num;
				num = (short)1452320953;
				switch (num3 == num)
				{
				}
				num = (short)193658881;
				if (num != 0)
				{
				}
				num = (short)1072496640;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsPIN_A8705.HiddenStatic = value;
			}
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0600429E RID: 17054 RVA: 0x003E3870 File Offset: 0x003E1A70
		// (set) Token: 0x0600429F RID: 17055 RVA: 0x003E3928 File Offset: 0x003E1B28
		internal bool RadWideUserInformationandPasswordsPIN_A8705_HiddenDynamic
		{
			get
			{
				short num = (short)851247104;
				short num2 = num;
				num = (short)1928481216;
				short num3 = num;
				num = (short)888228288;
				switch (num3 == num)
				{
				}
				num = (short)1218314241;
				if (num != 0)
				{
				}
				num = (short)1478361088;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705.HiddenDynamic;
			}
			set
			{
				short num = (short)1933770752;
				short num2 = num;
				num = (short)1791169779;
				short num3 = num;
				num = (short)1676547315;
				switch (num3 == num)
				{
				}
				num = (short)1568276481;
				if (num != 0)
				{
				}
				num = (short)161480704;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsPIN_A8705.HiddenDynamic = value;
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x003E39E0 File Offset: 0x003E1BE0
		public bool RadWideUserInformationandPasswordsPIN_A8705_HasDiffs
		{
			get
			{
				short num = (short)276496384;
				short num2 = num;
				num = (short)53427114;
				short num3 = num;
				num = (short)1231567786;
				switch (num3 == num)
				{
				}
				num = (short)2000027649;
				if (num != 0)
				{
				}
				num = (short)1244790784;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsPIN_A8705._HasDiffs;
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x003E3A94 File Offset: 0x003E1C94
		// (set) Token: 0x060042A2 RID: 17058 RVA: 0x003E3B48 File Offset: 0x003E1D48
		public string RadWideUserInformationandPasswordsProtectedZonePassword_A8766Value
		{
			get
			{
				short num = (short)2136342528;
				short num2 = num;
				num = (short)1215764919;
				short num3 = num;
				num = (short)1970346423;
				switch (num3 == num)
				{
				}
				num = (short)479985665;
				if (num != 0)
				{
				}
				num = (short)1118371840;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Value;
			}
			set
			{
				short num = (short)379912192;
				short num2 = num;
				num = (short)1970667521;
				if (num != 0)
				{
				}
				num = (short)1735561195;
				short num3 = num;
				num = (short)316706795;
				switch (num3 == num)
				{
				}
				num = (short)87621632;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Value = value;
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x003E3C00 File Offset: 0x003E1E00
		public global::AcpBusinessLayer.AcpField<string> RadWideUserInformationandPasswordsProtectedZonePassword_A8766
		{
			get
			{
				short num = (short)1960312832;
				short num2 = num;
				num = (short)1934136994;
				short num3 = num;
				num = (short)690919074;
				switch (num3 == num)
				{
				}
				num = (short)345243649;
				if (num != 0)
				{
				}
				num = (short)1028587520;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766;
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x003E3CB4 File Offset: 0x003E1EB4
		// (set) Token: 0x060042A5 RID: 17061 RVA: 0x003E3D68 File Offset: 0x003E1F68
		public string RadWideUserInformationandPasswordsProtectedZonePassword_A8766_UIValue
		{
			get
			{
				short num = (short)987365376;
				short num2 = num;
				num = (short)2113461493;
				short num3 = num;
				num = (short)1720835317;
				switch (num3 == num)
				{
				}
				num = (short)655753217;
				if (num != 0)
				{
				}
				num = (short)1091895296;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Value;
			}
			set
			{
				short num = (short)594673664;
				short num2 = num;
				num = (short)1793676872;
				short num3 = num;
				num = (short)122377800;
				switch (num3 == num)
				{
				}
				num = (short)1333198849;
				if (num != 0)
				{
				}
				num = (short)469303296;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Value = value;
			}
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x003E3E1C File Offset: 0x003E201C
		// (set) Token: 0x060042A7 RID: 17063 RVA: 0x003E3ED4 File Offset: 0x003E20D4
		public bool RadWideUserInformationandPasswordsProtectedZonePassword_A8766_Applicable
		{
			get
			{
				short num = (short)2133000192;
				short num2 = num;
				num = (short)267127674;
				short num3 = num;
				num = (short)566692730;
				switch (num3 == num)
				{
				}
				num = (short)1612185601;
				if (num != 0)
				{
				}
				num = (short)1072234496;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Applicable;
			}
			set
			{
				short num = (short)1916207104;
				short num2 = num;
				num = (short)1333869593;
				short num3 = num;
				num = (short)1331313689;
				switch (num3 == num)
				{
				}
				num = (short)305266688;
				if (num != 0)
				{
				}
				num = (short)1167654913;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Applicable = value;
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x003E3F88 File Offset: 0x003E2188
		// (set) Token: 0x060042A9 RID: 17065 RVA: 0x003E403C File Offset: 0x003E223C
		public bool RadWideUserInformationandPasswordsProtectedZonePassword_A8766_Valid
		{
			get
			{
				short num = (short)776601600;
				short num2 = num;
				num = (short)1152843777;
				if (num != 0)
				{
				}
				num = (short)1834464041;
				short num3 = num;
				num = (short)244233001;
				switch (num3 == num)
				{
				}
				num = (short)80412672;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Valid;
			}
			set
			{
				short num = (short)909115392;
				short num2 = num;
				num = (short)434791592;
				short num3 = num;
				num = (short)2070963368;
				switch (num3 == num)
				{
				}
				num = (short)736952321;
				if (num != 0)
				{
				}
				num = (short)1501429760;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Valid = value;
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x003E40F4 File Offset: 0x003E22F4
		// (set) Token: 0x060042AB RID: 17067 RVA: 0x003E41A8 File Offset: 0x003E23A8
		public bool RadWideUserInformationandPasswordsProtectedZonePassword_A8766_Visible
		{
			get
			{
				short num = (short)1327693824;
				short num2 = num;
				num = (short)128764068;
				short num3 = num;
				num = (short)996788388;
				switch (num3 == num)
				{
				}
				num = (short)1817903105;
				if (num != 0)
				{
				}
				num = (short)1832779776;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Visible;
			}
			set
			{
				short num = (short)583467008;
				short num2 = num;
				num = (short)100363443;
				short num3 = num;
				num = (short)724331699;
				switch (num3 == num)
				{
				}
				num = (short)166789120;
				if (num != 0)
				{
				}
				num = (short)1310851073;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Visible = value;
			}
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x003E425C File Offset: 0x003E245C
		// (set) Token: 0x060042AD RID: 17069 RVA: 0x003E4314 File Offset: 0x003E2514
		public bool RadWideUserInformationandPasswordsProtectedZonePassword_A8766_Editable
		{
			get
			{
				short num = (short)1520566272;
				short num2 = num;
				num = (short)1606401131;
				short num3 = num;
				num = (short)1397537899;
				switch (num3 == num)
				{
				}
				num = (short)1354432513;
				if (num != 0)
				{
				}
				num = (short)275841024;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Editable;
			}
			set
			{
				short num = (short)928120832;
				short num2 = num;
				num = (short)1037395003;
				short num3 = num;
				num = (short)1015112763;
				switch (num3 == num)
				{
				}
				num = (short)108265473;
				if (num != 0)
				{
				}
				num = (short)1858469888;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.Editable = value;
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x003E43C8 File Offset: 0x003E25C8
		internal string RadWideUserInformationandPasswordsProtectedZonePassword_A8766_UILabel
		{
			get
			{
				short num = (short)610598912;
				short num2 = num;
				num = (short)378530974;
				short num3 = num;
				num = (short)1449323678;
				switch (num3 == num)
				{
				}
				num = (short)640614401;
				if (num != 0)
				{
				}
				num = (short)200605696;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.UIName;
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x003E447C File Offset: 0x003E267C
		// (set) Token: 0x060042B0 RID: 17072 RVA: 0x003E4538 File Offset: 0x003E2738
		internal bool RadWideUserInformationandPasswordsProtectedZonePassword_A8766_HiddenStatic
		{
			get
			{
				short num = (short)1053949952;
				short num2 = num;
				num = (short)1727732787;
				short num3 = num;
				num = (short)779295795;
				switch (num3 == num)
				{
				}
				num = (short)863174657;
				if (num != 0)
				{
				}
				num = (short)550961152;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.HiddenStatic;
			}
			set
			{
				short num = (short)1463681024;
				short num2 = num;
				num = (short)253722561;
				short num3 = num;
				num = (short)1132560321;
				switch (num3 == num)
				{
				}
				num = (short)1993867265;
				if (num != 0)
				{
				}
				num = (short)948436992;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.HiddenStatic = value;
			}
		}

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x060042B1 RID: 17073 RVA: 0x003E45F0 File Offset: 0x003E27F0
		// (set) Token: 0x060042B2 RID: 17074 RVA: 0x003E46A4 File Offset: 0x003E28A4
		internal bool RadWideUserInformationandPasswordsProtectedZonePassword_A8766_HiddenDynamic
		{
			get
			{
				short num = (short)1615659008;
				short num2 = num;
				num = (short)438479291;
				short num3 = num;
				num = (short)155953595;
				switch (num3 == num)
				{
				}
				num = (short)416677889;
				if (num != 0)
				{
				}
				num = (short)1455620096;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.HiddenDynamic;
			}
			set
			{
				short num = (short)468647936;
				short num2 = num;
				num = (short)1184343496;
				short num3 = num;
				num = (short)1350346184;
				switch (num3 == num)
				{
				}
				num = (short)905576449;
				if (num != 0)
				{
				}
				num = (short)1904476160;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsProtectedZonePassword_A8766.HiddenDynamic = value;
			}
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x003E4758 File Offset: 0x003E2958
		public bool RadWideUserInformationandPasswordsProtectedZonePassword_A8766_HasDiffs
		{
			get
			{
				short num = (short)736559104;
				short num2 = num;
				num = (short)1976076273;
				short num3 = num;
				num = (short)1157793777;
				switch (num3 == num)
				{
				}
				num = (short)1519452161;
				if (num != 0)
				{
				}
				num = (short)2095054848;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsProtectedZonePassword_A8766._HasDiffs;
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x060042B4 RID: 17076 RVA: 0x003E480C File Offset: 0x003E2A0C
		// (set) Token: 0x060042B5 RID: 17077 RVA: 0x003E48C0 File Offset: 0x003E2AC0
		public bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830Value
		{
			get
			{
				short num = (short)133300224;
				short num2 = num;
				num = (short)23909604;
				short num3 = num;
				num = (short)1591989476;
				switch (num3 == num)
				{
				}
				num = (short)605421568;
				if (num != 0)
				{
				}
				num = (short)110886913;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Value;
			}
			set
			{
				short num = (short)1861877760;
				short num2 = num;
				num = (short)1379406775;
				short num3 = num;
				num = (short)1784222647;
				switch (num3 == num)
				{
				}
				num = (short)963641344;
				if (num != 0)
				{
				}
				num = (short)2121138177;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Value = value;
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x060042B6 RID: 17078 RVA: 0x003E4974 File Offset: 0x003E2B74
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserInformationandPasswordsRadioAliasEnable_A8830
		{
			get
			{
				short num = (short)388104192;
				short num2 = num;
				num = (short)1866661889;
				if (num != 0)
				{
				}
				num = (short)2083353621;
				short num3 = num;
				num = (short)805270549;
				switch (num3 == num)
				{
				}
				num = (short)1073020928;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830;
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x060042B7 RID: 17079 RVA: 0x003E4A24 File Offset: 0x003E2C24
		// (set) Token: 0x060042B8 RID: 17080 RVA: 0x003E4AD8 File Offset: 0x003E2CD8
		public bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830_UIValue
		{
			get
			{
				short num = (short)889257984;
				short num2 = num;
				num = (short)1643308185;
				short num3 = num;
				num = (short)1236133017;
				switch (num3 == num)
				{
				}
				num = (short)1264844800;
				if (num != 0)
				{
				}
				num = (short)221708289;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Value;
			}
			set
			{
				short num = (short)814219264;
				short num2 = num;
				num = (short)726409018;
				short num3 = num;
				num = (short)519577402;
				switch (num3 == num)
				{
				}
				num = (short)2112946177;
				if (num != 0)
				{
				}
				num = (short)1714225152;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Value = value;
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x003E4B90 File Offset: 0x003E2D90
		// (set) Token: 0x060042BA RID: 17082 RVA: 0x003E4C44 File Offset: 0x003E2E44
		public bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830_Applicable
		{
			get
			{
				short num = (short)625606656;
				short num2 = num;
				num = (short)1672276254;
				short num3 = num;
				num = (short)215017758;
				switch (num3 == num)
				{
				}
				num = (short)1156120576;
				if (num != 0)
				{
				}
				num = (short)671481857;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Applicable;
			}
			set
			{
				short num = (short)9175040;
				short num2 = num;
				num = (short)414457511;
				short num3 = num;
				num = (short)1219108519;
				switch (num3 == num)
				{
				}
				num = (short)1288699905;
				if (num != 0)
				{
				}
				num = (short)2015690752;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Applicable = value;
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x060042BB RID: 17083 RVA: 0x003E4CF8 File Offset: 0x003E2EF8
		// (set) Token: 0x060042BC RID: 17084 RVA: 0x003E4DAC File Offset: 0x003E2FAC
		public bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830_Valid
		{
			get
			{
				short num = (short)802226176;
				short num2 = num;
				num = (short)1495007233;
				if (num != 0)
				{
				}
				num = (short)41054754;
				short num3 = num;
				num = (short)1919054370;
				switch (num3 == num)
				{
				}
				num = (short)207683584;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Valid;
			}
			set
			{
				short num = (short)228196352;
				short num2 = num;
				num = (short)16481627;
				short num3 = num;
				num = (short)441154907;
				switch (num3 == num)
				{
				}
				num = (short)491061249;
				if (num != 0)
				{
				}
				num = (short)490471424;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Valid = value;
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x003E4E64 File Offset: 0x003E3064
		// (set) Token: 0x060042BE RID: 17086 RVA: 0x003E4F1C File Offset: 0x003E311C
		public bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830_Visible
		{
			get
			{
				short num = (short)2119499776;
				short num2 = num;
				num = (short)903704060;
				short num3 = num;
				num = (short)645754364;
				switch (num3 == num)
				{
				}
				num = (short)95748096;
				if (num != 0)
				{
				}
				num = (short)633602049;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Visible;
			}
			set
			{
				short num = (short)1895366656;
				short num2 = num;
				num = (short)1050083329;
				if (num != 0)
				{
				}
				num = (short)497917038;
				short num3 = num;
				num = (short)99064942;
				switch (num3 == num)
				{
				}
				num = (short)1939341312;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Visible = value;
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x060042BF RID: 17087 RVA: 0x003E4FD0 File Offset: 0x003E31D0
		// (set) Token: 0x060042C0 RID: 17088 RVA: 0x003E5088 File Offset: 0x003E3288
		public bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830_Editable
		{
			get
			{
				short num = (short)1938030592;
				short num2 = num;
				num = (short)959453;
				short num3 = num;
				num = (short)763536349;
				switch (num3 == num)
				{
				}
				num = (short)353239041;
				if (num != 0)
				{
				}
				num = (short)955318272;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Editable;
			}
			set
			{
				short num = (short)413132457;
				short num2 = num;
				num = (short)1493493417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749797376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1076953089;
				if (num != 0)
				{
				}
				num = (short)1475477504;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.Editable = value;
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x060042C1 RID: 17089 RVA: 0x003E513C File Offset: 0x003E333C
		internal string RadWideUserInformationandPasswordsRadioAliasEnable_A8830_UILabel
		{
			get
			{
				short num = (short)624558081;
				if (num != 0)
				{
				}
				num = (short)315031552;
				short num2 = num;
				num = (short)1923521660;
				short num3 = num;
				num = (short)1528732796;
				switch (num3 == num)
				{
				}
				num = (short)59244544;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.UIName;
			}
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x060042C2 RID: 17090 RVA: 0x003E51F0 File Offset: 0x003E33F0
		// (set) Token: 0x060042C3 RID: 17091 RVA: 0x003E52A4 File Offset: 0x003E34A4
		internal bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830_HiddenStatic
		{
			get
			{
				short num = (short)2017083352;
				short num2 = num;
				num = (short)547700696;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1394540544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)42926081;
				if (num != 0)
				{
				}
				num = (short)1948057600;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.HiddenStatic;
			}
			set
			{
				short num = (short)1316074250;
				short num2 = num;
				num = (short)2135667466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1554055168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)361365505;
				if (num != 0)
				{
				}
				num = (short)1548025856;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.HiddenStatic = value;
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x003E5358 File Offset: 0x003E3558
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x003E5410 File Offset: 0x003E3610
		internal bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830_HiddenDynamic
		{
			get
			{
				short num = (short)17815887;
				short num2 = num;
				num = (short)643619151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)385744896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2008350720;
				if (num != 0)
				{
				}
				num = (short)1351286785;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.HiddenDynamic;
			}
			set
			{
				short num = (short)750459443;
				short num2 = num;
				num = (short)1987779123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)463011840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)110034945;
				if (num != 0)
				{
				}
				num = (short)666435584;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAliasEnable_A8830.HiddenDynamic = value;
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x003E54C8 File Offset: 0x003E36C8
		public bool RadWideUserInformationandPasswordsRadioAliasEnable_A8830_HasDiffs
		{
			get
			{
				short num = (short)664207361;
				if (num != 0)
				{
				}
				num = (short)608698368;
				short num2 = num;
				num = (short)1375350445;
				short num3 = num;
				num = (short)866135725;
				switch (num3 == num)
				{
				}
				num = (short)1713504256;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAliasEnable_A8830._HasDiffs;
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x060042C7 RID: 17095 RVA: 0x003E557C File Offset: 0x003E377C
		// (set) Token: 0x060042C8 RID: 17096 RVA: 0x003E5630 File Offset: 0x003E3830
		public bool RadWideUserInformationandPasswordsRadioLock_A8836Value
		{
			get
			{
				short num = (short)1397030873;
				short num2 = num;
				num = (short)916193241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)13434880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1038483456;
				if (num != 0)
				{
				}
				num = (short)2022440961;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.Value;
			}
			set
			{
				short num = (short)882658124;
				short num2 = num;
				num = (short)1761233740;
				switch (num2 == num)
				{
				default:
				{
					num = (short)610467840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688338432;
				if (num != 0)
				{
				}
				num = (short)864550913;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLock_A8836.Value = value;
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x060042C9 RID: 17097 RVA: 0x003E56E8 File Offset: 0x003E38E8
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserInformationandPasswordsRadioLock_A8836
		{
			get
			{
				short num = (short)652472249;
				short num2 = num;
				num = (short)1107816377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)388497408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)721879041;
				if (num != 0)
				{
				}
				num = (short)63569920;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836;
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x003E5798 File Offset: 0x003E3998
		// (set) Token: 0x060042CB RID: 17099 RVA: 0x003E584C File Offset: 0x003E3A4C
		public bool RadWideUserInformationandPasswordsRadioLock_A8836_UIValue
		{
			get
			{
				short num = (short)1846553156;
				short num2 = num;
				num = (short)1136208452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)357695488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)223084545;
				if (num != 0)
				{
				}
				num = (short)598212608;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.Value;
			}
			set
			{
				short num = (short)1317097681;
				short num2 = num;
				num = (short)2130333905;
				switch (num2 == num)
				{
				default:
				{
					num = (short)250281984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1748303872;
				if (num != 0)
				{
				}
				num = (short)803340289;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLock_A8836.Value = value;
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x003E5904 File Offset: 0x003E3B04
		// (set) Token: 0x060042CD RID: 17101 RVA: 0x003E59BC File Offset: 0x003E3BBC
		public bool RadWideUserInformationandPasswordsRadioLock_A8836_Applicable
		{
			get
			{
				short num = (short)1565982721;
				if (num != 0)
				{
				}
				num = (short)1043202048;
				short num2 = num;
				num = (short)608569529;
				short num3 = num;
				num = (short)365693113;
				switch (num3 == num)
				{
				}
				num = (short)736034816;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.Applicable;
			}
			set
			{
				short num = (short)2111654310;
				short num2 = num;
				num = (short)1420315046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767047168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1703477249;
				if (num != 0)
				{
				}
				num = (short)1505689600;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLock_A8836.Applicable = value;
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x060042CE RID: 17102 RVA: 0x003E5A74 File Offset: 0x003E3C74
		// (set) Token: 0x060042CF RID: 17103 RVA: 0x003E5B28 File Offset: 0x003E3D28
		public bool RadWideUserInformationandPasswordsRadioLock_A8836_Valid
		{
			get
			{
				short num = (short)2133289150;
				short num2 = num;
				num = (short)871459006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1304166400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)149225473;
				if (num != 0)
				{
				}
				num = (short)306446336;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.Valid;
			}
			set
			{
				short num = (short)54525953;
				if (num != 0)
				{
				}
				num = (short)1763901440;
				short num2 = num;
				num = (short)154351158;
				short num3 = num;
				num = (short)493303350;
				switch (num3 == num)
				{
				}
				num = (short)1488125952;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLock_A8836.Valid = value;
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x060042D0 RID: 17104 RVA: 0x003E5BE0 File Offset: 0x003E3DE0
		// (set) Token: 0x060042D1 RID: 17105 RVA: 0x003E5C94 File Offset: 0x003E3E94
		public bool RadWideUserInformationandPasswordsRadioLock_A8836_Visible
		{
			get
			{
				short num = (short)1253142134;
				short num2 = num;
				num = (short)213741174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)974258176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109445121;
				if (num != 0)
				{
				}
				num = (short)1516240896;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.Visible;
			}
			set
			{
				short num = (short)14963397;
				short num2 = num;
				num = (short)2045399749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144403456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)205586433;
				if (num != 0)
				{
				}
				num = (short)301465600;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLock_A8836.Visible = value;
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x060042D2 RID: 17106 RVA: 0x003E5D48 File Offset: 0x003E3F48
		// (set) Token: 0x060042D3 RID: 17107 RVA: 0x003E5E00 File Offset: 0x003E4000
		public bool RadWideUserInformationandPasswordsRadioLock_A8836_Editable
		{
			get
			{
				short num = (short)617892089;
				short num2 = num;
				num = (short)1108560121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203175424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1294925825;
				if (num != 0)
				{
				}
				num = (short)660930560;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.Editable;
			}
			set
			{
				short num = (short)1835009;
				if (num != 0)
				{
				}
				num = (short)1297940480;
				short num2 = num;
				num = (short)1509835825;
				short num3 = num;
				num = (short)1355891761;
				switch (num3 == num)
				{
				}
				num = (short)1264189440;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLock_A8836.Editable = value;
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x003E5EB4 File Offset: 0x003E40B4
		internal string RadWideUserInformationandPasswordsRadioLock_A8836_UILabel
		{
			get
			{
				short num = (short)971703025;
				short num2 = num;
				num = (short)2001470193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1849884672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1679556608;
				if (num != 0)
				{
				}
				num = (short)152240129;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.UIName;
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x003E5F68 File Offset: 0x003E4168
		// (set) Token: 0x060042D6 RID: 17110 RVA: 0x003E601C File Offset: 0x003E421C
		internal bool RadWideUserInformationandPasswordsRadioLock_A8836_HiddenStatic
		{
			get
			{
				short num = (short)1135133135;
				short num2 = num;
				num = (short)1042399695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)259391488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)998047744;
				if (num != 0)
				{
				}
				num = (short)1263730689;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.HiddenStatic;
			}
			set
			{
				short num = (short)742932494;
				short num2 = num;
				num = (short)94191630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1688535040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2011168769;
				if (num != 0)
				{
				}
				num = (short)800325632;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLock_A8836.HiddenStatic = value;
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x003E60D0 File Offset: 0x003E42D0
		// (set) Token: 0x060042D8 RID: 17112 RVA: 0x003E6184 File Offset: 0x003E4384
		internal bool RadWideUserInformationandPasswordsRadioLock_A8836_HiddenDynamic
		{
			get
			{
				short num = (short)371402739;
				short num2 = num;
				num = (short)732702707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)876609536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)172490752;
				if (num != 0)
				{
				}
				num = (short)1892810753;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836.HiddenDynamic;
			}
			set
			{
				short num = (short)2129569186;
				short num2 = num;
				num = (short)1641522594;
				switch (num2 == num)
				{
				default:
				{
					num = (short)619773952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1476460545;
				if (num != 0)
				{
				}
				num = (short)1645084672;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLock_A8836.HiddenDynamic = value;
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x060042D9 RID: 17113 RVA: 0x003E623C File Offset: 0x003E443C
		public bool RadWideUserInformationandPasswordsRadioLock_A8836_HasDiffs
		{
			get
			{
				short num = (short)846834513;
				short num2 = num;
				num = (short)277195601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)661585920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989921281;
				if (num != 0)
				{
				}
				num = (short)1866727424;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLock_A8836._HasDiffs;
			}
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x003E62F0 File Offset: 0x003E44F0
		// (set) Token: 0x060042DB RID: 17115 RVA: 0x003E63A4 File Offset: 0x003E45A4
		public string RadWideUserInformationandPasswordsSoftIDUsername_A9169Value
		{
			get
			{
				short num = (short)1864171521;
				if (num != 0)
				{
				}
				num = (short)1746337792;
				short num2 = num;
				num = (short)1610643303;
				short num3 = num;
				num = (short)214726503;
				switch (num3 == num)
				{
				}
				num = (short)1909391360;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Value;
			}
			set
			{
				short num = (short)294319062;
				short num2 = num;
				num = (short)411562966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)85393408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)549257217;
				if (num != 0)
				{
				}
				num = (short)1000800256;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Value = value;
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x003E6458 File Offset: 0x003E4658
		public global::AcpBusinessLayer.AcpFieldX<string, string> RadWideUserInformationandPasswordsSoftIDUsername_A9169
		{
			get
			{
				short num = (short)1516124064;
				short num2 = num;
				num = (short)1696675744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1138556928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)946536448;
				if (num != 0)
				{
				}
				num = (short)1767374849;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169;
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x003E650C File Offset: 0x003E470C
		// (set) Token: 0x060042DE RID: 17118 RVA: 0x003E65C0 File Offset: 0x003E47C0
		public string RadWideUserInformationandPasswordsSoftIDUsername_A9169_UIValue
		{
			get
			{
				short num = (short)1236336641;
				if (num != 0)
				{
				}
				num = (short)1597898752;
				short num2 = num;
				num = (short)1724291415;
				short num3 = num;
				num = (short)1322555735;
				switch (num3 == num)
				{
				}
				num = (short)1008664576;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.UIValue;
			}
			set
			{
				short num = (short)585744061;
				short num2 = num;
				num = (short)1873788605;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1092419584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1504051201;
				if (num != 0)
				{
				}
				num = (short)83099648;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsername_A9169.UIValue = value;
			}
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x060042DF RID: 17119 RVA: 0x003E6678 File Offset: 0x003E4878
		// (set) Token: 0x060042E0 RID: 17120 RVA: 0x003E672C File Offset: 0x003E492C
		public bool RadWideUserInformationandPasswordsSoftIDUsername_A9169_Applicable
		{
			get
			{
				short num = (short)199181612;
				short num2 = num;
				num = (short)2133804332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)511049728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1663041537;
				if (num != 0)
				{
				}
				num = (short)1446772736;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Applicable;
			}
			set
			{
				short num = (short)947847169;
				if (num != 0)
				{
				}
				num = (short)420610048;
				short num2 = num;
				num = (short)1472776250;
				short num3 = num;
				num = (short)320522298;
				switch (num3 == num)
				{
				}
				num = (short)329318400;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Applicable = value;
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x060042E1 RID: 17121 RVA: 0x003E67E0 File Offset: 0x003E49E0
		// (set) Token: 0x060042E2 RID: 17122 RVA: 0x003E6894 File Offset: 0x003E4A94
		public bool RadWideUserInformationandPasswordsSoftIDUsername_A9169_Valid
		{
			get
			{
				short num = (short)972891334;
				short num2 = num;
				num = (short)605562054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1912864768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)22675457;
				if (num != 0)
				{
				}
				num = (short)1062862848;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Valid;
			}
			set
			{
				short num = (short)793085450;
				short num2 = num;
				num = (short)895321610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2044395520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432748033;
				if (num != 0)
				{
				}
				num = (short)654245888;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Valid = value;
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x003E694C File Offset: 0x003E4B4C
		// (set) Token: 0x060042E4 RID: 17124 RVA: 0x003E6A00 File Offset: 0x003E4C00
		public bool RadWideUserInformationandPasswordsSoftIDUsername_A9169_Visible
		{
			get
			{
				short num = (short)428285935;
				short num2 = num;
				num = (short)2015633391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)599326720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1870200833;
				if (num != 0)
				{
				}
				num = (short)980811776;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Visible;
			}
			set
			{
				short num = (short)278078562;
				short num2 = num;
				num = (short)667952226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)70189056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1837039616;
				if (num != 0)
				{
				}
				num = (short)1251147777;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Visible = value;
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x003E6AB8 File Offset: 0x003E4CB8
		// (set) Token: 0x060042E6 RID: 17126 RVA: 0x003E6B70 File Offset: 0x003E4D70
		public bool RadWideUserInformationandPasswordsSoftIDUsername_A9169_Editable
		{
			get
			{
				short num = (short)85917697;
				if (num != 0)
				{
				}
				num = (short)765984768;
				short num2 = num;
				num = (short)2131048851;
				short num3 = num;
				num = (short)1847343507;
				switch (num3 == num)
				{
				}
				num = (short)947519488;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Editable;
			}
			set
			{
				short num = (short)1289962211;
				short num2 = num;
				num = (short)1461732067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)125960192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1571422209;
				if (num != 0)
				{
				}
				num = (short)257622016;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsername_A9169.Editable = value;
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x003E6C24 File Offset: 0x003E4E24
		internal string RadWideUserInformationandPasswordsSoftIDUsername_A9169_UILabel
		{
			get
			{
				short num = (short)65011713;
				if (num != 0)
				{
				}
				num = (short)2129788928;
				short num2 = num;
				num = (short)169305486;
				short num3 = num;
				num = (short)1439458702;
				switch (num3 == num)
				{
				}
				num = (short)1084162048;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.UIName;
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x060042E8 RID: 17128 RVA: 0x003E6CDC File Offset: 0x003E4EDC
		// (set) Token: 0x060042E9 RID: 17129 RVA: 0x003E6D90 File Offset: 0x003E4F90
		internal bool RadWideUserInformationandPasswordsSoftIDUsername_A9169_HiddenStatic
		{
			get
			{
				short num = (short)904166157;
				short num2 = num;
				num = (short)847805197;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1908408320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)871956481;
				if (num != 0)
				{
				}
				num = (short)1136590848;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.HiddenStatic;
			}
			set
			{
				short num = (short)1668326894;
				short num2 = num;
				num = (short)660121070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1890320384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)646512640;
				if (num != 0)
				{
				}
				num = (short)831389697;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsername_A9169.HiddenStatic = value;
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x003E6E48 File Offset: 0x003E5048
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x003E6F00 File Offset: 0x003E5100
		internal bool RadWideUserInformationandPasswordsSoftIDUsername_A9169_HiddenDynamic
		{
			get
			{
				short num = (short)969292964;
				short num2 = num;
				num = (short)686898340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)899547136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)658374657;
				if (num != 0)
				{
				}
				num = (short)364445696;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169.HiddenDynamic;
			}
			set
			{
				short num = (short)514909483;
				short num2 = num;
				num = (short)156362027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)972881920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1094189057;
				if (num != 0)
				{
				}
				num = (short)415891456;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsername_A9169.HiddenDynamic = value;
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x003E6FB4 File Offset: 0x003E51B4
		public bool RadWideUserInformationandPasswordsSoftIDUsername_A9169_HasDiffs
		{
			get
			{
				short num = (short)1208019314;
				short num2 = num;
				num = (short)1094838642;
				switch (num2 == num)
				{
				default:
				{
					num = (short)713818112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1939144705;
				if (num != 0)
				{
				}
				num = (short)1356464128;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsername_A9169._HasDiffs;
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x060042ED RID: 17133 RVA: 0x003E7068 File Offset: 0x003E5268
		// (set) Token: 0x060042EE RID: 17134 RVA: 0x003E711C File Offset: 0x003E531C
		public string RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395Value
		{
			get
			{
				short num = (short)1178215236;
				short num2 = num;
				num = (short)990847812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1213333504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1432879105;
				if (num != 0)
				{
				}
				num = (short)1916600320;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Value;
			}
			set
			{
				short num = (short)2055199712;
				short num2 = num;
				num = (short)1432214496;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1039728640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)45154304;
				if (num != 0)
				{
				}
				num = (short)652148737;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Value = value;
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x060042EF RID: 17135 RVA: 0x003E71D4 File Offset: 0x003E53D4
		public global::AcpBusinessLayer.AcpField<string> RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395
		{
			get
			{
				short num = (short)871759873;
				if (num != 0)
				{
				}
				num = (short)104136704;
				short num2 = num;
				num = (short)470144404;
				short num3 = num;
				num = (short)404149652;
				switch (num3 == num)
				{
				}
				num = (short)234029056;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395;
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x003E7280 File Offset: 0x003E5480
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x003E7334 File Offset: 0x003E5534
		public string RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_UIValue
		{
			get
			{
				short num = (short)99188832;
				short num2 = num;
				num = (short)971276384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1954414592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)589430785;
				if (num != 0)
				{
				}
				num = (short)1578827776;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Value;
			}
			set
			{
				short num = (short)1371334769;
				short num2 = num;
				num = (short)1452664945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)853671936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706360833;
				if (num != 0)
				{
				}
				num = (short)887029760;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Value = value;
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x003E73EC File Offset: 0x003E55EC
		// (set) Token: 0x060042F3 RID: 17139 RVA: 0x003E74A4 File Offset: 0x003E56A4
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_Applicable
		{
			get
			{
				short num = (short)244974508;
				short num2 = num;
				num = (short)1280836524;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1460011008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)746455041;
				if (num != 0)
				{
				}
				num = (short)1912537088;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Applicable;
			}
			set
			{
				short num = (short)1976117910;
				short num2 = num;
				num = (short)1600662166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)897974272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2009268225;
				if (num != 0)
				{
				}
				num = (short)769261568;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Applicable = value;
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x003E7558 File Offset: 0x003E5758
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x003E760C File Offset: 0x003E580C
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_Valid
		{
			get
			{
				short num = (short)1566778627;
				short num2 = num;
				num = (short)1330652419;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364445696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1157955584;
				if (num != 0)
				{
				}
				num = (short)1491206145;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Valid;
			}
			set
			{
				short num = (short)1529544705;
				if (num != 0)
				{
				}
				num = (short)832307200;
				short num2 = num;
				num = (short)953374781;
				short num3 = num;
				num = (short)46159933;
				switch (num3 == num)
				{
				}
				num = (short)2025521152;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Valid = value;
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x003E76C4 File Offset: 0x003E58C4
		// (set) Token: 0x060042F7 RID: 17143 RVA: 0x003E7778 File Offset: 0x003E5978
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_Visible
		{
			get
			{
				short num = (short)697147628;
				short num2 = num;
				num = (short)65446124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1177026560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1373110272;
				if (num != 0)
				{
				}
				num = (short)2063859713;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Visible;
			}
			set
			{
				short num = (short)610542810;
				short num2 = num;
				num = (short)1182868698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)971571200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1725628417;
				if (num != 0)
				{
				}
				num = (short)25493504;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Visible = value;
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x003E782C File Offset: 0x003E5A2C
		// (set) Token: 0x060042F9 RID: 17145 RVA: 0x003E78E0 File Offset: 0x003E5AE0
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_Editable
		{
			get
			{
				short num = (short)961567853;
				short num2 = num;
				num = (short)731405421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1883635712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)249626625;
				if (num != 0)
				{
				}
				num = (short)284229632;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Editable;
			}
			set
			{
				short num = (short)1697126373;
				short num2 = num;
				num = (short)1947211749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1502150656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1541341184;
				if (num != 0)
				{
				}
				num = (short)2024341505;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.Editable = value;
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x003E7998 File Offset: 0x003E5B98
		internal string RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_UILabel
		{
			get
			{
				short num = (short)1517617153;
				if (num != 0)
				{
				}
				num = (short)1430326632;
				short num2 = num;
				num = (short)356126056;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1157103616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975503360;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.UIName;
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x003E7A4C File Offset: 0x003E5C4C
		// (set) Token: 0x060042FC RID: 17148 RVA: 0x003E7B00 File Offset: 0x003E5D00
		internal bool RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_HiddenStatic
		{
			get
			{
				short num = (short)483470846;
				short num2 = num;
				num = (short)134360574;
				switch (num2 == num)
				{
				}
				num = (short)918880256;
				short num3 = num;
				num = (short)1733427201;
				if (num != 0)
				{
				}
				num = (short)1303183360;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.HiddenStatic;
			}
			set
			{
				short num = (short)1520607948;
				short num2 = num;
				num = (short)1636999884;
				switch (num2 == num)
				{
				}
				num = (short)903806976;
				short num3 = num;
				num = (short)1161625601;
				if (num != 0)
				{
				}
				num = (short)185663488;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.HiddenStatic = value;
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x060042FD RID: 17149 RVA: 0x003E7BB8 File Offset: 0x003E5DB8
		// (set) Token: 0x060042FE RID: 17150 RVA: 0x003E7C6C File Offset: 0x003E5E6C
		internal bool RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_HiddenDynamic
		{
			get
			{
				short num = (short)2017802966;
				short num2 = num;
				num = (short)626670294;
				switch (num2 == num)
				{
				}
				num = (short)1854865408;
				short num3 = num;
				num = (short)259194881;
				if (num != 0)
				{
				}
				num = (short)668467200;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.HiddenDynamic;
			}
			set
			{
				short num = (short)1243072568;
				short num2 = num;
				num = (short)1604175928;
				switch (num2 == num)
				{
				}
				num = (short)2051866624;
				short num3 = num;
				num = (short)530513920;
				if (num != 0)
				{
				}
				num = (short)713687041;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.HiddenDynamic = value;
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x003E7D24 File Offset: 0x003E5F24
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395_HasDiffs
		{
			get
			{
				short num = (short)1322693109;
				short num2 = num;
				num = (short)139309557;
				switch (num2 == num)
				{
				}
				num = (short)1975451648;
				short num3 = num;
				num = (short)591200256;
				if (num != 0)
				{
				}
				num = (short)1960378369;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395._HasDiffs;
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x003E7DD8 File Offset: 0x003E5FD8
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x003E7E90 File Offset: 0x003E6090
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405Value
		{
			get
			{
				short num = (short)1672019969;
				if (num != 0)
				{
				}
				num = (short)955330811;
				short num2 = num;
				num = (short)1783443707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1661272064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1688403968;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value;
			}
			set
			{
				short num = (short)617086977;
				if (num != 0)
				{
				}
				num = (short)1115809048;
				short num2 = num;
				num = (short)1105454360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448724992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)565706752;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value = value;
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x003E7F48 File Offset: 0x003E6148
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405
		{
			get
			{
				short num = (short)914983063;
				short num2 = num;
				num = (short)391874711;
				switch (num2 == num)
				{
				}
				num = (short)1701183488;
				short num3 = num;
				num = (short)1111752705;
				if (num != 0)
				{
				}
				num = (short)555155456;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405;
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x003E7FFC File Offset: 0x003E61FC
		// (set) Token: 0x06004304 RID: 17156 RVA: 0x003E80B4 File Offset: 0x003E62B4
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_UIValue
		{
			get
			{
				short num = (short)100459506;
				short num2 = num;
				num = (short)162325490;
				switch (num2 == num)
				{
				}
				num = (short)504365056;
				short num3 = num;
				num = (short)72744960;
				if (num != 0)
				{
				}
				num = (short)1051066369;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value;
			}
			set
			{
				short num = (short)17023900;
				short num2 = num;
				num = (short)1910293404;
				switch (num2 == num)
				{
				}
				num = (short)2005598208;
				short num3 = num;
				num = (short)1688600576;
				if (num != 0)
				{
				}
				num = (short)1390608385;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value = value;
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x003E816C File Offset: 0x003E636C
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x003E8220 File Offset: 0x003E6420
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_Applicable
		{
			get
			{
				short num = (short)35586049;
				if (num != 0)
				{
				}
				num = (short)438782159;
				short num2 = num;
				num = (short)2043234511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2094923776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1297940480;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Applicable;
			}
			set
			{
				short num = (short)1736774099;
				short num2 = num;
				num = (short)1194987987;
				switch (num2 == num)
				{
				}
				num = (short)859832320;
				short num3 = num;
				num = (short)2016935937;
				if (num != 0)
				{
				}
				num = (short)978124800;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Applicable = value;
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x003E82D8 File Offset: 0x003E64D8
		// (set) Token: 0x06004308 RID: 17160 RVA: 0x003E838C File Offset: 0x003E658C
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_Valid
		{
			get
			{
				short num = (short)1818113250;
				short num2 = num;
				num = (short)870986978;
				switch (num2 == num)
				{
				}
				num = (short)41287680;
				short num3 = num;
				num = (short)603389953;
				if (num != 0)
				{
				}
				num = (short)1144782848;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Valid;
			}
			set
			{
				short num = (short)514654209;
				if (num != 0)
				{
				}
				num = (short)1790709730;
				short num2 = num;
				num = (short)290852834;
				switch (num2 == num)
				{
				default:
				{
					num = (short)187826176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2013986816;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Valid = value;
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x06004309 RID: 17161 RVA: 0x003E8444 File Offset: 0x003E6644
		// (set) Token: 0x0600430A RID: 17162 RVA: 0x003E84F8 File Offset: 0x003E66F8
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_Visible
		{
			get
			{
				short num = (short)254796650;
				short num2 = num;
				num = (short)1188356970;
				switch (num2 == num)
				{
				}
				num = (short)1282539520;
				short num3 = num;
				num = (short)1533411329;
				if (num != 0)
				{
				}
				num = (short)1894449152;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Visible;
			}
			set
			{
				short num = (short)1613351203;
				short num2 = num;
				num = (short)1758644515;
				switch (num2 == num)
				{
				}
				num = (short)1238433792;
				short num3 = num;
				num = (short)1575419904;
				if (num != 0)
				{
				}
				num = (short)1798438913;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Visible = value;
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x003E85AC File Offset: 0x003E67AC
		// (set) Token: 0x0600430C RID: 17164 RVA: 0x003E8660 File Offset: 0x003E6860
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_Editable
		{
			get
			{
				short num = (short)659184898;
				short num2 = num;
				num = (short)1199856898;
				switch (num2 == num)
				{
				}
				num = (short)801374208;
				short num3 = num;
				num = (short)1071906816;
				if (num != 0)
				{
				}
				num = (short)73728001;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Editable;
			}
			set
			{
				short num = (short)1659929898;
				short num2 = num;
				num = (short)747668778;
				switch (num2 == num)
				{
				}
				num = (short)173867008;
				short num3 = num;
				num = (short)305332225;
				if (num != 0)
				{
				}
				num = (short)2015756288;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Editable = value;
			}
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x003E8718 File Offset: 0x003E6918
		internal string RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_UILabel
		{
			get
			{
				short num = (short)1683446499;
				short num2 = num;
				num = (short)1555716835;
				switch (num2 == num)
				{
				}
				num = (short)704053248;
				short num3 = num;
				num = (short)303169537;
				if (num != 0)
				{
				}
				num = (short)834076672;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.UIName;
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x003E87CC File Offset: 0x003E69CC
		// (set) Token: 0x0600430F RID: 17167 RVA: 0x003E8884 File Offset: 0x003E6A84
		internal bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_HiddenStatic
		{
			get
			{
				short num = (short)1924218496;
				short num2 = num;
				num = (short)1211973248;
				switch (num2 == num)
				{
				}
				num = (short)894238720;
				short num3 = num;
				num = (short)1692729345;
				if (num != 0)
				{
				}
				num = (short)1627521024;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.HiddenStatic;
			}
			set
			{
				short num = (short)722305630;
				short num2 = num;
				num = (short)1145078366;
				switch (num2 == num)
				{
				}
				num = (short)47906816;
				short num3 = num;
				num = (short)707592192;
				if (num != 0)
				{
				}
				num = (short)513081345;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.HiddenStatic = value;
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x003E8938 File Offset: 0x003E6B38
		// (set) Token: 0x06004311 RID: 17169 RVA: 0x003E89EC File Offset: 0x003E6BEC
		internal bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_HiddenDynamic
		{
			get
			{
				short num = (short)2023346032;
				short num2 = num;
				num = (short)479055728;
				switch (num2 == num)
				{
				}
				num = (short)2127364096;
				short num3 = num;
				num = (short)40828929;
				if (num != 0)
				{
				}
				num = (short)1344602112;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.HiddenDynamic;
			}
			set
			{
				short num = (short)1704722433;
				if (num != 0)
				{
				}
				num = (short)40608211;
				short num2 = num;
				num = (short)1395171795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2076573696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)25559040;
				if (num != 0)
				{
				}
				this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.HiddenDynamic = value;
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x003E8AA0 File Offset: 0x003E6CA0
		public bool RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405_HasDiffs
		{
			get
			{
				short num = (short)1110310913;
				if (num != 0)
				{
				}
				num = (short)1196323701;
				short num2 = num;
				num = (short)1006400373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)911409152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1810563072;
				if (num != 0)
				{
				}
				return this.radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405._HasDiffs;
			}
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x06004313 RID: 17171 RVA: 0x003E8B58 File Offset: 0x003E6D58
		// (set) Token: 0x06004314 RID: 17172 RVA: 0x003E8C0C File Offset: 0x003E6E0C
		public int RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453Value
		{
			get
			{
				short num = (short)891899695;
				short num2 = num;
				num = (short)1386696495;
				switch (num2 == num)
				{
				}
				num = (short)918618112;
				short num3 = num;
				num = (short)2092236801;
				if (num != 0)
				{
				}
				num = (short)2082603008;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Value;
			}
			set
			{
				short num = (short)1905300906;
				short num2 = num;
				num = (short)126260650;
				switch (num2 == num)
				{
				}
				num = (short)767426560;
				short num3 = num;
				num = (short)2087976961;
				if (num != 0)
				{
				}
				num = (short)1512243200;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Value = value;
			}
		}

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x06004315 RID: 17173 RVA: 0x003E8CC0 File Offset: 0x003E6EC0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453
		{
			get
			{
				short num = (short)1194038311;
				short num2 = num;
				num = (short)657364007;
				switch (num2 == num)
				{
				}
				num = (short)1821573120;
				short num3 = num;
				num = (short)168689664;
				if (num != 0)
				{
				}
				num = (short)1709113345;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;
			}
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x003E8D74 File Offset: 0x003E6F74
		// (set) Token: 0x06004317 RID: 17175 RVA: 0x003E8E28 File Offset: 0x003E7028
		public string RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_UIValue
		{
			get
			{
				short num = (short)1958551592;
				short num2 = num;
				num = (short)870391848;
				switch (num2 == num)
				{
				}
				num = (short)286720000;
				short num3 = num;
				num = (short)1097531393;
				if (num != 0)
				{
				}
				num = (short)539099136;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.UIValue;
			}
			set
			{
				short num = (short)1203961857;
				if (num != 0)
				{
				}
				num = (short)1373401085;
				short num2 = num;
				num = (short)1292660733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1058406400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1206714368;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.UIValue = value;
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x003E8EE0 File Offset: 0x003E70E0
		// (set) Token: 0x06004319 RID: 17177 RVA: 0x003E8F94 File Offset: 0x003E7194
		internal int RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453Min
		{
			get
			{
				short num = (short)1790936026;
				short num2 = num;
				num = (short)1328055258;
				switch (num2 == num)
				{
				}
				num = (short)1468334080;
				short num3 = num;
				num = (short)710606849;
				if (num != 0)
				{
				}
				num = (short)339607552;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Min;
			}
			set
			{
				short num = (short)1647665456;
				short num2 = num;
				num = (short)1120952624;
				switch (num2 == num)
				{
				}
				num = (short)932511744;
				short num3 = num;
				num = (short)235601921;
				if (num != 0)
				{
				}
				num = (short)1832255488;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Min = value;
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x003E9048 File Offset: 0x003E7248
		// (set) Token: 0x0600431B RID: 17179 RVA: 0x003E90FC File Offset: 0x003E72FC
		internal int RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453Max
		{
			get
			{
				short num = (short)1648018305;
				short num2 = num;
				num = (short)1017889665;
				switch (num2 == num)
				{
				}
				num = (short)1971519488;
				short num3 = num;
				num = (short)1035665408;
				if (num != 0)
				{
				}
				num = (short)2037121025;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Max;
			}
			set
			{
				short num = (short)918817917;
				short num2 = num;
				num = (short)773131389;
				switch (num2 == num)
				{
				}
				num = (short)2019360768;
				short num3 = num;
				num = (short)1216937985;
				if (num != 0)
				{
				}
				num = (short)449708032;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Max = value;
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x003E91B4 File Offset: 0x003E73B4
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x003E9268 File Offset: 0x003E7468
		internal int RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453Step
		{
			get
			{
				short num = (short)6695978;
				short num2 = num;
				num = (short)599075882;
				switch (num2 == num)
				{
				}
				num = (short)1614741504;
				short num3 = num;
				num = (short)1873215488;
				if (num != 0)
				{
				}
				num = (short)1055260673;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.StepSize;
			}
			set
			{
				short num = (short)1100027109;
				short num2 = num;
				num = (short)1184765157;
				switch (num2 == num)
				{
				}
				num = (short)1501560832;
				short num3 = num;
				num = (short)1776418816;
				if (num != 0)
				{
				}
				num = (short)1954217985;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.StepSize = value;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x003E9320 File Offset: 0x003E7520
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x003E93D4 File Offset: 0x003E75D4
		public bool RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_Applicable
		{
			get
			{
				short num = (short)255705794;
				short num2 = num;
				num = (short)1675346626;
				switch (num2 == num)
				{
				}
				num = (short)998703104;
				short num3 = num;
				num = (short)1066795009;
				if (num != 0)
				{
				}
				num = (short)416743424;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Applicable;
			}
			set
			{
				short num = (short)455098422;
				short num2 = num;
				num = (short)1138376758;
				switch (num2 == num)
				{
				}
				num = (short)625672192;
				short num3 = num;
				num = (short)471859200;
				if (num != 0)
				{
				}
				num = (short)460455937;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Applicable = value;
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x003E9488 File Offset: 0x003E7688
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x003E953C File Offset: 0x003E773C
		public bool RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_Valid
		{
			get
			{
				short num = (short)1514536961;
				if (num != 0)
				{
				}
				num = (short)1530584502;
				short num2 = num;
				num = (short)175300022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835204608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1551630336;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Valid;
			}
			set
			{
				short num = (short)1692371631;
				short num2 = num;
				num = (short)1148488367;
				switch (num2 == num)
				{
				}
				num = (short)1381564416;
				short num3 = num;
				num = (short)1211498497;
				if (num != 0)
				{
				}
				num = (short)928907264;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Valid = value;
			}
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x003E95F4 File Offset: 0x003E77F4
		// (set) Token: 0x06004323 RID: 17187 RVA: 0x003E96AC File Offset: 0x003E78AC
		public bool RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_Visible
		{
			get
			{
				short num = (short)1070183471;
				short num2 = num;
				num = (short)1890038831;
				switch (num2 == num)
				{
				}
				num = (short)65273856;
				short num3 = num;
				num = (short)968884225;
				if (num != 0)
				{
				}
				num = (short)889978880;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Visible;
			}
			set
			{
				short num = (short)446497882;
				short num2 = num;
				num = (short)1972241498;
				switch (num2 == num)
				{
				}
				num = (short)1689387008;
				short num3 = num;
				num = (short)283705345;
				if (num != 0)
				{
				}
				num = (short)1413742592;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Visible = value;
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x003E9760 File Offset: 0x003E7960
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x003E9814 File Offset: 0x003E7A14
		public bool RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_Editable
		{
			get
			{
				short num = (short)541432492;
				short num2 = num;
				num = (short)1640405676;
				switch (num2 == num)
				{
				}
				num = (short)329777152;
				short num3 = num;
				num = (short)951844864;
				if (num != 0)
				{
				}
				num = (short)1581449217;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Editable;
			}
			set
			{
				short num = (short)1017116654;
				short num2 = num;
				num = (short)160298990;
				switch (num2 == num)
				{
				}
				num = (short)1795883008;
				short num3 = num;
				num = (short)2016411648;
				if (num != 0)
				{
				}
				num = (short)808124417;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Editable = value;
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x003E98C8 File Offset: 0x003E7AC8
		internal string RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_UILabel
		{
			get
			{
				short num = (short)1883574776;
				short num2 = num;
				num = (short)136385016;
				switch (num2 == num)
				{
				}
				num = (short)575995904;
				short num3 = num;
				num = (short)527106049;
				if (num != 0)
				{
				}
				num = (short)787152896;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.UIName;
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x06004327 RID: 17191 RVA: 0x003E9980 File Offset: 0x003E7B80
		// (set) Token: 0x06004328 RID: 17192 RVA: 0x003E9A30 File Offset: 0x003E7C30
		internal bool RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_HiddenStatic
		{
			get
			{
				short num = (short)274282385;
				short num2 = num;
				num = (short)118830993;
				switch (num2 == num)
				{
				}
				num = (short)1321467904;
				short num3 = num;
				num = (short)2140602369;
				if (num != 0)
				{
				}
				num = (short)1180434432;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.HiddenStatic;
			}
			set
			{
				short num = (short)1154995869;
				short num2 = num;
				num = (short)1835194013;
				switch (num2 == num)
				{
				}
				num = (short)253034496;
				short num3 = num;
				num = (short)662044673;
				if (num != 0)
				{
				}
				num = (short)1228406784;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.HiddenStatic = value;
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06004329 RID: 17193 RVA: 0x003E9AE4 File Offset: 0x003E7CE4
		// (set) Token: 0x0600432A RID: 17194 RVA: 0x003E9B98 File Offset: 0x003E7D98
		internal bool RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_HiddenDynamic
		{
			get
			{
				short num = (short)1661325002;
				short num2 = num;
				num = (short)2023935690;
				switch (num2 == num)
				{
				}
				num = (short)1140654080;
				short num3 = num;
				num = (short)662437888;
				if (num != 0)
				{
				}
				num = (short)1371406337;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.HiddenDynamic;
			}
			set
			{
				short num = (short)715791028;
				short num2 = num;
				num = (short)391584436;
				switch (num2 == num)
				{
				}
				num = (short)1509883904;
				short num3 = num;
				num = (short)335216641;
				if (num != 0)
				{
				}
				num = (short)15007744;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.HiddenDynamic = value;
			}
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x0600432B RID: 17195 RVA: 0x003E9C4C File Offset: 0x003E7E4C
		public bool RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453_HasDiffs
		{
			get
			{
				short num = (short)1356349849;
				short num2 = num;
				num = (short)395002265;
				switch (num2 == num)
				{
				}
				num = (short)1026490368;
				short num3 = num;
				num = (short)67502081;
				if (num != 0)
				{
				}
				num = (short)1864499200;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453._HasDiffs;
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x003E9D00 File Offset: 0x003E7F00
		// (set) Token: 0x0600432D RID: 17197 RVA: 0x003E9DB0 File Offset: 0x003E7FB0
		public bool RadWideUserinfoPassRequiredForGunlock_A36531Value
		{
			get
			{
				short num = (short)1462275865;
				short num2 = num;
				num = (short)764448537;
				switch (num2 == num)
				{
				}
				num = (short)96403456;
				short num3 = num;
				num = (short)1980694529;
				if (num != 0)
				{
				}
				num = (short)1246822400;
				if (num != 0)
				{
				}
				return this.radWideUserinfoPassRequiredForGunlock_A36531.Value;
			}
			set
			{
				short num = (short)784155626;
				short num2 = num;
				num = (short)1946960874;
				switch (num2 == num)
				{
				}
				num = (short)783417344;
				short num3 = num;
				num = (short)119865344;
				if (num != 0)
				{
				}
				num = (short)348258305;
				if (num != 0)
				{
				}
				this.radWideUserinfoPassRequiredForGunlock_A36531.Value = value;
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x003E9E68 File Offset: 0x003E8068
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserinfoPassRequiredForGunlock_A36531
		{
			get
			{
				short num = (short)2037292975;
				short num2 = num;
				num = (short)1366073263;
				switch (num2 == num)
				{
				}
				num = (short)1486553088;
				short num3 = num;
				num = (short)1702428672;
				if (num != 0)
				{
				}
				num = (short)1460338689;
				if (num != 0)
				{
				}
				return this.radWideUserinfoPassRequiredForGunlock_A36531;
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x0600432F RID: 17199 RVA: 0x003E9F1C File Offset: 0x003E811C
		// (set) Token: 0x06004330 RID: 17200 RVA: 0x003E9FD0 File Offset: 0x003E81D0
		public bool RadWideUserinfoPassRequiredForGunlock_A36531_UIValue
		{
			get
			{
				short num = (short)311099785;
				short num2 = num;
				num = (short)1600323977;
				switch (num2 == num)
				{
				}
				num = (short)1821442048;
				short num3 = num;
				num = (short)2083192833;
				if (num != 0)
				{
				}
				num = (short)431816704;
				if (num != 0)
				{
				}
				return this.radWideUserinfoPassRequiredForGunlock_A36531.Value;
			}
			set
			{
				short num = (short)748804452;
				short num2 = num;
				num = (short)1287248228;
				switch (num2 == num)
				{
				}
				num = (short)1794899969;
				if (num != 0)
				{
				}
				num = (short)581369856;
				if (num != 0)
				{
				}
				num = (short)230359040;
				short num3 = num;
				this.radWideUserinfoPassRequiredForGunlock_A36531.Value = value;
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x003EA084 File Offset: 0x003E8284
		// (set) Token: 0x06004332 RID: 17202 RVA: 0x003EA138 File Offset: 0x003E8338
		public bool RadWideUserinfoPassRequiredForGunlock_A36531_Applicable
		{
			get
			{
				short num = (short)2099743498;
				short num2 = num;
				num = (short)1329892106;
				switch (num2 == num)
				{
				}
				num = (short)1699741697;
				if (num != 0)
				{
				}
				num = (short)1453326336;
				if (num != 0)
				{
				}
				num = (short)1796472832;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForGunlock_A36531.Applicable;
			}
			set
			{
				short num = (short)824729229;
				short num2 = num;
				num = (short)239951501;
				switch (num2 == num)
				{
				}
				num = (short)69009409;
				if (num != 0)
				{
				}
				num = (short)136708096;
				if (num != 0)
				{
				}
				num = (short)1095630848;
				short num3 = num;
				this.radWideUserinfoPassRequiredForGunlock_A36531.Applicable = value;
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x003EA1E8 File Offset: 0x003E83E8
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x003EA29C File Offset: 0x003E849C
		public bool RadWideUserinfoPassRequiredForGunlock_A36531_Valid
		{
			get
			{
				short num = (short)235143417;
				short num2 = num;
				num = (short)1148780793;
				switch (num2 == num)
				{
				}
				num = (short)1680015361;
				if (num != 0)
				{
				}
				num = (short)45809664;
				if (num != 0)
				{
				}
				num = (short)1907949568;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForGunlock_A36531.Valid;
			}
			set
			{
				short num = (short)1892271969;
				short num2 = num;
				num = (short)2126104417;
				switch (num2 == num)
				{
				}
				num = (short)38600705;
				if (num != 0)
				{
				}
				num = (short)1384054784;
				if (num != 0)
				{
				}
				num = (short)1799946240;
				short num3 = num;
				this.radWideUserinfoPassRequiredForGunlock_A36531.Valid = value;
			}
		}

		// Token: 0x17002279 RID: 8825
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x003EA350 File Offset: 0x003E8550
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x003EA404 File Offset: 0x003E8604
		public bool RadWideUserinfoPassRequiredForGunlock_A36531_Visible
		{
			get
			{
				short num = (short)609057033;
				short num2 = num;
				num = (short)402618633;
				switch (num2 == num)
				{
				}
				num = (short)1870135297;
				if (num != 0)
				{
				}
				num = (short)2037776384;
				if (num != 0)
				{
				}
				num = (short)57409536;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForGunlock_A36531.Visible;
			}
			set
			{
				short num = (short)1464474698;
				short num2 = num;
				num = (short)579345482;
				switch (num2 == num)
				{
				}
				num = (short)1475543041;
				if (num != 0)
				{
				}
				num = (short)404094976;
				if (num != 0)
				{
				}
				num = (short)894369792;
				short num3 = num;
				this.radWideUserinfoPassRequiredForGunlock_A36531.Visible = value;
			}
		}

		// Token: 0x1700227A RID: 8826
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x003EA4BC File Offset: 0x003E86BC
		// (set) Token: 0x06004338 RID: 17208 RVA: 0x003EA570 File Offset: 0x003E8770
		public bool RadWideUserinfoPassRequiredForGunlock_A36531_Editable
		{
			get
			{
				short num = (short)583860225;
				if (num != 0)
				{
				}
				num = (short)1906547924;
				short num2 = num;
				num = (short)208837844;
				switch (num2 == num)
				{
				}
				num = (short)359399424;
				if (num != 0)
				{
				}
				num = (short)829751296;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForGunlock_A36531.Editable;
			}
			set
			{
				short num = (short)1383318767;
				short num2 = num;
				num = (short)703448303;
				switch (num2 == num)
				{
				}
				num = (short)1593311233;
				if (num != 0)
				{
				}
				num = (short)2076770304;
				if (num != 0)
				{
				}
				num = (short)731709440;
				short num3 = num;
				this.radWideUserinfoPassRequiredForGunlock_A36531.Editable = value;
			}
		}

		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x003EA628 File Offset: 0x003E8828
		internal string RadWideUserinfoPassRequiredForGunlock_A36531_UILabel
		{
			get
			{
				short num = (short)275650713;
				short num2 = num;
				num = (short)1371674777;
				switch (num2 == num)
				{
				}
				num = (short)895418369;
				if (num != 0)
				{
				}
				num = (short)1387724800;
				if (num != 0)
				{
				}
				num = (short)1400307712;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForGunlock_A36531.UIName;
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x0600433A RID: 17210 RVA: 0x003EA6DC File Offset: 0x003E88DC
		// (set) Token: 0x0600433B RID: 17211 RVA: 0x003EA790 File Offset: 0x003E8990
		internal bool RadWideUserinfoPassRequiredForGunlock_A36531_HiddenStatic
		{
			get
			{
				short num = (short)1907187736;
				short num2 = num;
				num = (short)2093375512;
				switch (num2 == num)
				{
				}
				num = (short)1861615617;
				if (num != 0)
				{
				}
				num = (short)395378688;
				if (num != 0)
				{
				}
				num = (short)1887240192;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForGunlock_A36531.HiddenStatic;
			}
			set
			{
				short num = (short)360735340;
				short num2 = num;
				num = (short)1972068972;
				switch (num2 == num)
				{
				}
				num = (short)1126498305;
				if (num != 0)
				{
				}
				num = (short)1497825280;
				if (num != 0)
				{
				}
				num = (short)1212678144;
				short num3 = num;
				this.radWideUserinfoPassRequiredForGunlock_A36531.HiddenStatic = value;
			}
		}

		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x0600433C RID: 17212 RVA: 0x003EA848 File Offset: 0x003E8A48
		// (set) Token: 0x0600433D RID: 17213 RVA: 0x003EA8FC File Offset: 0x003E8AFC
		internal bool RadWideUserinfoPassRequiredForGunlock_A36531_HiddenDynamic
		{
			get
			{
				short num = (short)356615501;
				short num2 = num;
				num = (short)405374285;
				switch (num2 == num)
				{
				}
				num = (short)1607925761;
				if (num != 0)
				{
				}
				num = (short)1419706368;
				if (num != 0)
				{
				}
				num = (short)824639488;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForGunlock_A36531.HiddenDynamic;
			}
			set
			{
				short num = (short)586022913;
				if (num != 0)
				{
				}
				num = (short)2015298902;
				short num2 = num;
				num = (short)1627260246;
				switch (num2 == num)
				{
				}
				num = (short)1237319680;
				if (num != 0)
				{
				}
				num = (short)2096955392;
				short num3 = num;
				this.radWideUserinfoPassRequiredForGunlock_A36531.HiddenDynamic = value;
			}
		}

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x003EA9B0 File Offset: 0x003E8BB0
		public bool RadWideUserinfoPassRequiredForGunlock_A36531_HasDiffs
		{
			get
			{
				short num = (short)557582519;
				short num2 = num;
				num = (short)740755639;
				switch (num2 == num)
				{
				}
				num = (short)1726545921;
				if (num != 0)
				{
				}
				num = (short)1813381120;
				if (num != 0)
				{
				}
				num = (short)2085224448;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForGunlock_A36531._HasDiffs;
			}
		}

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x003EAA64 File Offset: 0x003E8C64
		// (set) Token: 0x06004340 RID: 17216 RVA: 0x003EAB18 File Offset: 0x003E8D18
		public bool RadWideUserinfoPassRequiredForLightbar_A36532Value
		{
			get
			{
				short num = (short)1045102593;
				if (num != 0)
				{
				}
				num = (short)1588132604;
				short num2 = num;
				num = (short)1726020348;
				switch (num2 == num)
				{
				}
				num = (short)587595776;
				if (num != 0)
				{
				}
				num = (short)679411712;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.Value;
			}
			set
			{
				short num = (short)718610600;
				short num2 = num;
				num = (short)1547509928;
				switch (num2 == num)
				{
				}
				num = (short)1067253760;
				if (num != 0)
				{
				}
				num = (short)511770625;
				if (num != 0)
				{
				}
				num = (short)2012610560;
				short num3 = num;
				this.radWideUserinfoPassRequiredForLightbar_A36532.Value = value;
			}
		}

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06004341 RID: 17217 RVA: 0x003EABD0 File Offset: 0x003E8DD0
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserinfoPassRequiredForLightbar_A36532
		{
			get
			{
				short num = (short)411303937;
				if (num != 0)
				{
				}
				num = (short)1027705068;
				short num2 = num;
				num = (short)1582074092;
				switch (num2 == num)
				{
				}
				num = (short)1836122112;
				if (num != 0)
				{
				}
				num = (short)379650048;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532;
			}
		}

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x06004342 RID: 17218 RVA: 0x003EAC84 File Offset: 0x003E8E84
		// (set) Token: 0x06004343 RID: 17219 RVA: 0x003EAD38 File Offset: 0x003E8F38
		public bool RadWideUserinfoPassRequiredForLightbar_A36532_UIValue
		{
			get
			{
				short num = (short)898662219;
				short num2 = num;
				num = (short)1453227851;
				switch (num2 == num)
				{
				}
				num = (short)419954688;
				if (num != 0)
				{
				}
				num = (short)979566593;
				if (num != 0)
				{
				}
				num = (short)298647552;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.Value;
			}
			set
			{
				short num = (short)745405051;
				short num2 = num;
				num = (short)1669659259;
				switch (num2 == num)
				{
				}
				num = (short)462094336;
				if (num != 0)
				{
				}
				num = (short)2000093185;
				if (num != 0)
				{
				}
				num = (short)2099445760;
				short num3 = num;
				this.radWideUserinfoPassRequiredForLightbar_A36532.Value = value;
			}
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x003EADEC File Offset: 0x003E8FEC
		// (set) Token: 0x06004345 RID: 17221 RVA: 0x003EAEA4 File Offset: 0x003E90A4
		public bool RadWideUserinfoPassRequiredForLightbar_A36532_Applicable
		{
			get
			{
				short num = (short)1322428084;
				short num2 = num;
				num = (short)338601652;
				switch (num2 == num)
				{
				}
				num = (short)860094464;
				if (num != 0)
				{
				}
				num = (short)1044447233;
				if (num != 0)
				{
				}
				num = (short)1869545472;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.Applicable;
			}
			set
			{
				short num = (short)186318849;
				if (num != 0)
				{
				}
				num = (short)1504983590;
				short num2 = num;
				num = (short)1653684774;
				switch (num2 == num)
				{
				}
				num = (short)923729920;
				if (num != 0)
				{
				}
				num = (short)1540816896;
				short num3 = num;
				this.radWideUserinfoPassRequiredForLightbar_A36532.Applicable = value;
			}
		}

		// Token: 0x17002283 RID: 8835
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x003EAF5C File Offset: 0x003E915C
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x003EB010 File Offset: 0x003E9210
		public bool RadWideUserinfoPassRequiredForLightbar_A36532_Valid
		{
			get
			{
				short num = (short)1927872513;
				if (num != 0)
				{
				}
				num = (short)590014385;
				short num2 = num;
				num = (short)1143465905;
				switch (num2 == num)
				{
				}
				num = (short)1333002240;
				if (num != 0)
				{
				}
				num = (short)1796866048;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.Valid;
			}
			set
			{
				short num = (short)1682757506;
				short num2 = num;
				num = (short)798021506;
				switch (num2 == num)
				{
				}
				num = (short)1124073473;
				if (num != 0)
				{
				}
				num = (short)139132928;
				if (num != 0)
				{
				}
				num = (short)219414528;
				short num3 = num;
				this.radWideUserinfoPassRequiredForLightbar_A36532.Valid = value;
			}
		}

		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x003EB0C4 File Offset: 0x003E92C4
		// (set) Token: 0x06004349 RID: 17225 RVA: 0x003EB178 File Offset: 0x003E9378
		public bool RadWideUserinfoPassRequiredForLightbar_A36532_Visible
		{
			get
			{
				short num = (short)1610321882;
				short num2 = num;
				num = (short)244092890;
				switch (num2 == num)
				{
				}
				num = (short)1356791808;
				if (num != 0)
				{
				}
				num = (short)688848897;
				if (num != 0)
				{
				}
				num = (short)1596260352;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.Visible;
			}
			set
			{
				short num = (short)975387620;
				short num2 = num;
				num = (short)1550138340;
				switch (num2 == num)
				{
				}
				num = (short)731512833;
				if (num != 0)
				{
				}
				num = (short)1606156288;
				if (num != 0)
				{
				}
				num = (short)1781334016;
				short num3 = num;
				this.radWideUserinfoPassRequiredForLightbar_A36532.Visible = value;
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x003EB22C File Offset: 0x003E942C
		// (set) Token: 0x0600434B RID: 17227 RVA: 0x003EB2E4 File Offset: 0x003E94E4
		public bool RadWideUserinfoPassRequiredForLightbar_A36532_Editable
		{
			get
			{
				short num = (short)1392343186;
				short num2 = num;
				num = (short)688093330;
				switch (num2 == num)
				{
				}
				num = (short)133431297;
				if (num != 0)
				{
				}
				num = (short)1059520512;
				if (num != 0)
				{
				}
				num = (short)586481664;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.Editable;
			}
			set
			{
				short num = (short)1200932576;
				short num2 = num;
				num = (short)505792224;
				switch (num2 == num)
				{
				}
				num = (short)1589575681;
				if (num != 0)
				{
				}
				num = (short)838270976;
				if (num != 0)
				{
				}
				num = (short)111738880;
				short num3 = num;
				this.radWideUserinfoPassRequiredForLightbar_A36532.Editable = value;
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x003EB398 File Offset: 0x003E9598
		internal string RadWideUserinfoPassRequiredForLightbar_A36532_UILabel
		{
			get
			{
				short num = (short)1708226931;
				short num2 = num;
				num = (short)1326152051;
				switch (num2 == num)
				{
				}
				num = (short)230490113;
				if (num != 0)
				{
				}
				num = (short)290783232;
				if (num != 0)
				{
				}
				num = (short)769720320;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.UIName;
			}
		}

		// Token: 0x17002287 RID: 8839
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x003EB450 File Offset: 0x003E9650
		// (set) Token: 0x0600434E RID: 17230 RVA: 0x003EB504 File Offset: 0x003E9704
		internal bool RadWideUserinfoPassRequiredForLightbar_A36532_HiddenStatic
		{
			get
			{
				short num = (short)1754652303;
				short num2 = num;
				num = (short)1538186895;
				switch (num2 == num)
				{
				}
				num = (short)1841430528;
				if (num != 0)
				{
				}
				num = (short)1461649409;
				if (num != 0)
				{
				}
				num = (short)1762459648;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.HiddenStatic;
			}
			set
			{
				short num = (short)578019555;
				short num2 = num;
				num = (short)400154851;
				switch (num2 == num)
				{
				}
				num = (short)1661534208;
				if (num != 0)
				{
				}
				num = (short)1747320833;
				if (num != 0)
				{
				}
				num = (short)1110769664;
				short num3 = num;
				this.radWideUserinfoPassRequiredForLightbar_A36532.HiddenStatic = value;
			}
		}

		// Token: 0x17002288 RID: 8840
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x003EB5BC File Offset: 0x003E97BC
		// (set) Token: 0x06004350 RID: 17232 RVA: 0x003EB674 File Offset: 0x003E9874
		internal bool RadWideUserinfoPassRequiredForLightbar_A36532_HiddenDynamic
		{
			get
			{
				short num = (short)936656879;
				short num2 = num;
				num = (short)1269972975;
				switch (num2 == num)
				{
				}
				num = (short)2121728001;
				if (num != 0)
				{
				}
				num = (short)1925251072;
				if (num != 0)
				{
				}
				num = (short)1538916352;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532.HiddenDynamic;
			}
			set
			{
				short num = (short)1378271616;
				short num2 = num;
				num = (short)1668071808;
				switch (num2 == num)
				{
				}
				num = (short)1831862273;
				if (num != 0)
				{
				}
				num = (short)600768512;
				if (num != 0)
				{
				}
				num = (short)54263808;
				short num3 = num;
				this.radWideUserinfoPassRequiredForLightbar_A36532.HiddenDynamic = value;
			}
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x003EB72C File Offset: 0x003E992C
		public bool RadWideUserinfoPassRequiredForLightbar_A36532_HasDiffs
		{
			get
			{
				short num = (short)2051850743;
				short num2 = num;
				num = (short)1203945975;
				switch (num2 == num)
				{
				}
				num = (short)337903617;
				if (num != 0)
				{
				}
				num = (short)1712717824;
				if (num != 0)
				{
				}
				num = (short)1246232576;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForLightbar_A36532._HasDiffs;
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x003EB7E0 File Offset: 0x003E99E0
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x003EB894 File Offset: 0x003E9A94
		public bool RadWideUserinfoPassRequiredForSiren_A36533Value
		{
			get
			{
				short num = (short)2102342425;
				short num2 = num;
				num = (short)381760281;
				switch (num2 == num)
				{
				}
				num = (short)2038890496;
				if (num != 0)
				{
				}
				num = (short)1525088257;
				if (num != 0)
				{
				}
				num = (short)969211904;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.Value;
			}
			set
			{
				short num = (short)428056864;
				short num2 = num;
				num = (short)621846816;
				switch (num2 == num)
				{
				}
				num = (short)497614848;
				if (num != 0)
				{
				}
				num = (short)1078525953;
				if (num != 0)
				{
				}
				num = (short)888930304;
				short num3 = num;
				this.radWideUserinfoPassRequiredForSiren_A36533.Value = value;
			}
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x003EB948 File Offset: 0x003E9B48
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserinfoPassRequiredForSiren_A36533
		{
			get
			{
				short num = (short)572634711;
				short num2 = num;
				num = (short)450606679;
				switch (num2 == num)
				{
				}
				num = (short)1963524096;
				if (num != 0)
				{
				}
				num = (short)684982273;
				if (num != 0)
				{
				}
				num = (short)2093481984;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533;
			}
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x003EB9F8 File Offset: 0x003E9BF8
		// (set) Token: 0x06004356 RID: 17238 RVA: 0x003EBAB0 File Offset: 0x003E9CB0
		public bool RadWideUserinfoPassRequiredForSiren_A36533_UIValue
		{
			get
			{
				short num = (short)1889714633;
				short num2 = num;
				num = (short)1308082633;
				switch (num2 == num)
				{
				}
				num = (short)1338048512;
				if (num != 0)
				{
				}
				num = (short)1054670849;
				if (num != 0)
				{
				}
				num = (short)1758134272;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.Value;
			}
			set
			{
				short num = (short)554137813;
				short num2 = num;
				num = (short)378501333;
				switch (num2 == num)
				{
				}
				num = (short)1541537793;
				if (num != 0)
				{
				}
				num = (short)518782976;
				if (num != 0)
				{
				}
				num = (short)1425080320;
				short num3 = num;
				this.radWideUserinfoPassRequiredForSiren_A36533.Value = value;
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x003EBB64 File Offset: 0x003E9D64
		// (set) Token: 0x06004358 RID: 17240 RVA: 0x003EBC18 File Offset: 0x003E9E18
		public bool RadWideUserinfoPassRequiredForSiren_A36533_Applicable
		{
			get
			{
				short num = (short)1507550381;
				short num2 = num;
				num = (short)1883923629;
				switch (num2 == num)
				{
				}
				num = (short)1109000192;
				if (num != 0)
				{
				}
				num = (short)2067988481;
				if (num != 0)
				{
				}
				num = (short)487653376;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.Applicable;
			}
			set
			{
				short num = (short)2016149505;
				if (num != 0)
				{
				}
				num = (short)82341477;
				short num2 = num;
				num = (short)77295205;
				switch (num2 == num)
				{
				}
				num = (short)1781989376;
				if (num != 0)
				{
				}
				num = (short)172359680;
				short num3 = num;
				this.radWideUserinfoPassRequiredForSiren_A36533.Applicable = value;
			}
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x003EBCCC File Offset: 0x003E9ECC
		// (set) Token: 0x0600435A RID: 17242 RVA: 0x003EBD80 File Offset: 0x003E9F80
		public bool RadWideUserinfoPassRequiredForSiren_A36533_Valid
		{
			get
			{
				short num = (short)1480988507;
				short num2 = num;
				num = (short)234362715;
				switch (num2 == num)
				{
				}
				num = (short)1280835585;
				if (num != 0)
				{
				}
				num = (short)700317696;
				if (num != 0)
				{
				}
				num = (short)713949184;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.Valid;
			}
			set
			{
				short num = (short)1364606827;
				short num2 = num;
				num = (short)1290551147;
				switch (num2 == num)
				{
				}
				num = (short)508231680;
				if (num != 0)
				{
				}
				num = (short)1738342401;
				if (num != 0)
				{
				}
				num = (short)533331968;
				short num3 = num;
				this.radWideUserinfoPassRequiredForSiren_A36533.Valid = value;
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x003EBE34 File Offset: 0x003EA034
		// (set) Token: 0x0600435C RID: 17244 RVA: 0x003EBEE8 File Offset: 0x003EA0E8
		public bool RadWideUserinfoPassRequiredForSiren_A36533_Visible
		{
			get
			{
				short num = (short)543326739;
				short num2 = num;
				num = (short)456884755;
				switch (num2 == num)
				{
				}
				num = (short)606404609;
				if (num != 0)
				{
				}
				num = (short)515244032;
				if (num != 0)
				{
				}
				num = (short)369754112;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.Visible;
			}
			set
			{
				short num = (short)1083676629;
				short num2 = num;
				num = (short)917280725;
				switch (num2 == num)
				{
				}
				num = (short)57802753;
				if (num != 0)
				{
				}
				num = (short)1098907648;
				if (num != 0)
				{
				}
				num = (short)1870987264;
				short num3 = num;
				this.radWideUserinfoPassRequiredForSiren_A36533.Visible = value;
			}
		}

		// Token: 0x17002290 RID: 8848
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x003EBF9C File Offset: 0x003EA19C
		// (set) Token: 0x0600435E RID: 17246 RVA: 0x003EC050 File Offset: 0x003EA250
		public bool RadWideUserinfoPassRequiredForSiren_A36533_Editable
		{
			get
			{
				short num = (short)1488170892;
				short num2 = num;
				num = (short)1714007948;
				switch (num2 == num)
				{
				}
				num = (short)1412300801;
				if (num != 0)
				{
				}
				num = (short)1943535616;
				if (num != 0)
				{
				}
				num = (short)1339031552;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.Editable;
			}
			set
			{
				short num = (short)1693974529;
				if (num != 0)
				{
				}
				num = (short)362984004;
				short num2 = num;
				num = (short)2110370372;
				switch (num2 == num)
				{
				}
				num = (short)62586880;
				if (num != 0)
				{
				}
				num = (short)956956672;
				short num3 = num;
				this.radWideUserinfoPassRequiredForSiren_A36533.Editable = value;
			}
		}

		// Token: 0x17002291 RID: 8849
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x003EC108 File Offset: 0x003EA308
		internal string RadWideUserinfoPassRequiredForSiren_A36533_UILabel
		{
			get
			{
				short num = (short)1498140999;
				short num2 = num;
				num = (short)675402055;
				switch (num2 == num)
				{
				}
				num = (short)1950744577;
				if (num != 0)
				{
				}
				num = (short)1056768000;
				if (num != 0)
				{
				}
				num = (short)1683685376;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.UIName;
			}
		}

		// Token: 0x17002292 RID: 8850
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x003EC1B8 File Offset: 0x003EA3B8
		// (set) Token: 0x06004361 RID: 17249 RVA: 0x003EC26C File Offset: 0x003EA46C
		internal bool RadWideUserinfoPassRequiredForSiren_A36533_HiddenStatic
		{
			get
			{
				short num = (short)1503708690;
				short num2 = num;
				num = (short)764790290;
				switch (num2 == num)
				{
				}
				num = (short)1877016577;
				if (num != 0)
				{
				}
				num = (short)112656384;
				if (num != 0)
				{
				}
				num = (short)237502464;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.HiddenStatic;
			}
			set
			{
				short num = (short)827793335;
				short num2 = num;
				num = (short)426254263;
				switch (num2 == num)
				{
				}
				num = (short)828768257;
				if (num != 0)
				{
				}
				num = (short)1615200256;
				if (num != 0)
				{
				}
				num = (short)1301151744;
				short num3 = num;
				this.radWideUserinfoPassRequiredForSiren_A36533.HiddenStatic = value;
			}
		}

		// Token: 0x17002293 RID: 8851
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x003EC31C File Offset: 0x003EA51C
		// (set) Token: 0x06004363 RID: 17251 RVA: 0x003EC3D0 File Offset: 0x003EA5D0
		internal bool RadWideUserinfoPassRequiredForSiren_A36533_HiddenDynamic
		{
			get
			{
				short num = (short)1439834352;
				short num2 = num;
				num = (short)51650800;
				switch (num2 == num)
				{
				}
				num = (short)1132068864;
				if (num != 0)
				{
				}
				num = (short)771096577;
				if (num != 0)
				{
				}
				num = (short)591200256;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533.HiddenDynamic;
			}
			set
			{
				short num = (short)1796212269;
				short num2 = num;
				num = (short)1664222765;
				switch (num2 == num)
				{
				}
				num = (short)1438056449;
				if (num != 0)
				{
				}
				num = (short)1682767872;
				if (num != 0)
				{
				}
				num = (short)1660616704;
				short num3 = num;
				this.radWideUserinfoPassRequiredForSiren_A36533.HiddenDynamic = value;
			}
		}

		// Token: 0x17002294 RID: 8852
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x003EC484 File Offset: 0x003EA684
		public bool RadWideUserinfoPassRequiredForSiren_A36533_HasDiffs
		{
			get
			{
				short num = (short)154075137;
				if (num != 0)
				{
				}
				num = (short)1360184478;
				short num2 = num;
				num = (short)246072478;
				switch (num2 == num)
				{
				}
				num = (short)155058176;
				if (num != 0)
				{
				}
				num = (short)1678704640;
				short num3 = num;
				return this.radWideUserinfoPassRequiredForSiren_A36533._HasDiffs;
			}
		}

		// Token: 0x17002295 RID: 8853
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x003EC538 File Offset: 0x003EA738
		// (set) Token: 0x06004366 RID: 17254 RVA: 0x003EC5EC File Offset: 0x003EA7EC
		public string RadWideUserInformationandPasswordsUnlockPassword_A8690Value
		{
			get
			{
				short num = (short)1820786689;
				if (num != 0)
				{
				}
				num = (short)1378484224;
				short num2 = num;
				num = (short)1822532916;
				short num3 = num;
				num = (short)61580596;
				switch (num3 == num)
				{
				}
				num = (short)1953103872;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.Value;
			}
			set
			{
				short num = (short)533158613;
				short num2 = num;
				num = (short)1347967701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)857735168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1723465729;
				if (num != 0)
				{
				}
				num = (short)333840384;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsUnlockPassword_A8690.Value = value;
			}
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x003EC6A4 File Offset: 0x003EA8A4
		public global::AcpBusinessLayer.AcpField<string> RadWideUserInformationandPasswordsUnlockPassword_A8690
		{
			get
			{
				short num = (short)1734123326;
				short num2 = num;
				num = (short)331783998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1299644416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2133721089;
				if (num != 0)
				{
				}
				num = (short)35586048;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690;
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x003EC750 File Offset: 0x003EA950
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x003EC804 File Offset: 0x003EAA04
		public string RadWideUserInformationandPasswordsUnlockPassword_A8690_UIValue
		{
			get
			{
				short num = (short)268739417;
				short num2 = num;
				num = (short)1461691225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1228079104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)986054657;
				if (num != 0)
				{
				}
				num = (short)833617920;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.Value;
			}
			set
			{
				short num = (short)1886684938;
				short num2 = num;
				num = (short)1934460682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)141230080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16187393;
				if (num != 0)
				{
				}
				num = (short)1405747200;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsUnlockPassword_A8690.Value = value;
			}
		}

		// Token: 0x17002298 RID: 8856
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x003EC8BC File Offset: 0x003EAABC
		// (set) Token: 0x0600436B RID: 17259 RVA: 0x003EC970 File Offset: 0x003EAB70
		public bool RadWideUserInformationandPasswordsUnlockPassword_A8690_Applicable
		{
			get
			{
				short num = (short)1283551518;
				short num2 = num;
				num = (short)1516925214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2128543744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1303052288;
				if (num != 0)
				{
				}
				num = (short)1204813825;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.Applicable;
			}
			set
			{
				short num = (short)173443965;
				short num2 = num;
				num = (short)656444285;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712179712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1073676288;
				if (num != 0)
				{
				}
				num = (short)1384120321;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsUnlockPassword_A8690.Applicable = value;
			}
		}

		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x003ECA28 File Offset: 0x003EAC28
		// (set) Token: 0x0600436D RID: 17261 RVA: 0x003ECADC File Offset: 0x003EACDC
		public bool RadWideUserInformationandPasswordsUnlockPassword_A8690_Valid
		{
			get
			{
				short num = (short)902692982;
				short num2 = num;
				num = (short)1667891318;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1886126080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1577910273;
				if (num != 0)
				{
				}
				num = (short)1270284288;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.Valid;
			}
			set
			{
				short num = (short)184898921;
				short num2 = num;
				num = (short)556881257;
				switch (num2 == num)
				{
				default:
				{
					num = (short)681312256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1392246784;
				if (num != 0)
				{
				}
				num = (short)1461846017;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsUnlockPassword_A8690.Valid = value;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x003ECB90 File Offset: 0x003EAD90
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x003ECC44 File Offset: 0x003EAE44
		public bool RadWideUserInformationandPasswordsUnlockPassword_A8690_Visible
		{
			get
			{
				short num = (short)1632183136;
				short num2 = num;
				num = (short)1719608160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1668022272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1835925504;
				if (num != 0)
				{
				}
				num = (short)294584321;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.Visible;
			}
			set
			{
				short num = (short)965011039;
				short num2 = num;
				num = (short)1893787231;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1994129408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)64618497;
				if (num != 0)
				{
				}
				num = (short)780861440;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsUnlockPassword_A8690.Visible = value;
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x003ECCF8 File Offset: 0x003EAEF8
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x003ECDA8 File Offset: 0x003EAFA8
		public bool RadWideUserInformationandPasswordsUnlockPassword_A8690_Editable
		{
			get
			{
				short num = (short)99432374;
				short num2 = num;
				num = (short)1503737782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)222822400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)236912641;
				if (num != 0)
				{
				}
				num = (short)486146048;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.Editable;
			}
			set
			{
				short num = (short)1389568040;
				short num2 = num;
				num = (short)393158696;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1816395776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1544880128;
				if (num != 0)
				{
				}
				num = (short)922025985;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsUnlockPassword_A8690.Editable = value;
			}
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x003ECE5C File Offset: 0x003EB05C
		internal string RadWideUserInformationandPasswordsUnlockPassword_A8690_UILabel
		{
			get
			{
				short num = (short)1562222827;
				short num2 = num;
				num = (short)1716691179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)581828608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1633222657;
				if (num != 0)
				{
				}
				num = (short)1503789056;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.UIName;
			}
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06004373 RID: 17267 RVA: 0x003ECF14 File Offset: 0x003EB114
		// (set) Token: 0x06004374 RID: 17268 RVA: 0x003ECFC8 File Offset: 0x003EB1C8
		internal bool RadWideUserInformationandPasswordsUnlockPassword_A8690_HiddenStatic
		{
			get
			{
				short num = (short)297976661;
				short num2 = num;
				num = (short)476693333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486866944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1309868033;
				if (num != 0)
				{
				}
				num = (short)1098842112;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.HiddenStatic;
			}
			set
			{
				short num = (short)506265601;
				if (num != 0)
				{
				}
				num = (short)408027136;
				short num2 = num;
				num = (short)1127797308;
				short num3 = num;
				num = (short)434426428;
				switch (num3 == num)
				{
				}
				num = (short)1865613312;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsUnlockPassword_A8690.HiddenStatic = value;
			}
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06004375 RID: 17269 RVA: 0x003ED07C File Offset: 0x003EB27C
		// (set) Token: 0x06004376 RID: 17270 RVA: 0x003ED130 File Offset: 0x003EB330
		internal bool RadWideUserInformationandPasswordsUnlockPassword_A8690_HiddenDynamic
		{
			get
			{
				short num = (short)650405783;
				short num2 = num;
				num = (short)2030331799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)211484672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)668336128;
				if (num != 0)
				{
				}
				num = (short)512163841;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690.HiddenDynamic;
			}
			set
			{
				short num = (short)1825784997;
				short num2 = num;
				num = (short)292242597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1394606080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)491257857;
				if (num != 0)
				{
				}
				num = (short)921108480;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsUnlockPassword_A8690.HiddenDynamic = value;
			}
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x06004377 RID: 17271 RVA: 0x003ED1E8 File Offset: 0x003EB3E8
		public bool RadWideUserInformationandPasswordsUnlockPassword_A8690_HasDiffs
		{
			get
			{
				short num = (short)1014169601;
				if (num != 0)
				{
				}
				num = (short)2076770304;
				short num2 = num;
				num = (short)716136159;
				short num3 = num;
				num = (short)598695647;
				switch (num3 == num)
				{
				}
				num = (short)970260480;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsUnlockPassword_A8690._HasDiffs;
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x003ED2A0 File Offset: 0x003EB4A0
		// (set) Token: 0x06004379 RID: 17273 RVA: 0x003ED354 File Offset: 0x003EB554
		public bool RadWideUserInformationandPasswordsMandatoryPassword_A8461Value
		{
			get
			{
				short num = (short)1970606102;
				short num2 = num;
				num = (short)45158422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861929472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1738014720;
				if (num != 0)
				{
				}
				num = (short)604176385;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Value;
			}
			set
			{
				short num = (short)522584065;
				if (num != 0)
				{
				}
				num = (short)683278336;
				short num2 = num;
				num = (short)1025251998;
				short num3 = num;
				num = (short)293870238;
				switch (num3 == num)
				{
				}
				num = (short)1467219968;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Value = value;
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x003ED408 File Offset: 0x003EB608
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserInformationandPasswordsMandatoryPassword_A8461
		{
			get
			{
				short num = (short)575441941;
				short num2 = num;
				num = (short)1941933077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)275382272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1198129153;
				if (num != 0)
				{
				}
				num = (short)1448083456;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461;
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x003ED4B8 File Offset: 0x003EB6B8
		// (set) Token: 0x0600437C RID: 17276 RVA: 0x003ED56C File Offset: 0x003EB76C
		public bool RadWideUserInformationandPasswordsMandatoryPassword_A8461_UIValue
		{
			get
			{
				short num = (short)826052441;
				short num2 = num;
				num = (short)1204719449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1941897216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1849098241;
				if (num != 0)
				{
				}
				num = (short)1373569024;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Value;
			}
			set
			{
				short num = (short)2058878977;
				if (num != 0)
				{
				}
				num = (short)101777408;
				short num2 = num;
				num = (short)1720384186;
				short num3 = num;
				num = (short)1426586298;
				switch (num3 == num)
				{
				}
				num = (short)611254272;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Value = value;
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x003ED620 File Offset: 0x003EB820
		// (set) Token: 0x0600437E RID: 17278 RVA: 0x003ED6D4 File Offset: 0x003EB8D4
		public bool RadWideUserInformationandPasswordsMandatoryPassword_A8461_Applicable
		{
			get
			{
				short num = (short)170091933;
				short num2 = num;
				num = (short)688547229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722599936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)278069248;
				if (num != 0)
				{
				}
				num = (short)960167937;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Applicable;
			}
			set
			{
				short num = (short)715784193;
				if (num != 0)
				{
				}
				num = (short)1761738752;
				short num2 = num;
				num = (short)671563692;
				short num3 = num;
				num = (short)234176428;
				switch (num3 == num)
				{
				}
				num = (short)529596416;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Applicable = value;
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x0600437F RID: 17279 RVA: 0x003ED78C File Offset: 0x003EB98C
		// (set) Token: 0x06004380 RID: 17280 RVA: 0x003ED844 File Offset: 0x003EBA44
		public bool RadWideUserInformationandPasswordsMandatoryPassword_A8461_Valid
		{
			get
			{
				short num = (short)1587732558;
				short num2 = num;
				num = (short)326688846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)962658304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1151991809;
				if (num != 0)
				{
				}
				num = (short)841285632;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Valid;
			}
			set
			{
				short num = (short)1980729760;
				short num2 = num;
				num = (short)1745324448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1710882816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)974389249;
				if (num != 0)
				{
				}
				num = (short)1823539200;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Valid = value;
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06004381 RID: 17281 RVA: 0x003ED8FC File Offset: 0x003EBAFC
		// (set) Token: 0x06004382 RID: 17282 RVA: 0x003ED9B0 File Offset: 0x003EBBB0
		public bool RadWideUserInformationandPasswordsMandatoryPassword_A8461_Visible
		{
			get
			{
				short num = (short)797943626;
				short num2 = num;
				num = (short)200189770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)791019520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575340544;
				if (num != 0)
				{
				}
				num = (short)556204033;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Visible;
			}
			set
			{
				short num = (short)967311566;
				short num2 = num;
				num = (short)710607054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1322516480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1826684929;
				if (num != 0)
				{
				}
				num = (short)1556283392;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Visible = value;
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x003EDA64 File Offset: 0x003EBC64
		// (set) Token: 0x06004384 RID: 17284 RVA: 0x003EDB1C File Offset: 0x003EBD1C
		public bool RadWideUserInformationandPasswordsMandatoryPassword_A8461_Editable
		{
			get
			{
				short num = (short)557210044;
				short num2 = num;
				num = (short)958486972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1677656064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1470955520;
				if (num != 0)
				{
				}
				num = (short)2057240577;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Editable;
			}
			set
			{
				short num = (short)1340997633;
				if (num != 0)
				{
				}
				num = (short)1400700928;
				short num2 = num;
				num = (short)651935135;
				short num3 = num;
				num = (short)1059241375;
				switch (num3 == num)
				{
				}
				num = (short)1182007296;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMandatoryPassword_A8461.Editable = value;
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x003EDBD4 File Offset: 0x003EBDD4
		internal string RadWideUserInformationandPasswordsMandatoryPassword_A8461_UILabel
		{
			get
			{
				short num = (short)1495325365;
				short num2 = num;
				num = (short)1436736181;
				switch (num2 == num)
				{
				default:
				{
					num = (short)533594112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2091646976;
				if (num != 0)
				{
				}
				num = (short)71237633;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.UIName;
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x003EDC88 File Offset: 0x003EBE88
		// (set) Token: 0x06004387 RID: 17287 RVA: 0x003EDD40 File Offset: 0x003EBF40
		internal bool RadWideUserInformationandPasswordsMandatoryPassword_A8461_HiddenStatic
		{
			get
			{
				short num = (short)1951759185;
				short num2 = num;
				num = (short)1431534417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)906362880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)551944193;
				if (num != 0)
				{
				}
				num = (short)566558720;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.HiddenStatic;
			}
			set
			{
				short num = (short)1140457473;
				if (num != 0)
				{
				}
				num = (short)1229389824;
				short num2 = num;
				num = (short)1553407052;
				short num3 = num;
				num = (short)1582111820;
				switch (num3 == num)
				{
				}
				num = (short)1431437312;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMandatoryPassword_A8461.HiddenStatic = value;
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x003EDDF8 File Offset: 0x003EBFF8
		// (set) Token: 0x06004389 RID: 17289 RVA: 0x003EDEAC File Offset: 0x003EC0AC
		internal bool RadWideUserInformationandPasswordsMandatoryPassword_A8461_HiddenDynamic
		{
			get
			{
				short num = (short)2009425698;
				short num2 = num;
				num = (short)711616290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)501350400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)245956609;
				if (num != 0)
				{
				}
				num = (short)445120512;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461.HiddenDynamic;
			}
			set
			{
				short num = (short)1540199386;
				short num2 = num;
				num = (short)680367066;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156827648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)201129985;
				if (num != 0)
				{
				}
				num = (short)1085669376;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMandatoryPassword_A8461.HiddenDynamic = value;
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x003EDF60 File Offset: 0x003EC160
		public bool RadWideUserInformationandPasswordsMandatoryPassword_A8461_HasDiffs
		{
			get
			{
				short num = (short)2036268486;
				short num2 = num;
				num = (short)1287978438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363724800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)965869569;
				if (num != 0)
				{
				}
				num = (short)614465536;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMandatoryPassword_A8461._HasDiffs;
			}
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600438B RID: 17291 RVA: 0x003EE010 File Offset: 0x003EC210
		// (set) Token: 0x0600438C RID: 17292 RVA: 0x003EE0C4 File Offset: 0x003EC2C4
		public bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508Value
		{
			get
			{
				short num = (short)1971728205;
				short num2 = num;
				num = (short)1184509773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)300744704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)640024577;
				if (num != 0)
				{
				}
				num = (short)1076690944;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Value;
			}
			set
			{
				short num = (short)1514950827;
				short num2 = num;
				num = (short)1258311851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)840040448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)628097024;
				if (num != 0)
				{
				}
				num = (short)1009778689;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Value = value;
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x003EE178 File Offset: 0x003EC378
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508
		{
			get
			{
				short num = (short)2106387800;
				short num2 = num;
				num = (short)980217176;
				switch (num2 == num)
				{
				default:
				{
					num = (short)549126144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982188033;
				if (num != 0)
				{
				}
				num = (short)2001141760;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508;
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x003EE22C File Offset: 0x003EC42C
		// (set) Token: 0x0600438F RID: 17295 RVA: 0x003EE2E0 File Offset: 0x003EC4E0
		public bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_UIValue
		{
			get
			{
				short num = (short)2120508470;
				short num2 = num;
				num = (short)1418159158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1125515264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1484259329;
				if (num != 0)
				{
				}
				num = (short)378011648;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Value;
			}
			set
			{
				short num = (short)498997499;
				short num2 = num;
				num = (short)664803579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)143589376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1714225153;
				if (num != 0)
				{
				}
				num = (short)997326848;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Value = value;
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x003EE394 File Offset: 0x003EC594
		// (set) Token: 0x06004391 RID: 17297 RVA: 0x003EE44C File Offset: 0x003EC64C
		public bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_Applicable
		{
			get
			{
				short num = (short)1829044224;
				short num2 = num;
				num = (short)1785197562;
				short num3 = num;
				num = (short)1158083578;
				switch (num3 == num)
				{
				}
				num = (short)536150017;
				if (num != 0)
				{
				}
				num = (short)260964352;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Applicable;
			}
			set
			{
				short num = (short)256573440;
				short num2 = num;
				num = (short)2110937355;
				short num3 = num;
				num = (short)1524259083;
				switch (num3 == num)
				{
				}
				num = (short)1974730753;
				if (num != 0)
				{
				}
				num = (short)704118784;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Applicable = value;
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x003EE500 File Offset: 0x003EC700
		// (set) Token: 0x06004393 RID: 17299 RVA: 0x003EE5B4 File Offset: 0x003EC7B4
		public bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_Valid
		{
			get
			{
				short num = (short)897122304;
				short num2 = num;
				num = (short)16861788;
				short num3 = num;
				num = (short)496978524;
				switch (num3 == num)
				{
				}
				num = (short)1153499137;
				if (num != 0)
				{
				}
				num = (short)644808704;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Valid;
			}
			set
			{
				short num = (short)1449263104;
				short num2 = num;
				num = (short)258373549;
				short num3 = num;
				num = (short)2104981421;
				switch (num3 == num)
				{
				}
				num = (short)303628289;
				if (num != 0)
				{
				}
				num = (short)1436155904;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Valid = value;
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x003EE668 File Offset: 0x003EC868
		// (set) Token: 0x06004395 RID: 17301 RVA: 0x003EE71C File Offset: 0x003EC91C
		public bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_Visible
		{
			get
			{
				short num = (short)1336147968;
				short num2 = num;
				num = (short)1137708704;
				short num3 = num;
				num = (short)1223036576;
				switch (num3 == num)
				{
				}
				num = (short)294256641;
				if (num != 0)
				{
				}
				num = (short)1444151296;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Visible;
			}
			set
			{
				short num = (short)166920192;
				short num2 = num;
				num = (short)159248110;
				short num3 = num;
				num = (short)1893986030;
				switch (num3 == num)
				{
				}
				num = (short)2132475905;
				if (num != 0)
				{
				}
				num = (short)1902772224;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Visible = value;
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x003EE7D4 File Offset: 0x003EC9D4
		// (set) Token: 0x06004397 RID: 17303 RVA: 0x003EE88C File Offset: 0x003ECA8C
		public bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_Editable
		{
			get
			{
				short num = (short)336265216;
				short num2 = num;
				num = (short)1029111809;
				if (num != 0)
				{
				}
				num = (short)656670474;
				short num3 = num;
				num = (short)450428682;
				switch (num3 == num)
				{
				}
				num = (short)605880320;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Editable;
			}
			set
			{
				short num = (short)1939472384;
				short num2 = num;
				num = (short)130768506;
				short num3 = num;
				num = (short)569925242;
				switch (num3 == num)
				{
				}
				num = (short)2038956033;
				if (num != 0)
				{
				}
				num = (short)1245118464;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.Editable = value;
			}
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x003EE940 File Offset: 0x003ECB40
		internal string RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_UILabel
		{
			get
			{
				short num = (short)1769996288;
				short num2 = num;
				num = (short)1462960129;
				if (num != 0)
				{
				}
				num = (short)1531042577;
				short num3 = num;
				num = (short)959109905;
				switch (num3 == num)
				{
				}
				num = (short)736034816;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.UIName;
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06004399 RID: 17305 RVA: 0x003EE9F8 File Offset: 0x003ECBF8
		// (set) Token: 0x0600439A RID: 17306 RVA: 0x003EEAB0 File Offset: 0x003ECCB0
		internal bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_HiddenStatic
		{
			get
			{
				short num = (short)1218510848;
				short num2 = num;
				num = (short)20824593;
				short num3 = num;
				num = (short)1364050449;
				switch (num3 == num)
				{
				}
				num = (short)1755774976;
				if (num != 0)
				{
				}
				num = (short)1881800705;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.HiddenStatic;
			}
			set
			{
				short num = (short)486801408;
				short num2 = num;
				num = (short)1062860311;
				short num3 = num;
				num = (short)562361879;
				switch (num3 == num)
				{
				}
				num = (short)1463156737;
				if (num != 0)
				{
				}
				num = (short)1766129664;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.HiddenStatic = value;
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x0600439B RID: 17307 RVA: 0x003EEB64 File Offset: 0x003ECD64
		// (set) Token: 0x0600439C RID: 17308 RVA: 0x003EEC18 File Offset: 0x003ECE18
		internal bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_HiddenDynamic
		{
			get
			{
				short num = (short)50003968;
				short num2 = num;
				num = (short)1046413313;
				if (num != 0)
				{
				}
				num = (short)1027189247;
				short num3 = num;
				num = (short)1281665535;
				switch (num3 == num)
				{
				}
				num = (short)1012662272;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.HiddenDynamic;
			}
			set
			{
				short num = (short)934608896;
				short num2 = num;
				num = (short)389421342;
				short num3 = num;
				num = (short)687151390;
				switch (num3 == num)
				{
				}
				num = (short)179634177;
				if (num != 0)
				{
				}
				num = (short)560070656;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.HiddenDynamic = value;
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x0600439D RID: 17309 RVA: 0x003EECCC File Offset: 0x003ECECC
		public bool RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508_HasDiffs
		{
			get
			{
				short num = (short)867172352;
				short num2 = num;
				num = (short)1259654012;
				short num3 = num;
				num = (short)949930876;
				switch (num3 == num)
				{
				}
				num = (short)1049559041;
				if (num != 0)
				{
				}
				num = (short)2101346304;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508._HasDiffs;
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x0600439E RID: 17310 RVA: 0x003EED80 File Offset: 0x003ECF80
		// (set) Token: 0x0600439F RID: 17311 RVA: 0x003EEE34 File Offset: 0x003ED034
		public string RadWideUserInformationandPasswordsRadioAlias_A8829Value
		{
			get
			{
				short num = (short)1699545088;
				short num2 = num;
				num = (short)384607363;
				short num3 = num;
				num = (short)979936387;
				switch (num3 == num)
				{
				}
				num = (short)1341980673;
				if (num != 0)
				{
				}
				num = (short)233046016;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.Value;
			}
			set
			{
				short num = (short)1525088256;
				short num2 = num;
				num = (short)372522427;
				short num3 = num;
				num = (short)2077703611;
				switch (num3 == num)
				{
				}
				num = (short)1757937665;
				if (num != 0)
				{
				}
				num = (short)195428352;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAlias_A8829.Value = value;
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x060043A0 RID: 17312 RVA: 0x003EEEEC File Offset: 0x003ED0EC
		public global::AcpBusinessLayer.AcpField<string> RadWideUserInformationandPasswordsRadioAlias_A8829
		{
			get
			{
				short num = (short)36110336;
				short num2 = num;
				num = (short)1979467614;
				short num3 = num;
				num = (short)591546206;
				switch (num3 == num)
				{
				}
				num = (short)65667073;
				if (num != 0)
				{
				}
				num = (short)1319043072;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829;
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x060043A1 RID: 17313 RVA: 0x003EEF98 File Offset: 0x003ED198
		// (set) Token: 0x060043A2 RID: 17314 RVA: 0x003EF04C File Offset: 0x003ED24C
		public string RadWideUserInformationandPasswordsRadioAlias_A8829_UIValue
		{
			get
			{
				short num = (short)355467264;
				short num2 = num;
				num = (short)256807119;
				short num3 = num;
				num = (short)82022607;
				switch (num3 == num)
				{
				}
				num = (short)1794310145;
				if (num != 0)
				{
				}
				num = (short)205127680;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.Value;
			}
			set
			{
				short num = (short)1556611072;
				short num2 = num;
				num = (short)1697317341;
				short num3 = num;
				num = (short)1521877469;
				switch (num3 == num)
				{
				}
				num = (short)1764884481;
				if (num != 0)
				{
				}
				num = (short)1811283968;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAlias_A8829.Value = value;
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x003EF100 File Offset: 0x003ED300
		// (set) Token: 0x060043A4 RID: 17316 RVA: 0x003EF1B4 File Offset: 0x003ED3B4
		public bool RadWideUserInformationandPasswordsRadioAlias_A8829_Applicable
		{
			get
			{
				short num = (short)569573376;
				short num2 = num;
				num = (short)1835686188;
				short num3 = num;
				num = (short)163993900;
				switch (num3 == num)
				{
				}
				num = (short)659423233;
				if (num != 0)
				{
				}
				num = (short)151388160;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.Applicable;
			}
			set
			{
				short num = (short)1902641152;
				short num2 = num;
				num = (short)1435063451;
				short num3 = num;
				num = (short)741495963;
				switch (num3 == num)
				{
				}
				num = (short)173277185;
				if (num != 0)
				{
				}
				num = (short)1558773760;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAlias_A8829.Applicable = value;
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x003EF268 File Offset: 0x003ED468
		// (set) Token: 0x060043A6 RID: 17318 RVA: 0x003EF31C File Offset: 0x003ED51C
		public bool RadWideUserInformationandPasswordsRadioAlias_A8829_Valid
		{
			get
			{
				short num = (short)1748041728;
				short num2 = num;
				num = (short)2042153380;
				short num3 = num;
				num = (short)1856358820;
				switch (num3 == num)
				{
				}
				num = (short)1731067904;
				if (num != 0)
				{
				}
				num = (short)1239482369;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.Valid;
			}
			set
			{
				short num = (short)1730215936;
				short num2 = num;
				num = (short)704522432;
				short num3 = num;
				num = (short)1697065152;
				switch (num3 == num)
				{
				}
				num = (short)348520449;
				if (num != 0)
				{
				}
				num = (short)358547456;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAlias_A8829.Valid = value;
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x003EF3D0 File Offset: 0x003ED5D0
		// (set) Token: 0x060043A8 RID: 17320 RVA: 0x003EF484 File Offset: 0x003ED684
		public bool RadWideUserInformationandPasswordsRadioAlias_A8829_Visible
		{
			get
			{
				short num = (short)1818230784;
				short num2 = num;
				num = (short)1849187584;
				short num3 = num;
				num = (short)134241536;
				switch (num3 == num)
				{
				}
				num = (short)2005598208;
				if (num != 0)
				{
				}
				num = (short)153747457;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.Visible;
			}
			set
			{
				short num = (short)567869440;
				short num2 = num;
				num = (short)532980951;
				short num3 = num;
				num = (short)1850385623;
				switch (num3 == num)
				{
				}
				num = (short)108068865;
				if (num != 0)
				{
				}
				num = (short)98828288;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAlias_A8829.Visible = value;
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x003EF53C File Offset: 0x003ED73C
		// (set) Token: 0x060043AA RID: 17322 RVA: 0x003EF5F0 File Offset: 0x003ED7F0
		public bool RadWideUserInformationandPasswordsRadioAlias_A8829_Editable
		{
			get
			{
				short num = (short)63242240;
				short num2 = num;
				num = (short)1430095007;
				short num3 = num;
				num = (short)1987413151;
				switch (num3 == num)
				{
				}
				num = (short)1991049217;
				if (num != 0)
				{
				}
				num = (short)2115436544;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.Editable;
			}
			set
			{
				short num = (short)328204288;
				short num2 = num;
				num = (short)444357682;
				short num3 = num;
				num = (short)1994611762;
				switch (num3 == num)
				{
				}
				num = (short)236257281;
				if (num != 0)
				{
				}
				num = (short)1030946816;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAlias_A8829.Editable = value;
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x003EF6A4 File Offset: 0x003ED8A4
		internal string RadWideUserInformationandPasswordsRadioAlias_A8829_UILabel
		{
			get
			{
				short num = (short)436994048;
				short num2 = num;
				num = (short)1951022689;
				short num3 = num;
				num = (short)1832468065;
				switch (num3 == num)
				{
				}
				num = (short)291176449;
				if (num != 0)
				{
				}
				num = (short)1100414976;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.UIName;
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x060043AC RID: 17324 RVA: 0x003EF758 File Offset: 0x003ED958
		// (set) Token: 0x060043AD RID: 17325 RVA: 0x003EF80C File Offset: 0x003EDA0C
		internal bool RadWideUserInformationandPasswordsRadioAlias_A8829_HiddenStatic
		{
			get
			{
				short num = (short)1141964800;
				short num2 = num;
				num = (short)1195993552;
				short num3 = num;
				num = (short)1255893456;
				switch (num3 == num)
				{
				}
				num = (short)765984769;
				if (num != 0)
				{
				}
				num = (short)1756561408;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.HiddenStatic;
			}
			set
			{
				short num = (short)878182400;
				short num2 = num;
				num = (short)1921979736;
				short num3 = num;
				num = (short)2100172120;
				switch (num3 == num)
				{
				}
				num = (short)1434517505;
				if (num != 0)
				{
				}
				num = (short)828506112;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAlias_A8829.HiddenStatic = value;
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x060043AE RID: 17326 RVA: 0x003EF8C4 File Offset: 0x003EDAC4
		// (set) Token: 0x060043AF RID: 17327 RVA: 0x003EF978 File Offset: 0x003EDB78
		internal bool RadWideUserInformationandPasswordsRadioAlias_A8829_HiddenDynamic
		{
			get
			{
				short num = (short)1917321216;
				short num2 = num;
				num = (short)2022506497;
				if (num != 0)
				{
				}
				num = (short)509546036;
				short num3 = num;
				num = (short)517475892;
				switch (num3 == num)
				{
				}
				num = (short)2018705408;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829.HiddenDynamic;
			}
			set
			{
				short num = (short)545652736;
				short num2 = num;
				num = (short)943465150;
				short num3 = num;
				num = (short)2142905022;
				switch (num3 == num)
				{
				}
				num = (short)1467744257;
				if (num != 0)
				{
				}
				num = (short)665321472;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioAlias_A8829.HiddenDynamic = value;
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x003EFA2C File Offset: 0x003EDC2C
		public bool RadWideUserInformationandPasswordsRadioAlias_A8829_HasDiffs
		{
			get
			{
				short num = (short)1173553152;
				short num2 = num;
				num = (short)1895282280;
				short num3 = num;
				num = (short)1146795624;
				switch (num3 == num)
				{
				}
				num = (short)1393426433;
				if (num != 0)
				{
				}
				num = (short)685572096;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioAlias_A8829._HasDiffs;
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x060043B1 RID: 17329 RVA: 0x003EFAE0 File Offset: 0x003EDCE0
		// (set) Token: 0x060043B2 RID: 17330 RVA: 0x003EFB94 File Offset: 0x003EDD94
		public int RadWideUserInformationandPasswordsMaximumPasswordLength_A8477Value
		{
			get
			{
				short num = (short)2008612864;
				short num2 = num;
				num = (short)945189658;
				short num3 = num;
				num = (short)1665037082;
				switch (num3 == num)
				{
				}
				num = (short)1381695489;
				if (num != 0)
				{
				}
				num = (short)35979264;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Value;
			}
			set
			{
				short num = (short)1502478336;
				short num2 = num;
				num = (short)730110814;
				short num3 = num;
				num = (short)706452318;
				switch (num3 == num)
				{
				}
				num = (short)1328152577;
				if (num != 0)
				{
				}
				num = (short)81920000;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Value = value;
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x003EFC48 File Offset: 0x003EDE48
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideUserInformationandPasswordsMaximumPasswordLength_A8477
		{
			get
			{
				short num = (short)1572601856;
				short num2 = num;
				num = (short)847028655;
				short num3 = num;
				num = (short)1683726767;
				switch (num3 == num)
				{
				}
				num = (short)693239808;
				if (num != 0)
				{
				}
				num = (short)1886191617;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477;
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x003EFCF8 File Offset: 0x003EDEF8
		// (set) Token: 0x060043B5 RID: 17333 RVA: 0x003EFDB0 File Offset: 0x003EDFB0
		public string RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_UIValue
		{
			get
			{
				short num = (short)1330905088;
				short num2 = num;
				num = (short)1920401409;
				if (num != 0)
				{
				}
				num = (short)40442689;
				short num3 = num;
				num = (short)625220417;
				switch (num3 == num)
				{
				}
				num = (short)1186070528;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.UIValue;
			}
			set
			{
				short num = (short)498335744;
				short num2 = num;
				num = (short)1708312575;
				short num3 = num;
				num = (short)768854015;
				switch (num3 == num)
				{
				}
				num = (short)98238465;
				if (num != 0)
				{
				}
				num = (short)606208000;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.UIValue = value;
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x060043B6 RID: 17334 RVA: 0x003EFE64 File Offset: 0x003EE064
		// (set) Token: 0x060043B7 RID: 17335 RVA: 0x003EFF18 File Offset: 0x003EE118
		internal int RadWideUserInformationandPasswordsMaximumPasswordLength_A8477Min
		{
			get
			{
				short num = (short)1733165056;
				short num2 = num;
				num = (short)1574556078;
				short num3 = num;
				num = (short)422760878;
				switch (num3 == num)
				{
				}
				num = (short)1420623872;
				if (num != 0)
				{
				}
				num = (short)1987772417;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Min;
			}
			set
			{
				short num = (short)2009530368;
				short num2 = num;
				num = (short)1100939265;
				if (num != 0)
				{
				}
				num = (short)713267889;
				short num3 = num;
				num = (short)1189452465;
				switch (num3 == num)
				{
				}
				num = (short)2122711040;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Min = value;
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x003EFFCC File Offset: 0x003EE1CC
		// (set) Token: 0x060043B9 RID: 17337 RVA: 0x003F0080 File Offset: 0x003EE280
		internal int RadWideUserInformationandPasswordsMaximumPasswordLength_A8477Max
		{
			get
			{
				short num = (short)438632448;
				short num2 = num;
				num = (short)795125824;
				short num3 = num;
				num = (short)1637722176;
				switch (num3 == num)
				{
				}
				num = (short)211025920;
				if (num != 0)
				{
				}
				num = (short)337707009;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Max;
			}
			set
			{
				short num = (short)612302848;
				short num2 = num;
				num = (short)545980417;
				if (num != 0)
				{
				}
				num = (short)1863033427;
				short num3 = num;
				num = (short)1073324627;
				switch (num3 == num)
				{
				}
				num = (short)426704896;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Max = value;
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x060043BA RID: 17338 RVA: 0x003F0134 File Offset: 0x003EE334
		// (set) Token: 0x060043BB RID: 17339 RVA: 0x003F01E8 File Offset: 0x003EE3E8
		internal int RadWideUserInformationandPasswordsMaximumPasswordLength_A8477Step
		{
			get
			{
				short num = (short)617152512;
				short num2 = num;
				num = (short)2080603818;
				short num3 = num;
				num = (short)729841322;
				switch (num3 == num)
				{
				}
				num = (short)25952256;
				if (num != 0)
				{
				}
				num = (short)1258029057;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.StepSize;
			}
			set
			{
				short num = (short)2090795008;
				short num2 = num;
				num = (short)1173027725;
				short num3 = num;
				num = (short)403700621;
				switch (num3 == num)
				{
				}
				num = (short)1415905281;
				if (num != 0)
				{
				}
				num = (short)1232011264;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.StepSize = value;
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x060043BC RID: 17340 RVA: 0x003F029C File Offset: 0x003EE49C
		// (set) Token: 0x060043BD RID: 17341 RVA: 0x003F0354 File Offset: 0x003EE554
		public bool RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_Applicable
		{
			get
			{
				short num = (short)138674176;
				short num2 = num;
				num = (short)1005380766;
				short num3 = num;
				num = (short)431875230;
				switch (num3 == num)
				{
				}
				num = (short)961150977;
				if (num != 0)
				{
				}
				num = (short)1580859392;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Applicable;
			}
			set
			{
				short num = (short)568852480;
				short num2 = num;
				num = (short)31379793;
				short num3 = num;
				num = (short)762433873;
				switch (num3 == num)
				{
				}
				num = (short)2072838145;
				if (num != 0)
				{
				}
				num = (short)885850112;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Applicable = value;
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x003F040C File Offset: 0x003EE60C
		// (set) Token: 0x060043BF RID: 17343 RVA: 0x003F04C0 File Offset: 0x003EE6C0
		public bool RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_Valid
		{
			get
			{
				short num = (short)701104128;
				short num2 = num;
				num = (short)853213997;
				short num3 = num;
				num = (short)830604077;
				switch (num3 == num)
				{
				}
				num = (short)1756889089;
				if (num != 0)
				{
				}
				num = (short)1330053120;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Valid;
			}
			set
			{
				short num = (short)966787072;
				short num2 = num;
				num = (short)445815718;
				short num3 = num;
				num = (short)1307679654;
				switch (num3 == num)
				{
				}
				num = (short)1495728128;
				if (num != 0)
				{
				}
				num = (short)1370488833;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Valid = value;
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x060043C0 RID: 17344 RVA: 0x003F0578 File Offset: 0x003EE778
		// (set) Token: 0x060043C1 RID: 17345 RVA: 0x003F062C File Offset: 0x003EE82C
		public bool RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_Visible
		{
			get
			{
				short num = (short)530513920;
				short num2 = num;
				num = (short)1724706647;
				short num3 = num;
				num = (short)301789015;
				switch (num3 == num)
				{
				}
				num = (short)396558337;
				if (num != 0)
				{
				}
				num = (short)592052224;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Visible;
			}
			set
			{
				short num = (short)460455936;
				short num2 = num;
				num = (short)685424651;
				short num3 = num;
				num = (short)1590542347;
				switch (num3 == num)
				{
				}
				num = (short)822607873;
				if (num != 0)
				{
				}
				num = (short)1406861312;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Visible = value;
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x003F06E0 File Offset: 0x003EE8E0
		// (set) Token: 0x060043C3 RID: 17347 RVA: 0x003F0798 File Offset: 0x003EE998
		public bool RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_Editable
		{
			get
			{
				short num = (short)1967390720;
				short num2 = num;
				num = (short)1232529390;
				short num3 = num;
				num = (short)1799940078;
				switch (num3 == num)
				{
				}
				num = (short)1821638657;
				if (num != 0)
				{
				}
				num = (short)216399872;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Editable;
			}
			set
			{
				short num = (short)1556414464;
				short num2 = num;
				num = (short)169983963;
				short num3 = num;
				num = (short)502644699;
				switch (num3 == num)
				{
				}
				num = (short)2065956865;
				if (num != 0)
				{
				}
				num = (short)1692401664;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.Editable = value;
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x003F084C File Offset: 0x003EEA4C
		internal string RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_UILabel
		{
			get
			{
				short num = (short)673775616;
				short num2 = num;
				num = (short)11075585;
				if (num != 0)
				{
				}
				num = (short)1286663035;
				short num3 = num;
				num = (short)1931668347;
				switch (num3 == num)
				{
				}
				num = (short)1722875904;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.UIName;
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x003F0900 File Offset: 0x003EEB00
		// (set) Token: 0x060043C6 RID: 17350 RVA: 0x003F09B8 File Offset: 0x003EEBB8
		internal bool RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_HiddenStatic
		{
			get
			{
				short num = (short)567279616;
				short num2 = num;
				num = (short)224660234;
				short num3 = num;
				num = (short)1201801994;
				switch (num3 == num)
				{
				}
				num = (short)1236205569;
				if (num != 0)
				{
				}
				num = (short)108986368;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.HiddenStatic;
			}
			set
			{
				short num = (short)565182464;
				short num2 = num;
				num = (short)813432833;
				if (num != 0)
				{
				}
				num = (short)684508255;
				short num3 = num;
				num = (short)2022294623;
				switch (num3 == num)
				{
				}
				num = (short)1979580416;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.HiddenStatic = value;
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x003F0A70 File Offset: 0x003EEC70
		// (set) Token: 0x060043C8 RID: 17352 RVA: 0x003F0B24 File Offset: 0x003EED24
		internal bool RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_HiddenDynamic
		{
			get
			{
				short num = (short)1297809408;
				short num2 = num;
				num = (short)796731989;
				short num3 = num;
				num = (short)1162947157;
				switch (num3 == num)
				{
				}
				num = (short)138739712;
				if (num != 0)
				{
				}
				num = (short)1899102209;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.HiddenDynamic;
			}
			set
			{
				short num = (short)2080440320;
				short num2 = num;
				num = (short)1358508106;
				short num3 = num;
				num = (short)18427978;
				switch (num3 == num)
				{
				}
				num = (short)694484993;
				if (num != 0)
				{
				}
				num = (short)1749221376;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477.HiddenDynamic = value;
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x003F0BDC File Offset: 0x003EEDDC
		public bool RadWideUserInformationandPasswordsMaximumPasswordLength_A8477_HasDiffs
		{
			get
			{
				short num = (short)1620705280;
				short num2 = num;
				num = (short)2010049884;
				short num3 = num;
				num = (short)1368255836;
				switch (num3 == num)
				{
				}
				num = (short)657326080;
				if (num != 0)
				{
				}
				num = (short)2062155777;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsMaximumPasswordLength_A8477._HasDiffs;
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x060043CA RID: 17354 RVA: 0x003F0C90 File Offset: 0x003EEE90
		// (set) Token: 0x060043CB RID: 17355 RVA: 0x003F0D44 File Offset: 0x003EEF44
		public string RadWideUserInformationandPINPassword_41303Value
		{
			get
			{
				short num = (short)1571356672;
				short num2 = num;
				num = (short)294572758;
				short num3 = num;
				num = (short)297259734;
				switch (num3 == num)
				{
				}
				num = (short)455933953;
				if (num != 0)
				{
				}
				num = (short)521207808;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPINPassword_41303.Value;
			}
			set
			{
				short num = (short)1689124864;
				short num2 = num;
				num = (short)1977190913;
				short num3 = num;
				num = (short)1458735617;
				switch (num3 == num)
				{
				}
				num = (short)38731777;
				if (num != 0)
				{
				}
				num = (short)1618870272;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPINPassword_41303.Value = value;
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x060043CC RID: 17356 RVA: 0x003F0DF8 File Offset: 0x003EEFF8
		public global::AcpBusinessLayer.AcpFieldX<string, string> RadWideUserInformationandPINPassword_41303
		{
			get
			{
				short num = (short)1886819003;
				short num2 = num;
				num = (short)1033409211;
				switch (num2 == num)
				{
				}
				num = (short)1477509121;
				if (num != 0)
				{
				}
				num = (short)996540416;
				if (num != 0)
				{
				}
				num = (short)1895628800;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303;
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x003F0EA8 File Offset: 0x003EF0A8
		// (set) Token: 0x060043CE RID: 17358 RVA: 0x003F0F60 File Offset: 0x003EF160
		public string RadWideUserInformationandPINPassword_41303_UIValue
		{
			get
			{
				short num = (short)773570728;
				short num2 = num;
				num = (short)1512554664;
				switch (num2 == num)
				{
				}
				num = (short)2010185729;
				if (num != 0)
				{
				}
				num = (short)1463222272;
				if (num != 0)
				{
				}
				num = (short)520617984;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303.UIValue;
			}
			set
			{
				short num = (short)44758185;
				short num2 = num;
				num = (short)91681961;
				switch (num2 == num)
				{
				}
				num = (short)951058432;
				if (num != 0)
				{
				}
				num = (short)522059777;
				if (num != 0)
				{
				}
				num = (short)331874304;
				short num3 = num;
				this.radWideUserInformationandPINPassword_41303.UIValue = value;
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x003F1014 File Offset: 0x003EF214
		// (set) Token: 0x060043D0 RID: 17360 RVA: 0x003F10C8 File Offset: 0x003EF2C8
		public bool RadWideUserInformationandPINPassword_41303_Applicable
		{
			get
			{
				short num = (short)1282983353;
				short num2 = num;
				num = (short)446350777;
				switch (num2 == num)
				{
				}
				num = (short)1897857024;
				if (num != 0)
				{
				}
				num = (short)414711809;
				if (num != 0)
				{
				}
				num = (short)1259798528;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303.Applicable;
			}
			set
			{
				short num = (short)604812253;
				short num2 = num;
				num = (short)522564573;
				switch (num2 == num)
				{
				}
				num = (short)1230176257;
				if (num != 0)
				{
				}
				num = (short)156631040;
				if (num != 0)
				{
				}
				num = (short)432406528;
				short num3 = num;
				this.radWideUserInformationandPINPassword_41303.Applicable = value;
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x003F1180 File Offset: 0x003EF380
		// (set) Token: 0x060043D2 RID: 17362 RVA: 0x003F1238 File Offset: 0x003EF438
		public bool RadWideUserInformationandPINPassword_41303_Valid
		{
			get
			{
				short num = (short)441111384;
				short num2 = num;
				num = (short)1946604376;
				switch (num2 == num)
				{
				}
				num = (short)1409417216;
				if (num != 0)
				{
				}
				num = (short)40304641;
				if (num != 0)
				{
				}
				num = (short)630521856;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303.Valid;
			}
			set
			{
				short num = (short)1138291606;
				short num2 = num;
				num = (short)1469969302;
				switch (num2 == num)
				{
				}
				num = (short)1097990145;
				if (num != 0)
				{
				}
				num = (short)1357381632;
				if (num != 0)
				{
				}
				num = (short)674758656;
				short num3 = num;
				this.radWideUserInformationandPINPassword_41303.Valid = value;
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x003F12EC File Offset: 0x003EF4EC
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x003F13A0 File Offset: 0x003EF5A0
		public bool RadWideUserInformationandPINPassword_41303_Visible
		{
			get
			{
				short num = (short)724107265;
				if (num != 0)
				{
				}
				num = (short)1310303747;
				short num2 = num;
				num = (short)2141038083;
				switch (num2 == num)
				{
				}
				num = (short)14614528;
				if (num != 0)
				{
				}
				num = (short)344719360;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303.Visible;
			}
			set
			{
				short num = (short)590557213;
				short num2 = num;
				num = (short)1322725405;
				switch (num2 == num)
				{
				}
				num = (short)1756758017;
				if (num != 0)
				{
				}
				num = (short)538312704;
				if (num != 0)
				{
				}
				num = (short)2089025536;
				short num3 = num;
				this.radWideUserInformationandPINPassword_41303.Visible = value;
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x003F1454 File Offset: 0x003EF654
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x003F150C File Offset: 0x003EF70C
		public bool RadWideUserInformationandPINPassword_41303_Editable
		{
			get
			{
				short num = (short)1571291860;
				short num2 = num;
				num = (short)502989524;
				switch (num2 == num)
				{
				}
				num = (short)1925382145;
				if (num != 0)
				{
				}
				num = (short)39124992;
				if (num != 0)
				{
				}
				num = (short)2041905152;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303.Editable;
			}
			set
			{
				short num = (short)1296507514;
				short num2 = num;
				num = (short)152183418;
				switch (num2 == num)
				{
				}
				num = (short)456589313;
				if (num != 0)
				{
				}
				num = (short)1974468608;
				if (num != 0)
				{
				}
				num = (short)1830158336;
				short num3 = num;
				this.radWideUserInformationandPINPassword_41303.Editable = value;
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x003F15C0 File Offset: 0x003EF7C0
		internal string RadWideUserInformationandPINPassword_41303_UILabel
		{
			get
			{
				short num = (short)1959296862;
				short num2 = num;
				num = (short)1596620638;
				switch (num2 == num)
				{
				}
				num = (short)1909719040;
				if (num != 0)
				{
				}
				num = (short)944570369;
				if (num != 0)
				{
				}
				num = (short)2060779520;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303.UIName;
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x060043D8 RID: 17368 RVA: 0x003F1674 File Offset: 0x003EF874
		// (set) Token: 0x060043D9 RID: 17369 RVA: 0x003F172C File Offset: 0x003EF92C
		internal bool RadWideUserInformationandPINPassword_41303_HiddenStatic
		{
			get
			{
				short num = (short)1053802273;
				short num2 = num;
				num = (short)2063580961;
				switch (num2 == num)
				{
				}
				num = (short)320602112;
				if (num != 0)
				{
				}
				num = (short)1106903041;
				if (num != 0)
				{
				}
				num = (short)308281344;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303.HiddenStatic;
			}
			set
			{
				short num = (short)247752491;
				short num2 = num;
				num = (short)1182754603;
				switch (num2 == num)
				{
				}
				num = (short)1825636353;
				if (num != 0)
				{
				}
				num = (short)947847168;
				if (num != 0)
				{
				}
				num = (short)974192640;
				short num3 = num;
				this.radWideUserInformationandPINPassword_41303.HiddenStatic = value;
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x060043DA RID: 17370 RVA: 0x003F17E4 File Offset: 0x003EF9E4
		// (set) Token: 0x060043DB RID: 17371 RVA: 0x003F1898 File Offset: 0x003EFA98
		internal bool RadWideUserInformationandPINPassword_41303_HiddenDynamic
		{
			get
			{
				short num = (short)466137323;
				short num2 = num;
				num = (short)1792782571;
				switch (num2 == num)
				{
				}
				num = (short)1001979905;
				if (num != 0)
				{
				}
				num = (short)1282015232;
				if (num != 0)
				{
				}
				num = (short)785973248;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303.HiddenDynamic;
			}
			set
			{
				short num = (short)798470728;
				short num2 = num;
				num = (short)729526856;
				switch (num2 == num)
				{
				}
				num = (short)2052587521;
				if (num != 0)
				{
				}
				num = (short)275120128;
				if (num != 0)
				{
				}
				num = (short)1229455360;
				short num3 = num;
				this.radWideUserInformationandPINPassword_41303.HiddenDynamic = value;
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x060043DC RID: 17372 RVA: 0x003F194C File Offset: 0x003EFB4C
		public bool RadWideUserInformationandPINPassword_41303_HasDiffs
		{
			get
			{
				short num = (short)1515997945;
				short num2 = num;
				num = (short)1409305337;
				switch (num2 == num)
				{
				}
				num = (short)669057024;
				if (num != 0)
				{
				}
				num = (short)707657729;
				if (num != 0)
				{
				}
				num = (short)1885929472;
				short num3 = num;
				return this.radWideUserInformationandPINPassword_41303._HasDiffs;
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x003F1A00 File Offset: 0x003EFC00
		// (set) Token: 0x060043DE RID: 17374 RVA: 0x003F1AB4 File Offset: 0x003EFCB4
		public string RadWideUserInformationandPINPasswordPart2_41304Value
		{
			get
			{
				short num = (short)1122118962;
				short num2 = num;
				num = (short)482290994;
				switch (num2 == num)
				{
				}
				num = (short)585170945;
				if (num != 0)
				{
				}
				num = (short)578224128;
				if (num != 0)
				{
				}
				num = (short)139788288;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.Value;
			}
			set
			{
				short num = (short)662796385;
				short num2 = num;
				num = (short)1139177569;
				switch (num2 == num)
				{
				}
				num = (short)1628962817;
				if (num != 0)
				{
				}
				num = (short)653721600;
				if (num != 0)
				{
				}
				num = (short)999161856;
				short num3 = num;
				this.radWideUserInformationandPINPasswordPart2_41304.Value = value;
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x003F1B68 File Offset: 0x003EFD68
		public global::AcpBusinessLayer.AcpField<string> RadWideUserInformationandPINPasswordPart2_41304
		{
			get
			{
				short num = (short)813093765;
				short num2 = num;
				num = (short)442225541;
				switch (num2 == num)
				{
				}
				num = (short)838074368;
				if (num != 0)
				{
				}
				num = (short)2023030785;
				if (num != 0)
				{
				}
				num = (short)57212928;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304;
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x060043E0 RID: 17376 RVA: 0x003F1C18 File Offset: 0x003EFE18
		// (set) Token: 0x060043E1 RID: 17377 RVA: 0x003F1CD0 File Offset: 0x003EFED0
		public string RadWideUserInformationandPINPasswordPart2_41304_UIValue
		{
			get
			{
				short num = (short)129794417;
				short num2 = num;
				num = (short)1425310065;
				switch (num2 == num)
				{
				}
				num = (short)1176698881;
				if (num != 0)
				{
				}
				num = (short)710410240;
				if (num != 0)
				{
				}
				num = (short)1929707520;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.Value;
			}
			set
			{
				short num = (short)1564852364;
				short num2 = num;
				num = (short)813613196;
				switch (num2 == num)
				{
				}
				num = (short)1051983873;
				if (num != 0)
				{
				}
				num = (short)1773797376;
				if (num != 0)
				{
				}
				num = (short)31784960;
				short num3 = num;
				this.radWideUserInformationandPINPasswordPart2_41304.Value = value;
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x060043E2 RID: 17378 RVA: 0x003F1D88 File Offset: 0x003EFF88
		// (set) Token: 0x060043E3 RID: 17379 RVA: 0x003F1E3C File Offset: 0x003F003C
		public bool RadWideUserInformationandPINPasswordPart2_41304_Applicable
		{
			get
			{
				short num = (short)1365966849;
				if (num != 0)
				{
				}
				num = (short)198004490;
				short num2 = num;
				num = (short)322588426;
				switch (num2 == num)
				{
				}
				num = (short)749404160;
				if (num != 0)
				{
				}
				num = (short)1930690560;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.Applicable;
			}
			set
			{
				short num = (short)381266373;
				short num2 = num;
				num = (short)1068542405;
				switch (num2 == num)
				{
				}
				num = (short)1844445185;
				if (num != 0)
				{
				}
				num = (short)1873674240;
				if (num != 0)
				{
				}
				num = (short)346030080;
				short num3 = num;
				this.radWideUserInformationandPINPasswordPart2_41304.Applicable = value;
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x060043E4 RID: 17380 RVA: 0x003F1EF0 File Offset: 0x003F00F0
		// (set) Token: 0x060043E5 RID: 17381 RVA: 0x003F1FA4 File Offset: 0x003F01A4
		public bool RadWideUserInformationandPINPasswordPart2_41304_Valid
		{
			get
			{
				short num = (short)2016423273;
				short num2 = num;
				num = (short)2103651689;
				switch (num2 == num)
				{
				}
				num = (short)1649672193;
				if (num != 0)
				{
				}
				num = (short)1273954304;
				if (num != 0)
				{
				}
				num = (short)1952055296;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.Valid;
			}
			set
			{
				short num = (short)252595800;
				short num2 = num;
				num = (short)17649240;
				switch (num2 == num)
				{
				}
				num = (short)1863254016;
				if (num != 0)
				{
				}
				num = (short)363134977;
				if (num != 0)
				{
				}
				num = (short)1032323072;
				short num3 = num;
				this.radWideUserInformationandPINPasswordPart2_41304.Valid = value;
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x060043E6 RID: 17382 RVA: 0x003F205C File Offset: 0x003F025C
		// (set) Token: 0x060043E7 RID: 17383 RVA: 0x003F2110 File Offset: 0x003F0310
		public bool RadWideUserInformationandPINPasswordPart2_41304_Visible
		{
			get
			{
				short num = (short)955660098;
				short num2 = num;
				num = (short)1254831938;
				switch (num2 == num)
				{
				}
				num = (short)990183425;
				if (num != 0)
				{
				}
				num = (short)161742848;
				if (num != 0)
				{
				}
				num = (short)1453785088;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.Visible;
			}
			set
			{
				short num = (short)1084489729;
				if (num != 0)
				{
				}
				num = (short)1996860254;
				short num2 = num;
				num = (short)1699982174;
				switch (num2 == num)
				{
				}
				num = (short)1123352576;
				if (num != 0)
				{
				}
				num = (short)1283784704;
				short num3 = num;
				this.radWideUserInformationandPINPasswordPart2_41304.Visible = value;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x060043E8 RID: 17384 RVA: 0x003F21C8 File Offset: 0x003F03C8
		// (set) Token: 0x060043E9 RID: 17385 RVA: 0x003F2280 File Offset: 0x003F0480
		public bool RadWideUserInformationandPINPasswordPart2_41304_Editable
		{
			get
			{
				short num = (short)854306491;
				short num2 = num;
				num = (short)120237755;
				switch (num2 == num)
				{
				}
				num = (short)580321281;
				if (num != 0)
				{
				}
				num = (short)1417478144;
				if (num != 0)
				{
				}
				num = (short)1439105024;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.Editable;
			}
			set
			{
				short num = (short)545485065;
				short num2 = num;
				num = (short)754217225;
				switch (num2 == num)
				{
				}
				num = (short)418775041;
				if (num != 0)
				{
				}
				num = (short)337510400;
				if (num != 0)
				{
				}
				num = (short)1602027520;
				short num3 = num;
				this.radWideUserInformationandPINPasswordPart2_41304.Editable = value;
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x060043EA RID: 17386 RVA: 0x003F2338 File Offset: 0x003F0538
		internal string RadWideUserInformationandPINPasswordPart2_41304_UILabel
		{
			get
			{
				short num = (short)109080932;
				short num2 = num;
				num = (short)177893732;
				switch (num2 == num)
				{
				}
				num = (short)1594818561;
				if (num != 0)
				{
				}
				num = (short)1352400896;
				if (num != 0)
				{
				}
				num = (short)1410859008;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.UIName;
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x003F23EC File Offset: 0x003F05EC
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x003F24A0 File Offset: 0x003F06A0
		internal bool RadWideUserInformationandPINPasswordPart2_41304_HiddenStatic
		{
			get
			{
				short num = (short)738143716;
				short num2 = num;
				num = (short)518139364;
				switch (num2 == num)
				{
				}
				num = (short)1934819329;
				if (num != 0)
				{
				}
				num = (short)860618752;
				if (num != 0)
				{
				}
				num = (short)1396375552;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.HiddenStatic;
			}
			set
			{
				short num = (short)2049504553;
				short num2 = num;
				num = (short)1977611561;
				switch (num2 == num)
				{
				}
				num = (short)436469761;
				if (num != 0)
				{
				}
				num = (short)1263861760;
				if (num != 0)
				{
				}
				num = (short)131137536;
				short num3 = num;
				this.radWideUserInformationandPINPasswordPart2_41304.HiddenStatic = value;
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x003F2554 File Offset: 0x003F0754
		// (set) Token: 0x060043EE RID: 17390 RVA: 0x003F2608 File Offset: 0x003F0808
		internal bool RadWideUserInformationandPINPasswordPart2_41304_HiddenDynamic
		{
			get
			{
				short num = (short)935479212;
				short num2 = num;
				num = (short)1677084588;
				switch (num2 == num)
				{
				}
				num = (short)610795521;
				if (num != 0)
				{
				}
				num = (short)2123366400;
				if (num != 0)
				{
				}
				num = (short)1169162240;
				short num3 = num;
				return this.radWideUserInformationandPINPasswordPart2_41304.HiddenDynamic;
			}
			set
			{
				short num = (short)890636277;
				short num2 = num;
				num = (short)1077479413;
				switch (num2 == num)
				{
				}
				num = (short)347406336;
				if (num != 0)
				{
				}
				num = (short)628162561;
				if (num != 0)
				{
				}
				num = (short)310706176;
				short num3 = num;
				this.radWideUserInformationandPINPasswordPart2_41304.HiddenDynamic = value;
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x003F26C0 File Offset: 0x003F08C0
		public bool RadWideUserInformationandPINPasswordPart2_41304_HasDiffs
		{
			get
			{
				short num = (short)135522199;
				short num2 = num;
				num = (short)1400235927;
				switch (num2 == num)
				{
				}
				num = (short)629997568;
				short num3 = num;
				num = (short)1475543041;
				if (num != 0)
				{
				}
				num = (short)1187840000;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPINPasswordPart2_41304._HasDiffs;
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x060043F0 RID: 17392 RVA: 0x003F2774 File Offset: 0x003F0974
		// (set) Token: 0x060043F1 RID: 17393 RVA: 0x003F2828 File Offset: 0x003F0A28
		public bool RadWideUserInformationandUserLoginUnitIDEnable_41305Value
		{
			get
			{
				short num = (short)1013448705;
				if (num != 0)
				{
				}
				num = (short)157789609;
				short num2 = num;
				num = (short)1491709353;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471545344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1058603008;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.Value;
			}
			set
			{
				short num = (short)550877424;
				short num2 = num;
				num = (short)148224240;
				switch (num2 == num)
				{
				}
				num = (short)140836864;
				short num3 = num;
				num = (short)1282932736;
				if (num != 0)
				{
				}
				num = (short)730136577;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDEnable_41305.Value = value;
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x060043F2 RID: 17394 RVA: 0x003F28E0 File Offset: 0x003F0AE0
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserInformationandUserLoginUnitIDEnable_41305
		{
			get
			{
				short num = (short)316098480;
				short num2 = num;
				num = (short)507266992;
				switch (num2 == num)
				{
				}
				num = (short)541196288;
				short num3 = num;
				num = (short)398917633;
				if (num != 0)
				{
				}
				num = (short)1977876480;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305;
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x003F298C File Offset: 0x003F0B8C
		// (set) Token: 0x060043F4 RID: 17396 RVA: 0x003F2A40 File Offset: 0x003F0C40
		public bool RadWideUserInformationandUserLoginUnitIDEnable_41305_UIValue
		{
			get
			{
				short num = (short)2115899717;
				short num2 = num;
				num = (short)1755779397;
				switch (num2 == num)
				{
				}
				num = (short)2007891968;
				short num3 = num;
				num = (short)1252720641;
				if (num != 0)
				{
				}
				num = (short)2087190528;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.Value;
			}
			set
			{
				short num = (short)442499073;
				if (num != 0)
				{
				}
				num = (short)602987962;
				short num2 = num;
				num = (short)25222586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)124911616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)83820544;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDEnable_41305.Value = value;
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x003F2AF8 File Offset: 0x003F0CF8
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x003F2BAC File Offset: 0x003F0DAC
		public bool RadWideUserInformationandUserLoginUnitIDEnable_41305_Applicable
		{
			get
			{
				short num = (short)1654349098;
				short num2 = num;
				num = (short)1828543786;
				switch (num2 == num)
				{
				}
				num = (short)1824456704;
				short num3 = num;
				num = (short)494600193;
				if (num != 0)
				{
				}
				num = (short)1154875392;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.Applicable;
			}
			set
			{
				short num = (short)1952279433;
				short num2 = num;
				num = (short)493054857;
				switch (num2 == num)
				{
				}
				num = (short)1869021184;
				short num3 = num;
				num = (short)1267400705;
				if (num != 0)
				{
				}
				num = (short)1173291008;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDEnable_41305.Applicable = value;
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x003F2C60 File Offset: 0x003F0E60
		// (set) Token: 0x060043F8 RID: 17400 RVA: 0x003F2D14 File Offset: 0x003F0F14
		public bool RadWideUserInformationandUserLoginUnitIDEnable_41305_Valid
		{
			get
			{
				short num = (short)484174979;
				short num2 = num;
				num = (short)1941302403;
				switch (num2 == num)
				{
				}
				num = (short)535822336;
				short num3 = num;
				num = (short)1014824961;
				if (num != 0)
				{
				}
				num = (short)1444806656;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.Valid;
			}
			set
			{
				short num = (short)2011209105;
				short num2 = num;
				num = (short)1055235473;
				switch (num2 == num)
				{
				}
				num = (short)1660485632;
				short num3 = num;
				num = (short)681312256;
				if (num != 0)
				{
				}
				num = (short)71630849;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDEnable_41305.Valid = value;
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x003F2DCC File Offset: 0x003F0FCC
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x003F2E84 File Offset: 0x003F1084
		public bool RadWideUserInformationandUserLoginUnitIDEnable_41305_Visible
		{
			get
			{
				short num = (short)1574922384;
				short num2 = num;
				num = (short)830040208;
				switch (num2 == num)
				{
				}
				num = (short)1289420800;
				short num3 = num;
				num = (short)1189806081;
				if (num != 0)
				{
				}
				num = (short)1777205248;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.Visible;
			}
			set
			{
				short num = (short)1631977658;
				short num2 = num;
				num = (short)225509562;
				switch (num2 == num)
				{
				}
				num = (short)686096384;
				short num3 = num;
				num = (short)250871809;
				if (num != 0)
				{
				}
				num = (short)103940096;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDEnable_41305.Visible = value;
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x003F2F38 File Offset: 0x003F1138
		// (set) Token: 0x060043FC RID: 17404 RVA: 0x003F2FEC File Offset: 0x003F11EC
		public bool RadWideUserInformationandUserLoginUnitIDEnable_41305_Editable
		{
			get
			{
				short num = (short)2119795791;
				short num2 = num;
				num = (short)1298826319;
				switch (num2 == num)
				{
				}
				num = (short)559546368;
				short num3 = num;
				num = (short)1334050816;
				if (num != 0)
				{
				}
				num = (short)390725633;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.Editable;
			}
			set
			{
				short num = (short)2065521182;
				short num2 = num;
				num = (short)1895127582;
				switch (num2 == num)
				{
				}
				num = (short)989265920;
				short num3 = num;
				num = (short)683474944;
				if (num != 0)
				{
				}
				num = (short)130220033;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDEnable_41305.Editable = value;
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x003F30A0 File Offset: 0x003F12A0
		internal string RadWideUserInformationandUserLoginUnitIDEnable_41305_UILabel
		{
			get
			{
				short num = (short)478548503;
				short num2 = num;
				num = (short)595399191;
				switch (num2 == num)
				{
				}
				num = (short)1950154752;
				short num3 = num;
				num = (short)1804337153;
				if (num != 0)
				{
				}
				num = (short)1869021184;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.UIName;
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x003F3154 File Offset: 0x003F1354
		// (set) Token: 0x060043FF RID: 17407 RVA: 0x003F320C File Offset: 0x003F140C
		internal bool RadWideUserInformationandUserLoginUnitIDEnable_41305_HiddenStatic
		{
			get
			{
				short num = (short)675471196;
				short num2 = num;
				num = (short)1202184028;
				switch (num2 == num)
				{
				}
				num = (short)1611399168;
				short num3 = num;
				num = (short)23920640;
				if (num != 0)
				{
				}
				num = (short)1403584513;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.HiddenStatic;
			}
			set
			{
				short num = (short)201655063;
				short num2 = num;
				num = (short)2069037847;
				switch (num2 == num)
				{
				}
				num = (short)50921472;
				short num3 = num;
				num = (short)1343422465;
				if (num != 0)
				{
				}
				num = (short)1840250880;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDEnable_41305.HiddenStatic = value;
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x003F32C0 File Offset: 0x003F14C0
		// (set) Token: 0x06004401 RID: 17409 RVA: 0x003F3378 File Offset: 0x003F1578
		internal bool RadWideUserInformationandUserLoginUnitIDEnable_41305_HiddenDynamic
		{
			get
			{
				short num = (short)1840018682;
				short num2 = num;
				num = (short)418084090;
				switch (num2 == num)
				{
				}
				num = (short)1136656384;
				short num3 = num;
				num = (short)1633484801;
				if (num != 0)
				{
				}
				num = (short)533069824;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305.HiddenDynamic;
			}
			set
			{
				short num = (short)198377296;
				short num2 = num;
				num = (short)284229456;
				switch (num2 == num)
				{
				}
				num = (short)64815104;
				short num3 = num;
				num = (short)502530049;
				if (num != 0)
				{
				}
				num = (short)996868096;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDEnable_41305.HiddenDynamic = value;
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x06004402 RID: 17410 RVA: 0x003F3430 File Offset: 0x003F1630
		public bool RadWideUserInformationandUserLoginUnitIDEnable_41305_HasDiffs
		{
			get
			{
				short num = (short)342624399;
				short num2 = num;
				num = (short)396822671;
				switch (num2 == num)
				{
				}
				num = (short)642711552;
				short num3 = num;
				num = (short)461570048;
				if (num != 0)
				{
				}
				num = (short)82378753;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDEnable_41305._HasDiffs;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x003F34E4 File Offset: 0x003F16E4
		// (set) Token: 0x06004404 RID: 17412 RVA: 0x003F3594 File Offset: 0x003F1794
		public string RadWideUserInformationandUserLoginUnitID_41306Value
		{
			get
			{
				short num = (short)508809775;
				short num2 = num;
				num = (short)351588911;
				switch (num2 == num)
				{
				}
				num = (short)847904768;
				short num3 = num;
				num = (short)229834753;
				if (num != 0)
				{
				}
				num = (short)746520576;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.Value;
			}
			set
			{
				short num = (short)698773918;
				short num2 = num;
				num = (short)12415390;
				switch (num2 == num)
				{
				}
				num = (short)1388183552;
				short num3 = num;
				num = (short)1400832001;
				if (num != 0)
				{
				}
				num = (short)1377173504;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitID_41306.Value = value;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x003F364C File Offset: 0x003F184C
		public global::AcpBusinessLayer.AcpField<string> RadWideUserInformationandUserLoginUnitID_41306
		{
			get
			{
				short num = (short)859196132;
				short num2 = num;
				num = (short)36326116;
				switch (num2 == num)
				{
				}
				num = (short)1744371712;
				short num3 = num;
				num = (short)1931345920;
				if (num != 0)
				{
				}
				num = (short)414121985;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306;
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x003F36F8 File Offset: 0x003F18F8
		// (set) Token: 0x06004407 RID: 17415 RVA: 0x003F37B0 File Offset: 0x003F19B0
		public string RadWideUserInformationandUserLoginUnitID_41306_UIValue
		{
			get
			{
				short num = (short)1964349520;
				short num2 = num;
				num = (short)1141872720;
				switch (num2 == num)
				{
				}
				num = (short)856293376;
				short num3 = num;
				num = (short)1943928833;
				if (num != 0)
				{
				}
				num = (short)1459748864;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.Value;
			}
			set
			{
				short num = (short)1875076484;
				short num2 = num;
				num = (short)84043140;
				switch (num2 == num)
				{
				}
				num = (short)775684096;
				short num3 = num;
				num = (short)302710784;
				if (num != 0)
				{
				}
				num = (short)690356225;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitID_41306.Value = value;
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x003F3868 File Offset: 0x003F1A68
		// (set) Token: 0x06004409 RID: 17417 RVA: 0x003F391C File Offset: 0x003F1B1C
		public bool RadWideUserInformationandUserLoginUnitID_41306_Applicable
		{
			get
			{
				short num = (short)82418710;
				short num2 = num;
				num = (short)1723702294;
				switch (num2 == num)
				{
				}
				num = (short)1865220096;
				short num3 = num;
				num = (short)104988673;
				if (num != 0)
				{
				}
				num = (short)1338507264;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.Applicable;
			}
			set
			{
				short num = (short)533284920;
				short num2 = num;
				num = (short)1921599544;
				switch (num2 == num)
				{
				}
				num = (short)712376320;
				short num3 = num;
				num = (short)1669464065;
				if (num != 0)
				{
				}
				num = (short)764739584;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitID_41306.Applicable = value;
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x003F39D0 File Offset: 0x003F1BD0
		// (set) Token: 0x0600440B RID: 17419 RVA: 0x003F3A88 File Offset: 0x003F1C88
		public bool RadWideUserInformationandUserLoginUnitID_41306_Valid
		{
			get
			{
				short num = (short)899151688;
				short num2 = num;
				num = (short)239269704;
				switch (num2 == num)
				{
				}
				num = (short)1546190848;
				short num3 = num;
				num = (short)1074200576;
				if (num != 0)
				{
				}
				num = (short)178520065;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.Valid;
			}
			set
			{
				short num = (short)492240897;
				if (num != 0)
				{
				}
				num = (short)238206740;
				short num2 = num;
				num = (short)1241956116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)558104576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1743388672;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitID_41306.Valid = value;
			}
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x0600440C RID: 17420 RVA: 0x003F3B40 File Offset: 0x003F1D40
		// (set) Token: 0x0600440D RID: 17421 RVA: 0x003F3BF4 File Offset: 0x003F1DF4
		public bool RadWideUserInformationandUserLoginUnitID_41306_Visible
		{
			get
			{
				short num = (short)416846191;
				short num2 = num;
				num = (short)1026265455;
				switch (num2 == num)
				{
				}
				num = (short)1578958848;
				short num3 = num;
				num = (short)1798897664;
				if (num != 0)
				{
				}
				num = (short)993918977;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.Visible;
			}
			set
			{
				short num = (short)879555733;
				short num2 = num;
				num = (short)1655436437;
				switch (num2 == num)
				{
				}
				num = (short)2116812800;
				short num3 = num;
				num = (short)801177600;
				if (num != 0)
				{
				}
				num = (short)1002504193;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitID_41306.Visible = value;
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x003F3CAC File Offset: 0x003F1EAC
		// (set) Token: 0x0600440F RID: 17423 RVA: 0x003F3D60 File Offset: 0x003F1F60
		public bool RadWideUserInformationandUserLoginUnitID_41306_Editable
		{
			get
			{
				short num = (short)1032358453;
				short num2 = num;
				num = (short)2023197237;
				switch (num2 == num)
				{
				}
				num = (short)943783936;
				short num3 = num;
				num = (short)865533953;
				if (num != 0)
				{
				}
				num = (short)146538496;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.Editable;
			}
			set
			{
				short num = (short)243758964;
				short num2 = num;
				num = (short)409237364;
				switch (num2 == num)
				{
				}
				num = (short)1211760640;
				short num3 = num;
				num = (short)894304257;
				if (num != 0)
				{
				}
				num = (short)565182464;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitID_41306.Editable = value;
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x003F3E14 File Offset: 0x003F2014
		internal string RadWideUserInformationandUserLoginUnitID_41306_UILabel
		{
			get
			{
				short num = (short)1174232885;
				short num2 = num;
				num = (short)1266048821;
				switch (num2 == num)
				{
				}
				num = (short)1367015424;
				short num3 = num;
				num = (short)899809281;
				if (num != 0)
				{
				}
				num = (short)1025966080;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.UIName;
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x003F3EC8 File Offset: 0x003F20C8
		// (set) Token: 0x06004412 RID: 17426 RVA: 0x003F3F7C File Offset: 0x003F217C
		internal bool RadWideUserInformationandUserLoginUnitID_41306_HiddenStatic
		{
			get
			{
				short num = (short)2089077076;
				short num2 = num;
				num = (short)2010630484;
				switch (num2 == num)
				{
				}
				num = (short)843186176;
				short num3 = num;
				num = (short)1140457473;
				if (num != 0)
				{
				}
				num = (short)605290496;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.HiddenStatic;
			}
			set
			{
				short num = (short)1214973086;
				short num2 = num;
				num = (short)1508508830;
				switch (num2 == num)
				{
				}
				num = (short)52363264;
				short num3 = num;
				num = (short)687341569;
				if (num != 0)
				{
				}
				num = (short)1419902976;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitID_41306.HiddenStatic = value;
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x003F4030 File Offset: 0x003F2230
		// (set) Token: 0x06004414 RID: 17428 RVA: 0x003F40E4 File Offset: 0x003F22E4
		internal bool RadWideUserInformationandUserLoginUnitID_41306_HiddenDynamic
		{
			get
			{
				short num = (short)73007105;
				if (num != 0)
				{
				}
				num = (short)1257411081;
				short num2 = num;
				num = (short)81891849;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1618804736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)709885952;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306.HiddenDynamic;
			}
			set
			{
				short num = (short)1791616386;
				short num2 = num;
				num = (short)676521346;
				switch (num2 == num)
				{
				}
				num = (short)162004992;
				short num3 = num;
				num = (short)540999681;
				if (num != 0)
				{
				}
				num = (short)149094400;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitID_41306.HiddenDynamic = value;
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x003F419C File Offset: 0x003F239C
		public bool RadWideUserInformationandUserLoginUnitID_41306_HasDiffs
		{
			get
			{
				short num = (short)2091607836;
				short num2 = num;
				num = (short)596010780;
				switch (num2 == num)
				{
				}
				num = (short)302186496;
				short num3 = num;
				num = (short)1585577984;
				if (num != 0)
				{
				}
				num = (short)891224065;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitID_41306._HasDiffs;
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x06004416 RID: 17430 RVA: 0x003F4250 File Offset: 0x003F2450
		// (set) Token: 0x06004417 RID: 17431 RVA: 0x003F4304 File Offset: 0x003F2504
		public int RadWideUserInformationandCachedCredentialsUserLoginMode_41307Value
		{
			get
			{
				short num = (short)853472714;
				short num2 = num;
				num = (short)603518410;
				switch (num2 == num)
				{
				}
				num = (short)1422196736;
				short num3 = num;
				num = (short)1362165760;
				if (num != 0)
				{
				}
				num = (short)400359425;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Value;
			}
			set
			{
				short num = (short)873210951;
				short num2 = num;
				num = (short)1416635463;
				switch (num2 == num)
				{
				}
				num = (short)1400766464;
				short num3 = num;
				num = (short)939065344;
				if (num != 0)
				{
				}
				num = (short)776011777;
				if (num != 0)
				{
				}
				this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Value = value;
			}
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06004418 RID: 17432 RVA: 0x003F43B8 File Offset: 0x003F25B8
		// (set) Token: 0x06004419 RID: 17433 RVA: 0x003F4470 File Offset: 0x003F2670
		public string RadWideUserInformationandCachedCredentialsUserLoginMode_41307_UIValue
		{
			get
			{
				short num = (short)555308291;
				short num2 = num;
				num = (short)548492547;
				switch (num2 == num)
				{
				}
				num = (short)1587347456;
				short num3 = num;
				num = (short)2039480321;
				if (num != 0)
				{
				}
				num = (short)1103495168;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.UIValue;
			}
			set
			{
				short num = (short)1325294215;
				short num2 = num;
				num = (short)56582791;
				switch (num2 == num)
				{
				}
				num = (short)1444216832;
				short num3 = num;
				num = (short)737673216;
				if (num != 0)
				{
				}
				num = (short)952303617;
				if (num != 0)
				{
				}
				this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.UIValue = value;
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x0600441A RID: 17434 RVA: 0x003F4528 File Offset: 0x003F2728
		public global::AcpBusinessLayer.AcpListField RadWideUserInformationandCachedCredentialsUserLoginMode_41307
		{
			get
			{
				short num = (short)680594483;
				short num2 = num;
				num = (short)1847987251;
				switch (num2 == num)
				{
				}
				num = (short)400293888;
				short num3 = num;
				num = (short)1473773569;
				if (num != 0)
				{
				}
				num = (short)213581824;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307;
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x0600441B RID: 17435 RVA: 0x003F45DC File Offset: 0x003F27DC
		// (set) Token: 0x0600441C RID: 17436 RVA: 0x003F4690 File Offset: 0x003F2890
		public bool RadWideUserInformationandCachedCredentialsUserLoginMode_41307_Applicable
		{
			get
			{
				short num = (short)1885127897;
				short num2 = num;
				num = (short)1410974937;
				switch (num2 == num)
				{
				}
				num = (short)25821184;
				short num3 = num;
				num = (short)432996352;
				if (num != 0)
				{
				}
				num = (short)1417936897;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Applicable;
			}
			set
			{
				short num = (short)1080315293;
				short num2 = num;
				num = (short)928271773;
				switch (num2 == num)
				{
				}
				num = (short)903086080;
				short num3 = num;
				num = (short)69468161;
				if (num != 0)
				{
				}
				num = (short)1281687552;
				if (num != 0)
				{
				}
				this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Applicable = value;
			}
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x003F474C File Offset: 0x003F294C
		// (set) Token: 0x0600441E RID: 17438 RVA: 0x003F4800 File Offset: 0x003F2A00
		public bool RadWideUserInformationandCachedCredentialsUserLoginMode_41307_Valid
		{
			get
			{
				short num = (short)500871922;
				short num2 = num;
				num = (short)1704637170;
				switch (num2 == num)
				{
				}
				num = (short)2146500608;
				short num3 = num;
				num = (short)1633419265;
				if (num != 0)
				{
				}
				num = (short)1753153536;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Valid;
			}
			set
			{
				short num = (short)1909456897;
				if (num != 0)
				{
				}
				num = (short)314790208;
				short num2 = num;
				num = (short)717771072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)646184960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1420820480;
				if (num != 0)
				{
				}
				this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Valid = value;
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x0600441F RID: 17439 RVA: 0x003F48B4 File Offset: 0x003F2AB4
		// (set) Token: 0x06004420 RID: 17440 RVA: 0x003F496C File Offset: 0x003F2B6C
		public bool RadWideUserInformationandCachedCredentialsUserLoginMode_41307_Visible
		{
			get
			{
				short num = (short)316578980;
				short num2 = num;
				num = (short)1156750500;
				switch (num2 == num)
				{
				}
				num = (short)1491402752;
				short num3 = num;
				num = (short)548405249;
				if (num != 0)
				{
				}
				num = (short)158662656;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Visible;
			}
			set
			{
				short num = (short)1681166764;
				short num2 = num;
				num = (short)1450348972;
				switch (num2 == num)
				{
				}
				num = (short)1864630272;
				short num3 = num;
				num = (short)1941504001;
				if (num != 0)
				{
				}
				num = (short)1417871360;
				if (num != 0)
				{
				}
				this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Visible = value;
			}
		}

		// Token: 0x17002301 RID: 8961
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x003F4A24 File Offset: 0x003F2C24
		// (set) Token: 0x06004422 RID: 17442 RVA: 0x003F4ADC File Offset: 0x003F2CDC
		public bool RadWideUserInformationandCachedCredentialsUserLoginMode_41307_Editable
		{
			get
			{
				short num = (short)970288716;
				short num2 = num;
				num = (short)243691084;
				switch (num2 == num)
				{
				}
				num = (short)1410924544;
				short num3 = num;
				num = (short)609484800;
				if (num != 0)
				{
				}
				num = (short)1367015425;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Editable;
			}
			set
			{
				short num = (short)1600389121;
				if (num != 0)
				{
				}
				num = (short)642562282;
				short num2 = num;
				num = (short)570472682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1696923648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)299302912;
				if (num != 0)
				{
				}
				this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.Editable = value;
			}
		}

		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x06004423 RID: 17443 RVA: 0x003F4B90 File Offset: 0x003F2D90
		internal string RadWideUserInformationandCachedCredentialsUserLoginMode_41307_UILabel
		{
			get
			{
				short num = (short)896857560;
				short num2 = num;
				num = (short)1416820184;
				switch (num2 == num)
				{
				}
				num = (short)1869479936;
				short num3 = num;
				num = (short)366608384;
				if (num != 0)
				{
				}
				num = (short)1564344321;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.UIName;
			}
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x06004424 RID: 17444 RVA: 0x003F4C44 File Offset: 0x003F2E44
		// (set) Token: 0x06004425 RID: 17445 RVA: 0x003F4CF8 File Offset: 0x003F2EF8
		internal bool RadWideUserInformationandCachedCredentialsUserLoginMode_41307_HiddenStatic
		{
			get
			{
				short num = (short)1167671069;
				short num2 = num;
				num = (short)1242513181;
				switch (num2 == num)
				{
				}
				num = (short)235077632;
				short num3 = num;
				num = (short)2010513408;
				if (num != 0)
				{
				}
				num = (short)783351809;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.HiddenStatic;
			}
			set
			{
				short num = (short)1472476614;
				short num2 = num;
				num = (short)683488710;
				switch (num2 == num)
				{
				}
				num = (short)1587675136;
				short num3 = num;
				num = (short)242155521;
				if (num != 0)
				{
				}
				num = (short)1579089920;
				if (num != 0)
				{
				}
				this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.HiddenStatic = value;
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x06004426 RID: 17446 RVA: 0x003F4DAC File Offset: 0x003F2FAC
		// (set) Token: 0x06004427 RID: 17447 RVA: 0x003F4E60 File Offset: 0x003F3060
		internal bool RadWideUserInformationandCachedCredentialsUserLoginMode_41307_HiddenDynamic
		{
			get
			{
				short num = (short)473986553;
				short num2 = num;
				num = (short)1083274745;
				switch (num2 == num)
				{
				}
				num = (short)616235008;
				short num3 = num;
				num = (short)1159069696;
				if (num != 0)
				{
				}
				num = (short)1026752513;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.HiddenDynamic;
			}
			set
			{
				short num = (short)466969285;
				short num2 = num;
				num = (short)189358789;
				switch (num2 == num)
				{
				}
				num = (short)7012352;
				short num3 = num;
				num = (short)211615745;
				if (num != 0)
				{
				}
				num = (short)1430847488;
				if (num != 0)
				{
				}
				this.radWideUserInformationandCachedCredentialsUserLoginMode_41307.HiddenDynamic = value;
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06004428 RID: 17448 RVA: 0x003F4F1C File Offset: 0x003F311C
		public bool RadWideUserInformationandCachedCredentialsUserLoginMode_41307_HasDiffs
		{
			get
			{
				short num = (short)922034336;
				short num2 = num;
				num = (short)841097376;
				switch (num2 == num)
				{
				}
				num = (short)2139488256;
				short num3 = num;
				num = (short)146800641;
				if (num != 0)
				{
				}
				num = (short)32374784;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandCachedCredentialsUserLoginMode_41307._HasDiffs;
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x003F4FD4 File Offset: 0x003F31D4
		// (set) Token: 0x0600442A RID: 17450 RVA: 0x003F5084 File Offset: 0x003F3284
		public int RadWideUserInformationandUserLoginUnitIDTextSize_41309Value
		{
			get
			{
				short num = (short)16966188;
				short num2 = num;
				num = (short)1696260652;
				switch (num2 == num)
				{
				}
				num = (short)234881024;
				short num3 = num;
				num = (short)1141047296;
				if (num != 0)
				{
				}
				num = (short)709558273;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Value;
			}
			set
			{
				short num = (short)649920513;
				if (num != 0)
				{
				}
				num = (short)949843247;
				short num2 = num;
				num = (short)63534383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)403767296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)785645568;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Value = value;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x003F513C File Offset: 0x003F333C
		public global::AcpBusinessLayer.AcpField<int> RadWideUserInformationandUserLoginUnitIDTextSize_41309
		{
			get
			{
				short num = (short)343315842;
				short num2 = num;
				num = (short)20288898;
				switch (num2 == num)
				{
				}
				num = (short)1615855616;
				short num3 = num;
				num = (short)1322188801;
				if (num != 0)
				{
				}
				num = (short)483393536;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309;
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x0600442C RID: 17452 RVA: 0x003F51EC File Offset: 0x003F33EC
		// (set) Token: 0x0600442D RID: 17453 RVA: 0x003F52A0 File Offset: 0x003F34A0
		public int RadWideUserInformationandUserLoginUnitIDTextSize_41309_UIValue
		{
			get
			{
				short num = (short)153642465;
				short num2 = num;
				num = (short)1868457441;
				switch (num2 == num)
				{
				}
				num = (short)267845632;
				short num3 = num;
				num = (short)283967488;
				if (num != 0)
				{
				}
				num = (short)84017153;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Value;
			}
			set
			{
				short num = (short)641772661;
				short num2 = num;
				num = (short)1859824757;
				switch (num2 == num)
				{
				}
				num = (short)1978728448;
				short num3 = num;
				num = (short)141164545;
				if (num != 0)
				{
				}
				num = (short)1833435136;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Value = value;
			}
		}

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600442E RID: 17454 RVA: 0x003F5358 File Offset: 0x003F3558
		// (set) Token: 0x0600442F RID: 17455 RVA: 0x003F540C File Offset: 0x003F360C
		public bool RadWideUserInformationandUserLoginUnitIDTextSize_41309_Applicable
		{
			get
			{
				short num = (short)817191699;
				short num2 = num;
				num = (short)962485011;
				switch (num2 == num)
				{
				}
				num = (short)1961558016;
				short num3 = num;
				num = (short)1354301441;
				if (num != 0)
				{
				}
				num = (short)1058471936;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Applicable;
			}
			set
			{
				short num = (short)1949892609;
				if (num != 0)
				{
				}
				num = (short)2003609851;
				short num2 = num;
				num = (short)1021225211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1447690240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1990656000;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Applicable = value;
			}
		}

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x06004430 RID: 17456 RVA: 0x003F54C4 File Offset: 0x003F36C4
		// (set) Token: 0x06004431 RID: 17457 RVA: 0x003F557C File Offset: 0x003F377C
		public bool RadWideUserInformationandUserLoginUnitIDTextSize_41309_Valid
		{
			get
			{
				short num = (short)928505434;
				short num2 = num;
				num = (short)1479401050;
				switch (num2 == num)
				{
				}
				num = (short)547225600;
				short num3 = num;
				num = (short)1107886081;
				if (num != 0)
				{
				}
				num = (short)553320448;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Valid;
			}
			set
			{
				short num = (short)1920043334;
				short num2 = num;
				num = (short)173246790;
				switch (num2 == num)
				{
				}
				num = (short)152109056;
				short num3 = num;
				num = (short)97976321;
				if (num != 0)
				{
				}
				num = (short)1369571328;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Valid = value;
			}
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x003F5634 File Offset: 0x003F3834
		// (set) Token: 0x06004433 RID: 17459 RVA: 0x003F56E8 File Offset: 0x003F38E8
		public bool RadWideUserInformationandUserLoginUnitIDTextSize_41309_Visible
		{
			get
			{
				short num = (short)456729882;
				short num2 = num;
				num = (short)1762534682;
				switch (num2 == num)
				{
				}
				num = (short)1576206336;
				short num3 = num;
				num = (short)517734401;
				if (num != 0)
				{
				}
				num = (short)259325952;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Visible;
			}
			set
			{
				short num = (short)1143247049;
				short num2 = num;
				num = (short)138121417;
				switch (num2 == num)
				{
				}
				num = (short)631635968;
				short num3 = num;
				num = (short)1507328000;
				if (num != 0)
				{
				}
				num = (short)1396047873;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Visible = value;
			}
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x06004434 RID: 17460 RVA: 0x003F57A4 File Offset: 0x003F39A4
		// (set) Token: 0x06004435 RID: 17461 RVA: 0x003F5858 File Offset: 0x003F3A58
		public bool RadWideUserInformationandUserLoginUnitIDTextSize_41309_Editable
		{
			get
			{
				short num = (short)1837370744;
				short num2 = num;
				num = (short)1937968504;
				switch (num2 == num)
				{
				}
				num = (short)730595328;
				short num3 = num;
				num = (short)1286668289;
				if (num != 0)
				{
				}
				num = (short)795410432;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Editable;
			}
			set
			{
				short num = (short)75386194;
				short num2 = num;
				num = (short)473976146;
				switch (num2 == num)
				{
				}
				num = (short)167378944;
				short num3 = num;
				num = (short)562757632;
				if (num != 0)
				{
				}
				num = (short)229244929;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDTextSize_41309.Editable = value;
			}
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x06004436 RID: 17462 RVA: 0x003F590C File Offset: 0x003F3B0C
		internal string RadWideUserInformationandUserLoginUnitIDTextSize_41309_UILabel
		{
			get
			{
				short num = (short)277224853;
				short num2 = num;
				num = (short)1225530773;
				switch (num2 == num)
				{
				}
				num = (short)128581632;
				short num3 = num;
				num = (short)1826553856;
				if (num != 0)
				{
				}
				num = (short)203489281;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.UIName;
			}
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x06004437 RID: 17463 RVA: 0x003F59C0 File Offset: 0x003F3BC0
		// (set) Token: 0x06004438 RID: 17464 RVA: 0x003F5A74 File Offset: 0x003F3C74
		internal bool RadWideUserInformationandUserLoginUnitIDTextSize_41309_HiddenStatic
		{
			get
			{
				short num = (short)1783041502;
				short num2 = num;
				num = (short)315559390;
				switch (num2 == num)
				{
				}
				num = (short)869597184;
				short num3 = num;
				num = (short)180224001;
				if (num != 0)
				{
				}
				num = (short)138018816;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.HiddenStatic;
			}
			set
			{
				short num = (short)1079773573;
				short num2 = num;
				num = (short)2016348549;
				switch (num2 == num)
				{
				}
				num = (short)1382219776;
				short num3 = num;
				num = (short)1907884033;
				if (num != 0)
				{
				}
				num = (short)1641349120;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDTextSize_41309.HiddenStatic = value;
			}
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x06004439 RID: 17465 RVA: 0x003F5B28 File Offset: 0x003F3D28
		// (set) Token: 0x0600443A RID: 17466 RVA: 0x003F5BDC File Offset: 0x003F3DDC
		internal bool RadWideUserInformationandUserLoginUnitIDTextSize_41309_HiddenDynamic
		{
			get
			{
				short num = (short)1685316680;
				short num2 = num;
				num = (short)1185211464;
				switch (num2 == num)
				{
				}
				num = (short)2066677760;
				short num3 = num;
				num = (short)2053570560;
				if (num != 0)
				{
				}
				num = (short)1088815105;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309.HiddenDynamic;
			}
			set
			{
				short num = (short)736656683;
				short num2 = num;
				num = (short)920157483;
				switch (num2 == num)
				{
				}
				num = (short)331612160;
				short num3 = num;
				num = (short)703266817;
				if (num != 0)
				{
				}
				num = (short)131661824;
				if (num != 0)
				{
				}
				this.radWideUserInformationandUserLoginUnitIDTextSize_41309.HiddenDynamic = value;
			}
		}

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x0600443B RID: 17467 RVA: 0x003F5C90 File Offset: 0x003F3E90
		public bool RadWideUserInformationandUserLoginUnitIDTextSize_41309_HasDiffs
		{
			get
			{
				short num = (short)1773473558;
				short num2 = num;
				num = (short)1148129046;
				switch (num2 == num)
				{
				}
				num = (short)1342439424;
				short num3 = num;
				num = (short)356777985;
				if (num != 0)
				{
				}
				num = (short)1202257920;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandUserLoginUnitIDTextSize_41309._HasDiffs;
			}
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x0600443C RID: 17468 RVA: 0x003F5D44 File Offset: 0x003F3F44
		// (set) Token: 0x0600443D RID: 17469 RVA: 0x003F5DF8 File Offset: 0x003F3FF8
		public int RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582Value
		{
			get
			{
				short num = (short)1177042608;
				short num2 = num;
				num = (short)1862942384;
				switch (num2 == num)
				{
				}
				num = (short)1646526464;
				short num3 = num;
				num = (short)1302134785;
				if (num != 0)
				{
				}
				num = (short)1830158336;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Value;
			}
			set
			{
				short num = (short)869847927;
				short num2 = num;
				num = (short)1285870455;
				switch (num2 == num)
				{
				}
				num = (short)595001344;
				short num3 = num;
				num = (short)1458896897;
				if (num != 0)
				{
				}
				num = (short)1656094720;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Value = value;
			}
		}

		// Token: 0x17002312 RID: 8978
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x003F5EB0 File Offset: 0x003F40B0
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582
		{
			get
			{
				short num = (short)1028200422;
				short num2 = num;
				num = (short)1966544870;
				switch (num2 == num)
				{
				}
				num = (short)2006843392;
				short num3 = num;
				num = (short)314703873;
				if (num != 0)
				{
				}
				num = (short)1353318400;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582;
			}
		}

		// Token: 0x17002313 RID: 8979
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x003F5F60 File Offset: 0x003F4160
		// (set) Token: 0x06004440 RID: 17472 RVA: 0x003F6018 File Offset: 0x003F4218
		public string RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_UIValue
		{
			get
			{
				short num = (short)1600258049;
				if (num != 0)
				{
				}
				num = (short)842983715;
				short num2 = num;
				num = (short)710273315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1741291520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1236664320;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.UIValue;
			}
			set
			{
				short num = (short)280688376;
				short num2 = num;
				num = (short)929167096;
				switch (num2 == num)
				{
				}
				num = (short)447348736;
				short num3 = num;
				num = (short)1122631681;
				if (num != 0)
				{
				}
				num = (short)295829504;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.UIValue = value;
			}
		}

		// Token: 0x17002314 RID: 8980
		// (get) Token: 0x06004441 RID: 17473 RVA: 0x003F60CC File Offset: 0x003F42CC
		// (set) Token: 0x06004442 RID: 17474 RVA: 0x003F6184 File Offset: 0x003F4384
		internal int RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582Min
		{
			get
			{
				short num = (short)906058404;
				short num2 = num;
				num = (short)830823076;
				switch (num2 == num)
				{
				}
				num = (short)60882944;
				short num3 = num;
				num = (short)279511041;
				if (num != 0)
				{
				}
				num = (short)643301376;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Min;
			}
			set
			{
				short num = (short)290991463;
				short num2 = num;
				num = (short)607530343;
				switch (num2 == num)
				{
				}
				num = (short)706936832;
				short num3 = num;
				num = (short)1881341953;
				if (num != 0)
				{
				}
				num = (short)1878261760;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Min = value;
			}
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x003F623C File Offset: 0x003F443C
		// (set) Token: 0x06004444 RID: 17476 RVA: 0x003F62F0 File Offset: 0x003F44F0
		internal int RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582Max
		{
			get
			{
				short num = (short)1548943361;
				if (num != 0)
				{
				}
				num = (short)1896882979;
				short num2 = num;
				num = (short)930030371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)998768640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660223488;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Max;
			}
			set
			{
				short num = (short)973290411;
				short num2 = num;
				num = (short)656358315;
				switch (num2 == num)
				{
				}
				num = (short)1718550528;
				short num3 = num;
				num = (short)1277231104;
				if (num != 0)
				{
				}
				num = (short)92012545;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Max = value;
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x003F63A8 File Offset: 0x003F45A8
		// (set) Token: 0x06004446 RID: 17478 RVA: 0x003F6460 File Offset: 0x003F4660
		internal int RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582Step
		{
			get
			{
				short num = (short)1715770461;
				short num2 = num;
				num = (short)85169245;
				switch (num2 == num)
				{
				}
				num = (short)1421541376;
				short num3 = num;
				num = (short)1505755137;
				if (num != 0)
				{
				}
				num = (short)180748288;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.StepSize;
			}
			set
			{
				short num = (short)1623537751;
				short num2 = num;
				num = (short)579352663;
				switch (num2 == num)
				{
				}
				num = (short)308215808;
				short num3 = num;
				num = (short)1073283073;
				if (num != 0)
				{
				}
				num = (short)856752128;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.StepSize = value;
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x003F6514 File Offset: 0x003F4714
		// (set) Token: 0x06004448 RID: 17480 RVA: 0x003F65C8 File Offset: 0x003F47C8
		public bool RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_Applicable
		{
			get
			{
				short num = (short)746192897;
				if (num != 0)
				{
				}
				num = (short)410921327;
				short num2 = num;
				num = (short)167520623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1699545088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)725745664;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Applicable;
			}
			set
			{
				short num = (short)742282075;
				short num2 = num;
				num = (short)1223840603;
				switch (num2 == num)
				{
				}
				num = (short)1534132224;
				short num3 = num;
				num = (short)162594817;
				if (num != 0)
				{
				}
				num = (short)843972608;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Applicable = value;
			}
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x06004449 RID: 17481 RVA: 0x003F667C File Offset: 0x003F487C
		// (set) Token: 0x0600444A RID: 17482 RVA: 0x003F6730 File Offset: 0x003F4930
		public bool RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_Valid
		{
			get
			{
				short num = (short)596091353;
				short num2 = num;
				num = (short)997433817;
				switch (num2 == num)
				{
				}
				num = (short)416022528;
				short num3 = num;
				num = (short)325844992;
				if (num != 0)
				{
				}
				num = (short)434831361;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Valid;
			}
			set
			{
				short num = (short)1880584552;
				short num2 = num;
				num = (short)834629992;
				switch (num2 == num)
				{
				}
				num = (short)1720909824;
				short num3 = num;
				num = (short)2064252929;
				if (num != 0)
				{
				}
				num = (short)1286471680;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Valid = value;
			}
		}

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x003F67E8 File Offset: 0x003F49E8
		// (set) Token: 0x0600444C RID: 17484 RVA: 0x003F689C File Offset: 0x003F4A9C
		public bool RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_Visible
		{
			get
			{
				short num = (short)1322320725;
				short num2 = num;
				num = (short)409076565;
				switch (num2 == num)
				{
				}
				num = (short)1119813632;
				short num3 = num;
				num = (short)990117889;
				if (num != 0)
				{
				}
				num = (short)1226440704;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Visible;
			}
			set
			{
				short num = (short)651358700;
				short num2 = num;
				num = (short)582939116;
				switch (num2 == num)
				{
				}
				num = (short)1691090944;
				short num3 = num;
				num = (short)1655177216;
				if (num != 0)
				{
				}
				num = (short)238616577;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Visible = value;
			}
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x003F6954 File Offset: 0x003F4B54
		// (set) Token: 0x0600444E RID: 17486 RVA: 0x003F6A08 File Offset: 0x003F4C08
		public bool RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_Editable
		{
			get
			{
				short num = (short)353067080;
				short num2 = num;
				num = (short)1209229384;
				switch (num2 == num)
				{
				}
				num = (short)1545207808;
				short num3 = num;
				num = (short)946208769;
				if (num != 0)
				{
				}
				num = (short)2036989952;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Editable;
			}
			set
			{
				short num = (short)436207617;
				if (num != 0)
				{
				}
				num = (short)1849343589;
				short num2 = num;
				num = (short)342343269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2099118080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1035730944;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.Editable = value;
			}
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x003F6ABC File Offset: 0x003F4CBC
		internal string RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_UILabel
		{
			get
			{
				short num = (short)1747167374;
				short num2 = num;
				num = (short)676636814;
				switch (num2 == num)
				{
				}
				num = (short)218824704;
				short num3 = num;
				num = (short)873136128;
				if (num != 0)
				{
				}
				num = (short)899743745;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.UIName;
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x003F6B70 File Offset: 0x003F4D70
		// (set) Token: 0x06004451 RID: 17489 RVA: 0x003F6C24 File Offset: 0x003F4E24
		internal bool RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_HiddenStatic
		{
			get
			{
				short num = (short)489883508;
				short num2 = num;
				num = (short)293341044;
				switch (num2 == num)
				{
				}
				num = (short)719585280;
				short num3 = num;
				num = (short)1140785153;
				if (num != 0)
				{
				}
				num = (short)626458624;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.HiddenStatic;
			}
			set
			{
				short num = (short)784884536;
				short num2 = num;
				num = (short)1182753592;
				switch (num2 == num)
				{
				}
				num = (short)839647232;
				short num3 = num;
				num = (short)900661249;
				if (num != 0)
				{
				}
				num = (short)2062680064;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.HiddenStatic = value;
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x003F6CD8 File Offset: 0x003F4ED8
		// (set) Token: 0x06004453 RID: 17491 RVA: 0x003F6D8C File Offset: 0x003F4F8C
		internal bool RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_HiddenDynamic
		{
			get
			{
				short num = (short)1668867710;
				short num2 = num;
				num = (short)698672766;
				switch (num2 == num)
				{
				}
				num = (short)561381376;
				short num3 = num;
				num = (short)1013579776;
				if (num != 0)
				{
				}
				num = (short)139526145;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.HiddenDynamic;
			}
			set
			{
				short num = (short)1974387799;
				short num2 = num;
				num = (short)653837399;
				switch (num2 == num)
				{
				}
				num = (short)1207238656;
				short num3 = num;
				num = (short)1351548929;
				if (num != 0)
				{
				}
				num = (short)623706112;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.HiddenDynamic = value;
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x06004454 RID: 17492 RVA: 0x003F6E40 File Offset: 0x003F5040
		public bool RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582_HasDiffs
		{
			get
			{
				short num = (short)254971352;
				short num2 = num;
				num = (short)2043121112;
				switch (num2 == num)
				{
				}
				num = (short)861732864;
				short num3 = num;
				num = (short)458686464;
				if (num != 0)
				{
				}
				num = (short)701562881;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582._HasDiffs;
			}
		}

		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x06004455 RID: 17493 RVA: 0x003F6EF4 File Offset: 0x003F50F4
		// (set) Token: 0x06004456 RID: 17494 RVA: 0x003F6FA8 File Offset: 0x003F51A8
		public bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584Value
		{
			get
			{
				short num = (short)1109901430;
				short num2 = num;
				num = (short)1841479798;
				switch (num2 == num)
				{
				}
				num = (short)930742272;
				short num3 = num;
				num = (short)1751646209;
				if (num != 0)
				{
				}
				num = (short)1902116864;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Value;
			}
			set
			{
				short num = (short)1043107627;
				short num2 = num;
				num = (short)2053017387;
				switch (num2 == num)
				{
				}
				num = (short)13500416;
				short num3 = num;
				num = (short)1048379393;
				if (num != 0)
				{
				}
				num = (short)1513947136;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Value = value;
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x06004457 RID: 17495 RVA: 0x003F7060 File Offset: 0x003F5260
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584
		{
			get
			{
				short num = (short)261506138;
				short num2 = num;
				num = (short)1456555098;
				switch (num2 == num)
				{
				}
				num = (short)1532362752;
				short num3 = num;
				num = (short)1836253184;
				if (num != 0)
				{
				}
				num = (short)961019905;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584;
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x003F7110 File Offset: 0x003F5310
		// (set) Token: 0x06004459 RID: 17497 RVA: 0x003F71C8 File Offset: 0x003F53C8
		public bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_UIValue
		{
			get
			{
				short num = (short)1254555649;
				if (num != 0)
				{
				}
				num = (short)1871597750;
				short num2 = num;
				num = (short)402542774;
				switch (num2 == num)
				{
				default:
				{
					num = (short)924254208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1182728192;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Value;
			}
			set
			{
				short num = (short)735095563;
				short num2 = num;
				num = (short)19835659;
				switch (num2 == num)
				{
				}
				num = (short)967507968;
				short num3 = num;
				num = (short)166199297;
				if (num != 0)
				{
				}
				num = (short)642908160;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Value = value;
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x003F727C File Offset: 0x003F547C
		// (set) Token: 0x0600445B RID: 17499 RVA: 0x003F7330 File Offset: 0x003F5530
		public bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_Applicable
		{
			get
			{
				short num = (short)2130635858;
				short num2 = num;
				num = (short)1611983954;
				switch (num2 == num)
				{
				}
				num = (short)1877278720;
				short num3 = num;
				num = (short)1946288129;
				if (num != 0)
				{
				}
				num = (short)528744448;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Applicable;
			}
			set
			{
				short num = (short)1025376257;
				if (num != 0)
				{
				}
				num = (short)360864468;
				short num2 = num;
				num = (short)296377044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1454112768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)381550592;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Applicable = value;
			}
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x0600445C RID: 17500 RVA: 0x003F73E4 File Offset: 0x003F55E4
		// (set) Token: 0x0600445D RID: 17501 RVA: 0x003F7498 File Offset: 0x003F5698
		public bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_Valid
		{
			get
			{
				short num = (short)722909338;
				short num2 = num;
				num = (short)1045674138;
				switch (num2 == num)
				{
				}
				num = (short)2134704128;
				short num3 = num;
				num = (short)143982592;
				if (num != 0)
				{
				}
				num = (short)1819279361;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Valid;
			}
			set
			{
				short num = (short)856489985;
				if (num != 0)
				{
				}
				num = (short)620979938;
				short num2 = num;
				num = (short)788752098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)230162432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)494075904;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Valid = value;
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x0600445E RID: 17502 RVA: 0x003F7550 File Offset: 0x003F5750
		// (set) Token: 0x0600445F RID: 17503 RVA: 0x003F7604 File Offset: 0x003F5804
		public bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_Visible
		{
			get
			{
				short num = (short)1107108884;
				short num2 = num;
				num = (short)812000276;
				switch (num2 == num)
				{
				}
				num = (short)1272840192;
				short num3 = num;
				num = (short)1563361280;
				if (num != 0)
				{
				}
				num = (short)917504001;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Visible;
			}
			set
			{
				short num = (short)904986625;
				if (num != 0)
				{
				}
				num = (short)361254184;
				short num2 = num;
				num = (short)1035619624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)996737024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1130889216;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Visible = value;
			}
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x003F76B8 File Offset: 0x003F58B8
		// (set) Token: 0x06004461 RID: 17505 RVA: 0x003F7770 File Offset: 0x003F5970
		public bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_Editable
		{
			get
			{
				short num = (short)1715980869;
				short num2 = num;
				num = (short)439011909;
				switch (num2 == num)
				{
				}
				num = (short)378667008;
				short num3 = num;
				num = (short)2043740161;
				if (num != 0)
				{
				}
				num = (short)1651310592;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Editable;
			}
			set
			{
				short num = (short)1269366785;
				if (num != 0)
				{
				}
				num = (short)567053323;
				short num2 = num;
				num = (short)1955302411;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1849884672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1004404736;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.Editable = value;
			}
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x06004462 RID: 17506 RVA: 0x003F7824 File Offset: 0x003F5A24
		internal string RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_UILabel
		{
			get
			{
				short num = (short)727228041;
				short num2 = num;
				num = (short)1212718729;
				switch (num2 == num)
				{
				}
				num = (short)1178730496;
				short num3 = num;
				num = (short)625410049;
				if (num != 0)
				{
				}
				num = (short)2075787264;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.UIName;
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x003F78D8 File Offset: 0x003F5AD8
		// (set) Token: 0x06004464 RID: 17508 RVA: 0x003F798C File Offset: 0x003F5B8C
		internal bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_HiddenStatic
		{
			get
			{
				short num = (short)380832573;
				short num2 = num;
				num = (short)1383992125;
				switch (num2 == num)
				{
				}
				num = (short)646053888;
				short num3 = num;
				num = (short)1151074305;
				if (num != 0)
				{
				}
				num = (short)1911816192;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.HiddenStatic;
			}
			set
			{
				short num = (short)1199341326;
				short num2 = num;
				num = (short)1536786190;
				switch (num2 == num)
				{
				}
				num = (short)1421148160;
				short num3 = num;
				num = (short)471597056;
				if (num != 0)
				{
				}
				num = (short)271187969;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.HiddenStatic = value;
			}
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x06004465 RID: 17509 RVA: 0x003F7A44 File Offset: 0x003F5C44
		// (set) Token: 0x06004466 RID: 17510 RVA: 0x003F7AF8 File Offset: 0x003F5CF8
		internal bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_HiddenDynamic
		{
			get
			{
				short num = (short)2036217840;
				short num2 = num;
				num = (short)1907570672;
				switch (num2 == num)
				{
				}
				num = (short)1738276864;
				short num3 = num;
				num = (short)1028521985;
				if (num != 0)
				{
				}
				num = (short)1561198592;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.HiddenDynamic;
			}
			set
			{
				short num = (short)651062608;
				short num2 = num;
				num = (short)949513552;
				switch (num2 == num)
				{
				}
				num = (short)828309504;
				short num3 = num;
				num = (short)1092550657;
				if (num != 0)
				{
				}
				num = (short)1708523520;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.HiddenDynamic = value;
			}
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x003F7BAC File Offset: 0x003F5DAC
		public bool RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584_HasDiffs
		{
			get
			{
				short num = (short)1065372156;
				short num2 = num;
				num = (short)869353980;
				switch (num2 == num)
				{
				}
				num = (short)713555968;
				short num3 = num;
				num = (short)1448607745;
				if (num != 0)
				{
				}
				num = (short)418250752;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584._HasDiffs;
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x06004468 RID: 17512 RVA: 0x003F7C60 File Offset: 0x003F5E60
		// (set) Token: 0x06004469 RID: 17513 RVA: 0x003F7D14 File Offset: 0x003F5F14
		public bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583Value
		{
			get
			{
				short num = (short)1234391279;
				short num2 = num;
				num = (short)445010159;
				switch (num2 == num)
				{
				}
				num = (short)529661952;
				short num3 = num;
				num = (short)980615168;
				if (num != 0)
				{
				}
				num = (short)1498480641;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Value;
			}
			set
			{
				short num = (short)647756715;
				short num2 = num;
				num = (short)1409219499;
				switch (num2 == num)
				{
				}
				num = (short)731119616;
				short num3 = num;
				num = (short)137166849;
				if (num != 0)
				{
				}
				num = (short)802553856;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Value = value;
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x0600446A RID: 17514 RVA: 0x003F7DCC File Offset: 0x003F5FCC
		public global::AcpBusinessLayer.AcpField<bool> RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583
		{
			get
			{
				short num = (short)717307246;
				short num2 = num;
				num = (short)1324957038;
				switch (num2 == num)
				{
				}
				num = (short)416153600;
				short num3 = num;
				num = (short)981925889;
				if (num != 0)
				{
				}
				num = (short)1983315968;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x003F7E80 File Offset: 0x003F6080
		// (set) Token: 0x0600446C RID: 17516 RVA: 0x003F7F34 File Offset: 0x003F6134
		public bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_UIValue
		{
			get
			{
				short num = (short)995126175;
				short num2 = num;
				num = (short)1399155615;
				switch (num2 == num)
				{
				}
				num = (short)1945370624;
				short num3 = num;
				num = (short)77660161;
				if (num != 0)
				{
				}
				num = (short)1614741504;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Value;
			}
			set
			{
				short num = (short)54647786;
				short num2 = num;
				num = (short)259644394;
				switch (num2 == num)
				{
				}
				num = (short)2034434048;
				short num3 = num;
				num = (short)1607925761;
				if (num != 0)
				{
				}
				num = (short)1102184448;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Value = value;
			}
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x003F7FE8 File Offset: 0x003F61E8
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x003F809C File Offset: 0x003F629C
		public bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_Applicable
		{
			get
			{
				short num = (short)2052849665;
				if (num != 0)
				{
				}
				num = (short)2007439936;
				short num2 = num;
				num = (short)933108288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1147863040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729612288;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Applicable;
			}
			set
			{
				short num = (short)2040273905;
				short num2 = num;
				num = (short)643898353;
				switch (num2 == num)
				{
				}
				num = (short)1070399488;
				short num3 = num;
				num = (short)1250230273;
				if (num != 0)
				{
				}
				num = (short)1356595200;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Applicable = value;
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x003F8150 File Offset: 0x003F6350
		// (set) Token: 0x06004470 RID: 17520 RVA: 0x003F8200 File Offset: 0x003F6400
		public bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_Valid
		{
			get
			{
				short num = (short)1130146108;
				short num2 = num;
				num = (short)147695932;
				switch (num2 == num)
				{
				}
				num = (short)207159296;
				short num3 = num;
				num = (short)77725697;
				if (num != 0)
				{
				}
				num = (short)1383137280;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Valid;
			}
			set
			{
				short num = (short)155330018;
				short num2 = num;
				num = (short)2122917346;
				switch (num2 == num)
				{
				}
				num = (short)582811648;
				short num3 = num;
				num = (short)267255808;
				if (num != 0)
				{
				}
				num = (short)142540801;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Valid = value;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x06004471 RID: 17521 RVA: 0x003F82B4 File Offset: 0x003F64B4
		// (set) Token: 0x06004472 RID: 17522 RVA: 0x003F8368 File Offset: 0x003F6568
		public bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_Visible
		{
			get
			{
				short num = (short)957142173;
				short num2 = num;
				num = (short)1871893661;
				switch (num2 == num)
				{
				}
				num = (short)437911552;
				short num3 = num;
				num = (short)167641089;
				if (num != 0)
				{
				}
				num = (short)1778778112;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Visible;
			}
			set
			{
				short num = (short)1999306753;
				if (num != 0)
				{
				}
				num = (short)385615778;
				short num2 = num;
				num = (short)319621026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)796524544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053242880;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Visible = value;
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x003F841C File Offset: 0x003F661C
		// (set) Token: 0x06004474 RID: 17524 RVA: 0x003F84D0 File Offset: 0x003F66D0
		public bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_Editable
		{
			get
			{
				short num = (short)1736170360;
				short num2 = num;
				num = (short)1985928056;
				switch (num2 == num)
				{
				}
				num = (short)921239552;
				short num3 = num;
				num = (short)1444675585;
				if (num != 0)
				{
				}
				num = (short)1712259072;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Editable;
			}
			set
			{
				short num = (short)622259448;
				short num2 = num;
				num = (short)1556344056;
				switch (num2 == num)
				{
				}
				num = (short)248709120;
				short num3 = num;
				num = (short)1814953984;
				if (num != 0)
				{
				}
				num = (short)2017722369;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.Editable = value;
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x06004475 RID: 17525 RVA: 0x003F8588 File Offset: 0x003F6788
		internal string RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_UILabel
		{
			get
			{
				short num = (short)1487098766;
				short num2 = num;
				num = (short)1233736590;
				switch (num2 == num)
				{
				}
				num = (short)1373962240;
				short num3 = num;
				num = (short)1004011521;
				if (num != 0)
				{
				}
				num = (short)1453981696;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.UIName;
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x003F863C File Offset: 0x003F683C
		// (set) Token: 0x06004477 RID: 17527 RVA: 0x003F86F0 File Offset: 0x003F68F0
		internal bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_HiddenStatic
		{
			get
			{
				short num = (short)1970077697;
				if (num != 0)
				{
				}
				num = (short)307059531;
				short num2 = num;
				num = (short)26303307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)653262848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1879638016;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.HiddenStatic;
			}
			set
			{
				short num = (short)295108609;
				if (num != 0)
				{
				}
				num = (short)513881729;
				short num2 = num;
				num = (short)749876865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1936326656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1592131584;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.HiddenStatic = value;
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x003F87A4 File Offset: 0x003F69A4
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x003F885C File Offset: 0x003F6A5C
		internal bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_HiddenDynamic
		{
			get
			{
				short num = (short)602786680;
				short num2 = num;
				num = (short)920832888;
				switch (num2 == num)
				{
				}
				num = (short)15663104;
				short num3 = num;
				num = (short)2091581440;
				if (num != 0)
				{
				}
				num = (short)2133983233;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.HiddenDynamic;
			}
			set
			{
				short num = (short)1841555725;
				short num2 = num;
				num = (short)1862330637;
				switch (num2 == num)
				{
				}
				num = (short)5636096;
				short num3 = num;
				num = (short)313524225;
				if (num != 0)
				{
				}
				num = (short)1820655616;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.HiddenDynamic = value;
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x003F8914 File Offset: 0x003F6B14
		public bool RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583_HasDiffs
		{
			get
			{
				short num = (short)1324012140;
				short num2 = num;
				num = (short)297325164;
				switch (num2 == num)
				{
				}
				num = (short)2107899904;
				short num3 = num;
				num = (short)2080243712;
				if (num != 0)
				{
				}
				num = (short)1758658561;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583._HasDiffs;
			}
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x003F89C8 File Offset: 0x003F6BC8
		// (set) Token: 0x0600447C RID: 17532 RVA: 0x003F8A80 File Offset: 0x003F6C80
		public string RadWideConventionalDynamicIDWithPassword_A43705Value
		{
			get
			{
				short num = (short)1934295041;
				if (num != 0)
				{
				}
				num = (short)1359777951;
				short num2 = num;
				num = (short)717656223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)549453824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1548222464;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.Value;
			}
			set
			{
				short num = (short)1331079178;
				short num2 = num;
				num = (short)1605740554;
				switch (num2 == num)
				{
				}
				num = (short)1698365440;
				short num3 = num;
				num = (short)1250230273;
				if (num != 0)
				{
				}
				num = (short)881655808;
				if (num != 0)
				{
				}
				this.radWideConventionalDynamicIDWithPassword_A43705.Value = value;
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x003F8B38 File Offset: 0x003F6D38
		public global::AcpBusinessLayer.AcpField<string> RadWideConventionalDynamicIDWithPassword_A43705
		{
			get
			{
				short num = (short)1775164802;
				short num2 = num;
				num = (short)290905474;
				switch (num2 == num)
				{
				}
				num = (short)254869504;
				short num3 = num;
				num = (short)173342721;
				if (num != 0)
				{
				}
				num = (short)1549664256;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705;
			}
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x003F8BE8 File Offset: 0x003F6DE8
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x003F8CA0 File Offset: 0x003F6EA0
		public string RadWideConventionalDynamicIDWithPassword_A43705_UIValue
		{
			get
			{
				short num = (short)1784807425;
				if (num != 0)
				{
				}
				num = (short)415920340;
				short num2 = num;
				num = (short)1141207252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255473152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1748238336;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.Value;
			}
			set
			{
				short num = (short)869395576;
				short num2 = num;
				num = (short)1260645496;
				switch (num2 == num)
				{
				}
				num = (short)1499529216;
				short num3 = num;
				num = (short)1905328129;
				if (num != 0)
				{
				}
				num = (short)743702528;
				if (num != 0)
				{
				}
				this.radWideConventionalDynamicIDWithPassword_A43705.Value = value;
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x003F8D54 File Offset: 0x003F6F54
		// (set) Token: 0x06004481 RID: 17537 RVA: 0x003F8E08 File Offset: 0x003F7008
		public bool RadWideConventionalDynamicIDWithPassword_A43705_Applicable
		{
			get
			{
				short num = (short)1297940481;
				if (num != 0)
				{
				}
				num = (short)1946648005;
				short num2 = num;
				num = (short)1608220101;
				switch (num2 == num)
				{
				default:
				{
					num = (short)67436544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2133458944;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.Applicable;
			}
			set
			{
				short num = (short)774906943;
				short num2 = num;
				num = (short)769467455;
				switch (num2 == num)
				{
				}
				num = (short)6356992;
				short num3 = num;
				num = (short)634781697;
				if (num != 0)
				{
				}
				num = (short)1593311232;
				if (num != 0)
				{
				}
				this.radWideConventionalDynamicIDWithPassword_A43705.Applicable = value;
			}
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x003F8EBC File Offset: 0x003F70BC
		// (set) Token: 0x06004483 RID: 17539 RVA: 0x003F8F70 File Offset: 0x003F7170
		public bool RadWideConventionalDynamicIDWithPassword_A43705_Valid
		{
			get
			{
				short num = (short)432013313;
				if (num != 0)
				{
				}
				num = (short)1940404496;
				short num2 = num;
				num = (short)1108162832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1268449280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273167872;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.Valid;
			}
			set
			{
				short num = (short)638543329;
				short num2 = num;
				num = (short)1244554721;
				switch (num2 == num)
				{
				}
				num = (short)10551296;
				short num3 = num;
				num = (short)14352384;
				if (num != 0)
				{
				}
				num = (short)1872035841;
				if (num != 0)
				{
				}
				this.radWideConventionalDynamicIDWithPassword_A43705.Valid = value;
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x06004484 RID: 17540 RVA: 0x003F9028 File Offset: 0x003F7228
		// (set) Token: 0x06004485 RID: 17541 RVA: 0x003F90E0 File Offset: 0x003F72E0
		public bool RadWideConventionalDynamicIDWithPassword_A43705_Visible
		{
			get
			{
				short num = (short)2130378753;
				if (num != 0)
				{
				}
				num = (short)1789116862;
				short num2 = num;
				num = (short)933085630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)367722496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)757202944;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.Visible;
			}
			set
			{
				short num = (short)1007989543;
				short num2 = num;
				num = (short)1822602023;
				switch (num2 == num)
				{
				}
				num = (short)1463418880;
				short num3 = num;
				num = (short)1084620801;
				if (num != 0)
				{
				}
				num = (short)1421541376;
				if (num != 0)
				{
				}
				this.radWideConventionalDynamicIDWithPassword_A43705.Visible = value;
			}
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x06004486 RID: 17542 RVA: 0x003F9194 File Offset: 0x003F7394
		// (set) Token: 0x06004487 RID: 17543 RVA: 0x003F924C File Offset: 0x003F744C
		public bool RadWideConventionalDynamicIDWithPassword_A43705_Editable
		{
			get
			{
				short num = (short)1772355585;
				if (num != 0)
				{
				}
				num = (short)784214399;
				short num2 = num;
				num = (short)1888233855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1086128128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)240451584;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.Editable;
			}
			set
			{
				short num = (short)1568001923;
				short num2 = num;
				num = (short)942198659;
				switch (num2 == num)
				{
				}
				num = (short)270401536;
				short num3 = num;
				num = (short)346488833;
				if (num != 0)
				{
				}
				num = (short)2070872064;
				if (num != 0)
				{
				}
				this.radWideConventionalDynamicIDWithPassword_A43705.Editable = value;
			}
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x003F9300 File Offset: 0x003F7500
		internal string RadWideConventionalDynamicIDWithPassword_A43705_UILabel
		{
			get
			{
				short num = (short)1869673959;
				short num2 = num;
				num = (short)260109799;
				switch (num2 == num)
				{
				}
				num = (short)1453981696;
				short num3 = num;
				num = (short)1669398528;
				if (num != 0)
				{
				}
				num = (short)63307777;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.UIName;
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x06004489 RID: 17545 RVA: 0x003F93B4 File Offset: 0x003F75B4
		// (set) Token: 0x0600448A RID: 17546 RVA: 0x003F946C File Offset: 0x003F766C
		internal bool RadWideConventionalDynamicIDWithPassword_A43705_HiddenStatic
		{
			get
			{
				short num = (short)1477549185;
				short num2 = num;
				num = (short)1258593409;
				switch (num2 == num)
				{
				}
				num = (short)338034688;
				short num3 = num;
				num = (short)472252417;
				if (num != 0)
				{
				}
				num = (short)1239023616;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.HiddenStatic;
			}
			set
			{
				short num = (short)1281782632;
				short num2 = num;
				num = (short)884306792;
				switch (num2 == num)
				{
				}
				num = (short)737935360;
				short num3 = num;
				num = (short)2146172929;
				if (num != 0)
				{
				}
				num = (short)1187250176;
				if (num != 0)
				{
				}
				this.radWideConventionalDynamicIDWithPassword_A43705.HiddenStatic = value;
			}
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x003F9524 File Offset: 0x003F7724
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x003F95D8 File Offset: 0x003F77D8
		internal bool RadWideConventionalDynamicIDWithPassword_A43705_HiddenDynamic
		{
			get
			{
				short num = (short)1533252141;
				short num2 = num;
				num = (short)1424855597;
				switch (num2 == num)
				{
				}
				num = (short)1038942208;
				short num3 = num;
				num = (short)1492844545;
				if (num != 0)
				{
				}
				num = (short)1897005056;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705.HiddenDynamic;
			}
			set
			{
				short num = (short)1033208583;
				short num2 = num;
				num = (short)652444423;
				switch (num2 == num)
				{
				}
				num = (short)1890451456;
				short num3 = num;
				num = (short)838402048;
				if (num != 0)
				{
				}
				num = (short)1856634881;
				if (num != 0)
				{
				}
				this.radWideConventionalDynamicIDWithPassword_A43705.HiddenDynamic = value;
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x003F9690 File Offset: 0x003F7890
		public bool RadWideConventionalDynamicIDWithPassword_A43705_HasDiffs
		{
			get
			{
				short num = (short)194782092;
				short num2 = num;
				num = (short)158475148;
				switch (num2 == num)
				{
				}
				num = (short)1305804800;
				short num3 = num;
				num = (short)1031864321;
				if (num != 0)
				{
				}
				num = (short)1456537600;
				if (num != 0)
				{
				}
				return this.radWideConventionalDynamicIDWithPassword_A43705._HasDiffs;
			}
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x0600448E RID: 17550 RVA: 0x003F9744 File Offset: 0x003F7944
		// (set) Token: 0x0600448F RID: 17551 RVA: 0x003F97F8 File Offset: 0x003F79F8
		public string RadWideUserInformationandPasswordsTacticalServiceEncodePasswordValue
		{
			get
			{
				short num = (short)102066287;
				short num2 = num;
				num = (short)2046453871;
				switch (num2 == num)
				{
				}
				num = (short)407371776;
				short num3 = num;
				num = (short)1700855809;
				if (num != 0)
				{
				}
				num = (short)490733568;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Value;
			}
			set
			{
				short num = (short)1491744374;
				short num2 = num;
				num = (short)1863136886;
				switch (num2 == num)
				{
				}
				num = (short)1661861888;
				short num3 = num;
				num = (short)591396864;
				if (num != 0)
				{
				}
				num = (short)1811677185;
				if (num != 0)
				{
				}
				this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Value = value;
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x003F98AC File Offset: 0x003F7AAC
		public global::AcpBusinessLayer.AcpField<string> RadWideUserInformationandPasswordsTacticalServiceEncodePassword
		{
			get
			{
				short num = (short)1278447385;
				short num2 = num;
				num = (short)1334611737;
				switch (num2 == num)
				{
				}
				num = (short)966918144;
				short num3 = num;
				num = (short)429260801;
				if (num != 0)
				{
				}
				num = (short)1924726784;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword;
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x003F995C File Offset: 0x003F7B5C
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x003F9A10 File Offset: 0x003F7C10
		public string RadWideUserInformationandPasswordsTacticalServiceEncodePassword_UIValue
		{
			get
			{
				short num = (short)1065370389;
				short num2 = num;
				num = (short)1043350293;
				switch (num2 == num)
				{
				}
				num = (short)1086586880;
				short num3 = num;
				num = (short)1115226112;
				if (num != 0)
				{
				}
				num = (short)930086913;
				if (num != 0)
				{
				}
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Value;
			}
			set
			{
				short num = (short)1724527857;
				short num2 = num;
				num = (short)691614961;
				switch (num2 == num)
				{
				}
				num = (short)332398593;
				if (num != 0)
				{
				}
				num = (short)1656750080;
				if (num != 0)
				{
				}
				num = (short)1930756096;
				short num3 = num;
				this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Value = value;
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x003F9AC8 File Offset: 0x003F7CC8
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x003F9B80 File Offset: 0x003F7D80
		public bool RadWideUserInformationandPasswordsTacticalServiceEncodePassword_Applicable
		{
			get
			{
				short num = (short)1262543869;
				short num2 = num;
				num = (short)1963451389;
				switch (num2 == num)
				{
				}
				num = (short)1578106881;
				if (num != 0)
				{
				}
				num = (short)2129723392;
				if (num != 0)
				{
				}
				num = (short)439484416;
				short num3 = num;
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Applicable;
			}
			set
			{
				short num = (short)1417084929;
				if (num != 0)
				{
				}
				num = (short)480010047;
				short num2 = num;
				num = (short)1723162431;
				switch (num2 == num)
				{
				}
				num = (short)1207894016;
				if (num != 0)
				{
				}
				num = (short)395902976;
				short num3 = num;
				this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Applicable = value;
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x003F9C34 File Offset: 0x003F7E34
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x003F9CE8 File Offset: 0x003F7EE8
		public bool RadWideUserInformationandPasswordsTacticalServiceEncodePassword_Valid
		{
			get
			{
				short num = (short)186665115;
				short num2 = num;
				num = (short)874858651;
				switch (num2 == num)
				{
				}
				num = (short)1485897729;
				if (num != 0)
				{
				}
				num = (short)1272840192;
				if (num != 0)
				{
				}
				num = (short)261816320;
				short num3 = num;
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Valid;
			}
			set
			{
				short num = (short)470900784;
				short num2 = num;
				num = (short)1704681520;
				switch (num2 == num)
				{
				}
				num = (short)367329281;
				if (num != 0)
				{
				}
				num = (short)1771241472;
				if (num != 0)
				{
				}
				num = (short)599654400;
				short num3 = num;
				this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Valid = value;
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x003F9DA0 File Offset: 0x003F7FA0
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x003F9E54 File Offset: 0x003F8054
		public bool RadWideUserInformationandPasswordsTacticalServiceEncodePassword_Visible
		{
			get
			{
				short num = (short)201422518;
				short num2 = num;
				num = (short)1384281782;
				switch (num2 == num)
				{
				}
				num = (short)463405057;
				if (num != 0)
				{
				}
				num = (short)1652031488;
				if (num != 0)
				{
				}
				num = (short)810811392;
				short num3 = num;
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Visible;
			}
			set
			{
				short num = (short)649998528;
				short num2 = num;
				num = (short)1280651456;
				switch (num2 == num)
				{
				}
				num = (short)110559232;
				if (num != 0)
				{
				}
				num = (short)750845953;
				if (num != 0)
				{
				}
				num = (short)1023148032;
				short num3 = num;
				this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Visible = value;
			}
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x003F9F08 File Offset: 0x003F8108
		// (set) Token: 0x0600449A RID: 17562 RVA: 0x003F9FC0 File Offset: 0x003F81C0
		public bool RadWideUserInformationandPasswordsTacticalServiceEncodePassword_Editable
		{
			get
			{
				short num = (short)1985282049;
				if (num != 0)
				{
				}
				num = (short)788752392;
				short num2 = num;
				num = (short)1064003592;
				switch (num2 == num)
				{
				}
				num = (short)261947392;
				if (num != 0)
				{
				}
				num = (short)948502528;
				short num3 = num;
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Editable;
			}
			set
			{
				short num = (short)798572485;
				short num2 = num;
				num = (short)65617861;
				switch (num2 == num)
				{
				}
				num = (short)7536641;
				if (num != 0)
				{
				}
				num = (short)1263403008;
				if (num != 0)
				{
				}
				num = (short)2105999360;
				short num3 = num;
				this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.Editable = value;
			}
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x003FA078 File Offset: 0x003F8278
		internal string RadWideUserInformationandPasswordsTacticalServiceEncodePassword_UILabel
		{
			get
			{
				short num = (short)664114688;
				short num2 = num;
				num = (short)1861654016;
				switch (num2 == num)
				{
				}
				num = (short)989134849;
				if (num != 0)
				{
				}
				num = (short)733282304;
				if (num != 0)
				{
				}
				num = (short)243204096;
				short num3 = num;
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.UIName;
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x003FA130 File Offset: 0x003F8330
		// (set) Token: 0x0600449D RID: 17565 RVA: 0x003FA1E4 File Offset: 0x003F83E4
		internal bool RadWideUserInformationandPasswordsTacticalServiceEncodePassword_HiddenStatic
		{
			get
			{
				short num = (short)972580228;
				short num2 = num;
				num = (short)1823892868;
				switch (num2 == num)
				{
				}
				num = (short)762773505;
				if (num != 0)
				{
				}
				num = (short)1608318976;
				if (num != 0)
				{
				}
				num = (short)842399744;
				short num3 = num;
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.HiddenStatic;
			}
			set
			{
				short num = (short)243981488;
				short num2 = num;
				num = (short)692640944;
				switch (num2 == num)
				{
				}
				num = (short)1439301633;
				if (num != 0)
				{
				}
				num = (short)1971781632;
				if (num != 0)
				{
				}
				num = (short)1329004544;
				short num3 = num;
				this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.HiddenStatic = value;
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x0600449E RID: 17566 RVA: 0x003FA298 File Offset: 0x003F8498
		// (set) Token: 0x0600449F RID: 17567 RVA: 0x003FA34C File Offset: 0x003F854C
		internal bool RadWideUserInformationandPasswordsTacticalServiceEncodePassword_HiddenDynamic
		{
			get
			{
				short num = (short)1378853362;
				short num2 = num;
				num = (short)1207149042;
				switch (num2 == num)
				{
				}
				num = (short)2067922945;
				if (num != 0)
				{
				}
				num = (short)1054605312;
				if (num != 0)
				{
				}
				num = (short)1223163904;
				short num3 = num;
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.HiddenDynamic;
			}
			set
			{
				short num = (short)851407724;
				short num2 = num;
				num = (short)1893167980;
				switch (num2 == num)
				{
				}
				num = (short)1212809217;
				if (num != 0)
				{
				}
				num = (short)1878327296;
				if (num != 0)
				{
				}
				num = (short)750845952;
				short num3 = num;
				this.radWideUserInformationandPasswordsTacticalServiceEncodePassword.HiddenDynamic = value;
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x060044A0 RID: 17568 RVA: 0x003FA404 File Offset: 0x003F8604
		public bool RadWideUserInformationandPasswordsTacticalServiceEncodePassword_HasDiffs
		{
			get
			{
				short num = (short)2026015446;
				short num2 = num;
				num = (short)909544150;
				switch (num2 == num)
				{
				}
				num = (short)1356398593;
				if (num != 0)
				{
				}
				num = (short)1415118848;
				if (num != 0)
				{
				}
				num = (short)393805824;
				short num3 = num;
				return this.radWideUserInformationandPasswordsTacticalServiceEncodePassword._HasDiffs;
			}
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x003FA4B8 File Offset: 0x003F86B8
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x003FA56C File Offset: 0x003F876C
		public int RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926Value
		{
			get
			{
				short num = (short)1564540929;
				if (num != 0)
				{
				}
				num = (short)420630773;
				short num2 = num;
				num = (short)1253462261;
				switch (num2 == num)
				{
				}
				num = (short)668073984;
				if (num != 0)
				{
				}
				num = (short)24772608;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Value;
			}
			set
			{
				short num = (short)1306062298;
				short num2 = num;
				num = (short)924052954;
				switch (num2 == num)
				{
				}
				num = (short)1185546241;
				if (num != 0)
				{
				}
				num = (short)1594163200;
				if (num != 0)
				{
				}
				num = (short)62455808;
				short num3 = num;
				this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Value = value;
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x003FA620 File Offset: 0x003F8820
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x003FA6D0 File Offset: 0x003F88D0
		public string RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_UIValue
		{
			get
			{
				short num = (short)1377548202;
				short num2 = num;
				num = (short)2091366314;
				switch (num2 == num)
				{
				}
				num = (short)1322385408;
				if (num != 0)
				{
				}
				num = (short)109117441;
				if (num != 0)
				{
				}
				num = (short)1007026176;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.UIValue;
			}
			set
			{
				short num = (short)552927233;
				if (num != 0)
				{
				}
				num = (short)1325392175;
				short num2 = num;
				num = (short)1479663919;
				switch (num2 == num)
				{
				}
				num = (short)616562688;
				if (num != 0)
				{
				}
				num = (short)1813970944;
				short num3 = num;
				this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.UIValue = value;
			}
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x003FA784 File Offset: 0x003F8984
		public global::AcpBusinessLayer.AcpListField RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926
		{
			get
			{
				short num = (short)1876473360;
				short num2 = num;
				num = (short)637974032;
				switch (num2 == num)
				{
				}
				num = (short)1737949185;
				if (num != 0)
				{
				}
				num = (short)864354304;
				if (num != 0)
				{
				}
				num = (short)352059392;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926;
			}
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x003FA834 File Offset: 0x003F8A34
		// (set) Token: 0x060044A7 RID: 17575 RVA: 0x003FA8E8 File Offset: 0x003F8AE8
		public bool RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_Applicable
		{
			get
			{
				short num = (short)390326142;
				short num2 = num;
				num = (short)1540286334;
				switch (num2 == num)
				{
				}
				num = (short)1132396545;
				if (num != 0)
				{
				}
				num = (short)1798504448;
				if (num != 0)
				{
				}
				num = (short)1077477376;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Applicable;
			}
			set
			{
				short num = (short)1248359099;
				short num2 = num;
				num = (short)1882223291;
				switch (num2 == num)
				{
				}
				num = (short)1774125057;
				if (num != 0)
				{
				}
				num = (short)2106392576;
				if (num != 0)
				{
				}
				num = (short)637337600;
				short num3 = num;
				this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Applicable = value;
			}
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x003FA99C File Offset: 0x003F8B9C
		// (set) Token: 0x060044A9 RID: 17577 RVA: 0x003FAA54 File Offset: 0x003F8C54
		public bool RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_Valid
		{
			get
			{
				short num = (short)932883229;
				short num2 = num;
				num = (short)1206954781;
				switch (num2 == num)
				{
				}
				num = (short)1799553025;
				if (num != 0)
				{
				}
				num = (short)28049408;
				if (num != 0)
				{
				}
				num = (short)2129657856;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Valid;
			}
			set
			{
				short num = (short)1219508254;
				short num2 = num;
				num = (short)232011806;
				switch (num2 == num)
				{
				}
				num = (short)1542455296;
				if (num != 0)
				{
				}
				num = (short)1911095297;
				if (num != 0)
				{
				}
				num = (short)70123520;
				short num3 = num;
				this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Valid = value;
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x003FAB08 File Offset: 0x003F8D08
		// (set) Token: 0x060044AB RID: 17579 RVA: 0x003FABBC File Offset: 0x003F8DBC
		public bool RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_Visible
		{
			get
			{
				short num = (short)1994712464;
				short num2 = num;
				num = (short)1291576720;
				switch (num2 == num)
				{
				}
				num = (short)848297985;
				if (num != 0)
				{
				}
				num = (short)317718528;
				if (num != 0)
				{
				}
				num = (short)2074017792;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Visible;
			}
			set
			{
				short num = (short)933253238;
				short num2 = num;
				num = (short)176640118;
				switch (num2 == num)
				{
				}
				num = (short)1029767169;
				if (num != 0)
				{
				}
				num = (short)1369571328;
				if (num != 0)
				{
				}
				num = (short)1524432896;
				short num3 = num;
				this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Visible = value;
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x003FAC70 File Offset: 0x003F8E70
		// (set) Token: 0x060044AD RID: 17581 RVA: 0x003FAD24 File Offset: 0x003F8F24
		public bool RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_Editable
		{
			get
			{
				short num = (short)2008023041;
				if (num != 0)
				{
				}
				num = (short)1020583974;
				short num2 = num;
				num = (short)1144447014;
				switch (num2 == num)
				{
				}
				num = (short)2127429632;
				if (num != 0)
				{
				}
				num = (short)1536425984;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Editable;
			}
			set
			{
				short num = (short)104122653;
				short num2 = num;
				num = (short)63949085;
				switch (num2 == num)
				{
				}
				num = (short)967442433;
				if (num != 0)
				{
				}
				num = (short)1405812736;
				if (num != 0)
				{
				}
				num = (short)1096613888;
				short num3 = num;
				this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.Editable = value;
			}
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x003FADDC File Offset: 0x003F8FDC
		internal string RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_UILabel
		{
			get
			{
				short num = (short)1110376449;
				if (num != 0)
				{
				}
				num = (short)1338749817;
				short num2 = num;
				num = (short)984855417;
				switch (num2 == num)
				{
				}
				num = (short)1342046208;
				if (num != 0)
				{
				}
				num = (short)898498560;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.UIName;
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x060044AF RID: 17583 RVA: 0x003FAE90 File Offset: 0x003F9090
		// (set) Token: 0x060044B0 RID: 17584 RVA: 0x003FAF48 File Offset: 0x003F9148
		internal bool RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_HiddenStatic
		{
			get
			{
				short num = (short)774809580;
				short num2 = num;
				num = (short)228894700;
				switch (num2 == num)
				{
				}
				num = (short)1808334849;
				if (num != 0)
				{
				}
				num = (short)979697664;
				if (num != 0)
				{
				}
				num = (short)310444032;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.HiddenStatic;
			}
			set
			{
				short num = (short)633438365;
				short num2 = num;
				num = (short)423657629;
				switch (num2 == num)
				{
				}
				num = (short)1335689217;
				if (num != 0)
				{
				}
				num = (short)109117440;
				if (num != 0)
				{
				}
				num = (short)1943011328;
				short num3 = num;
				this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.HiddenStatic = value;
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x060044B1 RID: 17585 RVA: 0x003FB000 File Offset: 0x003F9200
		// (set) Token: 0x060044B2 RID: 17586 RVA: 0x003FB0B0 File Offset: 0x003F92B0
		internal bool RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_HiddenDynamic
		{
			get
			{
				short num = (short)1607244789;
				short num2 = num;
				num = (short)104373237;
				switch (num2 == num)
				{
				}
				num = (short)1416822784;
				if (num != 0)
				{
				}
				num = (short)1042481153;
				if (num != 0)
				{
				}
				num = (short)1258291200;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.HiddenDynamic;
			}
			set
			{
				short num = (short)101908870;
				short num2 = num;
				num = (short)1239482758;
				switch (num2 == num)
				{
				}
				num = (short)245760000;
				if (num != 0)
				{
				}
				num = (short)1894907905;
				if (num != 0)
				{
				}
				num = (short)2006384640;
				short num3 = num;
				this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.HiddenDynamic = value;
			}
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x060044B3 RID: 17587 RVA: 0x003FB164 File Offset: 0x003F9364
		public bool RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926_HasDiffs
		{
			get
			{
				short num = (short)2146067701;
				short num2 = num;
				num = (short)1411933429;
				switch (num2 == num)
				{
				}
				num = (short)2107047937;
				if (num != 0)
				{
				}
				num = (short)2013200384;
				if (num != 0)
				{
				}
				num = (short)1376780288;
				short num3 = num;
				return this.radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926._HasDiffs;
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x003FB218 File Offset: 0x003F9418
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)449445889;
				if (num != 0)
				{
				}
				num = (short)560834705;
				short num2 = num;
				num = (short)1469687953;
				switch (num2 == num)
				{
				}
				num = (short)1800536064;
				if (num != 0)
				{
				}
				num = (short)2066874368;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x060044B5 RID: 17589 RVA: 0x003FB2D4 File Offset: 0x003F94D4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)551718103;
				short num2 = num;
				num = (short)1767673047;
				switch (num2 == num)
				{
				}
				num = (short)1987444737;
				if (num != 0)
				{
				}
				num = (short)1949696000;
				if (num != 0)
				{
				}
				num = (short)1203437568;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x003FB390 File Offset: 0x003F9590
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1193869312;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)1057328440;
					short num4 = num;
					num = (short)1170967864;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1006895104;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)290848771;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					num = (short)859963393;
					if (num != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num = (short)256376834;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)1591803908;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)509935616;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4D;
			}
			return result;
			IL_4D:
			result = null;
			num = (short)303497217;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04001A22 RID: 6690
		private global::AcpBusinessLayer.AcpField<string> radWideUserInformationandPasswordsPIN_A8705;

		// Token: 0x04001A23 RID: 6691
		private global::AcpBusinessLayer.AcpField<string> radWideUserInformationandPasswordsProtectedZonePassword_A8766;

		// Token: 0x04001A24 RID: 6692
		private global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsRadioAliasEnable_A8830;

		// Token: 0x04001A25 RID: 6693
		private global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsRadioLock_A8836;

		// Token: 0x04001A26 RID: 6694
		private global::AcpBusinessLayer.AcpFieldX<string, string> radWideUserInformationandPasswordsSoftIDUsername_A9169;

		// Token: 0x04001A27 RID: 6695
		private global::AcpBusinessLayer.AcpField<string> radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395;

		// Token: 0x04001A28 RID: 6696
		private global::AcpBusinessLayer.AcpField<bool> radWideUserInformationAndPasswordsTacticalInhibitEnable_A34405;

		// Token: 0x04001A29 RID: 6697
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;

		// Token: 0x04001A2A RID: 6698
		private global::AcpBusinessLayer.AcpField<bool> radWideUserinfoPassRequiredForGunlock_A36531;

		// Token: 0x04001A2B RID: 6699
		private global::AcpBusinessLayer.AcpField<bool> radWideUserinfoPassRequiredForLightbar_A36532;

		// Token: 0x04001A2C RID: 6700
		private global::AcpBusinessLayer.AcpField<bool> radWideUserinfoPassRequiredForSiren_A36533;

		// Token: 0x04001A2D RID: 6701
		private global::AcpBusinessLayer.AcpField<string> radWideUserInformationandPasswordsUnlockPassword_A8690;

		// Token: 0x04001A2E RID: 6702
		private global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsMandatoryPassword_A8461;

		// Token: 0x04001A2F RID: 6703
		private global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508;

		// Token: 0x04001A30 RID: 6704
		private global::AcpBusinessLayer.AcpField<string> radWideUserInformationandPasswordsRadioAlias_A8829;

		// Token: 0x04001A31 RID: 6705
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideUserInformationandPasswordsMaximumPasswordLength_A8477;

		// Token: 0x04001A32 RID: 6706
		private global::AcpBusinessLayer.AcpFieldX<string, string> radWideUserInformationandPINPassword_41303;

		// Token: 0x04001A33 RID: 6707
		private global::AcpBusinessLayer.AcpField<string> radWideUserInformationandPINPasswordPart2_41304;

		// Token: 0x04001A34 RID: 6708
		private global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandUserLoginUnitIDEnable_41305;

		// Token: 0x04001A35 RID: 6709
		private global::AcpBusinessLayer.AcpField<string> radWideUserInformationandUserLoginUnitID_41306;

		// Token: 0x04001A36 RID: 6710
		private global::AcpBusinessLayer.AcpListField radWideUserInformationandCachedCredentialsUserLoginMode_41307;

		// Token: 0x04001A37 RID: 6711
		private global::AcpBusinessLayer.AcpField<int> radWideUserInformationandUserLoginUnitIDTextSize_41309;

		// Token: 0x04001A38 RID: 6712
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582;

		// Token: 0x04001A39 RID: 6713
		private global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584;

		// Token: 0x04001A3A RID: 6714
		private global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;

		// Token: 0x04001A3B RID: 6715
		private global::AcpBusinessLayer.AcpField<string> radWideConventionalDynamicIDWithPassword_A43705;

		// Token: 0x04001A3C RID: 6716
		private global::AcpBusinessLayer.AcpField<string> radWideUserInformationandPasswordsTacticalServiceEncodePassword;

		// Token: 0x04001A3D RID: 6717
		private global::AcpBusinessLayer.AcpListField radWideUserInformationandPasswordsUserLoginAuthenticationType_A44926;
	}
}
