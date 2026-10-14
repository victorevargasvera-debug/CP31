using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200032E RID: 814
	[global::System.Serializable]
	public class DEKButtonInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007D5E RID: 32094 RVA: 0x0073B91C File Offset: 0x00739B1C
		public DEKButtonInnerRecset() : base(global::CommonResources.AcgResources.ID_DEKBUTTON, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x0073B940 File Offset: 0x00739B40
		public DEKButtonInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004027 RID: 16423
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x0073B96C File Offset: 0x00739B6C
		public override int MaxPool
		{
			get
			{
				short num = (short)930152448;
				short num2 = num;
				num = (short)825710631;
				short num3 = num;
				num = (short)242767911;
				switch (num3 == num)
				{
				}
				num = (short)2018443265;
				if (num != 0)
				{
				}
				num = (short)575078400;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset._MaxPool;
			}
		}

		// Token: 0x17004028 RID: 16424
		// (get) Token: 0x06007D61 RID: 32097 RVA: 0x0073BA1C File Offset: 0x00739C1C
		// (set) Token: 0x06007D62 RID: 32098 RVA: 0x0073BADC File Offset: 0x00739CDC
		public override int Max
		{
			get
			{
				short num = (short)1351090177;
				if (num != 0)
				{
				}
				num = (short)2022131477;
				short num2 = num;
				num = (short)1030768405;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)391839744;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						num = (short)1261043712;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset._Max;
					}
					break;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1993342976;
				short num2 = num;
				num = (short)314857466;
				short num3 = num;
				num = (short)2024364026;
				switch (num3 == num)
				{
				}
				num = (short)865533953;
				if (num != 0)
				{
				}
				num = (short)973602816;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004029 RID: 16425
		// (get) Token: 0x06007D63 RID: 32099 RVA: 0x0073BB90 File Offset: 0x00739D90
		public override int Min
		{
			get
			{
				short num = (short)1341849600;
				short num2 = num;
				num = (short)1613734447;
				short num3 = num;
				num = (short)1898816047;
				switch (num3 == num)
				{
				}
				num = (short)1509752832;
				if (num != 0)
				{
				}
				num = (short)683016193;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset._Min;
			}
		}

		// Token: 0x1700402A RID: 16426
		// (get) Token: 0x06007D64 RID: 32100 RVA: 0x0073BC40 File Offset: 0x00739E40
		// (set) Token: 0x06007D65 RID: 32101 RVA: 0x0073BCF0 File Offset: 0x00739EF0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2033909760;
				short num2 = num;
				num = (short)1870473271;
				short num3 = num;
				num = (short)1653811255;
				switch (num3 == num)
				{
				}
				num = (short)1377042432;
				if (num != 0)
				{
				}
				num = (short)28114945;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)162332672;
				short num2 = num;
				num = (short)481434174;
				short num3 = num;
				num = (short)165222974;
				switch (num3 == num)
				{
				}
				num = (short)1589837825;
				if (num != 0)
				{
				}
				num = (short)2038956032;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700402B RID: 16427
		// (get) Token: 0x06007D66 RID: 32102 RVA: 0x0073BDA0 File Offset: 0x00739FA0
		public bool HasDiffs
		{
			get
			{
				short num = (short)892928000;
				short num2 = num;
				num = (short)1710602614;
				short num3 = num;
				num = (short)203143542;
				switch (num3 == num)
				{
				}
				num = (short)996737024;
				if (num != 0)
				{
				}
				num = (short)402063361;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007D67 RID: 32103 RVA: 0x0073BE50 File Offset: 0x0073A050
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)837681152;
			short num2 = num;
			num = (short)1802665651;
			short num3 = num;
			num = (short)941522611;
			switch (num3 == num)
			{
			}
			num = (short)1000603648;
			if (num != 0)
			{
			}
			num = (short)98304001;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner(this);
		}

		// Token: 0x06007D68 RID: 32104 RVA: 0x0073BF00 File Offset: 0x0073A100
		internal void SetValues()
		{
			short num = (short)579272704;
			short num2 = num;
			num = (short)848232449;
			if (num != 0)
			{
			}
			num = (short)1158155982;
			short num3 = num;
			num = (short)574099150;
			switch (num3 == num)
			{
			}
			num = (short)506986496;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DEKBUTTON;
			base.DataTransferOrder = 14;
		}

		// Token: 0x06007D69 RID: 32105 RVA: 0x0073BFCC File Offset: 0x0073A1CC
		// Note: this type is marked as 'beforefieldinit'.
		static DEKButtonInnerRecset()
		{
			short num = (short)1821507584;
			short num2 = num;
			num = (short)439973761;
			short num3 = num;
			num = (short)492205953;
			switch (num3 == num)
			{
			}
			num = (short)1957298177;
			if (num != 0)
			{
			}
			num = (short)788398080;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset._Min = 1;
		}

		// Token: 0x04003983 RID: 14723
		public static int _MaxPool;

		// Token: 0x04003984 RID: 14724
		public static int _Max;

		// Token: 0x04003985 RID: 14725
		public int _DynMax;

		// Token: 0x04003986 RID: 14726
		public static int _Min;

		// Token: 0x04003987 RID: 14727
		public static int _DefaultRecordCount;
	}
}
