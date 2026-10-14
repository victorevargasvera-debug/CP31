using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x02000298 RID: 664
	[global::System.Serializable]
	public class ConventionalSwitchTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600744C RID: 29772 RVA: 0x0068CBD8 File Offset: 0x0068ADD8
		public ConventionalSwitchTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x0068CBF4 File Offset: 0x0068ADF4
		protected ConventionalSwitchTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x0068CC0C File Offset: 0x0068AE0C
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1193379851;
			short num2 = num;
			num = (short)1026852875;
			switch (num2 == num)
			{
			}
			num = (short)978124800;
			if (num != 0)
			{
			}
			num = (short)481427457;
			if (num != 0)
			{
			}
			num = (short)892272640;
			short num3 = num;
			this.switchConventionalSwitchTablePositionsQuantity_A19654 = new global::AcpBusinessLayer.AcpListField(5, this, global::AllFeatures.CodeplugGuid.b("鷍꟏믑ꃓ뗕냗駙돛냝雟蟡諣鋥臧藩苫迭鳯ꇱ菳鿵賷駹铻꫽懿态栃挅堇攉缋服搏笑笓砕欗䬙椛缝丟嘡䴣別儧甩洫Ἥयбĳȵ", a_), global::CommonResources.AcgResources.ID_POSITIONSQUANTITY, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePositionsQuantity_A19654LovStrs);
			this.switchConventionalSwitchTablePositionsQuantity_A19654.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchConventionalSwitchTablePositionsQuantity_A19654.DataTransferOrder = 5;
			this.switchConventionalSwitchTablePosition1Feature_A19655 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition1Feature_A19655LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition1Feature_A19655LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷍꟏믑ꃓ뗕냗駙돛냝雟蟡諣鋥臧藩苫迭鳯ꇱ菳鿵賷駹铻꫽懿态栃挅堇攉缋服搏笑笓砕⤗尙礛缝吟圡嘣䌥眧欩ᴫᜭدܱĳ", a_), global::CommonResources.AcgResources.ID_POSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition1Feature_A19655LovStrs);
			this.switchConventionalSwitchTablePosition1Feature_A19655.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchConventionalSwitchTablePosition1Feature_A19655.DataTransferOrder = 17;
			this.switchConventionalSwitchTablePosition2Feature_A19656 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition2Feature_A19656LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition2Feature_A19656LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷍꟏믑ꃓ뗕냗駙돛냝雟蟡諣鋥臧藩苫迭鳯ꇱ菳鿵賷駹铻꫽懿态栃挅堇攉缋服搏笑笓砕⨗尙礛缝吟圡嘣䌥眧欩ᴫᜭدܱȳ", a_), global::CommonResources.AcgResources.ID_POSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition2Feature_A19656LovStrs);
			this.switchConventionalSwitchTablePosition2Feature_A19656.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchConventionalSwitchTablePosition2Feature_A19656.DataTransferOrder = 18;
			this.switchConventionalSwitchTablePosition3Feature_A19657 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition3Feature_A19657LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition3Feature_A19657LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷍꟏믑ꃓ뗕냗駙돛냝雟蟡諣鋥臧藩苫迭鳯ꇱ菳鿵賷駹铻꫽懿态栃挅堇攉缋服搏笑笓砕⬗尙礛缝吟圡嘣䌥眧欩ᴫᜭدܱ̳", a_), global::CommonResources.AcgResources.ID_POSITIONC, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition3Feature_A19657LovStrs);
			this.switchConventionalSwitchTablePosition3Feature_A19657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchConventionalSwitchTablePosition3Feature_A19657.DataTransferOrder = 19;
			this.switchConventionalSwitchTablePosition4Feature_A19658 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition4Feature_A19658LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition4Feature_A19658LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷍꟏믑ꃓ뗕냗駙돛냝雟蟡諣鋥臧藩苫迭鳯ꇱ菳鿵賷駹铻꫽懿态栃挅堇攉缋服搏笑笓砕Ⱇ尙礛缝吟圡嘣䌥眧欩ᴫᜭدܱళ", a_), global::CommonResources.AcgResources.ID_POSITIOND, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition4Feature_A19658LovStrs);
			this.switchConventionalSwitchTablePosition4Feature_A19658.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchConventionalSwitchTablePosition4Feature_A19658.DataTransferOrder = 20;
			this.switchConventionalSwitchTablePosition5Feature_A19717 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition5Feature_A19717LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition5Feature_A19717LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷍꟏믑ꃓ뗕냗駙돛냝雟蟡諣鋥臧藩苫迭鳯ꇱ菳鿵賷駹铻꫽懿态栃挅堇攉缋服搏笑笓砕ⴗ尙礛缝吟圡嘣䌥眧欩ᴫᜭܯ̱̳", a_), global::CommonResources.AcgResources.ID_POSITIONE, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition5Feature_A19717LovStrs);
			this.switchConventionalSwitchTablePosition5Feature_A19717.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchConventionalSwitchTablePosition5Feature_A19717.DataTransferOrder = 21;
			this.switchConventionalSwitchKey_A21293 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鷍꟏믑ꃓ뗕냗駙돛냝雟蟡諣鋥臧藩苫迭鳯ꇱ菳鿵賷駹铻뗽旿笁嬃䜅㨇㬉㸋㜍⌏", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.switchConventionalSwitchKey_A21293.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchConventionalSwitchKey_A21293.DataTransferOrder = 27;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跍뿏병ꋓ돕뛗껙뗛뇝軟菡裣웥믧鷩藫髭鏯髱퓳ꋵ駷飹郻鯽", a_);
			base.Id = 10086;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x0068CEF0 File Offset: 0x0068B0F0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1437663246;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_589;
				case 1:
					this.switchConventionalSwitchTablePosition3Feature_A19657 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition3Feature_A19657LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition3Feature_A19657LovStrs), this, global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙⼛堝䔟䌡倣匥娧伩猫漭į଱ȳ̵༷", a_), global::CommonResources.AcgResources.ID_POSITIONC, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition3Feature_A19657LovStrs);
					this.switchConventionalSwitchTablePosition3Feature_A19657.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchConventionalSwitchTablePosition3Feature_A19657.DataTransferOrder = 19;
					num = (short)1980170257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙⸛堝䔟䌡倣匥娧伩猫漭į଱ȳ̵ื", a_)))
					{
						num = (short)1929969668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D4;
				case 3:
					num = (short)2021720084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.switchConventionalSwitchTablePosition2Feature_A19656 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition2Feature_A19656LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition2Feature_A19656LovStrs), this, global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙⸛堝䔟䌡倣匥娧伩猫漭į଱ȳ̵ื", a_), global::CommonResources.AcgResources.ID_POSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition2Feature_A19656LovStrs);
					this.switchConventionalSwitchTablePosition2Feature_A19656.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchConventionalSwitchTablePosition2Feature_A19656.DataTransferOrder = 18;
					goto IL_3BC;
				case 5:
					if (producerFields != null)
					{
						num = (short)1469906947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66C;
				case 6:
					num = (short)1934819329;
					if (num != 0)
					{
					}
					this.switchConventionalSwitchTablePositionsQuantity_A19654 = new global::AcpBusinessLayer.AcpListField(5, this, global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙漛伝唟䌡䨣別䄧帩唫焭焯̱ള5ഷู", a_), global::CommonResources.AcgResources.ID_POSITIONSQUANTITY, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePositionsQuantity_A19654LovStrs);
					this.switchConventionalSwitchTablePositionsQuantity_A19654.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchConventionalSwitchTablePositionsQuantity_A19654.DataTransferOrder = 5;
					num = (short)409862167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿䤁愃缅圇䬉㸋㼍∏⬑✓", a_)))
					{
						num = (short)120389642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66C;
				case 8:
					goto IL_49B;
				case 9:
					goto IL_5D4;
				case 10:
					this.switchConventionalSwitchKey_A21293 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿䤁愃缅圇䬉㸋㼍∏⬑✓", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.switchConventionalSwitchKey_A21293.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchConventionalSwitchKey_A21293.DataTransferOrder = 27;
					num = (short)124059670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙⠛堝䔟䌡倣匥娧伩猫漭į଱ȳ̵7", a_)))
					{
						num = (short)64880659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49B;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙ⴛ堝䔟䌡倣匥娧伩猫漭į଱ȳ̵ഷ", a_)))
					{
						num = (short)1307901952;
						short num3 = num;
						num = (short)616562709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_589;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙⤛堝䔟䌡倣匥娧伩猫漭į଱̳༷ܵ", a_)))
					{
						num = (short)1344143384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44D;
				case 14:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 15:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙⼛堝䔟䌡倣匥娧伩猫漭į଱ȳ̵༷", a_)))
					{
						goto IL_2C8;
					}
					num = (short)2078360264;
					short num4 = num;
					num = (short)962806472;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3BC;
					default:
						num = (short)2008416256;
						if (num != 0)
						{
						}
						num = (short)922550273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					goto IL_44D;
				case 17:
					goto IL_2C8;
				case 18:
					num = (short)924844037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.switchConventionalSwitchTablePosition4Feature_A19658 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition4Feature_A19658LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition4Feature_A19658LovStrs), this, global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙⠛堝䔟䌡倣匥娧伩猫漭į଱ȳ̵7", a_), global::CommonResources.AcgResources.ID_POSITIOND, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition4Feature_A19658LovStrs);
					this.switchConventionalSwitchTablePosition4Feature_A19658.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchConventionalSwitchTablePosition4Feature_A19658.DataTransferOrder = 20;
					num = (short)1823604744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙漛伝唟䌡䨣別䄧帩唫焭焯̱ള5ഷู", a_)))
					{
						num = (short)1941700614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D8;
				case 21:
					this.switchConventionalSwitchTablePosition1Feature_A19655 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition1Feature_A19655LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition1Feature_A19655LovStrs), this, global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙ⴛ堝䔟䌡倣匥娧伩猫漭į଱ȳ̵ഷ", a_), global::CommonResources.AcgResources.ID_POSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition1Feature_A19655LovStrs);
					this.switchConventionalSwitchTablePosition1Feature_A19655.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchConventionalSwitchTablePosition1Feature_A19655.DataTransferOrder = 17;
					num = (short)323616768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_368;
				case 23:
					goto IL_3D8;
				case 24:
					this.switchConventionalSwitchTablePosition5Feature_A19717 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchConventionalSwitchTablePosition5Feature_A19717LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchConventionalSwitchTablePosition5Feature_A19717LovStrs), this, global::AllFeatures.CodeplugGuid.b("臑ꏓ뿕곗맙듛鷝迟賡鋣菥蛧黩藫臭黯鏱飳ꗵ迷鏹裻鷽棿嘁攃搅搇漉尋愍挏笑怓缕眗琙⤛堝䔟䌡倣匥娧伩猫漭į଱̳༷ܵ", a_), global::CommonResources.AcgResources.ID_POSITIONE, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchConventionalSwitchTablePosition5Feature_A19717LovStrs);
					this.switchConventionalSwitchTablePosition5Feature_A19717.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchConventionalSwitchTablePosition5Feature_A19717.DataTransferOrder = 21;
					num = (short)585039888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_92:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1088684050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2C8:
				num = (short)307429387;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BC:
				num = (short)1758527497;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D8:
				num = (short)967507980;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44D:
				num = (short)75497479;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_49B:
				num = (short)854720525;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_589:
				num = (short)2112749570;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D4:
				num = (short)1415839759;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_368:
			IL_66C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("金믓룕껗뿙닛ꫝ觟跡諣蟥蓧쫩뿫駭駯蛱音黵\ud8f7껹鷻鳽泿朁", a_);
			base.Id = 10086;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x0068D59C File Offset: 0x0068B79C
		public override void PopulateReferences()
		{
			short num = (short)1527382017;
			if (num != 0)
			{
			}
			num = (short)1264119131;
			short num2 = num;
			num = (short)802090331;
			switch (num2 == num)
			{
			}
			num = (short)876281856;
			if (num != 0)
			{
			}
			num = (short)1747648512;
			short num3 = num;
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x0068D644 File Offset: 0x0068B844
		public override void DropReferences()
		{
			short num = (short)1532749888;
			short num2 = num;
			num = (short)947120192;
			switch (num2 == num)
			{
			}
			num = (short)2116812800;
			if (num != 0)
			{
			}
			num = (short)1895366657;
			if (num != 0)
			{
			}
			num = (short)1645477888;
			short num3 = num;
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x0068D6EC File Offset: 0x0068B8EC
		public override void SetConstraints()
		{
			short num = (short)1400484176;
			short num2 = num;
			num = (short)300003664;
			switch (num2 == num)
			{
			}
			num = (short)867762177;
			if (num != 0)
			{
			}
			num = (short)648806400;
			if (num != 0)
			{
			}
			num = (short)193789952;
			short num3 = num;
			this.switchConventionalSwitchTablePosition1Feature_A19655.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.SyncPositionAInCnvSwitchTable);
			this.switchConventionalSwitchTablePosition2Feature_A19656.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.SyncPositionBInCnvSwitchTable);
			this.switchConventionalSwitchTablePosition3Feature_A19657.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.SyncPositionCInCnvSwitchTable);
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x0068D7DC File Offset: 0x0068B9DC
		public override void SetupDependencies()
		{
			short num = (short)190450272;
			short num2 = num;
			num = (short)368970336;
			switch (num2 == num)
			{
			}
			num = (short)795213824;
			if (num != 0)
			{
			}
			num = (short)71958529;
			if (num != 0)
			{
			}
			num = (short)2002714624;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.switchConventionalSwitchTablePosition1Feature_A19655);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.switchConventionalSwitchTablePosition1Feature_A19655);
			this.RefRadioWide.Features.SwitchConventionalSwitchesPosition1_A12643.AddDependentObject(this.switchConventionalSwitchTablePosition1Feature_A19655);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.switchConventionalSwitchTablePosition2Feature_A19656);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.switchConventionalSwitchTablePosition2Feature_A19656);
			switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.switchConventionalSwitchTablePosition3Feature_A19657);
			this.switchConventionalSwitchTablePosition1Feature_A19655.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.switchConventionalSwitchTablePosition1Feature_A19655.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.switchConventionalSwitchTablePosition1Feature_A19655.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10075] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedLogicalSwitch2_A7756);
			this.switchConventionalSwitchTablePosition1Feature_A19655.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10046] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Features).SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238);
			this.switchConventionalSwitchTablePosition1Feature_A19655.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).SwitchConventionalSwitchesPosition1_A12643);
			this.switchConventionalSwitchTablePosition2Feature_A19656.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.switchConventionalSwitchTablePosition2Feature_A19656.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition2_A7735);
			this.switchConventionalSwitchTablePosition2Feature_A19656.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.switchConventionalSwitchTablePosition2Feature_A19656.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10075] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedLogicalSwitch2_A7756);
			this.switchConventionalSwitchTablePosition2Feature_A19656.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition4_A21530);
			this.switchConventionalSwitchTablePosition3Feature_A19657.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.switchConventionalSwitchTablePosition3Feature_A19657.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10075] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedLogicalSwitch2_A7756);
			this.switchConventionalSwitchTablePosition3Feature_A19657.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition5_A21531);
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x0068DB9C File Offset: 0x0068BD9C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1776997970;
				short num2 = num;
				num = (short)1193858642;
				switch (num2 == num)
				{
				}
				num = (short)1875312640;
				if (num != 0)
				{
				}
				num = (short)1607598081;
				if (num != 0)
				{
				}
				num = (short)460455936;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x06007455 RID: 29781 RVA: 0x0068DC4C File Offset: 0x0068BE4C
		// (set) Token: 0x06007456 RID: 29782 RVA: 0x0068DD00 File Offset: 0x0068BF00
		public int SwitchConventionalSwitchTablePositionsQuantity_A19654Value
		{
			get
			{
				short num = (short)311249091;
				short num2 = num;
				num = (short)1281968323;
				switch (num2 == num)
				{
				}
				num = (short)1096089601;
				if (num != 0)
				{
				}
				num = (short)1384382464;
				if (num != 0)
				{
				}
				num = (short)877920256;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.Value;
			}
			set
			{
				short num = (short)830776102;
				short num2 = num;
				num = (short)1499767590;
				switch (num2 == num)
				{
				}
				num = (short)1085472768;
				if (num != 0)
				{
				}
				num = (short)1278279681;
				if (num != 0)
				{
				}
				num = (short)1924136960;
				short num3 = num;
				this.switchConventionalSwitchTablePositionsQuantity_A19654.Value = value;
			}
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x06007457 RID: 29783 RVA: 0x0068DDB4 File Offset: 0x0068BFB4
		// (set) Token: 0x06007458 RID: 29784 RVA: 0x0068DE68 File Offset: 0x0068C068
		public string SwitchConventionalSwitchTablePositionsQuantity_A19654_UIValue
		{
			get
			{
				short num = (short)339287479;
				short num2 = num;
				num = (short)1752833463;
				switch (num2 == num)
				{
				}
				num = (short)787742720;
				if (num != 0)
				{
				}
				num = (short)1058799617;
				if (num != 0)
				{
				}
				num = (short)1282408448;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.UIValue;
			}
			set
			{
				short num = (short)1411068076;
				short num2 = num;
				num = (short)1780953260;
				switch (num2 == num)
				{
				}
				num = (short)987430913;
				if (num != 0)
				{
				}
				num = (short)1735131136;
				if (num != 0)
				{
				}
				num = (short)1891827712;
				short num3 = num;
				this.switchConventionalSwitchTablePositionsQuantity_A19654.UIValue = value;
			}
		}

		// Token: 0x17003BF3 RID: 15347
		// (get) Token: 0x06007459 RID: 29785 RVA: 0x0068DF20 File Offset: 0x0068C120
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchTablePositionsQuantity_A19654
		{
			get
			{
				short num = (short)516931524;
				short num2 = num;
				num = (short)1329315780;
				switch (num2 == num)
				{
				}
				num = (short)1507852288;
				if (num != 0)
				{
				}
				num = (short)85983233;
				if (num != 0)
				{
				}
				num = (short)1953300480;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654;
			}
		}

		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0600745A RID: 29786 RVA: 0x0068DFD0 File Offset: 0x0068C1D0
		// (set) Token: 0x0600745B RID: 29787 RVA: 0x0068E084 File Offset: 0x0068C284
		public bool SwitchConventionalSwitchTablePositionsQuantity_A19654_Applicable
		{
			get
			{
				short num = (short)2045361990;
				short num2 = num;
				num = (short)1454620486;
				switch (num2 == num)
				{
				}
				num = (short)1243938817;
				if (num != 0)
				{
				}
				num = (short)1503330304;
				if (num != 0)
				{
				}
				num = (short)705757184;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.Applicable;
			}
			set
			{
				short num = (short)1054922191;
				short num2 = num;
				num = (short)1909642703;
				switch (num2 == num)
				{
				}
				num = (short)2025062401;
				if (num != 0)
				{
				}
				num = (short)873070592;
				if (num != 0)
				{
				}
				num = (short)249626624;
				short num3 = num;
				this.switchConventionalSwitchTablePositionsQuantity_A19654.Applicable = value;
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0600745C RID: 29788 RVA: 0x0068E138 File Offset: 0x0068C338
		// (set) Token: 0x0600745D RID: 29789 RVA: 0x0068E1EC File Offset: 0x0068C3EC
		public bool SwitchConventionalSwitchTablePositionsQuantity_A19654_Valid
		{
			get
			{
				short num = (short)1634271233;
				if (num != 0)
				{
				}
				num = (short)210849882;
				short num2 = num;
				num = (short)1691177050;
				switch (num2 == num)
				{
				}
				num = (short)1738997760;
				if (num != 0)
				{
				}
				num = (short)959971328;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.Valid;
			}
			set
			{
				short num = (short)919569144;
				short num2 = num;
				num = (short)1153598200;
				switch (num2 == num)
				{
				}
				num = (short)712966145;
				if (num != 0)
				{
				}
				num = (short)838598656;
				if (num != 0)
				{
				}
				num = (short)1907294208;
				short num3 = num;
				this.switchConventionalSwitchTablePositionsQuantity_A19654.Valid = value;
			}
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0600745E RID: 29790 RVA: 0x0068E2A4 File Offset: 0x0068C4A4
		// (set) Token: 0x0600745F RID: 29791 RVA: 0x0068E358 File Offset: 0x0068C558
		public bool SwitchConventionalSwitchTablePositionsQuantity_A19654_Visible
		{
			get
			{
				short num = (short)108491781;
				short num2 = num;
				num = (short)811103237;
				switch (num2 == num)
				{
				}
				num = (short)986644481;
				if (num != 0)
				{
				}
				num = (short)669057024;
				if (num != 0)
				{
				}
				num = (short)1935605760;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.Visible;
			}
			set
			{
				short num = (short)982654149;
				short num2 = num;
				num = (short)1764498629;
				switch (num2 == num)
				{
				}
				num = (short)210960384;
				if (num != 0)
				{
				}
				num = (short)1428553729;
				if (num != 0)
				{
				}
				num = (short)369033216;
				short num3 = num;
				this.switchConventionalSwitchTablePositionsQuantity_A19654.Visible = value;
			}
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x06007460 RID: 29792 RVA: 0x0068E40C File Offset: 0x0068C60C
		// (set) Token: 0x06007461 RID: 29793 RVA: 0x0068E4C0 File Offset: 0x0068C6C0
		public bool SwitchConventionalSwitchTablePositionsQuantity_A19654_Editable
		{
			get
			{
				short num = (short)168107140;
				short num2 = num;
				num = (short)1085545604;
				switch (num2 == num)
				{
				}
				num = (short)1580466176;
				if (num != 0)
				{
				}
				num = (short)1189085185;
				if (num != 0)
				{
				}
				num = (short)2118975488;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.Editable;
			}
			set
			{
				short num = (short)1435566081;
				if (num != 0)
				{
				}
				num = (short)214202276;
				short num2 = num;
				num = (short)2021619620;
				switch (num2 == num)
				{
				}
				num = (short)2000355328;
				if (num != 0)
				{
				}
				num = (short)1986461696;
				short num3 = num;
				this.switchConventionalSwitchTablePositionsQuantity_A19654.Editable = value;
			}
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x06007462 RID: 29794 RVA: 0x0068E578 File Offset: 0x0068C778
		internal string SwitchConventionalSwitchTablePositionsQuantity_A19654_UILabel
		{
			get
			{
				short num = (short)294435886;
				short num2 = num;
				num = (short)1069399086;
				switch (num2 == num)
				{
				}
				num = (short)843382785;
				if (num != 0)
				{
				}
				num = (short)949354496;
				if (num != 0)
				{
				}
				num = (short)880345088;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.UIName;
			}
		}

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x06007463 RID: 29795 RVA: 0x0068E62C File Offset: 0x0068C82C
		// (set) Token: 0x06007464 RID: 29796 RVA: 0x0068E6E0 File Offset: 0x0068C8E0
		internal bool SwitchConventionalSwitchTablePositionsQuantity_A19654_HiddenStatic
		{
			get
			{
				short num = (short)2061340109;
				short num2 = num;
				num = (short)1477152205;
				switch (num2 == num)
				{
				}
				num = (short)1791229953;
				if (num != 0)
				{
				}
				num = (short)2032140288;
				if (num != 0)
				{
				}
				num = (short)201785344;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.HiddenStatic;
			}
			set
			{
				short num = (short)1088743341;
				short num2 = num;
				num = (short)794748845;
				switch (num2 == num)
				{
				}
				num = (short)1415446528;
				if (num != 0)
				{
				}
				num = (short)2077163521;
				if (num != 0)
				{
				}
				num = (short)714080256;
				short num3 = num;
				this.switchConventionalSwitchTablePositionsQuantity_A19654.HiddenStatic = value;
			}
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x06007465 RID: 29797 RVA: 0x0068E794 File Offset: 0x0068C994
		// (set) Token: 0x06007466 RID: 29798 RVA: 0x0068E84C File Offset: 0x0068CA4C
		internal bool SwitchConventionalSwitchTablePositionsQuantity_A19654_HiddenDynamic
		{
			get
			{
				short num = (short)2082964258;
				short num2 = num;
				num = (short)760709922;
				switch (num2 == num)
				{
				}
				num = (short)1237188608;
				if (num != 0)
				{
				}
				num = (short)1507131393;
				if (num != 0)
				{
				}
				num = (short)62259200;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654.HiddenDynamic;
			}
			set
			{
				short num = (short)1248198657;
				if (num != 0)
				{
				}
				num = (short)1448693476;
				short num2 = num;
				num = (short)437341924;
				switch (num2 == num)
				{
				}
				num = (short)457900032;
				if (num != 0)
				{
				}
				num = (short)595263488;
				short num3 = num;
				this.switchConventionalSwitchTablePositionsQuantity_A19654.HiddenDynamic = value;
			}
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x06007467 RID: 29799 RVA: 0x0068E900 File Offset: 0x0068CB00
		public bool SwitchConventionalSwitchTablePositionsQuantity_A19654_HasDiffs
		{
			get
			{
				short num = (short)766332166;
				short num2 = num;
				num = (short)612912390;
				switch (num2 == num)
				{
				}
				num = (short)2030305280;
				if (num != 0)
				{
				}
				num = (short)1613496321;
				if (num != 0)
				{
				}
				num = (short)1065222144;
				short num3 = num;
				return this.switchConventionalSwitchTablePositionsQuantity_A19654._HasDiffs;
			}
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x06007468 RID: 29800 RVA: 0x0068E9B4 File Offset: 0x0068CBB4
		// (set) Token: 0x06007469 RID: 29801 RVA: 0x0068EA68 File Offset: 0x0068CC68
		public int SwitchConventionalSwitchTablePosition1Feature_A19655Value
		{
			get
			{
				short num = (short)1661021987;
				short num2 = num;
				num = (short)1145384739;
				switch (num2 == num)
				{
				}
				num = (short)1013252097;
				if (num != 0)
				{
				}
				num = (short)55705600;
				if (num != 0)
				{
				}
				num = (short)665780224;
				short num3 = num;
				return this.switchConventionalSwitchTablePosition1Feature_A19655.Value;
			}
			set
			{
				short num = (short)602422768;
				short num2 = num;
				num = (short)530398704;
				switch (num2 == num)
				{
				}
				num = (short)1682833409;
				if (num != 0)
				{
				}
				num = (short)1664679936;
				if (num != 0)
				{
				}
				num = (short)674693120;
				short num3 = num;
				this.switchConventionalSwitchTablePosition1Feature_A19655.Value = value;
			}
		}

		// Token: 0x17003BFD RID: 15357
		// (get) Token: 0x0600746A RID: 29802 RVA: 0x0068EB1C File Offset: 0x0068CD1C
		// (set) Token: 0x0600746B RID: 29803 RVA: 0x0068EBD0 File Offset: 0x0068CDD0
		public string SwitchConventionalSwitchTablePosition1Feature_A19655_UIValue
		{
			get
			{
				short num = (short)2098207691;
				short num2 = num;
				num = (short)667687883;
				switch (num2 == num)
				{
				}
				num = (short)571015168;
				if (num != 0)
				{
				}
				num = (short)1626537985;
				if (num != 0)
				{
				}
				num = (short)133234688;
				short num3 = num;
				return this.switchConventionalSwitchTablePosition1Feature_A19655.UIValue;
			}
			set
			{
				short num = (short)176064420;
				short num2 = num;
				num = (short)1999800228;
				switch (num2 == num)
				{
				}
				num = (short)554696705;
				if (num != 0)
				{
				}
				num = (short)125304832;
				if (num != 0)
				{
				}
				num = (short)1529020416;
				short num3 = num;
				this.switchConventionalSwitchTablePosition1Feature_A19655.UIValue = value;
			}
		}

		// Token: 0x17003BFE RID: 15358
		// (get) Token: 0x0600746C RID: 29804 RVA: 0x0068EC88 File Offset: 0x0068CE88
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchTablePosition1Feature_A19655
		{
			get
			{
				short num = (short)131465216;
				short num2 = num;
				num = (short)1481990923;
				short num3 = num;
				num = (short)685728523;
				switch (num3 == num)
				{
				}
				num = (short)2055667713;
				if (num != 0)
				{
				}
				num = (short)1508704256;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655;
			}
		}

		// Token: 0x17003BFF RID: 15359
		// (get) Token: 0x0600746D RID: 29805 RVA: 0x0068ED38 File Offset: 0x0068CF38
		// (set) Token: 0x0600746E RID: 29806 RVA: 0x0068EDEC File Offset: 0x0068CFEC
		public bool SwitchConventionalSwitchTablePosition1Feature_A19655_Applicable
		{
			get
			{
				short num = (short)251658240;
				short num2 = num;
				num = (short)1685651472;
				short num3 = num;
				num = (short)2015559696;
				switch (num3 == num)
				{
				}
				num = (short)2686977;
				if (num != 0)
				{
				}
				num = (short)473628672;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655.Applicable;
			}
			set
			{
				short num = (short)490012672;
				short num2 = num;
				num = (short)588612932;
				short num3 = num;
				num = (short)1523942724;
				switch (num3 == num)
				{
				}
				num = (short)501743616;
				if (num != 0)
				{
				}
				num = (short)998047745;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition1Feature_A19655.Applicable = value;
			}
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x0600746F RID: 29807 RVA: 0x0068EEA0 File Offset: 0x0068D0A0
		// (set) Token: 0x06007470 RID: 29808 RVA: 0x0068EF54 File Offset: 0x0068D154
		public bool SwitchConventionalSwitchTablePosition1Feature_A19655_Valid
		{
			get
			{
				short num = (short)1565589504;
				short num2 = num;
				num = (short)1724760392;
				short num3 = num;
				num = (short)1833484616;
				switch (num3 == num)
				{
				}
				num = (short)1873805312;
				if (num != 0)
				{
				}
				num = (short)244580353;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655.Valid;
			}
			set
			{
				short num = (short)1572274176;
				short num2 = num;
				num = (short)2127900667;
				short num3 = num;
				num = (short)978792443;
				switch (num3 == num)
				{
				}
				num = (short)1552023552;
				if (num != 0)
				{
				}
				num = (short)843644929;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition1Feature_A19655.Valid = value;
			}
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x06007471 RID: 29809 RVA: 0x0068F008 File Offset: 0x0068D208
		// (set) Token: 0x06007472 RID: 29810 RVA: 0x0068F0BC File Offset: 0x0068D2BC
		public bool SwitchConventionalSwitchTablePosition1Feature_A19655_Visible
		{
			get
			{
				short num = (short)546766848;
				short num2 = num;
				num = (short)122687721;
				short num3 = num;
				num = (short)410521833;
				switch (num3 == num)
				{
				}
				num = (short)237305857;
				if (num != 0)
				{
				}
				num = (short)11665408;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655.Visible;
			}
			set
			{
				short num = (short)2063925248;
				short num2 = num;
				num = (short)1427379853;
				short num3 = num;
				num = (short)1852053133;
				switch (num3 == num)
				{
				}
				num = (short)1621622785;
				if (num != 0)
				{
				}
				num = (short)987693056;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition1Feature_A19655.Visible = value;
			}
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x06007473 RID: 29811 RVA: 0x0068F170 File Offset: 0x0068D370
		// (set) Token: 0x06007474 RID: 29812 RVA: 0x0068F224 File Offset: 0x0068D424
		public bool SwitchConventionalSwitchTablePosition1Feature_A19655_Editable
		{
			get
			{
				short num = (short)751108096;
				short num2 = num;
				num = (short)59377229;
				short num3 = num;
				num = (short)1348798029;
				switch (num3 == num)
				{
				}
				num = (short)1008402433;
				if (num != 0)
				{
				}
				num = (short)900136960;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655.Editable;
			}
			set
			{
				short num = (short)838074368;
				short num2 = num;
				num = (short)558938319;
				short num3 = num;
				num = (short)582858959;
				switch (num3 == num)
				{
				}
				num = (short)243007489;
				if (num != 0)
				{
				}
				num = (short)2012676096;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition1Feature_A19655.Editable = value;
			}
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x06007475 RID: 29813 RVA: 0x0068F2DC File Offset: 0x0068D4DC
		internal string SwitchConventionalSwitchTablePosition1Feature_A19655_UILabel
		{
			get
			{
				short num = (short)764870656;
				short num2 = num;
				num = (short)98540325;
				short num3 = num;
				num = (short)1646304037;
				switch (num3 == num)
				{
				}
				num = (short)1815347201;
				if (num != 0)
				{
				}
				num = (short)1519124480;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655.UIName;
			}
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x0068F394 File Offset: 0x0068D594
		// (set) Token: 0x06007477 RID: 29815 RVA: 0x0068F448 File Offset: 0x0068D648
		internal bool SwitchConventionalSwitchTablePosition1Feature_A19655_HiddenStatic
		{
			get
			{
				short num = (short)120717312;
				short num2 = num;
				num = (short)324554170;
				short num3 = num;
				num = (short)168709562;
				switch (num3 == num)
				{
				}
				num = (short)287375361;
				if (num != 0)
				{
				}
				num = (short)620756992;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655.HiddenStatic;
			}
			set
			{
				short num = (short)405733376;
				short num2 = num;
				num = (short)1368003385;
				short num3 = num;
				num = (short)233706297;
				switch (num3 == num)
				{
				}
				num = (short)1480589312;
				if (num != 0)
				{
				}
				num = (short)1677000705;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition1Feature_A19655.HiddenStatic = value;
			}
		}

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x06007478 RID: 29816 RVA: 0x0068F500 File Offset: 0x0068D700
		// (set) Token: 0x06007479 RID: 29817 RVA: 0x0068F5B4 File Offset: 0x0068D7B4
		internal bool SwitchConventionalSwitchTablePosition1Feature_A19655_HiddenDynamic
		{
			get
			{
				short num = (short)1947009024;
				short num2 = num;
				num = (short)577301217;
				short num3 = num;
				num = (short)1159588577;
				switch (num3 == num)
				{
				}
				num = (short)2109538305;
				if (num != 0)
				{
				}
				num = (short)264503296;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655.HiddenDynamic;
			}
			set
			{
				short num = (short)1010499584;
				short num2 = num;
				num = (short)2033786755;
				short num3 = num;
				num = (short)1917067139;
				switch (num3 == num)
				{
				}
				num = (short)100335617;
				if (num != 0)
				{
				}
				num = (short)51445760;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition1Feature_A19655.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0600747A RID: 29818 RVA: 0x0068F668 File Offset: 0x0068D868
		public bool SwitchConventionalSwitchTablePosition1Feature_A19655_HasDiffs
		{
			get
			{
				short num = (short)315686912;
				short num2 = num;
				num = (short)611020151;
				short num3 = num;
				num = (short)36072823;
				switch (num3 == num)
				{
				}
				num = (short)654508033;
				if (num != 0)
				{
				}
				num = (short)474480640;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition1Feature_A19655._HasDiffs;
			}
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0600747B RID: 29819 RVA: 0x0068F720 File Offset: 0x0068D920
		// (set) Token: 0x0600747C RID: 29820 RVA: 0x0068F7D4 File Offset: 0x0068D9D4
		public int SwitchConventionalSwitchTablePosition2Feature_A19656Value
		{
			get
			{
				short num = (short)2115502080;
				short num2 = num;
				num = (short)1080811039;
				short num3 = num;
				num = (short)431939103;
				switch (num3 == num)
				{
				}
				num = (short)1792737280;
				if (num != 0)
				{
				}
				num = (short)655491073;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.Value;
			}
			set
			{
				short num = (short)1053687808;
				short num2 = num;
				num = (short)1649672193;
				if (num != 0)
				{
				}
				num = (short)1647032110;
				short num3 = num;
				num = (short)1136703278;
				switch (num3 == num)
				{
				}
				num = (short)1799421952;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition2Feature_A19656.Value = value;
			}
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0600747D RID: 29821 RVA: 0x0068F888 File Offset: 0x0068DA88
		// (set) Token: 0x0600747E RID: 29822 RVA: 0x0068F93C File Offset: 0x0068DB3C
		public string SwitchConventionalSwitchTablePosition2Feature_A19656_UIValue
		{
			get
			{
				short num = (short)994639872;
				short num2 = num;
				num = (short)1617502729;
				short num3 = num;
				num = (short)147071497;
				switch (num3 == num)
				{
				}
				num = (short)2077491201;
				if (num != 0)
				{
				}
				num = (short)2141061120;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.UIValue;
			}
			set
			{
				short num = (short)492503040;
				short num2 = num;
				num = (short)585097071;
				short num3 = num;
				num = (short)974446447;
				switch (num3 == num)
				{
				}
				num = (short)508166145;
				if (num != 0)
				{
				}
				num = (short)1044447232;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition2Feature_A19656.UIValue = value;
			}
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x0600747F RID: 29823 RVA: 0x0068F9F0 File Offset: 0x0068DBF0
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchTablePosition2Feature_A19656
		{
			get
			{
				short num = (short)1247674368;
				short num2 = num;
				num = (short)1839071233;
				if (num != 0)
				{
				}
				num = (short)2010908336;
				short num3 = num;
				num = (short)1325401776;
				switch (num3 == num)
				{
				}
				num = (short)838074368;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656;
			}
		}

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x06007480 RID: 29824 RVA: 0x0068FAA0 File Offset: 0x0068DCA0
		// (set) Token: 0x06007481 RID: 29825 RVA: 0x0068FB58 File Offset: 0x0068DD58
		public bool SwitchConventionalSwitchTablePosition2Feature_A19656_Applicable
		{
			get
			{
				short num = (short)1501757440;
				short num2 = num;
				num = (short)789693403;
				short num3 = num;
				num = (short)2145436635;
				switch (num3 == num)
				{
				}
				num = (short)1155596289;
				if (num != 0)
				{
				}
				num = (short)1715470336;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.Applicable;
			}
			set
			{
				short num = (short)1439760384;
				short num2 = num;
				num = (short)155254785;
				if (num != 0)
				{
				}
				num = (short)434107806;
				short num3 = num;
				num = (short)695334302;
				switch (num3 == num)
				{
				}
				num = (short)1330970624;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition2Feature_A19656.Applicable = value;
			}
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x06007482 RID: 29826 RVA: 0x0068FC10 File Offset: 0x0068DE10
		// (set) Token: 0x06007483 RID: 29827 RVA: 0x0068FCC4 File Offset: 0x0068DEC4
		public bool SwitchConventionalSwitchTablePosition2Feature_A19656_Valid
		{
			get
			{
				short num = (short)1844510720;
				short num2 = num;
				num = (short)1522920756;
				short num3 = num;
				num = (short)329706804;
				switch (num3 == num)
				{
				}
				num = (short)1245380609;
				if (num != 0)
				{
				}
				num = (short)484114432;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.Valid;
			}
			set
			{
				short num = (short)1210253312;
				short num2 = num;
				num = (short)2075143588;
				short num3 = num;
				num = (short)416165284;
				switch (num3 == num)
				{
				}
				num = (short)914292737;
				if (num != 0)
				{
				}
				num = (short)1400438784;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition2Feature_A19656.Valid = value;
			}
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x0068FD80 File Offset: 0x0068DF80
		// (set) Token: 0x06007485 RID: 29829 RVA: 0x0068FE34 File Offset: 0x0068E034
		public bool SwitchConventionalSwitchTablePosition2Feature_A19656_Visible
		{
			get
			{
				short num = (short)1417740288;
				short num2 = num;
				num = (short)1844183041;
				if (num != 0)
				{
				}
				num = (short)1848242872;
				short num3 = num;
				num = (short)678359736;
				switch (num3 == num)
				{
				}
				num = (short)1683226624;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.Visible;
			}
			set
			{
				short num = (short)110166016;
				short num2 = num;
				num = (short)1798765117;
				short num3 = num;
				num = (short)1765472829;
				switch (num3 == num)
				{
				}
				num = (short)21168129;
				if (num != 0)
				{
				}
				num = (short)323682304;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition2Feature_A19656.Visible = value;
			}
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x06007486 RID: 29830 RVA: 0x0068FEEC File Offset: 0x0068E0EC
		// (set) Token: 0x06007487 RID: 29831 RVA: 0x0068FFA0 File Offset: 0x0068E1A0
		public bool SwitchConventionalSwitchTablePosition2Feature_A19656_Editable
		{
			get
			{
				short num = (short)1539571712;
				short num2 = num;
				num = (short)1086282522;
				short num3 = num;
				num = (short)2000050970;
				switch (num3 == num)
				{
				}
				num = (short)1500512257;
				if (num != 0)
				{
				}
				num = (short)2139553792;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.Editable;
			}
			set
			{
				short num = (short)496500736;
				short num2 = num;
				num = (short)1908763193;
				short num3 = num;
				num = (short)331639353;
				switch (num3 == num)
				{
				}
				num = (short)1265172481;
				if (num != 0)
				{
				}
				num = (short)2110259200;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition2Feature_A19656.Editable = value;
			}
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x06007488 RID: 29832 RVA: 0x00690054 File Offset: 0x0068E254
		internal string SwitchConventionalSwitchTablePosition2Feature_A19656_UILabel
		{
			get
			{
				short num = (short)2130116608;
				short num2 = num;
				num = (short)1349425499;
				short num3 = num;
				num = (short)280205659;
				switch (num3 == num)
				{
				}
				num = (short)1830354945;
				if (num != 0)
				{
				}
				num = (short)944242688;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.UIName;
			}
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x06007489 RID: 29833 RVA: 0x00690108 File Offset: 0x0068E308
		// (set) Token: 0x0600748A RID: 29834 RVA: 0x006901C0 File Offset: 0x0068E3C0
		internal bool SwitchConventionalSwitchTablePosition2Feature_A19656_HiddenStatic
		{
			get
			{
				short num = (short)852557824;
				short num2 = num;
				num = (short)65430602;
				short num3 = num;
				num = (short)391799882;
				switch (num3 == num)
				{
				}
				num = (short)823984128;
				if (num != 0)
				{
				}
				num = (short)46596097;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.HiddenStatic;
			}
			set
			{
				short num = (short)1002176512;
				short num2 = num;
				num = (short)401922876;
				short num3 = num;
				num = (short)862509884;
				switch (num3 == num)
				{
				}
				num = (short)1225195521;
				if (num != 0)
				{
				}
				num = (short)1597308928;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition2Feature_A19656.HiddenStatic = value;
			}
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x0600748B RID: 29835 RVA: 0x00690278 File Offset: 0x0068E478
		// (set) Token: 0x0600748C RID: 29836 RVA: 0x00690330 File Offset: 0x0068E530
		internal bool SwitchConventionalSwitchTablePosition2Feature_A19656_HiddenDynamic
		{
			get
			{
				short num = (short)937754624;
				short num2 = num;
				num = (short)941070434;
				short num3 = num;
				num = (short)421173346;
				switch (num3 == num)
				{
				}
				num = (short)50855937;
				if (num != 0)
				{
				}
				num = (short)2116091904;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656.HiddenDynamic;
			}
			set
			{
				short num = (short)2136866816;
				short num2 = num;
				num = (short)1779117303;
				short num3 = num;
				num = (short)1650601207;
				switch (num3 == num)
				{
				}
				num = (short)534118401;
				if (num != 0)
				{
				}
				num = (short)957546496;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition2Feature_A19656.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0600748D RID: 29837 RVA: 0x006903E8 File Offset: 0x0068E5E8
		public bool SwitchConventionalSwitchTablePosition2Feature_A19656_HasDiffs
		{
			get
			{
				short num = (short)848560128;
				short num2 = num;
				num = (short)978066305;
				short num3 = num;
				num = (short)1150688129;
				switch (num3 == num)
				{
				}
				num = (short)121307137;
				if (num != 0)
				{
				}
				num = (short)1221591040;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition2Feature_A19656._HasDiffs;
			}
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0600748E RID: 29838 RVA: 0x006904A0 File Offset: 0x0068E6A0
		// (set) Token: 0x0600748F RID: 29839 RVA: 0x00690554 File Offset: 0x0068E754
		public int SwitchConventionalSwitchTablePosition3Feature_A19657Value
		{
			get
			{
				short num = (short)328925184;
				short num2 = num;
				num = (short)10599083;
				short num3 = num;
				num = (short)1311685291;
				switch (num3 == num)
				{
				}
				num = (short)1058930689;
				if (num != 0)
				{
				}
				num = (short)1762197504;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.Value;
			}
			set
			{
				short num = (short)1344602112;
				short num2 = num;
				num = (short)444018843;
				short num3 = num;
				num = (short)723267739;
				switch (num3 == num)
				{
				}
				num = (short)729088001;
				if (num != 0)
				{
				}
				num = (short)863567872;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition3Feature_A19657.Value = value;
			}
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x06007490 RID: 29840 RVA: 0x00690608 File Offset: 0x0068E808
		// (set) Token: 0x06007491 RID: 29841 RVA: 0x006906BC File Offset: 0x0068E8BC
		public string SwitchConventionalSwitchTablePosition3Feature_A19657_UIValue
		{
			get
			{
				short num = (short)2035548160;
				short num2 = num;
				num = (short)1388773377;
				if (num != 0)
				{
				}
				num = (short)684210815;
				short num3 = num;
				num = (short)509885055;
				switch (num3 == num)
				{
				}
				num = (short)1791754240;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.UIValue;
			}
			set
			{
				short num = (short)1540489216;
				short num2 = num;
				num = (short)1791098365;
				short num3 = num;
				num = (short)1949957629;
				switch (num3 == num)
				{
				}
				num = (short)807993345;
				if (num != 0)
				{
				}
				num = (short)10289152;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition3Feature_A19657.UIValue = value;
			}
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x06007492 RID: 29842 RVA: 0x00690774 File Offset: 0x0068E974
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchTablePosition3Feature_A19657
		{
			get
			{
				short num = (short)1405288448;
				short num2 = num;
				num = (short)1725670867;
				short num3 = num;
				num = (short)865183187;
				switch (num3 == num)
				{
				}
				num = (short)1246560257;
				if (num != 0)
				{
				}
				num = (short)1337589760;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657;
			}
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x06007493 RID: 29843 RVA: 0x00690824 File Offset: 0x0068EA24
		// (set) Token: 0x06007494 RID: 29844 RVA: 0x006908D4 File Offset: 0x0068EAD4
		public bool SwitchConventionalSwitchTablePosition3Feature_A19657_Applicable
		{
			get
			{
				short num = (short)1730543616;
				short num2 = num;
				num = (short)1507606385;
				short num3 = num;
				num = (short)1379680113;
				switch (num3 == num)
				{
				}
				num = (short)1962803201;
				if (num != 0)
				{
				}
				num = (short)2110914560;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.Applicable;
			}
			set
			{
				short num = (short)425721856;
				short num2 = num;
				num = (short)1831169130;
				short num3 = num;
				num = (short)989555818;
				switch (num3 == num)
				{
				}
				num = (short)129957889;
				if (num != 0)
				{
				}
				num = (short)2140340224;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition3Feature_A19657.Applicable = value;
			}
		}

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x06007495 RID: 29845 RVA: 0x00690988 File Offset: 0x0068EB88
		// (set) Token: 0x06007496 RID: 29846 RVA: 0x00690A40 File Offset: 0x0068EC40
		public bool SwitchConventionalSwitchTablePosition3Feature_A19657_Valid
		{
			get
			{
				short num = (short)8388608;
				short num2 = num;
				num = (short)201289143;
				short num3 = num;
				num = (short)2010279351;
				switch (num3 == num)
				{
				}
				num = (short)737214465;
				if (num != 0)
				{
				}
				num = (short)1650982912;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.Valid;
			}
			set
			{
				short num = (short)77135872;
				short num2 = num;
				num = (short)932733942;
				short num3 = num;
				num = (short)853173238;
				switch (num3 == num)
				{
				}
				num = (short)543227905;
				if (num != 0)
				{
				}
				num = (short)206897152;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition3Feature_A19657.Valid = value;
			}
		}

		// Token: 0x17003C17 RID: 15383
		// (get) Token: 0x06007497 RID: 29847 RVA: 0x00690AF4 File Offset: 0x0068ECF4
		// (set) Token: 0x06007498 RID: 29848 RVA: 0x00690BA8 File Offset: 0x0068EDA8
		public bool SwitchConventionalSwitchTablePosition3Feature_A19657_Visible
		{
			get
			{
				short num = (short)753467392;
				short num2 = num;
				num = (short)1624867167;
				short num3 = num;
				num = (short)260604255;
				switch (num3 == num)
				{
				}
				num = (short)10682369;
				if (num != 0)
				{
				}
				num = (short)1167982592;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.Visible;
			}
			set
			{
				short num = (short)1399259136;
				short num2 = num;
				num = (short)884615658;
				short num3 = num;
				num = (short)171649514;
				switch (num3 == num)
				{
				}
				num = (short)50855937;
				if (num != 0)
				{
				}
				num = (short)366215168;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition3Feature_A19657.Visible = value;
			}
		}

		// Token: 0x17003C18 RID: 15384
		// (get) Token: 0x06007499 RID: 29849 RVA: 0x00690C60 File Offset: 0x0068EE60
		// (set) Token: 0x0600749A RID: 29850 RVA: 0x00690D18 File Offset: 0x0068EF18
		public bool SwitchConventionalSwitchTablePosition3Feature_A19657_Editable
		{
			get
			{
				short num = (short)1302790144;
				short num2 = num;
				num = (short)207792373;
				short num3 = num;
				num = (short)689416437;
				switch (num3 == num)
				{
				}
				num = (short)423231489;
				if (num != 0)
				{
				}
				num = (short)1168965632;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.Editable;
			}
			set
			{
				short num = (short)518717440;
				short num2 = num;
				num = (short)747021036;
				short num3 = num;
				num = (short)639279852;
				switch (num3 == num)
				{
				}
				num = (short)417333248;
				if (num != 0)
				{
				}
				num = (short)1462829057;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition3Feature_A19657.Editable = value;
			}
		}

		// Token: 0x17003C19 RID: 15385
		// (get) Token: 0x0600749B RID: 29851 RVA: 0x00690DD0 File Offset: 0x0068EFD0
		internal string SwitchConventionalSwitchTablePosition3Feature_A19657_UILabel
		{
			get
			{
				short num = (short)91160576;
				short num2 = num;
				num = (short)184535081;
				short num3 = num;
				num = (short)1558366249;
				switch (num3 == num)
				{
				}
				num = (short)286064641;
				if (num != 0)
				{
				}
				num = (short)805502976;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.UIName;
			}
		}

		// Token: 0x17003C1A RID: 15386
		// (get) Token: 0x0600749C RID: 29852 RVA: 0x00690E84 File Offset: 0x0068F084
		// (set) Token: 0x0600749D RID: 29853 RVA: 0x00690F38 File Offset: 0x0068F138
		internal bool SwitchConventionalSwitchTablePosition3Feature_A19657_HiddenStatic
		{
			get
			{
				short num = (short)873857024;
				short num2 = num;
				num = (short)1899369898;
				short num3 = num;
				num = (short)1870009770;
				switch (num3 == num)
				{
				}
				num = (short)1136328705;
				if (num != 0)
				{
				}
				num = (short)1682243584;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.HiddenStatic;
			}
			set
			{
				short num = (short)968687616;
				short num2 = num;
				num = (short)999059653;
				short num3 = num;
				num = (short)417951941;
				switch (num3 == num)
				{
				}
				num = (short)1672478721;
				if (num != 0)
				{
				}
				num = (short)1037041664;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition3Feature_A19657.HiddenStatic = value;
			}
		}

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0600749E RID: 29854 RVA: 0x00690FF0 File Offset: 0x0068F1F0
		// (set) Token: 0x0600749F RID: 29855 RVA: 0x006910A4 File Offset: 0x0068F2A4
		internal bool SwitchConventionalSwitchTablePosition3Feature_A19657_HiddenDynamic
		{
			get
			{
				short num = (short)1240530944;
				short num2 = num;
				num = (short)1984402904;
				short num3 = num;
				num = (short)836867544;
				switch (num3 == num)
				{
				}
				num = (short)1839267840;
				if (num != 0)
				{
				}
				num = (short)1468006401;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657.HiddenDynamic;
			}
			set
			{
				short num = (short)848887808;
				short num2 = num;
				num = (short)613485850;
				short num3 = num;
				num = (short)1575226650;
				switch (num3 == num)
				{
				}
				num = (short)2112552961;
				if (num != 0)
				{
				}
				num = (short)2033123328;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition3Feature_A19657.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x060074A0 RID: 29856 RVA: 0x0069115C File Offset: 0x0068F35C
		public bool SwitchConventionalSwitchTablePosition3Feature_A19657_HasDiffs
		{
			get
			{
				short num = (short)278396928;
				short num2 = num;
				num = (short)1206083201;
				short num3 = num;
				num = (short)495345281;
				switch (num3 == num)
				{
				}
				num = (short)1910702080;
				if (num != 0)
				{
				}
				num = (short)104923137;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition3Feature_A19657._HasDiffs;
			}
		}

		// Token: 0x17003C1D RID: 15389
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x00691210 File Offset: 0x0068F410
		// (set) Token: 0x060074A2 RID: 29858 RVA: 0x006912C0 File Offset: 0x0068F4C0
		public int SwitchConventionalSwitchTablePosition4Feature_A19658Value
		{
			get
			{
				short num = (short)642252800;
				short num2 = num;
				num = (short)1000740123;
				short num3 = num;
				num = (short)986846491;
				switch (num3 == num)
				{
				}
				num = (short)730267648;
				if (num != 0)
				{
				}
				num = (short)725352449;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.Value;
			}
			set
			{
				short num = (short)812696521;
				short num2 = num;
				num = (short)2041037769;
				switch (num2 == num)
				{
				}
				num = (short)238288897;
				if (num != 0)
				{
				}
				num = (short)1506148352;
				short num3 = num;
				num = (short)1963720704;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition4Feature_A19658.Value = value;
			}
		}

		// Token: 0x17003C1E RID: 15390
		// (get) Token: 0x060074A3 RID: 29859 RVA: 0x00691374 File Offset: 0x0068F574
		// (set) Token: 0x060074A4 RID: 29860 RVA: 0x00691428 File Offset: 0x0068F628
		public string SwitchConventionalSwitchTablePosition4Feature_A19658_UIValue
		{
			get
			{
				short num = (short)808021357;
				short num2 = num;
				num = (short)1393847661;
				switch (num2 == num)
				{
				}
				num = (short)1375076353;
				if (num != 0)
				{
				}
				num = (short)1720188928;
				short num3 = num;
				num = (short)322043904;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.UIValue;
			}
			set
			{
				short num = (short)422056668;
				short num2 = num;
				num = (short)698159836;
				switch (num2 == num)
				{
				}
				num = (short)2067070977;
				if (num != 0)
				{
				}
				num = (short)1987575808;
				short num3 = num;
				num = (short)449445888;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition4Feature_A19658.UIValue = value;
			}
		}

		// Token: 0x17003C1F RID: 15391
		// (get) Token: 0x060074A5 RID: 29861 RVA: 0x006914DC File Offset: 0x0068F6DC
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchTablePosition4Feature_A19658
		{
			get
			{
				short num = (short)1158764448;
				short num2 = num;
				num = (short)1700747168;
				switch (num2 == num)
				{
				}
				num = (short)1842348033;
				if (num != 0)
				{
				}
				num = (short)182190080;
				short num3 = num;
				num = (short)451084288;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658;
			}
		}

		// Token: 0x17003C20 RID: 15392
		// (get) Token: 0x060074A6 RID: 29862 RVA: 0x0069158C File Offset: 0x0068F78C
		// (set) Token: 0x060074A7 RID: 29863 RVA: 0x00691640 File Offset: 0x0068F840
		public bool SwitchConventionalSwitchTablePosition4Feature_A19658_Applicable
		{
			get
			{
				short num = (short)1651297936;
				short num2 = num;
				num = (short)429117072;
				switch (num2 == num)
				{
				}
				num = (short)945946625;
				if (num != 0)
				{
				}
				num = (short)1223426048;
				short num3 = num;
				num = (short)235470848;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.Applicable;
			}
			set
			{
				short num = (short)416298430;
				short num2 = num;
				num = (short)1260729790;
				switch (num2 == num)
				{
				}
				num = (short)1705967617;
				if (num != 0)
				{
				}
				num = (short)22478848;
				short num3 = num;
				num = (short)1979842560;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition4Feature_A19658.Applicable = value;
			}
		}

		// Token: 0x17003C21 RID: 15393
		// (get) Token: 0x060074A8 RID: 29864 RVA: 0x006916F8 File Offset: 0x0068F8F8
		// (set) Token: 0x060074A9 RID: 29865 RVA: 0x006917A8 File Offset: 0x0068F9A8
		public bool SwitchConventionalSwitchTablePosition4Feature_A19658_Valid
		{
			get
			{
				short num = (short)2004334030;
				short num2 = num;
				num = (short)211727822;
				switch (num2 == num)
				{
				}
				num = (short)1463746561;
				if (num != 0)
				{
				}
				num = (short)119078912;
				short num3 = num;
				num = (short)2108686336;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.Valid;
			}
			set
			{
				short num = (short)286698580;
				short num2 = num;
				num = (short)555068500;
				switch (num2 == num)
				{
				}
				num = (short)927465473;
				if (num != 0)
				{
				}
				num = (short)623640576;
				short num3 = num;
				num = (short)459800576;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition4Feature_A19658.Valid = value;
			}
		}

		// Token: 0x17003C22 RID: 15394
		// (get) Token: 0x060074AA RID: 29866 RVA: 0x0069185C File Offset: 0x0068FA5C
		// (set) Token: 0x060074AB RID: 29867 RVA: 0x00691910 File Offset: 0x0068FB10
		public bool SwitchConventionalSwitchTablePosition4Feature_A19658_Visible
		{
			get
			{
				short num = (short)839544049;
				short num2 = num;
				num = (short)314666225;
				switch (num2 == num)
				{
				}
				num = (short)227606528;
				if (num != 0)
				{
				}
				num = (short)520880128;
				short num3 = num;
				num = (short)56229889;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.Visible;
			}
			set
			{
				short num = (short)141251717;
				short num2 = num;
				num = (short)1353077893;
				switch (num2 == num)
				{
				}
				num = (short)1944322049;
				if (num != 0)
				{
				}
				num = (short)82706432;
				short num3 = num;
				num = (short)1098055680;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition4Feature_A19658.Visible = value;
			}
		}

		// Token: 0x17003C23 RID: 15395
		// (get) Token: 0x060074AC RID: 29868 RVA: 0x006919C4 File Offset: 0x0068FBC4
		// (set) Token: 0x060074AD RID: 29869 RVA: 0x00691A7C File Offset: 0x0068FC7C
		public bool SwitchConventionalSwitchTablePosition4Feature_A19658_Editable
		{
			get
			{
				short num = (short)1997602817;
				if (num != 0)
				{
				}
				num = (short)1437319144;
				short num2 = num;
				num = (short)1111998440;
				switch (num2 == num)
				{
				}
				num = (short)982253568;
				short num3 = num;
				num = (short)860225536;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.Editable;
			}
			set
			{
				short num = (short)1639822679;
				short num2 = num;
				num = (short)55817559;
				switch (num2 == num)
				{
				}
				num = (short)573243392;
				if (num != 0)
				{
				}
				num = (short)246415360;
				short num3 = num;
				num = (short)1727135745;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition4Feature_A19658.Editable = value;
			}
		}

		// Token: 0x17003C24 RID: 15396
		// (get) Token: 0x060074AE RID: 29870 RVA: 0x00691B30 File Offset: 0x0068FD30
		internal string SwitchConventionalSwitchTablePosition4Feature_A19658_UILabel
		{
			get
			{
				short num = (short)1853023810;
				short num2 = num;
				num = (short)1862198850;
				switch (num2 == num)
				{
				}
				num = (short)1027932161;
				if (num != 0)
				{
				}
				num = (short)1398865920;
				short num3 = num;
				num = (short)110755840;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.UIName;
			}
		}

		// Token: 0x17003C25 RID: 15397
		// (get) Token: 0x060074AF RID: 29871 RVA: 0x00691BE8 File Offset: 0x0068FDE8
		// (set) Token: 0x060074B0 RID: 29872 RVA: 0x00691CA0 File Offset: 0x0068FEA0
		internal bool SwitchConventionalSwitchTablePosition4Feature_A19658_HiddenStatic
		{
			get
			{
				short num = (short)2099367775;
				short num2 = num;
				num = (short)1647955807;
				switch (num2 == num)
				{
				}
				num = (short)31129601;
				if (num != 0)
				{
				}
				num = (short)887422976;
				short num3 = num;
				num = (short)208273408;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.HiddenStatic;
			}
			set
			{
				short num = (short)1259995137;
				if (num != 0)
				{
				}
				num = (short)1639998679;
				short num2 = num;
				num = (short)1046897879;
				switch (num2 == num)
				{
				}
				num = (short)880541696;
				short num3 = num;
				num = (short)1042219008;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition4Feature_A19658.HiddenStatic = value;
			}
		}

		// Token: 0x17003C26 RID: 15398
		// (get) Token: 0x060074B1 RID: 29873 RVA: 0x00691D58 File Offset: 0x0068FF58
		// (set) Token: 0x060074B2 RID: 29874 RVA: 0x00691E0C File Offset: 0x0069000C
		internal bool SwitchConventionalSwitchTablePosition4Feature_A19658_HiddenDynamic
		{
			get
			{
				short num = (short)1307049985;
				if (num != 0)
				{
				}
				num = (short)237255900;
				short num2 = num;
				num = (short)979320028;
				switch (num2 == num)
				{
				}
				num = (short)1343946752;
				short num3 = num;
				num = (short)1574371328;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658.HiddenDynamic;
			}
			set
			{
				short num = (short)546349983;
				short num2 = num;
				num = (short)2016322463;
				switch (num2 == num)
				{
				}
				num = (short)2027945984;
				if (num != 0)
				{
				}
				num = (short)1752956928;
				short num3 = num;
				num = (short)1896087553;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition4Feature_A19658.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C27 RID: 15399
		// (get) Token: 0x060074B3 RID: 29875 RVA: 0x00691EC4 File Offset: 0x006900C4
		public bool SwitchConventionalSwitchTablePosition4Feature_A19658_HasDiffs
		{
			get
			{
				short num = (short)1479719216;
				short num2 = num;
				num = (short)1448261936;
				switch (num2 == num)
				{
				}
				num = (short)696582145;
				if (num != 0)
				{
				}
				num = (short)578224128;
				short num3 = num;
				num = (short)1670971392;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition4Feature_A19658._HasDiffs;
			}
		}

		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x060074B4 RID: 29876 RVA: 0x00691F78 File Offset: 0x00690178
		// (set) Token: 0x060074B5 RID: 29877 RVA: 0x0069202C File Offset: 0x0069022C
		public int SwitchConventionalSwitchTablePosition5Feature_A19717Value
		{
			get
			{
				short num = (short)565083189;
				short num2 = num;
				num = (short)1400536117;
				switch (num2 == num)
				{
				}
				num = (short)2122514433;
				if (num != 0)
				{
				}
				num = (short)980811776;
				short num3 = num;
				num = (short)209846272;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.Value;
			}
			set
			{
				short num = (short)809238529;
				if (num != 0)
				{
				}
				num = (short)1401462782;
				short num2 = num;
				num = (short)1850843134;
				switch (num2 == num)
				{
				}
				num = (short)146997248;
				short num3 = num;
				num = (short)1932853248;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition5Feature_A19717.Value = value;
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x060074B6 RID: 29878 RVA: 0x006920E0 File Offset: 0x006902E0
		// (set) Token: 0x060074B7 RID: 29879 RVA: 0x00692194 File Offset: 0x00690394
		public string SwitchConventionalSwitchTablePosition5Feature_A19717_UIValue
		{
			get
			{
				short num = (short)2042927685;
				short num2 = num;
				num = (short)1046714949;
				switch (num2 == num)
				{
				}
				num = (short)1254948864;
				if (num != 0)
				{
				}
				num = (short)390266880;
				short num3 = num;
				num = (short)636485633;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.UIValue;
			}
			set
			{
				short num = (short)698897955;
				short num2 = num;
				num = (short)313611811;
				switch (num2 == num)
				{
				}
				num = (short)620953600;
				if (num != 0)
				{
				}
				num = (short)1198325760;
				short num3 = num;
				num = (short)270663681;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition5Feature_A19717.UIValue = value;
			}
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x060074B8 RID: 29880 RVA: 0x00692248 File Offset: 0x00690448
		public global::AcpBusinessLayer.AcpListField SwitchConventionalSwitchTablePosition5Feature_A19717
		{
			get
			{
				short num = (short)354718120;
				short num2 = num;
				num = (short)2000523688;
				switch (num2 == num)
				{
				}
				num = (short)1916796929;
				if (num != 0)
				{
				}
				num = (short)468385792;
				short num3 = num;
				num = (short)1506213888;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717;
			}
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x060074B9 RID: 29881 RVA: 0x006922F8 File Offset: 0x006904F8
		// (set) Token: 0x060074BA RID: 29882 RVA: 0x006923AC File Offset: 0x006905AC
		public bool SwitchConventionalSwitchTablePosition5Feature_A19717_Applicable
		{
			get
			{
				short num = (short)1131178964;
				short num2 = num;
				num = (short)1183673300;
				switch (num2 == num)
				{
				}
				num = (short)805437440;
				if (num != 0)
				{
				}
				num = (short)1785593856;
				short num3 = num;
				num = (short)1758658561;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.Applicable;
			}
			set
			{
				short num = (short)1403061177;
				short num2 = num;
				num = (short)341509049;
				switch (num2 == num)
				{
				}
				num = (short)374734848;
				if (num != 0)
				{
				}
				num = (short)1205469184;
				short num3 = num;
				num = (short)654835713;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition5Feature_A19717.Applicable = value;
			}
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x060074BB RID: 29883 RVA: 0x00692460 File Offset: 0x00690660
		// (set) Token: 0x060074BC RID: 29884 RVA: 0x00692514 File Offset: 0x00690714
		public bool SwitchConventionalSwitchTablePosition5Feature_A19717_Valid
		{
			get
			{
				short num = (short)693717443;
				short num2 = num;
				num = (short)612977091;
				switch (num2 == num)
				{
				}
				num = (short)872153089;
				if (num != 0)
				{
				}
				num = (short)1372061696;
				short num3 = num;
				num = (short)1104740352;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.Valid;
			}
			set
			{
				short num = (short)1511675729;
				short num2 = num;
				num = (short)2147309393;
				switch (num2 == num)
				{
				}
				num = (short)963313665;
				if (num != 0)
				{
				}
				num = (short)1388511232;
				short num3 = num;
				num = (short)2020999168;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition5Feature_A19717.Valid = value;
			}
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x060074BD RID: 29885 RVA: 0x006925CC File Offset: 0x006907CC
		// (set) Token: 0x060074BE RID: 29886 RVA: 0x00692680 File Offset: 0x00690880
		public bool SwitchConventionalSwitchTablePosition5Feature_A19717_Visible
		{
			get
			{
				short num = (short)1211339505;
				short num2 = num;
				num = (short)793285361;
				switch (num2 == num)
				{
				}
				num = (short)1890582528;
				if (num != 0)
				{
				}
				num = (short)950140928;
				short num3 = num;
				num = (short)953745409;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.Visible;
			}
			set
			{
				short num = (short)1159091342;
				short num2 = num;
				num = (short)1239897230;
				switch (num2 == num)
				{
				}
				num = (short)1182138368;
				if (num != 0)
				{
				}
				num = (short)1251540992;
				short num3 = num;
				num = (short)1814953985;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition5Feature_A19717.Visible = value;
			}
		}

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x060074BF RID: 29887 RVA: 0x00692734 File Offset: 0x00690934
		// (set) Token: 0x060074C0 RID: 29888 RVA: 0x006927E8 File Offset: 0x006909E8
		public bool SwitchConventionalSwitchTablePosition5Feature_A19717_Editable
		{
			get
			{
				short num = (short)1233528982;
				short num2 = num;
				num = (short)822814870;
				switch (num2 == num)
				{
				}
				num = (short)1500708865;
				if (num != 0)
				{
				}
				num = (short)144244736;
				short num3 = num;
				num = (short)1026686976;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.Editable;
			}
			set
			{
				short num = (short)1041813105;
				short num2 = num;
				num = (short)28888689;
				switch (num2 == num)
				{
				}
				num = (short)492961792;
				if (num != 0)
				{
				}
				num = (short)1208614912;
				short num3 = num;
				num = (short)2122973185;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition5Feature_A19717.Editable = value;
			}
		}

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x060074C1 RID: 29889 RVA: 0x0069289C File Offset: 0x00690A9C
		internal string SwitchConventionalSwitchTablePosition5Feature_A19717_UILabel
		{
			get
			{
				short num = (short)1972358690;
				short num2 = num;
				num = (short)823774754;
				switch (num2 == num)
				{
				}
				num = (short)1151467520;
				if (num != 0)
				{
				}
				num = (short)1552351232;
				short num3 = num;
				num = (short)837419009;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.UIName;
			}
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x060074C2 RID: 29890 RVA: 0x00692950 File Offset: 0x00690B50
		// (set) Token: 0x060074C3 RID: 29891 RVA: 0x00692A04 File Offset: 0x00690C04
		internal bool SwitchConventionalSwitchTablePosition5Feature_A19717_HiddenStatic
		{
			get
			{
				short num = (short)290011617;
				short num2 = num;
				num = (short)190134753;
				switch (num2 == num)
				{
				}
				num = (short)728956929;
				if (num != 0)
				{
				}
				num = (short)1123221504;
				short num3 = num;
				num = (short)1111162880;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.HiddenStatic;
			}
			set
			{
				short num = (short)903223260;
				short num2 = num;
				num = (short)560469980;
				switch (num2 == num)
				{
				}
				num = (short)883490817;
				if (num != 0)
				{
				}
				num = (short)812580864;
				short num3 = num;
				num = (short)809697280;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition5Feature_A19717.HiddenStatic = value;
			}
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x060074C4 RID: 29892 RVA: 0x00692ABC File Offset: 0x00690CBC
		// (set) Token: 0x060074C5 RID: 29893 RVA: 0x00692B74 File Offset: 0x00690D74
		internal bool SwitchConventionalSwitchTablePosition5Feature_A19717_HiddenDynamic
		{
			get
			{
				short num = (short)1821835265;
				if (num != 0)
				{
				}
				num = (short)1804752824;
				short num2 = num;
				num = (short)1704286136;
				switch (num2 == num)
				{
				}
				num = (short)1408761856;
				short num3 = num;
				num = (short)1423507456;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717.HiddenDynamic;
			}
			set
			{
				short num = (short)645811518;
				short num2 = num;
				num = (short)1134841150;
				switch (num2 == num)
				{
				}
				num = (short)961347584;
				if (num != 0)
				{
				}
				num = (short)1142161408;
				short num3 = num;
				num = (short)480968705;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchTablePosition5Feature_A19717.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x060074C6 RID: 29894 RVA: 0x00692C2C File Offset: 0x00690E2C
		public bool SwitchConventionalSwitchTablePosition5Feature_A19717_HasDiffs
		{
			get
			{
				short num = (short)912793023;
				short num2 = num;
				num = (short)1943870911;
				switch (num2 == num)
				{
				}
				num = (short)472580097;
				if (num != 0)
				{
				}
				num = (short)1888485376;
				short num3 = num;
				num = (short)1454899200;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchTablePosition5Feature_A19717._HasDiffs;
			}
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x060074C7 RID: 29895 RVA: 0x00692CE0 File Offset: 0x00690EE0
		// (set) Token: 0x060074C8 RID: 29896 RVA: 0x00692D94 File Offset: 0x00690F94
		public string SwitchConventionalSwitchKey_A21293Value
		{
			get
			{
				short num = (short)2141971167;
				short num2 = num;
				num = (short)1979310815;
				switch (num2 == num)
				{
				}
				num = (short)681312256;
				if (num != 0)
				{
				}
				num = (short)1880817664;
				short num3 = num;
				num = (short)1912995841;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.Value;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1090781185;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)733753197;
							short num3 = num;
							num = (short)1310601069;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1232797696;
								if (num != 0)
								{
								}
								num = (short)833945601;
								if (num != 0)
								{
								}
								num = (short)270139392;
								short num4 = num;
								this.switchConventionalSwitchKey_A21293.Value = value;
								num = (short)1282015234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							continue;
						case 2:
							return;
						}
						IL_31:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)982974464;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x060074C9 RID: 29897 RVA: 0x00692EBC File Offset: 0x006910BC
		// (set) Token: 0x060074CA RID: 29898 RVA: 0x00692F70 File Offset: 0x00691170
		public string SwitchConventionalSwitchKey_A21293_UIValue
		{
			get
			{
				short num = (short)1768517653;
				short num2 = num;
				num = (short)28733461;
				switch (num2 == num)
				{
				}
				num = (short)1100611584;
				if (num != 0)
				{
				}
				num = (short)1617821696;
				short num3 = num;
				num = (short)1317404673;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.Value;
			}
			set
			{
				short num = (short)714508706;
				short num2 = num;
				num = (short)1847167394;
				switch (num2 == num)
				{
				}
				num = (short)6619137;
				if (num != 0)
				{
				}
				num = (short)745472000;
				short num3 = num;
				num = (short)1267204096;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchKey_A21293.Value = value;
			}
		}

		// Token: 0x17003C35 RID: 15413
		// (get) Token: 0x060074CB RID: 29899 RVA: 0x00693028 File Offset: 0x00691228
		public global::AcpBusinessLayer.AcpKeyField SwitchConventionalSwitchKey_A21293
		{
			get
			{
				short num = (short)2087174166;
				short num2 = num;
				num = (short)1401012246;
				switch (num2 == num)
				{
				}
				num = (short)786956288;
				if (num != 0)
				{
				}
				num = (short)1068498944;
				short num3 = num;
				num = (short)401670145;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293;
			}
		}

		// Token: 0x17003C36 RID: 15414
		// (get) Token: 0x060074CC RID: 29900 RVA: 0x006930D8 File Offset: 0x006912D8
		// (set) Token: 0x060074CD RID: 29901 RVA: 0x00693190 File Offset: 0x00691390
		public bool SwitchConventionalSwitchKey_A21293_Applicable
		{
			get
			{
				short num = (short)742654149;
				short num2 = num;
				num = (short)2056978629;
				switch (num2 == num)
				{
				}
				num = (short)985399297;
				if (num != 0)
				{
				}
				num = (short)1839464448;
				short num3 = num;
				num = (short)55115776;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.Applicable;
			}
			set
			{
				short num = (short)1727004673;
				if (num != 0)
				{
				}
				num = (short)1713508208;
				short num2 = num;
				num = (short)49221488;
				switch (num2 == num)
				{
				}
				num = (short)254607360;
				short num3 = num;
				num = (short)851574784;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchKey_A21293.Applicable = value;
			}
		}

		// Token: 0x17003C37 RID: 15415
		// (get) Token: 0x060074CE RID: 29902 RVA: 0x00693244 File Offset: 0x00691444
		// (set) Token: 0x060074CF RID: 29903 RVA: 0x006932F8 File Offset: 0x006914F8
		public bool SwitchConventionalSwitchKey_A21293_Valid
		{
			get
			{
				short num = (short)732610935;
				short num2 = num;
				num = (short)65716599;
				switch (num2 == num)
				{
				}
				num = (short)155516929;
				if (num != 0)
				{
				}
				num = (short)1953366016;
				short num3 = num;
				num = (short)445972480;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.Valid;
			}
			set
			{
				short num = (short)1968010386;
				short num2 = num;
				num = (short)1054110866;
				switch (num2 == num)
				{
				}
				num = (short)311623680;
				if (num != 0)
				{
				}
				num = (short)833945600;
				short num3 = num;
				num = (short)524812289;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchKey_A21293.Valid = value;
			}
		}

		// Token: 0x17003C38 RID: 15416
		// (get) Token: 0x060074D0 RID: 29904 RVA: 0x006933AC File Offset: 0x006915AC
		// (set) Token: 0x060074D1 RID: 29905 RVA: 0x00693460 File Offset: 0x00691660
		public bool SwitchConventionalSwitchKey_A21293_Visible
		{
			get
			{
				short num = (short)223150081;
				if (num != 0)
				{
				}
				num = (short)1194705587;
				short num2 = num;
				num = (short)1593557683;
				switch (num2 == num)
				{
				}
				num = (short)213188608;
				short num3 = num;
				num = (short)1779564544;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.Visible;
			}
			set
			{
				short num = (short)105632652;
				short num2 = num;
				num = (short)1721422732;
				switch (num2 == num)
				{
				}
				num = (short)127139841;
				if (num != 0)
				{
				}
				num = (short)481624064;
				short num3 = num;
				num = (short)305463296;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchKey_A21293.Visible = value;
			}
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x060074D2 RID: 29906 RVA: 0x00693514 File Offset: 0x00691714
		// (set) Token: 0x060074D3 RID: 29907 RVA: 0x006935CC File Offset: 0x006917CC
		public bool SwitchConventionalSwitchKey_A21293_Editable
		{
			get
			{
				short num = (short)426926930;
				short num2 = num;
				num = (short)1068327762;
				switch (num2 == num)
				{
				}
				num = (short)2107834369;
				if (num != 0)
				{
				}
				num = (short)2134310912;
				short num3 = num;
				num = (short)1897857024;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.Editable;
			}
			set
			{
				short num = (short)336003073;
				if (num != 0)
				{
				}
				num = (short)725407950;
				short num2 = num;
				num = (short)1791482062;
				switch (num2 == num)
				{
				}
				num = (short)325320704;
				short num3 = num;
				num = (short)409534464;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchKey_A21293.Editable = value;
			}
		}

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x060074D4 RID: 29908 RVA: 0x00693680 File Offset: 0x00691880
		internal string SwitchConventionalSwitchKey_A21293_UILabel
		{
			get
			{
				short num = (short)1083034917;
				short num2 = num;
				num = (short)1480183077;
				switch (num2 == num)
				{
				}
				num = (short)1418395649;
				if (num != 0)
				{
				}
				num = (short)457965568;
				short num3 = num;
				num = (short)1502150656;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.UIName;
			}
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x060074D5 RID: 29909 RVA: 0x00693734 File Offset: 0x00691934
		// (set) Token: 0x060074D6 RID: 29910 RVA: 0x006937E8 File Offset: 0x006919E8
		internal bool SwitchConventionalSwitchKey_A21293_HiddenStatic
		{
			get
			{
				short num = (short)288939175;
				short num2 = num;
				num = (short)356048039;
				switch (num2 == num)
				{
				}
				num = (short)1630208001;
				if (num != 0)
				{
				}
				num = (short)1126563840;
				short num3 = num;
				num = (short)1545469952;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.HiddenStatic;
			}
			set
			{
				short num = (short)1122078948;
				short num2 = num;
				num = (short)1453560036;
				switch (num2 == num)
				{
				}
				num = (short)201326593;
				if (num != 0)
				{
				}
				num = (short)192348160;
				short num3 = num;
				num = (short)235274240;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchKey_A21293.HiddenStatic = value;
			}
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x060074D7 RID: 29911 RVA: 0x0069389C File Offset: 0x00691A9C
		// (set) Token: 0x060074D8 RID: 29912 RVA: 0x00693954 File Offset: 0x00691B54
		internal bool SwitchConventionalSwitchKey_A21293_HiddenDynamic
		{
			get
			{
				short num = (short)74825346;
				short num2 = num;
				num = (short)1687404162;
				switch (num2 == num)
				{
				}
				num = (short)1501822976;
				if (num != 0)
				{
				}
				num = (short)193331200;
				short num3 = num;
				num = (short)1984954369;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293.HiddenDynamic;
			}
			set
			{
				short num = (short)1142489089;
				if (num != 0)
				{
				}
				num = (short)1761245909;
				short num2 = num;
				num = (short)701725397;
				switch (num2 == num)
				{
				}
				num = (short)248381440;
				short num3 = num;
				num = (short)1416560640;
				if (num != 0)
				{
				}
				this.switchConventionalSwitchKey_A21293.HiddenDynamic = value;
			}
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x060074D9 RID: 29913 RVA: 0x00693A08 File Offset: 0x00691C08
		public bool SwitchConventionalSwitchKey_A21293_HasDiffs
		{
			get
			{
				short num = (short)28929445;
				short num2 = num;
				num = (short)1911713189;
				switch (num2 == num)
				{
				}
				num = (short)301072385;
				if (num != 0)
				{
				}
				num = (short)587137024;
				short num3 = num;
				num = (short)1762066432;
				if (num != 0)
				{
				}
				return this.switchConventionalSwitchKey_A21293._HasDiffs;
			}
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x060074DA RID: 29914 RVA: 0x00693ABC File Offset: 0x00691CBC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)45416449;
				if (num != 0)
				{
				}
				num = (short)2064571333;
				short num2 = num;
				num = (short)1427692485;
				switch (num2 == num)
				{
				}
				num = (short)1716060160;
				short num3 = num;
				num = (short)1587412992;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00693B80 File Offset: 0x00691D80
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1239351300;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				case 1:
					goto IL_AA;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1461190659;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				case 3:
				{
					num2 = (short)1987641345;
					if (num2 != 0)
					{
					}
					num2 = (short)1479059207;
					short num3 = num2;
					num2 = (short)1760864007;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_81;
					default:
						num2 = (short)1200160768;
						if (num2 != 0)
						{
						}
						num2 = (short)1602813952;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_81;
				}
				goto IL_24;
				IL_81:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1206779905;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_AA:
			IL_13B:
			num2 = (short)585433088;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1259274242;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002D16 RID: 11542
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePositionsQuantity_A19654;

		// Token: 0x04002D17 RID: 11543
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePosition1Feature_A19655;

		// Token: 0x04002D18 RID: 11544
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePosition2Feature_A19656;

		// Token: 0x04002D19 RID: 11545
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePosition3Feature_A19657;

		// Token: 0x04002D1A RID: 11546
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePosition4Feature_A19658;

		// Token: 0x04002D1B RID: 11547
		private global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePosition5Feature_A19717;

		// Token: 0x04002D1C RID: 11548
		private global::AcpBusinessLayer.AcpKeyField switchConventionalSwitchKey_A21293;
	}
}
