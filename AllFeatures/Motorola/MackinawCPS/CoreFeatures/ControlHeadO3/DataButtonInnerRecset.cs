using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003BD RID: 957
	[global::System.Serializable]
	public class DataButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600899B RID: 35227 RVA: 0x0080C070 File Offset: 0x0080A270
		public DataButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_O3DATABUTTON)
		{
			this.SetValues();
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x0080C090 File Offset: 0x0080A290
		public DataButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170045C6 RID: 17862
		// (get) Token: 0x0600899D RID: 35229 RVA: 0x0080C0BC File Offset: 0x0080A2BC
		public override int MaxPool
		{
			get
			{
				short num = (short)710843435;
				short num2 = num;
				num = (short)914988075;
				switch (num2 == num)
				{
				}
				num = (short)762707969;
				if (num != 0)
				{
				}
				num = (short)2081816576;
				if (num != 0)
				{
				}
				num = (short)403046400;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x170045C7 RID: 17863
		// (get) Token: 0x0600899E RID: 35230 RVA: 0x0080C16C File Offset: 0x0080A36C
		// (set) Token: 0x0600899F RID: 35231 RVA: 0x0080C234 File Offset: 0x0080A434
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)531765357;
					short num2 = num;
					num = (short)1815091309;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)742457344;
						short num3 = num;
						num = (short)1489371136;
						if (num != 0)
						{
						}
						num = (short)1705902081;
						if (num != 0)
						{
						}
						break;
					}
					}
					return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1682957693;
				short num2 = num;
				num = (short)1117578621;
				switch (num2 == num)
				{
				}
				num = (short)461701120;
				if (num != 0)
				{
				}
				num = (short)1880752129;
				if (num != 0)
				{
				}
				num = (short)1260388352;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170045C8 RID: 17864
		// (get) Token: 0x060089A0 RID: 35232 RVA: 0x0080C2E4 File Offset: 0x0080A4E4
		public override int Min
		{
			get
			{
				short num = (short)586285057;
				if (num != 0)
				{
				}
				num = (short)1187847550;
				short num2 = num;
				num = (short)71376254;
				switch (num2 == num)
				{
				}
				num = (short)2076704768;
				if (num != 0)
				{
				}
				num = (short)971505664;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset._Min;
			}
		}

		// Token: 0x170045C9 RID: 17865
		// (get) Token: 0x060089A1 RID: 35233 RVA: 0x0080C398 File Offset: 0x0080A598
		// (set) Token: 0x060089A2 RID: 35234 RVA: 0x0080C448 File Offset: 0x0080A648
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1741225985;
				if (num != 0)
				{
				}
				num = (short)1234106784;
				short num2 = num;
				num = (short)1891760544;
				switch (num2 == num)
				{
				}
				num = (short)1494679552;
				if (num != 0)
				{
				}
				num = (short)511574016;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1009582081;
				if (num != 0)
				{
				}
				num = (short)1469881204;
				short num2 = num;
				num = (short)942775156;
				switch (num2 == num)
				{
				}
				num = (short)552337408;
				if (num != 0)
				{
				}
				num = (short)30146560;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170045CA RID: 17866
		// (get) Token: 0x060089A3 RID: 35235 RVA: 0x0080C4F8 File Offset: 0x0080A6F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)2006495043;
				short num2 = num;
				num = (short)1680912195;
				switch (num2 == num)
				{
				}
				num = (short)865337345;
				if (num != 0)
				{
				}
				num = (short)1313734656;
				if (num != 0)
				{
				}
				num = (short)28114944;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x0080C5AC File Offset: 0x0080A7AC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2118159673;
			short num2 = num;
			num = (short)1020103993;
			switch (num2 == num)
			{
			}
			num = (short)884736001;
			if (num != 0)
			{
			}
			num = (short)618790912;
			if (num != 0)
			{
			}
			num = (short)1836253184;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInner(this);
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x0080C660 File Offset: 0x0080A860
		internal void SetValues()
		{
			short num = (short)2142628827;
			short num2 = num;
			num = (short)140700635;
			switch (num2 == num)
			{
			}
			num = (short)596967425;
			if (num != 0)
			{
			}
			num = (short)2098593792;
			if (num != 0)
			{
			}
			num = (short)1102512128;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_O3DATABUTTON;
			base.DataTransferOrder = 17;
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x0080C728 File Offset: 0x0080A928
		// Note: this type is marked as 'beforefieldinit'.
		static DataButtonInnerRecset()
		{
			short num = (short)49818650;
			short num2 = num;
			num = (short)1509633050;
			switch (num2 == num)
			{
			}
			num = (short)1756364801;
			if (num != 0)
			{
			}
			num = (short)1043267584;
			if (num != 0)
			{
			}
			num = (short)726990848;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset._Min = 1;
		}

		// Token: 0x04004180 RID: 16768
		public static int _MaxPool;

		// Token: 0x04004181 RID: 16769
		public static int _Max;

		// Token: 0x04004182 RID: 16770
		public int _DynMax;

		// Token: 0x04004183 RID: 16771
		public static int _Min;

		// Token: 0x04004184 RID: 16772
		public static int _DefaultRecordCount;
	}
}
