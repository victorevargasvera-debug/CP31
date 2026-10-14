using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Windows;

namespace Infragistics.Themes
{
	// Token: 0x020001C9 RID: 457
	public static class ThemeManager
	{
		// Token: 0x06000FDF RID: 4063 RVA: 0x00034260 File Offset: 0x00032460
		private static void OnThemeChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::System.Windows.FrameworkElement frameworkElement = sender as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				return;
			}
			global::Infragistics.Themes.ThemeBase newTheme = (args.NewValue != null) ? ((global::Infragistics.Themes.ThemeBase)args.NewValue) : null;
			global::Infragistics.Themes.ThemeBase oldTheme = (args.OldValue != null) ? ((global::Infragistics.Themes.ThemeBase)args.OldValue) : null;
			if (oldTheme != null)
			{
				global::Infragistics.Themes.ThemeResourceDictionary themeResourceDictionary = global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.FirstOrDefault((global::Infragistics.Themes.ThemeResourceDictionary i) => i.Theme == oldTheme);
				if (themeResourceDictionary != null)
				{
					frameworkElement.Resources.MergedDictionaries.Remove(themeResourceDictionary);
				}
			}
			if (newTheme != null)
			{
				global::Infragistics.Themes.ThemeResourceDictionary themeResourceDictionary2 = global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.FirstOrDefault((global::Infragistics.Themes.ThemeResourceDictionary i) => i.Theme == newTheme);
				if (themeResourceDictionary2 != null)
				{
					frameworkElement.Resources.MergedDictionaries.Add(themeResourceDictionary2);
					return;
				}
				global::Infragistics.Themes.ThemeResourceDictionary item = global::Infragistics.Themes.ThemeManager.BuildThemeResourceForTheme(newTheme);
				frameworkElement.Resources.MergedDictionaries.Add(item);
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0003435D File Offset: 0x0003255D
		public static global::Infragistics.Themes.ThemeBase GetTheme(global::System.Windows.DependencyObject element)
		{
			return (global::Infragistics.Themes.ThemeBase)element.GetValue(global::Infragistics.Themes.ThemeManager.ThemeProperty);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0003436F File Offset: 0x0003256F
		public static void SetTheme(global::System.Windows.DependencyObject element, global::Infragistics.Themes.ThemeBase theme)
		{
			element.SetValue(global::Infragistics.Themes.ThemeManager.ThemeProperty, theme);
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0003437D File Offset: 0x0003257D
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x000343BC File Offset: 0x000325BC
		public static global::Infragistics.Themes.ThemeBase ApplicationTheme
		{
			get
			{
				return global::Infragistics.Themes.ThemeManager._applicationTheme;
			}
			set
			{
				if (global::Infragistics.Themes.ThemeManager._applicationTheme != value)
				{
					if (global::Infragistics.Themes.ThemeManager._applicationTheme != null)
					{
						global::Infragistics.Themes.ThemeResourceDictionary themeResourceDictionary = global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.FirstOrDefault((global::Infragistics.Themes.ThemeResourceDictionary i) => i.Theme == global::Infragistics.Themes.ThemeManager._applicationTheme);
						if (themeResourceDictionary != null)
						{
							global::System.Windows.Application.Current.Resources.MergedDictionaries.Remove(themeResourceDictionary);
						}
					}
					if (value != null)
					{
						global::Infragistics.Themes.ThemeResourceDictionary themeResourceDictionary2;
						if (!global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.Any((global::Infragistics.Themes.ThemeResourceDictionary i) => i.Theme == value))
						{
							themeResourceDictionary2 = global::Infragistics.Themes.ThemeManager.BuildThemeResourceForTheme(value);
						}
						else
						{
							themeResourceDictionary2 = global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.FirstOrDefault((global::Infragistics.Themes.ThemeResourceDictionary i) => i.Theme == value);
						}
						global::Infragistics.Themes.ThemeResourceDictionary item = themeResourceDictionary2;
						global::System.Windows.Application.Current.Resources.MergedDictionaries.Add(item);
					}
					global::Infragistics.Themes.ThemeManager._applicationTheme = value;
				}
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000344A8 File Offset: 0x000326A8
		public static void RegisterControl(global::System.Type type)
		{
			if (!global::Infragistics.Themes.ThemeManager._regiteredControls.Contains(type.FullName))
			{
				global::Infragistics.Themes.ThemeManager._regiteredControls.Add(type.FullName);
				global::Infragistics.Themes.ThemeManager.OnAssemblyRegistered(type.Assembly);
				global::Infragistics.Themes.ThemeManager.UpdateThemeDictionaries(type.FullName);
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x000344E4 File Offset: 0x000326E4
		internal static global::Infragistics.Themes.ThemeResourceDictionary BuildThemeResourceForTheme(global::Infragistics.Themes.ThemeBase newTheme)
		{
			global::Infragistics.Themes.ThemeManager.ProcessPendingRegistrations();
			if (global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.Count % 50 == 0)
			{
				global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.Compact();
			}
			global::Infragistics.Themes.ThemeResourceDictionary themeResourceDictionary = new global::Infragistics.Themes.ThemeResourceDictionary(newTheme);
			global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.Add(themeResourceDictionary);
			string[] array = global::Infragistics.Themes.ThemeManager._regiteredControls.ToArray();
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			do
			{
				foreach (string controlTypeName in array)
				{
					themeResourceDictionary.RegisterControl(controlTypeName);
				}
				list.AddRange(array);
				array = global::Infragistics.Themes.ThemeManager._regiteredControls.Except(list).ToArray<string>();
			}
			while (array.Any<string>());
			return themeResourceDictionary;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00034578 File Offset: 0x00032778
		internal static void UpdateThemeDictionaries(string controlTypeName)
		{
			foreach (global::Infragistics.Themes.ThemeResourceDictionary themeResourceDictionary in global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs)
			{
				themeResourceDictionary.RegisterControl(controlTypeName);
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000345DC File Offset: 0x000327DC
		internal static void UpdateStylingMsControlsForTheme(global::Infragistics.Themes.BuiltInThemeBase theme)
		{
			global::Infragistics.Themes.ThemeResourceDictionary themeResourceDictionary = global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.FirstOrDefault((global::Infragistics.Themes.ThemeResourceDictionary t) => t.Theme == theme);
			if (themeResourceDictionary == null)
			{
				return;
			}
			if (theme.StyleMicrosoftControls)
			{
				themeResourceDictionary.RegisterControl(global::Infragistics.Themes.ControlMappingKeys.MsCoreControls);
				return;
			}
			if (theme.MappingsSnapshot.Keys.Contains(global::Infragistics.Themes.ControlMappingKeys.MsCoreControls))
			{
				themeResourceDictionary.RemoveResourceDictionary(theme.MappingsSnapshot[global::Infragistics.Themes.ControlMappingKeys.MsCoreControls]);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00034664 File Offset: 0x00032864
		private static void OnAssemblyRegistered(global::System.Reflection.Assembly assembly)
		{
			lock (global::Infragistics.Themes.ThemeManager.RegisterAssemblyLock)
			{
				if (!global::Infragistics.Themes.ThemeManager._processedAssemblies.Contains(assembly) && global::Infragistics.Themes.ThemeManager._assembliesPendingRegistration.Add(assembly) && global::Infragistics.Themes.ThemeManager._currentlyUsedThemeRDs.Count > 0)
				{
					global::Infragistics.Themes.ThemeManager.ProcessPendingRegistrations();
				}
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000346CC File Offset: 0x000328CC
		private static void ProcessPendingRegistrations()
		{
			lock (global::Infragistics.Themes.ThemeManager.RegisterAssemblyLock)
			{
				global::System.Reflection.Assembly[] array = global::Infragistics.Themes.ThemeManager._assembliesPendingRegistration.ToArray<global::System.Reflection.Assembly>();
				global::Infragistics.Themes.ThemeManager._assembliesPendingRegistration.Clear();
				try
				{
					foreach (global::System.Reflection.Assembly assembly in array)
					{
						global::Infragistics.Themes.ThemeManager.VerifyReferencesAreLoaded(assembly, global::Infragistics.Themes.ThemeManager._processedAssemblies);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00034754 File Offset: 0x00032954
		private static void VerifyReferencesAreLoaded(global::System.Reflection.Assembly assembly, global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly> processedAssemblies)
		{
			if (!processedAssemblies.Add(assembly))
			{
				return;
			}
			foreach (global::System.Reflection.AssemblyName assemblyName in assembly.GetReferencedAssemblies())
			{
				string publicKeyToken = global::Infragistics.Windows.Utilities.GetPublicKeyToken(assemblyName.FullName);
				if (global::Infragistics.Windows.Utilities.HasSamePublicKey(publicKeyToken))
				{
					global::System.Reflection.Assembly assembly2 = global::System.AppDomain.CurrentDomain.Load(assemblyName);
					global::Infragistics.Themes.ThemeManager.VerifyReferencesAreLoaded(assembly2, processedAssemblies);
				}
			}
		}

		// Token: 0x0400085E RID: 2142
		private static global::Infragistics.Collections.WeakList<global::Infragistics.Themes.ThemeResourceDictionary> _currentlyUsedThemeRDs = new global::Infragistics.Collections.WeakList<global::Infragistics.Themes.ThemeResourceDictionary>();

		// Token: 0x0400085F RID: 2143
		private static global::System.Collections.Generic.List<string> _regiteredControls = new global::System.Collections.Generic.List<string>
		{
			global::Infragistics.Themes.ControlMappingKeys.MsCoreControls
		};

		// Token: 0x04000860 RID: 2144
		private static global::Infragistics.Themes.ThemeBase _applicationTheme = null;

		// Token: 0x04000861 RID: 2145
		private static readonly object RegisterAssemblyLock = new object();

		// Token: 0x04000862 RID: 2146
		private static global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly> _assembliesPendingRegistration = new global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly>();

		// Token: 0x04000863 RID: 2147
		private static global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly> _processedAssemblies = new global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly>();

		// Token: 0x04000864 RID: 2148
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::System.Windows.DependencyProperty.RegisterAttached("Theme", typeof(global::Infragistics.Themes.ThemeBase), typeof(global::Infragistics.Themes.ThemeManager), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Themes.ThemeManager.OnThemeChanged)));
	}
}
