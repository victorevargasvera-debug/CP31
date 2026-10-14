using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Keypad
{
	// Token: 0x02000303 RID: 771
	[global::System.Serializable]
	public class KeypadButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007ACF RID: 31439 RVA: 0x006FF8FC File Offset: 0x006FDAFC
		public KeypadButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_KEYPADBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x006FF91C File Offset: 0x006FDB1C
		public KeypadButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003F05 RID: 16133
		// (get) Token: 0x06007AD1 RID: 31441 RVA: 0x006FF948 File Offset: 0x006FDB48
		public override int MaxPool
		{
			get
			{
				short num = (short)1821442049;
				if (num != 0)
				{
				}
				num = (short)1451661721;
				short num2 = num;
				num = (short)1784060313;
				switch (num2 == num)
				{
				}
				num = (short)283508736;
				short num3 = num;
				num = (short)1622999040;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003F06 RID: 16134
		// (get) Token: 0x06007AD2 RID: 31442 RVA: 0x006FF9F4 File Offset: 0x006FDBF4
		// (set) Token: 0x06007AD3 RID: 31443 RVA: 0x006FFAB4 File Offset: 0x006FDCB4
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					for (;;)
					{
						num = (short)104219625;
						short num2 = num;
						num = (short)836453353;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_3F;
						}
					}
					IL_3F:
					num = (short)1108803585;
					if (num != 0)
					{
					}
					num = (short)17104896;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset._Max;
				}
				num = (short)1509621760;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)1572668490;
				short num2 = num;
				num = (short)869925962;
				switch (num2 == num)
				{
				}
				num = (short)1959329792;
				if (num != 0)
				{
				}
				num = (short)1211760640;
				short num3 = num;
				num = (short)1495072769;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003F07 RID: 16135
		// (get) Token: 0x06007AD4 RID: 31444 RVA: 0x006FFB60 File Offset: 0x006FDD60
		public override int Min
		{
			get
			{
				short num = (short)1716453377;
				if (num != 0)
				{
				}
				num = (short)1333725440;
				short num2 = num;
				num = (short)1914767616;
				switch (num2 == num)
				{
				}
				num = (short)1453457408;
				short num3 = num;
				num = (short)1971912704;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset._Min;
			}
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x06007AD5 RID: 31445 RVA: 0x006FFC14 File Offset: 0x006FDE14
		// (set) Token: 0x06007AD6 RID: 31446 RVA: 0x006FFCC4 File Offset: 0x006FDEC4
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)633965523;
				short num2 = num;
				num = (short)1291815891;
				switch (num2 == num)
				{
				}
				num = (short)1761017857;
				if (num != 0)
				{
				}
				num = (short)188219392;
				short num3 = num;
				num = (short)1703084032;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)848388431;
				short num2 = num;
				num = (short)281633103;
				switch (num2 == num)
				{
				}
				num = (short)1528233984;
				if (num != 0)
				{
				}
				num = (short)609157120;
				short num3 = num;
				num = (short)43253761;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x06007AD7 RID: 31447 RVA: 0x006FFD74 File Offset: 0x006FDF74
		public bool HasDiffs
		{
			get
			{
				short num = (short)2030950191;
				short num2 = num;
				num = (short)1007408943;
				switch (num2 == num)
				{
				}
				num = (short)1112473601;
				if (num != 0)
				{
				}
				num = (short)1990721536;
				short num3 = num;
				num = (short)36569088;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x006FFE20 File Offset: 0x006FE020
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)940653150;
			short num2 = num;
			num = (short)175127134;
			switch (num2 == num)
			{
			}
			num = (short)464388097;
			if (num != 0)
			{
			}
			num = (short)2128674816;
			short num3 = num;
			num = (short)119734272;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner(this);
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x006FFED0 File Offset: 0x006FE0D0
		internal void SetValues()
		{
			short num = (short)1053755713;
			short num2 = num;
			num = (short)1618217281;
			switch (num2 == num)
			{
			}
			num = (short)106430464;
			if (num != 0)
			{
			}
			num = (short)1163788288;
			short num3 = num;
			num = (short)2126512129;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_KEYPADBUTTON;
			base.DataTransferOrder = 56;
		}

		// Token: 0x06007ADA RID: 31450 RVA: 0x006FFF9C File Offset: 0x006FE19C
		// Note: this type is marked as 'beforefieldinit'.
		static KeypadButtonInnerRecset()
		{
			short num = (short)1360902996;
			short num2 = num;
			num = (short)1108851540;
			switch (num2 == num)
			{
			}
			num = (short)309067776;
			if (num != 0)
			{
			}
			num = (short)2055929856;
			short num3 = num;
			num = (short)755499009;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset._Min = 1;
		}

		// Token: 0x040035E0 RID: 13792
		public static int _MaxPool;

		// Token: 0x040035E1 RID: 13793
		public static int _Max;

		// Token: 0x040035E2 RID: 13794
		public int _DynMax;

		// Token: 0x040035E3 RID: 13795
		public static int _Min;

		// Token: 0x040035E4 RID: 13796
		public static int _DefaultRecordCount;
	}
}
