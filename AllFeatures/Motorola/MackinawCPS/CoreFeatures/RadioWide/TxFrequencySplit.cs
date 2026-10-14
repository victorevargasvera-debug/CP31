using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000189 RID: 393
	[global::System.Serializable]
	public class TxFrequencySplit : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003FC5 RID: 16325 RVA: 0x003BE87C File Offset: 0x003BCA7C
		public TxFrequencySplit(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x003BE8BC File Offset: 0x003BCABC
		protected TxFrequencySplit(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x003BE8D4 File Offset: 0x003BCAD4
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1464991745;
			if (num != 0)
			{
			}
			num = (short)181723047;
			short num2 = num;
			num = (short)1028317095;
			switch (num2 == num)
			{
			}
			num = (short)347406336;
			if (num != 0)
			{
			}
			num = (short)1247608832;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋅냇請볍뗏ꏑꇓ돕뛗맙ꗛﻝ돟鋡裣迥鳧", a_);
			base.Id = 10094;
			base.UIName = global::CommonResources.AcgResources.ID_TXFREQUENCYSPLIT;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x003BE9B8 File Offset: 0x003BCBB8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)2048023582;
			short num2 = num;
			num = (short)1980324894;
			switch (num2 == num)
			{
			}
			num = (short)832045057;
			if (num != 0)
			{
			}
			num = (short)2135293952;
			if (num != 0)
			{
			}
			num = (short)1672740864;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郃뻅賉뻋ꯍꇏꟑ뇓룕믗ꏙﳛ距郟軡跣鋥", a_);
			base.Id = 10094;
			base.UIName = global::CommonResources.AcgResources.ID_TXFREQUENCYSPLIT;
			base.DataTransferOrder = 10;
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x003BEA9C File Offset: 0x003BCC9C
		public override void PopulateReferences()
		{
			short num = (short)1779302401;
			if (num != 0)
			{
			}
			num = (short)1539201996;
			short num2 = num;
			num = (short)910187468;
			switch (num2 == num)
			{
			}
			num = (short)1767112704;
			if (num != 0)
			{
			}
			num = (short)655949824;
			short num3 = num;
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x003BEB48 File Offset: 0x003BCD48
		public override void DropReferences()
		{
			short num = (short)1211549720;
			short num2 = num;
			num = (short)1108461592;
			switch (num2 == num)
			{
			}
			num = (short)847839232;
			if (num != 0)
			{
			}
			num = (short)91291649;
			if (num != 0)
			{
			}
			num = (short)1941176320;
			short num3 = num;
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x003BEBF0 File Offset: 0x003BCDF0
		public override void SetConstraints()
		{
			short num = (short)57748238;
			short num2 = num;
			num = (short)1759783694;
			switch (num2 == num)
			{
			}
			num = (short)737607680;
			if (num != 0)
			{
			}
			num = (short)384303105;
			if (num != 0)
			{
			}
			num = (short)952696832;
			short num3 = num;
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x003BEC98 File Offset: 0x003BCE98
		public override void SetupDependencies()
		{
			short num = (short)977884684;
			short num2 = num;
			num = (short)1005671948;
			switch (num2 == num)
			{
			}
			num = (short)1440350209;
			if (num != 0)
			{
			}
			num = (short)397869056;
			if (num != 0)
			{
			}
			num = (short)714407936;
			short num3 = num;
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x003BED40 File Offset: 0x003BCF40
		public bool HasDiffs
		{
			get
			{
				short num = (short)196454844;
				short num2 = num;
				num = (short)1792977340;
				switch (num2 == num)
				{
				}
				num = (short)556597249;
				if (num != 0)
				{
				}
				num = (short)1746075648;
				if (num != 0)
				{
				}
				num = (short)1390673920;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x003BEDF0 File Offset: 0x003BCFF0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)569180160;
						short num3 = num2;
						num2 = (short)538050563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)876085248;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11A;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)481034244;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11A;
					case 3:
						goto IL_AE;
					case 4:
						num2 = (short)1645150209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				IL_11A:
				num2 = (short)507163250;
				short num4 = num2;
				num2 = (short)1466806898;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_151;
				}
				IL_AE:
				num2 = (short)1346240513;
				if (num2 != 0)
				{
				}
				goto IL_11A;
				IL_24:
				result = null;
				num2 = (short)129236994;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_151:
			num2 = (short)1602617344;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x040019F8 RID: 6648
		private global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset innerRecset;
	}
}
