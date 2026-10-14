using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200002F RID: 47
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "MainRegion")]
	public class RadioMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000206 RID: 518 RVA: 0x000246C0 File Offset: 0x000228C0
		public RadioMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000067 RID: 103
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000246DC File Offset: 0x000228DC
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Radio.MainViewModel ViewModel
		{
			set
			{
				short num = (short)1519788507;
				short num2 = num;
				num = (short)1345266139;
				switch (num2 == num)
				{
				}
				num = (short)1385431040;
				short num3 = num;
				num = (short)1906900993;
				if (num != 0)
				{
				}
				num = (short)274857984;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0002478C File Offset: 0x0002298C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			if (this._contentLoaded)
			{
				short num = (short)1888288769;
				if (num != 0)
				{
				}
				num = (short)245144040;
				short num2 = num;
				num = (short)153262568;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1256980480;
					short num3 = num;
					break;
				}
				}
				num = (short)978255872;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("醽趿귁냃꧅뫇ꗉꃋ꿍ﻏ金믓믕뗗뗙닛鷝냟뇡쫣듥觧軩藫臭뷯鏱髳韵鿷鿹釻鯽滿瘁⨃吅椇渉攋愍⬏焑笓笕栗甙爛笝丟嘡ଣ䬥䤧䌩䈫堭夯圱䌳ᠵ䀷嬹儻刽", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00024870 File Offset: 0x00022A70
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)455540737;
			if (num != 0)
			{
			}
			num = (short)1714096435;
			short num2 = num;
			num = (short)1698498867;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1656356864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)411435008;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
		}

		// Token: 0x040000F8 RID: 248
		private bool _contentLoaded;
	}
}
