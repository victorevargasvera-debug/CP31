using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000262 RID: 610
	public static class ThemeManager
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x0005C744 File Offset: 0x0005A944
		static ThemeManager()
		{
			global::System.Reflection.Assembly[] assemblies = global::System.AppDomain.CurrentDomain.GetAssemblies();
			foreach (global::System.Reflection.Assembly item in assemblies)
			{
				global::Infragistics.Windows.Themes.ThemeManager.g_assemblyList.Add(item);
			}
			global::Infragistics.Windows.Themes.ThemeManager.g_loadedAssemblyVersion++;
			try
			{
				global::System.Security.Permissions.SecurityPermission securityPermission = new global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityPermissionFlag.ControlAppDomain);
				try
				{
					securityPermission.Assert();
				}
				catch (global::System.InvalidOperationException)
				{
				}
				global::Infragistics.Windows.Themes.ThemeManager.HookAssemblyLoad();
				global::Infragistics.Windows.Themes.ThemeManager.g_hookedAssemblyLoad = true;
			}
			catch (global::System.Security.SecurityException)
			{
				global::Infragistics.Windows.Themes.ThemeManager.g_hookedAssemblyLoad = false;
				global::Infragistics.Windows.Themes.ThemeManager.g_reviewedAssemblies = new global::System.Collections.Hashtable();
				for (int j = 0; j < assemblies.Length; j++)
				{
					global::Infragistics.Windows.Themes.ThemeManager.g_reviewedAssemblies.Add(assemblies[j], null);
				}
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06001838 RID: 6200 RVA: 0x0005C8D4 File Offset: 0x0005AAD4
		// (remove) Token: 0x06001839 RID: 6201 RVA: 0x0005C934 File Offset: 0x0005AB34
		public static event global::System.EventHandler CurrentThemeChanged
		{
			add
			{
				lock (global::Infragistics.Windows.Themes.ThemeManager.g_EventLock)
				{
					if (global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate == null)
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate = value;
					}
					else
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate = (global::System.EventHandler)global::System.Delegate.Combine(global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate, value);
					}
				}
			}
			remove
			{
				lock (global::Infragistics.Windows.Themes.ThemeManager.g_EventLock)
				{
					if (global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate != null)
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate = (global::System.EventHandler)global::System.Delegate.Remove(global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate, value);
					}
				}
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x0600183A RID: 6202 RVA: 0x0005C98C File Offset: 0x0005AB8C
		// (remove) Token: 0x0600183B RID: 6203 RVA: 0x0005C9EC File Offset: 0x0005ABEC
		public static event global::System.EventHandler RegistrationInfoChanged
		{
			add
			{
				lock (global::Infragistics.Windows.Themes.ThemeManager.g_EventLock)
				{
					if (global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate == null)
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate = value;
					}
					else
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate = (global::System.EventHandler)global::System.Delegate.Combine(global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate, value);
					}
				}
			}
			remove
			{
				lock (global::Infragistics.Windows.Themes.ThemeManager.g_EventLock)
				{
					if (global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate != null)
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate = (global::System.EventHandler)global::System.Delegate.Remove(global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate, value);
					}
				}
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0005CA44 File Offset: 0x0005AC44
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		public static string CurrentTheme
		{
			get
			{
				return global::Infragistics.Windows.Themes.ThemeManager.g_currentTheme;
			}
			set
			{
				if (global::Infragistics.Windows.Themes.ThemeManager.g_currentTheme != value)
				{
					if (value == "[default]")
					{
						value = null;
					}
					if (value != null && global::Infragistics.Windows.Themes.ThemeManager.GetThemeInfo(value, false) == null)
					{
						throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_6", new object[]
						{
							value
						}));
					}
					global::Infragistics.Windows.Themes.ThemeManager.g_currentTheme = value;
					global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeInfoDirty = true;
					global::Infragistics.Windows.Themes.ThemeManager.VerifyCurrentThemeInfo();
					if (global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate != null)
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeChangedDelegate(null, global::System.EventArgs.Empty);
					}
				}
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0005CAC8 File Offset: 0x0005ACC8
		private static object CoerceTheme(global::System.Windows.DependencyObject target, object value)
		{
			if (value is string)
			{
				if (string.Compare((string)value, "[default]", true) == 0)
				{
					return null;
				}
				if (((string)value).Length == 0)
				{
					return null;
				}
			}
			return value;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
		private static void OnThemeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (target is global::System.Windows.FrameworkElement)
			{
				global::System.Type type = target.GetType();
				string[] groupingsForType = global::Infragistics.Windows.Themes.ThemeManager.GetGroupingsForType(type);
				if (groupingsForType == null)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_ThemeManagerRegisterGroupings", new object[]
					{
						type.FullName
					}));
				}
				global::Infragistics.Windows.Themes.ThemeManager.OnThemeChanged(target as global::System.Windows.FrameworkElement, (string)e.NewValue, groupingsForType);
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0005CB57 File Offset: 0x0005AD57
		public static string GetTheme(global::System.Windows.DependencyObject d)
		{
			return (string)d.GetValue(global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0005CB69 File Offset: 0x0005AD69
		public static void SetTheme(global::System.Windows.DependencyObject d, string value)
		{
			d.SetValue(global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty, value);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0005CB78 File Offset: 0x0005AD78
		public static string[] GetGroupingsForType(global::System.Type type)
		{
			string[] array = global::Infragistics.Windows.Themes.ThemeManager.GetGroupingsForTypeImpl(type);
			if (array != null)
			{
				array = (string[])array.Clone();
			}
			return array;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0005CB9C File Offset: 0x0005AD9C
		private static string[] GetGroupingsForTypeImpl(global::System.Type type)
		{
			string[] result = null;
			lock (global::Infragistics.Windows.Themes.ThemeManager.g_RegisteredGroupingsSyncObject)
			{
				while (null != type)
				{
					if (global::Infragistics.Windows.Themes.ThemeManager.g_registeredGroupings.TryGetValue(type, out result))
					{
						return result;
					}
					type = type.BaseType;
				}
			}
			return result;
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0005CC00 File Offset: 0x0005AE00
		public static string[] GetGroupingsForTheme(string theme)
		{
			global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo = global::Infragistics.Windows.Themes.ThemeManager.GetThemeInfo(theme, false);
			if (themeInfo == null)
			{
				return new string[0];
			}
			string[] groupingNames;
			lock (typeof(global::Infragistics.Windows.Themes.ThemeManager))
			{
				groupingNames = themeInfo.GetGroupingNames();
			}
			return groupingNames;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0005CC58 File Offset: 0x0005AE58
		public static global::System.Windows.ResourceDictionary GetResourceSet(string theme, string grouping)
		{
			global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo = global::Infragistics.Windows.Themes.ThemeManager.GetThemeInfo(theme, true);
			if (themeInfo == null)
			{
				return null;
			}
			if (grouping == null)
			{
				throw new global::System.ArgumentNullException("grouping");
			}
			if (grouping.Length == 0)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_7"));
			}
			global::System.Windows.ResourceDictionary resourceSet;
			lock (typeof(global::Infragistics.Windows.Themes.ThemeManager))
			{
				if (themeInfo == global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeInfo)
				{
					global::Infragistics.Windows.Themes.ThemeManager.VerifyCurrentThemeInfo();
				}
				string grouping2 = grouping.ToLower();
				resourceSet = themeInfo.GetResourceSet(grouping2, true);
			}
			return resourceSet;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0005CCE8 File Offset: 0x0005AEE8
		public static string[] GetThemes()
		{
			return global::Infragistics.Windows.Themes.ThemeManager.GetThemes(false);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0005CCF0 File Offset: 0x0005AEF0
		public static string[] GetThemes(bool includeDefault)
		{
			return global::Infragistics.Windows.Themes.ThemeManager.GetThemes(includeDefault, "*");
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0005CD00 File Offset: 0x0005AF00
		public static string[] GetThemes(bool includeDefault, string grouping)
		{
			global::Infragistics.Windows.Themes.ThemeManager.ProcessLoadedAssemblies();
			string[] result;
			lock (typeof(global::Infragistics.Windows.Themes.ThemeManager))
			{
				int count = global::Infragistics.Windows.Themes.ThemeManager.g_themes.Count;
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				global::System.Collections.Generic.IList<global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo> values = global::Infragistics.Windows.Themes.ThemeManager.g_themes.Values;
				if (includeDefault)
				{
					list.Add("[default]");
				}
				if (grouping != null)
				{
					grouping = grouping.ToLower();
				}
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo = values[i];
					if (themeInfo.HasGrouping(grouping))
					{
						list.Add(themeInfo.Name);
					}
				}
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0005CDB0 File Offset: 0x0005AFB0
		public static bool IsThemeValid(string theme)
		{
			if (theme == null || theme.Length == 0)
			{
				return false;
			}
			global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo = global::Infragistics.Windows.Themes.ThemeManager.GetThemeInfo(theme, true);
			return themeInfo != null;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0005CDD9 File Offset: 0x0005AFD9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static void OnThemeChanged(global::System.Windows.FrameworkElement themedControl, string theme, string[] groupings)
		{
			global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo.ProcessThemeChanged(themedControl, theme, groupings);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0005CDE3 File Offset: 0x0005AFE3
		public static void Register(string theme, string grouping, global::System.Windows.ResourceDictionary resources)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(resources, "resources");
			global::Infragistics.Windows.Themes.ThemeManager.Register(theme, grouping, resources);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0005CDF8 File Offset: 0x0005AFF8
		public static void Register(global::Infragistics.Windows.Themes.ResourceSetLocator locator)
		{
			if (locator.Assembly == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ThemeManagerLocatorAssembly"));
			}
			global::Infragistics.Windows.Utilities.ThrowIfNull(locator, "locator");
			global::Infragistics.Windows.Themes.ThemeManager.Register(locator.Theme, locator.Grouping, locator);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0005CE38 File Offset: 0x0005B038
		private static void Register(string theme, string grouping, object objectToRegister)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(theme, "theme");
			global::Infragistics.Windows.Utilities.ThrowIfNull(grouping, "grouping");
			global::Infragistics.Windows.Utilities.ThrowIfNull(objectToRegister, "objectToRegister");
			if (theme.Length == 0)
			{
				throw new global::System.ArgumentException("theme");
			}
			if (grouping.Length == 0)
			{
				throw new global::System.ArgumentException("grouping");
			}
			if (!(objectToRegister is global::System.Windows.ResourceDictionary) && !(objectToRegister is global::Infragistics.Windows.Themes.ResourceSetLocator))
			{
				throw new global::System.ArgumentException("objectToRegister");
			}
			string text = theme.ToLower();
			if (text == "[default]" || text == "[current]")
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_8"));
			}
			string text2 = grouping.ToLower();
			if (text2 == "*")
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_9"));
			}
			bool flag = false;
			global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo = null;
			global::System.Threading.Monitor.Enter(typeof(global::Infragistics.Windows.Themes.ThemeManager));
			try
			{
				if (!global::Infragistics.Windows.Themes.ThemeManager.g_themes.TryGetValue(text, out themeInfo))
				{
					themeInfo = new global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo(theme);
					global::Infragistics.Windows.Themes.ThemeManager.g_themes.Add(text, themeInfo);
					flag = true;
				}
				if (objectToRegister is global::Infragistics.Windows.Themes.ResourceSetLocator)
				{
					flag = themeInfo.Register(text2, (global::Infragistics.Windows.Themes.ResourceSetLocator)objectToRegister);
				}
				else
				{
					flag = themeInfo.Register(text2, (global::System.Windows.ResourceDictionary)objectToRegister);
				}
			}
			finally
			{
				global::System.Threading.Monitor.Exit(typeof(global::Infragistics.Windows.Themes.ThemeManager));
				if (flag)
				{
					if (themeInfo.Name == global::Infragistics.Windows.Themes.ThemeManager.g_currentTheme)
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeInfoDirty = true;
					}
					if (!global::Infragistics.Windows.Themes.ThemeManager.g_ignoreRegistrationInfoChanged)
					{
						themeInfo.VerifyAllGroupings();
						global::Infragistics.Windows.Themes.ThemeManager.VerifyCurrentThemeInfo();
						if (global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate != null)
						{
							global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate(null, global::System.EventArgs.Empty);
						}
					}
				}
			}
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0005CFC4 File Offset: 0x0005B1C4
		public static void RegisterGroupings(global::System.Type type, string[] groupings)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(type, "type");
			global::Infragistics.Windows.Utilities.ThrowIfNull(groupings, "groupings");
			lock (global::Infragistics.Windows.Themes.ThemeManager.g_RegisteredGroupingsSyncObject)
			{
				if (global::Infragistics.Windows.Themes.ThemeManager.g_registeredGroupings.ContainsKey(type))
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_ThemeManagerGroupingsAlreadyRegistered", new object[]
					{
						type.FullName
					}));
				}
				string[] array = (string[])groupings.Clone();
				foreach (string value in array)
				{
					if (string.IsNullOrEmpty(value))
					{
						throw new global::System.ArgumentException(global::SR.GetString("LE_ThemeManagerGroupingsCannotBeNull"), "groupings");
					}
				}
				global::Infragistics.Windows.Themes.ThemeManager.g_registeredGroupings[type] = groupings;
			}
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x0005D098 File Offset: 0x0005B298
		public static void VerifyThemeInformationRegistered(global::System.Reflection.Assembly assembly)
		{
			global::Infragistics.Windows.Themes.ThemeManager.ProcessLoadedAssemblies();
			if (null != assembly && !global::Infragistics.Windows.Themes.ThemeManager.g_hookedAssemblyLoad && !global::Infragistics.Windows.Themes.ThemeManager.g_ignoreRegistrationInfoChanged && !global::Infragistics.Windows.Themes.ThemeManager.g_reviewedAssemblies.ContainsKey(assembly))
			{
				global::Infragistics.Windows.Themes.ThemeManager.g_reviewedAssemblies.Add(assembly, null);
				global::Infragistics.Windows.Themes.ThemeManager.OnAssemblyLoaded(assembly);
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0005D0D8 File Offset: 0x0005B2D8
		internal static global::System.Windows.ResourceDictionary Clone(global::System.Windows.ResourceDictionary source)
		{
			global::Infragistics.Windows.Themes.ResourceSet resourceSet = source as global::Infragistics.Windows.Themes.ResourceSet;
			if (resourceSet != null)
			{
				resourceSet.VerifyResources();
			}
			global::Infragistics.Windows.Themes.ResourceWasher resourceWasher = source as global::Infragistics.Windows.Themes.ResourceWasher;
			if (resourceWasher != null)
			{
				resourceWasher.VerifyThemeAccess();
			}
			global::System.Windows.ResourceDictionary resourceDictionary = new global::System.Windows.ResourceDictionary();
			foreach (object obj in source)
			{
				global::System.Collections.DictionaryEntry dictionaryEntry = (global::System.Collections.DictionaryEntry)obj;
				resourceDictionary.Add(dictionaryEntry.Key, dictionaryEntry.Value);
			}
			foreach (global::System.Windows.ResourceDictionary source2 in source.MergedDictionaries)
			{
				global::System.Windows.ResourceDictionary item = global::Infragistics.Windows.Themes.ThemeManager.Clone(source2);
				resourceDictionary.MergedDictionaries.Add(item);
			}
			return resourceDictionary;
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0005D1B8 File Offset: 0x0005B3B8
		private static global::Infragistics.Windows.Themes.AssemblyResourceSetLoader CreateAssemblyInfo(global::System.Type assemblyResourceSetLoaderType)
		{
			global::Infragistics.Windows.Themes.AssemblyResourceSetLoader result;
			try
			{
				result = (global::System.Activator.CreateInstance(assemblyResourceSetLoaderType) as global::Infragistics.Windows.Themes.AssemblyResourceSetLoader);
			}
			catch (global::System.Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0005D1EC File Offset: 0x0005B3EC
		private static void CreateAssemblyResourceSetLoaders(global::System.Collections.Generic.List<global::Infragistics.Windows.Themes.AssemblyResourceSetLoader> list, global::System.Collections.Generic.List<global::System.Type> assemblyStyleResourceSetLoaderTypes)
		{
			if (assemblyStyleResourceSetLoaderTypes != null)
			{
				foreach (global::System.Type assemblyResourceSetLoaderType in assemblyStyleResourceSetLoaderTypes)
				{
					global::Infragistics.Windows.Themes.AssemblyResourceSetLoader assemblyResourceSetLoader = global::Infragistics.Windows.Themes.ThemeManager.CreateAssemblyInfo(assemblyResourceSetLoaderType);
					if (assemblyResourceSetLoader != null)
					{
						list.Add(assemblyResourceSetLoader);
					}
				}
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0005D248 File Offset: 0x0005B448
		private static void GetAssemblyResourceSetLoaderTypes(global::System.Collections.Generic.List<global::System.Type> list, global::System.Reflection.Assembly assembly)
		{
			try
			{
				if (!(assembly.GetType() == typeof(global::System.Reflection.Emit.AssemblyBuilder)))
				{
					if (!assembly.ReflectionOnly)
					{
						object[] customAttributes = assembly.GetCustomAttributes(typeof(global::Infragistics.Windows.Themes.AssemblyResourceSetLoaderAttribute), false);
						if (customAttributes != null && customAttributes.Length > 0)
						{
							list.Add(((global::Infragistics.Windows.Themes.AssemblyResourceSetLoaderAttribute)customAttributes[0]).AssemblyResourceSetLoaderType);
						}
					}
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0005D2BC File Offset: 0x0005B4BC
		private static void GetAssemblyThemeGroupingName(global::System.Collections.Generic.List<string> list, global::System.Reflection.Assembly assembly)
		{
			try
			{
				if (!(assembly.GetType() == typeof(global::System.Reflection.Emit.AssemblyBuilder)))
				{
					if (!assembly.ReflectionOnly)
					{
						object[] customAttributes = assembly.GetCustomAttributes(typeof(global::Infragistics.Windows.Themes.AssemblyThemeGroupingNameAttribute), false);
						if (customAttributes != null && customAttributes.Length > 0)
						{
							list.Add(((global::Infragistics.Windows.Themes.AssemblyThemeGroupingNameAttribute)customAttributes[0]).Name);
						}
					}
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0005D330 File Offset: 0x0005B530
		private static global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo GetThemeInfo(string theme, bool allowSpecialLiterals)
		{
			if (theme == null)
			{
				throw new global::System.ArgumentNullException("theme");
			}
			if (theme.Length == 0)
			{
				throw new global::System.ArgumentException("theme");
			}
			global::Infragistics.Windows.Themes.ThemeManager.ProcessLoadedAssemblies();
			global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo result;
			lock (typeof(global::Infragistics.Windows.Themes.ThemeManager))
			{
				string text = theme.ToLower();
				string a;
				if (allowSpecialLiterals && (a = text) != null)
				{
					if (a == "[current]")
					{
						return global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeInfo;
					}
					if (a == "[default]")
					{
						text = theme.ToLower();
					}
				}
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo;
				if (!global::Infragistics.Windows.Themes.ThemeManager.g_themes.TryGetValue(text, out themeInfo))
				{
					result = null;
				}
				else
				{
					result = themeInfo;
				}
			}
			return result;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0005D3EC File Offset: 0x0005B5EC
		private static void HookAssemblyLoad()
		{
			global::System.AppDomain.CurrentDomain.AssemblyLoad += global::Infragistics.Windows.Themes.ThemeManager.OnAssemblyLoaded;
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0005D404 File Offset: 0x0005B604
		private static void OnAssemblyLoaded(object sender, global::System.AssemblyLoadEventArgs e)
		{
			global::Infragistics.Windows.Themes.ThemeManager.OnAssemblyLoaded(e.LoadedAssembly);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0005D414 File Offset: 0x0005B614
		private static void OnAssemblyLoaded(global::System.Reflection.Assembly loadedAssembly)
		{
			try
			{
				global::System.Threading.Monitor.Enter(global::Infragistics.Windows.Themes.ThemeManager.g_AssemblyLoadSyncObject);
				global::Infragistics.Windows.Themes.ThemeManager.g_assemblyList.Add(loadedAssembly);
				global::Infragistics.Windows.Themes.ThemeManager.g_loadedAssemblyVersion++;
			}
			finally
			{
				global::System.Threading.Monitor.Exit(global::Infragistics.Windows.Themes.ThemeManager.g_AssemblyLoadSyncObject);
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0005D460 File Offset: 0x0005B660
		private static void ProcessLoadedAssemblies()
		{
			if (global::Infragistics.Windows.Themes.ThemeManager.g_lastProcessedAssemblyVersion != global::Infragistics.Windows.Themes.ThemeManager.g_loadedAssemblyVersion)
			{
				global::Infragistics.Windows.Themes.ThemeManager.ProcessLoadedAssembliesImpl();
			}
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0005D474 File Offset: 0x0005B674
		private static void ProcessLoadedAssembliesImpl()
		{
			global::System.Reflection.Assembly[] array;
			try
			{
				global::System.Threading.Monitor.Enter(global::Infragistics.Windows.Themes.ThemeManager.g_AssemblyLoadSyncObject);
				array = new global::System.Reflection.Assembly[global::Infragistics.Windows.Themes.ThemeManager.g_assemblyList.Count];
				global::Infragistics.Windows.Themes.ThemeManager.g_assemblyList.CopyTo(array);
				global::Infragistics.Windows.Themes.ThemeManager.g_assemblyList.Clear();
				global::Infragistics.Windows.Themes.ThemeManager.g_lastProcessedAssemblyVersion = global::Infragistics.Windows.Themes.ThemeManager.g_loadedAssemblyVersion;
			}
			finally
			{
				global::System.Threading.Monitor.Exit(global::Infragistics.Windows.Themes.ThemeManager.g_AssemblyLoadSyncObject);
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				global::Infragistics.Windows.Themes.ThemeManager.GetAssemblyThemeGroupingName(list, array[i]);
			}
			global::System.Collections.Generic.List<global::System.Type> list2 = new global::System.Collections.Generic.List<global::System.Type>();
			for (int j = 0; j < array.Length; j++)
			{
				global::Infragistics.Windows.Themes.ThemeManager.GetAssemblyResourceSetLoaderTypes(list2, array[j]);
			}
			global::System.Collections.Generic.List<string> list3 = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<global::System.Type> list4 = new global::System.Collections.Generic.List<global::System.Type>();
			lock (typeof(global::Infragistics.Windows.Themes.ThemeManager))
			{
				list4.AddRange(global::Infragistics.Windows.Themes.ThemeManager.g_processedResourceSetTypes);
				if (list2.Count > 0)
				{
					foreach (global::System.Type item in list2)
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_processedResourceSetTypes.Add(item);
					}
				}
				if (list.Count > 0)
				{
					foreach (string item2 in list)
					{
						global::Infragistics.Windows.Themes.ThemeManager.g_loadedGroupingNames.Add(item2);
					}
				}
				list3.AddRange(global::Infragistics.Windows.Themes.ThemeManager.g_loadedGroupingNames);
			}
			global::Infragistics.Windows.Themes.ThemeManager.g_ignoreRegistrationInfoChanged = true;
			try
			{
				if (list.Count > 0)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.Themes.AssemblyResourceSetLoader> list5 = new global::System.Collections.Generic.List<global::Infragistics.Windows.Themes.AssemblyResourceSetLoader>();
					global::Infragistics.Windows.Themes.ThemeManager.CreateAssemblyResourceSetLoaders(list5, list4);
					foreach (global::Infragistics.Windows.Themes.AssemblyResourceSetLoader assemblyResourceSetLoader in list5)
					{
						assemblyResourceSetLoader.RegisterResourceSets(list);
					}
				}
				if (list2.Count > 0)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.Themes.AssemblyResourceSetLoader> list6 = new global::System.Collections.Generic.List<global::Infragistics.Windows.Themes.AssemblyResourceSetLoader>();
					global::Infragistics.Windows.Themes.ThemeManager.CreateAssemblyResourceSetLoaders(list6, list2);
					foreach (global::Infragistics.Windows.Themes.AssemblyResourceSetLoader assemblyResourceSetLoader2 in list6)
					{
						assemblyResourceSetLoader2.RegisterResourceSets(list3);
					}
				}
			}
			finally
			{
				global::Infragistics.Windows.Themes.ThemeManager.g_ignoreRegistrationInfoChanged = false;
			}
			if (list.Count > 0 || list2.Count > 0)
			{
				if (global::Infragistics.Windows.Themes.ThemeManager.g_themes != null)
				{
					lock (typeof(global::Infragistics.Windows.Themes.ThemeManager))
					{
						foreach (global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo in global::Infragistics.Windows.Themes.ThemeManager.g_themes.Values)
						{
							themeInfo.VerifyAllGroupings();
						}
					}
				}
				global::Infragistics.Windows.Themes.ThemeManager.VerifyCurrentThemeInfo();
				if (global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate != null)
				{
					global::Infragistics.Windows.Themes.ThemeManager.g_registrationInfoChangedDelegate(null, global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0005D77C File Offset: 0x0005B97C
		private static void VerifyCurrentThemeInfo()
		{
			if (!global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeInfoDirty || global::Infragistics.Windows.Themes.ThemeManager.g_ignoreRegistrationInfoChanged)
			{
				return;
			}
			global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeInfoDirty = false;
			lock (typeof(global::Infragistics.Windows.Themes.ThemeManager))
			{
				string text;
				if (global::Infragistics.Windows.Themes.ThemeManager.g_currentTheme != null)
				{
					text = global::Infragistics.Windows.Themes.ThemeManager.g_currentTheme.ToLower();
				}
				else
				{
					text = null;
				}
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo = null;
				if (text != null)
				{
					themeInfo = global::Infragistics.Windows.Themes.ThemeManager.GetThemeInfo(text, false);
				}
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo2 = global::Infragistics.Windows.Themes.ThemeManager.g_currentThemeInfo;
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				list.AddRange(themeInfo2.GetGroupingNames());
				if (themeInfo != null)
				{
					themeInfo.TransferRegisteredObjects(themeInfo2);
					foreach (string item in themeInfo.GetGroupingNames())
					{
						list.Remove(item);
					}
				}
				foreach (string grouping in list)
				{
					themeInfo2.Register(grouping, new global::System.Windows.ResourceDictionary());
				}
				themeInfo2.VerifyAllGroupings();
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0005D88C File Offset: 0x0005BA8C
		private static void VerifyResourcesWashed(global::System.Windows.ResourceDictionary rd)
		{
			if (rd == null)
			{
				return;
			}
			int count = rd.MergedDictionaries.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Themes.ResourceWasher resourceWasher = rd.MergedDictionaries[i] as global::Infragistics.Windows.Themes.ResourceWasher;
				if (resourceWasher != null)
				{
					resourceWasher.VerifyThemeAccess();
				}
			}
		}

		// Token: 0x04000B8A RID: 2954
		public const string AllGroupingsLiteral = "*";

		// Token: 0x04000B8B RID: 2955
		public const string ThemeDefaultLiteral = "[default]";

		// Token: 0x04000B8C RID: 2956
		public const string ThemeCurrentLiteral = "[current]";

		// Token: 0x04000B8D RID: 2957
		public const string ThemeNameGeneric = "Generic";

		// Token: 0x04000B8E RID: 2958
		public const string ThemeNameAero = "Aero";

		// Token: 0x04000B8F RID: 2959
		public const string ThemeNameOnyx = "Onyx";

		// Token: 0x04000B90 RID: 2960
		public const string ThemeNameRoyale = "Royale";

		// Token: 0x04000B91 RID: 2961
		public const string ThemeNameRoyaleStrong = "RoyaleStrong";

		// Token: 0x04000B92 RID: 2962
		public const string ThemeNameForestGreen = "ForestGreen";

		// Token: 0x04000B93 RID: 2963
		public const string ThemeNameLeaf = "Leaf";

		// Token: 0x04000B94 RID: 2964
		public const string ThemeNameLipstick = "Lipstick";

		// Token: 0x04000B95 RID: 2965
		public const string ThemeNameLunaNormal = "LunaNormal";

		// Token: 0x04000B96 RID: 2966
		public const string ThemeNameLunaOlive = "LunaOlive";

		// Token: 0x04000B97 RID: 2967
		public const string ThemeNameLunaSilver = "LunaSilver";

		// Token: 0x04000B98 RID: 2968
		public const string ThemeNameMetro = "Metro";

		// Token: 0x04000B99 RID: 2969
		public const string ThemeNameOffice2010Blue = "Office2010Blue";

		// Token: 0x04000B9A RID: 2970
		public const string ThemeNameOffice2k7Blue = "Office2k7Blue";

		// Token: 0x04000B9B RID: 2971
		public const string ThemeNameOffice2k7Black = "Office2k7Black";

		// Token: 0x04000B9C RID: 2972
		public const string ThemeNameOffice2k7Silver = "Office2k7Silver";

		// Token: 0x04000B9D RID: 2973
		public const string ThemeNameHighContrast = "HighContrast";

		// Token: 0x04000B9E RID: 2974
		public const string ThemeNameWashBaseLight = "WashBaseLight";

		// Token: 0x04000B9F RID: 2975
		public const string ThemeNameWashBaseDark = "WashBaseDark";

		// Token: 0x04000BA0 RID: 2976
		public const string ThemeNamePrintBasic = "Print Basic";

		// Token: 0x04000BA1 RID: 2977
		public const string ThemeNameIGTheme = "IGTheme";

		// Token: 0x04000BA2 RID: 2978
		private static string g_currentTheme = "Generic";

		// Token: 0x04000BA3 RID: 2979
		private static global::System.Collections.Generic.SortedList<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo> g_themes = new global::System.Collections.Generic.SortedList<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo>();

		// Token: 0x04000BA4 RID: 2980
		private static global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo g_currentThemeInfo = new global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo("[current]");

		// Token: 0x04000BA5 RID: 2981
		private static bool g_currentThemeInfoDirty = true;

		// Token: 0x04000BA6 RID: 2982
		private static object g_EventLock = new object();

		// Token: 0x04000BA7 RID: 2983
		private static global::System.EventHandler g_currentThemeChangedDelegate;

		// Token: 0x04000BA8 RID: 2984
		private static global::System.EventHandler g_registrationInfoChangedDelegate;

		// Token: 0x04000BA9 RID: 2985
		private static bool g_ignoreRegistrationInfoChanged;

		// Token: 0x04000BAA RID: 2986
		private static int g_loadedAssemblyVersion;

		// Token: 0x04000BAB RID: 2987
		private static int g_lastProcessedAssemblyVersion;

		// Token: 0x04000BAC RID: 2988
		private static global::System.Collections.Generic.List<global::System.Reflection.Assembly> g_assemblyList = new global::System.Collections.Generic.List<global::System.Reflection.Assembly>();

		// Token: 0x04000BAD RID: 2989
		private static readonly object g_AssemblyLoadSyncObject = new object();

		// Token: 0x04000BAE RID: 2990
		private static readonly bool g_hookedAssemblyLoad;

		// Token: 0x04000BAF RID: 2991
		private static readonly global::System.Collections.Hashtable g_reviewedAssemblies;

		// Token: 0x04000BB0 RID: 2992
		private static global::System.Collections.Generic.List<string> g_loadedGroupingNames = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000BB1 RID: 2993
		private static global::System.Collections.Generic.List<global::System.Type> g_processedResourceSetTypes = new global::System.Collections.Generic.List<global::System.Type>();

		// Token: 0x04000BB2 RID: 2994
		private static readonly object g_RegisteredGroupingsSyncObject = new object();

		// Token: 0x04000BB3 RID: 2995
		private static global::System.Collections.Generic.Dictionary<global::System.Type, string[]> g_registeredGroupings = new global::System.Collections.Generic.Dictionary<global::System.Type, string[]>();

		// Token: 0x04000BB4 RID: 2996
		public static readonly global::System.Windows.RoutedEvent ThemeChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ThemeChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<string>), typeof(global::Infragistics.Windows.Themes.ThemeManager));

		// Token: 0x04000BB5 RID: 2997
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::System.Windows.DependencyProperty.RegisterAttached("Theme", typeof(string), typeof(global::Infragistics.Windows.Themes.ThemeManager), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Themes.ThemeManager.OnThemeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Themes.ThemeManager.CoerceTheme)));

		// Token: 0x02000263 RID: 611
		private class ThemeInfo
		{
			// Token: 0x0600185D RID: 6237 RVA: 0x0005D8D0 File Offset: 0x0005BAD0
			internal ThemeInfo(string name)
			{
				this._name = name;
				this._registrationInfo = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo>();
			}

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x0600185E RID: 6238 RVA: 0x0005D8EA File Offset: 0x0005BAEA
			public string Name
			{
				get
				{
					return this._name;
				}
			}

			// Token: 0x0600185F RID: 6239 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
			private static global::System.Windows.ResourceDictionary CreateAllGroupings(global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo info)
			{
				global::System.Windows.ResourceDictionary resourceDictionary = global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.CreateProvidedDictionary();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo> keyValuePair in info._registrationInfo)
				{
					global::System.Windows.ResourceDictionary providedDictionary = keyValuePair.Value.GetProvidedDictionary(true);
					resourceDictionary.MergedDictionaries.Add(providedDictionary);
				}
				return resourceDictionary;
			}

			// Token: 0x06001860 RID: 6240 RVA: 0x0005D964 File Offset: 0x0005BB64
			private static global::System.Windows.ResourceDictionary CreateProvidedDictionary()
			{
				global::System.Windows.ResourceDictionary resourceDictionary = new global::System.Windows.ResourceDictionary();
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.PrepareProvidedDictionary(resourceDictionary);
				return resourceDictionary;
			}

			// Token: 0x06001861 RID: 6241 RVA: 0x0005D980 File Offset: 0x0005BB80
			internal string[] GetGroupingNames()
			{
				string[] array = new string[this._registrationInfo.Count];
				this._registrationInfo.Keys.CopyTo(array, 0);
				global::System.Array.Sort<string>(array, global::System.StringComparer.Ordinal);
				return array;
			}

			// Token: 0x06001862 RID: 6242 RVA: 0x0005D9BC File Offset: 0x0005BBBC
			private global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo GetInfo(string grouping)
			{
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo registrationInfo;
				if (!this._registrationInfo.TryGetValue(grouping, out registrationInfo))
				{
					registrationInfo = new global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo(grouping);
					this._registrationInfo.Add(grouping, registrationInfo);
				}
				return registrationInfo;
			}

			// Token: 0x06001863 RID: 6243 RVA: 0x0005D9F0 File Offset: 0x0005BBF0
			public global::System.Windows.ResourceDictionary GetResourceSet(string grouping, bool createIfNull)
			{
				if (grouping == "*")
				{
					return this.VerifyAllGroupings(createIfNull);
				}
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo registrationInfo;
				if (!this._registrationInfo.TryGetValue(grouping, out registrationInfo))
				{
					return null;
				}
				return registrationInfo.GetProvidedDictionary(createIfNull);
			}

			// Token: 0x06001864 RID: 6244 RVA: 0x0005DA2B File Offset: 0x0005BC2B
			internal bool HasGrouping(string grouping)
			{
				if (string.IsNullOrEmpty(grouping) || grouping == "*")
				{
					return this._registrationInfo.Count > 0;
				}
				return this._registrationInfo.ContainsKey(grouping);
			}

			// Token: 0x06001865 RID: 6245 RVA: 0x0005DA5D File Offset: 0x0005BC5D
			private static void PrepareProvidedDictionary(global::System.Windows.ResourceDictionary rd)
			{
				if (global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo._sharedOwner == null)
				{
					global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo._sharedOwner = new global::System.Windows.FrameworkElement();
				}
				if (global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo._sharedEmptyDictionary == null)
				{
					global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo._sharedEmptyDictionary = new global::System.Windows.ResourceDictionary();
				}
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo._sharedOwner.Resources = rd;
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo._sharedOwner.Resources = global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo._sharedEmptyDictionary;
			}

			// Token: 0x06001866 RID: 6246 RVA: 0x0005DA9C File Offset: 0x0005BC9C
			public bool Register(string grouping, global::Infragistics.Windows.Themes.ResourceSetLocator locator)
			{
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo info = this.GetInfo(grouping);
				global::System.Windows.ResourceDictionary resourceDictionary;
				if (info.Register(locator, out resourceDictionary))
				{
					this._areAllGroupingsDirty = true;
					return true;
				}
				return false;
			}

			// Token: 0x06001867 RID: 6247 RVA: 0x0005DAC8 File Offset: 0x0005BCC8
			public bool Register(string grouping, global::System.Windows.ResourceDictionary dictionary)
			{
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo info = this.GetInfo(grouping);
				global::System.Windows.ResourceDictionary resourceDictionary;
				if (info.Register(dictionary, out resourceDictionary))
				{
					this._areAllGroupingsDirty = true;
					return true;
				}
				return false;
			}

			// Token: 0x06001868 RID: 6248 RVA: 0x0005DAF4 File Offset: 0x0005BCF4
			internal void TransferRegisteredObjects(global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo destThemeInfo)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo> keyValuePair in this._registrationInfo)
				{
					if (keyValuePair.Value.RegisteredLocator != null)
					{
						destThemeInfo.Register(keyValuePair.Key, keyValuePair.Value.RegisteredLocator);
					}
					else
					{
						destThemeInfo.Register(keyValuePair.Key, keyValuePair.Value.RegisteredDictionary);
					}
				}
			}

			// Token: 0x06001869 RID: 6249 RVA: 0x0005DB84 File Offset: 0x0005BD84
			internal void VerifyAllGroupings()
			{
				this.VerifyAllGroupings(false);
			}

			// Token: 0x0600186A RID: 6250 RVA: 0x0005DB90 File Offset: 0x0005BD90
			private global::System.Windows.ResourceDictionary VerifyAllGroupings(bool createIfNull)
			{
				global::System.Windows.ResourceDictionary resourceDictionary = null;
				if (this._areAllGroupingsDirty && this._allGroupings != null)
				{
					resourceDictionary = ((this._allGroupings != null) ? (global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._allGroupings) as global::System.Windows.ResourceDictionary) : null);
					if (resourceDictionary != null)
					{
						this._areAllGroupingsDirty = false;
						if (resourceDictionary.MergedDictionaries.Count == 1)
						{
							resourceDictionary.MergedDictionaries[0] = global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.CreateAllGroupings(this);
						}
						return resourceDictionary;
					}
					this._allGroupings = null;
				}
				if (createIfNull)
				{
					this._areAllGroupingsDirty = false;
					resourceDictionary = new global::System.Windows.ResourceDictionary();
					resourceDictionary.MergedDictionaries.Add(global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.CreateAllGroupings(this));
					this._allGroupings = new global::System.WeakReference(resourceDictionary);
				}
				return resourceDictionary;
			}

			// Token: 0x04000BB6 RID: 2998
			private string _name;

			// Token: 0x04000BB7 RID: 2999
			private global::System.WeakReference _allGroupings;

			// Token: 0x04000BB8 RID: 3000
			private bool _areAllGroupingsDirty;

			// Token: 0x04000BB9 RID: 3001
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo> _registrationInfo;

			// Token: 0x04000BBA RID: 3002
			[global::System.ThreadStatic]
			private static global::System.Windows.FrameworkElement _sharedOwner;

			// Token: 0x04000BBB RID: 3003
			[global::System.ThreadStatic]
			private static global::System.Windows.ResourceDictionary _sharedEmptyDictionary;

			// Token: 0x02000264 RID: 612
			private class RegistrationInfo
			{
				// Token: 0x0600186B RID: 6251 RVA: 0x0005DC2C File Offset: 0x0005BE2C
				internal RegistrationInfo(string grouping)
				{
					this._grouping = grouping;
				}

				// Token: 0x170005C3 RID: 1475
				// (get) Token: 0x0600186C RID: 6252 RVA: 0x0005DC3B File Offset: 0x0005BE3B
				internal string Grouping
				{
					get
					{
						return this._grouping;
					}
				}

				// Token: 0x170005C4 RID: 1476
				// (get) Token: 0x0600186D RID: 6253 RVA: 0x0005DC43 File Offset: 0x0005BE43
				internal global::Infragistics.Windows.Themes.ResourceSetLocator RegisteredLocator
				{
					get
					{
						return this._registeredLocator;
					}
				}

				// Token: 0x170005C5 RID: 1477
				// (get) Token: 0x0600186E RID: 6254 RVA: 0x0005DC4B File Offset: 0x0005BE4B
				internal global::System.Windows.ResourceDictionary RegisteredDictionary
				{
					get
					{
						return this._registeredDictionary;
					}
				}

				// Token: 0x0600186F RID: 6255 RVA: 0x0005DC54 File Offset: 0x0005BE54
				internal global::System.Windows.ResourceDictionary GetProvidedDictionary(bool createIfNull)
				{
					global::System.Windows.ResourceDictionary resourceDictionary;
					if (this._providedDictionary != null)
					{
						resourceDictionary = (global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._providedDictionary) as global::System.Windows.ResourceDictionary);
						if (resourceDictionary != null)
						{
							return resourceDictionary;
						}
						this._providedDictionary = null;
					}
					if (!createIfNull)
					{
						return null;
					}
					resourceDictionary = new global::System.Windows.ResourceDictionary();
					if (this._registeredDictionary != null)
					{
						resourceDictionary.MergedDictionaries.Add(this._registeredDictionary);
					}
					else if (this._registeredLocator != null)
					{
						resourceDictionary.MergedDictionaries.Add(new global::Infragistics.Windows.Themes.ResourceSetLoader(this._registeredLocator));
					}
					global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.PrepareProvidedDictionary(resourceDictionary);
					this._providedDictionary = new global::System.WeakReference(resourceDictionary);
					return resourceDictionary;
				}

				// Token: 0x06001870 RID: 6256 RVA: 0x0005DCE0 File Offset: 0x0005BEE0
				internal bool Register(global::Infragistics.Windows.Themes.ResourceSetLocator value, out global::System.Windows.ResourceDictionary oldDictionary)
				{
					oldDictionary = null;
					if (this._registeredLocator == value)
					{
						return false;
					}
					this._registeredLocator = value;
					this._registeredDictionary = null;
					global::System.Windows.ResourceDictionary providedDictionary = this.GetProvidedDictionary(false);
					if (providedDictionary != null)
					{
						if (providedDictionary.IsReadOnly)
						{
							this._providedDictionary = null;
						}
						else if (providedDictionary.MergedDictionaries.Count == 1)
						{
							oldDictionary = providedDictionary.MergedDictionaries[0];
							providedDictionary.MergedDictionaries[0] = new global::Infragistics.Windows.Themes.ResourceSetLoader(this._registeredLocator);
						}
					}
					return true;
				}

				// Token: 0x06001871 RID: 6257 RVA: 0x0005DD5C File Offset: 0x0005BF5C
				internal bool Register(global::System.Windows.ResourceDictionary value, out global::System.Windows.ResourceDictionary oldDictionary)
				{
					oldDictionary = null;
					if (value == this._registeredDictionary)
					{
						return false;
					}
					this._registeredLocator = null;
					this._registeredDictionary = value;
					global::System.Windows.ResourceDictionary providedDictionary = this.GetProvidedDictionary(false);
					if (providedDictionary != null)
					{
						if (providedDictionary.IsReadOnly)
						{
							this._providedDictionary = null;
						}
						else if (providedDictionary.MergedDictionaries.Count == 1)
						{
							oldDictionary = providedDictionary.MergedDictionaries[0];
							providedDictionary.MergedDictionaries[0] = this._registeredDictionary;
						}
					}
					return true;
				}

				// Token: 0x04000BBC RID: 3004
				private global::System.WeakReference _providedDictionary;

				// Token: 0x04000BBD RID: 3005
				private global::System.Windows.ResourceDictionary _registeredDictionary;

				// Token: 0x04000BBE RID: 3006
				private global::Infragistics.Windows.Themes.ResourceSetLocator _registeredLocator;

				// Token: 0x04000BBF RID: 3007
				private string _grouping;
			}
		}

		// Token: 0x02000265 RID: 613
		private class ControlThemeInfo : global::System.Windows.DependencyObject
		{
			// Token: 0x06001872 RID: 6258 RVA: 0x0005DDD0 File Offset: 0x0005BFD0
			private ControlThemeInfo(global::System.Windows.FrameworkElement element)
			{
				this._element = element;
				if (!element.IsInitialized)
				{
					element.Initialized += this.OnElementInitialized;
					return;
				}
				if (element.IsLoaded)
				{
					element.AddHandler(global::System.Windows.FrameworkElement.UnloadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementUnloaded), true);
					return;
				}
				element.AddHandler(global::System.Windows.FrameworkElement.LoadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementLoaded), true);
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x06001873 RID: 6259 RVA: 0x0005DE3E File Offset: 0x0005C03E
			private bool IsApplyThemeNeeded
			{
				get
				{
					return this._currentTheme != this._appliedTheme || this._currentGroupings != this._appliedGroupings;
				}
			}

			// Token: 0x06001874 RID: 6260 RVA: 0x0005DE68 File Offset: 0x0005C068
			private void ApplyTheme(string theme, string[] groupings, bool updateMembers)
			{
				if (this._isApplyingTheme)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotChangeThemeWhileApplyingTheme", new object[]
					{
						theme,
						this._currentTheme
					}));
				}
				this._isApplyingTheme = true;
				try
				{
					this.ApplyThemeImpl(theme, groupings, updateMembers);
				}
				finally
				{
					this._isApplyingTheme = false;
				}
			}

			// Token: 0x06001875 RID: 6261 RVA: 0x0005DECC File Offset: 0x0005C0CC
			private void ApplyThemeImpl(string theme, string[] groupings, bool updateMembers)
			{
				if (updateMembers)
				{
					this._currentTheme = theme;
					this._currentGroupings = groupings;
				}
				this._appliedTheme = theme;
				this._appliedGroupings = groupings;
				global::System.Windows.ResourceDictionary resourceDictionary = new global::System.Windows.ResourceDictionary();
				if (!string.IsNullOrEmpty(theme))
				{
					foreach (string text in groupings)
					{
						if (text != null)
						{
							global::System.Windows.ResourceDictionary resourceSet = global::Infragistics.Windows.Themes.ThemeManager.GetResourceSet(theme, text);
							if (resourceSet != null)
							{
								resourceDictionary.MergedDictionaries.Add(resourceSet);
							}
						}
					}
				}
				global::System.Collections.ObjectModel.Collection<global::System.Windows.ResourceDictionary> mergedDictionaries = this._element.Resources.MergedDictionaries;
				if (this._mergedDictionary != null)
				{
					for (int j = 0; j < mergedDictionaries.Count; j++)
					{
						if (mergedDictionaries[j] == this._mergedDictionary)
						{
							this._mergedDictionary = resourceDictionary;
							mergedDictionaries[j] = this._mergedDictionary;
							break;
						}
					}
				}
				if (this._mergedDictionary != resourceDictionary)
				{
					this._mergedDictionary = resourceDictionary;
					mergedDictionaries.Insert(0, this._mergedDictionary);
				}
			}

			// Token: 0x06001876 RID: 6262 RVA: 0x0005DFAC File Offset: 0x0005C1AC
			private void OnDelayedUnload(object param)
			{
				if (global::Infragistics.Windows.Utilities.HasLoadedAncestor(this._element))
				{
					return;
				}
				this._element.RemoveHandler(global::System.Windows.FrameworkElement.UnloadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementUnloaded));
				this._element.AddHandler(global::System.Windows.FrameworkElement.LoadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementLoaded), true);
				this.ApplyTheme(null, null, false);
			}

			// Token: 0x06001877 RID: 6263 RVA: 0x0005E00C File Offset: 0x0005C20C
			private void OnElementInitialized(object sender, global::System.EventArgs e)
			{
				this._element.Initialized -= this.OnElementInitialized;
				if (this._element.IsLoaded)
				{
					this._element.AddHandler(global::System.Windows.FrameworkElement.UnloadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementUnloaded), true);
				}
				else
				{
					this._element.AddHandler(global::System.Windows.FrameworkElement.LoadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementLoaded), true);
				}
				if (this.IsApplyThemeNeeded)
				{
					this.ApplyTheme(this._currentTheme, this._currentGroupings, false);
				}
			}

			// Token: 0x06001878 RID: 6264 RVA: 0x0005E094 File Offset: 0x0005C294
			private void OnElementLoaded(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this._element.RemoveHandler(global::System.Windows.FrameworkElement.LoadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementLoaded));
				this._element.AddHandler(global::System.Windows.FrameworkElement.UnloadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementUnloaded), true);
				if (this.IsApplyThemeNeeded)
				{
					this.ApplyTheme(this._currentTheme, this._currentGroupings, false);
				}
			}

			// Token: 0x06001879 RID: 6265 RVA: 0x0005E0F5 File Offset: 0x0005C2F5
			private void OnElementUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this._element.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.ContextIdle, new global::System.Threading.SendOrPostCallback(this.OnDelayedUnload), null);
			}

			// Token: 0x0600187A RID: 6266 RVA: 0x0005E118 File Offset: 0x0005C318
			internal static void ProcessThemeChanged(global::System.Windows.FrameworkElement themedControl, string theme, string[] groupings)
			{
				global::Infragistics.Windows.Utilities.ThrowIfNull(themedControl, "themedControl");
				global::Infragistics.Windows.Utilities.ThrowIfNull(groupings, "groupings");
				global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo controlThemeInfo = themedControl.GetValue(global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo.ControlThemeInfoProperty) as global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo;
				if (controlThemeInfo == null)
				{
					controlThemeInfo = new global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo(themedControl);
					themedControl.SetValue(global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo.ControlThemeInfoProperty, controlThemeInfo);
				}
				if (themedControl.IsLoaded || global::Infragistics.Windows.Reporting.ReportSection.GetIsInReport(themedControl))
				{
					controlThemeInfo.ApplyTheme(theme, groupings, true);
					return;
				}
				if (!controlThemeInfo.IsApplyThemeNeeded && themedControl.IsInitialized && global::Infragistics.Windows.Utilities.HasLoadedAncestor(themedControl))
				{
					controlThemeInfo.ApplyTheme(theme, groupings, true);
					return;
				}
				controlThemeInfo._currentTheme = theme;
				controlThemeInfo._currentGroupings = groupings;
			}

			// Token: 0x04000BC0 RID: 3008
			private string _currentTheme;

			// Token: 0x04000BC1 RID: 3009
			private global::System.Windows.ResourceDictionary _mergedDictionary;

			// Token: 0x04000BC2 RID: 3010
			private global::System.Windows.FrameworkElement _element;

			// Token: 0x04000BC3 RID: 3011
			private string[] _currentGroupings;

			// Token: 0x04000BC4 RID: 3012
			private string _appliedTheme;

			// Token: 0x04000BC5 RID: 3013
			private string[] _appliedGroupings;

			// Token: 0x04000BC6 RID: 3014
			private bool _isApplyingTheme;

			// Token: 0x04000BC7 RID: 3015
			private static readonly global::System.Windows.DependencyProperty ControlThemeInfoProperty = global::System.Windows.DependencyProperty.Register("ControlThemeInfo", typeof(global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo), typeof(global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo), new global::System.Windows.FrameworkPropertyMetadata(null));
		}
	}
}
