using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Motorola.Common.Communication.Message;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	public class DnsQueryMessage : global::Motorola.Common.Communication.DnsBaseMessage
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public DnsQueryMessage(string queryType, ushort type)
		{
			base.Header = new global::Motorola.Common.Communication.Header();
			base.Header.ID = 0;
			base.Header.QR = 0;
			base.Header.OPCODE = 0;
			base.Header.AA = 0;
			base.Header.TC = 0;
			base.Header.RD = 0;
			base.Header.RA = 0;
			base.Header.Z = 0;
			base.Header.RCODE = 0;
			base.Header.QDCOUNT = 1;
			base.Header.ANCOUNT = 0;
			base.Header.NSCOUNT = 0;
			base.Header.ARCOUNT = 0;
			base.Questions = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Question>();
			global::Motorola.Common.Communication.Question question = new global::Motorola.Common.Communication.Question();
			question.QNAME = queryType;
			question.QTYPE = type;
			question.QClass = 1;
			base.Questions.Add(question);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006DAC File Offset: 0x00004FAC
		public override int BuildCommandMessage(byte[] buffer)
		{
			int a_ = 15;
			short num = (short)1864302592;
			switch (num)
			{
			default:
			{
				num = (short)1077346306;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.IO.MemoryStream memoryStream;
					switch (num2)
					{
					case 0:
					{
						num = (short)1656750080;
						short num3 = num;
						try
						{
							memoryStream.WriteByte((byte)((base.Header.ID & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.ID & 255));
							byte b = 0;
							b |= (byte)(base.Header.QR << 7);
							b |= (byte)(base.Header.OPCODE << 3);
							b |= (byte)(base.Header.AA << 2);
							b |= (byte)(base.Header.TC << 1);
							b |= base.Header.RD;
							memoryStream.WriteByte(b);
							b = 0;
							b |= (byte)(base.Header.RA << 7);
							b |= (byte)(base.Header.Z << 4);
							b |= base.Header.RCODE;
							memoryStream.WriteByte(b);
							memoryStream.WriteByte((byte)((base.Header.QDCOUNT & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.QDCOUNT & 255));
							memoryStream.WriteByte((byte)((base.Header.ANCOUNT & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.ANCOUNT & 255));
							memoryStream.WriteByte((byte)((base.Header.NSCOUNT & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.NSCOUNT & 255));
							memoryStream.WriteByte((byte)((base.Header.ARCOUNT & 65280) >> 8));
							memoryStream.WriteByte((byte)(base.Header.ARCOUNT & 255));
							using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Question>.Enumerator enumerator = base.Questions.GetEnumerator())
							{
								num = (short)1236598794;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_3BD;
									case 1:
									{
										memoryStream.WriteByte(0);
										global::Motorola.Common.Communication.Question question;
										memoryStream.WriteByte((byte)((question.QTYPE & 65280) >> 8));
										memoryStream.WriteByte((byte)(question.QTYPE & 255));
										memoryStream.WriteByte((byte)((question.QClass & 65280) >> 8));
										memoryStream.WriteByte((byte)(question.QClass & 255));
										num = (short)1785528323;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										num = (short)911987201;
										short num4 = num;
										num = (short)1809109505;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_4FD;
										}
										break;
									}
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)987889676;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Question question = enumerator.Current;
										string[] array = question.QNAME.Split(new char[]
										{
											'.'
										});
										int num5 = 0;
										num = (short)407044096;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										int num6;
										byte[] bytes;
										if (num6 >= bytes.Length)
										{
											num = (short)28049419;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										memoryStream.WriteByte(bytes[num6]);
										num6++;
										num = (short)599523335;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										goto IL_3BD;
									case 7:
										goto IL_46D;
									case 8:
										goto IL_46D;
									case 9:
									{
										string[] array;
										int num5;
										if (num5 >= array.Length)
										{
											num = (short)510722049;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string s = array[num5];
										byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(s);
										memoryStream.WriteByte((byte)bytes.Length);
										int num6 = 0;
										num = (short)1016266760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										switch (0)
										{
										case 0:
											goto IL_2A1;
										}
										continue;
									case 11:
									{
										int num5;
										num5++;
										num = (short)429981702;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										num = (short)83230722;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2A6:
									num = (short)2018246660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2A1:
									goto IL_2A6;
									IL_3BD:
									num = (short)152698889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_46D:
									num = (short)1448476677;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4FD:
								num = (short)1976565760;
								if (num != 0)
								{
								}
							}
							return (int)memoryStream.Position;
						}
						finally
						{
							num = (short)221315074;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_59B;
								case 1:
									memoryStream.Dispose();
									num = (short)1733230592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_564;
									}
									continue;
								}
								IL_564:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1911029761;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_59B:;
						}
						goto IL_59E;
					}
					case 1:
						goto IL_9C;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					num = (short)482541569;
					if (num != 0)
					{
					}
					if (buffer == null)
					{
						num = (short)1656487937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_59E:
					memoryStream = new global::System.IO.MemoryStream(buffer, 0, buffer.Length, true);
					num = (short)1064304640;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9C:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Message.PCRDnsResponseMessage.b("氍攏琑爓猕樗", a_));
			}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000073F4 File Offset: 0x000055F4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)585324427;
			short num2 = num;
			num = (short)668948363;
			switch (num2 == num)
			{
			}
			num = (short)750125057;
			if (num != 0)
			{
			}
			num = (short)1275396096;
			if (num != 0)
			{
			}
			num = (short)898826240;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
