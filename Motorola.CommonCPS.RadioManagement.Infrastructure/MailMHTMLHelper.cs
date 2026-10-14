using System;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000043 RID: 67
	public class MailMHTMLHelper
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00018934 File Offset: 0x00016B34
		public static byte[] GetMHTML(string htmlString)
		{
			int a_ = 17;
			short num;
			byte[] array;
			for (;;)
			{
				num = (short)1019609088;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)822280193;
					if (num != 0)
					{
					}
					global::System.Net.Mail.AlternateView alternateView = global::System.Net.Mail.AlternateView.CreateAlternateViewFromString(htmlString, new global::System.Net.Mime.ContentType(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("崨个唬嬮Ḱ嬲䄴娶唸", a_)));
					try
					{
						alternateView.TransferEncoding = global::System.Net.Mime.TransferEncoding.SevenBit;
						global::System.Net.Mail.MailMessage mailMessage = new global::System.Net.Mail.MailMessage();
						try
						{
							mailMessage.From = new global::System.Net.Mail.MailAddress(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䠨欪䰬Į到尲場", a_));
							mailMessage.AlternateViews.Add(alternateView);
							global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
							try
							{
								switch (0)
								{
								case 0:
									goto IL_CA;
								}
								int num3;
								for (;;)
								{
									IL_AF:
									switch (num2)
									{
									case 0:
										goto IL_12F;
									case 1:
										if ((long)num3 >= memoryStream.Length)
										{
											num = (short)525598722;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num3 += memoryStream.Read(array, 0, (int)memoryStream.Length - num3);
										num = (short)1015480324;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										num = (short)282525699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_184;
									case 4:
										goto IL_12F;
									}
									goto IL_CA;
									IL_12F:
									num = (short)1522401281;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_184:
								goto IL_2CA;
								IL_CA:
								mailMessage.Write(memoryStream);
								array = new byte[memoryStream.Length];
								num3 = 0;
								memoryStream.Position = 0L;
								num = (short)642646016;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_AF;
							}
							finally
							{
								num = (short)803340289;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1F2;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1BD;
										}
										continue;
									case 2:
										((global::System.IDisposable)memoryStream).Dispose();
										num = (short)1139081216;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1BD:
									if (memoryStream == null)
									{
										break;
									}
									num = (short)1181286402;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1F2:;
							}
						}
						finally
						{
							num = (short)807665665;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_25D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_227;
									}
									continue;
								case 2:
									((global::System.IDisposable)mailMessage).Dispose();
									num = (short)409927680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_227:
								if (mailMessage == null)
								{
									break;
								}
								num = (short)1944125442;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25D:;
						}
					}
					finally
					{
						num = (short)1551761409;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2C7;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_292;
								}
								continue;
							case 2:
								((global::System.IDisposable)alternateView).Dispose();
								num = (short)359923712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_292:
							if (alternateView == null)
							{
								break;
							}
							num = (short)1060962306;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2C7:;
					}
					IL_2CA:
					num = (short)1540897112;
					short num4 = num;
					num = (short)775829848;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_32A;
					}
					goto Block_2;
				}
				}
			}
			Block_2:
			num = (short)76873728;
			short num5 = num;
			IL_32A:
			num = (short)1566703616;
			if (num != 0)
			{
			}
			return array;
		}
	}
}
