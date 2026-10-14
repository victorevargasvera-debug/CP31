using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.ConfigurationEditor;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.LanguagePack
{
	// Token: 0x02000005 RID: 5
	[global::System.ComponentModel.Composition.Export("LanguagePackMainView")]
	public class LanguagePackMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00004258 File Offset: 0x00002458
		public LanguagePackMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00004274 File Offset: 0x00002474
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.LanguagePack.MainViewModel ViewModel
		{
			set
			{
				short num = (short)416544882;
				short num2 = num;
				num = (short)1983445106;
				switch (num2 == num)
				{
				}
				num = (short)206700545;
				if (num != 0)
				{
				}
				num = (short)614334464;
				if (num != 0)
				{
				}
				num = (short)1040515072;
				short num3 = num;
				base.DataContext = value;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004328 File Offset: 0x00002528
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)811204609;
			if (num != 0)
			{
			}
			num = (short)1802533423;
			short num2 = num;
			num = (short)421231151;
			switch (num2 == num)
			{
			}
			num = (short)302448640;
			if (num != 0)
			{
			}
			num = (short)1315176448;
			short num3 = num;
			this.dgrLanguagePacks.HideColumn(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ቝşౡͣ፥१൩५⡭ᅯάᵳ᩵ŷ", a_));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000043F4 File Offset: 0x000025F4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 2;
			while (!this._contentLoaded)
			{
				short num = (short)1303804832;
				short num2 = num;
				num = (short)369195936;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1216544768;
					short num3 = num;
					break;
				}
				}
				num = (short)912457729;
				if (num != 0)
				{
				}
				num = (short)23789568;
				if (num != 0)
				{
				}
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("留ᅛㅝᑟൡᙣ॥ѧ୩䉫⵭Ὧάᥳ᥵ᙷ㥹ⱻ⵽깿킁솋ﺏﾙ躟얣좥쾧\udfa9춫즭햯햳햵펷膹\udfbb톽궿닁ꯃꣅ귇꓉룋뷏돑뷓룕껗동맛꧝컟髡藣该蓧", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000044D4 File Offset: 0x000026D4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1343684610;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1088159745;
					if (num != 0)
					{
					}
					num = (short)1724645380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1079312384;
					short num3 = num;
					num = (short)637272067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 3:
				{
					num = (short)1766035602;
					short num4 = num;
					num = (short)1603506322;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						num = (short)1508835328;
						if (num != 0)
						{
						}
						if (connectionId != 2)
						{
							num = (short)582352896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163;
					}
					break;
				}
				case 4:
					goto IL_8D;
				}
				goto IL_3A;
				IL_3E:
				num = (short)335609857;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A:
				if (connectionId != 1)
				{
					goto IL_3E;
				}
				break;
			}
			this.uscLanguagePacks = (global::Motorola.CommonCPS.RadioManagement.LanguagePack.LanguagePackMainView)target;
			this.uscLanguagePacks.Loaded += this.a;
			return;
			IL_8D:
			this._contentLoaded = true;
			return;
			IL_163:
			this.dgrLanguagePacks = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x0400000E RID: 14
		internal global::Motorola.CommonCPS.RadioManagement.LanguagePack.LanguagePackMainView uscLanguagePacks;

		// Token: 0x0400000F RID: 15
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrLanguagePacks;

		// Token: 0x04000010 RID: 16
		private bool _contentLoaded;
	}
}
