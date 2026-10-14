using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Infragistics;

// Token: 0x02000002 RID: 2
internal static class SR
{
	// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
	static SR()
	{
		global::System.Reflection.Assembly assembly = typeof(global::SR).Assembly;
		object[] customAttributes = assembly.GetCustomAttributes(typeof(global::Infragistics.StringResourceLocationAttribute), true);
		if (customAttributes == null || customAttributes.Length == 0)
		{
			throw new global::System.InvalidOperationException("Assembly is missing the StringResourceLocation attribute.");
		}
		global::Infragistics.StringResourceLocationAttribute stringResourceLocationAttribute = customAttributes[0] as global::Infragistics.StringResourceLocationAttribute;
		if (stringResourceLocationAttribute == null)
		{
			throw new global::System.InvalidOperationException("Error retrieving the StringResourceLocation attribute.");
		}
		string[] array = stringResourceLocationAttribute.Location.Split(new char[]
		{
			';'
		});
		int num = 0;
		foreach (string text in array)
		{
			if (text != null && text.Length > 0)
			{
				num++;
			}
		}
		global::SR._resourceManagers = new global::System.Collections.Generic.List<global::System.Resources.ResourceManager>();
		foreach (string text2 in array)
		{
			if (text2 != null && text2.Length > 0)
			{
				global::SR._resourceManagers.Add(new global::System.Resources.ResourceManager(text2, assembly));
			}
		}
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000021C0 File Offset: 0x000003C0
	internal static string GetString(string resourceName)
	{
		foreach (global::System.Resources.ResourceManager resourceManager in global::SR._resourceManagers)
		{
			string @string = resourceManager.GetString(resourceName, global::System.Globalization.CultureInfo.CurrentCulture);
			if (@string != null)
			{
				return @string;
			}
		}
		return null;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002224 File Offset: 0x00000424
	internal static void AddResource(string name, global::System.Reflection.Assembly assembly)
	{
		global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(name, assembly);
		resourceManager.GetString("DummyValue");
		global::SR._resourceManagers.Insert(0, resourceManager);
		global::SR._customResourcesVersion++;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002260 File Offset: 0x00000460
	internal static void RemoveResource(string name)
	{
		global::System.Resources.ResourceManager resourceManager = null;
		int num = 0;
		foreach (global::System.Resources.ResourceManager resourceManager2 in global::SR._resourceManagers)
		{
			string baseName = resourceManager2.BaseName;
			if (baseName == name)
			{
				resourceManager = resourceManager2;
				break;
			}
			num++;
		}
		if (resourceManager != null)
		{
			global::SR._resourceManagers.Remove(resourceManager);
			global::SR._customResourcesVersion++;
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000022E4 File Offset: 0x000004E4
	internal static string GetString(string resourceName, params object[] args)
	{
		string text = global::SR.GetString(resourceName);
		if (text != null && args != null && args.Length > 0 && text.Length > 2)
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

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x0000232C File Offset: 0x0000052C
	internal static int CustomResourcesVersion
	{
		get
		{
			return global::SR._customResourcesVersion;
		}
	}

	// Token: 0x04000001 RID: 1
	private static global::System.Collections.Generic.List<global::System.Resources.ResourceManager> _resourceManagers;

	// Token: 0x04000002 RID: 2
	private static int _customResourcesVersion;
}
