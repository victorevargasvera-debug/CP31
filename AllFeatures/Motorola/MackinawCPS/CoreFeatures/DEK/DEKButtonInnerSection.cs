using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200032F RID: 815
	[global::System.Serializable]
	public class DEKButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007D6A RID: 32106 RVA: 0x0073C090 File Offset: 0x0073A290
		public DEKButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007D6B RID: 32107 RVA: 0x0073C0AC File Offset: 0x0073A2AC
		protected DEKButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x0073C0C4 File Offset: 0x0073A2C4
		public override void Init()
		{
			int a_ = 5;
			short num = (short)703397888;
			short num2 = num;
			num = (short)1887464470;
			short num3 = num;
			num = (short)1075145750;
			switch (num3 == num)
			{
			}
			num = (short)1546125313;
			if (num != 0)
			{
			}
			num = (short)289996800;
			if (num != 0)
			{
			}
			this.dEKButtonBCO_A21352 = new global::AcpBusinessLayer.AcpSparseLOVField(192, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKButtonBCO_A21352LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKButtonBCO_A21352LovStrs), this, global::AllFeatures.CodeplugGuid.b("苅跇臉軋믍꓏ꛑ믓룕髗駙鏛臝ꇟ탡헣헥\udde7\ud8e9", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKButtonBCO_A21352LovStrs);
			this.dEKButtonBCO_A21352.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKButtonBCO_A21352.DataTransferOrder = 11;
			this.dEKButtonFeature_A21353 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKButtonFeature_A21353LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKButtonFeature_A21353LovStrs), this, global::AllFeatures.CodeplugGuid.b("苅跇臉軋믍꓏ꛑ믓룕黗뿙뷛ꫝ闟郡臣맥ꧧ\ud8e9\uddeb\udded엯쇱", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKButtonFeature_A21353LovStrs);
			this.dEKButtonFeature_A21353.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKButtonFeature_A21353.DataTransferOrder = 4;
			this.dEKChannel_A22565 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苅跇臉迋ꛍ뇏병뫓돕듗藙鷛틟ퟡ틣폥", a_), global::CommonResources.AcgResources.ID_CHANNEL, null, null, false, false);
			this.dEKChannel_A22565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKChannel_A22565.DataTransferOrder = 16;
			this.dEKZone_A22566 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苅跇臉雋ꇍ뻏럑诓韕훟", a_), global::CommonResources.AcgResources.ID_ZONE, null, null, false, false);
			this.dEKZone_A22566.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKZone_A22566.DataTransferOrder = 15;
			this.dEKButtonName_A22568 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DEKABUTTON1, this, global::AllFeatures.CodeplugGuid.b("苅跇臉軋믍꓏ꛑ믓룕雗믙뇛믝뿟ꏡ훣퓥\udde7\udce9퓫", a_), global::CommonResources.AcgResources.ID_NAME, 20);
			this.dEKButtonName_A22568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKButtonName_A22568.DataTransferOrder = -1;
			this.dEKButtonKey_A22569 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("苅跇臉軋믍꓏ꛑ믓룕鏗뿙ꗛ臝ꇟ탡훣폥\udee7폩", a_), global::CommonResources.AcgResources.ID_KEY);
			this.dEKButtonKey_A22569.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKButtonIndex_A22570 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::AllFeatures.CodeplugGuid.b("苅跇臉軋믍꓏ꛑ믓룕釗듙룛믝食뷡ꗣ퓥\udae7\udfe9\udbeb\udeed", a_), global::CommonResources.AcgResources.ID_INDEX, 1, 16, 1);
			this.dEKButtonIndex_A22570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.dEKButtonIndex_A22570.DataTransferOrder = 17;
			this.dEKButtonIndex_A22570.ValidateAcrossRecset = true;
			this.dEKButtonIndex_A22570.ShowHexValue = false;
			this.dEKButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("苅跇臉軋믍꓏ꛑ믓룕诗닙돛곝铟닡難菥鯧駩룫蟭鷯韱", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.dEKButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKButtonShortPressTime.DataTransferOrder = -1;
			this.dEKButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.dEKButtonShortPressTime.ShowHexValue = false;
			this.dEKButtonShortPressTime.ValidateAcrossRecset = true;
			this.dEKButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("苅跇臉軋믍꓏ꛑ믓룕铗뗙닛망냟郡臣闥鯧뻩藫菭闯", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.dEKButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKButtonLongPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.dEKButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.dEKButtonLongPressTime.ShowHexValue = false;
			this.dEKButtonLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苅跇臉賍ꗏꛑꃓ맕뛗", a_);
			base.Id = 10204;
			base.UIName = global::CommonResources.AcgResources.ID_DEKBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x0073C46C File Offset: 0x0073A66C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1954152457;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					for (;;)
					{
						num = (short)662748359;
						short num3 = num;
						num = (short)25279687;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_54F;
						}
					}
					IL_54F:
					num = (short)698089472;
					if (num != 0)
					{
					}
					this.dEKChannel_A22565 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("臄苆苈裊ꗌ껎뿐뷒냔믖蛘髚퓠헢탤", a_), global::CommonResources.AcgResources.ID_CHANNEL, null, null, false, false);
					this.dEKChannel_A22565.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKChannel_A22565.DataTransferOrder = 16;
					num = (short)1962213402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.dEKButtonBCO_A21352 = new global::AcpBusinessLayer.AcpSparseLOVField(192, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKButtonBCO_A21352LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKButtonBCO_A21352LovStrs), this, global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔闖高铚苜點폠틢훤틦\udbe8", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKButtonBCO_A21352LovStrs);
					this.dEKButtonBCO_A21352.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKButtonBCO_A21352.DataTransferOrder = 11;
					num = (short)2089484315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.dEKButtonFeature_A21353 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKButtonFeature_A21353LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKButtonFeature_A21353LovStrs), this, global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔釖볘뫚꧜꫞鏠蛢뫤ꛦ\udbe8\udaea\udeec\udaee싰", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKButtonFeature_A21353LovStrs);
					this.dEKButtonFeature_A21353.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKButtonFeature_A21353.DataTransferOrder = 4;
					num = (short)1178664974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_515;
				case 4:
					this.dEKButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔鯖뛘뗚뫜连鏠蛢雤铦뷨苪胬諮", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.dEKButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKButtonLongPressTime.DataTransferOrder = -1;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.dEKButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.dEKButtonLongPressTime.ShowHexValue = false;
					this.dEKButtonLongPressTime.ValidateAcrossRecset = true;
					num = (short)546111491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.dEKZone_A22566 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("臄苆苈释ꋌꇎ듐賒铔", a_), global::CommonResources.AcgResources.ID_ZONE, null, null, false, false);
					this.dEKZone_A22566.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKZone_A22566.DataTransferOrder = 15;
					num = (short)1547829272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔蓖뇘듚꿜ꯞ뇠釢胤铦髨뿪蓬苮铰", a_)))
					{
						num = (short)1518862354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C9;
				case 7:
					goto IL_2C9;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔鳖볘ꋚ苜點폠퇢탤퇦탨", a_)))
					{
						num = (short)479854604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔黖럘뿚룜꟞뻠ꋢퟤ헦\udce8\udcea\uddec", a_)))
					{
						num = (short)724893709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5;
				case 11:
					goto IL_D0;
				case 12:
					this.dEKButtonKey_A22569 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔鳖볘ꋚ苜點폠퇢탤퇦탨", a_), global::CommonResources.AcgResources.ID_KEY);
					this.dEKButtonKey_A22569.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)886439947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)2096889857;
					if (num != 0)
					{
					}
					this.dEKButtonIndex_A22570 = new global::AcpBusinessLayer.AcpRangeField<int, int>(1, null, this, global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔黖럘뿚룜꟞뻠ꋢퟤ헦\udce8\udcea\uddec", a_), global::CommonResources.AcgResources.ID_INDEX);
					this.dEKButtonIndex_A22570.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKButtonIndex_A22570.DataTransferOrder = 17;
					this.dEKButtonIndex_A22570.ValidateAcrossRecset = true;
					this.dEKButtonIndex_A22570.ShowHexValue = false;
					num = (short)2143485982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_5F7;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔闖高铚苜點폠틢훤틦\udbe8", a_)))
					{
						num = (short)2013921281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_176;
				case 16:
					this.dEKButtonName_A22568 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DEKABUTTON1, this, global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔駖룘뛚룜胞ꃠ퇢ퟤ틦\udfe8폪", a_), global::CommonResources.AcgResources.ID_NAME, 20);
					this.dEKButtonName_A22568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.dEKButtonName_A22568.DataTransferOrder = -1;
					num = (short)399638550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields != null)
					{
						num = (short)707919892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_819;
				case 18:
				{
					num = (short)104464384;
					short num4 = num;
					this.dEKButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔蓖뇘듚꿜ꯞ뇠釢胤铦髨뿪蓬苮铰", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.dEKButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKButtonShortPressTime.DataTransferOrder = -1;
					this.dEKButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.dEKButtonShortPressTime.ShowHexValue = false;
					this.dEKButtonShortPressTime.ValidateAcrossRecset = true;
					num = (short)1944059911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔鯖뛘뗚뫜连鏠蛢雤铦뷨苪胬諮", a_)))
					{
						num = (short)1969422340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_819;
				case 20:
					num = (short)239075343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈释ꋌꇎ듐賒铔", a_)))
					{
						num = (short)2049310725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_316;
				case 22:
					goto IL_773;
				case 23:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔駖룘뛚룜胞ꃠ퇢ퟤ틦\udfe8폪", a_)))
					{
						num = (short)1999241232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_773;
				case 24:
					goto IL_316;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈裊ꗌ껎뿐뷒냔믖蛘髚퓠헢탤", a_)))
					{
						num = (short)2067857408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_691;
				case 26:
					goto IL_691;
				case 27:
					goto IL_176;
				case 28:
					num = (short)548339729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄苆苈觊료믎ꗐ볒믔釖볘뫚꧜꫞鏠蛢뫤ꛦ\udbe8\udaea\udeec\udaee싰", a_)))
					{
						num = (short)626786306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F7;
				case 30:
					goto IL_1C5;
				}
				IL_A9:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)795410460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D0:
				num = (short)1931477002;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_176:
				num = (short)562692125;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C5:
				num = (short)1095434246;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C9:
				num = (short)940572691;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_316:
				num = (short)814350359;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F7:
				num = (short)890961945;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_691:
				num = (short)1332674581;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_773:
				num = (short)1526071304;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_515:
			IL_819:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臄苆苈迌뫎ꗐ꟒뫔맖", a_);
			base.Id = 10204;
			base.UIName = global::CommonResources.AcgResources.ID_DEKBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007D6E RID: 32110 RVA: 0x0073CCC4 File Offset: 0x0073AEC4
		public override void PopulateReferences()
		{
			short num = (short)1920758718;
			short num2 = num;
			num = (short)737178558;
			switch (num2 == num)
			{
			default:
			{
				num = (short)247791616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1984036865;
			if (num != 0)
			{
			}
			num = (short)1824325632;
			if (num != 0)
			{
			}
			this.dEKZone_A22566.SetRecset(this.a(2051));
			this.dEKZone_A22566.AddSlaveField(this.dEKChannel_A22565, 10114);
		}

		// Token: 0x06007D6F RID: 32111 RVA: 0x0073CD98 File Offset: 0x0073AF98
		public override void DropReferences()
		{
			short num = (short)657890888;
			short num2 = num;
			num = (short)1394318920;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2087845888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)114753537;
			if (num != 0)
			{
			}
			num = (short)1837760512;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007D70 RID: 32112 RVA: 0x0073CE40 File Offset: 0x0073B040
		public override void SetConstraints()
		{
			short num = (short)185412615;
			short num2 = num;
			num = (short)1621371911;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1367605248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)571146240;
			if (num != 0)
			{
			}
			num = (short)814284801;
			if (num != 0)
			{
			}
			this.dEKButtonFeature_A21353.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesForDEKButton);
			this.dEKButtonFeature_A21353.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConDEKButtonFeaturesSelect);
			this.dEKButtonFeature_A21353.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesForDEKButtonEditbl);
			this.dEKButtonFeature_A21353.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConValueSetIfFeatIsStsXOrMsgXOrMode);
			this.dEKChannel_A22565.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesAndFeatIsModeAndNonDynamicZone);
			this.dEKChannel_A22565.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesAndFeatIsModeEditbl);
			this.dEKChannel_A22565.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConDEKButtonModeChannelSelect);
			this.dEKZone_A22566.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesAndFeatIsMode);
			this.dEKZone_A22566.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConDynamicZoneInDEKValid);
			this.dEKZone_A22566.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesAndFeatIsModeEditbl);
			this.dEKZone_A22566.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConDEKButtonModeZoneSelect);
			this.dEKButtonName_A22568.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.dEKButtonIndex_A22570.ValidateAcrossRecset = true;
			this.dEKButtonIndex_A22570.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesAndFeatIsStsXOrMsgX);
			this.dEKButtonIndex_A22570.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConDekFeatIndexPairUniqueConstraint);
			this.dEKButtonIndex_A22570.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConNumOfDekBoxesAndFeatIsStsXOrMsgXEditbl);
			this.dEKButtonIndex_A22570.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.ConValueSetIfFeatIdxIsChanged);
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x0073D068 File Offset: 0x0073B268
		public override void SetupDependencies()
		{
			short num = (short)1290178983;
			short num2 = num;
			num = (short)1039569319;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1394933760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1057882113;
			if (num != 0)
			{
			}
			num = (short)232259584;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK dek = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK;
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.AddDependentObject(this.dEKButtonFeature_A21353);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.dEKButtonFeature_A21353);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.dEKButtonFeature_A21353);
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKButtonFeature_A21353);
			this.dEKButtonName_A22568.AddDependentObject(this.dEKButtonFeature_A21353);
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKChannel_A22565);
			this.dEKButtonName_A22568.AddDependentObject(this.dEKChannel_A22565);
			this.dEKButtonFeature_A21353.AddDependentObject(this.dEKChannel_A22565);
			this.dEKZone_A22566.AddDependentObject(this.dEKChannel_A22565);
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKZone_A22566);
			this.dEKButtonName_A22568.AddDependentObject(this.dEKZone_A22566);
			this.dEKButtonFeature_A21353.AddDependentObject(this.dEKZone_A22566);
			this.dEKChannel_A22565.AddDependentObject(this.dEKZone_A22566);
			dek.General.DEKNumberofDEKBoxes_A8579.AddDependentObject(this.dEKButtonIndex_A22570);
			this.dEKButtonName_A22568.AddDependentObject(this.dEKButtonIndex_A22570);
			this.dEKButtonFeature_A21353.AddDependentObject(this.dEKButtonIndex_A22570);
		}

		// Token: 0x1700402C RID: 16428
		// (get) Token: 0x06007D72 RID: 32114 RVA: 0x0073D278 File Offset: 0x0073B478
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForDEKChannel_A22565
		{
			get
			{
				short num = (short)1145672148;
				short num2 = num;
				num = (short)2106692052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)527302656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2120155137;
				if (num != 0)
				{
				}
				num = (short)554827776;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x1700402D RID: 16429
		// (get) Token: 0x06007D73 RID: 32115 RVA: 0x0073D330 File Offset: 0x0073B530
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForDEKZone_A22566
		{
			get
			{
				short num = (short)877146812;
				short num2 = num;
				num = (short)578106044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1602224128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)249495553;
				if (num != 0)
				{
				}
				num = (short)657915904;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x1700402E RID: 16430
		// (get) Token: 0x06007D74 RID: 32116 RVA: 0x0073D3EC File Offset: 0x0073B5EC
		public bool HasDiffs
		{
			get
			{
				short num = (short)30642920;
				short num2 = num;
				num = (short)248746728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1207697408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2043346945;
				if (num != 0)
				{
				}
				num = (short)1334378496;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700402F RID: 16431
		// (get) Token: 0x06007D75 RID: 32117 RVA: 0x0073D49C File Offset: 0x0073B69C
		// (set) Token: 0x06007D76 RID: 32118 RVA: 0x0073D550 File Offset: 0x0073B750
		public int DEKButtonBCO_A21352Value
		{
			get
			{
				short num = (short)1850363743;
				short num2 = num;
				num = (short)152981343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)18874368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)146604032;
				if (num != 0)
				{
				}
				num = (short)144506881;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.Value;
			}
			set
			{
				short num = (short)1937248601;
				short num2 = num;
				num = (short)1795428697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)233832448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104071169;
				if (num != 0)
				{
				}
				num = (short)2119565312;
				if (num != 0)
				{
				}
				this.dEKButtonBCO_A21352.Value = value;
			}
		}

		// Token: 0x17004030 RID: 16432
		// (get) Token: 0x06007D77 RID: 32119 RVA: 0x0073D604 File Offset: 0x0073B804
		// (set) Token: 0x06007D78 RID: 32120 RVA: 0x0073D6B8 File Offset: 0x0073B8B8
		public string DEKButtonBCO_A21352_UIValue
		{
			get
			{
				short num = (short)11862017;
				if (num != 0)
				{
				}
				num = (short)209125376;
				short num2 = num;
				num = (short)1660497466;
				short num3 = num;
				num = (short)101854778;
				switch (num3 == num)
				{
				}
				num = (short)572588032;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.UIValue;
			}
			set
			{
				short num = (short)483595310;
				short num2 = num;
				num = (short)898372654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1476132864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1939210241;
				if (num != 0)
				{
				}
				num = (short)437321728;
				if (num != 0)
				{
				}
				this.dEKButtonBCO_A21352.UIValue = value;
			}
		}

		// Token: 0x17004031 RID: 16433
		// (get) Token: 0x06007D79 RID: 32121 RVA: 0x0073D770 File Offset: 0x0073B970
		public global::AcpBusinessLayer.AcpListField DEKButtonBCO_A21352
		{
			get
			{
				short num = (short)1211891713;
				if (num != 0)
				{
				}
				num = (short)1105199104;
				short num2 = num;
				num = (short)2038512621;
				short num3 = num;
				num = (short)12336109;
				switch (num3 == num)
				{
				}
				num = (short)634519552;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352;
			}
		}

		// Token: 0x17004032 RID: 16434
		// (get) Token: 0x06007D7A RID: 32122 RVA: 0x0073D820 File Offset: 0x0073BA20
		// (set) Token: 0x06007D7B RID: 32123 RVA: 0x0073D8D4 File Offset: 0x0073BAD4
		public bool DEKButtonBCO_A21352_Applicable
		{
			get
			{
				short num = (short)13660199;
				short num2 = num;
				num = (short)1060991015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)272891904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)136249345;
				if (num != 0)
				{
				}
				num = (short)1781792768;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.Applicable;
			}
			set
			{
				short num = (short)1230720514;
				short num2 = num;
				num = (short)168709634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)467009536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2067660801;
				if (num != 0)
				{
				}
				num = (short)210894848;
				if (num != 0)
				{
				}
				this.dEKButtonBCO_A21352.Applicable = value;
			}
		}

		// Token: 0x17004033 RID: 16435
		// (get) Token: 0x06007D7C RID: 32124 RVA: 0x0073D98C File Offset: 0x0073BB8C
		// (set) Token: 0x06007D7D RID: 32125 RVA: 0x0073DA40 File Offset: 0x0073BC40
		public bool DEKButtonBCO_A21352_Valid
		{
			get
			{
				short num = (short)1953319235;
				short num2 = num;
				num = (short)1479887171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)562626560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267845633;
				if (num != 0)
				{
				}
				num = (short)1686962176;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.Valid;
			}
			set
			{
				short num = (short)224985089;
				if (num != 0)
				{
				}
				num = (short)306970624;
				short num2 = num;
				num = (short)1424036190;
				short num3 = num;
				num = (short)784666974;
				switch (num3 == num)
				{
				}
				num = (short)1599733760;
				if (num != 0)
				{
				}
				this.dEKButtonBCO_A21352.Valid = value;
			}
		}

		// Token: 0x17004034 RID: 16436
		// (get) Token: 0x06007D7E RID: 32126 RVA: 0x0073DAF4 File Offset: 0x0073BCF4
		// (set) Token: 0x06007D7F RID: 32127 RVA: 0x0073DBA8 File Offset: 0x0073BDA8
		public bool DEKButtonBCO_A21352_Visible
		{
			get
			{
				short num = (short)1369478765;
				short num2 = num;
				num = (short)190682733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)346619904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1924202496;
				if (num != 0)
				{
				}
				num = (short)604569601;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.Visible;
			}
			set
			{
				short num = (short)558519320;
				short num2 = num;
				num = (short)592532504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)125435904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031667713;
				if (num != 0)
				{
				}
				num = (short)1051787264;
				if (num != 0)
				{
				}
				this.dEKButtonBCO_A21352.Visible = value;
			}
		}

		// Token: 0x17004035 RID: 16437
		// (get) Token: 0x06007D80 RID: 32128 RVA: 0x0073DC60 File Offset: 0x0073BE60
		// (set) Token: 0x06007D81 RID: 32129 RVA: 0x0073DD18 File Offset: 0x0073BF18
		public bool DEKButtonBCO_A21352_Editable
		{
			get
			{
				short num = (short)1387370402;
				short num2 = num;
				num = (short)317429666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)459210752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)411500545;
				if (num != 0)
				{
				}
				num = (short)1957953536;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.Editable;
			}
			set
			{
				short num = (short)1797136605;
				short num2 = num;
				num = (short)203301085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1234894848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)286785537;
				if (num != 0)
				{
				}
				num = (short)12648448;
				if (num != 0)
				{
				}
				this.dEKButtonBCO_A21352.Editable = value;
			}
		}

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x06007D82 RID: 32130 RVA: 0x0073DDCC File Offset: 0x0073BFCC
		internal string DEKButtonBCO_A21352_UILabel
		{
			get
			{
				short num = (short)823495002;
				short num2 = num;
				num = (short)1617398106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1393229824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1318256640;
				if (num != 0)
				{
				}
				num = (short)1298923521;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.UIName;
			}
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x06007D83 RID: 32131 RVA: 0x0073DE80 File Offset: 0x0073C080
		// (set) Token: 0x06007D84 RID: 32132 RVA: 0x0073DF38 File Offset: 0x0073C138
		internal bool DEKButtonBCO_A21352_HiddenStatic
		{
			get
			{
				short num = (short)523266702;
				short num2 = num;
				num = (short)2033019534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1009582080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618608128;
				if (num != 0)
				{
				}
				num = (short)1444937729;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.HiddenStatic;
			}
			set
			{
				short num = (short)936998645;
				short num2 = num;
				num = (short)1413445365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1255669760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)84017153;
				if (num != 0)
				{
				}
				num = (short)1483210752;
				if (num != 0)
				{
				}
				this.dEKButtonBCO_A21352.HiddenStatic = value;
			}
		}

		// Token: 0x17004038 RID: 16440
		// (get) Token: 0x06007D85 RID: 32133 RVA: 0x0073DFF4 File Offset: 0x0073C1F4
		// (set) Token: 0x06007D86 RID: 32134 RVA: 0x0073E0A8 File Offset: 0x0073C2A8
		internal bool DEKButtonBCO_A21352_HiddenDynamic
		{
			get
			{
				short num = (short)1725791562;
				short num2 = num;
				num = (short)1300135242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1192624128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)718798849;
				if (num != 0)
				{
				}
				num = (short)1330053120;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352.HiddenDynamic;
			}
			set
			{
				short num = (short)507342356;
				short num2 = num;
				num = (short)251948564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320602112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)450560001;
				if (num != 0)
				{
				}
				num = (short)1523777536;
				if (num != 0)
				{
				}
				this.dEKButtonBCO_A21352.HiddenDynamic = value;
			}
		}

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x06007D87 RID: 32135 RVA: 0x0073E15C File Offset: 0x0073C35C
		public bool DEKButtonBCO_A21352_HasDiffs
		{
			get
			{
				short num = (short)2008314508;
				short num2 = num;
				num = (short)2132308620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770244608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)844562433;
				if (num != 0)
				{
				}
				num = (short)69074944;
				if (num != 0)
				{
				}
				return this.dEKButtonBCO_A21352._HasDiffs;
			}
		}

		// Token: 0x1700403A RID: 16442
		// (get) Token: 0x06007D88 RID: 32136 RVA: 0x0073E214 File Offset: 0x0073C414
		// (set) Token: 0x06007D89 RID: 32137 RVA: 0x0073E2C8 File Offset: 0x0073C4C8
		public int DEKButtonFeature_A21353Value
		{
			get
			{
				short num = (short)1930518437;
				short num2 = num;
				num = (short)1618436005;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1440612352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1809252352;
				if (num != 0)
				{
				}
				num = (short)1764163585;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.Value;
			}
			set
			{
				short num = (short)2019991580;
				short num2 = num;
				num = (short)1782751260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)137887744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1257504769;
				if (num != 0)
				{
				}
				num = (short)1632370688;
				if (num != 0)
				{
				}
				this.dEKButtonFeature_A21353.Value = value;
			}
		}

		// Token: 0x1700403B RID: 16443
		// (get) Token: 0x06007D8A RID: 32138 RVA: 0x0073E380 File Offset: 0x0073C580
		// (set) Token: 0x06007D8B RID: 32139 RVA: 0x0073E438 File Offset: 0x0073C638
		public string DEKButtonFeature_A21353_UIValue
		{
			get
			{
				short num = (short)764027044;
				short num2 = num;
				num = (short)1712791716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1094647808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1214840832;
				if (num != 0)
				{
				}
				num = (short)179961857;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.UIValue;
			}
			set
			{
				short num = (short)890943580;
				short num2 = num;
				num = (short)74233948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325648384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1931214849;
				if (num != 0)
				{
				}
				num = (short)720502784;
				if (num != 0)
				{
				}
				this.dEKButtonFeature_A21353.UIValue = value;
			}
		}

		// Token: 0x1700403C RID: 16444
		// (get) Token: 0x06007D8C RID: 32140 RVA: 0x0073E4F0 File Offset: 0x0073C6F0
		public global::AcpBusinessLayer.AcpListField DEKButtonFeature_A21353
		{
			get
			{
				short num = (short)1027260159;
				short num2 = num;
				num = (short)377274111;
				switch (num2 == num)
				{
				default:
				{
					num = (short)79298560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429667841;
				if (num != 0)
				{
				}
				num = (short)1723138048;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353;
			}
		}

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x06007D8D RID: 32141 RVA: 0x0073E5A0 File Offset: 0x0073C7A0
		// (set) Token: 0x06007D8E RID: 32142 RVA: 0x0073E654 File Offset: 0x0073C854
		public bool DEKButtonFeature_A21353_Applicable
		{
			get
			{
				short num = (short)1159916803;
				short num2 = num;
				num = (short)1213525251;
				switch (num2 == num)
				{
				default:
				{
					num = (short)479264768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)435355649;
				if (num != 0)
				{
				}
				num = (short)1112276992;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.Applicable;
			}
			set
			{
				short num = (short)1939996673;
				if (num != 0)
				{
				}
				num = (short)847708160;
				short num2 = num;
				num = (short)1203023002;
				short num3 = num;
				num = (short)707636378;
				switch (num3 == num)
				{
				}
				num = (short)1302855680;
				if (num != 0)
				{
				}
				this.dEKButtonFeature_A21353.Applicable = value;
			}
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x06007D8F RID: 32143 RVA: 0x0073E710 File Offset: 0x0073C910
		// (set) Token: 0x06007D90 RID: 32144 RVA: 0x0073E7C4 File Offset: 0x0073C9C4
		public bool DEKButtonFeature_A21353_Valid
		{
			get
			{
				short num = (short)1322473527;
				short num2 = num;
				num = (short)1224497207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)259719168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1136525313;
				if (num != 0)
				{
				}
				num = (short)414253056;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.Valid;
			}
			set
			{
				short num = (short)1891739950;
				short num2 = num;
				num = (short)1568123182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2111700992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1510932481;
				if (num != 0)
				{
				}
				num = (short)494272512;
				if (num != 0)
				{
				}
				this.dEKButtonFeature_A21353.Valid = value;
			}
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x06007D91 RID: 32145 RVA: 0x0073E878 File Offset: 0x0073CA78
		// (set) Token: 0x06007D92 RID: 32146 RVA: 0x0073E92C File Offset: 0x0073CB2C
		public bool DEKButtonFeature_A21353_Visible
		{
			get
			{
				short num = (short)1761476608;
				short num2 = num;
				num = (short)146174011;
				short num3 = num;
				num = (short)1680764987;
				switch (num3 == num)
				{
				}
				num = (short)1907621889;
				if (num != 0)
				{
				}
				num = (short)14155776;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.Visible;
			}
			set
			{
				short num = (short)1065287680;
				short num2 = num;
				num = (short)661474804;
				short num3 = num;
				num = (short)353062388;
				switch (num3 == num)
				{
				}
				num = (short)1398210561;
				if (num != 0)
				{
				}
				num = (short)1852047360;
				if (num != 0)
				{
				}
				this.dEKButtonFeature_A21353.Visible = value;
			}
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x06007D93 RID: 32147 RVA: 0x0073E9E0 File Offset: 0x0073CBE0
		// (set) Token: 0x06007D94 RID: 32148 RVA: 0x0073EA98 File Offset: 0x0073CC98
		public bool DEKButtonFeature_A21353_Editable
		{
			get
			{
				short num = (short)348061696;
				short num2 = num;
				num = (short)1564065164;
				short num3 = num;
				num = (short)272547212;
				switch (num3 == num)
				{
				}
				num = (short)380895233;
				if (num != 0)
				{
				}
				num = (short)1383858176;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.Editable;
			}
			set
			{
				short num = (short)873791488;
				short num2 = num;
				num = (short)1529462184;
				short num3 = num;
				num = (short)564641192;
				switch (num3 == num)
				{
				}
				num = (short)153354241;
				if (num != 0)
				{
				}
				num = (short)1065615360;
				if (num != 0)
				{
				}
				this.dEKButtonFeature_A21353.Editable = value;
			}
		}

		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x06007D95 RID: 32149 RVA: 0x0073EB4C File Offset: 0x0073CD4C
		internal string DEKButtonFeature_A21353_UILabel
		{
			get
			{
				short num = (short)1221459968;
				short num2 = num;
				num = (short)383123457;
				if (num != 0)
				{
				}
				num = (short)325132943;
				short num3 = num;
				num = (short)974987919;
				switch (num3 == num)
				{
				}
				num = (short)1224605696;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.UIName;
			}
		}

		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x06007D96 RID: 32150 RVA: 0x0073EC00 File Offset: 0x0073CE00
		// (set) Token: 0x06007D97 RID: 32151 RVA: 0x0073ECB8 File Offset: 0x0073CEB8
		internal bool DEKButtonFeature_A21353_HiddenStatic
		{
			get
			{
				short num = (short)466223104;
				short num2 = num;
				num = (short)1977942313;
				short num3 = num;
				num = (short)1690566953;
				switch (num3 == num)
				{
				}
				num = (short)1213792257;
				if (num != 0)
				{
				}
				num = (short)447741952;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.HiddenStatic;
			}
			set
			{
				short num = (short)277479424;
				short num2 = num;
				num = (short)1211957249;
				if (num != 0)
				{
				}
				num = (short)1712964091;
				short num3 = num;
				num = (short)1045938683;
				switch (num3 == num)
				{
				}
				num = (short)73596928;
				if (num != 0)
				{
				}
				this.dEKButtonFeature_A21353.HiddenStatic = value;
			}
		}

		// Token: 0x17004043 RID: 16451
		// (get) Token: 0x06007D98 RID: 32152 RVA: 0x0073ED6C File Offset: 0x0073CF6C
		// (set) Token: 0x06007D99 RID: 32153 RVA: 0x0073EE20 File Offset: 0x0073D020
		internal bool DEKButtonFeature_A21353_HiddenDynamic
		{
			get
			{
				short num = (short)1218576384;
				short num2 = num;
				num = (short)147324929;
				if (num != 0)
				{
				}
				num = (short)1592463732;
				short num3 = num;
				num = (short)140054900;
				switch (num3 == num)
				{
				}
				num = (short)335282176;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353.HiddenDynamic;
			}
			set
			{
				short num = (short)1090584576;
				short num2 = num;
				num = (short)940780013;
				short num3 = num;
				num = (short)110832109;
				switch (num3 == num)
				{
				}
				num = (short)1324613633;
				if (num != 0)
				{
				}
				num = (short)428081152;
				if (num != 0)
				{
				}
				this.dEKButtonFeature_A21353.HiddenDynamic = value;
			}
		}

		// Token: 0x17004044 RID: 16452
		// (get) Token: 0x06007D9A RID: 32154 RVA: 0x0073EED8 File Offset: 0x0073D0D8
		public bool DEKButtonFeature_A21353_HasDiffs
		{
			get
			{
				short num = (short)340590592;
				short num2 = num;
				num = (short)595079910;
				short num3 = num;
				num = (short)34157286;
				switch (num3 == num)
				{
				}
				num = (short)1161625601;
				if (num != 0)
				{
				}
				num = (short)1964834816;
				if (num != 0)
				{
				}
				return this.dEKButtonFeature_A21353._HasDiffs;
			}
		}

		// Token: 0x17004045 RID: 16453
		// (get) Token: 0x06007D9B RID: 32155 RVA: 0x0073EF8C File Offset: 0x0073D18C
		// (set) Token: 0x06007D9C RID: 32156 RVA: 0x0073F044 File Offset: 0x0073D244
		public int DEKChannel_A22565Value
		{
			get
			{
				short num = (short)789512192;
				short num2 = num;
				num = (short)2091392012;
				short num3 = num;
				num = (short)2141723660;
				switch (num3 == num)
				{
				}
				num = (short)886046721;
				if (num != 0)
				{
				}
				num = (short)1284046848;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.Value;
			}
			set
			{
				short num = (short)1788739584;
				short num2 = num;
				num = (short)26292744;
				short num3 = num;
				num = (short)1164915208;
				switch (num3 == num)
				{
				}
				num = (short)1409613825;
				if (num != 0)
				{
				}
				num = (short)1233453056;
				if (num != 0)
				{
				}
				this.dEKChannel_A22565.Value = value;
			}
		}

		// Token: 0x17004046 RID: 16454
		// (get) Token: 0x06007D9D RID: 32157 RVA: 0x0073F0FC File Offset: 0x0073D2FC
		// (set) Token: 0x06007D9E RID: 32158 RVA: 0x0073F1B4 File Offset: 0x0073D3B4
		public string DEKChannel_A22565_UIValue
		{
			get
			{
				short num = (short)1753939968;
				short num2 = num;
				num = (short)5560885;
				short num3 = num;
				num = (short)937548341;
				switch (num3 == num)
				{
				}
				num = (short)1996423169;
				if (num != 0)
				{
				}
				num = (short)356581376;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.UIValue;
			}
			set
			{
				short num = (short)624164864;
				short num2 = num;
				num = (short)471060730;
				short num3 = num;
				num = (short)1453904122;
				switch (num3 == num)
				{
				}
				num = (short)1024851968;
				if (num != 0)
				{
				}
				num = (short)983433217;
				if (num != 0)
				{
				}
				this.dEKChannel_A22565.UIValue = value;
			}
		}

		// Token: 0x17004047 RID: 16455
		// (get) Token: 0x06007D9F RID: 32159 RVA: 0x0073F268 File Offset: 0x0073D468
		public global::AcpBusinessLayer.AcpRecRefField DEKChannel_A22565
		{
			get
			{
				short num = (short)1394475008;
				short num2 = num;
				num = (short)101951511;
				short num3 = num;
				num = (short)962897943;
				switch (num3 == num)
				{
				}
				num = (short)1343684608;
				if (num != 0)
				{
				}
				num = (short)1883439105;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565;
			}
		}

		// Token: 0x17004048 RID: 16456
		// (get) Token: 0x06007DA0 RID: 32160 RVA: 0x0073F31C File Offset: 0x0073D51C
		// (set) Token: 0x06007DA1 RID: 32161 RVA: 0x0073F3D0 File Offset: 0x0073D5D0
		public bool DEKChannel_A22565_Applicable
		{
			get
			{
				short num = (short)1076101120;
				short num2 = num;
				num = (short)1341849601;
				if (num != 0)
				{
				}
				num = (short)45279301;
				short num3 = num;
				num = (short)898951237;
				switch (num3 == num)
				{
				}
				num = (short)644546560;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.Applicable;
			}
			set
			{
				short num = (short)329449472;
				short num2 = num;
				num = (short)842709685;
				short num3 = num;
				num = (short)1873853109;
				switch (num3 == num)
				{
				}
				num = (short)1172176897;
				if (num != 0)
				{
				}
				num = (short)798556160;
				if (num != 0)
				{
				}
				this.dEKChannel_A22565.Applicable = value;
			}
		}

		// Token: 0x17004049 RID: 16457
		// (get) Token: 0x06007DA2 RID: 32162 RVA: 0x0073F484 File Offset: 0x0073D684
		// (set) Token: 0x06007DA3 RID: 32163 RVA: 0x0073F53C File Offset: 0x0073D73C
		public bool DEKChannel_A22565_Valid
		{
			get
			{
				short num = (short)1056440320;
				short num2 = num;
				num = (short)14475230;
				short num3 = num;
				num = (short)1762648030;
				switch (num3 == num)
				{
				}
				num = (short)1394671617;
				if (num != 0)
				{
				}
				num = (short)351141888;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.Valid;
			}
			set
			{
				short num = (short)994639872;
				short num2 = num;
				num = (short)613632825;
				short num3 = num;
				num = (short)1154304825;
				switch (num3 == num)
				{
				}
				num = (short)533921792;
				if (num != 0)
				{
				}
				num = (short)1236008961;
				if (num != 0)
				{
				}
				this.dEKChannel_A22565.Valid = value;
			}
		}

		// Token: 0x1700404A RID: 16458
		// (get) Token: 0x06007DA4 RID: 32164 RVA: 0x0073F5F4 File Offset: 0x0073D7F4
		// (set) Token: 0x06007DA5 RID: 32165 RVA: 0x0073F6A8 File Offset: 0x0073D8A8
		public bool DEKChannel_A22565_Visible
		{
			get
			{
				short num = (short)248315904;
				short num2 = num;
				num = (short)933625857;
				if (num != 0)
				{
				}
				num = (short)660026220;
				short num3 = num;
				num = (short)387199852;
				switch (num3 == num)
				{
				}
				num = (short)627965952;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.Visible;
			}
			set
			{
				short num = (short)836304896;
				short num2 = num;
				num = (short)1911163183;
				short num3 = num;
				num = (short)676333871;
				switch (num3 == num)
				{
				}
				num = (short)1318912000;
				if (num != 0)
				{
				}
				num = (short)104005633;
				if (num != 0)
				{
				}
				this.dEKChannel_A22565.Visible = value;
			}
		}

		// Token: 0x1700404B RID: 16459
		// (get) Token: 0x06007DA6 RID: 32166 RVA: 0x0073F75C File Offset: 0x0073D95C
		// (set) Token: 0x06007DA7 RID: 32167 RVA: 0x0073F814 File Offset: 0x0073DA14
		public bool DEKChannel_A22565_Editable
		{
			get
			{
				short num = (short)144048128;
				short num2 = num;
				num = (short)249626625;
				if (num != 0)
				{
				}
				num = (short)1611081555;
				short num3 = num;
				num = (short)1634346835;
				switch (num3 == num)
				{
				}
				num = (short)747307008;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.Editable;
			}
			set
			{
				short num = (short)1643184128;
				short num2 = num;
				num = (short)1365094076;
				short num3 = num;
				num = (short)899591868;
				switch (num3 == num)
				{
				}
				num = (short)581500929;
				if (num != 0)
				{
				}
				num = (short)376897536;
				if (num != 0)
				{
				}
				this.dEKChannel_A22565.Editable = value;
			}
		}

		// Token: 0x1700404C RID: 16460
		// (get) Token: 0x06007DA8 RID: 32168 RVA: 0x0073F8C8 File Offset: 0x0073DAC8
		internal string DEKChannel_A22565_UILabel
		{
			get
			{
				short num = (short)1860960256;
				short num2 = num;
				num = (short)1129849747;
				short num3 = num;
				num = (short)1296573331;
				switch (num3 == num)
				{
				}
				num = (short)315883521;
				if (num != 0)
				{
				}
				num = (short)1456013312;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.UIName;
			}
		}

		// Token: 0x1700404D RID: 16461
		// (get) Token: 0x06007DA9 RID: 32169 RVA: 0x0073F97C File Offset: 0x0073DB7C
		// (set) Token: 0x06007DAA RID: 32170 RVA: 0x0073FA30 File Offset: 0x0073DC30
		internal bool DEKChannel_A22565_HiddenStatic
		{
			get
			{
				short num = (short)1483276288;
				short num2 = num;
				num = (short)147726151;
				short num3 = num;
				num = (short)1696866119;
				switch (num3 == num)
				{
				}
				num = (short)2101673985;
				if (num != 0)
				{
				}
				num = (short)1125056512;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.HiddenStatic;
			}
			set
			{
				short num = (short)942800896;
				short num2 = num;
				num = (short)1409143575;
				short num3 = num;
				num = (short)1895289623;
				switch (num3 == num)
				{
				}
				num = (short)50921473;
				if (num != 0)
				{
				}
				num = (short)1871642624;
				if (num != 0)
				{
				}
				this.dEKChannel_A22565.HiddenStatic = value;
			}
		}

		// Token: 0x1700404E RID: 16462
		// (get) Token: 0x06007DAB RID: 32171 RVA: 0x0073FAE4 File Offset: 0x0073DCE4
		// (set) Token: 0x06007DAC RID: 32172 RVA: 0x0073FB98 File Offset: 0x0073DD98
		internal bool DEKChannel_A22565_HiddenDynamic
		{
			get
			{
				short num = (short)1607335936;
				short num2 = num;
				num = (short)1560998603;
				short num3 = num;
				num = (short)1215820491;
				switch (num3 == num)
				{
				}
				num = (short)318242816;
				if (num != 0)
				{
				}
				num = (short)227606529;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565.HiddenDynamic;
			}
			set
			{
				short num = (short)1341325312;
				short num2 = num;
				num = (short)246349825;
				if (num != 0)
				{
				}
				num = (short)275459770;
				short num3 = num;
				num = (short)1856384698;
				switch (num3 == num)
				{
				}
				num = (short)1867579392;
				if (num != 0)
				{
				}
				this.dEKChannel_A22565.HiddenDynamic = value;
			}
		}

		// Token: 0x1700404F RID: 16463
		// (get) Token: 0x06007DAD RID: 32173 RVA: 0x0073FC4C File Offset: 0x0073DE4C
		public bool DEKChannel_A22565_HasDiffs
		{
			get
			{
				short num = (short)1203109888;
				short num2 = num;
				num = (short)1108171005;
				short num3 = num;
				num = (short)637819133;
				switch (num3 == num)
				{
				}
				num = (short)782368768;
				if (num != 0)
				{
				}
				num = (short)631177217;
				if (num != 0)
				{
				}
				return this.dEKChannel_A22565._HasDiffs;
			}
		}

		// Token: 0x17004050 RID: 16464
		// (get) Token: 0x06007DAE RID: 32174 RVA: 0x0073FD04 File Offset: 0x0073DF04
		// (set) Token: 0x06007DAF RID: 32175 RVA: 0x0073FDBC File Offset: 0x0073DFBC
		public int DEKZone_A22566Value
		{
			get
			{
				short num = (short)1348730880;
				short num2 = num;
				num = (short)43937594;
				short num3 = num;
				num = (short)1115582266;
				switch (num3 == num)
				{
				}
				num = (short)983236609;
				if (num != 0)
				{
				}
				num = (short)1017315328;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.Value;
			}
			set
			{
				short num = (short)979632128;
				short num2 = num;
				num = (short)489236267;
				short num3 = num;
				num = (short)890119979;
				switch (num3 == num)
				{
				}
				num = (short)2074083328;
				if (num != 0)
				{
				}
				num = (short)900530177;
				if (num != 0)
				{
				}
				this.dEKZone_A22566.Value = value;
			}
		}

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x06007DB0 RID: 32176 RVA: 0x0073FE70 File Offset: 0x0073E070
		// (set) Token: 0x06007DB1 RID: 32177 RVA: 0x0073FF24 File Offset: 0x0073E124
		public string DEKZone_A22566_UIValue
		{
			get
			{
				short num = (short)1964900352;
				short num2 = num;
				num = (short)2027683841;
				if (num != 0)
				{
				}
				num = (short)854560595;
				short num3 = num;
				num = (short)488083283;
				switch (num3 == num)
				{
				}
				num = (short)1926037504;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.UIValue;
			}
			set
			{
				short num = (short)1090846720;
				short num2 = num;
				num = (short)450303984;
				short num3 = num;
				num = (short)1785599984;
				switch (num3 == num)
				{
				}
				num = (short)1217986561;
				if (num != 0)
				{
				}
				num = (short)1421869056;
				if (num != 0)
				{
				}
				this.dEKZone_A22566.UIValue = value;
			}
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x0073FFD8 File Offset: 0x0073E1D8
		public global::AcpBusinessLayer.AcpRecRefField DEKZone_A22566
		{
			get
			{
				short num = (short)826015744;
				short num2 = num;
				num = (short)1101898963;
				short num3 = num;
				num = (short)192390355;
				switch (num3 == num)
				{
				}
				num = (short)975175680;
				if (num != 0)
				{
				}
				num = (short)1531510785;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566;
			}
		}

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x06007DB3 RID: 32179 RVA: 0x00740088 File Offset: 0x0073E288
		// (set) Token: 0x06007DB4 RID: 32180 RVA: 0x00740140 File Offset: 0x0073E340
		public bool DEKZone_A22566_Applicable
		{
			get
			{
				short num = (short)1404239872;
				short num2 = num;
				num = (short)1570953479;
				short num3 = num;
				num = (short)1416681735;
				switch (num3 == num)
				{
				}
				num = (short)859242496;
				if (num != 0)
				{
				}
				num = (short)307953665;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.Applicable;
			}
			set
			{
				short num = (short)539426816;
				short num2 = num;
				num = (short)499696490;
				short num3 = num;
				num = (short)365085546;
				switch (num3 == num)
				{
				}
				num = (short)1453850625;
				if (num != 0)
				{
				}
				num = (short)114294784;
				if (num != 0)
				{
				}
				this.dEKZone_A22566.Applicable = value;
			}
		}

		// Token: 0x17004054 RID: 16468
		// (get) Token: 0x06007DB5 RID: 32181 RVA: 0x007401F8 File Offset: 0x0073E3F8
		// (set) Token: 0x06007DB6 RID: 32182 RVA: 0x007402AC File Offset: 0x0073E4AC
		public bool DEKZone_A22566_Valid
		{
			get
			{
				short num = (short)2068774912;
				short num2 = num;
				num = (short)1423431904;
				short num3 = num;
				num = (short)1619450080;
				switch (num3 == num)
				{
				}
				num = (short)1010892801;
				if (num != 0)
				{
				}
				num = (short)450428928;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.Valid;
			}
			set
			{
				short num = (short)1532362752;
				short num2 = num;
				num = (short)1735917569;
				if (num != 0)
				{
				}
				num = (short)2085131887;
				short num3 = num;
				num = (short)1610192495;
				switch (num3 == num)
				{
				}
				num = (short)1873412096;
				if (num != 0)
				{
				}
				this.dEKZone_A22566.Valid = value;
			}
		}

		// Token: 0x17004055 RID: 16469
		// (get) Token: 0x06007DB7 RID: 32183 RVA: 0x0074035C File Offset: 0x0073E55C
		// (set) Token: 0x06007DB8 RID: 32184 RVA: 0x00740410 File Offset: 0x0073E610
		public bool DEKZone_A22566_Visible
		{
			get
			{
				short num = (short)1826553856;
				short num2 = num;
				num = (short)827290898;
				short num3 = num;
				num = (short)1949463826;
				switch (num3 == num)
				{
				}
				num = (short)1102249985;
				if (num != 0)
				{
				}
				num = (short)1825439744;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.Visible;
			}
			set
			{
				short num = (short)84869120;
				short num2 = num;
				num = (short)1399594931;
				short num3 = num;
				num = (short)1626808243;
				switch (num3 == num)
				{
				}
				num = (short)190578688;
				if (num != 0)
				{
				}
				num = (short)1788542977;
				if (num != 0)
				{
				}
				this.dEKZone_A22566.Visible = value;
			}
		}

		// Token: 0x17004056 RID: 16470
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x007404C4 File Offset: 0x0073E6C4
		// (set) Token: 0x06007DBA RID: 32186 RVA: 0x0074057C File Offset: 0x0073E77C
		public bool DEKZone_A22566_Editable
		{
			get
			{
				short num = (short)2103312384;
				short num2 = num;
				num = (short)1505544030;
				short num3 = num;
				num = (short)2041628510;
				switch (num3 == num)
				{
				}
				num = (short)1368391680;
				if (num != 0)
				{
				}
				num = (short)341377025;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.Editable;
			}
			set
			{
				short num = (short)112263168;
				short num2 = num;
				num = (short)879778073;
				short num3 = num;
				num = (short)1939036441;
				switch (num3 == num)
				{
				}
				num = (short)1990656000;
				if (num != 0)
				{
				}
				num = (short)1851326465;
				if (num != 0)
				{
				}
				this.dEKZone_A22566.Editable = value;
			}
		}

		// Token: 0x17004057 RID: 16471
		// (get) Token: 0x06007DBB RID: 32187 RVA: 0x00740634 File Offset: 0x0073E834
		internal string DEKZone_A22566_UILabel
		{
			get
			{
				short num = (short)1331232768;
				short num2 = num;
				num = (short)425872648;
				short num3 = num;
				num = (short)1895845128;
				switch (num3 == num)
				{
				}
				num = (short)890437632;
				if (num != 0)
				{
				}
				num = (short)121176065;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.UIName;
			}
		}

		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x06007DBC RID: 32188 RVA: 0x007406E8 File Offset: 0x0073E8E8
		// (set) Token: 0x06007DBD RID: 32189 RVA: 0x0074079C File Offset: 0x0073E99C
		internal bool DEKZone_A22566_HiddenStatic
		{
			get
			{
				short num = (short)247398400;
				short num2 = num;
				num = (short)755059300;
				short num3 = num;
				num = (short)444222052;
				switch (num3 == num)
				{
				}
				num = (short)1987772417;
				if (num != 0)
				{
				}
				num = (short)1055195136;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.HiddenStatic;
			}
			set
			{
				short num = (short)1942159360;
				short num2 = num;
				num = (short)1181241864;
				short num3 = num;
				num = (short)472732168;
				switch (num3 == num)
				{
				}
				num = (short)605552641;
				if (num != 0)
				{
				}
				num = (short)1529085952;
				if (num != 0)
				{
				}
				this.dEKZone_A22566.HiddenStatic = value;
			}
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x06007DBE RID: 32190 RVA: 0x00740854 File Offset: 0x0073EA54
		// (set) Token: 0x06007DBF RID: 32191 RVA: 0x00740908 File Offset: 0x0073EB08
		internal bool DEKZone_A22566_HiddenDynamic
		{
			get
			{
				short num = (short)1583415296;
				short num2 = num;
				num = (short)1033322628;
				short num3 = num;
				num = (short)512901252;
				switch (num3 == num)
				{
				}
				num = (short)21561345;
				if (num != 0)
				{
				}
				num = (short)185139200;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566.HiddenDynamic;
			}
			set
			{
				short num = (short)1298989056;
				short num2 = num;
				num = (short)1569817968;
				short num3 = num;
				num = (short)1025344880;
				switch (num3 == num)
				{
				}
				num = (short)974192641;
				if (num != 0)
				{
				}
				num = (short)579141632;
				if (num != 0)
				{
				}
				this.dEKZone_A22566.HiddenDynamic = value;
			}
		}

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x06007DC0 RID: 32192 RVA: 0x007409BC File Offset: 0x0073EBBC
		public bool DEKZone_A22566_HasDiffs
		{
			get
			{
				short num = (short)1617887232;
				short num2 = num;
				num = (short)1034080033;
				short num3 = num;
				num = (short)1758908193;
				switch (num3 == num)
				{
				}
				num = (short)115736576;
				if (num != 0)
				{
				}
				num = (short)976093185;
				if (num != 0)
				{
				}
				return this.dEKZone_A22566._HasDiffs;
			}
		}

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x06007DC1 RID: 32193 RVA: 0x00740A74 File Offset: 0x0073EC74
		// (set) Token: 0x06007DC2 RID: 32194 RVA: 0x00740B2C File Offset: 0x0073ED2C
		public string DEKButtonName_A22568Value
		{
			get
			{
				short num = (short)817168384;
				short num2 = num;
				num = (short)314376193;
				if (num != 0)
				{
				}
				num = (short)1176008844;
				short num3 = num;
				num = (short)854423692;
				switch (num3 == num)
				{
				}
				num = (short)1891041280;
				if (num != 0)
				{
				}
				return this.dEKButtonName_A22568.Value;
			}
			set
			{
				short num = (short)1609760768;
				short num2 = num;
				num = (short)1737805846;
				short num3 = num;
				num = (short)1366020118;
				switch (num3 == num)
				{
				}
				num = (short)1470496769;
				if (num != 0)
				{
				}
				num = (short)1952710656;
				if (num != 0)
				{
				}
				this.dEKButtonName_A22568.Value = value;
			}
		}

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x06007DC3 RID: 32195 RVA: 0x00740BE0 File Offset: 0x0073EDE0
		public global::AcpBusinessLayer.AcpField<string> DEKButtonName_A22568
		{
			get
			{
				short num = (short)1280573440;
				short num2 = num;
				num = (short)61800449;
				if (num != 0)
				{
				}
				num = (short)2064254026;
				short num3 = num;
				num = (short)486802506;
				switch (num3 == num)
				{
				}
				num = (short)1283719168;
				if (num != 0)
				{
				}
				return this.dEKButtonName_A22568;
			}
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x06007DC4 RID: 32196 RVA: 0x00740C94 File Offset: 0x0073EE94
		// (set) Token: 0x06007DC5 RID: 32197 RVA: 0x00740D50 File Offset: 0x0073EF50
		public string DEKButtonName_A22568_UIValue
		{
			get
			{
				short num = (short)418906112;
				short num2 = num;
				num = (short)1366232356;
				short num3 = num;
				num = (short)1134759204;
				switch (num3 == num)
				{
				}
				num = (short)693633024;
				if (num != 0)
				{
				}
				num = (short)1220083713;
				if (num != 0)
				{
				}
				return this.dEKButtonName_A22568.Value;
			}
			set
			{
				short num = (short)740687872;
				short num2 = num;
				num = (short)1652842848;
				short num3 = num;
				num = (short)2102944096;
				switch (num3 == num)
				{
				}
				num = (short)316604417;
				if (num != 0)
				{
				}
				num = (short)108134400;
				if (num != 0)
				{
				}
				this.dEKButtonName_A22568.Value = value;
			}
		}

		// Token: 0x1700405E RID: 16478
		// (get) Token: 0x06007DC6 RID: 32198 RVA: 0x00740E04 File Offset: 0x0073F004
		// (set) Token: 0x06007DC7 RID: 32199 RVA: 0x00740EBC File Offset: 0x0073F0BC
		public bool DEKButtonName_A22568_Applicable
		{
			get
			{
				short num = (short)995229697;
				if (num != 0)
				{
				}
				num = (short)1047602378;
				short num2 = num;
				num = (short)362685642;
				switch (num2 == num)
				{
				}
				num = (short)997982208;
				if (num != 0)
				{
				}
				num = (short)1280180224;
				short num3 = num;
				return this.dEKButtonName_A22568.Applicable;
			}
			set
			{
				short num = (short)1730912255;
				short num2 = num;
				num = (short)927506431;
				switch (num2 == num)
				{
				}
				num = (short)1721106433;
				if (num != 0)
				{
				}
				num = (short)1319370752;
				if (num != 0)
				{
				}
				num = (short)687800320;
				short num3 = num;
				this.dEKButtonName_A22568.Applicable = value;
			}
		}

		// Token: 0x1700405F RID: 16479
		// (get) Token: 0x06007DC8 RID: 32200 RVA: 0x00740F70 File Offset: 0x0073F170
		// (set) Token: 0x06007DC9 RID: 32201 RVA: 0x00741024 File Offset: 0x0073F224
		public bool DEKButtonName_A22568_Valid
		{
			get
			{
				short num = (short)2102806759;
				short num2 = num;
				num = (short)1211582695;
				switch (num2 == num)
				{
				}
				num = (short)475856897;
				if (num != 0)
				{
				}
				num = (short)448462848;
				if (num != 0)
				{
				}
				num = (short)1139212288;
				short num3 = num;
				return this.dEKButtonName_A22568.Valid;
			}
			set
			{
				short num = (short)1834131255;
				short num2 = num;
				num = (short)1273470775;
				switch (num2 == num)
				{
				}
				num = (short)1410269184;
				if (num != 0)
				{
				}
				num = (short)10158081;
				if (num != 0)
				{
				}
				num = (short)53870592;
				short num3 = num;
				this.dEKButtonName_A22568.Valid = value;
			}
		}

		// Token: 0x17004060 RID: 16480
		// (get) Token: 0x06007DCA RID: 32202 RVA: 0x007410D8 File Offset: 0x0073F2D8
		// (set) Token: 0x06007DCB RID: 32203 RVA: 0x0074118C File Offset: 0x0073F38C
		public bool DEKButtonName_A22568_Visible
		{
			get
			{
				short num = (short)1480432121;
				short num2 = num;
				num = (short)1157601785;
				switch (num2 == num)
				{
				}
				num = (short)2058027009;
				if (num != 0)
				{
				}
				num = (short)559874048;
				if (num != 0)
				{
				}
				num = (short)21561344;
				short num3 = num;
				return this.dEKButtonName_A22568.Visible;
			}
			set
			{
				short num = (short)1701813857;
				short num2 = num;
				num = (short)1529585249;
				switch (num2 == num)
				{
				}
				num = (short)2041577472;
				if (num != 0)
				{
				}
				num = (short)1062076417;
				if (num != 0)
				{
				}
				num = (short)1457848320;
				short num3 = num;
				this.dEKButtonName_A22568.Visible = value;
			}
		}

		// Token: 0x17004061 RID: 16481
		// (get) Token: 0x06007DCC RID: 32204 RVA: 0x00741240 File Offset: 0x0073F440
		// (set) Token: 0x06007DCD RID: 32205 RVA: 0x007412F4 File Offset: 0x0073F4F4
		public bool DEKButtonName_A22568_Editable
		{
			get
			{
				short num = (short)1753567096;
				short num2 = num;
				num = (short)784027512;
				switch (num2 == num)
				{
				}
				num = (short)554434561;
				if (num != 0)
				{
				}
				num = (short)191234048;
				if (num != 0)
				{
				}
				num = (short)406716416;
				short num3 = num;
				return this.dEKButtonName_A22568.Editable;
			}
			set
			{
				short num = (short)1084821086;
				short num2 = num;
				num = (short)59117150;
				switch (num2 == num)
				{
				}
				num = (short)1479606272;
				if (num != 0)
				{
				}
				num = (short)1900740609;
				if (num != 0)
				{
				}
				num = (short)1205927936;
				short num3 = num;
				this.dEKButtonName_A22568.Editable = value;
			}
		}

		// Token: 0x17004062 RID: 16482
		// (get) Token: 0x06007DCE RID: 32206 RVA: 0x007413A8 File Offset: 0x0073F5A8
		internal string DEKButtonName_A22568_UILabel
		{
			get
			{
				short num = (short)1485869889;
				short num2 = num;
				num = (short)1156354881;
				switch (num2 == num)
				{
				}
				num = (short)953942016;
				if (num != 0)
				{
				}
				num = (short)1372061697;
				if (num != 0)
				{
				}
				num = (short)1871314944;
				short num3 = num;
				return this.dEKButtonName_A22568.UIName;
			}
		}

		// Token: 0x17004063 RID: 16483
		// (get) Token: 0x06007DCF RID: 32207 RVA: 0x00741460 File Offset: 0x0073F660
		// (set) Token: 0x06007DD0 RID: 32208 RVA: 0x00741518 File Offset: 0x0073F718
		internal bool DEKButtonName_A22568_HiddenStatic
		{
			get
			{
				short num = (short)185907319;
				short num2 = num;
				num = (short)294041719;
				switch (num2 == num)
				{
				}
				num = (short)404291585;
				if (num != 0)
				{
				}
				num = (short)140836864;
				if (num != 0)
				{
				}
				num = (short)1612906496;
				short num3 = num;
				return this.dEKButtonName_A22568.HiddenStatic;
			}
			set
			{
				short num = (short)1114963969;
				if (num != 0)
				{
				}
				num = (short)667073203;
				short num2 = num;
				num = (short)132364979;
				switch (num2 == num)
				{
				}
				num = (short)2031616;
				if (num != 0)
				{
				}
				num = (short)45744128;
				short num3 = num;
				this.dEKButtonName_A22568.HiddenStatic = value;
			}
		}

		// Token: 0x17004064 RID: 16484
		// (get) Token: 0x06007DD1 RID: 32209 RVA: 0x007415CC File Offset: 0x0073F7CC
		// (set) Token: 0x06007DD2 RID: 32210 RVA: 0x00741684 File Offset: 0x0073F884
		internal bool DEKButtonName_A22568_HiddenDynamic
		{
			get
			{
				short num = (short)1362561979;
				short num2 = num;
				num = (short)817564603;
				switch (num2 == num)
				{
				}
				num = (short)1550909441;
				if (num != 0)
				{
				}
				num = (short)62193664;
				if (num != 0)
				{
				}
				num = (short)1028390912;
				short num3 = num;
				return this.dEKButtonName_A22568.HiddenDynamic;
			}
			set
			{
				short num = (short)1831570616;
				short num2 = num;
				num = (short)949718200;
				switch (num2 == num)
				{
				}
				num = (short)647168001;
				if (num != 0)
				{
				}
				num = (short)999161856;
				if (num != 0)
				{
				}
				num = (short)411697152;
				short num3 = num;
				this.dEKButtonName_A22568.HiddenDynamic = value;
			}
		}

		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x06007DD3 RID: 32211 RVA: 0x0074173C File Offset: 0x0073F93C
		public bool DEKButtonName_A22568_HasDiffs
		{
			get
			{
				short num = (short)1091312152;
				short num2 = num;
				num = (short)571939352;
				switch (num2 == num)
				{
				}
				num = (short)107413505;
				if (num != 0)
				{
				}
				num = (short)1598226432;
				if (num != 0)
				{
				}
				num = (short)33423360;
				short num3 = num;
				return this.dEKButtonName_A22568._HasDiffs;
			}
		}

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x06007DD4 RID: 32212 RVA: 0x007417F0 File Offset: 0x0073F9F0
		// (set) Token: 0x06007DD5 RID: 32213 RVA: 0x007418A4 File Offset: 0x0073FAA4
		public string DEKButtonKey_A22569Value
		{
			get
			{
				short num = (short)1212036449;
				short num2 = num;
				num = (short)932263265;
				switch (num2 == num)
				{
				}
				num = (short)1161691137;
				if (num != 0)
				{
				}
				num = (short)1030619136;
				if (num != 0)
				{
				}
				num = (short)31129600;
				short num3 = num;
				return this.dEKButtonKey_A22569.Value;
			}
			set
			{
				short num = (short)1079508994;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)219283457;
						if (num != 0)
						{
						}
						this.dEKButtonKey_A22569.Value = value;
						num = (short)752418817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					num = (short)2086598643;
					short num3 = num;
					num = (short)1457649651;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)912326656;
						short num4 = num;
						num = (short)1862336512;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)550240256;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x007419CC File Offset: 0x0073FBCC
		// (set) Token: 0x06007DD7 RID: 32215 RVA: 0x00741A80 File Offset: 0x0073FC80
		public string DEKButtonKey_A22569_UIValue
		{
			get
			{
				short num = (short)1720975361;
				if (num != 0)
				{
				}
				num = (short)1423565997;
				short num2 = num;
				num = (short)301655213;
				switch (num2 == num)
				{
				}
				num = (short)1520959488;
				if (num != 0)
				{
				}
				num = (short)315162624;
				short num3 = num;
				return this.dEKButtonKey_A22569.Value;
			}
			set
			{
				short num = (short)114823013;
				short num2 = num;
				num = (short)2122583909;
				switch (num2 == num)
				{
				}
				num = (short)2009595905;
				if (num != 0)
				{
				}
				num = (short)2094202880;
				if (num != 0)
				{
				}
				num = (short)1305673728;
				short num3 = num;
				this.dEKButtonKey_A22569.Value = value;
			}
		}

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x06007DD8 RID: 32216 RVA: 0x00741B34 File Offset: 0x0073FD34
		public global::AcpBusinessLayer.AcpKeyField DEKButtonKey_A22569
		{
			get
			{
				short num = (short)379528262;
				short num2 = num;
				num = (short)1463952454;
				switch (num2 == num)
				{
				}
				num = (short)1956773889;
				if (num != 0)
				{
				}
				num = (short)1927479296;
				if (num != 0)
				{
				}
				num = (short)102039552;
				short num3 = num;
				return this.dEKButtonKey_A22569;
			}
		}

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x06007DD9 RID: 32217 RVA: 0x00741BE0 File Offset: 0x0073FDE0
		// (set) Token: 0x06007DDA RID: 32218 RVA: 0x00741C94 File Offset: 0x0073FE94
		public bool DEKButtonKey_A22569_Applicable
		{
			get
			{
				short num = (short)897608396;
				short num2 = num;
				num = (short)223374028;
				switch (num2 == num)
				{
				}
				num = (short)44498945;
				if (num != 0)
				{
				}
				num = (short)2003632128;
				if (num != 0)
				{
				}
				num = (short)1717436416;
				short num3 = num;
				return this.dEKButtonKey_A22569.Applicable;
			}
			set
			{
				short num = (short)1806303233;
				if (num != 0)
				{
				}
				num = (short)493235077;
				short num2 = num;
				num = (short)1321216901;
				switch (num2 == num)
				{
				}
				num = (short)1267990528;
				if (num != 0)
				{
				}
				num = (short)1570308096;
				short num3 = num;
				this.dEKButtonKey_A22569.Applicable = value;
			}
		}

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x06007DDB RID: 32219 RVA: 0x00741D4C File Offset: 0x0073FF4C
		// (set) Token: 0x06007DDC RID: 32220 RVA: 0x00741DFC File Offset: 0x0073FFFC
		public bool DEKButtonKey_A22569_Valid
		{
			get
			{
				short num = (short)1567845390;
				short num2 = num;
				num = (short)1453943822;
				switch (num2 == num)
				{
				}
				num = (short)1880686593;
				if (num != 0)
				{
				}
				num = (short)1604583424;
				if (num != 0)
				{
				}
				num = (short)877658112;
				short num3 = num;
				return this.dEKButtonKey_A22569.Valid;
			}
			set
			{
				short num = (short)863285269;
				short num2 = num;
				num = (short)1627041813;
				switch (num2 == num)
				{
				}
				num = (short)1555628032;
				if (num != 0)
				{
				}
				num = (short)920584193;
				if (num != 0)
				{
				}
				num = (short)1382350848;
				short num3 = num;
				this.dEKButtonKey_A22569.Valid = value;
			}
		}

		// Token: 0x1700406B RID: 16491
		// (get) Token: 0x06007DDD RID: 32221 RVA: 0x00741EB0 File Offset: 0x007400B0
		// (set) Token: 0x06007DDE RID: 32222 RVA: 0x00741F64 File Offset: 0x00740164
		public bool DEKButtonKey_A22569_Visible
		{
			get
			{
				short num = (short)1650055755;
				short num2 = num;
				num = (short)172218955;
				switch (num2 == num)
				{
				}
				num = (short)549650433;
				if (num != 0)
				{
				}
				num = (short)1989541888;
				if (num != 0)
				{
				}
				num = (short)353828864;
				short num3 = num;
				return this.dEKButtonKey_A22569.Visible;
			}
			set
			{
				short num = (short)1415472216;
				short num2 = num;
				num = (short)2083152984;
				switch (num2 == num)
				{
				}
				num = (short)390856704;
				if (num != 0)
				{
				}
				num = (short)1616052225;
				if (num != 0)
				{
				}
				num = (short)276758528;
				short num3 = num;
				this.dEKButtonKey_A22569.Visible = value;
			}
		}

		// Token: 0x1700406C RID: 16492
		// (get) Token: 0x06007DDF RID: 32223 RVA: 0x0074201C File Offset: 0x0074021C
		// (set) Token: 0x06007DE0 RID: 32224 RVA: 0x007420D0 File Offset: 0x007402D0
		public bool DEKButtonKey_A22569_Editable
		{
			get
			{
				short num = (short)2002309514;
				short num2 = num;
				num = (short)1136906634;
				switch (num2 == num)
				{
				}
				num = (short)985989121;
				if (num != 0)
				{
				}
				num = (short)1978073088;
				if (num != 0)
				{
				}
				num = (short)694878208;
				short num3 = num;
				return this.dEKButtonKey_A22569.Editable;
			}
			set
			{
				short num = (short)689561282;
				short num2 = num;
				num = (short)1397939906;
				switch (num2 == num)
				{
				}
				num = (short)1263140865;
				if (num != 0)
				{
				}
				num = (short)1410400256;
				if (num != 0)
				{
				}
				num = (short)1691025408;
				short num3 = num;
				this.dEKButtonKey_A22569.Editable = value;
			}
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x06007DE1 RID: 32225 RVA: 0x00742184 File Offset: 0x00740384
		internal string DEKButtonKey_A22569_UILabel
		{
			get
			{
				short num = (short)211877889;
				if (num != 0)
				{
				}
				num = (short)1847610791;
				short num2 = num;
				num = (short)228609447;
				switch (num2 == num)
				{
				}
				num = (short)1758724096;
				if (num != 0)
				{
				}
				num = (short)542507008;
				short num3 = num;
				return this.dEKButtonKey_A22569.UIName;
			}
		}

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x06007DE2 RID: 32226 RVA: 0x00742238 File Offset: 0x00740438
		// (set) Token: 0x06007DE3 RID: 32227 RVA: 0x007422EC File Offset: 0x007404EC
		internal bool DEKButtonKey_A22569_HiddenStatic
		{
			get
			{
				short num = (short)1397826473;
				short num2 = num;
				num = (short)506602409;
				switch (num2 == num)
				{
				}
				num = (short)1957363712;
				if (num != 0)
				{
				}
				num = (short)1969750017;
				if (num != 0)
				{
				}
				num = (short)870318080;
				short num3 = num;
				return this.dEKButtonKey_A22569.HiddenStatic;
			}
			set
			{
				short num = (short)1010939438;
				short num2 = num;
				num = (short)1466414638;
				switch (num2 == num)
				{
				}
				num = (short)1756430336;
				if (num != 0)
				{
				}
				num = (short)1770848257;
				if (num != 0)
				{
				}
				num = (short)1406271488;
				short num3 = num;
				this.dEKButtonKey_A22569.HiddenStatic = value;
			}
		}

		// Token: 0x1700406F RID: 16495
		// (get) Token: 0x06007DE4 RID: 32228 RVA: 0x007423A0 File Offset: 0x007405A0
		// (set) Token: 0x06007DE5 RID: 32229 RVA: 0x00742454 File Offset: 0x00740654
		internal bool DEKButtonKey_A22569_HiddenDynamic
		{
			get
			{
				short num = (short)243501286;
				short num2 = num;
				num = (short)78416102;
				switch (num2 == num)
				{
				}
				num = (short)1397948417;
				if (num != 0)
				{
				}
				num = (short)766705664;
				if (num != 0)
				{
				}
				num = (short)2127167488;
				short num3 = num;
				return this.dEKButtonKey_A22569.HiddenDynamic;
			}
			set
			{
				short num = (short)187853552;
				short num2 = num;
				num = (short)1673226992;
				switch (num2 == num)
				{
				}
				num = (short)1554055169;
				if (num != 0)
				{
				}
				num = (short)1877540864;
				if (num != 0)
				{
				}
				num = (short)2017394688;
				short num3 = num;
				this.dEKButtonKey_A22569.HiddenDynamic = value;
			}
		}

		// Token: 0x17004070 RID: 16496
		// (get) Token: 0x06007DE6 RID: 32230 RVA: 0x0074250C File Offset: 0x0074070C
		public bool DEKButtonKey_A22569_HasDiffs
		{
			get
			{
				short num = (short)697761793;
				if (num != 0)
				{
				}
				num = (short)1030167046;
				short num2 = num;
				num = (short)346167814;
				switch (num2 == num)
				{
				}
				num = (short)1154744320;
				if (num != 0)
				{
				}
				num = (short)1411514368;
				short num3 = num;
				return this.dEKButtonKey_A22569._HasDiffs;
			}
		}

		// Token: 0x17004071 RID: 16497
		// (get) Token: 0x06007DE7 RID: 32231 RVA: 0x007425C0 File Offset: 0x007407C0
		// (set) Token: 0x06007DE8 RID: 32232 RVA: 0x00742678 File Offset: 0x00740878
		public int DEKButtonIndex_A22570Value
		{
			get
			{
				short num = (short)2085432818;
				short num2 = num;
				num = (short)1994141170;
				switch (num2 == num)
				{
				}
				num = (short)1244200960;
				if (num != 0)
				{
				}
				num = (short)854851585;
				if (num != 0)
				{
				}
				num = (short)1523908608;
				short num3 = num;
				return this.dEKButtonIndex_A22570.Value;
			}
			set
			{
				short num = (short)1108148225;
				if (num != 0)
				{
				}
				num = (short)84800293;
				short num2 = num;
				num = (short)623702821;
				switch (num2 == num)
				{
				}
				num = (short)1956118528;
				if (num != 0)
				{
				}
				num = (short)1969881088;
				short num3 = num;
				this.dEKButtonIndex_A22570.Value = value;
			}
		}

		// Token: 0x17004072 RID: 16498
		// (get) Token: 0x06007DE9 RID: 32233 RVA: 0x0074272C File Offset: 0x0074092C
		public global::AcpBusinessLayer.AcpRangeField<int, int> DEKButtonIndex_A22570
		{
			get
			{
				short num = (short)751830228;
				short num2 = num;
				num = (short)1257637076;
				switch (num2 == num)
				{
				}
				num = (short)795344897;
				if (num != 0)
				{
				}
				num = (short)1323237376;
				if (num != 0)
				{
				}
				num = (short)674627584;
				short num3 = num;
				return this.dEKButtonIndex_A22570;
			}
		}

		// Token: 0x17004073 RID: 16499
		// (get) Token: 0x06007DEA RID: 32234 RVA: 0x007427DC File Offset: 0x007409DC
		// (set) Token: 0x06007DEB RID: 32235 RVA: 0x00742894 File Offset: 0x00740A94
		public int DEKButtonIndex_A22570_UIValue
		{
			get
			{
				short num = (short)267030559;
				short num2 = num;
				num = (short)452431903;
				switch (num2 == num)
				{
				}
				num = (short)1528299521;
				if (num != 0)
				{
				}
				num = (short)1065418752;
				if (num != 0)
				{
				}
				num = (short)759431168;
				short num3 = num;
				return this.dEKButtonIndex_A22570.UIValue;
			}
			set
			{
				short num = (short)699868210;
				short num2 = num;
				num = (short)1531323442;
				switch (num2 == num)
				{
				}
				num = (short)1480720384;
				if (num != 0)
				{
				}
				num = (short)1036124161;
				if (num != 0)
				{
				}
				num = (short)1563623424;
				short num3 = num;
				this.dEKButtonIndex_A22570.UIValue = value;
			}
		}

		// Token: 0x17004074 RID: 16500
		// (get) Token: 0x06007DEC RID: 32236 RVA: 0x0074294C File Offset: 0x00740B4C
		// (set) Token: 0x06007DED RID: 32237 RVA: 0x00742A00 File Offset: 0x00740C00
		internal int DEKButtonIndex_A22570Min
		{
			get
			{
				short num = (short)913587942;
				short num2 = num;
				num = (short)2108571366;
				switch (num2 == num)
				{
				}
				num = (short)2062024705;
				if (num != 0)
				{
				}
				num = (short)357957632;
				if (num != 0)
				{
				}
				num = (short)911409152;
				short num3 = num;
				return this.dEKButtonIndex_A22570.Min;
			}
			set
			{
				short num = (short)157548545;
				if (num != 0)
				{
				}
				num = (short)1033893902;
				short num2 = num;
				num = (short)1310717966;
				switch (num2 == num)
				{
				}
				num = (short)1617362944;
				if (num != 0)
				{
				}
				num = (short)839516160;
				short num3 = num;
				this.dEKButtonIndex_A22570.Min = value;
			}
		}

		// Token: 0x17004075 RID: 16501
		// (get) Token: 0x06007DEE RID: 32238 RVA: 0x00742AB4 File Offset: 0x00740CB4
		// (set) Token: 0x06007DEF RID: 32239 RVA: 0x00742B68 File Offset: 0x00740D68
		internal int DEKButtonIndex_A22570Max
		{
			get
			{
				short num = (short)668804506;
				short num2 = num;
				num = (short)820651418;
				switch (num2 == num)
				{
				}
				num = (short)778174465;
				if (num != 0)
				{
				}
				num = (short)146538496;
				if (num != 0)
				{
				}
				num = (short)1265958912;
				short num3 = num;
				return this.dEKButtonIndex_A22570.Max;
			}
			set
			{
				short num = (short)1884749825;
				if (num != 0)
				{
				}
				num = (short)254349653;
				short num2 = num;
				num = (short)1313935701;
				switch (num2 == num)
				{
				}
				num = (short)1487011840;
				if (num != 0)
				{
				}
				num = (short)537526272;
				short num3 = num;
				this.dEKButtonIndex_A22570.Max = value;
			}
		}

		// Token: 0x17004076 RID: 16502
		// (get) Token: 0x06007DF0 RID: 32240 RVA: 0x00742C1C File Offset: 0x00740E1C
		// (set) Token: 0x06007DF1 RID: 32241 RVA: 0x00742CCC File Offset: 0x00740ECC
		internal int DEKButtonIndex_A22570Step
		{
			get
			{
				short num = (short)1867789341;
				short num2 = num;
				num = (short)1012544541;
				switch (num2 == num)
				{
				}
				num = (short)2067922944;
				if (num != 0)
				{
				}
				num = (short)2025193473;
				if (num != 0)
				{
				}
				num = (short)1990852608;
				short num3 = num;
				return this.dEKButtonIndex_A22570.StepSize;
			}
			set
			{
				short num = (short)309764257;
				short num2 = num;
				num = (short)672768161;
				switch (num2 == num)
				{
				}
				num = (short)1535180801;
				if (num != 0)
				{
				}
				num = (short)1420558336;
				if (num != 0)
				{
				}
				num = (short)742785024;
				short num3 = num;
				this.dEKButtonIndex_A22570.StepSize = value;
			}
		}

		// Token: 0x17004077 RID: 16503
		// (get) Token: 0x06007DF2 RID: 32242 RVA: 0x00742D84 File Offset: 0x00740F84
		// (set) Token: 0x06007DF3 RID: 32243 RVA: 0x00742E38 File Offset: 0x00741038
		public bool DEKButtonIndex_A22570_Applicable
		{
			get
			{
				short num = (short)792302164;
				short num2 = num;
				num = (short)464097876;
				switch (num2 == num)
				{
				}
				num = (short)1497563136;
				if (num != 0)
				{
				}
				num = (short)1694433281;
				if (num != 0)
				{
				}
				num = (short)1702559744;
				short num3 = num;
				return this.dEKButtonIndex_A22570.Applicable;
			}
			set
			{
				short num = (short)1989230248;
				short num2 = num;
				num = (short)871186088;
				switch (num2 == num)
				{
				}
				num = (short)956956672;
				if (num != 0)
				{
				}
				num = (short)1055522817;
				if (num != 0)
				{
				}
				num = (short)1300496384;
				short num3 = num;
				this.dEKButtonIndex_A22570.Applicable = value;
			}
		}

		// Token: 0x17004078 RID: 16504
		// (get) Token: 0x06007DF4 RID: 32244 RVA: 0x00742EF0 File Offset: 0x007410F0
		// (set) Token: 0x06007DF5 RID: 32245 RVA: 0x00742FA4 File Offset: 0x007411A4
		public bool DEKButtonIndex_A22570_Valid
		{
			get
			{
				short num = (short)1209991169;
				if (num != 0)
				{
				}
				num = (short)1803797839;
				short num2 = num;
				num = (short)1977075023;
				switch (num2 == num)
				{
				}
				num = (short)701759488;
				if (num != 0)
				{
				}
				num = (short)841023488;
				short num3 = num;
				return this.dEKButtonIndex_A22570.Valid;
			}
			set
			{
				short num = (short)1476470380;
				short num2 = num;
				num = (short)558638700;
				switch (num2 == num)
				{
				}
				num = (short)1782185984;
				if (num != 0)
				{
				}
				num = (short)1663369217;
				if (num != 0)
				{
				}
				num = (short)192806912;
				short num3 = num;
				this.dEKButtonIndex_A22570.Valid = value;
			}
		}

		// Token: 0x17004079 RID: 16505
		// (get) Token: 0x06007DF6 RID: 32246 RVA: 0x00743058 File Offset: 0x00741258
		// (set) Token: 0x06007DF7 RID: 32247 RVA: 0x0074310C File Offset: 0x0074130C
		public bool DEKButtonIndex_A22570_Visible
		{
			get
			{
				short num = (short)21647374;
				short num2 = num;
				num = (short)2018856974;
				switch (num2 == num)
				{
				}
				num = (short)1817444353;
				if (num != 0)
				{
				}
				num = (short)1300037632;
				if (num != 0)
				{
				}
				num = (short)76808192;
				short num3 = num;
				return this.dEKButtonIndex_A22570.Visible;
			}
			set
			{
				short num = (short)1167589377;
				if (num != 0)
				{
				}
				num = (short)1035917102;
				short num2 = num;
				num = (short)1698748206;
				switch (num2 == num)
				{
				}
				num = (short)15663104;
				if (num != 0)
				{
				}
				num = (short)1276444672;
				short num3 = num;
				this.dEKButtonIndex_A22570.Visible = value;
			}
		}

		// Token: 0x1700407A RID: 16506
		// (get) Token: 0x06007DF8 RID: 32248 RVA: 0x007431C0 File Offset: 0x007413C0
		// (set) Token: 0x06007DF9 RID: 32249 RVA: 0x00743274 File Offset: 0x00741474
		public bool DEKButtonIndex_A22570_Editable
		{
			get
			{
				short num = (short)1064932319;
				short num2 = num;
				num = (short)1900385247;
				switch (num2 == num)
				{
				}
				num = (short)18087936;
				if (num != 0)
				{
				}
				num = (short)1057423361;
				if (num != 0)
				{
				}
				num = (short)1666056192;
				short num3 = num;
				return this.dEKButtonIndex_A22570.Editable;
			}
			set
			{
				short num = (short)722665473;
				if (num != 0)
				{
				}
				num = (short)1243201712;
				short num2 = num;
				num = (short)980336816;
				switch (num2 == num)
				{
				}
				num = (short)1159987200;
				if (num != 0)
				{
				}
				num = (short)483065856;
				short num3 = num;
				this.dEKButtonIndex_A22570.Editable = value;
			}
		}

		// Token: 0x1700407B RID: 16507
		// (get) Token: 0x06007DFA RID: 32250 RVA: 0x0074332C File Offset: 0x0074152C
		internal string DEKButtonIndex_A22570_UILabel
		{
			get
			{
				short num = (short)1218437123;
				short num2 = num;
				num = (short)325771267;
				switch (num2 == num)
				{
				}
				num = (short)314376193;
				if (num != 0)
				{
				}
				num = (short)349306880;
				if (num != 0)
				{
				}
				num = (short)1621360640;
				short num3 = num;
				return this.dEKButtonIndex_A22570.UIName;
			}
		}

		// Token: 0x1700407C RID: 16508
		// (get) Token: 0x06007DFB RID: 32251 RVA: 0x007433DC File Offset: 0x007415DC
		// (set) Token: 0x06007DFC RID: 32252 RVA: 0x00743490 File Offset: 0x00741690
		internal bool DEKButtonIndex_A22570_HiddenStatic
		{
			get
			{
				short num = (short)1834132056;
				short num2 = num;
				num = (short)570597976;
				switch (num2 == num)
				{
				}
				num = (short)936902656;
				if (num != 0)
				{
				}
				num = (short)1624899585;
				if (num != 0)
				{
				}
				num = (short)143720448;
				short num3 = num;
				return this.dEKButtonIndex_A22570.HiddenStatic;
			}
			set
			{
				short num = (short)1614020609;
				if (num != 0)
				{
				}
				num = (short)625882587;
				short num2 = num;
				num = (short)958346715;
				switch (num2 == num)
				{
				}
				num = (short)655622144;
				if (num != 0)
				{
				}
				num = (short)892272640;
				short num3 = num;
				this.dEKButtonIndex_A22570.HiddenStatic = value;
			}
		}

		// Token: 0x1700407D RID: 16509
		// (get) Token: 0x06007DFD RID: 32253 RVA: 0x00743544 File Offset: 0x00741744
		// (set) Token: 0x06007DFE RID: 32254 RVA: 0x007435F8 File Offset: 0x007417F8
		internal bool DEKButtonIndex_A22570_HiddenDynamic
		{
			get
			{
				short num = (short)464828604;
				short num2 = num;
				num = (short)1871034556;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27656192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541917184;
				if (num != 0)
				{
				}
				num = (short)1291452417;
				if (num != 0)
				{
				}
				return this.dEKButtonIndex_A22570.HiddenDynamic;
			}
			set
			{
				short num = (short)137949161;
				short num2 = num;
				num = (short)1319890921;
				switch (num2 == num)
				{
				default:
				{
					num = (short)655294464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1232863233;
				if (num != 0)
				{
				}
				num = (short)1755643904;
				if (num != 0)
				{
				}
				this.dEKButtonIndex_A22570.HiddenDynamic = value;
			}
		}

		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x06007DFF RID: 32255 RVA: 0x007436B0 File Offset: 0x007418B0
		public bool DEKButtonIndex_A22570_HasDiffs
		{
			get
			{
				short num = (short)502361756;
				short num2 = num;
				num = (short)231435932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1669660672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1635909633;
				if (num != 0)
				{
				}
				num = (short)1334640640;
				if (num != 0)
				{
				}
				return this.dEKButtonIndex_A22570._HasDiffs;
			}
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x06007E00 RID: 32256 RVA: 0x00743764 File Offset: 0x00741964
		// (set) Token: 0x06007E01 RID: 32257 RVA: 0x0074381C File Offset: 0x00741A1C
		public int DEKButtonShortPressTimeValue
		{
			get
			{
				short num = (short)891551745;
				if (num != 0)
				{
				}
				num = (short)1514340352;
				short num2 = num;
				num = (short)708459231;
				short num3 = num;
				num = (short)1154038495;
				switch (num3 == num)
				{
				}
				num = (short)1500053504;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)326107137;
				if (num != 0)
				{
				}
				num = (short)1737293824;
				short num2 = num;
				num = (short)559728750;
				short num3 = num;
				num = (short)1485949038;
				switch (num3 == num)
				{
				}
				num = (short)880607232;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.Value = value;
			}
		}

		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x06007E02 RID: 32258 RVA: 0x007438D0 File Offset: 0x00741AD0
		// (set) Token: 0x06007E03 RID: 32259 RVA: 0x00743984 File Offset: 0x00741B84
		public string DEKButtonShortPressTime_UIValue
		{
			get
			{
				short num = (short)2003746718;
				short num2 = num;
				num = (short)1838989214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1839661056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847183873;
				if (num != 0)
				{
				}
				num = (short)1320222720;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.UIValue;
			}
			set
			{
				short num = (short)1299579345;
				short num2 = num;
				num = (short)673841617;
				switch (num2 == num)
				{
				default:
				{
					num = (short)247463936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717094913;
				if (num != 0)
				{
				}
				num = (short)288489472;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x06007E04 RID: 32260 RVA: 0x00743A3C File Offset: 0x00741C3C
		public global::AcpBusinessLayer.AcpSimpleRangeField DEKButtonShortPressTime
		{
			get
			{
				short num = (short)128379572;
				short num2 = num;
				num = (short)1879173812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110690304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379453440;
				if (num != 0)
				{
				}
				num = (short)1009123329;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime;
			}
		}

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x06007E05 RID: 32261 RVA: 0x00743AEC File Offset: 0x00741CEC
		// (set) Token: 0x06007E06 RID: 32262 RVA: 0x00743BA0 File Offset: 0x00741DA0
		internal int DEKButtonShortPressTimeMin
		{
			get
			{
				short num = (short)1672216577;
				if (num != 0)
				{
				}
				num = (short)1218445312;
				short num2 = num;
				num = (short)459005203;
				short num3 = num;
				num = (short)1265556755;
				switch (num3 == num)
				{
				}
				num = (short)1610416128;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.Min;
			}
			set
			{
				short num = (short)1114517393;
				short num2 = num;
				num = (short)978726801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118516736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900085248;
				if (num != 0)
				{
				}
				num = (short)1647837185;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.Min = value;
			}
		}

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x00743C54 File Offset: 0x00741E54
		// (set) Token: 0x06007E08 RID: 32264 RVA: 0x00743D0C File Offset: 0x00741F0C
		internal int DEKButtonShortPressTimeMax
		{
			get
			{
				short num = (short)143871938;
				short num2 = num;
				num = (short)1610698690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1227489280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)280821761;
				if (num != 0)
				{
				}
				num = (short)96206848;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.Max;
			}
			set
			{
				short num = (short)343994804;
				short num2 = num;
				num = (short)587526580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1188626432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706688513;
				if (num != 0)
				{
				}
				num = (short)2063400960;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.Max = value;
			}
		}

		// Token: 0x17004084 RID: 16516
		// (get) Token: 0x06007E09 RID: 32265 RVA: 0x00743DC0 File Offset: 0x00741FC0
		// (set) Token: 0x06007E0A RID: 32266 RVA: 0x00743E78 File Offset: 0x00742078
		internal int DEKButtonShortPressTimeStep
		{
			get
			{
				short num = (short)294543045;
				short num2 = num;
				num = (short)1986813637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)62783488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)799539201;
				if (num != 0)
				{
				}
				num = (short)332005376;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.StepSize;
			}
			set
			{
				short num = (short)1543251698;
				short num2 = num;
				num = (short)1913726706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)892010496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)287703041;
				if (num != 0)
				{
				}
				num = (short)862453760;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.StepSize = value;
			}
		}

		// Token: 0x17004085 RID: 16517
		// (get) Token: 0x06007E0B RID: 32267 RVA: 0x00743F2C File Offset: 0x0074212C
		// (set) Token: 0x06007E0C RID: 32268 RVA: 0x00743FE0 File Offset: 0x007421E0
		public bool DEKButtonShortPressTime_Applicable
		{
			get
			{
				short num = (short)1290219660;
				short num2 = num;
				num = (short)480587916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1879703552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1187512321;
				if (num != 0)
				{
				}
				num = (short)1826291712;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.Applicable;
			}
			set
			{
				short num = (short)152004563;
				short num2 = num;
				num = (short)754083795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1199767552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2050883585;
				if (num != 0)
				{
				}
				num = (short)853409792;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17004086 RID: 16518
		// (get) Token: 0x06007E0D RID: 32269 RVA: 0x00744098 File Offset: 0x00742298
		// (set) Token: 0x06007E0E RID: 32270 RVA: 0x0074414C File Offset: 0x0074234C
		public bool DEKButtonShortPressTime_Valid
		{
			get
			{
				short num = (short)255639675;
				short num2 = num;
				num = (short)251510907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)831389696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)72024065;
				if (num != 0)
				{
				}
				num = (short)1546780672;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.Valid;
			}
			set
			{
				short num = (short)82432126;
				short num2 = num;
				num = (short)2001588350;
				switch (num2 == num)
				{
				default:
				{
					num = (short)609681408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2078277633;
				if (num != 0)
				{
				}
				num = (short)955318272;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.Valid = value;
			}
		}

		// Token: 0x17004087 RID: 16519
		// (get) Token: 0x06007E0F RID: 32271 RVA: 0x00744204 File Offset: 0x00742404
		// (set) Token: 0x06007E10 RID: 32272 RVA: 0x007442B8 File Offset: 0x007424B8
		public bool DEKButtonShortPressTime_Visible
		{
			get
			{
				short num = (short)1835412536;
				short num2 = num;
				num = (short)1510681656;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1479016448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1966145537;
				if (num != 0)
				{
				}
				num = (short)1180106752;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.Visible;
			}
			set
			{
				short num = (short)10962226;
				short num2 = num;
				num = (short)186533170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075511296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687407105;
				if (num != 0)
				{
				}
				num = (short)259457024;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.Visible = value;
			}
		}

		// Token: 0x17004088 RID: 16520
		// (get) Token: 0x06007E11 RID: 32273 RVA: 0x00744370 File Offset: 0x00742570
		// (set) Token: 0x06007E12 RID: 32274 RVA: 0x00744424 File Offset: 0x00742624
		public bool DEKButtonShortPressTime_Editable
		{
			get
			{
				short num = (short)1093599233;
				if (num != 0)
				{
				}
				num = (short)1203961856;
				short num2 = num;
				num = (short)2023758383;
				short num3 = num;
				num = (short)881728047;
				switch (num3 == num)
				{
				}
				num = (short)1246625792;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.Editable;
			}
			set
			{
				short num = (short)1821849584;
				short num2 = num;
				num = (short)85080048;
				switch (num2 == num)
				{
				default:
				{
					num = (short)951320576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784596993;
				if (num != 0)
				{
				}
				num = (short)20185088;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.Editable = value;
			}
		}

		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x06007E13 RID: 32275 RVA: 0x007444D8 File Offset: 0x007426D8
		internal string DEKButtonShortPressTime_UILabel
		{
			get
			{
				short num = (short)745672563;
				short num2 = num;
				num = (short)1073942387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776273920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)67305473;
				if (num != 0)
				{
				}
				num = (short)1843462144;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.UIName;
			}
		}

		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x06007E14 RID: 32276 RVA: 0x00744590 File Offset: 0x00742790
		// (set) Token: 0x06007E15 RID: 32277 RVA: 0x00744644 File Offset: 0x00742844
		internal bool DEKButtonShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)510085110;
				short num2 = num;
				num = (short)250693622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)376897536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1933443073;
				if (num != 0)
				{
				}
				num = (short)744554496;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)2025727407;
				short num2 = num;
				num = (short)1398678959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1422327808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)540934144;
				if (num != 0)
				{
				}
				num = (short)466944001;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x06007E16 RID: 32278 RVA: 0x007446FC File Offset: 0x007428FC
		// (set) Token: 0x06007E17 RID: 32279 RVA: 0x007447B0 File Offset: 0x007429B0
		internal bool DEKButtonShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)498076730;
				short num2 = num;
				num = (short)258935866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)926679040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)483065857;
				if (num != 0)
				{
				}
				num = (short)1157758976;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)763279446;
				short num2 = num;
				num = (short)1475524694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036203520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438056449;
				if (num != 0)
				{
				}
				num = (short)1594818560;
				if (num != 0)
				{
				}
				this.dEKButtonShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x06007E18 RID: 32280 RVA: 0x00744864 File Offset: 0x00742A64
		public bool DEKButtonShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)828308888;
				short num2 = num;
				num = (short)1423768984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)221184000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1020461057;
				if (num != 0)
				{
				}
				num = (short)1316225024;
				if (num != 0)
				{
				}
				return this.dEKButtonShortPressTime._HasDiffs;
			}
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x06007E19 RID: 32281 RVA: 0x00744918 File Offset: 0x00742B18
		// (set) Token: 0x06007E1A RID: 32282 RVA: 0x007449CC File Offset: 0x00742BCC
		public int DEKButtonLongPressTimeValue
		{
			get
			{
				short num = (short)1050823803;
				short num2 = num;
				num = (short)460737659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)350552064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)10682368;
				if (num != 0)
				{
				}
				num = (short)1545273345;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.Value;
			}
			set
			{
				short num = (short)670564353;
				if (num != 0)
				{
				}
				num = (short)1044578304;
				short num2 = num;
				num = (short)281027150;
				short num3 = num;
				num = (short)1740841550;
				switch (num3 == num)
				{
				}
				num = (short)942669824;
				if (num != 0)
				{
				}
				this.dEKButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x1700408E RID: 16526
		// (get) Token: 0x06007E1B RID: 32283 RVA: 0x00744A84 File Offset: 0x00742C84
		// (set) Token: 0x06007E1C RID: 32284 RVA: 0x00744B38 File Offset: 0x00742D38
		public string DEKButtonLongPressTime_UIValue
		{
			get
			{
				short num = (short)394971189;
				short num2 = num;
				num = (short)2085406773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)986710016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1843134465;
				if (num != 0)
				{
				}
				num = (short)1138163712;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.UIValue;
			}
			set
			{
				short num = (short)850561772;
				short num2 = num;
				num = (short)400132844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135804416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)76873729;
				if (num != 0)
				{
				}
				num = (short)1736572928;
				if (num != 0)
				{
				}
				this.dEKButtonLongPressTime.UIValue = value;
			}
		}

		// Token: 0x1700408F RID: 16527
		// (get) Token: 0x06007E1D RID: 32285 RVA: 0x00744BEC File Offset: 0x00742DEC
		public global::AcpBusinessLayer.AcpCustomRangeField DEKButtonLongPressTime
		{
			get
			{
				short num = (short)838498222;
				short num2 = num;
				num = (short)1771468718;
				switch (num2 == num)
				{
				default:
				{
					num = (short)644022272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2093154305;
				if (num != 0)
				{
				}
				num = (short)135462912;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime;
			}
		}

		// Token: 0x17004090 RID: 16528
		// (get) Token: 0x06007E1E RID: 32286 RVA: 0x00744C9C File Offset: 0x00742E9C
		// (set) Token: 0x06007E1F RID: 32287 RVA: 0x00744D50 File Offset: 0x00742F50
		public bool DEKButtonLongPressTime_Applicable
		{
			get
			{
				short num = (short)1390147607;
				short num2 = num;
				num = (short)1911814167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618528768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1215758336;
				if (num != 0)
				{
				}
				num = (short)1603469313;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.Applicable;
			}
			set
			{
				short num = (short)1766668905;
				short num2 = num;
				num = (short)455883369;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1489305600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)321454081;
				if (num != 0)
				{
				}
				num = (short)370343936;
				if (num != 0)
				{
				}
				this.dEKButtonLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17004091 RID: 16529
		// (get) Token: 0x06007E20 RID: 32288 RVA: 0x00744E08 File Offset: 0x00743008
		// (set) Token: 0x06007E21 RID: 32289 RVA: 0x00744EBC File Offset: 0x007430BC
		public bool DEKButtonLongPressTime_Valid
		{
			get
			{
				short num = (short)83694826;
				short num2 = num;
				num = (short)1654789354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2060451840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)713228288;
				if (num != 0)
				{
				}
				num = (short)1771372545;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.Valid;
			}
			set
			{
				short num = (short)226304387;
				short num2 = num;
				num = (short)1314988419;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377094144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)982122497;
				if (num != 0)
				{
				}
				num = (short)1104871424;
				if (num != 0)
				{
				}
				this.dEKButtonLongPressTime.Valid = value;
			}
		}

		// Token: 0x17004092 RID: 16530
		// (get) Token: 0x06007E22 RID: 32290 RVA: 0x00744F70 File Offset: 0x00743170
		// (set) Token: 0x06007E23 RID: 32291 RVA: 0x00745024 File Offset: 0x00743224
		public bool DEKButtonLongPressTime_Visible
		{
			get
			{
				short num = (short)1651894611;
				short num2 = num;
				num = (short)450619731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)728760320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)912588800;
				if (num != 0)
				{
				}
				num = (short)594083841;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.Visible;
			}
			set
			{
				short num = (short)139919361;
				if (num != 0)
				{
				}
				num = (short)1046085632;
				short num2 = num;
				num = (short)1807775351;
				short num3 = num;
				num = (short)670791287;
				switch (num3 == num)
				{
				}
				num = (short)1008009216;
				if (num != 0)
				{
				}
				this.dEKButtonLongPressTime.Visible = value;
			}
		}

		// Token: 0x17004093 RID: 16531
		// (get) Token: 0x06007E24 RID: 32292 RVA: 0x007450DC File Offset: 0x007432DC
		// (set) Token: 0x06007E25 RID: 32293 RVA: 0x00745190 File Offset: 0x00743390
		public bool DEKButtonLongPressTime_Editable
		{
			get
			{
				short num = (short)2053912687;
				short num2 = num;
				num = (short)1947154543;
				switch (num2 == num)
				{
				default:
				{
					num = (short)243204096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1500315649;
				if (num != 0)
				{
				}
				num = (short)833355776;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.Editable;
			}
			set
			{
				short num = (short)1119158273;
				if (num != 0)
				{
				}
				num = (short)1709834240;
				short num2 = num;
				num = (short)1868112840;
				short num3 = num;
				num = (short)225321928;
				switch (num3 == num)
				{
				}
				num = (short)1602420736;
				if (num != 0)
				{
				}
				this.dEKButtonLongPressTime.Editable = value;
			}
		}

		// Token: 0x17004094 RID: 16532
		// (get) Token: 0x06007E26 RID: 32294 RVA: 0x00745244 File Offset: 0x00743444
		internal string DEKButtonLongPressTime_UILabel
		{
			get
			{
				short num = (short)490874528;
				short num2 = num;
				num = (short)794633888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)704512000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526450689;
				if (num != 0)
				{
				}
				num = (short)1748500480;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.UIName;
			}
		}

		// Token: 0x17004095 RID: 16533
		// (get) Token: 0x06007E27 RID: 32295 RVA: 0x007452F8 File Offset: 0x007434F8
		// (set) Token: 0x06007E28 RID: 32296 RVA: 0x007453AC File Offset: 0x007435AC
		internal bool DEKButtonLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)2100254474;
				short num2 = num;
				num = (short)954095370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)385941504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)558628864;
				if (num != 0)
				{
				}
				num = (short)417857537;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)507998480;
				short num2 = num;
				num = (short)453210384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)342097920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1429078017;
				if (num != 0)
				{
				}
				num = (short)220332032;
				if (num != 0)
				{
				}
				this.dEKButtonLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004096 RID: 16534
		// (get) Token: 0x06007E29 RID: 32297 RVA: 0x00745464 File Offset: 0x00743664
		// (set) Token: 0x06007E2A RID: 32298 RVA: 0x0074551C File Offset: 0x0074371C
		internal bool DEKButtonLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1357250561;
				if (num != 0)
				{
				}
				num = (short)1590558720;
				short num2 = num;
				num = (short)352404114;
				short num3 = num;
				num = (short)1157513874;
				switch (num3 == num)
				{
				}
				num = (short)1691811840;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1554926835;
				short num2 = num;
				num = (short)1144212723;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101594624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1535770625;
				if (num != 0)
				{
				}
				num = (short)1492844544;
				if (num != 0)
				{
				}
				this.dEKButtonLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004097 RID: 16535
		// (get) Token: 0x06007E2B RID: 32299 RVA: 0x007455D0 File Offset: 0x007437D0
		public bool DEKButtonLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)1963222666;
				short num2 = num;
				num = (short)1691117194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1643708416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1414004736;
				if (num != 0)
				{
				}
				num = (short)1636368385;
				if (num != 0)
				{
				}
				return this.dEKButtonLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17004098 RID: 16536
		// (get) Token: 0x06007E2C RID: 32300 RVA: 0x00745688 File Offset: 0x00743888
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)269090681;
				short num2 = num;
				num = (short)1435893625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)850460672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)447283200;
				if (num != 0)
				{
				}
				num = (short)452132865;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x17004099 RID: 16537
		// (get) Token: 0x06007E2D RID: 32301 RVA: 0x00745744 File Offset: 0x00743944
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1062993920;
				short num2 = num;
				num = (short)1425612674;
				short num3 = num;
				num = (short)1397104514;
				switch (num3 == num)
				{
				}
				num = (short)874971137;
				if (num != 0)
				{
				}
				num = (short)80478208;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x00745804 File Offset: 0x00743A04
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
					if (base.ParentRecset != null)
					{
						num2 = (short)433717252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_D4;
				case 2:
					num2 = (short)58654721;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1354432512;
						short num3 = num2;
						num2 = (short)1750728707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_168;
				case 4:
					num2 = (short)2121465858;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_D4:
			return result;
			IL_168:
			result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
			goto IL_BD;
			IL_24:
			num2 = (short)115240795;
			short num4 = num2;
			num2 = (short)1651732315;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BD:
				num2 = (short)452460545;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2068840448;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)1910833152;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04003988 RID: 14728
		private global::AcpBusinessLayer.AcpListField dEKButtonBCO_A21352;

		// Token: 0x04003989 RID: 14729
		private global::AcpBusinessLayer.AcpListField dEKButtonFeature_A21353;

		// Token: 0x0400398A RID: 14730
		private global::AcpBusinessLayer.AcpRecRefField dEKChannel_A22565;

		// Token: 0x0400398B RID: 14731
		private global::AcpBusinessLayer.AcpRecRefField dEKZone_A22566;

		// Token: 0x0400398C RID: 14732
		private global::AcpBusinessLayer.AcpField<string> dEKButtonName_A22568;

		// Token: 0x0400398D RID: 14733
		private global::AcpBusinessLayer.AcpKeyField dEKButtonKey_A22569;

		// Token: 0x0400398E RID: 14734
		private global::AcpBusinessLayer.AcpRangeField<int, int> dEKButtonIndex_A22570;

		// Token: 0x0400398F RID: 14735
		private global::AcpBusinessLayer.AcpSimpleRangeField dEKButtonShortPressTime;

		// Token: 0x04003990 RID: 14736
		private global::AcpBusinessLayer.AcpCustomRangeField dEKButtonLongPressTime;
	}
}
