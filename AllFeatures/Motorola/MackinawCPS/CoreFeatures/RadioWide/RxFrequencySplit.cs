using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000181 RID: 385
	[global::System.Serializable]
	public class RxFrequencySplit : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003E51 RID: 15953 RVA: 0x003AD3C0 File Offset: 0x003AB5C0
		public RxFrequencySplit(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x003AD400 File Offset: 0x003AB600
		protected RxFrequencySplit(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x003AD418 File Offset: 0x003AB618
		public override void Init()
		{
			int a_ = 1;
			short num = (short)1944655943;
			short num2 = num;
			num = (short)1090263111;
			switch (num2 == num)
			{
			}
			num = (short)657915904;
			short num3 = num;
			num = (short)1134231553;
			if (num != 0)
			{
			}
			num = (short)1950941184;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郁볃軇룉꧋뿍ꗏ럑뫓뗕ꇗ龎进껝賟诡郣", a_);
			base.Id = 10096;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYSPLIT;
			base.DataTransferOrder = 9;
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x003AD4FC File Offset: 0x003AB6FC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1177035100;
			short num2 = num;
			num = (short)92479836;
			switch (num2 == num)
			{
			}
			num = (short)635895808;
			short num3 = num;
			num = (short)854654976;
			if (num != 0)
			{
			}
			num = (short)681312257;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髇닉裍ꋏ럑ꗓꏕ뷗듙뿛꟝샟뇡铣諥臧黩", a_);
			base.Id = 10096;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYSPLIT;
			base.DataTransferOrder = 9;
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x003AD5E4 File Offset: 0x003AB7E4
		public override void PopulateReferences()
		{
			short num = (short)792338615;
			short num2 = num;
			num = (short)586162359;
			switch (num2 == num)
			{
			}
			num = (short)2091384832;
			short num3 = num;
			num = (short)936968193;
			if (num != 0)
			{
			}
			num = (short)1029046272;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x003AD68C File Offset: 0x003AB88C
		public override void DropReferences()
		{
			short num = (short)1829815471;
			short num2 = num;
			num = (short)42255535;
			switch (num2 == num)
			{
			}
			num = (short)1465712640;
			short num3 = num;
			num = (short)1223688193;
			if (num != 0)
			{
			}
			num = (short)564527104;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x003AD734 File Offset: 0x003AB934
		public override void SetConstraints()
		{
			short num = (short)39927623;
			short num2 = num;
			num = (short)1272659783;
			switch (num2 == num)
			{
			}
			num = (short)1508835328;
			short num3 = num;
			num = (short)1624637440;
			if (num != 0)
			{
			}
			num = (short)1998127105;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x003AD7DC File Offset: 0x003AB9DC
		public override void SetupDependencies()
		{
			short num = (short)1973617616;
			short num2 = num;
			num = (short)681182160;
			switch (num2 == num)
			{
			}
			num = (short)1628307456;
			short num3 = num;
			num = (short)2061500417;
			if (num != 0)
			{
			}
			num = (short)1483997184;
			if (num != 0)
			{
			}
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x003AD888 File Offset: 0x003ABA88
		public bool HasDiffs
		{
			get
			{
				short num = (short)265605450;
				short num2 = num;
				num = (short)2013122890;
				switch (num2 == num)
				{
				}
				num = (short)667615232;
				short num3 = num;
				num = (short)1634009088;
				if (num != 0)
				{
				}
				num = (short)1272512513;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x003AD934 File Offset: 0x003ABB34
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					num2 = (short)394583414;
					short num3 = num2;
					num2 = (short)99409270;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1887895552;
						if (num2 != 0)
						{
						}
						num2 = (short)811073537;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1804468226;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1943142400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)227934208;
					short num4 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)2070806532;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 4:
					num2 = (short)1367998465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)852295683;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040019E3 RID: 6627
		private global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset innerRecset;
	}
}
