using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ApplicationLicense
{
	// Token: 0x02000006 RID: 6
	public class RegisterLicenseView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002E04 File Offset: 0x00001004
		public RegisterLicenseView()
		{
			this.InitializeComponent();
			this.a();
			this.b();
			base.DataContextChanged += this.a;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002E3C File Offset: 0x0000103C
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1107623936;
			short num2 = num;
			num = (short)1565486943;
			short num3 = num;
			num = (short)530870111;
			switch (num3 == num)
			{
			}
			num = (short)691208193;
			if (num != 0)
			{
			}
			num = (short)1583808512;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002EE8 File Offset: 0x000010E8
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel ViewModel
		{
			set
			{
				short num = (short)1621884928;
				short num2 = num;
				num = (short)1803749408;
				short num3 = num;
				num = (short)1428359200;
				switch (num3 == num)
				{
				}
				num = (short)1474691072;
				if (num != 0)
				{
				}
				num = (short)304807937;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002F98 File Offset: 0x00001198
		private void b()
		{
			short num = (short)548077568;
			short num2 = num;
			num = (short)410301972;
			short num3 = num;
			num = (short)1599714836;
			switch (num3 == num)
			{
			}
			num = (short)1651048448;
			if (num != 0)
			{
			}
			num = (short)842203137;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003040 File Offset: 0x00001240
		private void a()
		{
			short num = (short)1157103616;
			short num2 = num;
			num = (short)1890481320;
			short num3 = num;
			num = (short)103052456;
			switch (num3 == num)
			{
			}
			num = (short)13238273;
			if (num != 0)
			{
			}
			num = (short)1505624064;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000030EC File Offset: 0x000012EC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)923690837;
			short num2 = num;
			num = (short)1720477525;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)92864512;
				short num3 = num;
				num = (short)1991180289;
				if (num != 0)
				{
				}
				num = (short)1776680960;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ApplicationLicense.RegisterLicenseViewModel.g("莫\udfaf욱\udbb3쒵ힷ횹\uddbb邽莿귁꧃ꯅꟇ꓉迋黍菏ﳑ蛓럕볗동돛鏝臟賡藣臥跧蟩觫胭蓯\udcf1꛳믵맷뛹꿻엽揿洁椃瘅朇搉椋怍搏㴑易猕缗猙漛樝䔟倡䠣伥䬧伩䈫崭唯䐱崳匵伷ᔹ主嬽✿⭁㝃㉅ⵇ㡉⁋❍㍏㝑㩓╕㵗ⱙ㕛㭝᝟䱡ᱣݥէ٩", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000031CC File Offset: 0x000013CC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1269170176;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					num = (short)1342373890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1C1;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_1D3;
				case 2:
					goto IL_119;
				case 3:
					goto IL_FF;
				case 4:
					goto IL_14D;
				case 5:
					goto IL_1C6;
				case 6:
					goto IL_19D;
				case 7:
					goto IL_1E0;
				case 8:
					goto IL_22E;
				case 9:
					goto IL_140;
				case 10:
					goto IL_F2;
				case 11:
					goto IL_221;
				case 12:
					goto IL_126;
				case 13:
					goto IL_9A;
				case 14:
					goto IL_214;
				case 15:
					goto IL_10C;
				case 16:
					goto IL_15A;
				case 17:
					goto IL_133;
				case 18:
					goto IL_167;
				default:
					num = (short)402259969;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_9A:
			num = (short)1673445616;
			short num3 = num;
			num = (short)506904816;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_119:
				this.lbiEID = (global::System.Windows.Controls.ListBoxItem)target;
				return;
			default:
				num = (short)1472397312;
				if (num != 0)
				{
				}
				this.gridEID = (global::System.Windows.Controls.Grid)target;
				return;
			}
			IL_F2:
			this.btnGetHostID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_FF:
			this.lbiFile = (global::System.Windows.Controls.ListBoxItem)target;
			return;
			IL_10C:
			this.btnPCRQuery = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_126:
			this.grdPCR = (global::System.Windows.Controls.Grid)target;
			return;
			IL_133:
			this.btnRegister = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_140:
			this.gridFile = (global::System.Windows.Controls.Grid)target;
			return;
			IL_14D:
			this.bdEID = (global::System.Windows.Controls.Border)target;
			return;
			IL_15A:
			this.dgrPCRFeatures = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_167:
			num = (short)312541184;
			short num4 = num;
			this.btnClose = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_19D:
			this.btnQuery = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1C1:
			this._contentLoaded = true;
			return;
			IL_1C6:
			this.msiEID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_1D3:
			this.grdASTRO = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1E0:
			num = (short)540016641;
			if (num != 0)
			{
			}
			this.dgrFeatures = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_214:
			this.msiPCREID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_221:
			this.msiLicenseFile = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_22E:
			this.bdFile = (global::System.Windows.Controls.Border)target;
		}

		// Token: 0x04000007 RID: 7
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.Grid grdASTRO;

		// Token: 0x04000008 RID: 8
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.ListBoxItem lbiEID;

		// Token: 0x04000009 RID: 9
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.ListBoxItem lbiFile;

		// Token: 0x0400000A RID: 10
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.Border bdEID;

		// Token: 0x0400000B RID: 11
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiEID;

		// Token: 0x0400000C RID: 12
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnQuery;

		// Token: 0x0400000D RID: 13
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrFeatures;

		// Token: 0x0400000E RID: 14
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.Border bdFile;

		// Token: 0x0400000F RID: 15
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.Grid gridFile;

		// Token: 0x04000010 RID: 16
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnGetHostID;

		// Token: 0x04000011 RID: 17
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiLicenseFile;

		// Token: 0x04000012 RID: 18
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.Grid grdPCR;

		// Token: 0x04000013 RID: 19
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.Grid gridEID;

		// Token: 0x04000014 RID: 20
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiPCREID;

		// Token: 0x04000015 RID: 21
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnPCRQuery;

		// Token: 0x04000016 RID: 22
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrPCRFeatures;

		// Token: 0x04000017 RID: 23
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRegister;

		// Token: 0x04000018 RID: 24
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnClose;

		// Token: 0x04000019 RID: 25
		private bool _contentLoaded;
	}
}
