using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001CE RID: 462
	[global::System.Serializable]
	public class ConventionalShepherdListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600534C RID: 21324 RVA: 0x004B976C File Offset: 0x004B796C
		public ConventionalShepherdListInnerRecset() : base(global::CommonResources.AcgResources.ID_CONVENTIONALSHEPHERDLIST, global::CommonResources.AcgResources.ID_CNVSHEPH)
		{
			this.SetValues();
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x004B9790 File Offset: 0x004B7990
		public ConventionalShepherdListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x004B97BC File Offset: 0x004B79BC
		public override int MaxPool
		{
			get
			{
				short num = (short)98825725;
				short num2 = num;
				num = (short)2011821565;
				switch (num2 == num)
				{
				}
				num = (short)1357578241;
				if (num != 0)
				{
				}
				num = (short)1521352704;
				if (num != 0)
				{
				}
				num = (short)1305608192;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x0600534F RID: 21327 RVA: 0x004B986C File Offset: 0x004B7A6C
		// (set) Token: 0x06005350 RID: 21328 RVA: 0x004B992C File Offset: 0x004B7B2C
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)1696719264;
					short num2 = num;
					num = (short)768795040;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1885929473;
						if (num != 0)
						{
						}
						num = (short)831717376;
						if (num != 0)
						{
						}
						num = (short)1385037824;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)697325180;
				short num2 = num;
				num = (short)1910724220;
				switch (num2 == num)
				{
				}
				num = (short)1899692032;
				if (num != 0)
				{
				}
				num = (short)113442817;
				if (num != 0)
				{
				}
				num = (short)1558773760;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x06005351 RID: 21329 RVA: 0x004B99DC File Offset: 0x004B7BDC
		public override int Min
		{
			get
			{
				short num = (short)1306808784;
				short num2 = num;
				num = (short)425284048;
				switch (num2 == num)
				{
				}
				num = (short)1570832384;
				if (num != 0)
				{
				}
				num = (short)1313079297;
				if (num != 0)
				{
				}
				num = (short)335413248;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset._Min;
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x004B9A8C File Offset: 0x004B7C8C
		// (set) Token: 0x06005353 RID: 21331 RVA: 0x004B9B38 File Offset: 0x004B7D38
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)518381918;
				short num2 = num;
				num = (short)279699806;
				switch (num2 == num)
				{
				}
				num = (short)1740046337;
				if (num != 0)
				{
				}
				num = (short)1750728704;
				if (num != 0)
				{
				}
				num = (short)1643708416;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)220346616;
				short num2 = num;
				num = (short)1208236280;
				switch (num2 == num)
				{
				}
				num = (short)983236609;
				if (num != 0)
				{
				}
				num = (short)628817920;
				if (num != 0)
				{
				}
				num = (short)1020264448;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x004B9BE8 File Offset: 0x004B7DE8
		public bool HasDiffs
		{
			get
			{
				short num = (short)2023372897;
				short num2 = num;
				num = (short)737949793;
				switch (num2 == num)
				{
				}
				num = (short)2008875008;
				if (num != 0)
				{
				}
				num = (short)626393089;
				if (num != 0)
				{
				}
				num = (short)2018050048;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x004B9C98 File Offset: 0x004B7E98
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)564937347;
			short num2 = num;
			num = (short)207897219;
			switch (num2 == num)
			{
			}
			num = (short)651821057;
			if (num != 0)
			{
			}
			num = (short)1328545792;
			if (num != 0)
			{
			}
			num = (short)1234501632;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInner(this);
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x004B9D44 File Offset: 0x004B7F44
		internal void SetValues()
		{
			short num = (short)111859045;
			short num2 = num;
			num = (short)1067832677;
			switch (num2 == num)
			{
			}
			num = (short)383975424;
			if (num != 0)
			{
			}
			num = (short)133562369;
			if (num != 0)
			{
			}
			num = (short)1424949248;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSHEPHERDLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_CNVSHEPH;
			base.DataTransferOrder = 22;
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x004B9E18 File Offset: 0x004B8018
		// Note: this type is marked as 'beforefieldinit'.
		static ConventionalShepherdListInnerRecset()
		{
			short num = (short)897023890;
			short num2 = num;
			num = (short)1470726034;
			switch (num2 == num)
			{
			}
			num = (short)705036289;
			if (num != 0)
			{
			}
			num = (short)915603456;
			if (num != 0)
			{
			}
			num = (short)1476329472;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset._Min = 1;
		}

		// Token: 0x04001FAF RID: 8111
		public static int _MaxPool;

		// Token: 0x04001FB0 RID: 8112
		public static int _Max;

		// Token: 0x04001FB1 RID: 8113
		public int _DynMax;

		// Token: 0x04001FB2 RID: 8114
		public static int _Min;

		// Token: 0x04001FB3 RID: 8115
		public static int _DefaultRecordCount;
	}
}
