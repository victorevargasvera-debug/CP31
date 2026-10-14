using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200011B RID: 283
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportTGSAFromCSVRequest
	{
		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x000B0708 File Offset: 0x000AE908
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x000B07B8 File Offset: 0x000AE9B8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? SystemUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)427753472;
				short num2 = num;
				num = (short)151142112;
				short num3 = num;
				num = (short)750272224;
				switch (num3 == num)
				{
				}
				num = (short)1660485633;
				if (num != 0)
				{
				}
				num = (short)1484062720;
				if (num != 0)
				{
				}
				return this.<SystemUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1235419136;
				short num2 = num;
				num = (short)640782637;
				short num3 = num;
				num = (short)898666797;
				switch (num3 == num)
				{
				}
				num = (short)1970864128;
				if (num != 0)
				{
				}
				num = (short)106627073;
				if (num != 0)
				{
				}
				this.<SystemUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x000B0868 File Offset: 0x000AEA68
		// (set) Token: 0x0600107E RID: 4222 RVA: 0x000B0918 File Offset: 0x000AEB18
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.TGSARecord RecordData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)930938880;
				short num2 = num;
				num = (short)1743092054;
				short num3 = num;
				num = (short)58751318;
				switch (num3 == num)
				{
				}
				num = (short)1689321473;
				if (num != 0)
				{
				}
				num = (short)1811546112;
				if (num != 0)
				{
				}
				return this.<RecordData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1784545280;
				short num2 = num;
				num = (short)1299700152;
				short num3 = num;
				num = (short)397007288;
				switch (num3 == num)
				{
				}
				num = (short)533331969;
				if (num != 0)
				{
				}
				num = (short)1974730752;
				if (num != 0)
				{
				}
				this.<RecordData>k__BackingField = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x000B09C8 File Offset: 0x000AEBC8
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x000B0A78 File Offset: 0x000AEC78
		[global::System.Runtime.Serialization.DataMember]
		public string WarningMsg
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1058144256;
				short num2 = num;
				num = (short)17122105;
				short num3 = num;
				num = (short)2029667129;
				switch (num3 == num)
				{
				}
				num = (short)302710784;
				if (num != 0)
				{
				}
				num = (short)16318465;
				if (num != 0)
				{
				}
				return this.<WarningMsg>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)667680768;
				short num2 = num;
				num = (short)182644112;
				short num3 = num;
				num = (short)1551953296;
				switch (num3 == num)
				{
				}
				num = (short)731643904;
				if (num != 0)
				{
				}
				num = (short)100007937;
				if (num != 0)
				{
				}
				this.<WarningMsg>k__BackingField = value;
			}
		}

		// Token: 0x040007BA RID: 1978
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> PropertiesToSet = new global::System.Collections.Generic.List<string>();
	}
}
