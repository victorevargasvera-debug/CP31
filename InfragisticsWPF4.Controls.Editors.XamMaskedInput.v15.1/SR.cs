using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Infragistics;
using Infragistics.Controls.Primitives;

// Token: 0x02000006 RID: 6
internal static class SR
{
	// Token: 0x06000013 RID: 19 RVA: 0x00002548 File Offset: 0x00000748
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

	// Token: 0x06000014 RID: 20 RVA: 0x00002638 File Offset: 0x00000838
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

	// Token: 0x06000015 RID: 21 RVA: 0x0000269C File Offset: 0x0000089C
	internal static void AddResource(string name, global::System.Reflection.Assembly assembly)
	{
		global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(name, assembly);
		resourceManager.GetString("DummyValue");
		global::SR._resourceManagers.Insert(0, resourceManager);
		global::Infragistics.Controls.Primitives.ResourceStringBase.InvalidateCachedResources();
		global::SR._customResourcesVersion++;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000026DC File Offset: 0x000008DC
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
			global::Infragistics.Controls.Primitives.ResourceStringBase.InvalidateCachedResources();
			global::SR._customResourcesVersion++;
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002764 File Offset: 0x00000964
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

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000018 RID: 24 RVA: 0x000027AC File Offset: 0x000009AC
	internal static int CustomResourcesVersion
	{
		get
		{
			return global::SR._customResourcesVersion;
		}
	}

	// Token: 0x04000011 RID: 17
	private static global::System.Collections.Generic.List<global::System.Resources.ResourceManager> _resourceManagers;

	// Token: 0x04000012 RID: 18
	private static int _customResourcesVersion;
}
