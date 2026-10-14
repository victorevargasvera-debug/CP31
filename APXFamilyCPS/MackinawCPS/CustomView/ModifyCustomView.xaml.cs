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
	// Token: 0x02000090 RID: 144
	public partial class ModifyCustomView : Page
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x000EC9A4 File Offset: 0x000EABA4
		public ModifyCustomView()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}

		// Token: 0x04000375 RID: 885
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
