using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002E7 RID: 743
	[global::System.Serializable]
	public class GCAI : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060078CC RID: 30924 RVA: 0x006DEB18 File Offset: 0x006DCD18
		public GCAI(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x006DEB58 File Offset: 0x006DCD58
		protected GCAI(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060078CE RID: 30926 RVA: 0x006DEB70 File Offset: 0x006DCD70
		public override void Init()
		{
			int a_ = 13;
			short num = (short)29954589;
			short num2 = num;
			num = (short)784798237;
			switch (num2 == num)
			{
			default:
			{
				num = (short)131137536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1711210496;
			if (num != 0)
			{
			}
			num = (short)958464001;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觍鏏鏑鷓", a_);
			base.Id = 10797;
			base.UIName = global::CommonResources.AcgResources.ID_GCAI;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x006DEC50 File Offset: 0x006DCE50
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1535520467;
			short num2 = num;
			num = (short)601173715;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1329332224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1801584640;
			if (num != 0)
			{
			}
			num = (short)1049296897;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈裊賌蛎", a_);
			base.Id = 10797;
			base.UIName = global::CommonResources.AcgResources.ID_GCAI;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x006DED38 File Offset: 0x006DCF38
		public override void PopulateReferences()
		{
			short num = (short)1871441620;
			short num2 = num;
			num = (short)1314975444;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1453457408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1024917504;
			if (num != 0)
			{
			}
			num = (short)208142337;
			if (num != 0)
			{
			}
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x006DEDE0 File Offset: 0x006DCFE0
		public override void DropReferences()
		{
			short num = (short)2059484521;
			short num2 = num;
			num = (short)334904681;
			switch (num2 == num)
			{
			}
			num = (short)1154220033;
			if (num != 0)
			{
			}
			num = (short)1605173248;
			if (num != 0)
			{
			}
			num = (short)1788411904;
			short num3 = num;
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x006DEE88 File Offset: 0x006DD088
		public override void SetConstraints()
		{
			short num = (short)858998926;
			short num2 = num;
			num = (short)114706574;
			switch (num2 == num)
			{
			}
			num = (short)1681063936;
			if (num != 0)
			{
			}
			num = (short)422903809;
			if (num != 0)
			{
			}
			num = (short)1653866496;
			short num3 = num;
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x006DEF30 File Offset: 0x006DD130
		public override void SetupDependencies()
		{
			short num = (short)1664346927;
			short num2 = num;
			num = (short)1115024175;
			switch (num2 == num)
			{
			}
			num = (short)1136459777;
			if (num != 0)
			{
			}
			num = (short)570753024;
			if (num != 0)
			{
			}
			num = (short)262209536;
			short num3 = num;
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x060078D4 RID: 30932 RVA: 0x006DEFD8 File Offset: 0x006DD1D8
		public bool HasDiffs
		{
			get
			{
				short num = (short)213581825;
				if (num != 0)
				{
				}
				num = (short)724574777;
				short num2 = num;
				num = (short)2006655545;
				switch (num2 == num)
				{
				}
				num = (short)1994326016;
				if (num != 0)
				{
				}
				num = (short)1949892608;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x006DF088 File Offset: 0x006DD288
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1498873857;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return result;
					case 2:
						num2 = (short)819920899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)1950875931;
						short num3 = num2;
						num2 = (short)920650011;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)1202585600;
							if (num2 != 0)
							{
							}
							if (base.ParentRecset.ContainerDoc != null)
							{
								num2 = (short)270204928;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						break;
					}
					case 4:
						num2 = (short)532873217;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num2 = (short)526123008;
							short num4 = num2;
							num2 = (short)261881858;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)817299460;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003349 RID: 13129
		private global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset innerRecset;
	}
}
