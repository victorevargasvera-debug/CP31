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
		object[] customAttributes = typeof(global::SR).Assembly.GetCustomAttributes(typeof(global::Infragistics.StringResourceLocationAttribute), true);
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
		global::System.Reflection.Assembly assembly = typeof(global::SR).Assembly;
		foreach (string text2 in array)
		{
			if (text2 != null && text2.Length > 0)
			{
				global::SR._resourceManagers.Add(new global::System.Resources.ResourceManager(text2, assembly));
			}
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002648 File Offset: 0x00000848
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

	// Token: 0x06000015 RID: 21 RVA: 0x000026AC File Offset: 0x000008AC
	internal static void AddResource(string name, global::System.Reflection.Assembly assembly)
	{
		global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(name, assembly);
		resourceManager.GetString("DummyValue");
		global::SR._resourceManagers.Insert(0, resourceManager);
		global::Infragistics.Controls.Primitives.ResourceStringBase.InvalidateCachedResources();
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000026E0 File Offset: 0x000008E0
	internal static void RemoveResource(string name)
	{
		global::System.Resources.ResourceManager resourceManager = null;
		foreach (global::System.Resources.ResourceManager resourceManager2 in global::SR._resourceManagers)
		{
			if (resourceManager2.BaseName == name)
			{
				resourceManager = resourceManager2;
				break;
			}
		}
		if (resourceManager != null)
		{
			global::SR._resourceManagers.Remove(resourceManager);
			global::Infragistics.Controls.Primitives.ResourceStringBase.InvalidateCachedResources();
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002754 File Offset: 0x00000954
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

	// Token: 0x04000011 RID: 17
	private static global::System.Collections.Generic.List<global::System.Resources.ResourceManager> _resourceManagers;
}
