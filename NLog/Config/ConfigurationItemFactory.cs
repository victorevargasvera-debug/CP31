using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using NLog.Common;
using NLog.Conditions;
using NLog.Filters;
using NLog.Internal;
using NLog.LayoutRenderers;
using NLog.Layouts;
using NLog.MessageTemplates;
using NLog.Targets;
using NLog.Time;

namespace NLog.Config
{
	// Token: 0x0200015C RID: 348
	public class ConfigurationItemFactory
	{
		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000F3A RID: 3898 RVA: 0x00026ACC File Offset: 0x00024CCC
		// (remove) Token: 0x06000F3B RID: 3899 RVA: 0x00026B00 File Offset: 0x00024D00
		public static event global::System.EventHandler<global::NLog.Config.AssemblyLoadingEventArgs> AssemblyLoading;

		// Token: 0x06000F3C RID: 3900 RVA: 0x00026B34 File Offset: 0x00024D34
		public ConfigurationItemFactory(params global::System.Reflection.Assembly[] assemblies)
		{
			this.CreateInstance = new global::NLog.Config.ConfigurationItemCreator(global::NLog.Internal.FactoryHelper.CreateInstance);
			this._targets = new global::NLog.Config.Factory<global::NLog.Targets.Target, global::NLog.Targets.TargetAttribute>(this);
			this._filters = new global::NLog.Config.Factory<global::NLog.Filters.Filter, global::NLog.Filters.FilterAttribute>(this);
			this._layoutRenderers = new global::NLog.Config.LayoutRendererFactory(this);
			this._layouts = new global::NLog.Config.Factory<global::NLog.Layouts.Layout, global::NLog.Layouts.LayoutAttribute>(this);
			this._conditionMethods = new global::NLog.Config.MethodFactory<global::NLog.Conditions.ConditionMethodsAttribute, global::NLog.Conditions.ConditionMethodAttribute>();
			this._ambientProperties = new global::NLog.Config.Factory<global::NLog.LayoutRenderers.LayoutRenderer, global::NLog.LayoutRenderers.AmbientPropertyAttribute>(this);
			this._timeSources = new global::NLog.Config.Factory<global::NLog.Time.TimeSource, global::NLog.Time.TimeSourceAttribute>(this);
			this._allFactories = new global::System.Collections.Generic.List<object>
			{
				this._targets,
				this._filters,
				this._layoutRenderers,
				this._layouts,
				this._conditionMethods,
				this._ambientProperties,
				this._timeSources
			};
			foreach (global::System.Reflection.Assembly assembly in assemblies)
			{
				this.RegisterItemsFromAssembly(assembly);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00026C31 File Offset: 0x00024E31
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00026C47 File Offset: 0x00024E47
		public static global::NLog.Config.ConfigurationItemFactory Default
		{
			get
			{
				global::NLog.Config.ConfigurationItemFactory result;
				if ((result = global::NLog.Config.ConfigurationItemFactory.defaultInstance) == null)
				{
					result = (global::NLog.Config.ConfigurationItemFactory.defaultInstance = global::NLog.Config.ConfigurationItemFactory.BuildDefaultFactory());
				}
				return result;
			}
			set
			{
				global::NLog.Config.ConfigurationItemFactory.defaultInstance = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00026C4F File Offset: 0x00024E4F
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00026C57 File Offset: 0x00024E57
		public global::NLog.Config.ConfigurationItemCreator CreateInstance { get; set; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00026C60 File Offset: 0x00024E60
		public global::NLog.Config.INamedItemFactory<global::NLog.Targets.Target, global::System.Type> Targets
		{
			get
			{
				return this._targets;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00026C68 File Offset: 0x00024E68
		public global::NLog.Config.INamedItemFactory<global::NLog.Filters.Filter, global::System.Type> Filters
		{
			get
			{
				return this._filters;
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00026C70 File Offset: 0x00024E70
		internal global::NLog.Config.LayoutRendererFactory GetLayoutRenderers()
		{
			return this._layoutRenderers;
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00026C78 File Offset: 0x00024E78
		public global::NLog.Config.INamedItemFactory<global::NLog.LayoutRenderers.LayoutRenderer, global::System.Type> LayoutRenderers
		{
			get
			{
				return this._layoutRenderers;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00026C80 File Offset: 0x00024E80
		public global::NLog.Config.INamedItemFactory<global::NLog.Layouts.Layout, global::System.Type> Layouts
		{
			get
			{
				return this._layouts;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00026C88 File Offset: 0x00024E88
		public global::NLog.Config.INamedItemFactory<global::NLog.LayoutRenderers.LayoutRenderer, global::System.Type> AmbientProperties
		{
			get
			{
				return this._ambientProperties;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x00026C90 File Offset: 0x00024E90
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x00026CA0 File Offset: 0x00024EA0
		[global::System.Obsolete("Use JsonConverter property instead. Marked obsolete on NLog 4.5")]
		public global::NLog.Targets.IJsonSerializer JsonSerializer
		{
			get
			{
				return this._jsonSerializer as global::NLog.Targets.IJsonSerializer;
			}
			set
			{
				global::NLog.IJsonConverter jsonSerializer;
				if (value == null)
				{
					global::NLog.IJsonConverter jsonConverter = global::NLog.Targets.DefaultJsonSerializer.Instance;
					jsonSerializer = jsonConverter;
				}
				else
				{
					global::NLog.IJsonConverter jsonConverter = new global::NLog.Targets.JsonConverterLegacy(value);
					jsonSerializer = jsonConverter;
				}
				this._jsonSerializer = jsonSerializer;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00026CC7 File Offset: 0x00024EC7
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x00026CCF File Offset: 0x00024ECF
		public global::NLog.IJsonConverter JsonConverter
		{
			get
			{
				return this._jsonSerializer;
			}
			set
			{
				this._jsonSerializer = (value ?? global::NLog.Targets.DefaultJsonSerializer.Instance);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00026CE1 File Offset: 0x00024EE1
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x00026CE8 File Offset: 0x00024EE8
		public global::NLog.IValueFormatter ValueFormatter
		{
			get
			{
				return global::NLog.MessageTemplates.ValueFormatter.Instance;
			}
			set
			{
				global::NLog.MessageTemplates.ValueFormatter.Instance = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00026CF0 File Offset: 0x00024EF0
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00026D31 File Offset: 0x00024F31
		public bool? ParseMessageTemplates
		{
			get
			{
				if (global::NLog.LogEventInfo.DefaultMessageFormatter == global::NLog.LogEventInfo.StringFormatMessageFormatter)
				{
					return new bool?(false);
				}
				if (global::NLog.LogEventInfo.DefaultMessageFormatter == global::NLog.Internal.LogMessageTemplateFormatter.Default.MessageFormatter)
				{
					return new bool?(true);
				}
				return null;
			}
			set
			{
				global::NLog.LogEventInfo.SetDefaultMessageFormatter(value);
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00026D39 File Offset: 0x00024F39
		public global::NLog.Config.INamedItemFactory<global::NLog.Time.TimeSource, global::System.Type> TimeSources
		{
			get
			{
				return this._timeSources;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00026D41 File Offset: 0x00024F41
		public global::NLog.Config.INamedItemFactory<global::System.Reflection.MethodInfo, global::System.Reflection.MethodInfo> ConditionMethods
		{
			get
			{
				return this._conditionMethods;
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00026D49 File Offset: 0x00024F49
		public void RegisterItemsFromAssembly(global::System.Reflection.Assembly assembly)
		{
			this.RegisterItemsFromAssembly(assembly, string.Empty);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00026D58 File Offset: 0x00024F58
		public void RegisterItemsFromAssembly(global::System.Reflection.Assembly assembly, string itemNamePrefix)
		{
			if (global::NLog.Config.ConfigurationItemFactory.AssemblyLoading != null)
			{
				global::NLog.Config.AssemblyLoadingEventArgs assemblyLoadingEventArgs = new global::NLog.Config.AssemblyLoadingEventArgs(assembly);
				global::NLog.Config.ConfigurationItemFactory.AssemblyLoading(null, assemblyLoadingEventArgs);
				if (assemblyLoadingEventArgs.Cancel)
				{
					global::NLog.Common.InternalLogger.Info<string>("Loading assembly '{0}' is canceled", assembly.FullName);
					return;
				}
			}
			global::NLog.Common.InternalLogger.Debug<string>("ScanAssembly('{0}')", assembly.FullName);
			global::System.Type[] array = assembly.SafeGetTypes();
			this.PreloadAssembly(array);
			foreach (object obj in this._allFactories)
			{
				((global::NLog.Config.IFactory)obj).ScanTypes(array, itemNamePrefix);
			}
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00026DFC File Offset: 0x00024FFC
		public void PreloadAssembly(global::System.Type[] typesToScan)
		{
			foreach (global::System.Type type in from t in typesToScan
			where t.Name.Equals("NLogPackageLoader", global::System.StringComparison.OrdinalIgnoreCase)
			select t)
			{
				global::NLog.Config.ConfigurationItemFactory.CallPreload(type);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00026E68 File Offset: 0x00025068
		private static void CallPreload(global::System.Type type)
		{
			if (type != null)
			{
				global::NLog.Common.InternalLogger.Debug<string>("Found for preload'{0}'", type.FullName);
				global::System.Reflection.MethodInfo method = type.GetMethod("Preload");
				if (method != null)
				{
					if (method.IsStatic)
					{
						global::NLog.Common.InternalLogger.Debug("NLogPackageLoader contains Preload method");
						try
						{
							method.Invoke(null, null);
							global::NLog.Common.InternalLogger.Debug<string>("Preload succesfully invoked for '{0}'", type.FullName);
							return;
						}
						catch (global::System.Exception ex)
						{
							global::NLog.Common.InternalLogger.Warn(ex, "Invoking Preload for '{0}' failed", new object[]
							{
								type.FullName
							});
							return;
						}
					}
					global::NLog.Common.InternalLogger.Debug("NLogPackageLoader contains a preload method, but isn't static");
					return;
				}
				global::NLog.Common.InternalLogger.Debug<string>("{0} doesn't contain Preload method", type.FullName);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00026F1C File Offset: 0x0002511C
		public void Clear()
		{
			foreach (object obj in this._allFactories)
			{
				((global::NLog.Config.IFactory)obj).Clear();
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00026F6C File Offset: 0x0002516C
		public void RegisterType(global::System.Type type, string itemNamePrefix)
		{
			foreach (object obj in this._allFactories)
			{
				((global::NLog.Config.IFactory)obj).RegisterType(type, itemNamePrefix);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00026FC0 File Offset: 0x000251C0
		private static global::NLog.Config.ConfigurationItemFactory BuildDefaultFactory()
		{
			global::System.Reflection.Assembly assembly = typeof(global::NLog.ILogger).GetAssembly();
			global::NLog.Config.ConfigurationItemFactory configurationItemFactory = new global::NLog.Config.ConfigurationItemFactory(new global::System.Reflection.Assembly[]
			{
				assembly
			});
			configurationItemFactory.RegisterExtendedItems();
			try
			{
				string text = string.Empty;
				string[] array = global::NLog.Internal.ArrayHelper.Empty<string>();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Reflection.Assembly> keyValuePair in global::NLog.Config.ConfigurationItemFactory.GetAutoLoadingFileLocations())
				{
					if (!string.IsNullOrEmpty(keyValuePair.Key))
					{
						if (string.IsNullOrEmpty(text))
						{
							text = keyValuePair.Key;
						}
						array = global::NLog.Config.ConfigurationItemFactory.GetNLogExtensionFiles(keyValuePair.Key);
						if (array.Length != 0)
						{
							text = keyValuePair.Key;
							break;
						}
					}
				}
				global::NLog.Common.InternalLogger.Debug<string>("Start auto loading, location: {0}", text);
				global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase);
				hashSet.Add(assembly.FullName);
				foreach (string text2 in array)
				{
					global::NLog.Common.InternalLogger.Info<string>("Auto loading assembly file: {0}", text2);
					bool flag = false;
					try
					{
						global::System.Reflection.Assembly assembly2 = global::NLog.Internal.AssemblyHelpers.LoadFromPath(text2, null);
						global::NLog.Common.InternalLogger.LogAssemblyVersion(assembly2);
						configurationItemFactory.RegisterItemsFromAssembly(assembly2);
						hashSet.Add(assembly2.FullName);
						flag = true;
					}
					catch (global::System.Exception ex)
					{
						if (ex.MustBeRethrownImmediately())
						{
							throw;
						}
						global::NLog.Common.InternalLogger.Warn(ex, "Auto loading assembly file: {0} failed! Skipping this file.", new object[]
						{
							text2
						});
					}
					if (flag)
					{
						global::NLog.Common.InternalLogger.Info<string>("Auto loading assembly file: {0} succeeded!", text2);
					}
				}
				foreach (global::System.Reflection.Assembly assembly3 in global::NLog.LogFactory.CurrentAppDomain.GetAssemblies())
				{
					if (assembly3.FullName.StartsWith("NLog.", global::System.StringComparison.OrdinalIgnoreCase) && !hashSet.Contains(assembly3.FullName))
					{
						configurationItemFactory.RegisterItemsFromAssembly(assembly3);
					}
					if (assembly3.FullName.StartsWith("NLog.Extensions.Logging,", global::System.StringComparison.OrdinalIgnoreCase) || assembly3.FullName.StartsWith("NLog.Web,", global::System.StringComparison.OrdinalIgnoreCase) || assembly3.FullName.StartsWith("NLog.Web.AspNetCore,", global::System.StringComparison.OrdinalIgnoreCase) || assembly3.FullName.StartsWith("Microsoft.Extensions.Logging,", global::System.StringComparison.OrdinalIgnoreCase) || assembly3.FullName.StartsWith("Microsoft.Extensions.Logging.Abstractions,", global::System.StringComparison.OrdinalIgnoreCase) || assembly3.FullName.StartsWith("Microsoft.Extensions.Logging.Filter,", global::System.StringComparison.OrdinalIgnoreCase) || assembly3.FullName.StartsWith("Microsoft.Logging,", global::System.StringComparison.OrdinalIgnoreCase))
					{
						global::NLog.LogManager.AddHiddenAssembly(assembly3);
					}
				}
			}
			catch (global::System.Security.SecurityException ex2)
			{
				global::NLog.Common.InternalLogger.Warn(ex2, "Seems that we do not have permission");
				if (ex2.MustBeRethrown())
				{
					throw;
				}
			}
			catch (global::System.UnauthorizedAccessException ex3)
			{
				global::NLog.Common.InternalLogger.Warn(ex3, "Seems that we do not have permission");
				if (ex3.MustBeRethrown())
				{
					throw;
				}
			}
			global::NLog.Common.InternalLogger.Debug("Auto loading done");
			return configurationItemFactory;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000272C8 File Offset: 0x000254C8
		internal static global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Reflection.Assembly>> GetAutoLoadingFileLocations()
		{
			global::System.Reflection.Assembly assembly = typeof(global::NLog.ILogger).GetAssembly();
			string assemblyLocation = global::NLog.Config.ConfigurationItemFactory.GetAssemblyFileLocation(assembly);
			global::NLog.Common.InternalLogger.Debug<string>("Auto loading based on NLog-Assembly found location: {0}", assemblyLocation);
			if (!string.IsNullOrEmpty(assemblyLocation))
			{
				yield return new global::System.Collections.Generic.KeyValuePair<string, global::System.Reflection.Assembly>(assemblyLocation, assembly);
			}
			global::System.Reflection.Assembly entryAssembly = global::System.Reflection.Assembly.GetEntryAssembly();
			string assemblyFileLocation = global::NLog.Config.ConfigurationItemFactory.GetAssemblyFileLocation(global::System.Reflection.Assembly.GetEntryAssembly());
			global::NLog.Common.InternalLogger.Debug<string>("Auto loading based on Entry-Assembly found location: {0}", assemblyFileLocation);
			if (!string.IsNullOrEmpty(assemblyFileLocation) && !string.Equals(assemblyFileLocation, assemblyLocation, global::System.StringComparison.OrdinalIgnoreCase))
			{
				yield return new global::System.Collections.Generic.KeyValuePair<string, global::System.Reflection.Assembly>(assemblyFileLocation, entryAssembly);
			}
			string baseDirectory = global::NLog.LogFactory.CurrentAppDomain.BaseDirectory;
			global::NLog.Common.InternalLogger.Debug<string>("Auto loading based on AppDomain-BaseDirectory found location: {0}", baseDirectory);
			if (!string.IsNullOrEmpty(baseDirectory) && !string.Equals(baseDirectory, assemblyLocation, global::System.StringComparison.OrdinalIgnoreCase))
			{
				yield return new global::System.Collections.Generic.KeyValuePair<string, global::System.Reflection.Assembly>(baseDirectory, null);
			}
			yield break;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000272D4 File Offset: 0x000254D4
		private static string GetAssemblyFileLocation(global::System.Reflection.Assembly assembly)
		{
			string text = string.Empty;
			string result;
			try
			{
				if (assembly == null)
				{
					result = string.Empty;
				}
				else
				{
					text = assembly.FullName;
					global::System.Uri uri;
					if (!global::System.Uri.TryCreate(assembly.CodeBase, global::System.UriKind.RelativeOrAbsolute, out uri))
					{
						global::NLog.Common.InternalLogger.Warn<string, string>("Skipping auto loading location because code base is unknown: '{0}' ({1})", assembly.CodeBase, text);
						result = string.Empty;
					}
					else
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(uri.LocalPath);
						if (string.IsNullOrEmpty(directoryName))
						{
							global::NLog.Common.InternalLogger.Warn<string, string>("Skipping auto loading location because it is not a valid directory: '{0}' ({1})", uri.LocalPath, text);
							result = string.Empty;
						}
						else if (!global::System.IO.Directory.Exists(directoryName))
						{
							global::NLog.Common.InternalLogger.Warn<string, string>("Skipping auto loading location because directory doesn't exists: '{0}' ({1})", directoryName, text);
							result = string.Empty;
						}
						else
						{
							result = directoryName;
						}
					}
				}
			}
			catch (global::System.PlatformNotSupportedException ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Skipping auto loading location because assembly lookup is not supported: {0}", new object[]
				{
					text
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
				result = string.Empty;
			}
			catch (global::System.Security.SecurityException ex2)
			{
				global::NLog.Common.InternalLogger.Warn(ex2, "Skipping auto loading location because assembly lookup is not allowed: {0}", new object[]
				{
					text
				});
				if (ex2.MustBeRethrown())
				{
					throw;
				}
				result = string.Empty;
			}
			catch (global::System.UnauthorizedAccessException ex3)
			{
				global::NLog.Common.InternalLogger.Warn(ex3, "Skipping auto loading location because assembly lookup is not allowed: {0}", new object[]
				{
					text
				});
				if (ex3.MustBeRethrown())
				{
					throw;
				}
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00027430 File Offset: 0x00025630
		private static string[] GetNLogExtensionFiles(string assemblyLocation)
		{
			string[] result;
			try
			{
				global::NLog.Common.InternalLogger.Debug<string>("Search for auto loading files in location: {0}", assemblyLocation);
				if (string.IsNullOrEmpty(assemblyLocation))
				{
					result = global::NLog.Internal.ArrayHelper.Empty<string>();
				}
				else
				{
					result = (from x in global::System.IO.Directory.GetFiles(assemblyLocation, "NLog*.dll").Select(new global::System.Func<string, string>(global::System.IO.Path.GetFileName))
					where !x.Equals("NLog.dll", global::System.StringComparison.OrdinalIgnoreCase)
					where !x.Equals("NLog.UnitTests.dll", global::System.StringComparison.OrdinalIgnoreCase)
					where !x.Equals("NLog.Extended.dll", global::System.StringComparison.OrdinalIgnoreCase)
					select global::System.IO.Path.Combine(assemblyLocation, x)).ToArray<string>();
				}
			}
			catch (global::System.IO.DirectoryNotFoundException ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Skipping auto loading location because assembly directory does not exist: {0}", new object[]
				{
					assemblyLocation
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
				result = global::NLog.Internal.ArrayHelper.Empty<string>();
			}
			catch (global::System.Security.SecurityException ex2)
			{
				global::NLog.Common.InternalLogger.Warn(ex2, "Skipping auto loading location because access not allowed to assembly directory: {0}", new object[]
				{
					assemblyLocation
				});
				if (ex2.MustBeRethrown())
				{
					throw;
				}
				result = global::NLog.Internal.ArrayHelper.Empty<string>();
			}
			catch (global::System.UnauthorizedAccessException ex3)
			{
				global::NLog.Common.InternalLogger.Warn(ex3, "Skipping auto loading location because access not allowed to assembly directory: {0}", new object[]
				{
					assemblyLocation
				});
				if (ex3.MustBeRethrown())
				{
					throw;
				}
				result = global::NLog.Internal.ArrayHelper.Empty<string>();
			}
			return result;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000275D0 File Offset: 0x000257D0
		private void RegisterExtendedItems()
		{
			string text = typeof(global::NLog.ILogger).AssemblyQualifiedName;
			string text2 = "NLog,";
			string str = "NLog.Extended,";
			int num = text.IndexOf(text2, global::System.StringComparison.OrdinalIgnoreCase);
			if (num >= 0)
			{
				text = ", " + str + text.Substring(num + text2.Length);
				string @namespace = typeof(global::NLog.Targets.DebugTarget).Namespace;
				this._targets.RegisterNamedType("AspNetTrace", @namespace + ".AspNetTraceTarget" + text);
				this._targets.RegisterNamedType("MSMQ", @namespace + ".MessageQueueTarget" + text);
				this._targets.RegisterNamedType("AspNetBufferingWrapper", @namespace + ".Wrappers.AspNetBufferingTargetWrapper" + text);
				string namespace2 = typeof(global::NLog.LayoutRenderers.MessageLayoutRenderer).Namespace;
				this._layoutRenderers.RegisterNamedType("appsetting", namespace2 + ".AppSettingLayoutRenderer" + text);
				this._layoutRenderers.RegisterNamedType("aspnet-application", namespace2 + ".AspNetApplicationValueLayoutRenderer" + text);
				this._layoutRenderers.RegisterNamedType("aspnet-request", namespace2 + ".AspNetRequestValueLayoutRenderer" + text);
				this._layoutRenderers.RegisterNamedType("aspnet-sessionid", namespace2 + ".AspNetSessionIDLayoutRenderer" + text);
				this._layoutRenderers.RegisterNamedType("aspnet-session", namespace2 + ".AspNetSessionValueLayoutRenderer" + text);
				this._layoutRenderers.RegisterNamedType("aspnet-user-authtype", namespace2 + ".AspNetUserAuthTypeLayoutRenderer" + text);
				this._layoutRenderers.RegisterNamedType("aspnet-user-identity", namespace2 + ".AspNetUserIdentityLayoutRenderer" + text);
			}
		}

		// Token: 0x04000439 RID: 1081
		private static global::NLog.Config.ConfigurationItemFactory defaultInstance;

		// Token: 0x0400043A RID: 1082
		private readonly global::System.Collections.Generic.IList<object> _allFactories;

		// Token: 0x0400043B RID: 1083
		private readonly global::NLog.Config.Factory<global::NLog.Targets.Target, global::NLog.Targets.TargetAttribute> _targets;

		// Token: 0x0400043C RID: 1084
		private readonly global::NLog.Config.Factory<global::NLog.Filters.Filter, global::NLog.Filters.FilterAttribute> _filters;

		// Token: 0x0400043D RID: 1085
		private readonly global::NLog.Config.LayoutRendererFactory _layoutRenderers;

		// Token: 0x0400043E RID: 1086
		private readonly global::NLog.Config.Factory<global::NLog.Layouts.Layout, global::NLog.Layouts.LayoutAttribute> _layouts;

		// Token: 0x0400043F RID: 1087
		private readonly global::NLog.Config.MethodFactory<global::NLog.Conditions.ConditionMethodsAttribute, global::NLog.Conditions.ConditionMethodAttribute> _conditionMethods;

		// Token: 0x04000440 RID: 1088
		private readonly global::NLog.Config.Factory<global::NLog.LayoutRenderers.LayoutRenderer, global::NLog.LayoutRenderers.AmbientPropertyAttribute> _ambientProperties;

		// Token: 0x04000441 RID: 1089
		private readonly global::NLog.Config.Factory<global::NLog.Time.TimeSource, global::NLog.Time.TimeSourceAttribute> _timeSources;

		// Token: 0x04000442 RID: 1090
		private global::NLog.IJsonConverter _jsonSerializer = global::NLog.Targets.DefaultJsonSerializer.Instance;
	}
}
