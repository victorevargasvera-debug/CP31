using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000D2 RID: 210
	[global::System.Serializable]
	public class TrunkingPersonalityRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001E35 RID: 7733 RVA: 0x001E1180 File Offset: 0x001DF380
		public TrunkingPersonalityRecset() : base(global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITY, global::CommonResources.AcgResources.ID_TRKPER)
		{
			this.SetValues();
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x001E11A4 File Offset: 0x001DF3A4
		public TrunkingPersonalityRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x001E11D0 File Offset: 0x001DF3D0
		public override int MaxPool
		{
			get
			{
				short num = (short)8692376;
				short num2 = num;
				num = (short)1144365720;
				switch (num2 == num)
				{
				}
				num = (short)309395457;
				if (num != 0)
				{
				}
				num = (short)627376128;
				short num3 = num;
				num = (short)452722688;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset._MaxPool;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x001E127C File Offset: 0x001DF47C
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x001E1340 File Offset: 0x001DF540
		public override int Max
		{
			get
			{
				while (this._DynMax != -1)
				{
					short num = (short)676664908;
					short num2 = num;
					num = (short)653268556;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1542782977;
						if (num != 0)
						{
						}
						num = (short)1031733248;
						short num3 = num;
						num = (short)1745682432;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset._Max;
			}
			set
			{
				short num = (short)1613752796;
				short num2 = num;
				num = (short)848882140;
				switch (num2 == num)
				{
				}
				num = (short)1370488833;
				if (num != 0)
				{
				}
				num = (short)127139840;
				short num3 = num;
				num = (short)15794176;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x001E13EC File Offset: 0x001DF5EC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1288039695;
				short num2 = num;
				num = (short)782757135;
				switch (num2 == num)
				{
				}
				num = (short)1553596416;
				if (num != 0)
				{
				}
				num = (short)1223819264;
				short num3 = num;
				num = (short)1789460481;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x001E149C File Offset: 0x001DF69C
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x001E1550 File Offset: 0x001DF750
		public override int Min
		{
			get
			{
				short num = (short)1988834977;
				short num2 = num;
				num = (short)2108765857;
				switch (num2 == num)
				{
				}
				num = (short)994639873;
				if (num != 0)
				{
				}
				num = (short)1853227008;
				short num3 = num;
				num = (short)854392832;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset._Min;
			}
			set
			{
				short num = (short)824539603;
				short num2 = num;
				num = (short)15759827;
				switch (num2 == num)
				{
				}
				num = (short)1373831169;
				if (num != 0)
				{
				}
				num = (short)1730412544;
				short num3 = num;
				num = (short)314638336;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset._Min = value;
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x001E1600 File Offset: 0x001DF800
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)734031276;
			short num2 = num;
			num = (short)1035759020;
			switch (num2 == num)
			{
			}
			num = (short)601489409;
			if (num != 0)
			{
			}
			num = (short)2121138176;
			short num3 = num;
			num = (short)1113128960;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality(this);
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x001E16B0 File Offset: 0x001DF8B0
		internal void SetValues()
		{
			int a_ = 14;
			short num = (short)1841663756;
			short num2 = num;
			num = (short)440897292;
			switch (num2 == num)
			{
			}
			num = (short)1265041409;
			if (num != 0)
			{
			}
			num = (short)517144576;
			short num3 = num;
			num = (short)812777472;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2072;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4ꓦ蛨蛪鷬胮鿰雲鯴菶ꗸ꿺迼諾漀栂氄椆済⬊丌怎缐甒簔瀖氘椚簜欞䠠䰢䬤符紨太堬䄮娰娲嬴倶ᤸ欺堼䴾㉀ⱂ⭄♆╈≊㥌㙎൐ݒ❔≖㝘ず㑜ㅞ٠㍢dᕦᩨѪͬ๮ᵰᩲŴ๶⵸᥺ᅼ兾呂", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPERSONALITY;
			base.KeySeed = global::CommonResources.AcgResources.ID_TRKPER;
			base.DataTransferOrder = 45;
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x001E17B0 File Offset: 0x001DF9B0
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)143600831;
			short num2 = num;
			num = (short)810691775;
			switch (num2 == num)
			{
			}
			num = (short)1128398849;
			if (num != 0)
			{
			}
			num = (short)2009137152;
			short num3 = num;
			num = (short)996868096;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord(record);
			this.b(record);
			this.c(record);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x001E1870 File Offset: 0x001DFA70
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)324711069;
			short num2 = num;
			num = (short)1611379357;
			switch (num2 == num)
			{
			}
			num = (short)521994241;
			if (num != 0)
			{
			}
			num = (short)834600960;
			short num3 = num;
			num = (short)650117120;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x001E191C File Offset: 0x001DFB1C
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)910571497;
			short num2 = num;
			num = (short)1277114345;
			switch (num2 == num)
			{
			}
			num = (short)1807155201;
			if (num != 0)
			{
			}
			num = (short)1567817728;
			short num3 = num;
			num = (short)967770112;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x001E19CC File Offset: 0x001DFBCC
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset feature;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (feature != null)
					{
						num2 = (short)1063452674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num2 = (short)728711357;
					short num3 = num2;
					num2 = (short)1854750909;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1019346945;
						if (num2 != 0)
						{
						}
						num2 = (short)2083520512;
						if (num2 != 0)
						{
						}
						feature.CalculateValidity();
						num2 = (short)80674817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1782382592;
			short num4 = num2;
			feature = global::AcpCommonLib.FeatureManager.GetFeature(2076);
			num2 = (short)1358626816;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x001E1AF0 File Offset: 0x001DFCF0
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingPersonalityRecset()
		{
			short num = (short)810740168;
			short num2 = num;
			num = (short)1046669768;
			switch (num2 == num)
			{
			}
			num = (short)1175191552;
			if (num != 0)
			{
			}
			num = (short)138280960;
			short num3 = num;
			num = (short)989331457;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset._Min = 1;
		}

		// Token: 0x04000B73 RID: 2931
		public static int _MaxPool;

		// Token: 0x04000B74 RID: 2932
		public static int _Max;

		// Token: 0x04000B75 RID: 2933
		public int _DynMax;

		// Token: 0x04000B76 RID: 2934
		public static int _Min;
	}
}
