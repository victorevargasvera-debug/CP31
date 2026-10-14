using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x0200053B RID: 1339
	[global::System.Serializable]
	public class MPLList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B21E RID: 45598 RVA: 0x00A5728C File Offset: 0x00A5548C
		public MPLList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x00A572CC File Offset: 0x00A554CC
		protected MPLList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x00A572E4 File Offset: 0x00A554E4
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1132841125;
			short num2 = num;
			num = (short)1597229221;
			switch (num2 == num)
			{
			}
			num = (short)2030305280;
			if (num != 0)
			{
			}
			num = (short)1220280320;
			short num3 = num;
			num = (short)1419575297;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駓蛕铗龎郛럝鏟雡", a_);
			base.Id = 10192;
			base.UIName = global::CommonResources.AcgResources.ID_MPLLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x00A573C8 File Offset: 0x00A555C8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1313983093;
			short num2 = num;
			num = (short)1458424437;
			switch (num2 == num)
			{
			}
			num = (short)1832583168;
			if (num != 0)
			{
			}
			num = (short)1013186560;
			short num3 = num;
			num = (short)527499265;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苎臐鿒鯖냘꣚꧜", a_);
			base.Id = 10192;
			base.UIName = global::CommonResources.AcgResources.ID_MPLLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x00A574AC File Offset: 0x00A556AC
		public override void PopulateReferences()
		{
			short num = (short)2083661394;
			short num2 = num;
			num = (short)1391863378;
			switch (num2 == num)
			{
			}
			num = (short)97255425;
			if (num != 0)
			{
			}
			num = (short)152829952;
			short num3 = num;
			num = (short)2115305472;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x00A57558 File Offset: 0x00A55758
		public override void DropReferences()
		{
			short num = (short)1606788581;
			short num2 = num;
			num = (short)1694803429;
			switch (num2 == num)
			{
			}
			num = (short)1397161985;
			if (num != 0)
			{
			}
			num = (short)1094320128;
			short num3 = num;
			num = (short)1324220416;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x00A57604 File Offset: 0x00A55804
		public override void SetConstraints()
		{
			short num = (short)1748566017;
			if (num != 0)
			{
			}
			num = (short)1425614142;
			short num2 = num;
			num = (short)881272126;
			switch (num2 == num)
			{
			}
			num = (short)2142044160;
			short num3 = num;
			num = (short)1127088128;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x00A576B0 File Offset: 0x00A558B0
		public override void SetupDependencies()
		{
			short num = (short)1573030066;
			short num2 = num;
			num = (short)1608878258;
			switch (num2 == num)
			{
			}
			num = (short)1003945985;
			if (num != 0)
			{
			}
			num = (short)1566048256;
			short num3 = num;
			num = (short)374669312;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700593E RID: 22846
		// (get) Token: 0x0600B226 RID: 45606 RVA: 0x00A57758 File Offset: 0x00A55958
		public bool HasDiffs
		{
			get
			{
				short num = (short)917079012;
				short num2 = num;
				num = (short)1236763620;
				switch (num2 == num)
				{
				}
				num = (short)1992491008;
				if (num != 0)
				{
				}
				num = (short)1633288192;
				short num3 = num;
				num = (short)2111111169;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x00A57808 File Offset: 0x00A55A08
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1516192818;
					short num2 = num;
					num = (short)1430209586;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						num = (short)1621819392;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (base.ParentRecset.ContainerDoc != null)
							{
								num = (short)1580335107;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 1:
							if (base.ParentRecset != null)
							{
								num = (short)2076901378;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 2:
							num = (short)1468137472;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)961019905;
							if (num != 0)
							{
							}
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num = (short)938409988;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							return result;
						}
						goto IL_6E;
					}
				}
				return result;
			}
			IL_6E:
			result = null;
			IL_70:
			num = (short)1538523136;
			short num4 = num;
			num = (short)424673281;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04005792 RID: 22418
		private global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerRecset innerRecset;
	}
}
