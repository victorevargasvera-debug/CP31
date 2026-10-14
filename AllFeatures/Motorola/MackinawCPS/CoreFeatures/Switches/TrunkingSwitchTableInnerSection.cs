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
	// Token: 0x020002C3 RID: 707
	[global::System.Serializable]
	public class TrunkingSwitchTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600766B RID: 30315 RVA: 0x006AD344 File Offset: 0x006AB544
		public TrunkingSwitchTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x006AD360 File Offset: 0x006AB560
		protected TrunkingSwitchTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x006AD378 File Offset: 0x006AB578
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1672401424;
			short num2 = num;
			num = (short)1695470096;
			switch (num2 == num)
			{
			}
			num = (short)498204672;
			short num3 = num;
			num = (short)1236074496;
			if (num != 0)
			{
			}
			num = (short)206176257;
			if (num != 0)
			{
			}
			this.switchTrunkingSwitchTablePositionsQuantity_A21003 = new global::AcpBusinessLayer.AcpListField(5, this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜诞鏠離诤賦胨藪諬볮蛰髲致银釸꿺鳼鷾洀昂唄栆稈戊礌明縐紒昔䘖氘稚猜欞䠠圢尤砦栨ᤪᰬἮİ2", a_), global::CommonResources.AcgResources.ID_POSITIONSQUANTITY, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePositionsQuantity_A21003LovStrs);
			this.switchTrunkingSwitchTablePositionsQuantity_A21003.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchTrunkingSwitchTablePositionsQuantity_A21003.DataTransferOrder = 11;
			this.switchTrunkingSwitchTablePosition1Feature_A21004 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition1Feature_A21004LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition1Feature_A21004LovStrs), this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜诞鏠離诤賦胨藪諬볮蛰髲致银釸꿺鳼鷾洀昂唄栆稈戊礌明縐紒␔儖簘稚検樞匠䘢稤昦ᬨᨪᴬἮ԰", a_), global::CommonResources.AcgResources.ID_POSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition1Feature_A21004LovStrs);
			this.switchTrunkingSwitchTablePosition1Feature_A21004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchTrunkingSwitchTablePosition1Feature_A21004.DataTransferOrder = 22;
			this.switchTrunkingSwitchTablePosition2Feature_A21005 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition2Feature_A21005LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition2Feature_A21005LovStrs), this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜诞鏠離诤賦胨藪諬볮蛰髲致银釸꿺鳼鷾洀昂唄栆稈戊礌明縐紒✔儖簘稚検樞匠䘢稤昦ᬨᨪᴬἮа", a_), global::CommonResources.AcgResources.ID_POSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition2Feature_A21005LovStrs);
			this.switchTrunkingSwitchTablePosition2Feature_A21005.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchTrunkingSwitchTablePosition2Feature_A21005.DataTransferOrder = 23;
			this.switchTrunkingSwitchTablePosition3Feature_A21006 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition3Feature_A21006LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition3Feature_A21006LovStrs), this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜诞鏠離诤賦胨藪諬볮蛰髲致银釸꿺鳼鷾洀昂唄栆稈戊礌明縐紒☔儖簘稚検樞匠䘢稤昦ᬨᨪᴬἮܰ", a_), global::CommonResources.AcgResources.ID_POSITIONC, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition3Feature_A21006LovStrs);
			this.switchTrunkingSwitchTablePosition3Feature_A21006.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchTrunkingSwitchTablePosition3Feature_A21006.DataTransferOrder = 24;
			this.switchTrunkingSwitchTablePosition4Feature_A21007 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition4Feature_A21007LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition4Feature_A21007LovStrs), this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜诞鏠離诤賦胨藪諬볮蛰髲致银釸꿺鳼鷾洀昂唄栆稈戊礌明縐紒℔儖簘稚検樞匠䘢稤昦ᬨᨪᴬἮذ", a_), global::CommonResources.AcgResources.ID_POSITIOND, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition4Feature_A21007LovStrs);
			this.switchTrunkingSwitchTablePosition4Feature_A21007.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchTrunkingSwitchTablePosition4Feature_A21007.DataTransferOrder = 25;
			this.switchTrunkingSwitchTablePosition5Feature_A21008 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition5Feature_A21008LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition5Feature_A21008LovStrs), this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜诞鏠離诤賦胨藪諬볮蛰髲致银釸꿺鳼鷾洀昂唄栆稈戊礌明縐紒—儖簘稚検樞匠䘢稤昦ᬨᨪᴬἮर", a_), global::CommonResources.AcgResources.ID_POSITIONE, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition5Feature_A21008LovStrs);
			this.switchTrunkingSwitchTablePosition5Feature_A21008.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchTrunkingSwitchTablePosition5Feature_A21008.DataTransferOrder = 26;
			this.switchTrunkingSwitchKey_A21294 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胒ꋔ뻖귘룚뗜诞鏠離诤賦胨藪諬볮蛰髲致银釸냺飼蛾帀䈂㜄㘆㬈㈊㤌", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.switchTrunkingSwitchKey_A21294.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.switchTrunkingSwitchKey_A21294.DataTransferOrder = 28;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟒꟔ꋖ럘냚드뇞蛠쏢뛤郦胨鿪軬蟮퇰ꟲ铴闶闸黺", a_);
			base.Id = 10084;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSWITCHTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x006AD660 File Offset: 0x006AB860
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)1084620822;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁㄃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝᠟", a_)))
					{
						num = (short)478806034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_426;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁〃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝ᜟ", a_)))
					{
						num = (short)1553072143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_474;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁㘃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝ᔟ", a_)))
					{
						num = (short)424345607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5AB;
				case 3:
					goto IL_474;
				case 4:
					goto IL_561;
				case 5:
					this.switchTrunkingSwitchTablePositionsQuantity_A21003 = new global::AcpBusinessLayer.AcpListField(5, this, global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁眃圅紇欉戋稍礏昑洓䤕夗⠙ⴛ⸝ဟᄡ", a_), global::CommonResources.AcgResources.ID_POSITIONSQUANTITY, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePositionsQuantity_A21003LovStrs);
					this.switchTrunkingSwitchTablePositionsQuantity_A21003.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchTrunkingSwitchTablePositionsQuantity_A21003.DataTransferOrder = 11;
					num = (short)1640562704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_2A1;
				case 7:
				{
					this.switchTrunkingSwitchTablePosition2Feature_A21005 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition2Feature_A21005LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition2Feature_A21005LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁㘃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝ᔟ", a_), global::CommonResources.AcgResources.ID_POSITIONB, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition2Feature_A21005LovStrs);
					this.switchTrunkingSwitchTablePosition2Feature_A21005.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchTrunkingSwitchTablePosition2Feature_A21005.DataTransferOrder = 23;
					num = (short)1702428672;
					short num3 = num;
					num = (short)1497038865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧ꇩ觫韭꿯돱웳쟵쫷쏹죻", a_)))
					{
						num = (short)1213988873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_643;
				case 9:
					this.switchTrunkingSwitchKey_A21294 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧ꇩ觫韭꿯돱웳쟵쫷쏹죻", a_), global::CommonResources.AcgResources.ID_KEY, 14);
					this.switchTrunkingSwitchKey_A21294.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchTrunkingSwitchKey_A21294.DataTransferOrder = 28;
					num = (short)134021132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					this.switchTrunkingSwitchTablePosition1Feature_A21004 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition1Feature_A21004LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition1Feature_A21004LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁㔃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝ᐟ", a_), global::CommonResources.AcgResources.ID_POSITIONA, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition1Feature_A21004LovStrs);
					this.switchTrunkingSwitchTablePosition1Feature_A21004.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchTrunkingSwitchTablePosition1Feature_A21004.DataTransferOrder = 22;
					num = (short)1069744132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_426;
				case 12:
					goto IL_33E;
				case 13:
					num = (short)762511383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁眃圅紇欉戋稍礏昑洓䤕夗⠙ⴛ⸝ဟᄡ", a_)))
					{
						num = (short)1530986501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D8;
				case 15:
					this.switchTrunkingSwitchTablePosition4Feature_A21007 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition4Feature_A21007LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition4Feature_A21007LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁〃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝ᜟ", a_), global::CommonResources.AcgResources.ID_POSITIOND, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition4Feature_A21007LovStrs);
					this.switchTrunkingSwitchTablePosition4Feature_A21007.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchTrunkingSwitchTablePosition4Feature_A21007.DataTransferOrder = 25;
					num = (short)663879683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_3D8;
				case 17:
					goto IL_5AB;
				case 18:
					this.switchTrunkingSwitchTablePosition5Feature_A21008 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition5Feature_A21008LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition5Feature_A21008LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁㄃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝᠟", a_), global::CommonResources.AcgResources.ID_POSITIONE, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition5Feature_A21008LovStrs);
					this.switchTrunkingSwitchTablePosition5Feature_A21008.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.switchTrunkingSwitchTablePosition5Feature_A21008.DataTransferOrder = 26;
					num = (short)270925835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
				{
					num = (short)1089688955;
					short num4 = num;
					num = (short)487937403;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_643;
					default:
						num = (short)1662648320;
						if (num != 0)
						{
						}
						this.switchTrunkingSwitchTablePosition3Feature_A21006 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Motorola.MackinawCPS.CoreFeatures.Switches.ControlLockSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.indexSwitchTrunkingSwitchTablePosition3Feature_A21006LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.idSwitchTrunkingSwitchTablePosition3Feature_A21006LovStrs), this, global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁㜃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝ᘟ", a_), global::CommonResources.AcgResources.ID_POSITIONC, true, global::Motorola.MackinawCPS.CoreFeatures.Switches.LOVs.SwitchTrunkingSwitchTablePosition3Feature_A21006LovStrs);
						this.switchTrunkingSwitchTablePosition3Feature_A21006.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.switchTrunkingSwitchTablePosition3Feature_A21006.DataTransferOrder = 24;
						num = (short)2041446406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 20:
					num = (short)909246478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁㔃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝ᐟ", a_)))
					{
						num = (short)529399818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_561;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 23:
					if (producerFields != null)
					{
						num = (short)1686700052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_643;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釁돃꿅볇꧉꓋髍ꋏꟑ뫓뷕뇗듙믛距韟诡郣藥胧뻩跫賭鳯韱ꓳ駵请鏹裻韽濿氁㜃䀅洇欉砋笍戏眑䬓圕⨗⬙Ⱋ⸝ᘟ", a_)))
					{
						num = (short)877461523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A1;
				}
				IL_91:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1293615117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2A1:
				num = (short)819658753;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D8:
				num = (short)620429333;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_426:
				num = (short)43384840;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_474:
				num = (short)477364224;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_561:
				num = (short)1432944642;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5AB:
				num = (short)1028325400;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_33E:
			IL_643:
			num = (short)1476788225;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雁뛃독ꛇꇉꗋꃍ럏蟓ꇕ뇗껙뿛뛝샟뛡藣蓥蓧迩", a_);
			base.Id = 10084;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSWITCHTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x006ADD08 File Offset: 0x006ABF08
		public override void PopulateReferences()
		{
			short num = (short)1604340159;
			short num2 = num;
			num = (short)2139048383;
			switch (num2 == num)
			{
			}
			num = (short)1038286848;
			short num3 = num;
			num = (short)825229312;
			if (num != 0)
			{
			}
			num = (short)1541996545;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x006ADDB0 File Offset: 0x006ABFB0
		public override void DropReferences()
		{
			short num = (short)112650863;
			short num2 = num;
			num = (short)849603183;
			switch (num2 == num)
			{
			}
			num = (short)186515456;
			short num3 = num;
			num = (short)171507713;
			if (num != 0)
			{
			}
			num = (short)1632174080;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x006ADE58 File Offset: 0x006AC058
		public override void SetConstraints()
		{
			short num = (short)323944449;
			if (num != 0)
			{
			}
			num = (short)1787042940;
			short num2 = num;
			num = (short)470097020;
			switch (num2 == num)
			{
			default:
			{
				num = (short)965804032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1484259328;
			if (num != 0)
			{
			}
			this.switchTrunkingSwitchTablePosition1Feature_A21004.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.SyncPositionAInTrkSwitchTable);
			this.switchTrunkingSwitchTablePosition2Feature_A21005.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.SyncPositionBInTrkSwitchTable);
			this.switchTrunkingSwitchTablePosition3Feature_A21006.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesConstraints.SyncPositionCInTrkSwitchTable);
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x006ADF44 File Offset: 0x006AC144
		public override void SetupDependencies()
		{
			short num = (short)416923754;
			short num2 = num;
			num = (short)2119090282;
			switch (num2 == num)
			{
			}
			num = (short)1567883264;
			short num3 = num;
			num = (short)570949632;
			if (num != 0)
			{
			}
			num = (short)1803026433;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.switchTrunkingSwitchTablePosition1Feature_A21004);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.switchTrunkingSwitchTablePosition1Feature_A21004);
			this.RefRadioWide.Features.SwitchConventionalSwitchesPosition1_A12643.AddDependentObject(this.switchTrunkingSwitchTablePosition1Feature_A21004);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.switchTrunkingSwitchTablePosition2Feature_A21005);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.switchTrunkingSwitchTablePosition2Feature_A21005);
			switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.switchTrunkingSwitchTablePosition3Feature_A21006);
			this.switchTrunkingSwitchTablePosition1Feature_A21004.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.switchTrunkingSwitchTablePosition1Feature_A21004.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.switchTrunkingSwitchTablePosition1Feature_A21004.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10075] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedLogicalSwitch2_A7756);
			this.switchTrunkingSwitchTablePosition1Feature_A21004.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10046] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.Features).SecWideFeaturesIgnoreSecureClearSwitchWhenStrapped_A8238);
			this.switchTrunkingSwitchTablePosition1Feature_A21004.AddDependentObject((base.ParentRecset.ParentSection.Parent[10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.switchTrunkingSwitchTablePosition1Feature_A21004.AddDependentObject((base.ParentRecset.ParentSection.Parent[10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.switchTrunkingSwitchTablePosition1Feature_A21004.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).SwitchConventionalSwitchesPosition1_A12643);
			this.switchTrunkingSwitchTablePosition2Feature_A21005.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.switchTrunkingSwitchTablePosition2Feature_A21005.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.switchTrunkingSwitchTablePosition2Feature_A21005.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10075] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedLogicalSwitch2_A7756);
			this.switchTrunkingSwitchTablePosition2Feature_A21005.AddDependentObject((base.ParentRecset.ParentSection.Parent[10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.switchTrunkingSwitchTablePosition2Feature_A21005.AddDependentObject((base.ParentRecset.ParentSection.Parent[10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.switchTrunkingSwitchTablePosition3Feature_A21006.AddDependentObject((base.ParentRecset.ParentSection.Parent[10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.switchTrunkingSwitchTablePosition3Feature_A21006.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10075] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedLogicalSwitch2_A7756);
			this.switchTrunkingSwitchTablePosition3Feature_A21006.AddDependentObject((base.ParentRecset.ParentSection.Parent[10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x06007673 RID: 30323 RVA: 0x006AE360 File Offset: 0x006AC560
		public bool HasDiffs
		{
			get
			{
				short num = (short)1773225122;
				short num2 = num;
				num = (short)1627800738;
				switch (num2 == num)
				{
				}
				num = (short)971374592;
				short num3 = num;
				num = (short)267583489;
				if (num != 0)
				{
				}
				num = (short)1663565824;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x006AE410 File Offset: 0x006AC610
		// (set) Token: 0x06007675 RID: 30325 RVA: 0x006AE4C4 File Offset: 0x006AC6C4
		public int SwitchTrunkingSwitchTablePositionsQuantity_A21003Value
		{
			get
			{
				short num = (short)247861738;
				short num2 = num;
				num = (short)1672155626;
				switch (num2 == num)
				{
				}
				num = (short)2115764224;
				short num3 = num;
				num = (short)1332346880;
				if (num != 0)
				{
				}
				num = (short)92471297;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.Value;
			}
			set
			{
				short num = (short)2092814795;
				short num2 = num;
				num = (short)1021235659;
				switch (num2 == num)
				{
				}
				num = (short)1507000320;
				short num3 = num;
				num = (short)185991168;
				if (num != 0)
				{
				}
				num = (short)2122645505;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePositionsQuantity_A21003.Value = value;
			}
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x06007676 RID: 30326 RVA: 0x006AE57C File Offset: 0x006AC77C
		// (set) Token: 0x06007677 RID: 30327 RVA: 0x006AE630 File Offset: 0x006AC830
		public string SwitchTrunkingSwitchTablePositionsQuantity_A21003_UIValue
		{
			get
			{
				short num = (short)1183850253;
				short num2 = num;
				num = (short)1553932045;
				switch (num2 == num)
				{
				}
				num = (short)1161691136;
				short num3 = num;
				num = (short)1758396417;
				if (num != 0)
				{
				}
				num = (short)1215168512;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.UIValue;
			}
			set
			{
				short num = (short)1091969293;
				short num2 = num;
				num = (short)1251156237;
				switch (num2 == num)
				{
				}
				num = (short)1007222785;
				if (num != 0)
				{
				}
				num = (short)1897332736;
				short num3 = num;
				num = (short)1936326656;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePositionsQuantity_A21003.UIValue = value;
			}
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x06007678 RID: 30328 RVA: 0x006AE6E4 File Offset: 0x006AC8E4
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchTablePositionsQuantity_A21003
		{
			get
			{
				short num = (short)448531855;
				short num2 = num;
				num = (short)1165626767;
				switch (num2 == num)
				{
				}
				num = (short)701628416;
				if (num != 0)
				{
				}
				num = (short)892928000;
				short num3 = num;
				num = (short)1473904641;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003;
			}
		}

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x06007679 RID: 30329 RVA: 0x006AE794 File Offset: 0x006AC994
		// (set) Token: 0x0600767A RID: 30330 RVA: 0x006AE848 File Offset: 0x006ACA48
		public bool SwitchTrunkingSwitchTablePositionsQuantity_A21003_Applicable
		{
			get
			{
				short num = (short)1296762577;
				short num2 = num;
				num = (short)1924204241;
				switch (num2 == num)
				{
				}
				num = (short)2139160577;
				if (num != 0)
				{
				}
				num = (short)1451360256;
				short num3 = num;
				num = (short)161021952;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.Applicable;
			}
			set
			{
				short num = (short)1132645726;
				short num2 = num;
				num = (short)1184025950;
				switch (num2 == num)
				{
				}
				num = (short)1537474560;
				if (num != 0)
				{
				}
				num = (short)1989148672;
				short num3 = num;
				num = (short)586547201;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePositionsQuantity_A21003.Applicable = value;
			}
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x0600767B RID: 30331 RVA: 0x006AE900 File Offset: 0x006ACB00
		// (set) Token: 0x0600767C RID: 30332 RVA: 0x006AE9B4 File Offset: 0x006ACBB4
		public bool SwitchTrunkingSwitchTablePositionsQuantity_A21003_Valid
		{
			get
			{
				short num = (short)1646371665;
				short num2 = num;
				num = (short)2092475217;
				switch (num2 == num)
				{
				}
				num = (short)1938948097;
				if (num != 0)
				{
				}
				num = (short)54067200;
				short num3 = num;
				num = (short)521666560;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.Valid;
			}
			set
			{
				short num = (short)700288574;
				short num2 = num;
				num = (short)59084350;
				switch (num2 == num)
				{
				}
				num = (short)1278017536;
				if (num != 0)
				{
				}
				num = (short)1655635968;
				short num3 = num;
				num = (short)1328152577;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePositionsQuantity_A21003.Valid = value;
			}
		}

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0600767D RID: 30333 RVA: 0x006AEA68 File Offset: 0x006ACC68
		// (set) Token: 0x0600767E RID: 30334 RVA: 0x006AEB1C File Offset: 0x006ACD1C
		public bool SwitchTrunkingSwitchTablePositionsQuantity_A21003_Visible
		{
			get
			{
				short num = (short)991138512;
				short num2 = num;
				num = (short)689083088;
				switch (num2 == num)
				{
				}
				num = (short)434896897;
				if (num != 0)
				{
				}
				num = (short)1742667776;
				short num3 = num;
				num = (short)2111963136;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.Visible;
			}
			set
			{
				short num = (short)1889639645;
				short num2 = num;
				num = (short)656579805;
				switch (num2 == num)
				{
				}
				num = (short)411762689;
				if (num != 0)
				{
				}
				num = (short)1143406592;
				short num3 = num;
				num = (short)620167168;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePositionsQuantity_A21003.Visible = value;
			}
		}

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0600767F RID: 30335 RVA: 0x006AEBD4 File Offset: 0x006ACDD4
		// (set) Token: 0x06007680 RID: 30336 RVA: 0x006AEC88 File Offset: 0x006ACE88
		public bool SwitchTrunkingSwitchTablePositionsQuantity_A21003_Editable
		{
			get
			{
				short num = (short)1087373313;
				if (num != 0)
				{
				}
				num = (short)1613487056;
				short num2 = num;
				num = (short)673962960;
				switch (num2 == num)
				{
				}
				num = (short)116260864;
				short num3 = num;
				num = (short)1143013376;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.Editable;
			}
			set
			{
				short num = (short)342148776;
				short num2 = num;
				num = (short)865060520;
				switch (num2 == num)
				{
				}
				num = (short)1092550656;
				if (num != 0)
				{
				}
				num = (short)430243840;
				short num3 = num;
				num = (short)429522945;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePositionsQuantity_A21003.Editable = value;
			}
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x06007681 RID: 30337 RVA: 0x006AED40 File Offset: 0x006ACF40
		internal string SwitchTrunkingSwitchTablePositionsQuantity_A21003_UILabel
		{
			get
			{
				short num = (short)1831087727;
				short num2 = num;
				num = (short)236007023;
				switch (num2 == num)
				{
				}
				num = (short)123076609;
				if (num != 0)
				{
				}
				num = (short)1294336000;
				short num3 = num;
				num = (short)713949184;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.UIName;
			}
		}

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x06007682 RID: 30338 RVA: 0x006AEDF4 File Offset: 0x006ACFF4
		// (set) Token: 0x06007683 RID: 30339 RVA: 0x006AEEA8 File Offset: 0x006AD0A8
		internal bool SwitchTrunkingSwitchTablePositionsQuantity_A21003_HiddenStatic
		{
			get
			{
				short num = (short)255085164;
				short num2 = num;
				num = (short)1036274284;
				switch (num2 == num)
				{
				}
				num = (short)1649410049;
				if (num != 0)
				{
				}
				num = (short)1106182144;
				short num3 = num;
				num = (short)1922433024;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.HiddenStatic;
			}
			set
			{
				short num = (short)348991972;
				short num2 = num;
				num = (short)1090007524;
				switch (num2 == num)
				{
				}
				num = (short)1908670464;
				if (num != 0)
				{
				}
				num = (short)1761280000;
				short num3 = num;
				num = (short)784859137;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePositionsQuantity_A21003.HiddenStatic = value;
			}
		}

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x06007684 RID: 30340 RVA: 0x006AEF60 File Offset: 0x006AD160
		// (set) Token: 0x06007685 RID: 30341 RVA: 0x006AF014 File Offset: 0x006AD214
		internal bool SwitchTrunkingSwitchTablePositionsQuantity_A21003_HiddenDynamic
		{
			get
			{
				short num = (short)2138908100;
				short num2 = num;
				num = (short)648226244;
				switch (num2 == num)
				{
				}
				num = (short)1791098881;
				if (num != 0)
				{
				}
				num = (short)1386676224;
				short num3 = num;
				num = (short)133562368;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003.HiddenDynamic;
			}
			set
			{
				short num = (short)1510476598;
				short num2 = num;
				num = (short)1968769846;
				switch (num2 == num)
				{
				}
				num = (short)146145281;
				if (num != 0)
				{
				}
				num = (short)1312882688;
				short num3 = num;
				num = (short)904855552;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePositionsQuantity_A21003.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x06007686 RID: 30342 RVA: 0x006AF0CC File Offset: 0x006AD2CC
		public bool SwitchTrunkingSwitchTablePositionsQuantity_A21003_HasDiffs
		{
			get
			{
				short num = (short)1279401845;
				short num2 = num;
				num = (short)1118838645;
				switch (num2 == num)
				{
				}
				num = (short)719716352;
				if (num != 0)
				{
				}
				num = (short)1743192064;
				short num3 = num;
				num = (short)2144206849;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePositionsQuantity_A21003._HasDiffs;
			}
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x06007687 RID: 30343 RVA: 0x006AF184 File Offset: 0x006AD384
		// (set) Token: 0x06007688 RID: 30344 RVA: 0x006AF238 File Offset: 0x006AD438
		public int SwitchTrunkingSwitchTablePosition1Feature_A21004Value
		{
			get
			{
				short num = (short)2020879444;
				short num2 = num;
				num = (short)616836180;
				switch (num2 == num)
				{
				}
				num = (short)213712896;
				if (num != 0)
				{
				}
				num = (short)2091384832;
				short num3 = num;
				num = (short)1741619201;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.Value;
			}
			set
			{
				short num = (short)1239457016;
				short num2 = num;
				num = (short)1690803448;
				switch (num2 == num)
				{
				}
				num = (short)57802752;
				if (num != 0)
				{
				}
				num = (short)1938554880;
				short num3 = num;
				num = (short)870842369;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition1Feature_A21004.Value = value;
			}
		}

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x06007689 RID: 30345 RVA: 0x006AF2F0 File Offset: 0x006AD4F0
		// (set) Token: 0x0600768A RID: 30346 RVA: 0x006AF3A4 File Offset: 0x006AD5A4
		public string SwitchTrunkingSwitchTablePosition1Feature_A21004_UIValue
		{
			get
			{
				short num = (short)2074786521;
				short num2 = num;
				num = (short)1600633561;
				switch (num2 == num)
				{
				}
				num = (short)169803777;
				if (num != 0)
				{
				}
				num = (short)1689321472;
				short num3 = num;
				num = (short)1372782592;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.UIValue;
			}
			set
			{
				short num = (short)46928721;
				short num2 = num;
				num = (short)893457233;
				switch (num2 == num)
				{
				}
				num = (short)211681281;
				if (num != 0)
				{
				}
				num = (short)1595015168;
				short num3 = num;
				num = (short)2105802752;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition1Feature_A21004.UIValue = value;
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0600768B RID: 30347 RVA: 0x006AF45C File Offset: 0x006AD65C
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchTablePosition1Feature_A21004
		{
			get
			{
				short num = (short)1715684060;
				short num2 = num;
				num = (short)1000293084;
				switch (num2 == num)
				{
				}
				num = (short)2089156609;
				if (num != 0)
				{
				}
				num = (short)632553472;
				short num3 = num;
				num = (short)189857792;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004;
			}
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x0600768C RID: 30348 RVA: 0x006AF50C File Offset: 0x006AD70C
		// (set) Token: 0x0600768D RID: 30349 RVA: 0x006AF5C0 File Offset: 0x006AD7C0
		public bool SwitchTrunkingSwitchTablePosition1Feature_A21004_Applicable
		{
			get
			{
				short num = (short)779510080;
				short num2 = num;
				num = (short)917397824;
				switch (num2 == num)
				{
				}
				num = (short)829816833;
				if (num != 0)
				{
				}
				num = (short)1742929920;
				short num3 = num;
				num = (short)960626688;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.Applicable;
			}
			set
			{
				short num = (short)216576530;
				short num2 = num;
				num = (short)66040338;
				switch (num2 == num)
				{
				}
				num = (short)1572864001;
				if (num != 0)
				{
				}
				num = (short)2114519040;
				short num3 = num;
				num = (short)2144010240;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition1Feature_A21004.Applicable = value;
			}
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x0600768E RID: 30350 RVA: 0x006AF674 File Offset: 0x006AD874
		// (set) Token: 0x0600768F RID: 30351 RVA: 0x006AF728 File Offset: 0x006AD928
		public bool SwitchTrunkingSwitchTablePosition1Feature_A21004_Valid
		{
			get
			{
				short num = (short)1448090174;
				short num2 = num;
				num = (short)1393826366;
				switch (num2 == num)
				{
				}
				num = (short)1131479040;
				if (num != 0)
				{
				}
				num = (short)503119872;
				short num3 = num;
				num = (short)194576385;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.Valid;
			}
			set
			{
				short num = (short)579178306;
				short num2 = num;
				num = (short)302616386;
				switch (num2 == num)
				{
				}
				num = (short)1441988608;
				if (num != 0)
				{
				}
				num = (short)757792768;
				short num3 = num;
				num = (short)784334849;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition1Feature_A21004.Valid = value;
			}
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x06007690 RID: 30352 RVA: 0x006AF7DC File Offset: 0x006AD9DC
		// (set) Token: 0x06007691 RID: 30353 RVA: 0x006AF890 File Offset: 0x006ADA90
		public bool SwitchTrunkingSwitchTablePosition1Feature_A21004_Visible
		{
			get
			{
				short num = (short)1055463317;
				short num2 = num;
				num = (short)1034557333;
				switch (num2 == num)
				{
				}
				num = (short)1157038080;
				if (num != 0)
				{
				}
				num = (short)318832640;
				short num3 = num;
				num = (short)1866203137;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.Visible;
			}
			set
			{
				short num = (short)958641817;
				short num2 = num;
				num = (short)423933593;
				switch (num2 == num)
				{
				}
				num = (short)971505664;
				if (num != 0)
				{
				}
				num = (short)928579584;
				short num3 = num;
				num = (short)1664483329;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition1Feature_A21004.Visible = value;
			}
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x06007692 RID: 30354 RVA: 0x006AF944 File Offset: 0x006ADB44
		// (set) Token: 0x06007693 RID: 30355 RVA: 0x006AF9F8 File Offset: 0x006ADBF8
		public bool SwitchTrunkingSwitchTablePosition1Feature_A21004_Editable
		{
			get
			{
				short num = (short)609409899;
				short num2 = num;
				num = (short)1216142187;
				switch (num2 == num)
				{
				}
				num = (short)2037448704;
				if (num != 0)
				{
				}
				num = (short)825753600;
				short num3 = num;
				num = (short)756744193;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.Editable;
			}
			set
			{
				short num = (short)362065061;
				short num2 = num;
				num = (short)320318629;
				switch (num2 == num)
				{
				}
				num = (short)1251737600;
				if (num != 0)
				{
				}
				num = (short)1564082176;
				short num3 = num;
				num = (short)830734337;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition1Feature_A21004.Editable = value;
			}
		}

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x06007694 RID: 30356 RVA: 0x006AFAB0 File Offset: 0x006ADCB0
		internal string SwitchTrunkingSwitchTablePosition1Feature_A21004_UILabel
		{
			get
			{
				short num = (short)2020119212;
				short num2 = num;
				num = (short)325358252;
				switch (num2 == num)
				{
				}
				num = (short)175308801;
				if (num != 0)
				{
				}
				num = (short)727646208;
				short num3 = num;
				num = (short)691798016;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.UIName;
			}
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x006AFB64 File Offset: 0x006ADD64
		// (set) Token: 0x06007696 RID: 30358 RVA: 0x006AFC18 File Offset: 0x006ADE18
		internal bool SwitchTrunkingSwitchTablePosition1Feature_A21004_HiddenStatic
		{
			get
			{
				short num = (short)882349465;
				short num2 = num;
				num = (short)1290507673;
				switch (num2 == num)
				{
				}
				num = (short)230096897;
				if (num != 0)
				{
				}
				num = (short)926679040;
				short num3 = num;
				num = (short)1514733568;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.HiddenStatic;
			}
			set
			{
				short num = (short)607192227;
				short num2 = num;
				num = (short)2132083875;
				switch (num2 == num)
				{
				}
				num = (short)921567233;
				if (num != 0)
				{
				}
				num = (short)515112960;
				short num3 = num;
				num = (short)2109865984;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition1Feature_A21004.HiddenStatic = value;
			}
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x06007697 RID: 30359 RVA: 0x006AFCD0 File Offset: 0x006ADED0
		// (set) Token: 0x06007698 RID: 30360 RVA: 0x006AFD84 File Offset: 0x006ADF84
		internal bool SwitchTrunkingSwitchTablePosition1Feature_A21004_HiddenDynamic
		{
			get
			{
				short num = (short)665991174;
				short num2 = num;
				num = (short)1545549830;
				switch (num2 == num)
				{
				}
				num = (short)993001473;
				if (num != 0)
				{
				}
				num = (short)691929088;
				short num3 = num;
				num = (short)912982016;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004.HiddenDynamic;
			}
			set
			{
				short num = (short)1917019724;
				short num2 = num;
				num = (short)263611980;
				switch (num2 == num)
				{
				}
				num = (short)357892097;
				if (num != 0)
				{
				}
				num = (short)2052194304;
				short num3 = num;
				num = (short)1607401472;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition1Feature_A21004.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x06007699 RID: 30361 RVA: 0x006AFE38 File Offset: 0x006AE038
		public bool SwitchTrunkingSwitchTablePosition1Feature_A21004_HasDiffs
		{
			get
			{
				short num = (short)1160369014;
				short num2 = num;
				num = (short)1917703030;
				switch (num2 == num)
				{
				}
				num = (short)1921646593;
				if (num != 0)
				{
				}
				num = (short)1145176064;
				short num3 = num;
				num = (short)1217789952;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition1Feature_A21004._HasDiffs;
			}
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x0600769A RID: 30362 RVA: 0x006AFEEC File Offset: 0x006AE0EC
		// (set) Token: 0x0600769B RID: 30363 RVA: 0x006AFFA0 File Offset: 0x006AE1A0
		public int SwitchTrunkingSwitchTablePosition2Feature_A21005Value
		{
			get
			{
				short num = (short)160647189;
				short num2 = num;
				num = (short)566839317;
				switch (num2 == num)
				{
				}
				num = (short)1043005440;
				if (num != 0)
				{
				}
				num = (short)1151729664;
				short num3 = num;
				num = (short)1184301057;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.Value;
			}
			set
			{
				short num = (short)1906166783;
				short num2 = num;
				num = (short)1157745663;
				switch (num2 == num)
				{
				}
				num = (short)1927348224;
				if (num != 0)
				{
				}
				num = (short)792199168;
				short num3 = num;
				num = (short)341901313;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition2Feature_A21005.Value = value;
			}
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x0600769C RID: 30364 RVA: 0x006B0058 File Offset: 0x006AE258
		// (set) Token: 0x0600769D RID: 30365 RVA: 0x006B010C File Offset: 0x006AE30C
		public string SwitchTrunkingSwitchTablePosition2Feature_A21005_UIValue
		{
			get
			{
				short num = (short)43694130;
				short num2 = num;
				num = (short)1467201586;
				switch (num2 == num)
				{
				}
				num = (short)1732706304;
				if (num != 0)
				{
				}
				num = (short)628686848;
				short num3 = num;
				num = (short)964296705;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.UIValue;
			}
			set
			{
				short num = (short)191284122;
				short num2 = num;
				num = (short)1917961114;
				switch (num2 == num)
				{
				}
				num = (short)1121124352;
				if (num != 0)
				{
				}
				num = (short)1978007552;
				short num3 = num;
				num = (short)1291583489;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition2Feature_A21005.UIValue = value;
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x0600769E RID: 30366 RVA: 0x006B01C4 File Offset: 0x006AE3C4
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchTablePosition2Feature_A21005
		{
			get
			{
				short num = (short)1276388265;
				short num2 = num;
				num = (short)1862411177;
				switch (num2 == num)
				{
				}
				num = (short)434176001;
				if (num != 0)
				{
				}
				num = (short)171114496;
				short num3 = num;
				num = (short)1503133696;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005;
			}
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x0600769F RID: 30367 RVA: 0x006B0274 File Offset: 0x006AE474
		// (set) Token: 0x060076A0 RID: 30368 RVA: 0x006B0328 File Offset: 0x006AE528
		public bool SwitchTrunkingSwitchTablePosition2Feature_A21005_Applicable
		{
			get
			{
				short num = (short)315683779;
				short num2 = num;
				num = (short)1625224131;
				switch (num2 == num)
				{
				}
				num = (short)946208768;
				if (num != 0)
				{
				}
				num = (short)415891456;
				short num3 = num;
				num = (short)38207489;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.Applicable;
			}
			set
			{
				short num = (short)70651070;
				short num2 = num;
				num = (short)25955518;
				switch (num2 == num)
				{
				}
				num = (short)1488191488;
				if (num != 0)
				{
				}
				num = (short)1498021888;
				short num3 = num;
				num = (short)362414081;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition2Feature_A21005.Applicable = value;
			}
		}

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x060076A1 RID: 30369 RVA: 0x006B03E0 File Offset: 0x006AE5E0
		// (set) Token: 0x060076A2 RID: 30370 RVA: 0x006B0494 File Offset: 0x006AE694
		public bool SwitchTrunkingSwitchTablePosition2Feature_A21005_Valid
		{
			get
			{
				short num = (short)919863297;
				if (num != 0)
				{
				}
				num = (short)1733007822;
				short num2 = num;
				num = (short)272341454;
				switch (num2 == num)
				{
				}
				num = (short)1692401664;
				short num3 = num;
				num = (short)1872625664;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.Valid;
			}
			set
			{
				short num = (short)1111014850;
				short num2 = num;
				num = (short)1435090370;
				switch (num2 == num)
				{
				}
				num = (short)1352794113;
				if (num != 0)
				{
				}
				num = (short)445317120;
				short num3 = num;
				num = (short)1642004480;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition2Feature_A21005.Valid = value;
			}
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x060076A3 RID: 30371 RVA: 0x006B0548 File Offset: 0x006AE748
		// (set) Token: 0x060076A4 RID: 30372 RVA: 0x006B05FC File Offset: 0x006AE7FC
		public bool SwitchTrunkingSwitchTablePosition2Feature_A21005_Visible
		{
			get
			{
				short num = (short)2010710017;
				if (num != 0)
				{
				}
				num = (short)1372528667;
				short num2 = num;
				num = (short)1125916699;
				switch (num2 == num)
				{
				}
				num = (short)1790705664;
				short num3 = num;
				num = (short)1896284160;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.Visible;
			}
			set
			{
				short num = (short)2045872035;
				short num2 = num;
				num = (short)1555007395;
				switch (num2 == num)
				{
				}
				num = (short)54853633;
				if (num != 0)
				{
				}
				num = (short)416743424;
				short num3 = num;
				num = (short)2104819712;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition2Feature_A21005.Visible = value;
			}
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x060076A5 RID: 30373 RVA: 0x006B06B0 File Offset: 0x006AE8B0
		// (set) Token: 0x060076A6 RID: 30374 RVA: 0x006B0764 File Offset: 0x006AE964
		public bool SwitchTrunkingSwitchTablePosition2Feature_A21005_Editable
		{
			get
			{
				short num = (short)2099445761;
				if (num != 0)
				{
				}
				num = (short)296952726;
				short num2 = num;
				num = (short)689251222;
				switch (num2 == num)
				{
				}
				num = (short)539754496;
				short num3 = num;
				num = (short)1715929088;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.Editable;
			}
			set
			{
				short num = (short)11215867;
				short num2 = num;
				num = (short)804791291;
				switch (num2 == num)
				{
				}
				num = (short)1677459457;
				if (num != 0)
				{
				}
				num = (short)1693712384;
				short num3 = num;
				num = (short)2006122496;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition2Feature_A21005.Editable = value;
			}
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x060076A7 RID: 30375 RVA: 0x006B081C File Offset: 0x006AEA1C
		internal string SwitchTrunkingSwitchTablePosition2Feature_A21005_UILabel
		{
			get
			{
				short num = (short)1848639489;
				if (num != 0)
				{
				}
				num = (short)1121509177;
				short num2 = num;
				num = (short)1271979833;
				switch (num2 == num)
				{
				}
				num = (short)218759168;
				short num3 = num;
				num = (short)220790784;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.UIName;
			}
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x060076A8 RID: 30376 RVA: 0x006B08D0 File Offset: 0x006AEAD0
		// (set) Token: 0x060076A9 RID: 30377 RVA: 0x006B0984 File Offset: 0x006AEB84
		internal bool SwitchTrunkingSwitchTablePosition2Feature_A21005_HiddenStatic
		{
			get
			{
				short num = (short)886177030;
				short num2 = num;
				num = (short)1343356166;
				switch (num2 == num)
				{
				}
				num = (short)593625089;
				if (num != 0)
				{
				}
				num = (short)1860829184;
				short num3 = num;
				num = (short)1369702400;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.HiddenStatic;
			}
			set
			{
				short num = (short)83072022;
				short num2 = num;
				num = (short)439522326;
				switch (num2 == num)
				{
				}
				num = (short)179634176;
				if (num != 0)
				{
				}
				num = (short)277020672;
				short num3 = num;
				num = (short)1080492033;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition2Feature_A21005.HiddenStatic = value;
			}
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x060076AA RID: 30378 RVA: 0x006B0A3C File Offset: 0x006AEC3C
		// (set) Token: 0x060076AB RID: 30379 RVA: 0x006B0AF0 File Offset: 0x006AECF0
		internal bool SwitchTrunkingSwitchTablePosition2Feature_A21005_HiddenDynamic
		{
			get
			{
				short num = (short)541829033;
				short num2 = num;
				num = (short)974366633;
				switch (num2 == num)
				{
				}
				num = (short)1648558081;
				if (num != 0)
				{
				}
				num = (short)949878784;
				short num3 = num;
				num = (short)1228734464;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005.HiddenDynamic;
			}
			set
			{
				short num = (short)175331089;
				short num2 = num;
				num = (short)368203537;
				switch (num2 == num)
				{
				}
				num = (short)1894645761;
				if (num != 0)
				{
				}
				num = (short)406585344;
				short num3 = num;
				num = (short)835715072;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition2Feature_A21005.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x060076AC RID: 30380 RVA: 0x006B0BA4 File Offset: 0x006AEDA4
		public bool SwitchTrunkingSwitchTablePosition2Feature_A21005_HasDiffs
		{
			get
			{
				short num = (short)218807930;
				short num2 = num;
				num = (short)91405946;
				switch (num2 == num)
				{
				}
				num = (short)98238465;
				if (num != 0)
				{
				}
				num = (short)382730240;
				short num3 = num;
				num = (short)114556928;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition2Feature_A21005._HasDiffs;
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x060076AD RID: 30381 RVA: 0x006B0C58 File Offset: 0x006AEE58
		// (set) Token: 0x060076AE RID: 30382 RVA: 0x006B0D0C File Offset: 0x006AEF0C
		public int SwitchTrunkingSwitchTablePosition3Feature_A21006Value
		{
			get
			{
				short num = (short)472702001;
				short num2 = num;
				num = (short)2053495857;
				switch (num2 == num)
				{
				}
				num = (short)179306496;
				if (num != 0)
				{
				}
				num = (short)524091392;
				short num3 = num;
				num = (short)1117257729;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.Value;
			}
			set
			{
				short num = (short)1985527756;
				short num2 = num;
				num = (short)502317004;
				switch (num2 == num)
				{
				}
				num = (short)1701838849;
				if (num != 0)
				{
				}
				num = (short)1831141376;
				short num3 = num;
				num = (short)1799159808;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition3Feature_A21006.Value = value;
			}
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x060076AF RID: 30383 RVA: 0x006B0DC4 File Offset: 0x006AEFC4
		// (set) Token: 0x060076B0 RID: 30384 RVA: 0x006B0E7C File Offset: 0x006AF07C
		public string SwitchTrunkingSwitchTablePosition3Feature_A21006_UIValue
		{
			get
			{
				short num = (short)1062951805;
				short num2 = num;
				num = (short)577198973;
				switch (num2 == num)
				{
				}
				num = (short)55771137;
				if (num != 0)
				{
				}
				num = (short)1031012352;
				short num3 = num;
				num = (short)1362558976;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.UIValue;
			}
			set
			{
				short num = (short)617737363;
				short num2 = num;
				num = (short)1069345939;
				switch (num2 == num)
				{
				}
				num = (short)324206593;
				if (num != 0)
				{
				}
				num = (short)956235776;
				short num3 = num;
				num = (short)421789696;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition3Feature_A21006.UIValue = value;
			}
		}

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x060076B1 RID: 30385 RVA: 0x006B0F30 File Offset: 0x006AF130
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchTablePosition3Feature_A21006
		{
			get
			{
				short num = (short)864944129;
				if (num != 0)
				{
				}
				num = (short)899825179;
				short num2 = num;
				num = (short)1407073819;
				switch (num2 == num)
				{
				}
				num = (short)1264910336;
				short num3 = num;
				num = (short)2131296256;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006;
			}
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x060076B2 RID: 30386 RVA: 0x006B0FE0 File Offset: 0x006AF1E0
		// (set) Token: 0x060076B3 RID: 30387 RVA: 0x006B1090 File Offset: 0x006AF290
		public bool SwitchTrunkingSwitchTablePosition3Feature_A21006_Applicable
		{
			get
			{
				short num = (short)136678332;
				short num2 = num;
				num = (short)1142524860;
				switch (num2 == num)
				{
				}
				num = (short)821690368;
				if (num != 0)
				{
				}
				num = (short)659750912;
				short num3 = num;
				num = (short)871759873;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.Applicable;
			}
			set
			{
				short num = (short)1168037797;
				short num2 = num;
				num = (short)1450235813;
				switch (num2 == num)
				{
				}
				num = (short)95682560;
				if (num != 0)
				{
				}
				num = (short)745537536;
				short num3 = num;
				num = (short)193069057;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition3Feature_A21006.Applicable = value;
			}
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x060076B4 RID: 30388 RVA: 0x006B1144 File Offset: 0x006AF344
		// (set) Token: 0x060076B5 RID: 30389 RVA: 0x006B11F8 File Offset: 0x006AF3F8
		public bool SwitchTrunkingSwitchTablePosition3Feature_A21006_Valid
		{
			get
			{
				short num = (short)1242478436;
				short num2 = num;
				num = (short)833861476;
				switch (num2 == num)
				{
				}
				num = (short)1902510081;
				if (num != 0)
				{
				}
				num = (short)1925251072;
				short num3 = num;
				num = (short)263520256;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.Valid;
			}
			set
			{
				short num = (short)509341751;
				short num2 = num;
				num = (short)1088614455;
				switch (num2 == num)
				{
				}
				num = (short)670629889;
				if (num != 0)
				{
				}
				num = (short)86376448;
				short num3 = num;
				num = (short)2129985536;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition3Feature_A21006.Valid = value;
			}
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x060076B6 RID: 30390 RVA: 0x006B12B0 File Offset: 0x006AF4B0
		// (set) Token: 0x060076B7 RID: 30391 RVA: 0x006B1368 File Offset: 0x006AF568
		public bool SwitchTrunkingSwitchTablePosition3Feature_A21006_Visible
		{
			get
			{
				short num = (short)1253919011;
				short num2 = num;
				num = (short)1621969187;
				switch (num2 == num)
				{
				}
				num = (short)185597953;
				if (num != 0)
				{
				}
				num = (short)653328384;
				short num3 = num;
				num = (short)994443264;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.Visible;
			}
			set
			{
				short num = (short)267268366;
				short num2 = num;
				num = (short)1734029582;
				switch (num2 == num)
				{
				}
				num = (short)501678081;
				if (num != 0)
				{
				}
				num = (short)1776484352;
				short num3 = num;
				num = (short)611778560;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition3Feature_A21006.Visible = value;
			}
		}

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x060076B8 RID: 30392 RVA: 0x006B141C File Offset: 0x006AF61C
		// (set) Token: 0x060076B9 RID: 30393 RVA: 0x006B14D0 File Offset: 0x006AF6D0
		public bool SwitchTrunkingSwitchTablePosition3Feature_A21006_Editable
		{
			get
			{
				short num = (short)1805068748;
				short num2 = num;
				num = (short)904473036;
				switch (num2 == num)
				{
				}
				num = (short)832438273;
				if (num != 0)
				{
				}
				num = (short)1806172160;
				short num3 = num;
				num = (short)944963584;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.Editable;
			}
			set
			{
				short num = (short)627380838;
				short num2 = num;
				num = (short)1525420646;
				switch (num2 == num)
				{
				}
				num = (short)1228472320;
				if (num != 0)
				{
				}
				num = (short)1445265408;
				short num3 = num;
				num = (short)2134310913;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition3Feature_A21006.Editable = value;
			}
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x060076BA RID: 30394 RVA: 0x006B1584 File Offset: 0x006AF784
		internal string SwitchTrunkingSwitchTablePosition3Feature_A21006_UILabel
		{
			get
			{
				short num = (short)1814757376;
				short num2 = num;
				num = (short)799329176;
				short num3 = num;
				num = (short)2055588760;
				switch (num3 == num)
				{
				}
				num = (short)2018312193;
				if (num != 0)
				{
				}
				num = (short)1546977280;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.UIName;
			}
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x060076BB RID: 30395 RVA: 0x006B1634 File Offset: 0x006AF834
		// (set) Token: 0x060076BC RID: 30396 RVA: 0x006B16E8 File Offset: 0x006AF8E8
		internal bool SwitchTrunkingSwitchTablePosition3Feature_A21006_HiddenStatic
		{
			get
			{
				short num = (short)283049984;
				short num2 = num;
				num = (short)638997069;
				short num3 = num;
				num = (short)319246925;
				switch (num3 == num)
				{
				}
				num = (short)897843201;
				if (num != 0)
				{
				}
				num = (short)1426718720;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.HiddenStatic;
			}
			set
			{
				short num = (short)527695872;
				short num2 = num;
				num = (short)1385677600;
				short num3 = num;
				num = (short)1908130592;
				switch (num3 == num)
				{
				}
				num = (short)1649934336;
				if (num != 0)
				{
				}
				num = (short)1095434241;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition3Feature_A21006.HiddenStatic = value;
			}
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x060076BD RID: 30397 RVA: 0x006B179C File Offset: 0x006AF99C
		// (set) Token: 0x060076BE RID: 30398 RVA: 0x006B1850 File Offset: 0x006AFA50
		internal bool SwitchTrunkingSwitchTablePosition3Feature_A21006_HiddenDynamic
		{
			get
			{
				short num = (short)691929088;
				short num2 = num;
				num = (short)619074421;
				short num3 = num;
				num = (short)1065374581;
				switch (num3 == num)
				{
				}
				num = (short)1997340672;
				if (num != 0)
				{
				}
				num = (short)406061057;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006.HiddenDynamic;
			}
			set
			{
				short num = (short)1449787392;
				short num2 = num;
				num = (short)561607713;
				short num3 = num;
				num = (short)945714209;
				switch (num3 == num)
				{
				}
				num = (short)1220935681;
				if (num != 0)
				{
				}
				num = (short)1105330176;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition3Feature_A21006.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x060076BF RID: 30399 RVA: 0x006B1904 File Offset: 0x006AFB04
		public bool SwitchTrunkingSwitchTablePosition3Feature_A21006_HasDiffs
		{
			get
			{
				short num = (short)661389312;
				short num2 = num;
				num = (short)871432193;
				if (num != 0)
				{
				}
				num = (short)887019869;
				short num3 = num;
				num = (short)777509213;
				switch (num3 == num)
				{
				}
				num = (short)2053242880;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition3Feature_A21006._HasDiffs;
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x060076C0 RID: 30400 RVA: 0x006B19B8 File Offset: 0x006AFBB8
		// (set) Token: 0x060076C1 RID: 30401 RVA: 0x006B1A6C File Offset: 0x006AFC6C
		public int SwitchTrunkingSwitchTablePosition4Feature_A21007Value
		{
			get
			{
				short num = (short)746979328;
				short num2 = num;
				num = (short)738983937;
				if (num != 0)
				{
				}
				num = (short)1992202032;
				short num3 = num;
				num = (short)1046648624;
				switch (num3 == num)
				{
				}
				num = (short)41353216;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.Value;
			}
			set
			{
				short num = (short)692584448;
				short num2 = num;
				num = (short)1082007438;
				short num3 = num;
				num = (short)928194446;
				switch (num3 == num)
				{
				}
				num = (short)571146241;
				if (num != 0)
				{
				}
				num = (short)600637440;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition4Feature_A21007.Value = value;
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x060076C2 RID: 30402 RVA: 0x006B1B24 File Offset: 0x006AFD24
		// (set) Token: 0x060076C3 RID: 30403 RVA: 0x006B1BD8 File Offset: 0x006AFDD8
		public string SwitchTrunkingSwitchTablePosition4Feature_A21007_UIValue
		{
			get
			{
				short num = (short)1976238080;
				short num2 = num;
				num = (short)326645278;
				short num3 = num;
				num = (short)591541790;
				switch (num3 == num)
				{
				}
				num = (short)800915457;
				if (num != 0)
				{
				}
				num = (short)821035008;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.UIValue;
			}
			set
			{
				short num = (short)740098048;
				short num2 = num;
				num = (short)288882689;
				if (num != 0)
				{
				}
				num = (short)44812145;
				short num3 = num;
				num = (short)552257393;
				switch (num3 == num)
				{
				}
				num = (short)1682833408;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition4Feature_A21007.UIValue = value;
			}
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x060076C4 RID: 30404 RVA: 0x006B1C8C File Offset: 0x006AFE8C
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchTablePosition4Feature_A21007
		{
			get
			{
				short num = (short)1782054912;
				short num2 = num;
				num = (short)977925199;
				short num3 = num;
				num = (short)1758786639;
				switch (num3 == num)
				{
				}
				num = (short)646512640;
				if (num != 0)
				{
				}
				num = (short)579862529;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007;
			}
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x060076C5 RID: 30405 RVA: 0x006B1D3C File Offset: 0x006AFF3C
		// (set) Token: 0x060076C6 RID: 30406 RVA: 0x006B1DF4 File Offset: 0x006AFFF4
		public bool SwitchTrunkingSwitchTablePosition4Feature_A21007_Applicable
		{
			get
			{
				short num = (short)1545142272;
				short num2 = num;
				num = (short)1327168034;
				short num3 = num;
				num = (short)386595362;
				switch (num3 == num)
				{
				}
				num = (short)1580138496;
				if (num != 0)
				{
				}
				num = (short)1463877633;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.Applicable;
			}
			set
			{
				short num = (short)1036582912;
				short num2 = num;
				num = (short)655886239;
				short num3 = num;
				num = (short)888997791;
				switch (num3 == num)
				{
				}
				num = (short)176029697;
				if (num != 0)
				{
				}
				num = (short)564527104;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition4Feature_A21007.Applicable = value;
			}
		}

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x060076C7 RID: 30407 RVA: 0x006B1EAC File Offset: 0x006B00AC
		// (set) Token: 0x060076C8 RID: 30408 RVA: 0x006B1F64 File Offset: 0x006B0164
		public bool SwitchTrunkingSwitchTablePosition4Feature_A21007_Valid
		{
			get
			{
				short num = (short)665452544;
				short num2 = num;
				num = (short)644150270;
				short num3 = num;
				num = (short)1448014846;
				switch (num3 == num)
				{
				}
				num = (short)1268449280;
				if (num != 0)
				{
				}
				num = (short)1337655297;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.Valid;
			}
			set
			{
				short num = (short)1768423424;
				short num2 = num;
				num = (short)1230607005;
				short num3 = num;
				num = (short)1781240477;
				switch (num3 == num)
				{
				}
				num = (short)928907265;
				if (num != 0)
				{
				}
				num = (short)1331167232;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition4Feature_A21007.Valid = value;
			}
		}

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x060076C9 RID: 30409 RVA: 0x006B2018 File Offset: 0x006B0218
		// (set) Token: 0x060076CA RID: 30410 RVA: 0x006B20CC File Offset: 0x006B02CC
		public bool SwitchTrunkingSwitchTablePosition4Feature_A21007_Visible
		{
			get
			{
				short num = (short)777453568;
				short num2 = num;
				num = (short)2004679730;
				short num3 = num;
				num = (short)1177943090;
				switch (num3 == num)
				{
				}
				num = (short)984940545;
				if (num != 0)
				{
				}
				num = (short)1471217664;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.Visible;
			}
			set
			{
				short num = (short)484900864;
				short num2 = num;
				num = (short)365735838;
				short num3 = num;
				num = (short)1132834718;
				switch (num3 == num)
				{
				}
				num = (short)1312948225;
				if (num != 0)
				{
				}
				num = (short)1269039104;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition4Feature_A21007.Visible = value;
			}
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x060076CB RID: 30411 RVA: 0x006B2180 File Offset: 0x006B0380
		// (set) Token: 0x060076CC RID: 30412 RVA: 0x006B2234 File Offset: 0x006B0434
		public bool SwitchTrunkingSwitchTablePosition4Feature_A21007_Editable
		{
			get
			{
				short num = (short)621740032;
				short num2 = num;
				num = (short)1081671318;
				short num3 = num;
				num = (short)1292304022;
				switch (num3 == num)
				{
				}
				num = (short)1740177409;
				if (num != 0)
				{
				}
				num = (short)93585408;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.Editable;
			}
			set
			{
				short num = (short)1205403648;
				short num2 = num;
				num = (short)1143341057;
				if (num != 0)
				{
				}
				num = (short)1505160687;
				short num3 = num;
				num = (short)1813179887;
				switch (num3 == num)
				{
				}
				num = (short)1447362560;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition4Feature_A21007.Editable = value;
			}
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x060076CD RID: 30413 RVA: 0x006B22EC File Offset: 0x006B04EC
		internal string SwitchTrunkingSwitchTablePosition4Feature_A21007_UILabel
		{
			get
			{
				short num = (short)830865408;
				short num2 = num;
				num = (short)596946322;
				short num3 = num;
				num = (short)1307094418;
				switch (num3 == num)
				{
				}
				num = (short)580583425;
				if (num != 0)
				{
				}
				num = (short)821952512;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.UIName;
			}
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x060076CE RID: 30414 RVA: 0x006B23A0 File Offset: 0x006B05A0
		// (set) Token: 0x060076CF RID: 30415 RVA: 0x006B2458 File Offset: 0x006B0658
		internal bool SwitchTrunkingSwitchTablePosition4Feature_A21007_HiddenStatic
		{
			get
			{
				short num = (short)1130692608;
				short num2 = num;
				num = (short)1959098764;
				short num3 = num;
				num = (short)1099790732;
				switch (num3 == num)
				{
				}
				num = (short)574029825;
				if (num != 0)
				{
				}
				num = (short)17629184;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.HiddenStatic;
			}
			set
			{
				short num = (short)85721088;
				short num2 = num;
				num = (short)388467227;
				short num3 = num;
				num = (short)310413851;
				switch (num3 == num)
				{
				}
				num = (short)51314688;
				if (num != 0)
				{
				}
				num = (short)656539649;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition4Feature_A21007.HiddenStatic = value;
			}
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x060076D0 RID: 30416 RVA: 0x006B250C File Offset: 0x006B070C
		// (set) Token: 0x060076D1 RID: 30417 RVA: 0x006B25BC File Offset: 0x006B07BC
		internal bool SwitchTrunkingSwitchTablePosition4Feature_A21007_HiddenDynamic
		{
			get
			{
				short num = (short)923860992;
				short num2 = num;
				num = (short)1385763753;
				short num3 = num;
				num = (short)800461737;
				switch (num3 == num)
				{
				}
				num = (short)2123497472;
				if (num != 0)
				{
				}
				num = (short)535035905;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007.HiddenDynamic;
			}
			set
			{
				short num = (short)1828257792;
				short num2 = num;
				num = (short)669445272;
				short num3 = num;
				num = (short)421915800;
				switch (num3 == num)
				{
				}
				num = (short)1434648577;
				if (num != 0)
				{
				}
				num = (short)1292369920;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition4Feature_A21007.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x060076D2 RID: 30418 RVA: 0x006B2674 File Offset: 0x006B0874
		public bool SwitchTrunkingSwitchTablePosition4Feature_A21007_HasDiffs
		{
			get
			{
				short num = (short)1003159552;
				short num2 = num;
				num = (short)1685905259;
				short num3 = num;
				num = (short)272686955;
				switch (num3 == num)
				{
				}
				num = (short)392036353;
				if (num != 0)
				{
				}
				num = (short)2117599232;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition4Feature_A21007._HasDiffs;
			}
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x060076D3 RID: 30419 RVA: 0x006B272C File Offset: 0x006B092C
		// (set) Token: 0x060076D4 RID: 30420 RVA: 0x006B27E0 File Offset: 0x006B09E0
		public int SwitchTrunkingSwitchTablePosition5Feature_A21008Value
		{
			get
			{
				short num = (short)1885143040;
				short num2 = num;
				num = (short)1593342486;
				short num3 = num;
				num = (short)263879190;
				switch (num3 == num)
				{
				}
				num = (short)762183680;
				if (num != 0)
				{
				}
				num = (short)812318721;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.Value;
			}
			set
			{
				short num = (short)2010251264;
				short num2 = num;
				num = (short)902707166;
				short num3 = num;
				num = (short)1489254366;
				switch (num3 == num)
				{
				}
				num = (short)1417412609;
				if (num != 0)
				{
				}
				num = (short)753860608;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition5Feature_A21008.Value = value;
			}
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x060076D5 RID: 30421 RVA: 0x006B289C File Offset: 0x006B0A9C
		// (set) Token: 0x060076D6 RID: 30422 RVA: 0x006B2950 File Offset: 0x006B0B50
		public string SwitchTrunkingSwitchTablePosition5Feature_A21008_UIValue
		{
			get
			{
				short num = (short)1897463808;
				short num2 = num;
				num = (short)811879427;
				short num3 = num;
				num = (short)347753475;
				switch (num3 == num)
				{
				}
				num = (short)191037441;
				if (num != 0)
				{
				}
				num = (short)997326848;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.UIValue;
			}
			set
			{
				short num = (short)390135808;
				short num2 = num;
				num = (short)1978678366;
				short num3 = num;
				num = (short)63978590;
				switch (num3 == num)
				{
				}
				num = (short)865140737;
				if (num != 0)
				{
				}
				num = (short)1222049792;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition5Feature_A21008.UIValue = value;
			}
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x060076D7 RID: 30423 RVA: 0x006B2A08 File Offset: 0x006B0C08
		public global::AcpBusinessLayer.AcpListField SwitchTrunkingSwitchTablePosition5Feature_A21008
		{
			get
			{
				short num = (short)821493760;
				short num2 = num;
				num = (short)1008213126;
				short num3 = num;
				num = (short)941235334;
				switch (num3 == num)
				{
				}
				num = (short)464912385;
				if (num != 0)
				{
				}
				num = (short)1046544384;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008;
			}
		}

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x060076D8 RID: 30424 RVA: 0x006B2AB8 File Offset: 0x006B0CB8
		// (set) Token: 0x060076D9 RID: 30425 RVA: 0x006B2B70 File Offset: 0x006B0D70
		public bool SwitchTrunkingSwitchTablePosition5Feature_A21008_Applicable
		{
			get
			{
				short num = (short)2053636096;
				short num2 = num;
				num = (short)2048610474;
				short num3 = num;
				num = (short)427839658;
				switch (num3 == num)
				{
				}
				num = (short)1846214657;
				if (num != 0)
				{
				}
				num = (short)314703872;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.Applicable;
			}
			set
			{
				short num = (short)1627914240;
				short num2 = num;
				num = (short)1380224179;
				short num3 = num;
				num = (short)36342963;
				switch (num3 == num)
				{
				}
				num = (short)41549825;
				if (num != 0)
				{
				}
				num = (short)1282736128;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition5Feature_A21008.Applicable = value;
			}
		}

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x060076DA RID: 30426 RVA: 0x006B2C24 File Offset: 0x006B0E24
		// (set) Token: 0x060076DB RID: 30427 RVA: 0x006B2CDC File Offset: 0x006B0EDC
		public bool SwitchTrunkingSwitchTablePosition5Feature_A21008_Valid
		{
			get
			{
				short num = (short)1017184256;
				short num2 = num;
				num = (short)191493711;
				short num3 = num;
				num = (short)1729230415;
				switch (num3 == num)
				{
				}
				num = (short)452853760;
				if (num != 0)
				{
				}
				num = (short)1964310529;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.Valid;
			}
			set
			{
				short num = (short)202375168;
				short num2 = num;
				num = (short)1112110397;
				short num3 = num;
				num = (short)374502717;
				switch (num3 == num)
				{
				}
				num = (short)744751105;
				if (num != 0)
				{
				}
				num = (short)1651113984;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition5Feature_A21008.Valid = value;
			}
		}

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x060076DC RID: 30428 RVA: 0x006B2D90 File Offset: 0x006B0F90
		// (set) Token: 0x060076DD RID: 30429 RVA: 0x006B2E44 File Offset: 0x006B1044
		public bool SwitchTrunkingSwitchTablePosition5Feature_A21008_Visible
		{
			get
			{
				short num = (short)1421017088;
				short num2 = num;
				num = (short)488003582;
				short num3 = num;
				num = (short)720787454;
				switch (num3 == num)
				{
				}
				num = (short)443154432;
				if (num != 0)
				{
				}
				num = (short)1553268737;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.Visible;
			}
			set
			{
				short num = (short)1768882176;
				short num2 = num;
				num = (short)716951981;
				short num3 = num;
				num = (short)2070925741;
				switch (num3 == num)
				{
				}
				num = (short)1623982081;
				if (num != 0)
				{
				}
				num = (short)815267840;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition5Feature_A21008.Visible = value;
			}
		}

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x060076DE RID: 30430 RVA: 0x006B2EFC File Offset: 0x006B10FC
		// (set) Token: 0x060076DF RID: 30431 RVA: 0x006B2FB0 File Offset: 0x006B11B0
		public bool SwitchTrunkingSwitchTablePosition5Feature_A21008_Editable
		{
			get
			{
				short num = (short)272564224;
				short num2 = num;
				num = (short)977083416;
				short num3 = num;
				num = (short)1239096344;
				switch (num3 == num)
				{
				}
				num = (short)1162477569;
				if (num != 0)
				{
				}
				num = (short)1082720256;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.Editable;
			}
			set
			{
				short num = (short)50855936;
				short num2 = num;
				num = (short)1792453009;
				short num3 = num;
				num = (short)850110865;
				switch (num3 == num)
				{
				}
				num = (short)1734606849;
				if (num != 0)
				{
				}
				num = (short)867762176;
				if (num != 0)
				{
				}
				this.switchTrunkingSwitchTablePosition5Feature_A21008.Editable = value;
			}
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x060076E0 RID: 30432 RVA: 0x006B3068 File Offset: 0x006B1268
		internal string SwitchTrunkingSwitchTablePosition5Feature_A21008_UILabel
		{
			get
			{
				short num = (short)312606720;
				short num2 = num;
				num = (short)877338612;
				short num3 = num;
				num = (short)857546740;
				switch (num3 == num)
				{
				}
				num = (short)993918976;
				if (num != 0)
				{
				}
				num = (short)1460797441;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.UIName;
			}
		}

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x060076E1 RID: 30433 RVA: 0x006B3120 File Offset: 0x006B1320
		// (set) Token: 0x060076E2 RID: 30434 RVA: 0x006B31D4 File Offset: 0x006B13D4
		internal bool SwitchTrunkingSwitchTablePosition5Feature_A21008_HiddenStatic
		{
			get
			{
				short num = (short)898564096;
				short num2 = num;
				num = (short)1266273868;
				short num3 = num;
				num = (short)771673676;
				switch (num3 == num)
				{
				}
				num = (short)1237516289;
				if (num != 0)
				{
				}
				num = (short)445186048;
				if (num != 0)
				{
				}
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.HiddenStatic;
			}
			set
			{
				short num = (short)236126209;
				if (num != 0)
				{
				}
				num = (short)143638497;
				short num2 = num;
				num = (short)486391777;
				switch (num2 == num)
				{
				}
				num = (short)747962368;
				if (num != 0)
				{
				}
				num = (short)508821504;
				short num3 = num;
				this.switchTrunkingSwitchTablePosition5Feature_A21008.HiddenStatic = value;
			}
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x060076E3 RID: 30435 RVA: 0x006B328C File Offset: 0x006B148C
		// (set) Token: 0x060076E4 RID: 30436 RVA: 0x006B333C File Offset: 0x006B153C
		internal bool SwitchTrunkingSwitchTablePosition5Feature_A21008_HiddenDynamic
		{
			get
			{
				short num = (short)1575984875;
				short num2 = num;
				num = (short)248291051;
				switch (num2 == num)
				{
				}
				num = (short)329777153;
				if (num != 0)
				{
				}
				num = (short)1693319168;
				if (num != 0)
				{
				}
				num = (short)1697185792;
				short num3 = num;
				return this.switchTrunkingSwitchTablePosition5Feature_A21008.HiddenDynamic;
			}
			set
			{
				short num = (short)220505618;
				short num2 = num;
				num = (short)722314770;
				switch (num2 == num)
				{
				}
				num = (short)425066497;
				if (num != 0)
				{
				}
				num = (short)362545152;
				if (num != 0)
				{
				}
				num = (short)1467809792;
				short num3 = num;
				this.switchTrunkingSwitchTablePosition5Feature_A21008.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x060076E5 RID: 30437 RVA: 0x006B33F0 File Offset: 0x006B15F0
		public bool SwitchTrunkingSwitchTablePosition5Feature_A21008_HasDiffs
		{
			get
			{
				short num = (short)830535771;
				short num2 = num;
				num = (short)687208539;
				switch (num2 == num)
				{
				}
				num = (short)1159462913;
				if (num != 0)
				{
				}
				num = (short)2045444096;
				if (num != 0)
				{
				}
				num = (short)1783300096;
				short num3 = num;
				return this.switchTrunkingSwitchTablePosition5Feature_A21008._HasDiffs;
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x060076E6 RID: 30438 RVA: 0x006B34A4 File Offset: 0x006B16A4
		// (set) Token: 0x060076E7 RID: 30439 RVA: 0x006B355C File Offset: 0x006B175C
		public string SwitchTrunkingSwitchKey_A21294Value
		{
			get
			{
				short num = (short)87582509;
				short num2 = num;
				num = (short)1203136301;
				switch (num2 == num)
				{
				}
				num = (short)1467613185;
				if (num != 0)
				{
				}
				num = (short)232521728;
				if (num != 0)
				{
				}
				num = (short)896925696;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.Value;
			}
			set
			{
				short num = (short)341114882;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_1E:
					switch (num2)
					{
					case 0:
						goto IL_EA;
					case 1:
						num = (short)1459290113;
						if (num != 0)
						{
						}
						this.switchTrunkingSwitchKey_A21294.Value = value;
						num = (short)1470365696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					while (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)1843589745;
						short num3 = num;
						num = (short)100659825;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1844314112;
							if (num != 0)
							{
							}
							num = (short)2073427969;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					break;
				}
				IL_EA:
				num = (short)1556938752;
				short num4 = num;
			}
		}

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x060076E8 RID: 30440 RVA: 0x006B3680 File Offset: 0x006B1880
		// (set) Token: 0x060076E9 RID: 30441 RVA: 0x006B3734 File Offset: 0x006B1934
		public string SwitchTrunkingSwitchKey_A21294_UIValue
		{
			get
			{
				short num = (short)945567356;
				short num2 = num;
				num = (short)65812092;
				switch (num2 == num)
				{
				}
				num = (short)1308819457;
				if (num != 0)
				{
				}
				num = (short)1633681408;
				if (num != 0)
				{
				}
				num = (short)1864237056;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.Value;
			}
			set
			{
				short num = (short)2007472062;
				short num2 = num;
				num = (short)2119538622;
				switch (num2 == num)
				{
				}
				num = (short)1448083456;
				if (num != 0)
				{
				}
				num = (short)90767361;
				if (num != 0)
				{
				}
				num = (short)1393885184;
				short num3 = num;
				this.switchTrunkingSwitchKey_A21294.Value = value;
			}
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x060076EA RID: 30442 RVA: 0x006B37E8 File Offset: 0x006B19E8
		public global::AcpBusinessLayer.AcpKeyField SwitchTrunkingSwitchKey_A21294
		{
			get
			{
				short num = (short)2112177416;
				short num2 = num;
				num = (short)1101612296;
				switch (num2 == num)
				{
				}
				num = (short)9961473;
				if (num != 0)
				{
				}
				num = (short)2086141952;
				if (num != 0)
				{
				}
				num = (short)962002944;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294;
			}
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x060076EB RID: 30443 RVA: 0x006B3898 File Offset: 0x006B1A98
		// (set) Token: 0x060076EC RID: 30444 RVA: 0x006B394C File Offset: 0x006B1B4C
		public bool SwitchTrunkingSwitchKey_A21294_Applicable
		{
			get
			{
				short num = (short)1007222785;
				if (num != 0)
				{
				}
				num = (short)218872626;
				short num2 = num;
				num = (short)958970674;
				switch (num2 == num)
				{
				}
				num = (short)1352794112;
				if (num != 0)
				{
				}
				num = (short)1206452224;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.Applicable;
			}
			set
			{
				short num = (short)954089624;
				short num2 = num;
				num = (short)920469656;
				switch (num2 == num)
				{
				}
				num = (short)246218752;
				if (num != 0)
				{
				}
				num = (short)300810241;
				if (num != 0)
				{
				}
				num = (short)34930688;
				short num3 = num;
				this.switchTrunkingSwitchKey_A21294.Applicable = value;
			}
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x006B3A00 File Offset: 0x006B1C00
		// (set) Token: 0x060076EE RID: 30446 RVA: 0x006B3AB4 File Offset: 0x006B1CB4
		public bool SwitchTrunkingSwitchKey_A21294_Valid
		{
			get
			{
				short num = (short)816269965;
				short num2 = num;
				num = (short)2034584205;
				switch (num2 == num)
				{
				}
				num = (short)1289617409;
				if (num != 0)
				{
				}
				num = (short)2135228416;
				if (num != 0)
				{
				}
				num = (short)1156907008;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.Valid;
			}
			set
			{
				short num = (short)1309540353;
				if (num != 0)
				{
				}
				num = (short)555041567;
				short num2 = num;
				num = (short)1139295007;
				switch (num2 == num)
				{
				}
				num = (short)1182990336;
				if (num != 0)
				{
				}
				num = (short)1909653504;
				short num3 = num;
				this.switchTrunkingSwitchKey_A21294.Valid = value;
			}
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x060076EF RID: 30447 RVA: 0x006B3B68 File Offset: 0x006B1D68
		// (set) Token: 0x060076F0 RID: 30448 RVA: 0x006B3C1C File Offset: 0x006B1E1C
		public bool SwitchTrunkingSwitchKey_A21294_Visible
		{
			get
			{
				short num = (short)314670137;
				short num2 = num;
				num = (short)143162425;
				switch (num2 == num)
				{
				}
				num = (short)768606209;
				if (num != 0)
				{
				}
				num = (short)1407582208;
				if (num != 0)
				{
				}
				num = (short)826408960;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.Visible;
			}
			set
			{
				short num = (short)1608358106;
				short num2 = num;
				num = (short)1964873946;
				switch (num2 == num)
				{
				}
				num = (short)1983971329;
				if (num != 0)
				{
				}
				num = (short)926744576;
				if (num != 0)
				{
				}
				num = (short)495845376;
				short num3 = num;
				this.switchTrunkingSwitchKey_A21294.Visible = value;
			}
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x006B3CD0 File Offset: 0x006B1ED0
		// (set) Token: 0x060076F2 RID: 30450 RVA: 0x006B3D88 File Offset: 0x006B1F88
		public bool SwitchTrunkingSwitchKey_A21294_Editable
		{
			get
			{
				short num = (short)1042628989;
				short num2 = num;
				num = (short)284377469;
				switch (num2 == num)
				{
				}
				num = (short)2138505217;
				if (num != 0)
				{
				}
				num = (short)2074804224;
				if (num != 0)
				{
				}
				num = (short)197722112;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.Editable;
			}
			set
			{
				short num = (short)476528292;
				short num2 = num;
				num = (short)1351171748;
				switch (num2 == num)
				{
				}
				num = (short)1797390337;
				if (num != 0)
				{
				}
				num = (short)824508416;
				if (num != 0)
				{
				}
				num = (short)659685376;
				short num3 = num;
				this.switchTrunkingSwitchKey_A21294.Editable = value;
			}
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x060076F3 RID: 30451 RVA: 0x006B3E3C File Offset: 0x006B203C
		internal string SwitchTrunkingSwitchKey_A21294_UILabel
		{
			get
			{
				short num = (short)2072761992;
				short num2 = num;
				num = (short)1005049480;
				switch (num2 == num)
				{
				}
				num = (short)761135105;
				if (num != 0)
				{
				}
				num = (short)427032576;
				if (num != 0)
				{
				}
				num = (short)1266221056;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.UIName;
			}
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x060076F4 RID: 30452 RVA: 0x006B3EF0 File Offset: 0x006B20F0
		// (set) Token: 0x060076F5 RID: 30453 RVA: 0x006B3FA4 File Offset: 0x006B21A4
		internal bool SwitchTrunkingSwitchKey_A21294_HiddenStatic
		{
			get
			{
				short num = (short)2083025929;
				short num2 = num;
				num = (short)1984918537;
				switch (num2 == num)
				{
				}
				num = (short)1502478336;
				if (num != 0)
				{
				}
				num = (short)1214709761;
				if (num != 0)
				{
				}
				num = (short)2061303808;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.HiddenStatic;
			}
			set
			{
				short num = (short)502331915;
				short num2 = num;
				num = (short)609483275;
				switch (num2 == num)
				{
				}
				num = (short)1246625793;
				if (num != 0)
				{
				}
				num = (short)1355153408;
				if (num != 0)
				{
				}
				num = (short)1365835776;
				short num3 = num;
				this.switchTrunkingSwitchKey_A21294.HiddenStatic = value;
			}
		}

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x060076F6 RID: 30454 RVA: 0x006B405C File Offset: 0x006B225C
		// (set) Token: 0x060076F7 RID: 30455 RVA: 0x006B4110 File Offset: 0x006B2310
		internal bool SwitchTrunkingSwitchKey_A21294_HiddenDynamic
		{
			get
			{
				short num = (short)32678270;
				short num2 = num;
				num = (short)332439934;
				switch (num2 == num)
				{
				}
				num = (short)565772288;
				if (num != 0)
				{
				}
				num = (short)171376641;
				if (num != 0)
				{
				}
				num = (short)2047410176;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294.HiddenDynamic;
			}
			set
			{
				short num = (short)1424509740;
				short num2 = num;
				num = (short)636570412;
				switch (num2 == num)
				{
				}
				num = (short)1980563457;
				if (num != 0)
				{
				}
				num = (short)1983971328;
				if (num != 0)
				{
				}
				num = (short)1096744960;
				short num3 = num;
				this.switchTrunkingSwitchKey_A21294.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x060076F8 RID: 30456 RVA: 0x006B41C8 File Offset: 0x006B23C8
		public bool SwitchTrunkingSwitchKey_A21294_HasDiffs
		{
			get
			{
				short num = (short)1005511471;
				short num2 = num;
				num = (short)2074534703;
				switch (num2 == num)
				{
				}
				num = (short)143130625;
				if (num != 0)
				{
				}
				num = (short)2081619968;
				if (num != 0)
				{
				}
				num = (short)1397227520;
				short num3 = num;
				return this.switchTrunkingSwitchKey_A21294._HasDiffs;
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x060076F9 RID: 30457 RVA: 0x006B4280 File Offset: 0x006B2480
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1886722456;
				short num2 = num;
				num = (short)254876056;
				switch (num2 == num)
				{
				}
				num = (short)1746796545;
				if (num != 0)
				{
				}
				num = (short)1373896704;
				if (num != 0)
				{
				}
				num = (short)15925248;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x006B433C File Offset: 0x006B253C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_162;
				case 1:
					goto IL_124;
				case 2:
					num2 = (short)338427907;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)860094464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)661520384;
						short num3 = num2;
						num2 = (short)306249730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_124:
			return result;
			IL_162:
			goto IL_D3;
			IL_24:
			num2 = (short)235304646;
			short num4 = num2;
			num2 = (short)1921087174;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D3:
				num2 = (short)101908481;
				if (num2 != 0)
				{
				}
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1144389633;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)995164160;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)367919108;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0400308B RID: 12427
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePositionsQuantity_A21003;

		// Token: 0x0400308C RID: 12428
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePosition1Feature_A21004;

		// Token: 0x0400308D RID: 12429
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePosition2Feature_A21005;

		// Token: 0x0400308E RID: 12430
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePosition3Feature_A21006;

		// Token: 0x0400308F RID: 12431
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePosition4Feature_A21007;

		// Token: 0x04003090 RID: 12432
		private global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePosition5Feature_A21008;

		// Token: 0x04003091 RID: 12433
		private global::AcpBusinessLayer.AcpKeyField switchTrunkingSwitchKey_A21294;
	}
}
