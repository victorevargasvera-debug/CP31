using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E2 RID: 482
	[global::System.Serializable]
	public class SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06005435 RID: 21557 RVA: 0x004C8F3C File Offset: 0x004C713C
		public SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset() : base(global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTNONPROGRAMMABLEBUTTONLIST, global::CommonResources.AcgResources.ID_SIGNNONPRG)
		{
			this.SetValues();
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x004C8F60 File Offset: 0x004C7160
		public SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x06005437 RID: 21559 RVA: 0x004C8F8C File Offset: 0x004C718C
		public override int MaxPool
		{
			get
			{
				short num = (short)2093744128;
				short num2 = num;
				num = (short)1715239915;
				short num3 = num;
				num = (short)851803115;
				switch (num3 == num)
				{
				}
				num = (short)1075052545;
				if (num != 0)
				{
				}
				num = (short)1477246976;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x004C903C File Offset: 0x004C723C
		// (set) Token: 0x06005439 RID: 21561 RVA: 0x004C90FC File Offset: 0x004C72FC
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax != -1)
				{
					num = (short)2118726995;
					short num2 = num;
					num = (short)747517267;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)775159809;
						if (num != 0)
						{
						}
						num = (short)2059403264;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)548864000;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset._Max;
			}
			set
			{
				short num = (short)587988992;
				short num2 = num;
				num = (short)1592721409;
				if (num != 0)
				{
				}
				num = (short)634364088;
				short num3 = num;
				num = (short)2005377208;
				switch (num3 == num)
				{
				}
				num = (short)1185480704;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x0600543A RID: 21562 RVA: 0x004C91B0 File Offset: 0x004C73B0
		public override int Min
		{
			get
			{
				short num = (short)1748434944;
				short num2 = num;
				num = (short)1194264195;
				short num3 = num;
				num = (short)692586115;
				switch (num3 == num)
				{
				}
				num = (short)756744193;
				if (num != 0)
				{
				}
				num = (short)675348480;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset._Min;
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x004C9260 File Offset: 0x004C7460
		// (set) Token: 0x0600543C RID: 21564 RVA: 0x004C9310 File Offset: 0x004C7510
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1190330368;
				short num2 = num;
				num = (short)1273161739;
				short num3 = num;
				num = (short)298641419;
				switch (num3 == num)
				{
				}
				num = (short)300089345;
				if (num != 0)
				{
				}
				num = (short)1653800960;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1846673408;
				short num2 = num;
				num = (short)1022892463;
				short num3 = num;
				num = (short)710875567;
				switch (num3 == num)
				{
				}
				num = (short)1497956353;
				if (num != 0)
				{
				}
				num = (short)2054225920;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x0600543D RID: 21565 RVA: 0x004C93C0 File Offset: 0x004C75C0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1367867392;
				short num2 = num;
				num = (short)518469824;
				short num3 = num;
				num = (short)1749039296;
				switch (num3 == num)
				{
				}
				num = (short)542703617;
				if (num != 0)
				{
				}
				num = (short)594804736;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x004C9474 File Offset: 0x004C7674
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1686175744;
			short num2 = num;
			num = (short)660886651;
			short num3 = num;
			num = (short)468145275;
			switch (num3 == num)
			{
			}
			num = (short)1786707969;
			if (num != 0)
			{
			}
			num = (short)1828585472;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner(this);
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x004C9520 File Offset: 0x004C7720
		internal void SetValues()
		{
			short num = (short)947716096;
			short num2 = num;
			num = (short)44401913;
			short num3 = num;
			num = (short)396657913;
			switch (num3 == num)
			{
			}
			num = (short)1616707585;
			if (num != 0)
			{
			}
			num = (short)1241317376;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTNONPROGRAMMABLEBUTTONLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_SIGNNONPRG;
			base.DataTransferOrder = 22;
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x004C95F4 File Offset: 0x004C77F4
		// Note: this type is marked as 'beforefieldinit'.
		static SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset()
		{
			short num = (short)1952710656;
			short num2 = num;
			num = (short)1444180843;
			short num3 = num;
			num = (short)2079355755;
			switch (num3 == num)
			{
			}
			num = (short)1685389313;
			if (num != 0)
			{
			}
			num = (short)2016018432;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset._Min = 1;
		}

		// Token: 0x0400215E RID: 8542
		public static int _MaxPool;

		// Token: 0x0400215F RID: 8543
		public static int _Max;

		// Token: 0x04002160 RID: 8544
		public int _DynMax;

		// Token: 0x04002161 RID: 8545
		public static int _Min;

		// Token: 0x04002162 RID: 8546
		public static int _DefaultRecordCount;
	}
}
