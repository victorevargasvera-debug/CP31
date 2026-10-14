using System;
using System.Text;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Encodings
{
	// Token: 0x0200000A RID: 10
	public class BinaryCodedCharEncoding : global::System.Text.Encoding
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00004400 File Offset: 0x00002600
		internal BinaryCodedCharEncoding(bool A_0)
		{
			this.c = new global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharEncoder(A_0);
			this.d = new global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharDecoder(A_0);
			this.b = A_0;
			this.c.StartNibble = this.a;
			this.d.StartNibble = this.a;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000445C File Offset: 0x0000265C
		internal BinaryCodedCharEncoding(int A_0) : base(A_0)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000447C File Offset: 0x0000267C
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00004528 File Offset: 0x00002728
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble StartNibble
		{
			get
			{
				short num = (short)1566244864;
				short num2 = num;
				num = (short)744384836;
				short num3 = num;
				num = (short)745433412;
				switch (num3 == num)
				{
				}
				num = (short)902823936;
				if (num != 0)
				{
				}
				num = (short)1603141633;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)194707456;
				short num2 = num;
				num = (short)747363879;
				short num3 = num;
				num = (short)195354151;
				switch (num3 == num)
				{
				}
				num = (short)432406529;
				if (num != 0)
				{
				}
				num = (short)102236160;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000045D8 File Offset: 0x000027D8
		internal bool BchEncoding
		{
			get
			{
				short num = (short)716636160;
				short num2 = num;
				num = (short)1720833081;
				short num3 = num;
				num = (short)1254741049;
				switch (num3 == num)
				{
				}
				num = (short)1402011648;
				if (num != 0)
				{
				}
				num = (short)516882433;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004688 File Offset: 0x00002888
		public override int GetByteCount(char[] chars, int index, int count)
		{
			short num = (short)1014235136;
			short num2 = num;
			num = (short)65498439;
			short num3 = num;
			num = (short)1957784903;
			switch (num3 == num)
			{
			}
			num = (short)1800273921;
			if (num != 0)
			{
			}
			num = (short)987037696;
			if (num != 0)
			{
			}
			this.c.StartNibble = this.StartNibble;
			return this.c.GetByteCount(chars, index, count, true);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004754 File Offset: 0x00002954
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			short num = (short)1946157056;
			short num2 = num;
			num = (short)384463612;
			short num3 = num;
			num = (short)1381659388;
			switch (num3 == num)
			{
			}
			num = (short)1049362433;
			if (num != 0)
			{
			}
			num = (short)2080440320;
			if (num != 0)
			{
			}
			this.c.StartNibble = this.StartNibble;
			return this.c.GetBytes(chars, charIndex, charCount, bytes, byteIndex, true);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004824 File Offset: 0x00002A24
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			short num = (short)157286400;
			short num2 = num;
			num = (short)1493462301;
			short num3 = num;
			num = (short)1281715485;
			switch (num3 == num)
			{
			}
			num = (short)1715273728;
			if (num != 0)
			{
			}
			num = (short)1579483137;
			if (num != 0)
			{
			}
			this.d.StartNibble = this.StartNibble;
			return this.d.GetCharCount(bytes, index, count);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000048EC File Offset: 0x00002AEC
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			short num = (short)1253507072;
			short num2 = num;
			num = (short)1142653754;
			short num3 = num;
			num = (short)1335067450;
			switch (num3 == num)
			{
			}
			num = (short)980025344;
			if (num != 0)
			{
			}
			num = (short)1948319745;
			if (num != 0)
			{
			}
			this.d.StartNibble = this.StartNibble;
			return this.d.GetChars(bytes, byteIndex, byteCount, chars, charIndex);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000049BC File Offset: 0x00002BBC
		public override int GetMaxByteCount(int charCount)
		{
			int a_ = 9;
			short num = (short)1270480896;
			short num2 = num;
			num = (short)854523905;
			if (num != 0)
			{
			}
			num = (short)1637210956;
			short num3 = num;
			num = (short)936106828;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1112145920;
				if (num != 0)
				{
				}
				if (charCount < 0)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎟쪡얣풥얩\ud9ab삭쒯", a_));
				}
				break;
			}
			return (int)global::System.Math.Ceiling((double)charCount / 2.0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004A98 File Offset: 0x00002C98
		public override int GetMaxCharCount(int byteCount)
		{
			int a_ = 4;
			short num = (short)1467154432;
			short num2 = num;
			num = (short)73072641;
			if (num != 0)
			{
			}
			num = (short)251384127;
			short num3 = num;
			num = (short)150393151;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)875888640;
				if (num != 0)
				{
				}
				if (byteCount < 0)
				{
					throw new global::System.ArgumentOutOfRangeException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("連쒠쪤튦잨\udfaa", a_));
				}
				break;
			}
			return byteCount * 2;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004B64 File Offset: 0x00002D64
		public override string EncodingName
		{
			get
			{
				int a_ = 7;
				short num = (short)1311899648;
				short num2 = num;
				num = (short)595874439;
				short num3 = num;
				num = (short)1004688007;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)658309120;
					if (num != 0)
					{
					}
					if (!this.b)
					{
						num = (short)389283841;
						if (num != 0)
						{
						}
						return global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc9d", a_);
					}
					break;
				}
				return global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("\udc9d", a_);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004C40 File Offset: 0x00002E40
		public override string BodyName
		{
			get
			{
				int a_ = 17;
				short num = (short)335216048;
				short num2 = num;
				num = (short)1678638512;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2083127297;
					if (num != 0)
					{
					}
					num = (short)646381568;
					if (num != 0)
					{
					}
					if (!this.b)
					{
						return global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪧즩좫", a_);
					}
					break;
				}
				num = (short)223150080;
				short num3 = num;
				return global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쪧즩쒫", a_);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00004D1C File Offset: 0x00002F1C
		public override string HeaderName
		{
			get
			{
				short num = (short)910149539;
				short num2 = num;
				num = (short)1011992483;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1221459968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1530396673;
				if (num != 0)
				{
				}
				num = (short)1740570624;
				if (num != 0)
				{
				}
				return this.BodyName;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004DCC File Offset: 0x00002FCC
		public override string WebName
		{
			get
			{
				short num = (short)514433471;
				short num2 = num;
				num = (short)664641983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)213581824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686175745;
				if (num != 0)
				{
				}
				num = (short)1221656576;
				if (num != 0)
				{
				}
				return this.BodyName;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004E7C File Offset: 0x0000307C
		public override global::System.Text.Encoder GetEncoder()
		{
			short num = (short)1097465857;
			if (num != 0)
			{
			}
			num = (short)1045692416;
			short num2 = num;
			num = (short)907828831;
			short num3 = num;
			num = (short)18046559;
			switch (num3 == num)
			{
			}
			num = (short)1350893568;
			if (num != 0)
			{
			}
			return new global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharEncoder(this.b)
			{
				StartNibble = this.a
			};
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004F40 File Offset: 0x00003140
		public override global::System.Text.Decoder GetDecoder()
		{
			short num = (short)1243480810;
			short num2 = num;
			num = (short)357892842;
			switch (num2 == num)
			{
			default:
			{
				num = (short)773324800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)921108481;
			if (num != 0)
			{
			}
			num = (short)2130509824;
			if (num != 0)
			{
			}
			return new global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharDecoder(this.b)
			{
				StartNibble = this.a
			};
		}

		// Token: 0x0400000C RID: 12
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble a = global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble.Upper;

		// Token: 0x0400000D RID: 13
		private bool b;

		// Token: 0x0400000E RID: 14
		private global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharEncoder c;

		// Token: 0x0400000F RID: 15
		private global::Motorola.Acp.PackUnpack.Encodings.BinaryCodedCharDecoder d;
	}
}
