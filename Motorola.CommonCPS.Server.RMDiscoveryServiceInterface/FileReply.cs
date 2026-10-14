using System;
using System.IO;
using System.ServiceModel;

namespace Motorola.CommonCPS.Server.RMDiscoveryServiceInterface
{
	// Token: 0x02000005 RID: 5
	[global::System.ServiceModel.MessageContract]
	public class FileReply : global::System.IDisposable
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002130 File Offset: 0x00000330
		public void Dispose()
		{
			short num = (short)2000486400;
			short num2 = num;
			num = (short)584485325;
			short num3 = num;
			num = (short)129927629;
			switch (num3 == num)
			{
			}
			num = (short)84344833;
			if (num != 0)
			{
			}
			num = (short)773324800;
			if (num != 0)
			{
			}
			this.Dispose(true);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000021E4 File Offset: 0x000003E4
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)2093219841;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EE;
				case 1:
					goto IL_16;
				case 2:
				{
					num = (short)2049827720;
					short num3 = num;
					num = (short)100721544;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						num = (short)1330511872;
						if (num != 0)
						{
						}
						this.ReplyFileStream.Close();
						this.ReplyFileStream = null;
						num = (short)538836992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_58;
				IL_16:
				num = (short)1261961217;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					IL_58:
					if (this.ReplyFileStream == null)
					{
						return;
					}
					num = (short)2121531394;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EE:
			num = (short)2104754176;
			short num4 = num;
		}

		// Token: 0x04000005 RID: 5
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string FileName;

		// Token: 0x04000006 RID: 6
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public long FileLength;

		// Token: 0x04000007 RID: 7
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string Version;

		// Token: 0x04000008 RID: 8
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string CommandLineArguments;

		// Token: 0x04000009 RID: 9
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string Hash;

		// Token: 0x0400000A RID: 10
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string ExecutableName;

		// Token: 0x0400000B RID: 11
		[global::System.ServiceModel.MessageBodyMember(Order = 1)]
		public global::System.IO.Stream ReplyFileStream;
	}
}
