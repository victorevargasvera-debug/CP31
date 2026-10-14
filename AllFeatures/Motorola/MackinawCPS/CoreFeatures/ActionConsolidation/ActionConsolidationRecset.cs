using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x0200041B RID: 1051
	[global::System.Serializable]
	public class ActionConsolidationRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008FEF RID: 36847 RVA: 0x0087BED4 File Offset: 0x0087A0D4
		public ActionConsolidationRecset() : base(global::CommonResources.AcgResources.ID_ACTIONCONSOLIDATION, global::CommonResources.AcgResources.ID_AC)
		{
			this.SetValues();
		}

		// Token: 0x06008FF0 RID: 36848 RVA: 0x0087BEF8 File Offset: 0x0087A0F8
		public ActionConsolidationRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170048A9 RID: 18601
		// (get) Token: 0x06008FF1 RID: 36849 RVA: 0x0087BF24 File Offset: 0x0087A124
		public override int MaxPool
		{
			get
			{
				short num = (short)1990886633;
				short num2 = num;
				num = (short)50496745;
				switch (num2 == num)
				{
				}
				num = (short)1477443585;
				if (num != 0)
				{
				}
				num = (short)1507590144;
				if (num != 0)
				{
				}
				num = (short)1026949120;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset._MaxPool;
			}
		}

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x06008FF2 RID: 36850 RVA: 0x0087BFD4 File Offset: 0x0087A1D4
		// (set) Token: 0x06008FF3 RID: 36851 RVA: 0x0087C094 File Offset: 0x0087A294
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)1337867433;
					short num2 = num;
					num = (short)234765481;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_0B;
					case 1:
						break;
					default:
					{
						num = (short)1207435264;
						short num3 = num;
						break;
					}
					}
					num = (short)1411121152;
					if (num != 0)
					{
					}
					num = (short)454426625;
					if (num != 0)
					{
					}
					return this._DynMax;
				}
				IL_0B:
				return global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset._Max;
			}
			set
			{
				short num = (short)1145548526;
				short num2 = num;
				num = (short)387886830;
				switch (num2 == num)
				{
				}
				num = (short)471662592;
				short num3 = num;
				num = (short)1479147520;
				if (num != 0)
				{
				}
				num = (short)647036929;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x06008FF4 RID: 36852 RVA: 0x0087C140 File Offset: 0x0087A340
		public bool HasDiffs
		{
			get
			{
				short num = (short)1387397121;
				if (num != 0)
				{
				}
				num = (short)1717821135;
				short num2 = num;
				num = (short)1546247887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1286012928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)632881152;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x06008FF5 RID: 36853 RVA: 0x0087C1F0 File Offset: 0x0087A3F0
		// (set) Token: 0x06008FF6 RID: 36854 RVA: 0x0087C2A0 File Offset: 0x0087A4A0
		public override int Min
		{
			get
			{
				short num = (short)1805981063;
				short num2 = num;
				num = (short)1185159;
				switch (num2 == num)
				{
				}
				num = (short)1824391168;
				short num3 = num;
				num = (short)966852608;
				if (num != 0)
				{
				}
				num = (short)379584513;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset._Min;
			}
			set
			{
				short num = (short)806223873;
				if (num != 0)
				{
				}
				num = (short)323571503;
				short num2 = num;
				num = (short)410472239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2020474880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1906507776;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset._Min = value;
			}
		}

		// Token: 0x06008FF7 RID: 36855 RVA: 0x0087C34C File Offset: 0x0087A54C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)190814482;
			short num2 = num;
			num = (short)2127272210;
			switch (num2 == num)
			{
			}
			num = (short)774766592;
			short num3 = num;
			num = (short)974716929;
			if (num != 0)
			{
			}
			num = (short)1501954048;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation(this);
		}

		// Token: 0x06008FF8 RID: 36856 RVA: 0x0087C3FC File Offset: 0x0087A5FC
		internal void SetValues()
		{
			int a_ = 1;
			short num = (short)1653478318;
			short num2 = num;
			num = (short)353244078;
			switch (num2 == num)
			{
			}
			num = (short)379453440;
			short num3 = num;
			num = (short)1001652224;
			if (num != 0)
			{
			}
			num = (short)1047592961;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 4008;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫볭釯雱鷳駵\ud8f7뿹軻駽濿氁欃欅愇椉缋⸍匏紑稓瀕焗紙椛氝䄟嘡䴣䤥䘧瘩洫䴭䐯嬱嬳堵ᠷ礹医倽㌿ⵁ⡃⽅ⱇ⭉㡋❍㽏㱑ࡓ᝕㭗⹙㕛ㅝ๟Ⅱୣࡥ᭧թkݭᑯ፱sή᝷ᑹ⡻ᱽ겁ﲃ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACTIONCONSOLIDATION;
			base.KeySeed = global::CommonResources.AcgResources.ID_AC;
			base.DataTransferOrder = 55;
		}

		// Token: 0x06008FF9 RID: 36857 RVA: 0x0087C4FC File Offset: 0x0087A6FC
		// Note: this type is marked as 'beforefieldinit'.
		static ActionConsolidationRecset()
		{
			short num = (short)207184301;
			short num2 = num;
			num = (short)1246847405;
			switch (num2 == num)
			{
			}
			num = (short)1476722688;
			short num3 = num;
			num = (short)167837697;
			if (num != 0)
			{
			}
			num = (short)93323264;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset._Min = 1;
		}

		// Token: 0x0400482C RID: 18476
		public static int _MaxPool;

		// Token: 0x0400482D RID: 18477
		public static int _Max;

		// Token: 0x0400482E RID: 18478
		public int _DynMax;

		// Token: 0x0400482F RID: 18479
		public static int _Min;
	}
}
