using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200007F RID: 127
	public class XcmpReadLanguagePackInfo : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0001AF94 File Offset: 0x00019194
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0001B044 File Offset: 0x00019244
		public uint AvailableSpace
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)479470234;
				short num2 = num;
				num = (short)1185555098;
				switch (num2 == num)
				{
				}
				num = (short)1822097409;
				if (num != 0)
				{
				}
				num = (short)1190199296;
				if (num != 0)
				{
				}
				num = (short)1684209664;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1468766059;
				short num2 = num;
				num = (short)648517483;
				switch (num2 == num)
				{
				}
				num = (short)998965249;
				if (num != 0)
				{
				}
				num = (short)1691353088;
				if (num != 0)
				{
				}
				num = (short)439156736;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0001B0F4 File Offset: 0x000192F4
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0001B1A4 File Offset: 0x000193A4
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo> LanguagePackInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1826301574;
				short num2 = num;
				num = (short)1965500038;
				switch (num2 == num)
				{
				}
				num = (short)754253825;
				if (num != 0)
				{
				}
				num = (short)978190336;
				if (num != 0)
				{
				}
				num = (short)62521344;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)619184129;
				if (num != 0)
				{
				}
				num = (short)248129227;
				short num2 = num;
				num = (short)1196828363;
				switch (num2 == num)
				{
				}
				num = (short)442368000;
				if (num != 0)
				{
				}
				num = (short)1988952064;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001B254 File Offset: 0x00019454
		public XcmpReadLanguagePackInfo(global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation operation, string queryLanguangePackID = null)
		{
			if (operation == global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.SingleLanguagePack && string.IsNullOrEmpty(queryLanguangePackID))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			base.Opcode = 44;
			this.a = operation;
			this.b = queryLanguangePackID;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001B294 File Offset: 0x00019494
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)793640960;
			short num2 = num;
			num = (short)86339139;
			short num3 = num;
			num = (short)1497591363;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1358299137;
				if (num != 0)
				{
				}
				num = (short)928645120;
				if (num != 0)
				{
				}
				if (string.IsNullOrEmpty(this.b))
				{
					return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
					{
						base.Opcode,
						(byte)this.a
					});
				}
				break;
			}
			byte[] array = new byte[16];
			global::Motorola.Common.Communication.r.a(this.b, array, 0, false);
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				array
			});
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001B3BC File Offset: 0x000195BC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)845841265;
			short num2 = num;
			num = (short)1710261105;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CA:
				num = (short)940113922;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1988231168;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1434189825;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_BF;
				case 2:
					goto IL_E1;
				}
				goto IL_66;
			}
			IL_BF:
			this.a(replyBuffer, offset, length);
			goto IL_CA;
			IL_E1:
			num = (short)2036203520;
			short num4 = num;
			num = (short)982450177;
			if (num != 0)
			{
			}
			return;
			IL_66:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
			offset += global::Motorola.Common.Communication.r.b();
			num = (short)1313013760;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001B4FC File Offset: 0x000196FC
		private void a(byte[] A_0, int A_1, int A_2)
		{
			short num = (short)1011679233;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num2;
			int num4;
			int num5;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
					goto IL_13E;
				case 1:
					goto IL_9A;
				case 2:
					goto IL_9A;
				case 3:
					return;
				case 4:
					goto IL_13E;
				case 5:
					if (this.a == global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation.AllTTSLanguagePack)
					{
						num = (short)58261510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a(A_0, ref A_1, A_2);
					num = (short)527695873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)554706955;
					short num3 = num;
					num = (short)320350219;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)42860544;
						if (num != 0)
						{
						}
						this.b(A_0, ref A_1, A_2);
						num = (short)955318274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (num4 >= num5)
					{
						num = (short)1974403075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)490668037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_58;
				IL_9A:
				num = (short)1757675520;
				short num6 = num;
				num4++;
				num = (short)1164640260;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13E:
				num = (short)1526988807;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_58:
			this.AvailableSpace = global::Motorola.Common.Communication.r.b(A_0, A_1);
			A_1 += 4;
			num5 = (int)A_0[A_1];
			A_1++;
			this.LanguagePackInfo = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo>(num5);
			num4 = 0;
			num = (short)1766588416;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001B6F0 File Offset: 0x000198F0
		private void b(byte[] A_0, ref int A_1, int A_2)
		{
			short num = (short)688185006;
			short num2 = num;
			num = (short)447078062;
			switch (num2 == num)
			{
			}
			num = (short)840237057;
			if (num != 0)
			{
			}
			num = (short)986251264;
			if (num != 0)
			{
			}
			num = (short)961413120;
			short num3 = num;
			global::Motorola.Common.Communication.Rcmp.LanguagePackInfo languagePackInfo = new global::Motorola.Common.Communication.Rcmp.LanguagePackInfo();
			byte b = A_0[A_1];
			A_1++;
			languagePackInfo.PackID = global::Motorola.Common.Communication.r.a(A_0, A_1, 16);
			A_1 += 16;
			languagePackInfo.MajorVersion = global::Motorola.Common.Communication.r.b(A_0, A_1);
			A_1 += 4;
			languagePackInfo.MinorVersion = global::Motorola.Common.Communication.r.b(A_0, A_1);
			A_1 += 4;
			languagePackInfo.Size = global::Motorola.Common.Communication.r.b(A_0, A_1);
			A_1 += 4;
			languagePackInfo.TTSLanguageCode = global::Motorola.Common.Communication.r.a(A_0, A_1, 12);
			A_1 += 12;
			languagePackInfo.TTSVoiceGender = A_0[A_1];
			A_1++;
			languagePackInfo.TTSSpeakerNameSize = (uint)A_0[A_1];
			A_1++;
			int ttsspeakerNameSize = (int)languagePackInfo.TTSSpeakerNameSize;
			languagePackInfo.TTSSpeakerName = global::Motorola.Common.Communication.r.a(A_0, A_1, ttsspeakerNameSize);
			A_1 += ttsspeakerNameSize;
			languagePackInfo.TTSNameSize = (uint)A_0[A_1];
			A_1++;
			int ttsnameSize = (int)languagePackInfo.TTSNameSize;
			languagePackInfo.Name = global::Motorola.Common.Communication.r.a(A_0, A_1, ttsnameSize);
			A_1 += ttsnameSize;
			this.LanguagePackInfo.Add(languagePackInfo);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001B888 File Offset: 0x00019A88
		private void a(byte[] A_0, ref int A_1, int A_2)
		{
			short num = (short)1765999804;
			short num2 = num;
			num = (short)1979778236;
			switch (num2 == num)
			{
			}
			num = (short)1656750080;
			if (num != 0)
			{
			}
			num = (short)613351425;
			if (num != 0)
			{
			}
			num = (short)1086259200;
			short num3 = num;
			global::Motorola.Common.Communication.Rcmp.LanguagePackInfo languagePackInfo = new global::Motorola.Common.Communication.Rcmp.LanguagePackInfo();
			int num4 = (int)A_0[A_1];
			A_1++;
			languagePackInfo.PackID = global::Motorola.Common.Communication.r.a(A_0, A_1, 16);
			A_1 += 16;
			languagePackInfo.MajorVersion = global::Motorola.Common.Communication.r.b(A_0, A_1);
			A_1 += 4;
			languagePackInfo.MinorVersion = global::Motorola.Common.Communication.r.b(A_0, A_1);
			A_1 += 4;
			languagePackInfo.Size = global::Motorola.Common.Communication.r.b(A_0, A_1);
			A_1 += 4;
			int num5 = num4 - 29;
			languagePackInfo.Name = global::Motorola.Common.Communication.r.a(A_0, A_1, num5);
			A_1 += num5;
			this.LanguagePackInfo.Add(languagePackInfo);
		}

		// Token: 0x04000284 RID: 644
		private global::Motorola.Common.Communication.Rcmp.ReadLanguagePackInfoOperation a;

		// Token: 0x04000285 RID: 645
		private string b;

		// Token: 0x04000286 RID: 646
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private uint c;

		// Token: 0x04000287 RID: 647
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Rcmp.LanguagePackInfo> d;
	}
}
