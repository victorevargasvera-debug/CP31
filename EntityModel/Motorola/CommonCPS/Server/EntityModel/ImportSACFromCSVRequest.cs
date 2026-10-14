using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200011A RID: 282
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportSACFromCSVRequest
	{
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x000B02C8 File Offset: 0x000AE4C8
		// (set) Token: 0x06001075 RID: 4213 RVA: 0x000B0378 File Offset: 0x000AE578
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? SystemUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)959774720;
				short num2 = num;
				num = (short)1950005610;
				short num3 = num;
				num = (short)1397471594;
				switch (num3 == num)
				{
				}
				num = (short)391249921;
				if (num != 0)
				{
				}
				num = (short)1171652608;
				if (num != 0)
				{
				}
				return this.<SystemUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1209139200;
				short num2 = num;
				num = (short)243990529;
				if (num != 0)
				{
				}
				num = (short)903008838;
				short num3 = num;
				num = (short)1363923526;
				switch (num3 == num)
				{
				}
				num = (short)1947402240;
				if (num != 0)
				{
				}
				this.<SystemUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x000B0428 File Offset: 0x000AE628
		// (set) Token: 0x06001077 RID: 4215 RVA: 0x000B04D8 File Offset: 0x000AE6D8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary RecordData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1207500800;
				short num2 = num;
				num = (short)60076919;
				short num3 = num;
				num = (short)619361143;
				switch (num3 == num)
				{
				}
				num = (short)35717120;
				if (num != 0)
				{
				}
				num = (short)1904476161;
				if (num != 0)
				{
				}
				return this.<RecordData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1771241472;
				short num2 = num;
				num = (short)2072626670;
				short num3 = num;
				num = (short)832882158;
				switch (num3 == num)
				{
				}
				num = (short)1383989249;
				if (num != 0)
				{
				}
				num = (short)311623680;
				if (num != 0)
				{
				}
				this.<RecordData>k__BackingField = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x000B0588 File Offset: 0x000AE788
		// (set) Token: 0x06001079 RID: 4217 RVA: 0x000B0638 File Offset: 0x000AE838
		[global::System.Runtime.Serialization.DataMember]
		public string WarningMsg
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)434307072;
				short num2 = num;
				num = (short)34996225;
				if (num != 0)
				{
				}
				num = (short)1532561412;
				short num3 = num;
				num = (short)1383008260;
				switch (num3 == num)
				{
				}
				num = (short)1433993216;
				if (num != 0)
				{
				}
				return this.<WarningMsg>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1994326016;
				short num2 = num;
				num = (short)921531384;
				short num3 = num;
				num = (short)1854305272;
				switch (num3 == num)
				{
				}
				num = (short)1227096064;
				if (num != 0)
				{
				}
				num = (short)950337537;
				if (num != 0)
				{
				}
				this.<WarningMsg>k__BackingField = value;
			}
		}

		// Token: 0x040007B6 RID: 1974
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> PropertiesToSet = new global::System.Collections.Generic.List<string>();
	}
}
