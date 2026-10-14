using System;
using System.Runtime.InteropServices;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200006D RID: 109
	public sealed class ResetPasswordFileManager
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x00035B08 File Offset: 0x00033D08
		public static global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus CheckFileContentsValid(byte[] rawBytes, string expectedSerialNumber)
		{
			int a_ = 14;
			short num = (short)1616773126;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.InvalidSerialNumber;
				case 1:
				{
					global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileStructure resetPasswordFileStructure;
					if (resetPasswordFileStructure.MagicNumber != global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䘑堓䔕䨗", a_))
					{
						num = (short)957349893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)279445508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.InvalidFile;
				case 3:
					return global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.InvalidFile;
				case 4:
				{
					global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileStructure resetPasswordFileStructure;
					if (resetPasswordFileStructure.SerialNumber != expectedSerialNumber)
					{
						goto IL_1C9;
					}
					return global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.ValidFile;
				}
				case 5:
					return global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.InvalidFile;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 7:
				{
					global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileStructure resetPasswordFileStructure;
					if ((long)rawBytes.Length != (long)((ulong)resetPasswordFileStructure.TotalFileSize))
					{
						num = (short)665976834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1174994945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4D:
				if (rawBytes != null)
				{
					global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileStructure resetPasswordFileStructure = global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.a<global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileStructure>(rawBytes);
					num = (short)2086535175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1933770753;
				if (num != 0)
				{
				}
				num = (short)1977762696;
				short num3 = num;
				num = (short)491144072;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1969225728;
					if (num != 0)
					{
					}
					num = (short)887685120;
					short num4 = num;
					num = (short)571015171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_1C9:
				num = (short)575275008;
				num2 = (int)((global::System.IntPtr)num);
			}
			return global::Motorola.Common.Communication.CommonUtil.ResetPasswordFileManager.ResetPasswordFileValidationStatus.InvalidFile;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00035CFC File Offset: 0x00033EFC
		private static a a<a>(byte[] A_0)
		{
			short num = (short)2018092398;
			short num2 = num;
			num = (short)389588334;
			switch (num2 == num)
			{
			}
			num = (short)765919233;
			if (num != 0)
			{
			}
			num = (short)753860608;
			if (num != 0)
			{
			}
			num = (short)204603392;
			short num3 = num;
			global::System.Runtime.InteropServices.GCHandle gchandle = global::System.Runtime.InteropServices.GCHandle.Alloc(A_0, global::System.Runtime.InteropServices.GCHandleType.Pinned);
			a result = (a)((object)global::System.Runtime.InteropServices.Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(a)));
			gchandle.Free();
			return result;
		}

		// Token: 0x040002E6 RID: 742
		private const string a = "TLSR";

		// Token: 0x0200006E RID: 110
		public enum ResetPasswordFileValidationStatus
		{
			// Token: 0x040002E8 RID: 744
			InvalidFile,
			// Token: 0x040002E9 RID: 745
			InvalidSerialNumber,
			// Token: 0x040002EA RID: 746
			ValidFile
		}

		// Token: 0x0200006F RID: 111
		public struct ResetPasswordFileStructure
		{
			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x00035DE4 File Offset: 0x00033FE4
			public string MagicNumber
			{
				get
				{
					short num = (short)1136790669;
					short num2 = num;
					num = (short)310381709;
					switch (num2 == num)
					{
					}
					num = (short)910360577;
					if (num != 0)
					{
					}
					num = (short)1843593216;
					if (num != 0)
					{
					}
					num = (short)1016070144;
					short num3 = num;
					return new string(this.a);
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x00035E98 File Offset: 0x00034098
			public string SerialNumber
			{
				get
				{
					short num = (short)1228962066;
					short num2 = num;
					num = (short)54819090;
					switch (num2 == num)
					{
					}
					num = (short)1614151680;
					if (num != 0)
					{
					}
					num = (short)1621426177;
					if (num != 0)
					{
					}
					num = (short)1668022272;
					short num3 = num;
					return new string(this.b);
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002F5 RID: 757 RVA: 0x00035F4C File Offset: 0x0003414C
			public string SignerName
			{
				get
				{
					short num = (short)390529025;
					if (num != 0)
					{
					}
					num = (short)1352445889;
					short num2 = num;
					num = (short)1528737729;
					switch (num2 == num)
					{
					}
					num = (short)1236074496;
					if (num != 0)
					{
					}
					num = (short)1826750464;
					short num3 = num;
					return new string(this.c).Trim(new char[1]);
				}
			}

			// Token: 0x040002EB RID: 747
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 4)]
			private char[] a;

			// Token: 0x040002EC RID: 748
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.I4)]
			public uint Version;

			// Token: 0x040002ED RID: 749
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.I4)]
			public uint TotalFileSize;

			// Token: 0x040002EE RID: 750
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 10)]
			private char[] b;

			// Token: 0x040002EF RID: 751
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 2)]
			public byte[] Flags;

			// Token: 0x040002F0 RID: 752
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16)]
			private char[] c;

			// Token: 0x040002F1 RID: 753
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.I4)]
			public uint CreationDate;

			// Token: 0x040002F2 RID: 754
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 144)]
			public byte[] Signature;
		}
	}
}
