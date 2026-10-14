using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000176 RID: 374
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	public class ReferenceMap
	{
		// Token: 0x06001458 RID: 5208 RVA: 0x000D82A8 File Offset: 0x000D64A8
		public ReferenceMap()
		{
			this.ReferingRecordList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>();
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x000D82C8 File Offset: 0x000D64C8
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x000D837C File Offset: 0x000D657C
		[global::System.Runtime.Serialization.DataMember]
		public string ReferedUUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1131100755;
				short num2 = num;
				num = (short)657537619;
				switch (num2 == num)
				{
				}
				num = (short)2070544384;
				short num3 = num;
				num = (short)57999360;
				if (num != 0)
				{
				}
				num = (short)714735617;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1702494209;
				if (num != 0)
				{
				}
				num = (short)1212744170;
				short num2 = num;
				num = (short)1065681386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597440000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1181483008;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x000D8430 File Offset: 0x000D6630
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x000D84E0 File Offset: 0x000D66E0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ReferingRecordList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)439877633;
				if (num != 0)
				{
				}
				num = (short)738764071;
				short num2 = num;
				num = (short)939828519;
				switch (num2 == num)
				{
				}
				num = (short)1654652928;
				short num3 = num;
				num = (short)1315700736;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)183534457;
				short num2 = num;
				num = (short)547521401;
				switch (num2 == num)
				{
				}
				num = (short)1753284608;
				if (num != 0)
				{
				}
				num = (short)1742012416;
				short num3 = num;
				num = (short)65208321;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x04000986 RID: 2438
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000987 RID: 2439
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> b;
	}
}
