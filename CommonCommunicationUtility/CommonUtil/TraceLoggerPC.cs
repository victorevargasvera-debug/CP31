using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Security;
using System.Threading;
using Motorola.Common.Communication.CommonUtility;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004B RID: 75
	public class TraceLoggerPC : global::Motorola.Common.Communication.CommonUtil.TraceLogger, global::System.IDisposable
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000C214 File Offset: 0x0000A414
		public override global::System.Diagnostics.TraceLevel Level
		{
			get
			{
				short num = (short)138558379;
				short num2 = num;
				num = (short)200752043;
				switch (num2 == num)
				{
				}
				num = (short)546963457;
				if (num != 0)
				{
				}
				num = (short)1900019712;
				short num3 = num;
				num = (short)1212022784;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.Level;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		internal TraceLoggerPC()
		{
			if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.Level != global::System.Diagnostics.TraceLevel.Off)
			{
				this.g = global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.LogFilePath;
				if (global::System.IO.Directory.Exists(this.g))
				{
					goto IL_1B3;
				}
				Block_3:
				try
				{
					global::System.IO.Directory.CreateDirectory(this.g);
					goto IL_1B3;
				}
				catch
				{
					global::System.Console.WriteLine("Create the log folder {0} failed", this.g);
					goto IL_1B3;
				}
				IL_A3:
				global::System.IO.FileInfo fileInfo;
				if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.Level != global::System.Diagnostics.TraceLevel.Off)
				{
					this.h = new global::System.Diagnostics.TextWriterTraceListener(fileInfo.FullName);
					global::System.Diagnostics.Trace.Listeners.Add(this.h);
					global::System.Diagnostics.Trace.AutoFlush = true;
					global::System.Console.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0},+++Common Communication Log+++", global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b()));
				}
				return;
				IL_1B3:
				string text = global::System.Diagnostics.Process.GetCurrentProcess().ProcessName + "_CommonCommunication.log";
				this.f = global::System.IO.Path.Combine(this.g, text);
				fileInfo = new global::System.IO.FileInfo(this.f);
				try
				{
					fileInfo.Open(global::System.IO.FileMode.Append, global::System.IO.FileAccess.Write).Close();
					goto IL_D1;
				}
				catch (global::System.Security.SecurityException ex)
				{
					global::System.Console.WriteLine("No permission to output the log to {0} {1}", text, ex.Message);
					this.g = global::System.Environment.GetEnvironmentVariable("temp");
					text = global::System.IO.Path.Combine(this.g, text);
					fileInfo = new global::System.IO.FileInfo(text);
					global::System.Console.WriteLine("Redirect the log to {0}", text);
					goto IL_D1;
				}
				catch (global::System.Exception ex2)
				{
					global::System.Console.WriteLine("Unexpected exception for outputting the log to {0} {1}", text, ex2.Message);
					this.g = global::System.Environment.GetEnvironmentVariable("temp");
					text = global::System.IO.Path.Combine(this.g, text);
					fileInfo = new global::System.IO.FileInfo(text);
					goto IL_D1;
				}
				return;
				IL_D1:
				this.c();
				try
				{
					global::System.Diagnostics.EventLog.WriteEntry("Motorola Device Communication", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The log of '{0}' level of Motorola Device Communication was output to \"{1}\"", global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.Level, fileInfo.FullName), global::System.Diagnostics.EventLogEntryType.Information, 49161);
					goto IL_A3;
				}
				catch
				{
					goto IL_A3;
				}
				goto Block_3;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1505365628;
				short num2 = num;
				num = (short)1390218876;
				switch (num2 == num)
				{
				}
				num = (short)2131296256;
				if (num != 0)
				{
				}
				this.Dispose(false);
				this.d();
			}
			finally
			{
				num = (short)776732673;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1424883712;
			short num3 = num;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000C5C4 File Offset: 0x0000A7C4
		private void d()
		{
			short num;
			try
			{
				num = (short)799288089;
				short num2 = num;
				num = (short)688335641;
				switch (num2 == num)
				{
				}
				num = (short)1756430336;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Trace.WriteLine(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0},---Common Communication Log---", global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b()));
				global::System.Diagnostics.Trace.Flush();
			}
			catch (global::System.Exception)
			{
			}
			num = (short)591265793;
			if (num != 0)
			{
			}
			num = (short)16711680;
			short num3 = num;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000C69C File Offset: 0x0000A89C
		private void c()
		{
			short num;
			try
			{
				num = (short)1335033857;
				if (num != 0)
				{
				}
				num = (short)2102198272;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					global::System.IO.FileInfo fileInfo;
					string processName;
					for (;;)
					{
						IL_4E:
						string text;
						switch (num2)
						{
						case 0:
							goto IL_275;
						case 1:
							goto IL_306;
						case 2:
							try
							{
								num = (short)607191040;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_103;
										}
										continue;
									case 1:
										goto IL_256;
									case 2:
									{
										this.h = new global::System.Diagnostics.TextWriterTraceListener(fileInfo.FullName);
										global::System.Diagnostics.Trace.Listeners.Add(this.h);
										global::System.Diagnostics.Trace.AutoFlush = true;
										num = (short)260815457;
										short num3 = num;
										num = (short)1834400353;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_156;
										default:
											num = (short)766312448;
											if (num != 0)
											{
											}
											num = (short)600506371;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										goto IL_23E;
									case 4:
										if (this.h != null)
										{
											num = (short)170917890;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_23E;
									case 5:
										global::System.Diagnostics.Trace.Listeners.Remove(this.h);
										this.h.Close();
										num = (short)1792147462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_156;
									}
									IL_103:
									if (this.h != null)
									{
										num = (short)2078605317;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1E7:
									global::System.IO.File.Move(fileInfo.FullName, global::System.IO.Path.Combine(this.g, text));
									num = (short)1428422660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_156:
									goto IL_1E7;
									IL_23E:
									num = (short)930414593;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_256:
								goto IL_2EC;
							}
							catch (global::System.Exception ex)
							{
								global::System.Console.WriteLine("Can't rename the log file from {0} to {1} : {2}", fileInfo.FullName, text, ex.Message);
								goto IL_2EC;
							}
							goto IL_275;
						case 3:
							if (fileInfo.Length > 52428800L)
							{
								num = (short)1212022784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2EC;
						case 4:
							if (fileInfo.Exists)
							{
								num = (short)1746796549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2EC;
						case 5:
							num = (short)814940163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D;
						IL_275:
						text = processName + "_CommonCommunication" + global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a() + ".log";
						num = (short)757268482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2EC:
						num = (short)676724737;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_306:
					break;
					IL_6D:
					fileInfo = new global::System.IO.FileInfo(this.f);
					processName = global::System.Diagnostics.Process.GetCurrentProcess().ProcessName;
					num = (short)1129119748;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4E;
				}
				}
			}
			catch (global::System.Exception ex2)
			{
				this.a("INTERNAL", ex2.Message);
				this.a("INTERNAL", ex2.StackTrace);
			}
			num = (short)1956904960;
			short num4 = num;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000CA38 File Offset: 0x0000AC38
		public override void WriteError(string format, params object[] args)
		{
			short num;
			try
			{
				num = (short)1482752004;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a("ERROR", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
						num = (short)984350722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_128;
					case 2:
						goto IL_C5;
					case 3:
						if (!string.IsNullOrEmpty(format))
						{
							num = (short)1155203072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
						num = (short)1939079171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3C:
					if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.TraceError)
					{
						num = (short)28246021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C5:
					num = (short)196525658;
					short num3 = num;
					num = (short)1853079130;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_128;
					default:
						num = (short)1845035008;
						if (num != 0)
						{
						}
						num = (short)850395137;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_128:;
			}
			catch (global::System.Exception ex)
			{
				this.a("INTERNAL", ex.Message);
				this.a("INTERNAL", format);
				this.a("INTERNAL", ex.StackTrace);
			}
			num = (short)44040193;
			if (num != 0)
			{
			}
			num = (short)1177092096;
			short num4 = num;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000CC0C File Offset: 0x0000AE0C
		public override void WriteWarning(string format, params object[] args)
		{
			short num;
			try
			{
				num = (short)1305673732;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a("WARNING", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
						num = (short)644284418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_12D;
					case 2:
						goto IL_CB;
					case 3:
						if (!string.IsNullOrEmpty(format))
						{
							num = (short)1300889600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 5:
						num = (short)938803203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3D:
					if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.TraceWarning)
					{
						num = (short)220790789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CB:
					num = (short)892346215;
					short num3 = num;
					num = (short)1760632679;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12D;
					default:
						num = (short)1755971584;
						if (num != 0)
						{
						}
						num = (short)332005377;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_12D:;
			}
			catch (global::System.Exception ex)
			{
				this.a("INTERNAL", ex.Message);
				this.a("INTERNAL", format);
				this.a("INTERNAL", ex.StackTrace);
			}
			num = (short)12910593;
			if (num != 0)
			{
			}
			num = (short)1145503744;
			short num4 = num;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
		public override void WriteInfo(string format, params object[] args)
		{
			short num;
			try
			{
				num = (short)962461700;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a("INFO", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
						num = (short)1688403970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_128;
					case 2:
						goto IL_C5;
					case 3:
						if (!string.IsNullOrEmpty(format))
						{
							num = (short)1833500672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
						num = (short)153354243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C;
					IL_48:
					num = (short)993591301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C5:
					num = (short)1556144319;
					short num3 = num;
					num = (short)334684351;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
						num = (short)1182334976;
						if (num != 0)
						{
						}
						num = (short)282591233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3C:
					if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.TraceInfo)
					{
						goto IL_48;
					}
					goto IL_C5;
				}
				IL_128:;
			}
			catch (global::System.Exception ex)
			{
				this.a("INTERNAL", ex.Message);
				this.a("INTERNAL", format);
				this.a("INTERNAL", ex.StackTrace);
			}
			num = (short)1368195072;
			short num4 = num;
			num = (short)1029898241;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		public override void WriteVerbose(global::Motorola.Common.Communication.CommonUtil.TraceLogger.TraceLoggerStringBuilder errorBuilder)
		{
			short num;
			try
			{
				num = (short)1105723396;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_141;
					case 1:
						num = (short)1977942019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_B8;
					case 3:
						if (errorBuilder != null)
						{
							num = (short)820445189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B8;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 5:
						this.a("VERBOSE", errorBuilder());
						num = (short)2114125826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D;
					IL_49:
					num = (short)1184497665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B8:
					num = (short)731205555;
					short num3 = num;
					num = (short)2127843251;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_49;
					default:
						num = (short)1502347265;
						if (num != 0)
						{
						}
						num = (short)1713635328;
						if (num != 0)
						{
						}
						num = (short)430112768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3D:
					if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.TraceVerbose)
					{
						goto IL_49;
					}
					goto IL_B8;
				}
				IL_141:;
			}
			catch (global::System.Exception ex)
			{
				this.a("INTERNAL", ex.Message);
				this.a("INTERNAL", ex.StackTrace);
			}
			num = (short)1964244992;
			short num4 = num;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000D17C File Offset: 0x0000B37C
		public override void WriteVerbose(string format, params object[] args)
		{
			short num;
			try
			{
				num = (short)1097465860;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
						num = (short)713490435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_C4;
					case 3:
						if (!string.IsNullOrEmpty(format))
						{
							num = (short)1566507013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
						this.a("VERBOSE", string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, args));
						num = (short)1598554114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C;
					IL_48:
					num = (short)2088304641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C4:
					num = (short)245908857;
					short num3 = num;
					num = (short)1620198777;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
						num = (short)548732928;
						if (num != 0)
						{
						}
						num = (short)1742405632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3C:
					if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.TraceVerbose)
					{
						goto IL_48;
					}
					goto IL_C4;
				}
				IL_125:;
			}
			catch (global::System.Exception ex)
			{
				this.a("INTERNAL", ex.Message);
				this.a("INTERNAL", format);
				this.a("INTERNAL", ex.StackTrace);
			}
			num = (short)49872896;
			short num4 = num;
			num = (short)1267728385;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000D34C File Offset: 0x0000B54C
		public override void WriteSensitive(string format, params object[] args)
		{
			short num = (short)2117206017;
			if (num != 0)
			{
			}
			num = (short)1632740604;
			short num2 = num;
			num = (short)1634510076;
			switch (num2 == num)
			{
			}
			num = (short)1647509504;
			if (num != 0)
			{
			}
			num = (short)1020657664;
			short num3 = num;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		public override void WriteVoid(string format, params object[] args)
		{
			short num = (short)565182465;
			if (num != 0)
			{
			}
			num = (short)732420835;
			short num2 = num;
			num = (short)1709169379;
			switch (num2 == num)
			{
			}
			num = (short)1662910464;
			if (num != 0)
			{
			}
			num = (short)1450311680;
			short num3 = num;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		private void a(string A_0, string A_1)
		{
			short num = (short)631308289;
			if (num != 0)
			{
			}
			num = (short)1293418496;
			short num2 = num;
			num = (short)1932293307;
			short num3 = num;
			num = (short)779842747;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1320681472;
				if (num != 0)
				{
				}
				object obj = this.i;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_DE;
					}
					int num4;
					for (;;)
					{
						IL_B0:
						switch (num4)
						{
						case 0:
							goto IL_2BA;
						case 1:
							if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a.Level != global::System.Diagnostics.TraceLevel.Off)
							{
								num = (short)1177878535;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11F;
						case 2:
							global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b.WriteWarning(string.Format("{0},[{1}],{2},{3}\n {4}", new object[]
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b(),
								global::System.Threading.Thread.CurrentThread.ManagedThreadId,
								A_0,
								global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.c,
								A_1
							}));
							num = (short)1151336452;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b.WriteError(string.Format("{0},[{1}],{2},{3}\n {4}", new object[]
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b(),
								global::System.Threading.Thread.CurrentThread.ManagedThreadId,
								A_0,
								global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.c,
								A_1
							}));
							num = (short)38797312;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_2BF;
						case 5:
							if (A_0 == "ERROR")
							{
								num = (short)2124218371;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)249954313;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_2D8;
						case 7:
							this.c();
							global::System.Diagnostics.Trace.WriteLine(string.Format("{0},[{1}],{2},\"{3}\"", new object[]
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b(),
								global::System.Threading.Thread.CurrentThread.ManagedThreadId,
								A_0,
								A_1
							}));
							num = (short)67502088;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_11F;
						case 9:
							if (A_0 == "WARNING")
							{
								num = (short)1589510146;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2BF;
						}
						goto IL_DE;
						IL_11F:
						num = (short)417726469;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_2BF:
						num = (short)394657798;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_2BA:
					IL_2D8:
					break;
					IL_DE:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1074462721;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B0;
				}
				finally
				{
					num = (short)22806528;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_30A;
							}
							continue;
						case 1:
							goto IL_33D;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1251409921;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_30A:
						if (!flag)
						{
							break;
						}
						num = (short)136970242;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_33D:;
				}
				break;
			}
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000D810 File Offset: 0x0000BA10
		private static string b()
		{
			short num = (short)289865729;
			if (num != 0)
			{
			}
			num = (short)1348259085;
			short num2 = num;
			num = (short)1199754509;
			switch (num2 == num)
			{
			}
			num = (short)1226702848;
			if (num != 0)
			{
			}
			num = (short)1444937728;
			short num3 = num;
			return global::System.DateTime.Now.ToString("[MM/dd/yy HH:mm:ss.fff]", global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		private static string a()
		{
			short num = (short)208535553;
			if (num != 0)
			{
			}
			num = (short)1543201717;
			short num2 = num;
			num = (short)600728501;
			switch (num2 == num)
			{
			}
			num = (short)2064252928;
			if (num != 0)
			{
			}
			num = (short)1814626304;
			short num3 = num;
			return global::System.DateTime.Now.ToString("_MM_dd_yy_HH_mm_ss", global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000D990 File Offset: 0x0000BB90
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)615862776;
			short num2 = num;
			num = (short)398152184;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_21C;
			case 1:
				break;
			default:
			{
				num = (short)1541603328;
				short num3 = num;
				break;
			}
			}
			num = (short)612564992;
			if (num != 0)
			{
			}
			object obj = this.j;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_AA;
				}
				int num4;
				for (;;)
				{
					IL_88:
					switch (num4)
					{
					case 0:
						if (this.h != null)
						{
							num = (short)2067660804;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E;
					case 1:
						goto IL_198;
					case 2:
						goto IL_1B0;
					case 3:
						goto IL_13E;
					case 4:
						try
						{
							global::System.Diagnostics.Trace.Listeners.Remove(this.h);
							this.h.Close();
							this.h.Dispose();
							goto IL_178;
						}
						catch
						{
							goto IL_178;
						}
						goto IL_13E;
						IL_178:
						this.h = null;
						num = (short)1836777475;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b != null)
						{
							num = (short)2071658502;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198;
					case 6:
						global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b.Dispose();
						global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b = null;
						num = (short)402325505;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
					IL_13E:
					num = (short)502857733;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_198:
					num = (short)1390804994;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1B0:
				goto IL_21C;
				IL_AA:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)325648384;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_88;
			}
			finally
			{
				num = (short)1160773632;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1E4;
						}
						continue;
					case 1:
						goto IL_219;
					case 2:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)977731585;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1E4:
					if (!flag)
					{
						break;
					}
					num = (short)1723269122;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_219:;
			}
			IL_21C:
			num = (short)942080001;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000DC14 File Offset: 0x0000BE14
		public void Dispose()
		{
			short num = (short)967176680;
			short num2 = num;
			num = (short)173142504;
			switch (num2 == num)
			{
			}
			num = (short)1049231361;
			if (num != 0)
			{
			}
			num = (short)286261248;
			if (num != 0)
			{
			}
			num = (short)643760128;
			short num3 = num;
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		// Note: this type is marked as 'beforefieldinit'.
		static TraceLoggerPC()
		{
			short num = (short)1571755629;
			short num2 = num;
			num = (short)1452545645;
			switch (num2 == num)
			{
			}
			num = (short)251527169;
			if (num != 0)
			{
			}
			num = (short)1960509440;
			if (num != 0)
			{
			}
			num = (short)1670119424;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.a = new global::System.Diagnostics.TraceSwitch("CommonCommunicationTraceSwitch", "Common Communication Trace", "Off");
			global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.b = new global::Motorola.Common.Communication.CommonUtil.EventLogger(null);
			global::Motorola.Common.Communication.CommonUtil.TraceLoggerPC.c = global::System.Diagnostics.Process.GetCurrentProcess().ProcessName;
		}

		// Token: 0x0400022B RID: 555
		private static readonly global::System.Diagnostics.TraceSwitch a;

		// Token: 0x0400022C RID: 556
		private static global::Motorola.Common.Communication.CommonUtil.EventLogger b;

		// Token: 0x0400022D RID: 557
		private static string c;

		// Token: 0x0400022E RID: 558
		private const int d = 52428800;

		// Token: 0x0400022F RID: 559
		private const int e = 49161;

		// Token: 0x04000230 RID: 560
		private string f = string.Empty;

		// Token: 0x04000231 RID: 561
		private string g = string.Empty;

		// Token: 0x04000232 RID: 562
		private global::System.Diagnostics.TextWriterTraceListener h;

		// Token: 0x04000233 RID: 563
		private object i = new object();

		// Token: 0x04000234 RID: 564
		private object j = new object();
	}
}
