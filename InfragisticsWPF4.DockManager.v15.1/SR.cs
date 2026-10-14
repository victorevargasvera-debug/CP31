using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Infragistics.Shared;

// Token: 0x02000004 RID: 4
internal sealed class SR
{
	// Token: 0x0600000A RID: 10 RVA: 0x000023E4 File Offset: 0x000005E4
	private SR()
	{
		string text = "Infragistics.Windows.DockManager.strings";
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

	// Token: 0x0600000B RID: 11 RVA: 0x000024A0 File Offset: 0x000006A0
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

	// Token: 0x0600000C RID: 12 RVA: 0x00002530 File Offset: 0x00000730
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

	// Token: 0x0600000D RID: 13 RVA: 0x00002584 File Offset: 0x00000784
	public static string GetString(string name)
	{
		return global::SR.GetString(null, name);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000258D File Offset: 0x0000078D
	public static string GetString(string name, params object[] args)
	{
		return global::SR.GetString(null, name, args);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002597 File Offset: 0x00000797
	public static string GetString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetString(culture, name, null);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000025A1 File Offset: 0x000007A1
	public static string GetString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(true, culture, name, args);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000025AC File Offset: 0x000007AC
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

	// Token: 0x06000012 RID: 18 RVA: 0x00002620 File Offset: 0x00000820
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

	// Token: 0x06000013 RID: 19 RVA: 0x0000265E File Offset: 0x0000085E
	public static string GetUncustomizedString(string name)
	{
		return global::SR.GetUncustomizedString(null, name);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002667 File Offset: 0x00000867
	public static string GetUncustomizedString(string name, params object[] args)
	{
		return global::SR.GetUncustomizedString(null, name, args);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002671 File Offset: 0x00000871
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetUncustomizedString(culture, name, null);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000267B File Offset: 0x0000087B
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(false, culture, name, args);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002686 File Offset: 0x00000886
	public static object GetObject(string name)
	{
		return global::SR.GetObject(null, name);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002690 File Offset: 0x00000890
	public static object GetObject(global::System.Globalization.CultureInfo culture, string name)
	{
		global::SR sr = global::SR.GetLoader();
		if (sr == null)
		{
			return null;
		}
		return sr.GetObject(name, culture);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000026B0 File Offset: 0x000008B0
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

	// Token: 0x04000007 RID: 7
	private static global::SR loader;

	// Token: 0x04000008 RID: 8
	[global::System.ThreadStatic]
	private static global::System.Collections.Generic.Dictionary<global::Infragistics.Shared.DynamicResourceString.ID, global::Infragistics.Shared.DynamicResourceString> _dynamicResourceStrings = null;

	// Token: 0x04000009 RID: 9
	private global::System.Resources.ResourceManager[] resources;
}
