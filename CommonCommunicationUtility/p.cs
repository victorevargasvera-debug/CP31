using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	internal class p : global::System.IDisposable
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004CEC File Offset: 0x00002EEC
		public p(string strData)
		{
			if (string.IsNullOrEmpty(strData))
			{
				throw new global::System.ArgumentNullException("strData");
			}
			this.b = new global::System.IO.StringReader(strData);
			this.f = strData.Length;
			this.e = "";
			this.a = false;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004D40 File Offset: 0x00002F40
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)2056015986;
				short num2 = num;
				num = (short)336351346;
				switch (num2 == num)
				{
				}
				num = (short)550043648;
				if (num != 0)
				{
				}
				this.d(false);
			}
			finally
			{
				num = (short)2060910593;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)466419712;
			short num3 = num;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004E0C File Offset: 0x0000300C
		public global::Motorola.Common.Communication.SrecLine h()
		{
			short num = (short)383123456;
			short num2 = num;
			num = (short)62279010;
			short num3 = num;
			num = (short)325274978;
			switch (num3 == num)
			{
			}
			num = (short)1705050113;
			if (num != 0)
			{
			}
			num = (short)320995328;
			if (num != 0)
			{
			}
			return this.d;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004EC0 File Offset: 0x000030C0
		private bool g()
		{
			short num = (short)2093219840;
			short num2 = num;
			num = (short)1628107041;
			short num3 = num;
			num = (short)77984033;
			switch (num3 == num)
			{
			}
			num = (short)196345856;
			if (num != 0)
			{
			}
			num = (short)1566703617;
			if (num != 0)
			{
			}
			return this.e == null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004F70 File Offset: 0x00003170
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool f()
		{
			short num = (short)2017525760;
			short num2 = num;
			num = (short)828273205;
			short num3 = num;
			num = (short)386036277;
			switch (num3 == num)
			{
			}
			num = (short)2026045441;
			if (num != 0)
			{
			}
			num = (short)606863360;
			if (num != 0)
			{
			}
			return this.g;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000501C File Offset: 0x0000321C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void b(bool A_0)
		{
			short num = (short)1683554304;
			short num2 = num;
			num = (short)64141191;
			short num3 = num;
			num = (short)1295562631;
			switch (num3 == num)
			{
			}
			num = (short)1103167489;
			if (num != 0)
			{
			}
			num = (short)972423168;
			if (num != 0)
			{
			}
			this.g = A_0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000050CC File Offset: 0x000032CC
		public bool i()
		{
			short num = (short)614203392;
			switch (num)
			{
			default:
			{
				num = (short)255655936;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 1:
						num = (short)1101856770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.g())
						{
							num = (short)873857027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1438187521;
						if (num != 0)
						{
						}
						num = (short)1076822020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return false;
					case 4:
						goto IL_E6;
					}
					IL_58:
					if (this.f == 0)
					{
						return false;
					}
					num = (short)1160577024;
					short num3 = num;
					num = (short)767557633;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E6:
				bool result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_170;
					}
					byte b2;
					global::Motorola.Common.Communication.SrecType srecType;
					for (;;)
					{
						IL_131:
						byte b;
						byte[] array;
						uint address;
						switch (num2)
						{
						case 0:
							goto IL_21F;
						case 1:
							if (b != global::Motorola.Common.Communication.p.b(this.d))
							{
								num = (short)1231814667;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B4;
						case 2:
							goto IL_21F;
						case 3:
							goto IL_1B0;
						case 4:
							goto IL_21A;
						case 5:
						{
							int num4;
							int num5;
							if (num4 >= num5)
							{
								num = (short)1333461000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array[num4] = this.e();
							num4++;
							num = (short)825688066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_3DE;
						case 7:
							if (this.f())
							{
								num = (short)610926604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B4;
						case 8:
							goto IL_2EE;
						case 9:
						{
							if (b2 <= 1)
							{
								num = (short)202571779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num6 = global::Motorola.Common.Communication.o.a(srecType);
							address = this.b(num6);
							array = null;
							num = (short)1535377421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							int num6;
							int num5 = (int)(b2 - 1) - num6;
							array = new byte[num5];
							int num4 = 0;
							num = (short)105316352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							num = (short)1157824519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							result = false;
							num = (short)1241748093;
							short num7 = num;
							num = (short)173249149;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)1135542272;
								if (num != 0)
								{
								}
								num = (short)515637252;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
							if (srecType != global::Motorola.Common.Communication.SrecType.S7)
							{
								num = (short)1340407818;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2EE;
						}
						goto IL_170;
						IL_21F:
						num = (short)542441477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2EE:
						b = this.e();
						this.d = new global::Motorola.Common.Communication.SrecLine(srecType, b2, address, array, b);
						num = (short)400031745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B4:
						this.e = this.b.ReadLine();
						num = (short)1541996550;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1B0:
					throw new global::System.IO.InvalidDataException();
					IL_21A:
					return result;
					IL_3DE:
					return true;
					IL_170:
					srecType = this.d();
					b2 = this.e();
					num = (short)1599733769;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_131;
				}
				catch (global::System.Exception)
				{
					this.e = null;
					result = false;
				}
				return result;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000054E8 File Offset: 0x000036E8
		private static byte b(global::Motorola.Common.Communication.SrecLine A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			byte[] array;
			short num2;
			int num5;
			byte b;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_11A;
				case 1:
					while (array != null)
					{
						num2 = (short)228270187;
						short num3 = num2;
						num2 = (short)1137975403;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num2 = (short)177471488;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)2089091072;
						if (num2 != 0)
						{
						}
						num2 = (short)1407385602;
						num = (int)((global::System.IntPtr)num2);
						goto IL_0A;
					}
					goto IL_1BB;
				case 2:
					num5 = 0;
					num2 = (short)1447690241;
					if (num2 != 0)
					{
					}
					num2 = (short)945815552;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_11A;
				case 4:
					goto IL_14E;
				case 5:
					if (num5 >= array.Length)
					{
						num2 = (short)1648164868;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b += array[num5];
					num5++;
					num2 = (short)233832451;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_11A:
				num2 = (short)1411842053;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14E:
			IL_1BB:
			return ~b;
			IL_28:
			num5 = 0;
			b = 0;
			b += A_0.RecordLen;
			b += (byte)(A_0.Address >> 24);
			b += (byte)(A_0.Address >> 16);
			b += (byte)(A_0.Address >> 8);
			b += (byte)A_0.Address;
			array = A_0.c();
			num2 = (short)485818369;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000056B4 File Offset: 0x000038B4
		private byte e()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num2;
			short num3;
			int num5;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (num2 != -1)
					{
						num3 = (short)1257046019;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_66;
				case 1:
					goto IL_F7;
				case 2:
				{
					num3 = (short)240386048;
					short num4 = num3;
					if (num5 == -1)
					{
						num3 = (short)1425801217;
						if (num3 != 0)
						{
						}
						num3 = (short)348454913;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_147;
				}
				case 3:
					num3 = (short)1157627906;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_20;
			}
			IL_66:
			throw new global::System.IO.IOException("end of stream");
			IL_F7:
			num3 = (short)417456373;
			short num6 = num3;
			num3 = (short)704897269;
			switch ((num6 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_20:
				num2 = this.b.Read();
				num5 = this.b.Read();
				num3 = (short)262275072;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			default:
				num3 = (short)595066880;
				if (num3 != 0)
				{
				}
				goto IL_66;
			}
			IL_147:
			byte[] bytes = new byte[]
			{
				(byte)num2,
				(byte)num5
			};
			return global::System.Convert.ToByte(new global::System.Text.ASCIIEncoding().GetString(bytes), 16);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000582C File Offset: 0x00003A2C
		private uint b(int addressSize)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			uint num4;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_3A;
				case 1:
				{
					num2 = (short)1636914666;
					short num3 = num2;
					num2 = (short)1461999082;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2013200385;
						if (num2 != 0)
						{
						}
						num2 = (short)1642463232;
						if (num2 != 0)
						{
						}
						goto IL_3A;
					}
					break;
				}
				case 2:
					return num4;
				case 3:
				{
					if (num5 >= addressSize)
					{
						num2 = (short)1275068418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1582563328;
					short num6 = num2;
					byte b = this.e();
					num4 |= (uint)((uint)b << (addressSize - 1 - num5) * 8);
					num5++;
					num2 = (short)1170407425;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
				IL_3A:
				num2 = (short)954793987;
				num = (int)((global::System.IntPtr)num2);
			}
			return num4;
			IL_20:
			num4 = 0U;
			num5 = 0;
			num2 = (short)1701314560;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005978 File Offset: 0x00003B78
		private global::Motorola.Common.Communication.SrecType d()
		{
			short num = (short)2062286848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::Motorola.Common.Communication.SrecType result;
				int num4;
				int num5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						string @string;
						if (@string == "S0")
						{
							num = (short)1120993289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1259864069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1407707201;
						short num3 = num;
						num = (short)480372801;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_90;
						default:
						{
							num = (short)1702756352;
							if (num != 0)
							{
							}
							string @string;
							if (@string == "S7")
							{
								num = (short)938344455;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_262;
						}
						}
						break;
					}
					case 2:
						return result;
					case 3:
						num = (short)527040516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (num4 == -1)
						{
							num = (short)1709703179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] bytes = new byte[]
						{
							(byte)num5,
							(byte)num4
						};
						string @string = new global::System.Text.ASCIIEncoding().GetString(bytes);
						num = (short)1402077184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)675676161;
						if (num != 0)
						{
						}
						string @string;
						if (@string == "S3")
						{
							num = (short)2055995404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)496959489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_201;
					case 7:
					{
						num = (short)104398848;
						short num6 = num;
						result = global::Motorola.Common.Communication.SrecType.S7;
						num = (short)98041862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_90;
					case 9:
						result = global::Motorola.Common.Communication.SrecType.S0;
						num = (short)1190068226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_25D;
					case 11:
						goto IL_23D;
					case 12:
						result = global::Motorola.Common.Communication.SrecType.S3;
						num = (short)1456799754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63;
					IL_90:
					if (num5 == -1)
					{
						break;
					}
					num = (short)407896067;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B3:
				throw new global::System.IO.IOException("end of stream");
				IL_201:
				return result;
				IL_23D:
				goto IL_1B3;
				IL_25D:
				return result;
				IL_262:
				throw new global::System.NotImplementedException();
				IL_63:
				num5 = this.b.Read();
				num4 = this.b.Read();
				num = (short)38404104;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005C70 File Offset: 0x00003E70
		private void b()
		{
			short num = (short)538941014;
			short num2 = num;
			num = (short)137336406;
			switch (num2 == num)
			{
			}
			num = (short)1609039872;
			short num3 = num;
			num = (short)1392836609;
			if (num != 0)
			{
			}
			num = (short)359006208;
			if (num != 0)
			{
			}
			((global::System.IDisposable)this).Dispose();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005D20 File Offset: 0x00003F20
		void global::System.IDisposable.j()
		{
			short num;
			for (;;)
			{
				num = (short)825425921;
				if (num != 0)
				{
				}
				if (!this.a)
				{
					goto IL_7D;
				}
				num = (short)227129049;
				short num2 = num;
				num = (short)1664202457;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			IL_66:
			num = (short)664403968;
			if (num != 0)
			{
			}
			return;
			IL_7D:
			num = (short)601161728;
			short num3 = num;
			this.d(true);
			this.a = true;
			this.b.Dispose();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005DF4 File Offset: 0x00003FF4
		protected virtual void d(bool A_0)
		{
			short num = (short)1638596609;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9F;
				case 1:
				{
					num = (short)379387905;
					if (num != 0)
					{
					}
					num = (short)1161560064;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_80;
					}
					continue;
				}
				case 2:
				{
					num = (short)790371828;
					short num4 = num;
					num = (short)125509108;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						goto IL_F6;
					}
					break;
				}
				}
				IL_80:
				if (this.b != null)
				{
					num = (short)804651008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_9F:
				this.b.Close();
				num = (short)378011650;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			num = (short)2084962304;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400002A RID: 42
		private bool a;

		// Token: 0x0400002B RID: 43
		private global::System.IO.StringReader b;

		// Token: 0x0400002C RID: 44
		private const int c = 1;

		// Token: 0x0400002D RID: 45
		private global::Motorola.Common.Communication.SrecLine d;

		// Token: 0x0400002E RID: 46
		private string e;

		// Token: 0x0400002F RID: 47
		private int f;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;
	}
}
