using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TLS.TlsPskForAstro;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000007 RID: 7
	public class SecureTlsCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000028DC File Offset: 0x00000ADC
		public SecureTlsCommPipe(global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsHandler securityLayer)
		{
			this._securityLayer = securityLayer;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002908 File Offset: 0x00000B08
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000029B8 File Offset: 0x00000BB8
		public int ReceiveTimeout
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)844867995;
				short num2 = num;
				num = (short)1255778715;
				switch (num2 == num)
				{
				}
				num = (short)1434058752;
				short num3 = num;
				num = (short)1597440001;
				if (num != 0)
				{
				}
				num = (short)375586816;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)672517810;
				short num2 = num;
				num = (short)1876676274;
				switch (num2 == num)
				{
				}
				num = (short)380108800;
				short num3 = num;
				num = (short)459407361;
				if (num != 0)
				{
				}
				num = (short)1161035776;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002A6C File Offset: 0x00000C6C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002B28 File Offset: 0x00000D28
		public bool IsOpen
		{
			get
			{
				short num = (short)1904384432;
				short num2 = num;
				num = (short)579508656;
				switch (num2 == num)
				{
				}
				num = (short)408158208;
				short num3 = num;
				num = (short)1014300673;
				if (num != 0)
				{
				}
				num = (short)407502848;
				if (num != 0)
				{
				}
				return this._securityLayer.Pipe.IsOpen;
			}
			set
			{
				short num = (short)1073153777;
				short num2 = num;
				num = (short)485754609;
				switch (num2 == num)
				{
				}
				num = (short)1931214848;
				short num3 = num;
				num = (short)1373634560;
				if (num != 0)
				{
				}
				num = (short)193658881;
				if (num != 0)
				{
				}
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public int AvailableReadBytesCount
		{
			get
			{
				short num = (short)1806134773;
				short num2 = num;
				num = (short)679308789;
				switch (num2 == num)
				{
				}
				num = (short)1266548736;
				short num3 = num;
				num = (short)213516289;
				if (num != 0)
				{
				}
				num = (short)1031864320;
				if (num != 0)
				{
				}
				return this._securityLayer.Pipe.AvailableReadBytesCount;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002C94 File Offset: 0x00000E94
		public void OpenPort(int timeout)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)1937864726;
				short num2 = num;
				num = (short)1500215318;
				switch (num2 == num)
				{
				}
				num = (short)12976129;
				if (num != 0)
				{
				}
				num = (short)921370624;
				if (num != 0)
				{
				}
				this._securityLayer.Connect(timeout);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("砺刼儾⽀♂♄㍆⁈⑊⍌潎㥐㉒♔睖㭘㹚㡜ㅞ䅠ౢᕤɦݨ๪६", a_), global::System.Array.Empty<object>());
			}
			catch (global::System.Exception ex)
			{
				this.ClosePort();
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("砺尼儾慀ⵂ⩄㍆楈⑊㵌⩎㽐獒㙔㡖㝘㕚㡜㱞ᕠ੢੤०䝨䭪⡬ᝮተᙲմͶၸᑺ፼彾떎놐ꖔ", a_), new object[]
				{
					ex.Message
				});
				throw;
			}
			num = (short)1093206016;
			short num3 = num;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public void ClosePort()
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)1987807073;
				short num2 = num;
				num = (short)558925665;
				switch (num2 == num)
				{
				}
				num = (short)534315009;
				if (num != 0)
				{
				}
				num = (short)787349504;
				if (num != 0)
				{
				}
				this._securityLayer.Uninitialize();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ɀ⽂⩄㑆ⱈ⽊浌㡎㡐❒㵔睖㱘⍚㹜㩞ᅠᝢ౤ࡦݨ兪䵬ᑮ䅰๲啴", a_), new object[]
				{
					ex.ToString()
				});
			}
			num = (short)1290534912;
			short num3 = num;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002EAC File Offset: 0x000010AC
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			short num = (short)2088805982;
			short num2 = num;
			num = (short)1484826206;
			switch (num2 == num)
			{
			}
			num = (short)1464664064;
			short num3 = num;
			num = (short)529203200;
			if (num != 0)
			{
			}
			num = (short)802881537;
			if (num != 0)
			{
			}
			return this.RequestData(buffer, start, length);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002F60 File Offset: 0x00001160
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			int a_ = 9;
			short num = (short)1037220267;
			short num2 = num;
			num = (short)1681897899;
			switch (num2 == num)
			{
			}
			num = (short)864485376;
			short num3 = num;
			num = (short)1647116288;
			if (num != 0)
			{
			}
			num = (short)1358168065;
			if (num != 0)
			{
			}
			this.SendData(buffer, start, length);
			byte[] array = this.ReceiveData();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("椺堼尾⑀⩂㍄≆ⵈ歊⥌⹎═㉒畔⁖じ⽚㕜罞ൠ٢୤fᵨͪ䵬ᑮ䅰๲", a_), new object[]
			{
				array.Length
			});
			return array;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000304C File Offset: 0x0000124C
		public virtual void SendData(byte[] buffer, int start, int length)
		{
			short num = (short)1737267389;
			short num2 = num;
			num = (short)1731500221;
			switch (num2 == num)
			{
			}
			num = (short)1248919552;
			short num3 = num;
			num = (short)708902913;
			if (num != 0)
			{
			}
			num = (short)109772800;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			this._securityLayer.SendData(buffer, start, length);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003110 File Offset: 0x00001310
		public virtual byte[] ReceiveData()
		{
			short num = (short)203816961;
			if (num != 0)
			{
			}
			num = (short)403313902;
			short num2 = num;
			num = (short)1458509038;
			switch (num2 == num)
			{
			default:
			{
				num = (short)740818944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)77201408;
			if (num != 0)
			{
			}
			return this.ReceiveData(-1);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000031C0 File Offset: 0x000013C0
		public byte[] ReceiveData(int timeout)
		{
			short num = (short)2135677877;
			short num2 = num;
			num = (short)1455414197;
			switch (num2 == num)
			{
			}
			num = (short)660537344;
			short num3 = num;
			num = (short)1299775488;
			if (num != 0)
			{
			}
			num = (short)996343809;
			if (num != 0)
			{
			}
			int count = this.ReceiveData(this._rxBuffer, 0, timeout);
			return this._rxBuffer.Take(count).ToArray<byte>();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003288 File Offset: 0x00001488
		public int ReceiveData(byte[] buffer, int start)
		{
			short num = (short)363224536;
			short num2 = num;
			num = (short)696606168;
			switch (num2 == num)
			{
			}
			num = (short)1187315712;
			short num3 = num;
			num = (short)105840641;
			if (num != 0)
			{
			}
			num = (short)263847936;
			if (num != 0)
			{
			}
			return this.ReceiveData(buffer, start, -1);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003338 File Offset: 0x00001538
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			int a_ = 7;
			short num = (short)180486144;
			short num2 = num;
			num = (short)1922693421;
			short num3 = num;
			num = (short)401799469;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9E;
			default:
				num = (short)1781465088;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				break;
			}
			int num4;
			int num5;
			for (;;)
			{
				IL_88:
				switch (num4)
				{
				case 0:
					if (num5 > buffer.Length)
					{
						num = (short)1613496321;
						if (num != 0)
						{
						}
						num = (short)1784020995;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16D;
				case 1:
					num = (short)1366294528;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (num5 > 0)
					{
						num = (short)1333460993;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DC;
				case 3:
					goto IL_168;
				}
				goto IL_9E;
			}
			IL_DC:
			global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Receive_Failed, global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("樸帺帼䨾㍀⩂ㅄ㹆楈❊ⱌ㙎㑐⅒畔╖㱘㡚㡜㙞ᝠ٢䕤զᱨ൪୬੮Ͱ卲ᵴᙶᵸ孺ᑼᅾꮊﾐﾖ", a_));
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
			throw ex;
			IL_168:
			goto IL_DC;
			IL_16D:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("欸帺帼娾⡀㕂⁄⍆楈⽊ⱌ㭎ぐ獒≔㹖ⵘ㍚絜㍞Ѡൢɤ፦Ũ䭪ᙬ彮౰", a_), new object[]
			{
				num5
			});
			return num5;
			IL_9E:
			num5 = this._securityLayer.ReceiveData(buffer, start, timeout);
			num = (short)1998520322;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_88;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000034DC File Offset: 0x000016DC
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			int a_ = 0;
			short num = (short)841692309;
			short num2 = num;
			num = (short)388314261;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1AD:
				num = (short)2058551299;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)644284416;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A4;
				}
				break;
			}
			int num5;
			for (;;)
			{
				IL_5D:
				num = (short)250478592;
				short num4 = num;
				switch (num3)
				{
				case 0:
					goto IL_174;
				case 1:
					num = (short)1434517509;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1AD;
				case 3:
					if (num5 != expectedlength)
					{
						num = (short)843776000;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF;
				case 4:
					if (num5 > 0)
					{
						num = (short)791871489;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10F;
				case 5:
					if (num5 <= buffer.Length)
					{
						num = (short)1977942018;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10F;
				}
				goto IL_A4;
			}
			IL_10F:
			global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Receive_Failed, global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("愱儳唵䴷䠹唻䨽㤿扁⡃❅ㅇ⽉㹋湍≏㝑㝓㍕ㅗⱙ㥛繝ɟᝡɣe൧ᡩ䱫٭ᅯᙱ味ήᙷ౹ᵻችꒃ揄", a_));
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
			throw ex;
			IL_174:
			goto IL_10F;
			IL_1AF:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("怱儳唵崷匹䨻嬽␿扁⁃❅㱇⭉汋㥍㥏♑㱓癕㑗㽙㉛㥝ᑟ੡䑣ᵥ塧ᝩ", a_), new object[]
			{
				num5
			});
			return num5;
			IL_A4:
			num = (short)790036481;
			if (num != 0)
			{
			}
			num5 = this._securityLayer.ReceiveData(buffer, start, timeout, expectedlength);
			num = (short)1105985540;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5D;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000036C0 File Offset: 0x000018C0
		public byte[] PeekData(int length, int timeOut)
		{
			short num = (short)1417745339;
			short num2 = num;
			num = (short)2074547131;
			switch (num2 == num)
			{
			}
			num = (short)1772421120;
			short num3 = num;
			num = (short)2137522177;
			if (num != 0)
			{
			}
			num = (short)1925513216;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000376C File Offset: 0x0000196C
		public global::System.IO.Stream GetStream()
		{
			short num = (short)565570680;
			short num2 = num;
			num = (short)634645624;
			switch (num2 == num)
			{
			}
			num = (short)1108082688;
			short num3 = num;
			num = (short)480575489;
			if (num != 0)
			{
			}
			num = (short)1759248384;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000381C File Offset: 0x00001A1C
		public virtual bool TryEstablishSecureConnection(string psk)
		{
			int a_ = 4;
			short num;
			bool result;
			object obj;
			global::Motorola.Common.CustomException.CommonException ex;
			bool flag;
			global::Motorola.Common.CustomException.CommonException ex2;
			short num2;
			int num3;
			try
			{
				num = (short)1750204417;
				if (num != 0)
				{
				}
				result = this.a(psk);
			}
			catch when (delegate
			{
				// Failed to create a 'catch-when' expression
				ex = (obj as global::Motorola.Common.CustomException.CommonException);
				if (ex == null)
				{
					flag = false;
				}
				else
				{
					ex2 = ex;
					if (ex2.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenTimeout)
					{
						for (;;)
						{
							num = (short)298566069;
							num2 = num;
							num = (short)109363637;
							switch ((num2 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_8F;
							}
						}
						IL_8F:
						num = (short)359071744;
						if (num != 0)
						{
						}
						num3 = ((ex2.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure) ? 1 : 0);
					}
					else
					{
						num3 = 1;
					}
					flag = (num3 != 0);
				}
				endfilter(flag);
			})
			{
				global::System.InvalidOperationException ex3 = new global::System.InvalidOperationException(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("电夷吹刻儽㐿扁❃⥅♇⑉⥋ⵍ⑏牑⁓㥕硗⹙㑛㭝䁟ၡգɥŧթ䉫", a_));
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(ex3.Message, global::System.Array.Empty<object>());
				throw ex3;
			}
			catch (global::System.Exception ex4)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("攵崷夹䤻䰽┿ੁぃ㉅㡇㥉ཋ⅍㵏㽑ѓ㽕⡗㽙籛獝䁟ݡᙣᑥݧᡩ䱫ŭo᝱ᩳήᙷᵹ屻੽ꒃ꺍ﾕﶙ벛ﮝ펟횡얣쒥쒧쎩\udfab욭\uddafힱ\udab3습颷햹\udabb麽뎿ꟁꟃ독뫇꿉귍뿏병뫓돕믗껙뗛뇝軟쳡쓣ꏥ郧觩觫黭蓯鯱鯳飵싷\udaf9蟻컽緿Ⰱ␃䬅洇礉缋漍眏眑㐓洕⤗朙", a_), new object[]
				{
					global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("匵䀷", a_),
					ex4.Message
				});
				result = false;
			}
			finally
			{
				try
				{
					this._securityLayer.Pipe.ClosePort();
				}
				catch (global::System.Exception ex5)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("电夷吹᰻倽⼿㙁摃╅⑇╉㽋⭍灏≑㭓⑕ⱗ瑙籛᭝ᡟšţᙥᱧͩͫm偯άᅳյ୷᭹᭻᭽멿ꊁﾃ뚅", a_), new object[]
					{
						ex5.Message
					});
				}
			}
			num = (short)918749184;
			short num4 = num;
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003A20 File Offset: 0x00001C20
		private bool a(string psk)
		{
			int a_ = 6;
			short num;
			for (;;)
			{
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory connectClientFactory = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory();
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient identityClient = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient(this._securityLayer.Pipe, connectClientFactory);
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsHandler tlsHandler = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsHandler(this._securityLayer.Pipe, connectClientFactory, identityClient, psk);
				bool result;
				try
				{
					tlsHandler.Connect(-1);
					global::System.Diagnostics.Trace.WriteLine(base.GetType().Name + global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ᘷ缹伻䨽ℿ⁁⡃⽅㭇≉Ὃ⭍㍏❑♓㍕᭗㕙㉛そ՟šၣཥݧѩ䱫㹭Ὧqs噵ၷ᭹ཻ幽ꢇﲋﺏ뢕뚗뒙", a_));
					goto IL_3A;
				}
				catch (global::System.Exception ex)
				{
					global::System.Diagnostics.Trace.TraceError(base.GetType().Name + global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ᘷ缹伻䨽ℿ⁁⡃⽅㭇≉Ὃ⭍㍏❑♓㍕᭗㕙㉛そ՟šၣཥݧѩ䱫⭭ɯq᭳ѵ塷ṹॻ౽ꚅ黎ﮑﾕ잟芡힣쎥쮧\udfa9\udeab쮭邯톱\udbb3\ud8b5횷\udfb9\udfbb쪽ꦿ귁꫃", a_) + string.Format(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("紷䈹弻嬽〿㙁ⵃ⥅♇灉汋㕍恏⽑穓癕ᕗ㽙⽛ⵝşաţ䙥፧孩ᅫ", a_), 0, 1), new object[]
					{
						global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("崷䈹", a_),
						ex.Message
					});
					result = false;
				}
				finally
				{
					tlsHandler.Uninitialize();
				}
				return result;
				IL_3A:
				num = (short)1935819597;
				short num2 = num;
				num = (short)2096776013;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6E;
				}
			}
			IL_6E:
			num = (short)96141312;
			short num3 = num;
			num = (short)563150849;
			if (num != 0)
			{
			}
			num = (short)999686144;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x04000011 RID: 17
		protected readonly global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsHandler _securityLayer;

		// Token: 0x04000012 RID: 18
		protected const int RX_BUF_LEN = 65536;

		// Token: 0x04000013 RID: 19
		protected byte[] _rxBuffer = new byte[65536];

		// Token: 0x04000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;
	}
}
