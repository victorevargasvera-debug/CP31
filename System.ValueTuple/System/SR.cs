using System;
using System.Resources;
using System.Runtime.CompilerServices;
using FxResources.System.ValueTuple;

namespace System
{
	// Token: 0x02000003 RID: 3
	internal static class SR
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				global::System.Resources.ResourceManager result;
				if ((result = global::System.SR.s_resourceManager) == null)
				{
					result = (global::System.SR.s_resourceManager = new global::System.Resources.ResourceManager(global::System.SR.ResourceType));
				}
				return result;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000206B File Offset: 0x0000026B
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool UsingResourceKeys()
		{
			return false;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002070 File Offset: 0x00000270
		internal static string GetResourceString(string resourceKey, string defaultString)
		{
			string text = null;
			try
			{
				text = global::System.SR.ResourceManager.GetString(resourceKey);
			}
			catch (global::System.Resources.MissingManifestResourceException)
			{
			}
			if (defaultString != null && resourceKey.Equals(text, global::System.StringComparison.Ordinal))
			{
				return defaultString;
			}
			return text;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020B0 File Offset: 0x000002B0
		internal static string Format(string resourceFormat, params object[] args)
		{
			if (args == null)
			{
				return resourceFormat;
			}
			if (global::System.SR.UsingResourceKeys())
			{
				return resourceFormat + string.Join(", ", args);
			}
			return string.Format(resourceFormat, args);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020D7 File Offset: 0x000002D7
		internal static string Format(string resourceFormat, object p1)
		{
			if (global::System.SR.UsingResourceKeys())
			{
				return string.Join(", ", new object[]
				{
					resourceFormat,
					p1
				});
			}
			return string.Format(resourceFormat, p1);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002100 File Offset: 0x00000300
		internal static string Format(string resourceFormat, object p1, object p2)
		{
			if (global::System.SR.UsingResourceKeys())
			{
				return string.Join(", ", new object[]
				{
					resourceFormat,
					p1,
					p2
				});
			}
			return string.Format(resourceFormat, p1, p2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000212E File Offset: 0x0000032E
		internal static string Format(string resourceFormat, object p1, object p2, object p3)
		{
			if (global::System.SR.UsingResourceKeys())
			{
				return string.Join(", ", new object[]
				{
					resourceFormat,
					p1,
					p2,
					p3
				});
			}
			return string.Format(resourceFormat, p1, p2, p3);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002161 File Offset: 0x00000361
		internal static global::System.Type ResourceType { get; } = typeof(global::FxResources.System.ValueTuple.SR);

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002168 File Offset: 0x00000368
		internal static string ArgumentException_ValueTupleIncorrectType
		{
			get
			{
				return global::System.SR.GetResourceString("ArgumentException_ValueTupleIncorrectType", null);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002175 File Offset: 0x00000375
		internal static string ArgumentException_ValueTupleLastArgumentNotAValueTuple
		{
			get
			{
				return global::System.SR.GetResourceString("ArgumentException_ValueTupleLastArgumentNotAValueTuple", null);
			}
		}

		// Token: 0x04000001 RID: 1
		private static global::System.Resources.ResourceManager s_resourceManager;
	}
}
