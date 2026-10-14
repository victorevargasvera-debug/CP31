using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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
	// Token: 0x0200029B RID: 667
	public static class ThemeManager
	{
		// Token: 0x06001A47 RID: 6727 RVA: 0x00063250 File Offset: 0x00061450
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

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06001A48 RID: 6728 RVA: 0x000633E0 File Offset: 0x000615E0
		// (remove) Token: 0x06001A49 RID: 6729 RVA: 0x00063440 File Offset: 0x00061640
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

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06001A4A RID: 6730 RVA: 0x00063498 File Offset: 0x00061698
		// (remove) Token: 0x06001A4B RID: 6731 RVA: 0x000634F8 File Offset: 0x000616F8
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x00063550 File Offset: 0x00061750
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x00063558 File Offset: 0x00061758
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

		// Token: 0x06001A4E RID: 6734 RVA: 0x000635D4 File Offset: 0x000617D4
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

		// Token: 0x06001A4F RID: 6735 RVA: 0x00063604 File Offset: 0x00061804
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

		// Token: 0x06001A50 RID: 6736 RVA: 0x00063663 File Offset: 0x00061863
		public static string GetTheme(global::System.Windows.DependencyObject d)
		{
			return (string)d.GetValue(global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00063675 File Offset: 0x00061875
		public static void SetTheme(global::System.Windows.DependencyObject d, string value)
		{
			d.SetValue(global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty, value);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00063684 File Offset: 0x00061884
		public static string[] GetGroupingsForType(global::System.Type type)
		{
			string[] array = global::Infragistics.Windows.Themes.ThemeManager.GetGroupingsForTypeImpl(type);
			if (array != null)
			{
				array = (string[])array.Clone();
			}
			return array;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000636A8 File Offset: 0x000618A8
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

		// Token: 0x06001A54 RID: 6740 RVA: 0x0006370C File Offset: 0x0006190C
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

		// Token: 0x06001A55 RID: 6741 RVA: 0x00063764 File Offset: 0x00061964
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

		// Token: 0x06001A56 RID: 6742 RVA: 0x000637F4 File Offset: 0x000619F4
		public static string[] GetThemes()
		{
			return global::Infragistics.Windows.Themes.ThemeManager.GetThemes(false);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000637FC File Offset: 0x000619FC
		public static string[] GetThemes(bool includeDefault)
		{
			return global::Infragistics.Windows.Themes.ThemeManager.GetThemes(includeDefault, "*");
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0006380C File Offset: 0x00061A0C
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

		// Token: 0x06001A59 RID: 6745 RVA: 0x000638BC File Offset: 0x00061ABC
		public static bool IsThemeValid(string theme)
		{
			if (theme == null || theme.Length == 0)
			{
				return false;
			}
			global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo themeInfo = global::Infragistics.Windows.Themes.ThemeManager.GetThemeInfo(theme, true);
			return themeInfo != null;
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000638E5 File Offset: 0x00061AE5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static void OnThemeChanged(global::System.Windows.FrameworkElement themedControl, string theme, string[] groupings)
		{
			global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo.ProcessThemeChanged(themedControl, theme, groupings);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000638EF File Offset: 0x00061AEF
		public static void Register(string theme, string grouping, global::System.Windows.ResourceDictionary resources)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(resources, "resources");
			global::Infragistics.Windows.Themes.ThemeManager.Register(theme, grouping, resources);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00063904 File Offset: 0x00061B04
		public static void Register(global::Infragistics.Windows.Themes.ResourceSetLocator locator)
		{
			if (locator.Assembly == null)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ThemeManagerLocatorAssembly"));
			}
			global::Infragistics.Windows.Utilities.ThrowIfNull(locator, "locator");
			global::Infragistics.Windows.Themes.ThemeManager.Register(locator.Theme, locator.Grouping, locator);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00063944 File Offset: 0x00061B44
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

		// Token: 0x06001A5E RID: 6750 RVA: 0x00063AD0 File Offset: 0x00061CD0
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

		// Token: 0x06001A5F RID: 6751 RVA: 0x00063BA4 File Offset: 0x00061DA4
		public static void VerifyThemeInformationRegistered(global::System.Reflection.Assembly assembly)
		{
			global::Infragistics.Windows.Themes.ThemeManager.ProcessLoadedAssemblies();
			if (null != assembly && !global::Infragistics.Windows.Themes.ThemeManager.g_hookedAssemblyLoad && !global::Infragistics.Windows.Themes.ThemeManager.g_ignoreRegistrationInfoChanged && !global::Infragistics.Windows.Themes.ThemeManager.g_reviewedAssemblies.ContainsKey(assembly))
			{
				global::Infragistics.Windows.Themes.ThemeManager.g_reviewedAssemblies.Add(assembly, null);
				global::Infragistics.Windows.Themes.ThemeManager.OnAssemblyLoaded(assembly);
			}
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00063BE4 File Offset: 0x00061DE4
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

		// Token: 0x06001A61 RID: 6753 RVA: 0x00063CC4 File Offset: 0x00061EC4
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

		// Token: 0x06001A62 RID: 6754 RVA: 0x00063CF8 File Offset: 0x00061EF8
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

		// Token: 0x06001A63 RID: 6755 RVA: 0x00063D54 File Offset: 0x00061F54
		internal static global::System.Windows.ResourceDictionary GetAppliedThemeDictionary(global::System.Windows.FrameworkElement fe)
		{
			return global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo.GetThemeDictionary(fe);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00063D5C File Offset: 0x00061F5C
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

		// Token: 0x06001A65 RID: 6757 RVA: 0x00063DD0 File Offset: 0x00061FD0
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

		// Token: 0x06001A66 RID: 6758 RVA: 0x00063E44 File Offset: 0x00062044
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

		// Token: 0x06001A67 RID: 6759 RVA: 0x00063F00 File Offset: 0x00062100
		private static void HookAssemblyLoad()
		{
			global::System.AppDomain.CurrentDomain.AssemblyLoad += global::Infragistics.Windows.Themes.ThemeManager.OnAssemblyLoaded;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00063F18 File Offset: 0x00062118
		private static void OnAssemblyLoaded(object sender, global::System.AssemblyLoadEventArgs e)
		{
			global::Infragistics.Windows.Themes.ThemeManager.OnAssemblyLoaded(e.LoadedAssembly);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00063F28 File Offset: 0x00062128
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

		// Token: 0x06001A6A RID: 6762 RVA: 0x00063F74 File Offset: 0x00062174
		private static void ProcessLoadedAssemblies()
		{
			if (global::Infragistics.Windows.Themes.ThemeManager.g_lastProcessedAssemblyVersion != global::Infragistics.Windows.Themes.ThemeManager.g_loadedAssemblyVersion)
			{
				global::Infragistics.Windows.Themes.ThemeManager.ProcessLoadedAssembliesImpl();
			}
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00063F88 File Offset: 0x00062188
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

		// Token: 0x06001A6C RID: 6764 RVA: 0x00064290 File Offset: 0x00062490
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

		// Token: 0x06001A6D RID: 6765 RVA: 0x000643A0 File Offset: 0x000625A0
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

		// Token: 0x04000CEF RID: 3311
		public const string AllGroupingsLiteral = "*";

		// Token: 0x04000CF0 RID: 3312
		public const string ThemeDefaultLiteral = "[default]";

		// Token: 0x04000CF1 RID: 3313
		public const string ThemeCurrentLiteral = "[current]";

		// Token: 0x04000CF2 RID: 3314
		public const string ThemeNameGeneric = "Generic";

		// Token: 0x04000CF3 RID: 3315
		public const string ThemeNameAero = "Aero";

		// Token: 0x04000CF4 RID: 3316
		public const string ThemeNameOnyx = "Onyx";

		// Token: 0x04000CF5 RID: 3317
		public const string ThemeNameRoyale = "Royale";

		// Token: 0x04000CF6 RID: 3318
		public const string ThemeNameRoyaleStrong = "RoyaleStrong";

		// Token: 0x04000CF7 RID: 3319
		public const string ThemeNameForestGreen = "ForestGreen";

		// Token: 0x04000CF8 RID: 3320
		public const string ThemeNameLeaf = "Leaf";

		// Token: 0x04000CF9 RID: 3321
		public const string ThemeNameLipstick = "Lipstick";

		// Token: 0x04000CFA RID: 3322
		public const string ThemeNameLunaNormal = "LunaNormal";

		// Token: 0x04000CFB RID: 3323
		public const string ThemeNameLunaOlive = "LunaOlive";

		// Token: 0x04000CFC RID: 3324
		public const string ThemeNameLunaSilver = "LunaSilver";

		// Token: 0x04000CFD RID: 3325
		public const string ThemeNameMetro = "Metro";

		// Token: 0x04000CFE RID: 3326
		public const string ThemeNameMetroDark = "MetroDark";

		// Token: 0x04000CFF RID: 3327
		public const string ThemeNameOffice2010Blue = "Office2010Blue";

		// Token: 0x04000D00 RID: 3328
		public const string ThemeNameOffice2013 = "Office2013";

		// Token: 0x04000D01 RID: 3329
		public const string ThemeNameOffice2k7Blue = "Office2k7Blue";

		// Token: 0x04000D02 RID: 3330
		public const string ThemeNameOffice2k7Black = "Office2k7Black";

		// Token: 0x04000D03 RID: 3331
		public const string ThemeNameOffice2k7Silver = "Office2k7Silver";

		// Token: 0x04000D04 RID: 3332
		public const string ThemeNameHighContrast = "HighContrast";

		// Token: 0x04000D05 RID: 3333
		public const string ThemeNameWashBaseLight = "WashBaseLight";

		// Token: 0x04000D06 RID: 3334
		public const string ThemeNameWashBaseDark = "WashBaseDark";

		// Token: 0x04000D07 RID: 3335
		public const string ThemeNamePrintBasic = "Print Basic";

		// Token: 0x04000D08 RID: 3336
		public const string ThemeNameIGTheme = "IGTheme";

		// Token: 0x04000D09 RID: 3337
		private static string g_currentTheme = "Generic";

		// Token: 0x04000D0A RID: 3338
		private static global::System.Collections.Generic.SortedList<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo> g_themes = new global::System.Collections.Generic.SortedList<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo>();

		// Token: 0x04000D0B RID: 3339
		private static global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo g_currentThemeInfo = new global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo("[current]");

		// Token: 0x04000D0C RID: 3340
		private static bool g_currentThemeInfoDirty = true;

		// Token: 0x04000D0D RID: 3341
		private static object g_EventLock = new object();

		// Token: 0x04000D0E RID: 3342
		private static global::System.EventHandler g_currentThemeChangedDelegate;

		// Token: 0x04000D0F RID: 3343
		private static global::System.EventHandler g_registrationInfoChangedDelegate;

		// Token: 0x04000D10 RID: 3344
		private static bool g_ignoreRegistrationInfoChanged;

		// Token: 0x04000D11 RID: 3345
		private static int g_loadedAssemblyVersion;

		// Token: 0x04000D12 RID: 3346
		private static int g_lastProcessedAssemblyVersion;

		// Token: 0x04000D13 RID: 3347
		private static global::System.Collections.Generic.List<global::System.Reflection.Assembly> g_assemblyList = new global::System.Collections.Generic.List<global::System.Reflection.Assembly>();

		// Token: 0x04000D14 RID: 3348
		private static readonly object g_AssemblyLoadSyncObject = new object();

		// Token: 0x04000D15 RID: 3349
		private static readonly bool g_hookedAssemblyLoad;

		// Token: 0x04000D16 RID: 3350
		private static readonly global::System.Collections.Hashtable g_reviewedAssemblies;

		// Token: 0x04000D17 RID: 3351
		private static global::System.Collections.Generic.List<string> g_loadedGroupingNames = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000D18 RID: 3352
		private static global::System.Collections.Generic.List<global::System.Type> g_processedResourceSetTypes = new global::System.Collections.Generic.List<global::System.Type>();

		// Token: 0x04000D19 RID: 3353
		private static readonly object g_RegisteredGroupingsSyncObject = new object();

		// Token: 0x04000D1A RID: 3354
		private static global::System.Collections.Generic.Dictionary<global::System.Type, string[]> g_registeredGroupings = new global::System.Collections.Generic.Dictionary<global::System.Type, string[]>();

		// Token: 0x04000D1B RID: 3355
		public static readonly global::System.Windows.RoutedEvent ThemeChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ThemeChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<string>), typeof(global::Infragistics.Windows.Themes.ThemeManager));

		// Token: 0x04000D1C RID: 3356
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::System.Windows.DependencyProperty.RegisterAttached("Theme", typeof(string), typeof(global::Infragistics.Windows.Themes.ThemeManager), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Themes.ThemeManager.OnThemeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Themes.ThemeManager.CoerceTheme)));

		// Token: 0x0200029C RID: 668
		private class ThemeInfo
		{
			// Token: 0x06001A6E RID: 6766 RVA: 0x000643EC File Offset: 0x000625EC
			internal ThemeInfo(string name)
			{
				this._name = name;
				this._registrationInfo = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo>();
				this._allGroupings = new global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryList(false, () => global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.CreateAllGroupings(this));
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00064430 File Offset: 0x00062630
			public string Name
			{
				get
				{
					return this._name;
				}
			}

			// Token: 0x06001A70 RID: 6768 RVA: 0x00064438 File Offset: 0x00062638
			private static global::System.Windows.ResourceDictionary CreateAllGroupings(global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo info)
			{
				global::System.Windows.ResourceDictionary resourceDictionary = global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.CreateProvidedDictionary();
				global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo>[] array = info._registrationInfo.ToArray<global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo>>();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo> keyValuePair in array)
				{
					global::System.Windows.ResourceDictionary providedDictionary = keyValuePair.Value.GetProvidedDictionary(true);
					resourceDictionary.MergedDictionaries.Add(providedDictionary);
				}
				return resourceDictionary;
			}

			// Token: 0x06001A71 RID: 6769 RVA: 0x00064498 File Offset: 0x00062698
			private static global::System.Windows.ResourceDictionary CreateProvidedDictionary()
			{
				global::System.Windows.ResourceDictionary resourceDictionary = new global::System.Windows.ResourceDictionary();
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.PrepareProvidedDictionary(resourceDictionary);
				return resourceDictionary;
			}

			// Token: 0x06001A72 RID: 6770 RVA: 0x000644B4 File Offset: 0x000626B4
			internal string[] GetGroupingNames()
			{
				string[] array = new string[this._registrationInfo.Count];
				this._registrationInfo.Keys.CopyTo(array, 0);
				global::System.Array.Sort<string>(array, global::System.StringComparer.Ordinal);
				return array;
			}

			// Token: 0x06001A73 RID: 6771 RVA: 0x000644F0 File Offset: 0x000626F0
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

			// Token: 0x06001A74 RID: 6772 RVA: 0x00064524 File Offset: 0x00062724
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

			// Token: 0x06001A75 RID: 6773 RVA: 0x0006455F File Offset: 0x0006275F
			internal bool HasGrouping(string grouping)
			{
				if (string.IsNullOrEmpty(grouping) || grouping == "*")
				{
					return this._registrationInfo.Count > 0;
				}
				return this._registrationInfo.ContainsKey(grouping);
			}

			// Token: 0x06001A76 RID: 6774 RVA: 0x00064591 File Offset: 0x00062791
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

			// Token: 0x06001A77 RID: 6775 RVA: 0x000645D0 File Offset: 0x000627D0
			public bool Register(string grouping, global::Infragistics.Windows.Themes.ResourceSetLocator locator)
			{
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo info = this.GetInfo(grouping);
				if (info.Register(locator))
				{
					this._areAllGroupingsDirty = true;
					return true;
				}
				return false;
			}

			// Token: 0x06001A78 RID: 6776 RVA: 0x000645F8 File Offset: 0x000627F8
			public bool Register(string grouping, global::System.Windows.ResourceDictionary dictionary)
			{
				global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo info = this.GetInfo(grouping);
				if (info.Register(dictionary))
				{
					this._areAllGroupingsDirty = true;
					return true;
				}
				return false;
			}

			// Token: 0x06001A79 RID: 6777 RVA: 0x00064620 File Offset: 0x00062820
			internal void TransferRegisteredObjects(global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo destThemeInfo)
			{
				global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo>[] array = this._registrationInfo.ToArray<global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo>>();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo> keyValuePair in array)
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

			// Token: 0x06001A7A RID: 6778 RVA: 0x0006469A File Offset: 0x0006289A
			internal void VerifyAllGroupings()
			{
				this.VerifyAllGroupings(false);
			}

			// Token: 0x06001A7B RID: 6779 RVA: 0x000646A4 File Offset: 0x000628A4
			private global::System.Windows.ResourceDictionary VerifyAllGroupings(bool createIfNull)
			{
				if (this._areAllGroupingsDirty)
				{
					this._areAllGroupingsDirty = false;
					this._allGroupings.Refresh();
				}
				return this._allGroupings.GetCurrent(createIfNull);
			}

			// Token: 0x04000D1D RID: 3357
			private string _name;

			// Token: 0x04000D1E RID: 3358
			private global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryList _allGroupings;

			// Token: 0x04000D1F RID: 3359
			private bool _areAllGroupingsDirty;

			// Token: 0x04000D20 RID: 3360
			private global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.RegistrationInfo> _registrationInfo;

			// Token: 0x04000D21 RID: 3361
			[global::System.ThreadStatic]
			private static global::System.Windows.FrameworkElement _sharedOwner;

			// Token: 0x04000D22 RID: 3362
			[global::System.ThreadStatic]
			private static global::System.Windows.ResourceDictionary _sharedEmptyDictionary;

			// Token: 0x0200029D RID: 669
			private class RegistrationInfo
			{
				// Token: 0x06001A7D RID: 6781 RVA: 0x000646CC File Offset: 0x000628CC
				internal RegistrationInfo(string grouping)
				{
					this._grouping = grouping;
					this._providedDictionary = new global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryList(true, new global::System.Func<global::System.Windows.ResourceDictionary>(this.CreateDictionary));
				}

				// Token: 0x1700064A RID: 1610
				// (get) Token: 0x06001A7E RID: 6782 RVA: 0x000646F3 File Offset: 0x000628F3
				internal string Grouping
				{
					get
					{
						return this._grouping;
					}
				}

				// Token: 0x1700064B RID: 1611
				// (get) Token: 0x06001A7F RID: 6783 RVA: 0x000646FB File Offset: 0x000628FB
				internal global::Infragistics.Windows.Themes.ResourceSetLocator RegisteredLocator
				{
					get
					{
						return this._registeredLocator;
					}
				}

				// Token: 0x1700064C RID: 1612
				// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00064703 File Offset: 0x00062903
				internal global::System.Windows.ResourceDictionary RegisteredDictionary
				{
					get
					{
						return this._registeredDictionary;
					}
				}

				// Token: 0x06001A81 RID: 6785 RVA: 0x0006470B File Offset: 0x0006290B
				private global::System.Windows.ResourceDictionary CreateDictionary()
				{
					if (this._registeredDictionary != null)
					{
						return this._registeredDictionary;
					}
					if (this._registeredLocator != null)
					{
						return new global::Infragistics.Windows.Themes.ResourceSetLoader(this._registeredLocator);
					}
					return new global::System.Windows.ResourceDictionary();
				}

				// Token: 0x06001A82 RID: 6786 RVA: 0x00064735 File Offset: 0x00062935
				internal global::System.Windows.ResourceDictionary GetProvidedDictionary(bool createIfNull)
				{
					return this._providedDictionary.GetCurrent(createIfNull);
				}

				// Token: 0x06001A83 RID: 6787 RVA: 0x00064743 File Offset: 0x00062943
				internal bool Register(global::Infragistics.Windows.Themes.ResourceSetLocator value)
				{
					if (this._registeredLocator == value)
					{
						return false;
					}
					this._registeredLocator = value;
					this._registeredDictionary = null;
					this._providedDictionary.Refresh();
					return true;
				}

				// Token: 0x06001A84 RID: 6788 RVA: 0x0006476A File Offset: 0x0006296A
				internal bool Register(global::System.Windows.ResourceDictionary value)
				{
					if (value == this._registeredDictionary)
					{
						return false;
					}
					this._registeredLocator = null;
					this._registeredDictionary = value;
					this._providedDictionary.Refresh();
					return true;
				}

				// Token: 0x04000D23 RID: 3363
				private global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryList _providedDictionary;

				// Token: 0x04000D24 RID: 3364
				private global::System.Windows.ResourceDictionary _registeredDictionary;

				// Token: 0x04000D25 RID: 3365
				private global::Infragistics.Windows.Themes.ResourceSetLocator _registeredLocator;

				// Token: 0x04000D26 RID: 3366
				private string _grouping;
			}

			// Token: 0x0200029E RID: 670
			private class DispatcherResourceDictionaryList
			{
				// Token: 0x06001A85 RID: 6789 RVA: 0x00064791 File Offset: 0x00062991
				internal DispatcherResourceDictionaryList(bool prepareProvidedDictionary, global::System.Func<global::System.Windows.ResourceDictionary> createCallback)
				{
					this._dictionaries = new global::System.Collections.Generic.List<global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryItem>();
					this._prepareProvidedDictionary = prepareProvidedDictionary;
					this._createCallback = createCallback;
				}

				// Token: 0x06001A86 RID: 6790 RVA: 0x000647B2 File Offset: 0x000629B2
				private global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryItem CreateItem(out global::System.Windows.ResourceDictionary dictionary)
				{
					dictionary = new global::System.Windows.ResourceDictionary();
					dictionary.MergedDictionaries.Add(this._createCallback());
					if (this._prepareProvidedDictionary)
					{
						global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.PrepareProvidedDictionary(dictionary);
					}
					return new global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryItem(global::System.Windows.Threading.Dispatcher.CurrentDispatcher, dictionary);
				}

				// Token: 0x06001A87 RID: 6791 RVA: 0x000647F0 File Offset: 0x000629F0
				private global::System.Windows.ResourceDictionary GetCurrent()
				{
					foreach (global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryItem dispatcherResourceDictionaryItem in this._dictionaries)
					{
						if (dispatcherResourceDictionaryItem.Dispatcher == global::System.Windows.Threading.Dispatcher.CurrentDispatcher)
						{
							return dispatcherResourceDictionaryItem.Dictionary;
						}
					}
					return null;
				}

				// Token: 0x06001A88 RID: 6792 RVA: 0x00064858 File Offset: 0x00062A58
				internal global::System.Windows.ResourceDictionary GetCurrent(bool createIfNull)
				{
					global::System.Windows.ResourceDictionary current = this.GetCurrent();
					if (current == null && createIfNull)
					{
						global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryItem item = this.CreateItem(out current);
						this._dictionaries.Add(item);
					}
					return current;
				}

				// Token: 0x06001A89 RID: 6793 RVA: 0x000648C0 File Offset: 0x00062AC0
				internal void Refresh()
				{
					for (int i = this._dictionaries.Count - 1; i >= 0; i--)
					{
						global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryItem dispatcherResourceDictionaryItem = this._dictionaries[i];
						global::System.Windows.ResourceDictionary rd = dispatcherResourceDictionaryItem.Dictionary;
						if (rd == null)
						{
							this._dictionaries.RemoveAt(i);
						}
						else
						{
							global::System.Windows.Threading.Dispatcher dispatcher = dispatcherResourceDictionaryItem.Dispatcher;
							if (dispatcher == global::System.Windows.Threading.Dispatcher.CurrentDispatcher)
							{
								if (!rd.IsReadOnly)
								{
									rd.MergedDictionaries[0] = this._createCallback();
								}
								else
								{
									global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryItem value = this.CreateItem(out rd);
									this._dictionaries[i] = value;
								}
							}
							else if (dispatcher == null)
							{
								this._dictionaries.RemoveAt(i);
							}
							else
							{
								dispatcher.BeginInvoke(new global::System.Action(delegate()
								{
									if (!rd.IsReadOnly)
									{
										rd.MergedDictionaries[0] = this._createCallback();
									}
								}), new object[0]);
							}
						}
					}
				}

				// Token: 0x04000D27 RID: 3367
				private global::System.Collections.Generic.List<global::Infragistics.Windows.Themes.ThemeManager.ThemeInfo.DispatcherResourceDictionaryItem> _dictionaries;

				// Token: 0x04000D28 RID: 3368
				private readonly bool _prepareProvidedDictionary;

				// Token: 0x04000D29 RID: 3369
				private readonly global::System.Func<global::System.Windows.ResourceDictionary> _createCallback;
			}

			// Token: 0x0200029F RID: 671
			private class DispatcherResourceDictionaryItem
			{
				// Token: 0x06001A8A RID: 6794 RVA: 0x000649BD File Offset: 0x00062BBD
				internal DispatcherResourceDictionaryItem(global::System.Windows.Threading.Dispatcher dispatcher, global::System.Windows.ResourceDictionary resourceDictionary)
				{
					this._dispatcher = new global::System.WeakReference(dispatcher);
					this._dictionary = new global::System.WeakReference(resourceDictionary);
				}

				// Token: 0x1700064D RID: 1613
				// (get) Token: 0x06001A8B RID: 6795 RVA: 0x000649DD File Offset: 0x00062BDD
				internal global::System.Windows.ResourceDictionary Dictionary
				{
					get
					{
						return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._dictionary) as global::System.Windows.ResourceDictionary;
					}
				}

				// Token: 0x1700064E RID: 1614
				// (get) Token: 0x06001A8C RID: 6796 RVA: 0x000649EF File Offset: 0x00062BEF
				internal global::System.Windows.Threading.Dispatcher Dispatcher
				{
					get
					{
						return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._dispatcher) as global::System.Windows.Threading.Dispatcher;
					}
				}

				// Token: 0x04000D2A RID: 3370
				private readonly global::System.WeakReference _dispatcher;

				// Token: 0x04000D2B RID: 3371
				private readonly global::System.WeakReference _dictionary;
			}
		}

		// Token: 0x020002A0 RID: 672
		private class ControlThemeInfo : global::System.Windows.DependencyObject
		{
			// Token: 0x06001A8D RID: 6797 RVA: 0x00064A04 File Offset: 0x00062C04
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

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x06001A8E RID: 6798 RVA: 0x00064A74 File Offset: 0x00062C74
			private bool IsApplyThemeNeeded
			{
				get
				{
					if (this._currentTheme != this._appliedTheme)
					{
						return true;
					}
					int count = global::Infragistics.CoreUtilities.GetCount(this._currentGroupings);
					if (count != global::Infragistics.CoreUtilities.GetCount(this._appliedGroupings))
					{
						return true;
					}
					if (count == 0)
					{
						return true;
					}
					if (count == 1)
					{
						return this._currentGroupings[0] == this._appliedGroupings[0];
					}
					foreach (string value in this._currentGroupings)
					{
						if (global::System.Array.IndexOf<string>(this._appliedGroupings, value) < 0)
						{
							return true;
						}
					}
					return false;
				}
			}

			// Token: 0x06001A8F RID: 6799 RVA: 0x00064B08 File Offset: 0x00062D08
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

			// Token: 0x06001A90 RID: 6800 RVA: 0x00064B6C File Offset: 0x00062D6C
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

			// Token: 0x06001A91 RID: 6801 RVA: 0x00064C4C File Offset: 0x00062E4C
			internal static global::System.Windows.ResourceDictionary GetThemeDictionary(global::System.Windows.FrameworkElement fe)
			{
				global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo controlThemeInfo = fe.GetValue(global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo.ControlThemeInfoProperty) as global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo;
				if (controlThemeInfo != null)
				{
					return controlThemeInfo._mergedDictionary;
				}
				return null;
			}

			// Token: 0x06001A92 RID: 6802 RVA: 0x00064C78 File Offset: 0x00062E78
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

			// Token: 0x06001A93 RID: 6803 RVA: 0x00064CD8 File Offset: 0x00062ED8
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

			// Token: 0x06001A94 RID: 6804 RVA: 0x00064D60 File Offset: 0x00062F60
			private void OnElementLoaded(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this._element.RemoveHandler(global::System.Windows.FrameworkElement.LoadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementLoaded));
				this._element.AddHandler(global::System.Windows.FrameworkElement.UnloadedEvent, new global::System.Windows.RoutedEventHandler(this.OnElementUnloaded), true);
				if (this.IsApplyThemeNeeded)
				{
					this.ApplyTheme(this._currentTheme, this._currentGroupings, false);
				}
			}

			// Token: 0x06001A95 RID: 6805 RVA: 0x00064DC1 File Offset: 0x00062FC1
			private void OnElementUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this._element.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.ContextIdle, new global::System.Threading.SendOrPostCallback(this.OnDelayedUnload), null);
			}

			// Token: 0x06001A96 RID: 6806 RVA: 0x00064DE4 File Offset: 0x00062FE4
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

			// Token: 0x04000D2C RID: 3372
			private string _currentTheme;

			// Token: 0x04000D2D RID: 3373
			private global::System.Windows.ResourceDictionary _mergedDictionary;

			// Token: 0x04000D2E RID: 3374
			private global::System.Windows.FrameworkElement _element;

			// Token: 0x04000D2F RID: 3375
			private string[] _currentGroupings;

			// Token: 0x04000D30 RID: 3376
			private string _appliedTheme;

			// Token: 0x04000D31 RID: 3377
			private string[] _appliedGroupings;

			// Token: 0x04000D32 RID: 3378
			private bool _isApplyingTheme;

			// Token: 0x04000D33 RID: 3379
			private static readonly global::System.Windows.DependencyProperty ControlThemeInfoProperty = global::System.Windows.DependencyProperty.Register("ControlThemeInfo", typeof(global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo), typeof(global::Infragistics.Windows.Themes.ThemeManager.ControlThemeInfo), new global::System.Windows.FrameworkPropertyMetadata(null));
		}
	}
}
