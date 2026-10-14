using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000331 RID: 817
	[global::System.Serializable]
	public class DEKVIP : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007E33 RID: 32307 RVA: 0x00745B74 File Offset: 0x00743D74
		public DEKVIP(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x00745BB4 File Offset: 0x00743DB4
		protected DEKVIP(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x00745BCC File Offset: 0x00743DCC
		public override void Init()
		{
			int a_ = 10;
			short num = (short)734461952;
			short num2 = num;
			num = (short)1278522315;
			short num3 = num;
			num = (short)42447819;
			switch (num3 == num)
			{
			}
			num = (short)1137836033;
			if (num != 0)
			{
			}
			num = (short)1201340416;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迊裌蓎藒鳔蟖", a_);
			base.Id = 10233;
			base.UIName = global::CommonResources.AcgResources.ID_DEKVIP;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x00745CB0 File Offset: 0x00743EB0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)2097676288;
			short num2 = num;
			num = (short)1106795813;
			short num3 = num;
			num = (short)462839077;
			switch (num3 == num)
			{
			}
			num = (short)141950977;
			if (num != 0)
			{
			}
			num = (short)1179451392;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苅跇臉飍駏苑", a_);
			base.Id = 10233;
			base.UIName = global::CommonResources.AcgResources.ID_DEKVIP;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x00745D94 File Offset: 0x00743F94
		public override void PopulateReferences()
		{
			short num = (short)259522560;
			short num2 = num;
			num = (short)1628707755;
			short num3 = num;
			num = (short)203955115;
			switch (num3 == num)
			{
			}
			num = (short)179634176;
			if (num != 0)
			{
			}
			num = (short)870187009;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x00745E3C File Offset: 0x0074403C
		public override void DropReferences()
		{
			short num = (short)624230400;
			short num2 = num;
			num = (short)2096136395;
			short num3 = num;
			num = (short)1936687307;
			switch (num3 == num)
			{
			}
			num = (short)1845297153;
			if (num != 0)
			{
			}
			num = (short)737935360;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x00745EE4 File Offset: 0x007440E4
		public override void SetConstraints()
		{
			short num = (short)2090074112;
			short num2 = num;
			num = (short)1634001014;
			short num3 = num;
			num = (short)13361270;
			switch (num3 == num)
			{
			}
			num = (short)794034177;
			if (num != 0)
			{
			}
			num = (short)59572224;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x00745F90 File Offset: 0x00744190
		public override void SetupDependencies()
		{
			short num = (short)1390477312;
			short num2 = num;
			num = (short)677979814;
			short num3 = num;
			num = (short)1916479142;
			switch (num3 == num)
			{
			}
			num = (short)1476722689;
			if (num != 0)
			{
			}
			num = (short)1417347072;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700409A RID: 16538
		// (get) Token: 0x06007E3B RID: 32315 RVA: 0x00746038 File Offset: 0x00744238
		public bool HasDiffs
		{
			get
			{
				short num = (short)1033306112;
				short num2 = num;
				num = (short)64230703;
				short num3 = num;
				num = (short)99620143;
				switch (num3 == num)
				{
				}
				num = (short)2123628545;
				if (num != 0)
				{
				}
				num = (short)1548025856;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x007460E8 File Offset: 0x007442E8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num2 = (short)650117124;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_D3;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1803616256;
						short num3 = num2;
						num2 = (short)1674248195;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_15F;
				case 4:
					num2 = (short)745275394;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_D3:
			num2 = (short)1992294401;
			if (num2 != 0)
			{
			}
			return result;
			IL_15F:
			result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
			goto IL_BC;
			IL_24:
			num2 = (short)536919092;
			short num4 = num2;
			num2 = (short)546421812;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BC:
				num2 = (short)73007105;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1117913088;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)779878400;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04003991 RID: 14737
		private global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset innerRecset;
	}
}
