using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000E5 RID: 229
	public class RadioInfoParams
	{
		// Token: 0x06000D72 RID: 3442 RVA: 0x000030DC File Offset: 0x000012DC
		internal RadioInfoParams(string model, string serial, string fcode)
		{
			this.a = model;
			this.b = serial;
			this.c = fcode;
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0011B600 File Offset: 0x00119800
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x0011B6B0 File Offset: 0x001198B0
		internal string ModelNumber
		{
			get
			{
				short num = (short)2147015849;
				short num2 = num;
				num = (short)52944041;
				switch (num2 == num)
				{
				}
				num = (short)552534017;
				if (num != 0)
				{
				}
				num = (short)1185021952;
				short num3 = num;
				num = (short)712507392;
				if (num != 0)
				{
				}
				return this.a;
			}
			private set
			{
				short num = (short)8637388;
				short num2 = num;
				num = (short)1280953292;
				switch (num2 == num)
				{
				}
				num = (short)1758724096;
				if (num != 0)
				{
				}
				num = (short)134938624;
				short num3 = num;
				num = (short)430964737;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0011B760 File Offset: 0x00119960
		// (set) Token: 0x06000D76 RID: 3446 RVA: 0x0011B810 File Offset: 0x00119A10
		internal string SerialNumber
		{
			get
			{
				short num = (short)314114049;
				if (num != 0)
				{
				}
				num = (short)2077640887;
				short num2 = num;
				num = (short)1590053047;
				switch (num2 == num)
				{
				}
				num = (short)1866727424;
				short num3 = num;
				num = (short)799801344;
				if (num != 0)
				{
				}
				return this.b;
			}
			private set
			{
				short num = (short)1646007239;
				short num2 = num;
				num = (short)875434951;
				switch (num2 == num)
				{
				}
				num = (short)1199702016;
				if (num != 0)
				{
				}
				num = (short)1759248384;
				short num3 = num;
				num = (short)103153665;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x0011B8C0 File Offset: 0x00119AC0
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x0011B970 File Offset: 0x00119B70
		internal string Flashcode
		{
			get
			{
				short num = (short)1936688783;
				short num2 = num;
				num = (short)1429112463;
				switch (num2 == num)
				{
				}
				num = (short)1955528704;
				if (num != 0)
				{
				}
				num = (short)1342832640;
				short num3 = num;
				num = (short)657391617;
				if (num != 0)
				{
				}
				return this.c;
			}
			private set
			{
				short num = (short)1240074095;
				short num2 = num;
				num = (short)931727215;
				switch (num2 == num)
				{
				}
				num = (short)462028800;
				if (num != 0)
				{
				}
				num = (short)2029191168;
				short num3 = num;
				num = (short)199950337;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x040006FC RID: 1788
		private string a;

		// Token: 0x040006FD RID: 1789
		private string b;

		// Token: 0x040006FE RID: 1790
		private string c;
	}
}
