using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x02000297 RID: 663
	[global::System.Serializable]
	public class ConventionalSwitchTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007440 RID: 29760 RVA: 0x0068C458 File Offset: 0x0068A658
		public ConventionalSwitchTableInnerRecset() : base(global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHTABLE, global::CommonResources.AcgResources.ID_CNVSWITCH)
		{
			this.SetValues();
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x0068C47C File Offset: 0x0068A67C
		public ConventionalSwitchTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x06007442 RID: 29762 RVA: 0x0068C4A8 File Offset: 0x0068A6A8
		public override int MaxPool
		{
			get
			{
				short num = (short)274636259;
				short num2 = num;
				num = (short)1785830883;
				switch (num2 == num)
				{
				}
				num = (short)2124742656;
				if (num != 0)
				{
				}
				num = (short)1346437120;
				short num3 = num;
				num = (short)780337153;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x06007443 RID: 29763 RVA: 0x0068C558 File Offset: 0x0068A758
		// (set) Token: 0x06007444 RID: 29764 RVA: 0x0068C61C File Offset: 0x0068A81C
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)1018459764;
					short num2 = num;
					num = (short)631731828;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)335478785;
						if (num != 0)
						{
						}
						num = (short)114556928;
						if (num != 0)
						{
						}
						num = (short)1394933760;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)232978392;
				short num2 = num;
				num = (short)117569496;
				switch (num2 == num)
				{
				}
				num = (short)1435041792;
				if (num != 0)
				{
				}
				num = (short)421658624;
				short num3 = num;
				num = (short)1902903297;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x06007445 RID: 29765 RVA: 0x0068C6D0 File Offset: 0x0068A8D0
		public override int Min
		{
			get
			{
				short num = (short)1217671113;
				short num2 = num;
				num = (short)1726558153;
				switch (num2 == num)
				{
				}
				num = (short)1630339073;
				if (num != 0)
				{
				}
				num = (short)1907949568;
				short num3 = num;
				num = (short)1771307008;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset._Min;
			}
		}

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x06007446 RID: 29766 RVA: 0x0068C77C File Offset: 0x0068A97C
		// (set) Token: 0x06007447 RID: 29767 RVA: 0x0068C82C File Offset: 0x0068AA2C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1542687144;
				short num2 = num;
				num = (short)53643688;
				switch (num2 == num)
				{
				}
				num = (short)1240465409;
				if (num != 0)
				{
				}
				num = (short)576389120;
				short num3 = num;
				num = (short)1711996928;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1477130208;
				short num2 = num;
				num = (short)297809888;
				switch (num2 == num)
				{
				}
				num = (short)1031864321;
				if (num != 0)
				{
				}
				num = (short)1967194112;
				short num3 = num;
				num = (short)1312751616;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x06007448 RID: 29768 RVA: 0x0068C8E0 File Offset: 0x0068AAE0
		public bool HasDiffs
		{
			get
			{
				short num = (short)743178241;
				if (num != 0)
				{
				}
				num = (short)283447908;
				short num2 = num;
				num = (short)293212772;
				switch (num2 == num)
				{
				}
				num = (short)814743552;
				short num3 = num;
				num = (short)861208576;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x0068C990 File Offset: 0x0068AB90
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)808257977;
			short num2 = num;
			num = (short)511904185;
			switch (num2 == num)
			{
			}
			num = (short)1885339649;
			if (num != 0)
			{
			}
			num = (short)649134080;
			short num3 = num;
			num = (short)947453952;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInner(this);
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x0068CA40 File Offset: 0x0068AC40
		internal void SetValues()
		{
			short num = (short)843294024;
			short num2 = num;
			num = (short)1694344520;
			switch (num2 == num)
			{
			}
			num = (short)1895956481;
			if (num != 0)
			{
			}
			num = (short)472842240;
			if (num != 0)
			{
			}
			num = (short)1199243264;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_CNVSWITCH;
			base.DataTransferOrder = 24;
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x0068CB14 File Offset: 0x0068AD14
		// Note: this type is marked as 'beforefieldinit'.
		static ConventionalSwitchTableInnerRecset()
		{
			short num = (short)1056091879;
			short num2 = num;
			num = (short)886812391;
			switch (num2 == num)
			{
			}
			num = (short)669188097;
			if (num != 0)
			{
			}
			num = (short)509739008;
			if (num != 0)
			{
			}
			num = (short)78118912;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset._Min = 1;
		}

		// Token: 0x04002D11 RID: 11537
		public static int _MaxPool;

		// Token: 0x04002D12 RID: 11538
		public static int _Max;

		// Token: 0x04002D13 RID: 11539
		public int _DynMax;

		// Token: 0x04002D14 RID: 11540
		public static int _Min;

		// Token: 0x04002D15 RID: 11541
		public static int _DefaultRecordCount;
	}
}
