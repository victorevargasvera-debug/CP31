using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Infragistics.Shared;

// Token: 0x02000008 RID: 8
internal sealed class SR
{
	// Token: 0x0600003F RID: 63 RVA: 0x00002DB4 File Offset: 0x00000FB4
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

	// Token: 0x06000040 RID: 64 RVA: 0x00002E70 File Offset: 0x00001070
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

	// Token: 0x06000041 RID: 65 RVA: 0x00002F00 File Offset: 0x00001100
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

	// Token: 0x06000042 RID: 66 RVA: 0x00002F54 File Offset: 0x00001154
	public static string GetString(string name)
	{
		return global::SR.GetString(null, name);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002F5D File Offset: 0x0000115D
	public static string GetString(string name, params object[] args)
	{
		return global::SR.GetString(null, name, args);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002F67 File Offset: 0x00001167
	public static string GetString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetString(culture, name, null);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002F71 File Offset: 0x00001171
	public static string GetString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(true, culture, name, args);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002F7C File Offset: 0x0000117C
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

	// Token: 0x06000047 RID: 71 RVA: 0x00002FF0 File Offset: 0x000011F0
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

	// Token: 0x06000048 RID: 72 RVA: 0x0000302E File Offset: 0x0000122E
	public static string GetUncustomizedString(string name)
	{
		return global::SR.GetUncustomizedString(null, name);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00003037 File Offset: 0x00001237
	public static string GetUncustomizedString(string name, params object[] args)
	{
		return global::SR.GetUncustomizedString(null, name, args);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00003041 File Offset: 0x00001241
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name)
	{
		return global::SR.GetUncustomizedString(culture, name, null);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000304B File Offset: 0x0000124B
	public static string GetUncustomizedString(global::System.Globalization.CultureInfo culture, string name, params object[] args)
	{
		return global::SR.GetStringHelper(false, culture, name, args);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003056 File Offset: 0x00001256
	public static object GetObject(string name)
	{
		return global::SR.GetObject(null, name);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00003060 File Offset: 0x00001260
	public static object GetObject(global::System.Globalization.CultureInfo culture, string name)
	{
		global::SR sr = global::SR.GetLoader();
		if (sr == null)
		{
			return null;
		}
		return sr.GetObject(name, culture);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003080 File Offset: 0x00001280
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

	// Token: 0x04000025 RID: 37
	private static global::SR loader;

	// Token: 0x04000026 RID: 38
	[global::System.ThreadStatic]
	private static global::System.Collections.Generic.Dictionary<global::Infragistics.Shared.DynamicResourceString.ID, global::Infragistics.Shared.DynamicResourceString> _dynamicResourceStrings = null;

	// Token: 0x04000027 RID: 39
	private global::System.Resources.ResourceManager[] resources;
}
