using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200021B RID: 539
	[global::System.Serializable]
	public class AuxControlTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006354 RID: 25428 RVA: 0x0058EA60 File Offset: 0x0058CC60
		public AuxControlTableInnerRecset() : base(global::CommonResources.AcgResources.ID_AUXCONTROLTABLE, global::CommonResources.AcgResources.ID_AUXCONTROL)
		{
			this.SetValues();
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x0058EA84 File Offset: 0x0058CC84
		public AuxControlTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x06006356 RID: 25430 RVA: 0x0058EAB0 File Offset: 0x0058CCB0
		public override int MaxPool
		{
			get
			{
				short num = (short)1271857153;
				if (num != 0)
				{
				}
				num = (short)286727552;
				short num2 = num;
				num = (short)1241324928;
				switch (num2 == num)
				{
				}
				num = (short)1300234240;
				short num3 = num;
				num = (short)336134144;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x06006357 RID: 25431 RVA: 0x0058EB68 File Offset: 0x0058CD68
		// (set) Token: 0x06006358 RID: 25432 RVA: 0x0058EC2C File Offset: 0x0058CE2C
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num;
					for (;;)
					{
						num = (short)1756692481;
						if (num != 0)
						{
						}
						num = (short)2104443495;
						short num2 = num;
						num = (short)1887060583;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6E;
						}
					}
					IL_6E:
					num = (short)914685952;
					if (num != 0)
					{
					}
					num = (short)400818176;
					short num3 = num;
					return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)319416687;
				short num2 = num;
				num = (short)512354671;
				switch (num2 == num)
				{
				}
				num = (short)19464193;
				if (num != 0)
				{
				}
				num = (short)1379991552;
				short num3 = num;
				num = (short)812122112;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x06006359 RID: 25433 RVA: 0x0058ECE0 File Offset: 0x0058CEE0
		public override int Min
		{
			get
			{
				short num = (short)1957879915;
				short num2 = num;
				num = (short)1310908523;
				switch (num2 == num)
				{
				}
				num = (short)1523449857;
				if (num != 0)
				{
				}
				num = (short)376045568;
				short num3 = num;
				num = (short)521535488;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset._Min;
			}
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600635A RID: 25434 RVA: 0x0058ED90 File Offset: 0x0058CF90
		// (set) Token: 0x0600635B RID: 25435 RVA: 0x0058EE3C File Offset: 0x0058D03C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1050024649;
				short num2 = num;
				num = (short)1051597513;
				switch (num2 == num)
				{
				}
				num = (short)1973813249;
				if (num != 0)
				{
				}
				num = (short)964820992;
				short num3 = num;
				num = (short)402784256;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)665814933;
				short num2 = num;
				num = (short)701073301;
				switch (num2 == num)
				{
				}
				num = (short)314769408;
				if (num != 0)
				{
				}
				num = (short)108396544;
				short num3 = num;
				num = (short)718209025;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600635C RID: 25436 RVA: 0x0058EEEC File Offset: 0x0058D0EC
		public bool HasDiffs
		{
			get
			{
				short num = (short)171949555;
				short num2 = num;
				num = (short)1861533171;
				switch (num2 == num)
				{
				}
				num = (short)1992884225;
				if (num != 0)
				{
				}
				num = (short)1316880384;
				short num3 = num;
				num = (short)305594368;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x0058EF9C File Offset: 0x0058D19C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)279764630;
			short num2 = num;
			num = (short)1044110998;
			switch (num2 == num)
			{
			}
			num = (short)559677440;
			if (num != 0)
			{
			}
			num = (short)1856045056;
			short num3 = num;
			num = (short)1447821313;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInner(this);
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x0058F048 File Offset: 0x0058D248
		internal void SetValues()
		{
			short num = (short)1083248298;
			short num2 = num;
			num = (short)505286314;
			switch (num2 == num)
			{
			}
			num = (short)1453064193;
			if (num != 0)
			{
			}
			num = (short)1936457728;
			short num3 = num;
			num = (short)1163722752;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_AUXCONTROLTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_AUXCONTROL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x0058F120 File Offset: 0x0058D320
		// Note: this type is marked as 'beforefieldinit'.
		static AuxControlTableInnerRecset()
		{
			short num = (short)544308815;
			short num2 = num;
			num = (short)646348367;
			switch (num2 == num)
			{
			}
			num = (short)357629952;
			if (num != 0)
			{
			}
			num = (short)2093350912;
			short num3 = num;
			num = (short)1790181377;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerRecset._Min = 1;
		}

		// Token: 0x04002628 RID: 9768
		public static int _MaxPool;

		// Token: 0x04002629 RID: 9769
		public static int _Max;

		// Token: 0x0400262A RID: 9770
		public int _DynMax;

		// Token: 0x0400262B RID: 9771
		public static int _Min;

		// Token: 0x0400262C RID: 9772
		public static int _DefaultRecordCount;
	}
}
