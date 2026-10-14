using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using Gibraltar.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x02000222 RID: 546
	internal class LocalServerDiscoveryFile
	{
		// Token: 0x06001B95 RID: 7061 RVA: 0x0005FDDC File Offset: 0x0005DFDC
		public LocalServerDiscoveryFile(string fileNamePath)
		{
			this.FileNamePath = fileNamePath;
			using (global::System.IO.FileStream fileStream = global::System.IO.File.Open(this.FileNamePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read | global::System.IO.FileShare.Write | global::System.IO.FileShare.Delete))
			{
				this.Read(fileStream);
			}
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0005FE30 File Offset: 0x0005E030
		public LocalServerDiscoveryFile(int publisher, int subscriber, int processId, global::System.IO.FileStream destination)
		{
			this.PublisherPort = publisher;
			this.SubscriberPort = subscriber;
			this.ProcessId = processId;
			this.Write(destination);
			this.Read(destination);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0005FE6C File Offset: 0x0005E06C
		private void Write(global::System.IO.FileStream destination)
		{
			byte[] array = new byte[12];
			int num = 0;
			foreach (byte b in global::Gibraltar.Data.BinarySerializer.SerializeValue(this.ProcessId))
			{
				array[num++] = b;
			}
			foreach (byte b2 in global::Gibraltar.Data.BinarySerializer.SerializeValue(this.PublisherPort))
			{
				array[num++] = b2;
			}
			foreach (byte b3 in global::Gibraltar.Data.BinarySerializer.SerializeValue(this.SubscriberPort))
			{
				array[num++] = b3;
			}
			destination.Position = 0L;
			destination.Write(array, 0, array.Length);
			destination.SetLength((long)array.Length);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0005FF28 File Offset: 0x0005E128
		private void Read(global::System.IO.FileStream source)
		{
			source.Position = 0L;
			int num;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(source, out num);
			this.ProcessId = num;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(source, out num);
			this.PublisherPort = num;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(source, out num);
			this.SubscriberPort = num;
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0005FF70 File Offset: 0x0005E170
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0005FF78 File Offset: 0x0005E178
		public int PublisherPort { get; private set; }

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0005FF84 File Offset: 0x0005E184
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0005FF8C File Offset: 0x0005E18C
		public int SubscriberPort { get; private set; }

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0005FF98 File Offset: 0x0005E198
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0005FFA0 File Offset: 0x0005E1A0
		public int ProcessId { get; private set; }

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0005FFAC File Offset: 0x0005E1AC
		public bool IsAlive
		{
			get
			{
				bool flag = global::System.IO.File.Exists(this.FileNamePath);
				if (flag)
				{
					try
					{
						global::System.Diagnostics.Process.GetProcessById(this.ProcessId);
					}
					catch (global::System.Exception ex)
					{
						if (ex is global::System.ArgumentException)
						{
							flag = false;
						}
					}
				}
				if (flag)
				{
					try
					{
						global::System.Net.IPEndPoint[] activeTcpListeners = global::System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners();
						bool flag2 = false;
						foreach (global::System.Net.IPEndPoint ipendPoint in activeTcpListeners)
						{
							if (global::System.Net.IPAddress.IsLoopback(ipendPoint.Address) && ipendPoint.Port == this.PublisherPort)
							{
								flag2 = true;
								break;
							}
						}
						flag = flag2;
					}
					catch (global::System.Exception)
					{
					}
				}
				if (!flag)
				{
					global::Gibraltar.Data.Win32Helper.SafeDeleteFile(this.FileNamePath);
				}
				return flag;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00060080 File Offset: 0x0005E280
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x00060088 File Offset: 0x0005E288
		public string FileNamePath { get; private set; }

		// Token: 0x040009EC RID: 2540
		public const string Extension = "gpd";

		// Token: 0x040009ED RID: 2541
		public const string FileFilter = "*.gpd";
	}
}
