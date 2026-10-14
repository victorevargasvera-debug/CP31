using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using AcpCommonResources;
using AcpExceptionLib;
using Microsoft.Win32;

namespace AcpFileHandlerLib
{
	// Token: 0x0200000A RID: 10
	public sealed class AcpSaveFileDialog : global::AcpFileHandlerLib.AcpFileDialog
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00008AEC File Offset: 0x00006CEC
		public AcpSaveFileDialog()
		{
			this.i = global::AcpFileHandlerLib.b.a;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008B08 File Offset: 0x00006D08
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode = true)]
		public override bool? ShowDialog(global::AcpFileHandlerLib.AcpFileHeader fileHeader)
		{
			short num = (short)1013230549;
			short num2 = num;
			num = (short)1945480149;
			switch (num2 == num)
			{
			}
			num = (short)144244737;
			if (num != 0)
			{
			}
			num = (short)1783889920;
			if (num != 0)
			{
			}
			num = (short)1407057920;
			short num3 = num;
			return this.ShowDialog(fileHeader, null);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008BB8 File Offset: 0x00006DB8
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.LinkDemand, UnmanagedCode = true)]
		public override bool? ShowDialog(global::AcpFileHandlerLib.AcpFileHeader fileHeader, global::System.Windows.Window owner)
		{
			int a_ = 19;
			short num = (short)2136473600;
			switch (num)
			{
			default:
			{
				num = (short)830210077;
				int num2 = (int)((global::System.IntPtr)num);
				int num5;
				bool value;
				for (;;)
				{
					global::AcpFileHandlerLib.l l;
					string[] array;
					global::System.Windows.Interop.WindowInteropHelper windowInteropHelper;
					switch (num2)
					{
					case 0:
						goto IL_240;
					case 1:
					{
						string text;
						if (!l.h.EndsWith(text))
						{
							num = (short)301137927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FD;
					}
					case 2:
					{
						string extension;
						if (!(extension == string.Empty))
						{
							num = (short)1552416774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FB;
					}
					case 3:
						goto IL_5EE;
					case 4:
					{
						string text;
						if (!(text == global::AcpFileHandlerLib.AcpSaveFileDialog.b("\udcf1\udef3", a_)))
						{
							num = (short)7864347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_754;
					}
					case 5:
					{
						if (!global::AcpFileHandlerLib.j.GetSaveFileName(ref l))
						{
							num = (short)1093074975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = this.c.Split(new char[]
						{
							'|'
						});
						string extension = global::System.IO.Path.GetExtension(l.h);
						string text = this.a(array.GetValue(l.g * 2 - 1).ToString(), extension);
						num = (short)1656815644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1304690697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1174732802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (owner != null)
						{
							num = (short)320274462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(global::System.Windows.Application.Current.MainWindow);
						num = (short)2121531408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						int num3;
						if (num3 == array.Length - 1)
						{
							num = (short)1139474455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 += 2;
						num = (short)1624506394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_240;
					case 11:
					{
						int num3 = 1;
						num = (short)972423193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_534;
					case 13:
						goto IL_569;
					case 14:
						goto IL_4FD;
					case 15:
					{
						int num3;
						if (num3 >= array.Length)
						{
							num = (short)1281687572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string extension;
						string text = this.a(array.GetValue(num3).ToString(), extension);
						num = (short)313131009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_45B;
					case 17:
						goto IL_45B;
					case 18:
						goto IL_60D;
					case 19:
						num = (short)2108620804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_4FD;
					case 21:
					{
						string text;
						if (text == global::AcpFileHandlerLib.AcpSaveFileDialog.b("\udcf1\udef3", a_))
						{
							num = (short)124387339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FD;
					}
					case 22:
						goto IL_4FD;
					case 23:
					{
						num = (short)1980170240;
						short num4 = num;
						goto IL_1FB;
					}
					case 24:
						if (num5 != 0)
						{
							num = (short)1448607747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value = false;
						num = (short)1035730962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_3CA;
					case 26:
						goto IL_3CA;
					case 27:
					{
						string text;
						l.h += text;
						num = (short)2001403918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						string text;
						if (!l.h.EndsWith(text))
						{
							num = (short)1545994259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_754;
					}
					case 29:
						switch (0)
						{
						case 0:
							goto IL_CF;
						}
						continue;
					case 30:
						num = (short)254672897;
						if (num != 0)
						{
						}
						windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(owner);
						num = (short)1517748241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num5 = global::AcpFileHandlerLib.j.CommDlgExtendedError();
						num = (short)516227096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CF:
					if (fileHeader == null)
					{
						this.h = new global::AcpFileHandlerLib.AcpFileHeader();
						num = (short)1524170752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)968476595;
					short num6 = num;
					num = (short)980928435;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_569;
					default:
						num = (short)528416768;
						if (num != 0)
						{
						}
						num = (short)912130061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1FB:
					l.h += this.a(array.GetValue(1).ToString(), string.Empty);
					num = (short)1052049430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_240:
					value = false;
					l = default(global::AcpFileHandlerLib.l);
					l.a = global::System.Runtime.InteropServices.Marshal.SizeOf<global::AcpFileHandlerLib.l>(l);
					l.d = this.c.Replace('|', '\0') + global::AcpFileHandlerLib.AcpSaveFileDialog.b("", a_);
					l.h = this.d + new string('\0', 32767 - this.d.Length);
					l.i = l.h.Length;
					string fileName = global::System.IO.Path.GetFileName(this.d);
					l.j = fileName + new string('\0', 32767 - fileName.Length);
					l.k = l.j.Length;
					l.m = global::AcpCommonResources.AcpResources.Save_As;
					l.q = this.e;
					l.l = global::AcpFileHandlerLib.AcpFileDialog.f;
					num = (short)225837064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CA:
					num = (short)1483800591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45B:
					l.b = windowInteropHelper.Handle;
					this.g = global::System.Windows.Forms.Screen.FromHandle(windowInteropHelper.Handle);
					l.n = 8980526;
					l.s = new global::AcpFileHandlerLib.k(base.HookProc);
					num = (short)441581573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FD:
					this.d = l.h;
					global::AcpFileHandlerLib.AcpFileDialog.InitialDirectory = global::System.IO.Path.GetDirectoryName(this.d);
					value = true;
					num = (short)1990197260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_569:
					this.h = fileHeader;
					num = (short)1674182666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_754:
					num = (short)1875247125;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_534:
				goto IL_7A3;
				IL_5EE:
				throw global::AcpExceptionLib.AcpException.CreateNewException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("등볳꧵꯷鋹鏻觽忿䘁洃朅搇攉欋儍嘏猑紓稕", a_), global::AcpFileHandlerLib.AcpSaveFileDialog.b("뇱鯳菵铷黹鋻\ud9fd瓿∁眃清朇紉Ⰻ栍礏縑焓㘕欗笙樛笝\u001f䘡䴣䜥䐧䔩䬫อᴯሱ", a_) + num5.ToString(), global::AcpExceptionLib.AcpException.SeverityLevel.Error, null);
				IL_60D:
				IL_7A3:
				return new bool?(value);
			}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00009370 File Offset: 0x00007570
		private string a(string A_0, string A_1)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num;
			string[] array;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!(A_1 == string.Empty))
					{
						goto IL_2A3;
					}
					goto IL_169;
				case 1:
				{
					int num2;
					if (num2 == array.Length - 1)
					{
						num3 = (short)448593932;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2++;
					num3 = (short)1501036545;
					if (num3 != 0)
					{
					}
					num3 = (short)750125062;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					num3 = (short)950534145;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					goto IL_17B;
				case 4:
					return A_0;
				case 5:
				{
					if (!A_0.Contains(global::AcpFileHandlerLib.AcpSaveFileDialog.b("\udde5", a_)))
					{
						num3 = (short)1086062601;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					A_0 = A_0.Replace(global::AcpFileHandlerLib.AcpSaveFileDialog.b("쳥", a_), "");
					array = A_0.Split(new char[]
					{
						';'
					});
					int num2 = 0;
					num3 = (short)671678467;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 6:
					goto IL_17B;
				case 7:
					goto IL_223;
				case 8:
					if (A_1 == A_0)
					{
						num3 = (short)35782666;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1262354432;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					return A_0;
				case 10:
					return A_0;
				case 11:
					if (A_1 == A_0)
					{
						num3 = (short)1893859332;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)107347973;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 12:
					goto IL_CD;
				case 13:
				{
					num3 = (short)1312454407;
					short num4 = num3;
					num3 = (short)211384071;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A3;
					case 1:
						break;
					default:
					{
						num3 = (short)242876416;
						short num5 = num3;
						break;
					}
					}
					num3 = (short)242024448;
					if (num3 != 0)
					{
					}
					int num2;
					if (num2 >= array.Length)
					{
						num3 = (short)1052573703;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					A_0 = array.GetValue(num2).ToString().Trim();
					num3 = (short)1826750472;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				}
				goto IL_51;
				IL_17B:
				num3 = (short)1671495693;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2A3:
				num3 = (short)1459748866;
				num = (int)((global::System.IntPtr)num3);
			}
			return A_0;
			IL_CD:
			IL_169:
			return array.GetValue(0).ToString().Trim();
			IL_223:
			return string.Empty;
			IL_51:
			A_0 = A_0.Trim().Substring(1);
			num3 = (short)1095303179;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000968C File Offset: 0x0000788C
		public override bool? ShowDialog()
		{
			short num = (short)1442566180;
			short num2 = num;
			num = (short)950456356;
			switch (num2 == num)
			{
			}
			num = (short)864157696;
			if (num != 0)
			{
			}
			num = (short)1015742464;
			short num3 = num;
			num = (short)757071873;
			if (num != 0)
			{
			}
			return this.ShowDialog(null);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000973C File Offset: 0x0000793C
		public override bool? ShowDialog(global::System.Windows.Window owner)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			bool value;
			for (;;)
			{
				IL_0A:
				bool? flag;
				bool flag2;
				switch (num)
				{
				case 0:
					goto IL_E0;
				case 1:
					this.a.InitialDirectory = global::AcpFileHandlerLib.AcpFileDialog.f;
					num2 = (short)18022400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					this.d = this.a.FileName;
					global::AcpFileHandlerLib.AcpFileDialog.InitialDirectory = global::System.IO.Path.GetDirectoryName(this.d);
					value = true;
					num2 = (short)1656684544;
					short num3 = num2;
					num2 = (short)769720324;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (global::System.IO.Directory.Exists(global::AcpFileHandlerLib.AcpFileDialog.f))
					{
						num2 = (short)586416129;
						if (num2 != 0)
						{
						}
						num2 = (short)643497985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a.InitialDirectory = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
					goto IL_149;
				case 4:
					goto IL_1F7;
				case 5:
					goto IL_E0;
				case 6:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)648413186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F7;
				}
				goto IL_2C;
				IL_E0:
				flag = this.a.ShowDialog(owner);
				flag2 = true;
				num2 = (short)529858566;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_149:
				num2 = (short)1763639301;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F7:
				num2 = (short)397868581;
				short num4 = num2;
				num2 = (short)803667493;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_149;
				default:
					goto IL_22D;
				}
			}
			IL_22D:
			num2 = (short)1358757888;
			if (num2 != 0)
			{
			}
			return new bool?(value);
			IL_2C:
			value = false;
			this.a = new global::Microsoft.Win32.SaveFileDialog();
			this.a.Filter = this.c;
			this.a.DefaultExt = this.e;
			this.a.FileName = base.FileName;
			this.a.RestoreDirectory = true;
			num2 = (short)2114912259;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00009994 File Offset: 0x00007B94
		internal new static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(481472384 + A_1) + (global::System.IntPtr)76 + (global::System.IntPtr)18);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x0400001A RID: 26
		private global::Microsoft.Win32.SaveFileDialog a;
	}
}
