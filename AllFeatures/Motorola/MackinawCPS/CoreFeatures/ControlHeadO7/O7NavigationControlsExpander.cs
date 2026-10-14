using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x020003A4 RID: 932
	[global::System.Serializable]
	public class O7NavigationControlsExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008824 RID: 34852 RVA: 0x007EB440 File Offset: 0x007E9640
		public O7NavigationControlsExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x007EB480 File Offset: 0x007E9680
		protected O7NavigationControlsExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x007EB498 File Offset: 0x007E9698
		public override void Init()
		{
			int a_ = 16;
			short num = (short)1035272192;
			short num2 = num;
			num = (short)713562806;
			short num3 = num;
			num = (short)665000630;
			switch (num3 == num)
			{
			}
			num = (short)358416385;
			if (num != 0)
			{
			}
			num = (short)165871616;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿐닒ꏔ뻖뻘뫚꧜뛞軠跢엤ꓦ蛨藪駬鷮黰鿲蛴", a_);
			base.Id = 10727;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06008827 RID: 34855 RVA: 0x007EB57C File Offset: 0x007E977C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)942145536;
			short num2 = num;
			num = (short)1413138880;
			short num3 = num;
			num = (short)2101791168;
			switch (num3 == num)
			{
			}
			num = (short)1982005249;
			if (num != 0)
			{
			}
			num = (short)718143488;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟈꫊믌ꛎ뛐닒ꇔ뻖뛘뗚﷜鳞軠跢釤闦蛨蟪黬", a_);
			base.Id = 10727;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x007EB660 File Offset: 0x007E9860
		public override void PopulateReferences()
		{
			short num = (short)1740505088;
			short num2 = num;
			num = (short)734280404;
			short num3 = num;
			num = (short)1367882452;
			switch (num3 == num)
			{
			}
			num = (short)724303872;
			if (num != 0)
			{
			}
			num = (short)1802698753;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x007EB70C File Offset: 0x007E990C
		public override void DropReferences()
		{
			short num = (short)112328704;
			short num2 = num;
			num = (short)954176943;
			short num3 = num;
			num = (short)673420719;
			switch (num3 == num)
			{
			}
			num = (short)663093249;
			if (num != 0)
			{
			}
			num = (short)872480768;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600882A RID: 34858 RVA: 0x007EB7B4 File Offset: 0x007E99B4
		public override void SetConstraints()
		{
			short num = (short)1163329536;
			short num2 = num;
			num = (short)1314521089;
			if (num != 0)
			{
			}
			num = (short)1414569279;
			short num3 = num;
			num = (short)1962712383;
			switch (num3 == num)
			{
			}
			num = (short)1728708608;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x007EB860 File Offset: 0x007E9A60
		public override void SetupDependencies()
		{
			short num = (short)62259200;
			short num2 = num;
			num = (short)627038339;
			short num3 = num;
			num = (short)817485955;
			switch (num3 == num)
			{
			}
			num = (short)1429929985;
			if (num != 0)
			{
			}
			num = (short)2024931328;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004539 RID: 17721
		// (get) Token: 0x0600882C RID: 34860 RVA: 0x007EB908 File Offset: 0x007E9B08
		public bool HasDiffs
		{
			get
			{
				short num = (short)487187762;
				short num2 = num;
				num = (short)1258939698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611333632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1151336449;
				if (num != 0)
				{
				}
				num = (short)1310457856;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600882D RID: 34861 RVA: 0x007EB9B8 File Offset: 0x007E9BB8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_95;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1684146756;
				short num2 = num;
				num = (short)2115177028;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)555089920;
					if (num != 0)
					{
					}
					num = (short)308150273;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)1151205377;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_114;
					case 2:
						return result;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1071906818;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.ParentRecset != null)
						{
							num = (short)868548608;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_95;
				}
				IL_114:
				num = (short)1099497472;
				short num4 = num;
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num = (short)1551302659;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_95:
			result = null;
			num = (short)1281687556;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04004000 RID: 16384
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset innerRecset;
	}
}
