using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x0200012F RID: 303
	[global::System.Serializable]
	public sealed class DVRSFileListInnerRecset : global::AcpBusinessLayer.Recordset, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000FE6 RID: 4070 RVA: 0x000034FB File Offset: 0x000016FB
		public DVRSFileListInnerRecset() : base(global::CommonResources.AcgResources.ID_DVRSFILELIST, true, false, null)
		{
			this.SetValues();
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00003511 File Offset: 0x00001711
		internal DVRSFileListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00164990 File Offset: 0x00162B90
		public new void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1731252278;
			short num2 = num;
			num = (short)98095158;
			switch (num2 == num)
			{
			}
			num = (short)1352138752;
			if (num != 0)
			{
			}
			num = (short)377356288;
			short num3 = num;
			num = (short)17104897;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00164A44 File Offset: 0x00162C44
		public override int MaxPool
		{
			get
			{
				short num = (short)452645996;
				short num2 = num;
				num = (short)1229902956;
				switch (num2 == num)
				{
				}
				num = (short)829423617;
				if (num != 0)
				{
				}
				num = (short)415105024;
				short num3 = num;
				num = (short)925499392;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00164AF4 File Offset: 0x00162CF4
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x00164BB4 File Offset: 0x00162DB4
		public override int Max
		{
			get
			{
				short num = (short)570884097;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					num = (short)125215536;
					short num2 = num;
					num = (short)59941680;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1014693888;
						short num3 = num;
						num = (short)1832189952;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
					}
				}
				return global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset._Max;
			}
			set
			{
				short num = (short)934739969;
				if (num != 0)
				{
				}
				num = (short)1966182057;
				short num2 = num;
				num = (short)2078838441;
				switch (num2 == num)
				{
				}
				num = (short)540737536;
				short num3 = num;
				num = (short)940441600;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00164C68 File Offset: 0x00162E68
		public override int Min
		{
			get
			{
				short num = (short)620179544;
				short num2 = num;
				num = (short)1187262552;
				switch (num2 == num)
				{
				}
				num = (short)531562497;
				if (num != 0)
				{
				}
				num = (short)351535104;
				short num3 = num;
				num = (short)454361088;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset._Min;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00164D18 File Offset: 0x00162F18
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x00164DC8 File Offset: 0x00162FC8
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1182052311;
				short num2 = num;
				num = (short)516009943;
				switch (num2 == num)
				{
				}
				num = (short)950337537;
				if (num != 0)
				{
				}
				num = (short)1194328064;
				short num3 = num;
				num = (short)160890880;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1440612004;
				short num2 = num;
				num = (short)1481506468;
				switch (num2 == num)
				{
				}
				num = (short)20709376;
				if (num != 0)
				{
				}
				num = (short)683212800;
				short num3 = num;
				num = (short)153550849;
				if (num != 0)
				{
				}
				global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00164E78 File Offset: 0x00163078
		public bool HasDiffs
		{
			get
			{
				short num = (short)795633736;
				short num2 = num;
				num = (short)1486776392;
				switch (num2 == num)
				{
				}
				num = (short)59047937;
				if (num != 0)
				{
				}
				num = (short)1626931200;
				short num3 = num;
				num = (short)1012400128;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00164F2C File Offset: 0x0016312C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)622429253;
			short num2 = num;
			num = (short)1034650693;
			switch (num2 == num)
			{
			}
			num = (short)1745092608;
			if (num != 0)
			{
			}
			num = (short)1064304640;
			short num3 = num;
			num = (short)558104577;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.DVRSFiles.List.DVRSFileListInner(this);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00164FDC File Offset: 0x001631DC
		internal void SetValues()
		{
			short num = (short)1588509868;
			short num2 = num;
			num = (short)669105324;
			switch (num2 == num)
			{
			}
			num = (short)1210187776;
			if (num != 0)
			{
			}
			num = (short)1400307712;
			short num3 = num;
			num = (short)1350959105;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DVRSFILELIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_DVRSFILE;
			base.DataTransferOrder = 405;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x001650B4 File Offset: 0x001632B4
		// Note: this type is marked as 'beforefieldinit'.
		static DVRSFileListInnerRecset()
		{
			short num = (short)1775531034;
			short num2 = num;
			num = (short)320631834;
			switch (num2 == num)
			{
			}
			num = (short)1180368897;
			if (num != 0)
			{
			}
			num = (short)1845231616;
			short num3 = num;
			num = (short)810221568;
			if (num != 0)
			{
			}
			global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset._Max = 5000;
			global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset._Min = 1;
		}

		// Token: 0x0400083B RID: 2107
		public static int _MaxPool;

		// Token: 0x0400083C RID: 2108
		public static int _Max;

		// Token: 0x0400083D RID: 2109
		internal int _DynMax;

		// Token: 0x0400083E RID: 2110
		public static int _Min;

		// Token: 0x0400083F RID: 2111
		public static int _DefaultRecordCount;
	}
}
