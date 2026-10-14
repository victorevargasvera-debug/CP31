using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.AmpRequest;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	public class AmpHttpMessageExecutor : global::Motorola.Common.Communication.MessageExecutorBase
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00008018 File Offset: 0x00006218
		public string Port
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)128427277;
				short num2 = num;
				num = (short)160539917;
				switch (num2 == num)
				{
				}
				num = (short)179240960;
				if (num != 0)
				{
				}
				num = (short)2007236608;
				short num3 = num;
				num = (short)183042049;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000080C8 File Offset: 0x000062C8
		public string Ip
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1828781766;
				short num2 = num;
				num = (short)104726214;
				switch (num2 == num)
				{
				}
				num = (short)1679491072;
				if (num != 0)
				{
				}
				num = (short)59506688;
				short num3 = num;
				num = (short)973799425;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00008178 File Offset: 0x00006378
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00008228 File Offset: 0x00006428
		public global::System.Collections.Generic.List<byte> ChunkBuffer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)381747201;
				if (num != 0)
				{
				}
				num = (short)1251820263;
				short num2 = num;
				num = (short)1423065831;
				switch (num2 == num)
				{
				}
				num = (short)578945024;
				short num3 = num;
				num = (short)869990400;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1668697526;
				short num2 = num;
				num = (short)991514038;
				switch (num2 == num)
				{
				}
				num = (short)1651572737;
				if (num != 0)
				{
				}
				num = (short)721616896;
				short num3 = num;
				num = (short)1796341760;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000082D8 File Offset: 0x000064D8
		public AmpHttpMessageExecutor(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe, string port, string ip)
		{
			this.a = port;
			this.b = ip;
			base.CommPipe = pipe;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00008300 File Offset: 0x00006500
		protected override void validateSendBuffer(byte[] sendBuffer, int length)
		{
			short num = (short)233897985;
			if (num != 0)
			{
			}
			num = (short)479334387;
			short num2 = num;
			num = (short)978522099;
			switch (num2 == num)
			{
			}
			num = (short)781647872;
			short num3 = num;
			num = (short)2066350080;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000083A8 File Offset: 0x000065A8
		public override void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg)
		{
			short num = (short)261226516;
			short num2 = num;
			num = (short)1185218580;
			switch (num2 == num)
			{
			}
			num = (short)987693056;
			if (num != 0)
			{
			}
			num = (short)319619072;
			short num3 = num;
			num = (short)547684353;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase httpAmpMessageBase = msg as global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase;
			httpAmpMessageBase.RequestMessage.RequestUri = this.a(httpAmpMessageBase.RequestMessage.RequestUri);
			this.preSendMessage(httpAmpMessageBase);
			int num4 = httpAmpMessageBase.BuildCommandMessage(base.sendBuffer);
			this.validateSendBuffer(base.sendBuffer, num4);
			this.Execute(num4, httpAmpMessageBase);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000849C File Offset: 0x0000669C
		protected override void Execute(int sendLength, global::Motorola.Common.Communication.IMessage msg)
		{
			int a_ = 0;
			short num = (short)644874240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				object syncRoot = base.sendBuffer.SyncRoot;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_98;
					}
					global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase httpAmpMessageBase;
					for (;;)
					{
						IL_41:
						switch (num2)
						{
						case 0:
							goto IL_386;
						case 1:
							goto IL_1B2;
						case 2:
						{
							global::System.Collections.Generic.List<byte> list;
							byte[] array;
							list.AddRange(array);
							num = (short)1575813123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_2A8;
						case 4:
						{
							if (!httpAmpMessageBase.HasContent)
							{
								num = (short)1601372175;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommunicationPipe.IHttpPipe httpPipe;
							base.receiveBuffer = httpPipe.RequestData(base.sendBuffer, httpAmpMessageBase.RequestMessage.Content, 0, sendLength, msg.ReadTimeout);
							num = (short)967901201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)135069705;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>(base.receiveBuffer);
							num = (short)1652686859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::System.Collections.Generic.List<byte> list;
							httpAmpMessageBase.DecodeReplyMessage(list.ToArray(), 0, list.Count);
							num = (short)36569100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_402;
						case 8:
							goto IL_34C;
						case 9:
							httpAmpMessageBase.DecodeReplyMessage(base.receiveBuffer, 0, base.receiveBuffer.Length);
							num = (short)1591738375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							byte[] array;
							if (array != null)
							{
								num = (short)675610626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E3;
						}
						case 11:
							goto IL_2A8;
						case 12:
							goto IL_434;
						case 13:
						{
							if (base.receiveBuffer == null)
							{
								num = (short)768802816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							bool flag2 = !this.b(base.receiveBuffer);
							num = (short)1014693893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
						{
							if (httpAmpMessageBase == null)
							{
								num = (short)1646985232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommunicationPipe.IHttpPipe httpPipe = base.CommPipe as global::Motorola.Common.Communication.CommunicationPipe.IHttpPipe;
							num = (short)100990994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
						{
							num = (short)1348141057;
							if (num != 0)
							{
							}
							global::Motorola.Common.Communication.CommunicationPipe.IHttpPipe httpPipe;
							base.receiveBuffer = httpPipe.RequestData(base.sendBuffer, 0, sendLength, msg.ReadTimeout);
							num = (short)627245064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							goto IL_DB;
						case 17:
							goto IL_34C;
						case 18:
						{
							global::Motorola.Common.Communication.CommunicationPipe.IHttpPipe httpPipe;
							if (httpPipe == null)
							{
								num = (short)819265537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)952631300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
						{
							bool flag2;
							if (flag2)
							{
								num = (short)1909522438;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommunicationPipe.IHttpPipe httpPipe;
							byte[] array = httpPipe.ReceiveData();
							flag2 = this.a(array);
							num = (short)751960074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_98;
						IL_2A8:
						num = (short)965083155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_34C:
						num = (short)1117650957;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_DB:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뛯鏱鷳髵鷷黹\udcfb諽濿∁會朅笇縉Ⰻ䜍崏眑朓攕礗紙礛", a_));
					IL_1B2:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뛯鏱鷳髵鷷黹\udcfb諽濿∁會朅笇縉Ⰻ䜍匏紑礓笕洗琙甛紝䄟嘡䴣䤥䘧稩䔫席唯", a_));
					IL_1E3:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꋯ諱컳훵듷鿹鋻쏽篿㈁礃★朇砉Ⰻ栍焏笑砓猕簗", a_), new object[]
					{
						0
					});
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure);
					IL_386:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Receive_Failed);
					IL_402:
					IL_434:
					goto IL_4F2;
					IL_98:
					global::System.Threading.Monitor.Enter(syncRoot, ref flag);
					httpAmpMessageBase = (msg as global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase);
					num = (short)133234702;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_41;
				}
				finally
				{
					num = (short)292290561;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_4EF;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_46D;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(syncRoot);
							num = (short)2103115776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_46D:
						num = (short)434745749;
						short num3 = num;
						num = (short)1231860117;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4F1;
						default:
							num = (short)1242431488;
							if (num != 0)
							{
							}
							if (!flag)
							{
								goto IL_4F1;
							}
							num = (short)1872625666;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_4EF:
					IL_4F1:;
				}
				IL_4F2:
				num = (short)1623195648;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000089E4 File Offset: 0x00006BE4
		private bool b(byte[] A_0)
		{
			int a_ = 5;
			short num = (short)1006890062;
			short num2 = num;
			num = (short)1580002382;
			switch (num2 == num)
			{
			}
			num = (short)228720641;
			if (num != 0)
			{
			}
			num = (short)1004797952;
			short num3 = num;
			num = (short)1287716864;
			if (num != 0)
			{
			}
			return global::System.Text.Encoding.UTF8.GetString(A_0).Contains(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꇴ藶飸闺軼駾搀焂⠄䈆月栊戌欎砐紒爔ⴖ㤘砚甜樞传䠢䀤䌦", a_));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00008AB4 File Offset: 0x00006CB4
		private global::System.Uri a(global::System.Uri A_0)
		{
			int a_ = 14;
			short num;
			if (!A_0.IsAbsoluteUri)
			{
				num = (short)1642238669;
				short num2 = num;
				num = (short)1321571021;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)586088448;
					if (num != 0)
					{
					}
					return new global::System.UriBuilder(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("雽瓿瘁球甅", a_), this.Ip, int.Parse(this.Port), A_0.OriginalString).Uri;
				}
			}
			num = (short)1816592384;
			short num3 = num;
			num = (short)2140471297;
			if (num != 0)
			{
			}
			return A_0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00008BA0 File Offset: 0x00006DA0
		private bool a(byte[] A_0)
		{
			short num = (short)1974469269;
			short num2 = num;
			num = (short)968098453;
			switch (num2 == num)
			{
			}
			num = (short)1995571201;
			if (num != 0)
			{
			}
			num = (short)73990144;
			short num3 = num;
			num = (short)594345984;
			if (num != 0)
			{
			}
			return new global::System.ArraySegment<byte>(A_0, A_0.Length - 7, global::Motorola.Common.Communication.HttpTlsPskConstants.TailChunk.Length).ToArray<byte>().SequenceEqual(global::Motorola.Common.Communication.HttpTlsPskConstants.TailChunk);
		}

		// Token: 0x04000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x04000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;

		// Token: 0x04000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<byte> c;
	}
}
