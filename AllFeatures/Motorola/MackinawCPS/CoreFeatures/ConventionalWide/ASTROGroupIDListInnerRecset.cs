using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000542 RID: 1346
	[global::System.Serializable]
	public class ASTROGroupIDListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B4B6 RID: 46262 RVA: 0x00A76838 File Offset: 0x00A74A38
		public ASTROGroupIDListInnerRecset() : base(global::CommonResources.AcgResources.ID_ASTROGROUPIDLIST)
		{
			this.SetValues();
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x00A76858 File Offset: 0x00A74A58
		public ASTROGroupIDListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005AA3 RID: 23203
		// (get) Token: 0x0600B4B8 RID: 46264 RVA: 0x00A76884 File Offset: 0x00A74A84
		public override int MaxPool
		{
			get
			{
				short num = (short)1807939435;
				short num2 = num;
				num = (short)1212217195;
				switch (num2 == num)
				{
				}
				num = (short)189792257;
				if (num != 0)
				{
				}
				num = (short)1802698752;
				short num3 = num;
				num = (short)811728896;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005AA4 RID: 23204
		// (get) Token: 0x0600B4B9 RID: 46265 RVA: 0x00A76930 File Offset: 0x00A74B30
		// (set) Token: 0x0600B4BA RID: 46266 RVA: 0x00A769F4 File Offset: 0x00A74BF4
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)81264641;
					if (num != 0)
					{
					}
					num = (short)1969547037;
					short num2 = num;
					num = (short)71952157;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)979632128;
						if (num != 0)
						{
						}
						num = (short)339345408;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)833089;
				short num2 = num;
				num = (short)185382465;
				switch (num2 == num)
				{
				}
				num = (short)1323761665;
				if (num != 0)
				{
				}
				num = (short)1576009728;
				short num3 = num;
				num = (short)976027648;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005AA5 RID: 23205
		// (get) Token: 0x0600B4BB RID: 46267 RVA: 0x00A76AA8 File Offset: 0x00A74CA8
		public override int Min
		{
			get
			{
				short num = (short)779613100;
				short num2 = num;
				num = (short)2101932972;
				switch (num2 == num)
				{
				}
				num = (short)454492161;
				if (num != 0)
				{
				}
				num = (short)383582208;
				short num3 = num;
				num = (short)2001862656;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset._Min;
			}
		}

		// Token: 0x17005AA6 RID: 23206
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x00A76B58 File Offset: 0x00A74D58
		// (set) Token: 0x0600B4BD RID: 46269 RVA: 0x00A76C08 File Offset: 0x00A74E08
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1985253593;
				short num2 = num;
				num = (short)1649053913;
				switch (num2 == num)
				{
				}
				num = (short)311754753;
				if (num != 0)
				{
				}
				num = (short)376569856;
				short num3 = num;
				num = (short)556531712;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1383715965;
				short num2 = num;
				num = (short)1733416061;
				switch (num2 == num)
				{
				}
				num = (short)656736257;
				if (num != 0)
				{
				}
				num = (short)1120206848;
				short num3 = num;
				num = (short)1873412096;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17005AA7 RID: 23207
		// (get) Token: 0x0600B4BE RID: 46270 RVA: 0x00A76CBC File Offset: 0x00A74EBC
		public bool HasDiffs
		{
			get
			{
				short num = (short)920933012;
				short num2 = num;
				num = (short)852644500;
				switch (num2 == num)
				{
				}
				num = (short)336003072;
				if (num != 0)
				{
				}
				num = (short)1353973760;
				short num3 = num;
				num = (short)480903169;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x00A76D68 File Offset: 0x00A74F68
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)381587410;
			short num2 = num;
			num = (short)918458322;
			switch (num2 == num)
			{
			}
			num = (short)1495400448;
			if (num != 0)
			{
			}
			num = (short)141033472;
			short num3 = num;
			num = (short)493027329;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInner(this);
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x00A76E14 File Offset: 0x00A75014
		internal void SetValues()
		{
			short num = (short)1055326791;
			short num2 = num;
			num = (short)2075329095;
			switch (num2 == num)
			{
			}
			num = (short)1311375361;
			if (num != 0)
			{
			}
			num = (short)1567621120;
			short num3 = num;
			num = (short)10027008;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_ASTROGROUPIDLIST;
			base.DataTransferOrder = 9;
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x00A76EE0 File Offset: 0x00A750E0
		// Note: this type is marked as 'beforefieldinit'.
		static ASTROGroupIDListInnerRecset()
		{
			short num = (short)1922302801;
			short num2 = num;
			num = (short)606208849;
			switch (num2 == num)
			{
			}
			num = (short)1929707521;
			if (num != 0)
			{
			}
			num = (short)1068302336;
			short num3 = num;
			num = (short)175964160;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerRecset._Min = 1;
		}

		// Token: 0x040057B5 RID: 22453
		public static int _MaxPool;

		// Token: 0x040057B6 RID: 22454
		public static int _Max;

		// Token: 0x040057B7 RID: 22455
		public int _DynMax;

		// Token: 0x040057B8 RID: 22456
		public static int _Min;

		// Token: 0x040057B9 RID: 22457
		public static int _DefaultRecordCount;
	}
}
