using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004ED RID: 1261
	[global::System.Serializable]
	public class QuickTextMessageListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600A977 RID: 43383 RVA: 0x009D45CC File Offset: 0x009D27CC
		public QuickTextMessageListInnerRecset() : base(global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGELIST)
		{
			this.SetValues();
		}

		// Token: 0x0600A978 RID: 43384 RVA: 0x009D45EC File Offset: 0x009D27EC
		public QuickTextMessageListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700551A RID: 21786
		// (get) Token: 0x0600A979 RID: 43385 RVA: 0x009D4618 File Offset: 0x009D2818
		public override int MaxPool
		{
			get
			{
				short num = (short)600113153;
				if (num != 0)
				{
				}
				num = (short)1324346410;
				short num2 = num;
				num = (short)2055728170;
				switch (num2 == num)
				{
				}
				num = (short)364904448;
				short num3 = num;
				num = (short)543293440;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700551B RID: 21787
		// (get) Token: 0x0600A97A RID: 43386 RVA: 0x009D46C8 File Offset: 0x009D28C8
		// (set) Token: 0x0600A97B RID: 43387 RVA: 0x009D478C File Offset: 0x009D298C
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)550857377;
					short num2 = num;
					num = (short)1755474593;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2092171264;
						short num3 = num;
						num = (short)1474101248;
						if (num != 0)
						{
						}
						num = (short)944046081;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset._Max;
			}
			set
			{
				short num = (short)81374661;
				short num2 = num;
				num = (short)1968549317;
				switch (num2 == num)
				{
				}
				num = (short)1028915200;
				if (num != 0)
				{
				}
				num = (short)1507721216;
				short num3 = num;
				num = (short)364445697;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700551C RID: 21788
		// (get) Token: 0x0600A97C RID: 43388 RVA: 0x009D483C File Offset: 0x009D2A3C
		public override int Min
		{
			get
			{
				short num = (short)1433188604;
				short num2 = num;
				num = (short)500021500;
				switch (num2 == num)
				{
				}
				num = (short)291438593;
				if (num != 0)
				{
				}
				num = (short)1845297152;
				short num3 = num;
				num = (short)708182016;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset._Min;
			}
		}

		// Token: 0x1700551D RID: 21789
		// (get) Token: 0x0600A97D RID: 43389 RVA: 0x009D48E8 File Offset: 0x009D2AE8
		// (set) Token: 0x0600A97E RID: 43390 RVA: 0x009D499C File Offset: 0x009D2B9C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1579470750;
				short num2 = num;
				num = (short)1950338974;
				switch (num2 == num)
				{
				}
				num = (short)1339490304;
				if (num != 0)
				{
				}
				num = (short)1991770112;
				short num3 = num;
				num = (short)1022885889;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)59843078;
				short num2 = num;
				num = (short)1775051270;
				switch (num2 == num)
				{
				}
				num = (short)1237975041;
				if (num != 0)
				{
				}
				num = (short)627507200;
				short num3 = num;
				num = (short)169279488;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700551E RID: 21790
		// (get) Token: 0x0600A97F RID: 43391 RVA: 0x009D4A4C File Offset: 0x009D2C4C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1178183054;
				short num2 = num;
				num = (short)539141518;
				switch (num2 == num)
				{
				}
				num = (short)1269104641;
				if (num != 0)
				{
				}
				num = (short)758644736;
				short num3 = num;
				num = (short)805699584;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x009D4B00 File Offset: 0x009D2D00
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1458741902;
			short num2 = num;
			num = (short)421241486;
			switch (num2 == num)
			{
			}
			num = (short)571604993;
			if (num != 0)
			{
			}
			num = (short)1241251840;
			short num3 = num;
			num = (short)567869440;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInner(this);
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x009D4BB0 File Offset: 0x009D2DB0
		internal void SetValues()
		{
			short num = (short)117510308;
			short num2 = num;
			num = (short)2045120676;
			switch (num2 == num)
			{
			}
			num = (short)1710817280;
			if (num != 0)
			{
			}
			num = (short)1107427328;
			short num3 = num;
			num = (short)604831745;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGELIST;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x009D4C7C File Offset: 0x009D2E7C
		// Note: this type is marked as 'beforefieldinit'.
		static QuickTextMessageListInnerRecset()
		{
			short num = (short)875757569;
			if (num != 0)
			{
			}
			num = (short)1080138705;
			short num2 = num;
			num = (short)336960465;
			switch (num2 == num)
			{
			}
			num = (short)443613184;
			short num3 = num;
			num = (short)79233024;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerRecset._Min = 1;
		}

		// Token: 0x04005145 RID: 20805
		public static int _MaxPool;

		// Token: 0x04005146 RID: 20806
		public static int _Max;

		// Token: 0x04005147 RID: 20807
		public int _DynMax;

		// Token: 0x04005148 RID: 20808
		public static int _Min;

		// Token: 0x04005149 RID: 20809
		public static int _DefaultRecordCount;
	}
}
