using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Infragistics
{
	// Token: 0x02000014 RID: 20
	internal class MenuNavigation : global::Infragistics.INavigation
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00003710 File Offset: 0x00001910
		public void NavigateTo()
		{
			if (this.NavigationUri == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Resources.GetString("Navigation_UriIsNotSet"));
			}
			global::System.Uri source;
			if (string.IsNullOrEmpty(this.NavigationParameter))
			{
				source = this.NavigationUri;
			}
			else
			{
				global::System.Collections.Generic.List<string> parameters = global::Infragistics.MenuNavigation.ParseParameters(this.NavigationParameter);
				source = global::Infragistics.MenuNavigation.BuildNavigationString(parameters, this.NavigationUri.OriginalString);
			}
			if (this.NavigationElement is global::System.Windows.Controls.Frame)
			{
				(this.NavigationElement as global::System.Windows.Controls.Frame).Navigate(source);
				return;
			}
			if (!(this.NavigationElement is global::System.Windows.Controls.Page))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Resources.GetString("Navigation_ElementIsNotSet"));
			}
			global::System.Windows.Navigation.NavigationService navigationService = (this.NavigationElement as global::System.Windows.Controls.Page).NavigationService;
			if (navigationService == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Resources.GetString("Navigation_PageIsNotSet"));
			}
			navigationService.Navigate(source);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000037DA File Offset: 0x000019DA
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000037E2 File Offset: 0x000019E2
		public global::System.Uri NavigationUri { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000037EB File Offset: 0x000019EB
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000037F3 File Offset: 0x000019F3
		public string NavigationParameter { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000037FC File Offset: 0x000019FC
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00003804 File Offset: 0x00001A04
		public global::System.Windows.FrameworkElement NavigationElement { get; set; }

		// Token: 0x0600007D RID: 125 RVA: 0x00003810 File Offset: 0x00001A10
		private static global::System.Uri BuildNavigationString(global::System.Collections.Generic.List<string> parameters, string sourceUri)
		{
			int num = 0;
			int num2 = 0;
			string text = "";
			for (;;)
			{
				int num3 = sourceUri.IndexOf("{", num, global::System.StringComparison.Ordinal);
				int num4 = sourceUri.IndexOf("}", num, global::System.StringComparison.Ordinal);
				if (num4 == -1 && num3 == -1)
				{
					goto IL_78;
				}
				if (num4 == -1 || num3 == -1)
				{
					break;
				}
				text += sourceUri.Substring(num, num3 - num);
				text += parameters[num2];
				num2++;
				num = num4 + 1;
			}
			throw new global::System.InvalidOperationException(global::Infragistics.Resources.GetString("Navigation_WrongFormat"));
			IL_78:
			if (num >= 0 && num < sourceUri.Length)
			{
				text += sourceUri.Substring(num);
			}
			return new global::System.Uri(text, global::System.UriKind.RelativeOrAbsolute);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000038BC File Offset: 0x00001ABC
		private static global::System.Collections.Generic.List<string> ParseParameters(string parameterString)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (parameterString[0] != '/')
			{
				list.Add(parameterString);
				return list;
			}
			int num = parameterString.IndexOf('/');
			while (num != -1)
			{
				int num2 = num + 1;
				if (num2 >= parameterString.Length)
				{
					list.Add("");
					break;
				}
				num = parameterString.IndexOf('/', num2);
				if (num == -1)
				{
					list.Add(parameterString.Substring(num2, parameterString.Length - num2));
					break;
				}
				list.Add(parameterString.Substring(num2, num - num2));
			}
			return list;
		}
	}
}
