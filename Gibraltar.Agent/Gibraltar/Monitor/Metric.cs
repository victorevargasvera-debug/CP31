using System;
using System.Diagnostics;
using System.Threading;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001BC RID: 444
	[global::System.Diagnostics.DebuggerDisplay("Name: {Name}, Id: {Id}, Caption: {Caption}")]
	internal abstract class Metric : global::Loupe.Extensibility.Data.IMetric, global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x06001455 RID: 5205 RVA: 0x0003C1AC File Offset: 0x0003A3AC
		internal Metric(global::Gibraltar.Monitor.MetricDefinition definition, global::Gibraltar.Monitor.Internal.MetricPacket packet)
		{
			if (definition == null)
			{
				throw new global::System.ArgumentNullException("definition");
			}
			if (packet == null)
			{
				throw new global::System.ArgumentNullException("packet");
			}
			if (definition.Id != packet.DefinitionId)
			{
				throw new global::System.ArgumentOutOfRangeException("packet", "The provided metric packet has a different definition Id than the provide metric definition.");
			}
			this.m_MetricDefinition = definition;
			this.m_Packet = packet;
			this.m_Samples = this.OnSampleCollectionCreate();
			this.m_MetricDefinition.Metrics.Add(this);
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0003C23C File Offset: 0x0003A43C
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.ID;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0003C24C File Offset: 0x0003A44C
		public string Name
		{
			get
			{
				return this.m_Packet.Name;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0003C25C File Offset: 0x0003A45C
		public string Caption
		{
			get
			{
				return this.m_Packet.Caption;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0003C26C File Offset: 0x0003A46C
		public string Description
		{
			get
			{
				return this.m_Packet.Description;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0003C27C File Offset: 0x0003A47C
		public global::Loupe.Extensibility.Data.IMetricDefinition Definition
		{
			get
			{
				return this.m_MetricDefinition;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0003C284 File Offset: 0x0003A484
		public string MetricTypeName
		{
			get
			{
				return this.Definition.MetricTypeName;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0003C294 File Offset: 0x0003A494
		public string CategoryName
		{
			get
			{
				return this.Definition.CategoryName;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0003C2A4 File Offset: 0x0003A4A4
		public string CounterName
		{
			get
			{
				return this.Definition.CounterName;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0003C2B4 File Offset: 0x0003A4B4
		public string InstanceName
		{
			get
			{
				return this.m_Packet.InstanceName;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0003C2C4 File Offset: 0x0003A4C4
		public bool IsDefault
		{
			get
			{
				return string.IsNullOrEmpty(this.m_Packet.InstanceName);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
		public global::System.DateTimeOffset StartDateTime
		{
			get
			{
				if (this.m_Samples.Count == 0)
				{
					throw new global::System.InvalidOperationException("there are no samples recorded for this metric so the start date is not available.");
				}
				return this.m_Samples.First.Timestamp;
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x0003C308 File Offset: 0x0003A508
		public global::System.DateTimeOffset EndDateTime
		{
			get
			{
				if (this.m_Samples.Count == 0)
				{
					throw new global::System.InvalidOperationException("there are no samples recorded for this metric so the start date is not available.");
				}
				return this.m_Samples.Last.Timestamp;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0003C338 File Offset: 0x0003A538
		public global::Loupe.Extensibility.Data.SampleType SampleType
		{
			get
			{
				return this.Definition.SampleType;
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0003C348 File Offset: 0x0003A548
		public int CompareTo(global::Gibraltar.Monitor.Metric other)
		{
			if (this.m_Packet.ID == other.Id)
			{
				return 0;
			}
			return string.Compare(this.m_Packet.Name, other.Name, global::System.StringComparison.InvariantCulture);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0003C390 File Offset: 0x0003A590
		public bool Equals(global::Gibraltar.Monitor.Metric other)
		{
			return other == this || (other != null && this.Id == other.Id);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0003C3B4 File Offset: 0x0003A5B4
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.Metric other = obj as global::Gibraltar.Monitor.Metric;
			return this.Equals(other);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0003C3D4 File Offset: 0x0003A5D4
		public override int GetHashCode()
		{
			return this.Id.GetHashCode();
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0003C3FC File Offset: 0x0003A5FC
		public static bool operator ==(global::Gibraltar.Monitor.Metric left, global::Gibraltar.Monitor.Metric right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0003C410 File Offset: 0x0003A610
		public static bool operator !=(global::Gibraltar.Monitor.Metric left, global::Gibraltar.Monitor.Metric right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0003C428 File Offset: 0x0003A628
		public static bool operator <(global::Gibraltar.Monitor.Metric left, global::Gibraltar.Monitor.Metric right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0003C434 File Offset: 0x0003A634
		public static bool operator >(global::Gibraltar.Monitor.Metric left, global::Gibraltar.Monitor.Metric right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0003C440 File Offset: 0x0003A640
		public global::System.DateTimeOffset CalculateOffset(global::System.DateTimeOffset baseline, global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals)
		{
			if (intervals == 0 && interval != global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest)
			{
				throw new global::System.ArgumentOutOfRangeException("intervals", intervals, "The number of intervals can't be zero if the interval isn't set to Shortest.");
			}
			global::System.DateTimeOffset result;
			switch (interval)
			{
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Default:
				if (this.Definition.Interval != global::Loupe.Extensibility.Data.MetricSampleInterval.Default)
				{
					result = this.CalculateOffset(baseline, this.Definition.Interval, intervals);
				}
				else
				{
					result = this.CalculateOffset(baseline, global::Loupe.Extensibility.Data.MetricSampleInterval.Second, intervals);
				}
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest:
				result = baseline.AddMilliseconds(16.0);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Millisecond:
				result = baseline.AddMilliseconds((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Second:
				result = baseline.AddSeconds((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Minute:
				result = baseline.AddMinutes((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Hour:
				result = baseline.AddHours((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Day:
				result = baseline.AddDays((double)intervals);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Week:
				result = baseline.AddDays((double)(intervals * 7));
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Month:
				result = baseline.AddMonths(intervals);
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException("interval");
			}
			return result;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0003C56C File Offset: 0x0003A76C
		public static global::System.TimeSpan CalculateOffsetTolerance(global::Loupe.Extensibility.Data.MetricSampleInterval interval)
		{
			global::System.TimeSpan result;
			switch (interval)
			{
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Default:
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest:
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Millisecond:
				result = new global::System.TimeSpan(1L);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Second:
				result = new global::System.TimeSpan(0, 0, 0, 0, 10);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Minute:
				result = new global::System.TimeSpan(0, 0, 0, 2);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Hour:
				result = new global::System.TimeSpan(0, 1, 0);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Day:
				result = new global::System.TimeSpan(0, 30, 0);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Week:
				result = new global::System.TimeSpan(12, 0, 0);
				break;
			case global::Loupe.Extensibility.Data.MetricSampleInterval.Month:
				result = new global::System.TimeSpan(2, 0, 0, 0);
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException("interval");
			}
			return result;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0003C628 File Offset: 0x0003A828
		public global::Loupe.Extensibility.Data.IMetricValueCollection CalculateValues()
		{
			if (this.m_Samples.Count == 0)
			{
				return this.CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval.Default, 1, null, null);
			}
			return this.CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval.Default, 1, new global::System.DateTimeOffset?(this.StartDateTime), new global::System.DateTimeOffset?(this.EndDateTime));
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0003C684 File Offset: 0x0003A884
		public global::Loupe.Extensibility.Data.IMetricValueCollection CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals)
		{
			if (this.m_Samples.Count == 0)
			{
				return this.CalculateValues(interval, intervals, null, null);
			}
			return this.CalculateValues(interval, intervals, new global::System.DateTimeOffset?(this.StartDateTime), new global::System.DateTimeOffset?(this.EndDateTime));
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0003C6E0 File Offset: 0x0003A8E0
		public global::Loupe.Extensibility.Data.IMetricValueCollection CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset? startDateTime, global::System.DateTimeOffset? endDateTime)
		{
			global::System.DateTimeOffset startDateTime2 = (startDateTime != null) ? startDateTime.Value : ((this.m_Samples.Count > 0) ? this.StartDateTime : global::System.DateTimeOffset.MinValue);
			global::System.DateTimeOffset endDateTime2 = (endDateTime != null) ? endDateTime.Value : ((this.m_Samples.Count > 0) ? this.EndDateTime : global::System.DateTimeOffset.MinValue);
			if (intervals < 0 || (interval != global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest && intervals == 0))
			{
				throw new global::System.ArgumentOutOfRangeException("intervals", intervals, "Negative intervals are not supported for calculating values.  Specify an interval count greater than zero, except for the Shortest interval where the interval count is ignored.");
			}
			if (interval == global::Loupe.Extensibility.Data.MetricSampleInterval.Millisecond && intervals < 16)
			{
				intervals = 16;
			}
			return this.OnCalculateValues(interval, intervals, startDateTime2, endDateTime2);
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0003C7AC File Offset: 0x0003A9AC
		public global::Loupe.Extensibility.Data.IMetricSampleCollection Samples
		{
			get
			{
				return this.m_Samples;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0003C7B4 File Offset: 0x0003A9B4
		internal global::Gibraltar.Monitor.Internal.MetricPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0003C7BC File Offset: 0x0003A9BC
		internal long GetSampleSequence()
		{
			return global::System.Threading.Interlocked.Increment(ref this.m_SampleSequence);
		}

		// Token: 0x06001473 RID: 5235
		internal abstract global::Gibraltar.Monitor.MetricSample OnMetricSampleRead(global::Gibraltar.Monitor.Internal.MetricSamplePacket packet);

		// Token: 0x06001474 RID: 5236
		protected abstract global::Gibraltar.Monitor.MetricSampleCollection OnSampleCollectionCreate();

		// Token: 0x06001475 RID: 5237
		protected abstract global::Gibraltar.Monitor.MetricValueCollection OnCalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime);

		// Token: 0x040006AC RID: 1708
		private readonly global::Gibraltar.Monitor.MetricDefinition m_MetricDefinition;

		// Token: 0x040006AD RID: 1709
		private readonly global::Gibraltar.Monitor.Internal.MetricPacket m_Packet;

		// Token: 0x040006AE RID: 1710
		private readonly global::Gibraltar.Monitor.MetricSampleCollection m_Samples;

		// Token: 0x040006AF RID: 1711
		private long m_SampleSequence;
	}
}
