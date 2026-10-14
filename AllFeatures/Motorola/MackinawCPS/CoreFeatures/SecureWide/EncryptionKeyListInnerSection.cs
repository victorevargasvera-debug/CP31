using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E4 RID: 228
	[global::System.Serializable]
	public class EncryptionKeyListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001EF3 RID: 7923 RVA: 0x001EFBC4 File Offset: 0x001EDDC4
		public EncryptionKeyListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x001EFBE0 File Offset: 0x001EDDE0
		protected EncryptionKeyListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x001EFBF8 File Offset: 0x001EDDF8
		public override void Init()
		{
			int a_ = 13;
			short num = (short)2025992187;
			short num2 = num;
			num = (short)1206661115;
			switch (num2 == num)
			{
			default:
			{
				num = (short)411631616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1888616449;
			if (num != 0)
			{
			}
			num = (short)1462304768;
			if (num != 0)
			{
			}
			this.secWideMultikeyListCKR_A7665 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙釛ꯝ賟雡跣跥跧鏩ꃫ蟭華蛱럳뷵꫷ꗹ뷻짽㛿㐁㄃", a_), global::CommonResources.AcgResources.ID_CKRP, 0, 4095, global::CommonResources.AcgResources.ID_BLANK, null, 0, 1);
			this.secWideMultikeyListCKR_A7665.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secWideMultikeyListCKR_A7665.DataTransferOrder = 37;
			this.secWideMultikeyListCKR_A7665.ValidateAcrossRecset = true;
			this.secWideMultikeyListCKR_A7665.ShowHexValue = false;
			this.secWideMultikeyListIndexed_A8282 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙釛ꯝ賟雡跣跥跧鏩ꃫ蟭華蛱뷳飵鳷鿹蓻鯽擿崁䔃㸅㨇㈉㸋", a_), global::CommonResources.AcgResources.ID_INDEXED);
			this.secWideMultikeyListIndexed_A8282.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secWideMultikeyListIndexed_A8282.DataTransferOrder = 42;
			this.secWideMultikeyListIndexed_A8282.ValidateAcrossRecset = true;
			this.secWideMultikeyListKeyName_A8362 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙釛ꯝ賟雡跣跥跧鏩ꃫ蟭華蛱뿳鏵臷듹鷻鏽旿崁䔃㸅㬇㰉㸋", a_), global::CommonResources.AcgResources.ID_KEYNAME, 14);
			this.secWideMultikeyListKeyName_A8362.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secWideMultikeyListKeyName_A8362.DataTransferOrder = 5;
			this.secWideMultikeyListKeyName_A8362.EvaluateRecRefs = true;
			this.secWideMultikeyListSlotA_A9155 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙釛ꯝ賟雡跣跥跧鏩ꃫ蟭華蛱ꟳ髵韷軹뷻ꇽ䇿㬁㔃㌅㴇", a_), global::CommonResources.AcgResources.ID_SLOTA, 0, 15, null, null, 0, 1);
			this.secWideMultikeyListSlotA_A9155.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secWideMultikeyListSlotA_A9155.DataTransferOrder = -1;
			this.secWideMultikeyListSlotA_A9155.ShowHexValue = false;
			this.secWideMultikeyListSlotB_A9158 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙釛ꯝ賟雡跣跥跧鏩ꃫ蟭華蛱ꟳ髵韷軹뻻ꇽ䇿㬁㔃㌅〇", a_), global::CommonResources.AcgResources.ID_SLOTB, 0, 15, null, null, 0, 1);
			this.secWideMultikeyListSlotB_A9158.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secWideMultikeyListSlotB_A9158.DataTransferOrder = -1;
			this.secWideMultikeyListSlotB_A9158.ShowHexValue = false;
			this.secWideMultikeyListSelectableADPKeyID_A9107 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ﻍ", a_), this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙釛ꯝ賟雡跣跥跧鏩ꃫ蟭華蛱ꟳ鏵铷鿹鿻諽懿态栃挅䤇三尋䔍甏欑崓刕䜗嬙┛⼝ဟᔡ", a_), global::CommonResources.AcgResources.ID_SELECTABLEADPKEYID, 4);
			this.secWideMultikeyListSelectableADPKeyID_A9107.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secWideMultikeyListSelectableADPKeyID_A9107.DataTransferOrder = 36;
			this.secWideMultikeyListSelectableADPKeyID_A9107.ValidateAcrossRecset = true;
			this.secWideMultikeyListSelectableADPKeyData_A9106 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("𢡊ﻓﳕ쫟", a_), this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑菓뿕볗뿙釛ꯝ賟雡跣跥跧鏩ꃫ蟭華蛱ꟳ鏵铷鿹鿻諽懿态栃挅䤇三尋䔍甏欑倓眕気笙䌛弝᤟ጡᐣဥ", a_), global::CommonResources.AcgResources.ID_SELECTABLEADPKEYDATA, 10);
			this.secWideMultikeyListSelectableADPKeyData_A9106.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secWideMultikeyListSelectableADPKeyData_A9106.DataTransferOrder = 40;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("词뻏뇑ꛓ꿕꣗껙뗛뇝軟싡꿣菥釧쫩ꃫ蟭華蛱", a_);
			base.Id = 10041;
			base.UIName = global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x001EFEF4 File Offset: 0x001EE0F4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1055719437;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.secWideMultikeyListSlotB_A9158 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲꛴鯶雸迺뿼ꃾ䀀㨂㐄㈆ㄈ", a_), global::CommonResources.AcgResources.ID_SLOTB, null, null, 0, 1);
					this.secWideMultikeyListSlotB_A9158.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secWideMultikeyListSlotB_A9158.DataTransferOrder = -1;
					this.secWideMultikeyListSlotB_A9158.ShowHexValue = false;
					num = (short)2071199755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_43D;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲뻴鋶胸뗺鳼鋾搀専䐄㼆㨈㴊㼌", a_)))
					{
						num = (short)912850959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62F;
				case 3:
					this.secWideMultikeyListSelectableADPKeyID_A9107 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ￎ", a_), this, global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲꛴鋶闸黺黼课怀愂椄戆䠈伊崌䐎琐樒尔化䘘娚␜⸞ᄠᐢ", a_), global::CommonResources.AcgResources.ID_SELECTABLEADPKEYID, 4);
					this.secWideMultikeyListSelectableADPKeyID_A9107.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secWideMultikeyListSelectableADPKeyID_A9107.DataTransferOrder = 36;
					this.secWideMultikeyListSelectableADPKeyID_A9107.ValidateAcrossRecset = true;
					num = (short)1880227859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_62F;
				case 5:
					this.secWideMultikeyListSlotA_A9155 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲꛴鯶雸迺볼ꃾ䀀㨂㐄㈆㰈", a_), global::CommonResources.AcgResources.ID_SLOTA, null, null, 0, 1);
					this.secWideMultikeyListSlotA_A9155.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secWideMultikeyListSlotA_A9155.DataTransferOrder = -1;
					this.secWideMultikeyListSlotA_A9155.ShowHexValue = false;
					num = (short)563150858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲꛴鋶闸黺黼课怀愂椄戆䠈伊崌䐎琐樒尔化䘘娚␜⸞ᄠᐢ", a_)))
					{
						num = (short)1744371715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48B;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲꛴鯶雸迺볼ꃾ䀀㨂㐄㈆㰈", a_)))
					{
						num = (short)126287877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_301;
				case 8:
				{
					num = (short)1161580952;
					short num3 = num;
					num = (short)668422552;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4FA;
					default:
						num = (short)260177920;
						if (num != 0)
						{
						}
						num = (short)1406140432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲꛴鋶闸黺黼课怀愂椄戆䠈伊崌䐎琐樒儔瘖洘稚䈜帞ᠠሢᔤᄦ", a_)))
					{
						num = (short)367984664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67B;
				case 10:
					goto IL_301;
				case 11:
					goto IL_4FF;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲뛴볶꯸ꓺ볼죾㜀㔂〄", a_)))
					{
						num = (short)1356791829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43D;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲보駶鷸黺藼髾攀専䐄㼆㬈㌊㼌", a_)))
					{
						num = (short)1962016786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E5;
				case 15:
					this.secWideMultikeyListKeyName_A8362 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲뻴鋶胸뗺鳼鋾搀専䐄㼆㨈㴊㼌", a_), global::CommonResources.AcgResources.ID_KEYNAME, 14);
					this.secWideMultikeyListKeyName_A8362.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secWideMultikeyListKeyName_A8362.DataTransferOrder = 5;
					this.secWideMultikeyListKeyName_A8362.EvaluateRecRefs = true;
					num = (short)1761804292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields != null)
					{
						num = (short)230621206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67B;
				case 17:
					goto IL_3D5;
				case 18:
					this.secWideMultikeyListIndexed_A8282 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲보駶鷸黺藼髾攀専䐄㼆㬈㌊㼌", a_), global::CommonResources.AcgResources.ID_INDEXED);
					this.secWideMultikeyListIndexed_A8282.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secWideMultikeyListIndexed_A8282.DataTransferOrder = 42;
					this.secWideMultikeyListIndexed_A8282.ValidateAcrossRecset = true;
					num = (short)1026818071;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_48B;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲꛴鯶雸迺뿼ꃾ䀀㨂㐄㈆ㄈ", a_)))
					{
						num = (short)566886400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FF;
				case 21:
					this.secWideMultikeyListCKR_A7665 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲뛴볶꯸ꓺ볼죾㜀㔂〄", a_), global::CommonResources.AcgResources.ID_CKRP, global::CommonResources.AcgResources.ID_BLANK, null, 0, 1);
					this.secWideMultikeyListCKR_A7665.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secWideMultikeyListCKR_A7665.DataTransferOrder = 37;
					this.secWideMultikeyListCKR_A7665.ValidateAcrossRecset = true;
					this.secWideMultikeyListCKR_A7665.ShowHexValue = false;
					num = (short)1605173249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1585840140;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_5E5;
				case 24:
					goto IL_4FA;
				}
				IL_92:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2024931336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_301:
				num = (short)206635028;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4FA:
				num = (short)12255233;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("﯐戮ￔ﷖쯠", a_), this, global::AllFeatures.CodeplugGuid.b("鳎듐냒苔뻖뷘뻚郜꫞跠韢賤賦賨鋪ꇬ蛮苰蟲꛴鋶闸黺黼课怀愂椄戆䠈伊崌䐎琐樒儔瘖洘稚䈜帞ᠠሢᔤᄦ", a_), global::CommonResources.AcgResources.ID_SELECTABLEADPKEYDATA, 10);
				this.secWideMultikeyListSelectableADPKeyData_A9106.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
				this.secWideMultikeyListSelectableADPKeyData_A9106.DataTransferOrder = 40;
				num = (short)2080702481;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43D:
				num = (short)1113718798;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48B:
				num = (short)318701568;
				short num4 = num;
				num = (short)1536688137;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4FF:
				num = (short)575143942;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5E5:
				num = (short)2071724034;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62F:
				num = (short)565968903;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3D5:
			IL_67B:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諎뿐냒꟔껖꧘꿚드냞迠쏢껤苦部쯪ꇬ蛮苰蟲", a_);
			base.Id = 10041;
			base.UIName = global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x001F05B0 File Offset: 0x001EE7B0
		public override void PopulateReferences()
		{
			short num = (short)101322973;
			short num2 = num;
			num = (short)1772490973;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1530003456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2112094209;
			if (num != 0)
			{
			}
			num = (short)320929792;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x001F065C File Offset: 0x001EE85C
		public override void DropReferences()
		{
			short num = (short)24249890;
			short num2 = num;
			num = (short)888276514;
			switch (num2 == num)
			{
			default:
			{
				num = (short)72286208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)608698368;
			if (num != 0)
			{
			}
			num = (short)1806630913;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x001F0704 File Offset: 0x001EE904
		public override void SetConstraints()
		{
			short num = (short)2067005622;
			short num2 = num;
			num = (short)426115254;
			switch (num2 == num)
			{
			default:
			{
				num = (short)334102528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)568131585;
			if (num != 0)
			{
			}
			num = (short)1648361472;
			if (num != 0)
			{
			}
			this.secWideMultikeyListCKR_A7665.ValidateAcrossRecset = true;
			this.secWideMultikeyListCKR_A7665.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConIsCKRApplicable);
			this.secWideMultikeyListCKR_A7665.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConValueNotBlankNorDuplicated);
			this.secWideMultikeyListIndexed_A8282.ValidateAcrossRecset = true;
			this.secWideMultikeyListIndexed_A8282.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperIsHwAndPidKeyMngmtIsEnAndRecordNumLt9);
			this.secWideMultikeyListIndexed_A8282.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecWideEncryKeyListIndexedIsValid);
			this.secWideMultikeyListIndexed_A8282.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.conSetSecPIDIndexMapAndSlotAAndSlotBValues);
			this.secWideMultikeyListKeyName_A8362.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationIsNotDisabled);
			this.secWideMultikeyListKeyName_A8362.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConInvalidIfLeadingSpacesAndPeriodsExist);
			this.secWideMultikeyListSlotA_A9155.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSlotAIsApplicable);
			this.secWideMultikeyListSlotA_A9155.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.secWideMultikeyListSlotB_A9158.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.secWideMultikeyListSelectableADPKeyID_A9107.ValidateAcrossRecset = true;
			this.secWideMultikeyListSelectableADPKeyID_A9107.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsADPWithTrigger);
			this.secWideMultikeyListSelectableADPKeyID_A9107.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConCheckForDuplicateADPKeyIDs);
			this.secWideMultikeyListSelectableADPKeyID_A9107.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConFormatADPKeystreamsAndKeyIDsForSelAdpKeyID);
			this.secWideMultikeyListSelectableADPKeyData_A9106.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsADP);
			this.secWideMultikeyListSelectableADPKeyData_A9106.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConIsADPKeyDataValid);
			this.secWideMultikeyListSelectableADPKeyData_A9106.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConFormatADPKeystreamsAndKeyIDsForSelAdpKeystream);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x001F0940 File Offset: 0x001EEB40
		public override void SetupDependencies()
		{
			short num = (short)596443137;
			if (num != 0)
			{
			}
			num = (short)106037248;
			short num2 = num;
			num = (short)1094865537;
			short num3 = num;
			num = (short)737759873;
			switch (num3 == num)
			{
			}
			num = (short)1191378944;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyListCKR_A7665);
			secureWide.General.SecureWideKeyloadingSource_43204.AddDependentObject(this.secWideMultikeyListCKR_A7665);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyListIndexed_A8282);
			secureWide.Multikey.SecWideMultikeyPIDKeyManagementforASNMode_A8704.AddDependentObject(this.secWideMultikeyListIndexed_A8282);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyListKeyName_A8362);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyListSlotA_A9155);
			secureWide.Multikey.SecWideMultikeyPIDKeyManagementforASNMode_A8704.AddDependentObject(this.secWideMultikeyListSlotA_A9155);
			this.secWideMultikeyListIndexed_A8282.AddDependentObject(this.secWideMultikeyListSlotA_A9155);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyListSelectableADPKeyID_A9107);
			secureWide.General.SecureWideADPAlgorithmEnable_43200.AddDependentObject(this.secWideMultikeyListSelectableADPKeyID_A9107);
			secureWide.General.SecureWideKeyloadingSource_43204.AddDependentObject(this.secWideMultikeyListSelectableADPKeyID_A9107);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyListSelectableADPKeyData_A9106);
			secureWide.General.SecureWideKeyloadingSource_43204.AddDependentObject(this.secWideMultikeyListSelectableADPKeyData_A9106);
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x001F0B28 File Offset: 0x001EED28
		public bool HasDiffs
		{
			get
			{
				short num = (short)755564575;
				short num2 = num;
				num = (short)2092957727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1073807360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1719730177;
				if (num != 0)
				{
				}
				num = (short)171966464;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x001F0BD8 File Offset: 0x001EEDD8
		// (set) Token: 0x06001EFD RID: 7933 RVA: 0x001F0C90 File Offset: 0x001EEE90
		public int SecWideMultikeyListCKR_A7665Value
		{
			get
			{
				short num = (short)1125256154;
				short num2 = num;
				num = (short)368380890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1400438784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1169555456;
				if (num != 0)
				{
				}
				num = (short)691470337;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.Value;
			}
			set
			{
				short num = (short)397584657;
				short num2 = num;
				num = (short)695904529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422117376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143078913;
				if (num != 0)
				{
				}
				num = (short)503906304;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.Value = value;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06001EFE RID: 7934 RVA: 0x001F0D44 File Offset: 0x001EEF44
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideMultikeyListCKR_A7665
		{
			get
			{
				short num = (short)395200668;
				short num2 = num;
				num = (short)302270620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)311754752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2034630656;
				if (num != 0)
				{
				}
				num = (short)2056912897;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x001F0DF4 File Offset: 0x001EEFF4
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x001F0EAC File Offset: 0x001EF0AC
		public string SecWideMultikeyListCKR_A7665_UIValue
		{
			get
			{
				short num = (short)1657623096;
				short num2 = num;
				num = (short)187912760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1312030720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1365573632;
				if (num != 0)
				{
				}
				num = (short)1910177793;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.UIValue;
			}
			set
			{
				short num = (short)803455133;
				short num2 = num;
				num = (short)498188445;
				switch (num2 == num)
				{
				default:
				{
					num = (short)170328064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192544769;
				if (num != 0)
				{
				}
				num = (short)1148846080;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.UIValue = value;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x001F0F60 File Offset: 0x001EF160
		// (set) Token: 0x06001F02 RID: 7938 RVA: 0x001F1018 File Offset: 0x001EF218
		internal int SecWideMultikeyListCKR_A7665Min
		{
			get
			{
				short num = (short)1183926308;
				short num2 = num;
				num = (short)1014712356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)83951616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174077440;
				if (num != 0)
				{
				}
				num = (short)24379393;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.Min;
			}
			set
			{
				short num = (short)1785291597;
				short num2 = num;
				num = (short)1184195405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1019871232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)64225281;
				if (num != 0)
				{
				}
				num = (short)1441005568;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.Min = value;
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x001F10CC File Offset: 0x001EF2CC
		// (set) Token: 0x06001F04 RID: 7940 RVA: 0x001F1180 File Offset: 0x001EF380
		internal int SecWideMultikeyListCKR_A7665Max
		{
			get
			{
				short num = (short)1402929153;
				if (num != 0)
				{
				}
				num = (short)179240960;
				short num2 = num;
				num = (short)1198682218;
				short num3 = num;
				num = (short)923365482;
				switch (num3 == num)
				{
				}
				num = (short)941621248;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.Max;
			}
			set
			{
				short num = (short)1638216817;
				short num2 = num;
				num = (short)1549677681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1990131712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1857486849;
				if (num != 0)
				{
				}
				num = (short)344850432;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.Max = value;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x001F1234 File Offset: 0x001EF434
		// (set) Token: 0x06001F06 RID: 7942 RVA: 0x001F12E8 File Offset: 0x001EF4E8
		internal int SecWideMultikeyListCKR_A7665Step
		{
			get
			{
				short num = (short)940456919;
				short num2 = num;
				num = (short)1111505879;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1873149952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)997457920;
				if (num != 0)
				{
				}
				num = (short)617152513;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.StepSize;
			}
			set
			{
				short num = (short)1867892755;
				short num2 = num;
				num = (short)2133444627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1866661888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2085552129;
				if (num != 0)
				{
				}
				num = (short)479526912;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.StepSize = value;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x001F13A0 File Offset: 0x001EF5A0
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x001F1454 File Offset: 0x001EF654
		public bool SecWideMultikeyListCKR_A7665_Applicable
		{
			get
			{
				short num = (short)63390162;
				short num2 = num;
				num = (short)1553482194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1635254272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1089470464;
				if (num != 0)
				{
				}
				num = (short)15269889;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.Applicable;
			}
			set
			{
				short num = (short)659916163;
				short num2 = num;
				num = (short)1738769795;
				switch (num2 == num)
				{
				}
				num = (short)288948224;
				short num3 = num;
				num = (short)1034158081;
				if (num != 0)
				{
				}
				num = (short)989855744;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.Applicable = value;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x001F150C File Offset: 0x001EF70C
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x001F15C0 File Offset: 0x001EF7C0
		public bool SecWideMultikeyListCKR_A7665_Valid
		{
			get
			{
				short num = (short)1549271041;
				if (num != 0)
				{
				}
				num = (short)1412125513;
				short num2 = num;
				num = (short)323507017;
				switch (num2 == num)
				{
				default:
				{
					num = (short)514326528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2143748096;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.Valid;
			}
			set
			{
				short num = (short)1750492558;
				short num2 = num;
				num = (short)913401230;
				switch (num2 == num)
				{
				}
				num = (short)1631059968;
				short num3 = num;
				num = (short)2037907457;
				if (num != 0)
				{
				}
				num = (short)419102720;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.Valid = value;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x001F1674 File Offset: 0x001EF874
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x001F1728 File Offset: 0x001EF928
		public bool SecWideMultikeyListCKR_A7665_Visible
		{
			get
			{
				short num = (short)1997229520;
				short num2 = num;
				num = (short)1170427344;
				switch (num2 == num)
				{
				}
				num = (short)1168834560;
				short num3 = num;
				num = (short)131072001;
				if (num != 0)
				{
				}
				num = (short)2098397184;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.Visible;
			}
			set
			{
				short num = (short)668440820;
				short num2 = num;
				num = (short)407279860;
				switch (num2 == num)
				{
				}
				num = (short)187432960;
				short num3 = num;
				num = (short)390070273;
				if (num != 0)
				{
				}
				num = (short)951713792;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.Visible = value;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x001F17E0 File Offset: 0x001EF9E0
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x001F1894 File Offset: 0x001EFA94
		public bool SecWideMultikeyListCKR_A7665_Editable
		{
			get
			{
				short num = (short)2083008904;
				short num2 = num;
				num = (short)436023688;
				switch (num2 == num)
				{
				}
				num = (short)1536950272;
				short num3 = num;
				num = (short)184680448;
				if (num != 0)
				{
				}
				num = (short)488308737;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.Editable;
			}
			set
			{
				short num = (short)257253492;
				short num2 = num;
				num = (short)115368052;
				switch (num2 == num)
				{
				}
				num = (short)576978944;
				short num3 = num;
				num = (short)761528321;
				if (num != 0)
				{
				}
				num = (short)1579876352;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.Editable = value;
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x001F1948 File Offset: 0x001EFB48
		internal string SecWideMultikeyListCKR_A7665_UILabel
		{
			get
			{
				short num = (short)209844937;
				short num2 = num;
				num = (short)448723657;
				switch (num2 == num)
				{
				}
				num = (short)2092564480;
				short num3 = num;
				num = (short)535625729;
				if (num != 0)
				{
				}
				num = (short)1140719616;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.UIName;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x001F19FC File Offset: 0x001EFBFC
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x001F1AB4 File Offset: 0x001EFCB4
		internal bool SecWideMultikeyListCKR_A7665_HiddenStatic
		{
			get
			{
				short num = (short)1482552820;
				short num2 = num;
				num = (short)465171956;
				switch (num2 == num)
				{
				}
				num = (short)294912000;
				short num3 = num;
				num = (short)890437633;
				if (num != 0)
				{
				}
				num = (short)1442775040;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.HiddenStatic;
			}
			set
			{
				short num = (short)2001778543;
				short num2 = num;
				num = (short)389461871;
				switch (num2 == num)
				{
				}
				num = (short)62586880;
				short num3 = num;
				num = (short)2016018433;
				if (num != 0)
				{
				}
				num = (short)683933696;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.HiddenStatic = value;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x001F1B68 File Offset: 0x001EFD68
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x001F1C1C File Offset: 0x001EFE1C
		internal bool SecWideMultikeyListCKR_A7665_HiddenDynamic
		{
			get
			{
				short num = (short)1363752892;
				short num2 = num;
				num = (short)739063740;
				switch (num2 == num)
				{
				}
				num = (short)1574830080;
				short num3 = num;
				num = (short)985530369;
				if (num != 0)
				{
				}
				num = (short)1843068928;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665.HiddenDynamic;
			}
			set
			{
				short num = (short)1513893287;
				short num2 = num;
				num = (short)1341926823;
				switch (num2 == num)
				{
				}
				num = (short)747503616;
				short num3 = num;
				num = (short)1645477888;
				if (num != 0)
				{
				}
				num = (short)547225601;
				if (num != 0)
				{
				}
				this.secWideMultikeyListCKR_A7665.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x001F1CD4 File Offset: 0x001EFED4
		public bool SecWideMultikeyListCKR_A7665_HasDiffs
		{
			get
			{
				short num = (short)1686783173;
				short num2 = num;
				num = (short)1974027461;
				switch (num2 == num)
				{
				}
				num = (short)2077360128;
				short num3 = num;
				num = (short)1381171201;
				if (num != 0)
				{
				}
				num = (short)332005376;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListCKR_A7665._HasDiffs;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x001F1D8C File Offset: 0x001EFF8C
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x001F1E40 File Offset: 0x001F0040
		public bool SecWideMultikeyListIndexed_A8282Value
		{
			get
			{
				short num = (short)239432483;
				short num2 = num;
				num = (short)1227977507;
				switch (num2 == num)
				{
				}
				num = (short)2087059456;
				short num3 = num;
				num = (short)886767616;
				if (num != 0)
				{
				}
				num = (short)1967390721;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.Value;
			}
			set
			{
				short num = (short)2000027649;
				if (num != 0)
				{
				}
				num = (short)1715685537;
				short num2 = num;
				num = (short)1975077025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2045575168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)829816832;
				if (num != 0)
				{
				}
				this.secWideMultikeyListIndexed_A8282.Value = value;
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x001F1EF8 File Offset: 0x001F00F8
		public global::AcpBusinessLayer.AcpField<bool> SecWideMultikeyListIndexed_A8282
		{
			get
			{
				short num = (short)368448865;
				short num2 = num;
				num = (short)1597314401;
				switch (num2 == num)
				{
				}
				num = (short)2102394880;
				short num3 = num;
				num = (short)1415774209;
				if (num != 0)
				{
				}
				num = (short)748683264;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x001F1FA8 File Offset: 0x001F01A8
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x001F205C File Offset: 0x001F025C
		public bool SecWideMultikeyListIndexed_A8282_UIValue
		{
			get
			{
				short num = (short)925112006;
				short num2 = num;
				num = (short)2102982;
				switch (num2 == num)
				{
				}
				num = (short)1174011904;
				short num3 = num;
				num = (short)715194369;
				if (num != 0)
				{
				}
				num = (short)1296957440;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.Value;
			}
			set
			{
				short num = (short)1094220719;
				short num2 = num;
				num = (short)1290435503;
				switch (num2 == num)
				{
				}
				num = (short)1330839552;
				short num3 = num;
				num = (short)2045968385;
				if (num != 0)
				{
				}
				num = (short)1124597760;
				if (num != 0)
				{
				}
				this.secWideMultikeyListIndexed_A8282.Value = value;
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x001F210C File Offset: 0x001F030C
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x001F21BC File Offset: 0x001F03BC
		public bool SecWideMultikeyListIndexed_A8282_Applicable
		{
			get
			{
				short num = (short)1533700845;
				short num2 = num;
				num = (short)89418477;
				switch (num2 == num)
				{
				}
				num = (short)1591869440;
				short num3 = num;
				num = (short)458424320;
				if (num != 0)
				{
				}
				num = (short)1793064961;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.Applicable;
			}
			set
			{
				short num = (short)191006481;
				short num2 = num;
				num = (short)867272465;
				switch (num2 == num)
				{
				}
				num = (short)776011776;
				short num3 = num;
				num = (short)1914372097;
				if (num != 0)
				{
				}
				num = (short)1584726016;
				if (num != 0)
				{
				}
				this.secWideMultikeyListIndexed_A8282.Applicable = value;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x001F2274 File Offset: 0x001F0474
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x001F2328 File Offset: 0x001F0528
		public bool SecWideMultikeyListIndexed_A8282_Valid
		{
			get
			{
				short num = (short)2108666929;
				short num2 = num;
				num = (short)2027009073;
				switch (num2 == num)
				{
				}
				num = (short)571408384;
				short num3 = num;
				num = (short)729743361;
				if (num != 0)
				{
				}
				num = (short)532676608;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.Valid;
			}
			set
			{
				short num = (short)27066369;
				if (num != 0)
				{
				}
				num = (short)715202944;
				short num2 = num;
				num = (short)2005934464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1358299136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)132775936;
				if (num != 0)
				{
				}
				this.secWideMultikeyListIndexed_A8282.Valid = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x001F23DC File Offset: 0x001F05DC
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x001F2494 File Offset: 0x001F0694
		public bool SecWideMultikeyListIndexed_A8282_Visible
		{
			get
			{
				short num = (short)1582599305;
				short num2 = num;
				num = (short)324242569;
				switch (num2 == num)
				{
				}
				num = (short)1048641536;
				short num3 = num;
				num = (short)1890975745;
				if (num != 0)
				{
				}
				num = (short)639238144;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.Visible;
			}
			set
			{
				short num = (short)1469249912;
				short num2 = num;
				num = (short)1853159800;
				switch (num2 == num)
				{
				}
				num = (short)1439105024;
				short num3 = num;
				num = (short)408027136;
				if (num != 0)
				{
				}
				num = (short)813301761;
				if (num != 0)
				{
				}
				this.secWideMultikeyListIndexed_A8282.Visible = value;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x001F2548 File Offset: 0x001F0748
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x001F25FC File Offset: 0x001F07FC
		public bool SecWideMultikeyListIndexed_A8282_Editable
		{
			get
			{
				short num = (short)1836580865;
				if (num != 0)
				{
				}
				num = (short)597597409;
				short num2 = num;
				num = (short)486710497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1365245952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195559424;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.Editable;
			}
			set
			{
				short num = (short)257377248;
				short num2 = num;
				num = (short)1155613664;
				switch (num2 == num)
				{
				}
				num = (short)2081357824;
				short num3 = num;
				num = (short)2048786433;
				if (num != 0)
				{
				}
				num = (short)1747517440;
				if (num != 0)
				{
				}
				this.secWideMultikeyListIndexed_A8282.Editable = value;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x001F26B4 File Offset: 0x001F08B4
		internal string SecWideMultikeyListIndexed_A8282_UILabel
		{
			get
			{
				short num = (short)629996694;
				short num2 = num;
				num = (short)1779235990;
				switch (num2 == num)
				{
				}
				num = (short)1351417856;
				short num3 = num;
				num = (short)698351617;
				if (num != 0)
				{
				}
				num = (short)915341312;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.UIName;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x001F2768 File Offset: 0x001F0968
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x001F281C File Offset: 0x001F0A1C
		internal bool SecWideMultikeyListIndexed_A8282_HiddenStatic
		{
			get
			{
				short num = (short)189568160;
				short num2 = num;
				num = (short)1360041120;
				switch (num2 == num)
				{
				}
				num = (short)1771962368;
				short num3 = num;
				num = (short)1456799744;
				if (num != 0)
				{
				}
				num = (short)853016577;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.HiddenStatic;
			}
			set
			{
				short num = (short)215914324;
				short num2 = num;
				num = (short)2027722580;
				switch (num2 == num)
				{
				}
				num = (short)1474822144;
				short num3 = num;
				num = (short)927727617;
				if (num != 0)
				{
				}
				num = (short)961216512;
				if (num != 0)
				{
				}
				this.secWideMultikeyListIndexed_A8282.HiddenStatic = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x001F28D0 File Offset: 0x001F0AD0
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x001F2984 File Offset: 0x001F0B84
		internal bool SecWideMultikeyListIndexed_A8282_HiddenDynamic
		{
			get
			{
				short num = (short)2070848748;
				short num2 = num;
				num = (short)1832494316;
				switch (num2 == num)
				{
				}
				num = (short)277807104;
				short num3 = num;
				num = (short)972161025;
				if (num != 0)
				{
				}
				num = (short)1093730304;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282.HiddenDynamic;
			}
			set
			{
				short num = (short)673650999;
				short num2 = num;
				num = (short)798497079;
				switch (num2 == num)
				{
				}
				num = (short)18546688;
				short num3 = num;
				num = (short)888406017;
				if (num != 0)
				{
				}
				num = (short)910884864;
				if (num != 0)
				{
				}
				this.secWideMultikeyListIndexed_A8282.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x001F2A3C File Offset: 0x001F0C3C
		public bool SecWideMultikeyListIndexed_A8282_HasDiffs
		{
			get
			{
				short num = (short)1889861633;
				if (num != 0)
				{
				}
				num = (short)36569428;
				short num2 = num;
				num = (short)1042809172;
				switch (num2 == num)
				{
				default:
				{
					num = (short)222887936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)242483200;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListIndexed_A8282._HasDiffs;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x001F2AF0 File Offset: 0x001F0CF0
		// (set) Token: 0x06001F29 RID: 7977 RVA: 0x001F2BA8 File Offset: 0x001F0DA8
		public string SecWideMultikeyListKeyName_A8362Value
		{
			get
			{
				short num = (short)2092630017;
				if (num != 0)
				{
				}
				num = (short)735726459;
				short num2 = num;
				num = (short)653871995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240451584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)393674752;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.Value;
			}
			set
			{
				short num = (short)1933705217;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1718573266;
					short num3 = num;
					num = (short)229529810;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1694302208;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							this.secWideMultikeyListKeyName_A8362.Value = value;
							goto IL_B4;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7D;
							}
							continue;
						case 2:
							goto IL_CC;
						}
						IL_7D:
						if (!string.IsNullOrEmpty(value.Trim()))
						{
							num = (short)10420224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_B4:
					num = (short)1636827138;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CC:
				num = (short)1431371776;
				short num4 = num;
				num = (short)640548865;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x001F2CD4 File Offset: 0x001F0ED4
		// (set) Token: 0x06001F2B RID: 7979 RVA: 0x001F2D88 File Offset: 0x001F0F88
		public string SecWideMultikeyListKeyName_A8362_UIValue
		{
			get
			{
				short num = (short)1037886178;
				short num2 = num;
				num = (short)372499170;
				switch (num2 == num)
				{
				}
				num = (short)1546321920;
				short num3 = num;
				num = (short)501481473;
				if (num != 0)
				{
				}
				num = (short)715522048;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.Value;
			}
			set
			{
				short num = (short)1243654047;
				short num2 = num;
				num = (short)776120223;
				switch (num2 == num)
				{
				}
				num = (short)442564608;
				short num3 = num;
				num = (short)1741357057;
				if (num != 0)
				{
				}
				num = (short)1970667520;
				if (num != 0)
				{
				}
				this.secWideMultikeyListKeyName_A8362.Value = value;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x001F2E3C File Offset: 0x001F103C
		public global::AcpBusinessLayer.AcpKeyField SecWideMultikeyListKeyName_A8362
		{
			get
			{
				short num = (short)368691821;
				short num2 = num;
				num = (short)212257389;
				switch (num2 == num)
				{
				}
				num = (short)1561853952;
				short num3 = num;
				num = (short)1828519937;
				if (num != 0)
				{
				}
				num = (short)570949632;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x001F2EEC File Offset: 0x001F10EC
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x001F2F9C File Offset: 0x001F119C
		public bool SecWideMultikeyListKeyName_A8362_Applicable
		{
			get
			{
				short num = (short)1100940231;
				short num2 = num;
				num = (short)507380679;
				switch (num2 == num)
				{
				}
				num = (short)1359872000;
				short num3 = num;
				num = (short)625672192;
				if (num != 0)
				{
				}
				num = (short)1681588225;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.Applicable;
			}
			set
			{
				short num = (short)324796417;
				if (num != 0)
				{
				}
				num = (short)2094954472;
				short num2 = num;
				num = (short)358709224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)834076672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1492254720;
				if (num != 0)
				{
				}
				this.secWideMultikeyListKeyName_A8362.Applicable = value;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x001F3054 File Offset: 0x001F1254
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x001F3108 File Offset: 0x001F1308
		public bool SecWideMultikeyListKeyName_A8362_Valid
		{
			get
			{
				short num = (short)446824449;
				if (num != 0)
				{
				}
				num = (short)1146803353;
				short num2 = num;
				num = (short)346936473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1279524864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1354956800;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.Valid;
			}
			set
			{
				short num = (short)1390149633;
				if (num != 0)
				{
				}
				num = (short)627548226;
				short num2 = num;
				num = (short)1916510274;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187774464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)261554176;
				if (num != 0)
				{
				}
				this.secWideMultikeyListKeyName_A8362.Valid = value;
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x001F31BC File Offset: 0x001F13BC
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x001F3270 File Offset: 0x001F1470
		public bool SecWideMultikeyListKeyName_A8362_Visible
		{
			get
			{
				short num = (short)661608376;
				short num2 = num;
				num = (short)789600184;
				switch (num2 == num)
				{
				}
				num = (short)1930690560;
				short num3 = num;
				num = (short)1239089153;
				if (num != 0)
				{
				}
				num = (short)1778581504;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.Visible;
			}
			set
			{
				short num = (short)66062891;
				short num2 = num;
				num = (short)1001130539;
				switch (num2 == num)
				{
				}
				num = (short)2118647808;
				short num3 = num;
				num = (short)1496711168;
				if (num != 0)
				{
				}
				num = (short)1073348609;
				if (num != 0)
				{
				}
				this.secWideMultikeyListKeyName_A8362.Visible = value;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x001F3324 File Offset: 0x001F1524
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x001F33DC File Offset: 0x001F15DC
		public bool SecWideMultikeyListKeyName_A8362_Editable
		{
			get
			{
				short num = (short)2048808042;
				short num2 = num;
				num = (short)236082282;
				switch (num2 == num)
				{
				}
				num = (short)1565327360;
				short num3 = num;
				num = (short)884932609;
				if (num != 0)
				{
				}
				num = (short)209846272;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.Editable;
			}
			set
			{
				short num = (short)1781363029;
				short num2 = num;
				num = (short)120615253;
				switch (num2 == num)
				{
				}
				num = (short)579534848;
				short num3 = num;
				num = (short)1109655553;
				if (num != 0)
				{
				}
				num = (short)1707868160;
				if (num != 0)
				{
				}
				this.secWideMultikeyListKeyName_A8362.Editable = value;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x001F3490 File Offset: 0x001F1690
		internal string SecWideMultikeyListKeyName_A8362_UILabel
		{
			get
			{
				short num = (short)2131499765;
				short num2 = num;
				num = (short)1484528373;
				switch (num2 == num)
				{
				}
				num = (short)1959854080;
				short num3 = num;
				num = (short)1157365760;
				if (num != 0)
				{
				}
				num = (short)44630017;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.UIName;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x001F3544 File Offset: 0x001F1744
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x001F35F8 File Offset: 0x001F17F8
		internal bool SecWideMultikeyListKeyName_A8362_HiddenStatic
		{
			get
			{
				short num = (short)10685810;
				short num2 = num;
				num = (short)182062450;
				switch (num2 == num)
				{
				}
				num = (short)905838592;
				short num3 = num;
				num = (short)1471545345;
				if (num != 0)
				{
				}
				num = (short)1205534720;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.HiddenStatic;
			}
			set
			{
				short num = (short)146034042;
				short num2 = num;
				num = (short)1825852794;
				switch (num2 == num)
				{
				}
				num = (short)2143617024;
				short num3 = num;
				num = (short)391774209;
				if (num != 0)
				{
				}
				num = (short)822607872;
				if (num != 0)
				{
				}
				this.secWideMultikeyListKeyName_A8362.HiddenStatic = value;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x001F36AC File Offset: 0x001F18AC
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x001F3760 File Offset: 0x001F1960
		internal bool SecWideMultikeyListKeyName_A8362_HiddenDynamic
		{
			get
			{
				short num = (short)565182339;
				short num2 = num;
				num = (short)1262419843;
				switch (num2 == num)
				{
				}
				num = (short)2035744768;
				short num3 = num;
				num = (short)1333329920;
				if (num != 0)
				{
				}
				num = (short)1194590209;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362.HiddenDynamic;
			}
			set
			{
				short num = (short)2100121068;
				short num2 = num;
				num = (short)195055084;
				switch (num2 == num)
				{
				}
				num = (short)696451072;
				short num3 = num;
				num = (short)1458569216;
				if (num != 0)
				{
				}
				num = (short)1488519169;
				if (num != 0)
				{
				}
				this.secWideMultikeyListKeyName_A8362.HiddenDynamic = value;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x001F3818 File Offset: 0x001F1A18
		public bool SecWideMultikeyListKeyName_A8362_HasDiffs
		{
			get
			{
				short num = (short)528832932;
				short num2 = num;
				num = (short)929847716;
				switch (num2 == num)
				{
				}
				num = (short)647036928;
				short num3 = num;
				num = (short)1525219328;
				if (num != 0)
				{
				}
				num = (short)371654657;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListKeyName_A8362._HasDiffs;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x001F38CC File Offset: 0x001F1ACC
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x001F3984 File Offset: 0x001F1B84
		public int SecWideMultikeyListSlotA_A9155Value
		{
			get
			{
				short num = (short)1349189633;
				if (num != 0)
				{
				}
				num = (short)1622849729;
				short num2 = num;
				num = (short)1584249025;
				switch (num2 == num)
				{
				default:
				{
					num = (short)849739776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)609091584;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.Value;
			}
			set
			{
				short num = (short)651874538;
				short num2 = num;
				num = (short)117559530;
				switch (num2 == num)
				{
				}
				num = (short)1255931904;
				short num3 = num;
				num = (short)1249771520;
				if (num != 0)
				{
				}
				num = (short)363659265;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.Value = value;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x001F3A38 File Offset: 0x001F1C38
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideMultikeyListSlotA_A9155
		{
			get
			{
				short num = (short)1301561602;
				short num2 = num;
				num = (short)1692156162;
				switch (num2 == num)
				{
				}
				num = (short)1805778944;
				short num3 = num;
				num = (short)1536688128;
				if (num != 0)
				{
				}
				num = (short)109117441;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x001F3AE8 File Offset: 0x001F1CE8
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x001F3B9C File Offset: 0x001F1D9C
		public string SecWideMultikeyListSlotA_A9155_UIValue
		{
			get
			{
				short num = (short)338005409;
				short num2 = num;
				num = (short)2087620001;
				switch (num2 == num)
				{
				}
				num = (short)711524352;
				short num3 = num;
				num = (short)1694040065;
				if (num != 0)
				{
				}
				num = (short)902234112;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.UIValue;
			}
			set
			{
				short num = (short)399991811;
				short num2 = num;
				num = (short)1864983555;
				switch (num2 == num)
				{
				}
				num = (short)1639448576;
				short num3 = num;
				num = (short)856358913;
				if (num != 0)
				{
				}
				num = (short)959971328;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.UIValue = value;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x001F3C50 File Offset: 0x001F1E50
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x001F3D04 File Offset: 0x001F1F04
		internal int SecWideMultikeyListSlotA_A9155Min
		{
			get
			{
				short num = (short)653706944;
				short num2 = num;
				num = (short)1831126720;
				switch (num2 == num)
				{
				}
				num = (short)533135360;
				short num3 = num;
				num = (short)844234753;
				if (num != 0)
				{
				}
				num = (short)1414660096;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.Min;
			}
			set
			{
				short num = (short)1263561750;
				short num2 = num;
				num = (short)570649622;
				switch (num2 == num)
				{
				}
				num = (short)163446784;
				short num3 = num;
				num = (short)867172353;
				if (num != 0)
				{
				}
				num = (short)2077622272;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.Min = value;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x001F3DBC File Offset: 0x001F1FBC
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x001F3E74 File Offset: 0x001F2074
		internal int SecWideMultikeyListSlotA_A9155Max
		{
			get
			{
				short num = (short)848933103;
				short num2 = num;
				num = (short)1812050159;
				switch (num2 == num)
				{
				}
				num = (short)660471808;
				short num3 = num;
				num = (short)1426915329;
				if (num != 0)
				{
				}
				num = (short)1067515904;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.Max;
			}
			set
			{
				short num = (short)341966848;
				short num2 = num;
				num = (short)1946353665;
				if (num != 0)
				{
				}
				num = (short)1038439700;
				short num3 = num;
				num = (short)422401300;
				switch (num3 == num)
				{
				}
				num = (short)960495616;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.Max = value;
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x001F3F24 File Offset: 0x001F2124
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x001F3FD4 File Offset: 0x001F21D4
		internal int SecWideMultikeyListSlotA_A9155Step
		{
			get
			{
				short num = (short)178782208;
				short num2 = num;
				num = (short)1532376305;
				short num3 = num;
				num = (short)840316145;
				switch (num3 == num)
				{
				}
				num = (short)963837952;
				if (num != 0)
				{
				}
				num = (short)2127691777;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.StepSize;
			}
			set
			{
				short num = (short)978780160;
				short num2 = num;
				num = (short)579849171;
				short num3 = num;
				num = (short)1624886227;
				switch (num3 == num)
				{
				}
				num = (short)259653633;
				if (num != 0)
				{
				}
				num = (short)1850802176;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.StepSize = value;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x001F4088 File Offset: 0x001F2288
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x001F4138 File Offset: 0x001F2338
		public bool SecWideMultikeyListSlotA_A9155_Applicable
		{
			get
			{
				short num = (short)1652817920;
				short num2 = num;
				num = (short)1499725825;
				if (num != 0)
				{
				}
				num = (short)180970356;
				short num3 = num;
				num = (short)1196122996;
				switch (num3 == num)
				{
				}
				num = (short)1375535104;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.Applicable;
			}
			set
			{
				short num = (short)488439808;
				short num2 = num;
				num = (short)1744457992;
				short num3 = num;
				num = (short)1375424776;
				switch (num3 == num)
				{
				}
				num = (short)1128333312;
				if (num != 0)
				{
				}
				num = (short)863436801;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.Applicable = value;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x001F41EC File Offset: 0x001F23EC
		// (set) Token: 0x06001F49 RID: 8009 RVA: 0x001F429C File Offset: 0x001F249C
		public bool SecWideMultikeyListSlotA_A9155_Valid
		{
			get
			{
				short num = (short)763428864;
				short num2 = num;
				num = (short)1380621880;
				short num3 = num;
				num = (short)1985846840;
				switch (num3 == num)
				{
				}
				num = (short)504037377;
				if (num != 0)
				{
				}
				num = (short)1313144832;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.Valid;
			}
			set
			{
				short num = (short)827719680;
				short num2 = num;
				num = (short)2047161960;
				short num3 = num;
				num = (short)1200436840;
				switch (num3 == num)
				{
				}
				num = (short)449970177;
				if (num != 0)
				{
				}
				num = (short)831193088;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.Valid = value;
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06001F4A RID: 8010 RVA: 0x001F4354 File Offset: 0x001F2554
		// (set) Token: 0x06001F4B RID: 8011 RVA: 0x001F4408 File Offset: 0x001F2608
		public bool SecWideMultikeyListSlotA_A9155_Visible
		{
			get
			{
				short num = (short)1231486976;
				short num2 = num;
				num = (short)1762976299;
				short num3 = num;
				num = (short)772792875;
				switch (num3 == num)
				{
				}
				num = (short)2086731776;
				if (num != 0)
				{
				}
				num = (short)1984430081;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.Visible;
			}
			set
			{
				short num = (short)1139605504;
				short num2 = num;
				num = (short)640674802;
				short num3 = num;
				num = (short)1558703090;
				switch (num3 == num)
				{
				}
				num = (short)369164289;
				if (num != 0)
				{
				}
				num = (short)1483800576;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.Visible = value;
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06001F4C RID: 8012 RVA: 0x001F44BC File Offset: 0x001F26BC
		// (set) Token: 0x06001F4D RID: 8013 RVA: 0x001F4574 File Offset: 0x001F2774
		public bool SecWideMultikeyListSlotA_A9155_Editable
		{
			get
			{
				short num = (short)1859059712;
				short num2 = num;
				num = (short)79401024;
				short num3 = num;
				num = (short)842829888;
				switch (num3 == num)
				{
				}
				num = (short)1187119105;
				if (num != 0)
				{
				}
				num = (short)1712783360;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.Editable;
			}
			set
			{
				short num = (short)2066350080;
				short num2 = num;
				num = (short)1983357185;
				short num3 = num;
				num = (short)2059903233;
				switch (num3 == num)
				{
				}
				num = (short)39321601;
				if (num != 0)
				{
				}
				num = (short)717225984;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.Editable = value;
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x001F462C File Offset: 0x001F282C
		internal string SecWideMultikeyListSlotA_A9155_UILabel
		{
			get
			{
				short num = (short)1417084928;
				short num2 = num;
				num = (short)1692093172;
				short num3 = num;
				num = (short)1940605684;
				switch (num3 == num)
				{
				}
				num = (short)674627584;
				if (num != 0)
				{
				}
				num = (short)1505755137;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.UIName;
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x001F46E4 File Offset: 0x001F28E4
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x001F4798 File Offset: 0x001F2998
		internal bool SecWideMultikeyListSlotA_A9155_HiddenStatic
		{
			get
			{
				short num = (short)1760428032;
				short num2 = num;
				num = (short)920720126;
				short num3 = num;
				num = (short)1289687806;
				switch (num3 == num)
				{
				}
				num = (short)2132279297;
				if (num != 0)
				{
				}
				num = (short)1653342208;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.HiddenStatic;
			}
			set
			{
				short num = (short)841285632;
				short num2 = num;
				num = (short)691405767;
				short num3 = num;
				num = (short)1640301511;
				switch (num3 == num)
				{
				}
				num = (short)959840257;
				if (num != 0)
				{
				}
				num = (short)180027392;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.HiddenStatic = value;
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x001F484C File Offset: 0x001F2A4C
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x001F4900 File Offset: 0x001F2B00
		internal bool SecWideMultikeyListSlotA_A9155_HiddenDynamic
		{
			get
			{
				short num = (short)475791360;
				short num2 = num;
				num = (short)244029011;
				short num3 = num;
				num = (short)2019792467;
				switch (num3 == num)
				{
				}
				num = (short)872873984;
				if (num != 0)
				{
				}
				num = (short)1083441153;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155.HiddenDynamic;
			}
			set
			{
				short num = (short)710410240;
				short num2 = num;
				num = (short)1288962049;
				if (num != 0)
				{
				}
				num = (short)1945429710;
				short num3 = num;
				num = (short)1246947022;
				switch (num3 == num)
				{
				}
				num = (short)1521025024;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotA_A9155.HiddenDynamic = value;
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x001F49B8 File Offset: 0x001F2BB8
		public bool SecWideMultikeyListSlotA_A9155_HasDiffs
		{
			get
			{
				short num = (short)1329528832;
				short num2 = num;
				num = (short)89522177;
				if (num != 0)
				{
				}
				num = (short)11164792;
				short num3 = num;
				num = (short)607476856;
				switch (num3 == num)
				{
				}
				num = (short)1373372416;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotA_A9155._HasDiffs;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x001F4A70 File Offset: 0x001F2C70
		// (set) Token: 0x06001F55 RID: 8021 RVA: 0x001F4B24 File Offset: 0x001F2D24
		public int SecWideMultikeyListSlotB_A9158Value
		{
			get
			{
				short num = (short)1132003328;
				short num2 = num;
				num = (short)1115821909;
				short num3 = num;
				num = (short)1442387797;
				switch (num3 == num)
				{
				}
				num = (short)199819265;
				if (num != 0)
				{
				}
				num = (short)1289814016;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.Value;
			}
			set
			{
				short num = (short)1377894400;
				short num2 = num;
				num = (short)147863582;
				short num3 = num;
				num = (short)1829320734;
				switch (num3 == num)
				{
				}
				num = (short)381353984;
				if (num != 0)
				{
				}
				num = (short)1862795265;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.Value = value;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x001F4BDC File Offset: 0x001F2DDC
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideMultikeyListSlotB_A9158
		{
			get
			{
				short num = (short)2127691776;
				short num2 = num;
				num = (short)1101367331;
				short num3 = num;
				num = (short)1161136163;
				switch (num3 == num)
				{
				}
				num = (short)1641807873;
				if (num != 0)
				{
				}
				num = (short)1444282368;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x001F4C8C File Offset: 0x001F2E8C
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x001F4D40 File Offset: 0x001F2F40
		public string SecWideMultikeyListSlotB_A9158_UIValue
		{
			get
			{
				short num = (short)584712192;
				short num2 = num;
				num = (short)1529544705;
				if (num != 0)
				{
				}
				num = (short)442073579;
				short num3 = num;
				num = (short)1051427307;
				switch (num3 == num)
				{
				}
				num = (short)266731520;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.UIValue;
			}
			set
			{
				short num = (short)2035286016;
				short num2 = num;
				num = (short)1486042733;
				short num3 = num;
				num = (short)2135045741;
				switch (num3 == num)
				{
				}
				num = (short)1196163072;
				if (num != 0)
				{
				}
				num = (short)1986789377;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.UIValue = value;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x001F4DF4 File Offset: 0x001F2FF4
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x001F4EA8 File Offset: 0x001F30A8
		internal int SecWideMultikeyListSlotB_A9158Min
		{
			get
			{
				short num = (short)339083264;
				short num2 = num;
				num = (short)1410203649;
				if (num != 0)
				{
				}
				num = (short)1251389211;
				short num3 = num;
				num = (short)1153281819;
				switch (num3 == num)
				{
				}
				num = (short)1516961792;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.Min;
			}
			set
			{
				short num = (short)432144384;
				short num2 = num;
				num = (short)2110455809;
				if (num != 0)
				{
				}
				num = (short)2090308892;
				short num3 = num;
				num = (short)714380572;
				switch (num3 == num)
				{
				}
				num = (short)1868038144;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.Min = value;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x001F4F5C File Offset: 0x001F315C
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x001F5010 File Offset: 0x001F3210
		internal int SecWideMultikeyListSlotB_A9158Max
		{
			get
			{
				short num = (short)16580608;
				short num2 = num;
				num = (short)2094156136;
				short num3 = num;
				num = (short)1466452328;
				switch (num3 == num)
				{
				}
				num = (short)297467905;
				if (num != 0)
				{
				}
				num = (short)21102592;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.Max;
			}
			set
			{
				short num = (short)402522112;
				short num2 = num;
				num = (short)1589136199;
				short num3 = num;
				num = (short)535120711;
				switch (num3 == num)
				{
				}
				num = (short)1584660480;
				if (num != 0)
				{
				}
				num = (short)664666113;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.Max = value;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x001F50C4 File Offset: 0x001F32C4
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x001F517C File Offset: 0x001F337C
		internal int SecWideMultikeyListSlotB_A9158Step
		{
			get
			{
				short num = (short)1443102720;
				short num2 = num;
				num = (short)267608181;
				short num3 = num;
				num = (short)690249845;
				switch (num3 == num)
				{
				}
				num = (short)1266024449;
				if (num != 0)
				{
				}
				num = (short)789839872;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.StepSize;
			}
			set
			{
				short num = (short)1414660096;
				short num2 = num;
				num = (short)1121333354;
				short num3 = num;
				num = (short)1193291882;
				switch (num3 == num)
				{
				}
				num = (short)1693974529;
				if (num != 0)
				{
				}
				num = (short)2093678592;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.StepSize = value;
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x001F5234 File Offset: 0x001F3434
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x001F52E8 File Offset: 0x001F34E8
		public bool SecWideMultikeyListSlotB_A9158_Applicable
		{
			get
			{
				short num = (short)2057240576;
				short num2 = num;
				num = (short)1649410049;
				if (num != 0)
				{
				}
				num = (short)283839097;
				short num3 = num;
				num = (short)2012220025;
				switch (num3 == num)
				{
				}
				num = (short)1661337600;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.Applicable;
			}
			set
			{
				short num = (short)1243611136;
				short num2 = num;
				num = (short)1372900144;
				short num3 = num;
				num = (short)1878051632;
				switch (num3 == num)
				{
				}
				num = (short)1610547201;
				if (num != 0)
				{
				}
				num = (short)856948736;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.Applicable = value;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x001F53A0 File Offset: 0x001F35A0
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x001F5454 File Offset: 0x001F3654
		public bool SecWideMultikeyListSlotB_A9158_Valid
		{
			get
			{
				short num = (short)498466816;
				short num2 = num;
				num = (short)458063583;
				short num3 = num;
				num = (short)1161199327;
				switch (num3 == num)
				{
				}
				num = (short)579272705;
				if (num != 0)
				{
				}
				num = (short)1434320896;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.Valid;
			}
			set
			{
				short num = (short)1066467328;
				short num2 = num;
				num = (short)629989598;
				short num3 = num;
				num = (short)412541150;
				switch (num3 == num)
				{
				}
				num = (short)1973288961;
				if (num != 0)
				{
				}
				num = (short)50331648;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.Valid = value;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x001F550C File Offset: 0x001F370C
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x001F55BC File Offset: 0x001F37BC
		public bool SecWideMultikeyListSlotB_A9158_Visible
		{
			get
			{
				short num = (short)177471488;
				short num2 = num;
				num = (short)860053078;
				short num3 = num;
				num = (short)1045847638;
				switch (num3 == num)
				{
				}
				num = (short)436862977;
				if (num != 0)
				{
				}
				num = (short)612302848;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.Visible;
			}
			set
			{
				short num = (short)2031616000;
				short num2 = num;
				num = (short)2080658136;
				short num3 = num;
				num = (short)93541080;
				switch (num3 == num)
				{
				}
				num = (short)1673986049;
				if (num != 0)
				{
				}
				num = (short)552992768;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.Visible = value;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x001F5670 File Offset: 0x001F3870
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x001F5724 File Offset: 0x001F3924
		public bool SecWideMultikeyListSlotB_A9158_Editable
		{
			get
			{
				short num = (short)1361182720;
				short num2 = num;
				num = (short)1697579009;
				if (num != 0)
				{
				}
				num = (short)1368859348;
				short num3 = num;
				num = (short)1146364628;
				switch (num3 == num)
				{
				}
				num = (short)718209024;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.Editable;
			}
			set
			{
				short num = (short)390266880;
				short num2 = num;
				num = (short)2016124840;
				short num3 = num;
				num = (short)2142937000;
				switch (num3 == num)
				{
				}
				num = (short)211025921;
				if (num != 0)
				{
				}
				num = (short)1119617024;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.Editable = value;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x001F57DC File Offset: 0x001F39DC
		internal string SecWideMultikeyListSlotB_A9158_UILabel
		{
			get
			{
				short num = (short)1234501632;
				short num2 = num;
				num = (short)1777980526;
				short num3 = num;
				num = (short)3069038;
				switch (num3 == num)
				{
				}
				num = (short)1472528385;
				if (num != 0)
				{
				}
				num = (short)2088960000;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.UIName;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x001F5894 File Offset: 0x001F3A94
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x001F5948 File Offset: 0x001F3B48
		internal bool SecWideMultikeyListSlotB_A9158_HiddenStatic
		{
			get
			{
				short num = (short)757137408;
				short num2 = num;
				num = (short)77919299;
				short num3 = num;
				num = (short)2131752003;
				switch (num3 == num)
				{
				}
				num = (short)1283325953;
				if (num != 0)
				{
				}
				num = (short)1860239360;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.HiddenStatic;
			}
			set
			{
				short num = (short)381812736;
				short num2 = num;
				num = (short)229357858;
				short num3 = num;
				num = (short)538425634;
				switch (num3 == num)
				{
				}
				num = (short)571146241;
				if (num != 0)
				{
				}
				num = (short)1459093504;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.HiddenStatic = value;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x001F5A04 File Offset: 0x001F3C04
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x001F5AB8 File Offset: 0x001F3CB8
		internal bool SecWideMultikeyListSlotB_A9158_HiddenDynamic
		{
			get
			{
				short num = (short)1492844544;
				short num2 = num;
				num = (short)1993670657;
				if (num != 0)
				{
				}
				num = (short)1554298418;
				short num3 = num;
				num = (short)664188466;
				switch (num3 == num)
				{
				}
				num = (short)306642944;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158.HiddenDynamic;
			}
			set
			{
				short num = (short)517406720;
				short num2 = num;
				num = (short)675298029;
				short num3 = num;
				num = (short)267598573;
				switch (num3 == num)
				{
				}
				num = (short)1757741056;
				if (num != 0)
				{
				}
				num = (short)597426177;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSlotB_A9158.HiddenDynamic = value;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x001F5B6C File Offset: 0x001F3D6C
		public bool SecWideMultikeyListSlotB_A9158_HasDiffs
		{
			get
			{
				short num = (short)252837888;
				short num2 = num;
				num = (short)1368588289;
				if (num != 0)
				{
				}
				num = (short)575158474;
				short num3 = num;
				num = (short)836581578;
				switch (num3 == num)
				{
				}
				num = (short)952500224;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSlotB_A9158._HasDiffs;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x001F5C24 File Offset: 0x001F3E24
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x001F5CDC File Offset: 0x001F3EDC
		public string SecWideMultikeyListSelectableADPKeyID_A9107Value
		{
			get
			{
				short num = (short)334233600;
				short num2 = num;
				num = (short)1138041215;
				short num3 = num;
				num = (short)2088313215;
				switch (num3 == num)
				{
				}
				num = (short)646184961;
				if (num != 0)
				{
				}
				num = (short)1314979840;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.Value;
			}
			set
			{
				short num = (short)1170866176;
				short num2 = num;
				num = (short)819510585;
				short num3 = num;
				num = (short)371899705;
				switch (num3 == num)
				{
				}
				num = (short)668270592;
				if (num != 0)
				{
				}
				num = (short)1742536705;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyID_A9107.Value = value;
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x001F5D94 File Offset: 0x001F3F94
		public global::AcpBusinessLayer.AcpField<string> SecWideMultikeyListSelectableADPKeyID_A9107
		{
			get
			{
				short num = (short)52887552;
				short num2 = num;
				num = (short)2119458433;
				short num3 = num;
				num = (short)1822908033;
				switch (num3 == num)
				{
				}
				num = (short)1652228097;
				if (num != 0)
				{
				}
				num = (short)1622540288;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x001F5E44 File Offset: 0x001F4044
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x001F5EF8 File Offset: 0x001F40F8
		public string SecWideMultikeyListSelectableADPKeyID_A9107_UIValue
		{
			get
			{
				short num = (short)2028797952;
				short num2 = num;
				num = (short)363463415;
				short num3 = num;
				num = (short)392299255;
				switch (num3 == num)
				{
				}
				num = (short)283836416;
				if (num != 0)
				{
				}
				num = (short)1389821953;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.Value;
			}
			set
			{
				short num = (short)1941897216;
				short num2 = num;
				num = (short)1346324133;
				short num3 = num;
				num = (short)291456677;
				switch (num3 == num)
				{
				}
				num = (short)371392513;
				if (num != 0)
				{
				}
				num = (short)345440256;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyID_A9107.Value = value;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x001F5FB0 File Offset: 0x001F41B0
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x001F6068 File Offset: 0x001F4268
		public bool SecWideMultikeyListSelectableADPKeyID_A9107_Applicable
		{
			get
			{
				short num = (short)948174848;
				short num2 = num;
				num = (short)1822733562;
				short num3 = num;
				num = (short)1000322298;
				switch (num3 == num)
				{
				}
				num = (short)1057030145;
				if (num != 0)
				{
				}
				num = (short)1689583616;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.Applicable;
			}
			set
			{
				short num = (short)1469775872;
				short num2 = num;
				num = (short)329661079;
				short num3 = num;
				num = (short)578566807;
				switch (num3 == num)
				{
				}
				num = (short)1424752640;
				if (num != 0)
				{
				}
				num = (short)1431633921;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyID_A9107.Applicable = value;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x001F611C File Offset: 0x001F431C
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x001F61D0 File Offset: 0x001F43D0
		public bool SecWideMultikeyListSelectableADPKeyID_A9107_Valid
		{
			get
			{
				short num = (short)503709696;
				short num2 = num;
				num = (short)341924403;
				short num3 = num;
				num = (short)1843354163;
				switch (num3 == num)
				{
				}
				num = (short)603258880;
				if (num != 0)
				{
				}
				num = (short)1474691073;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.Valid;
			}
			set
			{
				short num = (short)1096417280;
				short num2 = num;
				num = (short)582365480;
				short num3 = num;
				num = (short)178008360;
				switch (num3 == num)
				{
				}
				num = (short)873791489;
				if (num != 0)
				{
				}
				num = (short)1730871296;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyID_A9107.Valid = value;
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x001F6288 File Offset: 0x001F4488
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x001F633C File Offset: 0x001F453C
		public bool SecWideMultikeyListSelectableADPKeyID_A9107_Visible
		{
			get
			{
				short num = (short)300548097;
				if (num != 0)
				{
				}
				num = (short)590479360;
				short num2 = num;
				num = (short)208096429;
				short num3 = num;
				num = (short)1630096557;
				switch (num3 == num)
				{
				}
				num = (short)997457920;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.Visible;
			}
			set
			{
				short num = (short)714575522;
				short num2 = num;
				num = (short)2092797602;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579665920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)207683585;
				if (num != 0)
				{
				}
				num = (short)1895956480;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyID_A9107.Visible = value;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x001F63F4 File Offset: 0x001F45F4
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x001F64AC File Offset: 0x001F46AC
		public bool SecWideMultikeyListSelectableADPKeyID_A9107_Editable
		{
			get
			{
				short num = (short)324264947;
				short num2 = num;
				num = (short)1355473907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1104936960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)70844417;
				if (num != 0)
				{
				}
				num = (short)1984167936;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.Editable;
			}
			set
			{
				short num = (short)949497604;
				short num2 = num;
				num = (short)967126788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2080309248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1413152769;
				if (num != 0)
				{
				}
				num = (short)1294073856;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyID_A9107.Editable = value;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x001F6560 File Offset: 0x001F4760
		internal string SecWideMultikeyListSelectableADPKeyID_A9107_UILabel
		{
			get
			{
				short num = (short)1317936806;
				short num2 = num;
				num = (short)2075008678;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1222443008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1859321857;
				if (num != 0)
				{
				}
				num = (short)630456320;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.UIName;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x001F6614 File Offset: 0x001F4814
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x001F66CC File Offset: 0x001F48CC
		internal bool SecWideMultikeyListSelectableADPKeyID_A9107_HiddenStatic
		{
			get
			{
				short num = (short)736789973;
				short num2 = num;
				num = (short)1795196373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1562968064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1115488256;
				if (num != 0)
				{
				}
				num = (short)2135031809;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.HiddenStatic;
			}
			set
			{
				short num = (short)1944336055;
				short num2 = num;
				num = (short)1438725815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527054336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1921449985;
				if (num != 0)
				{
				}
				num = (short)1351155712;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyID_A9107.HiddenStatic = value;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x001F6780 File Offset: 0x001F4980
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x001F6834 File Offset: 0x001F4A34
		internal bool SecWideMultikeyListSelectableADPKeyID_A9107_HiddenDynamic
		{
			get
			{
				short num = (short)310319627;
				short num2 = num;
				num = (short)1760238091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1275527168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1191247873;
				if (num != 0)
				{
				}
				num = (short)2120679424;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107.HiddenDynamic;
			}
			set
			{
				short num = (short)1806697920;
				short num2 = num;
				num = (short)1528956352;
				switch (num2 == num)
				{
				default:
				{
					num = (short)649330688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)292159488;
				if (num != 0)
				{
				}
				num = (short)1698234369;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyID_A9107.HiddenDynamic = value;
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x001F68EC File Offset: 0x001F4AEC
		public bool SecWideMultikeyListSelectableADPKeyID_A9107_HasDiffs
		{
			get
			{
				short num = (short)1192574403;
				short num2 = num;
				num = (short)1205878211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1790509056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1692073984;
				if (num != 0)
				{
				}
				num = (short)1745485825;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyID_A9107._HasDiffs;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x001F69A0 File Offset: 0x001F4BA0
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x001F6A5C File Offset: 0x001F4C5C
		public string SecWideMultikeyListSelectableADPKeyData_A9106Value
		{
			get
			{
				short num = (short)530186241;
				if (num != 0)
				{
				}
				num = (short)1891172352;
				short num2 = num;
				num = (short)751896061;
				short num3 = num;
				num = (short)1291716093;
				switch (num3 == num)
				{
				}
				num = (short)1895497728;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.Value;
			}
			set
			{
				short num = (short)1907808177;
				short num2 = num;
				num = (short)2135349169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)516292608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1477640192;
				if (num != 0)
				{
				}
				num = (short)952565761;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106.Value = value;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x001F6B10 File Offset: 0x001F4D10
		public global::AcpBusinessLayer.AcpField<string> SecWideMultikeyListSelectableADPKeyData_A9106
		{
			get
			{
				short num = (short)392503490;
				short num2 = num;
				num = (short)2123440322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1839267840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1502740480;
				if (num != 0)
				{
				}
				num = (short)473235457;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106;
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x001F6BC0 File Offset: 0x001F4DC0
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x001F6C74 File Offset: 0x001F4E74
		public string SecWideMultikeyListSelectableADPKeyData_A9106_UIValue
		{
			get
			{
				short num = (short)102830433;
				short num2 = num;
				num = (short)1658065249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043740160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)250609664;
				if (num != 0)
				{
				}
				num = (short)1112997889;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.Value;
			}
			set
			{
				short num = (short)349224994;
				short num2 = num;
				num = (short)1284685858;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1531772928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113929217;
				if (num != 0)
				{
				}
				num = (short)679936000;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106.Value = value;
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x001F6D28 File Offset: 0x001F4F28
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x001F6DDC File Offset: 0x001F4FDC
		public bool SecWideMultikeyListSelectableADPKeyData_A9106_Applicable
		{
			get
			{
				short num = (short)1767894173;
				short num2 = num;
				num = (short)1840901277;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1033568256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1320091648;
				if (num != 0)
				{
				}
				num = (short)710803457;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.Applicable;
			}
			set
			{
				short num = (short)2041708545;
				if (num != 0)
				{
				}
				num = (short)825688064;
				short num2 = num;
				num = (short)1764933670;
				short num3 = num;
				num = (short)900710438;
				switch (num3 == num)
				{
				}
				num = (short)586481664;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106.Applicable = value;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x001F6E94 File Offset: 0x001F5094
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x001F6F4C File Offset: 0x001F514C
		public bool SecWideMultikeyListSelectableADPKeyData_A9106_Valid
		{
			get
			{
				short num = (short)493543666;
				short num2 = num;
				num = (short)833282290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413283840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1755447297;
				if (num != 0)
				{
				}
				num = (short)136773632;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.Valid;
			}
			set
			{
				short num = (short)713094827;
				short num2 = num;
				num = (short)576255659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238433792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)28704769;
				if (num != 0)
				{
				}
				num = (short)1294204928;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106.Valid = value;
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x001F7000 File Offset: 0x001F5200
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x001F70B4 File Offset: 0x001F52B4
		public bool SecWideMultikeyListSelectableADPKeyData_A9106_Visible
		{
			get
			{
				short num = (short)209850975;
				short num2 = num;
				num = (short)120918623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002190336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)33226753;
				if (num != 0)
				{
				}
				num = (short)1793327104;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.Visible;
			}
			set
			{
				short num = (short)112027700;
				short num2 = num;
				num = (short)953575476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1857159168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1526792193;
				if (num != 0)
				{
				}
				num = (short)1667497984;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106.Visible = value;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x001F716C File Offset: 0x001F536C
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x001F7220 File Offset: 0x001F5420
		public bool SecWideMultikeyListSelectableADPKeyData_A9106_Editable
		{
			get
			{
				short num = (short)1422065665;
				if (num != 0)
				{
				}
				num = (short)628621312;
				short num2 = num;
				num = (short)402480690;
				short num3 = num;
				num = (short)2143313458;
				switch (num3 == num)
				{
				}
				num = (short)92536832;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.Editable;
			}
			set
			{
				short num = (short)636322283;
				short num2 = num;
				num = (short)358711787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1307770880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1029701632;
				if (num != 0)
				{
				}
				num = (short)1657798657;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106.Editable = value;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x001F72D4 File Offset: 0x001F54D4
		internal string SecWideMultikeyListSelectableADPKeyData_A9106_UILabel
		{
			get
			{
				short num = (short)1805602102;
				short num2 = num;
				num = (short)278482230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)352976896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2091188224;
				if (num != 0)
				{
				}
				num = (short)104071169;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.UIName;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x001F7388 File Offset: 0x001F5588
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x001F743C File Offset: 0x001F563C
		internal bool SecWideMultikeyListSelectableADPKeyData_A9106_HiddenStatic
		{
			get
			{
				short num = (short)1857571105;
				short num2 = num;
				num = (short)1047087393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)117440512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)634454016;
				if (num != 0)
				{
				}
				num = (short)1491206145;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.HiddenStatic;
			}
			set
			{
				short num = (short)1781929197;
				short num2 = num;
				num = (short)428807405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)750714880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1117061121;
				if (num != 0)
				{
				}
				num = (short)1177288704;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106.HiddenStatic = value;
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06001F90 RID: 8080 RVA: 0x001F74F0 File Offset: 0x001F56F0
		// (set) Token: 0x06001F91 RID: 8081 RVA: 0x001F75A4 File Offset: 0x001F57A4
		internal bool SecWideMultikeyListSelectableADPKeyData_A9106_HiddenDynamic
		{
			get
			{
				short num = (short)1145044993;
				if (num != 0)
				{
				}
				num = (short)663945216;
				short num2 = num;
				num = (short)2036134370;
				short num3 = num;
				num = (short)1613099490;
				switch (num3 == num)
				{
				}
				num = (short)1476460544;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106.HiddenDynamic;
			}
			set
			{
				short num = (short)1642411675;
				short num2 = num;
				num = (short)1064646299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)20250624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1469972480;
				if (num != 0)
				{
				}
				num = (short)528285697;
				if (num != 0)
				{
				}
				this.secWideMultikeyListSelectableADPKeyData_A9106.HiddenDynamic = value;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06001F92 RID: 8082 RVA: 0x001F7658 File Offset: 0x001F5858
		public bool SecWideMultikeyListSelectableADPKeyData_A9106_HasDiffs
		{
			get
			{
				short num = (short)1964983920;
				short num2 = num;
				num = (short)823477872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1087111168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1878327297;
				if (num != 0)
				{
				}
				num = (short)1810300928;
				if (num != 0)
				{
				}
				return this.secWideMultikeyListSelectableADPKeyData_A9106._HasDiffs;
			}
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x001F770C File Offset: 0x001F590C
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
				{
					num2 = (short)1663696896;
					short num3 = num2;
					num2 = (short)1365311490;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					for (;;)
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1103824034;
						short num4 = num2;
						num2 = (short)660210850;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_D0;
						}
					}
					IL_D0:
					num2 = (short)179765248;
					if (num2 != 0)
					{
					}
					num2 = (short)2126315521;
					if (num2 != 0)
					{
					}
					num2 = (short)491454467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1722351617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1088815104;
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
			num2 = (short)582746116;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000BB3 RID: 2995
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideMultikeyListCKR_A7665;

		// Token: 0x04000BB4 RID: 2996
		private global::AcpBusinessLayer.AcpField<bool> secWideMultikeyListIndexed_A8282;

		// Token: 0x04000BB5 RID: 2997
		private global::AcpBusinessLayer.AcpKeyField secWideMultikeyListKeyName_A8362;

		// Token: 0x04000BB6 RID: 2998
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideMultikeyListSlotA_A9155;

		// Token: 0x04000BB7 RID: 2999
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideMultikeyListSlotB_A9158;

		// Token: 0x04000BB8 RID: 3000
		private global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyID_A9107;

		// Token: 0x04000BB9 RID: 3001
		private global::AcpBusinessLayer.AcpField<string> secWideMultikeyListSelectableADPKeyData_A9106;
	}
}
