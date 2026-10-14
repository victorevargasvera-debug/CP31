using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x020004F1 RID: 1265
	[global::System.Serializable]
	public class DAC : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AA22 RID: 43554 RVA: 0x009E7284 File Offset: 0x009E5484
		public DAC(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x009E72C4 File Offset: 0x009E54C4
		protected DAC(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x009E72DC File Offset: 0x009E54DC
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1437728768;
			short num2 = num;
			num = (short)1914175489;
			if (num != 0)
			{
			}
			num = (short)664731179;
			short num3 = num;
			num = (short)865402411;
			switch (num3 == num)
			{
			}
			num = (short)1636237312;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軌賎郐菒鏖飘飚", a_);
			base.Id = 10504;
			base.UIName = global::CommonResources.AcgResources.ID_CCAPDAC;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x009E73C0 File Offset: 0x009E55C0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1952317440;
			short num2 = num;
			num = (short)2100574509;
			short num3 = num;
			num = (short)1303853357;
			switch (num3 == num)
			{
			}
			num = (short)1385693185;
			if (num != 0)
			{
			}
			num = (short)455671808;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛄蓆裈鯊诎郐郒", a_);
			base.Id = 10504;
			base.UIName = global::CommonResources.AcgResources.ID_CCAPDAC;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600AA26 RID: 43558 RVA: 0x009E74A4 File Offset: 0x009E56A4
		public override void PopulateReferences()
		{
			short num = (short)2022440960;
			short num2 = num;
			num = (short)123634597;
			short num3 = num;
			num = (short)620004261;
			switch (num3 == num)
			{
			}
			num = (short)270991361;
			if (num != 0)
			{
			}
			num = (short)1924792320;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA27 RID: 43559 RVA: 0x009E7550 File Offset: 0x009E5750
		public override void DropReferences()
		{
			short num = (short)1833304064;
			short num2 = num;
			num = (short)176685057;
			if (num != 0)
			{
			}
			num = (short)490200410;
			short num3 = num;
			num = (short)1228856666;
			switch (num3 == num)
			{
			}
			num = (short)1047527424;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x009E75F8 File Offset: 0x009E57F8
		public override void SetConstraints()
		{
			short num = (short)14483456;
			short num2 = num;
			num = (short)2096452485;
			short num3 = num;
			num = (short)1830769541;
			switch (num3 == num)
			{
			}
			num = (short)1351942144;
			if (num != 0)
			{
			}
			num = (short)1691877377;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x009E76A4 File Offset: 0x009E58A4
		public override void SetupDependencies()
		{
			short num = (short)1109458944;
			short num2 = num;
			num = (short)289928948;
			short num3 = num;
			num = (short)1234892532;
			switch (num3 == num)
			{
			}
			num = (short)889192448;
			if (num != 0)
			{
			}
			num = (short)457375745;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005542 RID: 21826
		// (get) Token: 0x0600AA2A RID: 43562 RVA: 0x009E774C File Offset: 0x009E594C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1651507200;
				short num2 = num;
				num = (short)121459745;
				short num3 = num;
				num = (short)1028477985;
				switch (num3 == num)
				{
				}
				num = (short)1138294785;
				if (num != 0)
				{
				}
				num = (short)897515520;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x009E77FC File Offset: 0x009E59FC
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
						num2 = (short)746520580;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_DD;
					}
					return result;
				case 3:
				{
					num2 = (short)373492738;
					short num3 = num2;
					num2 = (short)930614274;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DD;
					default:
						num2 = (short)1962409984;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)296288257;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)496631810;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_DD:
				num2 = (short)867958785;
				if (num2 != 0)
				{
				}
				num2 = (short)1954676739;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			num2 = (short)1682833408;
			short num4 = num2;
			result = null;
			num2 = (short)1709047808;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400514E RID: 20814
		private global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset innerRecset;
	}
}
