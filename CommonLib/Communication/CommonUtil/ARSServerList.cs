using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200001E RID: 30
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ARSServerList
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00015F8C File Offset: 0x0001418C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00016038 File Offset: 0x00014238
		[global::System.Runtime.Serialization.DataMember]
		public string ServerName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1145768865;
				short num2 = num;
				num = (short)1053494177;
				switch (num2 == num)
				{
				}
				num = (short)1840185345;
				if (num != 0)
				{
				}
				num = (short)393871360;
				if (num != 0)
				{
				}
				num = (short)683671552;
				short num3 = num;
				return this.<ServerName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)243697798;
				short num2 = num;
				num = (short)249727110;
				switch (num2 == num)
				{
				}
				num = (short)50462721;
				if (num != 0)
				{
				}
				num = (short)1558970368;
				if (num != 0)
				{
				}
				num = (short)1402732544;
				short num3 = num;
				this.<ServerName>k__BackingField = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000160E8 File Offset: 0x000142E8
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00016198 File Offset: 0x00014398
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RecordType ServerType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1546327003;
				short num2 = num;
				num = (short)1645679579;
				switch (num2 == num)
				{
				}
				num = (short)1915027456;
				if (num != 0)
				{
				}
				num = (short)1820917761;
				if (num != 0)
				{
				}
				num = (short)285540352;
				short num3 = num;
				return this.<ServerType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1689529222;
				short num2 = num;
				num = (short)337521542;
				switch (num2 == num)
				{
				}
				num = (short)1294532609;
				if (num != 0)
				{
				}
				num = (short)221642752;
				if (num != 0)
				{
				}
				num = (short)1082261504;
				short num3 = num;
				this.<ServerType>k__BackingField = value;
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00016248 File Offset: 0x00014448
		public ARSServerList(string serverName, global::Motorola.Common.Communication.CommonUtil.RecordType serverType)
		{
			this.ServerName = serverName;
			this.ServerType = serverType;
		}
	}
}
