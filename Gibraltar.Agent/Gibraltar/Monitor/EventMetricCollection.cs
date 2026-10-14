using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B6 RID: 438
	internal class EventMetricCollection : global::Gibraltar.Monitor.MetricCollection
	{
		// Token: 0x060013E6 RID: 5094 RVA: 0x0003AB0C File Offset: 0x00038D0C
		public EventMetricCollection(global::Gibraltar.Monitor.EventMetricDefinition metricDefinition) : base(metricDefinition)
		{
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0003AB18 File Offset: 0x00038D18
		public global::Gibraltar.Monitor.EventMetric Add(string instanceName)
		{
			return new global::Gibraltar.Monitor.EventMetric(this.Definition, instanceName);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0003AB28 File Offset: 0x00038D28
		public global::Gibraltar.Monitor.EventMetric AddOrGet(object userDataObject)
		{
			if (userDataObject == null)
			{
				throw new global::System.ArgumentNullException("userDataObject");
			}
			string text = null;
			if (this.Definition.NameBound)
			{
				try
				{
					global::System.Reflection.MemberTypes nameMemberType = this.Definition.NameMemberType;
					global::System.Reflection.BindingFlags invokeAttr;
					if (nameMemberType != global::System.Reflection.MemberTypes.Field)
					{
						if (nameMemberType != global::System.Reflection.MemberTypes.Method)
						{
							if (nameMemberType != global::System.Reflection.MemberTypes.Property)
							{
								throw new global::System.ArgumentOutOfRangeException();
							}
							invokeAttr = global::System.Reflection.BindingFlags.GetProperty;
						}
						else
						{
							invokeAttr = global::System.Reflection.BindingFlags.InvokeMethod;
						}
					}
					else
					{
						invokeAttr = global::System.Reflection.BindingFlags.GetField;
					}
					object obj = this.Definition.BoundType.InvokeMember(this.Definition.NameMemberName, invokeAttr, null, userDataObject, null, global::System.Globalization.CultureInfo.InvariantCulture);
					if (obj == null)
					{
						text = null;
					}
					else
					{
						text = obj.ToString();
					}
				}
				catch (global::System.Exception ex)
				{
					global::System.Diagnostics.Trace.TraceWarning("Unable to retrieve the instance name to create a specific {0} metric because an exception occurred while accessing the member {1}: {2}", new object[]
					{
						this.Definition.Name,
						this.Definition.NameMemberName,
						ex.ToString()
					});
				}
			}
			object @lock = base.Lock;
			global::Gibraltar.Monitor.EventMetric result;
			lock (@lock)
			{
				if (!this.TryGetValue(text, out result))
				{
					result = this.Add(text);
				}
			}
			return result;
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x0003AC74 File Offset: 0x00038E74
		public new global::Gibraltar.Monitor.EventMetricDefinition Definition
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetricDefinition)base.Definition;
			}
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0003AC84 File Offset: 0x00038E84
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.EventMetric value)
		{
			global::Loupe.Extensibility.Data.IMetric metric;
			base.TryGetValue(key, out metric);
			value = (metric as global::Gibraltar.Monitor.EventMetric);
			return value != null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0003ACB0 File Offset: 0x00038EB0
		public bool TryGetValue(string key, out global::Gibraltar.Monitor.EventMetric value)
		{
			global::Loupe.Extensibility.Data.IMetric metric;
			base.TryGetValue(key, out metric);
			value = (metric as global::Gibraltar.Monitor.EventMetric);
			return value != null;
		}

		// Token: 0x17000726 RID: 1830
		public global::Gibraltar.Monitor.EventMetric this[int index]
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetric)base[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000727 RID: 1831
		public global::Gibraltar.Monitor.EventMetric this[global::System.Guid ID]
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetric)base[ID];
			}
		}

		// Token: 0x17000728 RID: 1832
		public global::Gibraltar.Monitor.EventMetric this[string key]
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetric)base[key];
			}
		}
	}
}
