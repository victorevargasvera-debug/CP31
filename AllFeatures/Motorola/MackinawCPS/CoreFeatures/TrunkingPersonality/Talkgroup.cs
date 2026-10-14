using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000CD RID: 205
	[global::System.Serializable]
	public class Talkgroup : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001CB4 RID: 7348 RVA: 0x001CA0B0 File Offset: 0x001C82B0
		public Talkgroup(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x001CA0F0 File Offset: 0x001C82F0
		protected Talkgroup(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x001CA108 File Offset: 0x001C8308
		public override void Init()
		{
			int a_ = 10;
			short num = (short)717165254;
			short num2 = num;
			num = (short)623252166;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1119944704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1733230592;
			if (num != 0)
			{
			}
			num = (short)896532481;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿊곌ꏎ뫐듒꟔룖곘ꯚ", a_);
			base.Id = 10179;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUP;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x001CA1EC File Offset: 0x001C83EC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)529056008;
			short num2 = num;
			num = (short)1468449032;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1515520000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)864813057;
			if (num != 0)
			{
			}
			num = (short)1877999616;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳇ꯉꃋꗍ럏ꃑ믓ꏕ꣗", a_);
			base.Id = 10179;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUP;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x001CA2D0 File Offset: 0x001C84D0
		public override void PopulateReferences()
		{
			short num = (short)1487638587;
			short num2 = num;
			num = (short)1562873915;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1739325440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)710606848;
			if (num != 0)
			{
			}
			num = (short)107479041;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x001CA37C File Offset: 0x001C857C
		public override void DropReferences()
		{
			short num = (short)466553110;
			short num2 = num;
			num = (short)338757910;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1434779648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1971126272;
			if (num != 0)
			{
			}
			num = (short)1346764801;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x001CA428 File Offset: 0x001C8628
		public override void SetConstraints()
		{
			short num = (short)1914631718;
			short num2 = num;
			num = (short)157218342;
			switch (num2 == num)
			{
			default:
			{
				num = (short)914292736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1526464513;
			if (num != 0)
			{
			}
			num = (short)952369152;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x001CA4D0 File Offset: 0x001C86D0
		public override void SetupDependencies()
		{
			short num = (short)47831656;
			short num2 = num;
			num = (short)811522664;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1711603712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1517420545;
			if (num != 0)
			{
			}
			num = (short)1182203904;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x001CA578 File Offset: 0x001C8778
		public bool HasDiffs
		{
			get
			{
				short num = (short)526004891;
				short num2 = num;
				num = (short)2004038299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)207355904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)204013568;
				if (num != 0)
				{
				}
				num = (short)115015681;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x001CA62C File Offset: 0x001C882C
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
					num2 = (short)1754464258;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_85;
				case 2:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						goto IL_13F;
					}
					num2 = (short)859977590;
					short num3 = num2;
					num2 = (short)1918973814;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13F;
					default:
						num2 = (short)252968961;
						if (num2 != 0)
						{
						}
						num2 = (short)830865408;
						if (num2 != 0)
						{
						}
						num2 = (short)230227971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1413742593;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)908984320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				}
				goto IL_24;
			}
			IL_85:
			IL_13F:
			num2 = (short)439484416;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)886439940;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000905 RID: 2309
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset innerRecset;
	}
}
