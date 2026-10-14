using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000098 RID: 152
	[global::System.ComponentModel.DataAnnotations.Schema.Table("SerialNumber")]
	public class SerialNumber
	{
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0007EFA4 File Offset: 0x0007D1A4
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x0007F054 File Offset: 0x0007D254
		[global::System.ComponentModel.DataAnnotations.Key]
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1714421761;
				if (num != 0)
				{
				}
				num = (short)1958050814;
				short num2 = num;
				num = (short)1055620094;
				switch (num2 == num)
				{
				}
				num = (short)571670528;
				short num3 = num;
				num = (short)1587216384;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1934447642;
				short num2 = num;
				num = (short)565924890;
				switch (num2 == num)
				{
				}
				num = (short)1464467457;
				if (num != 0)
				{
				}
				num = (short)809762816;
				short num3 = num;
				num = (short)372178944;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0007F108 File Offset: 0x0007D308
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x0007F1BC File Offset: 0x0007D3BC
		[global::System.ComponentModel.DataAnnotations.MaxLength(100)]
		public string SerialName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)985696680;
				short num2 = num;
				num = (short)1482852776;
				switch (num2 == num)
				{
				}
				num = (short)662700033;
				if (num != 0)
				{
				}
				num = (short)1410727936;
				short num3 = num;
				num = (short)182386688;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)454427345;
				short num2 = num;
				num = (short)180290257;
				switch (num2 == num)
				{
				}
				num = (short)886243329;
				if (num != 0)
				{
				}
				num = (short)765263872;
				short num3 = num;
				num = (short)2138570752;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0007F26C File Offset: 0x0007D46C
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0007F31C File Offset: 0x0007D51C
		public long Counter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)578056647;
				short num2 = num;
				num = (short)858878407;
				switch (num2 == num)
				{
				}
				num = (short)1592197121;
				if (num != 0)
				{
				}
				num = (short)1689911296;
				short num3 = num;
				num = (short)408420352;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)380853652;
				short num2 = num;
				num = (short)738745748;
				switch (num2 == num)
				{
				}
				num = (short)1610219520;
				if (num != 0)
				{
				}
				num = (short)1200095232;
				short num3 = num;
				num = (short)1040646145;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x0400059F RID: 1439
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Guid a;

		// Token: 0x040005A0 RID: 1440
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040005A1 RID: 1441
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private long c;
	}
}
