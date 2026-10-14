using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000024 RID: 36
	internal class PerformanceDetails : global::System.Collections.Generic.Dictionary<string, string>
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0001263C File Offset: 0x0001083C
		// (set) Token: 0x06000123 RID: 291 RVA: 0x000126EC File Offset: 0x000108EC
		public global::System.TimeSpan CycleTime
		{
			get
			{
				short num = (short)1528537705;
				short num2 = num;
				num = (short)549888617;
				switch (num2 == num)
				{
				}
				num = (short)1215823873;
				if (num != 0)
				{
				}
				num = (short)1601437696;
				if (num != 0)
				{
				}
				num = (short)1145176064;
				short num3 = num;
				return this.a;
			}
			set
			{
				int a_ = 16;
				short num = (short)1474083970;
				short num2 = num;
				num = (short)1983429762;
				switch (num2 == num)
				{
				}
				num = (short)430243841;
				if (num != 0)
				{
				}
				num = (short)997785600;
				if (num != 0)
				{
				}
				num = (short)840105984;
				short num3 = num;
				this.a = value;
				base.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("❣ὥ୧٩५㩭᥯άᅳ", a_).LogFormat(), value.TotalMilliseconds.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000127D4 File Offset: 0x000109D4
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00012884 File Offset: 0x00010A84
		public string Duration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)942161213;
				short num2 = num;
				num = (short)1914322237;
				switch (num2 == num)
				{
				}
				num = (short)830668801;
				if (num != 0)
				{
				}
				num = (short)155254784;
				if (num != 0)
				{
				}
				num = (short)970719232;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)100480544;
				short num2 = num;
				num = (short)803681824;
				switch (num2 == num)
				{
				}
				num = (short)597819393;
				if (num != 0)
				{
				}
				num = (short)693174272;
				if (num != 0)
				{
				}
				num = (short)1817051136;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00012938 File Offset: 0x00010B38
		public byte CpuTotalUsagePercentage
		{
			set
			{
				int a_ = 4;
				short num = (short)2028372110;
				short num2 = num;
				num = (short)854556814;
				switch (num2 == num)
				{
				}
				num = (short)364445696;
				if (num != 0)
				{
				}
				num = (short)1592524801;
				if (num != 0)
				{
				}
				num = (short)1272971264;
				short num3 = num;
				base.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("᭗⩙⥛੝ཟᙡգ੥㵧ᥩ൫७ᕯ≱ᅳѵ᭷όቻ੽", a_).LogFormat(), value.ToString());
			}
		}

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00012A0C File Offset: 0x00010C0C
		public byte CpuKernelUsagePercentage
		{
			set
			{
				int a_ = 14;
				short num = (short)1980227823;
				short num2 = num;
				num = (short)1142612207;
				switch (num2 == num)
				{
				}
				num = (short)462946305;
				if (num != 0)
				{
				}
				num = (short)468385792;
				if (num != 0)
				{
				}
				num = (short)1299775488;
				short num3 = num;
				base.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("Ⅱᑣ፥⍧ཀྵṫmᕯṱⅳյ᥷ᵹ᥻⹽ﺉ", a_).LogFormat(), value.ToString());
			}
		}

		// Token: 0x17000041 RID: 65
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00012ADC File Offset: 0x00010CDC
		public byte CpuUserUsagePercentage
		{
			set
			{
				int a_ = 9;
				short num = (short)825360385;
				if (num != 0)
				{
				}
				num = (short)554863985;
				short num2 = num;
				num = (short)550669681;
				switch (num2 == num)
				{
				}
				num = (short)984285184;
				if (num != 0)
				{
				}
				num = (short)1514799104;
				short num3 = num;
				base.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("Ṝ⽞ᑠ㙢ᙤɦ᭨㹪Ṭ๮ᙰᙲ╴ቶ୸᡺᡼ᅾ", a_).LogFormat(), value.ToString());
			}
		}

		// Token: 0x17000042 RID: 66
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00012BB0 File Offset: 0x00010DB0
		public short MemoryDeltaMB
		{
			set
			{
				int a_ = 19;
				short num = (short)2097481583;
				short num2 = num;
				num = (short)1770522479;
				switch (num2 == num)
				{
				}
				num = (short)354549761;
				if (num != 0)
				{
				}
				num = (short)1187708928;
				if (num != 0)
				{
				}
				num = (short)1241710592;
				short num3 = num;
				base.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⩦౨٪ɬᵮࡰ㝲ၴ᭶൸᩺ぼ㵾", a_).LogFormat(), value.ToString(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⥦奨", a_), global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture));
			}
		}

		// Token: 0x17000043 RID: 67
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00012C94 File Offset: 0x00010E94
		public ushort MemoryPeakMB
		{
			set
			{
				int a_ = 6;
				short num = (short)1676806616;
				short num2 = num;
				num = (short)806554072;
				switch (num2 == num)
				{
				}
				num = (short)2818048;
				if (num != 0)
				{
				}
				num = (short)220266497;
				if (num != 0)
				{
				}
				num = (short)1628438528;
				short num3 = num;
				base.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("᝙㥛㍝ཟၡᵣ㙥൧୩ݫ⍭㉯", a_).LogFormat(), value.ToString(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("ᑙ汛", a_), global::Motorola.Common.LogUtility.PredefinedName.DefaultCulture));
			}
		}

		// Token: 0x040000AC RID: 172
		private global::System.TimeSpan a;

		// Token: 0x040000AD RID: 173
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;
	}
}
