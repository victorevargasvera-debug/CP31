using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x02000437 RID: 1079
	[global::System.Serializable]
	public class DTMFCodes : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600920F RID: 37391 RVA: 0x0089B608 File Offset: 0x00899808
		public DTMFCodes(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x0089B648 File Offset: 0x00899848
		protected DTMFCodes(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x0089B660 File Offset: 0x00899860
		public override void Init()
		{
			int a_ = 3;
			short num = (short)39387136;
			short num2 = num;
			num = (short)1234501633;
			if (num != 0)
			{
			}
			num = (short)741117939;
			short num3 = num;
			num = (short)555913203;
			switch (num3 == num)
			{
			}
			num = (short)1718616064;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胃鋅藇賉跍뿏뛑뇓ꗕ", a_);
			base.Id = 10000;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFCODES;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x0089B740 File Offset: 0x00899940
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)447348736;
			short num2 = num;
			num = (short)216436975;
			short num3 = num;
			num = (short)1464766703;
			switch (num3 == num)
			{
			}
			num = (short)1360461825;
			if (num != 0)
			{
			}
			num = (short)1697841152;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軉飋菍雏韓맕볗뿙꿛", a_);
			base.Id = 10000;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFCODES;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x0089B824 File Offset: 0x00899A24
		public override void PopulateReferences()
		{
			short num = (short)591724544;
			short num2 = num;
			num = (short)2124380723;
			short num3 = num;
			num = (short)1498905139;
			switch (num3 == num)
			{
			}
			num = (short)180551681;
			if (num != 0)
			{
			}
			num = (short)1100480512;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x0089B8D0 File Offset: 0x00899AD0
		public override void DropReferences()
		{
			short num = (short)192151552;
			short num2 = num;
			num = (short)1511490794;
			short num3 = num;
			num = (short)1903002858;
			switch (num3 == num)
			{
			}
			num = (short)86441984;
			if (num != 0)
			{
			}
			num = (short)1362034689;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x0089B97C File Offset: 0x00899B7C
		public override void SetConstraints()
		{
			short num = (short)208207872;
			short num2 = num;
			num = (short)1218278550;
			short num3 = num;
			num = (short)654275734;
			switch (num3 == num)
			{
			}
			num = (short)1001521153;
			if (num != 0)
			{
			}
			num = (short)570425344;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x0089BA24 File Offset: 0x00899C24
		public override void SetupDependencies()
		{
			short num = (short)1491861504;
			short num2 = num;
			num = (short)156729541;
			short num3 = num;
			num = (short)706576581;
			switch (num3 == num)
			{
			}
			num = (short)2119434241;
			if (num != 0)
			{
			}
			num = (short)2030567424;
			if (num != 0)
			{
			}
		}

		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x06009217 RID: 37399 RVA: 0x0089BACC File Offset: 0x00899CCC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1462763520;
				short num2 = num;
				num = (short)1804130147;
				short num3 = num;
				num = (short)1084282723;
				switch (num3 == num)
				{
				}
				num = (short)1235419137;
				if (num != 0)
				{
				}
				num = (short)1477705728;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x0089BB7C File Offset: 0x00899D7C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1893531649;
					if (num != 0)
					{
					}
					num = (short)1572208490;
					short num2 = num;
					num = (short)1881997162;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9B;
					default:
						num = (short)863371264;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (base.ParentRecset != null)
							{
								num = (short)1335033857;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 1:
							num = (short)1877475331;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)404619264;
							short num4 = num;
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num = (short)1142947844;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (base.ParentRecset.ContainerDoc != null)
							{
								num = (short)719192066;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 4:
							return result;
						}
						goto IL_99;
					}
				}
				return result;
			}
			IL_99:
			result = null;
			IL_9B:
			num = (short)1318060032;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04004899 RID: 18585
		private global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerRecset innerRecset;
	}
}
