using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Gibraltar.Monitor.Net
{
	// Token: 0x020001D8 RID: 472
	internal class ProcessMonitor : global::System.IDisposable
	{
		// Token: 0x06001685 RID: 5765 RVA: 0x00046128 File Offset: 0x00044328
		public ProcessMonitor(bool monitorThreads)
		{
			this.m_ProcessId = global::System.Diagnostics.Process.GetCurrentProcess().Id;
			this.m_MonitoredProcess = global::System.Diagnostics.Process.GetProcessById(this.m_ProcessId);
			this.m_MonitorThreads = monitorThreads;
			this.Register();
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00046190 File Offset: 0x00044390
		public ProcessMonitor(bool monitorThreads, int processId)
		{
			this.m_ProcessId = processId;
			this.m_MonitoredProcess = global::System.Diagnostics.Process.GetProcessById(this.m_ProcessId);
			this.m_MonitorThreads = monitorThreads;
			this.Register();
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000461F0 File Offset: 0x000443F0
		public void Poll()
		{
			global::System.Collections.Generic.List<global::Gibraltar.Monitor.MetricSample> list = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.MetricSample>();
			if (this.m_MonitoredProcess.HasExited)
			{
				return;
			}
			this.m_MonitoredProcess.Refresh();
			try
			{
				global::System.TimeSpan timeSpan = global::System.DateTime.Now - this.m_MonitoredProcess.StartTime;
				list.Add(this.m_ProcessPercentProcessorTime.CreateSample((double)this.m_MonitoredProcess.TotalProcessorTime.Ticks, (double)timeSpan.Ticks));
				list.Add(this.m_ProcessPercentUserProcessorTime.CreateSample((double)this.m_MonitoredProcess.UserProcessorTime.Ticks, (double)timeSpan.Ticks));
				list.Add(this.m_ProcessPercentPrivilegedProcessorTime.CreateSample((double)this.m_MonitoredProcess.PrivilegedProcessorTime.Ticks, (double)timeSpan.Ticks));
				list.Add(this.m_ProcessNonpagedSystemMemorySize.CreateSample((double)this.m_MonitoredProcess.NonpagedSystemMemorySize64));
				list.Add(this.m_ProcessPagedMemorySize.CreateSample((double)this.m_MonitoredProcess.PagedMemorySize64));
				list.Add(this.m_ProcessPagedSystemMemorySize.CreateSample((double)this.m_MonitoredProcess.PagedSystemMemorySize64));
				list.Add(this.m_ProcessPeakPagedMemorySize.CreateSample((double)this.m_MonitoredProcess.PeakPagedMemorySize64));
				list.Add(this.m_ProcessPeakVirtualMemorySize.CreateSample((double)this.m_MonitoredProcess.PeakVirtualMemorySize64));
				list.Add(this.m_ProcessPeakWorkingSet.CreateSample((double)this.m_MonitoredProcess.PeakWorkingSet64));
				list.Add(this.m_ProcessPrivateMemorySize.CreateSample((double)this.m_MonitoredProcess.PrivateMemorySize64));
				list.Add(this.m_ProcessVirtualMemorySize.CreateSample((double)this.m_MonitoredProcess.VirtualMemorySize64));
				list.Add(this.m_ProcessWorkingSet.CreateSample((double)this.m_MonitoredProcess.WorkingSet64));
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			bool monitorThreads = this.m_MonitorThreads;
			global::Gibraltar.Monitor.Log.Write(list);
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x000463FC File Offset: 0x000445FC
		public global::System.Diagnostics.Process MonitoredProcess
		{
			get
			{
				return this.m_MonitoredProcess;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00046404 File Offset: 0x00044604
		public int ProcessId
		{
			get
			{
				return this.m_ProcessId;
			}
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0004640C File Offset: 0x0004460C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0004641C File Offset: 0x0004461C
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				this.m_MonitoredProcess.Dispose();
			}
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00046430 File Offset: 0x00044630
		private void Register()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_ProcessPercentProcessorTime = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Processor", "Total Processor Time", global::Gibraltar.Monitor.MetricSampleType.TotalFraction)
				{
					Description = "The percentage of processor capacity used by the process.",
					UnitCaption = "%"
				}.Metrics.Add(null);
				this.m_ProcessPercentUserProcessorTime = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Processor", "User Processor Time", global::Gibraltar.Monitor.MetricSampleType.TotalFraction)
				{
					Description = "The percentage of processor capacity used by the process for non-privileged tasks.",
					UnitCaption = "%"
				}.Metrics.Add(null);
				this.m_ProcessPercentPrivilegedProcessorTime = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Processor", "Privileged Processor Time", global::Gibraltar.Monitor.MetricSampleType.TotalFraction)
				{
					Description = "The percentage of processor capacity used by the process for privileged tasks.",
					UnitCaption = "%"
				}.Metrics.Add(null);
				this.m_ProcessNonpagedSystemMemorySize = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Nonpaged System Memory Size", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The amount of nonpaged system memory allocated for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				this.m_ProcessPagedMemorySize = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Paged Memory Size", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The amount of paged memory allocated for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				this.m_ProcessPagedSystemMemorySize = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Paged System Memory Size", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The amount of pageable system memory allocated for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				this.m_ProcessPeakPagedMemorySize = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Peak Paged Memory Size", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The maximum amount of memory in the virtual memory paging file for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				this.m_ProcessPeakVirtualMemorySize = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Peak Virtual Memory Size", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The maximum amount of virtual memory used for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				this.m_ProcessPeakWorkingSet = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Peak Working Set", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The maximum amount of physical memory used for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				this.m_ProcessPrivateMemorySize = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Private Memory Size", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The amount of private memory allocated for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				this.m_ProcessVirtualMemorySize = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Virtual Memory Size", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The amount of virtual memory allocated for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				this.m_ProcessWorkingSet = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, "Process", "Process.Memory", "Working Set", global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					Description = "The amount of physical memory allocated for the process.",
					UnitCaption = "Bytes"
				}.Metrics.Add(null);
				bool monitorThreads = this.m_MonitorThreads;
			}
		}

		// Token: 0x04000751 RID: 1873
		public const string ProcessMetricType = "Process";

		// Token: 0x04000752 RID: 1874
		public const string CounterNonpagedSystemMemorySize = "Nonpaged System Memory Size";

		// Token: 0x04000753 RID: 1875
		public const string CounterPagedMemorySize = "Paged Memory Size";

		// Token: 0x04000754 RID: 1876
		public const string CounterPagedSystemMemorySize = "Paged System Memory Size";

		// Token: 0x04000755 RID: 1877
		public const string CounterPeakPagedMemorySize = "Peak Paged Memory Size";

		// Token: 0x04000756 RID: 1878
		public const string CounterPeakVirtualMemorySize = "Peak Virtual Memory Size";

		// Token: 0x04000757 RID: 1879
		public const string CounterPeakWorkingSet = "Peak Working Set";

		// Token: 0x04000758 RID: 1880
		public const string CounterPrivateMemorySize = "Private Memory Size";

		// Token: 0x04000759 RID: 1881
		public const string CounterPrivilegedProcessorTime = "Privileged Processor Time";

		// Token: 0x0400075A RID: 1882
		public const string CounterTotalProcessorTime = "Total Processor Time";

		// Token: 0x0400075B RID: 1883
		public const string CounterUserProcessorTime = "User Processor Time";

		// Token: 0x0400075C RID: 1884
		public const string CounterVirtualMemorySize = "Virtual Memory Size";

		// Token: 0x0400075D RID: 1885
		public const string CounterWorkingSet = "Working Set";

		// Token: 0x0400075E RID: 1886
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.CustomSampledMetricDefinition> m_MetricDefinitions = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.CustomSampledMetricDefinition>();

		// Token: 0x0400075F RID: 1887
		private readonly int m_ProcessId;

		// Token: 0x04000760 RID: 1888
		private readonly object m_Lock = new object();

		// Token: 0x04000761 RID: 1889
		private readonly bool m_MonitorThreads;

		// Token: 0x04000762 RID: 1890
		private readonly global::System.Diagnostics.Process m_MonitoredProcess;

		// Token: 0x04000763 RID: 1891
		private readonly global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Gibraltar.Monitor.CustomSampledMetric>> m_MonitoredThreads = new global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::Gibraltar.Monitor.CustomSampledMetric>>();

		// Token: 0x04000764 RID: 1892
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPercentProcessorTime;

		// Token: 0x04000765 RID: 1893
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPercentUserProcessorTime;

		// Token: 0x04000766 RID: 1894
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPercentPrivilegedProcessorTime;

		// Token: 0x04000767 RID: 1895
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessNonpagedSystemMemorySize;

		// Token: 0x04000768 RID: 1896
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPagedMemorySize;

		// Token: 0x04000769 RID: 1897
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPagedSystemMemorySize;

		// Token: 0x0400076A RID: 1898
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPeakPagedMemorySize;

		// Token: 0x0400076B RID: 1899
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPeakVirtualMemorySize;

		// Token: 0x0400076C RID: 1900
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPeakWorkingSet;

		// Token: 0x0400076D RID: 1901
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessPrivateMemorySize;

		// Token: 0x0400076E RID: 1902
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessVirtualMemorySize;

		// Token: 0x0400076F RID: 1903
		private global::Gibraltar.Monitor.CustomSampledMetric m_ProcessWorkingSet;
	}
}
