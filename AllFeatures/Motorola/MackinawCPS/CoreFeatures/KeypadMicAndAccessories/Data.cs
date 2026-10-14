using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000307 RID: 775
	[global::System.Serializable]
	public class Data : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007B4B RID: 31563 RVA: 0x007104D4 File Offset: 0x0070E6D4
		public Data(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x00710514 File Offset: 0x0070E714
		protected Data(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x0071052C File Offset: 0x0070E72C
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1977745409;
			if (num != 0)
			{
			}
			num = (short)684095805;
			short num2 = num;
			num = (short)98138429;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2138963968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)802029568;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗", a_);
			base.Id = 10228;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x00710610 File Offset: 0x0070E810
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)2012415574;
			short num2 = num;
			num = (short)145360470;
			switch (num2 == num)
			{
			}
			num = (short)1181286400;
			short num3 = num;
			num = (short)270270465;
			if (num != 0)
			{
			}
			num = (short)713293824;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("資ꯉ룋꿍", a_);
			base.Id = 10228;
			base.UIName = global::CommonResources.AcgResources.ID_DATA;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007B4F RID: 31567 RVA: 0x007106F4 File Offset: 0x0070E8F4
		public override void PopulateReferences()
		{
			short num = (short)1598172194;
			short num2 = num;
			num = (short)56372258;
			switch (num2 == num)
			{
			}
			num = (short)1224933376;
			short num3 = num;
			num = (short)1765474305;
			if (num != 0)
			{
			}
			num = (short)1658322944;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x0071079C File Offset: 0x0070E99C
		public override void DropReferences()
		{
			short num = (short)1926627329;
			if (num != 0)
			{
			}
			num = (short)1950194251;
			short num2 = num;
			num = (short)372218443;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1610285056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2055536640;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x00710844 File Offset: 0x0070EA44
		public override void SetConstraints()
		{
			short num = (short)379992884;
			short num2 = num;
			num = (short)2136619828;
			switch (num2 == num)
			{
			}
			num = (short)1566900224;
			short num3 = num;
			num = (short)1563754497;
			if (num != 0)
			{
			}
			num = (short)1918435328;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x007108F0 File Offset: 0x0070EAF0
		public override void SetupDependencies()
		{
			short num = (short)1856148346;
			short num2 = num;
			num = (short)1936495482;
			switch (num2 == num)
			{
			}
			num = (short)1391919104;
			short num3 = num;
			num = (short)878641153;
			if (num != 0)
			{
			}
			num = (short)245301248;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x06007B53 RID: 31571 RVA: 0x00710998 File Offset: 0x0070EB98
		public bool HasDiffs
		{
			get
			{
				short num = (short)448775490;
				short num2 = num;
				num = (short)239453506;
				switch (num2 == num)
				{
				}
				num = (short)1185677312;
				short num3 = num;
				num = (short)1388576769;
				if (num != 0)
				{
				}
				num = (short)420085760;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x00710A4C File Offset: 0x0070EC4C
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
					if (base.ParentRecset != null)
					{
						num2 = (short)1038745604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1511522304;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)221446144;
					short num3 = num2;
					num2 = (short)587343522;
					short num4 = num2;
					num2 = (short)1877157538;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1567883264;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1370685442;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 4:
					num2 = (short)238878723;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)956301313;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)160563201;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040035E9 RID: 13801
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset innerRecset;
	}
}
