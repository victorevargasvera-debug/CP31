using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000090 RID: 144
	[global::System.Serializable]
	public class MigrateFDTPatrameters : global::System.ICloneable
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0003DE50 File Offset: 0x0003C050
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0003DF04 File Offset: 0x0003C104
		public string SrcCPVersion
		{
			get
			{
				short num = (short)1896782117;
				short num2 = num;
				num = (short)1099405605;
				switch (num2 == num)
				{
				}
				num = (short)1188429824;
				short num3 = num;
				num = (short)1732640769;
				if (num != 0)
				{
				}
				num = (short)1472462848;
				if (num != 0)
				{
				}
				return this._srcCPVer;
			}
			set
			{
				short num = (short)799307525;
				short num2 = num;
				num = (short)1949398789;
				switch (num2 == num)
				{
				}
				num = (short)304087040;
				short num3 = num;
				num = (short)2047803393;
				if (num != 0)
				{
				}
				num = (short)1756364800;
				if (num != 0)
				{
				}
				this._srcCPVer = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0003DFB0 File Offset: 0x0003C1B0
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0003E060 File Offset: 0x0003C260
		public string DstCPVersion
		{
			get
			{
				short num = (short)1212910344;
				short num2 = num;
				num = (short)533105416;
				switch (num2 == num)
				{
				}
				num = (short)617283584;
				short num3 = num;
				num = (short)576323585;
				if (num != 0)
				{
				}
				num = (short)755171328;
				if (num != 0)
				{
				}
				return this._dstCPVer;
			}
			set
			{
				short num = (short)1812736160;
				short num2 = num;
				num = (short)1108289696;
				switch (num2 == num)
				{
				}
				num = (short)781975552;
				short num3 = num;
				num = (short)805306369;
				if (num != 0)
				{
				}
				num = (short)983695360;
				if (num != 0)
				{
				}
				this._dstCPVer = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0003E110 File Offset: 0x0003C310
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0003E1C0 File Offset: 0x0003C3C0
		public ushort SrcModelType
		{
			get
			{
				short num = (short)843082098;
				short num2 = num;
				num = (short)1730832754;
				switch (num2 == num)
				{
				}
				num = (short)831324160;
				short num3 = num;
				num = (short)245301249;
				if (num != 0)
				{
				}
				num = (short)1094778880;
				if (num != 0)
				{
				}
				return this._srcModelType;
			}
			set
			{
				short num = (short)2041005393;
				short num2 = num;
				num = (short)435832145;
				switch (num2 == num)
				{
				}
				num = (short)816513024;
				short num3 = num;
				num = (short)368836609;
				if (num != 0)
				{
				}
				num = (short)847773696;
				if (num != 0)
				{
				}
				this._srcModelType = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0003E270 File Offset: 0x0003C470
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0003E320 File Offset: 0x0003C520
		public ushort DstModelType
		{
			get
			{
				short num = (short)524380138;
				short num2 = num;
				num = (short)841181162;
				switch (num2 == num)
				{
				}
				num = (short)479264768;
				short num3 = num;
				num = (short)1681588225;
				if (num != 0)
				{
				}
				num = (short)1962606592;
				if (num != 0)
				{
				}
				return this._dstModelType;
			}
			set
			{
				short num = (short)1403322907;
				short num2 = num;
				num = (short)293798427;
				switch (num2 == num)
				{
				}
				num = (short)1896218624;
				short num3 = num;
				num = (short)846069760;
				if (num != 0)
				{
				}
				num = (short)792526849;
				if (num != 0)
				{
				}
				this._dstModelType = value;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0003E3D4 File Offset: 0x0003C5D4
		public object Clone()
		{
			short num = (short)2106214479;
			short num2 = num;
			num = (short)1265059919;
			switch (num2 == num)
			{
			}
			num = (short)335937536;
			short num3 = num;
			num = (short)656539649;
			if (num != 0)
			{
			}
			num = (short)274595840;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.MigrateFDTPatrameters migrateFDTPatrameters = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.MigrateFDTPatrameters;
			migrateFDTPatrameters.SrcCPVersion = this.SrcCPVersion;
			migrateFDTPatrameters.DstCPVersion = this.DstCPVersion;
			migrateFDTPatrameters.SrcModelType = this.SrcModelType;
			migrateFDTPatrameters.DstModelType = this.DstModelType;
			return migrateFDTPatrameters;
		}

		// Token: 0x04000493 RID: 1171
		private string _srcCPVer = string.Empty;

		// Token: 0x04000494 RID: 1172
		private string _dstCPVer = string.Empty;

		// Token: 0x04000495 RID: 1173
		private ushort _srcModelType;

		// Token: 0x04000496 RID: 1174
		private ushort _dstModelType;
	}
}
