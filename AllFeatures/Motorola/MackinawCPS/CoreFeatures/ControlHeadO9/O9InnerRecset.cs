using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000374 RID: 884
	[global::System.Serializable]
	public class O9InnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600831B RID: 33563 RVA: 0x007A0294 File Offset: 0x0079E494
		public O9InnerRecset() : base(global::CommonResources.AcgResources.ID_O9)
		{
			this.SetValues();
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x007A02B4 File Offset: 0x0079E4B4
		public O9InnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x0600831D RID: 33565 RVA: 0x007A02E0 File Offset: 0x0079E4E0
		public override int MaxPool
		{
			get
			{
				short num = (short)1383831500;
				short num2 = num;
				num = (short)270047180;
				switch (num2 == num)
				{
				}
				num = (short)524681216;
				short num3 = num;
				num = (short)1200816128;
				if (num != 0)
				{
				}
				num = (short)639959041;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset._MaxPool;
			}
		}

		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x0600831E RID: 33566 RVA: 0x007A038C File Offset: 0x0079E58C
		// (set) Token: 0x0600831F RID: 33567 RVA: 0x007A0450 File Offset: 0x0079E650
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)141474034;
					short num2 = num;
					num = (short)1670166770;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1447755776;
						short num3 = num;
						num = (short)435945472;
						if (num != 0)
						{
						}
						num = (short)1935081473;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1500058442;
				short num2 = num;
				num = (short)1962021706;
				switch (num2 == num)
				{
				}
				num = (short)1995505664;
				short num3 = num;
				num = (short)45154305;
				if (num != 0)
				{
				}
				num = (short)454230016;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x007A0500 File Offset: 0x0079E700
		public override int Min
		{
			get
			{
				short num = (short)1483687768;
				short num2 = num;
				num = (short)1445545816;
				switch (num2 == num)
				{
				}
				num = (short)2115960832;
				short num3 = num;
				num = (short)1010434049;
				if (num != 0)
				{
				}
				num = (short)1860501504;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset._Min;
			}
		}

		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x06008321 RID: 33569 RVA: 0x007A05B0 File Offset: 0x0079E7B0
		// (set) Token: 0x06008322 RID: 33570 RVA: 0x007A0660 File Offset: 0x0079E860
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)374135428;
				short num2 = num;
				num = (short)5757572;
				switch (num2 == num)
				{
				}
				num = (short)878116864;
				short num3 = num;
				num = (short)1076101121;
				if (num != 0)
				{
				}
				num = (short)44761088;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1365141348;
				short num2 = num;
				num = (short)653879140;
				switch (num2 == num)
				{
				}
				num = (short)1613365248;
				short num3 = num;
				num = (short)1969356801;
				if (num != 0)
				{
				}
				num = (short)820314112;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x06008323 RID: 33571 RVA: 0x007A0710 File Offset: 0x0079E910
		public bool HasDiffs
		{
			get
			{
				short num = (short)1908271016;
				short num2 = num;
				num = (short)967042984;
				switch (num2 == num)
				{
				}
				num = (short)1024393216;
				short num3 = num;
				num = (short)663617537;
				if (num != 0)
				{
				}
				num = (short)921567232;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x007A07C4 File Offset: 0x0079E9C4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)660406273;
			if (num != 0)
			{
			}
			num = (short)1038576824;
			short num2 = num;
			num = (short)1875274936;
			switch (num2 == num)
			{
			default:
			{
				num = (short)280625152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2139357184;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9Inner(this);
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x007A0874 File Offset: 0x0079EA74
		internal void SetValues()
		{
			short num = (short)586071832;
			short num2 = num;
			num = (short)1772994328;
			switch (num2 == num)
			{
			}
			num = (short)196345856;
			short num3 = num;
			num = (short)1341652993;
			if (num != 0)
			{
			}
			num = (short)1368981504;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_O9;
			base.DataTransferOrder = 50;
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x007A0940 File Offset: 0x0079EB40
		// Note: this type is marked as 'beforefieldinit'.
		static O9InnerRecset()
		{
			short num = (short)352078045;
			short num2 = num;
			num = (short)1219512541;
			switch (num2 == num)
			{
			}
			num = (short)845086720;
			short num3 = num;
			num = (short)530710529;
			if (num != 0)
			{
			}
			num = (short)737083392;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset._Min = 1;
		}

		// Token: 0x04003E51 RID: 15953
		public static int _MaxPool;

		// Token: 0x04003E52 RID: 15954
		public static int _Max;

		// Token: 0x04003E53 RID: 15955
		public int _DynMax;

		// Token: 0x04003E54 RID: 15956
		public static int _Min;

		// Token: 0x04003E55 RID: 15957
		public static int _DefaultRecordCount;
	}
}
