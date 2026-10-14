using System;
using System.Globalization;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200005E RID: 94
	public class RcmpWriteIshItem : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00014460 File Offset: 0x00012660
		private byte LogicalPartition
		{
			get
			{
				short num = (short)1731774015;
				short num2 = num;
				num = (short)329238079;
				switch (num2 == num)
				{
				}
				num = (short)1435303937;
				if (num != 0)
				{
				}
				num = (short)1130561536;
				short num3 = num;
				num = (short)413663232;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00014510 File Offset: 0x00012710
		private ushort IshType
		{
			get
			{
				short num = (short)885956050;
				short num2 = num;
				num = (short)1885511122;
				switch (num2 == num)
				{
				}
				num = (short)65273857;
				if (num != 0)
				{
				}
				num = (short)1342177280;
				short num3 = num;
				num = (short)1059913728;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000145BC File Offset: 0x000127BC
		private ushort IshID
		{
			get
			{
				short num = (short)602625860;
				short num2 = num;
				num = (short)1332696900;
				switch (num2 == num)
				{
				}
				num = (short)1572667392;
				if (num != 0)
				{
				}
				num = (short)1415512064;
				short num3 = num;
				num = (short)821035009;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0001466C File Offset: 0x0001286C
		private ushort ItemSize
		{
			get
			{
				short num = (short)1669352822;
				short num2 = num;
				num = (short)1866878326;
				switch (num2 == num)
				{
				}
				num = (short)1760362497;
				if (num != 0)
				{
				}
				num = (short)1021640704;
				short num3 = num;
				num = (short)2123104256;
				if (num != 0)
				{
				}
				return this.f;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00014720 File Offset: 0x00012920
		private ushort NumberOfBytes
		{
			get
			{
				short num = (short)2067196697;
				short num2 = num;
				num = (short)1037363993;
				switch (num2 == num)
				{
				}
				num = (short)1948975104;
				if (num != 0)
				{
				}
				num = (short)19922944;
				short num3 = num;
				num = (short)999227393;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000147D0 File Offset: 0x000129D0
		private ushort Offset
		{
			get
			{
				short num = (short)2078099674;
				short num2 = num;
				num = (short)620841178;
				switch (num2 == num)
				{
				}
				num = (short)1347747841;
				if (num != 0)
				{
				}
				num = (short)1330446336;
				short num3 = num;
				num = (short)1699545088;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00014880 File Offset: 0x00012A80
		private byte[] Data
		{
			get
			{
				short num = (short)867041281;
				if (num != 0)
				{
				}
				num = (short)473328336;
				short num2 = num;
				num = (short)1795779280;
				switch (num2 == num)
				{
				}
				num = (short)232849408;
				short num3 = num;
				num = (short)584187904;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00014930 File Offset: 0x00012B30
		private bool WriteToDual
		{
			get
			{
				short num = (short)918567830;
				short num2 = num;
				num = (short)1843084182;
				switch (num2 == num)
				{
				}
				num = (short)741212161;
				if (num != 0)
				{
				}
				num = (short)286785536;
				short num3 = num;
				num = (short)2096431104;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000149E0 File Offset: 0x00012BE0
		public RcmpWriteIshItem(byte partition, ushort type, ushort id, ushort numberOfBytes, ushort offset, ushort itemSize, byte[] data, bool writeToDual)
		{
			int a_ = 17;
			base..ctor();
			base.Opcode = 257;
			if (data == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("列ﺞ햠슢", a_));
			}
			if ((int)numberOfBytes != data.Length)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("철솢삤햦춪횮얰횲운", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("列ﺞ햠슢薤풦삨톪좬辮\ud8b0삲閴\ud9b6횸쾺鶼\udabe냀뛂꓄ꯆ뿊ꋌ뿐ꛒ룔뗖볘꧚鋜맞ꏠ髢釤苦髨", a_));
			}
			this.a = partition;
			this.h = writeToDual;
			this.b = type;
			this.c = id;
			this.d = numberOfBytes;
			this.e = offset;
			this.f = itemSize;
			this.g = data;
			if (this.h)
			{
				this.a += 1;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00014AAC File Offset: 0x00012CAC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)138482854;
			short num2 = num;
			num = (short)2140935334;
			switch (num2 == num)
			{
			}
			num = (short)1310654464;
			if (num != 0)
			{
			}
			num = (short)462094336;
			short num3 = num;
			num = (short)1279983617;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c,
				this.d,
				this.e,
				this.f,
				this.g
			});
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00014BD0 File Offset: 0x00012DD0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.a,
						global::Motorola.Common.Communication.r.a,
						global::Motorola.Common.Communication.r.a,
						global::Motorola.Common.Communication.r.a,
						global::Motorola.Common.Communication.r.a
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (byte)array[0];
					this.b = (ushort)array[1];
					this.c = (ushort)array[2];
					this.d = (ushort)array[3];
					this.e = (ushort)array[4];
					this.f = (ushort)array[5];
					num2 = (short)1858338816;
					short num3 = num2;
					num2 = (short)1824456706;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (length > global::Motorola.Common.Communication.r.b())
					{
						num2 = (short)268763136;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_152;
				case 2:
					goto IL_150;
				}
				goto IL_1C;
			}
			IL_150:
			IL_152:
			num2 = (short)719896689;
			short num4 = num2;
			num2 = (short)728678513;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_150;
			default:
				num2 = (short)789643264;
				if (num2 != 0)
				{
				}
				num2 = (short)542113793;
				if (num2 != 0)
				{
				}
				return;
			}
			IL_1C:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1409679361;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00014DA4 File Offset: 0x00012FA4
		public int MaxMessageSize
		{
			get
			{
				short num = (short)1656474727;
				short num2 = num;
				num = (short)686935143;
				switch (num2 == num)
				{
				}
				num = (short)914554880;
				if (num != 0)
				{
				}
				num = (short)1076428800;
				short num3 = num;
				num = (short)2027028481;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.Rcmp.RcmpWriteIshItem.HeaderSize + this.g.Length;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00014E5C File Offset: 0x0001305C
		public static int HeaderSize
		{
			get
			{
				short num = (short)496001426;
				short num2 = num;
				num = (short)1069179282;
				switch (num2 == num)
				{
				}
				num = (short)779943937;
				if (num != 0)
				{
				}
				num = (short)412221440;
				short num3 = num;
				num = (short)1718091776;
				if (num != 0)
				{
				}
				return 14;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00014F04 File Offset: 0x00013104
		public override string ToString()
		{
			int a_ = 18;
			short num = (short)1610488093;
			short num2 = num;
			num = (short)1039407389;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2000158720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)136052737;
			if (num != 0)
			{
			}
			num = (short)1255604224;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("邟\udfa1貣즧\ud8a9\ud8ab잭쒯\udbb1\udbb3\ud8b5薷솹趻쎽雁뷃뛅귇럋ﳍ귏ﻑ鷓鋕ꇙꏝ쳟곡釣该諧迩黫ꇭ雯냱跳苵鷷觹쇻藽㓿缁⠃䤅渇氉缋欍搏⼑漓⌕攗㘙唛樝䔟伡眣伥刧伩ᄫ唭د伱ᠳ搵崷䨹倻䜽ሿ❁㝃㍅⑇㹉煋㕍杏⽑絓", a_), new object[]
			{
				base.GetType().Name,
				this.LogicalPartition,
				this.IshType,
				this.IshID,
				this.NumberOfBytes,
				this.Offset,
				this.ItemSize,
				base.ReplyResult
			});
		}

		// Token: 0x040001AB RID: 427
		private byte a;

		// Token: 0x040001AC RID: 428
		private ushort b;

		// Token: 0x040001AD RID: 429
		private ushort c;

		// Token: 0x040001AE RID: 430
		private ushort d;

		// Token: 0x040001AF RID: 431
		private ushort e;

		// Token: 0x040001B0 RID: 432
		private ushort f;

		// Token: 0x040001B1 RID: 433
		private byte[] g;

		// Token: 0x040001B2 RID: 434
		private bool h;
	}
}
