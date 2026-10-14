using System;
using System.Diagnostics;
using Motorola.Common.Communication.CommonUtility;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000014 RID: 20
	public class EventLogger : global::System.IDisposable
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000073C0 File Offset: 0x000055C0
		public EventLogger(string name = null)
		{
			if (name == null)
			{
				name = global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.DeviceComunicationLogsFolderName;
			}
			this.b = name;
			this.CreateEventLog();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000073F0 File Offset: 0x000055F0
		public void CreateEventLog()
		{
			short num;
			try
			{
				num = (short)657915905;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)161087489;
						if (num != 0)
						{
						}
						goto IL_EF;
					case 1:
					{
						num = (short)95757560;
						short num3 = num;
						num = (short)690365688;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A1;
						default:
							num = (short)314310656;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7D;
							}
							continue;
						}
						break;
					}
					case 2:
						goto IL_A1;
					case 3:
						goto IL_133;
					}
					IL_7D:
					if (!global::System.Diagnostics.EventLog.SourceExists(this.b))
					{
						num = (short)539164674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EF;
					IL_A1:
					global::System.Diagnostics.EventLog.CreateEventSource(this.b, "Application");
					num = (short)26935296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF:
					this.a = new global::System.Diagnostics.EventLog();
					this.a.Source = this.b;
					this.a.Log = "Application";
					num = (short)1408958467;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_133:;
			}
			catch (global::System.Exception)
			{
				this.a = null;
			}
			num = (short)1530920960;
			short num4 = num;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007580 File Offset: 0x00005780
		public void WriteError(string message)
		{
			short num = (short)964362242;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1477266546;
				short num3 = num;
				num = (short)537218162;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)99287040;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1536753664;
						short num4 = num;
						if (this.a != null)
						{
							num = (short)2088239108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						goto IL_BF;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 3:
						this.CreateEventLog();
						num = (short)1094123521;
						if (num != 0)
						{
						}
						num = (short)535363585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							this.a.WriteEntry(message, global::System.Diagnostics.EventLogEntryType.Error);
							return;
						}
						catch
						{
							return;
						}
						goto IL_BF;
					}
					IL_85:
					if (this.a == null)
					{
						num = (short)1415053315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_BF:
				num = (short)696254464;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000770C File Offset: 0x0000590C
		public void WriteWarning(string message)
		{
			short num = (short)548798465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)663093248;
						short num3 = num;
						num = (short)1795686404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					this.CreateEventLog();
					num = (short)802291715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)181419219;
					short num4 = num;
					num = (short)224607443;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)532676608;
						if (num != 0)
						{
						}
						goto IL_9C;
					}
					break;
				}
				case 4:
					try
					{
						this.a.WriteEntry(message, global::System.Diagnostics.EventLogEntryType.Warning);
						return;
					}
					catch
					{
						return;
					}
					goto IL_9C;
				}
				IL_3A:
				num = (short)297926657;
				if (num != 0)
				{
				}
				if (this.a == null)
				{
					num = (short)687341570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9C:
				num = (short)479068160;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007898 File Offset: 0x00005A98
		public void WriteInfo(string message)
		{
			short num = (short)1054998529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a != null)
					{
						num = (short)1357578240;
						short num3 = num;
						num = (short)1727463428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					num = (short)1383071745;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 2:
					this.CreateEventLog();
					num = (short)275185667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1495192631;
					short num4 = num;
					num = (short)1849218103;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)56164352;
						if (num != 0)
						{
						}
						goto IL_98;
					}
					break;
				}
				case 4:
					try
					{
						this.a.WriteEntry(message, global::System.Diagnostics.EventLogEntryType.Information);
						return;
					}
					catch
					{
						return;
					}
					goto IL_98;
				}
				IL_61:
				if (this.a == null)
				{
					num = (short)921305090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_98:
				num = (short)1869414400;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007A20 File Offset: 0x00005C20
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)147521540;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)133496832;
					short num3 = num;
					num = (short)2142961669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_1A2;
				case 2:
					num = (short)2085027846;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					num = (short)559022081;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 5:
					if (this.a != null)
					{
						num = (short)77463559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A2;
				case 6:
				{
					num = (short)619028645;
					short num4 = num;
					num = (short)1187094693;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A3;
					default:
						num = (short)1397293056;
						if (num != 0)
						{
						}
						if (disposing)
						{
							num = (short)910491648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A2;
					}
					break;
				}
				case 7:
					this.a.Close();
					this.a.Dispose();
					goto IL_A3;
				}
				IL_6C:
				if (!this.c)
				{
					num = (short)379125762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A3:
				num = (short)228589569;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A2:
				this.c = true;
				num = (short)1119092739;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007BF4 File Offset: 0x00005DF4
		public void Dispose()
		{
			short num = (short)1882379410;
			short num2 = num;
			num = (short)816305298;
			switch (num2 == num)
			{
			}
			num = (short)1355087872;
			short num3 = num;
			num = (short)791740417;
			if (num != 0)
			{
			}
			num = (short)2088370176;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000048 RID: 72
		private global::System.Diagnostics.EventLog a;

		// Token: 0x04000049 RID: 73
		private string b;

		// Token: 0x0400004A RID: 74
		private bool c;
	}
}
