using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000193 RID: 403
	[global::System.Serializable]
	public class TxPowerLevelsNewBandPlan : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600427B RID: 17019 RVA: 0x003DFE9C File Offset: 0x003DE09C
		public TxPowerLevelsNewBandPlan(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x003DFEDC File Offset: 0x003DE0DC
		protected TxPowerLevelsNewBandPlan(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x003DFEF4 File Offset: 0x003DE0F4
		public override void Init()
		{
			int a_ = 13;
			short num = (short)896008193;
			if (num != 0)
			{
			}
			num = (short)1859922320;
			short num2 = num;
			num = (short)53094800;
			switch (num2 == num)
			{
			}
			num = (short)827129856;
			short num3 = num;
			num = (short)223870976;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髍꣏蓓맕꿗뿙껛ﻝ곟蟡鋣菥蓧駩쳫웭뻯韱菳훵뫷鯹鋻髽⃿刁栃朅昇⌉", a_);
			base.Id = 10761;
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELSNEWBANDPLAN;
			base.DataTransferOrder = 19;
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x003DFFD8 File Offset: 0x003DE1D8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)139441655;
			short num2 = num;
			num = (short)415806967;
			switch (num2 == num)
			{
			}
			num = (short)1880883201;
			if (num != 0)
			{
			}
			num = (short)1854078976;
			short num3 = num;
			num = (short)1746206720;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿊뗌臐볒ꋔ닖ꯘﯚ釜뫞韠蛢觤铦짨쏪ꏬ諮蛰폲럴零韸鿺\uddfc꿾洀戂欄⸆", a_);
			base.Id = 10761;
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELSNEWBANDPLAN;
			base.DataTransferOrder = 19;
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x003E00BC File Offset: 0x003DE2BC
		public override void PopulateReferences()
		{
			short num = (short)2013910420;
			short num2 = num;
			num = (short)2024789396;
			switch (num2 == num)
			{
			}
			num = (short)527171585;
			if (num != 0)
			{
			}
			num = (short)1480065024;
			short num3 = num;
			num = (short)733020160;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x003E0168 File Offset: 0x003DE368
		public override void DropReferences()
		{
			short num = (short)1504251464;
			short num2 = num;
			num = (short)1847332424;
			switch (num2 == num)
			{
			}
			num = (short)878051329;
			if (num != 0)
			{
			}
			num = (short)814284800;
			short num3 = num;
			num = (short)1740963840;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x003E0210 File Offset: 0x003DE410
		public override void SetConstraints()
		{
			short num = (short)961591577;
			short num2 = num;
			num = (short)201767193;
			switch (num2 == num)
			{
			}
			num = (short)1363017729;
			if (num != 0)
			{
			}
			num = (short)1897136128;
			short num3 = num;
			num = (short)1472659456;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x003E02B8 File Offset: 0x003DE4B8
		public override void SetupDependencies()
		{
			short num = (short)910295041;
			if (num != 0)
			{
			}
			num = (short)544263479;
			short num2 = num;
			num = (short)381734199;
			switch (num2 == num)
			{
			}
			num = (short)1749549056;
			short num3 = num;
			num = (short)884998144;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x003E0360 File Offset: 0x003DE560
		public bool HasDiffs
		{
			get
			{
				short num = (short)180087892;
				short num2 = num;
				num = (short)124906580;
				switch (num2 == num)
				{
				}
				num = (short)1589706752;
				if (num != 0)
				{
				}
				num = (short)685768704;
				short num3 = num;
				num = (short)957153281;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x003E040C File Offset: 0x003DE60C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1427832835;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
						goto IL_81;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)1007550468;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)199294977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
					{
						num2 = (short)200998912;
						short num3 = num2;
						num2 = (short)284557313;
						if (num2 != 0)
						{
						}
						num2 = (short)17760256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_24;
				}
				IL_81:
				num2 = (short)273299128;
				short num4 = num2;
				num2 = (short)552416952;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_26;
				default:
					num2 = (short)1331625984;
					if (num2 != 0)
					{
					}
					break;
				}
				return result;
			}
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)843251714;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001A21 RID: 6689
		private global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerRecset innerRecset;
	}
}
