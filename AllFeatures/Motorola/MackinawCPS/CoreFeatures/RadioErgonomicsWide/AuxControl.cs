using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000219 RID: 537
	[global::System.Serializable]
	public class AuxControl : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006347 RID: 25415 RVA: 0x0058E23C File Offset: 0x0058C43C
		public AuxControl(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x0058E27C File Offset: 0x0058C47C
		protected AuxControl(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x0058E294 File Offset: 0x0058C494
		public override void Init()
		{
			int a_ = 1;
			short num = (short)1180381686;
			short num2 = num;
			num = (short)1251422710;
			switch (num2 == num)
			{
			}
			num = (short)17235968;
			if (num != 0)
			{
			}
			num = (short)514981888;
			short num3 = num;
			num = (short)1194196993;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菁뇃뻅觉ꏋꃍ꓏ꃑ믓뫕", a_);
			base.Id = 10633;
			base.UIName = global::CommonResources.AcgResources.ID_AUXCONTROL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x0058E378 File Offset: 0x0058C578
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1233626936;
			short num2 = num;
			num = (short)2054596408;
			switch (num2 == num)
			{
			}
			num = (short)919207937;
			if (num != 0)
			{
			}
			num = (short)1406140416;
			short num3 = num;
			num = (short)483459072;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓄닆뇈軌ꃎ뿐꟒꟔룖뗘", a_);
			base.Id = 10633;
			base.UIName = global::CommonResources.AcgResources.ID_AUXCONTROL;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x0058E45C File Offset: 0x0058C65C
		public override void PopulateReferences()
		{
			short num = (short)1452408833;
			if (num != 0)
			{
			}
			num = (short)1788945361;
			short num2 = num;
			num = (short)444736465;
			switch (num2 == num)
			{
			}
			num = (short)1733099520;
			short num3 = num;
			num = (short)732102656;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x0058E504 File Offset: 0x0058C704
		public override void DropReferences()
		{
			short num = (short)2112094209;
			if (num != 0)
			{
			}
			num = (short)1174373107;
			short num2 = num;
			num = (short)859931379;
			switch (num2 == num)
			{
			}
			num = (short)1710227456;
			short num3 = num;
			num = (short)2020999168;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x0058E5AC File Offset: 0x0058C7AC
		public override void SetConstraints()
		{
			short num = (short)937615220;
			short num2 = num;
			num = (short)1105518452;
			switch (num2 == num)
			{
			}
			num = (short)348061697;
			if (num != 0)
			{
			}
			num = (short)76283904;
			short num3 = num;
			num = (short)1447428096;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x0058E658 File Offset: 0x0058C858
		public override void SetupDependencies()
		{
			short num = (short)903341192;
			short num2 = num;
			num = (short)752346248;
			switch (num2 == num)
			{
			}
			num = (short)465764352;
			if (num != 0)
			{
			}
			num = (short)1649213440;
			short num3 = num;
			num = (short)198180865;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600634F RID: 25423 RVA: 0x0058E700 File Offset: 0x0058C900
		public bool HasDiffs
		{
			get
			{
				short num = (short)625913332;
				short num2 = num;
				num = (short)786804212;
				switch (num2 == num)
				{
				}
				num = (short)1671430145;
				if (num != 0)
				{
				}
				num = (short)1526857728;
				short num3 = num;
				num = (short)1425408000;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x0058E7B0 File Offset: 0x0058C9B0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_97;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1235744819;
				short num2 = num;
				num = (short)1714288691;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_97;
				default:
					num = (short)268894209;
					if (num != 0)
					{
					}
					num = (short)1052639232;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1967587330;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)1644560385;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.ParentRecset != null)
						{
							num = (short)1571880960;
							short num4 = num;
							num = (short)1548222468;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						num = (short)8388608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
				}
			}
			return result;
			IL_97:
			result = null;
			num = (short)414121987;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04002627 RID: 9767
		private global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset innerRecset;
	}
}
