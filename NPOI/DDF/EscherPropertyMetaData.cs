using System;

namespace NPOI.DDF
{
	// Token: 0x02000543 RID: 1347
	public class EscherPropertyMetaData
	{
		// Token: 0x060032E4 RID: 13028 RVA: 0x0009F2C7 File Offset: 0x0009D4C7
		public EscherPropertyMetaData(string description)
		{
			this.description = description;
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x0009F2D6 File Offset: 0x0009D4D6
		public EscherPropertyMetaData(string description, byte type)
		{
			this.description = description;
			this.type = type;
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060032E6 RID: 13030 RVA: 0x0009F2EC File Offset: 0x0009D4EC
		public string Description
		{
			get
			{
				return this.description;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060032E7 RID: 13031 RVA: 0x0009F2F4 File Offset: 0x0009D4F4
		public byte Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x040017E6 RID: 6118
		public const byte TYPE_UNKNOWN = 0;

		// Token: 0x040017E7 RID: 6119
		public const byte TYPE_BOOL = 1;

		// Token: 0x040017E8 RID: 6120
		public const byte TYPE_RGB = 2;

		// Token: 0x040017E9 RID: 6121
		public const byte TYPE_SHAPEPATH = 3;

		// Token: 0x040017EA RID: 6122
		public const byte TYPE_SIMPLE = 4;

		// Token: 0x040017EB RID: 6123
		public const byte TYPE_ARRAY = 5;

		// Token: 0x040017EC RID: 6124
		private string description;

		// Token: 0x040017ED RID: 6125
		private byte type;
	}
}
