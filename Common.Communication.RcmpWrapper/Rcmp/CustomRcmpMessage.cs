using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000029 RID: 41
	public class CustomRcmpMessage : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00009AC8 File Offset: 0x00007CC8
		public CustomRcmpMessage(byte[] messageBuffer)
		{
			this.a = messageBuffer;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00009AE4 File Offset: 0x00007CE4
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00009B98 File Offset: 0x00007D98
		private byte[] CommandBuffer
		{
			get
			{
				short num = (short)1919462649;
				short num2 = num;
				num = (short)1344253177;
				switch (num2 == num)
				{
				}
				num = (short)120193024;
				short num3 = num;
				num = (short)279445505;
				if (num != 0)
				{
				}
				num = (short)922943488;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1363555319;
				short num2 = num;
				num = (short)1031091191;
				switch (num2 == num)
				{
				}
				num = (short)364707840;
				short num3 = num;
				num = (short)1328939008;
				if (num != 0)
				{
				}
				num = (short)1665204225;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00009C48 File Offset: 0x00007E48
		public byte[] ReplyBuffer
		{
			get
			{
				short num = (short)866679270;
				short num2 = num;
				num = (short)905148902;
				switch (num2 == num)
				{
				}
				num = (short)995753984;
				short num3 = num;
				num = (short)1801060353;
				if (num != 0)
				{
				}
				num = (short)274202624;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00009CF8 File Offset: 0x00007EF8
		private new static global::Motorola.Common.Communication.RcmpReplyResult ReplyResult
		{
			get
			{
				int a_ = 12;
				short num = (short)2052142281;
				short num2 = num;
				num = (short)1198273737;
				switch (num2 == num)
				{
				}
				num = (short)469696512;
				short num3 = num;
				num = (short)944046081;
				if (num != 0)
				{
				}
				num = (short)149028864;
				if (num != 0)
				{
				}
				throw new global::System.NotSupportedException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\udb97쾟쾡얥얧\udaa9쮭쎯솱햳통\uddb7骹\ud8bb톽ꖿ뇁ꣅꟇ뻉뻍뇏ꃑꟓ돕껙듛믝샟郡臣雥蓧鏩싫", a_));
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009DBC File Offset: 0x00007FBC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)631767041;
			if (num != 0)
			{
			}
			num = (short)737147932;
			short num2 = num;
			num = (short)1869872156;
			switch (num2 == num)
			{
			default:
			{
				num = (short)141099008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)850984960;
			if (num != 0)
			{
			}
			global::System.Array.Copy(this.a, 0, buffer, offset, this.a.Length);
			return this.a.Length;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009E84 File Offset: 0x00008084
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)654165454;
			short num2 = num;
			num = (short)61457870;
			switch (num2 == num)
			{
			}
			num = (short)1766260736;
			short num3 = num;
			num = (short)915996672;
			if (num != 0)
			{
			}
			num = (short)1281753089;
			if (num != 0)
			{
			}
			this.b = new byte[length];
			global::System.Array.Copy(replyBuffer, offset, this.b, 0, length);
		}

		// Token: 0x040000CE RID: 206
		private byte[] a;

		// Token: 0x040000CF RID: 207
		private byte[] b;
	}
}
