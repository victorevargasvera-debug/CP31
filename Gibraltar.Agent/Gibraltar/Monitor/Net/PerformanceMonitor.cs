using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Net
{
	// Token: 0x020001D7 RID: 471
	internal class PerformanceMonitor
	{
		// Token: 0x0600167D RID: 5757 RVA: 0x00045700 File Offset: 0x00043900
		public void Initialize(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (configuration.EnableDiskPerformance && this.m_DiskCounters == null)
				{
					this.InitializeDiskCounters();
				}
				if (configuration.EnableNetworkPerformance && this.m_NetworkCounters == null)
				{
					this.InitializeNetworkCounters();
				}
				if (configuration.EnableSystemPerformance && this.m_SystemCounters == null)
				{
					this.InitializeSystemCounters();
				}
				if (configuration.EnableMemoryPerformance && this.m_MemoryCounters == null)
				{
					this.InitializeMemoryCounters();
				}
				this.m_EnableDiskCounters = configuration.EnableDiskPerformance;
				this.m_EnableMemoryCounters = configuration.EnableMemoryPerformance;
				this.m_EnableNetworkCounters = configuration.EnableNetworkPerformance;
				this.m_EnableSystemCounters = configuration.EnableSystemPerformance;
				this.m_Initialized = true;
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000457E8 File Offset: 0x000439E8
		public void Poll()
		{
			if (!this.m_Initialized)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Gibraltar.Agent", "Skipping counter poll because object is not yet initialized.", "This shouldn't happen unless the Performance Monitor is being misused.", new object[0]);
				return;
			}
			if (this.m_BusyPolling)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Gibraltar.Agent", "Skipping counter poll because we are still polling.", "If this situation persists, slow down the requested poll rate because it is too fast for the system.", new object[0]);
				return;
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				try
				{
					this.m_BusyPolling = true;
					if (this.m_SystemCounters != null && this.m_EnableSystemCounters)
					{
						this.m_SystemCounters.WriteSamples();
					}
					if (this.m_MemoryCounters != null && this.m_EnableMemoryCounters)
					{
						this.m_MemoryCounters.WriteSamples();
					}
					if (this.m_DiskCounters != null && this.m_EnableDiskCounters)
					{
						this.m_DiskCounters.WriteSamples();
					}
					if (this.m_NetworkCounters != null && this.m_EnableNetworkCounters)
					{
						this.m_NetworkCounters.WriteSamples();
					}
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Agent", "Failed to poll performance counters due to an exception.", "Exception type: {0}\r\nException message: {1}\r\n", new object[]
						{
							ex.GetType().FullName,
							ex.Message
						});
					}
				}
				finally
				{
					this.m_BusyPolling = false;
				}
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x0004596C File Offset: 0x00043B6C
		private void InitializeDiskCounters()
		{
			if (global::Gibraltar.Monitor.Log.IsMonoRuntime)
			{
				return;
			}
			this.m_DiskCounters = new global::Gibraltar.Monitor.PerfCounterCollection("Disk Counters", "System-wide disk performance counters (not specific to the process being monitored)");
			try
			{
				string[] instanceNames = new global::System.Diagnostics.PerformanceCounterCategory("LogicalDisk").GetInstanceNames();
				global::System.IO.DriveInfo[] drives = global::System.IO.DriveInfo.GetDrives();
				global::System.Collections.Generic.Dictionary<string, global::System.IO.DriveInfo> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.IO.DriveInfo>(drives.Length, global::System.StringComparer.OrdinalIgnoreCase);
				foreach (global::System.IO.DriveInfo driveInfo in drives)
				{
					try
					{
						if (driveInfo.DriveType == global::System.IO.DriveType.Fixed && driveInfo.IsReady)
						{
							string text = driveInfo.Name;
							int num = text.IndexOf(":");
							if (num > -1)
							{
								text = text.Substring(0, num + 1);
							}
							dictionary.Add(text, driveInfo);
						}
					}
					catch
					{
					}
				}
				foreach (string text2 in instanceNames)
				{
					string key = text2.TrimStart(new char[]
					{
						' ',
						'0',
						'1',
						'2',
						'3',
						'4',
						'5',
						'6',
						'7',
						'8',
						'9'
					});
					if (dictionary.ContainsKey(key))
					{
						this.m_DiskCounters.Add("LogicalDisk", "% Disk Time", text2);
						this.m_DiskCounters.Add("LogicalDisk", "Avg. Disk Queue Length", text2);
						this.m_DiskCounters.Add("LogicalDisk", "Avg. Disk sec/Transfer", text2);
						this.m_DiskCounters.Add("LogicalDisk", "Disk Transfers/sec", text2);
						this.m_DiskCounters.Add("LogicalDisk", "Disk Reads/sec", text2);
						this.m_DiskCounters.Add("LogicalDisk", "Disk Writes/sec", text2);
						this.m_DiskCounters.Add("LogicalDisk", "Disk Bytes/sec", text2);
						this.m_DiskCounters.Add("LogicalDisk", "Free Megabytes", text2);
						this.m_DiskCounters.Add("LogicalDisk", "% Free Space", text2);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.KeepAlive(ex);
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Agent", "Unable to record performance information for disk counters", "Specific exception: {0}\r\nException message: {1}", new object[]
				{
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00045BCC File Offset: 0x00043DCC
		private void InitializeNetworkCounters()
		{
			this.m_NetworkCounters = new global::Gibraltar.Monitor.PerfCounterCollection("Network Counters", "System-wide network performance counters (not specific to the process being monitored)");
			try
			{
				foreach (string text in new global::System.Diagnostics.PerformanceCounterCategory("Network Interface").GetInstanceNames())
				{
					if (text != "MS TCP Loopback interface" && text != "lo")
					{
						this.m_NetworkCounters.Add("Network Interface", "Bytes Received/sec", text);
						this.m_NetworkCounters.Add("Network Interface", "Bytes Sent/sec", text);
						if (global::Gibraltar.Monitor.Log.IsMonoRuntime)
						{
							this.m_NetworkCounters.Add("Network Interface", "Bytes Total/sec", text);
						}
						else
						{
							this.m_NetworkCounters.Add("Network Interface", "Current Bandwidth", text);
							this.m_NetworkCounters.Add("Network Interface", "Packets Received Errors", text);
							this.m_NetworkCounters.Add("Network Interface", "Packets Outbound Errors", text);
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.KeepAlive(ex);
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Agent", "Unable to record performance information for network counters", "Specific exception: {0}\r\nException message: {1}", new object[]
				{
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00045D24 File Offset: 0x00043F24
		private void InitializeMemoryCounters()
		{
			this.m_MemoryCounters = new global::Gibraltar.Monitor.PerfCounterCollection(".NET Memory Counters", "Detailed memory utilization counters specific to .NET");
			try
			{
				this.m_MemoryCounters.Add(".NET CLR Memory", "# GC Handles", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "# Bytes in all Heaps", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "# Gen 0 Collections", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "# Gen 1 Collections", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "# Gen 2 Collections", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "Large Object Heap Size", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "Gen 0 heap size", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "Gen 1 heap size", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "Gen 2 heap size", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_MemoryCounters.Add(".NET CLR Memory", "% Time in GC", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.KeepAlive(ex);
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Agent", "Unable to record performance information for .NET memory counters", "Specific exception: {0}\r\nException message: {1}", new object[]
				{
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00045E78 File Offset: 0x00044078
		private void InitializeSystemCounters()
		{
			this.m_SystemCounters = new global::Gibraltar.Monitor.PerfCounterCollection("System Counters", "System-wide performance counters (not specific to the process being monitored)");
			try
			{
				if (global::Gibraltar.Monitor.Log.IsMonoRuntime)
				{
					this.m_SystemCounters.Add("Processor", "% Processor Time", "_Total");
				}
				else
				{
					this.m_SystemCounters.Add("System", "Processor Queue Length");
					this.m_SystemCounters.Add("Processor", "% Processor Time", "_Total");
					this.m_SystemCounters.Add("Memory", "Committed Bytes");
					this.m_SystemCounters.Add("Memory", "Available Bytes");
					this.m_SystemCounters.Add("Memory", "Pages/sec");
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.KeepAlive(ex);
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Agent", "Unable to record performance information for system counters", "Specific exception: {0}\r\nException message: {1}", new object[]
				{
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00045F88 File Offset: 0x00044188
		private void InitializeProcessCounters()
		{
			this.m_ProcessCounters = new global::Gibraltar.Monitor.PerfCounterCollection("Process Counters", "Performance counters we capture that are specific to our process");
			try
			{
				this.m_ProcessCounters.Add("Process", "% Processor Time", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "% User Time", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "% Privileged Time", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "Handle Count", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "Page Faults/sec", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "Page File Bytes", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "Pool Nonpaged Bytes", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "Pool Paged Bytes", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "Private Bytes", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "Thread Count", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "Virtual Bytes", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
				this.m_ProcessCounters.Add("Process", "IO Data Bytes/sec", global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess);
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.KeepAlive(ex);
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Agent", "Unable to record performance information for process performance counters", "Specific exception: {0}\r\nException message: {1}", new object[]
				{
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x04000745 RID: 1861
		private readonly object m_Lock = new object();

		// Token: 0x04000746 RID: 1862
		private global::Gibraltar.Monitor.PerfCounterCollection m_DiskCounters;

		// Token: 0x04000747 RID: 1863
		private global::Gibraltar.Monitor.PerfCounterCollection m_NetworkCounters;

		// Token: 0x04000748 RID: 1864
		private global::Gibraltar.Monitor.PerfCounterCollection m_ProcessCounters;

		// Token: 0x04000749 RID: 1865
		private global::Gibraltar.Monitor.PerfCounterCollection m_SystemCounters;

		// Token: 0x0400074A RID: 1866
		private global::Gibraltar.Monitor.PerfCounterCollection m_MemoryCounters;

		// Token: 0x0400074B RID: 1867
		private bool m_Initialized;

		// Token: 0x0400074C RID: 1868
		private bool m_BusyPolling;

		// Token: 0x0400074D RID: 1869
		private bool m_EnableDiskCounters;

		// Token: 0x0400074E RID: 1870
		private bool m_EnableNetworkCounters;

		// Token: 0x0400074F RID: 1871
		private bool m_EnableSystemCounters;

		// Token: 0x04000750 RID: 1872
		private bool m_EnableMemoryCounters;
	}
}
