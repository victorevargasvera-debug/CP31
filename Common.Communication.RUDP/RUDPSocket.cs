using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200001A RID: 26
	public class RUDPSocket : global::System.IDisposable
	{
		// Token: 0x0600013A RID: 314 RVA: 0x000157F0 File Offset: 0x000139F0
		public RUDPSocket()
		{
			this.a = new global::Motorola.Common.Communication.RUDP.b(this);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00015810 File Offset: 0x00013A10
		public global::Motorola.Common.Communication.RUDP.RUDPSockState State
		{
			get
			{
				short num = (short)845479936;
				short num2 = num;
				num = (short)892534785;
				if (num != 0)
				{
				}
				num = (short)1471791959;
				short num3 = num;
				num = (short)1878508375;
				switch (num3 == num)
				{
				}
				num = (short)379322368;
				if (num != 0)
				{
				}
				return this.a.ai();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000158C4 File Offset: 0x00013AC4
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00015978 File Offset: 0x00013B78
		private int SendTimeout
		{
			get
			{
				short num = (short)609615872;
				short num2 = num;
				num = (short)2114060289;
				if (num != 0)
				{
				}
				num = (short)135235249;
				short num3 = num;
				num = (short)825919153;
				switch (num3 == num)
				{
				}
				num = (short)814219264;
				if (num != 0)
				{
				}
				return this.a.aj();
			}
			set
			{
				short num = (short)1945305088;
				short num2 = num;
				num = (short)1010357644;
				short num3 = num;
				num = (short)31774092;
				switch (num3 == num)
				{
				}
				num = (short)976486401;
				if (num != 0)
				{
				}
				num = (short)1613365248;
				if (num != 0)
				{
				}
				this.a.o(value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00015A30 File Offset: 0x00013C30
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00015AE8 File Offset: 0x00013CE8
		public int ReceiveTimeout
		{
			private get
			{
				short num = (short)1088290816;
				short num2 = num;
				num = (short)805313255;
				short num3 = num;
				num = (short)303504103;
				switch (num3 == num)
				{
				}
				num = (short)1810759681;
				if (num != 0)
				{
				}
				num = (short)381747200;
				if (num != 0)
				{
				}
				return this.a.ak();
			}
			set
			{
				short num = (short)582746112;
				short num2 = num;
				num = (short)1740040677;
				short num3 = num;
				num = (short)1395386853;
				switch (num3 == num)
				{
				}
				num = (short)1116733440;
				if (num != 0)
				{
				}
				num = (short)1230110721;
				if (num != 0)
				{
				}
				this.a.p(value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00015B9C File Offset: 0x00013D9C
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00015C50 File Offset: 0x00013E50
		public int OpenTimeout
		{
			private get
			{
				short num = (short)1363869696;
				short num2 = num;
				num = (short)1033895105;
				short num3 = num;
				num = (short)1999568065;
				switch (num3 == num)
				{
				}
				num = (short)1265041409;
				if (num != 0)
				{
				}
				num = (short)846659584;
				if (num != 0)
				{
				}
				return this.a.al();
			}
			set
			{
				short num = (short)172163072;
				short num2 = num;
				num = (short)271317535;
				short num3 = num;
				num = (short)1298070047;
				switch (num3 == num)
				{
				}
				num = (short)1268711425;
				if (num != 0)
				{
				}
				num = (short)107937792;
				if (num != 0)
				{
				}
				this.a.q(value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00015D04 File Offset: 0x00013F04
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00015DBC File Offset: 0x00013FBC
		private int CloseTimeout
		{
			get
			{
				short num = (short)315031552;
				short num2 = num;
				num = (short)1427435236;
				short num3 = num;
				num = (short)474476260;
				switch (num3 == num)
				{
				}
				num = (short)89391105;
				if (num != 0)
				{
				}
				num = (short)716111872;
				if (num != 0)
				{
				}
				return this.a.am();
			}
			set
			{
				short num = (short)70057984;
				short num2 = num;
				num = (short)123431828;
				short num3 = num;
				num = (short)256666516;
				switch (num3 == num)
				{
				}
				num = (short)595329024;
				if (num != 0)
				{
				}
				num = (short)946143233;
				if (num != 0)
				{
				}
				this.a.s(value);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00015E70 File Offset: 0x00014070
		private static int d()
		{
			short num = (short)7602176;
			short num2 = num;
			num = (short)350500222;
			short num3 = num;
			num = (short)953890174;
			switch (num3 == num)
			{
			}
			num = (short)969080833;
			if (num != 0)
			{
			}
			num = (short)2088763392;
			if (num != 0)
			{
			}
			return 1;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00015F1C File Offset: 0x0001411C
		private static int c()
		{
			short num = (short)1907490816;
			short num2 = num;
			num = (short)1632829441;
			if (num != 0)
			{
			}
			num = (short)329017651;
			short num3 = num;
			num = (short)1971349811;
			switch (num3 == num)
			{
			}
			num = (short)932839424;
			if (num != 0)
			{
			}
			return 1;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00015FC8 File Offset: 0x000141C8
		private static int b()
		{
			short num = (short)849084416;
			short num2 = num;
			num = (short)429547841;
			short num3 = num;
			num = (short)1176330561;
			switch (num3 == num)
			{
			}
			num = (short)1932066816;
			if (num != 0)
			{
			}
			num = (short)329842689;
			if (num != 0)
			{
			}
			return 1;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00016070 File Offset: 0x00014270
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult Connect(global::System.Net.IPAddress ipAddr, int port)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.RUDP.RUDPReplyResult rudpreplyResult;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("瀰挲攴᜶欸帺䰼䨾⑀あㅄ絆楈ࡊ≌ⅎ㽐㙒㙔⍖じ㕚㩜罞ᕠౢ䕤ᱦ奨ᙪ坬ᑮ䁰๲孴奶坸㽺㉼ㅾ쒀", a_), new object[]
					{
						ipAddr.ToString(),
						port
					});
					num2 = (short)465895427;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.a != null)
					{
						num2 = (short)414908420;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
				case 2:
					for (;;)
					{
						num2 = (short)2135752704;
						short num3 = num2;
						if (rudpreplyResult != global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success)
						{
							break;
						}
						num2 = (short)2085127168;
						short num4 = num2;
						num2 = (short)86148096;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_1FF;
						}
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("瀰挲攴᜶欸帺䰼䨾⑀あㅄ絆楈ࡊ≌ⅎ㽐㙒㙔⍖じ㕚㩜罞ᕠౢ䕤ᱦ奨ᙪ坬ᑮ䁰๲孴奶坸㵺㱼㙾춀", a_), new object[]
					{
						ipAddr.ToString(),
						port
					});
					num2 = (short)1467416581;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1FF:
					num2 = (short)1603993600;
					if (num2 != 0)
					{
					}
					num2 = (short)959840257;
					if (num2 != 0)
					{
					}
					num2 = (short)807731200;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return rudpreplyResult;
				case 4:
				{
					global::System.IAsyncResult a_2 = this.a.m(ipAddr, port, null, null);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("瀰挲攴᜶欸帺䰼䨾⑀あㅄ絆楈ࡊ≌ⅎ㽐㙒㙔⍖じ㕚㩜罞ᕠౢ䕤ᱦ奨ᙪ坬ᑮ䁰๲孴奶坸㍺㱼ㅾ얀킂춄욆슈슊쎌좎", a_), new object[]
					{
						ipAddr.ToString(),
						port
					});
					rudpreplyResult = this.a.n(a_2);
					num2 = (short)1405353986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					return rudpreplyResult;
				}
				goto IL_31;
			}
			return rudpreplyResult;
			IL_31:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("瀰挲攴᜶欸帺䰼䨾⑀あㅄ絆楈ࡊ≌ⅎ㽐㙒㙔⍖じ㕚㩜罞ᕠౢ䕤ᱦ奨ᙪ坬ᑮ䁰๲孴奶坸㉺㍼㙾햀", a_), new object[]
			{
				ipAddr.ToString(),
				port
			});
			num2 = (short)665976833;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000162DC File Offset: 0x000144DC
		public int Send(byte[] buffer, int offset, int size, out global::Motorola.Common.Communication.RUDP.RUDPReplyResult result)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return num2;
				case 1:
					if (this.a != null)
					{
						num3 = (short)742981634;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
					num3 = (short)899547136;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_FB;
				}
				goto IL_25;
			}
			IL_FB:
			try
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("✭㤯㬱㴳㼵ㄷ㌹㔻㜽䤿䭁䵃", a_), global::System.Array.Empty<object>());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("漭怯戱ᐳ搵崷䬹䤻嬽㌿㙁繃晅ᭇ⽉≋⩍㥏㱑㍓癕㑗㽙㉛捝᭟剡ᥣ䡥䙧䑩", a_), new object[]
				{
					size
				});
				global::System.IAsyncResult a_2 = this.a.m(buffer, offset, size, null, null);
				num2 = this.a.p(a_2);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("漭怯戱ᐳ搵崷䬹䤻嬽㌿㙁繃晅ᭇ⽉≋㩍灏㹑ㅓ㡕敗⅙汛⍝也䱡䩣≥❧⑩⥫", a_), new object[]
				{
					num2
				});
			}
			catch (global::System.Exception)
			{
				result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_SendFailed;
			}
			return num2;
			IL_25:
			num3 = (short)329485798;
			short num4 = num3;
			num3 = (short)977833446;
			switch ((num4 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			case 1:
				break;
			default:
			{
				num3 = (short)1402077184;
				short num5 = num3;
				break;
			}
			}
			num3 = (short)1824260097;
			if (num3 != 0)
			{
			}
			num3 = (short)723714048;
			if (num3 != 0)
			{
			}
			num2 = 0;
			result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
			num3 = (short)975765505;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000164AC File Offset: 0x000146AC
		public byte[] Receive(out global::Motorola.Common.Communication.RUDP.RUDPReplyResult result)
		{
			int a_ = 9;
			short num = (short)1836384256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_97;
					case 1:
						if (this.a != null)
						{
							num = (short)1644691458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
						num = (short)1183711232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_7D;
					}
					goto IL_43;
				}
				IL_7D:
				byte[] array2;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_11F;
					}
					object obj;
					for (;;)
					{
						IL_F8:
						switch (num2)
						{
						case 0:
						{
							byte[] array;
							if ((array = (obj as byte[])) != null)
							{
								goto IL_280;
							}
							goto IL_192;
						}
						case 1:
							goto IL_2C8;
						case 2:
							result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ReceiveTimeout;
							num = (short)203489287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (obj is int)
							{
								num = (short)815857666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1120468992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							byte[] array;
							array2 = array;
							num = (short)486255752;
							short num3 = num;
							num = (short)1100917896;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_280;
							default:
								num = (short)1620246528;
								if (num != 0)
								{
								}
								num = (short)1501822981;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_192;
						case 6:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("氬缮愰ጲ朴制䠸为堼䰾㕀祂敄ᕆⱈ⡊⡌♎❐㙒ㅔ睖㕘㹚㍜扞᩠卢ᡤ䥦䝨䕪⥬⁮㽰㙲", a_), new object[]
							{
								(array2 == null) ? 0 : array2.Length
							});
							num = (short)996343809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_192;
						}
						goto IL_11F;
						IL_192:
						num = (short)1244856326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_280:
						num = (short)2004942852;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C8:
					return array2;
					IL_11F:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("氬缮愰ጲ朴制䠸为堼䰾㕀祂敄ᕆⱈ⡊⡌♎❐㙒畔㭖㱘㕚恜煞你䵢Ɽ⥦⁨㽪", a_), global::System.Array.Empty<object>());
					global::System.IAsyncResult a_2 = this.a.n(null, null);
					obj = this.a.q(a_2);
					num = (short)1216544771;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_F8;
				}
				catch (global::System.Exception)
				{
					result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ReceiveFailed;
				}
				return array2;
				IL_97:
				num = (short)372178945;
				if (num != 0)
				{
				}
				num = (short)868810752;
				short num4 = num;
				return array2;
				IL_43:
				array2 = null;
				result = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
				num = (short)26738689;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000167A8 File Offset: 0x000149A8
		private int a(byte[] A_0, int A_1, int A_2, out global::Motorola.Common.Communication.RUDP.RUDPReplyResult A_3)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return num2;
				case 1:
					num3 = (short)356581377;
					if (num3 != 0)
					{
					}
					if (this.a != null)
					{
						num3 = (short)80478210;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					A_3 = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
					num3 = (short)1758265344;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_FD;
				}
				goto IL_25;
			}
			IL_FD:
			try
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("焯戱搳ᘵ樷弹䴻䬽┿ㅁぃ籅桇ᡉ⥋ⵍ㕏㭑≓㍕硗㙙㥛そ嵟ᥡ呣᭥䙧䑩䉫", a_), new object[]
				{
					A_2
				});
				global::System.IAsyncResult a_2 = this.a.n(A_0, A_1, A_2, null, null);
				num2 = (int)this.a.q(a_2);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("焯戱搳ᘵ樷弹䴻䬽┿ㅁぃ籅桇ᡉ⥋ⵍ㕏㭑≓㍕㱗穙せ㭝๟彡ὣ噥ᕧ䑩䉫䁭㑯㵱㩳㍵", a_), new object[]
				{
					num2
				});
			}
			catch (global::System.Exception)
			{
				A_3 = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_ReceiveFailed;
			}
			return num2;
			IL_25:
			num3 = (short)1500738759;
			short num4 = num3;
			num3 = (short)893285575;
			switch ((num4 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			case 1:
				break;
			default:
			{
				num3 = (short)52822016;
				short num5 = num3;
				break;
			}
			}
			num3 = (short)1318518784;
			if (num3 != 0)
			{
			}
			num2 = 0;
			A_3 = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
			num3 = (short)1869217793;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00016960 File Offset: 0x00014B60
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult Close()
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.RUDP.RUDPReplyResult rudpreplyResult;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (this.State == global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE_WAIT)
					{
						num2 = (short)1113194505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.IAsyncResult a_2 = this.a.m(null, null);
					rudpreplyResult = this.a.o(a_2);
					num2 = (short)335872011;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					rudpreplyResult = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success;
					num2 = (short)1846542343;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (this.State == global::Motorola.Common.Communication.RUDP.RUDPSockState.CLOSE)
					{
						num2 = (short)1750204417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1814560768;
					short num3 = num2;
					num2 = (short)460324864;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return rudpreplyResult;
				case 4:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("攣瘥砧਩縫䬭䄯䜱儳䔵䰷9᰻紽ⰿⵁ㝃⍅桇㹉⑋⭍灏ㅑ㭓㡕㙗㽙㽛⩝य़ൡ੣䡥䙧䑩⡫Ⅽ㹯㝱", a_), global::System.Array.Empty<object>());
					num2 = (short)1394802691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_223;
				case 6:
					num2 = (short)377815042;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_223;
				case 8:
					if (this.a != null)
					{
						num2 = (short)863109126;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
				case 9:
					goto IL_2DF;
				case 10:
				{
					if (rudpreplyResult == global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Success)
					{
						num2 = (short)917831684;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("攣瘥砧਩縫䬭䄯䜱儳䔵䰷9᰻紽⼿ⱁ⩃⍅⭇㹉╋⁍㝏牑⁓㹕㵗穙㽛ㅝ๟ౡţեᱧͩͫm幯山婳ふ㥷㍹ほ", a_), global::System.Array.Empty<object>());
					num2 = (short)63686901;
					short num4 = num2;
					num2 = (short)1583270133;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2DF;
					default:
						num2 = (short)727252992;
						if (num2 != 0)
						{
						}
						num2 = (short)475725836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					goto IL_223;
				case 12:
					return rudpreplyResult;
				}
				goto IL_4D;
				IL_223:
				num2 = (short)2084569098;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DF:
				rudpreplyResult = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_CloseInProgress;
				num2 = (short)272171013;
				num = (int)((global::System.IntPtr)num2);
			}
			return rudpreplyResult;
			IL_4D:
			num2 = (short)631635969;
			if (num2 != 0)
			{
			}
			rudpreplyResult = global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("攣瘥砧਩縫䬭䄯䜱儳䔵䰷9᰻紽ⰿⵁ㝃⍅桇㹉⑋⭍灏ㅑ㭓㡕㙗㽙㽛⩝य़ൡ੣䡥䙧䑩╫⁭㥯♱", a_), global::System.Array.Empty<object>());
			num2 = (short)1830944776;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00016C54 File Offset: 0x00014E54
		public global::Motorola.Common.Communication.RUDP.RUDPReplyResult SetSocketOpt(global::Motorola.Common.Communication.RUDP.RUDPConfigParams configParams)
		{
			short num = (short)421265409;
			if (num != 0)
			{
			}
			if (this.a != null)
			{
				num = (short)1138875153;
				short num2 = num;
				num = (short)59955985;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)591396864;
					short num3 = num;
					num = (short)101974016;
					if (num != 0)
					{
					}
					return this.a.m(configParams);
				}
				}
			}
			return global::Motorola.Common.Communication.RUDP.RUDPReplyResult.RUDPReply_Uninitialized;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00016D1C File Offset: 0x00014F1C
		private global::Motorola.Common.Communication.RUDP.RUDPConfigParams a()
		{
			short num = (short)1622016000;
			short num2 = num;
			num = (short)1660299728;
			short num3 = num;
			num = (short)1101146576;
			switch (num3 == num)
			{
			}
			num = (short)1488846849;
			if (num != 0)
			{
			}
			num = (short)1192689664;
			if (num != 0)
			{
			}
			return this.a.an();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00016DD4 File Offset: 0x00014FD4
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1613758465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E0;
				case 1:
				{
					num = (short)13337492;
					short num3 = num;
					num = (short)324305812;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						num = (short)1895628800;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					break;
				}
				case 2:
					this.b = true;
					num = (short)1218248704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7B:
				num = (short)2050686976;
				short num4 = num;
				if (this.b)
				{
					break;
				}
				num = (short)1613430786;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E0:
			IL_E2:
			num = (short)75628545;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00016EF0 File Offset: 0x000150F0
		public void Dispose()
		{
			short num = (short)1223353707;
			short num2 = num;
			num = (short)1319167339;
			switch (num2 == num)
			{
			}
			num = (short)1882849280;
			if (num != 0)
			{
			}
			num = (short)1892548608;
			short num3 = num;
			num = (short)1650982913;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00016FA4 File Offset: 0x000151A4
		internal static string i(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(644211306 + A_1) + (global::System.IntPtr)70 + (global::System.IntPtr)21 + (global::System.IntPtr)40 + (global::System.IntPtr)54);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
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
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x040000B2 RID: 178
		private global::Motorola.Common.Communication.RUDP.b a;

		// Token: 0x040000B3 RID: 179
		private bool b;
	}
}
