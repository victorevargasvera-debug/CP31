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

namespace Motorola.CommonCPS.RadioManagement.CACertificates
{
	// Token: 0x02000005 RID: 5
	[global::System.ComponentModel.Composition.Export("CACertificatesMainView")]
	public class CACertificatesMainView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002558 File Offset: 0x00000758
		public CACertificatesMainView()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002574 File Offset: 0x00000774
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.CACertificates.MainViewModel ViewModel
		{
			set
			{
				short num = (short)275180266;
				short num2 = num;
				num = (short)890628842;
				switch (num2 == num)
				{
				}
				num = (short)667680768;
				short num3 = num;
				num = (short)1894318081;
				if (num != 0)
				{
				}
				num = (short)784531456;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002620 File Offset: 0x00000820
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1396490388;
			short num2 = num;
			num = (short)525648020;
			switch (num2 == num)
			{
			}
			num = (short)436862976;
			short num3 = num;
			num = (short)1335296000;
			if (num != 0)
			{
			}
			num = (short)102825985;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000026CC File Offset: 0x000008CC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 2;
			short num = (short)50790401;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)455555901;
				short num2 = num;
				num = (short)527186749;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1360855040;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)1696661504;
				short num3 = num;
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("肮ﲰ\udcb2솴\ud8b6쮸풺톼\udebe胂꫄꫆꓈꓊ꏌ賎臐胒ﯔ藖룘뿚드냞고苢诤蛦軨軪胬諮鿰蟲\udbf4듶룸룺飼跾甀樂挄渆樈樊礌樎成⠒瘔砖琘欚爜焞䐠䴢儤ࠦ䐨䨪䐬䄮䜰娲倴䀶᜸䌺尼刾ⵀ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000027AC File Offset: 0x000009AC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1703939;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)943390720;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_12B;
				case 1:
					num = (short)2093285378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (connectionId != 2)
					{
						num = (short)446758916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_163;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 4:
					num = (short)1504247808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (connectionId == 1)
				{
					num = (short)1189896842;
					short num4 = num;
					num = (short)1176855178;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_B3;
					}
				}
				num = (short)1869807617;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B3:
			num = (short)1158414336;
			if (num != 0)
			{
			}
			num = (short)606666753;
			if (num != 0)
			{
			}
			this.uscCACertificates = (global::Motorola.CommonCPS.RadioManagement.CACertificates.CACertificatesMainView)target;
			this.uscCACertificates.Loaded += this.a;
			return;
			IL_12B:
			this._contentLoaded = true;
			return;
			IL_163:
			this.dgrCACertificates = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
		}

		// Token: 0x04000006 RID: 6
		internal global::Motorola.CommonCPS.RadioManagement.CACertificates.CACertificatesMainView uscCACertificates;

		// Token: 0x04000007 RID: 7
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrCACertificates;

		// Token: 0x04000008 RID: 8
		private bool _contentLoaded;
	}
}
