using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Themes
{
	// Token: 0x020001CA RID: 458
	internal class ThemeResourceDictionary : global::System.Windows.ResourceDictionary
	{
		// Token: 0x06000FED RID: 4077 RVA: 0x00034837 File Offset: 0x00032A37
		public ThemeResourceDictionary(global::Infragistics.Themes.ThemeBase theme)
		{
			this.Theme = theme;
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00034867 File Offset: 0x00032A67
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x0003486F File Offset: 0x00032A6F
		public global::Infragistics.Themes.ThemeBase Theme { get; set; }

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00034878 File Offset: 0x00032A78
		public void RegisterControl(string controlTypeName)
		{
			if (controlTypeName == global::Infragistics.Themes.ControlMappingKeys.MsCoreControls)
			{
				global::Infragistics.Themes.BuiltInThemeBase builtInThemeBase = this.Theme as global::Infragistics.Themes.BuiltInThemeBase;
				if (builtInThemeBase != null && !builtInThemeBase.StyleMicrosoftControls)
				{
					return;
				}
			}
			this.AddResourceDictionary(controlTypeName);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x000348B2 File Offset: 0x00032AB2
		internal static global::System.Uri BuildResourseUri(string relativeSource, string assemblyFullName)
		{
			return new global::System.Uri(string.Format("pack://application:,,,/{0};component/{1}", assemblyFullName, relativeSource), global::System.UriKind.Absolute);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000348C8 File Offset: 0x00032AC8
		internal global::System.Windows.ResourceDictionary AddResourceDictionary(string controlTypeName)
		{
			if (!this.Theme.MappingsSnapshot.ContainsKey(controlTypeName))
			{
				return null;
			}
			string text = this.Theme.MappingsSnapshot[controlTypeName];
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}
			if (this._alreadyMergedResourceDictionaries.ContainsKey(text))
			{
				return this._alreadyMergedResourceDictionaries[text];
			}
			global::System.Windows.ResourceDictionary resourceDictionary;
			if (this._resourceDictionaryCache.ContainsKey(text))
			{
				resourceDictionary = this._resourceDictionaryCache[text];
			}
			else
			{
				resourceDictionary = new global::System.Windows.ResourceDictionary
				{
					Source = new global::System.Uri(text)
				};
				if (!this._resourceDictionaryCache.ContainsKey(text))
				{
					this._resourceDictionaryCache.Add(text, resourceDictionary);
				}
			}
			if (this._alreadyMergedResourceDictionaries.ContainsKey(text))
			{
				return this._alreadyMergedResourceDictionaries[text];
			}
			base.MergedDictionaries.Add(resourceDictionary);
			this._alreadyMergedResourceDictionaries.Add(text, resourceDictionary);
			return resourceDictionary;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x000349A4 File Offset: 0x00032BA4
		internal void RemoveResourceDictionary(string source)
		{
			if (this._alreadyMergedResourceDictionaries.ContainsKey(source))
			{
				this._alreadyMergedResourceDictionaries.Remove(source);
				base.MergedDictionaries.Remove(this._resourceDictionaryCache[source]);
			}
		}

		// Token: 0x04000866 RID: 2150
		private global::System.Collections.Generic.Dictionary<string, global::System.Windows.ResourceDictionary> _resourceDictionaryCache = new global::System.Collections.Generic.Dictionary<string, global::System.Windows.ResourceDictionary>();

		// Token: 0x04000867 RID: 2151
		private global::System.Collections.Generic.Dictionary<string, global::System.Windows.ResourceDictionary> _alreadyMergedResourceDictionaries = new global::System.Collections.Generic.Dictionary<string, global::System.Windows.ResourceDictionary>();

		// Token: 0x04000868 RID: 2152
		private global::System.Collections.Generic.List<string> _registeredControlNames = new global::System.Collections.Generic.List<string>();
	}
}
