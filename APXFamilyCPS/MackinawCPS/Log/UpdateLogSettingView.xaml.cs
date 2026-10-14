using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Navigation;
using AcpUI;
using AcpUI.Common;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.Log
{
	// Token: 0x02000076 RID: 118
	public partial class UpdateLogSettingView : PageFunction<string>
	{
		// Token: 0x0600052E RID: 1326 RVA: 0x000E64EC File Offset: 0x000E46EC
		public UpdateLogSettingView(LogSetting logSetting)
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
			base.DataContext = new UpdateLogSettingViewModel(this, logSetting);
		}

		// Token: 0x040002FF RID: 767
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
