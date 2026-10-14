using System;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x0200000A RID: 10
	public class ACPVoiceAnnouncementResult
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002754 File Offset: 0x00000954
		internal ACPVoiceAnnouncementResult(string A_0, global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002778 File Offset: 0x00000978
		internal string FileName
		{
			get
			{
				short num = (short)1653400782;
				short num2 = num;
				num = (short)1297474766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1004470272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400176641;
				if (num != 0)
				{
				}
				num = (short)1097728000;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002824 File Offset: 0x00000A24
		internal global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes Code
		{
			get
			{
				short num = (short)397433510;
				short num2 = num;
				num = (short)1663457958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)496107520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1602748417;
				if (num != 0)
				{
				}
				num = (short)1041039360;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x04000022 RID: 34
		private string a;

		// Token: 0x04000023 RID: 35
		private global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes b;
	}
}
