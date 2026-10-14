using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200046A RID: 1130
	[global::System.Serializable]
	public class TxSynthesizerReferenceDividerList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600959D RID: 38301 RVA: 0x008C9DDC File Offset: 0x008C7FDC
		public TxSynthesizerReferenceDividerList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600959E RID: 38302 RVA: 0x008C9E1C File Offset: 0x008C801C
		protected TxSynthesizerReferenceDividerList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600959F RID: 38303 RVA: 0x008C9E34 File Offset: 0x008C8034
		public override void Init()
		{
			int a_ = 7;
			short num = (short)1312833958;
			short num2 = num;
			num = (short)1920024998;
			switch (num2 == num)
			{
			default:
			{
				num = (short)283246592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1373110273;
			if (num != 0)
			{
			}
			num = (short)923271168;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳇닉鷍ꧏ병ꃓ뻕뷗꧙뗛ꓝ藟郡쓣듥跧賩觫鳭闯鳱音鏵\ud8f7뻹闻製槿昁愃琅⠇䘉攋納搏", a_);
			base.Id = 10008;
			base.UIName = global::CommonResources.AcgResources.ID_TXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060095A0 RID: 38304 RVA: 0x008C9F18 File Offset: 0x008C8118
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1496449025;
			if (num != 0)
			{
			}
			num = (short)885981184;
			short num2 = num;
			num = (short)1460171440;
			short num3 = num;
			num = (short)1387164336;
			switch (num3 == num)
			{
			}
			num = (short)111345664;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓏꫑藕ꇗ듙꣛뛝藟釡跣鳥跧飩쳫볭闯铱釳蓵鷷铹鿻鯽⃿䘁洃瀅愇渉椋簍』帑紓攕気", a_);
			base.Id = 10008;
			base.UIName = global::CommonResources.AcgResources.ID_TXSYNTHESIZERREFERENCEDIVIDERLIST;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x008C9FFC File Offset: 0x008C81FC
		public override void PopulateReferences()
		{
			short num = (short)1064195618;
			short num2 = num;
			num = (short)1415271970;
			switch (num2 == num)
			{
			default:
			{
				num = (short)424476672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)673644544;
			if (num != 0)
			{
			}
			num = (short)2011037697;
			if (num != 0)
			{
			}
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x008CA0A4 File Offset: 0x008C82A4
		public override void DropReferences()
		{
			short num = (short)387890032;
			short num2 = num;
			num = (short)1086569328;
			switch (num2 == num)
			{
			default:
			{
				num = (short)493682688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1997144064;
			if (num != 0)
			{
			}
			num = (short)2139422721;
			if (num != 0)
			{
			}
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x008CA14C File Offset: 0x008C834C
		public override void SetConstraints()
		{
			short num = (short)518520833;
			if (num != 0)
			{
			}
			num = (short)303431680;
			short num2 = num;
			num = (short)1228988282;
			short num3 = num;
			num = (short)819126138;
			switch (num3 == num)
			{
			}
			num = (short)883425280;
			if (num != 0)
			{
			}
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x008CA1F8 File Offset: 0x008C83F8
		public override void SetupDependencies()
		{
			short num = (short)1996555478;
			short num2 = num;
			num = (short)713098454;
			switch (num2 == num)
			{
			default:
			{
				num = (short)577896448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1702821888;
			if (num != 0)
			{
			}
			num = (short)1975451649;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x060095A5 RID: 38309 RVA: 0x008CA2A4 File Offset: 0x008C84A4
		public bool HasDiffs
		{
			get
			{
				short num = (short)379718040;
				short num2 = num;
				num = (short)1407125912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)568000512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)139329537;
				if (num != 0)
				{
				}
				num = (short)1392050176;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060095A6 RID: 38310 RVA: 0x008CA358 File Offset: 0x008C8558
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
					num2 = (short)128450564;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)398196736;
					short num3 = num2;
					num2 = (short)1428488193;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1547108354;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)771162112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)854725455;
					short num4 = num2;
					num2 = (short)1868501839;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)938278912;
						if (num2 != 0)
						{
						}
						num2 = (short)406192129;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)412221443;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004A0B RID: 18955
		private global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInnerRecset innerRecset;
	}
}
