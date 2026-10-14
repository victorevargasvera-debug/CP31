using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	public class RecordTXT : global::Motorola.Common.Communication.ResourceRecord
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000059D4 File Offset: 0x00003BD4
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00005A80 File Offset: 0x00003C80
		public global::System.Collections.Generic.Dictionary<string, string> Txts
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)437303312;
				short num2 = num;
				num = (short)1056356368;
				switch (num2 == num)
				{
				}
				num = (short)2052980736;
				short num3 = num;
				num = (short)582090753;
				if (num != 0)
				{
				}
				num = (short)1498284032;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1967569709;
				short num2 = num;
				num = (short)601471789;
				switch (num2 == num)
				{
				}
				num = (short)770048000;
				short num3 = num;
				num = (short)222429184;
				if (num != 0)
				{
				}
				num = (short)183107585;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00005B30 File Offset: 0x00003D30
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00005BE0 File Offset: 0x00003DE0
		public byte TxtLength
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1507522162;
				short num2 = num;
				num = (short)421066354;
				switch (num2 == num)
				{
				}
				num = (short)821493760;
				short num3 = num;
				num = (short)2101149697;
				if (num != 0)
				{
				}
				num = (short)1209073664;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1713236053;
				short num2 = num;
				num = (short)172419157;
				switch (num2 == num)
				{
				}
				num = (short)1929641984;
				short num3 = num;
				num = (short)253231104;
				if (num != 0)
				{
				}
				num = (short)206569473;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005C94 File Offset: 0x00003E94
		public RecordTXT()
		{
			this.Txts = new global::System.Collections.Generic.Dictionary<string, string>();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005CB4 File Offset: 0x00003EB4
		public override void Serialize(global::System.IO.Stream stream)
		{
			short num = (short)1056571393;
			if (num != 0)
			{
			}
			num = (short)80864822;
			short num2 = num;
			num = (short)572778038;
			switch (num2 == num)
			{
			default:
			{
				num = (short)376504320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1071972352;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<string, string> a;

		// Token: 0x0400002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte b;
	}
}
