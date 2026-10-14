using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000CF RID: 207
	[global::System.Serializable]
	public class TalkgroupInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001CC1 RID: 7361 RVA: 0x001CA8E0 File Offset: 0x001C8AE0
		public TalkgroupInnerRecset() : base(global::CommonResources.AcgResources.ID_TALKGROUP)
		{
			this.SetValues();
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x001CA900 File Offset: 0x001C8B00
		public TalkgroupInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x001CA92C File Offset: 0x001C8B2C
		public override int MaxPool
		{
			get
			{
				short num = (short)701102799;
				short num2 = num;
				num = (short)1069873871;
				switch (num2 == num)
				{
				default:
				{
					num = (short)41287680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1014562816;
				if (num != 0)
				{
				}
				num = (short)1056964609;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x001CA9D8 File Offset: 0x001C8BD8
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x001CAA98 File Offset: 0x001C8C98
		public override int Max
		{
			get
			{
				while (this._DynMax != -1)
				{
					short num = (short)1140027364;
					short num2 = num;
					num = (short)340684772;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1876164609;
						if (num != 0)
						{
						}
						num = (short)956956672;
						if (num != 0)
						{
						}
						num = (short)1693908992;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset._Max;
			}
			set
			{
				short num = (short)540540928;
				short num2 = num;
				num = (short)1674236423;
				short num3 = num;
				num = (short)1302057479;
				switch (num3 == num)
				{
				}
				num = (short)1086652416;
				if (num != 0)
				{
				}
				num = (short)1259077633;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x001CAB48 File Offset: 0x001C8D48
		public override int Min
		{
			get
			{
				short num = (short)37289984;
				short num2 = num;
				num = (short)255160296;
				short num3 = num;
				num = (short)683962344;
				switch (num3 == num)
				{
				}
				num = (short)668401665;
				if (num != 0)
				{
				}
				num = (short)1554841600;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset._Min;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x001CABF8 File Offset: 0x001C8DF8
		// (set) Token: 0x06001CC8 RID: 7368 RVA: 0x001CACA8 File Offset: 0x001C8EA8
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1057882112;
				short num2 = num;
				num = (short)1869692760;
				short num3 = num;
				num = (short)488783704;
				switch (num3 == num)
				{
				}
				num = (short)768999425;
				if (num != 0)
				{
				}
				num = (short)1963261952;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1979842560;
				short num2 = num;
				num = (short)1237871785;
				short num3 = num;
				num = (short)1001942185;
				switch (num3 == num)
				{
				}
				num = (short)1171914753;
				if (num != 0)
				{
				}
				num = (short)1453129728;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x001CAD58 File Offset: 0x001C8F58
		public bool HasDiffs
		{
			get
			{
				short num = (short)25493504;
				short num2 = num;
				num = (short)819397754;
				short num3 = num;
				num = (short)1413481594;
				switch (num3 == num)
				{
				}
				num = (short)1383596032;
				if (num != 0)
				{
				}
				num = (short)1569325057;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x001CAE08 File Offset: 0x001C9008
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1407647744;
			short num2 = num;
			num = (short)600450784;
			short num3 = num;
			num = (short)212936416;
			switch (num3 == num)
			{
			}
			num = (short)1619853313;
			if (num != 0)
			{
			}
			num = (short)620101632;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner(this);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x001CAEB4 File Offset: 0x001C90B4
		internal void SetValues()
		{
			short num = (short)946339840;
			short num2 = num;
			num = (short)941651708;
			short num3 = num;
			num = (short)9795324;
			switch (num3 == num)
			{
			}
			num = (short)1340211201;
			if (num != 0)
			{
			}
			num = (short)1612316672;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUP;
			base.DataTransferOrder = 45;
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x001CAF7C File Offset: 0x001C917C
		// Note: this type is marked as 'beforefieldinit'.
		static TalkgroupInnerRecset()
		{
			short num = (short)249626624;
			short num2 = num;
			num = (short)1490373605;
			short num3 = num;
			num = (short)1474907109;
			switch (num3 == num)
			{
			}
			num = (short)1350434816;
			if (num != 0)
			{
			}
			num = (short)1928462337;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerRecset._Min = 1;
		}

		// Token: 0x04000906 RID: 2310
		public static int _MaxPool;

		// Token: 0x04000907 RID: 2311
		public static int _Max;

		// Token: 0x04000908 RID: 2312
		public int _DynMax;

		// Token: 0x04000909 RID: 2313
		public static int _Min;

		// Token: 0x0400090A RID: 2314
		public static int _DefaultRecordCount;
	}
}
