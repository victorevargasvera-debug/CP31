using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002B5 RID: 693
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060074E9 RID: 29929 RVA: 0x00698234 File Offset: 0x00696434
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x00698274 File Offset: 0x00696474
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x0069828C File Offset: 0x0069648C
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1107820545;
			if (num != 0)
			{
			}
			num = (short)1065318311;
			short num2 = num;
			num = (short)1973188519;
			switch (num2 == num)
			{
			}
			num = (short)601554944;
			if (num != 0)
			{
			}
			num = (short)1418919936;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铒냔맖볘꧚볜돞", a_);
			base.Id = 10081;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x00698370 File Offset: 0x00696570
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)699471768;
			short num2 = num;
			num = (short)273160088;
			switch (num2 == num)
			{
			}
			num = (short)1680998401;
			if (num != 0)
			{
			}
			num = (short)1969881088;
			if (num != 0)
			{
			}
			num = (short)855179264;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("过꿉ꋋꯍꋏ돑룓", a_);
			base.Id = 10081;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x00698454 File Offset: 0x00696654
		public override void PopulateReferences()
		{
			short num = (short)268181276;
			short num2 = num;
			num = (short)1537220380;
			switch (num2 == num)
			{
			}
			num = (short)513409024;
			if (num != 0)
			{
			}
			num = (short)1953693697;
			if (num != 0)
			{
			}
			num = (short)1535442944;
			short num3 = num;
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x006984FC File Offset: 0x006966FC
		public override void DropReferences()
		{
			short num = (short)1921171648;
			short num2 = num;
			num = (short)572506304;
			switch (num2 == num)
			{
			}
			num = (short)297861120;
			if (num != 0)
			{
			}
			num = (short)951844865;
			if (num != 0)
			{
			}
			num = (short)6160384;
			short num3 = num;
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x006985A8 File Offset: 0x006967A8
		public override void SetConstraints()
		{
			short num = (short)926779843;
			short num2 = num;
			num = (short)1489537475;
			switch (num2 == num)
			{
			}
			num = (short)1786970112;
			if (num != 0)
			{
			}
			num = (short)1869414401;
			if (num != 0)
			{
			}
			num = (short)542769152;
			short num3 = num;
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x00698654 File Offset: 0x00696854
		public override void SetupDependencies()
		{
			short num = (short)681315360;
			short num2 = num;
			num = (short)1764756512;
			switch (num2 == num)
			{
			}
			num = (short)1296171009;
			if (num != 0)
			{
			}
			num = (short)816119808;
			if (num != 0)
			{
			}
			num = (short)1159135232;
			short num3 = num;
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x060074F1 RID: 29937 RVA: 0x00698700 File Offset: 0x00696900
		public bool HasDiffs
		{
			get
			{
				short num = (short)1899107931;
				short num2 = num;
				num = (short)850925147;
				switch (num2 == num)
				{
				}
				num = (short)137363456;
				if (num != 0)
				{
				}
				num = (short)1166671873;
				if (num != 0)
				{
				}
				num = (short)1052835840;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x006987B0 File Offset: 0x006969B0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1568332334;
					short num3 = num2;
					num2 = (short)1120721454;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1398407169;
						if (num2 != 0)
						{
						}
						num2 = (short)1089667072;
						if (num2 != 0)
						{
						}
						num2 = (short)99680256;
						short num4 = num2;
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						break;
					}
					}
					num2 = (short)419299330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1593442304;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					num2 = (short)2030501889;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)2083454979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1599537156;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002F77 RID: 12151
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset innerRecset;
	}
}
