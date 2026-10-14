using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000013 RID: 19
	public class LoggingEventArgs : global::System.EventArgs
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x0000C2F4 File Offset: 0x0000A4F4
		public LoggingEventArgs()
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000C308 File Offset: 0x0000A508
		public LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel level, global::System.DateTime timeStamp, string message)
		{
			this.Level = level;
			this.TimeStamp = timeStamp;
			this.Message = message;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000C330 File Offset: 0x0000A530
		public LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel level, global::System.DateTime timeStamp, string message, global::System.Exception e)
		{
			this.Level = level;
			this.TimeStamp = timeStamp;
			this.Message = message;
			this.Exception = e;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000C360 File Offset: 0x0000A560
		public LoggingEventArgs(global::Motorola.Common.LogUtility.LoggingLevel level, global::System.DateTime timeStamp, string message, global::System.Diagnostics.StackFrame stackFrame, string stampName)
		{
			this.Level = level;
			this.TimeStamp = timeStamp;
			this.Message = message;
			this.StackFrame = stackFrame;
			this.StampName = stampName;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000C398 File Offset: 0x0000A598
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000C444 File Offset: 0x0000A644
		public global::Motorola.Common.LogUtility.LoggingLevel Level
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1451884544;
				short num2 = num;
				num = (short)342491137;
				if (num != 0)
				{
				}
				num = (short)2066220591;
				short num3 = num;
				num = (short)1881409071;
				switch (num3 == num)
				{
				}
				num = (short)1763704832;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1137704960;
				short num2 = num;
				num = (short)1164897588;
				short num3 = num;
				num = (short)156495156;
				switch (num3 == num)
				{
				}
				num = (short)616693760;
				if (num != 0)
				{
				}
				num = (short)462553089;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		public global::System.DateTime TimeStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)696909824;
				short num2 = num;
				num = (short)1463025665;
				if (num != 0)
				{
				}
				num = (short)2097975201;
				short num3 = num;
				num = (short)1762430881;
				switch (num3 == num)
				{
				}
				num = (short)1558511616;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2070544384;
				short num2 = num;
				num = (short)1927532644;
				short num3 = num;
				num = (short)1083166820;
				switch (num3 == num)
				{
				}
				num = (short)1470693377;
				if (num != 0)
				{
				}
				num = (short)71172096;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000C658 File Offset: 0x0000A858
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000C708 File Offset: 0x0000A908
		public string Message
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1278541824;
				short num2 = num;
				num = (short)386144694;
				short num3 = num;
				num = (short)1353783734;
				switch (num3 == num)
				{
				}
				num = (short)2046296064;
				if (num != 0)
				{
				}
				num = (short)1004208129;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)610271232;
				short num2 = num;
				num = (short)2026789821;
				short num3 = num;
				num = (short)1453546429;
				switch (num3 == num)
				{
				}
				num = (short)1131479041;
				if (num != 0)
				{
				}
				num = (short)2008023040;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000C7B4 File Offset: 0x0000A9B4
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000C864 File Offset: 0x0000AA64
		public global::System.Exception Exception
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1599275008;
				short num2 = num;
				num = (short)2049418288;
				short num3 = num;
				num = (short)327787568;
				switch (num3 == num)
				{
				}
				num = (short)805175297;
				if (num != 0)
				{
				}
				num = (short)1312161792;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1866465280;
				short num2 = num;
				num = (short)564224595;
				short num3 = num;
				num = (short)1199792723;
				switch (num3 == num)
				{
				}
				num = (short)1452081153;
				if (num != 0)
				{
				}
				num = (short)390594560;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000C918 File Offset: 0x0000AB18
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		public global::System.Diagnostics.StackFrame StackFrame
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2018902016;
				short num2 = num;
				num = (short)855857770;
				short num3 = num;
				num = (short)895572586;
				switch (num3 == num)
				{
				}
				num = (short)1157300225;
				if (num != 0)
				{
				}
				num = (short)54263808;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2121859072;
				short num2 = num;
				num = (short)1582209744;
				short num3 = num;
				num = (short)1387567824;
				switch (num3 == num)
				{
				}
				num = (short)1536622592;
				if (num != 0)
				{
				}
				num = (short)1636761601;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000CA74 File Offset: 0x0000AC74
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000CB24 File Offset: 0x0000AD24
		public string StampName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1250426880;
				short num2 = num;
				num = (short)996323337;
				short num3 = num;
				num = (short)1799925769;
				switch (num3 == num)
				{
				}
				num = (short)397737984;
				if (num != 0)
				{
				}
				num = (short)711065601;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)814219264;
				short num2 = num;
				num = (short)894346303;
				short num3 = num;
				num = (short)2089460799;
				switch (num3 == num)
				{
				}
				num = (short)1244594176;
				if (num != 0)
				{
				}
				num = (short)840105985;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public string FileNameSuffix
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1206452224;
				short num2 = num;
				num = (short)1081278465;
				if (num != 0)
				{
				}
				num = (short)539838274;
				short num3 = num;
				num = (short)180373314;
				switch (num3 == num)
				{
				}
				num = (short)1144193024;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)564920320;
				short num2 = num;
				num = (short)303041511;
				short num3 = num;
				num = (short)423168999;
				switch (num3 == num)
				{
				}
				num = (short)1040187392;
				if (num != 0)
				{
				}
				num = (short)1704198145;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x04000054 RID: 84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.LogUtility.LoggingLevel a;

		// Token: 0x04000055 RID: 85
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.DateTime b;

		// Token: 0x04000056 RID: 86
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000057 RID: 87
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Exception d;

		// Token: 0x04000058 RID: 88
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Diagnostics.StackFrame e;

		// Token: 0x04000059 RID: 89
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x0400005A RID: 90
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string g;
	}
}
