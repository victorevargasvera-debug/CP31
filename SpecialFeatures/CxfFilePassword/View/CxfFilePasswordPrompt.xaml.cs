using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.CxfFilePassword.View
{
	// Token: 0x0200014B RID: 331
	public partial class CxfFilePasswordPrompt : Window
	{
		// Token: 0x060010DF RID: 4319 RVA: 0x00003626 File Offset: 0x00001826
		public CxfFilePasswordPrompt()
		{
			this.InitializeComponent();
			Utility.SetDirection(this);
		}
	}
}
