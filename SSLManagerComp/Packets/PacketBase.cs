using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000026 RID: 38
	public abstract class PacketBase
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000E154 File Offset: 0x0000C354
		public global::SSLMangrComp.Packets.SubscriptionType Type
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1742209024;
				short num2 = num;
				num = (short)73990145;
				if (num != 0)
				{
				}
				num = (short)591429357;
				short num3 = num;
				num = (short)2100199149;
				switch (num3 == num)
				{
				}
				num = (short)1159921664;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1050673152;
				short num2 = num;
				num = (short)364224255;
				short num3 = num;
				num = (short)299081471;
				switch (num3 == num)
				{
				}
				num = (short)733020161;
				if (num != 0)
				{
				}
				num = (short)785055744;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000E204 File Offset: 0x0000C404
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		public bool IsPacketRecived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1425604608;
				short num2 = num;
				num = (short)1699999779;
				short num3 = num;
				num = (short)698347555;
				switch (num3 == num)
				{
				}
				num = (short)408289281;
				if (num != 0)
				{
				}
				num = (short)1184366592;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)184811520;
				short num2 = num;
				num = (short)259168143;
				short num3 = num;
				num = (short)769365903;
				switch (num3 == num)
				{
				}
				num = (short)68091905;
				if (num != 0)
				{
				}
				num = (short)786759680;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000E364 File Offset: 0x0000C564
		public global::System.DateTime PacketDataTime
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1354432512;
				short num2 = num;
				num = (short)1924604482;
				short num3 = num;
				num = (short)1451762242;
				switch (num3 == num)
				{
				}
				num = (short)89325569;
				if (num != 0)
				{
				}
				num = (short)366870528;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000E414 File Offset: 0x0000C614
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000E4C4 File Offset: 0x0000C6C4
		public byte MessageID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)5439488;
				short num2 = num;
				num = (short)1149076153;
				short num3 = num;
				num = (short)1185972921;
				switch (num3 == num)
				{
				}
				num = (short)1463812097;
				if (num != 0)
				{
				}
				num = (short)977403904;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)762904576;
				short num2 = num;
				num = (short)1504369184;
				short num3 = num;
				num = (short)2028329504;
				switch (num3 == num)
				{
				}
				num = (short)1206321152;
				if (num != 0)
				{
				}
				num = (short)316014593;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000E574 File Offset: 0x0000C774
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000E620 File Offset: 0x0000C820
		public ushort DialogID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)999817216;
				short num2 = num;
				num = (short)339294425;
				short num3 = num;
				num = (short)662780121;
				switch (num3 == num)
				{
				}
				num = (short)476905473;
				if (num != 0)
				{
				}
				num = (short)223412224;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1480458240;
				short num2 = num;
				num = (short)1662648321;
				if (num != 0)
				{
				}
				num = (short)1660319675;
				short num3 = num;
				num = (short)1182889915;
				switch (num3 == num)
				{
				}
				num = (short)1233977344;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x060000ED RID: 237
		public abstract byte[] getData();

		// Token: 0x060000EE RID: 238
		public abstract string getPacketDescription();

		// Token: 0x060000EF RID: 239
		public abstract string[,] GetAllParameters();

		// Token: 0x060000F0 RID: 240 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		protected void EncodeTLV(global::System.IO.MemoryStream msgBuffer, byte tag, byte objValue)
		{
			short num = (short)933363712;
			short num2 = num;
			num = (short)1956854167;
			short num3 = num;
			num = (short)814758295;
			switch (num3 == num)
			{
			}
			num = (short)657391616;
			if (num != 0)
			{
			}
			num = (short)1598423041;
			if (num != 0)
			{
			}
			msgBuffer.WriteByte(tag);
			msgBuffer.WriteByte(1);
			msgBuffer.WriteByte(objValue);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000E790 File Offset: 0x0000C990
		protected void EncodeTLV(global::System.IO.MemoryStream msgBuffer, byte tag, byte[] objValue)
		{
			short num = (short)534446080;
			short num2 = num;
			num = (short)151882878;
			short num3 = num;
			num = (short)1693420670;
			switch (num3 == num)
			{
			}
			num = (short)1438515201;
			if (num != 0)
			{
			}
			num = (short)494927872;
			if (num != 0)
			{
			}
			msgBuffer.WriteByte(tag);
			msgBuffer.WriteByte(global::System.Convert.ToByte(objValue.Length));
			msgBuffer.Write(objValue, 0, objValue.Length);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000E85C File Offset: 0x0000CA5C
		protected void EncodeTLV(global::System.IO.MemoryStream msgBuffer, byte tag, string objValue)
		{
			short num = (short)1476395008;
			short num2 = num;
			num = (short)401067319;
			short num3 = num;
			num = (short)601738551;
			switch (num3 == num)
			{
			}
			num = (short)2108358657;
			if (num != 0)
			{
			}
			num = (short)1041694720;
			if (num != 0)
			{
			}
			global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding(false, true);
			msgBuffer.WriteByte(tag);
			msgBuffer.WriteByte(global::System.Convert.ToByte(unicodeEncoding.GetByteCount(objValue)));
			byte[] bytes = unicodeEncoding.GetBytes(objValue);
			msgBuffer.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x04000089 RID: 137
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.Packets.SubscriptionType a;

		// Token: 0x0400008A RID: 138
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b = true;

		// Token: 0x0400008B RID: 139
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.DateTime c = global::System.DateTime.Now;

		// Token: 0x0400008C RID: 140
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte d;

		// Token: 0x0400008D RID: 141
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private ushort e;
	}
}
