using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E9 RID: 233
	[global::System.Serializable]
	public class MDCOTAR : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600218B RID: 8587 RVA: 0x0021023C File Offset: 0x0020E43C
		public MDCOTAR(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00210258 File Offset: 0x0020E458
		protected MDCOTAR(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00210270 File Offset: 0x0020E470
		public override void Init()
		{
			int a_ = 17;
			short num = (short)802124284;
			short num2 = num;
			num = (short)1242919420;
			switch (num2 == num)
			{
			}
			num = (short)775487489;
			if (num != 0)
			{
			}
			num = (short)1306329088;
			short num3 = num;
			num = (short)1547042816;
			if (num != 0)
			{
			}
			this.secWideMDCOTAREnable_A7967 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫꯭黯鏱雳髵鷷ꗹ뷻짽㧿㐁㌃", a_), global::CommonResources.AcgResources.ID_OTARACKNOWLEDGEMENTSENABLE);
			this.secWideMDCOTAREnable_A7967.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTAREnable_A7967.DataTransferOrder = 6;
			this.secWideMDCOTAREncryptedOnly_A7971 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫꯭黯釱蛳迵裷軹駻髽俿氁栃缅圇䬉㬋㜍✏⌑", a_), global::CommonResources.AcgResources.ID_OTARACKNOWLEDGEMENTSENCRYPTEDONLY);
			this.secWideMDCOTAREncryptedOnly_A7971.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTAREncryptedOnly_A7971.DataTransferOrder = 32;
			this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫꯭苯鏱蟳鏵ꣷ裹駻製槿洁焃甅䄇搉栋欍栏紑稓引瘗縙礛昝挟䨡䔣䠥伧伩猫漭ܯ଱̳5", a_), global::CommonResources.AcgResources.ID_ERASEPREVIOUSINDEXONINDEXCHANGE);
			this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.DataTransferOrder = 25;
			this.secWideMDCOTARKMCID_A8374 = new global::AcpBusinessLayer.AcpSimpleRangeField(4660, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫ꗭ뷯뇱뷳답ꟷ믹쓻췽㟿㘁", a_), global::CommonResources.AcgResources.ID_KMCID, 0, 65535, null, null, 0, 1);
			this.secWideMDCOTARKMCID_A8374.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTARKMCID_A8374.DataTransferOrder = 26;
			this.secWideMDCOTARKMCID_A8374.ShowHexValue = true;
			this.secWideMDCOTARMDCOTAREnable_A8488 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫ꏭ듯뇱믳ꋵ맷꣹맻都懿态栃挅圇䬉㐋㨍⠏⨑", a_), global::CommonResources.AcgResources.ID_MDCOTARENABLE);
			this.secWideMDCOTARMDCOTAREnable_A8488.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTARMDCOTAREnable_A8488.DataTransferOrder = 3;
			this.secWideMDCOTARStatusAlertTone_A8489 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫뷭蓯鏱胳菵请믹郻鯽狿瘁倃椅昇漉匋伍⠏☑Ⱃ⼕", a_), global::CommonResources.AcgResources.ID_REKEYREQUESTSTATUSALERTTONE_1);
			this.secWideMDCOTARStatusAlertTone_A8489.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTARStatusAlertTone_A8489.DataTransferOrder = 27;
			this.secWideMDCOTARMDCOTARSystem_A8490 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫ꏭ듯뇱믳ꋵ맷꣹꿻蟽珿瘁愃欅圇䬉㐋㨍⤏∑", a_), global::CommonResources.AcgResources.ID_MDCOTARSYSTEM, new string[]
			{
				global::CommonResources.AcgResources.ID_NONE
			}, new int[1], true, false);
			this.secWideMDCOTARMDCOTARSystem_A8490.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTARMDCOTARSystem_A8490.DataTransferOrder = 28;
			this.secWideMDCOTARMode_A8533 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.indexSecWideMDCOTARMode_A8533LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.idSecWideMDCOTARMode_A8533LovStrs), this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫ꏭ鿯雱釳꧵맷싹짻췽㏿", a_), global::CommonResources.AcgResources.ID_REKEYREQUESTMODE, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMDCOTARMode_A8533LovStrs);
			this.secWideMDCOTARMode_A8533.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTARMode_A8533.DataTransferOrder = 34;
			this.secWideMDCOTARPowerUp_A8716 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.indexSecWideMDCOTARPowerUp_A8716LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.idSecWideMDCOTARPowerUp_A8716LovStrs), this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫뻭鿯藱釳蓵귷諹ꏻ뿽㣿㔁㔃々", a_), global::CommonResources.AcgResources.ID_OTARACKNOWLEDGEMENTSPOWERUP, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMDCOTARPowerUp_A8716LovStrs);
			this.secWideMDCOTARPowerUp_A8716.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTARPowerUp_A8716.DataTransferOrder = 35;
			this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("臑뇓뗕迗동룛믝귟ꛡ꟣ꧥ볧ꯩ뻫볭釯雱鷳駵뇷铹铻韽拿欁瀃瀅愇欉䄋䨍匏崑䀓圕䨗䔙崛☝᠟ᄡᄣ", a_), global::CommonResources.AcgResources.ID_RADIOINHIBITVIAMDCOTAR);
			this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.DataTransferOrder = 29;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿑郓闕闙裛鿝닟", a_);
			base.Id = 10045;
			base.UIName = global::CommonResources.AcgResources.ID_MDCOTAR;
			base.DataTransferOrder = 2;
			this.a();
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x002105E8 File Offset: 0x0020E7E8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1879048214;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢ꃤ闦裨飪裬뿮菰雲菴黶雸軺軼뛾漀朂怄缆昈攊䐌愎甐瘒洔吖焘稚猜砞䐠簢搤ဦဨᰪᬬ", a_), global::CommonResources.AcgResources.ID_ERASEPREVIOUSINDEXONINDEXCHANGE);
					this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.DataTransferOrder = 25;
					num = (short)994770975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢뗤裦黨軪鿬뫮臰곲듴쿶컸쫺쯼", a_)))
					{
						num = (short)1768816663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D8;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢껤ꫦꫨꋪꧬ냮냰쯲웴샶췸", a_)))
					{
						num = (short)1188691969;
						if (num != 0)
						{
						}
						num = (short)136577041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_76C;
				case 3:
					num = (short)927727643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢럤蛦跨苪苬ꛮ鿰鯲鳴闶郸迺诼雾怀丂䄄䐆䘈弊䰌崎丐划ⴔ⼖⨘⸚", a_)))
					{
						num = (short)894042118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_85A;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢꣤ꏦꫨꓪ맬껮ꏰ뛲鯴零鯸韺飼ꃾ䀀㬂㄄㼆ㄈ", a_)))
					{
						num = (short)892076050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_145;
				case 6:
					this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢럤蛦跨苪苬ꛮ鿰鯲鳴闶郸迺诼雾怀丂䄄䐆䘈弊䰌崎丐划ⴔ⼖⨘⸚", a_), global::CommonResources.AcgResources.ID_RADIOINHIBITVIAMDCOTAR);
					this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.DataTransferOrder = 29;
					num = (short)1941897245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢꣤裦跨軪달껮짰웲웴쓶", a_)))
					{
						num = (short)441319439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E9;
				case 8:
					this.secWideMDCOTAREnable_A7967 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢ꃤ触裨觪臬諮껰닲싴컶쿸쳺", a_), global::CommonResources.AcgResources.ID_OTARACKNOWLEDGEMENTSENABLE);
					this.secWideMDCOTAREnable_A7967.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTAREnable_A7967.DataTransferOrder = 6;
					num = (short)1261764628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢ꃤ闦裨飪裬뿮菰雲菴黶雸軺軼뛾漀朂怄缆昈攊䐌愎甐瘒洔吖焘稚猜砞䐠簢搤ဦဨᰪᬬ", a_)))
					{
						num = (short)1420754944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_486;
				case 10:
					goto IL_1E9;
				case 11:
					this.secWideMDCOTARMDCOTARSystem_A8490 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢꣤ꏦꫨꓪ맬껮ꏰꃲ賴蓶跸黺郼ꃾ䀀㬂㄄㸆㤈", a_), global::CommonResources.AcgResources.ID_MDCOTARSYSTEM, new string[]
					{
						global::CommonResources.AcgResources.ID_NONE
					}, new int[1], true, false);
					this.secWideMDCOTARMDCOTARSystem_A8490.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTARMDCOTARSystem_A8490.DataTransferOrder = 28;
					num = (short)646971404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_28C;
				case 13:
					this.secWideMDCOTAREncryptedOnly_A7971 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢ꃤ触諨駪铬鿮藰雲釴룶韸韺蓼ꃾ䀀㐂㰄〆㠈", a_), global::CommonResources.AcgResources.ID_OTARACKNOWLEDGEMENTSENCRYPTEDONLY);
					this.secWideMDCOTAREncryptedOnly_A7971.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTAREncryptedOnly_A7971.DataTransferOrder = 32;
					num = (short)1538326560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)388562968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.secWideMDCOTARMode_A8533 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.indexSecWideMDCOTARMode_A8533LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.idSecWideMDCOTARMode_A8533LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢꣤裦跨軪달껮짰웲웴쓶", a_), global::CommonResources.AcgResources.ID_REKEYREQUESTMODE, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMDCOTARMode_A8533LovStrs);
					this.secWideMDCOTARMode_A8533.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTARMode_A8533.DataTransferOrder = 34;
					num = (short)828964874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢꣤ꏦꫨꓪ맬껮ꏰꃲ賴蓶跸黺郼ꃾ䀀㬂㄄㸆㤈", a_)))
					{
						num = (short)1735000075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28C;
				case 17:
					goto IL_4F5;
				case 18:
					this.secWideMDCOTARMDCOTAREnable_A8488 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢꣤ꏦꫨꓪ맬껮ꏰ뛲鯴零鯸韺飼ꃾ䀀㬂㄄㼆ㄈ", a_), global::CommonResources.AcgResources.ID_MDCOTARENABLE);
					this.secWideMDCOTARMDCOTAREnable_A8488.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTARMDCOTAREnable_A8488.DataTransferOrder = 3;
					num = (short)1492647964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_76C;
				case 20:
					goto IL_5A8;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢뛤鏦裨鿪飬鳮냰鿲郴藶跸꿺鋼釾搀専䐄㼆㴈㌊㐌", a_)))
					{
						num = (short)1579941921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71E;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_B5;
					}
					continue;
				case 23:
					this.secWideMDCOTARPowerUp_A8716 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.indexSecWideMDCOTARPowerUp_A8716LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.idSecWideMDCOTARPowerUp_A8716LovStrs), this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢뗤裦黨軪鿬뫮臰곲듴쿶컸쫺쯼", a_), global::CommonResources.AcgResources.ID_OTARACKNOWLEDGEMENTSPOWERUP, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMDCOTARPowerUp_A8716LovStrs);
					this.secWideMDCOTARPowerUp_A8716.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTARPowerUp_A8716.DataTransferOrder = 35;
					num = (short)318636057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢ꃤ触裨觪臬諮껰닲싴컶쿸쳺", a_)))
					{
						num = (short)1911488520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A8;
				case 25:
					goto IL_2D8;
				case 26:
					goto IL_71E;
				case 27:
				{
					if (producerFields == null)
					{
						goto IL_85A;
					}
					num = (short)1114010343;
					short num3 = num;
					num = (short)1242198759;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4F5;
					default:
					{
						num = (short)1570701312;
						if (num != 0)
						{
						}
						num = (short)85721088;
						short num4 = num;
						num = (short)287178766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 28:
					goto IL_145;
				case 29:
					goto IL_481;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢ꃤ触諨駪铬鿮藰雲釴룶韸韺蓼ꃾ䀀㐂㰄〆㠈", a_)))
					{
						num = (short)1670840333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37A;
				case 31:
					goto IL_486;
				case 32:
					goto IL_37A;
				case 33:
					this.secWideMDCOTARStatusAlertTone_A8489 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢뛤鏦裨鿪飬鳮냰鿲郴藶跸꿺鋼釾搀専䐄㼆㴈㌊㐌", a_), global::CommonResources.AcgResources.ID_REKEYREQUESTSTATUSALERTTONE_1);
					this.secWideMDCOTARStatusAlertTone_A8489.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMDCOTARStatusAlertTone_A8489.DataTransferOrder = 27;
					num = (short)320405530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B5:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)732495875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_145:
				num = (short)1303904277;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E9:
				num = (short)420020225;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_28C:
				num = (short)582746119;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D8:
				num = (short)1854668804;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37A:
				num = (short)1525219337;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_486:
				num = (short)1386872834;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4F5:
				this.secWideMDCOTARKMCID_A8374 = new global::AcpBusinessLayer.AcpSimpleRangeField(4660, this, global::AllFeatures.CodeplugGuid.b("髈껊껌风룐럒냔髖鷘飚鋜诞ꃠ뇢껤ꫦꫨꋪꧬ냮냰쯲웴샶췸", a_), global::CommonResources.AcgResources.ID_KMCID, null, null, 0, 1);
				this.secWideMDCOTARKMCID_A8374.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.secWideMDCOTARKMCID_A8374.DataTransferOrder = 26;
				this.secWideMDCOTARKMCID_A8374.ShowHexValue = true;
				num = (short)748617747;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A8:
				num = (short)930545694;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_71E:
				num = (short)743571472;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_76C:
				num = (short)1125515269;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_481:
			IL_85A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓈迊軌黐蟒铔藖", a_);
			base.Id = 10045;
			base.UIName = global::CommonResources.AcgResources.ID_MDCOTAR;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00210E80 File Offset: 0x0020F080
		public override void PopulateReferences()
		{
			short num = (short)1986510995;
			short num2 = num;
			num = (short)956285075;
			switch (num2 == num)
			{
			}
			num = (short)1682046976;
			if (num != 0)
			{
			}
			num = (short)1911488512;
			short num3 = num;
			num = (short)1722220545;
			if (num != 0)
			{
			}
			this.secWideMDCOTARMDCOTARSystem_A8490.SetRecset(this.a(2053));
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00210F40 File Offset: 0x0020F140
		public override void DropReferences()
		{
			short num = (short)2063956764;
			short num2 = num;
			num = (short)1489730332;
			switch (num2 == num)
			{
			}
			num = (short)1101463553;
			if (num != 0)
			{
			}
			num = (short)1000996864;
			short num3 = num;
			num = (short)667090944;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00210FEC File Offset: 0x0020F1EC
		public override void SetConstraints()
		{
			short num = (short)1742139886;
			short num2 = num;
			num = (short)1613427182;
			switch (num2 == num)
			{
			}
			num = (short)1095565313;
			if (num != 0)
			{
			}
			num = (short)2136014848;
			short num3 = num;
			num = (short)1016004608;
			if (num != 0)
			{
			}
			this.secWideMDCOTAREnable_A7967.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTAREnable_A7967.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
			this.secWideMDCOTAREncryptedOnly_A7971.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conOtarAcksEnIsEnAndMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTAREncryptedOnly_A7971.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
			this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
			this.secWideMDCOTARKMCID_A8374.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTARKMCID_A8374.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
			this.secWideMDCOTARMDCOTAREnable_A8488.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConOtarIsEnabledAndSecOperationIsHardware);
			this.secWideMDCOTARMDCOTAREnable_A8488.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMDCOtarEnableInvalidIfOtarEnabledAndSecureIsHardware);
			this.secWideMDCOTARMDCOTAREnable_A8488.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEditable);
			this.secWideMDCOTARStatusAlertTone_A8489.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTARStatusAlertTone_A8489.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
			this.secWideMDCOTARMDCOTARSystem_A8490.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTARMDCOTARSystem_A8490.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConIsMDCOTARSystemSelectionValid);
			this.secWideMDCOTARMDCOTARSystem_A8490.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
			this.secWideMDCOTARMode_A8533.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTARMode_A8533.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
			this.secWideMDCOTARPowerUp_A8716.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTARPowerUp_A8716.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
			this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conMdcOtarIsEnAndOtarIsEnAndSecOperationIsHardware);
			this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConMakeMDCOtarPageInvisibleInMackR1);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00211290 File Offset: 0x0020F490
		public override void SetupDependencies()
		{
			short num = (short)1145273137;
			short num2 = num;
			num = (short)1646820145;
			switch (num2 == num)
			{
			}
			num = (short)594411520;
			if (num != 0)
			{
			}
			num = (short)901185536;
			short num3 = num;
			num = (short)489291777;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTAREnable_A7967);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTAREnable_A7967);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTAREnable_A7967);
			this.secWideMDCOTAREnable_A7967.AddDependentObject(this.secWideMDCOTAREncryptedOnly_A7971);
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTAREncryptedOnly_A7971);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTAREncryptedOnly_A7971);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTAREncryptedOnly_A7971);
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976);
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTARKMCID_A8374);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTARKMCID_A8374);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTARKMCID_A8374);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTARMDCOTAREnable_A8488);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTARMDCOTAREnable_A8488);
			secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secWideMDCOTARMDCOTAREnable_A8488);
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTARStatusAlertTone_A8489);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTARStatusAlertTone_A8489);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTARStatusAlertTone_A8489);
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTARMDCOTARSystem_A8490);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTARMDCOTARSystem_A8490);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTARMDCOTARSystem_A8490);
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTARMode_A8533);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTARMode_A8533);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTARMode_A8533);
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTARPowerUp_A8716);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTARPowerUp_A8716);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTARPowerUp_A8716);
			this.secWideMDCOTARMDCOTAREnable_A8488.AddDependentObject(this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835);
			secureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835);
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x002115DC File Offset: 0x0020F7DC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem ConventionalSystemForSecWideMDCOTARMDCOTARSystem_A8490
		{
			get
			{
				short num = (short)44299601;
				short num2 = num;
				num = (short)730002769;
				switch (num2 == num)
				{
				}
				num = (short)883032064;
				if (num != 0)
				{
				}
				num = (short)258670592;
				short num3 = num;
				num = (short)1470169089;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x00211698 File Offset: 0x0020F898
		public bool HasDiffs
		{
			get
			{
				short num = (short)1340905192;
				short num2 = num;
				num = (short)1775474408;
				switch (num2 == num)
				{
				}
				num = (short)493420544;
				if (num != 0)
				{
				}
				num = (short)1950220288;
				short num3 = num;
				num = (short)1798176769;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x00211748 File Offset: 0x0020F948
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x00211800 File Offset: 0x0020FA00
		public bool SecWideMDCOTAREnable_A7967Value
		{
			get
			{
				short num = (short)2001394496;
				short num2 = num;
				num = (short)894950208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)418578432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2114846720;
				if (num != 0)
				{
				}
				num = (short)123928577;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.Value;
			}
			set
			{
				short num = (short)1264962301;
				short num2 = num;
				num = (short)1969801981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)419954688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)598802432;
				if (num != 0)
				{
				}
				num = (short)259522561;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREnable_A7967.Value = value;
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x002118B8 File Offset: 0x0020FAB8
		public global::AcpBusinessLayer.AcpField<bool> SecWideMDCOTAREnable_A7967
		{
			get
			{
				short num = (short)297712217;
				short num2 = num;
				num = (short)1681504857;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1547436032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)618594305;
				if (num != 0)
				{
				}
				num = (short)693567488;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967;
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x00211964 File Offset: 0x0020FB64
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x00211A1C File Offset: 0x0020FC1C
		public bool SecWideMDCOTAREnable_A7967_UIValue
		{
			get
			{
				short num = (short)1984561153;
				if (num != 0)
				{
				}
				num = (short)1331822592;
				short num2 = num;
				num = (short)908880094;
				short num3 = num;
				num = (short)788687070;
				switch (num3 == num)
				{
				}
				num = (short)1843134464;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.Value;
			}
			set
			{
				short num = (short)30315036;
				short num2 = num;
				num = (short)570855964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)768212992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624768512;
				if (num != 0)
				{
				}
				num = (short)2039545857;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREnable_A7967.Value = value;
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x00211AD4 File Offset: 0x0020FCD4
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x00211B88 File Offset: 0x0020FD88
		public bool SecWideMDCOTAREnable_A7967_Applicable
		{
			get
			{
				short num = (short)865529100;
				short num2 = num;
				num = (short)1029041420;
				switch (num2 == num)
				{
				default:
				{
					num = (short)384434176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2027814912;
				if (num != 0)
				{
				}
				num = (short)1672151041;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.Applicable;
			}
			set
			{
				short num = (short)945684481;
				if (num != 0)
				{
				}
				num = (short)740425728;
				short num2 = num;
				num = (short)1871973990;
				short num3 = num;
				num = (short)163516006;
				switch (num3 == num)
				{
				}
				num = (short)289800192;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREnable_A7967.Applicable = value;
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x00211C40 File Offset: 0x0020FE40
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x00211CF4 File Offset: 0x0020FEF4
		public bool SecWideMDCOTAREnable_A7967_Valid
		{
			get
			{
				short num = (short)1546652236;
				short num2 = num;
				num = (short)130419276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)505806848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1913126913;
				if (num != 0)
				{
				}
				num = (short)284753920;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.Valid;
			}
			set
			{
				short num = (short)626015848;
				short num2 = num;
				num = (short)694632040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1836777472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1223884801;
				if (num != 0)
				{
				}
				num = (short)48300032;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREnable_A7967.Valid = value;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x00211DA8 File Offset: 0x0020FFA8
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x00211E5C File Offset: 0x0021005C
		public bool SecWideMDCOTAREnable_A7967_Visible
		{
			get
			{
				short num = (short)2083586049;
				if (num != 0)
				{
				}
				num = (short)215154688;
				short num2 = num;
				num = (short)1397958753;
				short num3 = num;
				num = (short)119941217;
				switch (num3 == num)
				{
				}
				num = (short)1712062464;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.Visible;
			}
			set
			{
				short num = (short)2103669720;
				short num2 = num;
				num = (short)377582552;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1957232640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1259077633;
				if (num != 0)
				{
				}
				num = (short)136708096;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREnable_A7967.Visible = value;
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x00211F10 File Offset: 0x00210110
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00211FC4 File Offset: 0x002101C4
		public bool SecWideMDCOTAREnable_A7967_Editable
		{
			get
			{
				short num = (short)1581422872;
				short num2 = num;
				num = (short)22124824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)115998720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1366425601;
				if (num != 0)
				{
				}
				num = (short)1910833152;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.Editable;
			}
			set
			{
				short num = (short)606324996;
				short num2 = num;
				num = (short)244893956;
				switch (num2 == num)
				{
				default:
				{
					num = (short)999030784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)224919553;
				if (num != 0)
				{
				}
				num = (short)34865152;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREnable_A7967.Editable = value;
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00212078 File Offset: 0x00210278
		internal string SecWideMDCOTAREnable_A7967_UILabel
		{
			get
			{
				short num = (short)651273557;
				short num2 = num;
				num = (short)925082965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030043136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1856110593;
				if (num != 0)
				{
				}
				num = (short)1584070656;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.UIName;
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00212128 File Offset: 0x00210328
		// (set) Token: 0x060021A4 RID: 8612 RVA: 0x002121E0 File Offset: 0x002103E0
		internal bool SecWideMDCOTAREnable_A7967_HiddenStatic
		{
			get
			{
				short num = (short)832307201;
				if (num != 0)
				{
				}
				num = (short)446889984;
				short num2 = num;
				num = (short)19783679;
				short num3 = num;
				num = (short)1185079295;
				switch (num3 == num)
				{
				}
				num = (short)761528320;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.HiddenStatic;
			}
			set
			{
				short num = (short)771523415;
				short num2 = num;
				num = (short)477201239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2004746240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847656449;
				if (num != 0)
				{
				}
				num = (short)1141833728;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREnable_A7967.HiddenStatic = value;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00212294 File Offset: 0x00210494
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x00212348 File Offset: 0x00210548
		internal bool SecWideMDCOTAREnable_A7967_HiddenDynamic
		{
			get
			{
				short num = (short)569250426;
				short num2 = num;
				num = (short)1605636730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1089601536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1792147457;
				if (num != 0)
				{
				}
				num = (short)1681391616;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967.HiddenDynamic;
			}
			set
			{
				short num = (short)1371552536;
				short num2 = num;
				num = (short)815676184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)544276480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1772814336;
				if (num != 0)
				{
				}
				num = (short)954007553;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREnable_A7967.HiddenDynamic = value;
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00212400 File Offset: 0x00210600
		public bool SecWideMDCOTAREnable_A7967_HasDiffs
		{
			get
			{
				short num = (short)1398021515;
				short num2 = num;
				num = (short)756817291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)589889536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1859256320;
				if (num != 0)
				{
				}
				num = (short)699072513;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREnable_A7967._HasDiffs;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x002124B4 File Offset: 0x002106B4
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x0021256C File Offset: 0x0021076C
		public bool SecWideMDCOTAREncryptedOnly_A7971Value
		{
			get
			{
				short num = (short)1609912817;
				short num2 = num;
				num = (short)1885491697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)762314752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)230752257;
				if (num != 0)
				{
				}
				num = (short)120061952;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.Value;
			}
			set
			{
				short num = (short)492109825;
				if (num != 0)
				{
				}
				num = (short)450822144;
				short num2 = num;
				num = (short)879122853;
				short num3 = num;
				num = (short)2025675173;
				switch (num3 == num)
				{
				}
				num = (short)1851719680;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREncryptedOnly_A7971.Value = value;
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x00212620 File Offset: 0x00210820
		public global::AcpBusinessLayer.AcpField<bool> SecWideMDCOTAREncryptedOnly_A7971
		{
			get
			{
				short num = (short)298763929;
				short num2 = num;
				num = (short)1218561689;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1773862912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)278855681;
				if (num != 0)
				{
				}
				num = (short)1263271936;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x002126D0 File Offset: 0x002108D0
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x00212788 File Offset: 0x00210988
		public bool SecWideMDCOTAREncryptedOnly_A7971_UIValue
		{
			get
			{
				short num = (short)1397715799;
				short num2 = num;
				num = (short)679310167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)803995648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)287571968;
				if (num != 0)
				{
				}
				num = (short)1713569793;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.Value;
			}
			set
			{
				short num = (short)460629154;
				short num2 = num;
				num = (short)1117103266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)920387584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)221970433;
				if (num != 0)
				{
				}
				num = (short)1170210816;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREncryptedOnly_A7971.Value = value;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00212840 File Offset: 0x00210A40
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x002128F4 File Offset: 0x00210AF4
		public bool SecWideMDCOTAREncryptedOnly_A7971_Applicable
		{
			get
			{
				short num = (short)773390337;
				if (num != 0)
				{
				}
				num = (short)302972928;
				short num2 = num;
				num = (short)1691140650;
				short num3 = num;
				num = (short)1152893482;
				switch (num3 == num)
				{
				}
				num = (short)1861943296;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.Applicable;
			}
			set
			{
				short num = (short)145447107;
				short num2 = num;
				num = (short)609900739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721368576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1021116417;
				if (num != 0)
				{
				}
				num = (short)409534464;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREncryptedOnly_A7971.Applicable = value;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x002129AC File Offset: 0x00210BAC
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00212A64 File Offset: 0x00210C64
		public bool SecWideMDCOTAREncryptedOnly_A7971_Valid
		{
			get
			{
				short num = (short)380027908;
				short num2 = num;
				num = (short)1353761796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)433324032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662896641;
				if (num != 0)
				{
				}
				num = (short)1681391616;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.Valid;
			}
			set
			{
				short num = (short)1504459199;
				short num2 = num;
				num = (short)268712383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)492240896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1778909185;
				if (num != 0)
				{
				}
				num = (short)700710912;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREncryptedOnly_A7971.Valid = value;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00212B1C File Offset: 0x00210D1C
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x00212BD0 File Offset: 0x00210DD0
		public bool SecWideMDCOTAREncryptedOnly_A7971_Visible
		{
			get
			{
				short num = (short)1311164601;
				short num2 = num;
				num = (short)626444473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)321847296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1583677441;
				if (num != 0)
				{
				}
				num = (short)1391722496;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.Visible;
			}
			set
			{
				short num = (short)471793665;
				if (num != 0)
				{
				}
				num = (short)1345650688;
				short num2 = num;
				num = (short)620899454;
				short num3 = num;
				num = (short)1868246142;
				switch (num3 == num)
				{
				}
				num = (short)55312384;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREncryptedOnly_A7971.Visible = value;
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00212C88 File Offset: 0x00210E88
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x00212D3C File Offset: 0x00210F3C
		public bool SecWideMDCOTAREncryptedOnly_A7971_Editable
		{
			get
			{
				short num = (short)1377239041;
				if (num != 0)
				{
				}
				num = (short)1819934720;
				short num2 = num;
				num = (short)1296572973;
				short num3 = num;
				num = (short)411181613;
				switch (num3 == num)
				{
				}
				num = (short)1384775680;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.Editable;
			}
			set
			{
				short num = (short)1990794477;
				short num2 = num;
				num = (short)1764105453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1993998336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)162398209;
				if (num != 0)
				{
				}
				num = (short)1229848576;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREncryptedOnly_A7971.Editable = value;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x00212DF4 File Offset: 0x00210FF4
		internal string SecWideMDCOTAREncryptedOnly_A7971_UILabel
		{
			get
			{
				short num = (short)484546291;
				short num2 = num;
				num = (short)1376098035;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1506148352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)119996417;
				if (num != 0)
				{
				}
				num = (short)610861056;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.UIName;
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00212EA8 File Offset: 0x002110A8
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x00212F5C File Offset: 0x0021115C
		internal bool SecWideMDCOTAREncryptedOnly_A7971_HiddenStatic
		{
			get
			{
				short num = (short)1210939741;
				short num2 = num;
				num = (short)209025373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1082654720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1036124161;
				if (num != 0)
				{
				}
				num = (short)571342848;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.HiddenStatic;
			}
			set
			{
				short num = (short)1678917266;
				short num2 = num;
				num = (short)569130642;
				switch (num2 == num)
				{
				default:
				{
					num = (short)866516992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51773441;
				if (num != 0)
				{
				}
				num = (short)1000996864;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREncryptedOnly_A7971.HiddenStatic = value;
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00213014 File Offset: 0x00211214
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x002130C8 File Offset: 0x002112C8
		internal bool SecWideMDCOTAREncryptedOnly_A7971_HiddenDynamic
		{
			get
			{
				short num = (short)798621697;
				if (num != 0)
				{
				}
				num = (short)1404895232;
				short num2 = num;
				num = (short)1832031057;
				short num3 = num;
				num = (short)270111569;
				switch (num3 == num)
				{
				}
				num = (short)1769078784;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971.HiddenDynamic;
			}
			set
			{
				short num = (short)1140753256;
				short num2 = num;
				num = (short)2118157160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1681195008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1254490113;
				if (num != 0)
				{
				}
				num = (short)824901632;
				if (num != 0)
				{
				}
				this.secWideMDCOTAREncryptedOnly_A7971.HiddenDynamic = value;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x0021317C File Offset: 0x0021137C
		public bool SecWideMDCOTAREncryptedOnly_A7971_HasDiffs
		{
			get
			{
				short num = (short)1539470298;
				short num2 = num;
				num = (short)1379103706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)138674176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)356188161;
				if (num != 0)
				{
				}
				num = (short)875102208;
				if (num != 0)
				{
				}
				return this.secWideMDCOTAREncryptedOnly_A7971._HasDiffs;
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00213230 File Offset: 0x00211430
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x002132E4 File Offset: 0x002114E4
		public bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976Value
		{
			get
			{
				short num = (short)148204231;
				short num2 = num;
				num = (short)2140105415;
				switch (num2 == num)
				{
				default:
				{
					num = (short)161021952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)36241409;
				if (num != 0)
				{
				}
				num = (short)167510016;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Value;
			}
			set
			{
				short num = (short)598474753;
				if (num != 0)
				{
				}
				num = (short)208535552;
				short num2 = num;
				num = (short)210054230;
				short num3 = num;
				num = (short)1723083862;
				switch (num3 == num)
				{
				}
				num = (short)1196425216;
				if (num != 0)
				{
				}
				this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Value = value;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0021339C File Offset: 0x0021159C
		public global::AcpBusinessLayer.AcpField<bool> SecWideMDCOTARErasePreviousIndexonIndexChange_A7976
		{
			get
			{
				short num = (short)2147262813;
				short num2 = num;
				num = (short)1050911069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)686555136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429209089;
				if (num != 0)
				{
				}
				num = (short)665387008;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x0021344C File Offset: 0x0021164C
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x00213504 File Offset: 0x00211704
		public bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_UIValue
		{
			get
			{
				short num = (short)2055605313;
				short num2 = num;
				num = (short)377752641;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2095710208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)220594176;
				if (num != 0)
				{
				}
				num = (short)226557953;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Value;
			}
			set
			{
				short num = (short)1563033116;
				short num2 = num;
				num = (short)135855644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499187712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1978269697;
				if (num != 0)
				{
				}
				num = (short)1038417920;
				if (num != 0)
				{
				}
				this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Value = value;
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x002135BC File Offset: 0x002117BC
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x00213670 File Offset: 0x00211870
		public bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_Applicable
		{
			get
			{
				short num = (short)1864148270;
				short num2 = num;
				num = (short)1619830062;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1731919872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1634205697;
				if (num != 0)
				{
				}
				num = (short)17301504;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Applicable;
			}
			set
			{
				short num = (short)464023112;
				short num2 = num;
				num = (short)1878552136;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1749876736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)832765953;
				if (num != 0)
				{
				}
				num = (short)102498304;
				if (num != 0)
				{
				}
				this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Applicable = value;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00213724 File Offset: 0x00211924
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x002137D8 File Offset: 0x002119D8
		public bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_Valid
		{
			get
			{
				short num = (short)1625762954;
				short num2 = num;
				num = (short)1329015946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)138543104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16384000;
				if (num != 0)
				{
				}
				num = (short)1176109057;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Valid;
			}
			set
			{
				short num = (short)1212594038;
				short num2 = num;
				num = (short)1851963254;
				switch (num2 == num)
				{
				default:
				{
					num = (short)574095360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1260191745;
				if (num != 0)
				{
				}
				num = (short)1762459648;
				if (num != 0)
				{
				}
				this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Valid = value;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x00213890 File Offset: 0x00211A90
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x00213948 File Offset: 0x00211B48
		public bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_Visible
		{
			get
			{
				short num = (short)1738853543;
				short num2 = num;
				num = (short)1119341735;
				switch (num2 == num)
				{
				default:
				{
					num = (short)397475840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1507131393;
				if (num != 0)
				{
				}
				num = (short)1576271872;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Visible;
			}
			set
			{
				short num = (short)1405981415;
				short num2 = num;
				num = (short)778474215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1036058624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1254490113;
				if (num != 0)
				{
				}
				num = (short)34930688;
				if (num != 0)
				{
				}
				this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Visible = value;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x00213A00 File Offset: 0x00211C00
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x00213AB4 File Offset: 0x00211CB4
		public bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_Editable
		{
			get
			{
				short num = (short)1524186427;
				short num2 = num;
				num = (short)540228923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1408761856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)230621185;
				if (num != 0)
				{
				}
				num = (short)1617625088;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Editable;
			}
			set
			{
				short num = (short)1826488321;
				if (num != 0)
				{
				}
				num = (short)870580224;
				short num2 = num;
				num = (short)1377921185;
				short num3 = num;
				num = (short)507996321;
				switch (num3 == num)
				{
				}
				num = (short)575799296;
				if (num != 0)
				{
				}
				this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.Editable = value;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x00213B6C File Offset: 0x00211D6C
		internal string SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_UILabel
		{
			get
			{
				short num = (short)1210496725;
				short num2 = num;
				num = (short)314488533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1072168960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)709951489;
				if (num != 0)
				{
				}
				num = (short)1480261632;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.UIName;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x00213C20 File Offset: 0x00211E20
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x00213CD8 File Offset: 0x00211ED8
		internal bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_HiddenStatic
		{
			get
			{
				short num = (short)1301086209;
				if (num != 0)
				{
				}
				num = (short)484311040;
				short num2 = num;
				num = (short)743988645;
				short num3 = num;
				num = (short)935353765;
				switch (num3 == num)
				{
				}
				num = (short)1960640512;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.HiddenStatic;
			}
			set
			{
				short num = (short)1228972896;
				short num2 = num;
				num = (short)805217120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)172556288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1120993281;
				if (num != 0)
				{
				}
				num = (short)696123392;
				if (num != 0)
				{
				}
				this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.HiddenStatic = value;
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x00213D8C File Offset: 0x00211F8C
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x00213E44 File Offset: 0x00212044
		internal bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_HiddenDynamic
		{
			get
			{
				short num = (short)1390820675;
				short num2 = num;
				num = (short)1676557635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413152768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1012924416;
				if (num != 0)
				{
				}
				num = (short)1000341505;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.HiddenDynamic;
			}
			set
			{
				short num = (short)1207375015;
				short num2 = num;
				num = (short)867701927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)278331392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)584777729;
				if (num != 0)
				{
				}
				num = (short)764805120;
				if (num != 0)
				{
				}
				this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976.HiddenDynamic = value;
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x00213EF8 File Offset: 0x002120F8
		public bool SecWideMDCOTARErasePreviousIndexonIndexChange_A7976_HasDiffs
		{
			get
			{
				short num = (short)1764841382;
				short num2 = num;
				num = (short)587618214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)408223744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1778974720;
				if (num != 0)
				{
				}
				num = (short)1115947009;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARErasePreviousIndexonIndexChange_A7976._HasDiffs;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x00213FAC File Offset: 0x002121AC
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00214060 File Offset: 0x00212260
		public int SecWideMDCOTARKMCID_A8374Value
		{
			get
			{
				short num = (short)862983606;
				short num2 = num;
				num = (short)170923446;
				switch (num2 == num)
				{
				}
				num = (short)1297547264;
				short num3 = num;
				num = (short)161808384;
				if (num != 0)
				{
				}
				num = (short)1186988033;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.Value;
			}
			set
			{
				short num = (short)561446913;
				if (num != 0)
				{
				}
				num = (short)946906804;
				short num2 = num;
				num = (short)612083380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1186201600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)188481536;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.Value = value;
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00214118 File Offset: 0x00212318
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideMDCOTARKMCID_A8374
		{
			get
			{
				short num = (short)233373697;
				if (num != 0)
				{
				}
				num = (short)402995545;
				short num2 = num;
				num = (short)1316698457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1373044736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)261947392;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374;
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x002141C8 File Offset: 0x002123C8
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x0021427C File Offset: 0x0021247C
		public string SecWideMDCOTARKMCID_A8374_UIValue
		{
			get
			{
				short num = (short)52177160;
				short num2 = num;
				num = (short)2118461704;
				switch (num2 == num)
				{
				}
				num = (short)26804224;
				short num3 = num;
				num = (short)1433075713;
				if (num != 0)
				{
				}
				num = (short)1988034560;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.UIValue;
			}
			set
			{
				short num = (short)648926374;
				short num2 = num;
				num = (short)563008678;
				switch (num2 == num)
				{
				}
				num = (short)1053491200;
				short num3 = num;
				num = (short)222363649;
				if (num != 0)
				{
				}
				num = (short)27066368;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.UIValue = value;
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00214330 File Offset: 0x00212530
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x002143E4 File Offset: 0x002125E4
		public string SecWideMDCOTARKMCID_A8374_HexUIValue
		{
			get
			{
				short num = (short)485621761;
				if (num != 0)
				{
				}
				num = (short)986923410;
				short num2 = num;
				num = (short)945766802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)211746816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1875640320;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.HexUIValue;
			}
			set
			{
				short num = (short)1155273193;
				short num2 = num;
				num = (short)259723753;
				switch (num2 == num)
				{
				}
				num = (short)1575157760;
				short num3 = num;
				num = (short)288555009;
				if (num != 0)
				{
				}
				num = (short)1923219456;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.HexUIValue = value;
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0021449C File Offset: 0x0021269C
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x00214554 File Offset: 0x00212754
		internal int SecWideMDCOTARKMCID_A8374Min
		{
			get
			{
				short num = (short)522846209;
				if (num != 0)
				{
				}
				num = (short)2064254515;
				short num2 = num;
				num = (short)1396704819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1131216896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2017591296;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.Min;
			}
			set
			{
				short num = (short)12736235;
				short num2 = num;
				num = (short)779048683;
				switch (num2 == num)
				{
				}
				num = (short)374734848;
				short num3 = num;
				num = (short)1647771649;
				if (num != 0)
				{
				}
				num = (short)293142528;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.Min = value;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00214608 File Offset: 0x00212808
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x002146BC File Offset: 0x002128BC
		internal int SecWideMDCOTARKMCID_A8374Max
		{
			get
			{
				short num = (short)1023344641;
				if (num != 0)
				{
				}
				num = (short)1087439397;
				short num2 = num;
				num = (short)415760933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1773207552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1237254144;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.Max;
			}
			set
			{
				short num = (short)938889127;
				short num2 = num;
				num = (short)1996181415;
				switch (num2 == num)
				{
				}
				num = (short)859176960;
				short num3 = num;
				num = (short)374603776;
				if (num != 0)
				{
				}
				num = (short)1164378113;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.Max = value;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00214774 File Offset: 0x00212974
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x00214828 File Offset: 0x00212A28
		internal int SecWideMDCOTARKMCID_A8374Step
		{
			get
			{
				short num = (short)1456170690;
				short num2 = num;
				num = (short)644376258;
				switch (num2 == num)
				{
				}
				num = (short)1373044736;
				short num3 = num;
				num = (short)1248788481;
				if (num != 0)
				{
				}
				num = (short)854982656;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.StepSize;
			}
			set
			{
				short num = (short)1627586561;
				if (num != 0)
				{
				}
				num = (short)1739476142;
				short num2 = num;
				num = (short)146427054;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071775744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1953955840;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.StepSize = value;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x002148DC File Offset: 0x00212ADC
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x00214990 File Offset: 0x00212B90
		public bool SecWideMDCOTARKMCID_A8374_Applicable
		{
			get
			{
				short num = (short)2047279087;
				short num2 = num;
				num = (short)985006063;
				switch (num2 == num)
				{
				}
				num = (short)753467392;
				short num3 = num;
				num = (short)2022572033;
				if (num != 0)
				{
				}
				num = (short)1734803456;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.Applicable;
			}
			set
			{
				short num = (short)467967648;
				short num2 = num;
				num = (short)47292064;
				switch (num2 == num)
				{
				}
				num = (short)771817472;
				short num3 = num;
				num = (short)347996160;
				if (num != 0)
				{
				}
				num = (short)34340865;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.Applicable = value;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x00214A44 File Offset: 0x00212C44
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x00214AFC File Offset: 0x00212CFC
		public bool SecWideMDCOTARKMCID_A8374_Valid
		{
			get
			{
				short num = (short)780128336;
				short num2 = num;
				num = (short)1576194128;
				switch (num2 == num)
				{
				}
				num = (short)1547173888;
				short num3 = num;
				num = (short)1784217601;
				if (num != 0)
				{
				}
				num = (short)2106851328;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.Valid;
			}
			set
			{
				short num = (short)885453109;
				short num2 = num;
				num = (short)1371205941;
				switch (num2 == num)
				{
				}
				num = (short)583860224;
				short num3 = num;
				num = (short)1475805184;
				if (num != 0)
				{
				}
				num = (short)971505665;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.Valid = value;
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x00214BB4 File Offset: 0x00212DB4
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x00214C68 File Offset: 0x00212E68
		public bool SecWideMDCOTARKMCID_A8374_Visible
		{
			get
			{
				short num = (short)1106030739;
				short num2 = num;
				num = (short)755609747;
				switch (num2 == num)
				{
				}
				num = (short)1524498432;
				short num3 = num;
				num = (short)353894400;
				if (num != 0)
				{
				}
				num = (short)387317761;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.Visible;
			}
			set
			{
				short num = (short)1600671076;
				short num2 = num;
				num = (short)227822948;
				switch (num2 == num)
				{
				}
				num = (short)300023808;
				short num3 = num;
				num = (short)235274241;
				if (num != 0)
				{
				}
				num = (short)443416576;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.Visible = value;
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x00214D20 File Offset: 0x00212F20
		// (set) Token: 0x060021E2 RID: 8674 RVA: 0x00214DD4 File Offset: 0x00212FD4
		public bool SecWideMDCOTARKMCID_A8374_Editable
		{
			get
			{
				short num = (short)1938227201;
				if (num != 0)
				{
				}
				num = (short)8439933;
				short num2 = num;
				num = (short)275171453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2052784128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)45416448;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.Editable;
			}
			set
			{
				short num = (short)1914162729;
				short num2 = num;
				num = (short)582733353;
				switch (num2 == num)
				{
				}
				num = (short)1404633088;
				short num3 = num;
				num = (short)1940127745;
				if (num != 0)
				{
				}
				num = (short)882180096;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.Editable = value;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x00214E8C File Offset: 0x0021308C
		internal string SecWideMDCOTARKMCID_A8374_UILabel
		{
			get
			{
				short num = (short)194066010;
				short num2 = num;
				num = (short)1113142874;
				switch (num2 == num)
				{
				}
				num = (short)2105147392;
				short num3 = num;
				num = (short)461111296;
				if (num != 0)
				{
				}
				num = (short)1437007873;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.UIName;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x00214F44 File Offset: 0x00213144
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x00214FFC File Offset: 0x002131FC
		internal bool SecWideMDCOTARKMCID_A8374_HiddenStatic
		{
			get
			{
				short num = (short)213975041;
				if (num != 0)
				{
				}
				num = (short)1426953632;
				short num2 = num;
				num = (short)788436384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1789394944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)729939968;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.HiddenStatic;
			}
			set
			{
				short num = (short)1568383309;
				short num2 = num;
				num = (short)198615373;
				switch (num2 == num)
				{
				}
				num = (short)1401225216;
				short num3 = num;
				num = (short)889257985;
				if (num != 0)
				{
				}
				num = (short)1299447808;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.HiddenStatic = value;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x002150B0 File Offset: 0x002132B0
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x00215164 File Offset: 0x00213364
		internal bool SecWideMDCOTARKMCID_A8374_HiddenDynamic
		{
			get
			{
				short num = (short)1489368924;
				short num2 = num;
				num = (short)805238620;
				switch (num2 == num)
				{
				}
				num = (short)2067005440;
				short num3 = num;
				num = (short)2142765056;
				if (num != 0)
				{
				}
				num = (short)1649410049;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374.HiddenDynamic;
			}
			set
			{
				short num = (short)62826199;
				short num2 = num;
				num = (short)323397335;
				switch (num2 == num)
				{
				}
				num = (short)1899036672;
				short num3 = num;
				num = (short)738328577;
				if (num != 0)
				{
				}
				num = (short)1842151424;
				if (num != 0)
				{
				}
				this.secWideMDCOTARKMCID_A8374.HiddenDynamic = value;
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x0021521C File Offset: 0x0021341C
		public bool SecWideMDCOTARKMCID_A8374_HasDiffs
		{
			get
			{
				short num = (short)1447267198;
				short num2 = num;
				num = (short)90409854;
				switch (num2 == num)
				{
				}
				num = (short)915144704;
				short num3 = num;
				num = (short)1442971648;
				if (num != 0)
				{
				}
				num = (short)1574567937;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARKMCID_A8374._HasDiffs;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x002152D4 File Offset: 0x002134D4
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x00215388 File Offset: 0x00213588
		public bool SecWideMDCOTARMDCOTAREnable_A8488Value
		{
			get
			{
				short num = (short)759103489;
				if (num != 0)
				{
				}
				num = (short)904643549;
				short num2 = num;
				num = (short)1474806749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1984692224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)556793856;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.Value;
			}
			set
			{
				short num = (short)1039821655;
				short num2 = num;
				num = (short)1390832471;
				switch (num2 == num)
				{
				}
				num = (short)85131264;
				short num3 = num;
				num = (short)101056513;
				if (num != 0)
				{
				}
				num = (short)1906704384;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTAREnable_A8488.Value = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x00215440 File Offset: 0x00213640
		public global::AcpBusinessLayer.AcpField<bool> SecWideMDCOTARMDCOTAREnable_A8488
		{
			get
			{
				short num = (short)4243271;
				short num2 = num;
				num = (short)1684455239;
				switch (num2 == num)
				{
				}
				num = (short)32047104;
				short num3 = num;
				num = (short)926285825;
				if (num != 0)
				{
				}
				num = (short)544407552;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x002154EC File Offset: 0x002136EC
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x002155A0 File Offset: 0x002137A0
		public bool SecWideMDCOTARMDCOTAREnable_A8488_UIValue
		{
			get
			{
				short num = (short)1373172627;
				short num2 = num;
				num = (short)2043016083;
				switch (num2 == num)
				{
				}
				num = (short)1339031552;
				short num3 = num;
				num = (short)223412225;
				if (num != 0)
				{
				}
				num = (short)3735552;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.Value;
			}
			set
			{
				short num = (short)550190106;
				short num2 = num;
				num = (short)251935770;
				switch (num2 == num)
				{
				}
				num = (short)969015296;
				short num3 = num;
				num = (short)930086913;
				if (num != 0)
				{
				}
				num = (short)1270546432;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTAREnable_A8488.Value = value;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00215654 File Offset: 0x00213854
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x00215708 File Offset: 0x00213908
		public bool SecWideMDCOTARMDCOTAREnable_A8488_Applicable
		{
			get
			{
				short num = (short)850329601;
				if (num != 0)
				{
				}
				num = (short)1389308395;
				short num2 = num;
				num = (short)1716791787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246101504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1497235456;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.Applicable;
			}
			set
			{
				short num = (short)1813855147;
				short num2 = num;
				num = (short)1994341291;
				switch (num2 == num)
				{
				}
				num = (short)1670971392;
				short num3 = num;
				num = (short)1950613505;
				if (num != 0)
				{
				}
				num = (short)2047016960;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTAREnable_A8488.Applicable = value;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x002157C0 File Offset: 0x002139C0
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x00215874 File Offset: 0x00213A74
		public bool SecWideMDCOTARMDCOTAREnable_A8488_Valid
		{
			get
			{
				short num = (short)946367921;
				short num2 = num;
				num = (short)4746673;
				switch (num2 == num)
				{
				}
				num = (short)175046656;
				short num3 = num;
				num = (short)1465384961;
				if (num != 0)
				{
				}
				num = (short)143196160;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.Valid;
			}
			set
			{
				short num = (short)1568591142;
				short num2 = num;
				num = (short)1483132198;
				switch (num2 == num)
				{
				}
				num = (short)544079872;
				short num3 = num;
				num = (short)1717174273;
				if (num != 0)
				{
				}
				num = (short)1297874944;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTAREnable_A8488.Valid = value;
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00215928 File Offset: 0x00213B28
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x002159DC File Offset: 0x00213BDC
		public bool SecWideMDCOTARMDCOTAREnable_A8488_Visible
		{
			get
			{
				short num = (short)26161518;
				short num2 = num;
				num = (short)762196334;
				switch (num2 == num)
				{
				}
				num = (short)1151729664;
				short num3 = num;
				num = (short)462618625;
				if (num != 0)
				{
				}
				num = (short)1505099776;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.Visible;
			}
			set
			{
				short num = (short)1122370381;
				short num2 = num;
				num = (short)1987773261;
				switch (num2 == num)
				{
				}
				num = (short)884998144;
				short num3 = num;
				num = (short)2096562177;
				if (num != 0)
				{
				}
				num = (short)983040;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTAREnable_A8488.Visible = value;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x00215A90 File Offset: 0x00213C90
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x00215B40 File Offset: 0x00213D40
		public bool SecWideMDCOTARMDCOTAREnable_A8488_Editable
		{
			get
			{
				short num = (short)589941942;
				short num2 = num;
				num = (short)1996344502;
				switch (num2 == num)
				{
				}
				num = (short)170262528;
				short num3 = num;
				num = (short)1594556417;
				if (num != 0)
				{
				}
				num = (short)2120613888;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.Editable;
			}
			set
			{
				short num = (short)1792264879;
				short num2 = num;
				num = (short)1802488495;
				switch (num2 == num)
				{
				}
				num = (short)2050162688;
				short num3 = num;
				num = (short)1749155840;
				if (num != 0)
				{
				}
				num = (short)596836353;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTAREnable_A8488.Editable = value;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x00215BF8 File Offset: 0x00213DF8
		internal string SecWideMDCOTARMDCOTAREnable_A8488_UILabel
		{
			get
			{
				short num = (short)284879922;
				short num2 = num;
				num = (short)512158770;
				switch (num2 == num)
				{
				}
				num = (short)1713111040;
				short num3 = num;
				num = (short)1412825088;
				if (num != 0)
				{
				}
				num = (short)1873870849;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.UIName;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x00215CAC File Offset: 0x00213EAC
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x00215D60 File Offset: 0x00213F60
		internal bool SecWideMDCOTARMDCOTAREnable_A8488_HiddenStatic
		{
			get
			{
				short num = (short)1127784186;
				short num2 = num;
				num = (short)1703845626;
				switch (num2 == num)
				{
				}
				num = (short)686096384;
				short num3 = num;
				num = (short)2013593601;
				if (num != 0)
				{
				}
				num = (short)927072256;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.HiddenStatic;
			}
			set
			{
				short num = (short)1737430877;
				short num2 = num;
				num = (short)742528861;
				switch (num2 == num)
				{
				}
				num = (short)141361152;
				short num3 = num;
				num = (short)1960181760;
				if (num != 0)
				{
				}
				num = (short)1631649793;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTAREnable_A8488.HiddenStatic = value;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x00215E14 File Offset: 0x00214014
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x00215ECC File Offset: 0x002140CC
		internal bool SecWideMDCOTARMDCOTAREnable_A8488_HiddenDynamic
		{
			get
			{
				short num = (short)354101860;
				short num2 = num;
				num = (short)1779444324;
				switch (num2 == num)
				{
				}
				num = (short)1874984960;
				short num3 = num;
				num = (short)2005532672;
				if (num != 0)
				{
				}
				num = (short)868483073;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488.HiddenDynamic;
			}
			set
			{
				short num = (short)1801021391;
				short num2 = num;
				num = (short)2064279503;
				switch (num2 == num)
				{
				}
				num = (short)363200512;
				short num3 = num;
				num = (short)723779585;
				if (num != 0)
				{
				}
				num = (short)470155264;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTAREnable_A8488.HiddenDynamic = value;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x00215F80 File Offset: 0x00214180
		public bool SecWideMDCOTARMDCOTAREnable_A8488_HasDiffs
		{
			get
			{
				short num = (short)1935697380;
				short num2 = num;
				num = (short)821257700;
				switch (num2 == num)
				{
				}
				num = (short)2011955200;
				short num3 = num;
				num = (short)744882177;
				if (num != 0)
				{
				}
				num = (short)604045312;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTAREnable_A8488._HasDiffs;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x00216038 File Offset: 0x00214238
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x002160F0 File Offset: 0x002142F0
		public bool SecWideMDCOTARStatusAlertTone_A8489Value
		{
			get
			{
				short num = (short)1822049849;
				short num2 = num;
				num = (short)1439057465;
				switch (num2 == num)
				{
				}
				num = (short)1873805312;
				short num3 = num;
				num = (short)1315831809;
				if (num != 0)
				{
				}
				num = (short)810090496;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.Value;
			}
			set
			{
				short num = (short)176569676;
				short num2 = num;
				num = (short)2079210828;
				switch (num2 == num)
				{
				}
				num = (short)1117257728;
				short num3 = num;
				num = (short)1016135680;
				if (num != 0)
				{
				}
				num = (short)158531585;
				if (num != 0)
				{
				}
				this.secWideMDCOTARStatusAlertTone_A8489.Value = value;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x002161A4 File Offset: 0x002143A4
		public global::AcpBusinessLayer.AcpField<bool> SecWideMDCOTARStatusAlertTone_A8489
		{
			get
			{
				short num = (short)1150418945;
				if (num != 0)
				{
				}
				num = (short)508742145;
				short num2 = num;
				num = (short)1758317057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1034420224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)58785792;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489;
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x00216254 File Offset: 0x00214454
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x0021630C File Offset: 0x0021450C
		public bool SecWideMDCOTARStatusAlertTone_A8489_UIValue
		{
			get
			{
				short num = (short)1845814917;
				short num2 = num;
				num = (short)1485956741;
				switch (num2 == num)
				{
				}
				num = (short)965279744;
				short num3 = num;
				num = (short)1450442753;
				if (num != 0)
				{
				}
				num = (short)1075314688;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.Value;
			}
			set
			{
				short num = (short)1154182256;
				short num2 = num;
				num = (short)1710386288;
				switch (num2 == num)
				{
				}
				num = (short)1887240192;
				short num3 = num;
				num = (short)687079425;
				if (num != 0)
				{
				}
				num = (short)1983709184;
				if (num != 0)
				{
				}
				this.secWideMDCOTARStatusAlertTone_A8489.Value = value;
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x002163C0 File Offset: 0x002145C0
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x00216474 File Offset: 0x00214674
		public bool SecWideMDCOTARStatusAlertTone_A8489_Applicable
		{
			get
			{
				short num = (short)2042819276;
				short num2 = num;
				num = (short)1948840652;
				switch (num2 == num)
				{
				}
				num = (short)943456256;
				short num3 = num;
				num = (short)862781441;
				if (num != 0)
				{
				}
				num = (short)160104448;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.Applicable;
			}
			set
			{
				short num = (short)1695805406;
				short num2 = num;
				num = (short)308735966;
				switch (num2 == num)
				{
				}
				num = (short)1639055360;
				short num3 = num;
				num = (short)2126249985;
				if (num != 0)
				{
				}
				num = (short)621019136;
				if (num != 0)
				{
				}
				this.secWideMDCOTARStatusAlertTone_A8489.Applicable = value;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x00216528 File Offset: 0x00214728
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x002165E0 File Offset: 0x002147E0
		public bool SecWideMDCOTARStatusAlertTone_A8489_Valid
		{
			get
			{
				short num = (short)1715358762;
				short num2 = num;
				num = (short)669535274;
				switch (num2 == num)
				{
				}
				num = (short)650444800;
				short num3 = num;
				num = (short)1219690497;
				if (num != 0)
				{
				}
				num = (short)630259712;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.Valid;
			}
			set
			{
				short num = (short)640387452;
				short num2 = num;
				num = (short)778799484;
				switch (num2 == num)
				{
				}
				num = (short)152895488;
				short num3 = num;
				num = (short)1487732737;
				if (num != 0)
				{
				}
				num = (short)103219200;
				if (num != 0)
				{
				}
				this.secWideMDCOTARStatusAlertTone_A8489.Valid = value;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x00216694 File Offset: 0x00214894
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x00216748 File Offset: 0x00214948
		public bool SecWideMDCOTARStatusAlertTone_A8489_Visible
		{
			get
			{
				short num = (short)1867448321;
				if (num != 0)
				{
				}
				num = (short)1076420444;
				short num2 = num;
				num = (short)836427612;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881197056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)202899456;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.Visible;
			}
			set
			{
				short num = (short)2029125633;
				if (num != 0)
				{
				}
				num = (short)1610223892;
				short num2 = num;
				num = (short)416944404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1302724608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)235339776;
				if (num != 0)
				{
				}
				this.secWideMDCOTARStatusAlertTone_A8489.Visible = value;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x002167FC File Offset: 0x002149FC
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x002168AC File Offset: 0x00214AAC
		public bool SecWideMDCOTARStatusAlertTone_A8489_Editable
		{
			get
			{
				short num = (short)148740108;
				short num2 = num;
				num = (short)1947834380;
				switch (num2 == num)
				{
				}
				num = (short)1069088768;
				short num3 = num;
				num = (short)913833985;
				if (num != 0)
				{
				}
				num = (short)542572544;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.Editable;
			}
			set
			{
				short num = (short)1898328491;
				short num2 = num;
				num = (short)1345204651;
				switch (num2 == num)
				{
				}
				num = (short)965672960;
				short num3 = num;
				num = (short)658833409;
				if (num != 0)
				{
				}
				num = (short)699072512;
				if (num != 0)
				{
				}
				this.secWideMDCOTARStatusAlertTone_A8489.Editable = value;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x00216964 File Offset: 0x00214B64
		internal string SecWideMDCOTARStatusAlertTone_A8489_UILabel
		{
			get
			{
				short num = (short)837889486;
				short num2 = num;
				num = (short)263269838;
				switch (num2 == num)
				{
				}
				num = (short)925040640;
				short num3 = num;
				num = (short)1998192641;
				if (num != 0)
				{
				}
				num = (short)1012465664;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.UIName;
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x00216A20 File Offset: 0x00214C20
		// (set) Token: 0x0600220B RID: 8715 RVA: 0x00216AD4 File Offset: 0x00214CD4
		internal bool SecWideMDCOTARStatusAlertTone_A8489_HiddenStatic
		{
			get
			{
				short num = (short)600768512;
				short num2 = num;
				num = (short)488833025;
				if (num != 0)
				{
				}
				num = (short)1810544148;
				short num3 = num;
				num = (short)923121172;
				switch (num3 == num)
				{
				}
				num = (short)1198587904;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.HiddenStatic;
			}
			set
			{
				short num = (short)1099300864;
				short num2 = num;
				num = (short)1434406412;
				short num3 = num;
				num = (short)770592268;
				switch (num3 == num)
				{
				}
				num = (short)1053360129;
				if (num != 0)
				{
				}
				num = (short)1601634304;
				if (num != 0)
				{
				}
				this.secWideMDCOTARStatusAlertTone_A8489.HiddenStatic = value;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x00216B88 File Offset: 0x00214D88
		// (set) Token: 0x0600220D RID: 8717 RVA: 0x00216C3C File Offset: 0x00214E3C
		internal bool SecWideMDCOTARStatusAlertTone_A8489_HiddenDynamic
		{
			get
			{
				short num = (short)1271201792;
				short num2 = num;
				num = (short)396925660;
				short num3 = num;
				num = (short)324049628;
				switch (num3 == num)
				{
				}
				num = (short)1074659328;
				if (num != 0)
				{
				}
				num = (short)1348468737;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489.HiddenDynamic;
			}
			set
			{
				short num = (short)2130444288;
				short num2 = num;
				num = (short)255432611;
				short num3 = num;
				num = (short)925996963;
				switch (num3 == num)
				{
				}
				num = (short)352387073;
				if (num != 0)
				{
				}
				num = (short)1324089344;
				if (num != 0)
				{
				}
				this.secWideMDCOTARStatusAlertTone_A8489.HiddenDynamic = value;
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x00216CF0 File Offset: 0x00214EF0
		public bool SecWideMDCOTARStatusAlertTone_A8489_HasDiffs
		{
			get
			{
				short num = (short)465174528;
				short num2 = num;
				num = (short)2064322194;
				short num3 = num;
				num = (short)274992786;
				switch (num3 == num)
				{
				}
				num = (short)1176502272;
				if (num != 0)
				{
				}
				num = (short)2006253569;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARStatusAlertTone_A8489._HasDiffs;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00216DA4 File Offset: 0x00214FA4
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x00216E58 File Offset: 0x00215058
		public int SecWideMDCOTARMDCOTARSystem_A8490Value
		{
			get
			{
				short num = (short)316669952;
				short num2 = num;
				num = (short)1466962828;
				short num3 = num;
				num = (short)442373004;
				switch (num3 == num)
				{
				}
				num = (short)39845889;
				if (num != 0)
				{
				}
				num = (short)1422327808;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.Value;
			}
			set
			{
				short num = (short)2088108032;
				short num2 = num;
				num = (short)409600001;
				if (num != 0)
				{
				}
				num = (short)314195159;
				short num3 = num;
				num = (short)97467607;
				switch (num3 == num)
				{
				}
				num = (short)784007168;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTARSystem_A8490.Value = value;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x00216F10 File Offset: 0x00215110
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x00216FC4 File Offset: 0x002151C4
		public string SecWideMDCOTARMDCOTARSystem_A8490_UIValue
		{
			get
			{
				short num = (short)2132606976;
				short num2 = num;
				num = (short)1588531458;
				short num3 = num;
				num = (short)2065109250;
				switch (num3 == num)
				{
				}
				num = (short)283639808;
				if (num != 0)
				{
				}
				num = (short)2099707905;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.UIValue;
			}
			set
			{
				short num = (short)1745420288;
				short num2 = num;
				num = (short)1237881406;
				short num3 = num;
				num = (short)2101318206;
				switch (num3 == num)
				{
				}
				num = (short)1360265216;
				if (num != 0)
				{
				}
				num = (short)2162689;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTARSystem_A8490.UIValue = value;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x0021707C File Offset: 0x0021527C
		public global::AcpBusinessLayer.AcpRecRefField SecWideMDCOTARMDCOTARSystem_A8490
		{
			get
			{
				short num = (short)2141061120;
				short num2 = num;
				num = (short)2091503994;
				short num3 = num;
				num = (short)1428410746;
				switch (num3 == num)
				{
				}
				num = (short)1555496961;
				if (num != 0)
				{
				}
				num = (short)2123169792;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x0021712C File Offset: 0x0021532C
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x002171E0 File Offset: 0x002153E0
		public bool SecWideMDCOTARMDCOTARSystem_A8490_Applicable
		{
			get
			{
				short num = (short)2037383168;
				short num2 = num;
				num = (short)1346936546;
				short num3 = num;
				num = (short)1538170594;
				switch (num3 == num)
				{
				}
				num = (short)2137128961;
				if (num != 0)
				{
				}
				num = (short)1656881152;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.Applicable;
			}
			set
			{
				short num = (short)97189888;
				short num2 = num;
				num = (short)1557720551;
				short num3 = num;
				num = (short)1525542375;
				switch (num3 == num)
				{
				}
				num = (short)1354170369;
				if (num != 0)
				{
				}
				num = (short)896335872;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTARSystem_A8490.Applicable = value;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x00217298 File Offset: 0x00215498
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0021734C File Offset: 0x0021554C
		public bool SecWideMDCOTARMDCOTARSystem_A8490_Valid
		{
			get
			{
				short num = (short)1880227840;
				short num2 = num;
				num = (short)2082661340;
				short num3 = num;
				num = (short)670884828;
				switch (num3 == num)
				{
				}
				num = (short)772079617;
				if (num != 0)
				{
				}
				num = (short)223019008;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.Valid;
			}
			set
			{
				short num = (short)740884480;
				short num2 = num;
				num = (short)841188020;
				short num3 = num;
				num = (short)779059892;
				switch (num3 == num)
				{
				}
				num = (short)1986723841;
				if (num != 0)
				{
				}
				num = (short)1835008;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTARSystem_A8490.Valid = value;
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x00217400 File Offset: 0x00215600
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x002174B4 File Offset: 0x002156B4
		public bool SecWideMDCOTARMDCOTARSystem_A8490_Visible
		{
			get
			{
				short num = (short)258211840;
				short num2 = num;
				num = (short)190962762;
				short num3 = num;
				num = (short)1349246026;
				switch (num3 == num)
				{
				}
				num = (short)2134573057;
				if (num != 0)
				{
				}
				num = (short)1924268032;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.Visible;
			}
			set
			{
				short num = (short)905576448;
				short num2 = num;
				num = (short)900411182;
				short num3 = num;
				num = (short)405876526;
				switch (num3 == num)
				{
				}
				num = (short)1939603457;
				if (num != 0)
				{
				}
				num = (short)1864892416;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTARSystem_A8490.Visible = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x0021756C File Offset: 0x0021576C
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x00217620 File Offset: 0x00215820
		public bool SecWideMDCOTARMDCOTARSystem_A8490_Editable
		{
			get
			{
				short num = (short)1495662592;
				short num2 = num;
				num = (short)1664622333;
				short num3 = num;
				num = (short)2009079549;
				switch (num3 == num)
				{
				}
				num = (short)469827584;
				if (num != 0)
				{
				}
				num = (short)2132344833;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.Editable;
			}
			set
			{
				short num = (short)787742720;
				short num2 = num;
				num = (short)178940731;
				short num3 = num;
				num = (short)1286826811;
				switch (num3 == num)
				{
				}
				num = (short)405012481;
				if (num != 0)
				{
				}
				num = (short)763494400;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTARSystem_A8490.Editable = value;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x002176D4 File Offset: 0x002158D4
		internal string SecWideMDCOTARMDCOTARSystem_A8490_UILabel
		{
			get
			{
				short num = (short)816119808;
				short num2 = num;
				num = (short)669333885;
				short num3 = num;
				num = (short)1607481725;
				switch (num3 == num)
				{
				}
				num = (short)996802561;
				if (num != 0)
				{
				}
				num = (short)992477184;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.UIName;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x0021778C File Offset: 0x0021598C
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x00217844 File Offset: 0x00215A44
		internal bool SecWideMDCOTARMDCOTARSystem_A8490_HiddenStatic
		{
			get
			{
				short num = (short)1589444608;
				short num2 = num;
				num = (short)143561080;
				short num3 = num;
				num = (short)955683192;
				switch (num3 == num)
				{
				}
				num = (short)228589569;
				if (num != 0)
				{
				}
				num = (short)1108475904;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.HiddenStatic;
			}
			set
			{
				short num = (short)977469440;
				short num2 = num;
				num = (short)86335646;
				short num3 = num;
				num = (short)1344364702;
				switch (num3 == num)
				{
				}
				num = (short)931659776;
				if (num != 0)
				{
				}
				num = (short)1048577;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTARSystem_A8490.HiddenStatic = value;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x002178FC File Offset: 0x00215AFC
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x002179B4 File Offset: 0x00215BB4
		internal bool SecWideMDCOTARMDCOTARSystem_A8490_HiddenDynamic
		{
			get
			{
				short num = (short)1416036352;
				short num2 = num;
				num = (short)214519345;
				short num3 = num;
				num = (short)1192250929;
				switch (num3 == num)
				{
				}
				num = (short)2039873536;
				if (num != 0)
				{
				}
				num = (short)487981057;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490.HiddenDynamic;
			}
			set
			{
				short num = (short)2089156608;
				short num2 = num;
				num = (short)519174620;
				short num3 = num;
				num = (short)1788803548;
				switch (num3 == num)
				{
				}
				num = (short)1908670464;
				if (num != 0)
				{
				}
				num = (short)1965031425;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMDCOTARSystem_A8490.HiddenDynamic = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x00217A68 File Offset: 0x00215C68
		public bool SecWideMDCOTARMDCOTARSystem_A8490_HasDiffs
		{
			get
			{
				short num = (short)891289600;
				short num2 = num;
				num = (short)1146651858;
				short num3 = num;
				num = (short)158500050;
				switch (num3 == num)
				{
				}
				num = (short)762707968;
				if (num != 0)
				{
				}
				num = (short)1935933441;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMDCOTARSystem_A8490._HasDiffs;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00217B20 File Offset: 0x00215D20
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00217BD4 File Offset: 0x00215DD4
		public int SecWideMDCOTARMode_A8533Value
		{
			get
			{
				short num = (short)1334902784;
				short num2 = num;
				num = (short)318460630;
				short num3 = num;
				num = (short)724128470;
				switch (num3 == num)
				{
				}
				num = (short)1292304385;
				if (num != 0)
				{
				}
				num = (short)912982016;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.Value;
			}
			set
			{
				short num = (short)399376384;
				short num2 = num;
				num = (short)1146224838;
				short num3 = num;
				num = (short)884670662;
				switch (num3 == num)
				{
				}
				num = (short)1612513281;
				if (num != 0)
				{
				}
				num = (short)1352138752;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMode_A8533.Value = value;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00217C8C File Offset: 0x00215E8C
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x00217D40 File Offset: 0x00215F40
		public string SecWideMDCOTARMode_A8533_UIValue
		{
			get
			{
				short num = (short)481624064;
				short num2 = num;
				num = (short)1261830145;
				if (num != 0)
				{
				}
				num = (short)1182682171;
				short num3 = num;
				num = (short)1196903483;
				switch (num3 == num)
				{
				}
				num = (short)1817247744;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.UIValue;
			}
			set
			{
				short num = (short)1515520000;
				short num2 = num;
				num = (short)232906176;
				short num3 = num;
				num = (short)286514624;
				switch (num3 == num)
				{
				}
				num = (short)220200960;
				if (num != 0)
				{
				}
				num = (short)1612578817;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMode_A8533.UIValue = value;
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x00217DF4 File Offset: 0x00215FF4
		public global::AcpBusinessLayer.AcpListField SecWideMDCOTARMode_A8533
		{
			get
			{
				short num = (short)509476864;
				short num2 = num;
				num = (short)226406958;
				short num3 = num;
				num = (short)2024911406;
				switch (num3 == num)
				{
				}
				num = (short)1872625665;
				if (num != 0)
				{
				}
				num = (short)377028608;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x00217EA4 File Offset: 0x002160A4
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x00217F58 File Offset: 0x00216158
		public bool SecWideMDCOTARMode_A8533_Applicable
		{
			get
			{
				short num = (short)566034432;
				short num2 = num;
				num = (short)129076820;
				short num3 = num;
				num = (short)776113748;
				switch (num3 == num)
				{
				}
				num = (short)82051073;
				if (num != 0)
				{
				}
				num = (short)1557135360;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.Applicable;
			}
			set
			{
				short num = (short)1560477696;
				short num2 = num;
				num = (short)507558930;
				short num3 = num;
				num = (short)197835794;
				switch (num3 == num)
				{
				}
				num = (short)494862337;
				if (num != 0)
				{
				}
				num = (short)1992228864;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMode_A8533.Applicable = value;
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x0021800C File Offset: 0x0021620C
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x002180C4 File Offset: 0x002162C4
		public bool SecWideMDCOTARMode_A8533_Valid
		{
			get
			{
				short num = (short)550830080;
				short num2 = num;
				num = (short)156958721;
				if (num != 0)
				{
				}
				num = (short)557029730;
				short num3 = num;
				num = (short)125475170;
				switch (num3 == num)
				{
				}
				num = (short)1200160768;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.Valid;
			}
			set
			{
				short num = (short)2046492672;
				short num2 = num;
				num = (short)977129890;
				short num3 = num;
				num = (short)1798820258;
				switch (num3 == num)
				{
				}
				num = (short)2101608449;
				if (num != 0)
				{
				}
				num = (short)1813053440;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMode_A8533.Valid = value;
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x00218178 File Offset: 0x00216378
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x0021822C File Offset: 0x0021642C
		public bool SecWideMDCOTARMode_A8533_Visible
		{
			get
			{
				short num = (short)282984448;
				short num2 = num;
				num = (short)634257409;
				if (num != 0)
				{
				}
				num = (short)131702503;
				short num3 = num;
				num = (short)1136238311;
				switch (num3 == num)
				{
				}
				num = (short)1203240960;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.Visible;
			}
			set
			{
				short num = (short)1999962112;
				short num2 = num;
				num = (short)14029979;
				short num3 = num;
				num = (short)328340635;
				switch (num3 == num)
				{
				}
				num = (short)1324220416;
				if (num != 0)
				{
				}
				num = (short)400621569;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMode_A8533.Visible = value;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x002182E0 File Offset: 0x002164E0
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x00218394 File Offset: 0x00216594
		public bool SecWideMDCOTARMode_A8533_Editable
		{
			get
			{
				short num = (short)951320576;
				short num2 = num;
				num = (short)1831771686;
				short num3 = num;
				num = (short)1212063270;
				switch (num3 == num)
				{
				}
				num = (short)762314753;
				if (num != 0)
				{
				}
				num = (short)124256256;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.Editable;
			}
			set
			{
				short num = (short)930873344;
				short num2 = num;
				num = (short)1037239325;
				short num3 = num;
				num = (short)1641153565;
				switch (num3 == num)
				{
				}
				num = (short)303104001;
				if (num != 0)
				{
				}
				num = (short)1779433472;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMode_A8533.Editable = value;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x0021844C File Offset: 0x0021664C
		internal string SecWideMDCOTARMode_A8533_UILabel
		{
			get
			{
				short num = (short)460980224;
				short num2 = num;
				num = (short)50364345;
				short num3 = num;
				num = (short)1644003257;
				switch (num3 == num)
				{
				}
				num = (short)1009319937;
				if (num != 0)
				{
				}
				num = (short)1227096064;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.UIName;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x002184FC File Offset: 0x002166FC
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x002185B0 File Offset: 0x002167B0
		internal bool SecWideMDCOTARMode_A8533_HiddenStatic
		{
			get
			{
				short num = (short)353632256;
				short num2 = num;
				num = (short)1063132114;
				short num3 = num;
				num = (short)1417616338;
				switch (num3 == num)
				{
				}
				num = (short)1512964096;
				if (num != 0)
				{
				}
				num = (short)385875969;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.HiddenStatic;
			}
			set
			{
				short num = (short)283770880;
				short num2 = num;
				num = (short)423362561;
				if (num != 0)
				{
				}
				num = (short)1901155394;
				short num3 = num;
				num = (short)656233538;
				switch (num3 == num)
				{
				}
				num = (short)304611328;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMode_A8533.HiddenStatic = value;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x00218668 File Offset: 0x00216868
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x0021871C File Offset: 0x0021691C
		internal bool SecWideMDCOTARMode_A8533_HiddenDynamic
		{
			get
			{
				short num = (short)1849688064;
				short num2 = num;
				num = (short)1267214605;
				short num3 = num;
				num = (short)1636903181;
				switch (num3 == num)
				{
				}
				num = (short)1760100353;
				if (num != 0)
				{
				}
				num = (short)1707737088;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533.HiddenDynamic;
			}
			set
			{
				short num = (short)1284702208;
				short num2 = num;
				num = (short)2143827254;
				short num3 = num;
				num = (short)607270198;
				switch (num3 == num)
				{
				}
				num = (short)977469441;
				if (num != 0)
				{
				}
				num = (short)915996672;
				if (num != 0)
				{
				}
				this.secWideMDCOTARMode_A8533.HiddenDynamic = value;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x002187D0 File Offset: 0x002169D0
		public bool SecWideMDCOTARMode_A8533_HasDiffs
		{
			get
			{
				short num = (short)474808320;
				short num2 = num;
				num = (short)1366032385;
				if (num != 0)
				{
				}
				num = (short)1697164045;
				short num3 = num;
				num = (short)1684777741;
				switch (num3 == num)
				{
				}
				num = (short)1972502528;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARMode_A8533._HasDiffs;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x00218888 File Offset: 0x00216A88
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x0021893C File Offset: 0x00216B3C
		public int SecWideMDCOTARPowerUp_A8716Value
		{
			get
			{
				short num = (short)1163132928;
				short num2 = num;
				num = (short)1380841606;
				short num3 = num;
				num = (short)503969926;
				switch (num3 == num)
				{
				}
				num = (short)1176043521;
				if (num != 0)
				{
				}
				num = (short)552665088;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.Value;
			}
			set
			{
				short num = (short)84344832;
				short num2 = num;
				num = (short)1478838178;
				short num3 = num;
				num = (short)175523746;
				switch (num3 == num)
				{
				}
				num = (short)1971585024;
				if (num != 0)
				{
				}
				num = (short)1499201537;
				if (num != 0)
				{
				}
				this.secWideMDCOTARPowerUp_A8716.Value = value;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x002189F4 File Offset: 0x00216BF4
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x00218AA8 File Offset: 0x00216CA8
		public string SecWideMDCOTARPowerUp_A8716_UIValue
		{
			get
			{
				short num = (short)1865285632;
				short num2 = num;
				num = (short)702939137;
				if (num != 0)
				{
				}
				num = (short)172588680;
				short num3 = num;
				num = (short)1849196168;
				switch (num3 == num)
				{
				}
				num = (short)93323264;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.UIValue;
			}
			set
			{
				short num = (short)1328676864;
				short num2 = num;
				num = (short)1566375937;
				if (num != 0)
				{
				}
				num = (short)1460997871;
				short num3 = num;
				num = (short)1128533743;
				switch (num3 == num)
				{
				}
				num = (short)1452867584;
				if (num != 0)
				{
				}
				this.secWideMDCOTARPowerUp_A8716.UIValue = value;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x00218B5C File Offset: 0x00216D5C
		public global::AcpBusinessLayer.AcpListField SecWideMDCOTARPowerUp_A8716
		{
			get
			{
				short num = (short)1526726656;
				short num2 = num;
				num = (short)527068458;
				short num3 = num;
				num = (short)1698131242;
				switch (num3 == num)
				{
				}
				num = (short)541392897;
				if (num != 0)
				{
				}
				num = (short)1076363264;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x00218C08 File Offset: 0x00216E08
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x00218CB8 File Offset: 0x00216EB8
		public bool SecWideMDCOTARPowerUp_A8716_Applicable
		{
			get
			{
				short num = (short)615841792;
				short num2 = num;
				num = (short)1183150048;
				short num3 = num;
				num = (short)669151200;
				switch (num3 == num)
				{
				}
				num = (short)151257088;
				if (num != 0)
				{
				}
				num = (short)549060609;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.Applicable;
			}
			set
			{
				short num = (short)1624637440;
				short num2 = num;
				num = (short)572807757;
				short num3 = num;
				num = (short)8804941;
				switch (num3 == num)
				{
				}
				num = (short)438108161;
				if (num != 0)
				{
				}
				num = (short)1433468928;
				if (num != 0)
				{
				}
				this.secWideMDCOTARPowerUp_A8716.Applicable = value;
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x00218D6C File Offset: 0x00216F6C
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x00218E20 File Offset: 0x00217020
		public bool SecWideMDCOTARPowerUp_A8716_Valid
		{
			get
			{
				short num = (short)1679622144;
				short num2 = num;
				num = (short)1093714015;
				short num3 = num;
				num = (short)272416863;
				switch (num3 == num)
				{
				}
				num = (short)1668284417;
				if (num != 0)
				{
				}
				num = (short)614531072;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.Valid;
			}
			set
			{
				short num = (short)1237231064;
				short num2 = num;
				num = (short)452896216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)752812032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)622133248;
				if (num != 0)
				{
				}
				num = (short)183173121;
				if (num != 0)
				{
				}
				this.secWideMDCOTARPowerUp_A8716.Valid = value;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x00218EDC File Offset: 0x002170DC
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x00218F94 File Offset: 0x00217194
		public bool SecWideMDCOTARPowerUp_A8716_Visible
		{
			get
			{
				short num = (short)1291411086;
				short num2 = num;
				num = (short)189226638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2011430912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1505099777;
				if (num != 0)
				{
				}
				num = (short)1709441024;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.Visible;
			}
			set
			{
				short num = (short)929013811;
				short num2 = num;
				num = (short)267362355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1891893248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329908225;
				if (num != 0)
				{
				}
				num = (short)836501504;
				if (num != 0)
				{
				}
				this.secWideMDCOTARPowerUp_A8716.Visible = value;
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00219048 File Offset: 0x00217248
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x002190FC File Offset: 0x002172FC
		public bool SecWideMDCOTARPowerUp_A8716_Editable
		{
			get
			{
				short num = (short)1171574064;
				short num2 = num;
				num = (short)1135398192;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1786380288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)549912577;
				if (num != 0)
				{
				}
				num = (short)451280896;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.Editable;
			}
			set
			{
				short num = (short)490799105;
				if (num != 0)
				{
				}
				num = (short)1226964992;
				short num2 = num;
				num = (short)609118178;
				short num3 = num;
				num = (short)14575586;
				switch (num3 == num)
				{
				}
				num = (short)1806237696;
				if (num != 0)
				{
				}
				this.secWideMDCOTARPowerUp_A8716.Editable = value;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x002191B4 File Offset: 0x002173B4
		internal string SecWideMDCOTARPowerUp_A8716_UILabel
		{
			get
			{
				short num = (short)1641501744;
				short num2 = num;
				num = (short)928535600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)8847360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1110900737;
				if (num != 0)
				{
				}
				num = (short)190382080;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.UIName;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x00219268 File Offset: 0x00217468
		// (set) Token: 0x06002244 RID: 8772 RVA: 0x00219320 File Offset: 0x00217520
		internal bool SecWideMDCOTARPowerUp_A8716_HiddenStatic
		{
			get
			{
				short num = (short)1784747530;
				short num2 = num;
				num = (short)500307466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1880293376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1748828160;
				if (num != 0)
				{
				}
				num = (short)2046033921;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.HiddenStatic;
			}
			set
			{
				short num = (short)2014117889;
				if (num != 0)
				{
				}
				num = (short)327417856;
				short num2 = num;
				num = (short)1624327372;
				short num3 = num;
				num = (short)1446790348;
				switch (num3 == num)
				{
				}
				num = (short)575143936;
				if (num != 0)
				{
				}
				this.secWideMDCOTARPowerUp_A8716.HiddenStatic = value;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x002193D4 File Offset: 0x002175D4
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x0021948C File Offset: 0x0021768C
		internal bool SecWideMDCOTARPowerUp_A8716_HiddenDynamic
		{
			get
			{
				short num = (short)763497931;
				short num2 = num;
				num = (short)1985744331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1480196096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1607335937;
				if (num != 0)
				{
				}
				num = (short)1551433728;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716.HiddenDynamic;
			}
			set
			{
				short num = (short)2142422865;
				short num2 = num;
				num = (short)515950417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135411200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)474284033;
				if (num != 0)
				{
				}
				num = (short)421920768;
				if (num != 0)
				{
				}
				this.secWideMDCOTARPowerUp_A8716.HiddenDynamic = value;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x00219540 File Offset: 0x00217740
		public bool SecWideMDCOTARPowerUp_A8716_HasDiffs
		{
			get
			{
				short num = (short)657219351;
				short num2 = num;
				num = (short)495017751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)335937536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330563585;
				if (num != 0)
				{
				}
				num = (short)454492160;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARPowerUp_A8716._HasDiffs;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x002195F4 File Offset: 0x002177F4
		// (set) Token: 0x06002249 RID: 8777 RVA: 0x002196A8 File Offset: 0x002178A8
		public bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835Value
		{
			get
			{
				short num = (short)589627393;
				if (num != 0)
				{
				}
				num = (short)276758528;
				short num2 = num;
				num = (short)2109103827;
				short num3 = num;
				num = (short)206593747;
				switch (num3 == num)
				{
				}
				num = (short)1610219520;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Value;
			}
			set
			{
				short num = (short)39257065;
				short num2 = num;
				num = (short)743244777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1593573376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)733216769;
				if (num != 0)
				{
				}
				num = (short)1402601472;
				if (num != 0)
				{
				}
				this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Value = value;
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x0021975C File Offset: 0x0021795C
		public global::AcpBusinessLayer.AcpField<bool> SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835
		{
			get
			{
				short num = (short)830870888;
				short num2 = num;
				num = (short)1713116520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)714342400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1764491265;
				if (num != 0)
				{
				}
				num = (short)822083584;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835;
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x0021980C File Offset: 0x00217A0C
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x002198C0 File Offset: 0x00217AC0
		public bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_UIValue
		{
			get
			{
				short num = (short)1978008960;
				short num2 = num;
				num = (short)751764864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1151533056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1672216577;
				if (num != 0)
				{
				}
				num = (short)61407232;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Value;
			}
			set
			{
				short num = (short)573774917;
				short num2 = num;
				num = (short)1972640837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)663748608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)743309312;
				if (num != 0)
				{
				}
				num = (short)284295169;
				if (num != 0)
				{
				}
				this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Value = value;
			}
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x00219974 File Offset: 0x00217B74
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x00219A28 File Offset: 0x00217C28
		public bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_Applicable
		{
			get
			{
				short num = (short)1292584181;
				short num2 = num;
				num = (short)1849246965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)195231744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1828651009;
				if (num != 0)
				{
				}
				num = (short)1620115456;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Applicable;
			}
			set
			{
				short num = (short)1326345753;
				short num2 = num;
				num = (short)54291993;
				switch (num2 == num)
				{
				default:
				{
					num = (short)22675456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)99155969;
				if (num != 0)
				{
				}
				num = (short)1218445312;
				if (num != 0)
				{
				}
				this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Applicable = value;
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x00219ADC File Offset: 0x00217CDC
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x00219B90 File Offset: 0x00217D90
		public bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_Valid
		{
			get
			{
				short num = (short)467075073;
				if (num != 0)
				{
				}
				num = (short)278790144;
				short num2 = num;
				num = (short)1196834340;
				short num3 = num;
				num = (short)1821064740;
				switch (num3 == num)
				{
				}
				num = (short)1630732288;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Valid;
			}
			set
			{
				short num = (short)1977953041;
				short num2 = num;
				num = (short)1137388305;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1574174720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)738918401;
				if (num != 0)
				{
				}
				num = (short)595460096;
				if (num != 0)
				{
				}
				this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Valid = value;
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x00219C48 File Offset: 0x00217E48
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x00219CFC File Offset: 0x00217EFC
		public bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_Visible
		{
			get
			{
				short num = (short)1402339329;
				if (num != 0)
				{
				}
				num = (short)185204736;
				short num2 = num;
				num = (short)2012585795;
				short num3 = num;
				num = (short)945397571;
				switch (num3 == num)
				{
				}
				num = (short)1193345024;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Visible;
			}
			set
			{
				short num = (short)1305300840;
				short num2 = num;
				num = (short)621367144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)12451840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)582025217;
				if (num != 0)
				{
				}
				num = (short)1686110208;
				if (num != 0)
				{
				}
				this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Visible = value;
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00219DB0 File Offset: 0x00217FB0
		// (set) Token: 0x06002254 RID: 8788 RVA: 0x00219E68 File Offset: 0x00218068
		public bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_Editable
		{
			get
			{
				short num = (short)852623361;
				if (num != 0)
				{
				}
				num = (short)1313800192;
				short num2 = num;
				num = (short)320827;
				short num3 = num;
				num = (short)1050338619;
				switch (num3 == num)
				{
				}
				num = (short)209453056;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Editable;
			}
			set
			{
				short num = (short)1891919978;
				short num2 = num;
				num = (short)1908828266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)183566336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493106688;
				if (num != 0)
				{
				}
				num = (short)1655177217;
				if (num != 0)
				{
				}
				this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.Editable = value;
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x00219F20 File Offset: 0x00218120
		internal string SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_UILabel
		{
			get
			{
				short num = (short)950086503;
				short num2 = num;
				num = (short)779365223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1025245184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340866561;
				if (num != 0)
				{
				}
				num = (short)859963392;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.UIName;
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00219FD4 File Offset: 0x002181D4
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x0021A088 File Offset: 0x00218288
		internal bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_HiddenStatic
		{
			get
			{
				short num = (short)853779235;
				short num2 = num;
				num = (short)1971626787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919404544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1837498368;
				if (num != 0)
				{
				}
				num = (short)945029121;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.HiddenStatic;
			}
			set
			{
				short num = (short)276955477;
				short num2 = num;
				num = (short)883491157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)63438848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1895628801;
				if (num != 0)
				{
				}
				num = (short)2061500416;
				if (num != 0)
				{
				}
				this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.HiddenStatic = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x0021A13C File Offset: 0x0021833C
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x0021A1F4 File Offset: 0x002183F4
		internal bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_HiddenDynamic
		{
			get
			{
				short num = (short)462372143;
				short num2 = num;
				num = (short)276643119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1343160320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2030174208;
				if (num != 0)
				{
				}
				num = (short)1185677313;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.HiddenDynamic;
			}
			set
			{
				short num = (short)2029977601;
				if (num != 0)
				{
				}
				num = (short)415891456;
				short num2 = num;
				num = (short)227333198;
				short num3 = num;
				num = (short)1192350798;
				switch (num3 == num)
				{
				}
				num = (short)392953856;
				if (num != 0)
				{
				}
				this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835.HiddenDynamic = value;
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x0021A2A8 File Offset: 0x002184A8
		public bool SecWideMDCOTARRadioInhibitviaMDCOTAR_A8835_HasDiffs
		{
			get
			{
				short num = (short)787018198;
				short num2 = num;
				num = (short)2026828246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1733754880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)96337921;
				if (num != 0)
				{
				}
				num = (short)545456128;
				if (num != 0)
				{
				}
				return this.secWideMDCOTARRadioInhibitviaMDCOTAR_A8835._HasDiffs;
			}
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0021A360 File Offset: 0x00218560
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1149435906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)857473025;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)344719363;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1172561681;
					short num3 = num2;
					num2 = (short)439803665;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
					{
						num2 = (short)1947926528;
						if (num2 != 0)
						{
						}
						num2 = (short)1345323008;
						short num4 = num2;
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)724172801;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 3:
					return result;
				case 4:
					goto IL_3A;
				}
				goto IL_24;
				IL_3A:
				if (base.ParentRecset == null)
				{
					break;
				}
				num2 = (short)851968;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)146866180;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x0021A4D0 File Offset: 0x002186D0
		private void a()
		{
			short num = (short)1374683137;
			if (num != 0)
			{
			}
			num = (short)1283719168;
			short num2 = num;
			num = (short)2147053024;
			short num3 = num;
			num = (short)1415343584;
			switch (num3 == num)
			{
			}
			num = (short)550043648;
			if (num != 0)
			{
			}
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.SecureWide.General.OnSecureWideGeneralOtarEnablePropertyChanged;
		}

		// Token: 0x04000BD2 RID: 3026
		private global::AcpBusinessLayer.AcpField<bool> secWideMDCOTAREnable_A7967;

		// Token: 0x04000BD3 RID: 3027
		private global::AcpBusinessLayer.AcpField<bool> secWideMDCOTAREncryptedOnly_A7971;

		// Token: 0x04000BD4 RID: 3028
		private global::AcpBusinessLayer.AcpField<bool> secWideMDCOTARErasePreviousIndexonIndexChange_A7976;

		// Token: 0x04000BD5 RID: 3029
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideMDCOTARKMCID_A8374;

		// Token: 0x04000BD6 RID: 3030
		private global::AcpBusinessLayer.AcpField<bool> secWideMDCOTARMDCOTAREnable_A8488;

		// Token: 0x04000BD7 RID: 3031
		private global::AcpBusinessLayer.AcpField<bool> secWideMDCOTARStatusAlertTone_A8489;

		// Token: 0x04000BD8 RID: 3032
		private global::AcpBusinessLayer.AcpRecRefField secWideMDCOTARMDCOTARSystem_A8490;

		// Token: 0x04000BD9 RID: 3033
		private global::AcpBusinessLayer.AcpListField secWideMDCOTARMode_A8533;

		// Token: 0x04000BDA RID: 3034
		private global::AcpBusinessLayer.AcpListField secWideMDCOTARPowerUp_A8716;

		// Token: 0x04000BDB RID: 3035
		private global::AcpBusinessLayer.AcpField<bool> secWideMDCOTARRadioInhibitviaMDCOTAR_A8835;
	}
}
