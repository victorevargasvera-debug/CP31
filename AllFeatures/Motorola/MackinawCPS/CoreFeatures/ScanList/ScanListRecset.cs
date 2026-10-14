using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x02000120 RID: 288
	[global::System.Serializable]
	public class ScanListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06002A7A RID: 10874 RVA: 0x002964CC File Offset: 0x002946CC
		public ScanListRecset()
		{
			int a_ = 11;
			base..ctor(global::AllFeatures.CodeplugGuid.b("鿋귍뇏병髕뇗꧙꣛", a_));
			this.SetValues();
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x002964FC File Offset: 0x002946FC
		public ScanListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x00296528 File Offset: 0x00294728
		public override int MaxPool
		{
			get
			{
				short num = (short)392767662;
				short num2 = num;
				num = (short)2049517742;
				switch (num2 == num)
				{
				}
				num = (short)513081345;
				if (num != 0)
				{
				}
				num = (short)1389690880;
				short num3 = num;
				num = (short)338821120;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset._MaxPool;
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x002965D8 File Offset: 0x002947D8
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x0029669C File Offset: 0x0029489C
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)874389976;
					short num2 = num;
					num = (short)399843800;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)967704576;
						if (num != 0)
						{
						}
						num = (short)1884356609;
						if (num != 0)
						{
						}
						num = (short)83951616;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)2020999169;
				if (num != 0)
				{
				}
				num = (short)1071123606;
				short num2 = num;
				num = (short)1296960662;
				switch (num2 == num)
				{
				}
				num = (short)1341718528;
				short num3 = num;
				num = (short)2030436352;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x00296750 File Offset: 0x00294950
		public bool HasDiffs
		{
			get
			{
				short num = (short)1746039701;
				short num2 = num;
				num = (short)1735750549;
				switch (num2 == num)
				{
				}
				num = (short)1301413889;
				if (num != 0)
				{
				}
				num = (short)304742400;
				short num3 = num;
				num = (short)1899626496;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x002967FC File Offset: 0x002949FC
		// (set) Token: 0x06002A81 RID: 10881 RVA: 0x002968AC File Offset: 0x00294AAC
		public override int Min
		{
			get
			{
				short num = (short)1562177569;
				short num2 = num;
				num = (short)843706401;
				switch (num2 == num)
				{
				}
				num = (short)1965424641;
				if (num != 0)
				{
				}
				num = (short)283443200;
				short num3 = num;
				num = (short)1147928576;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset._Min;
			}
			set
			{
				short num = (short)2061834883;
				short num2 = num;
				num = (short)1484331651;
				switch (num2 == num)
				{
				}
				num = (short)1497169921;
				if (num != 0)
				{
				}
				num = (short)850591744;
				short num3 = num;
				num = (short)1844314112;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset._Min = value;
			}
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x0029695C File Offset: 0x00294B5C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)983202269;
			short num2 = num;
			num = (short)856979933;
			switch (num2 == num)
			{
			}
			num = (short)1195048960;
			if (num != 0)
			{
			}
			num = (short)461307904;
			short num3 = num;
			num = (short)879493121;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList(this);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00296A08 File Offset: 0x00294C08
		internal void SetValues()
		{
			int a_ = 10;
			short num = (short)1227602029;
			short num2 = num;
			num = (short)1833351277;
			switch (num2 == num)
			{
			}
			num = (short)112197633;
			if (num != 0)
			{
			}
			num = (short)2101673984;
			short num3 = num;
			num = (short)1360003072;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2057;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴ꓶ髸髺鏼\udffe䈀氂欄愆怈氊砌紎瀐朒簔砖眘䜚东簞䀠䴢Ԥ欦䀨堪夬献戰倲吴夶甸刺丼䬾ᕀ⅂⥄楆ㅈ⩊⁌⍎", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SCANLIST;
			base.DataTransferOrder = 47;
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00296AFC File Offset: 0x00294CFC
		// Note: this type is marked as 'beforefieldinit'.
		static ScanListRecset()
		{
			short num = (short)1005205726;
			short num2 = num;
			num = (short)233126110;
			switch (num2 == num)
			{
			}
			num = (short)1172176897;
			if (num != 0)
			{
			}
			num = (short)924254208;
			short num3 = num;
			num = (short)412024832;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset._Min = 1;
		}

		// Token: 0x04000FC7 RID: 4039
		public static int _MaxPool;

		// Token: 0x04000FC8 RID: 4040
		public static int _Max;

		// Token: 0x04000FC9 RID: 4041
		public int _DynMax;

		// Token: 0x04000FCA RID: 4042
		public static int _Min;
	}
}
