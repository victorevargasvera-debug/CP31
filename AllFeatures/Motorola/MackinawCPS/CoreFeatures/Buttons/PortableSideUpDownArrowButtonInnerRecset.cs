using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000417 RID: 1047
	[global::System.Serializable]
	public class PortableSideUpDownArrowButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008F78 RID: 36728 RVA: 0x00874C1C File Offset: 0x00872E1C
		public PortableSideUpDownArrowButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_PORTABLESIDEUPDOWNARROWBUTTON, global::CommonResources.AcgResources.ID_PORSIDEBUT)
		{
			this.SetValues();
		}

		// Token: 0x06008F79 RID: 36729 RVA: 0x00874C40 File Offset: 0x00872E40
		public PortableSideUpDownArrowButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004876 RID: 18550
		// (get) Token: 0x06008F7A RID: 36730 RVA: 0x00874C6C File Offset: 0x00872E6C
		public override int MaxPool
		{
			get
			{
				short num = (short)298511514;
				short num2 = num;
				num = (short)1977412762;
				switch (num2 == num)
				{
				}
				num = (short)2001993729;
				if (num != 0)
				{
				}
				num = (short)826474496;
				short num3 = num;
				num = (short)1553334272;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004877 RID: 18551
		// (get) Token: 0x06008F7B RID: 36731 RVA: 0x00874D20 File Offset: 0x00872F20
		// (set) Token: 0x06008F7C RID: 36732 RVA: 0x00874DE0 File Offset: 0x00872FE0
		public override int Max
		{
			get
			{
				short num = (short)1719218786;
				short num2 = num;
				num = (short)1173107298;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)854523904;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						num = (short)1554317312;
						short num3 = num;
						num = (short)49152001;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					break;
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset._Max;
			}
			set
			{
				short num = (short)303235073;
				if (num != 0)
				{
				}
				num = (short)1190380992;
				short num2 = num;
				num = (short)905823680;
				switch (num2 == num)
				{
				}
				num = (short)636944384;
				short num3 = num;
				num = (short)1276968960;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004878 RID: 18552
		// (get) Token: 0x06008F7D RID: 36733 RVA: 0x00874E8C File Offset: 0x0087308C
		public override int Min
		{
			get
			{
				short num = (short)735051777;
				if (num != 0)
				{
				}
				num = (short)156816108;
				short num2 = num;
				num = (short)996004588;
				switch (num2 == num)
				{
				}
				num = (short)2044592128;
				short num3 = num;
				num = (short)1870987264;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset._Min;
			}
		}

		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x06008F7E RID: 36734 RVA: 0x00874F38 File Offset: 0x00873138
		// (set) Token: 0x06008F7F RID: 36735 RVA: 0x00874FE8 File Offset: 0x008731E8
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2086795876;
				short num2 = num;
				num = (short)1811151460;
				switch (num2 == num)
				{
				}
				num = (short)244842497;
				if (num != 0)
				{
				}
				num = (short)984743936;
				short num3 = num;
				num = (short)839122944;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)332201985;
				if (num != 0)
				{
				}
				num = (short)289517870;
				short num2 = num;
				num = (short)481669422;
				switch (num2 == num)
				{
				}
				num = (short)1167589376;
				short num3 = num;
				num = (short)1954349056;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x06008F80 RID: 36736 RVA: 0x00875098 File Offset: 0x00873298
		public bool HasDiffs
		{
			get
			{
				short num = (short)239301790;
				short num2 = num;
				num = (short)173503646;
				switch (num2 == num)
				{
				}
				num = (short)636682241;
				if (num != 0)
				{
				}
				num = (short)1575813120;
				short num3 = num;
				num = (short)931135488;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x00875148 File Offset: 0x00873348
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1562227783;
			short num2 = num;
			num = (short)415740999;
			switch (num2 == num)
			{
			}
			num = (short)741605377;
			if (num != 0)
			{
			}
			num = (short)697237504;
			short num3 = num;
			num = (short)1977155584;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner(this);
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x008751FC File Offset: 0x008733FC
		internal void SetValues()
		{
			short num = (short)1392967681;
			if (num != 0)
			{
			}
			num = (short)194936618;
			short num2 = num;
			num = (short)1819574058;
			switch (num2 == num)
			{
			}
			num = (short)523239424;
			short num3 = num;
			num = (short)1765343232;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_PORTABLESIDEUPDOWNARROWBUTTON;
			base.KeySeed = global::CommonResources.AcgResources.ID_PORSIDEBUT;
			base.DataTransferOrder = 23;
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x008752D0 File Offset: 0x008734D0
		// Note: this type is marked as 'beforefieldinit'.
		static PortableSideUpDownArrowButtonInnerRecset()
		{
			short num = (short)657159411;
			short num2 = num;
			num = (short)770929907;
			switch (num2 == num)
			{
			}
			num = (short)146997249;
			if (num != 0)
			{
			}
			num = (short)1447100416;
			short num3 = num;
			num = (short)6029312;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset._Min = 1;
		}

		// Token: 0x04004785 RID: 18309
		public static int _MaxPool;

		// Token: 0x04004786 RID: 18310
		public static int _Max;

		// Token: 0x04004787 RID: 18311
		public int _DynMax;

		// Token: 0x04004788 RID: 18312
		public static int _Min;

		// Token: 0x04004789 RID: 18313
		public static int _DefaultRecordCount;
	}
}
