using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000403 RID: 1027
	[global::System.Serializable]
	public class DataButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008DF3 RID: 36339 RVA: 0x0085FEB4 File Offset: 0x0085E0B4
		public DataButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_DATABUTTON, global::CommonResources.AcgResources.ID_DATABUTTON_2)
		{
			this.SetValues();
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x0085FED8 File Offset: 0x0085E0D8
		public DataButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170047A8 RID: 18344
		// (get) Token: 0x06008DF5 RID: 36341 RVA: 0x0085FF04 File Offset: 0x0085E104
		public override int MaxPool
		{
			get
			{
				short num = (short)1280957040;
				short num2 = num;
				num = (short)1332599408;
				switch (num2 == num)
				{
				}
				num = (short)831520768;
				short num3 = num;
				num = (short)159318017;
				if (num != 0)
				{
				}
				num = (short)338886656;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x170047A9 RID: 18345
		// (get) Token: 0x06008DF6 RID: 36342 RVA: 0x0085FFB4 File Offset: 0x0085E1B4
		// (set) Token: 0x06008DF7 RID: 36343 RVA: 0x00860078 File Offset: 0x0085E278
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)869752205;
					short num2 = num;
					num = (short)696737165;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1328480257;
						if (num != 0)
						{
						}
						num = (short)1439694848;
						short num3 = num;
						num = (short)820510720;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)906089396;
				short num2 = num;
				num = (short)933483444;
				switch (num2 == num)
				{
				}
				num = (short)668008448;
				short num3 = num;
				num = (short)758972417;
				if (num != 0)
				{
				}
				num = (short)1120665600;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170047AA RID: 18346
		// (get) Token: 0x06008DF8 RID: 36344 RVA: 0x00860128 File Offset: 0x0085E328
		public override int Min
		{
			get
			{
				short num = (short)405357619;
				short num2 = num;
				num = (short)799753267;
				switch (num2 == num)
				{
				}
				num = (short)1062076416;
				short num3 = num;
				num = (short)2129526785;
				if (num != 0)
				{
				}
				num = (short)40632320;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset._Min;
			}
		}

		// Token: 0x170047AB RID: 18347
		// (get) Token: 0x06008DF9 RID: 36345 RVA: 0x008601D8 File Offset: 0x0085E3D8
		// (set) Token: 0x06008DFA RID: 36346 RVA: 0x00860284 File Offset: 0x0085E484
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1750968476;
				short num2 = num;
				num = (short)2041882780;
				switch (num2 == num)
				{
				}
				num = (short)433455104;
				short num3 = num;
				num = (short)533004288;
				if (num != 0)
				{
				}
				num = (short)328335361;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)385697638;
				short num2 = num;
				num = (short)1290815334;
				switch (num2 == num)
				{
				}
				num = (short)600768512;
				short num3 = num;
				num = (short)1715142656;
				if (num != 0)
				{
				}
				num = (short)777781249;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170047AC RID: 18348
		// (get) Token: 0x06008DFB RID: 36347 RVA: 0x00860330 File Offset: 0x0085E530
		public bool HasDiffs
		{
			get
			{
				short num = (short)316004788;
				short num2 = num;
				num = (short)1005509044;
				switch (num2 == num)
				{
				}
				num = (short)1306394624;
				short num3 = num;
				num = (short)1927741441;
				if (num != 0)
				{
				}
				num = (short)2087518208;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x008603E0 File Offset: 0x0085E5E0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1585295160;
			short num2 = num;
			num = (short)833007416;
			switch (num2 == num)
			{
			}
			num = (short)1491599360;
			short num3 = num;
			num = (short)199098369;
			if (num != 0)
			{
			}
			num = (short)1802240000;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInner(this);
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x00860490 File Offset: 0x0085E690
		internal void SetValues()
		{
			short num = (short)1341276870;
			short num2 = num;
			num = (short)1025786566;
			switch (num2 == num)
			{
			}
			num = (short)1367080960;
			short num3 = num;
			num = (short)117047297;
			if (num != 0)
			{
			}
			num = (short)327286784;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON;
			base.KeySeed = global::CommonResources.AcgResources.ID_DATABUTTON_2;
			base.DataTransferOrder = 23;
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x00860568 File Offset: 0x0085E768
		// Note: this type is marked as 'beforefieldinit'.
		static DataButtonInnerRecset()
		{
			short num = (short)365068932;
			short num2 = num;
			num = (short)1677951620;
			switch (num2 == num)
			{
			}
			num = (short)1308426240;
			short num3 = num;
			num = (short)1887436800;
			if (num != 0)
			{
			}
			num = (short)1624440833;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset._Min = 1;
		}

		// Token: 0x04004639 RID: 17977
		public static int _MaxPool;

		// Token: 0x0400463A RID: 17978
		public static int _Max;

		// Token: 0x0400463B RID: 17979
		public int _DynMax;

		// Token: 0x0400463C RID: 17980
		public static int _Min;

		// Token: 0x0400463D RID: 17981
		public static int _DefaultRecordCount;
	}
}
