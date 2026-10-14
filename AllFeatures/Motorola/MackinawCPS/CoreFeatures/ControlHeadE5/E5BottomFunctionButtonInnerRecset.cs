using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F3 RID: 1011
	[global::System.Serializable]
	public class E5BottomFunctionButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008CB5 RID: 36021 RVA: 0x008410A8 File Offset: 0x0083F2A8
		public E5BottomFunctionButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON, global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x008410CC File Offset: 0x0083F2CC
		public E5BottomFunctionButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004726 RID: 18214
		// (get) Token: 0x06008CB7 RID: 36023 RVA: 0x008410F8 File Offset: 0x0083F2F8
		public override int MaxPool
		{
			get
			{
				short num = (short)888406016;
				short num2 = num;
				num = (short)31457281;
				if (num != 0)
				{
				}
				num = (short)1304761126;
				short num3 = num;
				num = (short)386601766;
				switch (num3 == num)
				{
				}
				num = (short)886308864;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004727 RID: 18215
		// (get) Token: 0x06008CB8 RID: 36024 RVA: 0x008411A8 File Offset: 0x0083F3A8
		// (set) Token: 0x06008CB9 RID: 36025 RVA: 0x0084126C File Offset: 0x0083F46C
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)294042453;
					short num2 = num;
					num = (short)1285929813;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					case 1:
						break;
					default:
					{
						num = (short)678821888;
						short num3 = num;
						break;
					}
					}
					num = (short)87490561;
					if (num != 0)
					{
					}
					num = (short)580452352;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset._Max;
				}
				IL_B0:
				return this._DynMax;
			}
			set
			{
				short num = (short)1645723183;
				short num2 = num;
				num = (short)983940655;
				switch (num2 == num)
				{
				}
				num = (short)1290534912;
				short num3 = num;
				num = (short)1102315521;
				if (num != 0)
				{
				}
				num = (short)924778496;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004728 RID: 18216
		// (get) Token: 0x06008CBA RID: 36026 RVA: 0x00841320 File Offset: 0x0083F520
		public override int Min
		{
			get
			{
				short num = (short)1245970433;
				if (num != 0)
				{
				}
				num = (short)588006852;
				short num2 = num;
				num = (short)1994606020;
				switch (num2 == num)
				{
				default:
				{
					num = (short)142344192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)368181248;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset._Min;
			}
		}

		// Token: 0x17004729 RID: 18217
		// (get) Token: 0x06008CBB RID: 36027 RVA: 0x008413D0 File Offset: 0x0083F5D0
		// (set) Token: 0x06008CBC RID: 36028 RVA: 0x00841480 File Offset: 0x0083F680
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1150563729;
				short num2 = num;
				num = (short)1932801425;
				switch (num2 == num)
				{
				}
				num = (short)1557266432;
				short num3 = num;
				num = (short)296943616;
				if (num != 0)
				{
				}
				num = (short)1524891649;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1790492483;
				short num2 = num;
				num = (short)1655422787;
				switch (num2 == num)
				{
				}
				num = (short)1958412288;
				short num3 = num;
				num = (short)930086913;
				if (num != 0)
				{
				}
				num = (short)1374027776;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700472A RID: 18218
		// (get) Token: 0x06008CBD RID: 36029 RVA: 0x00841530 File Offset: 0x0083F730
		public bool HasDiffs
		{
			get
			{
				short num = (short)932466247;
				short num2 = num;
				num = (short)885673543;
				switch (num2 == num)
				{
				}
				num = (short)1851850752;
				short num3 = num;
				num = (short)1764753409;
				if (num != 0)
				{
				}
				num = (short)418709504;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x008415E0 File Offset: 0x0083F7E0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1679135843;
			short num2 = num;
			num = (short)1087083619;
			switch (num2 == num)
			{
			}
			num = (short)1286930432;
			short num3 = num;
			num = (short)1445068801;
			if (num != 0)
			{
			}
			num = (short)1532690432;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner(this);
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x00841690 File Offset: 0x0083F890
		internal void SetValues()
		{
			short num = (short)1746867843;
			short num2 = num;
			num = (short)1055528579;
			switch (num2 == num)
			{
			}
			num = (short)111738880;
			short num3 = num;
			num = (short)929497089;
			if (num != 0)
			{
			}
			num = (short)1166082048;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.KeySeed = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06008CC0 RID: 36032 RVA: 0x00841764 File Offset: 0x0083F964
		// Note: this type is marked as 'beforefieldinit'.
		static E5BottomFunctionButtonInnerRecset()
		{
			short num = (short)1792828337;
			short num2 = num;
			num = (short)37446577;
			switch (num2 == num)
			{
			}
			num = (short)989462528;
			short num3 = num;
			num = (short)426049537;
			if (num != 0)
			{
			}
			num = (short)977338368;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset._Min = 1;
		}

		// Token: 0x04004575 RID: 17781
		public static int _MaxPool;

		// Token: 0x04004576 RID: 17782
		public static int _Max;

		// Token: 0x04004577 RID: 17783
		public int _DynMax;

		// Token: 0x04004578 RID: 17784
		public static int _Min;

		// Token: 0x04004579 RID: 17785
		public static int _DefaultRecordCount;
	}
}
