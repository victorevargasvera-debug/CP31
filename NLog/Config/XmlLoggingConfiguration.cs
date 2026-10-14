using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using NLog.Common;
using NLog.Filters;
using NLog.Internal;
using NLog.Layouts;
using NLog.Targets;
using NLog.Targets.Wrappers;
using NLog.Time;

namespace NLog.Config
{
	// Token: 0x02000174 RID: 372
	public class XmlLoggingConfiguration : global::NLog.Config.LoggingConfiguration
	{
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x000297A4 File Offset: 0x000279A4
		private global::NLog.Config.ConfigurationItemFactory ConfigurationItemFactory
		{
			get
			{
				return global::NLog.Config.ConfigurationItemFactory.Default;
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000297AB File Offset: 0x000279AB
		public XmlLoggingConfiguration(string fileName) : this(fileName, global::NLog.LogManager.LogFactory)
		{
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000297B9 File Offset: 0x000279B9
		public XmlLoggingConfiguration(string fileName, global::NLog.LogFactory logFactory) : this(fileName, false, logFactory)
		{
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000297C4 File Offset: 0x000279C4
		public XmlLoggingConfiguration(string fileName, bool ignoreErrors) : this(fileName, ignoreErrors, global::NLog.LogManager.LogFactory)
		{
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x000297D4 File Offset: 0x000279D4
		public XmlLoggingConfiguration(string fileName, bool ignoreErrors, global::NLog.LogFactory logFactory)
		{
			this._fileMustAutoReloadLookup = new global::System.Collections.Generic.Dictionary<string, bool>(global::System.StringComparer.OrdinalIgnoreCase);
			base..ctor(logFactory);
			using (global::System.Xml.XmlReader xmlReader = global::NLog.Config.XmlLoggingConfiguration.CreateFileReader(fileName))
			{
				this.Initialize(xmlReader, fileName, ignoreErrors);
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00029824 File Offset: 0x00027A24
		private static global::System.Xml.XmlReader CreateFileReader(string fileName)
		{
			if (!string.IsNullOrEmpty(fileName))
			{
				fileName = fileName.Trim();
				return global::System.Xml.XmlReader.Create(fileName);
			}
			return null;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0002983E File Offset: 0x00027A3E
		public XmlLoggingConfiguration(global::System.Xml.XmlReader reader, string fileName) : this(reader, fileName, global::NLog.LogManager.LogFactory)
		{
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0002984D File Offset: 0x00027A4D
		public XmlLoggingConfiguration(global::System.Xml.XmlReader reader, string fileName, global::NLog.LogFactory logFactory) : this(reader, fileName, false, logFactory)
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00029859 File Offset: 0x00027A59
		public XmlLoggingConfiguration(global::System.Xml.XmlReader reader, string fileName, bool ignoreErrors) : this(reader, fileName, ignoreErrors, global::NLog.LogManager.LogFactory)
		{
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00029869 File Offset: 0x00027A69
		public XmlLoggingConfiguration(global::System.Xml.XmlReader reader, string fileName, bool ignoreErrors, global::NLog.LogFactory logFactory)
		{
			this._fileMustAutoReloadLookup = new global::System.Collections.Generic.Dictionary<string, bool>(global::System.StringComparer.OrdinalIgnoreCase);
			base..ctor(logFactory);
			this.Initialize(reader, fileName, ignoreErrors);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0002988C File Offset: 0x00027A8C
		internal XmlLoggingConfiguration(global::System.Xml.XmlElement element, string fileName)
		{
			this._fileMustAutoReloadLookup = new global::System.Collections.Generic.Dictionary<string, bool>(global::System.StringComparer.OrdinalIgnoreCase);
			base..ctor();
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(element.OuterXml))
			{
				global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(stringReader);
				this.Initialize(reader, fileName, false);
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000298E8 File Offset: 0x00027AE8
		internal XmlLoggingConfiguration(global::System.Xml.XmlElement element, string fileName, bool ignoreErrors)
		{
			this._fileMustAutoReloadLookup = new global::System.Collections.Generic.Dictionary<string, bool>(global::System.StringComparer.OrdinalIgnoreCase);
			base..ctor();
			using (global::System.IO.StringReader stringReader = new global::System.IO.StringReader(element.OuterXml))
			{
				global::System.Xml.XmlReader reader = global::System.Xml.XmlReader.Create(stringReader);
				this.Initialize(reader, fileName, ignoreErrors);
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00029944 File Offset: 0x00027B44
		public static global::NLog.Config.LoggingConfiguration AppConfig
		{
			get
			{
				return global::System.Configuration.ConfigurationManager.GetSection("nlog") as global::NLog.Config.LoggingConfiguration;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x00029955 File Offset: 0x00027B55
		// (set) Token: 0x06001016 RID: 4118 RVA: 0x0002995D File Offset: 0x00027B5D
		public bool? InitializeSucceeded { get; private set; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x00029966 File Offset: 0x00027B66
		// (set) Token: 0x06001018 RID: 4120 RVA: 0x00029998 File Offset: 0x00027B98
		public bool AutoReload
		{
			get
			{
				return this._fileMustAutoReloadLookup.Values.All((bool mustAutoReload) => mustAutoReload);
			}
			set
			{
				foreach (string key in this._fileMustAutoReloadLookup.Keys.ToList<string>())
				{
					this._fileMustAutoReloadLookup[key] = value;
				}
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x000299FC File Offset: 0x00027BFC
		public override global::System.Collections.Generic.IEnumerable<string> FileNamesToWatch
		{
			get
			{
				return from entry in this._fileMustAutoReloadLookup
				where entry.Value
				select entry.Key;
			}
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00029A57 File Offset: 0x00027C57
		public override global::NLog.Config.LoggingConfiguration Reload()
		{
			return new global::NLog.Config.XmlLoggingConfiguration(this._originalFileName);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00029A64 File Offset: 0x00027C64
		public static global::System.Collections.Generic.IEnumerable<string> GetCandidateConfigFilePaths()
		{
			return global::NLog.LogManager.LogFactory.GetCandidateConfigFilePaths();
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00029A70 File Offset: 0x00027C70
		public static void SetCandidateConfigFilePaths(global::System.Collections.Generic.IEnumerable<string> filePaths)
		{
			global::NLog.LogManager.LogFactory.SetCandidateConfigFilePaths(filePaths);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00029A7D File Offset: 0x00027C7D
		public static void ResetCandidateConfigFilePath()
		{
			global::NLog.LogManager.LogFactory.ResetCandidateConfigFilePath();
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00029A89 File Offset: 0x00027C89
		private static bool IsTargetElement(string name)
		{
			return name.Equals("target", global::System.StringComparison.OrdinalIgnoreCase) || name.Equals("wrapper", global::System.StringComparison.OrdinalIgnoreCase) || name.Equals("wrapper-target", global::System.StringComparison.OrdinalIgnoreCase) || name.Equals("compound-target", global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00029AC3 File Offset: 0x00027CC3
		private static bool IsTargetRefElement(string name)
		{
			return name.Equals("target-ref", global::System.StringComparison.OrdinalIgnoreCase) || name.Equals("wrapper-target-ref", global::System.StringComparison.OrdinalIgnoreCase) || name.Equals("compound-target-ref", global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00029AEF File Offset: 0x00027CEF
		private static string CleanSpaces(string s)
		{
			s = s.Replace(" ", string.Empty);
			return s;
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00029B04 File Offset: 0x00027D04
		private static string StripOptionalNamespacePrefix(string attributeValue)
		{
			if (attributeValue == null)
			{
				return null;
			}
			int num = attributeValue.IndexOf(':');
			if (num < 0)
			{
				return attributeValue;
			}
			return attributeValue.Substring(num + 1);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00029B30 File Offset: 0x00027D30
		private static global::NLog.Targets.Target WrapWithAsyncTargetWrapper(global::NLog.Targets.Target target)
		{
			global::NLog.Targets.Wrappers.AsyncTargetWrapper asyncTargetWrapper = new global::NLog.Targets.Wrappers.AsyncTargetWrapper
			{
				WrappedTarget = target,
				Name = target.Name
			};
			target.Name += "_wrapped";
			global::NLog.Common.InternalLogger.Debug<string, string>("Wrapping target '{0}' with AsyncTargetWrapper and renaming to '{1}", asyncTargetWrapper.Name, target.Name);
			target = asyncTargetWrapper;
			return target;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00029B88 File Offset: 0x00027D88
		private void Initialize(global::System.Xml.XmlReader reader, string fileName, bool ignoreErrors)
		{
			try
			{
				this.InitializeSucceeded = null;
				this._originalFileName = fileName;
				reader.MoveToContent();
				global::NLog.Config.NLogXmlElement nlogXmlElement = new global::NLog.Config.NLogXmlElement(reader);
				if (fileName != null)
				{
					this.ParseTopLevel(nlogXmlElement, fileName, false);
					global::NLog.Common.InternalLogger.Info<string>("Configured from an XML element in {0}...", fileName);
				}
				else
				{
					this.ParseTopLevel(nlogXmlElement, null, false);
				}
				this.InitializeSucceeded = new bool?(true);
				this.CheckParsingErrors(nlogXmlElement);
				base.CheckUnusedTargets();
			}
			catch (global::System.Exception ex)
			{
				this.InitializeSucceeded = new bool?(false);
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				global::NLog.NLogConfigurationException ex2 = new global::NLog.NLogConfigurationException(ex, "Exception when parsing {0}. ", new object[]
				{
					fileName
				});
				global::NLog.Common.InternalLogger.Error(ex2, "Parsing configuration from {0} failed.", new object[]
				{
					fileName
				});
				if (!ignoreErrors && ex2.MustBeRethrown())
				{
					throw ex2;
				}
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00029C58 File Offset: 0x00027E58
		private void CheckParsingErrors(global::NLog.Config.NLogXmlElement rootContentElement)
		{
			string[] array = rootContentElement.GetParsingErrors().ToArray<string>();
			if (array.Any<string>())
			{
				if (global::NLog.LogManager.ThrowConfigExceptions ?? global::NLog.LogManager.ThrowExceptions)
				{
					throw new global::NLog.NLogConfigurationException(string.Join(global::System.Environment.NewLine, array));
				}
				foreach (string message in array)
				{
					global::NLog.Common.InternalLogger.Log(global::NLog.LogLevel.Warn, message);
				}
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00029CCA File Offset: 0x00027ECA
		private void ConfigureFromFile(string fileName, bool autoReloadDefault)
		{
			if (!this._fileMustAutoReloadLookup.ContainsKey(global::NLog.Config.XmlLoggingConfiguration.GetFileLookupKey(fileName)))
			{
				this.ParseTopLevel(new global::NLog.Config.NLogXmlElement(fileName), fileName, autoReloadDefault);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00029CF0 File Offset: 0x00027EF0
		private void ParseTopLevel(global::NLog.Config.NLogXmlElement content, string filePath, bool autoReloadDefault)
		{
			content.AssertName(new string[]
			{
				"nlog",
				"configuration"
			});
			string a = content.LocalName.ToUpperInvariant();
			if (a == "CONFIGURATION")
			{
				this.ParseConfigurationElement(content, filePath, autoReloadDefault);
				return;
			}
			if (!(a == "NLOG"))
			{
				return;
			}
			this.ParseNLogElement(content, filePath, autoReloadDefault);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00029D54 File Offset: 0x00027F54
		private void ParseConfigurationElement(global::NLog.Config.NLogXmlElement configurationElement, string filePath, bool autoReloadDefault)
		{
			global::NLog.Common.InternalLogger.Trace("ParseConfigurationElement");
			configurationElement.AssertName(new string[]
			{
				"configuration"
			});
			foreach (global::NLog.Config.NLogXmlElement nlogElement in configurationElement.Elements("nlog").ToList<global::NLog.Config.NLogXmlElement>())
			{
				this.ParseNLogElement(nlogElement, filePath, autoReloadDefault);
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00029DD4 File Offset: 0x00027FD4
		private void ParseNLogElement(global::NLog.Config.NLogXmlElement nlogElement, string filePath, bool autoReloadDefault)
		{
			global::NLog.Common.InternalLogger.Trace("ParseNLogElement");
			nlogElement.AssertName(new string[]
			{
				"nlog"
			});
			if (nlogElement.GetOptionalBooleanAttribute("useInvariantCulture", false))
			{
				base.DefaultCultureInfo = global::System.Globalization.CultureInfo.InvariantCulture;
			}
			global::NLog.Common.InternalLogger.LogLevel = global::NLog.LogLevel.FromString(nlogElement.GetOptionalAttribute("internalLogLevel", global::NLog.Common.InternalLogger.LogLevel.Name));
			base.ExceptionLoggingOldStyle = nlogElement.GetOptionalBooleanAttribute("exceptionLoggingOldStyle", false);
			bool optionalBooleanAttribute = nlogElement.GetOptionalBooleanAttribute("autoReload", autoReloadDefault);
			if (filePath != null)
			{
				this._fileMustAutoReloadLookup[global::NLog.Config.XmlLoggingConfiguration.GetFileLookupKey(filePath)] = optionalBooleanAttribute;
			}
			base.LogFactory.ThrowExceptions = nlogElement.GetOptionalBooleanAttribute("throwExceptions", base.LogFactory.ThrowExceptions);
			base.LogFactory.ThrowConfigExceptions = nlogElement.GetOptionalBooleanAttribute("throwConfigExceptions", base.LogFactory.ThrowConfigExceptions);
			base.LogFactory.KeepVariablesOnReload = nlogElement.GetOptionalBooleanAttribute("keepVariablesOnReload", base.LogFactory.KeepVariablesOnReload);
			global::NLog.Common.InternalLogger.LogToConsole = nlogElement.GetOptionalBooleanAttribute("internalLogToConsole", global::NLog.Common.InternalLogger.LogToConsole);
			global::NLog.Common.InternalLogger.LogToConsoleError = nlogElement.GetOptionalBooleanAttribute("internalLogToConsoleError", global::NLog.Common.InternalLogger.LogToConsoleError);
			global::NLog.Common.InternalLogger.LogFile = nlogElement.GetOptionalAttribute("internalLogFile", global::NLog.Common.InternalLogger.LogFile);
			bool? optionalBooleanAttribute2 = nlogElement.GetOptionalBooleanAttribute("parseMessageTemplates", null);
			this.ConfigurationItemFactory.ParseMessageTemplates = optionalBooleanAttribute2;
			global::NLog.Common.InternalLogger.LogToTrace = nlogElement.GetOptionalBooleanAttribute("internalLogToTrace", global::NLog.Common.InternalLogger.LogToTrace);
			global::NLog.Common.InternalLogger.IncludeTimestamp = nlogElement.GetOptionalBooleanAttribute("internalLogIncludeTimestamp", global::NLog.Common.InternalLogger.IncludeTimestamp);
			base.LogFactory.GlobalThreshold = global::NLog.LogLevel.FromString(nlogElement.GetOptionalAttribute("globalThreshold", base.LogFactory.GlobalThreshold.Name));
			global::System.Collections.Generic.List<global::NLog.Config.NLogXmlElement> list = nlogElement.Children.ToList<global::NLog.Config.NLogXmlElement>();
			foreach (global::NLog.Config.NLogXmlElement extensionsElement in (from child in list
			where child.LocalName.Equals("EXTENSIONS", global::System.StringComparison.OrdinalIgnoreCase)
			select child).ToList<global::NLog.Config.NLogXmlElement>())
			{
				this.ParseExtensionsElement(extensionsElement, global::System.IO.Path.GetDirectoryName(filePath));
			}
			global::System.Collections.Generic.List<global::NLog.Config.NLogXmlElement> list2 = new global::System.Collections.Generic.List<global::NLog.Config.NLogXmlElement>();
			foreach (global::NLog.Config.NLogXmlElement nlogXmlElement in list)
			{
				string text = nlogXmlElement.LocalName.ToUpperInvariant();
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(text);
				if (num <= 582941476U)
				{
					if (num != 79073797U)
					{
						if (num != 221811691U)
						{
							if (num != 582941476U)
							{
								goto IL_35D;
							}
							if (!(text == "TIME"))
							{
								goto IL_35D;
							}
							this.ParseTimeElement(nlogXmlElement);
							continue;
						}
						else if (!(text == "APPENDERS"))
						{
							goto IL_35D;
						}
					}
					else
					{
						if (!(text == "VARIABLE"))
						{
							goto IL_35D;
						}
						this.ParseVariableElement(nlogXmlElement);
						continue;
					}
				}
				else if (num <= 1086804487U)
				{
					if (num != 1065641344U)
					{
						if (num != 1086804487U)
						{
							goto IL_35D;
						}
						if (!(text == "INCLUDE"))
						{
							goto IL_35D;
						}
						this.ParseIncludeElement(nlogXmlElement, global::System.IO.Path.GetDirectoryName(filePath), optionalBooleanAttribute);
						continue;
					}
					else
					{
						if (!(text == "RULES"))
						{
							goto IL_35D;
						}
						list2.Add(nlogXmlElement);
						continue;
					}
				}
				else if (num != 1482583691U)
				{
					if (num != 4066453633U)
					{
						goto IL_35D;
					}
					if (!(text == "TARGETS"))
					{
						goto IL_35D;
					}
				}
				else
				{
					if (!(text == "EXTENSIONS"))
					{
						goto IL_35D;
					}
					continue;
				}
				this.ParseTargetsElement(nlogXmlElement);
				continue;
				IL_35D:
				global::NLog.Common.InternalLogger.Warn<string>("Skipping unknown node: {0}", nlogXmlElement.LocalName);
			}
			foreach (global::NLog.Config.NLogXmlElement rulesElement in list2)
			{
				this.ParseRulesElement(rulesElement, base.LoggingRules);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0002A1F4 File Offset: 0x000283F4
		private void ParseRulesElement(global::NLog.Config.NLogXmlElement rulesElement, global::System.Collections.Generic.IList<global::NLog.Config.LoggingRule> rulesCollection)
		{
			global::NLog.Common.InternalLogger.Trace("ParseRulesElement");
			rulesElement.AssertName(new string[]
			{
				"rules"
			});
			foreach (global::NLog.Config.NLogXmlElement loggerElement in rulesElement.Elements("logger").ToList<global::NLog.Config.NLogXmlElement>())
			{
				this.ParseLoggerElement(loggerElement, rulesCollection);
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0002A270 File Offset: 0x00028470
		private void ParseLoggerElement(global::NLog.Config.NLogXmlElement loggerElement, global::System.Collections.Generic.IList<global::NLog.Config.LoggingRule> rulesCollection)
		{
			loggerElement.AssertName(new string[]
			{
				"logger"
			});
			string optionalAttribute = loggerElement.GetOptionalAttribute("name", "*");
			if (!loggerElement.GetOptionalBooleanAttribute("enabled", true))
			{
				global::NLog.Common.InternalLogger.Debug("The logger named '{0}' are disabled");
				return;
			}
			string text = loggerElement.GetOptionalAttribute("appendTo", null) ?? loggerElement.GetOptionalAttribute("writeTo", null);
			global::NLog.Config.LoggingRule loggingRule = new global::NLog.Config.LoggingRule
			{
				LoggerNamePattern = optionalAttribute
			};
			if (text != null)
			{
				foreach (string text2 in global::NLog.Config.XmlLoggingConfiguration.StringToList(text))
				{
					global::NLog.Targets.Target target = base.FindTargetByName(text2);
					if (target == null)
					{
						throw new global::NLog.NLogConfigurationException("Target " + text2 + " not found.");
					}
					loggingRule.Targets.Add(target);
				}
			}
			loggingRule.Final = loggerElement.GetOptionalBooleanAttribute("final", false);
			global::NLog.Config.XmlLoggingConfiguration.ParseLevels(loggerElement, loggingRule);
			foreach (global::NLog.Config.NLogXmlElement nlogXmlElement in loggerElement.Children.ToList<global::NLog.Config.NLogXmlElement>())
			{
				string a = nlogXmlElement.LocalName.ToUpperInvariant();
				if (!(a == "FILTERS"))
				{
					if (a == "LOGGER")
					{
						this.ParseLoggerElement(nlogXmlElement, loggingRule.ChildRules);
					}
				}
				else
				{
					this.ParseFilters(loggingRule, nlogXmlElement);
				}
			}
			lock (rulesCollection)
			{
				rulesCollection.Add(loggingRule);
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0002A428 File Offset: 0x00028628
		private static global::System.Collections.Generic.IEnumerable<string> StringToList(string text)
		{
			foreach (string text2 in text.Split(new char[]
			{
				','
			}))
			{
				if (!global::NLog.Internal.StringHelpers.IsNullOrWhiteSpace(text2))
				{
					yield return text2.Trim();
				}
			}
			string[] array = null;
			yield break;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0002A438 File Offset: 0x00028638
		private static void ParseLevels(global::NLog.Config.NLogXmlElement loggerElement, global::NLog.Config.LoggingRule rule)
		{
			string text;
			if (loggerElement.AttributeValues.TryGetValue("level", out text))
			{
				global::NLog.LogLevel level = global::NLog.LogLevel.FromString(text);
				rule.EnableLoggingForLevel(level);
				return;
			}
			if (loggerElement.AttributeValues.TryGetValue("levels", out text))
			{
				text = global::NLog.Config.XmlLoggingConfiguration.CleanSpaces(text);
				foreach (string text2 in text.Split(new char[]
				{
					','
				}))
				{
					if (!string.IsNullOrEmpty(text2))
					{
						global::NLog.LogLevel level2 = global::NLog.LogLevel.FromString(text2);
						rule.EnableLoggingForLevel(level2);
					}
				}
				return;
			}
			int num = 0;
			int ordinal = global::NLog.LogLevel.MaxLevel.Ordinal;
			string levelName;
			if (loggerElement.AttributeValues.TryGetValue("minLevel", out levelName))
			{
				num = global::NLog.LogLevel.FromString(levelName).Ordinal;
			}
			string levelName2;
			if (loggerElement.AttributeValues.TryGetValue("maxLevel", out levelName2))
			{
				ordinal = global::NLog.LogLevel.FromString(levelName2).Ordinal;
			}
			for (int j = num; j <= ordinal; j++)
			{
				rule.EnableLoggingForLevel(global::NLog.LogLevel.FromOrdinal(j));
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0002A538 File Offset: 0x00028738
		private void ParseFilters(global::NLog.Config.LoggingRule rule, global::NLog.Config.NLogXmlElement filtersElement)
		{
			filtersElement.AssertName(new string[]
			{
				"filters"
			});
			foreach (global::NLog.Config.NLogXmlElement nlogXmlElement in filtersElement.Children.ToList<global::NLog.Config.NLogXmlElement>())
			{
				string localName = nlogXmlElement.LocalName;
				global::NLog.Filters.Filter filter = this.ConfigurationItemFactory.Filters.CreateInstance(localName);
				this.ConfigureObjectFromAttributes(filter, nlogXmlElement, false);
				rule.Filters.Add(filter);
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0002A5CC File Offset: 0x000287CC
		private void ParseVariableElement(global::NLog.Config.NLogXmlElement variableElement)
		{
			variableElement.AssertName(new string[]
			{
				"variable"
			});
			string requiredAttribute = variableElement.GetRequiredAttribute("name");
			string text = base.ExpandSimpleVariables(variableElement.GetRequiredAttribute("value"));
			base.Variables[requiredAttribute] = text;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0002A620 File Offset: 0x00028820
		private void ParseTargetsElement(global::NLog.Config.NLogXmlElement targetsElement)
		{
			targetsElement.AssertName(new string[]
			{
				"targets",
				"appenders"
			});
			bool optionalBooleanAttribute = targetsElement.GetOptionalBooleanAttribute("async", false);
			global::NLog.Config.NLogXmlElement nlogXmlElement = null;
			global::System.Collections.Generic.Dictionary<string, global::NLog.Config.NLogXmlElement> dictionary = new global::System.Collections.Generic.Dictionary<string, global::NLog.Config.NLogXmlElement>();
			foreach (global::NLog.Config.NLogXmlElement nlogXmlElement2 in targetsElement.Children.ToList<global::NLog.Config.NLogXmlElement>())
			{
				string localName = nlogXmlElement2.LocalName;
				string text = global::NLog.Config.XmlLoggingConfiguration.StripOptionalNamespacePrefix(nlogXmlElement2.GetOptionalAttribute("type", null));
				string text2 = localName.ToUpperInvariant();
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(text2);
				if (num <= 1970515547U)
				{
					if (num != 934512166U)
					{
						if (num != 1924432750U)
						{
							if (num != 1970515547U)
							{
								continue;
							}
							if (!(text2 == "DEFAULT-TARGET-PARAMETERS"))
							{
								continue;
							}
							if (text == null)
							{
								throw new global::NLog.NLogConfigurationException("Missing 'type' attribute on <" + localName + "/>.");
							}
							dictionary[text] = nlogXmlElement2;
							continue;
						}
						else if (!(text2 == "WRAPPER-TARGET"))
						{
							continue;
						}
					}
					else if (!(text2 == "COMPOUND-TARGET"))
					{
						continue;
					}
				}
				else if (num <= 3098859044U)
				{
					if (num != 2730440272U)
					{
						if (num != 3098859044U)
						{
							continue;
						}
						if (!(text2 == "WRAPPER"))
						{
							continue;
						}
					}
					else
					{
						if (!(text2 == "DEFAULT-WRAPPER"))
						{
							continue;
						}
						nlogXmlElement = nlogXmlElement2;
						continue;
					}
				}
				else if (num != 3535797018U)
				{
					if (num != 4080126536U)
					{
						continue;
					}
					if (!(text2 == "TARGET"))
					{
						continue;
					}
				}
				else if (!(text2 == "APPENDER"))
				{
					continue;
				}
				if (text == null)
				{
					throw new global::NLog.NLogConfigurationException("Missing 'type' attribute on <" + localName + "/>.");
				}
				global::NLog.Targets.Target target = this.ConfigurationItemFactory.Targets.CreateInstance(text);
				this.ParseTargetElement(target, nlogXmlElement2, dictionary);
				if (optionalBooleanAttribute)
				{
					target = global::NLog.Config.XmlLoggingConfiguration.WrapWithAsyncTargetWrapper(target);
				}
				if (nlogXmlElement != null)
				{
					target = this.WrapWithDefaultWrapper(target, nlogXmlElement);
				}
				global::NLog.Common.InternalLogger.Info<global::NLog.Targets.Target>("Adding target {0}", target);
				base.AddTarget(target.Name, target);
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0002A870 File Offset: 0x00028A70
		private void ParseTargetElement(global::NLog.Targets.Target target, global::NLog.Config.NLogXmlElement targetElement, global::System.Collections.Generic.Dictionary<string, global::NLog.Config.NLogXmlElement> typeNameToDefaultTargetParameters = null)
		{
			string key = global::NLog.Config.XmlLoggingConfiguration.StripOptionalNamespacePrefix(targetElement.GetRequiredAttribute("type"));
			global::NLog.Config.NLogXmlElement targetElement2;
			if (typeNameToDefaultTargetParameters != null && typeNameToDefaultTargetParameters.TryGetValue(key, out targetElement2))
			{
				this.ParseTargetElement(target, targetElement2, null);
			}
			global::NLog.Targets.Wrappers.CompoundTargetBase compoundTargetBase = target as global::NLog.Targets.Wrappers.CompoundTargetBase;
			global::NLog.Targets.Wrappers.WrapperTargetBase wrapperTargetBase = target as global::NLog.Targets.Wrappers.WrapperTargetBase;
			this.ConfigureObjectFromAttributes(target, targetElement, true);
			foreach (global::NLog.Config.NLogXmlElement nlogXmlElement in targetElement.Children.ToList<global::NLog.Config.NLogXmlElement>())
			{
				string localName = nlogXmlElement.LocalName;
				if ((compoundTargetBase == null || !this.ParseCompoundTarget(typeNameToDefaultTargetParameters, localName, nlogXmlElement, compoundTargetBase)) && (wrapperTargetBase == null || !this.ParseTargetWrapper(typeNameToDefaultTargetParameters, localName, nlogXmlElement, wrapperTargetBase)))
				{
					this.SetPropertyFromElement(target, nlogXmlElement);
				}
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0002A938 File Offset: 0x00028B38
		private bool ParseTargetWrapper(global::System.Collections.Generic.Dictionary<string, global::NLog.Config.NLogXmlElement> typeNameToDefaultTargetParameters, string name, global::NLog.Config.NLogXmlElement childElement, global::NLog.Targets.Wrappers.WrapperTargetBase wrapper)
		{
			if (global::NLog.Config.XmlLoggingConfiguration.IsTargetRefElement(name))
			{
				string requiredAttribute = childElement.GetRequiredAttribute("name");
				global::NLog.Targets.Target target = base.FindTargetByName(requiredAttribute);
				if (target == null)
				{
					throw new global::NLog.NLogConfigurationException("Referenced target '" + requiredAttribute + "' not found.");
				}
				wrapper.WrappedTarget = target;
				return true;
			}
			else
			{
				if (global::NLog.Config.XmlLoggingConfiguration.IsTargetElement(name))
				{
					string itemName = global::NLog.Config.XmlLoggingConfiguration.StripOptionalNamespacePrefix(childElement.GetRequiredAttribute("type"));
					global::NLog.Targets.Target target2 = this.ConfigurationItemFactory.Targets.CreateInstance(itemName);
					if (target2 != null)
					{
						this.ParseTargetElement(target2, childElement, typeNameToDefaultTargetParameters);
						if (target2.Name != null)
						{
							base.AddTarget(target2.Name, target2);
						}
						if (wrapper.WrappedTarget != null)
						{
							throw new global::NLog.NLogConfigurationException("Wrapped target already defined.");
						}
						wrapper.WrappedTarget = target2;
					}
					return true;
				}
				return false;
			}
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0002A9F0 File Offset: 0x00028BF0
		private bool ParseCompoundTarget(global::System.Collections.Generic.Dictionary<string, global::NLog.Config.NLogXmlElement> typeNameToDefaultTargetParameters, string name, global::NLog.Config.NLogXmlElement childElement, global::NLog.Targets.Wrappers.CompoundTargetBase compound)
		{
			if (global::NLog.Config.XmlLoggingConfiguration.IsTargetRefElement(name))
			{
				string requiredAttribute = childElement.GetRequiredAttribute("name");
				global::NLog.Targets.Target target = base.FindTargetByName(requiredAttribute);
				if (target == null)
				{
					throw new global::NLog.NLogConfigurationException("Referenced target '" + requiredAttribute + "' not found.");
				}
				compound.Targets.Add(target);
				return true;
			}
			else
			{
				if (global::NLog.Config.XmlLoggingConfiguration.IsTargetElement(name))
				{
					string itemName = global::NLog.Config.XmlLoggingConfiguration.StripOptionalNamespacePrefix(childElement.GetRequiredAttribute("type"));
					global::NLog.Targets.Target target2 = this.ConfigurationItemFactory.Targets.CreateInstance(itemName);
					if (target2 != null)
					{
						this.ParseTargetElement(target2, childElement, typeNameToDefaultTargetParameters);
						if (target2.Name != null)
						{
							base.AddTarget(target2.Name, target2);
						}
						compound.Targets.Add(target2);
					}
					return true;
				}
				return false;
			}
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0002AAA0 File Offset: 0x00028CA0
		private void ParseExtensionsElement(global::NLog.Config.NLogXmlElement extensionsElement, string baseDirectory)
		{
			extensionsElement.AssertName(new string[]
			{
				"extensions"
			});
			foreach (global::NLog.Config.NLogXmlElement nlogXmlElement in extensionsElement.Elements("add").ToList<global::NLog.Config.NLogXmlElement>())
			{
				string text = nlogXmlElement.GetOptionalAttribute("prefix", null);
				if (text != null)
				{
					text += ".";
				}
				string text2 = global::NLog.Config.XmlLoggingConfiguration.StripOptionalNamespacePrefix(nlogXmlElement.GetOptionalAttribute("type", null));
				if (text2 != null)
				{
					this.RegistType(text2, text);
				}
				string optionalAttribute = nlogXmlElement.GetOptionalAttribute("assemblyFile", null);
				if (optionalAttribute != null)
				{
					this.ParseExtensionWithAssemblyFle(baseDirectory, optionalAttribute, text);
				}
				else
				{
					string optionalAttribute2 = nlogXmlElement.GetOptionalAttribute("assembly", null);
					if (optionalAttribute2 != null)
					{
						this.ParseExtensionWithAssembly(optionalAttribute2, text);
					}
				}
			}
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0002AB80 File Offset: 0x00028D80
		private void RegistType(string type, string prefix)
		{
			try
			{
				this.ConfigurationItemFactory.RegisterType(global::System.Type.GetType(type, true), prefix);
			}
			catch (global::System.Exception ex)
			{
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Error(ex, "Error loading extensions.");
				global::NLog.NLogConfigurationException ex2 = new global::NLog.NLogConfigurationException("Error loading extensions: " + type, ex);
				if (ex2.MustBeRethrown())
				{
					throw ex2;
				}
			}
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0002ABE8 File Offset: 0x00028DE8
		private void ParseExtensionWithAssembly(string assemblyName, string prefix)
		{
			try
			{
				global::System.Reflection.Assembly assembly = global::NLog.Internal.AssemblyHelpers.LoadFromName(assemblyName);
				this.ConfigurationItemFactory.RegisterItemsFromAssembly(assembly, prefix);
			}
			catch (global::System.Exception ex)
			{
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Error(ex, "Error loading extensions.");
				global::NLog.NLogConfigurationException ex2 = new global::NLog.NLogConfigurationException("Error loading extensions: " + assemblyName, ex);
				if (ex2.MustBeRethrown())
				{
					throw ex2;
				}
			}
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0002AC50 File Offset: 0x00028E50
		private void ParseExtensionWithAssemblyFle(string baseDirectory, string assemblyFile, string prefix)
		{
			try
			{
				global::System.Reflection.Assembly assembly = global::NLog.Internal.AssemblyHelpers.LoadFromPath(assemblyFile, baseDirectory);
				this.ConfigurationItemFactory.RegisterItemsFromAssembly(assembly, prefix);
			}
			catch (global::System.Exception ex)
			{
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				global::NLog.Common.InternalLogger.Error(ex, "Error loading extensions.");
				global::NLog.NLogConfigurationException ex2 = new global::NLog.NLogConfigurationException("Error loading extensions: " + assemblyFile, ex);
				if (ex2.MustBeRethrown())
				{
					throw ex2;
				}
			}
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0002ACB8 File Offset: 0x00028EB8
		private void ParseIncludeElement(global::NLog.Config.NLogXmlElement includeElement, string baseDirectory, bool autoReloadDefault)
		{
			includeElement.AssertName(new string[]
			{
				"include"
			});
			string text = includeElement.GetRequiredAttribute("file");
			bool optionalBooleanAttribute = includeElement.GetOptionalBooleanAttribute("ignoreErrors", false);
			try
			{
				text = base.ExpandSimpleVariables(text);
				text = global::NLog.Layouts.SimpleLayout.Evaluate(text);
				string text2 = text;
				if (baseDirectory != null)
				{
					text2 = global::System.IO.Path.Combine(baseDirectory, text);
				}
				if (global::System.IO.File.Exists(text2))
				{
					global::NLog.Common.InternalLogger.Debug<string>("Including file '{0}'", text2);
					this.ConfigureFromFile(text2, autoReloadDefault);
				}
				else if (text.Contains("*"))
				{
					this.ConfigureFromFilesByMask(baseDirectory, text, autoReloadDefault);
				}
				else
				{
					if (!optionalBooleanAttribute)
					{
						throw new global::System.IO.FileNotFoundException("Included file not found: " + text2);
					}
					global::NLog.Common.InternalLogger.Debug<string>("Skipping included file '{0}' as it can't be found", text2);
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Error when including '{0}'.", new object[]
				{
					text
				});
				if (!optionalBooleanAttribute)
				{
					if (ex.MustBeRethrown())
					{
						throw;
					}
					throw new global::NLog.NLogConfigurationException("Error when including: " + text, ex);
				}
			}
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0002ADB0 File Offset: 0x00028FB0
		private void ConfigureFromFilesByMask(string baseDirectory, string fileMask, bool autoReloadDefault)
		{
			string text = baseDirectory;
			if (global::System.IO.Path.IsPathRooted(fileMask))
			{
				text = global::System.IO.Path.GetDirectoryName(fileMask);
				if (text == null)
				{
					global::NLog.Common.InternalLogger.Warn<string>("directory is empty for include of '{0}'", fileMask);
					return;
				}
				string fileName = global::System.IO.Path.GetFileName(fileMask);
				if (fileName == null)
				{
					global::NLog.Common.InternalLogger.Warn<string>("filename is empty for include of '{0}'", fileMask);
					return;
				}
				fileMask = fileName;
			}
			foreach (string fileName2 in global::System.IO.Directory.GetFiles(text, fileMask))
			{
				this.ConfigureFromFile(fileName2, autoReloadDefault);
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0002AE1C File Offset: 0x0002901C
		private void ParseTimeElement(global::NLog.Config.NLogXmlElement timeElement)
		{
			timeElement.AssertName(new string[]
			{
				"time"
			});
			string requiredAttribute = timeElement.GetRequiredAttribute("type");
			global::NLog.Time.TimeSource timeSource = this.ConfigurationItemFactory.TimeSources.CreateInstance(requiredAttribute);
			this.ConfigureObjectFromAttributes(timeSource, timeElement, true);
			global::NLog.Common.InternalLogger.Info<global::NLog.Time.TimeSource>("Selecting time source {0}", timeSource);
			global::NLog.Time.TimeSource.Current = timeSource;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0002AE75 File Offset: 0x00029075
		private static string GetFileLookupKey(string fileName)
		{
			return global::System.IO.Path.GetFullPath(fileName);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0002AE80 File Offset: 0x00029080
		private void SetPropertyFromElement(object o, global::NLog.Config.NLogXmlElement element)
		{
			if (this.AddArrayItemFromElement(o, element))
			{
				return;
			}
			if (this.SetLayoutFromElement(o, element))
			{
				return;
			}
			if (this.SetItemFromElement(o, element))
			{
				return;
			}
			string text = base.ExpandSimpleVariables(element.Value);
			try
			{
				global::NLog.Internal.PropertyHelper.SetPropertyFromString(o, element.LocalName, text, this.ConfigurationItemFactory);
			}
			catch (global::NLog.NLogConfigurationException)
			{
				global::NLog.Common.InternalLogger.Warn<string, string>("Error when setting '{0}' from '<{1}>'", element.LocalName, text);
				throw;
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0002AEF4 File Offset: 0x000290F4
		private bool AddArrayItemFromElement(object o, global::NLog.Config.NLogXmlElement element)
		{
			string localName = element.LocalName;
			global::System.Reflection.PropertyInfo propertyInfo;
			if (!global::NLog.Internal.PropertyHelper.TryGetPropertyInfo(o, localName, out propertyInfo))
			{
				return false;
			}
			global::System.Type arrayItemType = global::NLog.Internal.PropertyHelper.GetArrayItemType(propertyInfo);
			if (arrayItemType != null)
			{
				global::System.Collections.IList list = (global::System.Collections.IList)propertyInfo.GetValue(o, null);
				object obj = this.TryCreateLayoutInstance(element, arrayItemType);
				if (obj == null)
				{
					obj = global::NLog.Internal.FactoryHelper.CreateInstance(arrayItemType);
				}
				this.ConfigureObjectFromAttributes(obj, element, true);
				this.ConfigureObjectFromElement(obj, element);
				list.Add(obj);
				return true;
			}
			return false;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0002AF60 File Offset: 0x00029160
		private void ConfigureObjectFromAttributes(object targetObject, global::NLog.Config.NLogXmlElement element, bool ignoreType)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in element.AttributeValues.ToList<global::System.Collections.Generic.KeyValuePair<string, string>>())
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				if (!ignoreType || !key.Equals("type", global::System.StringComparison.OrdinalIgnoreCase))
				{
					try
					{
						global::NLog.Internal.PropertyHelper.SetPropertyFromString(targetObject, key, base.ExpandSimpleVariables(value), this.ConfigurationItemFactory);
					}
					catch (global::NLog.NLogConfigurationException)
					{
						global::NLog.Common.InternalLogger.Warn<string, string>("Error when setting '{0}' on attibute '{1}'", value, key);
						throw;
					}
				}
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0002B004 File Offset: 0x00029204
		private bool SetLayoutFromElement(object o, global::NLog.Config.NLogXmlElement layoutElement)
		{
			string localName = layoutElement.LocalName;
			global::System.Reflection.PropertyInfo propertyInfo;
			if (global::NLog.Internal.PropertyHelper.TryGetPropertyInfo(o, localName, out propertyInfo))
			{
				global::NLog.Layouts.Layout layout = this.TryCreateLayoutInstance(layoutElement, propertyInfo.PropertyType);
				if (layout != null)
				{
					this.ConfigureObjectFromAttributes(layout, layoutElement, true);
					this.ConfigureObjectFromElement(layout, layoutElement);
					propertyInfo.SetValue(o, layout, null);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0002B054 File Offset: 0x00029254
		private bool SetItemFromElement(object o, global::NLog.Config.NLogXmlElement element)
		{
			if (element.Value != null)
			{
				return false;
			}
			string localName = element.LocalName;
			global::System.Reflection.PropertyInfo propertyInfo;
			if (!global::NLog.Internal.PropertyHelper.TryGetPropertyInfo(o, localName, out propertyInfo))
			{
				return false;
			}
			object value = propertyInfo.GetValue(o, null);
			this.ConfigureObjectFromAttributes(value, element, true);
			this.ConfigureObjectFromElement(value, element);
			return true;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0002B09C File Offset: 0x0002929C
		private void ConfigureObjectFromElement(object targetObject, global::NLog.Config.NLogXmlElement element)
		{
			foreach (global::NLog.Config.NLogXmlElement element2 in element.Children.ToList<global::NLog.Config.NLogXmlElement>())
			{
				this.SetPropertyFromElement(targetObject, element2);
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0002B0F8 File Offset: 0x000292F8
		private global::NLog.Targets.Target WrapWithDefaultWrapper(global::NLog.Targets.Target t, global::NLog.Config.NLogXmlElement defaultParameters)
		{
			string itemName = global::NLog.Config.XmlLoggingConfiguration.StripOptionalNamespacePrefix(defaultParameters.GetRequiredAttribute("type"));
			global::NLog.Targets.Target target = this.ConfigurationItemFactory.Targets.CreateInstance(itemName);
			global::NLog.Targets.Wrappers.WrapperTargetBase wrapperTargetBase = target as global::NLog.Targets.Wrappers.WrapperTargetBase;
			if (wrapperTargetBase == null)
			{
				throw new global::NLog.NLogConfigurationException("Target type specified on <default-wrapper /> is not a wrapper.");
			}
			this.ParseTargetElement(target, defaultParameters, null);
			while (wrapperTargetBase.WrappedTarget != null)
			{
				wrapperTargetBase = (wrapperTargetBase.WrappedTarget as global::NLog.Targets.Wrappers.WrapperTargetBase);
				if (wrapperTargetBase == null)
				{
					throw new global::NLog.NLogConfigurationException("Child target type specified on <default-wrapper /> is not a wrapper.");
				}
			}
			wrapperTargetBase.WrappedTarget = t;
			target.Name = t.Name;
			t.Name += "_wrapped";
			global::NLog.Common.InternalLogger.Debug<string, string, string>("Wrapping target '{0}' with '{1}' and renaming to '{2}", target.Name, target.GetType().Name, t.Name);
			return target;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0002B1B8 File Offset: 0x000293B8
		private global::NLog.Layouts.Layout TryCreateLayoutInstance(global::NLog.Config.NLogXmlElement element, global::System.Type type)
		{
			if (!typeof(global::NLog.Layouts.Layout).IsAssignableFrom(type))
			{
				return null;
			}
			string text = global::NLog.Config.XmlLoggingConfiguration.StripOptionalNamespacePrefix(element.GetOptionalAttribute("type", null));
			if (text == null)
			{
				return null;
			}
			return this.ConfigurationItemFactory.Layouts.CreateInstance(base.ExpandSimpleVariables(text));
		}

		// Token: 0x04000477 RID: 1143
		private readonly global::System.Collections.Generic.Dictionary<string, bool> _fileMustAutoReloadLookup;

		// Token: 0x04000478 RID: 1144
		private string _originalFileName;
	}
}
