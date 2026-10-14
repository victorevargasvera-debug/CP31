using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x02000019 RID: 25
	public sealed class EventMetric : global::System.IComparable<global::Gibraltar.Agent.Metrics.EventMetric>, global::System.IEquatable<global::Gibraltar.Agent.Metrics.EventMetric>
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00005860 File Offset: 0x00003A60
		internal EventMetric(global::Gibraltar.Agent.Metrics.EventMetricDefinition definition, string instanceName) : this(definition, new global::Gibraltar.Monitor.EventMetric(definition.WrappedDefinition, instanceName))
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005878 File Offset: 0x00003A78
		internal EventMetric(global::Gibraltar.Agent.Metrics.EventMetricDefinition definition, global::Gibraltar.Monitor.EventMetric metric)
		{
			this.m_MetricDefinition = definition;
			this.m_WrappedMetric = metric;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005890 File Offset: 0x00003A90
		public static void Register(object metricData)
		{
			if (metricData == null)
			{
				throw new global::System.ArgumentNullException("metricData");
			}
			global::Gibraltar.Agent.Metrics.EventMetricDefinition[] array = global::Gibraltar.Agent.Metrics.EventMetricDefinition.RegisterAll(metricData);
			if (!(metricData is global::System.Type))
			{
				foreach (global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition in array)
				{
					if (eventMetricDefinition.IsBound && eventMetricDefinition.NameBound)
					{
						string text = eventMetricDefinition.InvokeInstanceNameBinding(metricData);
						if (text != null)
						{
							global::Gibraltar.Agent.Metrics.EventMetric.Register(eventMetricDefinition, text);
						}
					}
				}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00005910 File Offset: 0x00003B10
		public static global::Gibraltar.Agent.Metrics.EventMetric Register(global::Gibraltar.Agent.Metrics.EventMetricDefinition definition, string instanceName)
		{
			if (definition == null)
			{
				return null;
			}
			object @lock = definition.Lock;
			global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition;
			lock (@lock)
			{
				if (!definition.IsReadOnly)
				{
					eventMetricDefinition = definition.Register();
				}
				else
				{
					eventMetricDefinition = definition;
				}
			}
			global::Gibraltar.Agent.Metrics.EventMetricCollection metrics = eventMetricDefinition.Metrics;
			@lock = metrics.Lock;
			global::Gibraltar.Agent.Metrics.EventMetric result;
			lock (@lock)
			{
				if (!metrics.TryGetValue(instanceName, out result))
				{
					result = metrics.Add(instanceName);
				}
			}
			return result;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000059AC File Offset: 0x00003BAC
		public global::Gibraltar.Agent.Metrics.EventMetricSample CreateSample()
		{
			return new global::Gibraltar.Agent.Metrics.EventMetricSample(this, this.m_WrappedMetric.CreateSample());
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000059C0 File Offset: 0x00003BC0
		internal global::Gibraltar.Agent.Metrics.EventMetricSample CreateSample(object userDataObject)
		{
			if (userDataObject == null)
			{
				throw new global::System.ArgumentNullException("userDataObject");
			}
			if (!this.Definition.IsBound)
			{
				throw new global::System.ArgumentException("This event metric's definition is not bound to sample automatically from a user data object.  CreateSample() and SetValue() must be used to specify the data values directly.");
			}
			global::System.Type type = userDataObject.GetType();
			if (!this.Definition.BoundType.IsAssignableFrom(type))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The provided user data object type ({0}) is not assignable to this event metric's bound type ({1}) and can not be sampled automatically for this metric instance.", new object[]
				{
					type,
					this.Definition.BoundType
				}));
			}
			global::Gibraltar.Agent.Metrics.EventMetricSample eventMetricSample = this.CreateSample();
			foreach (global::Gibraltar.Agent.Metrics.EventMetricValueDefinition eventMetricValueDefinition in ((global::System.Collections.Generic.IEnumerable<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>)this.Definition.ValueCollection))
			{
				if (eventMetricValueDefinition.Bound)
				{
					try
					{
						global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> binding = new global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes>(eventMetricValueDefinition.MemberName, eventMetricValueDefinition.MemberType);
						global::System.Reflection.BindingFlags bindingFlags = this.Definition.GetBindingFlags(binding);
						object value = type.InvokeMember(eventMetricValueDefinition.MemberName, bindingFlags, null, userDataObject, null, global::System.Globalization.CultureInfo.InvariantCulture);
						eventMetricSample.SetValue(eventMetricValueDefinition, value);
					}
					catch
					{
					}
				}
			}
			return eventMetricSample;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public void WriteSample(object metricData)
		{
			this.CreateSample(metricData).Write();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00005B08 File Offset: 0x00003D08
		public static void Write(object metricData, string fallbackInstanceName)
		{
			global::Gibraltar.Agent.Metrics.EventMetricDefinition.Write(metricData, fallbackInstanceName);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00005B14 File Offset: 0x00003D14
		public static void Write(object metricData)
		{
			global::Gibraltar.Agent.Metrics.EventMetricDefinition.Write(metricData, null);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00005B20 File Offset: 0x00003D20
		[global::System.Obsolete("The non-static metricSample.Write() method should be used instead.", true)]
		public static void Write(global::Gibraltar.Agent.Metrics.EventMetricSample metricSample)
		{
			metricSample.Write();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005B28 File Offset: 0x00003D28
		[global::System.Obsolete("The non-static metricSample.Write() method should be used instead.", true)]
		public static void Write(global::Gibraltar.Agent.Metrics.EventMetricSample metricSample, string str)
		{
			metricSample.Write();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005B30 File Offset: 0x00003D30
		[global::System.Obsolete("The non-static metricSample.Write() method should be used instead.", true)]
		public void WriteSample(global::Gibraltar.Agent.Metrics.EventMetricSample metricSample)
		{
			metricSample.Write();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005B38 File Offset: 0x00003D38
		public int CompareTo(global::Gibraltar.Agent.Metrics.EventMetric other)
		{
			return this.WrappedMetric.CompareTo(other.WrappedMetric);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00005B4C File Offset: 0x00003D4C
		public bool Equals(global::Gibraltar.Agent.Metrics.EventMetric other)
		{
			return this.WrappedMetric.Equals(other.WrappedMetric);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00005B60 File Offset: 0x00003D60
		public global::Gibraltar.Agent.Metrics.EventMetricDefinition Definition
		{
			get
			{
				return this.m_MetricDefinition;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00005B68 File Offset: 0x00003D68
		public global::System.Guid Id
		{
			get
			{
				return this.m_WrappedMetric.Id;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00005B78 File Offset: 0x00003D78
		public string Key
		{
			get
			{
				return this.m_WrappedMetric.Name;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00005B88 File Offset: 0x00003D88
		public string Caption
		{
			get
			{
				return this.m_WrappedMetric.Caption;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00005B98 File Offset: 0x00003D98
		public string Description
		{
			get
			{
				return this.m_WrappedMetric.Description;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public string MetricsSystem
		{
			get
			{
				return this.m_MetricDefinition.MetricsSystem;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00005BB8 File Offset: 0x00003DB8
		public string CategoryName
		{
			get
			{
				return this.m_MetricDefinition.CategoryName;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00005BC8 File Offset: 0x00003DC8
		public string CounterName
		{
			get
			{
				return this.m_MetricDefinition.CounterName;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public string InstanceName
		{
			get
			{
				return this.m_WrappedMetric.InstanceName;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public bool IsDefault
		{
			get
			{
				return this.m_WrappedMetric.IsDefault;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00005BF8 File Offset: 0x00003DF8
		internal global::Gibraltar.Monitor.EventMetric WrappedMetric
		{
			get
			{
				return this.m_WrappedMetric;
			}
		}

		// Token: 0x0400005C RID: 92
		private readonly global::Gibraltar.Monitor.EventMetric m_WrappedMetric;

		// Token: 0x0400005D RID: 93
		private readonly global::Gibraltar.Agent.Metrics.EventMetricDefinition m_MetricDefinition;
	}
}
