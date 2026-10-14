using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003CA RID: 970
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008A53 RID: 35411 RVA: 0x00816D20 File Offset: 0x00814F20
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x00816D60 File Offset: 0x00814F60
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x00816D78 File Offset: 0x00814F78
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1790743908;
			short num2 = num;
			num = (short)173512036;
			switch (num2 == num)
			{
			}
			num = (short)1443037184;
			if (num != 0)
			{
			}
			num = (short)539099136;
			short num3 = num;
			num = (short)1788280833;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏓돕뛗뿙껛뿝賟", a_);
			base.Id = 10235;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x00816E5C File Offset: 0x0081505C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1934505012;
			short num2 = num;
			num = (short)649999412;
			switch (num2 == num)
			{
			}
			num = (short)78446592;
			if (num != 0)
			{
			}
			num = (short)1175977984;
			short num3 = num;
			num = (short)992935937;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛀ꛂꯄꋆ믈꫊ꇌ", a_);
			base.Id = 10235;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x00816F3C File Offset: 0x0081513C
		public override void PopulateReferences()
		{
			short num = (short)1496587823;
			short num2 = num;
			num = (short)1071324719;
			switch (num2 == num)
			{
			}
			num = (short)677052417;
			if (num != 0)
			{
			}
			num = (short)1447100416;
			short num3 = num;
			num = (short)271515648;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x00816FE4 File Offset: 0x008151E4
		public override void DropReferences()
		{
			short num = (short)1149173869;
			short num2 = num;
			num = (short)250478701;
			switch (num2 == num)
			{
			}
			num = (short)1459814401;
			if (num != 0)
			{
			}
			num = (short)1913061376;
			short num3 = num;
			num = (short)675151872;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008A59 RID: 35417 RVA: 0x0081708C File Offset: 0x0081528C
		public override void SetConstraints()
		{
			short num = (short)1073620246;
			short num2 = num;
			num = (short)953099542;
			switch (num2 == num)
			{
			}
			num = (short)433979393;
			if (num != 0)
			{
			}
			num = (short)460521472;
			short num3 = num;
			num = (short)1518862336;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008A5A RID: 35418 RVA: 0x00817138 File Offset: 0x00815338
		public override void SetupDependencies()
		{
			short num = (short)1272891700;
			short num2 = num;
			num = (short)256624948;
			switch (num2 == num)
			{
			}
			num = (short)259850241;
			if (num != 0)
			{
			}
			num = (short)833617920;
			short num3 = num;
			num = (short)901644288;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700462A RID: 17962
		// (get) Token: 0x06008A5B RID: 35419 RVA: 0x008171E0 File Offset: 0x008153E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1953644976;
				short num2 = num;
				num = (short)986857904;
				switch (num2 == num)
				{
				}
				num = (short)906428417;
				if (num != 0)
				{
				}
				num = (short)1457061888;
				short num3 = num;
				num = (short)1333133312;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008A5C RID: 35420 RVA: 0x00817290 File Offset: 0x00815490
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)2051014657;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)60882945;
						if (num2 != 0)
						{
						}
						num2 = (short)1967849472;
						short num3 = num2;
						num2 = (short)1638727684;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						num2 = (short)27590656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)2068446376;
						short num4 = num2;
						num2 = (short)225705128;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)353042432;
							if (num2 != 0)
							{
							}
							if (base.ParentRecset != null)
							{
								num2 = (short)850264066;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						break;
					}
					case 4:
						return result;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)714080259;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x040042CE RID: 17102
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerRecset innerRecset;
	}
}
