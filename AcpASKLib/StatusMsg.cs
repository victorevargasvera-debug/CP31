using System;
using System.Runtime.CompilerServices;

namespace AcpASKLib
{
	// Token: 0x02000036 RID: 54
	public class StatusMsg
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00028EBC File Offset: 0x000270BC
		public StatusMsg(global::AcpASKLib.AskStatusType type, string message, uint retCode)
		{
			this.Type = type;
			this.Message = message;
			this.RetCode = retCode;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00028EE4 File Offset: 0x000270E4
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00028F90 File Offset: 0x00027190
		public uint RetCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1506378;
				short num2 = num;
				num = (short)1729363018;
				switch (num2 == num)
				{
				}
				num = (short)1212547072;
				short num3 = num;
				num = (short)318177281;
				if (num != 0)
				{
				}
				num = (short)1775894528;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)331498387;
				short num2 = num;
				num = (short)1547060115;
				switch (num2 == num)
				{
				}
				num = (short)2104623104;
				short num3 = num;
				num = (short)1144258561;
				if (num != 0)
				{
				}
				num = (short)1224933376;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00029040 File Offset: 0x00027240
		// (set) Token: 0x06000177 RID: 375 RVA: 0x000290EC File Offset: 0x000272EC
		public global::AcpASKLib.AskStatusType Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)291702032;
				short num2 = num;
				num = (short)606668048;
				switch (num2 == num)
				{
				}
				num = (short)1684799488;
				short num3 = num;
				num = (short)1766391808;
				if (num != 0)
				{
				}
				num = (short)1597964289;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1077139144;
				short num2 = num;
				num = (short)1263261384;
				switch (num2 == num)
				{
				}
				num = (short)920518656;
				short num3 = num;
				num = (short)902889473;
				if (num != 0)
				{
				}
				num = (short)1314390016;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000178 RID: 376 RVA: 0x000291A0 File Offset: 0x000273A0
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00029250 File Offset: 0x00027450
		public string Message
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1659220575;
				short num2 = num;
				num = (short)1912844895;
				switch (num2 == num)
				{
				}
				num = (short)1061879808;
				short num3 = num;
				num = (short)366018561;
				if (num != 0)
				{
				}
				num = (short)174915584;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1725665138;
				short num2 = num;
				num = (short)591564658;
				switch (num2 == num)
				{
				}
				num = (short)2138505216;
				short num3 = num;
				num = (short)410255361;
				if (num != 0)
				{
				}
				num = (short)1230372864;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x040001BB RID: 443
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint a;

		// Token: 0x040001BC RID: 444
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpASKLib.AskStatusType b;

		// Token: 0x040001BD RID: 445
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;
	}
}
