using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x0200051F RID: 1311
	[global::System.Serializable]
	public class SingletoneFrequencyList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B16F RID: 45423 RVA: 0x00A47E34 File Offset: 0x00A46034
		public SingletoneFrequencyList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x00A47E74 File Offset: 0x00A46074
		protected SingletoneFrequencyList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x00A47E8C File Offset: 0x00A4608C
		public override void Init()
		{
			int a_ = 3;
			short num = (short)941946088;
			short num2 = num;
			num = (short)229897448;
			switch (num2 == num)
			{
			}
			num = (short)1140129793;
			if (num != 0)
			{
			}
			num = (short)1662517248;
			if (num != 0)
			{
			}
			num = (short)809697280;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韃꿅ꛇ귉ꃋꯍ꓏뷑뫓돕鳙껛믝釟韡臣裥诧鏩쳫ꋭ駯臱胳", a_);
			base.Id = 10224;
			base.UIName = global::CommonResources.AcgResources.ID_SINGLETONEFREQUENCYLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x00A47F6C File Offset: 0x00A4616C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)508803988;
			short num2 = num;
			num = (short)1688976276;
			switch (num2 == num)
			{
			}
			num = (short)190185473;
			if (num != 0)
			{
			}
			num = (short)1869152256;
			if (num != 0)
			{
			}
			num = (short)812384256;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駉ꗋꃍ럏뻑뇓ꋕ럗듙맛ﻝꛟ郡臣韥鷧迩苫跭觯틱룳鿵请軹", a_);
			base.Id = 10224;
			base.UIName = global::CommonResources.AcgResources.ID_SINGLETONEFREQUENCYLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x00A48050 File Offset: 0x00A46250
		public override void PopulateReferences()
		{
			short num = (short)1389774536;
			short num2 = num;
			num = (short)328877768;
			switch (num2 == num)
			{
			}
			num = (short)1753677825;
			if (num != 0)
			{
			}
			num = (short)848035840;
			if (num != 0)
			{
			}
			num = (short)1719599104;
			short num3 = num;
		}

		// Token: 0x0600B174 RID: 45428 RVA: 0x00A480F8 File Offset: 0x00A462F8
		public override void DropReferences()
		{
			short num = (short)555693875;
			short num2 = num;
			num = (short)544290611;
			switch (num2 == num)
			{
			}
			num = (short)1287127041;
			if (num != 0)
			{
			}
			num = (short)9633792;
			if (num != 0)
			{
			}
			num = (short)932970496;
			short num3 = num;
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x00A481A4 File Offset: 0x00A463A4
		public override void SetConstraints()
		{
			short num = (short)554052496;
			short num2 = num;
			num = (short)1515662224;
			switch (num2 == num)
			{
			}
			num = (short)1446576128;
			if (num != 0)
			{
			}
			num = (short)1833500673;
			if (num != 0)
			{
			}
			num = (short)56229888;
			short num3 = num;
		}

		// Token: 0x0600B176 RID: 45430 RVA: 0x00A4824C File Offset: 0x00A4644C
		public override void SetupDependencies()
		{
			short num = (short)1206685309;
			short num2 = num;
			num = (short)2029883005;
			switch (num2 == num)
			{
			}
			num = (short)1044774912;
			if (num != 0)
			{
			}
			num = (short)1381564417;
			if (num != 0)
			{
			}
			num = (short)1459421184;
			short num3 = num;
		}

		// Token: 0x17005908 RID: 22792
		// (get) Token: 0x0600B177 RID: 45431 RVA: 0x00A482F4 File Offset: 0x00A464F4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1478258179;
				short num2 = num;
				num = (short)846556675;
				switch (num2 == num)
				{
				}
				num = (short)1129054209;
				if (num != 0)
				{
				}
				num = (short)65273856;
				if (num != 0)
				{
				}
				num = (short)954073088;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x00A483A4 File Offset: 0x00A465A4
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
					num2 = (short)1428570548;
					short num3 = num2;
					num2 = (short)2118664628;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)428277760;
						if (num2 != 0)
						{
						}
						num2 = (short)1161691137;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1627914241;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)726794244;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					num2 = (short)395444224;
					short num4 = num2;
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1383596032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 4:
					num2 = (short)1719336963;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1925906434;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04005422 RID: 21538
		private global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerRecset innerRecset;
	}
}
