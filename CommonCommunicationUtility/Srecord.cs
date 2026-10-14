using System;
using System.IO;
using System.Text;
using Motorola.Common.CommonLib;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class Srecord : global::System.IDisposable
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003328 File Offset: 0x00001528
		public Srecord()
		{
			this.a = string.Empty;
			this.b = new global::Motorola.Common.Communication.SrecDataCollection();
			this.e = 0;
			this.f = 0;
			this.h = 0U;
			this.g = null;
			this.i = 0;
			this.j = false;
			this.k = 0;
			this.l = string.Empty;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003390 File Offset: 0x00001590
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)251254274;
				short num2 = num;
				num = (short)1274205698;
				switch (num2 == num)
				{
				}
				num = (short)770506752;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)1512964097;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)370933760;
			short num3 = num;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000345C File Offset: 0x0000165C
		public int MaxDataSize
		{
			get
			{
				short num = (short)1398420188;
				short num2 = num;
				num = (short)1084764892;
				switch (num2 == num)
				{
				}
				num = (short)1848115201;
				if (num != 0)
				{
				}
				num = (short)2113273856;
				if (num != 0)
				{
				}
				num = (short)1771700224;
				short num3 = num;
				return this.k;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000350C File Offset: 0x0000170C
		private string strData
		{
			get
			{
				short num = (short)1303247738;
				short num2 = num;
				num = (short)792722298;
				switch (num2 == num)
				{
				}
				num = (short)371261441;
				if (num != 0)
				{
				}
				num = (short)1445855232;
				if (num != 0)
				{
				}
				num = (short)2096889856;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000035BC File Offset: 0x000017BC
		private string Signature
		{
			get
			{
				short num = (short)1437755356;
				short num2 = num;
				num = (short)102328284;
				switch (num2 == num)
				{
				}
				num = (short)114950145;
				if (num != 0)
				{
				}
				num = (short)1586429952;
				if (num != 0)
				{
				}
				num = (short)1910374400;
				short num3 = num;
				return this.l;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000366C File Offset: 0x0000186C
		public uint AddressLow
		{
			get
			{
				short num = (short)1797490656;
				short num2 = num;
				num = (short)1940948960;
				switch (num2 == num)
				{
				}
				num = (short)1528233985;
				if (num != 0)
				{
				}
				num = (short)1809711104;
				if (num != 0)
				{
				}
				num = (short)829292544;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000371C File Offset: 0x0000191C
		public uint AddressHigh
		{
			get
			{
				short num = (short)2087512478;
				short num2 = num;
				num = (short)1806428574;
				switch (num2 == num)
				{
				}
				num = (short)1230045185;
				if (num != 0)
				{
				}
				num = (short)1136197632;
				if (num != 0)
				{
				}
				num = (short)1885405184;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000037CC File Offset: 0x000019CC
		public global::Motorola.Common.Communication.SrecDataCollection DataRecords
		{
			get
			{
				short num = (short)765919233;
				if (num != 0)
				{
				}
				num = (short)1057358706;
				short num2 = num;
				num = (short)2080441202;
				switch (num2 == num)
				{
				}
				num = (short)940900352;
				if (num != 0)
				{
				}
				num = (short)806551552;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000387C File Offset: 0x00001A7C
		private void a(global::Motorola.Common.Communication.SrecLine A_0)
		{
			short num = (short)1490747392;
			switch (num)
			{
			default:
			{
				num = (short)444203029;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				bool flag;
				int num5;
				for (;;)
				{
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						global::System.Array.Copy(A_0.c(), 0, this.g, this.f, num3);
						this.f += num3;
						num = (short)933888032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!flag)
						{
							num = (short)2017787922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69F;
					case 2:
						goto IL_400;
					case 3:
						goto IL_61E;
					case 4:
					{
						global::Motorola.Common.Communication.SrecData item = new global::Motorola.Common.Communication.SrecData(0U, A_0.Address, null, global::Motorola.Common.Communication.SrecType.S7);
						this.b.Add(item);
						num = (short)1160577031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_69F;
					case 6:
						this.h = A_0.Address;
						num = (short)2094530563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_43B;
					case 8:
						if (flag2)
						{
							num = (short)790888478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						goto IL_619;
					case 10:
						if (A_0.Type == global::Motorola.Common.Communication.SrecType.S0)
						{
							num = (short)942473218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)262537250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						flag2 = true;
						flag = true;
						num = (short)511873574;
						short num4 = num;
						num = (short)437817894;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4F5;
						default:
							num = (short)1420558336;
							if (num != 0)
							{
							}
							num = (short)284164118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_69F;
					case 13:
						if ((ulong)A_0.Address + (ulong)((long)num3) - 1UL > (ulong)this.d)
						{
							num = (short)1473642515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_377;
					case 14:
						if (flag3)
						{
							num = (short)464519177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9;
					case 15:
						if (this.f == 0)
						{
							num = (short)357564422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1567162394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (A_0.Address < this.c)
						{
							num = (short)1120927768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187;
					case 17:
						num3 = A_0.c().Length;
						num = (short)1220280343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1769865244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						this.d = A_0.Address + (uint)num3 - 1U;
						num = (short)1371013140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_377;
					case 21:
						switch (0)
						{
						case 0:
							goto IL_D5;
						}
						continue;
					case 22:
						goto IL_61E;
					case 23:
						if (this.i == 0)
						{
							num = (short)1797586979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F4;
					case 24:
						this.c = A_0.Address;
						num = (short)957808667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_2C0;
					case 26:
						if ((ulong)A_0.Address != (ulong)this.h + (ulong)((long)this.f))
						{
							num = (short)1951465473;
							if (num != 0)
							{
							}
							num = (short)276299787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61E;
					case 27:
						goto IL_187;
					case 28:
						if (num3 <= this.e - this.f)
						{
							num = (short)44040192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Array.Copy(A_0.c(), 0, this.g, this.f, this.e - this.f);
						num5 = this.e - this.f;
						this.f = this.e;
						flag2 = true;
						flag3 = true;
						num = (short)2014969861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (flag)
						{
							num = (short)2114584601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1910046734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						this.k += this.f;
						global::Motorola.Common.Communication.SrecData item2 = new global::Motorola.Common.Communication.SrecData((uint)this.f, this.h, this.g, global::Motorola.Common.Communication.SrecType.S3);
						this.b.Add(item2);
						global::System.Array.Clear(this.g, 0, this.g.Length);
						num = (short)300285981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_1F4;
					case 32:
						if (this.f == this.e)
						{
							num = (short)837550113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69F;
					case 33:
						flag2 = true;
						num = (short)868352012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (A_0.Type == global::Motorola.Common.Communication.SrecType.S7)
						{
							num = (short)1313931268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 35:
						goto IL_4F5;
					}
					IL_D5:
					if (A_0.Type == global::Motorola.Common.Communication.SrecType.S3)
					{
						num = (short)810745873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1413218314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187:
					num = (short)1660813325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F4:
					num = (short)611254288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_377:
					flag2 = false;
					flag3 = false;
					num5 = 0;
					flag = false;
					num = (short)38076431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F5:
					this.c = A_0.Address;
					this.d = A_0.Address + (uint)num3 - 1U;
					this.i++;
					num = (short)1700200479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61E:
					num = (short)952762369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69F:
					num = (short)999751688;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D9:
				this.h += (uint)this.f;
				this.f = 0;
				return;
				IL_2C0:
				num = (short)1310851072;
				short num6 = num;
				this.h = A_0.Address;
				this.f = 0;
				global::System.Array.Copy(A_0.c(), 0, this.g, this.f, num3);
				this.f += num3;
				flag = false;
				return;
				IL_400:
				global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
				this.l = asciiencoding.GetString(A_0.c());
				return;
				IL_43B:
				return;
				IL_619:
				global::System.Array.Copy(A_0.c(), num5, this.g, 0, num3 - num5);
				this.h += (uint)this.f;
				this.f = num3 - num5;
				return;
			}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004068 File Offset: 0x00002268
		private void c()
		{
			short num = (short)1561722885;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)733020160;
					short num3 = num;
					if (this.b.Count == 0)
					{
						num = (short)41222152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num4 = this.b.Count - 1;
					num = (short)806617094;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					this.k += this.f;
					global::Motorola.Common.Communication.SrecData srecData = new global::Motorola.Common.Communication.SrecData((uint)this.f, this.h, this.g, global::Motorola.Common.Communication.SrecType.S3);
					goto IL_163;
				}
				case 2:
					goto IL_1CE;
				case 3:
					return;
				case 4:
					goto IL_1CE;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 6:
				{
					int num4;
					if (this.b[num4].Type != global::Motorola.Common.Communication.SrecType.S7)
					{
						global::Motorola.Common.Communication.SrecData srecData;
						this.b.Add(srecData);
						num = (short)1221525508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)977685852;
					short num5 = num;
					num = (short)1023298908;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_163;
					default:
						num = (short)172883968;
						if (num != 0)
						{
						}
						num = (short)653459465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num = (short)1848115201;
					if (num != 0)
					{
					}
					goto IL_1CE;
				case 8:
				{
					global::Motorola.Common.Communication.SrecData srecData;
					this.b.Add(srecData);
					num = (short)327876615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					int num4;
					global::Motorola.Common.Communication.SrecData srecData;
					this.b.a(num4, srecData);
					num = (short)10092546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4C:
				if (this.f != 0)
				{
					num = (short)224854017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_163:
				num = (short)2028208128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CE:
				global::System.Array.Clear(this.g, 0, this.g.Length);
				this.f = 0;
				this.h = 0U;
				num = (short)701038595;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000042F8 File Offset: 0x000024F8
		public void LoadSrecordData(string filePath, int maxDataPayload, bool verifyChecksum = true)
		{
			short num = (short)951386112;
			short num2 = num;
			num = (short)1285292033;
			if (num != 0)
			{
			}
			global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(filePath, global::System.IO.FileAccess.Read);
			try
			{
				byte[] bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream);
				string @string = new global::System.Text.ASCIIEncoding().GetString(bytesFromStream);
				this.LoadData(@string, maxDataPayload, verifyChecksum);
			}
			finally
			{
				num = (short)1439891456;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_9A;
					case 1:
						goto IL_139;
					case 2:
					{
						num = (short)438272062;
						short num4 = num;
						num = (short)954761278;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9A;
						default:
							num = (short)1449656320;
							if (num != 0)
							{
							}
							((global::System.IDisposable)stream).Dispose();
							num = (short)14090241;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_B6;
					IL_9A:
					switch (0)
					{
					case 0:
						IL_B6:
						if (stream == null)
						{
							goto IL_13B;
						}
						num = (short)1183121410;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_139:
				IL_13B:;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004454 File Offset: 0x00002654
		public void LoadData(string srecData, int maxDataPayload, bool verifyChecksum = true)
		{
			short num2;
			for (;;)
			{
				this.e = maxDataPayload;
				this.g = new byte[maxDataPayload];
				global::Motorola.Common.Communication.p p = new global::Motorola.Common.Communication.p(srecData);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					int num;
					for (;;)
					{
						IL_26:
						switch (num)
						{
						case 0:
							goto IL_80;
						case 1:
							goto IL_80;
						case 2:
							this.c();
							num2 = (short)1466892291;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_D4;
						case 4:
							if (!p.i())
							{
								num2 = (short)1042677762;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							this.a(p.h());
							num2 = (short)751304705;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_40;
						IL_80:
						num2 = (short)16252932;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_D4:
					goto IL_13E;
					IL_40:
					p.b(verifyChecksum);
					num2 = (short)1306656768;
					num = (int)((global::System.IntPtr)num2);
					goto IL_26;
				}
				finally
				{
					num2 = (short)680984576;
					int num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_106;
							}
							continue;
						case 1:
							goto IL_13B;
						case 2:
							((global::System.IDisposable)p).Dispose();
							num2 = (short)676790273;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_106:
						if (p == null)
						{
							break;
						}
						num2 = (short)533659650;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_13B:;
				}
				IL_13E:
				num2 = (short)1605435393;
				if (num2 != 0)
				{
				}
				num2 = (short)2123102679;
				short num3 = num2;
				num2 = (short)652671447;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_19C;
				}
			}
			IL_19C:
			num2 = (short)843186176;
			if (num2 != 0)
			{
			}
			num2 = (short)1589968896;
			short num4 = num2;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000464C File Offset: 0x0000284C
		public static string LoadSignatureFromSrecord(string srecData)
		{
			string result;
			short num;
			for (;;)
			{
				result = null;
				global::Motorola.Common.Communication.p p = new global::Motorola.Common.Communication.p(srecData);
				try
				{
					num = (short)160825346;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (p.h().Type == global::Motorola.Common.Communication.SrecType.S0)
							{
								num = (short)1208221702;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							if (!p.i())
							{
								num = (short)630652933;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)711524352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_4C;
							}
							continue;
						case 3:
							goto IL_109;
						case 4:
							goto IL_EC;
						case 5:
							num = (short)275382275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							result = new global::System.Text.ASCIIEncoding().GetString(p.h().c());
							num = (short)1946550276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_87:
						num = (short)871432193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4C:
						goto IL_87;
					}
					IL_EC:
					IL_109:;
				}
				finally
				{
					num = (short)1467547648;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_13B;
							}
							continue;
						case 1:
							goto IL_170;
						case 2:
							((global::System.IDisposable)p).Dispose();
							num = (short)1020723201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_13B:
						if (p == null)
						{
							break;
						}
						num = (short)1903689730;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_170:;
				}
				num = (short)703563883;
				short num3 = num;
				num = (short)115640427;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1A8;
				}
			}
			IL_1A8:
			num = (short)1699151873;
			if (num != 0)
			{
			}
			num = (short)355074048;
			if (num != 0)
			{
			}
			num = (short)1911226368;
			short num4 = num;
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004884 File Offset: 0x00002A84
		private void b()
		{
			short num = (short)489750529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AC;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					this.b.Clear();
					this.b = null;
					num = (short)658505728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)250347521;
					if (num != 0)
					{
					}
					num = (short)697303040;
					short num3 = num;
					this.g = null;
					num = (short)1737490437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (this.g != null)
					{
						num = (short)616562691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18A;
				case 5:
					goto IL_A7;
				}
				goto IL_3C;
				IL_44:
				num = (short)1705705474;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC:
				num = (short)1354532911;
				short num4 = num;
				num = (short)1704364079;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_44;
				default:
					num = (short)1472593920;
					if (num != 0)
					{
					}
					num = (short)1959788548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (this.b != null)
				{
					goto IL_44;
				}
				goto IL_AC;
			}
			IL_A7:
			IL_18A:
			this.a = null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004A24 File Offset: 0x00002C24
		private void a()
		{
			short num = (short)1689780224;
			short num2 = num;
			num = (short)622013122;
			short num3 = num;
			num = (short)184429250;
			switch (num3 == num)
			{
			}
			num = (short)1457324033;
			if (num != 0)
			{
			}
			num = (short)1875378176;
			if (num != 0)
			{
			}
			((global::System.IDisposable)this).Dispose();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004AD4 File Offset: 0x00002CD4
		public void Dispose()
		{
			short num = (short)635895808;
			short num2 = num;
			num = (short)85166718;
			short num3 = num;
			num = (short)321686142;
			switch (num3 == num)
			{
			}
			num = (short)1463549953;
			if (num != 0)
			{
			}
			num = (short)546766848;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004B88 File Offset: 0x00002D88
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)704118784;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
				{
					num = (short)1902699986;
					short num3 = num;
					num = (short)595518930;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AF;
					default:
						goto IL_8D;
					}
					break;
				}
				case 2:
					if (disposing)
					{
						num = (short)1763180547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				case 3:
					this.b();
					goto IL_AF;
				case 4:
					goto IL_EC;
				}
				IL_38:
				if (this.j)
				{
					num = (short)1634205697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1162018816;
				short num4 = num;
				num = (short)1049231362;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AF:
				num = (short)1890844673;
				if (num != 0)
				{
				}
				num = (short)1295515652;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8D:
			num = (short)878903296;
			if (num != 0)
			{
			}
			return;
			IL_EC:
			IL_14F:
			this.j = true;
		}

		// Token: 0x0400001E RID: 30
		private string a;

		// Token: 0x0400001F RID: 31
		private global::Motorola.Common.Communication.SrecDataCollection b;

		// Token: 0x04000020 RID: 32
		private uint c;

		// Token: 0x04000021 RID: 33
		private uint d;

		// Token: 0x04000022 RID: 34
		private int e;

		// Token: 0x04000023 RID: 35
		private int f;

		// Token: 0x04000024 RID: 36
		private byte[] g;

		// Token: 0x04000025 RID: 37
		private uint h;

		// Token: 0x04000026 RID: 38
		private int i;

		// Token: 0x04000027 RID: 39
		private bool j;

		// Token: 0x04000028 RID: 40
		private int k;

		// Token: 0x04000029 RID: 41
		private string l;
	}
}
