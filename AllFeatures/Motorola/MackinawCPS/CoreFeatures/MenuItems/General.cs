using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Switches;

namespace Motorola.MackinawCPS.CoreFeatures.MenuItems
{
	// Token: 0x020002F8 RID: 760
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007A48 RID: 31304 RVA: 0x006F563C File Offset: 0x006F383C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x006F5658 File Offset: 0x006F3858
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x006F5670 File Offset: 0x006F3870
		public override void Init()
		{
			int a_ = 8;
			short num = (short)50499580;
			short num2 = num;
			num = (short)839618556;
			switch (num2 == num)
			{
			}
			num = (short)1119289344;
			if (num != 0)
			{
			}
			num = (short)590217217;
			if (num != 0)
			{
			}
			num = (short)1246887936;
			short num3 = num;
			this.dispMenuTrunkingSelectedMenuItems_A21735 = new global::AcpBusinessLayer.AcpSparseLOVField(new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.indexDispMenuTrunkingSelectedMenuItems_A21735LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.idDispMenuTrunkingSelectedMenuItems_A21735LovStrs), this, global::AllFeatures.CodeplugGuid.b("跈ꋊ뻌뿎鳐뛒믔ꋖ跘꧚꣜뇞諠諢诤胦뫨軪臬諮鋰蟲郴鏶듸黺鏼諾䠀眂怄樆稈吊䰌㴎‐␒☔∖", a_), global::CommonResources.AcgResources.ID_TRUNKINGSELECTEDMENUITEMS, new string[]
			{
				global::CommonResources.AcgResources.ID_ZONE_1
			}, true);
			this.dispMenuTrunkingSelectedMenuItems_A21735.UndoIgnoresSelection = true;
			this.dispMenuTrunkingSelectedMenuItems_A21735.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuTrunkingSelectedMenuItems_A21735.DataTransferOrder = 35;
			this.dispMenuConventionalSelectedMenuItems_A21736 = new global::AcpBusinessLayer.AcpSparseLOVField(new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.indexDispMenuConventionalSelectedMenuItems_A21736LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.idDispMenuConventionalSelectedMenuItems_A21736LovStrs), this, global::AllFeatures.CodeplugGuid.b("跈ꋊ뻌뿎鳐뛒믔ꋖ高듚돜꧞蓠跢釤軦蛨藪賬菮ꋰ雲駴鋶髸迺飼鯾䰀昂欄爆䀈缊栌戎成䰒吔┖⠘Ⱊ⸜⤞", a_), global::CommonResources.AcgResources.ID_CONVENTIONALSELECTEDMENUITEMS, new string[]
			{
				global::CommonResources.AcgResources.ID_ZONE_1
			}, true);
			this.dispMenuConventionalSelectedMenuItems_A21736.UndoIgnoresSelection = true;
			this.dispMenuConventionalSelectedMenuItems_A21736.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuConventionalSelectedMenuItems_A21736.DataTransferOrder = 36;
			this.dispMenuConventionalAvailableMenuItems_A22666 = new global::AcpBusinessLayer.AcpSparseLOVField(28, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.indexDispMenuConventionalAvailableMenuItems_A22666LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.idDispMenuConventionalAvailableMenuItems_A22666LovStrs), this, global::AllFeatures.CodeplugGuid.b("跈ꋊ뻌뿎鳐뛒믔ꋖ高듚돜꧞蓠跢釤軦蛨藪賬菮냰藲铴黶闸髺鿼鏾搀丂怄椆簈䈊礌樎簐怒䨔嘖⬘⤚⬜⤞ᜠ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALAVAILABLEMENUITEMS, true, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.DispMenuConventionalAvailableMenuItems_A22666LovStrs);
			this.dispMenuConventionalAvailableMenuItems_A22666.IgnoreOnCompare = true;
			this.dispMenuConventionalAvailableMenuItems_A22666.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuConventionalAvailableMenuItems_A22666.DataTransferOrder = -1;
			this.dispMenuTrunkingAvailableMenuItems_A22667 = new global::AcpBusinessLayer.AcpSparseLOVField(28, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.indexDispMenuTrunkingAvailableMenuItems_A22667LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.idDispMenuTrunkingAvailableMenuItems_A22667LovStrs), this, global::AllFeatures.CodeplugGuid.b("跈ꋊ뻌뿎鳐뛒믔ꋖ跘꧚꣜뇞諠諢诤胦꣨鷪賬蛮鷰鋲韴鯶鳸뛺飼釾琀䨂焄戆搈砊刌与⌐ℒ⌔№⸘", a_), global::CommonResources.AcgResources.ID_TRUNKINGAVAILABLEMENUITEMS, true, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.DispMenuTrunkingAvailableMenuItems_A22667LovStrs);
			this.dispMenuTrunkingAvailableMenuItems_A22667.IgnoreOnCompare = true;
			this.dispMenuTrunkingAvailableMenuItems_A22667.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dispMenuTrunkingAvailableMenuItems_A22667.DataTransferOrder = -1;
			this.dispMenuTrunkingSelectedMenuItems_A21735.BuddyList = this.dispMenuTrunkingAvailableMenuItems_A22667;
			this.dispMenuConventionalSelectedMenuItems_A21736.BuddyList = this.dispMenuConventionalAvailableMenuItems_A22666;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈껊ꏌ꫎ꏐ닒맔", a_);
			base.Id = 10024;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x006F58EC File Offset: 0x006F3AEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1722286081;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)192610304;
					short num3 = num;
					this.dispMenuTrunkingSelectedMenuItems_A21735 = new global::AcpBusinessLayer.AcpSparseLOVField(new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.indexDispMenuTrunkingSelectedMenuItems_A21735LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.idDispMenuTrunkingSelectedMenuItems_A21735LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚觜귞铠跢軤軦蟨質뻬諮鷰雲雴菶鳸鿺냼髾漀瘂䰄猆氈昊縌倎倐ℒ␔‖⨘⸚", a_), global::CommonResources.AcgResources.ID_TRUNKINGSELECTEDMENUITEMS, new string[]
					{
						global::CommonResources.AcgResources.ID_ZONE_1
					}, true);
					this.dispMenuTrunkingSelectedMenuItems_A21735.UndoIgnoresSelection = true;
					this.dispMenuTrunkingSelectedMenuItems_A21735.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dispMenuTrunkingSelectedMenuItems_A21735.DataTransferOrder = 35;
					num = (short)2034040845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚黜냞迠闢胤触鷨苪苬臮郰鿲꛴鋶闸黺黼课搀朂䠄戆月縊䐌笎琐縒昔䠖堘⤚Ⱌ⠞ሠᔢ", a_)))
					{
						num = (short)3801094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56D;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚觜귞铠跢軤軦蟨質뻬諮鷰雲雴菶鳸鿺냼髾漀瘂䰄猆氈昊縌倎倐ℒ␔‖⨘⸚", a_)))
					{
						num = (short)1456472064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A6;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚觜귞铠跢軤軦蟨質곬駮郰髲駴零鯸韺飼닾搀洂瀄丆紈渊怌簎丐划✔┖⼘ⴚ⨜", a_)))
					{
						num = (short)275709966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚黜냞迠闢胤触鷨苪苬臮郰鿲꛴鋶闸黺黼课搀朂䠄戆月縊䐌笎琐縒昔䠖堘⤚Ⱌ⠞ሠᔢ", a_)))
					{
						num = (short)983105552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35A;
				case 6:
					this.dispMenuConventionalSelectedMenuItems_A21736.BuddyList = this.dispMenuConventionalAvailableMenuItems_A22666;
					num = (short)1525350420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.dispMenuConventionalAvailableMenuItems_A22666 = new global::AcpBusinessLayer.AcpSparseLOVField(28, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.indexDispMenuConventionalAvailableMenuItems_A22666LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.idDispMenuConventionalAvailableMenuItems_A22666LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚黜냞迠闢胤触鷨苪苬臮郰鿲듴臶飸鋺釼黾挀漂怄䨆氈攊砌䘎攐瘒研搖䘘娚⼜ⴞᜠᔢጤ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALAVAILABLEMENUITEMS, true, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.DispMenuConventionalAvailableMenuItems_A22666LovStrs);
					this.dispMenuConventionalAvailableMenuItems_A22666.IgnoreOnCompare = true;
					this.dispMenuConventionalAvailableMenuItems_A22666.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dispMenuConventionalAvailableMenuItems_A22666.DataTransferOrder = -1;
					num = (short)890306571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_35A;
				case 9:
					this.dispMenuTrunkingSelectedMenuItems_A21735.BuddyList = this.dispMenuTrunkingAvailableMenuItems_A22667;
					num = (short)2078539791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1933126362;
					short num4 = num;
					num = (short)452995802;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_41E;
					default:
						num = (short)1223557120;
						if (num != 0)
						{
						}
						num = (short)576192515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					goto IL_41E;
				case 12:
					if (producerFields != null)
					{
						num = (short)367394826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56D;
				case 13:
					goto IL_3A6;
				case 14:
					this.dispMenuTrunkingAvailableMenuItems_A22667 = new global::AcpBusinessLayer.AcpSparseLOVField(28, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.indexDispMenuTrunkingAvailableMenuItems_A22667LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.idDispMenuTrunkingAvailableMenuItems_A22667LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚觜귞铠跢軤軦蟨質곬駮郰髲駴零鯸韺飼닾搀洂瀄丆紈渊怌簎丐划✔┖⼘ⴚ⨜", a_), global::CommonResources.AcgResources.ID_TRUNKINGAVAILABLEMENUITEMS, true, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.DispMenuTrunkingAvailableMenuItems_A22667LovStrs);
					this.dispMenuTrunkingAvailableMenuItems_A22667.IgnoreOnCompare = true;
					this.dispMenuTrunkingAvailableMenuItems_A22667.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dispMenuTrunkingAvailableMenuItems_A22667.DataTransferOrder = -1;
					num = (short)32571411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_217;
				case 16:
					this.dispMenuConventionalSelectedMenuItems_A21736 = new global::AcpBusinessLayer.AcpSparseLOVField(new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.indexDispMenuConventionalSelectedMenuItems_A21736LovStrs, global::Motorola.MackinawCPS.CoreFeatures.MenuItems.LOVs.idDispMenuConventionalSelectedMenuItems_A21736LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚黜냞迠闢胤触鷨苪苬臮郰鿲꛴鋶闸黺黼课搀朂䠄戆月縊䐌笎琐縒昔䠖堘⤚Ⱌ⠞ሠᔢ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALSELECTEDMENUITEMS, new string[]
					{
						global::CommonResources.AcgResources.ID_ZONE_1
					}, true);
					this.dispMenuConventionalSelectedMenuItems_A21736.UndoIgnoresSelection = true;
					this.dispMenuConventionalSelectedMenuItems_A21736.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dispMenuConventionalSelectedMenuItems_A21736.DataTransferOrder = 36;
					num = (short)936116232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚觜귞铠跢軤軦蟨質뻬諮鷰雲雴菶鳸鿺냼髾漀瘂䰄猆氈昊縌倎倐ℒ␔‖⨘⸚", a_)))
					{
						num = (short)662437897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_217;
				case 18:
					num = (short)2037055500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_AA;
				case 20:
					goto IL_355;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觌ꛎꋐꏒ飔닖럘껚黜냞迠闢胤触鷨苪苬臮郰鿲듴臶飸鋺釼黾挀漂怄䨆氈攊砌䘎攐瘒研搖䘘娚⼜ⴞᜠᔢጤ", a_)))
					{
						num = (short)1208090631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41E;
				}
				IL_85:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)336199698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AA:
				num = (short)1064304657;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_217:
				num = (short)230883330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35A:
				num = (short)418578453;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A6:
				num = (short)223215621;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41E:
				num = (short)1600126980;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_355:
			IL_56D:
			num = (short)216006657;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諌꫎뿐뛒꟔뛖뗘", a_);
			base.Id = 10024;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x006F5EC0 File Offset: 0x006F40C0
		public override void PopulateReferences()
		{
			short num = (short)1536202572;
			short num2 = num;
			num = (short)750557004;
			switch (num2 == num)
			{
			}
			num = (short)1085997057;
			if (num != 0)
			{
			}
			num = (short)1426063360;
			short num3 = num;
			num = (short)51773440;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x006F5F6C File Offset: 0x006F416C
		public override void DropReferences()
		{
			short num = (short)1552385966;
			short num2 = num;
			num = (short)570263470;
			switch (num2 == num)
			{
			}
			num = (short)1200685056;
			if (num != 0)
			{
			}
			num = (short)1246232576;
			short num3 = num;
			num = (short)2026504193;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x006F6014 File Offset: 0x006F4214
		public override void SetConstraints()
		{
			short num = (short)791880580;
			short num2 = num;
			num = (short)1001137028;
			switch (num2 == num)
			{
			}
			num = (short)1902444544;
			if (num != 0)
			{
			}
			num = (short)1386545152;
			short num3 = num;
			num = (short)368836609;
			if (num != 0)
			{
			}
			this.dispMenuTrunkingSelectedMenuItems_A21735.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItemsConstraints.conMenuItemsTrkSel);
			this.dispMenuConventionalSelectedMenuItems_A21736.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItemsConstraints.conMenuItemsCnvSel);
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x006F60EC File Offset: 0x006F42EC
		public override void SetupDependencies()
		{
			short num = (short)939866705;
			short num2 = num;
			num = (short)1491286609;
			switch (num2 == num)
			{
			}
			num = (short)603455489;
			if (num != 0)
			{
			}
			num = (short)2035548160;
			short num3 = num;
			num = (short)520486912;
			if (num != 0)
			{
			}
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefRadioWide.Labtool.RadWideLabtoolKeypadType_A8372.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefRadioWide.Labtool.RadWideLabtoolKeypadType_A8372.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefRadioWide.Features.RadWideFeaturesSmartMessagingSmartMessageMode.AddDependentObject(this.dispMenuConventionalSelectedMenuItems_A21736);
			this.RefRadioWide.Features.RadWideFeaturesSmartMessagingSmartMessageMode.AddDependentObject(this.dispMenuTrunkingSelectedMenuItems_A21735);
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x06007A50 RID: 31312 RVA: 0x006F6434 File Offset: 0x006F4634
		public bool HasDiffs
		{
			get
			{
				short num = (short)1557585002;
				short num2 = num;
				num = (short)913890410;
				switch (num2 == num)
				{
				}
				num = (short)1059061761;
				if (num != 0)
				{
				}
				num = (short)1645740032;
				short num3 = num;
				num = (short)2064449536;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x06007A51 RID: 31313 RVA: 0x006F64E8 File Offset: 0x006F46E8
		// (set) Token: 0x06007A52 RID: 31314 RVA: 0x006F659C File Offset: 0x006F479C
		public int DispMenuTrunkingSelectedMenuItems_A21735Value
		{
			get
			{
				short num = (short)114749542;
				short num2 = num;
				num = (short)1252192358;
				switch (num2 == num)
				{
				}
				num = (short)1722482688;
				if (num != 0)
				{
				}
				num = (short)500301824;
				short num3 = num;
				num = (short)608829441;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.Value;
			}
			set
			{
				short num = (short)185350650;
				short num2 = num;
				num = (short)271530490;
				switch (num2 == num)
				{
				}
				num = (short)912588801;
				if (num != 0)
				{
				}
				num = (short)1850802176;
				short num3 = num;
				num = (short)99549184;
				if (num != 0)
				{
				}
				this.dispMenuTrunkingSelectedMenuItems_A21735.Value = value;
			}
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x06007A53 RID: 31315 RVA: 0x006F6654 File Offset: 0x006F4854
		// (set) Token: 0x06007A54 RID: 31316 RVA: 0x006F6708 File Offset: 0x006F4908
		public string DispMenuTrunkingSelectedMenuItems_A21735_UIValue
		{
			get
			{
				short num = (short)725701846;
				short num2 = num;
				num = (short)312366294;
				switch (num2 == num)
				{
				}
				num = (short)870842369;
				if (num != 0)
				{
				}
				num = (short)535166976;
				short num3 = num;
				num = (short)1281490944;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.UIValue;
			}
			set
			{
				short num = (short)1957333029;
				short num2 = num;
				num = (short)810584101;
				switch (num2 == num)
				{
				}
				num = (short)1872101377;
				if (num != 0)
				{
				}
				num = (short)1469186048;
				short num3 = num;
				num = (short)1960247296;
				if (num != 0)
				{
				}
				this.dispMenuTrunkingSelectedMenuItems_A21735.UIValue = value;
			}
		}

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x06007A55 RID: 31317 RVA: 0x006F67C0 File Offset: 0x006F49C0
		public global::AcpBusinessLayer.AcpListField DispMenuTrunkingSelectedMenuItems_A21735
		{
			get
			{
				short num = (short)630550057;
				short num2 = num;
				num = (short)723611177;
				switch (num2 == num)
				{
				}
				num = (short)380698625;
				if (num != 0)
				{
				}
				num = (short)543227904;
				short num3 = num;
				num = (short)1013383168;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735;
			}
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x06007A56 RID: 31318 RVA: 0x006F6874 File Offset: 0x006F4A74
		// (set) Token: 0x06007A57 RID: 31319 RVA: 0x006F6928 File Offset: 0x006F4B28
		public bool DispMenuTrunkingSelectedMenuItems_A21735_Applicable
		{
			get
			{
				short num = (short)1346122606;
				short num2 = num;
				num = (short)329134958;
				switch (num2 == num)
				{
				}
				num = (short)116260864;
				if (num != 0)
				{
				}
				num = (short)863240192;
				short num3 = num;
				num = (short)905183233;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.Applicable;
			}
			set
			{
				short num = (short)1286015891;
				short num2 = num;
				num = (short)572459923;
				switch (num2 == num)
				{
				}
				num = (short)116523009;
				if (num != 0)
				{
				}
				num = (short)989462528;
				short num3 = num;
				num = (short)1543110656;
				if (num != 0)
				{
				}
				this.dispMenuTrunkingSelectedMenuItems_A21735.Applicable = value;
			}
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x06007A58 RID: 31320 RVA: 0x006F69DC File Offset: 0x006F4BDC
		// (set) Token: 0x06007A59 RID: 31321 RVA: 0x006F6A90 File Offset: 0x006F4C90
		public bool DispMenuTrunkingSelectedMenuItems_A21735_Valid
		{
			get
			{
				short num = (short)1846775474;
				short num2 = num;
				num = (short)792497842;
				switch (num2 == num)
				{
				}
				num = (short)25165824;
				if (num != 0)
				{
				}
				num = (short)898695168;
				short num3 = num;
				num = (short)1974075393;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.Valid;
			}
			set
			{
				short num = (short)1040646145;
				if (num != 0)
				{
				}
				num = (short)862939373;
				short num2 = num;
				num = (short)779577581;
				switch (num2 == num)
				{
				}
				num = (short)149094400;
				short num3 = num;
				num = (short)1515323392;
				if (num != 0)
				{
				}
				this.dispMenuTrunkingSelectedMenuItems_A21735.Valid = value;
			}
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x06007A5A RID: 31322 RVA: 0x006F6B48 File Offset: 0x006F4D48
		// (set) Token: 0x06007A5B RID: 31323 RVA: 0x006F6BFC File Offset: 0x006F4DFC
		public bool DispMenuTrunkingSelectedMenuItems_A21735_Visible
		{
			get
			{
				short num = (short)2021523457;
				if (num != 0)
				{
				}
				num = (short)948727036;
				short num2 = num;
				num = (short)1026845948;
				switch (num2 == num)
				{
				}
				num = (short)1797586944;
				short num3 = num;
				num = (short)1763835904;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.Visible;
			}
			set
			{
				short num = (short)5340547;
				short num2 = num;
				num = (short)104430979;
				switch (num2 == num)
				{
				}
				num = (short)446431232;
				if (num != 0)
				{
				}
				num = (short)90832896;
				short num3 = num;
				num = (short)848625665;
				if (num != 0)
				{
				}
				this.dispMenuTrunkingSelectedMenuItems_A21735.Visible = value;
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x06007A5C RID: 31324 RVA: 0x006F6CB4 File Offset: 0x006F4EB4
		// (set) Token: 0x06007A5D RID: 31325 RVA: 0x006F6D68 File Offset: 0x006F4F68
		public bool DispMenuTrunkingSelectedMenuItems_A21735_Editable
		{
			get
			{
				short num = (short)1128004888;
				short num2 = num;
				num = (short)1974009112;
				switch (num2 == num)
				{
				}
				num = (short)635895809;
				if (num != 0)
				{
				}
				num = (short)343408640;
				short num3 = num;
				num = (short)1911226368;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.Editable;
			}
			set
			{
				short num = (short)1002864640;
				short num2 = num;
				num = (short)375554048;
				switch (num2 == num)
				{
				}
				num = (short)989134849;
				if (num != 0)
				{
				}
				num = (short)2122645504;
				short num3 = num;
				num = (short)978845696;
				if (num != 0)
				{
				}
				this.dispMenuTrunkingSelectedMenuItems_A21735.Editable = value;
			}
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x06007A5E RID: 31326 RVA: 0x006F6E20 File Offset: 0x006F5020
		internal string DispMenuTrunkingSelectedMenuItems_A21735_UILabel
		{
			get
			{
				short num = (short)772033428;
				short num2 = num;
				num = (short)1042959252;
				switch (num2 == num)
				{
				}
				num = (short)1222639616;
				if (num != 0)
				{
				}
				num = (short)1091239936;
				short num3 = num;
				num = (short)672661505;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.UIName;
			}
		}

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x06007A5F RID: 31327 RVA: 0x006F6ED4 File Offset: 0x006F50D4
		// (set) Token: 0x06007A60 RID: 31328 RVA: 0x006F6F8C File Offset: 0x006F518C
		internal bool DispMenuTrunkingSelectedMenuItems_A21735_HiddenStatic
		{
			get
			{
				short num = (short)701493264;
				short num2 = num;
				num = (short)657453072;
				switch (num2 == num)
				{
				}
				num = (short)1442709505;
				if (num != 0)
				{
				}
				num = (short)1007091712;
				short num3 = num;
				num = (short)1116798976;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.HiddenStatic;
			}
			set
			{
				short num = (short)332873454;
				short num2 = num;
				num = (short)441859822;
				switch (num2 == num)
				{
				}
				num = (short)1668087809;
				if (num != 0)
				{
				}
				num = (short)29687808;
				short num3 = num;
				num = (short)658046976;
				if (num != 0)
				{
				}
				this.dispMenuTrunkingSelectedMenuItems_A21735.HiddenStatic = value;
			}
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x06007A61 RID: 31329 RVA: 0x006F7040 File Offset: 0x006F5240
		// (set) Token: 0x06007A62 RID: 31330 RVA: 0x006F70F4 File Offset: 0x006F52F4
		internal bool DispMenuTrunkingSelectedMenuItems_A21735_HiddenDynamic
		{
			get
			{
				short num = (short)158271824;
				short num2 = num;
				num = (short)1825638736;
				switch (num2 == num)
				{
				}
				num = (short)1133445120;
				if (num != 0)
				{
				}
				num = (short)2074607616;
				short num3 = num;
				num = (short)1495400449;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735.HiddenDynamic;
			}
			set
			{
				short num = (short)1622110733;
				short num2 = num;
				num = (short)427061773;
				switch (num2 == num)
				{
				}
				num = (short)142540801;
				if (num != 0)
				{
				}
				num = (short)800587776;
				short num3 = num;
				num = (short)1544093696;
				if (num != 0)
				{
				}
				this.dispMenuTrunkingSelectedMenuItems_A21735.HiddenDynamic = value;
			}
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x06007A63 RID: 31331 RVA: 0x006F71AC File Offset: 0x006F53AC
		public bool DispMenuTrunkingSelectedMenuItems_A21735_HasDiffs
		{
			get
			{
				short num = (short)1415181246;
				short num2 = num;
				num = (short)552006590;
				switch (num2 == num)
				{
				}
				num = (short)197459969;
				if (num != 0)
				{
				}
				num = (short)687210496;
				short num3 = num;
				num = (short)358285312;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingSelectedMenuItems_A21735._HasDiffs;
			}
		}

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x06007A64 RID: 31332 RVA: 0x006F7264 File Offset: 0x006F5464
		// (set) Token: 0x06007A65 RID: 31333 RVA: 0x006F7318 File Offset: 0x006F5518
		public int DispMenuConventionalSelectedMenuItems_A21736Value
		{
			get
			{
				short num = (short)817095111;
				short num2 = num;
				num = (short)1499718087;
				switch (num2 == num)
				{
				}
				num = (short)1701904385;
				if (num != 0)
				{
				}
				num = (short)89980928;
				short num3 = num;
				num = (short)712310784;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.Value;
			}
			set
			{
				short num = (short)2092186838;
				short num2 = num;
				num = (short)1547320534;
				switch (num2 == num)
				{
				}
				num = (short)1302069248;
				if (num != 0)
				{
				}
				num = (short)765460480;
				short num3 = num;
				num = (short)340787201;
				if (num != 0)
				{
				}
				this.dispMenuConventionalSelectedMenuItems_A21736.Value = value;
			}
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x06007A66 RID: 31334 RVA: 0x006F73CC File Offset: 0x006F55CC
		// (set) Token: 0x06007A67 RID: 31335 RVA: 0x006F7480 File Offset: 0x006F5680
		public string DispMenuConventionalSelectedMenuItems_A21736_UIValue
		{
			get
			{
				short num = (short)1394016257;
				if (num != 0)
				{
				}
				num = (short)179805920;
				short num2 = num;
				num = (short)1566875360;
				switch (num2 == num)
				{
				}
				num = (short)1902706688;
				short num3 = num;
				num = (short)1838743552;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.UIValue;
			}
			set
			{
				short num = (short)297283464;
				short num2 = num;
				num = (short)1439182728;
				switch (num2 == num)
				{
				}
				num = (short)1455226881;
				if (num != 0)
				{
				}
				num = (short)925106176;
				short num3 = num;
				num = (short)1919221760;
				if (num != 0)
				{
				}
				this.dispMenuConventionalSelectedMenuItems_A21736.UIValue = value;
			}
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x06007A68 RID: 31336 RVA: 0x006F7538 File Offset: 0x006F5738
		public global::AcpBusinessLayer.AcpListField DispMenuConventionalSelectedMenuItems_A21736
		{
			get
			{
				short num = (short)1345099433;
				short num2 = num;
				num = (short)1976538793;
				switch (num2 == num)
				{
				}
				num = (short)793509888;
				if (num != 0)
				{
				}
				num = (short)54788096;
				short num3 = num;
				num = (short)1660420097;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736;
			}
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x06007A69 RID: 31337 RVA: 0x006F75E8 File Offset: 0x006F57E8
		// (set) Token: 0x06007A6A RID: 31338 RVA: 0x006F769C File Offset: 0x006F589C
		public bool DispMenuConventionalSelectedMenuItems_A21736_Applicable
		{
			get
			{
				short num = (short)1276896255;
				short num2 = num;
				num = (short)1899160575;
				switch (num2 == num)
				{
				}
				num = (short)863895553;
				if (num != 0)
				{
				}
				num = (short)762314752;
				short num3 = num;
				num = (short)1894645760;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.Applicable;
			}
			set
			{
				short num = (short)369040780;
				short num2 = num;
				num = (short)663494028;
				switch (num2 == num)
				{
				}
				num = (short)393805825;
				if (num != 0)
				{
				}
				num = (short)618004480;
				short num3 = num;
				num = (short)1904869376;
				if (num != 0)
				{
				}
				this.dispMenuConventionalSelectedMenuItems_A21736.Applicable = value;
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x06007A6B RID: 31339 RVA: 0x006F7750 File Offset: 0x006F5950
		// (set) Token: 0x06007A6C RID: 31340 RVA: 0x006F7804 File Offset: 0x006F5A04
		public bool DispMenuConventionalSelectedMenuItems_A21736_Valid
		{
			get
			{
				short num = (short)769174275;
				short num2 = num;
				num = (short)1661709059;
				switch (num2 == num)
				{
				}
				num = (short)1405485057;
				if (num != 0)
				{
				}
				num = (short)1344012288;
				short num3 = num;
				num = (short)1234894848;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.Valid;
			}
			set
			{
				short num = (short)1221363954;
				short num2 = num;
				num = (short)1557694706;
				switch (num2 == num)
				{
				}
				num = (short)1687683073;
				if (num != 0)
				{
				}
				num = (short)1133445120;
				short num3 = num;
				num = (short)309395456;
				if (num != 0)
				{
				}
				this.dispMenuConventionalSelectedMenuItems_A21736.Valid = value;
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x06007A6D RID: 31341 RVA: 0x006F78B8 File Offset: 0x006F5AB8
		// (set) Token: 0x06007A6E RID: 31342 RVA: 0x006F796C File Offset: 0x006F5B6C
		public bool DispMenuConventionalSelectedMenuItems_A21736_Visible
		{
			get
			{
				short num = (short)565255002;
				short num2 = num;
				num = (short)1215699802;
				switch (num2 == num)
				{
				}
				num = (short)1491337217;
				if (num != 0)
				{
				}
				num = (short)432865280;
				short num3 = num;
				num = (short)599719936;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.Visible;
			}
			set
			{
				short num = (short)917766145;
				if (num != 0)
				{
				}
				num = (short)1846966607;
				short num2 = num;
				num = (short)216103247;
				switch (num2 == num)
				{
				}
				num = (short)1838022656;
				short num3 = num;
				num = (short)2063663104;
				if (num != 0)
				{
				}
				this.dispMenuConventionalSelectedMenuItems_A21736.Visible = value;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x06007A6F RID: 31343 RVA: 0x006F7A24 File Offset: 0x006F5C24
		// (set) Token: 0x06007A70 RID: 31344 RVA: 0x006F7AD8 File Offset: 0x006F5CD8
		public bool DispMenuConventionalSelectedMenuItems_A21736_Editable
		{
			get
			{
				short num = (short)1187232974;
				short num2 = num;
				num = (short)1384627406;
				switch (num2 == num)
				{
				}
				num = (short)674299904;
				if (num != 0)
				{
				}
				num = (short)2120220672;
				short num3 = num;
				num = (short)1751515137;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.Editable;
			}
			set
			{
				short num = (short)1123979450;
				short num2 = num;
				num = (short)637636794;
				switch (num2 == num)
				{
				}
				num = (short)2125398017;
				if (num != 0)
				{
				}
				num = (short)1868562432;
				short num3 = num;
				num = (short)915996672;
				if (num != 0)
				{
				}
				this.dispMenuConventionalSelectedMenuItems_A21736.Editable = value;
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x06007A71 RID: 31345 RVA: 0x006F7B8C File Offset: 0x006F5D8C
		internal string DispMenuConventionalSelectedMenuItems_A21736_UILabel
		{
			get
			{
				short num = (short)1519942185;
				short num2 = num;
				num = (short)1637055017;
				switch (num2 == num)
				{
				}
				num = (short)1644822529;
				if (num != 0)
				{
				}
				num = (short)1908473856;
				short num3 = num;
				num = (short)916062208;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.UIName;
			}
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x06007A72 RID: 31346 RVA: 0x006F7C40 File Offset: 0x006F5E40
		// (set) Token: 0x06007A73 RID: 31347 RVA: 0x006F7CF4 File Offset: 0x006F5EF4
		internal bool DispMenuConventionalSelectedMenuItems_A21736_HiddenStatic
		{
			get
			{
				short num = (short)1475748915;
				short num2 = num;
				num = (short)456008755;
				switch (num2 == num)
				{
				}
				num = (short)427556864;
				if (num != 0)
				{
				}
				num = (short)1302986752;
				short num3 = num;
				num = (short)1629552641;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.HiddenStatic;
			}
			set
			{
				short num = (short)700494174;
				short num2 = num;
				num = (short)749973854;
				switch (num2 == num)
				{
				}
				num = (short)1296629761;
				if (num != 0)
				{
				}
				num = (short)2038759424;
				short num3 = num;
				num = (short)1213071360;
				if (num != 0)
				{
				}
				this.dispMenuConventionalSelectedMenuItems_A21736.HiddenStatic = value;
			}
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x06007A74 RID: 31348 RVA: 0x006F7DA8 File Offset: 0x006F5FA8
		// (set) Token: 0x06007A75 RID: 31349 RVA: 0x006F7E5C File Offset: 0x006F605C
		internal bool DispMenuConventionalSelectedMenuItems_A21736_HiddenDynamic
		{
			get
			{
				short num = (short)997128352;
				short num2 = num;
				num = (short)176486560;
				switch (num2 == num)
				{
				}
				num = (short)1924726785;
				if (num != 0)
				{
				}
				num = (short)2023555072;
				short num3 = num;
				num = (short)361889792;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736.HiddenDynamic;
			}
			set
			{
				short num = (short)1827676387;
				short num2 = num;
				num = (short)1128472803;
				switch (num2 == num)
				{
				}
				num = (short)1568538624;
				if (num != 0)
				{
				}
				num = (short)18808832;
				short num3 = num;
				num = (short)2105475073;
				if (num != 0)
				{
				}
				this.dispMenuConventionalSelectedMenuItems_A21736.HiddenDynamic = value;
			}
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x06007A76 RID: 31350 RVA: 0x006F7F14 File Offset: 0x006F6114
		public bool DispMenuConventionalSelectedMenuItems_A21736_HasDiffs
		{
			get
			{
				short num = (short)1490315706;
				short num2 = num;
				num = (short)1588816314;
				switch (num2 == num)
				{
				}
				num = (short)740294657;
				if (num != 0)
				{
				}
				num = (short)1569587200;
				short num3 = num;
				num = (short)1097007104;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalSelectedMenuItems_A21736._HasDiffs;
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x006F7FC8 File Offset: 0x006F61C8
		// (set) Token: 0x06007A78 RID: 31352 RVA: 0x006F807C File Offset: 0x006F627C
		public int DispMenuConventionalAvailableMenuItems_A22666Value
		{
			get
			{
				short num = (short)1867534290;
				short num2 = num;
				num = (short)43929554;
				switch (num2 == num)
				{
				}
				num = (short)360644609;
				if (num != 0)
				{
				}
				num = (short)1342242816;
				short num3 = num;
				num = (short)197656576;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.Value;
			}
			set
			{
				short num = (short)1630816351;
				short num2 = num;
				num = (short)1378240607;
				switch (num2 == num)
				{
				}
				num = (short)944570369;
				if (num != 0)
				{
				}
				num = (short)1845952512;
				short num3 = num;
				num = (short)13697024;
				if (num != 0)
				{
				}
				this.dispMenuConventionalAvailableMenuItems_A22666.Value = value;
			}
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x006F8130 File Offset: 0x006F6330
		// (set) Token: 0x06007A7A RID: 31354 RVA: 0x006F81E8 File Offset: 0x006F63E8
		public string DispMenuConventionalAvailableMenuItems_A22666_UIValue
		{
			get
			{
				short num = (short)1973344412;
				short num2 = num;
				num = (short)1673123996;
				switch (num2 == num)
				{
				}
				num = (short)5963776;
				if (num != 0)
				{
				}
				num = (short)1853423616;
				short num3 = num;
				num = (short)2089091073;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.UIValue;
			}
			set
			{
				short num = (short)1803161330;
				short num2 = num;
				num = (short)1335037682;
				switch (num2 == num)
				{
				}
				num = (short)522321921;
				if (num != 0)
				{
				}
				num = (short)734134272;
				short num3 = num;
				num = (short)1989279744;
				if (num != 0)
				{
				}
				this.dispMenuConventionalAvailableMenuItems_A22666.UIValue = value;
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x06007A7B RID: 31355 RVA: 0x006F82A0 File Offset: 0x006F64A0
		public global::AcpBusinessLayer.AcpListField DispMenuConventionalAvailableMenuItems_A22666
		{
			get
			{
				short num = (short)1807996354;
				short num2 = num;
				num = (short)1755960770;
				switch (num2 == num)
				{
				}
				num = (short)417464321;
				if (num != 0)
				{
				}
				num = (short)1682309120;
				short num3 = num;
				num = (short)40566784;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666;
			}
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x06007A7C RID: 31356 RVA: 0x006F8350 File Offset: 0x006F6550
		// (set) Token: 0x06007A7D RID: 31357 RVA: 0x006F8404 File Offset: 0x006F6604
		public bool DispMenuConventionalAvailableMenuItems_A22666_Applicable
		{
			get
			{
				short num = (short)1843928848;
				short num2 = num;
				num = (short)1911562000;
				switch (num2 == num)
				{
				}
				num = (short)800391168;
				if (num != 0)
				{
				}
				num = (short)994705408;
				short num3 = num;
				num = (short)743112705;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.Applicable;
			}
			set
			{
				short num = (short)1692914346;
				short num2 = num;
				num = (short)2045039274;
				switch (num2 == num)
				{
				}
				num = (short)1382875137;
				if (num != 0)
				{
				}
				num = (short)181534720;
				short num3 = num;
				num = (short)1411121152;
				if (num != 0)
				{
				}
				this.dispMenuConventionalAvailableMenuItems_A22666.Applicable = value;
			}
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x06007A7E RID: 31358 RVA: 0x006F84B8 File Offset: 0x006F66B8
		// (set) Token: 0x06007A7F RID: 31359 RVA: 0x006F856C File Offset: 0x006F676C
		public bool DispMenuConventionalAvailableMenuItems_A22666_Valid
		{
			get
			{
				short num = (short)1157116917;
				short num2 = num;
				num = (short)288895989;
				switch (num2 == num)
				{
				}
				num = (short)781778945;
				if (num != 0)
				{
				}
				num = (short)294846464;
				short num3 = num;
				num = (short)1765474304;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.Valid;
			}
			set
			{
				short num = (short)400494891;
				short num2 = num;
				num = (short)983765291;
				switch (num2 == num)
				{
				}
				num = (short)1352466433;
				if (num != 0)
				{
				}
				num = (short)1446248448;
				short num3 = num;
				num = (short)782303232;
				if (num != 0)
				{
				}
				this.dispMenuConventionalAvailableMenuItems_A22666.Valid = value;
			}
		}

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x06007A80 RID: 31360 RVA: 0x006F8624 File Offset: 0x006F6824
		// (set) Token: 0x06007A81 RID: 31361 RVA: 0x006F86DC File Offset: 0x006F68DC
		public bool DispMenuConventionalAvailableMenuItems_A22666_Visible
		{
			get
			{
				short num = (short)1618719371;
				short num2 = num;
				num = (short)1981592203;
				switch (num2 == num)
				{
				}
				num = (short)1347551233;
				if (num != 0)
				{
				}
				num = (short)394592256;
				short num3 = num;
				num = (short)308477952;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.Visible;
			}
			set
			{
				short num = (short)1329504236;
				short num2 = num;
				num = (short)1157930988;
				switch (num2 == num)
				{
				}
				num = (short)262668289;
				if (num != 0)
				{
				}
				num = (short)18415616;
				short num3 = num;
				num = (short)731709440;
				if (num != 0)
				{
				}
				this.dispMenuConventionalAvailableMenuItems_A22666.Visible = value;
			}
		}

		// Token: 0x17003EEF RID: 16111
		// (get) Token: 0x06007A82 RID: 31362 RVA: 0x006F8790 File Offset: 0x006F6990
		// (set) Token: 0x06007A83 RID: 31363 RVA: 0x006F8844 File Offset: 0x006F6A44
		public bool DispMenuConventionalAvailableMenuItems_A22666_Editable
		{
			get
			{
				short num = (short)2085678060;
				short num2 = num;
				num = (short)1484188652;
				switch (num2 == num)
				{
				}
				num = (short)929628161;
				if (num != 0)
				{
				}
				num = (short)2044067840;
				short num3 = num;
				num = (short)293994496;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.Editable;
			}
			set
			{
				short num = (short)1213304316;
				short num2 = num;
				num = (short)892374524;
				switch (num2 == num)
				{
				}
				num = (short)1129775105;
				if (num != 0)
				{
				}
				num = (short)491978752;
				short num3 = num;
				num = (short)1416757248;
				if (num != 0)
				{
				}
				this.dispMenuConventionalAvailableMenuItems_A22666.Editable = value;
			}
		}

		// Token: 0x17003EF0 RID: 16112
		// (get) Token: 0x06007A84 RID: 31364 RVA: 0x006F88F8 File Offset: 0x006F6AF8
		internal string DispMenuConventionalAvailableMenuItems_A22666_UILabel
		{
			get
			{
				short num = (short)1262753184;
				short num2 = num;
				num = (short)1199379872;
				switch (num2 == num)
				{
				}
				num = (short)1133838337;
				if (num != 0)
				{
				}
				num = (short)1609826304;
				short num3 = num;
				num = (short)1934491648;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.UIName;
			}
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x06007A85 RID: 31365 RVA: 0x006F89AC File Offset: 0x006F6BAC
		// (set) Token: 0x06007A86 RID: 31366 RVA: 0x006F8A5C File Offset: 0x006F6C5C
		internal bool DispMenuConventionalAvailableMenuItems_A22666_HiddenStatic
		{
			get
			{
				short num = (short)1798909893;
				short num2 = num;
				num = (short)855388101;
				switch (num2 == num)
				{
				}
				num = (short)201785345;
				if (num != 0)
				{
				}
				num = (short)480116736;
				short num3 = num;
				num = (short)491782144;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.HiddenStatic;
			}
			set
			{
				short num = (short)1916403713;
				if (num != 0)
				{
				}
				num = (short)135682186;
				short num2 = num;
				num = (short)439048330;
				switch (num2 == num)
				{
				}
				num = (short)1458110464;
				short num3 = num;
				num = (short)1166082048;
				if (num != 0)
				{
				}
				this.dispMenuConventionalAvailableMenuItems_A22666.HiddenStatic = value;
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x06007A87 RID: 31367 RVA: 0x006F8B14 File Offset: 0x006F6D14
		// (set) Token: 0x06007A88 RID: 31368 RVA: 0x006F8BC8 File Offset: 0x006F6DC8
		internal bool DispMenuConventionalAvailableMenuItems_A22666_HiddenDynamic
		{
			get
			{
				short num = (short)1147707284;
				short num2 = num;
				num = (short)1825808276;
				switch (num2 == num)
				{
				}
				num = (short)2048720897;
				if (num != 0)
				{
				}
				num = (short)1237778432;
				short num3 = num;
				num = (short)2000486400;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666.HiddenDynamic;
			}
			set
			{
				short num = (short)580997510;
				short num2 = num;
				num = (short)1683771782;
				switch (num2 == num)
				{
				}
				num = (short)1903230976;
				if (num != 0)
				{
				}
				num = (short)894763008;
				short num3 = num;
				num = (short)1064894465;
				if (num != 0)
				{
				}
				this.dispMenuConventionalAvailableMenuItems_A22666.HiddenDynamic = value;
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x06007A89 RID: 31369 RVA: 0x006F8C80 File Offset: 0x006F6E80
		public bool DispMenuConventionalAvailableMenuItems_A22666_HasDiffs
		{
			get
			{
				short num = (short)788859505;
				short num2 = num;
				num = (short)273746545;
				switch (num2 == num)
				{
				}
				num = (short)895811585;
				if (num != 0)
				{
				}
				num = (short)55115776;
				short num3 = num;
				num = (short)1542324224;
				if (num != 0)
				{
				}
				return this.dispMenuConventionalAvailableMenuItems_A22666._HasDiffs;
			}
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x06007A8A RID: 31370 RVA: 0x006F8D34 File Offset: 0x006F6F34
		// (set) Token: 0x06007A8B RID: 31371 RVA: 0x006F8DEC File Offset: 0x006F6FEC
		public int DispMenuTrunkingAvailableMenuItems_A22667Value
		{
			get
			{
				short num = (short)213302828;
				short num2 = num;
				num = (short)1949220396;
				switch (num2 == num)
				{
				}
				num = (short)194641921;
				if (num != 0)
				{
				}
				num = (short)801046528;
				short num3 = num;
				num = (short)1929117696;
				if (num != 0)
				{
				}
				return this.dispMenuTrunkingAvailableMenuItems_A22667.Value;
			}
			set
			{
				short num = (short)26869761;
				if (num != 0)
				{
				}
				num = (short)215000101;
				short num2 = num;
				num = (short)287024165;
				switch (num2 == num)
				{
				}
				num = (short)1394147328;
				if (num != 0)
				{
				}
				num = (short)1735655424;
				short num3 = num;
				this.dispMenuTrunkingAvailableMenuItems_A22667.Value = value;
			}
		}

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x06007A8C RID: 31372 RVA: 0x006F8EA4 File Offset: 0x006F70A4
		// (set) Token: 0x06007A8D RID: 31373 RVA: 0x006F8F58 File Offset: 0x006F7158
		public string DispMenuTrunkingAvailableMenuItems_A22667_UIValue
		{
			get
			{
				short num = (short)2055622813;
				short num2 = num;
				num = (short)1864126621;
				switch (num2 == num)
				{
				}
				num = (short)2084503553;
				if (num != 0)
				{
				}
				num = (short)481492992;
				if (num != 0)
				{
				}
				num = (short)101122048;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667.UIValue;
			}
			set
			{
				short num = (short)70551658;
				short num2 = num;
				num = (short)2101905514;
				switch (num2 == num)
				{
				}
				num = (short)1178599425;
				if (num != 0)
				{
				}
				num = (short)446169088;
				if (num != 0)
				{
				}
				num = (short)389873664;
				short num3 = num;
				this.dispMenuTrunkingAvailableMenuItems_A22667.UIValue = value;
			}
		}

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x06007A8E RID: 31374 RVA: 0x006F900C File Offset: 0x006F720C
		public global::AcpBusinessLayer.AcpListField DispMenuTrunkingAvailableMenuItems_A22667
		{
			get
			{
				short num = (short)1525874689;
				if (num != 0)
				{
				}
				num = (short)2019459744;
				short num2 = num;
				num = (short)248808096;
				switch (num2 == num)
				{
				}
				num = (short)1249509376;
				if (num != 0)
				{
				}
				num = (short)651034624;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667;
			}
		}

		// Token: 0x17003EF7 RID: 16119
		// (get) Token: 0x06007A8F RID: 31375 RVA: 0x006F90B8 File Offset: 0x006F72B8
		// (set) Token: 0x06007A90 RID: 31376 RVA: 0x006F916C File Offset: 0x006F736C
		public bool DispMenuTrunkingAvailableMenuItems_A22667_Applicable
		{
			get
			{
				short num = (short)2138272600;
				short num2 = num;
				num = (short)762082136;
				switch (num2 == num)
				{
				}
				num = (short)27394049;
				if (num != 0)
				{
				}
				num = (short)701366272;
				if (num != 0)
				{
				}
				num = (short)1785593856;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667.Applicable;
			}
			set
			{
				short num = (short)35319709;
				short num2 = num;
				num = (short)1962602397;
				switch (num2 == num)
				{
				}
				num = (short)669450240;
				if (num != 0)
				{
				}
				num = (short)1955201025;
				if (num != 0)
				{
				}
				num = (short)665780224;
				short num3 = num;
				this.dispMenuTrunkingAvailableMenuItems_A22667.Applicable = value;
			}
		}

		// Token: 0x17003EF8 RID: 16120
		// (get) Token: 0x06007A91 RID: 31377 RVA: 0x006F9224 File Offset: 0x006F7424
		// (set) Token: 0x06007A92 RID: 31378 RVA: 0x006F92DC File Offset: 0x006F74DC
		public bool DispMenuTrunkingAvailableMenuItems_A22667_Valid
		{
			get
			{
				short num = (short)352628781;
				short num2 = num;
				num = (short)17936429;
				switch (num2 == num)
				{
				}
				num = (short)2145583105;
				if (num != 0)
				{
				}
				num = (short)1246625792;
				if (num != 0)
				{
				}
				num = (short)1403846656;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667.Valid;
			}
			set
			{
				short num = (short)1208741064;
				short num2 = num;
				num = (short)1931865288;
				switch (num2 == num)
				{
				}
				num = (short)289603585;
				if (num != 0)
				{
				}
				num = (short)621740032;
				if (num != 0)
				{
				}
				num = (short)1773404160;
				short num3 = num;
				this.dispMenuTrunkingAvailableMenuItems_A22667.Valid = value;
			}
		}

		// Token: 0x17003EF9 RID: 16121
		// (get) Token: 0x06007A93 RID: 31379 RVA: 0x006F9390 File Offset: 0x006F7590
		// (set) Token: 0x06007A94 RID: 31380 RVA: 0x006F9444 File Offset: 0x006F7644
		public bool DispMenuTrunkingAvailableMenuItems_A22667_Visible
		{
			get
			{
				short num = (short)351830766;
				short num2 = num;
				num = (short)1565426414;
				switch (num2 == num)
				{
				}
				num = (short)1496973313;
				if (num != 0)
				{
				}
				num = (short)984678400;
				if (num != 0)
				{
				}
				num = (short)586350592;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667.Visible;
			}
			set
			{
				short num = (short)583490509;
				short num2 = num;
				num = (short)1190878157;
				switch (num2 == num)
				{
				}
				num = (short)1816657920;
				if (num != 0)
				{
				}
				num = (short)2117402625;
				if (num != 0)
				{
				}
				num = (short)1298857984;
				short num3 = num;
				this.dispMenuTrunkingAvailableMenuItems_A22667.Visible = value;
			}
		}

		// Token: 0x17003EFA RID: 16122
		// (get) Token: 0x06007A95 RID: 31381 RVA: 0x006F94F8 File Offset: 0x006F76F8
		// (set) Token: 0x06007A96 RID: 31382 RVA: 0x006F95A8 File Offset: 0x006F77A8
		public bool DispMenuTrunkingAvailableMenuItems_A22667_Editable
		{
			get
			{
				short num = (short)1384225334;
				short num2 = num;
				num = (short)58694198;
				switch (num2 == num)
				{
				}
				num = (short)158072833;
				if (num != 0)
				{
				}
				num = (short)1361969152;
				if (num != 0)
				{
				}
				num = (short)694747136;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667.Editable;
			}
			set
			{
				short num = (short)1360263024;
				short num2 = num;
				num = (short)268105584;
				switch (num2 == num)
				{
				}
				num = (short)654245889;
				if (num != 0)
				{
				}
				num = (short)481034240;
				if (num != 0)
				{
				}
				num = (short)268304384;
				short num3 = num;
				this.dispMenuTrunkingAvailableMenuItems_A22667.Editable = value;
			}
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x06007A97 RID: 31383 RVA: 0x006F9660 File Offset: 0x006F7860
		internal string DispMenuTrunkingAvailableMenuItems_A22667_UILabel
		{
			get
			{
				short num = (short)1535712779;
				short num2 = num;
				num = (short)182918667;
				switch (num2 == num)
				{
				}
				num = (short)1050017792;
				if (num != 0)
				{
				}
				num = (short)191823873;
				if (num != 0)
				{
				}
				num = (short)1300037632;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667.UIName;
			}
		}

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x06007A98 RID: 31384 RVA: 0x006F9718 File Offset: 0x006F7918
		// (set) Token: 0x06007A99 RID: 31385 RVA: 0x006F97D0 File Offset: 0x006F79D0
		internal bool DispMenuTrunkingAvailableMenuItems_A22667_HiddenStatic
		{
			get
			{
				short num = (short)359833493;
				short num2 = num;
				num = (short)613195669;
				switch (num2 == num)
				{
				}
				num = (short)1043070977;
				if (num != 0)
				{
				}
				num = (short)2028077056;
				if (num != 0)
				{
				}
				num = (short)2020474880;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667.HiddenStatic;
			}
			set
			{
				short num = (short)202768385;
				if (num != 0)
				{
				}
				num = (short)622666298;
				short num2 = num;
				num = (short)956441146;
				switch (num2 == num)
				{
				}
				num = (short)96010240;
				if (num != 0)
				{
				}
				num = (short)1068433408;
				short num3 = num;
				this.dispMenuTrunkingAvailableMenuItems_A22667.HiddenStatic = value;
			}
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x06007A9A RID: 31386 RVA: 0x006F9888 File Offset: 0x006F7A88
		// (set) Token: 0x06007A9B RID: 31387 RVA: 0x006F9940 File Offset: 0x006F7B40
		internal bool DispMenuTrunkingAvailableMenuItems_A22667_HiddenDynamic
		{
			get
			{
				short num = (short)1346022238;
				short num2 = num;
				num = (short)3779422;
				switch (num2 == num)
				{
				}
				num = (short)349110272;
				if (num != 0)
				{
				}
				num = (short)1305804801;
				if (num != 0)
				{
				}
				num = (short)700317696;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667.HiddenDynamic;
			}
			set
			{
				short num = (short)1880099115;
				short num2 = num;
				num = (short)1301350699;
				switch (num2 == num)
				{
				}
				num = (short)1663696896;
				if (num != 0)
				{
				}
				num = (short)220594177;
				if (num != 0)
				{
				}
				num = (short)321716224;
				short num3 = num;
				this.dispMenuTrunkingAvailableMenuItems_A22667.HiddenDynamic = value;
			}
		}

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x06007A9C RID: 31388 RVA: 0x006F99F8 File Offset: 0x006F7BF8
		public bool DispMenuTrunkingAvailableMenuItems_A22667_HasDiffs
		{
			get
			{
				short num = (short)1636773347;
				short num2 = num;
				num = (short)108080611;
				switch (num2 == num)
				{
				}
				num = (short)1391919105;
				if (num != 0)
				{
				}
				num = (short)1183318016;
				if (num != 0)
				{
				}
				num = (short)1810825216;
				short num3 = num;
				return this.dispMenuTrunkingAvailableMenuItems_A22667._HasDiffs;
			}
		}

		// Token: 0x17003EFF RID: 16127
		// (get) Token: 0x06007A9D RID: 31389 RVA: 0x006F9AAC File Offset: 0x006F7CAC
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches RefSwitches
		{
			get
			{
				short num = (short)2110245149;
				short num2 = num;
				num = (short)1412483357;
				switch (num2 == num)
				{
				}
				num = (short)210108416;
				if (num != 0)
				{
				}
				num = (short)1789919233;
				if (num != 0)
				{
				}
				num = (short)1585381376;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			}
		}

		// Token: 0x17003F00 RID: 16128
		// (get) Token: 0x06007A9E RID: 31390 RVA: 0x006F9B6C File Offset: 0x006F7D6C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)521146487;
				short num2 = num;
				num = (short)1676546167;
				switch (num2 == num)
				{
				}
				num = (short)1961295873;
				if (num != 0)
				{
				}
				num = (short)1563885568;
				if (num != 0)
				{
				}
				num = (short)594542592;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17003F01 RID: 16129
		// (get) Token: 0x06007A9F RID: 31391 RVA: 0x006F9C2C File Offset: 0x006F7E2C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality RefConvPersonality
		{
			get
			{
				short num = (short)1632420862;
				short num2 = num;
				num = (short)1658700798;
				switch (num2 == num)
				{
				}
				num = (short)1225719809;
				if (num != 0)
				{
				}
				num = (short)344981504;
				if (num != 0)
				{
				}
				num = (short)1465450496;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2059)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
			}
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x006F9CEC File Offset: 0x006F7EEC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1085997059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						num2 = (short)1574305793;
						if (num2 != 0)
						{
						}
						num2 = (short)1551499268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						num2 = (short)1275506698;
						short num3 = num2;
						num2 = (short)1785966602;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						case 1:
							break;
						default:
						{
							num2 = (short)541851648;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1042612224;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num2 = (short)579076097;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					case 3:
						return result;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)205193216;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)935198722;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003570 RID: 13680
		private global::AcpBusinessLayer.AcpListField dispMenuTrunkingSelectedMenuItems_A21735;

		// Token: 0x04003571 RID: 13681
		private global::AcpBusinessLayer.AcpListField dispMenuConventionalSelectedMenuItems_A21736;

		// Token: 0x04003572 RID: 13682
		private global::AcpBusinessLayer.AcpListField dispMenuConventionalAvailableMenuItems_A22666;

		// Token: 0x04003573 RID: 13683
		private global::AcpBusinessLayer.AcpListField dispMenuTrunkingAvailableMenuItems_A22667;
	}
}
