using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005BB RID: 1467
	[global::System.Serializable]
	public class DVRS : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600C23A RID: 49722 RVA: 0x00B676CC File Offset: 0x00B658CC
		public DVRS(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600C23B RID: 49723 RVA: 0x00B676E8 File Offset: 0x00B658E8
		protected DVRS(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600C23C RID: 49724 RVA: 0x00B67700 File Offset: 0x00B65900
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1105751815;
			short num2 = num;
			num = (short)1204055815;
			switch (num2 == num)
			{
			}
			num = (short)1208549376;
			if (num != 0)
			{
			}
			num = (short)1909784577;
			if (num != 0)
			{
			}
			num = (short)1503002624;
			short num3 = num;
			this.cnvPerAGAGWACNID_A40155 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑鏓韕鿗跙鷛鷝껟ꯡꃣ맥ꧧ\udee9\udceb\udfed엯쟱", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGWACNID, 0, 1048574, 1, null, null);
			this.cnvPerAGAGWACNID_A40155.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerAGAGWACNID_A40155.DataTransferOrder = -1;
			this.cnvPerAGAGWACNID_A40155.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
			this.cnvPerAGAGWACNID_A40155.ShowHexValue = true;
			this.cnvPerAGAGWACNID_A40155.ShowLeadingZeros = true;
			this.cnvPerAGAGSysID_A40156 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑鏓韕鿗觙ꗛ귝꧟ꛡ믣꟥\udce7\udae9\uddeb\udbed웯", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGSYSTEMID, 0, 4094, 1, null, null);
			this.cnvPerAGAGSysID_A40156.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerAGAGSysID_A40156.DataTransferOrder = -1;
			this.cnvPerAGAGSysID_A40156.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
			this.cnvPerAGAGSysID_A40156.ShowHexValue = true;
			this.cnvPerAGAGSysID_A40156.ShowLeadingZeros = true;
			this.cnvPerAGAGTalkgroupID_A40157 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑鏓韕鿗軙뷛닝诟藡難觥鷧髩ꗫꫭ꿯돱샳웵짷쿹쯻", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGTALKGROUPID, 0, 65534, 1, null, null);
			this.cnvPerAGAGTalkgroupID_A40157.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerAGAGTalkgroupID_A40157.DataTransferOrder = -1;
			this.cnvPerAGAGTalkgroupID_A40157.AddCustomValue(0, global::CommonResources.AcgResources.ID_NONE);
			this.cnvPerAGAGTalkgroupID_A40157.ShowHexValue = true;
			this.cnvPerAGAGSecStrap_A40158 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑鏓韕鿗觙맛뷝돟雡難蟥飧뗩귫\udaed샯쏱쇳컵", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerAGAGSecStrap_A40158LovStrs);
			this.cnvPerAGAGSecStrap_A40158.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerAGAGSecStrap_A40158.DataTransferOrder = -1;
			this.cnvPerAGAGKeySel_A40159 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藅ꛇ볉鳋ꯍꋏ鏑鏓韕鿗釙맛꟝돟蟡裣맥ꧧ\udee9\udceb\udfed엯쯱", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGKEYSELECT, null, null, true, false);
			this.cnvPerAGAGKeySel_A40159.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvPerAGAGKeySel_A40159.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苅黇飉鿋", a_);
			base.Id = 10642;
			base.UIName = global::CommonResources.AcgResources.ID_DVRS;
			base.DataTransferOrder = 16;
		}

		// Token: 0x0600C23D RID: 49725 RVA: 0x00B6798C File Offset: 0x00B65B8C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)944177164;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕賗믙냛뗝蟟郡诣鏥飧ꏩ꣫뇭뇯웱쓳쟵췷췹", a_)))
					{
						goto IL_9F;
					}
					num = (short)1140375982;
					short num3 = num;
					num = (short)1592770990;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EC;
					default:
					{
						num = (short)1766129664;
						short num4 = num;
						num = (short)1788739584;
						if (num != 0)
						{
						}
						num = (short)2008154122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					this.cnvPerAGAGKeySel_A40159 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕鏗뿙ꗛ距藟軡믣꟥\udce7\udae9\uddeb\udbed짯", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGKEYSELECT, null, null, true, false);
					this.cnvPerAGAGKeySel_A40159.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerAGAGKeySel_A40159.DataTransferOrder = -1;
					num = (short)254214157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.cnvPerAGAGSysID_A40156 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕诗ꏙ꿛韝ꓟ뷡ꗣ틥\ud8e7\udbe9\ud9eb\ud8ed", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGSYSTEMID, null, null);
					this.cnvPerAGAGSysID_A40156.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerAGAGSysID_A40156.DataTransferOrder = -1;
					this.cnvPerAGAGSysID_A40156.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
					this.cnvPerAGAGSysID_A40156.ShowHexValue = true;
					this.cnvPerAGAGSysID_A40156.ShowLeadingZeros = true;
					num = (short)14876678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.cnvPerAGAGWACNID_A40155 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕迗鯙鿛郝꧟ꛡ믣꟥\udce7\udae9\uddeb\udbed엯", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGWACNID, null, null);
					this.cnvPerAGAGWACNID_A40155.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerAGAGWACNID_A40155.DataTransferOrder = -1;
					this.cnvPerAGAGWACNID_A40155.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
					this.cnvPerAGAGWACNID_A40155.ShowHexValue = true;
					this.cnvPerAGAGWACNID_A40155.ShowLeadingZeros = true;
					num = (short)540540935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕诗뿙뿛距铟郡藣雥럧ꯩ\ud8eb\udeed쇯쟱쳳", a_)))
					{
						num = (short)1224474639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9;
				case 5:
					goto IL_1F9;
				case 6:
					goto IL_EC;
				case 7:
					goto IL_4A2;
				case 8:
					goto IL_9F;
				case 9:
					num = (short)1358233601;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕诗ꏙ꿛韝ꓟ뷡ꗣ틥\ud8e7\udbe9\ud9eb\ud8ed", a_)))
					{
						num = (short)1806958594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC;
				case 10:
					this.cnvPerAGAGTalkgroupID_A40157 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕賗믙냛뗝蟟郡诣鏥飧ꏩ꣫뇭뇯웱쓳쟵췷췹", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGTALKGROUPID, null, null);
					this.cnvPerAGAGTalkgroupID_A40157.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerAGAGTalkgroupID_A40157.DataTransferOrder = -1;
					this.cnvPerAGAGTalkgroupID_A40157.AddCustomValue(0, global::CommonResources.AcgResources.ID_NONE);
					this.cnvPerAGAGTalkgroupID_A40157.ShowHexValue = true;
					num = (short)698417160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)945160208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 13:
					goto IL_32D;
				case 14:
					num = (short)43778066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.cnvPerAGAGSecStrap_A40158 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕诗뿙뿛距铟郡藣雥럧ꯩ\ud8eb\udeed쇯쟱쳳", a_), global::CommonResources.AcgResources.ID_ANNOUNCEMENTGROUPAGSECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.LOVs.CnvPerAGAGSecStrap_A40158LovStrs);
					this.cnvPerAGAGSecStrap_A40158.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvPerAGAGSecStrap_A40158.DataTransferOrder = -1;
					num = (short)688128005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕迗鯙鿛郝꧟ꛡ믣꟥\udce7\udae9\uddeb\udbed엯", a_)))
					{
						num = (short)1105461251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A2;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃ꣅ뻇髉꧋볍量闑闓釕鏗뿙ꗛ距藟軡믣꟥\udce7\udae9\uddeb\udbed짯", a_)))
					{
						num = (short)1601372161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_514;
				case 18:
					if (producerFields != null)
					{
						num = (short)1871708171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_514;
				}
				IL_7A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1526202382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9F:
				num = (short)1694957572;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EC:
				num = (short)1737949184;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F9:
				num = (short)617480209;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A2:
				num = (short)1173684233;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_32D:
			IL_514:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胃郅髇駉", a_);
			base.Id = 10642;
			base.UIName = global::CommonResources.AcgResources.ID_DVRS;
			base.DataTransferOrder = 16;
		}

		// Token: 0x0600C23E RID: 49726 RVA: 0x00B67EE0 File Offset: 0x00B660E0
		public override void PopulateReferences()
		{
			short num = (short)1829014909;
			short num2 = num;
			num = (short)856853885;
			switch (num2 == num)
			{
			}
			num = (short)299237377;
			if (num != 0)
			{
			}
			num = (short)392036352;
			if (num != 0)
			{
			}
			num = (short)735576064;
			short num3 = num;
			global::AcpCommonLib.IAcpRecordset recset = this.a();
			this.cnvPerAGAGKeySel_A40159.SetRecset(recset);
		}

		// Token: 0x0600C23F RID: 49727 RVA: 0x00B67F9C File Offset: 0x00B6619C
		private global::AcpCommonLib.IAcpRecordset a()
		{
			short num = (short)1683226624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				for (;;)
				{
					IL_29:
					bool? flag;
					bool? flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = secureKMFProfile.General;
						if (general != null)
						{
							flag = new bool?(general.SecKmfProfGenIndependentKeyList_43597.Value);
							goto IL_2FC;
						}
						bool? flag2 = null;
						num = (short)433711017;
						short num3 = num;
						num = (short)1036642217;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return embeddedRecset;
						default:
							num = (short)872087552;
							if (num != 0)
							{
							}
							num = (short)143458309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)1845755916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						embeddedRecset = secureKMFProfile.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
						num = (short)513998857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (base.ParentRecset.ParentSection != null)
						{
							num = (short)91553793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 4:
					{
						num = (short)2116747264;
						short num4 = num;
						if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
						{
							num = (short)738918402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 5:
					{
						bool? flag2;
						flag = flag2;
						goto IL_2FC;
					}
					case 6:
						num = (short)217907200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure secure;
						if (secure.CnvPerSecureKMFProfileIndex_A8381.Value > 0)
						{
							num = (short)359989249;
							if (num != 0)
							{
							}
							num = (short)768999438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 8:
						if (base.ParentRecset != null)
						{
							num = (short)288030730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 9:
						return embeddedRecset;
					case 10:
						num = (short)446234627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)449314822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 12:
						if (base.ParentRecset.ParentSection.Parent != null)
						{
							num = (short)2111176717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure secure = base.Parent[10142] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure;
						num = (short)2030370823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Secure secure;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = secure.CnvPerSecureKMFProfileIndex_A8381.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)681508875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6C;
					IL_2FC:
					flag3 = flag;
					flag4 = true;
					num = (short)487522308;
					num2 = (int)((global::System.IntPtr)num);
				}
				return embeddedRecset;
				IL_6C:
				embeddedRecset = this.a(2021)[0][10040].EmbeddedRecset;
				num = (short)183566344;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600C240 RID: 49728 RVA: 0x00B68320 File Offset: 0x00B66520
		public override void DropReferences()
		{
			short num = (short)1212707148;
			short num2 = num;
			num = (short)215249228;
			switch (num2 == num)
			{
			}
			num = (short)183304192;
			if (num != 0)
			{
			}
			num = (short)525139969;
			if (num != 0)
			{
			}
			num = (short)818610176;
			short num3 = num;
		}

		// Token: 0x0600C241 RID: 49729 RVA: 0x00B683C8 File Offset: 0x00B665C8
		public override void SetConstraints()
		{
			short num = (short)1193965518;
			short num2 = num;
			num = (short)492795854;
			switch (num2 == num)
			{
			}
			num = (short)1547960321;
			if (num != 0)
			{
			}
			num = (short)163708928;
			if (num != 0)
			{
			}
			num = (short)635437056;
			short num3 = num;
			this.cnvPerAGAGWACNID_A40155.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerAGAGSysID_A40156.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerAGAGTalkgroupID_A40157.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConCnvPerSysTypeIsDVRSAndTalkgroupEn);
			this.cnvPerAGAGTalkgroupID_A40157.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerAGAGSecStrap_A40158.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerAGIDIsNotNoneWithSec);
			this.cnvPerAGAGSecStrap_A40158.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
			this.cnvPerAGAGKeySel_A40159.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conCnvPerAGIDIsNotNoneWithSecAndSecStrap);
			this.cnvPerAGAGKeySel_A40159.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.ConDvrsAgKeySelValid);
			this.cnvPerAGAGKeySel_A40159.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityConstraints.conRefAstroSysIsDVRS);
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x00B68540 File Offset: 0x00B66740
		public override void SetupDependencies()
		{
			short num = (short)1991483646;
			short num2 = num;
			num = (short)1069523198;
			switch (num2 == num)
			{
			}
			num = (short)69533697;
			if (num != 0)
			{
			}
			num = (short)774897664;
			if (num != 0)
			{
			}
			num = (short)645791744;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerAGAGWACNID_A40155);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerAGAGWACNID_A40155);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerAGAGSysID_A40156);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerAGAGSysID_A40156);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerAGAGTalkgroupID_A40157);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerAGAGTalkgroupID_A40157);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerAGAGTalkgroupID_A40157);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerAGAGSecStrap_A40158);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerAGAGSecStrap_A40158);
			this.cnvPerAGAGTalkgroupID_A40157.AddDependentObject(this.cnvPerAGAGSecStrap_A40158);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerAGAGSecStrap_A40158);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerAGAGSecStrap_A40158);
			conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			this.cnvPerAGAGTalkgroupID_A40157.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			conventionalPersonality.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			this.cnvPerAGAGSecStrap_A40158.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			conventionalPersonality.Secure.CnvPerSecureKMFProfileIndex_A8381.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvPerAGAGKeySel_A40159);
		}

		// Token: 0x17006119 RID: 24857
		// (get) Token: 0x0600C243 RID: 49731 RVA: 0x00B6882C File Offset: 0x00B66A2C
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvPerAGAGKeySel_A40159
		{
			get
			{
				short num = (short)143639990;
				short num2 = num;
				num = (short)1999422902;
				switch (num2 == num)
				{
				}
				num = (short)1464074241;
				if (num != 0)
				{
				}
				num = (short)937754624;
				if (num != 0)
				{
				}
				num = (short)2125529088;
				short num3 = num;
				return this.cnvPerAGAGKeySel_A40159.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x1700611A RID: 24858
		// (get) Token: 0x0600C244 RID: 49732 RVA: 0x00B688E4 File Offset: 0x00B66AE4
		public bool HasDiffs
		{
			get
			{
				short num = (short)375204251;
				short num2 = num;
				num = (short)267594139;
				switch (num2 == num)
				{
				}
				num = (short)1514012673;
				if (num != 0)
				{
				}
				num = (short)778240000;
				if (num != 0)
				{
				}
				num = (short)1119354880;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700611B RID: 24859
		// (get) Token: 0x0600C245 RID: 49733 RVA: 0x00B68994 File Offset: 0x00B66B94
		// (set) Token: 0x0600C246 RID: 49734 RVA: 0x00B68A48 File Offset: 0x00B66C48
		public int CnvPerAGAGWACNID_A40155Value
		{
			get
			{
				short num = (short)434182771;
				short num2 = num;
				num = (short)1852906099;
				switch (num2 == num)
				{
				}
				num = (short)48955392;
				if (num != 0)
				{
				}
				num = (short)1173159937;
				if (num != 0)
				{
				}
				num = (short)505675776;
				short num3 = num;
				return this.cnvPerAGAGWACNID_A40155.Value;
			}
			set
			{
				short num = (short)877418352;
				short num2 = num;
				num = (short)1475827568;
				switch (num2 == num)
				{
				}
				num = (short)431357953;
				if (num != 0)
				{
				}
				num = (short)430309376;
				if (num != 0)
				{
				}
				num = (short)1317339136;
				short num3 = num;
				this.cnvPerAGAGWACNID_A40155.Value = value;
			}
		}

		// Token: 0x1700611C RID: 24860
		// (get) Token: 0x0600C247 RID: 49735 RVA: 0x00B68B00 File Offset: 0x00B66D00
		public global::AcpBusinessLayer.AcpCustomRangeField CnvPerAGAGWACNID_A40155
		{
			get
			{
				short num = (short)2133815667;
				short num2 = num;
				num = (short)2041540979;
				switch (num2 == num)
				{
				}
				num = (short)665518081;
				if (num != 0)
				{
				}
				num = (short)398262272;
				if (num != 0)
				{
				}
				num = (short)1353449472;
				short num3 = num;
				return this.cnvPerAGAGWACNID_A40155;
			}
		}

		// Token: 0x1700611D RID: 24861
		// (get) Token: 0x0600C248 RID: 49736 RVA: 0x00B68BAC File Offset: 0x00B66DAC
		// (set) Token: 0x0600C249 RID: 49737 RVA: 0x00B68C64 File Offset: 0x00B66E64
		public string CnvPerAGAGWACNID_A40155_UIValue
		{
			get
			{
				short num = (short)1544871620;
				short num2 = num;
				num = (short)1920130756;
				switch (num2 == num)
				{
				}
				num = (short)24117249;
				if (num != 0)
				{
				}
				num = (short)664272896;
				if (num != 0)
				{
				}
				num = (short)950730752;
				short num3 = num;
				return this.cnvPerAGAGWACNID_A40155.UIValue;
			}
			set
			{
				short num = (short)1197736211;
				short num2 = num;
				num = (short)1773863187;
				switch (num2 == num)
				{
				}
				num = (short)575471617;
				if (num != 0)
				{
				}
				num = (short)1598291968;
				if (num != 0)
				{
				}
				num = (short)246677504;
				short num3 = num;
				this.cnvPerAGAGWACNID_A40155.UIValue = value;
			}
		}

		// Token: 0x1700611E RID: 24862
		// (get) Token: 0x0600C24A RID: 49738 RVA: 0x00B68D18 File Offset: 0x00B66F18
		// (set) Token: 0x0600C24B RID: 49739 RVA: 0x00B68DD0 File Offset: 0x00B66FD0
		public string CnvPerAGAGWACNID_A40155_HexUIValue
		{
			get
			{
				short num = (short)2125398017;
				if (num != 0)
				{
				}
				num = (short)910031618;
				short num2 = num;
				num = (short)1804991234;
				switch (num2 == num)
				{
				}
				num = (short)633864192;
				if (num != 0)
				{
				}
				num = (short)1405485056;
				short num3 = num;
				return this.cnvPerAGAGWACNID_A40155.HexUIValue;
			}
			set
			{
				short num = (short)1786933765;
				short num2 = num;
				num = (short)152138245;
				switch (num2 == num)
				{
				}
				num = (short)1325596672;
				if (num != 0)
				{
				}
				num = (short)203096064;
				short num3 = num;
				num = (short)1336213505;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.HexUIValue = value;
			}
		}

		// Token: 0x1700611F RID: 24863
		// (get) Token: 0x0600C24C RID: 49740 RVA: 0x00B68E88 File Offset: 0x00B67088
		// (set) Token: 0x0600C24D RID: 49741 RVA: 0x00B68F3C File Offset: 0x00B6713C
		internal int CnvPerAGAGWACNID_A40155Min
		{
			get
			{
				short num = (short)569311233;
				if (num != 0)
				{
				}
				num = (short)650523027;
				short num2 = num;
				num = (short)1551905171;
				switch (num2 == num)
				{
				}
				num = (short)1803419648;
				short num3 = num;
				num = (short)1765343232;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.Min;
			}
			set
			{
				short num = (short)258969615;
				short num2 = num;
				num = (short)409374735;
				switch (num2 == num)
				{
				}
				num = (short)1155989505;
				if (num != 0)
				{
				}
				num = (short)337903616;
				short num3 = num;
				num = (short)574226432;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.Min = value;
			}
		}

		// Token: 0x17006120 RID: 24864
		// (get) Token: 0x0600C24E RID: 49742 RVA: 0x00B68FF4 File Offset: 0x00B671F4
		// (set) Token: 0x0600C24F RID: 49743 RVA: 0x00B690AC File Offset: 0x00B672AC
		internal int CnvPerAGAGWACNID_A40155Max
		{
			get
			{
				short num = (short)1387694550;
				short num2 = num;
				num = (short)656902614;
				switch (num2 == num)
				{
				}
				num = (short)1756233728;
				if (num != 0)
				{
				}
				num = (short)127533056;
				short num3 = num;
				num = (short)1166868481;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.Max;
			}
			set
			{
				short num = (short)1797808017;
				short num2 = num;
				num = (short)1423925137;
				switch (num2 == num)
				{
				}
				num = (short)345112577;
				if (num != 0)
				{
				}
				num = (short)545718272;
				short num3 = num;
				num = (short)1369178112;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.Max = value;
			}
		}

		// Token: 0x17006121 RID: 24865
		// (get) Token: 0x0600C250 RID: 49744 RVA: 0x00B69164 File Offset: 0x00B67364
		// (set) Token: 0x0600C251 RID: 49745 RVA: 0x00B6921C File Offset: 0x00B6741C
		internal int CnvPerAGAGWACNID_A40155Step
		{
			get
			{
				short num = (short)950661432;
				short num2 = num;
				num = (short)638185784;
				switch (num2 == num)
				{
				}
				num = (short)902692864;
				if (num != 0)
				{
				}
				num = (short)386007040;
				short num3 = num;
				num = (short)1740111873;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.StepSize;
			}
			set
			{
				short num = (short)1637812104;
				short num2 = num;
				num = (short)1426851720;
				switch (num2 == num)
				{
				}
				num = (short)1254293505;
				if (num != 0)
				{
				}
				num = (short)1479016448;
				short num3 = num;
				num = (short)495845376;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.StepSize = value;
			}
		}

		// Token: 0x17006122 RID: 24866
		// (get) Token: 0x0600C252 RID: 49746 RVA: 0x00B692D0 File Offset: 0x00B674D0
		// (set) Token: 0x0600C253 RID: 49747 RVA: 0x00B69384 File Offset: 0x00B67584
		public bool CnvPerAGAGWACNID_A40155_Applicable
		{
			get
			{
				short num = (short)196512482;
				short num2 = num;
				num = (short)1877248738;
				switch (num2 == num)
				{
				}
				num = (short)1145765889;
				if (num != 0)
				{
				}
				num = (short)2016935936;
				short num3 = num;
				num = (short)423100416;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.Applicable;
			}
			set
			{
				short num = (short)1651731711;
				short num2 = num;
				num = (short)2057596159;
				switch (num2 == num)
				{
				}
				num = (short)460914688;
				if (num != 0)
				{
				}
				num = (short)1558708224;
				short num3 = num;
				num = (short)1101725697;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.Applicable = value;
			}
		}

		// Token: 0x17006123 RID: 24867
		// (get) Token: 0x0600C254 RID: 49748 RVA: 0x00B6943C File Offset: 0x00B6763C
		// (set) Token: 0x0600C255 RID: 49749 RVA: 0x00B694F4 File Offset: 0x00B676F4
		public bool CnvPerAGAGWACNID_A40155_Valid
		{
			get
			{
				short num = (short)1772552193;
				if (num != 0)
				{
				}
				num = (short)871290240;
				short num2 = num;
				num = (short)407229824;
				switch (num2 == num)
				{
				}
				num = (short)187301888;
				short num3 = num;
				num = (short)1781399552;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.Valid;
			}
			set
			{
				short num = (short)387110787;
				short num2 = num;
				num = (short)1722275715;
				switch (num2 == num)
				{
				}
				num = (short)896925696;
				if (num != 0)
				{
				}
				num = (short)906756096;
				short num3 = num;
				num = (short)340787201;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.Valid = value;
			}
		}

		// Token: 0x17006124 RID: 24868
		// (get) Token: 0x0600C256 RID: 49750 RVA: 0x00B695A8 File Offset: 0x00B677A8
		// (set) Token: 0x0600C257 RID: 49751 RVA: 0x00B6965C File Offset: 0x00B6785C
		public bool CnvPerAGAGWACNID_A40155_Visible
		{
			get
			{
				short num = (short)772666615;
				short num2 = num;
				num = (short)814806263;
				switch (num2 == num)
				{
				}
				num = (short)1617297408;
				if (num != 0)
				{
				}
				num = (short)1478623232;
				short num3 = num;
				num = (short)246546433;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.Visible;
			}
			set
			{
				short num = (short)824343003;
				short num2 = num;
				num = (short)1782675931;
				switch (num2 == num)
				{
				}
				num = (short)1763442689;
				if (num != 0)
				{
				}
				num = (short)1157955584;
				short num3 = num;
				num = (short)654508032;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.Visible = value;
			}
		}

		// Token: 0x17006125 RID: 24869
		// (get) Token: 0x0600C258 RID: 49752 RVA: 0x00B69714 File Offset: 0x00B67914
		// (set) Token: 0x0600C259 RID: 49753 RVA: 0x00B697CC File Offset: 0x00B679CC
		public bool CnvPerAGAGWACNID_A40155_Editable
		{
			get
			{
				short num = (short)261473255;
				short num2 = num;
				num = (short)876004327;
				switch (num2 == num)
				{
				}
				num = (short)663879680;
				if (num != 0)
				{
				}
				num = (short)1932722176;
				short num3 = num;
				num = (short)985858049;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.Editable;
			}
			set
			{
				short num = (short)552403824;
				short num2 = num;
				num = (short)1079509872;
				switch (num2 == num)
				{
				}
				num = (short)809893888;
				if (num != 0)
				{
				}
				num = (short)90636288;
				short num3 = num;
				num = (short)142475265;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.Editable = value;
			}
		}

		// Token: 0x17006126 RID: 24870
		// (get) Token: 0x0600C25A RID: 49754 RVA: 0x00B69880 File Offset: 0x00B67A80
		internal string CnvPerAGAGWACNID_A40155_UILabel
		{
			get
			{
				short num = (short)570793170;
				short num2 = num;
				num = (short)311270610;
				switch (num2 == num)
				{
				}
				num = (short)526516224;
				if (num != 0)
				{
				}
				num = (short)1652948992;
				short num3 = num;
				num = (short)976355329;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.UIName;
			}
		}

		// Token: 0x17006127 RID: 24871
		// (get) Token: 0x0600C25B RID: 49755 RVA: 0x00B69934 File Offset: 0x00B67B34
		// (set) Token: 0x0600C25C RID: 49756 RVA: 0x00B699E8 File Offset: 0x00B67BE8
		internal bool CnvPerAGAGWACNID_A40155_HiddenStatic
		{
			get
			{
				short num = (short)436507673;
				short num2 = num;
				num = (short)413766681;
				switch (num2 == num)
				{
				}
				num = (short)1884880897;
				if (num != 0)
				{
				}
				num = (short)1515651072;
				short num3 = num;
				num = (short)1461256192;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.HiddenStatic;
			}
			set
			{
				short num = (short)464060417;
				if (num != 0)
				{
				}
				num = (short)1976778642;
				short num2 = num;
				num = (short)24461202;
				switch (num2 == num)
				{
				}
				num = (short)1705574400;
				short num3 = num;
				num = (short)1649410048;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.HiddenStatic = value;
			}
		}

		// Token: 0x17006128 RID: 24872
		// (get) Token: 0x0600C25D RID: 49757 RVA: 0x00B69AA0 File Offset: 0x00B67CA0
		// (set) Token: 0x0600C25E RID: 49758 RVA: 0x00B69B58 File Offset: 0x00B67D58
		internal bool CnvPerAGAGWACNID_A40155_HiddenDynamic
		{
			get
			{
				short num = (short)1681457153;
				if (num != 0)
				{
				}
				num = (short)99113746;
				short num2 = num;
				num = (short)1573804818;
				switch (num2 == num)
				{
				}
				num = (short)1110441984;
				short num3 = num;
				num = (short)1304035328;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155.HiddenDynamic;
			}
			set
			{
				short num = (short)37945345;
				if (num != 0)
				{
				}
				num = (short)1047527548;
				short num2 = num;
				num = (short)400949372;
				switch (num2 == num)
				{
				}
				num = (short)1086652416;
				short num3 = num;
				num = (short)964755456;
				if (num != 0)
				{
				}
				this.cnvPerAGAGWACNID_A40155.HiddenDynamic = value;
			}
		}

		// Token: 0x17006129 RID: 24873
		// (get) Token: 0x0600C25F RID: 49759 RVA: 0x00B69C0C File Offset: 0x00B67E0C
		public bool CnvPerAGAGWACNID_A40155_HasDiffs
		{
			get
			{
				short num = (short)419966089;
				short num2 = num;
				num = (short)1938041993;
				switch (num2 == num)
				{
				}
				num = (short)2100625409;
				if (num != 0)
				{
				}
				num = (short)561577984;
				short num3 = num;
				num = (short)805502976;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGWACNID_A40155._HasDiffs;
			}
		}

		// Token: 0x1700612A RID: 24874
		// (get) Token: 0x0600C260 RID: 49760 RVA: 0x00B69CC0 File Offset: 0x00B67EC0
		// (set) Token: 0x0600C261 RID: 49761 RVA: 0x00B69D78 File Offset: 0x00B67F78
		public int CnvPerAGAGSysID_A40156Value
		{
			get
			{
				short num = (short)735653037;
				short num2 = num;
				num = (short)702491821;
				switch (num2 == num)
				{
				}
				num = (short)654704641;
				if (num != 0)
				{
				}
				num = (short)1487077376;
				short num3 = num;
				num = (short)1813970944;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.Value;
			}
			set
			{
				short num = (short)1900240418;
				short num2 = num;
				num = (short)66018850;
				switch (num2 == num)
				{
				}
				num = (short)1753874432;
				if (num != 0)
				{
				}
				num = (short)780795904;
				short num3 = num;
				num = (short)1367408641;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.Value = value;
			}
		}

		// Token: 0x1700612B RID: 24875
		// (get) Token: 0x0600C262 RID: 49762 RVA: 0x00B69E30 File Offset: 0x00B68030
		public global::AcpBusinessLayer.AcpCustomRangeField CnvPerAGAGSysID_A40156
		{
			get
			{
				short num = (short)1083520342;
				short num2 = num;
				num = (short)397423958;
				switch (num2 == num)
				{
				}
				num = (short)1196883969;
				if (num != 0)
				{
				}
				num = (short)648151040;
				short num3 = num;
				num = (short)565051392;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156;
			}
		}

		// Token: 0x1700612C RID: 24876
		// (get) Token: 0x0600C263 RID: 49763 RVA: 0x00B69EE4 File Offset: 0x00B680E4
		// (set) Token: 0x0600C264 RID: 49764 RVA: 0x00B69F98 File Offset: 0x00B68198
		public string CnvPerAGAGSysID_A40156_UIValue
		{
			get
			{
				short num = (short)2132170391;
				short num2 = num;
				num = (short)1332958871;
				switch (num2 == num)
				{
				}
				num = (short)2082603009;
				if (num != 0)
				{
				}
				num = (short)1698234368;
				short num3 = num;
				num = (short)1069744128;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.UIValue;
			}
			set
			{
				short num = (short)175224791;
				short num2 = num;
				num = (short)1910814679;
				switch (num2 == num)
				{
				}
				num = (short)458752001;
				if (num != 0)
				{
				}
				num = (short)761987072;
				short num3 = num;
				num = (short)762380288;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.UIValue = value;
			}
		}

		// Token: 0x1700612D RID: 24877
		// (get) Token: 0x0600C265 RID: 49765 RVA: 0x00B6A04C File Offset: 0x00B6824C
		// (set) Token: 0x0600C266 RID: 49766 RVA: 0x00B6A100 File Offset: 0x00B68300
		public string CnvPerAGAGSysID_A40156_HexUIValue
		{
			get
			{
				short num = (short)8233787;
				short num2 = num;
				num = (short)967942971;
				switch (num2 == num)
				{
				}
				num = (short)1660420096;
				if (num != 0)
				{
				}
				num = (short)1848967168;
				short num3 = num;
				num = (short)1465319425;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.HexUIValue;
			}
			set
			{
				short num = (short)222030746;
				short num2 = num;
				num = (short)1915415450;
				switch (num2 == num)
				{
				}
				num = (short)1086980097;
				if (num != 0)
				{
				}
				num = (short)1202454528;
				short num3 = num;
				num = (short)1802829824;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.HexUIValue = value;
			}
		}

		// Token: 0x1700612E RID: 24878
		// (get) Token: 0x0600C267 RID: 49767 RVA: 0x00B6A1B4 File Offset: 0x00B683B4
		// (set) Token: 0x0600C268 RID: 49768 RVA: 0x00B6A268 File Offset: 0x00B68468
		internal int CnvPerAGAGSysID_A40156Min
		{
			get
			{
				short num = (short)755868748;
				short num2 = num;
				num = (short)286958668;
				switch (num2 == num)
				{
				}
				num = (short)1648623617;
				if (num != 0)
				{
				}
				num = (short)1282670592;
				short num3 = num;
				num = (short)837943296;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.Min;
			}
			set
			{
				short num = (short)1532443810;
				short num2 = num;
				num = (short)1707162786;
				switch (num2 == num)
				{
				}
				num = (short)1233256448;
				if (num != 0)
				{
				}
				num = (short)467402752;
				short num3 = num;
				num = (short)1896611841;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.Min = value;
			}
		}

		// Token: 0x1700612F RID: 24879
		// (get) Token: 0x0600C269 RID: 49769 RVA: 0x00B6A31C File Offset: 0x00B6851C
		// (set) Token: 0x0600C26A RID: 49770 RVA: 0x00B6A3D0 File Offset: 0x00B685D0
		internal int CnvPerAGAGSysID_A40156Max
		{
			get
			{
				short num = (short)574074503;
				short num2 = num;
				num = (short)1830792839;
				switch (num2 == num)
				{
				}
				num = (short)1584332801;
				if (num != 0)
				{
				}
				num = (short)2053242880;
				short num3 = num;
				num = (short)2112487424;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.Max;
			}
			set
			{
				short num = (short)713327294;
				short num2 = num;
				num = (short)1953727166;
				switch (num2 == num)
				{
				}
				num = (short)105578497;
				if (num != 0)
				{
				}
				num = (short)1751842816;
				short num3 = num;
				num = (short)572391424;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.Max = value;
			}
		}

		// Token: 0x17006130 RID: 24880
		// (get) Token: 0x0600C26B RID: 49771 RVA: 0x00B6A488 File Offset: 0x00B68688
		// (set) Token: 0x0600C26C RID: 49772 RVA: 0x00B6A53C File Offset: 0x00B6873C
		internal int CnvPerAGAGSysID_A40156Step
		{
			get
			{
				short num = (short)1364987838;
				short num2 = num;
				num = (short)1152389054;
				switch (num2 == num)
				{
				}
				num = (short)1911947265;
				if (num != 0)
				{
				}
				num = (short)1654718464;
				short num3 = num;
				num = (short)711000064;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.StepSize;
			}
			set
			{
				short num = (short)1247557586;
				short num2 = num;
				num = (short)1673213906;
				switch (num2 == num)
				{
				}
				num = (short)1768554496;
				if (num != 0)
				{
				}
				num = (short)1112342528;
				short num3 = num;
				num = (short)1372913665;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.StepSize = value;
			}
		}

		// Token: 0x17006131 RID: 24881
		// (get) Token: 0x0600C26D RID: 49773 RVA: 0x00B6A5F0 File Offset: 0x00B687F0
		// (set) Token: 0x0600C26E RID: 49774 RVA: 0x00B6A6A8 File Offset: 0x00B688A8
		public bool CnvPerAGAGSysID_A40156_Applicable
		{
			get
			{
				short num = (short)1344230691;
				short num2 = num;
				num = (short)1427658019;
				switch (num2 == num)
				{
				}
				num = (short)871432193;
				if (num != 0)
				{
				}
				num = (short)71565312;
				short num3 = num;
				num = (short)538574848;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.Applicable;
			}
			set
			{
				short num = (short)1312319051;
				short num2 = num;
				num = (short)51668555;
				switch (num2 == num)
				{
				}
				num = (short)1930887168;
				if (num != 0)
				{
				}
				num = (short)1833041920;
				short num3 = num;
				num = (short)1802829825;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.Applicable = value;
			}
		}

		// Token: 0x17006132 RID: 24882
		// (get) Token: 0x0600C26F RID: 49775 RVA: 0x00B6A760 File Offset: 0x00B68960
		// (set) Token: 0x0600C270 RID: 49776 RVA: 0x00B6A814 File Offset: 0x00B68A14
		public bool CnvPerAGAGSysID_A40156_Valid
		{
			get
			{
				short num = (short)31326209;
				if (num != 0)
				{
				}
				num = (short)1076609316;
				short num2 = num;
				num = (short)659079460;
				switch (num2 == num)
				{
				}
				num = (short)534249472;
				short num3 = num;
				num = (short)247463936;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.Valid;
			}
			set
			{
				short num = (short)1829830657;
				if (num != 0)
				{
				}
				num = (short)438682229;
				short num2 = num;
				num = (short)1948697205;
				switch (num2 == num)
				{
				}
				num = (short)1911488512;
				short num3 = num;
				num = (short)1960509440;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.Valid = value;
			}
		}

		// Token: 0x17006133 RID: 24883
		// (get) Token: 0x0600C271 RID: 49777 RVA: 0x00B6A8C8 File Offset: 0x00B68AC8
		// (set) Token: 0x0600C272 RID: 49778 RVA: 0x00B6A97C File Offset: 0x00B68B7C
		public bool CnvPerAGAGSysID_A40156_Visible
		{
			get
			{
				short num = (short)1503693241;
				short num2 = num;
				num = (short)171280825;
				switch (num2 == num)
				{
				}
				num = (short)407109633;
				if (num != 0)
				{
				}
				num = (short)1527316480;
				short num3 = num;
				num = (short)1479409664;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.Visible;
			}
			set
			{
				short num = (short)1188765746;
				short num2 = num;
				num = (short)1374429234;
				switch (num2 == num)
				{
				}
				num = (short)2105671681;
				if (num != 0)
				{
				}
				num = (short)676528128;
				short num3 = num;
				num = (short)1034354688;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.Visible = value;
			}
		}

		// Token: 0x17006134 RID: 24884
		// (get) Token: 0x0600C273 RID: 49779 RVA: 0x00B6AA30 File Offset: 0x00B68C30
		// (set) Token: 0x0600C274 RID: 49780 RVA: 0x00B6AAE4 File Offset: 0x00B68CE4
		public bool CnvPerAGAGSysID_A40156_Editable
		{
			get
			{
				short num = (short)873228159;
				short num2 = num;
				num = (short)1521575807;
				switch (num2 == num)
				{
				}
				num = (short)366018561;
				if (num != 0)
				{
				}
				num = (short)2086600704;
				short num3 = num;
				num = (short)1578106880;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.Editable;
			}
			set
			{
				short num = (short)1891907276;
				short num2 = num;
				num = (short)1356019404;
				switch (num2 == num)
				{
				}
				num = (short)1088552961;
				if (num != 0)
				{
				}
				num = (short)271450112;
				short num3 = num;
				num = (short)1759772672;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.Editable = value;
			}
		}

		// Token: 0x17006135 RID: 24885
		// (get) Token: 0x0600C275 RID: 49781 RVA: 0x00B6AB9C File Offset: 0x00B68D9C
		internal string CnvPerAGAGSysID_A40156_UILabel
		{
			get
			{
				short num = (short)556343421;
				short num2 = num;
				num = (short)1933713533;
				switch (num2 == num)
				{
				}
				num = (short)541655041;
				if (num != 0)
				{
				}
				num = (short)1738342400;
				short num3 = num;
				num = (short)1189412864;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.UIName;
			}
		}

		// Token: 0x17006136 RID: 24886
		// (get) Token: 0x0600C276 RID: 49782 RVA: 0x00B6AC50 File Offset: 0x00B68E50
		// (set) Token: 0x0600C277 RID: 49783 RVA: 0x00B6AD08 File Offset: 0x00B68F08
		internal bool CnvPerAGAGSysID_A40156_HiddenStatic
		{
			get
			{
				short num = (short)2105872937;
				short num2 = num;
				num = (short)348459561;
				switch (num2 == num)
				{
				}
				num = (short)964493313;
				if (num != 0)
				{
				}
				num = (short)223870976;
				short num3 = num;
				num = (short)588644352;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.HiddenStatic;
			}
			set
			{
				short num = (short)1393990089;
				short num2 = num;
				num = (short)777165257;
				switch (num2 == num)
				{
				}
				num = (short)1560608768;
				if (num != 0)
				{
				}
				num = (short)1164443648;
				short num3 = num;
				num = (short)71303169;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.HiddenStatic = value;
			}
		}

		// Token: 0x17006137 RID: 24887
		// (get) Token: 0x0600C278 RID: 49784 RVA: 0x00B6ADC0 File Offset: 0x00B68FC0
		// (set) Token: 0x0600C279 RID: 49785 RVA: 0x00B6AE78 File Offset: 0x00B69078
		internal bool CnvPerAGAGSysID_A40156_HiddenDynamic
		{
			get
			{
				short num = (short)948732631;
				short num2 = num;
				num = (short)1433764567;
				switch (num2 == num)
				{
				}
				num = (short)1582497793;
				if (num != 0)
				{
				}
				num = (short)453836800;
				short num3 = num;
				num = (short)1001521152;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156.HiddenDynamic;
			}
			set
			{
				short num = (short)1901537059;
				short num2 = num;
				num = (short)1320757027;
				switch (num2 == num)
				{
				}
				num = (short)1113063425;
				if (num != 0)
				{
				}
				num = (short)1020985344;
				short num3 = num;
				num = (short)784269312;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSysID_A40156.HiddenDynamic = value;
			}
		}

		// Token: 0x17006138 RID: 24888
		// (get) Token: 0x0600C27A RID: 49786 RVA: 0x00B6AF2C File Offset: 0x00B6912C
		public bool CnvPerAGAGSysID_A40156_HasDiffs
		{
			get
			{
				short num = (short)1588003278;
				short num2 = num;
				num = (short)2118910414;
				switch (num2 == num)
				{
				}
				num = (short)354418689;
				if (num != 0)
				{
				}
				num = (short)1433272320;
				short num3 = num;
				num = (short)452722688;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSysID_A40156._HasDiffs;
			}
		}

		// Token: 0x17006139 RID: 24889
		// (get) Token: 0x0600C27B RID: 49787 RVA: 0x00B6AFE4 File Offset: 0x00B691E4
		// (set) Token: 0x0600C27C RID: 49788 RVA: 0x00B6B098 File Offset: 0x00B69298
		public int CnvPerAGAGTalkgroupID_A40157Value
		{
			get
			{
				short num = (short)1206068778;
				short num2 = num;
				num = (short)179512874;
				switch (num2 == num)
				{
				}
				num = (short)1741357057;
				if (num != 0)
				{
				}
				num = (short)1565655040;
				short num3 = num;
				num = (short)1062731776;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGTalkgroupID_A40157.Value;
			}
			set
			{
				short num = (short)495615392;
				short num2 = num;
				num = (short)565869984;
				switch (num2 == num)
				{
				}
				num = (short)2097807360;
				if (num != 0)
				{
				}
				num = (short)2054619136;
				short num3 = num;
				num = (short)499974145;
				if (num != 0)
				{
				}
				this.cnvPerAGAGTalkgroupID_A40157.Value = value;
			}
		}

		// Token: 0x1700613A RID: 24890
		// (get) Token: 0x0600C27D RID: 49789 RVA: 0x00B6B150 File Offset: 0x00B69350
		public global::AcpBusinessLayer.AcpCustomRangeField CnvPerAGAGTalkgroupID_A40157
		{
			get
			{
				short num = (short)2104935254;
				short num2 = num;
				num = (short)395559766;
				switch (num2 == num)
				{
				}
				num = (short)821362689;
				if (num != 0)
				{
				}
				num = (short)385286144;
				if (num != 0)
				{
				}
				num = (short)1344471040;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157;
			}
		}

		// Token: 0x1700613B RID: 24891
		// (get) Token: 0x0600C27E RID: 49790 RVA: 0x00B6B1FC File Offset: 0x00B693FC
		// (set) Token: 0x0600C27F RID: 49791 RVA: 0x00B6B2B4 File Offset: 0x00B694B4
		public string CnvPerAGAGTalkgroupID_A40157_UIValue
		{
			get
			{
				short num = (short)111817185;
				short num2 = num;
				num = (short)572535265;
				switch (num2 == num)
				{
				}
				num = (short)1016856577;
				if (num != 0)
				{
				}
				num = (short)1994326016;
				if (num != 0)
				{
				}
				num = (short)1804599296;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.UIValue;
			}
			set
			{
				short num = (short)4162482;
				short num2 = num;
				num = (short)1173849010;
				switch (num2 == num)
				{
				}
				num = (short)884211713;
				if (num != 0)
				{
				}
				num = (short)1792671744;
				if (num != 0)
				{
				}
				num = (short)1969029120;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.UIValue = value;
			}
		}

		// Token: 0x1700613C RID: 24892
		// (get) Token: 0x0600C280 RID: 49792 RVA: 0x00B6B36C File Offset: 0x00B6956C
		// (set) Token: 0x0600C281 RID: 49793 RVA: 0x00B6B424 File Offset: 0x00B69624
		public string CnvPerAGAGTalkgroupID_A40157_HexUIValue
		{
			get
			{
				short num = (short)1983971478;
				short num2 = num;
				num = (short)1904410774;
				switch (num2 == num)
				{
				}
				num = (short)163381249;
				if (num != 0)
				{
				}
				num = (short)1811939328;
				if (num != 0)
				{
				}
				num = (short)1722744832;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.HexUIValue;
			}
			set
			{
				short num = (short)1813958265;
				short num2 = num;
				num = (short)251907705;
				switch (num2 == num)
				{
				}
				num = (short)1119092737;
				if (num != 0)
				{
				}
				num = (short)1958936576;
				if (num != 0)
				{
				}
				num = (short)1299709952;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.HexUIValue = value;
			}
		}

		// Token: 0x1700613D RID: 24893
		// (get) Token: 0x0600C282 RID: 49794 RVA: 0x00B6B4D8 File Offset: 0x00B696D8
		// (set) Token: 0x0600C283 RID: 49795 RVA: 0x00B6B58C File Offset: 0x00B6978C
		internal int CnvPerAGAGTalkgroupID_A40157Min
		{
			get
			{
				short num = (short)1337673047;
				short num2 = num;
				num = (short)1958167895;
				switch (num2 == num)
				{
				}
				num = (short)1253048321;
				if (num != 0)
				{
				}
				num = (short)1888747520;
				if (num != 0)
				{
				}
				num = (short)725352448;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.Min;
			}
			set
			{
				short num = (short)1153880944;
				short num2 = num;
				num = (short)1365496688;
				switch (num2 == num)
				{
				}
				num = (short)2029191169;
				if (num != 0)
				{
				}
				num = (short)1879769088;
				if (num != 0)
				{
				}
				num = (short)2076049408;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.Min = value;
			}
		}

		// Token: 0x1700613E RID: 24894
		// (get) Token: 0x0600C284 RID: 49796 RVA: 0x00B6B640 File Offset: 0x00B69840
		// (set) Token: 0x0600C285 RID: 49797 RVA: 0x00B6B6F4 File Offset: 0x00B698F4
		internal int CnvPerAGAGTalkgroupID_A40157Max
		{
			get
			{
				short num = (short)983653048;
				short num2 = num;
				num = (short)851532472;
				switch (num2 == num)
				{
				}
				num = (short)1818951681;
				if (num != 0)
				{
				}
				num = (short)1814429696;
				if (num != 0)
				{
				}
				num = (short)1332609024;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.Max;
			}
			set
			{
				short num = (short)1758671678;
				short num2 = num;
				num = (short)127480638;
				switch (num2 == num)
				{
				}
				num = (short)1271267329;
				if (num != 0)
				{
				}
				num = (short)933298176;
				if (num != 0)
				{
				}
				num = (short)1161953280;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.Max = value;
			}
		}

		// Token: 0x1700613F RID: 24895
		// (get) Token: 0x0600C286 RID: 49798 RVA: 0x00B6B7AC File Offset: 0x00B699AC
		// (set) Token: 0x0600C287 RID: 49799 RVA: 0x00B6B860 File Offset: 0x00B69A60
		internal int CnvPerAGAGTalkgroupID_A40157Step
		{
			get
			{
				short num = (short)1976827905;
				if (num != 0)
				{
				}
				num = (short)1865590714;
				short num2 = num;
				num = (short)914139066;
				switch (num2 == num)
				{
				}
				num = (short)894631936;
				if (num != 0)
				{
				}
				num = (short)1177878528;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.StepSize;
			}
			set
			{
				short num = (short)1620200957;
				short num2 = num;
				num = (short)1011830269;
				switch (num2 == num)
				{
				}
				num = (short)905773056;
				if (num != 0)
				{
				}
				num = (short)1822621697;
				if (num != 0)
				{
				}
				num = (short)1571684352;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.StepSize = value;
			}
		}

		// Token: 0x17006140 RID: 24896
		// (get) Token: 0x0600C288 RID: 49800 RVA: 0x00B6B918 File Offset: 0x00B69B18
		// (set) Token: 0x0600C289 RID: 49801 RVA: 0x00B6B9CC File Offset: 0x00B69BCC
		public bool CnvPerAGAGTalkgroupID_A40157_Applicable
		{
			get
			{
				short num = (short)1542659054;
				short num2 = num;
				num = (short)148642798;
				switch (num2 == num)
				{
				}
				num = (short)824770561;
				if (num != 0)
				{
				}
				num = (short)1438187520;
				if (num != 0)
				{
				}
				num = (short)1398865920;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.Applicable;
			}
			set
			{
				short num = (short)1954545665;
				if (num != 0)
				{
				}
				num = (short)1418454678;
				short num2 = num;
				num = (short)1447356054;
				switch (num2 == num)
				{
				}
				num = (short)397344768;
				if (num != 0)
				{
				}
				num = (short)1044185088;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.Applicable = value;
			}
		}

		// Token: 0x17006141 RID: 24897
		// (get) Token: 0x0600C28A RID: 49802 RVA: 0x00B6BA80 File Offset: 0x00B69C80
		// (set) Token: 0x0600C28B RID: 49803 RVA: 0x00B6BB30 File Offset: 0x00B69D30
		public bool CnvPerAGAGTalkgroupID_A40157_Valid
		{
			get
			{
				short num = (short)690434141;
				short num2 = num;
				num = (short)662057053;
				switch (num2 == num)
				{
				}
				num = (short)467795968;
				if (num != 0)
				{
				}
				num = (short)1897332737;
				if (num != 0)
				{
				}
				num = (short)2010513408;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.Valid;
			}
			set
			{
				short num = (short)1457530616;
				short num2 = num;
				num = (short)1303586552;
				switch (num2 == num)
				{
				}
				num = (short)1340866560;
				if (num != 0)
				{
				}
				num = (short)1536229377;
				if (num != 0)
				{
				}
				num = (short)1387134976;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.Valid = value;
			}
		}

		// Token: 0x17006142 RID: 24898
		// (get) Token: 0x0600C28C RID: 49804 RVA: 0x00B6BBE4 File Offset: 0x00B69DE4
		// (set) Token: 0x0600C28D RID: 49805 RVA: 0x00B6BC9C File Offset: 0x00B69E9C
		public bool CnvPerAGAGTalkgroupID_A40157_Visible
		{
			get
			{
				short num = (short)202331332;
				short num2 = num;
				num = (short)1929794756;
				switch (num2 == num)
				{
				}
				num = (short)537985025;
				if (num != 0)
				{
				}
				num = (short)184745984;
				if (num != 0)
				{
				}
				num = (short)1265172480;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.Visible;
			}
			set
			{
				short num = (short)1658578232;
				short num2 = num;
				num = (short)1909056824;
				switch (num2 == num)
				{
				}
				num = (short)582811649;
				if (num != 0)
				{
				}
				num = (short)1725497344;
				if (num != 0)
				{
				}
				num = (short)842334208;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.Visible = value;
			}
		}

		// Token: 0x17006143 RID: 24899
		// (get) Token: 0x0600C28E RID: 49806 RVA: 0x00B6BD54 File Offset: 0x00B69F54
		// (set) Token: 0x0600C28F RID: 49807 RVA: 0x00B6BE10 File Offset: 0x00B6A010
		public bool CnvPerAGAGTalkgroupID_A40157_Editable
		{
			get
			{
				short num = (short)1774797320;
				short num2 = num;
				num = (short)2016035336;
				switch (num2 == num)
				{
				}
				num = (short)1439039489;
				if (num != 0)
				{
				}
				num = (short)1302003712;
				if (num != 0)
				{
				}
				num = (short)2033516544;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.Editable;
			}
			set
			{
				short num = (short)1136357060;
				short num2 = num;
				num = (short)1635086020;
				switch (num2 == num)
				{
				}
				num = (short)1705050113;
				if (num != 0)
				{
				}
				num = (short)1954873344;
				if (num != 0)
				{
				}
				num = (short)1260781568;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.Editable = value;
			}
		}

		// Token: 0x17006144 RID: 24900
		// (get) Token: 0x0600C290 RID: 49808 RVA: 0x00B6BEC8 File Offset: 0x00B6A0C8
		internal string CnvPerAGAGTalkgroupID_A40157_UILabel
		{
			get
			{
				short num = (short)1502256421;
				short num2 = num;
				num = (short)161783077;
				switch (num2 == num)
				{
				}
				num = (short)53542912;
				if (num != 0)
				{
				}
				num = (short)282329089;
				if (num != 0)
				{
				}
				num = (short)446169088;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.UIName;
			}
		}

		// Token: 0x17006145 RID: 24901
		// (get) Token: 0x0600C291 RID: 49809 RVA: 0x00B6BF7C File Offset: 0x00B6A17C
		// (set) Token: 0x0600C292 RID: 49810 RVA: 0x00B6C030 File Offset: 0x00B6A230
		internal bool CnvPerAGAGTalkgroupID_A40157_HiddenStatic
		{
			get
			{
				short num = (short)966122413;
				short num2 = num;
				num = (short)1586289581;
				switch (num2 == num)
				{
				}
				num = (short)2059206656;
				if (num != 0)
				{
				}
				num = (short)515244033;
				if (num != 0)
				{
				}
				num = (short)966262784;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.HiddenStatic;
			}
			set
			{
				short num = (short)1485558180;
				short num2 = num;
				num = (short)624349604;
				switch (num2 == num)
				{
				}
				num = (short)1178468353;
				if (num != 0)
				{
				}
				num = (short)494469120;
				if (num != 0)
				{
				}
				num = (short)1342308352;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.HiddenStatic = value;
			}
		}

		// Token: 0x17006146 RID: 24902
		// (get) Token: 0x0600C293 RID: 49811 RVA: 0x00B6C0E4 File Offset: 0x00B6A2E4
		// (set) Token: 0x0600C294 RID: 49812 RVA: 0x00B6C198 File Offset: 0x00B6A398
		internal bool CnvPerAGAGTalkgroupID_A40157_HiddenDynamic
		{
			get
			{
				short num = (short)869905880;
				short num2 = num;
				num = (short)915584472;
				switch (num2 == num)
				{
				}
				num = (short)398262273;
				if (num != 0)
				{
				}
				num = (short)1515192320;
				if (num != 0)
				{
				}
				num = (short)25165824;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157.HiddenDynamic;
			}
			set
			{
				short num = (short)87046879;
				short num2 = num;
				num = (short)535182047;
				switch (num2 == num)
				{
				}
				num = (short)667418624;
				if (num != 0)
				{
				}
				num = (short)1252458497;
				if (num != 0)
				{
				}
				num = (short)512163840;
				short num3 = num;
				this.cnvPerAGAGTalkgroupID_A40157.HiddenDynamic = value;
			}
		}

		// Token: 0x17006147 RID: 24903
		// (get) Token: 0x0600C295 RID: 49813 RVA: 0x00B6C250 File Offset: 0x00B6A450
		public bool CnvPerAGAGTalkgroupID_A40157_HasDiffs
		{
			get
			{
				short num = (short)1820563709;
				short num2 = num;
				num = (short)511285501;
				switch (num2 == num)
				{
				}
				num = (short)104529921;
				if (num != 0)
				{
				}
				num = (short)190316544;
				if (num != 0)
				{
				}
				num = (short)685244416;
				short num3 = num;
				return this.cnvPerAGAGTalkgroupID_A40157._HasDiffs;
			}
		}

		// Token: 0x17006148 RID: 24904
		// (get) Token: 0x0600C296 RID: 49814 RVA: 0x00B6C304 File Offset: 0x00B6A504
		// (set) Token: 0x0600C297 RID: 49815 RVA: 0x00B6C3BC File Offset: 0x00B6A5BC
		public int CnvPerAGAGSecStrap_A40158Value
		{
			get
			{
				short num = (short)1135869953;
				if (num != 0)
				{
				}
				num = (short)634385853;
				short num2 = num;
				num = (short)101905853;
				switch (num2 == num)
				{
				}
				num = (short)1071054848;
				if (num != 0)
				{
				}
				num = (short)1338769408;
				short num3 = num;
				return this.cnvPerAGAGSecStrap_A40158.Value;
			}
			set
			{
				short num = (short)771427376;
				short num2 = num;
				num = (short)689245232;
				switch (num2 == num)
				{
				}
				num = (short)1200881664;
				if (num != 0)
				{
				}
				num = (short)1927806977;
				if (num != 0)
				{
				}
				num = (short)1881079808;
				short num3 = num;
				this.cnvPerAGAGSecStrap_A40158.Value = value;
			}
		}

		// Token: 0x17006149 RID: 24905
		// (get) Token: 0x0600C298 RID: 49816 RVA: 0x00B6C470 File Offset: 0x00B6A670
		// (set) Token: 0x0600C299 RID: 49817 RVA: 0x00B6C524 File Offset: 0x00B6A724
		public string CnvPerAGAGSecStrap_A40158_UIValue
		{
			get
			{
				short num = (short)1788955640;
				short num2 = num;
				num = (short)1431391224;
				switch (num2 == num)
				{
				}
				num = (short)2057502721;
				if (num != 0)
				{
				}
				num = (short)1887043584;
				if (num != 0)
				{
				}
				num = (short)145948672;
				short num3 = num;
				return this.cnvPerAGAGSecStrap_A40158.UIValue;
			}
			set
			{
				short num = (short)743676813;
				short num2 = num;
				num = (short)2057804685;
				switch (num2 == num)
				{
				}
				num = (short)1023410177;
				if (num != 0)
				{
				}
				num = (short)1946877952;
				if (num != 0)
				{
				}
				num = (short)1767440384;
				short num3 = num;
				this.cnvPerAGAGSecStrap_A40158.UIValue = value;
			}
		}

		// Token: 0x1700614A RID: 24906
		// (get) Token: 0x0600C29A RID: 49818 RVA: 0x00B6C5D8 File Offset: 0x00B6A7D8
		public global::AcpBusinessLayer.AcpListField CnvPerAGAGSecStrap_A40158
		{
			get
			{
				short num = (short)1418919937;
				if (num != 0)
				{
				}
				num = (short)791270336;
				short num2 = num;
				num = (short)1069863872;
				switch (num2 == num)
				{
				}
				num = (short)643432448;
				if (num != 0)
				{
				}
				num = (short)194510848;
				short num3 = num;
				return this.cnvPerAGAGSecStrap_A40158;
			}
		}

		// Token: 0x1700614B RID: 24907
		// (get) Token: 0x0600C29B RID: 49819 RVA: 0x00B6C688 File Offset: 0x00B6A888
		// (set) Token: 0x0600C29C RID: 49820 RVA: 0x00B6C73C File Offset: 0x00B6A93C
		public bool CnvPerAGAGSecStrap_A40158_Applicable
		{
			get
			{
				short num = (short)693473460;
				short num2 = num;
				num = (short)1516409012;
				switch (num2 == num)
				{
				}
				num = (short)448724993;
				if (num != 0)
				{
				}
				num = (short)1294073856;
				if (num != 0)
				{
				}
				num = (short)1481441280;
				short num3 = num;
				return this.cnvPerAGAGSecStrap_A40158.Applicable;
			}
			set
			{
				short num = (short)1791664492;
				short num2 = num;
				num = (short)473342316;
				switch (num2 == num)
				{
				}
				num = (short)1523187713;
				if (num != 0)
				{
				}
				num = (short)102432768;
				if (num != 0)
				{
				}
				num = (short)1805189120;
				short num3 = num;
				this.cnvPerAGAGSecStrap_A40158.Applicable = value;
			}
		}

		// Token: 0x1700614C RID: 24908
		// (get) Token: 0x0600C29D RID: 49821 RVA: 0x00B6C7F0 File Offset: 0x00B6A9F0
		// (set) Token: 0x0600C29E RID: 49822 RVA: 0x00B6C8A8 File Offset: 0x00B6AAA8
		public bool CnvPerAGAGSecStrap_A40158_Valid
		{
			get
			{
				short num = (short)779026433;
				if (num != 0)
				{
				}
				num = (short)1362543983;
				short num2 = num;
				num = (short)573162863;
				switch (num2 == num)
				{
				}
				num = (short)1300103168;
				if (num != 0)
				{
				}
				num = (short)10420224;
				short num3 = num;
				return this.cnvPerAGAGSecStrap_A40158.Valid;
			}
			set
			{
				short num = (short)313468587;
				short num2 = num;
				num = (short)2136221355;
				switch (num2 == num)
				{
				}
				num = (short)1705312257;
				if (num != 0)
				{
				}
				num = (short)1286209536;
				if (num != 0)
				{
				}
				num = (short)1283457024;
				short num3 = num;
				this.cnvPerAGAGSecStrap_A40158.Valid = value;
			}
		}

		// Token: 0x1700614D RID: 24909
		// (get) Token: 0x0600C29F RID: 49823 RVA: 0x00B6C960 File Offset: 0x00B6AB60
		// (set) Token: 0x0600C2A0 RID: 49824 RVA: 0x00B6CA18 File Offset: 0x00B6AC18
		public bool CnvPerAGAGSecStrap_A40158_Visible
		{
			get
			{
				short num = (short)3897675;
				short num2 = num;
				num = (short)1351579979;
				switch (num2 == num)
				{
				}
				num = (short)1979777025;
				if (num != 0)
				{
				}
				num = (short)1987051520;
				if (num != 0)
				{
				}
				num = (short)981139456;
				short num3 = num;
				return this.cnvPerAGAGSecStrap_A40158.Visible;
			}
			set
			{
				short num = (short)94862502;
				short num2 = num;
				num = (short)31751334;
				switch (num2 == num)
				{
				}
				num = (short)2006056960;
				if (num != 0)
				{
				}
				num = (short)1776812033;
				if (num != 0)
				{
				}
				num = (short)1125646336;
				short num3 = num;
				this.cnvPerAGAGSecStrap_A40158.Visible = value;
			}
		}

		// Token: 0x1700614E RID: 24910
		// (get) Token: 0x0600C2A1 RID: 49825 RVA: 0x00B6CAD0 File Offset: 0x00B6ACD0
		// (set) Token: 0x0600C2A2 RID: 49826 RVA: 0x00B6CB84 File Offset: 0x00B6AD84
		public bool CnvPerAGAGSecStrap_A40158_Editable
		{
			get
			{
				short num = (short)1317994252;
				short num2 = num;
				num = (short)1531969292;
				switch (num2 == num)
				{
				}
				num = (short)173604864;
				if (num != 0)
				{
				}
				num = (short)1668546561;
				if (num != 0)
				{
				}
				num = (short)1911619584;
				short num3 = num;
				return this.cnvPerAGAGSecStrap_A40158.Editable;
			}
			set
			{
				short num = (short)487456769;
				if (num != 0)
				{
				}
				num = (short)18812711;
				short num2 = num;
				num = (short)1891176231;
				switch (num2 == num)
				{
				}
				num = (short)1655177216;
				short num3 = num;
				num = (short)309329920;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSecStrap_A40158.Editable = value;
			}
		}

		// Token: 0x1700614F RID: 24911
		// (get) Token: 0x0600C2A3 RID: 49827 RVA: 0x00B6CC3C File Offset: 0x00B6AE3C
		internal string CnvPerAGAGSecStrap_A40158_UILabel
		{
			get
			{
				short num = (short)1916037465;
				short num2 = num;
				num = (short)551446873;
				switch (num2 == num)
				{
				}
				num = (short)1456537601;
				if (num != 0)
				{
				}
				num = (short)5505024;
				short num3 = num;
				num = (short)1039532032;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSecStrap_A40158.UIName;
			}
		}

		// Token: 0x17006150 RID: 24912
		// (get) Token: 0x0600C2A4 RID: 49828 RVA: 0x00B6CCF0 File Offset: 0x00B6AEF0
		// (set) Token: 0x0600C2A5 RID: 49829 RVA: 0x00B6CDA8 File Offset: 0x00B6AFA8
		internal bool CnvPerAGAGSecStrap_A40158_HiddenStatic
		{
			get
			{
				short num = (short)226103244;
				short num2 = num;
				num = (short)1923682252;
				switch (num2 == num)
				{
				}
				num = (short)107872256;
				if (num != 0)
				{
				}
				num = (short)1277952000;
				short num3 = num;
				num = (short)2108489729;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSecStrap_A40158.HiddenStatic;
			}
			set
			{
				short num = (short)2018939611;
				short num2 = num;
				num = (short)1327665883;
				switch (num2 == num)
				{
				}
				num = (short)366477313;
				if (num != 0)
				{
				}
				num = (short)460849152;
				short num3 = num;
				num = (short)38207488;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSecStrap_A40158.HiddenStatic = value;
			}
		}

		// Token: 0x17006151 RID: 24913
		// (get) Token: 0x0600C2A6 RID: 49830 RVA: 0x00B6CE60 File Offset: 0x00B6B060
		// (set) Token: 0x0600C2A7 RID: 49831 RVA: 0x00B6CF18 File Offset: 0x00B6B118
		internal bool CnvPerAGAGSecStrap_A40158_HiddenDynamic
		{
			get
			{
				short num = (short)603874923;
				short num2 = num;
				num = (short)62219883;
				switch (num2 == num)
				{
				}
				num = (short)361955328;
				if (num != 0)
				{
				}
				num = (short)849149952;
				short num3 = num;
				num = (short)541917185;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSecStrap_A40158.HiddenDynamic;
			}
			set
			{
				short num = (short)975474486;
				short num2 = num;
				num = (short)1137217334;
				switch (num2 == num)
				{
				}
				num = (short)778108928;
				if (num != 0)
				{
				}
				num = (short)527892480;
				short num3 = num;
				num = (short)1323433985;
				if (num != 0)
				{
				}
				this.cnvPerAGAGSecStrap_A40158.HiddenDynamic = value;
			}
		}

		// Token: 0x17006152 RID: 24914
		// (get) Token: 0x0600C2A8 RID: 49832 RVA: 0x00B6CFD0 File Offset: 0x00B6B1D0
		public bool CnvPerAGAGSecStrap_A40158_HasDiffs
		{
			get
			{
				short num = (short)592896511;
				short num2 = num;
				num = (short)2098979327;
				switch (num2 == num)
				{
				}
				num = (short)382009345;
				if (num != 0)
				{
				}
				num = (short)174718976;
				short num3 = num;
				num = (short)1183711232;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGSecStrap_A40158._HasDiffs;
			}
		}

		// Token: 0x17006153 RID: 24915
		// (get) Token: 0x0600C2A9 RID: 49833 RVA: 0x00B6D084 File Offset: 0x00B6B284
		// (set) Token: 0x0600C2AA RID: 49834 RVA: 0x00B6D13C File Offset: 0x00B6B33C
		public int CnvPerAGAGKeySel_A40159Value
		{
			get
			{
				short num = (short)1257951797;
				short num2 = num;
				num = (short)1299698229;
				switch (num2 == num)
				{
				}
				num = (short)57737217;
				if (num != 0)
				{
				}
				num = (short)1576665088;
				short num3 = num;
				num = (short)5832704;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.Value;
			}
			set
			{
				short num = (short)300370833;
				short num2 = num;
				num = (short)1602046865;
				switch (num2 == num)
				{
				}
				num = (short)941031425;
				if (num != 0)
				{
				}
				num = (short)1662058496;
				short num3 = num;
				num = (short)160890880;
				if (num != 0)
				{
				}
				this.cnvPerAGAGKeySel_A40159.Value = value;
			}
		}

		// Token: 0x17006154 RID: 24916
		// (get) Token: 0x0600C2AB RID: 49835 RVA: 0x00B6D1F4 File Offset: 0x00B6B3F4
		// (set) Token: 0x0600C2AC RID: 49836 RVA: 0x00B6D2A8 File Offset: 0x00B6B4A8
		public string CnvPerAGAGKeySel_A40159_UIValue
		{
			get
			{
				short num = (short)1997361206;
				short num2 = num;
				num = (short)1120161846;
				switch (num2 == num)
				{
				}
				num = (short)336003073;
				if (num != 0)
				{
				}
				num = (short)1531445248;
				short num3 = num;
				num = (short)1015087104;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.UIValue;
			}
			set
			{
				short num = (short)96596000;
				short num2 = num;
				num = (short)1813835808;
				switch (num2 == num)
				{
				}
				num = (short)718536705;
				if (num != 0)
				{
				}
				num = (short)1673461760;
				short num3 = num;
				num = (short)1536688128;
				if (num != 0)
				{
				}
				this.cnvPerAGAGKeySel_A40159.UIValue = value;
			}
		}

		// Token: 0x17006155 RID: 24917
		// (get) Token: 0x0600C2AD RID: 49837 RVA: 0x00B6D35C File Offset: 0x00B6B55C
		public global::AcpBusinessLayer.AcpRecRefField CnvPerAGAGKeySel_A40159
		{
			get
			{
				short num = (short)491711281;
				short num2 = num;
				num = (short)589294385;
				switch (num2 == num)
				{
				}
				num = (short)1450573825;
				if (num != 0)
				{
				}
				num = (short)744095744;
				short num3 = num;
				num = (short)1354956800;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159;
			}
		}

		// Token: 0x17006156 RID: 24918
		// (get) Token: 0x0600C2AE RID: 49838 RVA: 0x00B6D408 File Offset: 0x00B6B608
		// (set) Token: 0x0600C2AF RID: 49839 RVA: 0x00B6D4BC File Offset: 0x00B6B6BC
		public bool CnvPerAGAGKeySel_A40159_Applicable
		{
			get
			{
				short num = (short)1009796356;
				short num2 = num;
				num = (short)2005222660;
				switch (num2 == num)
				{
				}
				num = (short)725942273;
				if (num != 0)
				{
				}
				num = (short)76939264;
				short num3 = num;
				num = (short)495583232;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.Applicable;
			}
			set
			{
				short num = (short)3014657;
				if (num != 0)
				{
				}
				num = (short)651009439;
				short num2 = num;
				num = (short)1491508639;
				switch (num2 == num)
				{
				}
				num = (short)1873346560;
				short num3 = num;
				num = (short)1615986688;
				if (num != 0)
				{
				}
				this.cnvPerAGAGKeySel_A40159.Applicable = value;
			}
		}

		// Token: 0x17006157 RID: 24919
		// (get) Token: 0x0600C2B0 RID: 49840 RVA: 0x00B6D570 File Offset: 0x00B6B770
		// (set) Token: 0x0600C2B1 RID: 49841 RVA: 0x00B6D624 File Offset: 0x00B6B824
		public bool CnvPerAGAGKeySel_A40159_Valid
		{
			get
			{
				short num = (short)1693508890;
				short num2 = num;
				num = (short)584312090;
				switch (num2 == num)
				{
				}
				num = (short)1348337664;
				if (num != 0)
				{
				}
				num = (short)2135425024;
				short num3 = num;
				num = (short)309133313;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.Valid;
			}
			set
			{
				short num = (short)200577802;
				short num2 = num;
				num = (short)536253194;
				switch (num2 == num)
				{
				}
				num = (short)827129856;
				if (num != 0)
				{
				}
				num = (short)2105278464;
				short num3 = num;
				num = (short)1387003905;
				if (num != 0)
				{
				}
				this.cnvPerAGAGKeySel_A40159.Valid = value;
			}
		}

		// Token: 0x17006158 RID: 24920
		// (get) Token: 0x0600C2B2 RID: 49842 RVA: 0x00B6D6D8 File Offset: 0x00B6B8D8
		// (set) Token: 0x0600C2B3 RID: 49843 RVA: 0x00B6D78C File Offset: 0x00B6B98C
		public bool CnvPerAGAGKeySel_A40159_Visible
		{
			get
			{
				short num = (short)890472709;
				short num2 = num;
				num = (short)1522829573;
				switch (num2 == num)
				{
				}
				num = (short)1341521921;
				if (num != 0)
				{
				}
				num = (short)1974796288;
				short num3 = num;
				num = (short)879755264;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.Visible;
			}
			set
			{
				short num = (short)1942528498;
				short num2 = num;
				num = (short)1142923762;
				switch (num2 == num)
				{
				}
				num = (short)154992640;
				if (num != 0)
				{
				}
				num = (short)1606811648;
				short num3 = num;
				num = (short)766312449;
				if (num != 0)
				{
				}
				this.cnvPerAGAGKeySel_A40159.Visible = value;
			}
		}

		// Token: 0x17006159 RID: 24921
		// (get) Token: 0x0600C2B4 RID: 49844 RVA: 0x00B6D840 File Offset: 0x00B6BA40
		// (set) Token: 0x0600C2B5 RID: 49845 RVA: 0x00B6D8F8 File Offset: 0x00B6BAF8
		public bool CnvPerAGAGKeySel_A40159_Editable
		{
			get
			{
				short num = (short)247919026;
				short num2 = num;
				num = (short)1812394418;
				switch (num2 == num)
				{
				}
				num = (short)1111031809;
				if (num != 0)
				{
				}
				num = (short)703004672;
				short num3 = num;
				num = (short)1107230720;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.Editable;
			}
			set
			{
				short num = (short)419527688;
				short num2 = num;
				num = (short)1073052680;
				switch (num2 == num)
				{
				}
				num = (short)345047041;
				if (num != 0)
				{
				}
				num = (short)1605959680;
				short num3 = num;
				num = (short)606339072;
				if (num != 0)
				{
				}
				this.cnvPerAGAGKeySel_A40159.Editable = value;
			}
		}

		// Token: 0x1700615A RID: 24922
		// (get) Token: 0x0600C2B6 RID: 49846 RVA: 0x00B6D9AC File Offset: 0x00B6BBAC
		internal string CnvPerAGAGKeySel_A40159_UILabel
		{
			get
			{
				short num = (short)2081442002;
				short num2 = num;
				num = (short)1342654674;
				switch (num2 == num)
				{
				}
				num = (short)407175168;
				if (num != 0)
				{
				}
				num = (short)1580204032;
				short num3 = num;
				num = (short)490733569;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.UIName;
			}
		}

		// Token: 0x1700615B RID: 24923
		// (get) Token: 0x0600C2B7 RID: 49847 RVA: 0x00B6DA60 File Offset: 0x00B6BC60
		// (set) Token: 0x0600C2B8 RID: 49848 RVA: 0x00B6DB14 File Offset: 0x00B6BD14
		internal bool CnvPerAGAGKeySel_A40159_HiddenStatic
		{
			get
			{
				short num = (short)1448503193;
				short num2 = num;
				num = (short)1922656153;
				switch (num2 == num)
				{
				}
				num = (short)418316288;
				if (num != 0)
				{
				}
				num = (short)1939079168;
				short num3 = num;
				num = (short)946601985;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.HiddenStatic;
			}
			set
			{
				short num = (short)1677580475;
				short num2 = num;
				num = (short)255318203;
				switch (num2 == num)
				{
				}
				num = (short)1867382785;
				if (num != 0)
				{
				}
				num = (short)275775488;
				short num3 = num;
				num = (short)330366976;
				if (num != 0)
				{
				}
				this.cnvPerAGAGKeySel_A40159.HiddenStatic = value;
			}
		}

		// Token: 0x1700615C RID: 24924
		// (get) Token: 0x0600C2B9 RID: 49849 RVA: 0x00B6DBCC File Offset: 0x00B6BDCC
		// (set) Token: 0x0600C2BA RID: 49850 RVA: 0x00B6DC84 File Offset: 0x00B6BE84
		internal bool CnvPerAGAGKeySel_A40159_HiddenDynamic
		{
			get
			{
				short num = (short)1439709479;
				short num2 = num;
				num = (short)314128679;
				switch (num2 == num)
				{
				}
				num = (short)76218369;
				if (num != 0)
				{
				}
				num = (short)1456734208;
				short num3 = num;
				num = (short)481427456;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159.HiddenDynamic;
			}
			set
			{
				short num = (short)889454593;
				if (num != 0)
				{
				}
				num = (short)924944247;
				short num2 = num;
				num = (short)1397065591;
				switch (num2 == num)
				{
				}
				num = (short)668073984;
				short num3 = num;
				num = (short)582418432;
				if (num != 0)
				{
				}
				this.cnvPerAGAGKeySel_A40159.HiddenDynamic = value;
			}
		}

		// Token: 0x1700615D RID: 24925
		// (get) Token: 0x0600C2BB RID: 49851 RVA: 0x00B6DD3C File Offset: 0x00B6BF3C
		public bool CnvPerAGAGKeySel_A40159_HasDiffs
		{
			get
			{
				short num = (short)1244643115;
				short num2 = num;
				num = (short)438550315;
				switch (num2 == num)
				{
				}
				num = (short)182648833;
				if (num != 0)
				{
				}
				num = (short)74645504;
				short num3 = num;
				num = (short)1898840064;
				if (num != 0)
				{
				}
				return this.cnvPerAGAGKeySel_A40159._HasDiffs;
			}
		}

		// Token: 0x1700615E RID: 24926
		// (get) Token: 0x0600C2BC RID: 49852 RVA: 0x00B6DDF0 File Offset: 0x00B6BFF0
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1335885825;
				if (num != 0)
				{
				}
				num = (short)707878782;
				short num2 = num;
				num = (short)569597822;
				switch (num2 == num)
				{
				}
				num = (short)1359478784;
				short num3 = num;
				num = (short)1829699584;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x00B6DEB0 File Offset: 0x00B6C0B0
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
					num2 = (short)374407169;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)939786242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					return result;
				case 2:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)937361408;
					short num3 = num2;
					num2 = (short)178126849;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					for (;;)
					{
						num2 = (short)128390918;
						short num4 = num2;
						num2 = (short)153491206;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_EA;
						}
					}
					IL_EA:
					num2 = (short)293994496;
					if (num2 != 0)
					{
					}
					num2 = (short)919994368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)154075139;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1978925060;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400646D RID: 25709
		private global::AcpBusinessLayer.AcpCustomRangeField cnvPerAGAGWACNID_A40155;

		// Token: 0x0400646E RID: 25710
		private global::AcpBusinessLayer.AcpCustomRangeField cnvPerAGAGSysID_A40156;

		// Token: 0x0400646F RID: 25711
		private global::AcpBusinessLayer.AcpCustomRangeField cnvPerAGAGTalkgroupID_A40157;

		// Token: 0x04006470 RID: 25712
		private global::AcpBusinessLayer.AcpListField cnvPerAGAGSecStrap_A40158;

		// Token: 0x04006471 RID: 25713
		private global::AcpBusinessLayer.AcpRecRefField cnvPerAGAGKeySel_A40159;
	}
}
