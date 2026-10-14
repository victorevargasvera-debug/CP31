using System;
using System.Collections.Generic;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x02000035 RID: 53
	internal class SystemState : global::System.Collections.Generic.Dictionary<string, string>
	{
		// Token: 0x17000076 RID: 118
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x000197C4 File Offset: 0x000179C4
		public byte? CpuAvailablePercentage
		{
			set
			{
				int a_ = 12;
				short num = (short)423493633;
				if (num != 0)
				{
				}
				num = (short)375196863;
				short num2 = num;
				num = (short)1601178815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)94306304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1855520768;
				if (num != 0)
				{
				}
				base.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⍟ቡᅣ❥ṧ୩իɭᅯၱᡳ፵⡷ό๻ᵽ", a_).LogFormat(), ((value != null) ? value.GetValueOrDefault().ToString() : null) ?? global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("⹟͡⩣", a_));
			}
		}

		// Token: 0x17000077 RID: 119
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000198C4 File Offset: 0x00017AC4
		public ushort MemoryAvailableMB
		{
			set
			{
				int a_ = 11;
				short num = (short)2023411209;
				short num2 = num;
				num = (short)531942921;
				switch (num2 == num)
				{
				}
				num = (short)502202368;
				short num3 = num;
				num = (short)823787521;
				if (num != 0)
				{
				}
				num = (short)1277886464;
				if (num != 0)
				{
				}
				base.Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("቞Ѡ๢੤ᕦၨ⩪᭬๮ᡰὲᑴᕶᕸṺぼ㵾", a_).LogFormat(), value.ToString());
			}
		}
	}
}
