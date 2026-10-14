using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200037E RID: 894
	[global::System.Serializable]
	public class RelayPatternBCOList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008414 RID: 33812 RVA: 0x007AB8F8 File Offset: 0x007A9AF8
		public RelayPatternBCOList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x007AB938 File Offset: 0x007A9B38
		protected RelayPatternBCOList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x007AB950 File Offset: 0x007A9B50
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1343755489;
			short num2 = num;
			num = (short)95032545;
			switch (num2 == num)
			{
			default:
			{
				num = (short)61538304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)468975617;
			if (num != 0)
			{
			}
			num = (short)836108288;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駊꣌ꏎ냐꫒蟖룘꿚꧜뫞鏠跢엤ꗦꫨꓪ췬ꏮ飰胲致", a_);
			base.Id = 10620;
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERNBCOLIST;
			base.DataTransferOrder = 9;
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x007ABA34 File Offset: 0x007A9C34
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)967425225;
			short num2 = num;
			num = (short)1652866249;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1388642304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)682754049;
			if (num != 0)
			{
			}
			num = (short)1284046848;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏀ꛂ꧄ꛆ냈鷌껎ꗐ꟒냔ꗖ럘ﯚ鿜鳞껠쏢ꧤ軦髨鿪", a_);
			base.Id = 10620;
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERNBCOLIST;
			base.DataTransferOrder = 9;
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x007ABB18 File Offset: 0x007A9D18
		public override void PopulateReferences()
		{
			short num = (short)1052854998;
			short num2 = num;
			num = (short)2075937494;
			switch (num2 == num)
			{
			default:
			{
				num = (short)180158464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)648282113;
			if (num != 0)
			{
			}
			num = (short)1172045824;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x007ABBC4 File Offset: 0x007A9DC4
		public override void DropReferences()
		{
			short num = (short)791294782;
			short num2 = num;
			num = (short)1188246334;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1139408896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2111504385;
			if (num != 0)
			{
			}
			num = (short)1314521088;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x007ABC70 File Offset: 0x007A9E70
		public override void SetConstraints()
		{
			short num = (short)1430674002;
			short num2 = num;
			num = (short)477649490;
			switch (num2 == num)
			{
			default:
			{
				num = (short)248119296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)239403008;
			if (num != 0)
			{
			}
			num = (short)1989148673;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x007ABD18 File Offset: 0x007A9F18
		public override void SetupDependencies()
		{
			short num = (short)105395103;
			short num2 = num;
			num = (short)284111775;
			switch (num2 == num)
			{
			default:
			{
				num = (short)596312064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1341390849;
			if (num != 0)
			{
			}
			num = (short)776536064;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x0600841C RID: 33820 RVA: 0x007ABDC0 File Offset: 0x007A9FC0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1116973358;
				short num2 = num;
				num = (short)1466476846;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1066008576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1946615808;
				if (num != 0)
				{
				}
				num = (short)1745682433;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x007ABE70 File Offset: 0x007AA070
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
				{
					num2 = (short)300351488;
					short num3 = num2;
					num2 = (short)1486553089;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)556662786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1527840771;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					goto IL_AD;
				}
				goto IL_24;
			}
			IL_AD:
			if (base.ParentRecset != null)
			{
				goto IL_B8;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)668205549;
			short num4 = num2;
			num2 = (short)928711149;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B8:
				num2 = (short)1085276160;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)214499328;
				if (num2 != 0)
				{
				}
				num2 = (short)1876295681;
				if (num2 != 0)
				{
				}
				num2 = (short)801046532;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04003E6A RID: 15978
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset innerRecset;
	}
}
