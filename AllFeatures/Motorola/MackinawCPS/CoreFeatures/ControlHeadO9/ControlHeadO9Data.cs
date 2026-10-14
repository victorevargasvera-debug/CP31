using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000350 RID: 848
	[global::System.Serializable]
	public class ControlHeadO9Data : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060081A3 RID: 33187 RVA: 0x0078AA3C File Offset: 0x00788C3C
		public ControlHeadO9Data(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x0078AA7C File Offset: 0x00788C7C
		protected ControlHeadO9Data(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x0078AA94 File Offset: 0x00788C94
		public override void Init()
		{
			int a_ = 0;
			short num = (short)410039323;
			short num2 = num;
			num = (short)986625051;
			switch (num2 == num)
			{
			}
			num = (short)1624899584;
			short num3 = num;
			num = (short)1885667329;
			if (num != 0)
			{
			}
			num = (short)1912274944;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ", a_);
			base.Id = 10611;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x0078AB78 File Offset: 0x00788D78
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)278063554;
			short num2 = num;
			num = (short)2069031362;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1348796416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1344143360;
			if (num != 0)
			{
			}
			num = (short)86179841;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛁ꗃ닅꧇", a_);
			base.Id = 10611;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 5;
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x0078AC58 File Offset: 0x00788E58
		public override void PopulateReferences()
		{
			short num = (short)1908932609;
			if (num != 0)
			{
			}
			num = (short)1071382528;
			short num2 = num;
			num = (short)1033261298;
			short num3 = num;
			num = (short)12865778;
			switch (num3 == num)
			{
			}
			num = (short)1530789888;
			if (num != 0)
			{
			}
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x0078AD00 File Offset: 0x00788F00
		public override void DropReferences()
		{
			short num = (short)1298532987;
			short num2 = num;
			num = (short)744753787;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1141506048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)579665920;
			if (num != 0)
			{
			}
			num = (short)1270546433;
			if (num != 0)
			{
			}
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x0078ADA8 File Offset: 0x00788FA8
		public override void SetConstraints()
		{
			short num = (short)174129153;
			if (num != 0)
			{
			}
			num = (short)146604032;
			short num2 = num;
			num = (short)226501835;
			short num3 = num;
			num = (short)1380525259;
			switch (num3 == num)
			{
			}
			num = (short)1240465408;
			if (num != 0)
			{
			}
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x0078AE50 File Offset: 0x00789050
		public override void SetupDependencies()
		{
			short num = (short)586416129;
			if (num != 0)
			{
			}
			num = (short)1940652032;
			short num2 = num;
			num = (short)2011125454;
			short num3 = num;
			num = (short)1563973326;
			switch (num3 == num)
			{
			}
			num = (short)103546880;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004213 RID: 16915
		// (get) Token: 0x060081AB RID: 33195 RVA: 0x0078AEFC File Offset: 0x007890FC
		public bool HasDiffs
		{
			get
			{
				short num = (short)942552751;
				short num2 = num;
				num = (short)375338671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)715259904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1836711937;
				if (num != 0)
				{
				}
				num = (short)1618608128;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060081AC RID: 33196 RVA: 0x0078AFA8 File Offset: 0x007891A8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						num2 = (short)379781124;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return result;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)642383872;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)477822977;
						if (num2 != 0)
						{
						}
						num2 = (short)1419182081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1065353219;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				IL_24:
				num2 = (short)1692146722;
				short num3 = num2;
				num2 = (short)791419938;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1525678080;
					short num4 = num2;
					num2 = (short)1247805440;
					if (num2 != 0)
					{
					}
					result = null;
					num2 = (short)716308482;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			return result;
		}

		// Token: 0x04003BA5 RID: 15269
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset innerRecset;
	}
}
