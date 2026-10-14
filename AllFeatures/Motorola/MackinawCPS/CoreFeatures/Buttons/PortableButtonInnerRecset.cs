using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000414 RID: 1044
	[global::System.Serializable]
	public class PortableButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008EBC RID: 36540 RVA: 0x0086B380 File Offset: 0x00869580
		public PortableButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_PORTABLEBUTTON, global::CommonResources.AcgResources.ID_PORTBUTTON)
		{
			this.SetValues();
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x0086B3A4 File Offset: 0x008695A4
		public PortableButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x06008EBE RID: 36542 RVA: 0x0086B3D0 File Offset: 0x008695D0
		public override int MaxPool
		{
			get
			{
				short num = (short)1608384512;
				short num2 = num;
				num = (short)1394737153;
				if (num != 0)
				{
				}
				num = (short)2033477891;
				short num3 = num;
				num = (short)881486083;
				switch (num3 == num)
				{
				}
				num = (short)1321140224;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004810 RID: 18448
		// (get) Token: 0x06008EBF RID: 36543 RVA: 0x0086B480 File Offset: 0x00869680
		// (set) Token: 0x06008EC0 RID: 36544 RVA: 0x0086B540 File Offset: 0x00869740
		public override int Max
		{
			get
			{
				short num = (short)613482496;
				short num2 = num;
				num = (short)194296536;
				short num3 = num;
				num = (short)121158360;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)516292609;
					if (num != 0)
					{
					}
					num = (short)1654652928;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						return global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset._Max;
					}
					break;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)125239296;
				short num2 = num;
				num = (short)407442948;
				short num3 = num;
				num = (short)772019716;
				switch (num3 == num)
				{
				}
				num = (short)900530176;
				if (num != 0)
				{
				}
				num = (short)201981953;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x06008EC1 RID: 36545 RVA: 0x0086B5F4 File Offset: 0x008697F4
		public override int Min
		{
			get
			{
				short num = (short)540278784;
				short num2 = num;
				num = (short)2041374003;
				short num3 = num;
				num = (short)241952051;
				switch (num3 == num)
				{
				}
				num = (short)1691615233;
				if (num != 0)
				{
				}
				num = (short)1785593856;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset._Min;
			}
		}

		// Token: 0x17004812 RID: 18450
		// (get) Token: 0x06008EC2 RID: 36546 RVA: 0x0086B6A4 File Offset: 0x008698A4
		// (set) Token: 0x06008EC3 RID: 36547 RVA: 0x0086B758 File Offset: 0x00869958
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1274544128;
				short num2 = num;
				num = (short)1564790422;
				short num3 = num;
				num = (short)944819862;
				switch (num3 == num)
				{
				}
				num = (short)416940033;
				if (num != 0)
				{
				}
				num = (short)1639055360;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)306249728;
				short num2 = num;
				num = (short)2059573329;
				short num3 = num;
				num = (short)388274257;
				switch (num3 == num)
				{
				}
				num = (short)2054422528;
				if (num != 0)
				{
				}
				num = (short)1164509185;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004813 RID: 18451
		// (get) Token: 0x06008EC4 RID: 36548 RVA: 0x0086B808 File Offset: 0x00869A08
		public bool HasDiffs
		{
			get
			{
				short num = (short)1153499136;
				short num2 = num;
				num = (short)1979615372;
				short num3 = num;
				num = (short)300648588;
				switch (num3 == num)
				{
				}
				num = (short)755367937;
				if (num != 0)
				{
				}
				num = (short)2097938432;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008EC5 RID: 36549 RVA: 0x0086B8B8 File Offset: 0x00869AB8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)302841856;
			short num2 = num;
			num = (short)1637416961;
			if (num != 0)
			{
			}
			num = (short)567036586;
			short num3 = num;
			num = (short)843729578;
			switch (num3 == num)
			{
			}
			num = (short)1102839808;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner(this);
		}

		// Token: 0x06008EC6 RID: 36550 RVA: 0x0086B968 File Offset: 0x00869B68
		internal void SetValues()
		{
			short num = (short)1308557312;
			short num2 = num;
			num = (short)465259562;
			short num3 = num;
			num = (short)270421034;
			switch (num3 == num)
			{
			}
			num = (short)479002625;
			if (num != 0)
			{
			}
			num = (short)1495072768;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_PORTABLEBUTTON;
			base.KeySeed = global::CommonResources.AcgResources.ID_PORTBUTTON;
			base.DataTransferOrder = 23;
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x0086BA40 File Offset: 0x00869C40
		// Note: this type is marked as 'beforefieldinit'.
		static PortableButtonInnerRecset()
		{
			short num = (short)1964113920;
			short num2 = num;
			num = (short)879696021;
			short num3 = num;
			num = (short)411310229;
			switch (num3 == num)
			{
			}
			num = (short)774307840;
			if (num != 0)
			{
			}
			num = (short)902496257;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset._Min = 1;
		}

		// Token: 0x04004778 RID: 18296
		public static int _MaxPool;

		// Token: 0x04004779 RID: 18297
		public static int _Max;

		// Token: 0x0400477A RID: 18298
		public int _DynMax;

		// Token: 0x0400477B RID: 18299
		public static int _Min;

		// Token: 0x0400477C RID: 18300
		public static int _DefaultRecordCount;
	}
}
