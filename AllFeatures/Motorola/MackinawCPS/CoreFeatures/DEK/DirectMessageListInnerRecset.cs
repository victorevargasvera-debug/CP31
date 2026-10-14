using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000337 RID: 823
	[global::System.Serializable]
	public class DirectMessageListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007F05 RID: 32517 RVA: 0x0074F978 File Offset: 0x0074DB78
		public DirectMessageListInnerRecset() : base(global::CommonResources.AcgResources.ID_DIRECTMESSAGELIST)
		{
			this.SetValues();
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0074F998 File Offset: 0x0074DB98
		public DirectMessageListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x06007F07 RID: 32519 RVA: 0x0074F9C4 File Offset: 0x0074DBC4
		public override int MaxPool
		{
			get
			{
				short num = (short)464802061;
				short num2 = num;
				num = (short)294211853;
				switch (num2 == num)
				{
				}
				num = (short)151060480;
				short num3 = num;
				num = (short)384696321;
				if (num != 0)
				{
				}
				num = (short)250740736;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x06007F08 RID: 32520 RVA: 0x0074FA74 File Offset: 0x0074DC74
		// (set) Token: 0x06007F09 RID: 32521 RVA: 0x0074FB34 File Offset: 0x0074DD34
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)1546452032;
					short num2 = num;
					num = (short)1696070720;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1576665088;
						short num3 = num;
						num = (short)255721472;
						if (num != 0)
						{
						}
						num = (short)1521025025;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset._Max;
			}
			set
			{
				short num = (short)1151759222;
				short num2 = num;
				num = (short)1672049526;
				switch (num2 == num)
				{
				}
				num = (short)1308557312;
				short num3 = num;
				num = (short)635699201;
				if (num != 0)
				{
				}
				num = (short)1947009024;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004105 RID: 16645
		// (get) Token: 0x06007F0A RID: 32522 RVA: 0x0074FBE4 File Offset: 0x0074DDE4
		public override int Min
		{
			get
			{
				short num = (short)389799489;
				short num2 = num;
				num = (short)2057756225;
				switch (num2 == num)
				{
				}
				num = (short)1615659008;
				short num3 = num;
				num = (short)634060800;
				if (num != 0)
				{
				}
				num = (short)1217658881;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset._Min;
			}
		}

		// Token: 0x17004106 RID: 16646
		// (get) Token: 0x06007F0B RID: 32523 RVA: 0x0074FC90 File Offset: 0x0074DE90
		// (set) Token: 0x06007F0C RID: 32524 RVA: 0x0074FD40 File Offset: 0x0074DF40
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2002220899;
				short num2 = num;
				num = (short)735803235;
				switch (num2 == num)
				{
				}
				num = (short)734593024;
				short num3 = num;
				num = (short)1260126209;
				if (num != 0)
				{
				}
				num = (short)764149760;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)540258788;
				short num2 = num;
				num = (short)2063053284;
				switch (num2 == num)
				{
				}
				num = (short)95551488;
				short num3 = num;
				num = (short)2124218369;
				if (num != 0)
				{
				}
				num = (short)1452081152;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004107 RID: 16647
		// (get) Token: 0x06007F0D RID: 32525 RVA: 0x0074FDF0 File Offset: 0x0074DFF0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1119329802;
				short num2 = num;
				num = (short)1931124234;
				switch (num2 == num)
				{
				}
				num = (short)350945280;
				short num3 = num;
				num = (short)1577123841;
				if (num != 0)
				{
				}
				num = (short)877395968;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x0074FEA4 File Offset: 0x0074E0A4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2020523203;
			short num2 = num;
			num = (short)678476995;
			switch (num2 == num)
			{
			}
			num = (short)1914699776;
			short num3 = num;
			num = (short)1267466241;
			if (num != 0)
			{
			}
			num = (short)1433206784;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner(this);
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x0074FF54 File Offset: 0x0074E154
		internal void SetValues()
		{
			short num = (short)1397486235;
			short num2 = num;
			num = (short)574485147;
			switch (num2 == num)
			{
			}
			num = (short)1487929344;
			short num3 = num;
			num = (short)37421057;
			if (num != 0)
			{
			}
			num = (short)1864040448;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMESSAGELIST;
			base.DataTransferOrder = 14;
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x00750024 File Offset: 0x0074E224
		// Note: this type is marked as 'beforefieldinit'.
		static DirectMessageListInnerRecset()
		{
			short num = (short)7821219;
			short num2 = num;
			num = (short)1718441891;
			switch (num2 == num)
			{
			}
			num = (short)489488384;
			short num3 = num;
			num = (short)166985728;
			if (num != 0)
			{
			}
			num = (short)1514930177;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset._Min = 1;
		}

		// Token: 0x040039A0 RID: 14752
		public static int _MaxPool;

		// Token: 0x040039A1 RID: 14753
		public static int _Max;

		// Token: 0x040039A2 RID: 14754
		public int _DynMax;

		// Token: 0x040039A3 RID: 14755
		public static int _Min;

		// Token: 0x040039A4 RID: 14756
		public static int _DefaultRecordCount;
	}
}
