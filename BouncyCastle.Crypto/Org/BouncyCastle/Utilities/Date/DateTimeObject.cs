using System;

namespace Org.BouncyCastle.Utilities.Date
{
	// Token: 0x02000069 RID: 105
	public sealed class DateTimeObject
	{
		// Token: 0x0600043B RID: 1083 RVA: 0x00015B52 File Offset: 0x00013D52
		public DateTimeObject(global::System.DateTime dt)
		{
			this.dt = dt;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00015B61 File Offset: 0x00013D61
		public global::System.DateTime Value
		{
			get
			{
				return this.dt;
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00015B6C File Offset: 0x00013D6C
		public override string ToString()
		{
			return this.dt.ToString();
		}

		// Token: 0x0400029B RID: 667
		private readonly global::System.DateTime dt;
	}
}
