using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002BB RID: 699
	[global::System.Serializable]
	public class RotaryControlInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600753F RID: 30015 RVA: 0x0069BEBC File Offset: 0x0069A0BC
		public RotaryControlInnerRecset() : base(global::CommonResources.AcgResources.ID_ROTARYCONTROL, global::CommonResources.AcgResources.ID_ROTARYCON)
		{
			this.SetValues();
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x0069BEE0 File Offset: 0x0069A0E0
		public RotaryControlInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x06007541 RID: 30017 RVA: 0x0069BF0C File Offset: 0x0069A10C
		public override int MaxPool
		{
			get
			{
				short num = (short)1623982081;
				if (num != 0)
				{
				}
				num = (short)604033847;
				short num2 = num;
				num = (short)2088948535;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1296105472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)291110912;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x06007542 RID: 30018 RVA: 0x0069BFBC File Offset: 0x0069A1BC
		// (set) Token: 0x06007543 RID: 30019 RVA: 0x0069C07C File Offset: 0x0069A27C
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)626589696;
					short num2 = num;
					if (this._DynMax != -1)
					{
						goto IL_AB;
					}
					num = (short)113508353;
					if (num != 0)
					{
					}
					num = (short)689831007;
					short num3 = num;
					num = (short)1707867231;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_90;
					}
				}
				IL_90:
				num = (short)1627979776;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset._Max;
				IL_AB:
				return this._DynMax;
			}
			set
			{
				short num = (short)1855640010;
				short num2 = num;
				num = (short)1561252298;
				switch (num2 == num)
				{
				}
				num = (short)142934016;
				short num3 = num;
				num = (short)336592897;
				if (num != 0)
				{
				}
				num = (short)803995648;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x06007544 RID: 30020 RVA: 0x0069C130 File Offset: 0x0069A330
		public override int Min
		{
			get
			{
				short num = (short)1297553387;
				short num2 = num;
				num = (short)528160747;
				switch (num2 == num)
				{
				}
				num = (short)785055744;
				short num3 = num;
				num = (short)1497235457;
				if (num != 0)
				{
				}
				num = (short)758054912;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset._Min;
			}
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x06007545 RID: 30021 RVA: 0x0069C1DC File Offset: 0x0069A3DC
		// (set) Token: 0x06007546 RID: 30022 RVA: 0x0069C288 File Offset: 0x0069A488
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)375880204;
				short num2 = num;
				num = (short)35289612;
				switch (num2 == num)
				{
				}
				num = (short)250478592;
				short num3 = num;
				num = (short)899219457;
				if (num != 0)
				{
				}
				num = (short)807206912;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1299565113;
				short num2 = num;
				num = (short)876595769;
				switch (num2 == num)
				{
				}
				num = (short)1915355136;
				short num3 = num;
				num = (short)1137770497;
				if (num != 0)
				{
				}
				num = (short)1217789952;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x06007547 RID: 30023 RVA: 0x0069C338 File Offset: 0x0069A538
		public bool HasDiffs
		{
			get
			{
				short num = (short)1524804835;
				short num2 = num;
				num = (short)1480961251;
				switch (num2 == num)
				{
				}
				num = (short)616628224;
				short num3 = num;
				num = (short)522518529;
				if (num != 0)
				{
				}
				num = (short)1538457600;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x0069C3EC File Offset: 0x0069A5EC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)572274432;
			short num2 = num;
			num = (short)1829517056;
			switch (num2 == num)
			{
			}
			num = (short)719781888;
			short num3 = num;
			num = (short)187957249;
			if (num != 0)
			{
			}
			num = (short)1320419328;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInner(this);
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x0069C4A0 File Offset: 0x0069A6A0
		internal void SetValues()
		{
			short num = (short)1880621057;
			if (num != 0)
			{
			}
			num = (short)2017489798;
			short num2 = num;
			num = (short)1500607366;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1331363840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1844707328;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_ROTARYCONTROL;
			base.KeySeed = global::CommonResources.AcgResources.ID_ROTARYCON;
			base.DataTransferOrder = 24;
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x0069C578 File Offset: 0x0069A778
		// Note: this type is marked as 'beforefieldinit'.
		static RotaryControlInnerRecset()
		{
			short num = (short)35228749;
			short num2 = num;
			num = (short)1917946957;
			switch (num2 == num)
			{
			}
			num = (short)1165688832;
			short num3 = num;
			num = (short)442564609;
			if (num != 0)
			{
			}
			num = (short)306577408;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset._Min = 1;
		}

		// Token: 0x04002F80 RID: 12160
		public static int _MaxPool;

		// Token: 0x04002F81 RID: 12161
		public static int _Max;

		// Token: 0x04002F82 RID: 12162
		public int _DynMax;

		// Token: 0x04002F83 RID: 12163
		public static int _Min;

		// Token: 0x04002F84 RID: 12164
		public static int _DefaultRecordCount;
	}
}
