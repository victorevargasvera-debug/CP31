using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.EmergencyWide
{
	// Token: 0x0200048E RID: 1166
	[global::System.Serializable]
	public class EmergencyWideImpactDetection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060098A3 RID: 39075 RVA: 0x008F409C File Offset: 0x008F229C
		public EmergencyWideImpactDetection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x008F40B8 File Offset: 0x008F22B8
		protected EmergencyWideImpactDetection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x008F40D0 File Offset: 0x008F22D0
		public override void Init()
		{
			int a_ = 12;
			short num = (short)392983783;
			short num2 = num;
			num = (short)853046503;
			switch (num2 == num)
			{
			}
			num = (short)134742016;
			if (num != 0)
			{
			}
			num = (short)1425211392;
			short num3 = num;
			num = (short)345309185;
			if (num != 0)
			{
			}
			this.emerWideImpactDetectionPreAlertTimer_A43381 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裌ꋎ듐ꇒ苔뻖뷘뻚铜닞釠苢蛤鏦귨軪駬諮鋰蟲鳴飶韸꯺迼髾䀀漂怄甆紈弊搌戎琐愒䨔嘖ⴘ⠚⸜✞ဠ", a_), global::CommonResources.AcgResources.ID_PREALERTTIMERSEC, 0, 120, null, null, 0, 1);
			this.emerWideImpactDetectionPreAlertTimer_A43381.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideImpactDetectionPreAlertTimer_A43381.DataTransferOrder = 17;
			this.emerWideImpactDetectionPreAlertTimer_A43381.ShowHexValue = false;
			this.emerWideImpactDetectionPostAlertTimer_A43382 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裌ꋎ듐ꇒ苔뻖뷘뻚铜닞釠苢蛤鏦귨軪駬諮鋰蟲鳴飶韸꯺鋼賾甀䈂椄戆笈缊夌明簐瘒朔䠖堘⼚⸜Ⱎᤠᄢ", a_), global::CommonResources.AcgResources.ID_POSTALERTTIMERSEC, 0, 120, null, null, 0, 1);
			this.emerWideImpactDetectionPostAlertTimer_A43382.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideImpactDetectionPostAlertTimer_A43382.DataTransferOrder = 16;
			this.emerWideImpactDetectionPostAlertTimer_A43382.ShowHexValue = false;
			this.emerWideImpactDetectionPreAlertTone_A43383 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裌ꋎ듐ꇒ苔뻖뷘뻚铜닞釠苢蛤鏦귨軪駬諮鋰蟲鳴飶韸꯺迼髾䀀漂怄甆紈弊戌愎琐䰒吔⌖⨘⠚├Ⱎ", a_), global::CommonResources.AcgResources.ID_PREALERTTONE, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideImpactDetectionPreAlertTone_A43383LovStrs);
			this.emerWideImpactDetectionPreAlertTone_A43383.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideImpactDetectionPreAlertTone_A43383.DataTransferOrder = 18;
			this.emerWideImpactDetectionConfigLevel_A43384 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裌ꋎ듐ꇒ苔뻖뷘뻚铜닞釠苢蛤鏦귨軪駬諮鋰蟲鳴飶韸룺鋼釾最樂戄䬆氈紊栌挎丐划℔␖⨘⌚⤜", a_), global::CommonResources.AcgResources.ID_CONFIGURABILITYLEVEL, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideImpactDetectionConfigLevel_A43384LovStrs);
			this.emerWideImpactDetectionConfigLevel_A43384.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideImpactDetectionConfigLevel_A43384.DataTransferOrder = 19;
			this.emerWideImpDectToneTrigger_A43386 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("裌ꋎ듐ꇒ苔뻖뷘뻚铜닞釠꟢胤蓦鷨뿪苬臮铰ꟲ蟴黶黸鳺飼跾帀䈂㄄㐆㨈㌊㬌", a_), global::CommonResources.AcgResources.ID_EMERGENCYTONETRIGGER);
			this.emerWideImpDectToneTrigger_A43386.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.emerWideImpDectToneTrigger_A43386.DataTransferOrder = 20;
			this.emerWideImpactDetectionEventDuration_A43427 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("裌ꋎ듐ꇒ苔뻖뷘뻚铜닞釠苢蛤鏦귨軪駬諮鋰蟲鳴飶韸뻺诼髾漀眂䄄爆笈樊礌明縐紒䨔嘖ⴘ⠚⤜ⴞᘠ", a_), global::CommonResources.AcgResources.ID_EVENTDURATIONMSEC, 0, 100, null, null, 0, 1);
			this.emerWideImpactDetectionEventDuration_A43427.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.emerWideImpactDetectionEventDuration_A43427.DataTransferOrder = 21;
			this.emerWideImpactDetectionEventDuration_A43427.ShowHexValue = false;
			this.emerWideImpactDetectionEventForce_A43428 = new global::AcpBusinessLayer.AcpSimpleRangeField(50, this, global::AllFeatures.CodeplugGuid.b("裌ꋎ듐ꇒ苔뻖뷘뻚铜닞釠苢蛤鏦귨軪駬諮鋰蟲鳴飶韸뻺诼髾漀眂䌄栆笈栊栌倎倐✒☔⌖⬘⌚", a_), global::CommonResources.AcgResources.ID_EVENTFORCE, 0, 100, null, null, 0, 1);
			this.emerWideImpactDetectionEventForce_A43428.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.emerWideImpactDetectionEventForce_A43428.DataTransferOrder = 22;
			this.emerWideImpactDetectionEventForce_A43428.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓌ꋎꇐ닒뛔ꏖ律鿚룜ꯞ蓠胢釤軦蛨藪", a_);
			base.Id = 10854;
			base.UIName = global::CommonResources.AcgResources.ID_IMPACTDETECTION;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x008F439C File Offset: 0x008F259C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1527185409;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥곧迩迫髭ꓯ鷱髳鏵곷裹闻駽柿朁瘃夅䤇㸉㼋㴍⠏␑", a_)))
					{
						num = (short)341770251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 2:
					IL_597:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都僿瀁愃䜅搇漉縋稍䐏紑稓猕䜗嬙⠛ⴝጟᨡᜣ", a_)))
					{
						num = (short)787808264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C9;
				case 3:
					goto IL_281;
				case 4:
					num = (short)614662156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_580;
				case 6:
					goto IL_5C9;
				case 7:
					num = (short)2028994569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.emerWideImpactDetectionPreAlertTone_A43383 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都僿瀁愃䜅搇漉縋稍䐏紑稓猕䜗嬙⠛ⴝጟᨡᜣ", a_), global::CommonResources.AcgResources.ID_PREALERTTONE, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideImpactDetectionPreAlertTone_A43383LovStrs);
					this.emerWideImpactDetectionPreAlertTone_A43383.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideImpactDetectionPreAlertTone_A43383.DataTransferOrder = 18;
					num = (short)1399324678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields != null)
					{
						num = (short)1503330308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_617;
				case 10:
					goto IL_3DA;
				case 11:
					this.emerWideImpDectToneTrigger_A43386 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥곧迩迫髭ꓯ鷱髳鏵곷裹闻駽柿朁瘃夅䤇㸉㼋㴍⠏␑", a_), global::CommonResources.AcgResources.ID_EMERGENCYTONETRIGGER);
					this.emerWideImpDectToneTrigger_A43386.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideImpDectToneTrigger_A43386.DataTransferOrder = 20;
					num = (short)254738447;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都僿瀁愃䜅搇漉縋稍䐏笑礓猕樗䔙崛⨝ጟᄡᰣᜥ", a_)))
					{
						num = (short)797376536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DA;
				case 13:
					this.emerWideImpactDetectionEventForce_A43428 = new global::AcpBusinessLayer.AcpSimpleRangeField(50, this, global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都䗿琁愃栅簇䰉挋簍猏眑䬓圕Ⱇ⤙⠛Ⱍ᠟", a_), global::CommonResources.AcgResources.ID_EVENTFORCE, null, null, 0, 1);
					this.emerWideImpactDetectionEventForce_A43428.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.emerWideImpactDetectionEventForce_A43428.DataTransferOrder = 22;
					this.emerWideImpactDetectionEventForce_A43428.ShowHexValue = false;
					num = (short)446365712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都僿洁眃爅䤇昉椋簍搏䘑紓笕紗栙䌛弝ᐟᄡᜣḥᨧ", a_)))
					{
						num = (short)723386387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_580;
				case 15:
					goto IL_49B;
				case 16:
					goto IL_37A;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都䗿琁愃栅簇三礋簍焏昑紓礕瘗䔙崛⨝ጟᘡᘣᄥ", a_)))
					{
						num = (short)1688600597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44E;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都䏿洁樃怅愇洉䀋欍昏眑砓䤕夗⸙⼛ⴝ᠟ᘡ", a_)))
					{
						num = (short)1420754964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_281;
				case 19:
					num = (short)1906966529;
					if (num != 0)
					{
					}
					this.emerWideImpactDetectionPostAlertTimer_A43382 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都僿洁眃爅䤇昉椋簍搏䘑紓笕紗栙䌛弝ᐟᄡᜣḥᨧ", a_), global::CommonResources.AcgResources.ID_POSTALERTTIMERSEC, null, null, 0, 1);
					this.emerWideImpactDetectionPostAlertTimer_A43382.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideImpactDetectionPostAlertTimer_A43382.DataTransferOrder = 16;
					this.emerWideImpactDetectionPostAlertTimer_A43382.ShowHexValue = false;
					num = (short)752353285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.emerWideImpactDetectionConfigLevel_A43384 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都䏿洁樃怅愇洉䀋欍昏眑砓䤕夗⸙⼛ⴝ᠟ᘡ", a_), global::CommonResources.AcgResources.ID_CONFIGURABILITYLEVEL, global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.LOVs.EmerWideImpactDetectionConfigLevel_A43384LovStrs);
					this.emerWideImpactDetectionConfigLevel_A43384.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideImpactDetectionConfigLevel_A43384.DataTransferOrder = 19;
					num = (short)1316225027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.emerWideImpactDetectionEventDuration_A43427 = new global::AcpBusinessLayer.AcpSimpleRangeField(40, this, global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都䗿琁愃栅簇三礋簍焏昑紓礕瘗䔙崛⨝ጟᘡᘣᄥ", a_), global::CommonResources.AcgResources.ID_EVENTDURATIONMSEC, null, null, 0, 1);
					this.emerWideImpactDetectionEventDuration_A43427.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.emerWideImpactDetectionEventDuration_A43427.DataTransferOrder = 21;
					this.emerWideImpactDetectionEventDuration_A43427.ShowHexValue = false;
					num = (short)1959591959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都䗿琁愃栅簇䰉挋簍猏眑䬓圕Ⱇ⤙⠛Ⱍ᠟", a_)))
					{
						num = (short)781123597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_617;
				case 23:
					goto IL_44E;
				case 24:
					this.emerWideImpactDetectionPreAlertTimer_A43381 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("韑맓돕꫗跙뗛뫝藟ꯡ解雥觧觩飫ꫭ闯蛱釳闵賷鏹鏻都僿瀁愃䜅搇漉縋稍䐏笑礓猕樗䔙崛⨝ጟᄡᰣᜥ", a_), global::CommonResources.AcgResources.ID_PREALERTTIMERSEC, null, null, 0, 1);
					this.emerWideImpactDetectionPreAlertTimer_A43381.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.emerWideImpactDetectionPreAlertTimer_A43381.DataTransferOrder = 17;
					this.emerWideImpactDetectionPreAlertTimer_A43381.ShowHexValue = false;
					num = (short)933691402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_92:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)974061575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_281:
				num = (short)2073597732;
				short num3 = num;
				num = (short)800757540;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_597;
				default:
					num = (short)2112815104;
					if (num != 0)
					{
					}
					num = (short)805109760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3DA:
				num = (short)56492046;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44E:
				num = (short)1445330966;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_49B:
				num = (short)1253638161;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_580:
				num = (short)1726349314;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5C9:
				num = (short)191561746;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_37A:
			IL_617:
			num = (short)1399652352;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯑맓ꛕ맗맙꣛ﻝꓟ蟡郣菥诧黩藫臭黯", a_);
			base.Id = 10854;
			base.UIName = global::CommonResources.AcgResources.ID_IMPACTDETECTION;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x008F4A1C File Offset: 0x008F2C1C
		public override void PopulateReferences()
		{
			short num = (short)767557632;
			short num2 = num;
			num = (short)1781406543;
			short num3 = num;
			num = (short)468720463;
			switch (num3 == num)
			{
			}
			num = (short)1745354753;
			if (num != 0)
			{
			}
			num = (short)516292608;
			if (num != 0)
			{
			}
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x008F4AC4 File Offset: 0x008F2CC4
		public override void DropReferences()
		{
			short num = (short)694353920;
			short num2 = num;
			num = (short)1711100425;
			short num3 = num;
			num = (short)575099401;
			switch (num3 == num)
			{
			}
			num = (short)496893953;
			if (num != 0)
			{
			}
			num = (short)2004418560;
			if (num != 0)
			{
			}
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x008F4B6C File Offset: 0x008F2D6C
		public override void SetConstraints()
		{
			short num = (short)860160000;
			short num2 = num;
			num = (short)1036517377;
			if (num != 0)
			{
			}
			num = (short)1060099718;
			short num3 = num;
			num = (short)386848390;
			switch (num3 == num)
			{
			}
			num = (short)676921344;
			if (num != 0)
			{
			}
			this.emerWideImpactDetectionPreAlertTimer_A43381.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConConfigLevelIsNotDisabled);
			this.emerWideImpactDetectionPreAlertTimer_A43381.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.SetEditabilityAlwaysFalse);
			this.emerWideImpactDetectionPostAlertTimer_A43382.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConConfigLevelIsNotDisabled);
			this.emerWideImpactDetectionPreAlertTone_A43383.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConConfigLevelIsNotDisabled);
			this.emerWideImpactDetectionConfigLevel_A43384.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.conSetTriggedByImpDetectValue);
			this.emerWideImpDectToneTrigger_A43386.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.conImpDetectApplicable);
			this.emerWideImpactDetectionEventDuration_A43427.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConConfigLevelIsNotDisabled);
			this.emerWideImpactDetectionEventForce_A43428.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideConstraints.ConConfigLevelIsNotDisabled);
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x008F4CD0 File Offset: 0x008F2ED0
		public override void SetupDependencies()
		{
			short num = (short)1174732800;
			short num2 = num;
			num = (short)999369441;
			short num3 = num;
			num = (short)675818209;
			switch (num3 == num)
			{
			}
			num = (short)2115633153;
			if (num != 0)
			{
			}
			num = (short)2052849664;
			if (num != 0)
			{
			}
			this.emerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerWideImpactDetectionPreAlertTimer_A43381);
			this.emerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerWideImpactDetectionPostAlertTimer_A43382);
			this.emerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerWideImpactDetectionPreAlertTone_A43383);
			this.emerWideImpDectToneTrigger_A43386.AddDependentObject(this.emerWideImpactDetectionConfigLevel_A43384);
			this.emerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerWideImpDectToneTrigger_A43386);
			this.emerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerWideImpactDetectionEventDuration_A43427);
			this.emerWideImpactDetectionConfigLevel_A43384.AddDependentObject(this.emerWideImpactDetectionEventForce_A43428);
		}

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x060098AB RID: 39083 RVA: 0x008F4DF8 File Offset: 0x008F2FF8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1556414464;
				short num2 = num;
				num = (short)1396363818;
				short num3 = num;
				num = (short)1101058602;
				switch (num3 == num)
				{
				}
				num = (short)2016018433;
				if (num != 0)
				{
				}
				num = (short)1547370496;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x060098AC RID: 39084 RVA: 0x008F4EA8 File Offset: 0x008F30A8
		// (set) Token: 0x060098AD RID: 39085 RVA: 0x008F4F5C File Offset: 0x008F315C
		public int EmerWideImpactDetectionPreAlertTimer_A43381Value
		{
			get
			{
				short num = (short)1983447040;
				short num2 = num;
				num = (short)1788955511;
				short num3 = num;
				num = (short)2086620023;
				switch (num3 == num)
				{
				}
				num = (short)1769996289;
				if (num != 0)
				{
				}
				num = (short)303955968;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.Value;
			}
			set
			{
				short num = (short)2006581248;
				short num2 = num;
				num = (short)434984872;
				short num3 = num;
				num = (short)801527720;
				switch (num3 == num)
				{
				}
				num = (short)1418985473;
				if (num != 0)
				{
				}
				num = (short)1240530944;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.Value = value;
			}
		}

		// Token: 0x17004C9C RID: 19612
		// (get) Token: 0x060098AE RID: 39086 RVA: 0x008F5010 File Offset: 0x008F3210
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerWideImpactDetectionPreAlertTimer_A43381
		{
			get
			{
				short num = (short)1458831360;
				short num2 = num;
				num = (short)1331730510;
				short num3 = num;
				num = (short)1466275918;
				switch (num3 == num)
				{
				}
				num = (short)1500577793;
				if (num != 0)
				{
				}
				num = (short)288423936;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381;
			}
		}

		// Token: 0x17004C9D RID: 19613
		// (get) Token: 0x060098AF RID: 39087 RVA: 0x008F50C4 File Offset: 0x008F32C4
		// (set) Token: 0x060098B0 RID: 39088 RVA: 0x008F5178 File Offset: 0x008F3378
		public string EmerWideImpactDetectionPreAlertTimer_A43381_UIValue
		{
			get
			{
				short num = (short)1725169664;
				short num2 = num;
				num = (short)1726358968;
				short num3 = num;
				num = (short)1271014840;
				switch (num3 == num)
				{
				}
				num = (short)1209008129;
				if (num != 0)
				{
				}
				num = (short)893517824;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.UIValue;
			}
			set
			{
				short num = (short)172621824;
				short num2 = num;
				num = (short)1898429734;
				short num3 = num;
				num = (short)2056109350;
				switch (num3 == num)
				{
				}
				num = (short)1238302721;
				if (num != 0)
				{
				}
				num = (short)237174784;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.UIValue = value;
			}
		}

		// Token: 0x17004C9E RID: 19614
		// (get) Token: 0x060098B1 RID: 39089 RVA: 0x008F522C File Offset: 0x008F342C
		// (set) Token: 0x060098B2 RID: 39090 RVA: 0x008F52E0 File Offset: 0x008F34E0
		internal int EmerWideImpactDetectionPreAlertTimer_A43381Min
		{
			get
			{
				short num = (short)109051904;
				short num2 = num;
				num = (short)2046568173;
				short num3 = num;
				num = (short)903554797;
				switch (num3 == num)
				{
				}
				num = (short)1023016961;
				if (num != 0)
				{
				}
				num = (short)279969792;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.Min;
			}
			set
			{
				short num = (short)1056243712;
				short num2 = num;
				num = (short)1492982292;
				short num3 = num;
				num = (short)528554516;
				switch (num3 == num)
				{
				}
				num = (short)941031424;
				if (num != 0)
				{
				}
				num = (short)1246298113;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.Min = value;
			}
		}

		// Token: 0x17004C9F RID: 19615
		// (get) Token: 0x060098B3 RID: 39091 RVA: 0x008F5394 File Offset: 0x008F3594
		// (set) Token: 0x060098B4 RID: 39092 RVA: 0x008F5448 File Offset: 0x008F3648
		internal int EmerWideImpactDetectionPreAlertTimer_A43381Max
		{
			get
			{
				short num = (short)1767243776;
				short num2 = num;
				num = (short)68264421;
				short num3 = num;
				num = (short)2054136293;
				switch (num3 == num)
				{
				}
				num = (short)1948385281;
				if (num != 0)
				{
				}
				num = (short)1437532160;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.Max;
			}
			set
			{
				short num = (short)263782400;
				short num2 = num;
				num = (short)931191358;
				short num3 = num;
				num = (short)251386430;
				switch (num3 == num)
				{
				}
				num = (short)543752193;
				if (num != 0)
				{
				}
				num = (short)2137063424;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.Max = value;
			}
		}

		// Token: 0x17004CA0 RID: 19616
		// (get) Token: 0x060098B5 RID: 39093 RVA: 0x008F54FC File Offset: 0x008F36FC
		// (set) Token: 0x060098B6 RID: 39094 RVA: 0x008F55B4 File Offset: 0x008F37B4
		internal int EmerWideImpactDetectionPreAlertTimer_A43381Step
		{
			get
			{
				short num = (short)1674182656;
				short num2 = num;
				num = (short)499022101;
				short num3 = num;
				num = (short)706836757;
				switch (num3 == num)
				{
				}
				num = (short)1740701697;
				if (num != 0)
				{
				}
				num = (short)510918656;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.StepSize;
			}
			set
			{
				short num = (short)859766784;
				short num2 = num;
				num = (short)950493113;
				short num3 = num;
				num = (short)492199865;
				switch (num3 == num)
				{
				}
				num = (short)1679294465;
				if (num != 0)
				{
				}
				num = (short)397672448;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.StepSize = value;
			}
		}

		// Token: 0x17004CA1 RID: 19617
		// (get) Token: 0x060098B7 RID: 39095 RVA: 0x008F566C File Offset: 0x008F386C
		// (set) Token: 0x060098B8 RID: 39096 RVA: 0x008F5720 File Offset: 0x008F3920
		public bool EmerWideImpactDetectionPreAlertTimer_A43381_Applicable
		{
			get
			{
				short num = (short)1453850624;
				short num2 = num;
				num = (short)244640818;
				short num3 = num;
				num = (short)850914354;
				switch (num3 == num)
				{
				}
				num = (short)523304960;
				if (num != 0)
				{
				}
				num = (short)904069121;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.Applicable;
			}
			set
			{
				short num = (short)18415616;
				short num2 = num;
				num = (short)1591254134;
				short num3 = num;
				num = (short)2021039222;
				switch (num3 == num)
				{
				}
				num = (short)915079169;
				if (num != 0)
				{
				}
				num = (short)863830016;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.Applicable = value;
			}
		}

		// Token: 0x17004CA2 RID: 19618
		// (get) Token: 0x060098B9 RID: 39097 RVA: 0x008F57D4 File Offset: 0x008F39D4
		// (set) Token: 0x060098BA RID: 39098 RVA: 0x008F5888 File Offset: 0x008F3A88
		public bool EmerWideImpactDetectionPreAlertTimer_A43381_Valid
		{
			get
			{
				short num = (short)1945501696;
				short num2 = num;
				num = (short)1376537528;
				short num3 = num;
				num = (short)1188055992;
				switch (num3 == num)
				{
				}
				num = (short)1193082880;
				if (num != 0)
				{
				}
				num = (short)315883521;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.Valid;
			}
			set
			{
				short num = (short)400818176;
				short num2 = num;
				num = (short)814239640;
				short num3 = num;
				num = (short)1556172696;
				switch (num3 == num)
				{
				}
				num = (short)1485111297;
				if (num != 0)
				{
				}
				num = (short)1733361664;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.Valid = value;
			}
		}

		// Token: 0x17004CA3 RID: 19619
		// (get) Token: 0x060098BB RID: 39099 RVA: 0x008F5940 File Offset: 0x008F3B40
		// (set) Token: 0x060098BC RID: 39100 RVA: 0x008F59F4 File Offset: 0x008F3BF4
		public bool EmerWideImpactDetectionPreAlertTimer_A43381_Visible
		{
			get
			{
				short num = (short)662634496;
				short num2 = num;
				num = (short)173184084;
				short num3 = num;
				num = (short)2062718036;
				switch (num3 == num)
				{
				}
				num = (short)484442112;
				if (num != 0)
				{
				}
				num = (short)1025703937;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.Visible;
			}
			set
			{
				short num = (short)2075983872;
				short num2 = num;
				num = (short)185407406;
				short num3 = num;
				num = (short)518002606;
				switch (num3 == num)
				{
				}
				num = (short)627834881;
				if (num != 0)
				{
				}
				num = (short)127008768;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.Visible = value;
			}
		}

		// Token: 0x17004CA4 RID: 19620
		// (get) Token: 0x060098BD RID: 39101 RVA: 0x008F5AA8 File Offset: 0x008F3CA8
		// (set) Token: 0x060098BE RID: 39102 RVA: 0x008F5B5C File Offset: 0x008F3D5C
		public bool EmerWideImpactDetectionPreAlertTimer_A43381_Editable
		{
			get
			{
				short num = (short)565182464;
				short num2 = num;
				num = (short)1568636963;
				short num3 = num;
				num = (short)159809571;
				switch (num3 == num)
				{
				}
				num = (short)2132541440;
				if (num != 0)
				{
				}
				num = (short)1438908417;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.Editable;
			}
			set
			{
				short num = (short)920190976;
				short num2 = num;
				num = (short)1037589288;
				short num3 = num;
				num = (short)1323391784;
				switch (num3 == num)
				{
				}
				num = (short)1677787137;
				if (num != 0)
				{
				}
				num = (short)83755008;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.Editable = value;
			}
		}

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x060098BF RID: 39103 RVA: 0x008F5C14 File Offset: 0x008F3E14
		internal string EmerWideImpactDetectionPreAlertTimer_A43381_UILabel
		{
			get
			{
				short num = (short)1276968960;
				short num2 = num;
				num = (short)695328219;
				short num3 = num;
				num = (short)485285339;
				switch (num3 == num)
				{
				}
				num = (short)1468006401;
				if (num != 0)
				{
				}
				num = (short)1641152512;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.UIName;
			}
		}

		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x060098C0 RID: 39104 RVA: 0x008F5CC8 File Offset: 0x008F3EC8
		// (set) Token: 0x060098C1 RID: 39105 RVA: 0x008F5D7C File Offset: 0x008F3F7C
		internal bool EmerWideImpactDetectionPreAlertTimer_A43381_HiddenStatic
		{
			get
			{
				short num = (short)34013184;
				short num2 = num;
				num = (short)102337227;
				short num3 = num;
				num = (short)882412235;
				switch (num3 == num)
				{
				}
				num = (short)1358233600;
				if (num != 0)
				{
				}
				num = (short)814088193;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.HiddenStatic;
			}
			set
			{
				short num = (short)866385920;
				short num2 = num;
				num = (short)156190307;
				short num3 = num;
				num = (short)1090930275;
				switch (num3 == num)
				{
				}
				num = (short)550699009;
				if (num != 0)
				{
				}
				num = (short)1603928064;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.HiddenStatic = value;
			}
		}

		// Token: 0x17004CA7 RID: 19623
		// (get) Token: 0x060098C2 RID: 39106 RVA: 0x008F5E30 File Offset: 0x008F4030
		// (set) Token: 0x060098C3 RID: 39107 RVA: 0x008F5EE4 File Offset: 0x008F40E4
		internal bool EmerWideImpactDetectionPreAlertTimer_A43381_HiddenDynamic
		{
			get
			{
				short num = (short)519307264;
				short num2 = num;
				num = (short)1716382384;
				short num3 = num;
				num = (short)1379658416;
				switch (num3 == num)
				{
				}
				num = (short)1592393729;
				if (num != 0)
				{
				}
				num = (short)1960706048;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381.HiddenDynamic;
			}
			set
			{
				short num = (short)1205796864;
				short num2 = num;
				num = (short)1355847755;
				short num3 = num;
				num = (short)952473675;
				switch (num3 == num)
				{
				}
				num = (short)886308865;
				if (num != 0)
				{
				}
				num = (short)564658176;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTimer_A43381.HiddenDynamic = value;
			}
		}

		// Token: 0x17004CA8 RID: 19624
		// (get) Token: 0x060098C4 RID: 39108 RVA: 0x008F5F98 File Offset: 0x008F4198
		public bool EmerWideImpactDetectionPreAlertTimer_A43381_HasDiffs
		{
			get
			{
				short num = (short)1428094976;
				short num2 = num;
				num = (short)1085264964;
				short num3 = num;
				num = (short)1782764612;
				switch (num3 == num)
				{
				}
				num = (short)1098645504;
				if (num != 0)
				{
				}
				num = (short)1442185217;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTimer_A43381._HasDiffs;
			}
		}

		// Token: 0x17004CA9 RID: 19625
		// (get) Token: 0x060098C5 RID: 39109 RVA: 0x008F6050 File Offset: 0x008F4250
		// (set) Token: 0x060098C6 RID: 39110 RVA: 0x008F6104 File Offset: 0x008F4304
		public int EmerWideImpactDetectionPostAlertTimer_A43382Value
		{
			get
			{
				short num = (short)1839267840;
				short num2 = num;
				num = (short)459693392;
				short num3 = num;
				num = (short)626744656;
				switch (num3 == num)
				{
				}
				num = (short)2082144257;
				if (num != 0)
				{
				}
				num = (short)280887296;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.Value;
			}
			set
			{
				short num = (short)443416576;
				short num2 = num;
				num = (short)43283348;
				short num3 = num;
				num = (short)1650422676;
				switch (num3 == num)
				{
				}
				num = (short)1972436993;
				if (num != 0)
				{
				}
				num = (short)1322450944;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.Value = value;
			}
		}

		// Token: 0x17004CAA RID: 19626
		// (get) Token: 0x060098C7 RID: 39111 RVA: 0x008F61BC File Offset: 0x008F43BC
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerWideImpactDetectionPostAlertTimer_A43382
		{
			get
			{
				short num = (short)239140864;
				short num2 = num;
				num = (short)1344775874;
				short num3 = num;
				num = (short)2117183170;
				switch (num3 == num)
				{
				}
				num = (short)1759444993;
				if (num != 0)
				{
				}
				num = (short)1507917824;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382;
			}
		}

		// Token: 0x17004CAB RID: 19627
		// (get) Token: 0x060098C8 RID: 39112 RVA: 0x008F626C File Offset: 0x008F446C
		// (set) Token: 0x060098C9 RID: 39113 RVA: 0x008F6320 File Offset: 0x008F4520
		public string EmerWideImpactDetectionPostAlertTimer_A43382_UIValue
		{
			get
			{
				short num = (short)1867120640;
				short num2 = num;
				num = (short)233110248;
				short num3 = num;
				num = (short)66386664;
				switch (num3 == num)
				{
				}
				num = (short)1943666688;
				if (num != 0)
				{
				}
				num = (short)366673921;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.UIValue;
			}
			set
			{
				short num = (short)1202716672;
				short num2 = num;
				num = (short)487622244;
				short num3 = num;
				num = (short)1058571876;
				switch (num3 == num)
				{
				}
				num = (short)1453916160;
				if (num != 0)
				{
				}
				num = (short)1030356993;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.UIValue = value;
			}
		}

		// Token: 0x17004CAC RID: 19628
		// (get) Token: 0x060098CA RID: 39114 RVA: 0x008F63D8 File Offset: 0x008F45D8
		// (set) Token: 0x060098CB RID: 39115 RVA: 0x008F6490 File Offset: 0x008F4690
		internal int EmerWideImpactDetectionPostAlertTimer_A43382Min
		{
			get
			{
				short num = (short)1242890240;
				short num2 = num;
				num = (short)1189271062;
				short num3 = num;
				num = (short)940234262;
				switch (num3 == num)
				{
				}
				num = (short)223739905;
				if (num != 0)
				{
				}
				num = (short)1776353280;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.Min;
			}
			set
			{
				short num = (short)952285387;
				short num2 = num;
				num = (short)80525515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601554944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173211649;
				if (num != 0)
				{
				}
				num = (short)341245952;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.Min = value;
			}
		}

		// Token: 0x17004CAD RID: 19629
		// (get) Token: 0x060098CC RID: 39116 RVA: 0x008F6544 File Offset: 0x008F4744
		// (set) Token: 0x060098CD RID: 39117 RVA: 0x008F65F8 File Offset: 0x008F47F8
		internal int EmerWideImpactDetectionPostAlertTimer_A43382Max
		{
			get
			{
				short num = (short)188798338;
				short num2 = num;
				num = (short)2069026178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)622854144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)419692545;
				if (num != 0)
				{
				}
				num = (short)61669376;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.Max;
			}
			set
			{
				short num = (short)251634361;
				short num2 = num;
				num = (short)1606722233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26673152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)479920129;
				if (num != 0)
				{
				}
				num = (short)1788346368;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.Max = value;
			}
		}

		// Token: 0x17004CAE RID: 19630
		// (get) Token: 0x060098CE RID: 39118 RVA: 0x008F66B0 File Offset: 0x008F48B0
		// (set) Token: 0x060098CF RID: 39119 RVA: 0x008F6764 File Offset: 0x008F4964
		internal int EmerWideImpactDetectionPostAlertTimer_A43382Step
		{
			get
			{
				short num = (short)1952833614;
				short num2 = num;
				num = (short)573497422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)311689216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1783431169;
				if (num != 0)
				{
				}
				num = (short)58130432;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.StepSize;
			}
			set
			{
				short num = (short)1516765185;
				if (num != 0)
				{
				}
				num = (short)426049536;
				short num2 = num;
				num = (short)696494493;
				short num3 = num;
				num = (short)1336584605;
				switch (num3 == num)
				{
				}
				num = (short)1167720448;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.StepSize = value;
			}
		}

		// Token: 0x17004CAF RID: 19631
		// (get) Token: 0x060098D0 RID: 39120 RVA: 0x008F6818 File Offset: 0x008F4A18
		// (set) Token: 0x060098D1 RID: 39121 RVA: 0x008F68CC File Offset: 0x008F4ACC
		public bool EmerWideImpactDetectionPostAlertTimer_A43382_Applicable
		{
			get
			{
				short num = (short)382470195;
				short num2 = num;
				num = (short)1726154803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)701956096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2071920640;
				if (num != 0)
				{
				}
				num = (short)1555890177;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.Applicable;
			}
			set
			{
				short num = (short)95426107;
				short num2 = num;
				num = (short)913970747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1983774720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203175425;
				if (num != 0)
				{
				}
				num = (short)1547436032;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.Applicable = value;
			}
		}

		// Token: 0x17004CB0 RID: 19632
		// (get) Token: 0x060098D2 RID: 39122 RVA: 0x008F6980 File Offset: 0x008F4B80
		// (set) Token: 0x060098D3 RID: 39123 RVA: 0x008F6A34 File Offset: 0x008F4C34
		public bool EmerWideImpactDetectionPostAlertTimer_A43382_Valid
		{
			get
			{
				short num = (short)523413185;
				short num2 = num;
				num = (short)1535485633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)687144960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1988427777;
				if (num != 0)
				{
				}
				num = (short)611123200;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.Valid;
			}
			set
			{
				short num = (short)811381114;
				short num2 = num;
				num = (short)717926778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1344667648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794375680;
				if (num != 0)
				{
				}
				num = (short)469303297;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.Valid = value;
			}
		}

		// Token: 0x17004CB1 RID: 19633
		// (get) Token: 0x060098D4 RID: 39124 RVA: 0x008F6AEC File Offset: 0x008F4CEC
		// (set) Token: 0x060098D5 RID: 39125 RVA: 0x008F6BA4 File Offset: 0x008F4DA4
		public bool EmerWideImpactDetectionPostAlertTimer_A43382_Visible
		{
			get
			{
				short num = (short)822250624;
				short num2 = num;
				num = (short)1794935936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)885194752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1818886144;
				if (num != 0)
				{
				}
				num = (short)995295233;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.Visible;
			}
			set
			{
				short num = (short)1510497797;
				short num2 = num;
				num = (short)317349381;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1335230464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1755709441;
				if (num != 0)
				{
				}
				num = (short)1983250432;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.Visible = value;
			}
		}

		// Token: 0x17004CB2 RID: 19634
		// (get) Token: 0x060098D6 RID: 39126 RVA: 0x008F6C5C File Offset: 0x008F4E5C
		// (set) Token: 0x060098D7 RID: 39127 RVA: 0x008F6D10 File Offset: 0x008F4F10
		public bool EmerWideImpactDetectionPostAlertTimer_A43382_Editable
		{
			get
			{
				short num = (short)1503230561;
				short num2 = num;
				num = (short)1586657889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1526464512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1910964225;
				if (num != 0)
				{
				}
				num = (short)1761083392;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.Editable;
			}
			set
			{
				short num = (short)418815867;
				short num2 = num;
				num = (short)1606786939;
				switch (num2 == num)
				{
				default:
				{
					num = (short)967835648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1598947328;
				if (num != 0)
				{
				}
				num = (short)750059521;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.Editable = value;
			}
		}

		// Token: 0x17004CB3 RID: 19635
		// (get) Token: 0x060098D8 RID: 39128 RVA: 0x008F6DC8 File Offset: 0x008F4FC8
		internal string EmerWideImpactDetectionPostAlertTimer_A43382_UILabel
		{
			get
			{
				short num = (short)1550501053;
				short num2 = num;
				num = (short)1509016765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)474611712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1724514305;
				if (num != 0)
				{
				}
				num = (short)885063680;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.UIName;
			}
		}

		// Token: 0x17004CB4 RID: 19636
		// (get) Token: 0x060098D9 RID: 39129 RVA: 0x008F6E7C File Offset: 0x008F507C
		// (set) Token: 0x060098DA RID: 39130 RVA: 0x008F6F34 File Offset: 0x008F5134
		internal bool EmerWideImpactDetectionPostAlertTimer_A43382_HiddenStatic
		{
			get
			{
				short num = (short)915985011;
				short num2 = num;
				num = (short)1466421875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667222016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)690946049;
				if (num != 0)
				{
				}
				num = (short)375717888;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.HiddenStatic;
			}
			set
			{
				short num = (short)641238793;
				short num2 = num;
				num = (short)1691715337;
				switch (num2 == num)
				{
				default:
				{
					num = (short)245235712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)558235649;
				if (num != 0)
				{
				}
				num = (short)898826240;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.HiddenStatic = value;
			}
		}

		// Token: 0x17004CB5 RID: 19637
		// (get) Token: 0x060098DB RID: 39131 RVA: 0x008F6FEC File Offset: 0x008F51EC
		// (set) Token: 0x060098DC RID: 39132 RVA: 0x008F70A0 File Offset: 0x008F52A0
		internal bool EmerWideImpactDetectionPostAlertTimer_A43382_HiddenDynamic
		{
			get
			{
				short num = (short)1171006305;
				short num2 = num;
				num = (short)500245345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320864256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2114912257;
				if (num != 0)
				{
				}
				num = (short)1750597632;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382.HiddenDynamic;
			}
			set
			{
				short num = (short)1531913550;
				short num2 = num;
				num = (short)841885006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)43909120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1594556416;
				if (num != 0)
				{
				}
				num = (short)902168577;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPostAlertTimer_A43382.HiddenDynamic = value;
			}
		}

		// Token: 0x17004CB6 RID: 19638
		// (get) Token: 0x060098DD RID: 39133 RVA: 0x008F7154 File Offset: 0x008F5354
		public bool EmerWideImpactDetectionPostAlertTimer_A43382_HasDiffs
		{
			get
			{
				short num = (short)1760297679;
				short num2 = num;
				num = (short)1155334863;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447021056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2125201409;
				if (num != 0)
				{
				}
				num = (short)927793152;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPostAlertTimer_A43382._HasDiffs;
			}
		}

		// Token: 0x17004CB7 RID: 19639
		// (get) Token: 0x060098DE RID: 39134 RVA: 0x008F7208 File Offset: 0x008F5408
		// (set) Token: 0x060098DF RID: 39135 RVA: 0x008F72BC File Offset: 0x008F54BC
		public int EmerWideImpactDetectionPreAlertTone_A43383Value
		{
			get
			{
				short num = (short)114164640;
				short num2 = num;
				num = (short)220988320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1281753088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)290914304;
				if (num != 0)
				{
				}
				num = (short)1423704065;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.Value;
			}
			set
			{
				short num = (short)640012773;
				short num2 = num;
				num = (short)445764069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)700710912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2102394880;
				if (num != 0)
				{
				}
				num = (short)142868481;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTone_A43383.Value = value;
			}
		}

		// Token: 0x17004CB8 RID: 19640
		// (get) Token: 0x060098E0 RID: 39136 RVA: 0x008F7374 File Offset: 0x008F5574
		// (set) Token: 0x060098E1 RID: 39137 RVA: 0x008F7428 File Offset: 0x008F5628
		public string EmerWideImpactDetectionPreAlertTone_A43383_UIValue
		{
			get
			{
				short num = (short)1261534045;
				short num2 = num;
				num = (short)1567521629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1526857728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)264699905;
				if (num != 0)
				{
				}
				num = (short)649920512;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.UIValue;
			}
			set
			{
				short num = (short)2057456902;
				short num2 = num;
				num = (short)1014844678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)987103232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1224605697;
				if (num != 0)
				{
				}
				num = (short)1132068864;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTone_A43383.UIValue = value;
			}
		}

		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x060098E2 RID: 39138 RVA: 0x008F74DC File Offset: 0x008F56DC
		public global::AcpBusinessLayer.AcpListField EmerWideImpactDetectionPreAlertTone_A43383
		{
			get
			{
				short num = (short)1214793566;
				short num2 = num;
				num = (short)856377182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)236519424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1606615041;
				if (num != 0)
				{
				}
				num = (short)1655308288;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383;
			}
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x060098E3 RID: 39139 RVA: 0x008F7588 File Offset: 0x008F5788
		// (set) Token: 0x060098E4 RID: 39140 RVA: 0x008F763C File Offset: 0x008F583C
		public bool EmerWideImpactDetectionPreAlertTone_A43383_Applicable
		{
			get
			{
				short num = (short)1467745555;
				short num2 = num;
				num = (short)1345651987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1650393088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)713424896;
				if (num != 0)
				{
				}
				num = (short)1465384961;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.Applicable;
			}
			set
			{
				short num = (short)1731985409;
				if (num != 0)
				{
				}
				num = (short)743178240;
				short num2 = num;
				num = (short)558329079;
				short num3 = num;
				num = (short)1602317559;
				switch (num3 == num)
				{
				}
				num = (short)950206464;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTone_A43383.Applicable = value;
			}
		}

		// Token: 0x17004CBB RID: 19643
		// (get) Token: 0x060098E5 RID: 39141 RVA: 0x008F76F0 File Offset: 0x008F58F0
		// (set) Token: 0x060098E6 RID: 39142 RVA: 0x008F77A4 File Offset: 0x008F59A4
		public bool EmerWideImpactDetectionPreAlertTone_A43383_Valid
		{
			get
			{
				short num = (short)227344386;
				short num2 = num;
				num = (short)1081802754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)301858816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)358350848;
				if (num != 0)
				{
				}
				num = (short)1611857921;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.Valid;
			}
			set
			{
				short num = (short)1380667764;
				short num2 = num;
				num = (short)1995723124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2138243072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1744240641;
				if (num != 0)
				{
				}
				num = (short)1588002816;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTone_A43383.Valid = value;
			}
		}

		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x060098E7 RID: 39143 RVA: 0x008F785C File Offset: 0x008F5A5C
		// (set) Token: 0x060098E8 RID: 39144 RVA: 0x008F7910 File Offset: 0x008F5B10
		public bool EmerWideImpactDetectionPreAlertTone_A43383_Visible
		{
			get
			{
				short num = (short)896950229;
				short num2 = num;
				num = (short)1773559765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2054225920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)891944960;
				if (num != 0)
				{
				}
				num = (short)1128857601;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.Visible;
			}
			set
			{
				short num = (short)725136217;
				short num2 = num;
				num = (short)32224089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)33488896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)462553088;
				if (num != 0)
				{
				}
				num = (short)1549598721;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTone_A43383.Visible = value;
			}
		}

		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x060098E9 RID: 39145 RVA: 0x008F79C4 File Offset: 0x008F5BC4
		// (set) Token: 0x060098EA RID: 39146 RVA: 0x008F7A78 File Offset: 0x008F5C78
		public bool EmerWideImpactDetectionPreAlertTone_A43383_Editable
		{
			get
			{
				short num = (short)1703834449;
				short num2 = num;
				num = (short)507933521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610678272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)157089793;
				if (num != 0)
				{
				}
				num = (short)1654718464;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.Editable;
			}
			set
			{
				short num = (short)1089382140;
				short num2 = num;
				num = (short)1864214268;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1989672960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1013121025;
				if (num != 0)
				{
				}
				num = (short)1923350528;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTone_A43383.Editable = value;
			}
		}

		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x060098EB RID: 39147 RVA: 0x008F7B2C File Offset: 0x008F5D2C
		internal string EmerWideImpactDetectionPreAlertTone_A43383_UILabel
		{
			get
			{
				short num = (short)857625562;
				short num2 = num;
				num = (short)938038234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298923520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1044840449;
				if (num != 0)
				{
				}
				num = (short)394788864;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.UIName;
			}
		}

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x060098EC RID: 39148 RVA: 0x008F7BE0 File Offset: 0x008F5DE0
		// (set) Token: 0x060098ED RID: 39149 RVA: 0x008F7C94 File Offset: 0x008F5E94
		internal bool EmerWideImpactDetectionPreAlertTone_A43383_HiddenStatic
		{
			get
			{
				short num = (short)177513214;
				short num2 = num;
				num = (short)975610622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722272256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1242431489;
				if (num != 0)
				{
				}
				num = (short)1025114112;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.HiddenStatic;
			}
			set
			{
				short num = (short)1379532801;
				if (num != 0)
				{
				}
				num = (short)2127691776;
				short num2 = num;
				num = (short)1424271086;
				short num3 = num;
				num = (short)1506387694;
				switch (num3 == num)
				{
				}
				num = (short)1764884480;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTone_A43383.HiddenStatic = value;
			}
		}

		// Token: 0x17004CC0 RID: 19648
		// (get) Token: 0x060098EE RID: 39150 RVA: 0x008F7D4C File Offset: 0x008F5F4C
		// (set) Token: 0x060098EF RID: 39151 RVA: 0x008F7E00 File Offset: 0x008F6000
		internal bool EmerWideImpactDetectionPreAlertTone_A43383_HiddenDynamic
		{
			get
			{
				short num = (short)86054576;
				short num2 = num;
				num = (short)1842812592;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1871380480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173867009;
				if (num != 0)
				{
				}
				num = (short)6094848;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383.HiddenDynamic;
			}
			set
			{
				short num = (short)518979585;
				if (num != 0)
				{
				}
				num = (short)46268416;
				short num2 = num;
				num = (short)895941052;
				short num3 = num;
				num = (short)1857812924;
				switch (num3 == num)
				{
				}
				num = (short)545456128;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionPreAlertTone_A43383.HiddenDynamic = value;
			}
		}

		// Token: 0x17004CC1 RID: 19649
		// (get) Token: 0x060098F0 RID: 39152 RVA: 0x008F7EB4 File Offset: 0x008F60B4
		public bool EmerWideImpactDetectionPreAlertTone_A43383_HasDiffs
		{
			get
			{
				short num = (short)448883561;
				short num2 = num;
				num = (short)777022313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1603665920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1657929729;
				if (num != 0)
				{
				}
				num = (short)1008074752;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionPreAlertTone_A43383._HasDiffs;
			}
		}

		// Token: 0x17004CC2 RID: 19650
		// (get) Token: 0x060098F1 RID: 39153 RVA: 0x008F7F68 File Offset: 0x008F6168
		// (set) Token: 0x060098F2 RID: 39154 RVA: 0x008F801C File Offset: 0x008F621C
		public int EmerWideImpactDetectionConfigLevel_A43384Value
		{
			get
			{
				short num = (short)574881793;
				if (num != 0)
				{
				}
				num = (short)1241055232;
				short num2 = num;
				num = (short)1478469115;
				short num3 = num;
				num = (short)1678550523;
				switch (num3 == num)
				{
				}
				num = (short)902037504;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionConfigLevel_A43384.Value;
			}
			set
			{
				short num = (short)993198081;
				if (num != 0)
				{
				}
				num = (short)102563840;
				short num2 = num;
				num = (short)944147489;
				short num3 = num;
				num = (short)1641384993;
				switch (num3 == num)
				{
				}
				num = (short)142606336;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionConfigLevel_A43384.Value = value;
			}
		}

		// Token: 0x17004CC3 RID: 19651
		// (get) Token: 0x060098F3 RID: 39155 RVA: 0x008F80D4 File Offset: 0x008F62D4
		// (set) Token: 0x060098F4 RID: 39156 RVA: 0x008F8188 File Offset: 0x008F6388
		public string EmerWideImpactDetectionConfigLevel_A43384_UIValue
		{
			get
			{
				short num = (short)1091961203;
				short num2 = num;
				num = (short)461242739;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207762944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1001717760;
				if (num != 0)
				{
				}
				num = (short)1948712961;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionConfigLevel_A43384.UIValue;
			}
			set
			{
				short num = (short)1414060386;
				short num2 = num;
				num = (short)1199954274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1485832192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1683423233;
				if (num != 0)
				{
				}
				num = (short)68878336;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionConfigLevel_A43384.UIValue = value;
			}
		}

		// Token: 0x17004CC4 RID: 19652
		// (get) Token: 0x060098F5 RID: 39157 RVA: 0x008F8240 File Offset: 0x008F6440
		public global::AcpBusinessLayer.AcpListField EmerWideImpactDetectionConfigLevel_A43384
		{
			get
			{
				short num = (short)1576577454;
				short num2 = num;
				num = (short)1970448814;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1671430144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)775487489;
				if (num != 0)
				{
				}
				num = (short)1113522176;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionConfigLevel_A43384;
			}
		}

		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x060098F6 RID: 39158 RVA: 0x008F82F0 File Offset: 0x008F64F0
		// (set) Token: 0x060098F7 RID: 39159 RVA: 0x008F83A0 File Offset: 0x008F65A0
		public bool EmerWideImpactDetectionConfigLevel_A43384_Applicable
		{
			get
			{
				short num = (short)1743737179;
				short num2 = num;
				num = (short)1443254619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1152581632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)47579137;
				if (num != 0)
				{
				}
				num = (short)1742274560;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionConfigLevel_A43384.Applicable;
			}
			set
			{
				short num = (short)2027236549;
				short num2 = num;
				num = (short)1825778885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1331822592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1656815617;
				if (num != 0)
				{
				}
				num = (short)226426880;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionConfigLevel_A43384.Applicable = value;
			}
		}

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x060098F8 RID: 39160 RVA: 0x008F8458 File Offset: 0x008F6658
		// (set) Token: 0x060098F9 RID: 39161 RVA: 0x008F8510 File Offset: 0x008F6710
		public bool EmerWideImpactDetectionConfigLevel_A43384_Valid
		{
			get
			{
				short num = (short)799722498;
				short num2 = num;
				num = (short)1611451394;
				switch (num2 == num)
				{
				default:
				{
					num = (short)832569344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1206779904;
				if (num != 0)
				{
				}
				num = (short)1810825217;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionConfigLevel_A43384.Valid;
			}
			set
			{
				short num = (short)1892830005;
				short num2 = num;
				num = (short)533875509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)871432192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2060976129;
				if (num != 0)
				{
				}
				num = (short)691535872;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionConfigLevel_A43384.Valid = value;
			}
		}

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x060098FA RID: 39162 RVA: 0x008F85C4 File Offset: 0x008F67C4
		// (set) Token: 0x060098FB RID: 39163 RVA: 0x008F8678 File Offset: 0x008F6878
		public bool EmerWideImpactDetectionConfigLevel_A43384_Visible
		{
			get
			{
				short num = (short)2129449870;
				short num2 = num;
				num = (short)1524028302;
				switch (num2 == num)
				{
				}
				num = (short)435617793;
				if (num != 0)
				{
				}
				num = (short)1441529856;
				if (num != 0)
				{
				}
				num = (short)1760952320;
				short num3 = num;
				return this.emerWideImpactDetectionConfigLevel_A43384.Visible;
			}
			set
			{
				short num = (short)447742416;
				short num2 = num;
				num = (short)279642576;
				switch (num2 == num)
				{
				}
				num = (short)1985609729;
				if (num != 0)
				{
				}
				num = (short)2088239104;
				if (num != 0)
				{
				}
				num = (short)1383923712;
				short num3 = num;
				this.emerWideImpactDetectionConfigLevel_A43384.Visible = value;
			}
		}

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x060098FC RID: 39164 RVA: 0x008F872C File Offset: 0x008F692C
		// (set) Token: 0x060098FD RID: 39165 RVA: 0x008F87DC File Offset: 0x008F69DC
		public bool EmerWideImpactDetectionConfigLevel_A43384_Editable
		{
			get
			{
				short num = (short)392232961;
				if (num != 0)
				{
				}
				num = (short)587978310;
				short num2 = num;
				num = (short)1555289670;
				switch (num2 == num)
				{
				}
				num = (short)908460032;
				if (num != 0)
				{
				}
				num = (short)1224474624;
				short num3 = num;
				return this.emerWideImpactDetectionConfigLevel_A43384.Editable;
			}
			set
			{
				short num = (short)898977843;
				short num2 = num;
				num = (short)1262112819;
				switch (num2 == num)
				{
				}
				num = (short)1047330817;
				if (num != 0)
				{
				}
				num = (short)335544320;
				if (num != 0)
				{
				}
				num = (short)715915264;
				short num3 = num;
				this.emerWideImpactDetectionConfigLevel_A43384.Editable = value;
			}
		}

		// Token: 0x17004CC9 RID: 19657
		// (get) Token: 0x060098FE RID: 39166 RVA: 0x008F8894 File Offset: 0x008F6A94
		internal string EmerWideImpactDetectionConfigLevel_A43384_UILabel
		{
			get
			{
				short num = (short)81822068;
				short num2 = num;
				num = (short)1437892980;
				switch (num2 == num)
				{
				}
				num = (short)766312448;
				if (num != 0)
				{
				}
				num = (short)1841430529;
				if (num != 0)
				{
				}
				num = (short)365232128;
				short num3 = num;
				return this.emerWideImpactDetectionConfigLevel_A43384.UIName;
			}
		}

		// Token: 0x17004CCA RID: 19658
		// (get) Token: 0x060098FF RID: 39167 RVA: 0x008F8948 File Offset: 0x008F6B48
		// (set) Token: 0x06009900 RID: 39168 RVA: 0x008F8A00 File Offset: 0x008F6C00
		internal bool EmerWideImpactDetectionConfigLevel_A43384_HiddenStatic
		{
			get
			{
				short num = (short)1593901057;
				if (num != 0)
				{
				}
				num = (short)1087830041;
				short num2 = num;
				num = (short)1386608665;
				switch (num2 == num)
				{
				}
				num = (short)1868759040;
				if (num != 0)
				{
				}
				num = (short)1927282688;
				short num3 = num;
				return this.emerWideImpactDetectionConfigLevel_A43384.HiddenStatic;
			}
			set
			{
				short num = (short)1059127297;
				if (num != 0)
				{
				}
				num = (short)371425987;
				short num2 = num;
				num = (short)665420483;
				switch (num2 == num)
				{
				}
				num = (short)138543104;
				if (num != 0)
				{
				}
				num = (short)1955004416;
				short num3 = num;
				this.emerWideImpactDetectionConfigLevel_A43384.HiddenStatic = value;
			}
		}

		// Token: 0x17004CCB RID: 19659
		// (get) Token: 0x06009901 RID: 39169 RVA: 0x008F8AB8 File Offset: 0x008F6CB8
		// (set) Token: 0x06009902 RID: 39170 RVA: 0x008F8B6C File Offset: 0x008F6D6C
		internal bool EmerWideImpactDetectionConfigLevel_A43384_HiddenDynamic
		{
			get
			{
				short num = (short)185730097;
				short num2 = num;
				num = (short)1951073329;
				switch (num2 == num)
				{
				}
				num = (short)391839745;
				if (num != 0)
				{
				}
				num = (short)472580096;
				if (num != 0)
				{
				}
				num = (short)1505558528;
				short num3 = num;
				return this.emerWideImpactDetectionConfigLevel_A43384.HiddenDynamic;
			}
			set
			{
				short num = (short)1174355309;
				short num2 = num;
				num = (short)293813613;
				switch (num2 == num)
				{
				}
				num = (short)341704704;
				if (num != 0)
				{
				}
				num = (short)1440022529;
				if (num != 0)
				{
				}
				num = (short)103088128;
				short num3 = num;
				this.emerWideImpactDetectionConfigLevel_A43384.HiddenDynamic = value;
			}
		}

		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x06009903 RID: 39171 RVA: 0x008F8C20 File Offset: 0x008F6E20
		public bool EmerWideImpactDetectionConfigLevel_A43384_HasDiffs
		{
			get
			{
				short num = (short)913344636;
				short num2 = num;
				num = (short)1534625916;
				switch (num2 == num)
				{
				}
				num = (short)1628504065;
				if (num != 0)
				{
				}
				num = (short)449839104;
				if (num != 0)
				{
				}
				num = (short)1980694528;
				short num3 = num;
				return this.emerWideImpactDetectionConfigLevel_A43384._HasDiffs;
			}
		}

		// Token: 0x17004CCD RID: 19661
		// (get) Token: 0x06009904 RID: 39172 RVA: 0x008F8CD4 File Offset: 0x008F6ED4
		// (set) Token: 0x06009905 RID: 39173 RVA: 0x008F8D84 File Offset: 0x008F6F84
		public bool EmerWideImpDectToneTrigger_A43386Value
		{
			get
			{
				short num = (short)1965644634;
				short num2 = num;
				num = (short)1549294426;
				switch (num2 == num)
				{
				}
				num = (short)557645824;
				if (num != 0)
				{
				}
				num = (short)546635777;
				if (num != 0)
				{
				}
				num = (short)2134769664;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.Value;
			}
			set
			{
				short num = (short)1271716666;
				short num2 = num;
				num = (short)643095354;
				switch (num2 == num)
				{
				}
				num = (short)772800513;
				if (num != 0)
				{
				}
				num = (short)1827209216;
				if (num != 0)
				{
				}
				num = (short)2072576000;
				short num3 = num;
				this.emerWideImpDectToneTrigger_A43386.Value = value;
			}
		}

		// Token: 0x17004CCE RID: 19662
		// (get) Token: 0x06009906 RID: 39174 RVA: 0x008F8E3C File Offset: 0x008F703C
		public global::AcpBusinessLayer.AcpField<bool> EmerWideImpDectToneTrigger_A43386
		{
			get
			{
				short num = (short)1062550693;
				short num2 = num;
				num = (short)128072869;
				switch (num2 == num)
				{
				}
				num = (short)1901330432;
				if (num != 0)
				{
				}
				num = (short)562102273;
				if (num != 0)
				{
				}
				num = (short)169279488;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386;
			}
		}

		// Token: 0x17004CCF RID: 19663
		// (get) Token: 0x06009907 RID: 39175 RVA: 0x008F8EEC File Offset: 0x008F70EC
		// (set) Token: 0x06009908 RID: 39176 RVA: 0x008F8FA0 File Offset: 0x008F71A0
		public bool EmerWideImpDectToneTrigger_A43386_UIValue
		{
			get
			{
				short num = (short)2036924417;
				if (num != 0)
				{
				}
				num = (short)419956785;
				short num2 = num;
				num = (short)1465387057;
				switch (num2 == num)
				{
				}
				num = (short)1100742656;
				if (num != 0)
				{
				}
				num = (short)1434451968;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.Value;
			}
			set
			{
				short num = (short)1316618241;
				if (num != 0)
				{
				}
				num = (short)1328858310;
				short num2 = num;
				num = (short)1382991046;
				switch (num2 == num)
				{
				}
				num = (short)1731854336;
				if (num != 0)
				{
				}
				num = (short)336920576;
				short num3 = num;
				this.emerWideImpDectToneTrigger_A43386.Value = value;
			}
		}

		// Token: 0x17004CD0 RID: 19664
		// (get) Token: 0x06009909 RID: 39177 RVA: 0x008F9058 File Offset: 0x008F7258
		// (set) Token: 0x0600990A RID: 39178 RVA: 0x008F910C File Offset: 0x008F730C
		public bool EmerWideImpDectToneTrigger_A43386_Applicable
		{
			get
			{
				short num = (short)1790265068;
				short num2 = num;
				num = (short)444876524;
				switch (num2 == num)
				{
				}
				num = (short)1858338817;
				if (num != 0)
				{
				}
				num = (short)428867584;
				if (num != 0)
				{
				}
				num = (short)1146814464;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.Applicable;
			}
			set
			{
				short num = (short)383057921;
				if (num != 0)
				{
				}
				num = (short)194772513;
				short num2 = num;
				num = (short)911605281;
				switch (num2 == num)
				{
				}
				num = (short)963641344;
				if (num != 0)
				{
				}
				num = (short)377618432;
				short num3 = num;
				this.emerWideImpDectToneTrigger_A43386.Applicable = value;
			}
		}

		// Token: 0x17004CD1 RID: 19665
		// (get) Token: 0x0600990B RID: 39179 RVA: 0x008F91C0 File Offset: 0x008F73C0
		// (set) Token: 0x0600990C RID: 39180 RVA: 0x008F9274 File Offset: 0x008F7474
		public bool EmerWideImpDectToneTrigger_A43386_Valid
		{
			get
			{
				short num = (short)2037520686;
				short num2 = num;
				num = (short)774707502;
				switch (num2 == num)
				{
				}
				num = (short)312344577;
				if (num != 0)
				{
				}
				num = (short)1227751424;
				if (num != 0)
				{
				}
				num = (short)1361969152;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.Valid;
			}
			set
			{
				short num = (short)972797705;
				short num2 = num;
				num = (short)997570313;
				switch (num2 == num)
				{
				}
				num = (short)1383792640;
				if (num != 0)
				{
				}
				num = (short)1635581953;
				if (num != 0)
				{
				}
				num = (short)772669440;
				short num3 = num;
				this.emerWideImpDectToneTrigger_A43386.Valid = value;
			}
		}

		// Token: 0x17004CD2 RID: 19666
		// (get) Token: 0x0600990D RID: 39181 RVA: 0x008F9328 File Offset: 0x008F7528
		// (set) Token: 0x0600990E RID: 39182 RVA: 0x008F93DC File Offset: 0x008F75DC
		public bool EmerWideImpDectToneTrigger_A43386_Visible
		{
			get
			{
				short num = (short)192816775;
				short num2 = num;
				num = (short)210708103;
				switch (num2 == num)
				{
				}
				num = (short)434503681;
				if (num != 0)
				{
				}
				num = (short)1121517568;
				if (num != 0)
				{
				}
				num = (short)1976041472;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.Visible;
			}
			set
			{
				short num = (short)687209597;
				short num2 = num;
				num = (short)1058208893;
				switch (num2 == num)
				{
				}
				num = (short)881459201;
				if (num != 0)
				{
				}
				num = (short)1795620864;
				if (num != 0)
				{
				}
				num = (short)1349844992;
				short num3 = num;
				this.emerWideImpDectToneTrigger_A43386.Visible = value;
			}
		}

		// Token: 0x17004CD3 RID: 19667
		// (get) Token: 0x0600990F RID: 39183 RVA: 0x008F9494 File Offset: 0x008F7694
		// (set) Token: 0x06009910 RID: 39184 RVA: 0x008F9548 File Offset: 0x008F7748
		public bool EmerWideImpDectToneTrigger_A43386_Editable
		{
			get
			{
				short num = (short)1943084495;
				short num2 = num;
				num = (short)490675663;
				switch (num2 == num)
				{
				}
				num = (short)958464001;
				if (num != 0)
				{
				}
				num = (short)1700265984;
				if (num != 0)
				{
				}
				num = (short)35717120;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.Editable;
			}
			set
			{
				short num = (short)1272101827;
				short num2 = num;
				num = (short)1557052355;
				switch (num2 == num)
				{
				}
				num = (short)1895563265;
				if (num != 0)
				{
				}
				num = (short)1857552384;
				if (num != 0)
				{
				}
				num = (short)1970929664;
				short num3 = num;
				this.emerWideImpDectToneTrigger_A43386.Editable = value;
			}
		}

		// Token: 0x17004CD4 RID: 19668
		// (get) Token: 0x06009911 RID: 39185 RVA: 0x008F9604 File Offset: 0x008F7804
		internal string EmerWideImpDectToneTrigger_A43386_UILabel
		{
			get
			{
				short num = (short)1179094348;
				short num2 = num;
				num = (short)1058770252;
				switch (num2 == num)
				{
				}
				num = (short)1514143745;
				if (num != 0)
				{
				}
				num = (short)1079377920;
				if (num != 0)
				{
				}
				num = (short)1800470528;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.UIName;
			}
		}

		// Token: 0x17004CD5 RID: 19669
		// (get) Token: 0x06009912 RID: 39186 RVA: 0x008F96BC File Offset: 0x008F78BC
		// (set) Token: 0x06009913 RID: 39187 RVA: 0x008F9770 File Offset: 0x008F7970
		internal bool EmerWideImpDectToneTrigger_A43386_HiddenStatic
		{
			get
			{
				short num = (short)1736488951;
				short num2 = num;
				num = (short)461551607;
				switch (num2 == num)
				{
				}
				num = (short)1324482560;
				if (num != 0)
				{
				}
				num = (short)306315265;
				if (num != 0)
				{
				}
				num = (short)1766916096;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.HiddenStatic;
			}
			set
			{
				short num = (short)1865252691;
				short num2 = num;
				num = (short)998211411;
				switch (num2 == num)
				{
				}
				num = (short)277610497;
				if (num != 0)
				{
				}
				num = (short)1287258112;
				if (num != 0)
				{
				}
				num = (short)984875008;
				short num3 = num;
				this.emerWideImpDectToneTrigger_A43386.HiddenStatic = value;
			}
		}

		// Token: 0x17004CD6 RID: 19670
		// (get) Token: 0x06009914 RID: 39188 RVA: 0x008F9828 File Offset: 0x008F7A28
		// (set) Token: 0x06009915 RID: 39189 RVA: 0x008F98DC File Offset: 0x008F7ADC
		internal bool EmerWideImpDectToneTrigger_A43386_HiddenDynamic
		{
			get
			{
				short num = (short)1104967342;
				short num2 = num;
				num = (short)1322612398;
				switch (num2 == num)
				{
				}
				num = (short)818151425;
				if (num != 0)
				{
				}
				num = (short)167903232;
				if (num != 0)
				{
				}
				num = (short)1046347776;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386.HiddenDynamic;
			}
			set
			{
				short num = (short)1785463341;
				short num2 = num;
				num = (short)448332333;
				switch (num2 == num)
				{
				}
				num = (short)139198464;
				if (num != 0)
				{
				}
				num = (short)2024275969;
				if (num != 0)
				{
				}
				num = (short)22675456;
				short num3 = num;
				this.emerWideImpDectToneTrigger_A43386.HiddenDynamic = value;
			}
		}

		// Token: 0x17004CD7 RID: 19671
		// (get) Token: 0x06009916 RID: 39190 RVA: 0x008F9990 File Offset: 0x008F7B90
		public bool EmerWideImpDectToneTrigger_A43386_HasDiffs
		{
			get
			{
				short num = (short)877983875;
				short num2 = num;
				num = (short)1686173827;
				switch (num2 == num)
				{
				}
				num = (short)630849537;
				if (num != 0)
				{
				}
				num = (short)1396506624;
				if (num != 0)
				{
				}
				num = (short)199163904;
				short num3 = num;
				return this.emerWideImpDectToneTrigger_A43386._HasDiffs;
			}
		}

		// Token: 0x17004CD8 RID: 19672
		// (get) Token: 0x06009917 RID: 39191 RVA: 0x008F9A44 File Offset: 0x008F7C44
		// (set) Token: 0x06009918 RID: 39192 RVA: 0x008F9AF8 File Offset: 0x008F7CF8
		public int EmerWideImpactDetectionEventDuration_A43427Value
		{
			get
			{
				short num = (short)1779290543;
				short num2 = num;
				num = (short)875024815;
				switch (num2 == num)
				{
				}
				num = (short)1919746049;
				if (num != 0)
				{
				}
				num = (short)898367488;
				if (num != 0)
				{
				}
				num = (short)1646788608;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.Value;
			}
			set
			{
				short num = (short)91552682;
				short num2 = num;
				num = (short)1004862378;
				switch (num2 == num)
				{
				}
				num = (short)1965359104;
				if (num != 0)
				{
				}
				num = (short)1546846209;
				if (num != 0)
				{
				}
				num = (short)699793408;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.Value = value;
			}
		}

		// Token: 0x17004CD9 RID: 19673
		// (get) Token: 0x06009919 RID: 39193 RVA: 0x008F9BB0 File Offset: 0x008F7DB0
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerWideImpactDetectionEventDuration_A43427
		{
			get
			{
				short num = (short)1409417217;
				if (num != 0)
				{
				}
				num = (short)498932376;
				short num2 = num;
				num = (short)188684952;
				switch (num2 == num)
				{
				}
				num = (short)98631680;
				if (num != 0)
				{
				}
				num = (short)1784217600;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427;
			}
		}

		// Token: 0x17004CDA RID: 19674
		// (get) Token: 0x0600991A RID: 39194 RVA: 0x008F9C60 File Offset: 0x008F7E60
		// (set) Token: 0x0600991B RID: 39195 RVA: 0x008F9D18 File Offset: 0x008F7F18
		public string EmerWideImpactDetectionEventDuration_A43427_UIValue
		{
			get
			{
				short num = (short)110690305;
				if (num != 0)
				{
				}
				num = (short)1025587473;
				short num2 = num;
				num = (short)1659975953;
				switch (num2 == num)
				{
				}
				num = (short)1929576448;
				if (num != 0)
				{
				}
				num = (short)1174405120;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.UIValue;
			}
			set
			{
				short num = (short)225976770;
				short num2 = num;
				num = (short)1098129858;
				switch (num2 == num)
				{
				}
				num = (short)743833600;
				if (num != 0)
				{
				}
				num = (short)1736572929;
				if (num != 0)
				{
				}
				num = (short)1192558592;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.UIValue = value;
			}
		}

		// Token: 0x17004CDB RID: 19675
		// (get) Token: 0x0600991C RID: 39196 RVA: 0x008F9DD0 File Offset: 0x008F7FD0
		// (set) Token: 0x0600991D RID: 39197 RVA: 0x008F9E84 File Offset: 0x008F8084
		internal int EmerWideImpactDetectionEventDuration_A43427Min
		{
			get
			{
				short num = (short)719006836;
				short num2 = num;
				num = (short)98315380;
				switch (num2 == num)
				{
				}
				num = (short)334954497;
				if (num != 0)
				{
				}
				num = (short)1114112000;
				if (num != 0)
				{
				}
				num = (short)1713963008;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.Min;
			}
			set
			{
				short num = (short)532893603;
				short num2 = num;
				num = (short)2082033571;
				switch (num2 == num)
				{
				}
				num = (short)1830486017;
				if (num != 0)
				{
				}
				num = (short)954204160;
				if (num != 0)
				{
				}
				num = (short)855834624;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.Min = value;
			}
		}

		// Token: 0x17004CDC RID: 19676
		// (get) Token: 0x0600991E RID: 39198 RVA: 0x008F9F38 File Offset: 0x008F8138
		// (set) Token: 0x0600991F RID: 39199 RVA: 0x008F9FEC File Offset: 0x008F81EC
		internal int EmerWideImpactDetectionEventDuration_A43427Max
		{
			get
			{
				short num = (short)690391438;
				short num2 = num;
				num = (short)1785432462;
				switch (num2 == num)
				{
				}
				num = (short)851771392;
				if (num != 0)
				{
				}
				num = (short)712900609;
				if (num != 0)
				{
				}
				num = (short)563412992;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.Max;
			}
			set
			{
				short num = (short)367682341;
				short num2 = num;
				num = (short)2066637605;
				switch (num2 == num)
				{
				}
				num = (short)1771372545;
				if (num != 0)
				{
				}
				num = (short)744488960;
				if (num != 0)
				{
				}
				num = (short)1420034048;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.Max = value;
			}
		}

		// Token: 0x17004CDD RID: 19677
		// (get) Token: 0x06009920 RID: 39200 RVA: 0x008FA0A0 File Offset: 0x008F82A0
		// (set) Token: 0x06009921 RID: 39201 RVA: 0x008FA154 File Offset: 0x008F8354
		internal int EmerWideImpactDetectionEventDuration_A43427Step
		{
			get
			{
				short num = (short)1139798492;
				short num2 = num;
				num = (short)66843100;
				switch (num2 == num)
				{
				}
				num = (short)59113473;
				if (num != 0)
				{
				}
				num = (short)1424228352;
				if (num != 0)
				{
				}
				num = (short)533856256;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.StepSize;
			}
			set
			{
				short num = (short)1662758627;
				short num2 = num;
				num = (short)1712041699;
				switch (num2 == num)
				{
				}
				num = (short)1257766913;
				if (num != 0)
				{
				}
				num = (short)1807941632;
				if (num != 0)
				{
				}
				num = (short)371720192;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.StepSize = value;
			}
		}

		// Token: 0x17004CDE RID: 19678
		// (get) Token: 0x06009922 RID: 39202 RVA: 0x008FA20C File Offset: 0x008F840C
		// (set) Token: 0x06009923 RID: 39203 RVA: 0x008FA2C0 File Offset: 0x008F84C0
		public bool EmerWideImpactDetectionEventDuration_A43427_Applicable
		{
			get
			{
				short num = (short)1358811414;
				short num2 = num;
				num = (short)815124758;
				switch (num2 == num)
				{
				}
				num = (short)409403393;
				if (num != 0)
				{
				}
				num = (short)1381892096;
				if (num != 0)
				{
				}
				num = (short)155254784;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.Applicable;
			}
			set
			{
				short num = (short)2111151821;
				short num2 = num;
				num = (short)172203725;
				switch (num2 == num)
				{
				}
				num = (short)1391591424;
				if (num != 0)
				{
				}
				num = (short)2037972993;
				if (num != 0)
				{
				}
				num = (short)249561088;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.Applicable = value;
			}
		}

		// Token: 0x17004CDF RID: 19679
		// (get) Token: 0x06009924 RID: 39204 RVA: 0x008FA374 File Offset: 0x008F8574
		// (set) Token: 0x06009925 RID: 39205 RVA: 0x008FA42C File Offset: 0x008F862C
		public bool EmerWideImpactDetectionEventDuration_A43427_Valid
		{
			get
			{
				short num = (short)2110482817;
				short num2 = num;
				num = (short)1070033281;
				switch (num2 == num)
				{
				}
				num = (short)1713438721;
				if (num != 0)
				{
				}
				num = (short)1777598464;
				if (num != 0)
				{
				}
				num = (short)563806208;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.Valid;
			}
			set
			{
				short num = (short)1600847873;
				if (num != 0)
				{
				}
				num = (short)1515163188;
				short num2 = num;
				num = (short)1203015220;
				switch (num2 == num)
				{
				}
				num = (short)1814429696;
				if (num != 0)
				{
				}
				num = (short)1314193408;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.Valid = value;
			}
		}

		// Token: 0x17004CE0 RID: 19680
		// (get) Token: 0x06009926 RID: 39206 RVA: 0x008FA4E4 File Offset: 0x008F86E4
		// (set) Token: 0x06009927 RID: 39207 RVA: 0x008FA598 File Offset: 0x008F8798
		public bool EmerWideImpactDetectionEventDuration_A43427_Visible
		{
			get
			{
				short num = (short)257203810;
				short num2 = num;
				num = (short)1280220770;
				switch (num2 == num)
				{
				}
				num = (short)215351297;
				if (num != 0)
				{
				}
				num = (short)1695481856;
				if (num != 0)
				{
				}
				num = (short)240648192;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.Visible;
			}
			set
			{
				short num = (short)525111343;
				short num2 = num;
				num = (short)2001113135;
				switch (num2 == num)
				{
				}
				num = (short)1376452608;
				if (num != 0)
				{
				}
				num = (short)1378549761;
				if (num != 0)
				{
				}
				num = (short)502661120;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.Visible = value;
			}
		}

		// Token: 0x17004CE1 RID: 19681
		// (get) Token: 0x06009928 RID: 39208 RVA: 0x008FA650 File Offset: 0x008F8850
		// (set) Token: 0x06009929 RID: 39209 RVA: 0x008FA704 File Offset: 0x008F8904
		public bool EmerWideImpactDetectionEventDuration_A43427_Editable
		{
			get
			{
				short num = (short)491284821;
				short num2 = num;
				num = (short)826632533;
				switch (num2 == num)
				{
				}
				num = (short)1194131457;
				if (num != 0)
				{
				}
				num = (short)2107965440;
				if (num != 0)
				{
				}
				num = (short)1534459904;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.Editable;
			}
			set
			{
				short num = (short)1588429808;
				short num2 = num;
				num = (short)1668842480;
				switch (num2 == num)
				{
				}
				num = (short)40304640;
				if (num != 0)
				{
				}
				num = (short)1020395521;
				if (num != 0)
				{
				}
				num = (short)1484652544;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.Editable = value;
			}
		}

		// Token: 0x17004CE2 RID: 19682
		// (get) Token: 0x0600992A RID: 39210 RVA: 0x008FA7BC File Offset: 0x008F89BC
		internal string EmerWideImpactDetectionEventDuration_A43427_UILabel
		{
			get
			{
				short num = (short)1074937005;
				short num2 = num;
				num = (short)1899707565;
				switch (num2 == num)
				{
				}
				num = (short)1443758080;
				if (num != 0)
				{
				}
				num = (short)786433;
				if (num != 0)
				{
				}
				num = (short)796590080;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.UIName;
			}
		}

		// Token: 0x17004CE3 RID: 19683
		// (get) Token: 0x0600992B RID: 39211 RVA: 0x008FA870 File Offset: 0x008F8A70
		// (set) Token: 0x0600992C RID: 39212 RVA: 0x008FA924 File Offset: 0x008F8B24
		internal bool EmerWideImpactDetectionEventDuration_A43427_HiddenStatic
		{
			get
			{
				short num = (short)228299381;
				short num2 = num;
				num = (short)1034916469;
				switch (num2 == num)
				{
				}
				num = (short)877133825;
				if (num != 0)
				{
				}
				num = (short)1917845504;
				if (num != 0)
				{
				}
				num = (short)644612096;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.HiddenStatic;
			}
			set
			{
				short num = (short)1531816845;
				short num2 = num;
				num = (short)379562893;
				switch (num2 == num)
				{
				}
				num = (short)533659649;
				if (num != 0)
				{
				}
				num = (short)1741881344;
				if (num != 0)
				{
				}
				num = (short)1418788864;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.HiddenStatic = value;
			}
		}

		// Token: 0x17004CE4 RID: 19684
		// (get) Token: 0x0600992D RID: 39213 RVA: 0x008FA9D8 File Offset: 0x008F8BD8
		// (set) Token: 0x0600992E RID: 39214 RVA: 0x008FAA90 File Offset: 0x008F8C90
		internal bool EmerWideImpactDetectionEventDuration_A43427_HiddenDynamic
		{
			get
			{
				short num = (short)74121217;
				if (num != 0)
				{
				}
				num = (short)890845228;
				short num2 = num;
				num = (short)1131755564;
				switch (num2 == num)
				{
				}
				num = (short)840892416;
				if (num != 0)
				{
				}
				num = (short)2129461248;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427.HiddenDynamic;
			}
			set
			{
				short num = (short)1527870908;
				short num2 = num;
				num = (short)585856444;
				switch (num2 == num)
				{
				}
				num = (short)250871808;
				if (num != 0)
				{
				}
				num = (short)14417921;
				if (num != 0)
				{
				}
				num = (short)654311424;
				short num3 = num;
				this.emerWideImpactDetectionEventDuration_A43427.HiddenDynamic = value;
			}
		}

		// Token: 0x17004CE5 RID: 19685
		// (get) Token: 0x0600992F RID: 39215 RVA: 0x008FAB48 File Offset: 0x008F8D48
		public bool EmerWideImpactDetectionEventDuration_A43427_HasDiffs
		{
			get
			{
				short num = (short)1151182203;
				short num2 = num;
				num = (short)1689036155;
				switch (num2 == num)
				{
				}
				num = (short)897974273;
				if (num != 0)
				{
				}
				num = (short)911409152;
				if (num != 0)
				{
				}
				num = (short)72810496;
				short num3 = num;
				return this.emerWideImpactDetectionEventDuration_A43427._HasDiffs;
			}
		}

		// Token: 0x17004CE6 RID: 19686
		// (get) Token: 0x06009930 RID: 39216 RVA: 0x008FAC00 File Offset: 0x008F8E00
		// (set) Token: 0x06009931 RID: 39217 RVA: 0x008FACB4 File Offset: 0x008F8EB4
		public int EmerWideImpactDetectionEventForce_A43428Value
		{
			get
			{
				short num = (short)210128567;
				short num2 = num;
				num = (short)1608666807;
				switch (num2 == num)
				{
				}
				num = (short)1096024065;
				if (num != 0)
				{
				}
				num = (short)436011008;
				if (num != 0)
				{
				}
				num = (short)253165568;
				short num3 = num;
				return this.emerWideImpactDetectionEventForce_A43428.Value;
			}
			set
			{
				short num = (short)66958783;
				short num2 = num;
				num = (short)126727615;
				switch (num2 == num)
				{
				}
				num = (short)2143092737;
				if (num != 0)
				{
				}
				num = (short)276955136;
				if (num != 0)
				{
				}
				num = (short)604766208;
				short num3 = num;
				this.emerWideImpactDetectionEventForce_A43428.Value = value;
			}
		}

		// Token: 0x17004CE7 RID: 19687
		// (get) Token: 0x06009932 RID: 39218 RVA: 0x008FAD6C File Offset: 0x008F8F6C
		public global::AcpBusinessLayer.AcpSimpleRangeField EmerWideImpactDetectionEventForce_A43428
		{
			get
			{
				short num = (short)320816653;
				short num2 = num;
				num = (short)451888653;
				switch (num2 == num)
				{
				}
				num = (short)1885143041;
				if (num != 0)
				{
				}
				num = (short)1987313664;
				if (num != 0)
				{
				}
				num = (short)523370496;
				short num3 = num;
				return this.emerWideImpactDetectionEventForce_A43428;
			}
		}

		// Token: 0x17004CE8 RID: 19688
		// (get) Token: 0x06009933 RID: 39219 RVA: 0x008FAE1C File Offset: 0x008F901C
		// (set) Token: 0x06009934 RID: 39220 RVA: 0x008FAED4 File Offset: 0x008F90D4
		public string EmerWideImpactDetectionEventForce_A43428_UIValue
		{
			get
			{
				short num = (short)1519798521;
				short num2 = num;
				num = (short)479676665;
				switch (num2 == num)
				{
				}
				num = (short)332070913;
				if (num != 0)
				{
				}
				num = (short)1639514112;
				short num3 = num;
				num = (short)1173225472;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.UIValue;
			}
			set
			{
				short num = (short)1024694332;
				short num2 = num;
				num = (short)2112919612;
				switch (num2 == num)
				{
				}
				num = (short)1097203713;
				if (num != 0)
				{
				}
				num = (short)1920794624;
				short num3 = num;
				num = (short)531169280;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.UIValue = value;
			}
		}

		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x06009935 RID: 39221 RVA: 0x008FAF88 File Offset: 0x008F9188
		// (set) Token: 0x06009936 RID: 39222 RVA: 0x008FB03C File Offset: 0x008F923C
		internal int EmerWideImpactDetectionEventForce_A43428Min
		{
			get
			{
				short num = (short)450887681;
				if (num != 0)
				{
				}
				num = (short)1836581408;
				short num2 = num;
				num = (short)1401553440;
				switch (num2 == num)
				{
				}
				num = (short)866123776;
				short num3 = num;
				num = (short)32309248;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.Min;
			}
			set
			{
				short num = (short)1461354859;
				short num2 = num;
				num = (short)1811513707;
				switch (num2 == num)
				{
				}
				num = (short)217579521;
				if (num != 0)
				{
				}
				num = (short)1987051520;
				short num3 = num;
				num = (short)643235840;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.Min = value;
			}
		}

		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x06009937 RID: 39223 RVA: 0x008FB0F0 File Offset: 0x008F92F0
		// (set) Token: 0x06009938 RID: 39224 RVA: 0x008FB1A4 File Offset: 0x008F93A4
		internal int EmerWideImpactDetectionEventForce_A43428Max
		{
			get
			{
				short num = (short)380076181;
				short num2 = num;
				num = (short)253395093;
				switch (num2 == num)
				{
				}
				num = (short)256638977;
				if (num != 0)
				{
				}
				num = (short)212205568;
				short num3 = num;
				num = (short)1046806528;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.Max;
			}
			set
			{
				short num = (short)2016411649;
				if (num != 0)
				{
				}
				num = (short)330501037;
				short num2 = num;
				num = (short)1927941037;
				switch (num2 == num)
				{
				}
				num = (short)1708326912;
				short num3 = num;
				num = (short)577503232;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.Max = value;
			}
		}

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x06009939 RID: 39225 RVA: 0x008FB25C File Offset: 0x008F945C
		// (set) Token: 0x0600993A RID: 39226 RVA: 0x008FB314 File Offset: 0x008F9514
		internal int EmerWideImpactDetectionEventForce_A43428Step
		{
			get
			{
				short num = (short)2010278846;
				short num2 = num;
				num = (short)1685744574;
				switch (num2 == num)
				{
				}
				num = (short)330235905;
				if (num != 0)
				{
				}
				num = (short)214106112;
				short num3 = num;
				num = (short)862781440;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.StepSize;
			}
			set
			{
				short num = (short)646352081;
				short num2 = num;
				num = (short)596937937;
				switch (num2 == num)
				{
				}
				num = (short)1186398209;
				if (num != 0)
				{
				}
				num = (short)1634598912;
				short num3 = num;
				num = (short)547160064;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.StepSize = value;
			}
		}

		// Token: 0x17004CEC RID: 19692
		// (get) Token: 0x0600993B RID: 39227 RVA: 0x008FB3C8 File Offset: 0x008F95C8
		// (set) Token: 0x0600993C RID: 39228 RVA: 0x008FB47C File Offset: 0x008F967C
		public bool EmerWideImpactDetectionEventForce_A43428_Applicable
		{
			get
			{
				short num = (short)464273601;
				short num2 = num;
				num = (short)1455571137;
				switch (num2 == num)
				{
				}
				num = (short)579665920;
				if (num != 0)
				{
				}
				num = (short)2111832064;
				short num3 = num;
				num = (short)1472528385;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.Applicable;
			}
			set
			{
				short num = (short)158900777;
				short num2 = num;
				num = (short)1860411945;
				switch (num2 == num)
				{
				}
				num = (short)762642433;
				if (num != 0)
				{
				}
				num = (short)491651072;
				short num3 = num;
				num = (short)255000576;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.Applicable = value;
			}
		}

		// Token: 0x17004CED RID: 19693
		// (get) Token: 0x0600993D RID: 39229 RVA: 0x008FB530 File Offset: 0x008F9730
		// (set) Token: 0x0600993E RID: 39230 RVA: 0x008FB5E4 File Offset: 0x008F97E4
		public bool EmerWideImpactDetectionEventForce_A43428_Valid
		{
			get
			{
				short num = (short)117185251;
				short num2 = num;
				num = (short)1019419363;
				switch (num2 == num)
				{
				}
				num = (short)2004025345;
				if (num != 0)
				{
				}
				num = (short)1738342400;
				short num3 = num;
				num = (short)433979392;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.Valid;
			}
			set
			{
				short num = (short)803527612;
				short num2 = num;
				num = (short)1666898876;
				switch (num2 == num)
				{
				}
				num = (short)1662976000;
				if (num != 0)
				{
				}
				num = (short)2055405568;
				short num3 = num;
				num = (short)93978625;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.Valid = value;
			}
		}

		// Token: 0x17004CEE RID: 19694
		// (get) Token: 0x0600993F RID: 39231 RVA: 0x008FB69C File Offset: 0x008F989C
		// (set) Token: 0x06009940 RID: 39232 RVA: 0x008FB750 File Offset: 0x008F9950
		public bool EmerWideImpactDetectionEventForce_A43428_Visible
		{
			get
			{
				short num = (short)54031650;
				short num2 = num;
				num = (short)760640802;
				switch (num2 == num)
				{
				}
				num = (short)1960312832;
				if (num != 0)
				{
				}
				num = (short)248381440;
				short num3 = num;
				num = (short)865468417;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.Visible;
			}
			set
			{
				short num = (short)629587293;
				short num2 = num;
				num = (short)1352973661;
				switch (num2 == num)
				{
				}
				num = (short)1384316929;
				if (num != 0)
				{
				}
				num = (short)1510801408;
				short num3 = num;
				num = (short)345702400;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.Visible = value;
			}
		}

		// Token: 0x17004CEF RID: 19695
		// (get) Token: 0x06009941 RID: 39233 RVA: 0x008FB804 File Offset: 0x008F9A04
		// (set) Token: 0x06009942 RID: 39234 RVA: 0x008FB8BC File Offset: 0x008F9ABC
		public bool EmerWideImpactDetectionEventForce_A43428_Editable
		{
			get
			{
				short num = (short)466852603;
				short num2 = num;
				num = (short)1021942523;
				switch (num2 == num)
				{
				}
				num = (short)510787585;
				if (num != 0)
				{
				}
				num = (short)861601792;
				short num3 = num;
				num = (short)531431424;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.Editable;
			}
			set
			{
				short num = (short)1741170514;
				short num2 = num;
				num = (short)1155475282;
				switch (num2 == num)
				{
				}
				num = (short)2043674624;
				if (num != 0)
				{
				}
				num = (short)299499520;
				short num3 = num;
				num = (short)1216282625;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.Editable = value;
			}
		}

		// Token: 0x17004CF0 RID: 19696
		// (get) Token: 0x06009943 RID: 39235 RVA: 0x008FB970 File Offset: 0x008F9B70
		internal string EmerWideImpactDetectionEventForce_A43428_UILabel
		{
			get
			{
				short num = (short)1745029157;
				short num2 = num;
				num = (short)1566771237;
				switch (num2 == num)
				{
				}
				num = (short)1008599041;
				if (num != 0)
				{
				}
				num = (short)1173946368;
				short num3 = num;
				num = (short)2027356160;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.UIName;
			}
		}

		// Token: 0x17004CF1 RID: 19697
		// (get) Token: 0x06009944 RID: 39236 RVA: 0x008FBA24 File Offset: 0x008F9C24
		// (set) Token: 0x06009945 RID: 39237 RVA: 0x008FBAD8 File Offset: 0x008F9CD8
		internal bool EmerWideImpactDetectionEventForce_A43428_HiddenStatic
		{
			get
			{
				short num = (short)1606178160;
				short num2 = num;
				num = (short)348673392;
				switch (num2 == num)
				{
				}
				num = (short)725090304;
				if (num != 0)
				{
				}
				num = (short)1045299200;
				short num3 = num;
				num = (short)645005313;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.HiddenStatic;
			}
			set
			{
				short num = (short)611081647;
				short num2 = num;
				num = (short)2026397103;
				switch (num2 == num)
				{
				}
				num = (short)101515264;
				if (num != 0)
				{
				}
				num = (short)1362231296;
				short num3 = num;
				num = (short)999948289;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.HiddenStatic = value;
			}
		}

		// Token: 0x17004CF2 RID: 19698
		// (get) Token: 0x06009946 RID: 39238 RVA: 0x008FBB90 File Offset: 0x008F9D90
		// (set) Token: 0x06009947 RID: 39239 RVA: 0x008FBC44 File Offset: 0x008F9E44
		internal bool EmerWideImpactDetectionEventForce_A43428_HiddenDynamic
		{
			get
			{
				short num = (short)372880461;
				short num2 = num;
				num = (short)1651684429;
				switch (num2 == num)
				{
				}
				num = (short)2137849856;
				if (num != 0)
				{
				}
				num = (short)1504968704;
				short num3 = num;
				num = (short)193331201;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428.HiddenDynamic;
			}
			set
			{
				short num = (short)585629697;
				if (num != 0)
				{
				}
				num = (short)1634676110;
				short num2 = num;
				num = (short)124005774;
				switch (num2 == num)
				{
				}
				num = (short)560922624;
				short num3 = num;
				num = (short)1412562944;
				if (num != 0)
				{
				}
				this.emerWideImpactDetectionEventForce_A43428.HiddenDynamic = value;
			}
		}

		// Token: 0x17004CF3 RID: 19699
		// (get) Token: 0x06009948 RID: 39240 RVA: 0x008FBCFC File Offset: 0x008F9EFC
		public bool EmerWideImpactDetectionEventForce_A43428_HasDiffs
		{
			get
			{
				short num = (short)1865477866;
				short num2 = num;
				num = (short)768995050;
				switch (num2 == num)
				{
				}
				num = (short)647692289;
				if (num != 0)
				{
				}
				num = (short)914227200;
				short num3 = num;
				num = (short)1127874560;
				if (num != 0)
				{
				}
				return this.emerWideImpactDetectionEventForce_A43428._HasDiffs;
			}
		}

		// Token: 0x06009949 RID: 39241 RVA: 0x008FBDB0 File Offset: 0x008F9FB0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)419627008;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_96;
			}
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_32:
				num = (short)279193544;
				short num3 = num;
				num = (short)841689032;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1114308608;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)585302020;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					case 1:
						goto IL_FB;
					case 2:
						goto IL_CE;
					case 3:
						if (base.ParentRecset != null)
						{
							num = (short)1480916994;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A;
					case 4:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)263323649;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96;
				}
				IL_CE:
				num = (short)654966784;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_FB:
			IL_13A:
			num = (short)638582785;
			if (num != 0)
			{
			}
			return result;
			IL_96:
			result = null;
			num = (short)1994850307;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x04004BCE RID: 19406
		private global::AcpBusinessLayer.AcpSimpleRangeField emerWideImpactDetectionPreAlertTimer_A43381;

		// Token: 0x04004BCF RID: 19407
		private global::AcpBusinessLayer.AcpSimpleRangeField emerWideImpactDetectionPostAlertTimer_A43382;

		// Token: 0x04004BD0 RID: 19408
		private global::AcpBusinessLayer.AcpListField emerWideImpactDetectionPreAlertTone_A43383;

		// Token: 0x04004BD1 RID: 19409
		private global::AcpBusinessLayer.AcpListField emerWideImpactDetectionConfigLevel_A43384;

		// Token: 0x04004BD2 RID: 19410
		private global::AcpBusinessLayer.AcpField<bool> emerWideImpDectToneTrigger_A43386;

		// Token: 0x04004BD3 RID: 19411
		private global::AcpBusinessLayer.AcpSimpleRangeField emerWideImpactDetectionEventDuration_A43427;

		// Token: 0x04004BD4 RID: 19412
		private global::AcpBusinessLayer.AcpSimpleRangeField emerWideImpactDetectionEventForce_A43428;
	}
}
