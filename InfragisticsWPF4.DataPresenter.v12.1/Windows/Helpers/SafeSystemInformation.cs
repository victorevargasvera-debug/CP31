using System;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Forms;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x0200000C RID: 12
	internal static class SafeSystemInformation
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000035E5 File Offset: 0x000017E5
		private static double ConvertToLogicalPixels(int pixelValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(pixelValue);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000035F0 File Offset: 0x000017F0
		internal static double VirtualScreenHeight
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.SafeSystemInformation.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.SafeSystemInformation.VirtualScreenHeightFallback;
				}
				double result;
				try
				{
					result = global::System.Windows.SystemParameters.VirtualScreenHeight;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.SafeSystemInformation.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.SafeSystemInformation.VirtualScreenHeightFallback;
				}
				return result;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003634 File Offset: 0x00001834
		private static double VirtualScreenHeightFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.SafeSystemInformation.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Height);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003654 File Offset: 0x00001854
		internal static double VirtualScreenWidth
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.SafeSystemInformation.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.SafeSystemInformation.VirtualScreenWidthFallback;
				}
				double result;
				try
				{
					result = global::System.Windows.SystemParameters.VirtualScreenWidth;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.SafeSystemInformation.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.SafeSystemInformation.VirtualScreenWidthFallback;
				}
				return result;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003698 File Offset: 0x00001898
		private static double VirtualScreenWidthFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.SafeSystemInformation.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Width);
			}
		}

		// Token: 0x04000025 RID: 37
		private static bool hasSecurityExceptionBeenThrown;
	}
}
