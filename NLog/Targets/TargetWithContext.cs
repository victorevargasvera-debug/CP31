using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000053 RID: 83
	public abstract class TargetWithContext : global::NLog.Targets.TargetWithLayout, global::NLog.IIncludeContext
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00012689 File Offset: 0x00010889
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00012691 File Offset: 0x00010891
		public sealed override global::NLog.Layouts.Layout Layout
		{
			get
			{
				return this._contextLayout;
			}
			set
			{
				if (this._contextLayout != null)
				{
					this._contextLayout.TargetLayout = value;
					return;
				}
				this._contextLayout = new global::NLog.Targets.TargetWithContext.TargetWithContextLayout(this, value);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000126B5 File Offset: 0x000108B5
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x000126BD File Offset: 0x000108BD
		bool global::NLog.IIncludeContext.IncludeAllProperties
		{
			get
			{
				return this.IncludeEventProperties;
			}
			set
			{
				this.IncludeEventProperties = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x000126C6 File Offset: 0x000108C6
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x000126D3 File Offset: 0x000108D3
		public bool IncludeEventProperties
		{
			get
			{
				return this._contextLayout.IncludeAllProperties;
			}
			set
			{
				this._contextLayout.IncludeAllProperties = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x000126E1 File Offset: 0x000108E1
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x000126EE File Offset: 0x000108EE
		public bool IncludeMdc
		{
			get
			{
				return this._contextLayout.IncludeMdc;
			}
			set
			{
				this._contextLayout.IncludeMdc = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x000126FC File Offset: 0x000108FC
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00012709 File Offset: 0x00010909
		public bool IncludeNdc
		{
			get
			{
				return this._contextLayout.IncludeNdc;
			}
			set
			{
				this._contextLayout.IncludeNdc = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00012717 File Offset: 0x00010917
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00012724 File Offset: 0x00010924
		public bool IncludeMdlc
		{
			get
			{
				return this._contextLayout.IncludeMdlc;
			}
			set
			{
				this._contextLayout.IncludeMdlc = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00012732 File Offset: 0x00010932
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0001273F File Offset: 0x0001093F
		public bool IncludeNdlc
		{
			get
			{
				return this._contextLayout.IncludeNdlc;
			}
			set
			{
				this._contextLayout.IncludeNdlc = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0001274D File Offset: 0x0001094D
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00012755 File Offset: 0x00010955
		public bool IncludeGdc { get; set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0001275E File Offset: 0x0001095E
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x0001276B File Offset: 0x0001096B
		public bool IncludeCallSite
		{
			get
			{
				return this._contextLayout.IncludeCallSite;
			}
			set
			{
				this._contextLayout.IncludeCallSite = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00012779 File Offset: 0x00010979
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00012786 File Offset: 0x00010986
		public bool IncludeCallSiteStackTrace
		{
			get
			{
				return this._contextLayout.IncludeCallSiteStackTrace;
			}
			set
			{
				this._contextLayout.IncludeCallSiteStackTrace = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00012794 File Offset: 0x00010994
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.TargetPropertyWithContext), "contextproperty")]
		public virtual global::System.Collections.Generic.IList<global::NLog.Targets.TargetPropertyWithContext> ContextProperties { get; } = new global::System.Collections.Generic.List<global::NLog.Targets.TargetPropertyWithContext>();

		// Token: 0x0600075D RID: 1885 RVA: 0x0001279C File Offset: 0x0001099C
		protected TargetWithContext()
		{
			this._contextLayout = (this._contextLayout ?? new global::NLog.Targets.TargetWithContext.TargetWithContextLayout(this, base.Layout));
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000127D2 File Offset: 0x000109D2
		protected bool ShouldIncludeProperties(global::NLog.LogEventInfo logEvent)
		{
			return this.IncludeGdc || this.IncludeMdc || this.IncludeMdlc || (this.IncludeEventProperties && logEvent != null && logEvent.HasProperties);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00012804 File Offset: 0x00010A04
		protected global::System.Collections.Generic.IDictionary<string, object> GetContextProperties(global::NLog.LogEventInfo logEvent)
		{
			global::System.Collections.Generic.IDictionary<string, object> dictionary = null;
			if (this.IncludeGdc)
			{
				dictionary = this.CaptureContextGdc(logEvent, null);
			}
			if (this.IncludeMdc && !global::NLog.Targets.TargetWithContext.CombineProperties(logEvent, this._contextLayout.MdcLayout, ref dictionary))
			{
				dictionary = this.CaptureContextMdc(logEvent, dictionary);
			}
			if (this.IncludeMdlc && !global::NLog.Targets.TargetWithContext.CombineProperties(logEvent, this._contextLayout.MdlcLayout, ref dictionary))
			{
				dictionary = this.CaptureContextMdlc(logEvent, dictionary);
			}
			if (this.ContextProperties != null && this.ContextProperties.Count > 0)
			{
				dictionary = (dictionary ?? new global::System.Collections.Generic.Dictionary<string, object>());
				for (int i = 0; i < this.ContextProperties.Count; i++)
				{
					global::NLog.Targets.TargetPropertyWithContext targetPropertyWithContext = this.ContextProperties[i];
					if (!string.IsNullOrEmpty((targetPropertyWithContext != null) ? targetPropertyWithContext.Name : null) && targetPropertyWithContext.Layout != null)
					{
						string value = base.RenderLogEvent(targetPropertyWithContext.Layout, logEvent);
						if (targetPropertyWithContext.IncludeEmptyValue || !string.IsNullOrEmpty(value))
						{
							dictionary[targetPropertyWithContext.Name] = value;
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00012900 File Offset: 0x00010B00
		protected global::System.Collections.Generic.IDictionary<string, object> GetAllProperties(global::NLog.LogEventInfo logEvent)
		{
			global::System.Collections.Generic.IDictionary<string, object> dictionary = this.GetContextProperties(logEvent);
			if (this.IncludeEventProperties && logEvent.HasProperties)
			{
				dictionary = (dictionary ?? new global::System.Collections.Generic.Dictionary<string, object>());
				foreach (global::System.Collections.Generic.KeyValuePair<object, object> keyValuePair in logEvent.Properties)
				{
					string text = keyValuePair.Key.ToString();
					if (!string.IsNullOrEmpty(text))
					{
						dictionary[text] = keyValuePair.Value;
					}
				}
			}
			return dictionary ?? new global::System.Collections.Generic.Dictionary<string, object>();
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00012998 File Offset: 0x00010B98
		private static bool CombineProperties(global::NLog.LogEventInfo logEvent, global::NLog.Layouts.Layout contextLayout, ref global::System.Collections.Generic.IDictionary<string, object> combinedPropties)
		{
			object obj;
			if (!logEvent.TryGetCachedLayoutValue(contextLayout, out obj))
			{
				return false;
			}
			global::System.Collections.Generic.IDictionary<string, object> dictionary = obj as global::System.Collections.Generic.IDictionary<string, object>;
			if (dictionary != null)
			{
				if (combinedPropties != null)
				{
					using (global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> enumerator = dictionary.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair = enumerator.Current;
							combinedPropties[keyValuePair.Key] = keyValuePair.Value;
						}
						return true;
					}
				}
				combinedPropties = dictionary;
			}
			return true;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00012A10 File Offset: 0x00010C10
		protected global::System.Collections.Generic.IDictionary<string, object> GetContextMdc(global::NLog.LogEventInfo logEvent)
		{
			object obj;
			if (logEvent.TryGetCachedLayoutValue(this._contextLayout.MdcLayout, out obj))
			{
				return obj as global::System.Collections.Generic.IDictionary<string, object>;
			}
			return this.CaptureContextMdc(logEvent, null);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00012A44 File Offset: 0x00010C44
		protected global::System.Collections.Generic.IDictionary<string, object> GetContextMdlc(global::NLog.LogEventInfo logEvent)
		{
			object obj;
			if (logEvent.TryGetCachedLayoutValue(this._contextLayout.MdlcLayout, out obj))
			{
				return obj as global::System.Collections.Generic.IDictionary<string, object>;
			}
			return this.CaptureContextMdlc(logEvent, null);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00012A78 File Offset: 0x00010C78
		protected global::System.Collections.Generic.IList<object> GetContextNdc(global::NLog.LogEventInfo logEvent)
		{
			object obj;
			if (logEvent.TryGetCachedLayoutValue(this._contextLayout.NdcLayout, out obj))
			{
				return obj as global::System.Collections.Generic.IList<object>;
			}
			return this.CaptureContextNdc(logEvent);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00012AA8 File Offset: 0x00010CA8
		protected global::System.Collections.Generic.IList<object> GetContextNdlc(global::NLog.LogEventInfo logEvent)
		{
			object obj;
			if (logEvent.TryGetCachedLayoutValue(this._contextLayout.NdlcLayout, out obj))
			{
				return obj as global::System.Collections.Generic.IList<object>;
			}
			return this.CaptureContextNdlc(logEvent);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00012AD8 File Offset: 0x00010CD8
		protected virtual global::System.Collections.Generic.IDictionary<string, object> CaptureContextGdc(global::NLog.LogEventInfo logEvent, global::System.Collections.Generic.IDictionary<string, object> contextProperties)
		{
			global::System.Collections.Generic.ICollection<string> names = global::NLog.GlobalDiagnosticsContext.GetNames();
			if (names.Count == 0)
			{
				return contextProperties;
			}
			contextProperties = (contextProperties ?? new global::System.Collections.Generic.Dictionary<string, object>());
			foreach (string text in names)
			{
				object @object = global::NLog.GlobalDiagnosticsContext.GetObject(text);
				if (this.SerializeItemValue(logEvent, text, @object, out @object))
				{
					contextProperties[text] = @object;
				}
			}
			return contextProperties;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00012B54 File Offset: 0x00010D54
		protected virtual global::System.Collections.Generic.IDictionary<string, object> CaptureContextMdc(global::NLog.LogEventInfo logEvent, global::System.Collections.Generic.IDictionary<string, object> contextProperties)
		{
			global::System.Collections.Generic.ICollection<string> names = global::NLog.MappedDiagnosticsContext.GetNames();
			if (names.Count == 0)
			{
				return contextProperties;
			}
			contextProperties = (contextProperties ?? new global::System.Collections.Generic.Dictionary<string, object>());
			foreach (string text in names)
			{
				object @object = global::NLog.MappedDiagnosticsContext.GetObject(text);
				object value;
				if (this.SerializeMdcItem(logEvent, text, @object, out value))
				{
					contextProperties[text] = value;
				}
			}
			return contextProperties;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00012BD0 File Offset: 0x00010DD0
		protected virtual bool SerializeMdcItem(global::NLog.LogEventInfo logEvent, string name, object value, out object serializedValue)
		{
			if (string.IsNullOrEmpty(name))
			{
				serializedValue = null;
				return false;
			}
			return this.SerializeItemValue(logEvent, name, value, out serializedValue);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00012BEC File Offset: 0x00010DEC
		protected virtual global::System.Collections.Generic.IDictionary<string, object> CaptureContextMdlc(global::NLog.LogEventInfo logEvent, global::System.Collections.Generic.IDictionary<string, object> contextProperties)
		{
			global::System.Collections.Generic.ICollection<string> names = global::NLog.MappedDiagnosticsLogicalContext.GetNames();
			if (names.Count == 0)
			{
				return contextProperties;
			}
			contextProperties = (contextProperties ?? new global::System.Collections.Generic.Dictionary<string, object>());
			foreach (string text in names)
			{
				object @object = global::NLog.MappedDiagnosticsLogicalContext.GetObject(text);
				object value;
				if (this.SerializeMdlcItem(logEvent, text, @object, out value))
				{
					contextProperties[text] = value;
				}
			}
			return contextProperties;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00012C68 File Offset: 0x00010E68
		protected virtual bool SerializeMdlcItem(global::NLog.LogEventInfo logEvent, string name, object value, out object serializedValue)
		{
			if (string.IsNullOrEmpty(name))
			{
				serializedValue = null;
				return false;
			}
			return this.SerializeItemValue(logEvent, name, value, out serializedValue);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00012C84 File Offset: 0x00010E84
		protected virtual global::System.Collections.Generic.IList<object> CaptureContextNdc(global::NLog.LogEventInfo logEvent)
		{
			object[] allObjects = global::NLog.NestedDiagnosticsContext.GetAllObjects();
			if (allObjects.Length == 0)
			{
				return allObjects;
			}
			global::System.Collections.Generic.IList<object> list = null;
			for (int i = 0; i < allObjects.Length; i++)
			{
				object value = allObjects[i];
				object obj;
				if (this.SerializeNdcItem(logEvent, value, out obj))
				{
					if (list != null)
					{
						list.Add(obj);
					}
					else
					{
						allObjects[i] = obj;
					}
				}
				else if (list == null)
				{
					list = new global::System.Collections.Generic.List<object>(allObjects.Length);
					for (int j = 0; j < i; j++)
					{
						list.Add(allObjects[j]);
					}
				}
			}
			return list ?? allObjects;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00012CFD File Offset: 0x00010EFD
		protected virtual bool SerializeNdcItem(global::NLog.LogEventInfo logEvent, object value, out object serializedValue)
		{
			return this.SerializeItemValue(logEvent, null, value, out serializedValue);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00012D0C File Offset: 0x00010F0C
		protected virtual global::System.Collections.Generic.IList<object> CaptureContextNdlc(global::NLog.LogEventInfo logEvent)
		{
			object[] allObjects = global::NLog.NestedDiagnosticsLogicalContext.GetAllObjects();
			if (allObjects.Length == 0)
			{
				return allObjects;
			}
			global::System.Collections.Generic.IList<object> list = null;
			for (int i = 0; i < allObjects.Length; i++)
			{
				object value = allObjects[i];
				object obj;
				if (this.SerializeNdlcItem(logEvent, value, out obj))
				{
					if (list != null)
					{
						list.Add(obj);
					}
					else
					{
						allObjects[i] = obj;
					}
				}
				else if (list == null)
				{
					list = new global::System.Collections.Generic.List<object>(allObjects.Length);
					for (int j = 0; j < i; j++)
					{
						list.Add(allObjects[j]);
					}
				}
			}
			return list ?? allObjects;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00012D85 File Offset: 0x00010F85
		protected virtual bool SerializeNdlcItem(global::NLog.LogEventInfo logEvent, object value, out object serializedValue)
		{
			return this.SerializeItemValue(logEvent, null, value, out serializedValue);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00012D94 File Offset: 0x00010F94
		protected virtual bool SerializeItemValue(global::NLog.LogEventInfo logEvent, string name, object value, out object serializedValue)
		{
			if (value == null)
			{
				serializedValue = null;
				return true;
			}
			if (value is string || global::System.Convert.GetTypeCode(value) != global::System.TypeCode.Object || value is global::System.Guid || value is global::System.TimeSpan || value is global::System.DateTimeOffset)
			{
				serializedValue = value;
				return true;
			}
			serializedValue = global::System.Convert.ToString(value, logEvent.FormatProvider ?? global::System.Globalization.CultureInfo.CurrentCulture);
			return true;
		}

		// Token: 0x04000178 RID: 376
		private global::NLog.Targets.TargetWithContext.TargetWithContextLayout _contextLayout;

		// Token: 0x020001D7 RID: 471
		[global::NLog.Config.ThreadSafe]
		[global::NLog.Config.ThreadAgnostic]
		private class TargetWithContextLayout : global::NLog.Layouts.Layout, global::NLog.IIncludeContext, global::NLog.Internal.IUsesStackTrace
		{
			// Token: 0x1700034E RID: 846
			// (get) Token: 0x06001207 RID: 4615 RVA: 0x0002F295 File Offset: 0x0002D495
			// (set) Token: 0x06001208 RID: 4616 RVA: 0x0002F29D File Offset: 0x0002D49D
			public global::NLog.Layouts.Layout TargetLayout
			{
				get
				{
					return this._targetLayout;
				}
				set
				{
					this._targetLayout = ((this == value) ? this._targetLayout : value);
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x06001209 RID: 4617 RVA: 0x0002F2B2 File Offset: 0x0002D4B2
			internal global::NLog.Targets.TargetWithContext.TargetWithContextLayout.LayoutContextMdc MdcLayout { get; }

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x0600120A RID: 4618 RVA: 0x0002F2BA File Offset: 0x0002D4BA
			internal global::NLog.Targets.TargetWithContext.TargetWithContextLayout.LayoutContextNdc NdcLayout { get; }

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x0600120B RID: 4619 RVA: 0x0002F2C2 File Offset: 0x0002D4C2
			internal global::NLog.Targets.TargetWithContext.TargetWithContextLayout.LayoutContextMdlc MdlcLayout { get; }

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x0600120C RID: 4620 RVA: 0x0002F2CA File Offset: 0x0002D4CA
			internal global::NLog.Targets.TargetWithContext.TargetWithContextLayout.LayoutContextNdlc NdlcLayout { get; }

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x0600120D RID: 4621 RVA: 0x0002F2D2 File Offset: 0x0002D4D2
			// (set) Token: 0x0600120E RID: 4622 RVA: 0x0002F2DA File Offset: 0x0002D4DA
			public bool IncludeAllProperties { get; set; }

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x0600120F RID: 4623 RVA: 0x0002F2E3 File Offset: 0x0002D4E3
			// (set) Token: 0x06001210 RID: 4624 RVA: 0x0002F2EB File Offset: 0x0002D4EB
			public bool IncludeCallSite { get; set; }

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x06001211 RID: 4625 RVA: 0x0002F2F4 File Offset: 0x0002D4F4
			// (set) Token: 0x06001212 RID: 4626 RVA: 0x0002F2FC File Offset: 0x0002D4FC
			public bool IncludeCallSiteStackTrace { get; set; }

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x06001213 RID: 4627 RVA: 0x0002F305 File Offset: 0x0002D505
			// (set) Token: 0x06001214 RID: 4628 RVA: 0x0002F312 File Offset: 0x0002D512
			public bool IncludeMdc
			{
				get
				{
					return this.MdcLayout.IsActive;
				}
				set
				{
					this.MdcLayout.IsActive = value;
				}
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x06001215 RID: 4629 RVA: 0x0002F320 File Offset: 0x0002D520
			// (set) Token: 0x06001216 RID: 4630 RVA: 0x0002F32D File Offset: 0x0002D52D
			public bool IncludeNdc
			{
				get
				{
					return this.NdcLayout.IsActive;
				}
				set
				{
					this.NdcLayout.IsActive = value;
				}
			}

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x06001217 RID: 4631 RVA: 0x0002F33B File Offset: 0x0002D53B
			// (set) Token: 0x06001218 RID: 4632 RVA: 0x0002F348 File Offset: 0x0002D548
			public bool IncludeMdlc
			{
				get
				{
					return this.MdlcLayout.IsActive;
				}
				set
				{
					this.MdlcLayout.IsActive = value;
				}
			}

			// Token: 0x17000359 RID: 857
			// (get) Token: 0x06001219 RID: 4633 RVA: 0x0002F356 File Offset: 0x0002D556
			// (set) Token: 0x0600121A RID: 4634 RVA: 0x0002F363 File Offset: 0x0002D563
			public bool IncludeNdlc
			{
				get
				{
					return this.NdlcLayout.IsActive;
				}
				set
				{
					this.NdlcLayout.IsActive = value;
				}
			}

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x0600121B RID: 4635 RVA: 0x0002F371 File Offset: 0x0002D571
			global::NLog.Config.StackTraceUsage global::NLog.Internal.IUsesStackTrace.StackTraceUsage
			{
				get
				{
					if (this.IncludeCallSiteStackTrace)
					{
						return global::NLog.Config.StackTraceUsage.WithSource;
					}
					if (this.IncludeCallSite)
					{
						return global::NLog.Config.StackTraceUsage.WithoutSource;
					}
					return global::NLog.Config.StackTraceUsage.None;
				}
			}

			// Token: 0x0600121C RID: 4636 RVA: 0x0002F388 File Offset: 0x0002D588
			public TargetWithContextLayout(global::NLog.Targets.TargetWithContext owner, global::NLog.Layouts.Layout targetLayout)
			{
				this.TargetLayout = targetLayout;
				this.MdcLayout = new global::NLog.Targets.TargetWithContext.TargetWithContextLayout.LayoutContextMdc(owner);
				this.NdcLayout = new global::NLog.Targets.TargetWithContext.TargetWithContextLayout.LayoutContextNdc(owner);
				this.MdlcLayout = new global::NLog.Targets.TargetWithContext.TargetWithContextLayout.LayoutContextMdlc(owner);
				this.NdlcLayout = new global::NLog.Targets.TargetWithContext.TargetWithContextLayout.LayoutContextNdlc(owner);
			}

			// Token: 0x0600121D RID: 4637 RVA: 0x0002F3C8 File Offset: 0x0002D5C8
			protected override void InitializeLayout()
			{
				base.InitializeLayout();
				if (this.IncludeMdc || this.IncludeNdc)
				{
					base.ThreadAgnostic = false;
				}
				if (this.IncludeMdlc || this.IncludeNdlc)
				{
					base.ThreadAgnostic = false;
				}
				if (this.IncludeAllProperties)
				{
					base.MutableUnsafe = true;
				}
			}

			// Token: 0x0600121E RID: 4638 RVA: 0x0002F418 File Offset: 0x0002D618
			public override string ToString()
			{
				global::NLog.Layouts.Layout targetLayout = this.TargetLayout;
				return ((targetLayout != null) ? targetLayout.ToString() : null) ?? base.ToString();
			}

			// Token: 0x0600121F RID: 4639 RVA: 0x0002F438 File Offset: 0x0002D638
			public override void Precalculate(global::NLog.LogEventInfo logEvent)
			{
				global::NLog.Layouts.Layout targetLayout = this.TargetLayout;
				if (targetLayout == null || targetLayout.ThreadAgnostic)
				{
					global::NLog.Layouts.Layout targetLayout2 = this.TargetLayout;
					if (targetLayout2 == null || !targetLayout2.MutableUnsafe)
					{
						goto IL_4C;
					}
				}
				this.TargetLayout.Precalculate(logEvent);
				object value;
				if (logEvent.TryGetCachedLayoutValue(this.TargetLayout, out value))
				{
					logEvent.AddCachedLayoutValue(this, value);
				}
				IL_4C:
				this.PrecalculateContext(logEvent);
			}

			// Token: 0x06001220 RID: 4640 RVA: 0x0002F498 File Offset: 0x0002D698
			internal override void PrecalculateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
			{
				global::NLog.Layouts.Layout targetLayout = this.TargetLayout;
				if (targetLayout == null || targetLayout.ThreadAgnostic)
				{
					global::NLog.Layouts.Layout targetLayout2 = this.TargetLayout;
					if (targetLayout2 == null || !targetLayout2.MutableUnsafe)
					{
						goto IL_4D;
					}
				}
				this.TargetLayout.PrecalculateBuilder(logEvent, target);
				object value;
				if (logEvent.TryGetCachedLayoutValue(this.TargetLayout, out value))
				{
					logEvent.AddCachedLayoutValue(this, value);
				}
				IL_4D:
				this.PrecalculateContext(logEvent);
			}

			// Token: 0x06001221 RID: 4641 RVA: 0x0002F4FC File Offset: 0x0002D6FC
			private void PrecalculateContext(global::NLog.LogEventInfo logEvent)
			{
				if (this.IncludeMdc)
				{
					this.MdcLayout.Precalculate(logEvent);
				}
				if (this.IncludeNdc)
				{
					this.NdcLayout.Precalculate(logEvent);
				}
				if (this.IncludeMdlc)
				{
					this.MdlcLayout.Precalculate(logEvent);
				}
				if (this.IncludeNdlc)
				{
					this.NdlcLayout.Precalculate(logEvent);
				}
			}

			// Token: 0x06001222 RID: 4642 RVA: 0x0002F559 File Offset: 0x0002D759
			protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
			{
				global::NLog.Layouts.Layout targetLayout = this.TargetLayout;
				return ((targetLayout != null) ? targetLayout.Render(logEvent) : null) ?? string.Empty;
			}

			// Token: 0x06001223 RID: 4643 RVA: 0x0002F577 File Offset: 0x0002D777
			protected override void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
			{
				global::NLog.Layouts.Layout targetLayout = this.TargetLayout;
				if (targetLayout == null)
				{
					return;
				}
				targetLayout.RenderAppendBuilder(logEvent, target, false);
			}

			// Token: 0x0400054C RID: 1356
			private global::NLog.Layouts.Layout _targetLayout;

			// Token: 0x0200024E RID: 590
			[global::NLog.Config.ThreadSafe]
			public class LayoutContextMdc : global::NLog.Layouts.Layout
			{
				// Token: 0x1700039F RID: 927
				// (get) Token: 0x060013CC RID: 5068 RVA: 0x000334EC File Offset: 0x000316EC
				// (set) Token: 0x060013CD RID: 5069 RVA: 0x000334F4 File Offset: 0x000316F4
				public bool IsActive { get; set; }

				// Token: 0x060013CE RID: 5070 RVA: 0x000334FD File Offset: 0x000316FD
				public LayoutContextMdc(global::NLog.Targets.TargetWithContext owner)
				{
					this._owner = owner;
				}

				// Token: 0x060013CF RID: 5071 RVA: 0x0003350C File Offset: 0x0003170C
				protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
				{
					this.CaptureContext(logEvent);
					return string.Empty;
				}

				// Token: 0x060013D0 RID: 5072 RVA: 0x0003351A File Offset: 0x0003171A
				public override void Precalculate(global::NLog.LogEventInfo logEvent)
				{
					this.CaptureContext(logEvent);
				}

				// Token: 0x060013D1 RID: 5073 RVA: 0x00033524 File Offset: 0x00031724
				private void CaptureContext(global::NLog.LogEventInfo logEvent)
				{
					if (this.IsActive)
					{
						global::System.Collections.Generic.IDictionary<string, object> value = this._owner.CaptureContextMdc(logEvent, null);
						logEvent.AddCachedLayoutValue(this, value);
					}
				}

				// Token: 0x040006A7 RID: 1703
				private readonly global::NLog.Targets.TargetWithContext _owner;
			}

			// Token: 0x0200024F RID: 591
			[global::NLog.Config.ThreadSafe]
			public class LayoutContextMdlc : global::NLog.Layouts.Layout
			{
				// Token: 0x170003A0 RID: 928
				// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0003354F File Offset: 0x0003174F
				// (set) Token: 0x060013D3 RID: 5075 RVA: 0x00033557 File Offset: 0x00031757
				public bool IsActive { get; set; }

				// Token: 0x060013D4 RID: 5076 RVA: 0x00033560 File Offset: 0x00031760
				public LayoutContextMdlc(global::NLog.Targets.TargetWithContext owner)
				{
					this._owner = owner;
				}

				// Token: 0x060013D5 RID: 5077 RVA: 0x0003356F File Offset: 0x0003176F
				protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
				{
					this.CaptureContext(logEvent);
					return string.Empty;
				}

				// Token: 0x060013D6 RID: 5078 RVA: 0x0003357D File Offset: 0x0003177D
				public override void Precalculate(global::NLog.LogEventInfo logEvent)
				{
					this.CaptureContext(logEvent);
				}

				// Token: 0x060013D7 RID: 5079 RVA: 0x00033588 File Offset: 0x00031788
				private void CaptureContext(global::NLog.LogEventInfo logEvent)
				{
					if (this.IsActive)
					{
						global::System.Collections.Generic.IDictionary<string, object> value = this._owner.CaptureContextMdlc(logEvent, null);
						logEvent.AddCachedLayoutValue(this, value);
					}
				}

				// Token: 0x040006A9 RID: 1705
				private readonly global::NLog.Targets.TargetWithContext _owner;
			}

			// Token: 0x02000250 RID: 592
			[global::NLog.Config.ThreadSafe]
			public class LayoutContextNdc : global::NLog.Layouts.Layout
			{
				// Token: 0x170003A1 RID: 929
				// (get) Token: 0x060013D8 RID: 5080 RVA: 0x000335B3 File Offset: 0x000317B3
				// (set) Token: 0x060013D9 RID: 5081 RVA: 0x000335BB File Offset: 0x000317BB
				public bool IsActive { get; set; }

				// Token: 0x060013DA RID: 5082 RVA: 0x000335C4 File Offset: 0x000317C4
				public LayoutContextNdc(global::NLog.Targets.TargetWithContext owner)
				{
					this._owner = owner;
				}

				// Token: 0x060013DB RID: 5083 RVA: 0x000335D3 File Offset: 0x000317D3
				protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
				{
					this.CaptureContext(logEvent);
					return string.Empty;
				}

				// Token: 0x060013DC RID: 5084 RVA: 0x000335E1 File Offset: 0x000317E1
				public override void Precalculate(global::NLog.LogEventInfo logEvent)
				{
					this.CaptureContext(logEvent);
				}

				// Token: 0x060013DD RID: 5085 RVA: 0x000335EC File Offset: 0x000317EC
				private void CaptureContext(global::NLog.LogEventInfo logEvent)
				{
					if (this.IsActive)
					{
						global::System.Collections.Generic.IList<object> value = this._owner.CaptureContextNdc(logEvent);
						logEvent.AddCachedLayoutValue(this, value);
					}
				}

				// Token: 0x040006AB RID: 1707
				private readonly global::NLog.Targets.TargetWithContext _owner;
			}

			// Token: 0x02000251 RID: 593
			[global::NLog.Config.ThreadSafe]
			public class LayoutContextNdlc : global::NLog.Layouts.Layout
			{
				// Token: 0x170003A2 RID: 930
				// (get) Token: 0x060013DE RID: 5086 RVA: 0x00033616 File Offset: 0x00031816
				// (set) Token: 0x060013DF RID: 5087 RVA: 0x0003361E File Offset: 0x0003181E
				public bool IsActive { get; set; }

				// Token: 0x060013E0 RID: 5088 RVA: 0x00033627 File Offset: 0x00031827
				public LayoutContextNdlc(global::NLog.Targets.TargetWithContext owner)
				{
					this._owner = owner;
				}

				// Token: 0x060013E1 RID: 5089 RVA: 0x00033636 File Offset: 0x00031836
				protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
				{
					this.CaptureContext(logEvent);
					return string.Empty;
				}

				// Token: 0x060013E2 RID: 5090 RVA: 0x00033644 File Offset: 0x00031844
				public override void Precalculate(global::NLog.LogEventInfo logEvent)
				{
					this.CaptureContext(logEvent);
				}

				// Token: 0x060013E3 RID: 5091 RVA: 0x00033650 File Offset: 0x00031850
				private void CaptureContext(global::NLog.LogEventInfo logEvent)
				{
					if (this.IsActive)
					{
						global::System.Collections.Generic.IList<object> value = this._owner.CaptureContextNdlc(logEvent);
						logEvent.AddCachedLayoutValue(this, value);
					}
				}

				// Token: 0x040006AD RID: 1709
				private readonly global::NLog.Targets.TargetWithContext _owner;
			}
		}
	}
}
