using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001DB RID: 475
	[global::System.Serializable]
	public class DBUpgradeVersionInfo
	{
		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00102100 File Offset: 0x00100300
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x001021B0 File Offset: 0x001003B0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.BLVersion CurrentDataModelVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1812810403;
				short num2 = num;
				num = (short)816466595;
				switch (num2 == num)
				{
				}
				num = (short)1465319425;
				if (num != 0)
				{
				}
				num = (short)471269376;
				if (num != 0)
				{
				}
				num = (short)206372864;
				short num3 = num;
				return this.<CurrentDataModelVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1711981721;
				short num2 = num;
				num = (short)154584217;
				switch (num2 == num)
				{
				}
				num = (short)542441473;
				if (num != 0)
				{
				}
				num = (short)1250033664;
				if (num != 0)
				{
				}
				num = (short)1893531648;
				short num3 = num;
				this.<CurrentDataModelVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00102260 File Offset: 0x00100460
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x00102310 File Offset: 0x00100510
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2060597126;
				short num2 = num;
				num = (short)1883780998;
				switch (num2 == num)
				{
				}
				num = (short)183566336;
				if (num != 0)
				{
				}
				num = (short)30081025;
				if (num != 0)
				{
				}
				num = (short)50724864;
				short num3 = num;
				return this.<pac>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2050883585;
				if (num != 0)
				{
				}
				num = (short)1087745402;
				short num2 = num;
				num = (short)452439418;
				switch (num2 == num)
				{
				}
				num = (short)1776680960;
				if (num != 0)
				{
				}
				num = (short)977469440;
				short num3 = num;
				this.<pac>k__BackingField = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x001023C0 File Offset: 0x001005C0
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00102470 File Offset: 0x00100670
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.DBUpgradeStatus CurrentStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)641625979;
				short num2 = num;
				num = (short)148664187;
				switch (num2 == num)
				{
				}
				num = (short)719454209;
				if (num != 0)
				{
				}
				num = (short)421789696;
				if (num != 0)
				{
				}
				num = (short)232783872;
				short num3 = num;
				return this.<CurrentStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1107886081;
				if (num != 0)
				{
				}
				num = (short)1628136739;
				short num2 = num;
				num = (short)119498019;
				switch (num2 == num)
				{
				}
				num = (short)2097283072;
				if (num != 0)
				{
				}
				num = (short)1704001536;
				short num3 = num;
				this.<CurrentStatus>k__BackingField = value;
			}
		}
	}
}
