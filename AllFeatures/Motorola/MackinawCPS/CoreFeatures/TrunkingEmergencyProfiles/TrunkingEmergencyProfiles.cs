using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x02000479 RID: 1145
	[global::System.Serializable]
	public class TrunkingEmergencyProfiles : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06009631 RID: 38449 RVA: 0x008D2F04 File Offset: 0x008D1104
		public TrunkingEmergencyProfiles(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 3;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("郃듅뷇꓉Ɤꟍ뻏뗑鏕뗗뿙껛망藟賡蟣鿥죧뫩黫臭雯鯱飳鏵请", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("藃꫅꓇賉꧋꿍꓏ꟑꛓ돕ꯗ鿛뇝跟鋡诣裥跧蓩飫닭뗯鿱釳蓵鿷鿹鋻鷽秿∁䜃椅昇氉攋植攏怑甓戕焗甙爛䈝琟倡儣䠥䌧䌩䈫䤭ု眱夳匵䨷崹夻倽⌿㭁摃ᙅ㩇╉⩋❍㱏㝑❓੕౗⡙⥛そୟୡ੣ťⵧݩ५ᱭᝯ᝱ᩳᕵŷ⩹๻ᅽﮇꒉﶏﺑ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.EmergencyCompatibilityOptionsTrunking(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06009632 RID: 38450 RVA: 0x008D2F94 File Offset: 0x008D1194
		protected TrunkingEmergencyProfiles(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓏ꃑꇓ룕돗동닛망샟꟡解菥髧跩觫胭鏯诱퓳꛵諷闹髻韽泿朁眃", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILES;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹맻鏽旿瀁挃挅昇椉甋⸍匏紑稓瀕焗紙椛氝䄟嘡䴣䤥䘧瘩砫尭䔯就弳張嘷崹᰻笽ⴿ❁㙃ⅅⵇ⑉⽋㝍灏ɑ♓㥕㹗㍙せ㭝፟㹡っᑥᵧѩݫݭṯᕱㅳ᭵ᵷࡹ᭻᭽ﶃ횅慎ﲏ뢕ﮙ", a_);
		}

		// Token: 0x17004B6A RID: 19306
		// (get) Token: 0x06009633 RID: 38451 RVA: 0x008D2FE8 File Offset: 0x008D11E8
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General General
		{
			get
			{
				short num = (short)327663516;
				short num2 = num;
				num = (short)680247196;
				switch (num2 == num)
				{
				}
				num = (short)1134690304;
				short num3 = num;
				num = (short)997261313;
				if (num != 0)
				{
				}
				num = (short)2021195776;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.General)base[10186];
			}
		}

		// Token: 0x17004B6B RID: 19307
		// (get) Token: 0x06009634 RID: 38452 RVA: 0x008D30A0 File Offset: 0x008D12A0
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneList TrunkingEmergencyToneList
		{
			get
			{
				short num = (short)494667500;
				short num2 = num;
				num = (short)581633772;
				switch (num2 == num)
				{
				}
				num = (short)2124349440;
				short num3 = num;
				num = (short)43188224;
				if (num != 0)
				{
				}
				num = (short)1473904641;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneList)base[10775];
			}
		}

		// Token: 0x17004B6C RID: 19308
		// (get) Token: 0x06009635 RID: 38453 RVA: 0x008D3158 File Offset: 0x008D1358
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.EmergencyCompatibilityOptionsTrunking EmergencyCompatibilityOptionsTrunking
		{
			get
			{
				short num = (short)85678324;
				short num2 = num;
				num = (short)611866868;
				switch (num2 == num)
				{
				}
				num = (short)1308098560;
				short num3 = num;
				num = (short)468451328;
				if (num != 0)
				{
				}
				num = (short)535166977;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.EmergencyCompatibilityOptionsTrunking)base[10845];
			}
		}

		// Token: 0x17004B6D RID: 19309
		// (get) Token: 0x06009636 RID: 38454 RVA: 0x008D3210 File Offset: 0x008D1410
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.Labtool Labtool
		{
			get
			{
				short num = (short)426678939;
				short num2 = num;
				num = (short)1693031067;
				switch (num2 == num)
				{
				}
				num = (short)1653145600;
				short num3 = num;
				num = (short)549978113;
				if (num != 0)
				{
				}
				num = (short)545128448;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.Labtool)base[10187];
			}
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x008D32C8 File Offset: 0x008D14C8
		public static global::AcpCommonLib.IAcpFeatureNode GetTrunkingEmergencyProfiles()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2076)[0];
					num2 = (short)86376450;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)1000870262;
					short num3 = num2;
					num2 = (short)1095700854;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1400504320;
						if (num2 != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)727515136;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2076)[0];
						break;
					}
					num2 = (short)90898433;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
			}
			return result;
			IL_20:
			num2 = (short)342425601;
			if (num2 != 0)
			{
			}
			num2 = (short)698155008;
			short num4 = num2;
			result = null;
			num2 = (short)1041760259;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
