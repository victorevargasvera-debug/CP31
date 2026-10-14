using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x02000026 RID: 38
	public sealed class SampledMetric : global::System.IComparable<global::Gibraltar.Agent.Metrics.SampledMetric>, global::System.IEquatable<global::Gibraltar.Agent.Metrics.SampledMetric>
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00008068 File Offset: 0x00006268
		internal SampledMetric(global::Gibraltar.Agent.Metrics.SampledMetricDefinition definition, string instanceName) : this(definition, new global::Gibraltar.Monitor.CustomSampledMetric(definition.WrappedDefinition, instanceName))
		{
			definition.Metrics.Internalize(this);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00008098 File Offset: 0x00006298
		internal SampledMetric(global::Gibraltar.Agent.Metrics.SampledMetricDefinition definition, global::Gibraltar.Monitor.CustomSampledMetric metric)
		{
			this.m_MetricDefinition = definition;
			this.m_WrappedMetric = metric;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000080B0 File Offset: 0x000062B0
		internal static global::Gibraltar.Agent.Metrics.SampledMetric[] RegisterAll(object userDataObject, string fallbackInstanceName)
		{
			if (userDataObject == null)
			{
				throw new global::System.ArgumentNullException("userDataObject");
			}
			global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] array = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RegisterAll(userDataObject);
			global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetric> list = new global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetric>();
			if (!(userDataObject is global::System.Type))
			{
				global::System.Type type = null;
				string text = null;
				foreach (global::Gibraltar.Agent.Metrics.SampledMetricDefinition sampledMetricDefinition in array)
				{
					if (sampledMetricDefinition.IsBound && sampledMetricDefinition.NameBound)
					{
						if (sampledMetricDefinition.BoundType != type)
						{
							text = (sampledMetricDefinition.InvokeInstanceNameBinding(userDataObject) ?? fallbackInstanceName);
							type = sampledMetricDefinition.BoundType;
						}
						if (text != null)
						{
							try
							{
								list.Add(global::Gibraltar.Agent.Metrics.SampledMetric.Register(sampledMetricDefinition, text));
							}
							catch
							{
							}
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00008184 File Offset: 0x00006384
		public static void Register(object metricData)
		{
			global::Gibraltar.Agent.Metrics.SampledMetric.RegisterAll(metricData, null);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00008190 File Offset: 0x00006390
		public static global::Gibraltar.Agent.Metrics.SampledMetric Register(string metricsSystem, string categoryName, string counterName, global::Gibraltar.Agent.Metrics.SamplingType samplingType, string unitCaption, string metricCaption, string description, string instanceName)
		{
			return global::Gibraltar.Agent.Metrics.SampledMetric.Register(global::Gibraltar.Agent.Metrics.SampledMetricDefinition.Register(metricsSystem, categoryName, counterName, samplingType, unitCaption, metricCaption, description), instanceName);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000081A8 File Offset: 0x000063A8
		public static global::Gibraltar.Agent.Metrics.SampledMetric Register(global::Gibraltar.Agent.Metrics.SampledMetricDefinition definition, string instanceName)
		{
			if (definition == null)
			{
				return null;
			}
			object @lock = definition.Metrics.Lock;
			global::Gibraltar.Agent.Metrics.SampledMetric result;
			lock (@lock)
			{
				if (!definition.Metrics.TryGetValue(instanceName, out result))
				{
					result = definition.Metrics.Add(instanceName);
				}
			}
			return result;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000820C File Offset: 0x0000640C
		public void WriteSample(double rawValue)
		{
			this.m_WrappedMetric.CreateSample(rawValue).Write();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00008220 File Offset: 0x00006420
		public void WriteSample(double rawValue, global::System.DateTimeOffset rawTimestamp)
		{
			this.m_WrappedMetric.CreateSample(rawValue, rawTimestamp).Write();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00008234 File Offset: 0x00006434
		public void WriteSample(double rawValue, double baseValue)
		{
			this.m_WrappedMetric.CreateSample(rawValue, baseValue).Write();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008248 File Offset: 0x00006448
		public void WriteSample(double rawValue, double baseValue, global::System.DateTimeOffset rawTimestamp)
		{
			this.m_WrappedMetric.CreateSample(rawValue, baseValue, rawTimestamp).Write();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00008260 File Offset: 0x00006460
		public void WriteSample(object metricData)
		{
			if (metricData == null)
			{
				throw new global::System.ArgumentNullException("metricData");
			}
			if (!this.Definition.IsBound)
			{
				throw new global::System.ArgumentException("This sampled metric's definition is not bound to sample automatically from a user data object.  WriteSample(...) must be given the data values directly.");
			}
			global::System.Type type = metricData.GetType();
			if (!this.Definition.BoundType.IsAssignableFrom(type))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The provided user data object type ({0}) is not assignable to this sampled metric's bound type ({1}) and can not be sampled automatically for this metric instance.", new object[]
				{
					type,
					this.Definition.BoundType
				}));
			}
			try
			{
				global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> dataBinding = this.Definition.DataBinding;
				global::System.Reflection.BindingFlags bindingFlags = this.m_MetricDefinition.GetBindingFlags(dataBinding);
				double rawValue = global::System.Convert.ToDouble(type.InvokeMember(dataBinding.Name, bindingFlags, null, metricData, null, global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.CultureInfo.CurrentCulture);
				if (global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RequiresDivisor(this.SamplingType))
				{
					global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> divisorBinding = this.Definition.DivisorBinding;
					global::System.Reflection.BindingFlags bindingFlags2 = this.m_MetricDefinition.GetBindingFlags(divisorBinding);
					double baseValue = global::System.Convert.ToDouble(type.InvokeMember(divisorBinding.Name, bindingFlags2, null, metricData, null, global::System.Globalization.CultureInfo.InvariantCulture), global::System.Globalization.CultureInfo.CurrentCulture);
					this.WriteSample(rawValue, baseValue);
				}
				else
				{
					this.WriteSample(rawValue);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000839C File Offset: 0x0000659C
		public static void Write(object metricData, string fallbackInstanceName)
		{
			foreach (global::Gibraltar.Agent.Metrics.SampledMetric sampledMetric in global::Gibraltar.Agent.Metrics.SampledMetric.RegisterAll(metricData, fallbackInstanceName ?? string.Empty))
			{
				try
				{
					sampledMetric.WriteSample(metricData);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000083F8 File Offset: 0x000065F8
		public static void Write(object metricData)
		{
			global::Gibraltar.Agent.Metrics.SampledMetric.Write(metricData, string.Empty);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00008408 File Offset: 0x00006608
		public int CompareTo(global::Gibraltar.Agent.Metrics.SampledMetric other)
		{
			return this.WrappedMetric.CompareTo(other.WrappedMetric);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000841C File Offset: 0x0000661C
		public bool Equals(global::Gibraltar.Agent.Metrics.SampledMetric other)
		{
			return this.WrappedMetric.Equals(other.WrappedMetric);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00008430 File Offset: 0x00006630
		public global::Gibraltar.Agent.Metrics.SampledMetricDefinition Definition
		{
			get
			{
				return this.m_MetricDefinition;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00008438 File Offset: 0x00006638
		public global::System.Guid Id
		{
			get
			{
				return this.m_WrappedMetric.Id;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00008448 File Offset: 0x00006648
		public string Key
		{
			get
			{
				return this.m_WrappedMetric.Name;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00008458 File Offset: 0x00006658
		public string Caption
		{
			get
			{
				return this.m_WrappedMetric.Caption;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00008468 File Offset: 0x00006668
		public string Description
		{
			get
			{
				return this.m_WrappedMetric.Description;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00008478 File Offset: 0x00006678
		public string MetricsSystem
		{
			get
			{
				return this.m_MetricDefinition.MetricsSystem;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00008488 File Offset: 0x00006688
		public string CategoryName
		{
			get
			{
				return this.m_MetricDefinition.CategoryName;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00008498 File Offset: 0x00006698
		public string CounterName
		{
			get
			{
				return this.m_MetricDefinition.CounterName;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000084A8 File Offset: 0x000066A8
		public global::Gibraltar.Agent.Metrics.SamplingType SamplingType
		{
			get
			{
				return this.m_MetricDefinition.SamplingType;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000084B8 File Offset: 0x000066B8
		public string UnitCaption
		{
			get
			{
				return this.m_MetricDefinition.UnitCaption;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000084C8 File Offset: 0x000066C8
		public string InstanceName
		{
			get
			{
				return this.m_WrappedMetric.InstanceName;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000084D8 File Offset: 0x000066D8
		public bool IsDefault
		{
			get
			{
				return this.m_WrappedMetric.IsDefault;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000084E8 File Offset: 0x000066E8
		internal global::Gibraltar.Monitor.CustomSampledMetric WrappedMetric
		{
			get
			{
				return this.m_WrappedMetric;
			}
		}

		// Token: 0x04000087 RID: 135
		private readonly global::Gibraltar.Monitor.CustomSampledMetric m_WrappedMetric;

		// Token: 0x04000088 RID: 136
		private readonly global::Gibraltar.Agent.Metrics.SampledMetricDefinition m_MetricDefinition;
	}
}
