using System;
using System.Windows;
using System.Windows.Controls;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000B0 RID: 176
	internal static class WebBrowserUtility
	{
		// Token: 0x06000475 RID: 1141 RVA: 0x00049140 File Offset: 0x00047340
		public static string GetBindableSource(global::System.Windows.DependencyObject A_0)
		{
			short num = (short)960500565;
			short num2 = num;
			num = (short)1091572565;
			switch (num2 == num)
			{
			}
			num = (short)297598976;
			short num3 = num;
			num = (short)464912384;
			if (num != 0)
			{
			}
			num = (short)1321992193;
			if (num != 0)
			{
			}
			return (string)A_0.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.WebBrowserUtility.BindableSourceProperty);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000491FC File Offset: 0x000473FC
		public static void SetBindableSource(global::System.Windows.DependencyObject A_0, string A_1)
		{
			short num = (short)454719844;
			short num2 = num;
			num = (short)1739422052;
			switch (num2 == num)
			{
			}
			num = (short)1258881024;
			short num3 = num;
			num = (short)189464577;
			if (num != 0)
			{
			}
			num = (short)577568768;
			if (num != 0)
			{
			}
			A_0.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.WebBrowserUtility.BindableSourceProperty, A_1);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000492B4 File Offset: 0x000474B4
		public static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			int a_ = 8;
			short num;
			global::System.Windows.Controls.WebBrowser webBrowser;
			for (;;)
			{
				num = (short)1114898432;
				short num2 = num;
				webBrowser = (global::System.Windows.Controls.WebBrowser)A_0;
				if (A_1.NewValue == null)
				{
					goto IL_D1;
				}
				num = (short)526856889;
				short num3 = num;
				num = (short)1280193209;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7A;
				}
			}
			IL_7A:
			num = (short)906100737;
			if (num != 0)
			{
			}
			num = (short)2067267584;
			if (num != 0)
			{
			}
			webBrowser.Navigate(new global::System.Uri(A_1.NewValue.ToString()));
			return;
			IL_D1:
			webBrowser.Navigate(new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("솟삡쮣펥\udca7邩캫슭톯\udcb1\udfb3", a_)));
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000493AC File Offset: 0x000475AC
		// Note: this type is marked as 'beforefieldinit'.
		static WebBrowserUtility()
		{
			int a_ = 11;
			short num = (short)1076035585;
			if (num != 0)
			{
			}
			num = (short)1150525945;
			short num2 = num;
			num = (short)1095672313;
			switch (num2 == num)
			{
			default:
			{
				num = (short)360906752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)918618112;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.WebBrowserUtility.BindableSourceProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첤즦춨쪪쾬쎮풰\udab4슶쮸\ud8ba\ud8bc", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.WebBrowserUtility), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.WebBrowserUtility.a)));
		}

		// Token: 0x040001A9 RID: 425
		public static readonly global::System.Windows.DependencyProperty BindableSourceProperty;
	}
}
