using System;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000078 RID: 120
	public class XcmpModuleInfo : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00019E08 File Offset: 0x00018008
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00019EB8 File Offset: 0x000180B8
		public string MacAddressPort1
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1344143360;
				short num2 = num;
				num = (short)2043089017;
				short num3 = num;
				num = (short)1436291193;
				switch (num3 == num)
				{
				}
				num = (short)1587609601;
				if (num != 0)
				{
				}
				num = (short)2086797312;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)114163712;
				short num2 = num;
				num = (short)1022230529;
				if (num != 0)
				{
				}
				num = (short)293581336;
				short num3 = num;
				num = (short)2054337048;
				switch (num3 == num)
				{
				}
				num = (short)898039808;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00019F68 File Offset: 0x00018168
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0001A018 File Offset: 0x00018218
		public string MacAddressPort2
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1734410240;
				short num2 = num;
				num = (short)469762049;
				if (num != 0)
				{
				}
				num = (short)1454743688;
				short num3 = num;
				num = (short)1038459016;
				switch (num3 == num)
				{
				}
				num = (short)451674112;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)140836864;
				short num2 = num;
				num = (short)609484801;
				if (num != 0)
				{
				}
				num = (short)1293832123;
				short num3 = num;
				num = (short)1009864635;
				switch (num3 == num)
				{
				}
				num = (short)1302331392;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0001A0C8 File Offset: 0x000182C8
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0001A178 File Offset: 0x00018378
		public string WIFIMacAddressPort1
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1918697472;
				short num2 = num;
				num = (short)2144390724;
				short num3 = num;
				num = (short)327077444;
				switch (num3 == num)
				{
				}
				num = (short)350027777;
				if (num != 0)
				{
				}
				num = (short)1165492224;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1016397824;
				short num2 = num;
				num = (short)119247736;
				short num3 = num;
				num = (short)1545966456;
				switch (num3 == num)
				{
				}
				num = (short)1430061057;
				if (num != 0)
				{
				}
				num = (short)2000158720;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0001A224 File Offset: 0x00018424
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0001A2D4 File Offset: 0x000184D4
		public string WIFIMacAddressPort2
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)369491968;
				short num2 = num;
				num = (short)1112719211;
				short num3 = num;
				num = (short)331988843;
				switch (num3 == num)
				{
				}
				num = (short)1529937921;
				if (num != 0)
				{
				}
				num = (short)716898304;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2077687808;
				short num2 = num;
				num = (short)1871249409;
				if (num != 0)
				{
				}
				num = (short)605974852;
				short num3 = num;
				num = (short)1025798468;
				switch (num3 == num)
				{
				}
				num = (short)1979383808;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001A384 File Offset: 0x00018584
		public XcmpModuleInfo(global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.FunctionType function, global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.ModuleID modeleID, global::Motorola.Common.Communication.Rcmp.XcmpModuleInfo.DataType dataType, byte datasize, byte[] dataValue)
		{
			base.Opcode = 1121;
			this.d = (byte)function;
			this.e = (byte)modeleID;
			this.f = (byte)dataType;
			this.g = datasize;
			this.h = dataValue;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001A3C8 File Offset: 0x000185C8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			while (this.e != 3)
			{
				short num = (short)931659776;
				short num2 = num;
				num = (short)1906979064;
				short num3 = num;
				num = (short)63254776;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1119092736;
					if (num != 0)
					{
					}
					num = (short)636616705;
					if (num != 0)
					{
					}
					return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
					{
						base.Opcode,
						this.d,
						this.e,
						this.f,
						this.g,
						this.h
					});
				}
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.d,
				this.e,
				this.f
			});
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001A520 File Offset: 0x00018720
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 12;
			short num = (short)1408499712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_C8;
				}
				for (;;)
				{
					IL_31:
					int num7;
					switch (num2)
					{
					case 0:
					{
						string text;
						if (text.Substring(0, 2) == global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ꢗꢙ", a_))
						{
							num = (short)136445953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_336;
					}
					case 1:
					{
						string text;
						this.MacAddressPort2 = text.Substring(3);
						num = (short)538116116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (this.d == 0)
						{
							num = (short)57016351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						string text;
						if (text.Substring(0, 2) == global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ꢗꢙ", a_))
						{
							num = (short)634978329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_376;
					}
					case 4:
						if (this.e == 6)
						{
							num = (short)1262485531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (length > global::Motorola.Common.Communication.r.b())
						{
							num = (short)1135673357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_376;
					case 7:
					{
						num = (short)21105504;
						short num3 = num;
						num = (short)1057295200;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5BE;
						default:
						{
							num = (short)2000093184;
							short num4 = num;
							num = (short)1970012160;
							if (num != 0)
							{
							}
							num = (short)1428881412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 8:
					{
						int num5 = 0;
						object[] array;
						int.TryParse(array[3].ToString(), out num5);
						int num6 = num5 / 6;
						num = (short)355663906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						string text;
						this.MacAddressPort1 = text.Substring(3);
						num = (short)1973616662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1532035077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)2015821857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (this.e == 6)
						{
							num = (short)627310627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_376;
					case 13:
					{
						object[] array = new object[]
						{
							global::Motorola.Common.Communication.r.b,
							global::Motorola.Common.Communication.r.b,
							global::Motorola.Common.Communication.r.b,
							global::Motorola.Common.Communication.r.b,
							global::Motorola.Common.Communication.r.c
						};
						global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
						num = (short)102825986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						return;
					case 15:
						goto IL_461;
					case 16:
						if (this.e == 1)
						{
							num = (short)77856779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_336;
					case 17:
						if (this.g == 1)
						{
							num = (short)664403998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						if (this.e != 1)
						{
							num = (short)919339015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53F;
					case 19:
					{
						int num6;
						if (num7 >= num6)
						{
							num = (short)629669902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object[] array;
						string text = global::System.BitConverter.ToString(array[4] as byte[], num7 * 6 + num7, 7);
						goto IL_5BE;
					}
					case 20:
						goto IL_336;
					case 21:
						num7 = 0;
						num = (short)1175388175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_336;
					case 23:
					{
						string text;
						if (text.Substring(0, 2) == global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ꢗꮙ", a_))
						{
							num = (short)262799384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2039283715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						string text;
						this.WIFIMacAddressPort1 = text.Substring(3);
						num = (short)1658191904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						string text;
						this.WIFIMacAddressPort2 = text.Substring(3);
						num = (short)455933958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num = (short)1952448513;
							if (num != 0)
							{
							}
							num = (short)637206538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						goto IL_53F;
					case 28:
						goto IL_461;
					case 29:
						if (this.h[0] == 0)
						{
							num = (short)307625992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 30:
						num = (short)1998192669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1411317777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_376;
					case 33:
					{
						string text;
						if (text.Substring(0, 2) == global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ꢗꮙ", a_))
						{
							num = (short)1305739273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2087387136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
					{
						int num6;
						if (num6 >= 1)
						{
							num = (short)681050133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 35:
						num = (short)1729888279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C8;
					IL_336:
					num = (short)1151467532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_376:
					num7++;
					num = (short)1917321244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_461:
					num = (short)277217299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53F:
					num = (short)1428291610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5BE:
					num = (short)1762131984;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_C8:
				base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
				num = (short)1005518866;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x0400024F RID: 591
		private const int a = 6;

		// Token: 0x04000250 RID: 592
		private const string b = "01";

		// Token: 0x04000251 RID: 593
		private const string c = "02";

		// Token: 0x04000252 RID: 594
		private byte d;

		// Token: 0x04000253 RID: 595
		private byte e;

		// Token: 0x04000254 RID: 596
		private byte f;

		// Token: 0x04000255 RID: 597
		private byte g;

		// Token: 0x04000256 RID: 598
		private byte[] h;

		// Token: 0x04000257 RID: 599
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string i;

		// Token: 0x04000258 RID: 600
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string j;

		// Token: 0x04000259 RID: 601
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string k;

		// Token: 0x0400025A RID: 602
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string l;

		// Token: 0x02000079 RID: 121
		public enum FunctionType : byte
		{
			// Token: 0x0400025C RID: 604
			Read,
			// Token: 0x0400025D RID: 605
			Write,
			// Token: 0x0400025E RID: 606
			Lock,
			// Token: 0x0400025F RID: 607
			UnLock
		}

		// Token: 0x0200007A RID: 122
		public enum ModuleID : byte
		{
			// Token: 0x04000261 RID: 609
			Device,
			// Token: 0x04000262 RID: 610
			Modem,
			// Token: 0x04000263 RID: 611
			PowerSupply,
			// Token: 0x04000264 RID: 612
			PowerAmplifier,
			// Token: 0x04000265 RID: 613
			FrontPanel,
			// Token: 0x04000266 RID: 614
			WirelineBoard,
			// Token: 0x04000267 RID: 615
			ExpansionBoard
		}

		// Token: 0x0200007B RID: 123
		public enum DataType : byte
		{
			// Token: 0x04000269 RID: 617
			SerialNumber,
			// Token: 0x0400026A RID: 618
			VendorIdentifier,
			// Token: 0x0400026B RID: 619
			KitNumber,
			// Token: 0x0400026C RID: 620
			RepeaterIdentifier,
			// Token: 0x0400026D RID: 621
			BuildDate,
			// Token: 0x0400026E RID: 622
			LastModifiedDate,
			// Token: 0x0400026F RID: 623
			InUseDate,
			// Token: 0x04000270 RID: 624
			HardwareVersion,
			// Token: 0x04000271 RID: 625
			SoftwareVersion,
			// Token: 0x04000272 RID: 626
			MACAddress,
			// Token: 0x04000273 RID: 627
			DeviceType,
			// Token: 0x04000274 RID: 628
			VendorBuildLocation
		}
	}
}
