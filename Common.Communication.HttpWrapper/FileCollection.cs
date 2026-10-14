using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000031 RID: 49
	[global::System.Runtime.Serialization.DataContract]
	public class FileCollection
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000BABC File Offset: 0x00009CBC
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000BB70 File Offset: 0x00009D70
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.UELog fileCollection
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1747373546;
				short num2 = num;
				num = (short)72142314;
				switch (num2 == num)
				{
				}
				num = (short)1841037313;
				if (num != 0)
				{
				}
				num = (short)198246400;
				if (num != 0)
				{
				}
				num = (short)1976762368;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1668878185;
				short num2 = num;
				num = (short)1601769321;
				switch (num2 == num)
				{
				}
				num = (short)1772945409;
				if (num != 0)
				{
				}
				num = (short)1111359488;
				if (num != 0)
				{
				}
				num = (short)1289682944;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000BC20 File Offset: 0x00009E20
		public FileCollection(global::Motorola.Common.Communication.UELog log)
		{
			this.fileCollection = log;
		}

		// Token: 0x04000078 RID: 120
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.UELog a;
	}
}
