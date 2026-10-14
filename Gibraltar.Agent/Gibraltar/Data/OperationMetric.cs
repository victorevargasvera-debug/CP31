using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data
{
	// Token: 0x0200025B RID: 603
	internal class OperationMetric : global::System.IDisposable
	{
		// Token: 0x06001EC1 RID: 7873 RVA: 0x0006DAC0 File Offset: 0x0006BCC0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public OperationMetric(string category, string operationName)
		{
			this.Initialize(category, operationName, null, null, null);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x0006DAE4 File Offset: 0x0006BCE4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public OperationMetric(string category, string operationName, string startMessage)
		{
			this.Initialize(category, operationName, startMessage, null, null);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0006DB08 File Offset: 0x0006BD08
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public OperationMetric(string category, string operationName, string startMessage, string endMessage)
		{
			this.Initialize(category, operationName, startMessage, endMessage, null);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0006DB2C File Offset: 0x0006BD2C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public OperationMetric(string category, string operationName, string startMessage, string endMessage, params object[] args)
		{
			this.Initialize(category, operationName, startMessage, endMessage, args);
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x0006DB50 File Offset: 0x0006BD50
		public string OperationName
		{
			get
			{
				return this.m_OperationName;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x0006DB58 File Offset: 0x0006BD58
		public global::System.TimeSpan Duration
		{
			get
			{
				return this.m_Duration;
			}
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0006DB60 File Offset: 0x0006BD60
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0006DB70 File Offset: 0x0006BD70
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_Disposed)
			{
				if (releaseManaged)
				{
					try
					{
						this.StopAndRecordMetric();
						if (this.m_Args == null)
						{
							global::Gibraltar.Monitor.Log.WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, 2, null, null, null, this.m_EndMessage, new object[0]);
						}
						else
						{
							global::Gibraltar.Monitor.Log.WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, 2, null, null, null, this.m_EndMessage, this.m_Args);
						}
					}
					catch
					{
					}
				}
				this.m_Disposed = true;
			}
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0006DBF8 File Offset: 0x0006BDF8
		private void Initialize(string category, string operationName, string startMessage, string endMessage, params object[] args)
		{
			this.m_Timer = global::System.Diagnostics.Stopwatch.StartNew();
			this.m_Category = (string.IsNullOrEmpty(category) ? "Gibraltar.Data" : category);
			this.m_OperationName = (string.IsNullOrEmpty(operationName) ? "Operation" : operationName);
			this.m_Args = args;
			try
			{
				if (string.IsNullOrEmpty(startMessage))
				{
					global::Gibraltar.Monitor.Log.WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, 2, null, null, null, "{0} started.", new object[]
					{
						this.m_OperationName
					});
				}
				else if (this.m_Args == null)
				{
					global::Gibraltar.Monitor.Log.WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, 2, null, null, null, startMessage, new object[0]);
				}
				else
				{
					global::Gibraltar.Monitor.Log.WriteMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, 2, null, null, null, startMessage, this.m_Args);
				}
				if (string.IsNullOrEmpty(endMessage))
				{
					this.m_EndMessage = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "{0} completed.", new object[]
					{
						this.m_OperationName
					});
				}
				else
				{
					this.m_EndMessage = endMessage;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0006DD10 File Offset: 0x0006BF10
		private void StopAndRecordMetric()
		{
			if (this.m_Timer == null)
			{
				this.m_Duration = new global::System.TimeSpan(0L);
			}
			else
			{
				this.m_Timer.Stop();
				this.m_Duration = this.m_Timer.Elapsed;
			}
			global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
			global::Gibraltar.Monitor.EventMetricDefinition eventMetricDefinition;
			if (!global::Gibraltar.Monitor.Log.Metrics.TryGetValue("Gibraltar Software", this.m_Category, "Operation", out metricDefinition))
			{
				eventMetricDefinition = new global::Gibraltar.Monitor.EventMetricDefinition("Gibraltar Software", this.m_Category, "Operation");
				eventMetricDefinition.Description = "Information about each time a data operation is performed";
				global::Gibraltar.Monitor.EventMetricValueDefinitionCollection eventMetricValueDefinitionCollection = (global::Gibraltar.Monitor.EventMetricValueDefinitionCollection)eventMetricDefinition.Values;
				eventMetricValueDefinitionCollection.Add("operationname", typeof(string), "Operation Name", "The operation that was executed.");
				eventMetricValueDefinitionCollection.Add("duration", typeof(global::System.TimeSpan), "Duration", "The duration the operation executed.");
				((global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricDefinition.Values["duration"]).UnitCaption = "Milliseconds";
				eventMetricDefinition.DefaultValue = eventMetricDefinition.Values["duration"];
				eventMetricDefinition = eventMetricDefinition.Register();
			}
			else
			{
				eventMetricDefinition = (global::Gibraltar.Monitor.EventMetricDefinition)metricDefinition;
			}
			global::Loupe.Extensibility.Data.IMetric metric;
			global::Gibraltar.Monitor.EventMetric eventMetric;
			if (!eventMetricDefinition.Metrics.TryGetValue(null, out metric))
			{
				eventMetric = new global::Gibraltar.Monitor.EventMetric(eventMetricDefinition, null);
			}
			else
			{
				eventMetric = (global::Gibraltar.Monitor.EventMetric)metric;
			}
			global::Gibraltar.Monitor.EventMetricSample eventMetricSample = eventMetric.CreateSample();
			eventMetricSample.SetValue("operationname", this.OperationName);
			eventMetricSample.SetValue("duration", this.Duration);
			eventMetricSample.Write();
		}

		// Token: 0x04000B8B RID: 2955
		public const string MetricTypeName = "Gibraltar Software";

		// Token: 0x04000B8C RID: 2956
		public const string MetricCounterName = "Operation";

		// Token: 0x04000B8D RID: 2957
		public const string MetricDefinitionDescription = "Information about each time a data operation is performed";

		// Token: 0x04000B8E RID: 2958
		private global::System.Diagnostics.Stopwatch m_Timer;

		// Token: 0x04000B8F RID: 2959
		private global::System.TimeSpan m_Duration;

		// Token: 0x04000B90 RID: 2960
		private string m_Category;

		// Token: 0x04000B91 RID: 2961
		private string m_OperationName;

		// Token: 0x04000B92 RID: 2962
		private string m_EndMessage;

		// Token: 0x04000B93 RID: 2963
		private object[] m_Args;

		// Token: 0x04000B94 RID: 2964
		private bool m_Disposed;
	}
}
