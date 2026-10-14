using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.CustomView
{
	// Token: 0x0200008F RID: 143
	public partial class ExitingCustomView : Page
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x000EC7F0 File Offset: 0x000EA9F0
		public ExitingCustomView()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}

		// Token: 0x04000373 RID: 883
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
