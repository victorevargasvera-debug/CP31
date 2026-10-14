using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000345 RID: 837
	[global::System.Serializable]
	public class BottomFunctionButtonBCOListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008033 RID: 32819 RVA: 0x0075D488 File Offset: 0x0075B688
		public BottomFunctionButtonBCOListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x0075D4A4 File Offset: 0x0075B6A4
		protected BottomFunctionButtonBCOListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008035 RID: 32821 RVA: 0x0075D4BC File Offset: 0x0075B6BC
		public override void Init()
		{
			int a_ = 2;
			short num = (short)480682550;
			short num2 = num;
			num = (short)798925366;
			switch (num2 == num)
			{
			}
			num = (short)1917845504;
			if (num != 0)
			{
			}
			num = (short)1460404224;
			short num3 = num;
			num = (short)34340865;
			if (num != 0)
			{
			}
			this.cHO9BottomFunctionButtonBCO_A36827 = new global::AcpBusinessLayer.AcpSparseLOVField(165, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9BottomFunctionButtonBCO_A36827LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9BottomFunctionButtonBCO_A36827LovStrs), this, global::AllFeatures.CodeplugGuid.b("胂跄裆觊ꋌ믎ꗐ볒룔釖곘뗚뻜ꯞ裠賢诤ꗦ鳨鿪駬胮鿰뇲뛴룶꛸뫺컼짾㤀㄂㈄", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9BottomFunctionButtonBCO_A36827LovStrs);
			this.cHO9BottomFunctionButtonBCO_A36827.IgnoreOnCompare = true;
			this.cHO9BottomFunctionButtonBCO_A36827.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9BottomFunctionButtonBCO_A36827.DataTransferOrder = -1;
			this.cHO9BottomFunctionButtonFeature_A36826 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9BottomFunctionButtonFeature_A36826LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9BottomFunctionButtonFeature_A36826LovStrs), this, global::AllFeatures.CodeplugGuid.b("胂跄裆觊ꋌ믎ꗐ볒룔釖곘뗚뻜ꯞ裠賢诤ꗦ鳨鿪駬胮鿰뗲郴零跸軺迼髾帀䈂㘄ㄆㄈ㤊㬌", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9BottomFunctionButtonFeature_A36826LovStrs);
			this.cHO9BottomFunctionButtonFeature_A36826.IgnoreOnCompare = true;
			this.cHO9BottomFunctionButtonFeature_A36826.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9BottomFunctionButtonFeature_A36826.DataTransferOrder = -1;
			this.pgrmbleO9BottomShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鏂苄闆蓈觊臌諎黐韔룖귘꿚닜닞닠询諤闦鷨믪鿬諮苰胲ꇴ黶铸黺", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.pgrmbleO9BottomShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.pgrmbleO9BottomShortPressTime.DataTransferOrder = -1;
			this.pgrmbleO9BottomShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.pgrmbleO9BottomShortPressTime.ShowHexValue = false;
			this.pgrmbleO9BottomShortPressTime.ValidateAcrossRecset = true;
			this.pgrmbleO9BottomLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鏂苄闆蓈觊臌諎黐韔룖귘꿚닜닞균賢诤胦맨駪裬鳮苰ꟲ鳴髶鳸", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.pgrmbleO9BottomLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.pgrmbleO9BottomLongPressTime.DataTransferOrder = -1;
			this.pgrmbleO9BottomLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.pgrmbleO9BottomLongPressTime.ShowHexValue = false;
			this.pgrmbleO9BottomLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臂꫄돆뷈꓊ꃌ韐ꛒ믔듖귘닚닜뇞쇠ꇢ郤鏦鷨蓪菬쿮돰냲뫴ퟶ뗸鋺軼课", a_);
			base.Id = 10629;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONBUTTONBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008036 RID: 32822 RVA: 0x0075D73C File Offset: 0x0075B93C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)446693382;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏂苄闆蓈觊臌諎黐韔룖귘꿚닜닞균賢诤胦맨駪裬鳮苰ꟲ鳴髶鳸", a_)))
					{
						num = (short)1110179854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AD;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂跄裆觊ꋌ믎ꗐ볒룔釖곘뗚뻜ꯞ裠賢诤ꗦ鳨鿪駬胮鿰뇲뛴룶꛸뫺컼짾㤀㄂㈄", a_)))
					{
						num = (short)61865993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E7;
				case 2:
					goto IL_285;
				case 3:
					this.cHO9BottomFunctionButtonFeature_A36826 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9BottomFunctionButtonFeature_A36826LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9BottomFunctionButtonFeature_A36826LovStrs), this, global::AllFeatures.CodeplugGuid.b("胂跄裆觊ꋌ믎ꗐ볒룔釖곘뗚뻜ꯞ裠賢诤ꗦ鳨鿪駬胮鿰뗲郴零跸軺迼髾帀䈂㘄ㄆㄈ㤊㬌", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9BottomFunctionButtonFeature_A36826LovStrs);
					this.cHO9BottomFunctionButtonFeature_A36826.IgnoreOnCompare = true;
					this.cHO9BottomFunctionButtonFeature_A36826.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO9BottomFunctionButtonFeature_A36826.DataTransferOrder = -1;
					num = (short)1891368975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_3E2;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胂跄裆觊ꋌ믎ꗐ볒룔釖곘뗚뻜ꯞ裠賢诤ꗦ鳨鿪駬胮鿰뗲郴零跸軺迼髾帀䈂㘄ㄆㄈ㤊㬌", a_)))
					{
						num = (short)1931280387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30A;
				case 6:
					num = (short)51445761;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_94;
					}
					continue;
				case 7:
					if (producerFields != null)
					{
						num = (short)1075642376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AD;
				case 8:
					num = (short)985071617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					this.cHO9BottomFunctionButtonBCO_A36827 = new global::AcpBusinessLayer.AcpSparseLOVField(165, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9BottomFunctionButtonBCO_A36827LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9BottomFunctionButtonBCO_A36827LovStrs), this, global::AllFeatures.CodeplugGuid.b("胂跄裆觊ꋌ믎ꗐ볒룔釖곘뗚뻜ꯞ裠賢诤ꗦ鳨鿪駬胮鿰뇲뛴룶꛸뫺컼짾㤀㄂㈄", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9BottomFunctionButtonBCO_A36827LovStrs);
					this.cHO9BottomFunctionButtonBCO_A36827.IgnoreOnCompare = true;
					this.cHO9BottomFunctionButtonBCO_A36827.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO9BottomFunctionButtonBCO_A36827.DataTransferOrder = -1;
					num = (short)485818381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1083011304;
					short num3 = num;
					num = (short)844853480;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1230176256;
						if (num != 0)
						{
						}
						this.pgrmbleO9BottomShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鏂苄闆蓈觊臌諎黐韔룖귘꿚닜닞닠询諤闦鷨믪鿬諮苰胲ꇴ黶铸黺", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
						this.pgrmbleO9BottomShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.pgrmbleO9BottomShortPressTime.DataTransferOrder = -1;
						this.pgrmbleO9BottomShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
						this.pgrmbleO9BottomShortPressTime.ShowHexValue = false;
						this.pgrmbleO9BottomShortPressTime.ValidateAcrossRecset = true;
						num = (short)1278345218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏂苄闆蓈觊臌諎黐韔룖귘꿚닜닞닠询諤闦鷨믪鿬諮苰胲ꇴ黶铸黺", a_)))
					{
						num = (short)99418122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_285;
				case 12:
					num = (short)1247215623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_3E7;
				case 14:
					this.pgrmbleO9BottomLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鏂苄闆蓈觊臌諎黐韔룖귘꿚닜닞균賢诤胦맨駪裬鳮苰ꟲ鳴髶鳸", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.pgrmbleO9BottomLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.pgrmbleO9BottomLongPressTime.DataTransferOrder = -1;
					this.pgrmbleO9BottomLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.pgrmbleO9BottomLongPressTime.ShowHexValue = false;
					this.pgrmbleO9BottomLongPressTime.ValidateAcrossRecset = true;
					num = (short)1401028612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_30A;
				}
				IL_94:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)364904448;
					short num4 = num;
					num = (short)183566348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_285:
				num = (short)1426456576;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30A:
				num = (short)150601739;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E7:
				num = (short)258277381;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3E2:
			IL_4AD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臂꫄돆뷈꓊ꃌ韐ꛒ믔듖귘닚닜뇞쇠ꇢ郤鏦鷨蓪菬쿮돰냲뫴ퟶ뗸鋺軼课", a_);
			base.Id = 10629;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONBUTTONBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008037 RID: 32823 RVA: 0x0075DC28 File Offset: 0x0075BE28
		public override void PopulateReferences()
		{
			short num = (short)1193521453;
			short num2 = num;
			num = (short)1301852461;
			switch (num2 == num)
			{
			}
			num = (short)399704065;
			if (num != 0)
			{
			}
			num = (short)816119808;
			short num3 = num;
			num = (short)396099584;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008038 RID: 32824 RVA: 0x0075DCD0 File Offset: 0x0075BED0
		public override void DropReferences()
		{
			short num = (short)170786817;
			if (num != 0)
			{
			}
			num = (short)977452608;
			short num2 = num;
			num = (short)1603190336;
			switch (num2 == num)
			{
			}
			num = (short)1020067840;
			short num3 = num;
			num = (short)713424896;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008039 RID: 32825 RVA: 0x0075DD7C File Offset: 0x0075BF7C
		public override void SetConstraints()
		{
			short num = (short)1266366298;
			short num2 = num;
			num = (short)289421146;
			switch (num2 == num)
			{
			}
			num = (short)23724033;
			if (num != 0)
			{
			}
			num = (short)1301610496;
			short num3 = num;
			num = (short)1873805312;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600803A RID: 32826 RVA: 0x0075DE24 File Offset: 0x0075C024
		public override void SetupDependencies()
		{
			short num = (short)1799807654;
			short num2 = num;
			num = (short)1753211558;
			switch (num2 == num)
			{
			}
			num = (short)876740609;
			if (num != 0)
			{
			}
			num = (short)1030488064;
			short num3 = num;
			num = (short)66912256;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x0600803B RID: 32827 RVA: 0x0075DECC File Offset: 0x0075C0CC
		public bool HasDiffs
		{
			get
			{
				short num = (short)2015780951;
				short num2 = num;
				num = (short)707747927;
				switch (num2 == num)
				{
				}
				num = (short)2043674625;
				if (num != 0)
				{
				}
				num = (short)345178112;
				short num3 = num;
				num = (short)900136960;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x0600803C RID: 32828 RVA: 0x0075DF7C File Offset: 0x0075C17C
		// (set) Token: 0x0600803D RID: 32829 RVA: 0x0075E034 File Offset: 0x0075C234
		public int CHO9BottomFunctionButtonBCO_A36827Value
		{
			get
			{
				short num = (short)812496350;
				short num2 = num;
				num = (short)390051294;
				switch (num2 == num)
				{
				}
				num = (short)1272643585;
				if (num != 0)
				{
				}
				num = (short)1059258368;
				short num3 = num;
				num = (short)1548943360;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.Value;
			}
			set
			{
				short num = (short)1064378248;
				short num2 = num;
				num = (short)899227528;
				switch (num2 == num)
				{
				}
				num = (short)2102984704;
				if (num != 0)
				{
				}
				num = (short)688193536;
				short num3 = num;
				num = (short)1836122113;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36827.Value = value;
			}
		}

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x0600803E RID: 32830 RVA: 0x0075E0E8 File Offset: 0x0075C2E8
		// (set) Token: 0x0600803F RID: 32831 RVA: 0x0075E19C File Offset: 0x0075C39C
		public string CHO9BottomFunctionButtonBCO_A36827_UIValue
		{
			get
			{
				short num = (short)180537963;
				short num2 = num;
				num = (short)1028049515;
				switch (num2 == num)
				{
				}
				num = (short)131073;
				if (num != 0)
				{
				}
				num = (short)62586880;
				short num3 = num;
				num = (short)1707606016;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.UIValue;
			}
			set
			{
				short num = (short)762663367;
				short num2 = num;
				num = (short)1581928903;
				switch (num2 == num)
				{
				}
				num = (short)1207369729;
				if (num != 0)
				{
				}
				num = (short)479723520;
				short num3 = num;
				num = (short)1070792704;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36827.UIValue = value;
			}
		}

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x06008040 RID: 32832 RVA: 0x0075E254 File Offset: 0x0075C454
		public global::AcpBusinessLayer.AcpListField CHO9BottomFunctionButtonBCO_A36827
		{
			get
			{
				short num = (short)2071737637;
				short num2 = num;
				num = (short)621491493;
				switch (num2 == num)
				{
				}
				num = (short)1177354241;
				if (num != 0)
				{
				}
				num = (short)2011365376;
				short num3 = num;
				num = (short)967376896;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827;
			}
		}

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x06008041 RID: 32833 RVA: 0x0075E304 File Offset: 0x0075C504
		// (set) Token: 0x06008042 RID: 32834 RVA: 0x0075E3BC File Offset: 0x0075C5BC
		public bool CHO9BottomFunctionButtonBCO_A36827_Applicable
		{
			get
			{
				short num = (short)2065275728;
				short num2 = num;
				num = (short)1267833680;
				switch (num2 == num)
				{
				}
				num = (short)456589313;
				if (num != 0)
				{
				}
				num = (short)1277689856;
				short num3 = num;
				num = (short)1610612736;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.Applicable;
			}
			set
			{
				short num = (short)601486622;
				short num2 = num;
				num = (short)1980101918;
				switch (num2 == num)
				{
				}
				num = (short)697761792;
				if (num != 0)
				{
				}
				num = (short)1479147520;
				short num3 = num;
				num = (short)293470209;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36827.Applicable = value;
			}
		}

		// Token: 0x1700418F RID: 16783
		// (get) Token: 0x06008043 RID: 32835 RVA: 0x0075E474 File Offset: 0x0075C674
		// (set) Token: 0x06008044 RID: 32836 RVA: 0x0075E52C File Offset: 0x0075C72C
		public bool CHO9BottomFunctionButtonBCO_A36827_Valid
		{
			get
			{
				short num = (short)2107695804;
				short num2 = num;
				num = (short)418046652;
				switch (num2 == num)
				{
				}
				num = (short)1674248193;
				if (num != 0)
				{
				}
				num = (short)1166409728;
				short num3 = num;
				num = (short)1953890304;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.Valid;
			}
			set
			{
				short num = (short)1148051884;
				short num2 = num;
				num = (short)134930860;
				switch (num2 == num)
				{
				}
				num = (short)285016065;
				if (num != 0)
				{
				}
				num = (short)211419136;
				short num3 = num;
				num = (short)587726848;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36827.Valid = value;
			}
		}

		// Token: 0x17004190 RID: 16784
		// (get) Token: 0x06008045 RID: 32837 RVA: 0x0075E5E4 File Offset: 0x0075C7E4
		// (set) Token: 0x06008046 RID: 32838 RVA: 0x0075E698 File Offset: 0x0075C898
		public bool CHO9BottomFunctionButtonBCO_A36827_Visible
		{
			get
			{
				short num = (short)1982743591;
				short num2 = num;
				num = (short)1978549287;
				switch (num2 == num)
				{
				}
				num = (short)404488193;
				if (num != 0)
				{
				}
				num = (short)1862598656;
				short num3 = num;
				num = (short)1131085824;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.Visible;
			}
			set
			{
				short num = (short)1476327901;
				short num2 = num;
				num = (short)1835465181;
				switch (num2 == num)
				{
				}
				num = (short)626720769;
				if (num != 0)
				{
				}
				num = (short)1758265344;
				short num3 = num;
				num = (short)1099563008;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36827.Visible = value;
			}
		}

		// Token: 0x17004191 RID: 16785
		// (get) Token: 0x06008047 RID: 32839 RVA: 0x0075E74C File Offset: 0x0075C94C
		// (set) Token: 0x06008048 RID: 32840 RVA: 0x0075E804 File Offset: 0x0075CA04
		public bool CHO9BottomFunctionButtonBCO_A36827_Editable
		{
			get
			{
				short num = (short)1520296607;
				short num2 = num;
				num = (short)1009705631;
				switch (num2 == num)
				{
				}
				num = (short)1354760193;
				if (num != 0)
				{
				}
				num = (short)1839857664;
				short num3 = num;
				num = (short)2005860352;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.Editable;
			}
			set
			{
				short num = (short)2052760206;
				short num2 = num;
				num = (short)796762766;
				switch (num2 == num)
				{
				}
				num = (short)1555955712;
				if (num != 0)
				{
				}
				num = (short)1497694208;
				short num3 = num;
				num = (short)362676225;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36827.Editable = value;
			}
		}

		// Token: 0x17004192 RID: 16786
		// (get) Token: 0x06008049 RID: 32841 RVA: 0x0075E8BC File Offset: 0x0075CABC
		internal string CHO9BottomFunctionButtonBCO_A36827_UILabel
		{
			get
			{
				short num = (short)1281909904;
				short num2 = num;
				num = (short)1021863056;
				switch (num2 == num)
				{
				}
				num = (short)1691156481;
				if (num != 0)
				{
				}
				num = (short)1684733952;
				short num3 = num;
				num = (short)1000931328;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.UIName;
			}
		}

		// Token: 0x17004193 RID: 16787
		// (get) Token: 0x0600804A RID: 32842 RVA: 0x0075E970 File Offset: 0x0075CB70
		// (set) Token: 0x0600804B RID: 32843 RVA: 0x0075EA24 File Offset: 0x0075CC24
		internal bool CHO9BottomFunctionButtonBCO_A36827_HiddenStatic
		{
			get
			{
				short num = (short)1718007503;
				short num2 = num;
				num = (short)1139324623;
				switch (num2 == num)
				{
				}
				num = (short)731119617;
				if (num != 0)
				{
				}
				num = (short)255066112;
				short num3 = num;
				num = (short)2096758784;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.HiddenStatic;
			}
			set
			{
				short num = (short)649507985;
				short num2 = num;
				num = (short)643609745;
				switch (num2 == num)
				{
				}
				num = (short)1712717825;
				if (num != 0)
				{
				}
				num = (short)269549568;
				short num3 = num;
				num = (short)995688448;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36827.HiddenStatic = value;
			}
		}

		// Token: 0x17004194 RID: 16788
		// (get) Token: 0x0600804C RID: 32844 RVA: 0x0075EADC File Offset: 0x0075CCDC
		// (set) Token: 0x0600804D RID: 32845 RVA: 0x0075EB90 File Offset: 0x0075CD90
		internal bool CHO9BottomFunctionButtonBCO_A36827_HiddenDynamic
		{
			get
			{
				short num = (short)2105128167;
				short num2 = num;
				num = (short)307737831;
				switch (num2 == num)
				{
				}
				num = (short)867303425;
				if (num != 0)
				{
				}
				num = (short)1711276032;
				short num3 = num;
				num = (short)408027136;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827.HiddenDynamic;
			}
			set
			{
				short num = (short)1278755787;
				short num2 = num;
				num = (short)114705355;
				switch (num2 == num)
				{
				}
				num = (short)641662977;
				if (num != 0)
				{
				}
				num = (short)820117504;
				short num3 = num;
				num = (short)1659633664;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonBCO_A36827.HiddenDynamic = value;
			}
		}

		// Token: 0x17004195 RID: 16789
		// (get) Token: 0x0600804E RID: 32846 RVA: 0x0075EC44 File Offset: 0x0075CE44
		public bool CHO9BottomFunctionButtonBCO_A36827_HasDiffs
		{
			get
			{
				short num = (short)1451801920;
				short num2 = num;
				num = (short)6798656;
				switch (num2 == num)
				{
				}
				num = (short)828309505;
				if (num != 0)
				{
				}
				num = (short)954204160;
				short num3 = num;
				num = (short)1829502976;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonBCO_A36827._HasDiffs;
			}
		}

		// Token: 0x17004196 RID: 16790
		// (get) Token: 0x0600804F RID: 32847 RVA: 0x0075ECF8 File Offset: 0x0075CEF8
		// (set) Token: 0x06008050 RID: 32848 RVA: 0x0075EDAC File Offset: 0x0075CFAC
		public int CHO9BottomFunctionButtonFeature_A36826Value
		{
			get
			{
				short num = (short)1863709021;
				short num2 = num;
				num = (short)802091357;
				switch (num2 == num)
				{
				}
				num = (short)1636171776;
				if (num != 0)
				{
				}
				num = (short)216662016;
				short num3 = num;
				num = (short)312934401;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.Value;
			}
			set
			{
				short num = (short)1177877471;
				short num2 = num;
				num = (short)1110309855;
				switch (num2 == num)
				{
				}
				num = (short)1438711809;
				if (num != 0)
				{
				}
				num = (short)1498873856;
				short num3 = num;
				num = (short)2010316800;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36826.Value = value;
			}
		}

		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x06008051 RID: 32849 RVA: 0x0075EE64 File Offset: 0x0075D064
		// (set) Token: 0x06008052 RID: 32850 RVA: 0x0075EF18 File Offset: 0x0075D118
		public string CHO9BottomFunctionButtonFeature_A36826_UIValue
		{
			get
			{
				short num = (short)1300532927;
				short num2 = num;
				num = (short)1142132415;
				switch (num2 == num)
				{
				}
				num = (short)1661861889;
				if (num != 0)
				{
				}
				num = (short)566493184;
				short num3 = num;
				num = (short)1501364224;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.UIValue;
			}
			set
			{
				short num = (short)1643970561;
				if (num != 0)
				{
				}
				num = (short)278773893;
				short num2 = num;
				num = (short)1073463429;
				switch (num2 == num)
				{
				}
				num = (short)73334784;
				short num3 = num;
				num = (short)63897600;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36826.UIValue = value;
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x06008053 RID: 32851 RVA: 0x0075EFCC File Offset: 0x0075D1CC
		public global::AcpBusinessLayer.AcpListField CHO9BottomFunctionButtonFeature_A36826
		{
			get
			{
				short num = (short)1519867527;
				short num2 = num;
				num = (short)238245511;
				switch (num2 == num)
				{
				}
				num = (short)986447873;
				if (num != 0)
				{
				}
				num = (short)657260544;
				short num3 = num;
				num = (short)1707606016;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826;
			}
		}

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x06008054 RID: 32852 RVA: 0x0075F07C File Offset: 0x0075D27C
		// (set) Token: 0x06008055 RID: 32853 RVA: 0x0075F130 File Offset: 0x0075D330
		public bool CHO9BottomFunctionButtonFeature_A36826_Applicable
		{
			get
			{
				short num = (short)1771634689;
				if (num != 0)
				{
				}
				num = (short)475856896;
				short num2 = num;
				num = (short)590120731;
				short num3 = num;
				num = (short)1532528411;
				switch (num3 == num)
				{
				}
				num = (short)626327552;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.Applicable;
			}
			set
			{
				short num = (short)900394291;
				short num2 = num;
				num = (short)110423347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1249902592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1455226881;
				if (num != 0)
				{
				}
				num = (short)1350565888;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36826.Applicable = value;
			}
		}

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x06008056 RID: 32854 RVA: 0x0075F1E4 File Offset: 0x0075D3E4
		// (set) Token: 0x06008057 RID: 32855 RVA: 0x0075F29C File Offset: 0x0075D49C
		public bool CHO9BottomFunctionButtonFeature_A36826_Valid
		{
			get
			{
				short num = (short)1908945349;
				short num2 = num;
				num = (short)1692217797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1876230144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)206962688;
				if (num != 0)
				{
				}
				num = (short)1072365569;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.Valid;
			}
			set
			{
				short num = (short)1266638021;
				short num2 = num;
				num = (short)778067141;
				switch (num2 == num)
				{
				default:
				{
					num = (short)812580864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1769013248;
				if (num != 0)
				{
				}
				num = (short)2139619329;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36826.Valid = value;
			}
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x06008058 RID: 32856 RVA: 0x0075F350 File Offset: 0x0075D550
		// (set) Token: 0x06008059 RID: 32857 RVA: 0x0075F404 File Offset: 0x0075D604
		public bool CHO9BottomFunctionButtonFeature_A36826_Visible
		{
			get
			{
				short num = (short)1322317851;
				short num2 = num;
				num = (short)220985371;
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
				num = (short)1999044608;
				if (num != 0)
				{
				}
				num = (short)2065104897;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.Visible;
			}
			set
			{
				short num = (short)1454355574;
				short num2 = num;
				num = (short)1515893878;
				switch (num2 == num)
				{
				default:
				{
					num = (short)867762176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)576454657;
				if (num != 0)
				{
				}
				num = (short)1807286272;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36826.Visible = value;
			}
		}

		// Token: 0x1700419C RID: 16796
		// (get) Token: 0x0600805A RID: 32858 RVA: 0x0075F4B8 File Offset: 0x0075D6B8
		// (set) Token: 0x0600805B RID: 32859 RVA: 0x0075F570 File Offset: 0x0075D770
		public bool CHO9BottomFunctionButtonFeature_A36826_Editable
		{
			get
			{
				short num = (short)1959775143;
				short num2 = num;
				num = (short)486460327;
				switch (num2 == num)
				{
				default:
				{
					num = (short)335020032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1472856065;
				if (num != 0)
				{
				}
				num = (short)1372127232;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.Editable;
			}
			set
			{
				short num = (short)1325936096;
				short num2 = num;
				num = (short)1016737248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)915537920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1142620161;
				if (num != 0)
				{
				}
				num = (short)505741312;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36826.Editable = value;
			}
		}

		// Token: 0x1700419D RID: 16797
		// (get) Token: 0x0600805C RID: 32860 RVA: 0x0075F628 File Offset: 0x0075D828
		internal string CHO9BottomFunctionButtonFeature_A36826_UILabel
		{
			get
			{
				short num = (short)672520160;
				short num2 = num;
				num = (short)863819744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363855872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1590165505;
				if (num != 0)
				{
				}
				num = (short)402522112;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.UIName;
			}
		}

		// Token: 0x1700419E RID: 16798
		// (get) Token: 0x0600805D RID: 32861 RVA: 0x0075F6DC File Offset: 0x0075D8DC
		// (set) Token: 0x0600805E RID: 32862 RVA: 0x0075F790 File Offset: 0x0075D990
		internal bool CHO9BottomFunctionButtonFeature_A36826_HiddenStatic
		{
			get
			{
				short num = (short)87655355;
				short num2 = num;
				num = (short)1024689083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1320484864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1874788353;
				if (num != 0)
				{
				}
				num = (short)1323368448;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.HiddenStatic;
			}
			set
			{
				short num = (short)1535945469;
				short num2 = num;
				num = (short)951692029;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1225588736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)558301184;
				if (num != 0)
				{
				}
				num = (short)1230766081;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36826.HiddenStatic = value;
			}
		}

		// Token: 0x1700419F RID: 16799
		// (get) Token: 0x0600805F RID: 32863 RVA: 0x0075F844 File Offset: 0x0075DA44
		// (set) Token: 0x06008060 RID: 32864 RVA: 0x0075F8FC File Offset: 0x0075DAFC
		internal bool CHO9BottomFunctionButtonFeature_A36826_HiddenDynamic
		{
			get
			{
				short num = (short)217428337;
				short num2 = num;
				num = (short)803123569;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557776896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)854851585;
				if (num != 0)
				{
				}
				num = (short)1595932672;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826.HiddenDynamic;
			}
			set
			{
				short num = (short)1435334373;
				short num2 = num;
				num = (short)886273765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1536032768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)119406593;
				if (num != 0)
				{
				}
				num = (short)1643839488;
				if (num != 0)
				{
				}
				this.cHO9BottomFunctionButtonFeature_A36826.HiddenDynamic = value;
			}
		}

		// Token: 0x170041A0 RID: 16800
		// (get) Token: 0x06008061 RID: 32865 RVA: 0x0075F9B0 File Offset: 0x0075DBB0
		public bool CHO9BottomFunctionButtonFeature_A36826_HasDiffs
		{
			get
			{
				short num = (short)351451491;
				short num2 = num;
				num = (short)565164387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2122514432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)837746689;
				if (num != 0)
				{
				}
				num = (short)129499136;
				if (num != 0)
				{
				}
				return this.cHO9BottomFunctionButtonFeature_A36826._HasDiffs;
			}
		}

		// Token: 0x170041A1 RID: 16801
		// (get) Token: 0x06008062 RID: 32866 RVA: 0x0075FA64 File Offset: 0x0075DC64
		// (set) Token: 0x06008063 RID: 32867 RVA: 0x0075FB18 File Offset: 0x0075DD18
		public int PGRMBLEO9BottomShortPressTimeValue
		{
			get
			{
				short num = (short)1618381567;
				short num2 = num;
				num = (short)740920063;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1372061696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)909639680;
				if (num != 0)
				{
				}
				num = (short)737083393;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.Value;
			}
			set
			{
				short num = (short)1115270724;
				short num2 = num;
				num = (short)1663938116;
				switch (num2 == num)
				{
				default:
				{
					num = (short)576716800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1324417024;
				if (num != 0)
				{
				}
				num = (short)534577153;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.Value = value;
			}
		}

		// Token: 0x170041A2 RID: 16802
		// (get) Token: 0x06008064 RID: 32868 RVA: 0x0075FBCC File Offset: 0x0075DDCC
		// (set) Token: 0x06008065 RID: 32869 RVA: 0x0075FC80 File Offset: 0x0075DE80
		public string PGRMBLEO9BottomShortPressTime_UIValue
		{
			get
			{
				short num = (short)1655735365;
				short num2 = num;
				num = (short)330400837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)187826176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113798145;
				if (num != 0)
				{
				}
				num = (short)1767768064;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.UIValue;
			}
			set
			{
				short num = (short)1603671638;
				short num2 = num;
				num = (short)1437406806;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1564344320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716898305;
				if (num != 0)
				{
				}
				num = (short)954466304;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.UIValue = value;
			}
		}

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x06008066 RID: 32870 RVA: 0x0075FD38 File Offset: 0x0075DF38
		public global::AcpBusinessLayer.AcpSimpleRangeField PGRMBLEO9BottomShortPressTime
		{
			get
			{
				short num = (short)1764998818;
				short num2 = num;
				num = (short)505200290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)186515456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1433141248;
				if (num != 0)
				{
				}
				num = (short)1225523201;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime;
			}
		}

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x06008067 RID: 32871 RVA: 0x0075FDEC File Offset: 0x0075DFEC
		// (set) Token: 0x06008068 RID: 32872 RVA: 0x0075FEA0 File Offset: 0x0075E0A0
		internal int PGRMBLEO9BottomShortPressTimeMin
		{
			get
			{
				short num = (short)1341704775;
				short num2 = num;
				num = (short)193382983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1787232256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1673920513;
				if (num != 0)
				{
				}
				num = (short)1824391168;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.Min;
			}
			set
			{
				short num = (short)565658682;
				short num2 = num;
				num = (short)1164657722;
				switch (num2 == num)
				{
				default:
				{
					num = (short)328990720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)352387072;
				if (num != 0)
				{
				}
				num = (short)1931739137;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.Min = value;
			}
		}

		// Token: 0x170041A5 RID: 16805
		// (get) Token: 0x06008069 RID: 32873 RVA: 0x0075FF58 File Offset: 0x0075E158
		// (set) Token: 0x0600806A RID: 32874 RVA: 0x0076000C File Offset: 0x0075E20C
		internal int PGRMBLEO9BottomShortPressTimeMax
		{
			get
			{
				short num = (short)593957552;
				short num2 = num;
				num = (short)1089082032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2137784320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)418578433;
				if (num != 0)
				{
				}
				num = (short)2069954560;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.Max;
			}
			set
			{
				short num = (short)538653149;
				short num2 = num;
				num = (short)270414301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1190264832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1114243073;
				if (num != 0)
				{
				}
				num = (short)2139815936;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.Max = value;
			}
		}

		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x0600806B RID: 32875 RVA: 0x007600C4 File Offset: 0x0075E2C4
		// (set) Token: 0x0600806C RID: 32876 RVA: 0x00760178 File Offset: 0x0075E378
		internal int PGRMBLEO9BottomShortPressTimeStep
		{
			get
			{
				short num = (short)1170737387;
				short num2 = num;
				num = (short)454953195;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1776877568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30998529;
				if (num != 0)
				{
				}
				num = (short)93519872;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.StepSize;
			}
			set
			{
				short num = (short)1141107559;
				short num2 = num;
				num = (short)1023142759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)543621120;
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
				num = (short)1794244608;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.StepSize = value;
			}
		}

		// Token: 0x170041A7 RID: 16807
		// (get) Token: 0x0600806D RID: 32877 RVA: 0x00760230 File Offset: 0x0075E430
		// (set) Token: 0x0600806E RID: 32878 RVA: 0x007602E8 File Offset: 0x0075E4E8
		public bool PGRMBLEO9BottomShortPressTime_Applicable
		{
			get
			{
				short num = (short)682081366;
				short num2 = num;
				num = (short)2101591126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1017380864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)139395073;
				if (num != 0)
				{
				}
				num = (short)801701888;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.Applicable;
			}
			set
			{
				short num = (short)1963654213;
				short num2 = num;
				num = (short)1825176645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431489024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)4259840;
				if (num != 0)
				{
				}
				num = (short)1976041473;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.Applicable = value;
			}
		}

		// Token: 0x170041A8 RID: 16808
		// (get) Token: 0x0600806F RID: 32879 RVA: 0x007603A0 File Offset: 0x0075E5A0
		// (set) Token: 0x06008070 RID: 32880 RVA: 0x00760454 File Offset: 0x0075E654
		public bool PGRMBLEO9BottomShortPressTime_Valid
		{
			get
			{
				short num = (short)1934457460;
				short num2 = num;
				num = (short)1386642036;
				switch (num2 == num)
				{
				default:
				{
					num = (short)739180544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)565116928;
				if (num != 0)
				{
				}
				num = (short)1829699585;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.Valid;
			}
			set
			{
				short num = (short)1471183386;
				short num2 = num;
				num = (short)1259108890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)171442176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461045761;
				if (num != 0)
				{
				}
				num = (short)2115633152;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.Valid = value;
			}
		}

		// Token: 0x170041A9 RID: 16809
		// (get) Token: 0x06008071 RID: 32881 RVA: 0x00760508 File Offset: 0x0075E708
		// (set) Token: 0x06008072 RID: 32882 RVA: 0x007605BC File Offset: 0x0075E7BC
		public bool PGRMBLEO9BottomShortPressTime_Visible
		{
			get
			{
				short num = (short)900788552;
				short num2 = num;
				num = (short)574026056;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97386496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)875364353;
				if (num != 0)
				{
				}
				num = (short)1665073152;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.Visible;
			}
			set
			{
				short num = (short)1826947073;
				if (num != 0)
				{
				}
				num = (short)1646854144;
				short num2 = num;
				num = (short)601973879;
				short num3 = num;
				num = (short)693003383;
				switch (num3 == num)
				{
				}
				num = (short)488898560;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.Visible = value;
			}
		}

		// Token: 0x170041AA RID: 16810
		// (get) Token: 0x06008073 RID: 32883 RVA: 0x00760674 File Offset: 0x0075E874
		// (set) Token: 0x06008074 RID: 32884 RVA: 0x0076072C File Offset: 0x0075E92C
		public bool PGRMBLEO9BottomShortPressTime_Editable
		{
			get
			{
				short num = (short)103556894;
				short num2 = num;
				num = (short)1817782046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1968963584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)818741249;
				if (num != 0)
				{
				}
				num = (short)1834221568;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.Editable;
			}
			set
			{
				short num = (short)1054891778;
				short num2 = num;
				num = (short)1784831746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)845545472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920860161;
				if (num != 0)
				{
				}
				num = (short)1226833920;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.Editable = value;
			}
		}

		// Token: 0x170041AB RID: 16811
		// (get) Token: 0x06008075 RID: 32885 RVA: 0x007607E0 File Offset: 0x0075E9E0
		internal string PGRMBLEO9BottomShortPressTime_UILabel
		{
			get
			{
				short num = (short)2032694244;
				short num2 = num;
				num = (short)993293284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)713359360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)83230720;
				if (num != 0)
				{
				}
				num = (short)1397555201;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.UIName;
			}
		}

		// Token: 0x170041AC RID: 16812
		// (get) Token: 0x06008076 RID: 32886 RVA: 0x00760894 File Offset: 0x0075EA94
		// (set) Token: 0x06008077 RID: 32887 RVA: 0x00760948 File Offset: 0x0075EB48
		internal bool PGRMBLEO9BottomShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)2060044971;
				short num2 = num;
				num = (short)233491115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1471414272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2143289345;
				if (num != 0)
				{
				}
				num = (short)594935808;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)192610305;
				if (num != 0)
				{
				}
				num = (short)663420928;
				short num2 = num;
				num = (short)948455410;
				short num3 = num;
				num = (short)128993266;
				switch (num3 == num)
				{
				}
				num = (short)1069350912;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x170041AD RID: 16813
		// (get) Token: 0x06008078 RID: 32888 RVA: 0x00760A00 File Offset: 0x0075EC00
		// (set) Token: 0x06008079 RID: 32889 RVA: 0x00760AB8 File Offset: 0x0075ECB8
		internal bool PGRMBLEO9BottomShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1126001035;
				short num2 = num;
				num = (short)1753966987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727070208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028470273;
				if (num != 0)
				{
				}
				num = (short)240123904;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)502831193;
				short num2 = num;
				num = (short)2100336729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)475332608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1200160768;
				if (num != 0)
				{
				}
				num = (short)1460666369;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170041AE RID: 16814
		// (get) Token: 0x0600807A RID: 32890 RVA: 0x00760B70 File Offset: 0x0075ED70
		public bool PGRMBLEO9BottomShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)1040181921;
				short num2 = num;
				num = (short)2121067169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)473759744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2077884416;
				if (num != 0)
				{
				}
				num = (short)2003763201;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomShortPressTime._HasDiffs;
			}
		}

		// Token: 0x170041AF RID: 16815
		// (get) Token: 0x0600807B RID: 32891 RVA: 0x00760C28 File Offset: 0x0075EE28
		// (set) Token: 0x0600807C RID: 32892 RVA: 0x00760CDC File Offset: 0x0075EEDC
		public int PGRMBLEO9BottomLongPressTimeValue
		{
			get
			{
				short num = (short)2094465025;
				if (num != 0)
				{
				}
				num = (short)2001272832;
				short num2 = num;
				num = (short)1494887734;
				short num3 = num;
				num = (short)836054326;
				switch (num3 == num)
				{
				}
				num = (short)1195573248;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.Value;
			}
			set
			{
				short num = (short)1784051839;
				short num2 = num;
				num = (short)862025855;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253558784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)15400960;
				if (num != 0)
				{
				}
				num = (short)58458113;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.Value = value;
			}
		}

		// Token: 0x170041B0 RID: 16816
		// (get) Token: 0x0600807D RID: 32893 RVA: 0x00760D94 File Offset: 0x0075EF94
		// (set) Token: 0x0600807E RID: 32894 RVA: 0x00760E48 File Offset: 0x0075F048
		public string PGRMBLEO9BottomLongPressTime_UIValue
		{
			get
			{
				short num = (short)872795133;
				short num2 = num;
				num = (short)1583139837;
				switch (num2 == num)
				{
				default:
				{
					num = (short)809041920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1890385920;
				if (num != 0)
				{
				}
				num = (short)488243201;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.UIValue;
			}
			set
			{
				short num = (short)1422133951;
				short num2 = num;
				num = (short)1326123711;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1765539840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)578289664;
				if (num != 0)
				{
				}
				num = (short)555155457;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.UIValue = value;
			}
		}

		// Token: 0x170041B1 RID: 16817
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x00760EFC File Offset: 0x0075F0FC
		public global::AcpBusinessLayer.AcpSimpleRangeField PGRMBLEO9BottomLongPressTime
		{
			get
			{
				short num = (short)2106531539;
				short num2 = num;
				num = (short)1794514643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1003683840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1167589377;
				if (num != 0)
				{
				}
				num = (short)948699136;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime;
			}
		}

		// Token: 0x170041B2 RID: 16818
		// (get) Token: 0x06008080 RID: 32896 RVA: 0x00760FAC File Offset: 0x0075F1AC
		// (set) Token: 0x06008081 RID: 32897 RVA: 0x00761060 File Offset: 0x0075F260
		internal int PGRMBLEO9BottomLongPressTimeMin
		{
			get
			{
				short num = (short)1663351186;
				short num2 = num;
				num = (short)1942010258;
				switch (num2 == num)
				{
				default:
				{
					num = (short)532742144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)787611649;
				if (num != 0)
				{
				}
				num = (short)355074048;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.Min;
			}
			set
			{
				short num = (short)1410925918;
				short num2 = num;
				num = (short)2110129502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1459290112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2010841089;
				if (num != 0)
				{
				}
				num = (short)1485307904;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.Min = value;
			}
		}

		// Token: 0x170041B3 RID: 16819
		// (get) Token: 0x06008082 RID: 32898 RVA: 0x00761114 File Offset: 0x0075F314
		// (set) Token: 0x06008083 RID: 32899 RVA: 0x007611CC File Offset: 0x0075F3CC
		internal int PGRMBLEO9BottomLongPressTimeMax
		{
			get
			{
				short num = (short)2017869227;
				short num2 = num;
				num = (short)372194731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1073086464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883228673;
				if (num != 0)
				{
				}
				num = (short)1485111296;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.Max;
			}
			set
			{
				short num = (short)444596225;
				if (num != 0)
				{
				}
				num = (short)460390400;
				short num2 = num;
				num = (short)1600715651;
				short num3 = num;
				num = (short)999226243;
				switch (num3 == num)
				{
				}
				num = (short)1595015168;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.Max = value;
			}
		}

		// Token: 0x170041B4 RID: 16820
		// (get) Token: 0x06008084 RID: 32900 RVA: 0x00761280 File Offset: 0x0075F480
		// (set) Token: 0x06008085 RID: 32901 RVA: 0x00761330 File Offset: 0x0075F530
		internal int PGRMBLEO9BottomLongPressTimeStep
		{
			get
			{
				short num = (short)544717004;
				short num2 = num;
				num = (short)942389452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)65994752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)920059905;
				if (num != 0)
				{
				}
				num = (short)1073610752;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.StepSize;
			}
			set
			{
				short num = (short)1149964027;
				short num2 = num;
				num = (short)100667131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1643577344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)437714945;
				if (num != 0)
				{
				}
				num = (short)520945664;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.StepSize = value;
			}
		}

		// Token: 0x170041B5 RID: 16821
		// (get) Token: 0x06008086 RID: 32902 RVA: 0x007613E4 File Offset: 0x0075F5E4
		// (set) Token: 0x06008087 RID: 32903 RVA: 0x00761498 File Offset: 0x0075F698
		public bool PGRMBLEO9BottomLongPressTime_Applicable
		{
			get
			{
				short num = (short)1260219671;
				short num2 = num;
				num = (short)1509911831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)651689984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)335740929;
				if (num != 0)
				{
				}
				num = (short)1761607680;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.Applicable;
			}
			set
			{
				short num = (short)1237254144;
				short num2 = num;
				num = (short)213254145;
				if (num != 0)
				{
				}
				num = (short)1757996424;
				short num3 = num;
				num = (short)887022984;
				switch (num3 == num)
				{
				}
				num = (short)1074855936;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.Applicable = value;
			}
		}

		// Token: 0x170041B6 RID: 16822
		// (get) Token: 0x06008088 RID: 32904 RVA: 0x0076154C File Offset: 0x0075F74C
		// (set) Token: 0x06008089 RID: 32905 RVA: 0x00761600 File Offset: 0x0075F800
		public bool PGRMBLEO9BottomLongPressTime_Valid
		{
			get
			{
				short num = (short)448331776;
				short num2 = num;
				num = (short)1447481373;
				short num3 = num;
				num = (short)1602867229;
				switch (num3 == num)
				{
				}
				num = (short)2084569089;
				if (num != 0)
				{
				}
				num = (short)1780547584;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.Valid;
			}
			set
			{
				short num = (short)1631059968;
				short num2 = num;
				num = (short)1947858494;
				short num3 = num;
				num = (short)1192621630;
				switch (num3 == num)
				{
				}
				num = (short)771948544;
				if (num != 0)
				{
				}
				num = (short)1478623233;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.Valid = value;
			}
		}

		// Token: 0x170041B7 RID: 16823
		// (get) Token: 0x0600808A RID: 32906 RVA: 0x007616B4 File Offset: 0x0075F8B4
		// (set) Token: 0x0600808B RID: 32907 RVA: 0x00761768 File Offset: 0x0075F968
		public bool PGRMBLEO9BottomLongPressTime_Visible
		{
			get
			{
				short num = (short)1050017792;
				short num2 = num;
				num = (short)391189069;
				short num3 = num;
				num = (short)1982992973;
				switch (num3 == num)
				{
				}
				num = (short)1174470657;
				if (num != 0)
				{
				}
				num = (short)369819648;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.Visible;
			}
			set
			{
				short num = (short)118882304;
				short num2 = num;
				num = (short)1997239403;
				short num3 = num;
				num = (short)314405995;
				switch (num3 == num)
				{
				}
				num = (short)847118337;
				if (num != 0)
				{
				}
				num = (short)1408040960;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.Visible = value;
			}
		}

		// Token: 0x170041B8 RID: 16824
		// (get) Token: 0x0600808C RID: 32908 RVA: 0x0076181C File Offset: 0x0075FA1C
		// (set) Token: 0x0600808D RID: 32909 RVA: 0x007618CC File Offset: 0x0075FACC
		public bool PGRMBLEO9BottomLongPressTime_Editable
		{
			get
			{
				short num = (short)1550909440;
				short num2 = num;
				num = (short)884980565;
				short num3 = num;
				num = (short)1129823061;
				switch (num3 == num)
				{
				}
				num = (short)1525022721;
				if (num != 0)
				{
				}
				num = (short)420806656;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.Editable;
			}
			set
			{
				short num = (short)699924480;
				short num2 = num;
				num = (short)1021192409;
				short num3 = num;
				num = (short)1217210585;
				switch (num3 == num)
				{
				}
				num = (short)1171849217;
				if (num != 0)
				{
				}
				num = (short)483721216;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.Editable = value;
			}
		}

		// Token: 0x170041B9 RID: 16825
		// (get) Token: 0x0600808E RID: 32910 RVA: 0x00761980 File Offset: 0x0075FB80
		internal string PGRMBLEO9BottomLongPressTime_UILabel
		{
			get
			{
				short num = (short)974913536;
				short num2 = num;
				num = (short)1414099294;
				short num3 = num;
				num = (short)448229726;
				switch (num3 == num)
				{
				}
				num = (short)766443520;
				if (num != 0)
				{
				}
				num = (short)422051841;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.UIName;
			}
		}

		// Token: 0x170041BA RID: 16826
		// (get) Token: 0x0600808F RID: 32911 RVA: 0x00761A34 File Offset: 0x0075FC34
		// (set) Token: 0x06008090 RID: 32912 RVA: 0x00761AF0 File Offset: 0x0075FCF0
		internal bool PGRMBLEO9BottomLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)292290560;
				short num2 = num;
				num = (short)334248900;
				short num3 = num;
				num = (short)1037056964;
				switch (num3 == num)
				{
				}
				num = (short)239730689;
				if (num != 0)
				{
				}
				num = (short)650969088;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)291307520;
				short num2 = num;
				num = (short)424720433;
				short num3 = num;
				num = (short)583252017;
				switch (num3 == num)
				{
				}
				num = (short)291897345;
				if (num != 0)
				{
				}
				num = (short)1379729408;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x170041BB RID: 16827
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x00761BA4 File Offset: 0x0075FDA4
		// (set) Token: 0x06008092 RID: 32914 RVA: 0x00761C5C File Offset: 0x0075FE5C
		internal bool PGRMBLEO9BottomLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)350420992;
				short num2 = num;
				num = (short)2105889074;
				short num3 = num;
				num = (short)2115719474;
				switch (num3 == num)
				{
				}
				num = (short)1678901248;
				if (num != 0)
				{
				}
				num = (short)1020985345;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1946812416;
				short num2 = num;
				num = (short)271168454;
				short num3 = num;
				num = (short)431862726;
				switch (num3 == num)
				{
				}
				num = (short)2056126465;
				if (num != 0)
				{
				}
				num = (short)13238272;
				if (num != 0)
				{
				}
				this.pgrmbleO9BottomLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x06008093 RID: 32915 RVA: 0x00761D10 File Offset: 0x0075FF10
		public bool PGRMBLEO9BottomLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)573046784;
				short num2 = num;
				num = (short)1090840215;
				short num3 = num;
				num = (short)33220247;
				switch (num3 == num)
				{
				}
				num = (short)257884161;
				if (num != 0)
				{
				}
				num = (short)1362296832;
				if (num != 0)
				{
				}
				return this.pgrmbleO9BottomLongPressTime._HasDiffs;
			}
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x00761DC8 File Offset: 0x0075FFC8
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
					if (base.ParentRecset != null)
					{
						num2 = (short)1759051780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1208614915;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1589575681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
				{
					num2 = (short)603725635;
					short num3 = num2;
					num2 = (short)1889607491;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1548156928;
						short num4 = num2;
						num2 = (short)1015021569;
						if (num2 != 0)
						{
						}
						num2 = (short)1079312384;
						if (num2 != 0)
						{
						}
						num2 = (short)2132672514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)849412096;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040039C0 RID: 14784
		private global::AcpBusinessLayer.AcpListField cHO9BottomFunctionButtonBCO_A36827;

		// Token: 0x040039C1 RID: 14785
		private global::AcpBusinessLayer.AcpListField cHO9BottomFunctionButtonFeature_A36826;

		// Token: 0x040039C2 RID: 14786
		private global::AcpBusinessLayer.AcpSimpleRangeField pgrmbleO9BottomShortPressTime;

		// Token: 0x040039C3 RID: 14787
		private global::AcpBusinessLayer.AcpSimpleRangeField pgrmbleO9BottomLongPressTime;
	}
}
