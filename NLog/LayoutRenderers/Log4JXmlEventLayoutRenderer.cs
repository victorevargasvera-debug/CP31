using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Xml;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Internal.Fakeables;
using NLog.Layouts;
using NLog.Targets;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C2 RID: 194
	[global::NLog.LayoutRenderers.LayoutRenderer("log4jxmlevent")]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.MutableUnsafe]
	public class Log4JXmlEventLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer, global::NLog.Internal.IUsesStackTrace, global::NLog.IIncludeContext
	{
		// Token: 0x06000B18 RID: 2840 RVA: 0x0001BF7F File Offset: 0x0001A17F
		public Log4JXmlEventLayoutRenderer() : this(global::NLog.LogFactory.CurrentAppDomain)
		{
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001BF8C File Offset: 0x0001A18C
		public Log4JXmlEventLayoutRenderer(global::NLog.Internal.Fakeables.IAppDomain appDomain)
		{
			this.IncludeNLogData = true;
			this.NdcItemSeparator = " ";
			this.NdlcItemSeparator = " ";
			this.AppInfo = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}({1})", new object[]
			{
				appDomain.FriendlyName,
				global::NLog.Internal.ThreadIDHelper.Instance.CurrentProcessID
			});
			this.Parameters = new global::System.Collections.Generic.List<global::NLog.Targets.NLogViewerParameterInfo>();
			try
			{
				this._machineName = global::NLog.Internal.EnvironmentHelper.GetMachineName();
				if (string.IsNullOrEmpty(this._machineName))
				{
					global::NLog.Common.InternalLogger.Info("MachineName is not available.");
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Error getting machine name.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
				this._machineName = string.Empty;
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0001C054 File Offset: 0x0001A254
		protected override void InitializeLayoutRenderer()
		{
			base.InitializeLayoutRenderer();
			this._xmlWriterSettings = new global::System.Xml.XmlWriterSettings
			{
				Indent = this.IndentXml,
				ConformanceLevel = global::System.Xml.ConformanceLevel.Fragment,
				IndentChars = "  "
			};
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0001C085 File Offset: 0x0001A285
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0001C08D File Offset: 0x0001A28D
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IncludeNLogData { get; set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0001C096 File Offset: 0x0001A296
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x0001C09E File Offset: 0x0001A29E
		public bool IndentXml { get; set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0001C0A7 File Offset: 0x0001A2A7
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0001C0AF File Offset: 0x0001A2AF
		public string AppInfo { get; set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x0001C0C0 File Offset: 0x0001A2C0
		public bool IncludeCallSite { get; set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0001C0C9 File Offset: 0x0001A2C9
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x0001C0D1 File Offset: 0x0001A2D1
		public bool IncludeSourceInfo { get; set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0001C0DA File Offset: 0x0001A2DA
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0001C0E2 File Offset: 0x0001A2E2
		public bool IncludeMdc { get; set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0001C0EB File Offset: 0x0001A2EB
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0001C0F3 File Offset: 0x0001A2F3
		public bool IncludeMdlc { get; set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0001C0FC File Offset: 0x0001A2FC
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x0001C104 File Offset: 0x0001A304
		public bool IncludeNdlc { get; set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0001C10D File Offset: 0x0001A30D
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x0001C115 File Offset: 0x0001A315
		[global::System.ComponentModel.DefaultValue(" ")]
		public string NdlcItemSeparator { get; set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0001C11E File Offset: 0x0001A31E
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x0001C126 File Offset: 0x0001A326
		public bool IncludeAllProperties { get; set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0001C12F File Offset: 0x0001A32F
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x0001C137 File Offset: 0x0001A337
		public bool IncludeNdc { get; set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0001C140 File Offset: 0x0001A340
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x0001C148 File Offset: 0x0001A348
		[global::System.ComponentModel.DefaultValue(" ")]
		public string NdcItemSeparator { get; set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0001C151 File Offset: 0x0001A351
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x0001C159 File Offset: 0x0001A359
		public global::NLog.Layouts.Layout LoggerName { get; set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0001C162 File Offset: 0x0001A362
		global::NLog.Config.StackTraceUsage global::NLog.Internal.IUsesStackTrace.StackTraceUsage
		{
			get
			{
				if (this.IncludeSourceInfo)
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0001C179 File Offset: 0x0001A379
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x0001C181 File Offset: 0x0001A381
		internal global::System.Collections.Generic.IList<global::NLog.Targets.NLogViewerParameterInfo> Parameters { get; set; }

		// Token: 0x06000B38 RID: 2872 RVA: 0x0001C18A File Offset: 0x0001A38A
		internal void AppendToStringBuilder(global::System.Text.StringBuilder sb, global::NLog.LogEventInfo logEvent)
		{
			this.Append(sb, logEvent);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0001C194 File Offset: 0x0001A394
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringBuilder, this._xmlWriterSettings))
			{
				xmlWriter.WriteStartElement("log4j", "event", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
				xmlWriter.WriteAttributeSafeString("xmlns", "nlog", null, global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNLogNamespace);
				xmlWriter.WriteAttributeSafeString("logger", (this.LoggerName != null) ? this.LoggerName.Render(logEvent) : logEvent.LoggerName);
				xmlWriter.WriteAttributeSafeString("level", logEvent.Level.Name.ToUpperInvariant());
				xmlWriter.WriteAttributeSafeString("timestamp", global::System.Convert.ToString((long)(logEvent.TimeStamp.ToUniversalTime() - global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.log4jDateBase).TotalMilliseconds, global::System.Globalization.CultureInfo.InvariantCulture));
				xmlWriter.WriteAttributeSafeString("thread", global::NLog.Common.AsyncHelpers.GetManagedThreadId().ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				xmlWriter.WriteElementSafeString("log4j", "message", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace, logEvent.FormattedMessage);
				if (logEvent.Exception != null)
				{
					xmlWriter.WriteElementSafeString("log4j", "throwable", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace, logEvent.Exception.ToString());
				}
				this.AppendNdc(xmlWriter);
				global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.AppendException(logEvent, xmlWriter);
				this.AppendCallSite(logEvent, xmlWriter);
				this.AppendProperties(xmlWriter);
				this.AppendMdlc(xmlWriter);
				if (this.IncludeAllProperties)
				{
					this.AppendProperties("log4j", xmlWriter, logEvent);
				}
				this.AppendParameters(logEvent, xmlWriter);
				xmlWriter.WriteStartElement("log4j", "data", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
				xmlWriter.WriteAttributeSafeString("name", "log4japp");
				xmlWriter.WriteAttributeSafeString("value", this.AppInfo);
				xmlWriter.WriteEndElement();
				xmlWriter.WriteStartElement("log4j", "data", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
				xmlWriter.WriteAttributeSafeString("name", "log4jmachinename");
				xmlWriter.WriteAttributeSafeString("value", this._machineName);
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
				xmlWriter.Flush();
				stringBuilder.Replace(global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespaceRemover, string.Empty);
				stringBuilder.Replace(global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNLogNamespaceRemover, string.Empty);
				stringBuilder.CopyTo(builder);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
		private void AppendMdlc(global::System.Xml.XmlWriter xtw)
		{
			if (this.IncludeMdlc)
			{
				foreach (string text in global::NLog.MappedDiagnosticsLogicalContext.GetNames())
				{
					string text2 = global::NLog.Internal.XmlHelper.XmlConvertToString(global::NLog.MappedDiagnosticsLogicalContext.GetObject(text));
					if (text2 != null)
					{
						xtw.WriteStartElement("log4j", "data", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
						xtw.WriteAttributeSafeString("name", text);
						xtw.WriteAttributeSafeString("value", text2);
						xtw.WriteEndElement();
					}
				}
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0001C464 File Offset: 0x0001A664
		private void AppendNdc(global::System.Xml.XmlWriter xtw)
		{
			string text = null;
			if (this.IncludeNdc)
			{
				text = string.Join(this.NdcItemSeparator, global::NLog.NestedDiagnosticsContext.GetAllMessages());
			}
			if (this.IncludeNdlc)
			{
				if (text != null)
				{
					text += this.NdcItemSeparator;
				}
				text += string.Join(this.NdlcItemSeparator, global::NLog.NestedDiagnosticsLogicalContext.GetAllMessages());
			}
			if (text != null)
			{
				xtw.WriteElementSafeString("log4j", "NDC", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace, text);
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0001C4D4 File Offset: 0x0001A6D4
		private static void AppendException(global::NLog.LogEventInfo logEvent, global::System.Xml.XmlWriter xtw)
		{
			if (logEvent.Exception != null)
			{
				xtw.WriteStartElement("log4j", "throwable", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
				xtw.WriteSafeCData(logEvent.Exception.ToString());
				xtw.WriteEndElement();
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0001C50C File Offset: 0x0001A70C
		private void AppendParameters(global::NLog.LogEventInfo logEvent, global::System.Xml.XmlWriter xtw)
		{
			if (this.Parameters.Count > 0)
			{
				foreach (global::NLog.Targets.NLogViewerParameterInfo nlogViewerParameterInfo in this.Parameters)
				{
					xtw.WriteStartElement("log4j", "data", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
					xtw.WriteAttributeSafeString("name", nlogViewerParameterInfo.Name);
					xtw.WriteAttributeSafeString("value", nlogViewerParameterInfo.Layout.Render(logEvent));
					xtw.WriteEndElement();
				}
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0001C5A4 File Offset: 0x0001A7A4
		private void AppendProperties(global::System.Xml.XmlWriter xtw)
		{
			xtw.WriteStartElement("log4j", "properties", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
			if (this.IncludeMdc)
			{
				foreach (string text in global::NLog.MappedDiagnosticsContext.GetNames())
				{
					string text2 = global::NLog.Internal.XmlHelper.XmlConvertToString(global::NLog.MappedDiagnosticsContext.GetObject(text));
					if (text2 != null)
					{
						xtw.WriteStartElement("log4j", "data", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
						xtw.WriteAttributeSafeString("name", text);
						xtw.WriteAttributeSafeString("value", text2);
						xtw.WriteEndElement();
					}
				}
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0001C648 File Offset: 0x0001A848
		private void AppendCallSite(global::NLog.LogEventInfo logEvent, global::System.Xml.XmlWriter xtw)
		{
			if ((this.IncludeCallSite || this.IncludeSourceInfo) && logEvent.CallSiteInformation != null)
			{
				global::System.Reflection.MethodBase callerStackFrameMethod = logEvent.CallSiteInformation.GetCallerStackFrameMethod(0);
				string callerClassName = logEvent.CallSiteInformation.GetCallerClassName(callerStackFrameMethod, true, true, true);
				string callerMemberName = logEvent.CallSiteInformation.GetCallerMemberName(callerStackFrameMethod, true, true, true);
				xtw.WriteStartElement("log4j", "locationInfo", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
				if (!string.IsNullOrEmpty(callerClassName))
				{
					xtw.WriteAttributeSafeString("class", callerClassName);
				}
				xtw.WriteAttributeSafeString("method", callerMemberName);
				if (this.IncludeSourceInfo)
				{
					xtw.WriteAttributeSafeString("file", logEvent.CallSiteInformation.GetCallerFilePath(0));
					xtw.WriteAttributeSafeString("line", logEvent.CallSiteInformation.GetCallerLineNumber(0).ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				}
				xtw.WriteEndElement();
				if (this.IncludeNLogData)
				{
					xtw.WriteElementSafeString("nlog", "eventSequenceNumber", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNLogNamespace, logEvent.SequenceID.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					xtw.WriteStartElement("nlog", "locationInfo", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNLogNamespace);
					global::System.Type type = (callerStackFrameMethod != null) ? callerStackFrameMethod.DeclaringType : null;
					if (type != null)
					{
						xtw.WriteAttributeSafeString("assembly", type.GetAssembly().FullName);
					}
					xtw.WriteEndElement();
					xtw.WriteStartElement("nlog", "properties", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNLogNamespace);
					this.AppendProperties("nlog", xtw, logEvent);
					xtw.WriteEndElement();
				}
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0001C7C4 File Offset: 0x0001A9C4
		private void AppendProperties(string prefix, global::System.Xml.XmlWriter xtw, global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.HasProperties)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<object, object> keyValuePair in logEvent.Properties)
				{
					string text = global::NLog.Internal.XmlHelper.XmlConvertToString(keyValuePair.Key);
					if (!string.IsNullOrEmpty(text))
					{
						string text2 = global::NLog.Internal.XmlHelper.XmlConvertToString(keyValuePair.Value);
						if (text2 != null)
						{
							xtw.WriteStartElement(prefix, "data", global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace);
							xtw.WriteAttributeSafeString("name", text);
							xtw.WriteAttributeSafeString("value", text2);
							xtw.WriteEndElement();
						}
					}
				}
			}
		}

		// Token: 0x040002D1 RID: 721
		private static readonly global::System.DateTime log4jDateBase = new global::System.DateTime(1970, 1, 1);

		// Token: 0x040002D2 RID: 722
		private static readonly string dummyNamespace = "http://nlog-project.org/dummynamespace/" + global::System.Guid.NewGuid();

		// Token: 0x040002D3 RID: 723
		private static readonly string dummyNamespaceRemover = " xmlns:log4j=\"" + global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNamespace + "\"";

		// Token: 0x040002D4 RID: 724
		private static readonly string dummyNLogNamespace = "http://nlog-project.org/dummynamespace/" + global::System.Guid.NewGuid();

		// Token: 0x040002D5 RID: 725
		private static readonly string dummyNLogNamespaceRemover = " xmlns:nlog=\"" + global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer.dummyNLogNamespace + "\"";

		// Token: 0x040002E3 RID: 739
		private readonly string _machineName;

		// Token: 0x040002E4 RID: 740
		private global::System.Xml.XmlWriterSettings _xmlWriterSettings;
	}
}
