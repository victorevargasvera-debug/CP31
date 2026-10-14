using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000508 RID: 1288
	[global::System.Serializable]
	public class EIDBypassList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AA97 RID: 43671 RVA: 0x009F2634 File Offset: 0x009F0834
		public EIDBypassList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600AA98 RID: 43672 RVA: 0x009F2674 File Offset: 0x009F0874
		protected EIDBypassList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x009F268C File Offset: 0x009F088C
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1893793792;
			short num2 = num;
			num = (short)1054730192;
			short num3 = num;
			num = (short)688646096;
			switch (num3 == num)
			{
			}
			num = (short)513409025;
			if (num != 0)
			{
			}
			num = (short)78577664;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雓꿕꣗믙꿛귝샟껡跣闥鳧", a_);
			base.Id = 10601;
			base.UIName = global::CommonResources.AcgResources.ID_BYPASSLIST;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x009F2770 File Offset: 0x009F0970
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)814481408;
			short num2 = num;
			num = (short)230205146;
			short num3 = num;
			num = (short)65906394;
			switch (num3 == num)
			{
			}
			num = (short)1647509505;
			if (num != 0)
			{
			}
			num = (short)824770560;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("談돉볋꿍ꏏꇑ髕뇗꧙꣛", a_);
			base.Id = 10601;
			base.UIName = global::CommonResources.AcgResources.ID_BYPASSLIST;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x009F2854 File Offset: 0x009F0A54
		public override void PopulateReferences()
		{
			short num = (short)867368960;
			short num2 = num;
			num = (short)1845827908;
			short num3 = num;
			num = (short)1059985732;
			switch (num3 == num)
			{
			}
			num = (short)1591214080;
			if (num != 0)
			{
			}
			num = (short)1014235137;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA9C RID: 43676 RVA: 0x009F28FC File Offset: 0x009F0AFC
		public override void DropReferences()
		{
			short num = (short)22609920;
			short num2 = num;
			num = (short)1336222527;
			short num3 = num;
			num = (short)1483875135;
			switch (num3 == num)
			{
			}
			num = (short)223412225;
			if (num != 0)
			{
			}
			num = (short)761724928;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x009F29A4 File Offset: 0x009F0BA4
		public override void SetConstraints()
		{
			short num = (short)1574567936;
			short num2 = num;
			num = (short)1641750526;
			short num3 = num;
			num = (short)227483646;
			switch (num3 == num)
			{
			}
			num = (short)745078785;
			if (num != 0)
			{
			}
			num = (short)1230700544;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AA9E RID: 43678 RVA: 0x009F2A4C File Offset: 0x009F0C4C
		public override void SetupDependencies()
		{
			short num = (short)1442840576;
			short num2 = num;
			num = (short)577685158;
			short num3 = num;
			num = (short)1269221030;
			switch (num3 == num)
			{
			}
			num = (short)2134704129;
			if (num != 0)
			{
			}
			num = (short)986185728;
			if (num != 0)
			{
			}
		}

		// Token: 0x17005564 RID: 21860
		// (get) Token: 0x0600AA9F RID: 43679 RVA: 0x009F2AF8 File Offset: 0x009F0CF8
		public bool HasDiffs
		{
			get
			{
				short num = (short)235405312;
				short num2 = num;
				num = (short)1911319732;
				short num3 = num;
				num = (short)1008102580;
				switch (num3 == num)
				{
				}
				num = (short)2096955392;
				if (num != 0)
				{
				}
				num = (short)552206337;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600AAA0 RID: 43680 RVA: 0x009F2BAC File Offset: 0x009F0DAC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)606518969;
			short num2 = num;
			num = (short)752598713;
			global::AcpCommonLib.IAcpRecordset result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D5:
				if (base.ParentRecset == null)
				{
					return result;
				}
				num = (short)887750657;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)1964572672;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_A4:
				switch (num3)
				{
				case 0:
					goto IL_D5;
				case 1:
					num = (short)126287874;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1404633091;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)420085764;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_11A;
				}
				goto IL_BE;
			}
			IL_11A:
			return result;
			IL_5E:
			num = (short)717881345;
			if (num != 0)
			{
			}
			num = (short)1205600256;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_BE;
			}
			goto IL_A4;
			IL_BE:
			result = null;
			num = (short)815857664;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_A4;
		}

		// Token: 0x040053A3 RID: 21411
		private global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset innerRecset;
	}
}
