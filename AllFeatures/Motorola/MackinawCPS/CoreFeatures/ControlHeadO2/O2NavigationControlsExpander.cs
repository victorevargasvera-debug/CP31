using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003E4 RID: 996
	[global::System.Serializable]
	public class O2NavigationControlsExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008C3E RID: 35902 RVA: 0x00833464 File Offset: 0x00831664
		public O2NavigationControlsExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008C3F RID: 35903 RVA: 0x008334A4 File Offset: 0x008316A4
		protected O2NavigationControlsExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008C40 RID: 35904 RVA: 0x008334BC File Offset: 0x008316BC
		public override void Init()
		{
			int a_ = 19;
			short num = (short)503148067;
			short num2 = num;
			num = (short)1399287331;
			switch (num2 == num)
			{
			}
			num = (short)1794703361;
			if (num != 0)
			{
			}
			num = (short)1427243008;
			short num3 = num;
			num = (short)1710817280;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髓럕껗동믛뿝铟诡诣裥죧ꧩ菫胭蓯胱鯳髵请", a_);
			base.Id = 10722;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x008335A4 File Offset: 0x008317A4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1940913259;
			short num2 = num;
			num = (short)774175851;
			switch (num2 == num)
			{
			}
			num = (short)1978662913;
			if (num != 0)
			{
			}
			num = (short)2099773440;
			short num3 = num;
			num = (short)1866989568;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黏돑ꋓ뿕뿗믙꣛럝迟賡쓣ꗥ蟧蓩飫鳭鿯黱蟳", a_);
			base.Id = 10722;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x00833688 File Offset: 0x00831888
		public override void PopulateReferences()
		{
			short num = (short)1163540378;
			short num2 = num;
			num = (short)677001114;
			switch (num2 == num)
			{
			}
			num = (short)322830337;
			if (num != 0)
			{
			}
			num = (short)991756288;
			short num3 = num;
			num = (short)1641873408;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x00833730 File Offset: 0x00831930
		public override void DropReferences()
		{
			short num = (short)1821376513;
			if (num != 0)
			{
			}
			num = (short)1408806292;
			short num2 = num;
			num = (short)1810869652;
			switch (num2 == num)
			{
			}
			num = (short)1891303424;
			short num3 = num;
			num = (short)717422592;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x008337DC File Offset: 0x008319DC
		public override void SetConstraints()
		{
			short num = (short)1228103573;
			short num2 = num;
			num = (short)1745903509;
			switch (num2 == num)
			{
			}
			num = (short)1914503169;
			if (num != 0)
			{
			}
			num = (short)1078067200;
			short num3 = num;
			num = (short)1438253056;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x00833884 File Offset: 0x00831A84
		public override void SetupDependencies()
		{
			short num = (short)243294836;
			short num2 = num;
			num = (short)1365860980;
			switch (num2 == num)
			{
			}
			num = (short)1901789185;
			if (num != 0)
			{
			}
			num = (short)1030160384;
			short num3 = num;
			num = (short)335020032;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004705 RID: 18181
		// (get) Token: 0x06008C46 RID: 35910 RVA: 0x0083392C File Offset: 0x00831B2C
		public bool HasDiffs
		{
			get
			{
				short num = (short)2093898889;
				short num2 = num;
				num = (short)1099390089;
				switch (num2 == num)
				{
				}
				num = (short)1685192705;
				if (num != 0)
				{
				}
				num = (short)1326972928;
				short num3 = num;
				num = (short)922222592;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x008339DC File Offset: 0x00831BDC
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
					IL_9A:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)245235713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C0;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1597505539;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1712193536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_C0;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1197211650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C0;
				}
				goto IL_24;
				IL_C0:
				num2 = (short)1489123666;
				short num3 = num2;
				num2 = (short)800733522;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9A;
				default:
					goto IL_F7;
				}
			}
			IL_F7:
			num2 = (short)2000486400;
			if (num2 != 0)
			{
			}
			num2 = (short)1695940609;
			if (num2 != 0)
			{
			}
			num2 = (short)1101594624;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)361889796;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040043ED RID: 17389
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset innerRecset;
	}
}
