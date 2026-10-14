using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000577 RID: 1399
	[global::System.Serializable]
	public class Secure : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600BEEA RID: 48874 RVA: 0x00B04D24 File Offset: 0x00B02F24
		public Secure(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600BEEB RID: 48875 RVA: 0x00B04D40 File Offset: 0x00B02F40
		protected Secure(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600BEEC RID: 48876 RVA: 0x00B04D58 File Offset: 0x00B02F58
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1730937253;
			short num2 = num;
			num = (short)1486225829;
			switch (num2 == num)
			{
			}
			num = (short)1928527872;
			short num3 = num;
			num = (short)376635393;
			if (num != 0)
			{
			}
			num = (short)915865600;
			if (num != 0)
			{
			}
			this.cnvSysSecureKMFProfIndex_A40132 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金뫓ꃕ诗ꏙ꿛距藟臡釣铥跧ꇩꇫ꣭ꃯ胱鯳郵뇷铹飻鯽磿崁䔃㈅㠇㬉㼋㰍", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_DISABLED
			}, new int[1], true, false, new string[]
			{
				global::CommonResources.AcgResources.ID_KMFPROFILEINDEX
			});
			this.cnvSysSecureKMFProfIndex_A40132.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysSecureKMFProfIndex_A40132.DataTransferOrder = 60;
			this.cnvSysSecureKMFProfIndex_A40132.EvaluateRecRefs = true;
			this.cnvSysSecureDynTGKeySel_A40133 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金뫓ꃕ诗ꏙ꿛距藟臡釣铥跧껩闫胭ꓯ뗱뿳鏵臷꧹駻鋽忿䌁〃㘅㤇㤉㼋", a_), global::CommonResources.AcgResources.ID_DYNAMICTALKGROUPKEYSELECT, null, null, true, false);
			this.cnvSysSecureDynTGKeySel_A40133.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysSecureDynTGKeySel_A40133.DataTransferOrder = 67;
			this.cnvSysSecureFSKeySel_A40134 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金뫓ꃕ诗ꏙ꿛距藟臡釣铥跧곩뿫ꗭ闯诱ꟳ鏵铷ꗹ뷻쫽ヿ㌁㜃㈅", a_), global::CommonResources.AcgResources.ID_FAILSOFTKEYSELECT, null, null, true, false);
			this.cnvSysSecureFSKeySel_A40134.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysSecureFSKeySel_A40134.DataTransferOrder = 68;
			this.cnvSysSecureInterConnectKeySel_A40135 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金뫓ꃕ诗ꏙ꿛距藟臡釣铥跧ꏩ苫髭闯胱럳駵雷铹駻鷽瓿䤁愃缅嬇漉怋儍儏☑␓✕⬗⼙", a_), global::CommonResources.AcgResources.ID_INTERCONNECTKEYSELECT, null, null, true, false);
			this.cnvSysSecureInterConnectKeySel_A40135.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysSecureInterConnectKeySel_A40135.DataTransferOrder = 66;
			this.cnvSysSecurePatchKeySel_A40136 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金뫓ꃕ诗ꏙ꿛距藟臡釣铥跧뫩跫髭鏯髱뿳鏵臷꧹駻鋽忿䌁〃㘅㤇㤉㨋", a_), global::CommonResources.AcgResources.ID_PATCHKEYSELECT, null, null, true, false);
			this.cnvSysSecurePatchKeySel_A40136.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysSecurePatchKeySel_A40136.DataTransferOrder = 62;
			this.cnvSysSecurePrivateCallKeySel_A40137 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("金뫓ꃕ诗ꏙ꿛距藟臡釣铥跧뫩黫蟭蛯鏱胳鏵믷鯹郻鋽䯿朁紃唅洇昉匋伍␏∑┓┕⼗", a_), global::CommonResources.AcgResources.ID_PRIVATECALLKEYSELECT, null, null, true, false);
			this.cnvSysSecurePrivateCallKeySel_A40137.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvSysSecurePrivateCallKeySel_A40137.DataTransferOrder = 65;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臑뇓뗕귗꣙맛", a_);
			base.Id = 10644;
			base.UIName = global::CommonResources.AcgResources.ID_SECURE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600BEED RID: 48877 RVA: 0x00B04FCC File Offset: 0x00B031CC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)668729350;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					this.cnvSysSecureFSKeySel_A40134 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥껧맩꟫语觯ꇱ釳髵ꟷ믹죻컽ㇿ㄁〃", a_), global::CommonResources.AcgResources.ID_FAILSOFTKEYSELECT, null, null, true, false);
					this.cnvSysSecureFSKeySel_A40134.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysSecureFSKeySel_A40134.DataTransferOrder = 68;
					num = (short)1739840544;
					short num3 = num;
					num = (short)357882912;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3F4;
					default:
						num = (short)388366336;
						if (num != 0)
						{
						}
						num = (short)1883111436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_21D;
				case 2:
					if (producerFields != null)
					{
						num = (short)2000617482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58A;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥룧飩藫飭釯蛱釳뗵駷雹郻뗽旿笁圃挅搇唉䴋㨍‏⌑✓ℕ", a_)))
					{
						num = (short)2032336917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58A;
				case 4:
					goto IL_38B;
				case 5:
					this.cnvSysSecureInterConnectKeySel_A40135 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥ꇧ蓩飫语苯뇱鯳飵雷鿹鿻諽䯿朁紃唅洇昉匋伍␏∑┓┕ⴗ", a_), global::CommonResources.AcgResources.ID_INTERCONNECTKEYSELECT, null, null, true, false);
					this.cnvSysSecureInterConnectKeySel_A40135.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysSecureInterConnectKeySel_A40135.DataTransferOrder = 66;
					num = (short)401342473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 7:
					this.cnvSysSecureKMFProfIndex_A40132 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥ꏧ꟩ꫫ뻭苯鷱鋳뿵雷黹駻蛽忿䌁〃㘅㤇㤉㸋", a_), global::CommonResources.AcgResources.ID_ASTROOTARPROFILEINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_DISABLED
					}, new int[1], true, false, new string[]
					{
						global::CommonResources.AcgResources.ID_KMFPROFILEINDEX
					});
					this.cnvSysSecureKMFProfIndex_A40132.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysSecureKMFProfIndex_A40132.DataTransferOrder = 60;
					this.cnvSysSecureKMFProfIndex_A40132.EvaluateRecRefs = true;
					num = (short)1143275528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_3DD;
				case 9:
					goto IL_A8;
				case 10:
					num = (short)1123221515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥ꏧ꟩ꫫ뻭苯鷱鋳뿵雷黹駻蛽忿䌁〃㘅㤇㤉㸋", a_)))
					{
						num = (short)451411975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 12:
					goto IL_47F;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥껧맩꟫语觯ꇱ釳髵ꟷ믹죻컽ㇿ㄁〃", a_)))
					{
						num = (short)1112145920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_47F;
				case 14:
					goto IL_390;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥룧诩飫跭飯맱釳迵꯷鿹郻ꇽ䇿㘁㐃㜅㬇㰉", a_)))
					{
						num = (short)1060306961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21D;
				case 16:
					this.cnvSysSecureDynTGKeySel_A40133 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥곧鏩苫뫭럯맱釳迵꯷鿹郻ꇽ䇿㘁㐃㜅㬇㤉", a_), global::CommonResources.AcgResources.ID_DYNAMICTALKGROUPKEYSELECT, null, null, true, false);
					this.cnvSysSecureDynTGKeySel_A40133.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysSecureDynTGKeySel_A40133.DataTransferOrder = 67;
					num = (short)1953103873;
					if (num != 0)
					{
					}
					num = (short)1556152334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.cnvSysSecurePatchKeySel_A40136 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥룧诩飫跭飯맱釳迵꯷鿹郻ꇽ䇿㘁㐃㜅㬇㰉", a_), global::CommonResources.AcgResources.ID_PATCHKEYSELECT, null, null, true, false);
					this.cnvSysSecurePatchKeySel_A40136.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysSecurePatchKeySel_A40136.DataTransferOrder = 62;
					num = (short)687800321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_3F4;
				case 19:
					num = (short)1116012546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥ꇧ蓩飫语苯뇱鯳飵雷鿹鿻諽䯿朁紃唅洇昉匋伍␏∑┓┕ⴗ", a_)))
					{
						num = (short)1064173573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A8;
				case 21:
					this.cnvSysSecurePrivateCallKeySel_A40137 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥룧飩藫飭釯蛱釳뗵駷雹郻뗽旿笁圃挅搇唉䴋㨍‏⌑✓ℕ", a_), global::CommonResources.AcgResources.ID_PRIVATECALLKEYSELECT, null, null, true, false);
					this.cnvSysSecurePrivateCallKeySel_A40137.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvSysSecurePrivateCallKeySel_A40137.DataTransferOrder = 65;
					num = (short)586219524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_85:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1569521683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A8:
				num = (short)894566415;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21D:
				num = (short)1336213504;
				short num4 = num;
				num = (short)431095811;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_390:
				num = (short)1452474381;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F4:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꋓ藕ꇗ꧙进믝菟韡難菥곧鏩苫뫭럯맱釳迵꯷鿹郻ꇽ䇿㘁㐃㜅㬇㤉", a_)))
				{
					num = (short)742719504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_390;
				IL_3DD:
				num = (short)2012610578;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_47F:
				num = (short)1134100500;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_38B:
			IL_58A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菏럑럓ꏕ꫗뿙", a_);
			base.Id = 10644;
			base.UIName = global::CommonResources.AcgResources.ID_SECURE;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x00B05594 File Offset: 0x00B03794
		public override void PopulateReferences()
		{
			short num = (short)1817903104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				for (;;)
				{
					IL_29:
					bool? flag;
					bool flag2;
					bool? flag3;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)750190600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					}
					case 1:
						num = (short)1945960455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)2045313024;
							short num3 = num;
							num = (short)1555103753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					case 3:
						goto IL_1DF;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = this.cnvSysSecureKMFProfIndex_A40132.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)468516864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (this.cnvSysSecureKMFProfIndex_A40132.Value > 0)
						{
							num = (short)581173249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					case 6:
					{
						bool? flag4;
						flag3 = flag4;
						goto IL_260;
					}
					case 7:
						if (this.cnvSysSecureKMFProfIndex_A40132.ReferencedNode != null)
						{
							num = (short)1218052100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D7;
					case 8:
						num = (short)491192330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						embeddedRecset = secureKMFProfile.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
						num = (short)1811611651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)496957936;
						short num4 = num;
						num = (short)1572993520;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1735393280;
							if (num != 0)
							{
							}
							num = (short)2125725697;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = secureKMFProfile.General;
							if (general == null)
							{
								bool? flag4 = null;
								num = (short)1348861958;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag3 = new bool?(general.SecKmfProfGenIndependentKeyList_43597.Value);
							goto IL_260;
						}
						}
						break;
					}
					}
					goto IL_5C;
					IL_260:
					flag = flag3;
					flag2 = true;
					num = (short)55115778;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DF:
				IL_2D7:
				this.cnvSysSecureDynTGKeySel_A40133.SetRecset(embeddedRecset);
				this.cnvSysSecureFSKeySel_A40134.SetRecset(embeddedRecset);
				this.cnvSysSecureInterConnectKeySel_A40135.SetRecset(embeddedRecset);
				this.cnvSysSecurePatchKeySel_A40136.SetRecset(embeddedRecset);
				this.cnvSysSecurePrivateCallKeySel_A40137.SetRecset(embeddedRecset);
				return;
				IL_5C:
				this.cnvSysSecureKMFProfIndex_A40132.SetRecset(this.a(2055));
				embeddedRecset = this.a(2021)[0][10040].EmbeddedRecset;
				num = (short)1817051141;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x00B058B4 File Offset: 0x00B03AB4
		public override void DropReferences()
		{
			short num = (short)1342056924;
			short num2 = num;
			num = (short)552151516;
			switch (num2 == num)
			{
			}
			num = (short)1519386625;
			if (num != 0)
			{
			}
			num = (short)679215104;
			if (num != 0)
			{
			}
			num = (short)686424064;
			short num3 = num;
		}

		// Token: 0x0600BEF0 RID: 48880 RVA: 0x00B05960 File Offset: 0x00B03B60
		public override void SetConstraints()
		{
			short num = (short)519438337;
			if (num != 0)
			{
			}
			num = (short)206595359;
			short num2 = num;
			num = (short)1836213535;
			switch (num2 == num)
			{
			}
			num = (short)559349760;
			if (num != 0)
			{
			}
			num = (short)1519648768;
			short num3 = num;
			this.cnvSysSecureKMFProfIndex_A40132.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSecKmfProfileEnAstroOtarOtarEmcEqpdExtIsEnableAndCfgSecTypeIsHW);
			this.cnvSysSecureKMFProfIndex_A40132.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysSecureDynTGKeySel_A40133.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConDynTlkGrpAndMultiKeyAndHWOrADP);
			this.cnvSysSecureDynTGKeySel_A40133.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvDVRSKeyValid);
			this.cnvSysSecureDynTGKeySel_A40133.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysSecureFSKeySel_A40134.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRSWithSecure);
			this.cnvSysSecureFSKeySel_A40134.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvDVRSKeyValid);
			this.cnvSysSecureFSKeySel_A40134.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysSecureInterConnectKeySel_A40135.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRSWithSecure);
			this.cnvSysSecureInterConnectKeySel_A40135.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvDVRSKeyValid);
			this.cnvSysSecureInterConnectKeySel_A40135.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysSecurePatchKeySel_A40136.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRSWithSecure);
			this.cnvSysSecurePatchKeySel_A40136.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvDVRSKeyValid);
			this.cnvSysSecurePatchKeySel_A40136.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
			this.cnvSysSecurePrivateCallKeySel_A40137.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRSWithSecure);
			this.cnvSysSecurePrivateCallKeySel_A40137.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConCnvDVRSKeyValid);
			this.cnvSysSecurePrivateCallKeySel_A40137.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemConstraints.ConSystemTypeIsDVRS);
		}

		// Token: 0x0600BEF1 RID: 48881 RVA: 0x00B05B90 File Offset: 0x00B03D90
		public override void SetupDependencies()
		{
			short num = (short)48298616;
			short num2 = num;
			num = (short)1122433656;
			switch (num2 == num)
			{
			}
			num = (short)608108545;
			if (num != 0)
			{
			}
			num = (short)713293824;
			if (num != 0)
			{
			}
			num = (short)1870004224;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysSecureKMFProfIndex_A40132);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvSysSecureKMFProfIndex_A40132);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvSysSecureKMFProfIndex_A40132);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvSysSecureKMFProfIndex_A40132);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvSysSecureKMFProfIndex_A40132);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysSecureDynTGKeySel_A40133);
			conventionalSystem.DVRS.CnvSysFeatureDynRegroupEn_A40146.AddDependentObject(this.cnvSysSecureDynTGKeySel_A40133);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvSysSecureDynTGKeySel_A40133);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvSysSecureDynTGKeySel_A40133);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvSysSecureDynTGKeySel_A40133);
			this.cnvSysSecureKMFProfIndex_A40132.AddDependentObject(this.cnvSysSecureDynTGKeySel_A40133);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvSysSecureDynTGKeySel_A40133);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvSysSecureDynTGKeySel_A40133);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysSecureFSKeySel_A40134);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvSysSecureFSKeySel_A40134);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvSysSecureFSKeySel_A40134);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvSysSecureFSKeySel_A40134);
			this.cnvSysSecureKMFProfIndex_A40132.AddDependentObject(this.cnvSysSecureFSKeySel_A40134);
			this.cnvSysSecureDynTGKeySel_A40133.AddDependentObject(this.cnvSysSecureFSKeySel_A40134);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvSysSecureFSKeySel_A40134);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvSysSecureFSKeySel_A40134);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysSecureInterConnectKeySel_A40135);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvSysSecureInterConnectKeySel_A40135);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvSysSecureInterConnectKeySel_A40135);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvSysSecureInterConnectKeySel_A40135);
			this.cnvSysSecureKMFProfIndex_A40132.AddDependentObject(this.cnvSysSecureInterConnectKeySel_A40135);
			this.cnvSysSecureDynTGKeySel_A40133.AddDependentObject(this.cnvSysSecureInterConnectKeySel_A40135);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvSysSecureInterConnectKeySel_A40135);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvSysSecureInterConnectKeySel_A40135);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysSecurePatchKeySel_A40136);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvSysSecurePatchKeySel_A40136);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvSysSecurePatchKeySel_A40136);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvSysSecurePatchKeySel_A40136);
			this.cnvSysSecureKMFProfIndex_A40132.AddDependentObject(this.cnvSysSecurePatchKeySel_A40136);
			this.cnvSysSecureDynTGKeySel_A40133.AddDependentObject(this.cnvSysSecurePatchKeySel_A40136);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvSysSecurePatchKeySel_A40136);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvSysSecurePatchKeySel_A40136);
			conventionalSystem.General.CnvSysGeneralSystemType_A13262.AddDependentObject(this.cnvSysSecurePrivateCallKeySel_A40137);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.cnvSysSecurePrivateCallKeySel_A40137);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.cnvSysSecurePrivateCallKeySel_A40137);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.cnvSysSecurePrivateCallKeySel_A40137);
			this.cnvSysSecureKMFProfIndex_A40132.AddDependentObject(this.cnvSysSecurePrivateCallKeySel_A40137);
			this.cnvSysSecureDynTGKeySel_A40133.AddDependentObject(this.cnvSysSecurePrivateCallKeySel_A40137);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.cnvSysSecurePrivateCallKeySel_A40137);
			this.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.cnvSysSecurePrivateCallKeySel_A40137);
		}

		// Token: 0x17005FD8 RID: 24536
		// (get) Token: 0x0600BEF2 RID: 48882 RVA: 0x00B060B4 File Offset: 0x00B042B4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile SecureKMFProfileForCnvSysSecureKMFProfIndex_A40132
		{
			get
			{
				short num = (short)214218117;
				short num2 = num;
				num = (short)20624773;
				switch (num2 == num)
				{
				}
				num = (short)724238337;
				if (num != 0)
				{
				}
				num = (short)264830976;
				if (num != 0)
				{
				}
				num = (short)1858535424;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
			}
		}

		// Token: 0x17005FD9 RID: 24537
		// (get) Token: 0x0600BEF3 RID: 48883 RVA: 0x00B06170 File Offset: 0x00B04370
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvSysSecureDynTGKeySel_A40133
		{
			get
			{
				short num = (short)324570970;
				short num2 = num;
				num = (short)1055297370;
				switch (num2 == num)
				{
				}
				num = (short)1421672448;
				if (num != 0)
				{
				}
				num = (short)1963458561;
				if (num != 0)
				{
				}
				num = (short)1945370624;
				short num3 = num;
				return this.cnvSysSecureDynTGKeySel_A40133.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17005FDA RID: 24538
		// (get) Token: 0x0600BEF4 RID: 48884 RVA: 0x00B0622C File Offset: 0x00B0442C
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvSysSecureFSKeySel_A40134
		{
			get
			{
				short num = (short)695468033;
				if (num != 0)
				{
				}
				num = (short)1669263279;
				short num2 = num;
				num = (short)174059439;
				switch (num2 == num)
				{
				}
				num = (short)593231872;
				if (num != 0)
				{
				}
				num = (short)1410334720;
				short num3 = num;
				return this.cnvSysSecureFSKeySel_A40134.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17005FDB RID: 24539
		// (get) Token: 0x0600BEF5 RID: 48885 RVA: 0x00B062E8 File Offset: 0x00B044E8
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvSysSecureInterConnectKeySel_A40135
		{
			get
			{
				short num = (short)1152689102;
				short num2 = num;
				num = (short)597009358;
				switch (num2 == num)
				{
				}
				num = (short)1766719489;
				if (num != 0)
				{
				}
				num = (short)897843200;
				if (num != 0)
				{
				}
				num = (short)445251584;
				short num3 = num;
				return this.cnvSysSecureInterConnectKeySel_A40135.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17005FDC RID: 24540
		// (get) Token: 0x0600BEF6 RID: 48886 RVA: 0x00B063A0 File Offset: 0x00B045A0
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvSysSecurePatchKeySel_A40136
		{
			get
			{
				short num = (short)814470283;
				short num2 = num;
				num = (short)1159451787;
				switch (num2 == num)
				{
				}
				num = (short)416284673;
				if (num != 0)
				{
				}
				num = (short)918421504;
				if (num != 0)
				{
				}
				num = (short)1749417984;
				short num3 = num;
				return this.cnvSysSecurePatchKeySel_A40136.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17005FDD RID: 24541
		// (get) Token: 0x0600BEF7 RID: 48887 RVA: 0x00B0645C File Offset: 0x00B0465C
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForCnvSysSecurePrivateCallKeySel_A40137
		{
			get
			{
				short num = (short)2030980980;
				short num2 = num;
				num = (short)1489915764;
				switch (num2 == num)
				{
				}
				num = (short)1385627648;
				if (num != 0)
				{
				}
				num = (short)419037185;
				if (num != 0)
				{
				}
				num = (short)1194000384;
				short num3 = num;
				return this.cnvSysSecurePrivateCallKeySel_A40137.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17005FDE RID: 24542
		// (get) Token: 0x0600BEF8 RID: 48888 RVA: 0x00B06514 File Offset: 0x00B04714
		public bool HasDiffs
		{
			get
			{
				short num = (short)2092716527;
				short num2 = num;
				num = (short)1343246831;
				switch (num2 == num)
				{
				}
				num = (short)584122369;
				if (num != 0)
				{
				}
				num = (short)1667432448;
				if (num != 0)
				{
				}
				num = (short)697499648;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17005FDF RID: 24543
		// (get) Token: 0x0600BEF9 RID: 48889 RVA: 0x00B065C4 File Offset: 0x00B047C4
		// (set) Token: 0x0600BEFA RID: 48890 RVA: 0x00B0667C File Offset: 0x00B0487C
		public int CnvSysSecureKMFProfIndex_A40132Value
		{
			get
			{
				short num = (short)403447625;
				short num2 = num;
				num = (short)701439817;
				switch (num2 == num)
				{
				}
				num = (short)1732444161;
				if (num != 0)
				{
				}
				num = (short)567672832;
				if (num != 0)
				{
				}
				num = (short)329580544;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.Value;
			}
			set
			{
				short num = (short)826808039;
				short num2 = num;
				num = (short)2080839399;
				switch (num2 == num)
				{
				}
				num = (short)1104805888;
				if (num != 0)
				{
				}
				num = (short)1634861057;
				if (num != 0)
				{
				}
				num = (short)112525312;
				short num3 = num;
				this.cnvSysSecureKMFProfIndex_A40132.Value = value;
			}
		}

		// Token: 0x17005FE0 RID: 24544
		// (get) Token: 0x0600BEFB RID: 48891 RVA: 0x00B06734 File Offset: 0x00B04934
		// (set) Token: 0x0600BEFC RID: 48892 RVA: 0x00B067E8 File Offset: 0x00B049E8
		public string CnvSysSecureKMFProfIndex_A40132_UIValue
		{
			get
			{
				short num = (short)1030815745;
				if (num != 0)
				{
				}
				num = (short)489949557;
				short num2 = num;
				num = (short)66128245;
				switch (num2 == num)
				{
				}
				num = (short)451739648;
				if (num != 0)
				{
				}
				num = (short)1470693376;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.UIValue;
			}
			set
			{
				short num = (short)197837766;
				short num2 = num;
				num = (short)280675270;
				switch (num2 == num)
				{
				}
				num = (short)1373306881;
				if (num != 0)
				{
				}
				num = (short)1418199040;
				if (num != 0)
				{
				}
				num = (short)564461568;
				short num3 = num;
				this.cnvSysSecureKMFProfIndex_A40132.UIValue = value;
			}
		}

		// Token: 0x17005FE1 RID: 24545
		// (get) Token: 0x0600BEFD RID: 48893 RVA: 0x00B068A0 File Offset: 0x00B04AA0
		public global::AcpBusinessLayer.AcpRecRefField CnvSysSecureKMFProfIndex_A40132
		{
			get
			{
				short num = (short)1576424044;
				short num2 = num;
				num = (short)1877365356;
				switch (num2 == num)
				{
				}
				num = (short)1790377985;
				if (num != 0)
				{
				}
				num = (short)329318400;
				if (num != 0)
				{
				}
				num = (short)1125646336;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132;
			}
		}

		// Token: 0x17005FE2 RID: 24546
		// (get) Token: 0x0600BEFE RID: 48894 RVA: 0x00B06950 File Offset: 0x00B04B50
		// (set) Token: 0x0600BEFF RID: 48895 RVA: 0x00B06A04 File Offset: 0x00B04C04
		public bool CnvSysSecureKMFProfIndex_A40132_Applicable
		{
			get
			{
				short num = (short)952676036;
				short num2 = num;
				num = (short)368946884;
				switch (num2 == num)
				{
				}
				num = (short)708837377;
				if (num != 0)
				{
				}
				num = (short)966721536;
				if (num != 0)
				{
				}
				num = (short)588251136;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.Applicable;
			}
			set
			{
				short num = (short)1963481916;
				short num2 = num;
				num = (short)1563319100;
				switch (num2 == num)
				{
				}
				num = (short)853934081;
				if (num != 0)
				{
				}
				num = (short)179503104;
				if (num != 0)
				{
				}
				num = (short)327417856;
				short num3 = num;
				this.cnvSysSecureKMFProfIndex_A40132.Applicable = value;
			}
		}

		// Token: 0x17005FE3 RID: 24547
		// (get) Token: 0x0600BF00 RID: 48896 RVA: 0x00B06AB8 File Offset: 0x00B04CB8
		// (set) Token: 0x0600BF01 RID: 48897 RVA: 0x00B06B6C File Offset: 0x00B04D6C
		public bool CnvSysSecureKMFProfIndex_A40132_Valid
		{
			get
			{
				short num = (short)1396140257;
				short num2 = num;
				num = (short)1794730209;
				switch (num2 == num)
				{
				}
				num = (short)717291521;
				if (num != 0)
				{
				}
				num = (short)1540096000;
				if (num != 0)
				{
				}
				num = (short)506527744;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.Valid;
			}
			set
			{
				short num = (short)1336388409;
				short num2 = num;
				num = (short)741452601;
				switch (num2 == num)
				{
				}
				num = (short)573243393;
				if (num != 0)
				{
				}
				num = (short)412745728;
				if (num != 0)
				{
				}
				num = (short)368181248;
				short num3 = num;
				this.cnvSysSecureKMFProfIndex_A40132.Valid = value;
			}
		}

		// Token: 0x17005FE4 RID: 24548
		// (get) Token: 0x0600BF02 RID: 48898 RVA: 0x00B06C24 File Offset: 0x00B04E24
		// (set) Token: 0x0600BF03 RID: 48899 RVA: 0x00B06CD8 File Offset: 0x00B04ED8
		public bool CnvSysSecureKMFProfIndex_A40132_Visible
		{
			get
			{
				short num = (short)1567447291;
				short num2 = num;
				num = (short)1765955835;
				switch (num2 == num)
				{
				}
				num = (short)444858369;
				if (num != 0)
				{
				}
				num = (short)1579614208;
				if (num != 0)
				{
				}
				num = (short)189005824;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.Visible;
			}
			set
			{
				short num = (short)349733265;
				short num2 = num;
				num = (short)2034925969;
				switch (num2 == num)
				{
				}
				num = (short)2006384640;
				if (num != 0)
				{
				}
				num = (short)270139393;
				if (num != 0)
				{
				}
				num = (short)1056112640;
				short num3 = num;
				this.cnvSysSecureKMFProfIndex_A40132.Visible = value;
			}
		}

		// Token: 0x17005FE5 RID: 24549
		// (get) Token: 0x0600BF04 RID: 48900 RVA: 0x00B06D8C File Offset: 0x00B04F8C
		// (set) Token: 0x0600BF05 RID: 48901 RVA: 0x00B06E44 File Offset: 0x00B05044
		public bool CnvSysSecureKMFProfIndex_A40132_Editable
		{
			get
			{
				short num = (short)533109894;
				short num2 = num;
				num = (short)1762827398;
				switch (num2 == num)
				{
				}
				num = (short)1444610048;
				if (num != 0)
				{
				}
				num = (short)394788865;
				if (num != 0)
				{
				}
				num = (short)1509228544;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.Editable;
			}
			set
			{
				short num = (short)107061483;
				short num2 = num;
				num = (short)1504485611;
				switch (num2 == num)
				{
				}
				num = (short)835518465;
				if (num != 0)
				{
				}
				num = (short)714539008;
				if (num != 0)
				{
				}
				num = (short)319422464;
				short num3 = num;
				this.cnvSysSecureKMFProfIndex_A40132.Editable = value;
			}
		}

		// Token: 0x17005FE6 RID: 24550
		// (get) Token: 0x0600BF06 RID: 48902 RVA: 0x00B06EF8 File Offset: 0x00B050F8
		internal string CnvSysSecureKMFProfIndex_A40132_UILabel
		{
			get
			{
				short num = (short)587462585;
				short num2 = num;
				num = (short)1493956537;
				switch (num2 == num)
				{
				}
				num = (short)1429078016;
				if (num != 0)
				{
				}
				num = (short)730136577;
				if (num != 0)
				{
				}
				num = (short)1608646656;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.UIName;
			}
		}

		// Token: 0x17005FE7 RID: 24551
		// (get) Token: 0x0600BF07 RID: 48903 RVA: 0x00B06FAC File Offset: 0x00B051AC
		// (set) Token: 0x0600BF08 RID: 48904 RVA: 0x00B07060 File Offset: 0x00B05260
		internal bool CnvSysSecureKMFProfIndex_A40132_HiddenStatic
		{
			get
			{
				short num = (short)145111724;
				short num2 = num;
				num = (short)1814182572;
				switch (num2 == num)
				{
				}
				num = (short)658571264;
				if (num != 0)
				{
				}
				num = (short)1481637889;
				if (num != 0)
				{
				}
				num = (short)1149435904;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.HiddenStatic;
			}
			set
			{
				short num = (short)1877865069;
				short num2 = num;
				num = (short)1808200301;
				switch (num2 == num)
				{
				}
				num = (short)1750007809;
				if (num != 0)
				{
				}
				num = (short)1535836160;
				if (num != 0)
				{
				}
				num = (short)429195264;
				short num3 = num;
				this.cnvSysSecureKMFProfIndex_A40132.HiddenStatic = value;
			}
		}

		// Token: 0x17005FE8 RID: 24552
		// (get) Token: 0x0600BF09 RID: 48905 RVA: 0x00B07118 File Offset: 0x00B05318
		// (set) Token: 0x0600BF0A RID: 48906 RVA: 0x00B071CC File Offset: 0x00B053CC
		internal bool CnvSysSecureKMFProfIndex_A40132_HiddenDynamic
		{
			get
			{
				short num = (short)1961662495;
				short num2 = num;
				num = (short)1410111519;
				switch (num2 == num)
				{
				}
				num = (short)1054539777;
				if (num != 0)
				{
				}
				num = (short)639238144;
				if (num != 0)
				{
				}
				num = (short)487522304;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132.HiddenDynamic;
			}
			set
			{
				short num = (short)2121964794;
				short num2 = num;
				num = (short)381525242;
				switch (num2 == num)
				{
				}
				num = (short)1201274881;
				if (num != 0)
				{
				}
				num = (short)184942592;
				if (num != 0)
				{
				}
				num = (short)209584128;
				short num3 = num;
				this.cnvSysSecureKMFProfIndex_A40132.HiddenDynamic = value;
			}
		}

		// Token: 0x17005FE9 RID: 24553
		// (get) Token: 0x0600BF0B RID: 48907 RVA: 0x00B07280 File Offset: 0x00B05480
		public bool CnvSysSecureKMFProfIndex_A40132_HasDiffs
		{
			get
			{
				short num = (short)1005559029;
				short num2 = num;
				num = (short)1636605173;
				switch (num2 == num)
				{
				}
				num = (short)391184385;
				if (num != 0)
				{
				}
				num = (short)864747520;
				if (num != 0)
				{
				}
				num = (short)1937178624;
				short num3 = num;
				return this.cnvSysSecureKMFProfIndex_A40132._HasDiffs;
			}
		}

		// Token: 0x17005FEA RID: 24554
		// (get) Token: 0x0600BF0C RID: 48908 RVA: 0x00B07338 File Offset: 0x00B05538
		// (set) Token: 0x0600BF0D RID: 48909 RVA: 0x00B073EC File Offset: 0x00B055EC
		public int CnvSysSecureDynTGKeySel_A40133Value
		{
			get
			{
				short num = (short)801130789;
				short num2 = num;
				num = (short)1864845605;
				switch (num2 == num)
				{
				}
				num = (short)1792212993;
				if (num != 0)
				{
				}
				num = (short)1221001216;
				if (num != 0)
				{
				}
				num = (short)741801984;
				short num3 = num;
				return this.cnvSysSecureDynTGKeySel_A40133.Value;
			}
			set
			{
				short num = (short)273403796;
				short num2 = num;
				num = (short)1084018580;
				switch (num2 == num)
				{
				}
				num = (short)861339648;
				if (num != 0)
				{
				}
				num = (short)728629249;
				if (num != 0)
				{
				}
				num = (short)1179123712;
				short num3 = num;
				this.cnvSysSecureDynTGKeySel_A40133.Value = value;
			}
		}

		// Token: 0x17005FEB RID: 24555
		// (get) Token: 0x0600BF0E RID: 48910 RVA: 0x00B074A4 File Offset: 0x00B056A4
		// (set) Token: 0x0600BF0F RID: 48911 RVA: 0x00B0755C File Offset: 0x00B0575C
		public string CnvSysSecureDynTGKeySel_A40133_UIValue
		{
			get
			{
				short num = (short)2024354614;
				short num2 = num;
				num = (short)2070623030;
				switch (num2 == num)
				{
				}
				num = (short)1152647169;
				if (num != 0)
				{
				}
				num = (short)56885248;
				if (num != 0)
				{
				}
				num = (short)435945472;
				short num3 = num;
				return this.cnvSysSecureDynTGKeySel_A40133.UIValue;
			}
			set
			{
				short num = (short)841573125;
				short num2 = num;
				num = (short)507470597;
				switch (num2 == num)
				{
				}
				num = (short)94699521;
				if (num != 0)
				{
				}
				num = (short)237699072;
				if (num != 0)
				{
				}
				num = (short)674889728;
				short num3 = num;
				this.cnvSysSecureDynTGKeySel_A40133.UIValue = value;
			}
		}

		// Token: 0x17005FEC RID: 24556
		// (get) Token: 0x0600BF10 RID: 48912 RVA: 0x00B07614 File Offset: 0x00B05814
		public global::AcpBusinessLayer.AcpRecRefField CnvSysSecureDynTGKeySel_A40133
		{
			get
			{
				short num = (short)733610447;
				short num2 = num;
				num = (short)1507721679;
				switch (num2 == num)
				{
				}
				num = (short)705757185;
				if (num != 0)
				{
				}
				num = (short)1465319424;
				if (num != 0)
				{
				}
				num = (short)242352128;
				short num3 = num;
				return this.cnvSysSecureDynTGKeySel_A40133;
			}
		}

		// Token: 0x17005FED RID: 24557
		// (get) Token: 0x0600BF11 RID: 48913 RVA: 0x00B076C8 File Offset: 0x00B058C8
		// (set) Token: 0x0600BF12 RID: 48914 RVA: 0x00B0777C File Offset: 0x00B0597C
		public bool CnvSysSecureDynTGKeySel_A40133_Applicable
		{
			get
			{
				short num = (short)177070651;
				short num2 = num;
				num = (short)2107105851;
				switch (num2 == num)
				{
				}
				num = (short)836894721;
				if (num != 0)
				{
				}
				num = (short)1264386048;
				if (num != 0)
				{
				}
				num = (short)25886720;
				short num3 = num;
				return this.cnvSysSecureDynTGKeySel_A40133.Applicable;
			}
			set
			{
				short num = (short)910894925;
				short num2 = num;
				num = (short)34481997;
				switch (num2 == num)
				{
				}
				num = (short)2056519681;
				if (num != 0)
				{
				}
				num = (short)1781006336;
				if (num != 0)
				{
				}
				num = (short)1411514368;
				short num3 = num;
				this.cnvSysSecureDynTGKeySel_A40133.Applicable = value;
			}
		}

		// Token: 0x17005FEE RID: 24558
		// (get) Token: 0x0600BF13 RID: 48915 RVA: 0x00B07834 File Offset: 0x00B05A34
		// (set) Token: 0x0600BF14 RID: 48916 RVA: 0x00B078E8 File Offset: 0x00B05AE8
		public bool CnvSysSecureDynTGKeySel_A40133_Valid
		{
			get
			{
				short num = (short)726002013;
				short num2 = num;
				num = (short)1060628829;
				switch (num2 == num)
				{
				}
				num = (short)2059862017;
				if (num != 0)
				{
				}
				num = (short)30277632;
				if (num != 0)
				{
				}
				num = (short)583467008;
				short num3 = num;
				return this.cnvSysSecureDynTGKeySel_A40133.Valid;
			}
			set
			{
				short num = (short)333774849;
				if (num != 0)
				{
				}
				num = (short)1917088949;
				short num2 = num;
				num = (short)1212511413;
				switch (num2 == num)
				{
				}
				num = (short)1866727424;
				if (num != 0)
				{
				}
				num = (short)43646976;
				short num3 = num;
				this.cnvSysSecureDynTGKeySel_A40133.Valid = value;
			}
		}

		// Token: 0x17005FEF RID: 24559
		// (get) Token: 0x0600BF15 RID: 48917 RVA: 0x00B0799C File Offset: 0x00B05B9C
		// (set) Token: 0x0600BF16 RID: 48918 RVA: 0x00B07A50 File Offset: 0x00B05C50
		public bool CnvSysSecureDynTGKeySel_A40133_Visible
		{
			get
			{
				short num = (short)1636293680;
				short num2 = num;
				num = (short)1223679024;
				switch (num2 == num)
				{
				}
				num = (short)1109655552;
				if (num != 0)
				{
				}
				num = (short)868548609;
				if (num != 0)
				{
				}
				num = (short)3407872;
				short num3 = num;
				return this.cnvSysSecureDynTGKeySel_A40133.Visible;
			}
			set
			{
				short num = (short)1435055790;
				short num2 = num;
				num = (short)537605806;
				switch (num2 == num)
				{
				}
				num = (short)1643839488;
				if (num != 0)
				{
				}
				num = (short)1814822913;
				if (num != 0)
				{
				}
				num = (short)1996816384;
				short num3 = num;
				this.cnvSysSecureDynTGKeySel_A40133.Visible = value;
			}
		}

		// Token: 0x17005FF0 RID: 24560
		// (get) Token: 0x0600BF17 RID: 48919 RVA: 0x00B07B08 File Offset: 0x00B05D08
		// (set) Token: 0x0600BF18 RID: 48920 RVA: 0x00B07BC0 File Offset: 0x00B05DC0
		public bool CnvSysSecureDynTGKeySel_A40133_Editable
		{
			get
			{
				short num = (short)24686017;
				short num2 = num;
				num = (short)927575489;
				switch (num2 == num)
				{
				default:
				{
					num = (short)809697280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)135004160;
				if (num != 0)
				{
				}
				num = (short)353828865;
				if (num != 0)
				{
				}
				return this.cnvSysSecureDynTGKeySel_A40133.Editable;
			}
			set
			{
				short num = (short)643050916;
				short num2 = num;
				num = (short)640298404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277165568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1245446145;
				if (num != 0)
				{
				}
				num = (short)852164608;
				if (num != 0)
				{
				}
				this.cnvSysSecureDynTGKeySel_A40133.Editable = value;
			}
		}

		// Token: 0x17005FF1 RID: 24561
		// (get) Token: 0x0600BF19 RID: 48921 RVA: 0x00B07C74 File Offset: 0x00B05E74
		internal string CnvSysSecureDynTGKeySel_A40133_UILabel
		{
			get
			{
				short num = (short)1422589953;
				if (num != 0)
				{
				}
				num = (short)637534208;
				short num2 = num;
				num = (short)1160820196;
				short num3 = num;
				num = (short)1538635236;
				switch (num3 == num)
				{
				}
				num = (short)1794113536;
				if (num != 0)
				{
				}
				return this.cnvSysSecureDynTGKeySel_A40133.UIName;
			}
		}

		// Token: 0x17005FF2 RID: 24562
		// (get) Token: 0x0600BF1A RID: 48922 RVA: 0x00B07D2C File Offset: 0x00B05F2C
		// (set) Token: 0x0600BF1B RID: 48923 RVA: 0x00B07DE4 File Offset: 0x00B05FE4
		internal bool CnvSysSecureDynTGKeySel_A40133_HiddenStatic
		{
			get
			{
				short num = (short)1299825069;
				short num2 = num;
				num = (short)1674625453;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1857814528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)600834049;
				if (num != 0)
				{
				}
				num = (short)59899904;
				if (num != 0)
				{
				}
				return this.cnvSysSecureDynTGKeySel_A40133.HiddenStatic;
			}
			set
			{
				short num = (short)666753222;
				short num2 = num;
				num = (short)1659033798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)150732800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109014017;
				if (num != 0)
				{
				}
				num = (short)649068544;
				if (num != 0)
				{
				}
				this.cnvSysSecureDynTGKeySel_A40133.HiddenStatic = value;
			}
		}

		// Token: 0x17005FF3 RID: 24563
		// (get) Token: 0x0600BF1C RID: 48924 RVA: 0x00B07E9C File Offset: 0x00B0609C
		// (set) Token: 0x0600BF1D RID: 48925 RVA: 0x00B07F4C File Offset: 0x00B0614C
		internal bool CnvSysSecureDynTGKeySel_A40133_HiddenDynamic
		{
			get
			{
				short num = (short)1555384216;
				short num2 = num;
				num = (short)1368606616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2129788928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)555155457;
				if (num != 0)
				{
				}
				num = (short)1839333376;
				if (num != 0)
				{
				}
				return this.cnvSysSecureDynTGKeySel_A40133.HiddenDynamic;
			}
			set
			{
				short num = (short)2051927500;
				short num2 = num;
				num = (short)2015948236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1498218496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)767164417;
				if (num != 0)
				{
				}
				num = (short)777584640;
				if (num != 0)
				{
				}
				this.cnvSysSecureDynTGKeySel_A40133.HiddenDynamic = value;
			}
		}

		// Token: 0x17005FF4 RID: 24564
		// (get) Token: 0x0600BF1E RID: 48926 RVA: 0x00B08000 File Offset: 0x00B06200
		public bool CnvSysSecureDynTGKeySel_A40133_HasDiffs
		{
			get
			{
				short num = (short)1791737970;
				short num2 = num;
				num = (short)2039922802;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363528192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981204992;
				if (num != 0)
				{
				}
				num = (short)121372673;
				if (num != 0)
				{
				}
				return this.cnvSysSecureDynTGKeySel_A40133._HasDiffs;
			}
		}

		// Token: 0x17005FF5 RID: 24565
		// (get) Token: 0x0600BF1F RID: 48927 RVA: 0x00B080B8 File Offset: 0x00B062B8
		// (set) Token: 0x0600BF20 RID: 48928 RVA: 0x00B08168 File Offset: 0x00B06368
		public int CnvSysSecureFSKeySel_A40134Value
		{
			get
			{
				short num = (short)1283722711;
				short num2 = num;
				num = (short)106892759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438842880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)694943745;
				if (num != 0)
				{
				}
				num = (short)1608908800;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.Value;
			}
			set
			{
				short num = (short)645637490;
				short num2 = num;
				num = (short)1249944946;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1213005824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409744897;
				if (num != 0)
				{
				}
				num = (short)1938751488;
				if (num != 0)
				{
				}
				this.cnvSysSecureFSKeySel_A40134.Value = value;
			}
		}

		// Token: 0x17005FF6 RID: 24566
		// (get) Token: 0x0600BF21 RID: 48929 RVA: 0x00B08220 File Offset: 0x00B06420
		// (set) Token: 0x0600BF22 RID: 48930 RVA: 0x00B082D8 File Offset: 0x00B064D8
		public string CnvSysSecureFSKeySel_A40134_UIValue
		{
			get
			{
				short num = (short)1586833509;
				short num2 = num;
				num = (short)1136207973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)912392192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)414842880;
				if (num != 0)
				{
				}
				num = (short)769458177;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.UIValue;
			}
			set
			{
				short num = (short)1908768464;
				short num2 = num;
				num = (short)1175092944;
				switch (num2 == num)
				{
				default:
				{
					num = (short)708640768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1355350017;
				if (num != 0)
				{
				}
				num = (short)1089863680;
				if (num != 0)
				{
				}
				this.cnvSysSecureFSKeySel_A40134.UIValue = value;
			}
		}

		// Token: 0x17005FF7 RID: 24567
		// (get) Token: 0x0600BF23 RID: 48931 RVA: 0x00B08390 File Offset: 0x00B06590
		public global::AcpBusinessLayer.AcpRecRefField CnvSysSecureFSKeySel_A40134
		{
			get
			{
				short num = (short)2125092460;
				short num2 = num;
				num = (short)1430410860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036334592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)42205185;
				if (num != 0)
				{
				}
				num = (short)548732928;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134;
			}
		}

		// Token: 0x17005FF8 RID: 24568
		// (get) Token: 0x0600BF24 RID: 48932 RVA: 0x00B08440 File Offset: 0x00B06640
		// (set) Token: 0x0600BF25 RID: 48933 RVA: 0x00B084F4 File Offset: 0x00B066F4
		public bool CnvSysSecureFSKeySel_A40134_Applicable
		{
			get
			{
				short num = (short)1035174693;
				short num2 = num;
				num = (short)1696432933;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1095106560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1803616257;
				if (num != 0)
				{
				}
				num = (short)1257373696;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.Applicable;
			}
			set
			{
				short num = (short)931756126;
				short num2 = num;
				num = (short)558397534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1757020160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)14548993;
				if (num != 0)
				{
				}
				num = (short)69599232;
				if (num != 0)
				{
				}
				this.cnvSysSecureFSKeySel_A40134.Applicable = value;
			}
		}

		// Token: 0x17005FF9 RID: 24569
		// (get) Token: 0x0600BF26 RID: 48934 RVA: 0x00B085A8 File Offset: 0x00B067A8
		// (set) Token: 0x0600BF27 RID: 48935 RVA: 0x00B0865C File Offset: 0x00B0685C
		public bool CnvSysSecureFSKeySel_A40134_Valid
		{
			get
			{
				short num = (short)1202818389;
				short num2 = num;
				num = (short)258116949;
				switch (num2 == num)
				{
				default:
				{
					num = (short)517341184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1880621057;
				if (num != 0)
				{
				}
				num = (short)1027080192;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.Valid;
			}
			set
			{
				short num = (short)290636852;
				short num2 = num;
				num = (short)643351604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)681967616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1124270080;
				if (num != 0)
				{
				}
				num = (short)2075328513;
				if (num != 0)
				{
				}
				this.cnvSysSecureFSKeySel_A40134.Valid = value;
			}
		}

		// Token: 0x17005FFA RID: 24570
		// (get) Token: 0x0600BF28 RID: 48936 RVA: 0x00B08714 File Offset: 0x00B06914
		// (set) Token: 0x0600BF29 RID: 48937 RVA: 0x00B087CC File Offset: 0x00B069CC
		public bool CnvSysSecureFSKeySel_A40134_Visible
		{
			get
			{
				short num = (short)1244594879;
				short num2 = num;
				num = (short)312672959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824311808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307443200;
				if (num != 0)
				{
				}
				num = (short)1884356609;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.Visible;
			}
			set
			{
				short num = (short)1316125401;
				short num2 = num;
				num = (short)479689433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)345964544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804271616;
				if (num != 0)
				{
				}
				num = (short)103481345;
				if (num != 0)
				{
				}
				this.cnvSysSecureFSKeySel_A40134.Visible = value;
			}
		}

		// Token: 0x17005FFB RID: 24571
		// (get) Token: 0x0600BF2A RID: 48938 RVA: 0x00B08884 File Offset: 0x00B06A84
		// (set) Token: 0x0600BF2B RID: 48939 RVA: 0x00B08938 File Offset: 0x00B06B38
		public bool CnvSysSecureFSKeySel_A40134_Editable
		{
			get
			{
				short num = (short)2014485740;
				short num2 = num;
				num = (short)1115528428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)581763072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)471203840;
				if (num != 0)
				{
				}
				num = (short)894042113;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.Editable;
			}
			set
			{
				short num = (short)2024101776;
				short num2 = num;
				num = (short)188241808;
				switch (num2 == num)
				{
				default:
				{
					num = (short)762380288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)925040640;
				if (num != 0)
				{
				}
				num = (short)1456996353;
				if (num != 0)
				{
				}
				this.cnvSysSecureFSKeySel_A40134.Editable = value;
			}
		}

		// Token: 0x17005FFC RID: 24572
		// (get) Token: 0x0600BF2C RID: 48940 RVA: 0x00B089EC File Offset: 0x00B06BEC
		internal string CnvSysSecureFSKeySel_A40134_UILabel
		{
			get
			{
				short num = (short)1001588435;
				short num2 = num;
				num = (short)247269075;
				switch (num2 == num)
				{
				default:
				{
					num = (short)272826368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141388800;
				if (num != 0)
				{
				}
				num = (short)1294270465;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.UIName;
			}
		}

		// Token: 0x17005FFD RID: 24573
		// (get) Token: 0x0600BF2D RID: 48941 RVA: 0x00B08AA0 File Offset: 0x00B06CA0
		// (set) Token: 0x0600BF2E RID: 48942 RVA: 0x00B08B58 File Offset: 0x00B06D58
		internal bool CnvSysSecureFSKeySel_A40134_HiddenStatic
		{
			get
			{
				short num = (short)1973368725;
				short num2 = num;
				num = (short)1352087445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)434307072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)190382080;
				if (num != 0)
				{
				}
				num = (short)229376001;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.HiddenStatic;
			}
			set
			{
				short num = (short)1109722702;
				short num2 = num;
				num = (short)632424014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458096640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)935329793;
				if (num != 0)
				{
				}
				num = (short)1383137280;
				if (num != 0)
				{
				}
				this.cnvSysSecureFSKeySel_A40134.HiddenStatic = value;
			}
		}

		// Token: 0x17005FFE RID: 24574
		// (get) Token: 0x0600BF2F RID: 48943 RVA: 0x00B08C10 File Offset: 0x00B06E10
		// (set) Token: 0x0600BF30 RID: 48944 RVA: 0x00B08CC4 File Offset: 0x00B06EC4
		internal bool CnvSysSecureFSKeySel_A40134_HiddenDynamic
		{
			get
			{
				short num = (short)677282394;
				short num2 = num;
				num = (short)108560986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721958400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575799297;
				if (num != 0)
				{
				}
				num = (short)1559429120;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134.HiddenDynamic;
			}
			set
			{
				short num = (short)451865619;
				short num2 = num;
				num = (short)690220051;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1721499648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)542965760;
				if (num != 0)
				{
				}
				num = (short)1218445313;
				if (num != 0)
				{
				}
				this.cnvSysSecureFSKeySel_A40134.HiddenDynamic = value;
			}
		}

		// Token: 0x17005FFF RID: 24575
		// (get) Token: 0x0600BF31 RID: 48945 RVA: 0x00B08D7C File Offset: 0x00B06F7C
		public bool CnvSysSecureFSKeySel_A40134_HasDiffs
		{
			get
			{
				short num = (short)1529787362;
				short num2 = num;
				num = (short)787788770;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1197211648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883752960;
				if (num != 0)
				{
				}
				num = (short)1120862209;
				if (num != 0)
				{
				}
				return this.cnvSysSecureFSKeySel_A40134._HasDiffs;
			}
		}

		// Token: 0x17006000 RID: 24576
		// (get) Token: 0x0600BF32 RID: 48946 RVA: 0x00B08E30 File Offset: 0x00B07030
		// (set) Token: 0x0600BF33 RID: 48947 RVA: 0x00B08EE4 File Offset: 0x00B070E4
		public int CnvSysSecureInterConnectKeySel_A40135Value
		{
			get
			{
				short num = (short)1771702181;
				short num2 = num;
				num = (short)1295255461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1574567936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1042677761;
				if (num != 0)
				{
				}
				num = (short)847577088;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.Value;
			}
			set
			{
				short num = (short)380166538;
				short num2 = num;
				num = (short)1571742090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)892731392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1962541057;
				if (num != 0)
				{
				}
				num = (short)1434976256;
				if (num != 0)
				{
				}
				this.cnvSysSecureInterConnectKeySel_A40135.Value = value;
			}
		}

		// Token: 0x17006001 RID: 24577
		// (get) Token: 0x0600BF34 RID: 48948 RVA: 0x00B08F9C File Offset: 0x00B0719C
		// (set) Token: 0x0600BF35 RID: 48949 RVA: 0x00B09054 File Offset: 0x00B07254
		public string CnvSysSecureInterConnectKeySel_A40135_UIValue
		{
			get
			{
				short num = (short)1317404673;
				if (num != 0)
				{
				}
				num = (short)822804480;
				short num2 = num;
				num = (short)1476406047;
				short num3 = num;
				num = (short)565127967;
				switch (num3 == num)
				{
				}
				num = (short)530841600;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.UIValue;
			}
			set
			{
				short num = (short)782237697;
				if (num != 0)
				{
				}
				num = (short)1304494080;
				short num2 = num;
				num = (short)305579367;
				short num3 = num;
				num = (short)424723815;
				switch (num3 == num)
				{
				}
				num = (short)1546452992;
				if (num != 0)
				{
				}
				this.cnvSysSecureInterConnectKeySel_A40135.UIValue = value;
			}
		}

		// Token: 0x17006002 RID: 24578
		// (get) Token: 0x0600BF36 RID: 48950 RVA: 0x00B09108 File Offset: 0x00B07308
		public global::AcpBusinessLayer.AcpRecRefField CnvSysSecureInterConnectKeySel_A40135
		{
			get
			{
				short num = (short)906552967;
				short num2 = num;
				num = (short)462153351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)450101248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1079902209;
				if (num != 0)
				{
				}
				num = (short)596049920;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135;
			}
		}

		// Token: 0x17006003 RID: 24579
		// (get) Token: 0x0600BF37 RID: 48951 RVA: 0x00B091B4 File Offset: 0x00B073B4
		// (set) Token: 0x0600BF38 RID: 48952 RVA: 0x00B0926C File Offset: 0x00B0746C
		public bool CnvSysSecureInterConnectKeySel_A40135_Applicable
		{
			get
			{
				short num = (short)1794280625;
				short num2 = num;
				num = (short)1045269681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)761004032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)873136129;
				if (num != 0)
				{
				}
				num = (short)292552704;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.Applicable;
			}
			set
			{
				short num = (short)2031842442;
				short num2 = num;
				num = (short)1242789002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)785973248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1969553409;
				if (num != 0)
				{
				}
				num = (short)2020081664;
				if (num != 0)
				{
				}
				this.cnvSysSecureInterConnectKeySel_A40135.Applicable = value;
			}
		}

		// Token: 0x17006004 RID: 24580
		// (get) Token: 0x0600BF39 RID: 48953 RVA: 0x00B09324 File Offset: 0x00B07524
		// (set) Token: 0x0600BF3A RID: 48954 RVA: 0x00B093D8 File Offset: 0x00B075D8
		public bool CnvSysSecureInterConnectKeySel_A40135_Valid
		{
			get
			{
				short num = (short)973253434;
				short num2 = num;
				num = (short)1737796410;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1256062976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)239009793;
				if (num != 0)
				{
				}
				num = (short)590610432;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.Valid;
			}
			set
			{
				short num = (short)1554076653;
				short num2 = num;
				num = (short)2053592045;
				switch (num2 == num)
				{
				default:
				{
					num = (short)396230656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1906442241;
				if (num != 0)
				{
				}
				num = (short)83361792;
				if (num != 0)
				{
				}
				this.cnvSysSecureInterConnectKeySel_A40135.Valid = value;
			}
		}

		// Token: 0x17006005 RID: 24581
		// (get) Token: 0x0600BF3B RID: 48955 RVA: 0x00B09490 File Offset: 0x00B07690
		// (set) Token: 0x0600BF3C RID: 48956 RVA: 0x00B09548 File Offset: 0x00B07748
		public bool CnvSysSecureInterConnectKeySel_A40135_Visible
		{
			get
			{
				short num = (short)1753147042;
				short num2 = num;
				num = (short)1673455266;
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
				num = (short)605749248;
				if (num != 0)
				{
				}
				num = (short)301662209;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.Visible;
			}
			set
			{
				short num = (short)1687814145;
				if (num != 0)
				{
				}
				num = (short)579010560;
				short num2 = num;
				num = (short)1665326909;
				short num3 = num;
				num = (short)406970173;
				switch (num3 == num)
				{
				}
				num = (short)922484736;
				if (num != 0)
				{
				}
				this.cnvSysSecureInterConnectKeySel_A40135.Visible = value;
			}
		}

		// Token: 0x17006006 RID: 24582
		// (get) Token: 0x0600BF3D RID: 48957 RVA: 0x00B095FC File Offset: 0x00B077FC
		// (set) Token: 0x0600BF3E RID: 48958 RVA: 0x00B096B0 File Offset: 0x00B078B0
		public bool CnvSysSecureInterConnectKeySel_A40135_Editable
		{
			get
			{
				short num = (short)222437106;
				short num2 = num;
				num = (short)1825971954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)204537856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)322109441;
				if (num != 0)
				{
				}
				num = (short)1076232192;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.Editable;
			}
			set
			{
				short num = (short)1808400384;
				short num2 = num;
				num = (short)1273426707;
				short num3 = num;
				num = (short)1399583507;
				switch (num3 == num)
				{
				}
				num = (short)1156055041;
				if (num != 0)
				{
				}
				num = (short)1552678912;
				if (num != 0)
				{
				}
				this.cnvSysSecureInterConnectKeySel_A40135.Editable = value;
			}
		}

		// Token: 0x17006007 RID: 24583
		// (get) Token: 0x0600BF3F RID: 48959 RVA: 0x00B09764 File Offset: 0x00B07964
		internal string CnvSysSecureInterConnectKeySel_A40135_UILabel
		{
			get
			{
				short num = (short)1543110656;
				short num2 = num;
				num = (short)789251233;
				short num3 = num;
				num = (short)23987361;
				switch (num3 == num)
				{
				}
				num = (short)56688641;
				if (num != 0)
				{
				}
				num = (short)499908608;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.UIName;
			}
		}

		// Token: 0x17006008 RID: 24584
		// (get) Token: 0x0600BF40 RID: 48960 RVA: 0x00B09818 File Offset: 0x00B07A18
		// (set) Token: 0x0600BF41 RID: 48961 RVA: 0x00B098CC File Offset: 0x00B07ACC
		internal bool CnvSysSecureInterConnectKeySel_A40135_HiddenStatic
		{
			get
			{
				short num = (short)1782317056;
				short num2 = num;
				num = (short)1000724397;
				short num3 = num;
				num = (short)184342445;
				switch (num3 == num)
				{
				}
				num = (short)1281753089;
				if (num != 0)
				{
				}
				num = (short)1825308672;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.HiddenStatic;
			}
			set
			{
				short num = (short)119668736;
				short num2 = num;
				num = (short)745472001;
				if (num != 0)
				{
				}
				num = (short)697012003;
				short num3 = num;
				num = (short)774672163;
				switch (num3 == num)
				{
				}
				num = (short)539885568;
				if (num != 0)
				{
				}
				this.cnvSysSecureInterConnectKeySel_A40135.HiddenStatic = value;
			}
		}

		// Token: 0x17006009 RID: 24585
		// (get) Token: 0x0600BF42 RID: 48962 RVA: 0x00B09980 File Offset: 0x00B07B80
		// (set) Token: 0x0600BF43 RID: 48963 RVA: 0x00B09A34 File Offset: 0x00B07C34
		internal bool CnvSysSecureInterConnectKeySel_A40135_HiddenDynamic
		{
			get
			{
				short num = (short)67239936;
				short num2 = num;
				num = (short)690943875;
				short num3 = num;
				num = (short)1845294979;
				switch (num3 == num)
				{
				}
				num = (short)1661468672;
				if (num != 0)
				{
				}
				num = (short)1451622401;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135.HiddenDynamic;
			}
			set
			{
				short num = (short)1862664192;
				short num2 = num;
				num = (short)1814044863;
				short num3 = num;
				num = (short)1370366143;
				switch (num3 == num)
				{
				}
				num = (short)346882049;
				if (num != 0)
				{
				}
				num = (short)1406664704;
				if (num != 0)
				{
				}
				this.cnvSysSecureInterConnectKeySel_A40135.HiddenDynamic = value;
			}
		}

		// Token: 0x1700600A RID: 24586
		// (get) Token: 0x0600BF44 RID: 48964 RVA: 0x00B09AE8 File Offset: 0x00B07CE8
		public bool CnvSysSecureInterConnectKeySel_A40135_HasDiffs
		{
			get
			{
				short num = (short)1111031808;
				short num2 = num;
				num = (short)384127172;
				short num3 = num;
				num = (short)1247826116;
				switch (num3 == num)
				{
				}
				num = (short)1403518977;
				if (num != 0)
				{
				}
				num = (short)1774518272;
				if (num != 0)
				{
				}
				return this.cnvSysSecureInterConnectKeySel_A40135._HasDiffs;
			}
		}

		// Token: 0x1700600B RID: 24587
		// (get) Token: 0x0600BF45 RID: 48965 RVA: 0x00B09BA0 File Offset: 0x00B07DA0
		// (set) Token: 0x0600BF46 RID: 48966 RVA: 0x00B09C54 File Offset: 0x00B07E54
		public int CnvSysSecurePatchKeySel_A40136Value
		{
			get
			{
				short num = (short)1479737344;
				short num2 = num;
				num = (short)420863178;
				short num3 = num;
				num = (short)1603525834;
				switch (num3 == num)
				{
				}
				num = (short)584843264;
				if (num != 0)
				{
				}
				num = (short)950665217;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.Value;
			}
			set
			{
				short num = (short)1382678528;
				short num2 = num;
				num = (short)2044321760;
				short num3 = num;
				num = (short)1492639712;
				switch (num3 == num)
				{
				}
				num = (short)1263730689;
				if (num != 0)
				{
				}
				num = (short)1036976128;
				if (num != 0)
				{
				}
				this.cnvSysSecurePatchKeySel_A40136.Value = value;
			}
		}

		// Token: 0x1700600C RID: 24588
		// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x00B09D0C File Offset: 0x00B07F0C
		// (set) Token: 0x0600BF48 RID: 48968 RVA: 0x00B09DC0 File Offset: 0x00B07FC0
		public string CnvSysSecurePatchKeySel_A40136_UIValue
		{
			get
			{
				short num = (short)1261109248;
				short num2 = num;
				num = (short)1699217409;
				if (num != 0)
				{
				}
				num = (short)487885169;
				short num3 = num;
				num = (short)411535729;
				switch (num3 == num)
				{
				}
				num = (short)2035613696;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.UIValue;
			}
			set
			{
				short num = (short)598736896;
				short num2 = num;
				num = (short)733500646;
				short num3 = num;
				num = (short)1231967462;
				switch (num3 == num)
				{
				}
				num = (short)735313921;
				if (num != 0)
				{
				}
				num = (short)560332800;
				if (num != 0)
				{
				}
				this.cnvSysSecurePatchKeySel_A40136.UIValue = value;
			}
		}

		// Token: 0x1700600D RID: 24589
		// (get) Token: 0x0600BF49 RID: 48969 RVA: 0x00B09E74 File Offset: 0x00B08074
		public global::AcpBusinessLayer.AcpRecRefField CnvSysSecurePatchKeySel_A40136
		{
			get
			{
				short num = (short)1436352512;
				short num2 = num;
				num = (short)1331061529;
				short num3 = num;
				num = (short)239624985;
				switch (num3 == num)
				{
				}
				num = (short)1410859008;
				if (num != 0)
				{
				}
				num = (short)395640833;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136;
			}
		}

		// Token: 0x1700600E RID: 24590
		// (get) Token: 0x0600BF4A RID: 48970 RVA: 0x00B09F24 File Offset: 0x00B08124
		// (set) Token: 0x0600BF4B RID: 48971 RVA: 0x00B09FDC File Offset: 0x00B081DC
		public bool CnvSysSecurePatchKeySel_A40136_Applicable
		{
			get
			{
				short num = (short)133169152;
				short num2 = num;
				num = (short)855107229;
				short num3 = num;
				num = (short)2055988893;
				switch (num3 == num)
				{
				}
				num = (short)509018113;
				if (num != 0)
				{
				}
				num = (short)903872512;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.Applicable;
			}
			set
			{
				short num = (short)1108279296;
				short num2 = num;
				num = (short)1296628187;
				short num3 = num;
				num = (short)637794779;
				switch (num3 == num)
				{
				}
				num = (short)1382154241;
				if (num != 0)
				{
				}
				num = (short)752287744;
				if (num != 0)
				{
				}
				this.cnvSysSecurePatchKeySel_A40136.Applicable = value;
			}
		}

		// Token: 0x1700600F RID: 24591
		// (get) Token: 0x0600BF4C RID: 48972 RVA: 0x00B0A090 File Offset: 0x00B08290
		// (set) Token: 0x0600BF4D RID: 48973 RVA: 0x00B0A144 File Offset: 0x00B08344
		public bool CnvSysSecurePatchKeySel_A40136_Valid
		{
			get
			{
				short num = (short)1821573120;
				short num2 = num;
				num = (short)1022427137;
				if (num != 0)
				{
				}
				num = (short)400506691;
				short num3 = num;
				num = (short)1384202051;
				switch (num3 == num)
				{
				}
				num = (short)930611200;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.Valid;
			}
			set
			{
				short num = (short)1618542592;
				short num2 = num;
				num = (short)998244353;
				if (num != 0)
				{
				}
				num = (short)1672470302;
				short num3 = num;
				num = (short)636673822;
				switch (num3 == num)
				{
				}
				num = (short)1996095488;
				if (num != 0)
				{
				}
				this.cnvSysSecurePatchKeySel_A40136.Valid = value;
			}
		}

		// Token: 0x17006010 RID: 24592
		// (get) Token: 0x0600BF4E RID: 48974 RVA: 0x00B0A1FC File Offset: 0x00B083FC
		// (set) Token: 0x0600BF4F RID: 48975 RVA: 0x00B0A2B0 File Offset: 0x00B084B0
		public bool CnvSysSecurePatchKeySel_A40136_Visible
		{
			get
			{
				short num = (short)925892608;
				short num2 = num;
				num = (short)458489857;
				if (num != 0)
				{
				}
				num = (short)701146861;
				short num3 = num;
				num = (short)391161581;
				switch (num3 == num)
				{
				}
				num = (short)2126118912;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.Visible;
			}
			set
			{
				short num = (short)783351808;
				short num2 = num;
				num = (short)1798698510;
				short num3 = num;
				num = (short)122680846;
				switch (num3 == num)
				{
				}
				num = (short)159121409;
				if (num != 0)
				{
				}
				num = (short)904134656;
				if (num != 0)
				{
				}
				this.cnvSysSecurePatchKeySel_A40136.Visible = value;
			}
		}

		// Token: 0x17006011 RID: 24593
		// (get) Token: 0x0600BF50 RID: 48976 RVA: 0x00B0A364 File Offset: 0x00B08564
		// (set) Token: 0x0600BF51 RID: 48977 RVA: 0x00B0A418 File Offset: 0x00B08618
		public bool CnvSysSecurePatchKeySel_A40136_Editable
		{
			get
			{
				short num = (short)405667840;
				short num2 = num;
				num = (short)648654741;
				short num3 = num;
				num = (short)103722901;
				switch (num3 == num)
				{
				}
				num = (short)1140588545;
				if (num != 0)
				{
				}
				num = (short)39059456;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.Editable;
			}
			set
			{
				short num = (short)1120272384;
				short num2 = num;
				num = (short)502218578;
				short num3 = num;
				num = (short)1439579986;
				switch (num3 == num)
				{
				}
				num = (short)2122907649;
				if (num != 0)
				{
				}
				num = (short)2130378752;
				if (num != 0)
				{
				}
				this.cnvSysSecurePatchKeySel_A40136.Editable = value;
			}
		}

		// Token: 0x17006012 RID: 24594
		// (get) Token: 0x0600BF52 RID: 48978 RVA: 0x00B0A4D0 File Offset: 0x00B086D0
		internal string CnvSysSecurePatchKeySel_A40136_UILabel
		{
			get
			{
				short num = (short)501481472;
				short num2 = num;
				num = (short)313715891;
				short num3 = num;
				num = (short)697035955;
				switch (num3 == num)
				{
				}
				num = (short)486866945;
				if (num != 0)
				{
				}
				num = (short)678100992;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.UIName;
			}
		}

		// Token: 0x17006013 RID: 24595
		// (get) Token: 0x0600BF53 RID: 48979 RVA: 0x00B0A584 File Offset: 0x00B08784
		// (set) Token: 0x0600BF54 RID: 48980 RVA: 0x00B0A638 File Offset: 0x00B08838
		internal bool CnvSysSecurePatchKeySel_A40136_HiddenStatic
		{
			get
			{
				short num = (short)2019426304;
				short num2 = num;
				num = (short)1667339190;
				short num3 = num;
				num = (short)228561846;
				switch (num3 == num)
				{
				}
				num = (short)170065920;
				if (num != 0)
				{
				}
				num = (short)1118633985;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.HiddenStatic;
			}
			set
			{
				short num = (short)70647808;
				short num2 = num;
				num = (short)1791747622;
				short num3 = num;
				num = (short)1870915110;
				switch (num3 == num)
				{
				}
				num = (short)1735983105;
				if (num != 0)
				{
				}
				num = (short)465633280;
				if (num != 0)
				{
				}
				this.cnvSysSecurePatchKeySel_A40136.HiddenStatic = value;
			}
		}

		// Token: 0x17006014 RID: 24596
		// (get) Token: 0x0600BF55 RID: 48981 RVA: 0x00B0A6F0 File Offset: 0x00B088F0
		// (set) Token: 0x0600BF56 RID: 48982 RVA: 0x00B0A7A4 File Offset: 0x00B089A4
		internal bool CnvSysSecurePatchKeySel_A40136_HiddenDynamic
		{
			get
			{
				short num = (short)64159744;
				short num2 = num;
				num = (short)776265448;
				short num3 = num;
				num = (short)640474856;
				switch (num3 == num)
				{
				}
				num = (short)598212609;
				if (num != 0)
				{
				}
				num = (short)445710336;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136.HiddenDynamic;
			}
			set
			{
				short num = (short)1910046720;
				short num2 = num;
				num = (short)799466168;
				short num3 = num;
				num = (short)1879499448;
				switch (num3 == num)
				{
				}
				num = (short)279904257;
				if (num != 0)
				{
				}
				num = (short)911081472;
				if (num != 0)
				{
				}
				this.cnvSysSecurePatchKeySel_A40136.HiddenDynamic = value;
			}
		}

		// Token: 0x17006015 RID: 24597
		// (get) Token: 0x0600BF57 RID: 48983 RVA: 0x00B0A85C File Offset: 0x00B08A5C
		public bool CnvSysSecurePatchKeySel_A40136_HasDiffs
		{
			get
			{
				short num = (short)1916010496;
				short num2 = num;
				num = (short)1128325131;
				short num3 = num;
				num = (short)510648331;
				switch (num3 == num)
				{
				}
				num = (short)242024449;
				if (num != 0)
				{
				}
				num = (short)1320026112;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePatchKeySel_A40136._HasDiffs;
			}
		}

		// Token: 0x17006016 RID: 24598
		// (get) Token: 0x0600BF58 RID: 48984 RVA: 0x00B0A910 File Offset: 0x00B08B10
		// (set) Token: 0x0600BF59 RID: 48985 RVA: 0x00B0A9C4 File Offset: 0x00B08BC4
		public int CnvSysSecurePrivateCallKeySel_A40137Value
		{
			get
			{
				short num = (short)74383360;
				short num2 = num;
				num = (short)1471168989;
				short num3 = num;
				num = (short)1230914013;
				switch (num3 == num)
				{
				}
				num = (short)2057109505;
				if (num != 0)
				{
				}
				num = (short)1383202816;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.Value;
			}
			set
			{
				short num = (short)1236926464;
				short num2 = num;
				num = (short)1282011679;
				short num3 = num;
				num = (short)509735455;
				switch (num3 == num)
				{
				}
				num = (short)1018101760;
				if (num != 0)
				{
				}
				num = (short)492765185;
				if (num != 0)
				{
				}
				this.cnvSysSecurePrivateCallKeySel_A40137.Value = value;
			}
		}

		// Token: 0x17006017 RID: 24599
		// (get) Token: 0x0600BF5A RID: 48986 RVA: 0x00B0AA7C File Offset: 0x00B08C7C
		// (set) Token: 0x0600BF5B RID: 48987 RVA: 0x00B0AB30 File Offset: 0x00B08D30
		public string CnvSysSecurePrivateCallKeySel_A40137_UIValue
		{
			get
			{
				short num = (short)1803485184;
				short num2 = num;
				num = (short)1346757089;
				short num3 = num;
				num = (short)998367713;
				switch (num3 == num)
				{
				}
				num = (short)1158742016;
				if (num != 0)
				{
				}
				num = (short)2120417281;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.UIValue;
			}
			set
			{
				short num = (short)361824256;
				short num2 = num;
				num = (short)1469962218;
				short num3 = num;
				num = (short)1921898474;
				switch (num3 == num)
				{
				}
				num = (short)54263809;
				if (num != 0)
				{
				}
				num = (short)2059206656;
				if (num != 0)
				{
				}
				this.cnvSysSecurePrivateCallKeySel_A40137.UIValue = value;
			}
		}

		// Token: 0x17006018 RID: 24600
		// (get) Token: 0x0600BF5C RID: 48988 RVA: 0x00B0ABE8 File Offset: 0x00B08DE8
		public global::AcpBusinessLayer.AcpRecRefField CnvSysSecurePrivateCallKeySel_A40137
		{
			get
			{
				short num = (short)98304000;
				short num2 = num;
				num = (short)111092849;
				short num3 = num;
				num = (short)897000561;
				switch (num3 == num)
				{
				}
				num = (short)792592385;
				if (num != 0)
				{
				}
				num = (short)1925120000;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137;
			}
		}

		// Token: 0x17006019 RID: 24601
		// (get) Token: 0x0600BF5D RID: 48989 RVA: 0x00B0AC98 File Offset: 0x00B08E98
		// (set) Token: 0x0600BF5E RID: 48990 RVA: 0x00B0AD50 File Offset: 0x00B08F50
		public bool CnvSysSecurePrivateCallKeySel_A40137_Applicable
		{
			get
			{
				short num = (short)788529152;
				short num2 = num;
				num = (short)161457842;
				short num3 = num;
				num = (short)209036978;
				switch (num3 == num)
				{
				}
				num = (short)1519190016;
				if (num != 0)
				{
				}
				num = (short)1813905409;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.Applicable;
			}
			set
			{
				short num = (short)1721434112;
				short num2 = num;
				num = (short)899867894;
				short num3 = num;
				num = (short)691528950;
				switch (num3 == num)
				{
				}
				num = (short)2144600065;
				if (num != 0)
				{
				}
				num = (short)619184128;
				if (num != 0)
				{
				}
				this.cnvSysSecurePrivateCallKeySel_A40137.Applicable = value;
			}
		}

		// Token: 0x1700601A RID: 24602
		// (get) Token: 0x0600BF5F RID: 48991 RVA: 0x00B0AE04 File Offset: 0x00B09004
		// (set) Token: 0x0600BF60 RID: 48992 RVA: 0x00B0AEBC File Offset: 0x00B090BC
		public bool CnvSysSecurePrivateCallKeySel_A40137_Valid
		{
			get
			{
				short num = (short)303628288;
				short num2 = num;
				num = (short)732160973;
				short num3 = num;
				num = (short)163767245;
				switch (num3 == num)
				{
				}
				num = (short)1929576449;
				if (num != 0)
				{
				}
				num = (short)766967808;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.Valid;
			}
			set
			{
				short num = (short)48627712;
				short num2 = num;
				num = (short)527992773;
				short num3 = num;
				num = (short)1033996229;
				switch (num3 == num)
				{
				}
				num = (short)706412545;
				if (num != 0)
				{
				}
				num = (short)187105280;
				if (num != 0)
				{
				}
				this.cnvSysSecurePrivateCallKeySel_A40137.Valid = value;
			}
		}

		// Token: 0x1700601B RID: 24603
		// (get) Token: 0x0600BF61 RID: 48993 RVA: 0x00B0AF70 File Offset: 0x00B09170
		// (set) Token: 0x0600BF62 RID: 48994 RVA: 0x00B0B028 File Offset: 0x00B09228
		public bool CnvSysSecurePrivateCallKeySel_A40137_Visible
		{
			get
			{
				short num = (short)707133440;
				short num2 = num;
				num = (short)1391394817;
				if (num != 0)
				{
				}
				num = (short)1853134923;
				short num3 = num;
				num = (short)1457494091;
				switch (num3 == num)
				{
				}
				num = (short)1702363136;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.Visible;
			}
			set
			{
				short num = (short)1835008000;
				short num2 = num;
				num = (short)1413021697;
				if (num != 0)
				{
				}
				num = (short)435781602;
				short num3 = num;
				num = (short)1694334946;
				switch (num3 == num)
				{
				}
				num = (short)77529088;
				if (num != 0)
				{
				}
				this.cnvSysSecurePrivateCallKeySel_A40137.Visible = value;
			}
		}

		// Token: 0x1700601C RID: 24604
		// (get) Token: 0x0600BF63 RID: 48995 RVA: 0x00B0B0DC File Offset: 0x00B092DC
		// (set) Token: 0x0600BF64 RID: 48996 RVA: 0x00B0B194 File Offset: 0x00B09394
		public bool CnvSysSecurePrivateCallKeySel_A40137_Editable
		{
			get
			{
				short num = (short)838402048;
				short num2 = num;
				num = (short)342259631;
				short num3 = num;
				num = (short)431454127;
				switch (num3 == num)
				{
				}
				num = (short)1682964480;
				if (num != 0)
				{
				}
				num = (short)373030913;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.Editable;
			}
			set
			{
				short num = (short)1352728576;
				short num2 = num;
				num = (short)1941045249;
				if (num != 0)
				{
				}
				num = (short)1921466386;
				short num3 = num;
				num = (short)378290194;
				switch (num3 == num)
				{
				}
				num = (short)1769340928;
				if (num != 0)
				{
				}
				this.cnvSysSecurePrivateCallKeySel_A40137.Editable = value;
			}
		}

		// Token: 0x1700601D RID: 24605
		// (get) Token: 0x0600BF65 RID: 48997 RVA: 0x00B0B24C File Offset: 0x00B0944C
		internal string CnvSysSecurePrivateCallKeySel_A40137_UILabel
		{
			get
			{
				short num = (short)1053163520;
				short num2 = num;
				num = (short)2058413454;
				short num3 = num;
				num = (short)477291918;
				switch (num3 == num)
				{
				}
				num = (short)1945763841;
				if (num != 0)
				{
				}
				num = (short)641400832;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.UIName;
			}
		}

		// Token: 0x1700601E RID: 24606
		// (get) Token: 0x0600BF66 RID: 48998 RVA: 0x00B0B304 File Offset: 0x00B09504
		// (set) Token: 0x0600BF67 RID: 48999 RVA: 0x00B0B3B8 File Offset: 0x00B095B8
		internal bool CnvSysSecurePrivateCallKeySel_A40137_HiddenStatic
		{
			get
			{
				short num = (short)2028011520;
				short num2 = num;
				num = (short)1567568278;
				short num3 = num;
				num = (short)169685398;
				switch (num3 == num)
				{
				}
				num = (short)208797697;
				if (num != 0)
				{
				}
				num = (short)894631936;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.HiddenStatic;
			}
			set
			{
				short num = (short)1562574848;
				short num2 = num;
				num = (short)703594497;
				if (num != 0)
				{
				}
				num = (short)407441224;
				short num3 = num;
				num = (short)834408264;
				switch (num3 == num)
				{
				}
				num = (short)739573760;
				if (num != 0)
				{
				}
				this.cnvSysSecurePrivateCallKeySel_A40137.HiddenStatic = value;
			}
		}

		// Token: 0x1700601F RID: 24607
		// (get) Token: 0x0600BF68 RID: 49000 RVA: 0x00B0B46C File Offset: 0x00B0966C
		// (set) Token: 0x0600BF69 RID: 49001 RVA: 0x00B0B520 File Offset: 0x00B09720
		internal bool CnvSysSecurePrivateCallKeySel_A40137_HiddenDynamic
		{
			get
			{
				short num = (short)197525504;
				short num2 = num;
				num = (short)777835521;
				short num3 = num;
				num = (short)576967681;
				switch (num3 == num)
				{
				}
				num = (short)1640824833;
				if (num != 0)
				{
				}
				num = (short)714014720;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137.HiddenDynamic;
			}
			set
			{
				short num = (short)303169536;
				short num2 = num;
				num = (short)1651998260;
				short num3 = num;
				num = (short)1268022836;
				switch (num3 == num)
				{
				}
				num = (short)1833435137;
				if (num != 0)
				{
				}
				num = (short)1993080832;
				if (num != 0)
				{
				}
				this.cnvSysSecurePrivateCallKeySel_A40137.HiddenDynamic = value;
			}
		}

		// Token: 0x17006020 RID: 24608
		// (get) Token: 0x0600BF6A RID: 49002 RVA: 0x00B0B5D4 File Offset: 0x00B097D4
		public bool CnvSysSecurePrivateCallKeySel_A40137_HasDiffs
		{
			get
			{
				short num = (short)1614741504;
				short num2 = num;
				num = (short)738823331;
				short num3 = num;
				num = (short)81956003;
				switch (num3 == num)
				{
				}
				num = (short)502530049;
				if (num != 0)
				{
				}
				num = (short)683147264;
				if (num != 0)
				{
				}
				return this.cnvSysSecurePrivateCallKeySel_A40137._HasDiffs;
			}
		}

		// Token: 0x17006021 RID: 24609
		// (get) Token: 0x0600BF6B RID: 49003 RVA: 0x00B0B684 File Offset: 0x00B09884
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)23527424;
				short num2 = num;
				num = (short)553240581;
				short num3 = num;
				num = (short)1436272645;
				switch (num3 == num)
				{
				}
				num = (short)1173618689;
				if (num != 0)
				{
				}
				num = (short)2027880448;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600BF6C RID: 49004 RVA: 0x00B0B740 File Offset: 0x00B09940
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
					num2 = (short)1237712897;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)1327562753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					num2 = (short)653524994;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2086928384;
						short num3 = num2;
						num2 = (short)1369833476;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1657208835;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)2027871945;
			short num4 = num2;
			num2 = (short)1705893577;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1828192256;
				if (num2 != 0)
				{
				}
				result = null;
				break;
			}
			num2 = (short)975503360;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005C39 RID: 23609
		private global::AcpBusinessLayer.AcpRecRefField cnvSysSecureKMFProfIndex_A40132;

		// Token: 0x04005C3A RID: 23610
		private global::AcpBusinessLayer.AcpRecRefField cnvSysSecureDynTGKeySel_A40133;

		// Token: 0x04005C3B RID: 23611
		private global::AcpBusinessLayer.AcpRecRefField cnvSysSecureFSKeySel_A40134;

		// Token: 0x04005C3C RID: 23612
		private global::AcpBusinessLayer.AcpRecRefField cnvSysSecureInterConnectKeySel_A40135;

		// Token: 0x04005C3D RID: 23613
		private global::AcpBusinessLayer.AcpRecRefField cnvSysSecurePatchKeySel_A40136;

		// Token: 0x04005C3E RID: 23614
		private global::AcpBusinessLayer.AcpRecRefField cnvSysSecurePrivateCallKeySel_A40137;
	}
}
