using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using SSLMangrComp.Connectors;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000048 RID: 72
	public class UDPClientConnector : global::SSLMangrComp.Connectors.c
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0001C540 File Offset: 0x0001A740
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0001C5EC File Offset: 0x0001A7EC
		public global::SSLMangrComp.ReportOnError_CallBack ErrorCallback
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)919338254;
				short num2 = num;
				num = (short)644283662;
				switch (num2 == num)
				{
				}
				num = (short)125698049;
				if (num != 0)
				{
				}
				num = (short)427163648;
				short num3 = num;
				num = (short)52428800;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1473380353;
				if (num != 0)
				{
				}
				num = (short)574132641;
				short num2 = num;
				num = (short)868782497;
				switch (num2 == num)
				{
				}
				num = (short)589103104;
				short num3 = num;
				num = (short)392495104;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001C698 File Offset: 0x0001A898
		public void SetTimeOutVal(int secsTime)
		{
			short num = (short)605157906;
			short num2 = num;
			num = (short)500234770;
			switch (num2 == num)
			{
			}
			num = (short)728891393;
			if (num != 0)
			{
			}
			num = (short)1192034304;
			short num3 = num;
			num = (short)1546387456;
			if (num != 0)
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060001C9 RID: 457 RVA: 0x0001C744 File Offset: 0x0001A944
		// (remove) Token: 0x060001CA RID: 458 RVA: 0x0001C87C File Offset: 0x0001AA7C
		public event global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle PacketRecived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)91140123;
				short num2 = num;
				num = (short)1877192731;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6A;
				default:
					num = (short)954793984;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					break;
				}
				int num3;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				for (;;)
				{
					IL_58:
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num3)
					{
					case 0:
						goto IL_B0;
					case 1:
						num = (short)1377304577;
						if (num != 0)
						{
						}
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num = (short)1338638338;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B0;
					case 2:
						return;
					}
					goto IL_6A;
					IL_B0:
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, value);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.f, value2, packetRecivedHandle2);
					num = (short)1565261825;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6A:
				packetRecivedHandle = this.f;
				num = (short)1776156672;
				short num4 = num;
				num = (short)430768128;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)2035231160;
				short num2 = num;
				num = (short)2032347576;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_68;
				default:
					num = (short)50331648;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					break;
				}
				int num3;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				for (;;)
				{
					IL_56:
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num3)
					{
					case 0:
						goto IL_D6;
					case 1:
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num = (short)791281666;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					case 2:
						return;
					}
					goto IL_68;
					IL_D6:
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, value);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.f, value2, packetRecivedHandle2);
					num = (short)944832513;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_68:
				num = (short)1100546049;
				if (num != 0)
				{
				}
				num = (short)450101248;
				short num4 = num;
				packetRecivedHandle = this.f;
				num = (short)1180762112;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060001CB RID: 459 RVA: 0x0001C9B4 File Offset: 0x0001ABB4
		// (remove) Token: 0x060001CC RID: 460 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		public event global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle ErrorReceived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)377215740;
				short num2 = num;
				num = (short)1680988924;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8D;
				default:
					num = (short)1963458561;
					if (num != 0)
					{
					}
					num = (short)1279197184;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8D;
					}
					break;
				}
				int num3;
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
				for (;;)
				{
					IL_7B:
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					switch (num3)
					{
					case 0:
						goto IL_D6;
					case 1:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num = (short)292290562;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					case 2:
						return;
					}
					goto IL_8D;
					IL_D6:
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, value);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.g, value2, errorReceivedHandle2);
					num = (short)107610113;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_8D:
				num = (short)1996816384;
				short num4 = num;
				errorReceivedHandle = this.g;
				num = (short)1427636224;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1187021190;
				short num2 = num;
				num = (short)1155170694;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_67;
				default:
					num = (short)1115160576;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				int num3;
				global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
				for (;;)
				{
					IL_55:
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					switch (num3)
					{
					case 0:
						goto IL_AF;
					case 1:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num = (short)461570050;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF;
					case 2:
						goto IL_FF;
					}
					goto IL_67;
					IL_AF:
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value2 = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, value);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.g, value2, errorReceivedHandle2);
					num = (short)347078657;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FF:
				num = (short)38338561;
				if (num != 0)
				{
				}
				return;
				IL_67:
				errorReceivedHandle = this.g;
				num = (short)1567752192;
				short num4 = num;
				num = (short)1828716544;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001CC24 File Offset: 0x0001AE24
		public void Connect(global::System.Net.IPAddress pnIpAddress, int portNumber, global::SSLMangrComp.SecureClientConfiguration clientConfig)
		{
			short num = (short)885092652;
			short num2 = num;
			num = (short)301297964;
			switch (num2 == num)
			{
			}
			num = (short)1133117441;
			if (num != 0)
			{
			}
			num = (short)15990784;
			short num3 = num;
			num = (short)657588224;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001CCD4 File Offset: 0x0001AED4
		public void Connect(global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			short num = (short)2138177536;
			short num2 = num;
			num = (short)1823849867;
			short num3 = num;
			num = (short)370982283;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)887029760;
				if (num != 0)
				{
				}
				num = (short)1565982721;
				if (num != 0)
				{
				}
				num = (short)797573120;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::System.Net.IPAddress pnIp = connInfo.PNConnectionConfig.PnIp;
			int pnPort = connInfo.PNConnectionConfig.PnPort;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_F4;
				}
				int num4;
				for (;;)
				{
					IL_DD:
					switch (num4)
					{
					case 0:
						this.a = new global::System.Net.Sockets.UdpClient(global::System.Net.Sockets.AddressFamily.InterNetwork);
						num = (short)1821704194;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.a == null)
						{
							num = (short)579272704;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 2:
						goto IL_15A;
					case 3:
						goto IL_174;
					}
					goto IL_F4;
					IL_15A:
					num = (short)1132724227;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_174:
				return;
				IL_F4:
				this.b = pnIp;
				this.c = pnPort;
				num = (short)396492801;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_DD;
			}
			catch (global::System.ArgumentException systemException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UDPArgumentException, systemException);
			}
			catch (global::System.Net.Sockets.SocketException systemException2)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket, systemException2);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001CE90 File Offset: 0x0001B090
		public void WriteData(byte[] dataToWrite)
		{
			short num;
			try
			{
				num = (short)404131549;
				short num2 = num;
				num = (short)975736541;
				switch (num2 == num)
				{
				}
				num = (short)1193017344;
				if (num != 0)
				{
				}
				this.a.Send(dataToWrite, dataToWrite.Length, this.b.ToString(), this.c);
			}
			catch (global::System.Exception systemException)
			{
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_UDPDataSendFail, systemException);
			}
			num = (short)81526784;
			short num3 = num;
			num = (short)327221249;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001CF7C File Offset: 0x0001B17C
		public int GetPortNumber()
		{
			short num = (short)1106626960;
			short num2 = num;
			num = (short)481413520;
			switch (num2 == num)
			{
			}
			num = (short)1963982849;
			if (num != 0)
			{
			}
			num = (short)276037632;
			short num3 = num;
			num = (short)628752384;
			if (num != 0)
			{
			}
			return this.c;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001D02C File Offset: 0x0001B22C
		public void ShutdownClient()
		{
			short num = (short)288292864;
			short num2 = num;
			num = (short)1978335232;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 1:
					goto IL_EF;
				case 2:
					return;
				}
				IL_5B:
				num = (short)861011969;
				if (num != 0)
				{
				}
				if (this.a == null)
				{
					break;
				}
				num = (short)1012978845;
				short num4 = num;
				num = (short)2053100701;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)594673664;
					if (num != 0)
					{
					}
					num = (short)227606529;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_EF:
				this.a.Close();
				this.a = null;
				num = (short)1279131650;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001D16C File Offset: 0x0001B36C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(117462080 + A_1) + (global::System.IntPtr)80 + (global::System.IntPtr)18 + (global::System.IntPtr)66 + (global::System.IntPtr)59 + (global::System.IntPtr)18);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x040000FA RID: 250
		private global::System.Net.Sockets.UdpClient a;

		// Token: 0x040000FB RID: 251
		private global::System.Net.IPAddress b;

		// Token: 0x040000FC RID: 252
		private int c;

		// Token: 0x040000FD RID: 253
		private global::SSLMangrComp.PresenceInfo_CallBack d;

		// Token: 0x040000FE RID: 254
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ReportOnError_CallBack e;

		// Token: 0x040000FF RID: 255
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle f;

		// Token: 0x04000100 RID: 256
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle g;
	}
}
