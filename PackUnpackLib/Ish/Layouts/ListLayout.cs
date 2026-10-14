using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000026 RID: 38
	public class ListLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00021B74 File Offset: 0x0001FD74
		internal ListLayout(string A_0, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_1, int A_2, int A_3, int A_4) : this(A_0, A_1, A_2, A_3, A_4, false)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00021B90 File Offset: 0x0001FD90
		public ListLayout(string name, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType headerType, global::Motorola.Acp.PackUnpack.Ish.ListListletType listletType, int listCapacity, int headerCapacity, int listletCapacity, int headerDataAreaSize, int listEntrySize) : this(name, headerType, listletType, listCapacity, headerCapacity, listletCapacity, headerDataAreaSize, listEntrySize, false)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00021BB4 File Offset: 0x0001FDB4
		internal ListLayout(string A_0, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType A_1, int A_2, int A_3, int A_4, bool A_5) : this(A_0, A_1, null, A_2, A_2, 0, A_3, A_4, A_5)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00021BD4 File Offset: 0x0001FDD4
		public ListLayout(string name, global::Motorola.Acp.PackUnpack.Ish.ListHeaderType headerType, global::Motorola.Acp.PackUnpack.Ish.ListListletType listletType, int listCapacity, int headerCapacity, int listletCapacity, int headerDataAreaSize, int listEntrySize, bool allowEmptyList)
		{
			int a_ = 4;
			base..ctor(name, global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayoutType.List, new global::Motorola.Acp.PackUnpack.Ish.IshType[]
			{
				headerType,
				listletType
			});
			if (headerType.ListletType != null)
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺞ얠욢힤킨\udbaa좬", a_));
			}
			if (listletType != null)
			{
				if (listletType.HeaderType != null)
				{
					throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠쾢삤펦ﶨ튪\uddac쪮", a_));
				}
				if (listletCapacity < 0)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠쾢삤펦쪪\uddac캮튰\udab2솴캶", a_));
				}
			}
			else if (listletCapacity != 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠쾢삤펦쪪\uddac캮튰\udab2솴캶", a_));
			}
			if (listCapacity <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠쒤힦좨좪쒬\udbae좰", a_));
			}
			if (headerCapacity < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺞ얠욢힤좨\udbaa첬첮\ud8b0잲체", a_));
			}
			if (headerDataAreaSize < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺞ얠욢힤좨\udfaa첬쎰횲풴킸솺\ud8bc", a_));
			}
			if (listEntrySize <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("햠쮤펦\udba8튪ﺬ욮쮰횲", a_));
			}
			if (headerDataAreaSize > 0)
			{
				this.f = new global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout(this, global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListHeader, name + global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("뮚햜爵삠잢삤햦覨첬\udbae킰鎲얶\udcb8\udaba鶼ꃀ뫂꫄닆뷈", a_), headerDataAreaSize);
			}
			else
			{
				this.f = null;
			}
			this.g = new global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout(this, global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType.ListEntry, name + global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("뮚톜튠힢薤잨\udfaa\udfac횮醰풴쎶\ud8b8鮺ﲼ춾꓀ꋂ识꣈닊ꋌ뫎ꗐ", a_), listEntrySize);
			headerType.ListletType = listletType;
			if (listletType != null)
			{
				listletType.HeaderType = headerType;
			}
			this.a = listCapacity;
			this.b = headerCapacity;
			this.c = listletCapacity;
			this.h = allowEmptyList;
			this.d = listEntrySize;
			this.e = headerDataAreaSize;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00021DA8 File Offset: 0x0001FFA8
		internal int ListCapacity
		{
			get
			{
				short num = (short)1814888449;
				if (num != 0)
				{
				}
				num = (short)777062873;
				short num2 = num;
				num = (short)148965849;
				switch (num2 == num)
				{
				}
				num = (short)320077824;
				if (num != 0)
				{
				}
				num = (short)1900740608;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00021E54 File Offset: 0x00020054
		internal int HeaderCapacity
		{
			get
			{
				short num = (short)269985967;
				short num2 = num;
				num = (short)551200943;
				switch (num2 == num)
				{
				}
				num = (short)1453129729;
				if (num != 0)
				{
				}
				num = (short)1919287296;
				if (num != 0)
				{
				}
				num = (short)150405120;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00021F04 File Offset: 0x00020104
		internal int ListletCapacity
		{
			get
			{
				short num = (short)326736608;
				short num2 = num;
				num = (short)1604426464;
				switch (num2 == num)
				{
				}
				num = (short)64749568;
				if (num != 0)
				{
				}
				num = (short)175308801;
				if (num != 0)
				{
				}
				num = (short)1572012032;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00021FB4 File Offset: 0x000201B4
		internal int ListEntrySize
		{
			get
			{
				short num = (short)1150664719;
				short num2 = num;
				num = (short)2040512527;
				switch (num2 == num)
				{
				}
				num = (short)1640562689;
				if (num != 0)
				{
				}
				num = (short)95354880;
				if (num != 0)
				{
				}
				num = (short)117637120;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00022064 File Offset: 0x00020264
		internal int HeaderDataAreaSize
		{
			get
			{
				short num = (short)1273745351;
				short num2 = num;
				num = (short)1693503431;
				switch (num2 == num)
				{
				}
				num = (short)705167361;
				if (num != 0)
				{
				}
				num = (short)246415360;
				if (num != 0)
				{
				}
				num = (short)167182336;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00022114 File Offset: 0x00020314
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout HeaderDataAreaLayout
		{
			get
			{
				short num = (short)1862726568;
				short num2 = num;
				num = (short)196539304;
				switch (num2 == num)
				{
				}
				num = (short)787873793;
				if (num != 0)
				{
				}
				num = (short)798162944;
				if (num != 0)
				{
				}
				num = (short)190971904;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000221C4 File Offset: 0x000203C4
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout ListEntryLayout
		{
			get
			{
				short num = (short)928666659;
				short num2 = num;
				num = (short)663966755;
				switch (num2 == num)
				{
				}
				num = (short)1909063681;
				if (num != 0)
				{
				}
				num = (short)749207552;
				if (num != 0)
				{
				}
				num = (short)2046623744;
				short num3 = num;
				return this.g;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00022278 File Offset: 0x00020478
		public global::Motorola.Acp.PackUnpack.Ish.ListHeaderType HeaderType
		{
			get
			{
				short num = (short)262587255;
				short num2 = num;
				num = (short)834847607;
				switch (num2 == num)
				{
				}
				num = (short)1812070401;
				if (num != 0)
				{
				}
				num = (short)1221132288;
				if (num != 0)
				{
				}
				num = (short)1596850176;
				short num3 = num;
				return base.IshTypes[0] as global::Motorola.Acp.PackUnpack.Ish.ListHeaderType;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00022330 File Offset: 0x00020530
		internal global::Motorola.Acp.PackUnpack.Ish.ListListletType ListletType
		{
			get
			{
				short num = (short)966983680;
				short num2 = num;
				if (base.IshTypes.Count == 1)
				{
					num = (short)483865485;
					short num3 = num;
					num = (short)1824928653;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)762970113;
						if (num != 0)
						{
						}
						num = (short)983760896;
						if (num != 0)
						{
						}
						return null;
					}
				}
				return base.IshTypes[1] as global::Motorola.Acp.PackUnpack.Ish.ListListletType;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00022400 File Offset: 0x00020600
		internal bool AllowEmptyList
		{
			get
			{
				short num = (short)569205713;
				short num2 = num;
				num = (short)1868719057;
				switch (num2 == num)
				{
				}
				num = (short)306315265;
				if (num != 0)
				{
				}
				num = (short)214368256;
				if (num != 0)
				{
				}
				num = (short)426573824;
				short num3 = num;
				return this.h;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000224B0 File Offset: 0x000206B0
		public override int Size
		{
			get
			{
				short num = (short)1286831913;
				short num2 = num;
				num = (short)912752425;
				switch (num2 == num)
				{
				}
				num = (short)825032705;
				if (num != 0)
				{
				}
				num = (short)1794899968;
				if (num != 0)
				{
				}
				num = (short)79036416;
				short num3 = num;
				return this.HeaderSize + this.ListletSize;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00022564 File Offset: 0x00020764
		internal int HeaderSize
		{
			get
			{
				short num = (short)914585300;
				short num2 = num;
				num = (short)1031042772;
				switch (num2 == num)
				{
				}
				num = (short)685309953;
				if (num != 0)
				{
				}
				num = (short)1156907008;
				if (num != 0)
				{
				}
				num = (short)1778843648;
				short num3 = num;
				return 18 + this.e + this.b * this.d;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00022624 File Offset: 0x00020824
		internal int ListletSize
		{
			get
			{
				short num = (short)1385579490;
				short num2 = num;
				num = (short)1952203746;
				switch (num2 == num)
				{
				}
				num = (short)701497344;
				if (num != 0)
				{
				}
				num = (short)1550778369;
				if (num != 0)
				{
				}
				num = (short)2014183424;
				short num3 = num;
				return 6 + this.c * this.d;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000226E0 File Offset: 0x000208E0
		public override int MaxSize
		{
			get
			{
				short num = (short)538778520;
				short num2 = num;
				num = (short)2132286360;
				switch (num2 == num)
				{
				}
				num = (short)1472724992;
				if (num != 0)
				{
				}
				num = (short)2074869761;
				if (num != 0)
				{
				}
				num = (short)1667956736;
				short num3 = num;
				return this.Size;
			}
		}

		// Token: 0x04000072 RID: 114
		private int a;

		// Token: 0x04000073 RID: 115
		private int b;

		// Token: 0x04000074 RID: 116
		private int c;

		// Token: 0x04000075 RID: 117
		private int d;

		// Token: 0x04000076 RID: 118
		private int e;

		// Token: 0x04000077 RID: 119
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout f;

		// Token: 0x04000078 RID: 120
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout g;

		// Token: 0x04000079 RID: 121
		private bool h;
	}
}
