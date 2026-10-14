using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x02000195 RID: 405
	[global::System.Serializable]
	public class AdvancedSystemKeyInfo : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060044B7 RID: 17591 RVA: 0x003FB508 File Offset: 0x003F9708
		public AdvancedSystemKeyInfo(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x003FB548 File Offset: 0x003F9748
		protected AdvancedSystemKeyInfo(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x003FB560 File Offset: 0x003F9760
		public override void Init()
		{
			int a_ = 7;
			short num = (short)43988265;
			short num2 = num;
			num = (short)746992937;
			switch (num2 == num)
			{
			}
			num = (short)866910209;
			if (num != 0)
			{
			}
			num = (short)1886126080;
			if (num != 0)
			{
			}
			num = (short)734461952;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觇껉뫋꿍뻏뇑뇓닕觙ꗛ귝铟蟡解웥ꏧ迩闫컭맯鳱鋳駵", a_);
			base.Id = 10112;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCEDSYSTEMKEYINFO;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x003FB644 File Offset: 0x003F9844
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1307558927;
			short num2 = num;
			num = (short)897696783;
			switch (num2 == num)
			{
			}
			num = (short)605814784;
			if (num != 0)
			{
			}
			num = (short)1634861057;
			if (num != 0)
			{
			}
			num = (short)1365901312;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓄ꏆ뿈꫊ꏌ곎듐럒蓖ꃘ꣚꧜뫞賠쏢껤苦部쯪ꓬ臮韰鳲", a_);
			base.Id = 10112;
			base.UIName = global::CommonResources.AcgResources.ID_ADVANCEDSYSTEMKEYINFO;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x003FB724 File Offset: 0x003F9924
		public override void PopulateReferences()
		{
			short num = (short)447726169;
			short num2 = num;
			num = (short)1589625433;
			switch (num2 == num)
			{
			}
			num = (short)34013184;
			if (num != 0)
			{
			}
			num = (short)471859201;
			if (num != 0)
			{
			}
			num = (short)1419706368;
			short num3 = num;
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x003FB7CC File Offset: 0x003F99CC
		public override void DropReferences()
		{
			short num = (short)1042101537;
			short num2 = num;
			num = (short)1304507681;
			switch (num2 == num)
			{
			}
			num = (short)2058420224;
			if (num != 0)
			{
			}
			num = (short)184745985;
			if (num != 0)
			{
			}
			num = (short)157614080;
			short num3 = num;
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x003FB874 File Offset: 0x003F9A74
		public override void SetConstraints()
		{
			short num = (short)835213750;
			short num2 = num;
			num = (short)462772662;
			switch (num2 == num)
			{
			}
			num = (short)804847616;
			if (num != 0)
			{
			}
			num = (short)1726611457;
			if (num != 0)
			{
			}
			num = (short)1394475008;
			short num3 = num;
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x003FB91C File Offset: 0x003F9B1C
		public override void SetupDependencies()
		{
			short num = (short)237663074;
			short num2 = num;
			num = (short)1016820578;
			switch (num2 == num)
			{
			}
			num = (short)752025600;
			if (num != 0)
			{
			}
			num = (short)501481473;
			if (num != 0)
			{
			}
			num = (short)782172160;
			short num3 = num;
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x060044BF RID: 17599 RVA: 0x003FB9C8 File Offset: 0x003F9BC8
		public bool HasDiffs
		{
			get
			{
				short num = (short)14979967;
				short num2 = num;
				num = (short)1411224447;
				switch (num2 == num)
				{
				}
				num = (short)299827201;
				if (num != 0)
				{
				}
				num = (short)1835270144;
				if (num != 0)
				{
				}
				num = (short)228196352;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x003FBA74 File Offset: 0x003F9C74
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)240713728;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)333933055;
					short num4 = num;
					num = (short)1392667135;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1558380544;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)802881539;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)1113325570;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					num = (short)436076548;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)326631425;
						if (num != 0)
						{
						}
						num = (short)2124939264;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4E;
			}
			return result;
			IL_4E:
			result = null;
			num = (short)529334273;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04001A3E RID: 6718
		private global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerRecset innerRecset;
	}
}
