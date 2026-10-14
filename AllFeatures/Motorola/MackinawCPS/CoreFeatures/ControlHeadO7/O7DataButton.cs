using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x02000398 RID: 920
	[global::System.Serializable]
	public class O7DataButton : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060086BD RID: 34493 RVA: 0x007DA9DC File Offset: 0x007D8BDC
		public O7DataButton(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060086BE RID: 34494 RVA: 0x007DAA1C File Offset: 0x007D8C1C
		protected O7DataButton(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x007DAA34 File Offset: 0x007D8C34
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1470119100;
			short num2 = num;
			num = (short)1614363836;
			switch (num2 == num)
			{
			}
			num = (short)773718017;
			if (num != 0)
			{
			}
			num = (short)1618608128;
			if (num != 0)
			{
			}
			num = (short)318242816;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ", a_);
			base.Id = 10717;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060086C0 RID: 34496 RVA: 0x007DAB18 File Offset: 0x007D8D18
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1155976615;
			short num2 = num;
			num = (short)705416615;
			switch (num2 == num)
			{
			}
			num = (short)1526988801;
			if (num != 0)
			{
			}
			num = (short)992870400;
			if (num != 0)
			{
			}
			num = (short)496959488;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ", a_);
			base.Id = 10717;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 4;
		}

		// Token: 0x060086C1 RID: 34497 RVA: 0x007DABFC File Offset: 0x007D8DFC
		public override void PopulateReferences()
		{
			short num = (short)1388445697;
			if (num != 0)
			{
			}
			num = (short)1604322767;
			short num2 = num;
			num = (short)1733625295;
			switch (num2 == num)
			{
			}
			num = (short)748158976;
			if (num != 0)
			{
			}
			num = (short)1193672704;
			short num3 = num;
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x007DACA8 File Offset: 0x007D8EA8
		public override void DropReferences()
		{
			short num = (short)643250537;
			short num2 = num;
			num = (short)2077047145;
			switch (num2 == num)
			{
			}
			num = (short)1986723841;
			if (num != 0)
			{
			}
			num = (short)1778253824;
			if (num != 0)
			{
			}
			num = (short)1177485312;
			short num3 = num;
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x007DAD50 File Offset: 0x007D8F50
		public override void SetConstraints()
		{
			short num = (short)655955368;
			short num2 = num;
			num = (short)755504552;
			switch (num2 == num)
			{
			}
			num = (short)2003566592;
			if (num != 0)
			{
			}
			num = (short)1877147649;
			if (num != 0)
			{
			}
			num = (short)409534464;
			short num3 = num;
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x007DADF8 File Offset: 0x007D8FF8
		public override void SetupDependencies()
		{
			short num = (short)512469038;
			short num2 = num;
			num = (short)2024122414;
			switch (num2 == num)
			{
			}
			num = (short)403177472;
			if (num != 0)
			{
			}
			num = (short)973537281;
			if (num != 0)
			{
			}
			num = (short)1244921856;
			short num3 = num;
		}

		// Token: 0x1700448B RID: 17547
		// (get) Token: 0x060086C5 RID: 34501 RVA: 0x007DAEA0 File Offset: 0x007D90A0
		public bool HasDiffs
		{
			get
			{
				short num = (short)545614664;
				short num2 = num;
				num = (short)953117512;
				switch (num2 == num)
				{
				}
				num = (short)700186625;
				if (num != 0)
				{
				}
				num = (short)431685632;
				if (num != 0)
				{
				}
				num = (short)343998464;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x007DAF50 File Offset: 0x007D9150
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
					num2 = (short)2005712027;
					short num3 = num2;
					num2 = (short)1637792923;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1054015488;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)768540675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)1631715329;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1942421504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1448607748;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					num2 = (short)607125505;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)2752512;
			short num4 = num2;
			num2 = (short)196280322;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003FE1 RID: 16353
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset innerRecset;
	}
}
