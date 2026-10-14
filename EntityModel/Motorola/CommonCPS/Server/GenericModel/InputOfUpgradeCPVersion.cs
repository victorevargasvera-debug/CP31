using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.Server.GenericModel
{
	// Token: 0x02000009 RID: 9
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class InputOfUpgradeCPVersion
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000039DC File Offset: 0x00001BDC
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00003A8C File Offset: 0x00001C8C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Radio, global::Motorola.CommonCPS.Server.EntityModel.Codeplug> EMRadio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1521898442;
				short num2 = num;
				num = (short)1435718602;
				switch (num2 == num)
				{
				}
				num = (short)4653057;
				if (num != 0)
				{
				}
				num = (short)350945280;
				short num3 = num;
				num = (short)1953955840;
				if (num != 0)
				{
				}
				return this.<EMRadio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)778862794;
				short num2 = num;
				num = (short)1591115978;
				switch (num2 == num)
				{
				}
				num = (short)885391361;
				if (num != 0)
				{
				}
				num = (short)1731461120;
				short num3 = num;
				num = (short)1209597952;
				if (num != 0)
				{
				}
				this.<EMRadio>k__BackingField = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003B3C File Offset: 0x00001D3C
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00003BEC File Offset: 0x00001DEC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Configuration EMConfiguration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)766671107;
				short num2 = num;
				num = (short)645167363;
				switch (num2 == num)
				{
				}
				num = (short)1680015361;
				if (num != 0)
				{
				}
				num = (short)1975386112;
				short num3 = num;
				num = (short)391315456;
				if (num != 0)
				{
				}
				return this.<EMConfiguration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)612778614;
				short num2 = num;
				num = (short)78987894;
				switch (num2 == num)
				{
				}
				num = (short)1467613185;
				if (num != 0)
				{
				}
				num = (short)195821568;
				short num3 = num;
				num = (short)1650917376;
				if (num != 0)
				{
				}
				this.<EMConfiguration>k__BackingField = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003C9C File Offset: 0x00001E9C
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00003D48 File Offset: 0x00001F48
		[global::System.Runtime.Serialization.DataMember]
		public string NewCPVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1430913025;
				if (num != 0)
				{
				}
				num = (short)1823422233;
				short num2 = num;
				num = (short)1885550361;
				switch (num2 == num)
				{
				}
				num = (short)1703280640;
				short num3 = num;
				num = (short)461701120;
				if (num != 0)
				{
				}
				return this.<NewCPVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)526262644;
				short num2 = num;
				num = (short)324870516;
				switch (num2 == num)
				{
				}
				num = (short)446431233;
				if (num != 0)
				{
				}
				num = (short)830144512;
				short num3 = num;
				num = (short)1218248704;
				if (num != 0)
				{
				}
				this.<NewCPVersion>k__BackingField = value;
			}
		}
	}
}
