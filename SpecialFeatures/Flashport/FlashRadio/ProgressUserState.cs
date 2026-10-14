using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000E4 RID: 228
	public class ProgressUserState
	{
		// Token: 0x06000D6B RID: 3435 RVA: 0x000030BF File Offset: 0x000012BF
		public ProgressUserState(global::SpecialFeatures.Flashport.FlashRadio.UserState currUS, global::SpecialFeatures.Flashport.FlashRadio.UserState newUS, string msg)
		{
			this.b = currUS;
			this.c = newUS;
			this.a = msg;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0011B1DC File Offset: 0x001193DC
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x0011B28C File Offset: 0x0011948C
		internal string UserText
		{
			get
			{
				short num = (short)1849520291;
				short num2 = num;
				num = (short)1358655651;
				switch (num2 == num)
				{
				}
				num = (short)1562378240;
				if (num != 0)
				{
				}
				num = (short)1920729088;
				short num3 = num;
				num = (short)462290945;
				if (num != 0)
				{
				}
				return this.a;
			}
			private set
			{
				short num = (short)1420688138;
				short num2 = num;
				num = (short)839383818;
				switch (num2 == num)
				{
				}
				num = (short)892665857;
				if (num != 0)
				{
				}
				num = (short)872022016;
				short num3 = num;
				num = (short)1453719552;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0011B340 File Offset: 0x00119540
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x0011B3F0 File Offset: 0x001195F0
		internal global::SpecialFeatures.Flashport.FlashRadio.UserState CurrentUserState
		{
			get
			{
				short num = (short)1156775283;
				short num2 = num;
				num = (short)1820130675;
				switch (num2 == num)
				{
				}
				num = (short)1490550785;
				if (num != 0)
				{
				}
				num = (short)2036989952;
				short num3 = num;
				num = (short)2144993280;
				if (num != 0)
				{
				}
				return this.b;
			}
			private set
			{
				short num = (short)1502294129;
				short num2 = num;
				num = (short)548876401;
				switch (num2 == num)
				{
				}
				num = (short)1787887617;
				if (num != 0)
				{
				}
				num = (short)567214080;
				short num3 = num;
				num = (short)1873084416;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0011B4A0 File Offset: 0x001196A0
		// (set) Token: 0x06000D71 RID: 3441 RVA: 0x0011B54C File Offset: 0x0011974C
		internal global::SpecialFeatures.Flashport.FlashRadio.UserState NewUserState
		{
			get
			{
				short num = (short)300206933;
				short num2 = num;
				num = (short)2076166997;
				switch (num2 == num)
				{
				}
				num = (short)1832845312;
				if (num != 0)
				{
				}
				num = (short)1360855040;
				short num3 = num;
				num = (short)200474625;
				if (num != 0)
				{
				}
				return this.c;
			}
			private set
			{
				short num = (short)1743648146;
				short num2 = num;
				num = (short)1337259410;
				switch (num2 == num)
				{
				}
				num = (short)898105345;
				if (num != 0)
				{
				}
				num = (short)12976128;
				short num3 = num;
				num = (short)1897463808;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x040006F9 RID: 1785
		private string a;

		// Token: 0x040006FA RID: 1786
		private global::SpecialFeatures.Flashport.FlashRadio.UserState b;

		// Token: 0x040006FB RID: 1787
		private global::SpecialFeatures.Flashport.FlashRadio.UserState c;
	}
}
