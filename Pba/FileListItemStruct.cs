using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000F RID: 15
	public class FileListItemStruct
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00005A34 File Offset: 0x00003C34
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00005AE8 File Offset: 0x00003CE8
		public global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile FileType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)837368315;
				short num2 = num;
				num = (short)635976187;
				switch (num2 == num)
				{
				}
				num = (short)925892608;
				short num3 = num;
				num = (short)1582366721;
				if (num != 0)
				{
				}
				num = (short)2033909760;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)364113198;
				short num2 = num;
				num = (short)266399022;
				switch (num2 == num)
				{
				}
				num = (short)65536;
				short num3 = num;
				num = (short)33554433;
				if (num != 0)
				{
				}
				num = (short)207486976;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00005B98 File Offset: 0x00003D98
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00005C44 File Offset: 0x00003E44
		public int FileSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2082462461;
				short num2 = num;
				num = (short)815520509;
				switch (num2 == num)
				{
				}
				num = (short)1779892224;
				short num3 = num;
				num = (short)1495597057;
				if (num != 0)
				{
				}
				num = (short)45088768;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)321620626;
				short num2 = num;
				num = (short)1253739154;
				switch (num2 == num)
				{
				}
				num = (short)104333312;
				short num3 = num;
				num = (short)829947905;
				if (num != 0)
				{
				}
				num = (short)1887436800;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00005CF4 File Offset: 0x00003EF4
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00005DA0 File Offset: 0x00003FA0
		public string FileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1400116558;
				short num2 = num;
				num = (short)819270990;
				switch (num2 == num)
				{
				}
				num = (short)861077504;
				short num3 = num;
				num = (short)312737792;
				if (num != 0)
				{
				}
				num = (short)781254657;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)242679809;
				if (num != 0)
				{
				}
				num = (short)17437474;
				short num2 = num;
				num = (short)189141794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432289280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2012217344;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005E50 File Offset: 0x00004050
		public FileListItemStruct()
		{
			this.FileType = global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.Unknown;
			this.FileSize = 0;
			this.FileName = "";
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005E7C File Offset: 0x0000407C
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> ParseTransferData(byte[] xferData)
		{
			short num = (short)1205338112;
			switch (num)
			{
			default:
			{
				num = (short)1296105476;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list;
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
					{
						num = (short)1609105409;
						if (num != 0)
						{
						}
						if (num3 >= xferData.Length)
						{
							num = (short)2105868293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct = new global::Motorola.Common.Communication.Pba.FileListItemStruct();
						fileListItemStruct.FileType = (global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile)xferData[num3];
						fileListItemStruct.FileSize = (int)xferData[num3 + 1];
						fileListItemStruct.FileSize = fileListItemStruct.FileSize * 256 + (int)xferData[num3 + 2];
						fileListItemStruct.FileSize = fileListItemStruct.FileSize * 256 + (int)xferData[num3 + 3];
						fileListItemStruct.FileSize = fileListItemStruct.FileSize * 256 + (int)xferData[num3 + 4];
						num3 += 5;
						byte[] array = new byte[xferData.Length - num3];
						global::System.Array.Copy(xferData, num3, array, 0, xferData.Length - num3);
						string @string = global::System.Text.Encoding.UTF8.GetString(array);
						int length = @string.IndexOf('\0');
						fileListItemStruct.FileName = @string.Substring(0, length);
						int num4 = global::System.Text.Encoding.UTF8.GetBytes(fileListItemStruct.FileName).Length;
						num3 = num3 + num4 + 1;
						list.Add(fileListItemStruct);
						num = (short)773849089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1B4;
					case 2:
					{
						num = (short)549912576;
						short num5 = num;
						goto IL_1B4;
					}
					case 3:
						goto IL_79;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 5:
					{
						num = (short)1415652910;
						short num6 = num;
						num = (short)2127767086;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_24B;
						}
						break;
					}
					}
					IL_5C:
					if (xferData == null)
					{
						num = (short)1762787331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>();
					num3 = 0;
					num = (short)1393295362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B4:
					num = (short)358744064;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_79:
				throw new global::System.ArgumentNullException();
				IL_24B:
				num = (short)707395584;
				if (num != 0)
				{
				}
				return list;
			}
			}
		}

		// Token: 0x04000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile a;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int b;

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x02000010 RID: 16
		public enum TypeOfFile : byte
		{
			// Token: 0x0400002C RID: 44
			Unknown,
			// Token: 0x0400002D RID: 45
			File,
			// Token: 0x0400002E RID: 46
			Directory
		}
	}
}
