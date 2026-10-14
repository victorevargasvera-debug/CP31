using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Infragistics.Shared;

// Token: 0x020000B8 RID: 184
internal sealed class SR
{
	// Token: 0x060006F1 RID: 1777 RVA: 0x00019CB8 File Offset: 0x00017EB8
	private SR()
	{
		string text = "Infragistics.Windows.strings";
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

	// Token: 0x060006F2 RID: 1778 RVA: 0x00019D74 File Offset: 0x00017F74
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

	// Token: 0x060006F3 RID: 1779 RVA: 0x00019E04 File Offset: 0x00018004
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

	// Token: 0x060006F4 RID: 1780 RVA: 0x00019E58 File Offset: 0x00018058
	public static string GetString(string name)
	{
		return global::SR.GetString(null, name);
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00019E61 File Offset: 0x00018061
	public static string GetString(string name, params object[] args)
	{
		return global::SR.GetString(null, name, args);
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00019E6B File Offset: 0x0001806B
	public static string GetString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetString(culture, name, null);
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00019E75 File Offset: 0x00018075
	public static string GetString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(true, culture, name, args);
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00019E80 File Offset: 0x00018080
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

	// Token: 0x060006F9 RID: 1785 RVA: 0x00019EF4 File Offset: 0x000180F4
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

	// Token: 0x060006FA RID: 1786 RVA: 0x00019F32 File Offset: 0x00018132
	public static string GetUncustomizedString(string name)
	{
		return global::SR.GetUncustomizedString(null, name);
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00019F3B File Offset: 0x0001813B
	public static string GetUncustomizedString(string name, params object[] args)
	{
		return global::SR.GetUncustomizedString(null, name, args);
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00019F45 File Offset: 0x00018145
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetUncustomizedString(culture, name, null);
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00019F4F File Offset: 0x0001814F
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(false, culture, name, args);
	}

	// Token: 0x060006FE RID: 1790 RVA: 0x00019F5A File Offset: 0x0001815A
	public static object GetObject(string name)
	{
		return global::SR.GetObject(null, name);
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00019F64 File Offset: 0x00018164
	public static object GetObject(global::System.Globalization.CultureInfo culture, string name)
	{
		global::SR sr = global::SR.GetLoader();
		if (sr == null)
		{
			return null;
		}
		return sr.GetObject(name, culture);
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00019F84 File Offset: 0x00018184
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

	// Token: 0x0400038D RID: 909
	private static global::SR loader;

	// Token: 0x0400038E RID: 910
	[global::System.ThreadStatic]
	private static global::System.Collections.Generic.Dictionary<global::Infragistics.Shared.DynamicResourceString.ID, global::Infragistics.Shared.DynamicResourceString> _dynamicResourceStrings = null;

	// Token: 0x0400038F RID: 911
	private global::System.Resources.ResourceManager[] resources;
}
