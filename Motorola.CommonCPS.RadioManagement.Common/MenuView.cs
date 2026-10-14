using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Infragistics.Controls.Menus;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000034 RID: 52
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "MenuRegion")]
	public class MenuView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00017AA4 File Offset: 0x00015CA4
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MenuView(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			this.InitializeComponent();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ActiveMainModuleChangedEvent>().Subscribe(new global::System.Action<string>(this.a));
		}

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00017AD8 File Offset: 0x00015CD8
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Common.MenuViewModel ViewModel
		{
			set
			{
				short num = (short)1564450467;
				short num2 = num;
				num = (short)2068029091;
				switch (num2 == num)
				{
				}
				num = (short)1645019137;
				if (num != 0)
				{
				}
				num = (short)1135476736;
				short num3 = num;
				num = (short)44892160;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00017B8C File Offset: 0x00015D8C
		private void a(string A_0)
		{
			short num = (short)1253209667;
			short num2 = num;
			num = (short)1328444995;
			switch (num2 == num)
			{
			}
			num = (short)1394409473;
			if (num != 0)
			{
			}
			num = (short)1910767616;
			short num3 = num;
			num = (short)1816592384;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00017C38 File Offset: 0x00015E38
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)882716256;
			short num2 = num;
			num = (short)1338715744;
			switch (num2 == num)
			{
			}
			num = (short)967704576;
			if (num != 0)
			{
			}
			num = (short)635174912;
			short num3 = num;
			num = (short)471203841;
			if (num != 0)
			{
			}
			global::System.Windows.Application.Current.MainWindow.Close();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00017CF0 File Offset: 0x00015EF0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 15;
			short num = (short)1718616065;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				num = (short)878416813;
				short num2 = num;
				num = (short)537170861;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AF;
				case 1:
					break;
				default:
				{
					num = (short)1873346560;
					short num3 = num;
					break;
				}
				}
				num = (short)1414004736;
				if (num != 0)
				{
				}
				return;
			}
			IL_AF:
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("컠껢諤鏦蛨駪苬菮郰\uddf2뛴飶铸雺鋼釾䈀匂嘄⤆嬈樊椌明縐帒琔礖砘簚砜爞䐠䴢儤द樨䐪䀬䈮帰崲ิ吶嘸嘺䴼倾⽀♂⭄㍆晈♊⡌ⅎ⑐╒㱔㉖⹘瑚ぜ㩞འᙢ፤๦౨ᱪ䍬ᝮၰṲᥴ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00017DD0 File Offset: 0x00015FD0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)120193026;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2082013185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_EC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_B9;
				case 2:
					goto IL_162;
				case 3:
					goto IL_17C;
				case 4:
					goto IL_155;
				case 5:
					goto IL_85;
				case 6:
					goto IL_16F;
				case 7:
					goto IL_78;
				case 8:
					goto IL_13B;
				case 9:
					goto IL_C6;
				case 10:
					goto IL_148;
				default:
					num = (short)1473642496;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_78:
			this.mniViewAppFeatures = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_85:
			num = (short)524222465;
			if (num != 0)
			{
			}
			this.mniLicenses = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_B9:
			this.mniCPS = (global::Infragistics.Controls.Menus.XamMenu)target;
			return;
			IL_C6:
			this.mniTools = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_EC:
			num = (short)634955267;
			short num3 = num;
			num = (short)231122435;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B9;
			default:
			{
				num = (short)1711996928;
				if (num != 0)
				{
				}
				num = (short)97845248;
				short num4 = num;
				this._contentLoaded = true;
				return;
			}
			}
			IL_13B:
			this.mniRecoverAppFeatures = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_148:
			this.mniHelp = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_155:
			this.mniDevice = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_162:
			this.mniFile = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_16F:
			this.mniRegAppFeatures = (global::Infragistics.Controls.Menus.XamMenuItem)target;
			return;
			IL_17C:
			((global::Infragistics.Controls.Menus.XamMenuItem)target).Click += this.a;
		}

		// Token: 0x040000F4 RID: 244
		internal global::Infragistics.Controls.Menus.XamMenu mniCPS;

		// Token: 0x040000F5 RID: 245
		internal global::Infragistics.Controls.Menus.XamMenuItem mniFile;

		// Token: 0x040000F6 RID: 246
		internal global::Infragistics.Controls.Menus.XamMenuItem mniDevice;

		// Token: 0x040000F7 RID: 247
		internal global::Infragistics.Controls.Menus.XamMenuItem mniLicenses;

		// Token: 0x040000F8 RID: 248
		internal global::Infragistics.Controls.Menus.XamMenuItem mniRegAppFeatures;

		// Token: 0x040000F9 RID: 249
		internal global::Infragistics.Controls.Menus.XamMenuItem mniViewAppFeatures;

		// Token: 0x040000FA RID: 250
		internal global::Infragistics.Controls.Menus.XamMenuItem mniRecoverAppFeatures;

		// Token: 0x040000FB RID: 251
		internal global::Infragistics.Controls.Menus.XamMenuItem mniTools;

		// Token: 0x040000FC RID: 252
		internal global::Infragistics.Controls.Menus.XamMenuItem mniHelp;

		// Token: 0x040000FD RID: 253
		private bool _contentLoaded;
	}
}
