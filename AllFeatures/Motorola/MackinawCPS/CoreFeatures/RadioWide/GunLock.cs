using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000177 RID: 375
	[global::System.Serializable]
	public class GunLock : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600366E RID: 13934 RVA: 0x0033F8B8 File Offset: 0x0033DAB8
		public GunLock(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x0033F8F8 File Offset: 0x0033DAF8
		protected GunLock(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x0033F910 File Offset: 0x0033DB10
		public override void Init()
		{
			int a_ = 12;
			short num = (short)435027969;
			if (num != 0)
			{
			}
			num = (short)175636480;
			short num2 = num;
			num = (short)166152855;
			short num3 = num;
			num = (short)1463044759;
			switch (num3 == num)
			{
			}
			num = (short)1243480064;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諌뫎뿐鿒뫔듖님", a_);
			base.Id = 10606;
			base.UIName = global::CommonResources.AcgResources.ID_GUNLOCK;
			base.DataTransferOrder = 12;
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0033F9F8 File Offset: 0x0033DBF8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1763573761;
			if (num != 0)
			{
			}
			num = (short)70647808;
			short num2 = num;
			num = (short)1642603701;
			short num3 = num;
			num = (short)909124789;
			switch (num3 == num)
			{
			}
			num = (short)31260672;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跉맋ꃍ鳏뷑럓뷕", a_);
			base.Id = 10606;
			base.UIName = global::CommonResources.AcgResources.ID_GUNLOCK;
			base.DataTransferOrder = 12;
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x0033FADC File Offset: 0x0033DCDC
		public override void PopulateReferences()
		{
			short num = (short)1595604993;
			if (num != 0)
			{
			}
			num = (short)732758016;
			short num2 = num;
			num = (short)277526149;
			short num3 = num;
			num = (short)243333;
			switch (num3 == num)
			{
			}
			num = (short)323616768;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x0033FB84 File Offset: 0x0033DD84
		public override void DropReferences()
		{
			short num = (short)1770076609;
			short num2 = num;
			num = (short)981547457;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1235222528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)279183360;
			if (num != 0)
			{
			}
			num = (short)1711734785;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0033FC2C File Offset: 0x0033DE2C
		public override void SetConstraints()
		{
			short num = (short)1714070644;
			short num2 = num;
			num = (short)929408116;
			switch (num2 == num)
			{
			default:
			{
				num = (short)698548224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1979908097;
			if (num != 0)
			{
			}
			num = (short)847577088;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x0033FCD8 File Offset: 0x0033DED8
		public override void SetupDependencies()
		{
			short num = (short)806798059;
			short num2 = num;
			num = (short)1829552875;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1580466176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1111228417;
			if (num != 0)
			{
			}
			num = (short)714539008;
			if (num != 0)
			{
			}
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06003676 RID: 13942 RVA: 0x0033FD80 File Offset: 0x0033DF80
		public bool HasDiffs
		{
			get
			{
				short num = (short)1417176927;
				short num2 = num;
				num = (short)171009887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1686568960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)575995905;
				if (num != 0)
				{
				}
				num = (short)100335616;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x0033FE30 File Offset: 0x0033E030
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)244693313;
			short num2 = num;
			num = (short)551991617;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AD:
				if (base.ParentRecset == null)
				{
					goto IL_137;
				}
				num = (short)1407188992;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)815988736;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					num = (short)1433600002;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_AD;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1474101251;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1530593284;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_F8;
				}
				goto IL_6F;
			}
			IL_F8:
			goto IL_137;
			IL_6F:
			result = null;
			num = (short)1439825920;
			short num4 = num;
			num = (short)1737424897;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
			IL_137:
			num = (short)357498881;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x040011BD RID: 4541
		private global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerRecset innerRecset;
	}
}
