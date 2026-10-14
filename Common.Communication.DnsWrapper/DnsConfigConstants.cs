using System;
using System.IO;
using System.Reflection;
using Motorola.Common.Communication.Message;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public class DnsConfigConstants
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002B50 File Offset: 0x00000D50
		public static string ConfigFilePath
		{
			get
			{
				short num = (short)1981213951;
				short num2 = num;
				num = (short)1360784639;
				switch (num2 == num)
				{
				}
				num = (short)1298464768;
				short num3 = num;
				num = (short)1466171393;
				if (num != 0)
				{
				}
				num = (short)2094202880;
				if (num != 0)
				{
				}
				return global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), global::Motorola.Common.Communication.DnsConfigConstants.DNS_METADATA_FOLDER, global::Motorola.Common.Communication.DnsConfigConstants.DNS_CONFIG_METADATA_FOLDER, global::Motorola.Common.Communication.DnsConfigConstants.DNS_CONFIG_FILE);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002C30 File Offset: 0x00000E30
		// Note: this type is marked as 'beforefieldinit'.
		static DnsConfigConstants()
		{
			int a_ = 13;
			short num = (short)376223137;
			short num2 = num;
			num = (short)1023391137;
			switch (num2 == num)
			{
			}
			num = (short)572784640;
			short num3 = num;
			num = (short)201064449;
			if (num != 0)
			{
			}
			num = (short)117637120;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.DnsConfigConstants.a = string.Empty;
			global::Motorola.Common.Communication.DnsConfigConstants.DNS_CONFIG_METADATA_FOLDER = global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("䠋䀍䌏", a_);
			global::Motorola.Common.Communication.DnsConfigConstants.DNS_METADATA_FOLDER = global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("䄋欍搏猑倓眕気笙", a_);
			global::Motorola.Common.Communication.DnsConfigConstants.DNS_CONFIG_FILE = global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("䠋䀍䌏儑笓砕縗猙笛〝堟伡䠣", a_);
			global::Motorola.Common.Communication.DnsConfigConstants.DNS_BODY_START_INDEX = 12;
		}

		// Token: 0x04000008 RID: 8
		private static string a;

		// Token: 0x04000009 RID: 9
		public static readonly string DNS_CONFIG_METADATA_FOLDER;

		// Token: 0x0400000A RID: 10
		public static readonly string DNS_METADATA_FOLDER;

		// Token: 0x0400000B RID: 11
		public static readonly string DNS_CONFIG_FILE;

		// Token: 0x0400000C RID: 12
		public static readonly int DNS_BODY_START_INDEX;
	}
}
