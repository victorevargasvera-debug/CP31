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
	// Token: 0x02000091 RID: 145
	public partial class NewCustomView : Page
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x000ECB58 File Offset: 0x000EAD58
		public NewCustomView()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}

		// Token: 0x04000377 RID: 887
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
