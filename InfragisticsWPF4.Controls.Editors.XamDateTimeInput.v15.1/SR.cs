using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Infragistics.Shared;

// Token: 0x02000007 RID: 7
internal sealed class SR
{
	// Token: 0x06000060 RID: 96 RVA: 0x000037A8 File Offset: 0x000019A8
	private SR()
	{
		string text = "Infragistics.Controls.Editors.strings";
		string[] array = text.Split(new char[]
		{
			';'
		});
		int num = 0;
		foreach (string text2 in array)
		{
			if (text2 != null && text2.Length > 0)
			{
				num++;
			}
		}
		this.resources = new global::System.Resources.ResourceManager[num];
		global::System.Reflection.Assembly assembly = base.GetType().Assembly;
		int num2 = 0;
		foreach (string text3 in array)
		{
			if (text3 != null && text3.Length > 0)
			{
				this.resources[num2++] = new global::System.Resources.ResourceManager(text3, assembly);
			}
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00003864 File Offset: 0x00001A64
	public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
	{
		global::Infragistics.Shared.DynamicResourceString result;
		lock (typeof(global::SR))
		{
			global::Infragistics.Shared.DynamicResourceString.ID key = new global::Infragistics.Shared.DynamicResourceString.ID(culture, name, args);
			global::Infragistics.Shared.DynamicResourceString dynamicResourceString = null;
			if (global::SR._dynamicResourceStrings == null)
			{
				global::SR._dynamicResourceStrings = new global::System.Collections.Generic.Dictionary<global::Infragistics.Shared.DynamicResourceString.ID, global::Infragistics.Shared.DynamicResourceString>();
			}
			else
			{
				global::SR._dynamicResourceStrings.TryGetValue(key, out dynamicResourceString);
			}
			if (dynamicResourceString == null)
			{
				dynamicResourceString = new global::InternalDynamicResourceString(global::ResourceCustomizerLocator.Customizer, culture, name, args);
				global::SR._dynamicResourceStrings.Add(key, dynamicResourceString);
			}
			result = dynamicResourceString;
		}
		return result;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000038F4 File Offset: 0x00001AF4
	private static global::SR GetLoader()
	{
		if (global::SR.loader == null)
		{
			global::System.Type typeFromHandle = typeof(global::SR);
			lock (typeFromHandle)
			{
				if (global::SR.loader == null)
				{
					global::SR.loader = new global::SR();
				}
			}
		}
		return global::SR.loader;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003948 File Offset: 0x00001B48
	public static string GetString(string name)
	{
		return global::SR.GetString(null, name);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003951 File Offset: 0x00001B51
	public static string GetString(string name, params object[] args)
	{
		return global::SR.GetString(null, name, args);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0000395B File Offset: 0x00001B5B
	public static string GetString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetString(culture, name, null);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00003965 File Offset: 0x00001B65
	public static string GetString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(true, culture, name, args);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003970 File Offset: 0x00001B70
	private static string GetStringHelper(bool allowCustomizedStrings, global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		string text = null;
		if (allowCustomizedStrings)
		{
			text = global::ResourceCustomizerLocator.Customizer.GetCustomizedString(name);
		}
		if (text == null)
		{
			global::SR sr = global::SR.GetLoader();
			if (sr == null)
			{
				return string.Empty;
			}
			text = sr.GetString(name, culture);
			if (text == null)
			{
				text = string.Empty;
			}
		}
		if (args != null && args.Length > 0 && text.Length > 2)
		{
			try
			{
				text = string.Format(null, text, args);
			}
			catch
			{
			}
		}
		return text;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000039E4 File Offset: 0x00001BE4
	private string GetString(string name, global::System.Globalization.CultureInfo culture)
	{
		foreach (global::System.Resources.ResourceManager resourceManager in this.resources)
		{
			string @string = resourceManager.GetString(name, culture);
			if (@string != null)
			{
				return @string;
			}
		}
		return null;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00003A22 File Offset: 0x00001C22
	public static string GetUncustomizedString(string name)
	{
		return global::SR.GetUncustomizedString(null, name);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00003A2B File Offset: 0x00001C2B
	public static string GetUncustomizedString(string name, params object[] args)
	{
		return global::SR.GetUncustomizedString(null, name, args);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003A35 File Offset: 0x00001C35
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetUncustomizedString(culture, name, null);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003A3F File Offset: 0x00001C3F
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(false, culture, name, args);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00003A4A File Offset: 0x00001C4A
	public static object GetObject(string name)
	{
		return global::SR.GetObject(null, name);
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00003A54 File Offset: 0x00001C54
	public static object GetObject(global::System.Globalization.CultureInfo culture, string name)
	{
		global::SR sr = global::SR.GetLoader();
		if (sr == null)
		{
			return null;
		}
		return sr.GetObject(name, culture);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003A74 File Offset: 0x00001C74
	private object GetObject(string name, global::System.Globalization.CultureInfo culture)
	{
		foreach (global::System.Resources.ResourceManager resourceManager in this.resources)
		{
			object @object = resourceManager.GetObject(name, culture);
			if (@object != null)
			{
				return @object;
			}
		}
		return null;
	}

	// Token: 0x04000029 RID: 41
	private static global::SR loader;

	// Token: 0x0400002A RID: 42
	[global::System.ThreadStatic]
	private static global::System.Collections.Generic.Dictionary<global::Infragistics.Shared.DynamicResourceString.ID, global::Infragistics.Shared.DynamicResourceString> _dynamicResourceStrings = null;

	// Token: 0x0400002B RID: 43
	private global::System.Resources.ResourceManager[] resources;
}
