using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.CodeplugConfiguration
{
	// Token: 0x02000099 RID: 153
	public partial class PageCodeplugNotOpened : Page
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x000FCD3C File Offset: 0x000FAF3C
		public PageCodeplugNotOpened()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}

		// Token: 0x040003AB RID: 939
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
