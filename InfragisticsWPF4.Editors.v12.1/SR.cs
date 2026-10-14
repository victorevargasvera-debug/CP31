using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Infragistics.Shared;

// Token: 0x02000002 RID: 2
internal sealed class SR
{
	// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
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

	// Token: 0x06000002 RID: 2 RVA: 0x0000218C File Offset: 0x0000038C
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

	// Token: 0x06000003 RID: 3 RVA: 0x0000221C File Offset: 0x0000041C
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

	// Token: 0x06000004 RID: 4 RVA: 0x00002270 File Offset: 0x00000470
	public static string GetString(string name)
	{
		return global::SR.GetString(null, name);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002279 File Offset: 0x00000479
	public static string GetString(string name, params object[] args)
	{
		return global::SR.GetString(null, name, args);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002283 File Offset: 0x00000483
	public static string GetString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetString(culture, name, null);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000228D File Offset: 0x0000048D
	public static string GetString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(true, culture, name, args);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002298 File Offset: 0x00000498
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

	// Token: 0x06000009 RID: 9 RVA: 0x0000230C File Offset: 0x0000050C
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

	// Token: 0x0600000A RID: 10 RVA: 0x0000234A File Offset: 0x0000054A
	public static string GetUncustomizedString(string name)
	{
		return global::SR.GetUncustomizedString(null, name);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002353 File Offset: 0x00000553
	public static string GetUncustomizedString(string name, params object[] args)
	{
		return global::SR.GetUncustomizedString(null, name, args);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000235D File Offset: 0x0000055D
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetUncustomizedString(culture, name, null);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002367 File Offset: 0x00000567
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(false, culture, name, args);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002372 File Offset: 0x00000572
	public static object GetObject(string name)
	{
		return global::SR.GetObject(null, name);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000237C File Offset: 0x0000057C
	public static object GetObject(global::System.Globalization.CultureInfo culture, string name)
	{
		global::SR sr = global::SR.GetLoader();
		if (sr == null)
		{
			return null;
		}
		return sr.GetObject(name, culture);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000239C File Offset: 0x0000059C
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

	// Token: 0x04000001 RID: 1
	private static global::SR loader;

	// Token: 0x04000002 RID: 2
	[global::System.ThreadStatic]
	private static global::System.Collections.Generic.Dictionary<global::Infragistics.Shared.DynamicResourceString.ID, global::Infragistics.Shared.DynamicResourceString> _dynamicResourceStrings = null;

	// Token: 0x04000003 RID: 3
	private global::System.Resources.ResourceManager[] resources;
}
