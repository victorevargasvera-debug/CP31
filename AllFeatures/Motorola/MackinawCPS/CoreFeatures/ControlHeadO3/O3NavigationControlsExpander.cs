using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003CE RID: 974
	[global::System.Serializable]
	public class O3NavigationControlsExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008B10 RID: 35600 RVA: 0x0081FBB8 File Offset: 0x0081DDB8
		public O3NavigationControlsExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x0081FBF8 File Offset: 0x0081DDF8
		protected O3NavigationControlsExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x0081FC10 File Offset: 0x0081DE10
		public override void Init()
		{
			int a_ = 13;
			short num = (short)832175233;
			short num2 = num;
			num = (short)1699150977;
			switch (num2 == num)
			{
			}
			num = (short)1592655872;
			short num3 = num;
			num = (short)573177857;
			if (num != 0)
			{
			}
			num = (short)135725056;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胍뇏ꓑ뷓뇕맗껙뗛뇝軟싡꟣觥蛧黩黫臭鳯臱", a_);
			base.Id = 10732;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x0081FCF4 File Offset: 0x0081DEF4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)250099423;
			short num2 = num;
			num = (short)1253914335;
			switch (num2 == num)
			{
			}
			num = (short)1353646080;
			short num3 = num;
			num = (short)610926593;
			if (num != 0)
			{
			}
			num = (short)855965696;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("评ꛆ뿈ꋊ꫌껎ꗐ뫒뫔맖律飚닜뇞闠釢諤详髨", a_);
			base.Id = 10732;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x0081FDDC File Offset: 0x0081DFDC
		public override void PopulateReferences()
		{
			short num = (short)1093635022;
			short num2 = num;
			num = (short)1554615246;
			switch (num2 == num)
			{
			}
			num = (short)309985280;
			short num3 = num;
			num = (short)148242433;
			if (num != 0)
			{
			}
			num = (short)71499776;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x0081FE88 File Offset: 0x0081E088
		public override void DropReferences()
		{
			short num = (short)2054566230;
			short num2 = num;
			num = (short)448803158;
			switch (num2 == num)
			{
			}
			num = (short)2054422528;
			short num3 = num;
			num = (short)651165697;
			if (num != 0)
			{
			}
			num = (short)1676804096;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x0081FF34 File Offset: 0x0081E134
		public override void SetConstraints()
		{
			short num = (short)1723400193;
			if (num != 0)
			{
			}
			num = (short)1214865943;
			short num2 = num;
			num = (short)1511940631;
			switch (num2 == num)
			{
			default:
			{
				num = (short)912523264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)229638144;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x0081FFE0 File Offset: 0x0081E1E0
		public override void SetupDependencies()
		{
			short num = (short)973146623;
			short num2 = num;
			num = (short)448334335;
			switch (num2 == num)
			{
			}
			num = (short)48693248;
			short num3 = num;
			num = (short)860880897;
			if (num != 0)
			{
			}
			num = (short)196870144;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x06008B18 RID: 35608 RVA: 0x00820088 File Offset: 0x0081E288
		public bool HasDiffs
		{
			get
			{
				short num = (short)1552719051;
				short num2 = num;
				num = (short)514497739;
				switch (num2 == num)
				{
				}
				num = (short)1349058560;
				short num3 = num;
				num = (short)615120897;
				if (num != 0)
				{
				}
				num = (short)486080512;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x00820138 File Offset: 0x0081E338
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1775435777;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					num = (short)1018953730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)295239683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
				{
					num = (short)749908940;
					short num3 = num;
					num = (short)643019724;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)1776615424;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1487929344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (base.ParentRecset != null)
					{
						num = (short)793903105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4A;
			}
			return result;
			IL_4A:
			result = null;
			num = (short)194772992;
			short num4 = num;
			num = (short)467730436;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x040042DC RID: 17116
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset innerRecset;
	}
}
