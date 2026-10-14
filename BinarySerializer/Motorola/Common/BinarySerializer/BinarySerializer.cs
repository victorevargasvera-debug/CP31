using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Motorola.Common.BinarySerializer
{
	// Token: 0x02000006 RID: 6
	[global::System.Runtime.CompilerServices.b(1)]
	[global::System.Runtime.CompilerServices.a(0)]
	public class BinarySerializer
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000218C File Offset: 0x0000038C
		public global::Motorola.Common.BinarySerializer.IBinarySerializerRecord Parse(byte[] input)
		{
			short num = (short)389162469;
			short num2 = num;
			num = (short)548808165;
			global::Motorola.Common.BinarySerializer.IBinarySerializerRecord result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)358875137;
				if (num != 0)
				{
				}
				num = (short)411369472;
				if (num != 0)
				{
				}
				num = (short)660078592;
				short num3 = num;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(input);
				try
				{
					global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(memoryStream);
					try
					{
						result = this.Parse(binaryReader);
					}
					finally
					{
						num = (short)916258816;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_EB;
								}
								continue;
							case 1:
								goto IL_11E;
							case 2:
								((global::System.IDisposable)binaryReader).Dispose();
								num = (short)1120731137;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_EB:
							if (binaryReader == null)
							{
								break;
							}
							num = (short)1948450818;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_11E:;
					}
				}
				finally
				{
					num = (short)996868096;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_151;
							}
							continue;
						case 1:
							goto IL_184;
						case 2:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1896742913;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_151:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)249823234;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_184:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002340 File Offset: 0x00000540
		public global::Motorola.Common.BinarySerializer.IBinarySerializerRecord Parse(global::System.IO.MemoryStream ms)
		{
			short num = (short)1637603140;
			short num2 = num;
			num = (short)1232525124;
			global::Motorola.Common.BinarySerializer.IBinarySerializerRecord result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1929510912;
				if (num != 0)
				{
				}
				num = (short)832634881;
				if (num != 0)
				{
				}
				num = (short)1715798016;
				short num3 = num;
				global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(ms);
				try
				{
					result = this.Parse(binaryReader);
				}
				finally
				{
					num = (short)2121596928;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						case 1:
							goto IL_113;
						case 2:
							((global::System.IDisposable)binaryReader).Dispose();
							num = (short)2072969217;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DD:
						if (binaryReader == null)
						{
							break;
						}
						num = (short)590151682;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_113:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002474 File Offset: 0x00000674
		public global::Motorola.Common.BinarySerializer.IBinarySerializerRecord Parse(global::System.IO.BinaryReader stream)
		{
			short num = (short)2056225965;
			short num2 = num;
			num = (short)801342637;
			switch (num2 == num)
			{
			default:
			{
				num = (short)310444032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1578500097;
			if (num != 0)
			{
			}
			num = (short)2091712512;
			if (num != 0)
			{
			}
			return this.a.a(stream);
		}

		// Token: 0x04000005 RID: 5
		private readonly global::Motorola.Common.BinarySerializer.a a = new global::Motorola.Common.BinarySerializer.a();
	}
}
