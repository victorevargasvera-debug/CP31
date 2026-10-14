using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x02000013 RID: 19
	public class RegisterLicenseView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0000A594 File Offset: 0x00008794
		public RegisterLicenseView()
		{
			this.InitializeComponent();
			this.a();
			base.DataContextChanged += this.a;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000A5C8 File Offset: 0x000087C8
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.RadioLicense.RegisterLicenseViewModel registerLicenseViewModel;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (registerLicenseViewModel == null)
					{
						return;
					}
					num2 = (short)1305049794;
					short num3 = num2;
					num2 = (short)442727106;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1397161984;
						if (num2 != 0)
						{
						}
						num2 = (short)2015821824;
						short num4 = num2;
						num2 = (short)1505558532;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					num2 = (short)1184759809;
					if (num2 != 0)
					{
					}
					this.licenseGrid.ColumnDefinitions[0].MaxWidth = 300.0;
					this.licenseGrid.ColumnDefinitions[0].MinWidth = 200.0;
					this.licenseGrid.ColumnDefinitions[0].Width = new global::System.Windows.GridLength(0.2, global::System.Windows.GridUnitType.Star);
					this.licenseGrid.ColumnDefinitions[1].Width = new global::System.Windows.GridLength(10.0, global::System.Windows.GridUnitType.Pixel);
					this.licenseGrid.ColumnDefinitions[2].Width = new global::System.Windows.GridLength(0.8, global::System.Windows.GridUnitType.Star);
					registerLicenseViewModel.RegistRadioLicenseContext.PropertyChanged += this.a;
					num2 = (short)913965058;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				case 3:
					if (registerLicenseViewModel != null)
					{
						num2 = (short)1822621697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					this.gplGroup.Groups = registerLicenseViewModel.RegistRadioLicenseContext.Groups;
					this.gplGroup.SelectedGroup = new global::Motorola.CommonCPS.RadioManagement.UIModels.Group();
					this.gplGroup.SelectedGroup = registerLicenseViewModel.RegistRadioLicenseContext.SelectedGroup;
					num2 = (short)1984430083;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return;
			IL_24:
			registerLicenseViewModel = (A_1.NewValue as global::Motorola.CommonCPS.RadioManagement.RadioLicense.RegisterLicenseViewModel);
			num2 = (short)1709899776;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000A830 File Offset: 0x00008A30
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1636171776;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1750663168;
				short num3 = num;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					continue;
				case 1:
					num = (short)1494089732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					this.errorBar.BringIntoView();
					num = (short)1496907778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
					if (!string.IsNullOrEmpty(registerRadioLicenseContext.ExceptionMessage))
					{
						num = (short)634322947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 5:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
					if (registerRadioLicenseContext != null)
					{
						num = (short)97517569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 6:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext = A_0 as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext;
					num = (short)718209029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_75:
				num = (short)1902875754;
				short num4 = num;
				num = (short)1617990762;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)150011904;
					if (num != 0)
					{
					}
					if (!A_1.PropertyName.Equals(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("猵䀷夹夻丽㐿⭁⭃⡅Շ⽉㽋㵍ㅏ㕑ㅓ", a_)))
					{
						return;
					}
					num = (short)763887617;
					if (num != 0)
					{
					}
					num = (short)175046662;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000A9FC File Offset: 0x00008BFC
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 14;
			short num = (short)1140457472;
			short num2 = num;
			num = (short)567345153;
			if (num != 0)
			{
			}
			num = (short)886705111;
			short num3 = num;
			num = (short)229706711;
			switch (num3 == num)
			{
			}
			num = (short)1862598656;
			if (num != 0)
			{
			}
			this.dgrAvailableDevices.HideColumn(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("缱嬳刵崷嘹爻䬽ⴿ⁁⅃㑅", a_));
			this.dgrSelectedDevices.HideColumn(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("缱嬳刵崷嘹爻䬽ⴿ⁁⅃㑅", a_));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			short num = (short)681574400;
			short num2 = num;
			num = (short)934557998;
			short num3 = num;
			num = (short)482228526;
			switch (num3 == num)
			{
			}
			num = (short)1402404865;
			if (num != 0)
			{
			}
			num = (short)861011968;
			if (num != 0)
			{
			}
			this.btnRegister.Focus();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000AB98 File Offset: 0x00008D98
		private void a()
		{
			short num = (short)1228079104;
			short num2 = num;
			num = (short)602693048;
			short num3 = num;
			num = (short)1345150392;
			switch (num3 == num)
			{
			}
			num = (short)1932656641;
			if (num != 0)
			{
			}
			num = (short)1865678848;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000AC44 File Offset: 0x00008E44
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			short num = (short)1932132352;
			short num2 = num;
			num = (short)918991675;
			short num3 = num;
			num = (short)571192123;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1042022401;
				if (num != 0)
				{
				}
				num = (short)1509883904;
				if (num != 0)
				{
				}
				if (this._contentLoaded)
				{
					return;
				}
				break;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d(".簰尲䄴堶䬸吺儼帾潀B⩄⩆⑈⑊⍌౎ŐR答Ֆ㡘㽚㑜ぞⱠɢ୤٦๨๪l੮ὰݲ孴╶㑸⥺ㅼⱾ몀麗ﾐ몔ﲘﲚ햠욢힤쮦삨좪좬솮슰횲쎴\udeb6\udcb8첺銼춾꓀꓂계듆뷈껊뿌ꏎ룐냒냔맖꫘뻚ꯜ뛞蓠铢쯤鿦裨蛪臬", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000AD24 File Offset: 0x00008F24
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)244514818;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1F0;
				case 1:
					num = (short)643629056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_202;
				case 2:
					goto IL_121;
				case 3:
					goto IL_107;
				case 4:
					goto IL_1A5;
				case 5:
					goto IL_1F5;
				case 6:
					goto IL_1CC;
				case 7:
					goto IL_226;
				case 8:
				case 10:
					goto IL_25A;
				case 9:
					goto IL_24D;
				case 11:
					goto IL_198;
				case 12:
					goto IL_FA;
				case 13:
					goto IL_240;
				case 14:
					goto IL_12E;
				case 15:
					goto IL_A3;
				case 16:
					goto IL_233;
				case 17:
					goto IL_114;
				case 18:
					goto IL_1B2;
				case 19:
					goto IL_164;
				case 20:
					goto IL_1BF;
				default:
					num = (short)483131393;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_A3:
			num = (short)923041747;
			short num3 = num;
			num = (short)1193574355;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_12E:
				num = (short)7274496;
				short num4 = num;
				this.btnRemove = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
				return;
			}
			default:
				num = (short)1101332480;
				if (num != 0)
				{
				}
				this.btnRemoveAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
				return;
			}
			IL_FA:
			this.btnAddAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_107:
			this.gplGroup = (global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList)target;
			return;
			IL_114:
			this.btnRegister = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_121:
			this.licenseGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_164:
			num = (short)434307073;
			if (num != 0)
			{
			}
			this.errorBar = (global::Motorola.CommonCPS.RadioManagement.Controls.RMErrorBar)target;
			return;
			IL_198:
			this.dgrAvailableDevices = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_1A5:
			this.msiEID = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_1B2:
			this.btnClose = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1BF:
			this.roundProgressCtrl = (global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator)target;
			return;
			IL_1CC:
			this.btnClearAll = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_1F0:
			goto IL_25A;
			IL_1F5:
			this.btnQuery = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_202:
			this.EIDView = (global::Motorola.CommonCPS.RadioManagement.RadioLicense.RegisterLicenseView)target;
			this.EIDView.Loaded += this.a;
			return;
			IL_226:
			this.dgrASTROEIDDetails = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_233:
			this.dgrSelectedDevices = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_240:
			this.btnAdd = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_24D:
			this.dgrPCREIDDetails = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_25A:
			this._contentLoaded = true;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000AF94 File Offset: 0x00009194
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1547108352;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					return;
				case 2:
					if (connectionId != 10)
					{
						num = (short)1875181569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_155;
				case 3:
				{
					num = (short)217625051;
					short num3 = num;
					num = (short)1410314715;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1167261696;
						if (num != 0)
						{
						}
						num = (short)116850689;
						if (num != 0)
						{
						}
						num = (short)404488194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_5D;
				IL_14:
				num = (short)813498368;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_5D:
					if (connectionId == 8)
					{
						goto IL_C2;
					}
					num = (short)1489043459;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C2:
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_155:
			eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
		}

		// Token: 0x0400003A RID: 58
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.RadioLicense.RegisterLicenseView EIDView;

		// Token: 0x0400003B RID: 59
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::System.Windows.Controls.Grid licenseGrid;

		// Token: 0x0400003C RID: 60
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupList gplGroup;

		// Token: 0x0400003D RID: 61
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiEID;

		// Token: 0x0400003E RID: 62
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnQuery;

		// Token: 0x0400003F RID: 63
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnClearAll;

		// Token: 0x04000040 RID: 64
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrASTROEIDDetails;

		// Token: 0x04000041 RID: 65
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrPCREIDDetails;

		// Token: 0x04000042 RID: 66
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrAvailableDevices;

		// Token: 0x04000043 RID: 67
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnAddAll;

		// Token: 0x04000044 RID: 68
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnAdd;

		// Token: 0x04000045 RID: 69
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRemove;

		// Token: 0x04000046 RID: 70
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRemoveAll;

		// Token: 0x04000047 RID: 71
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrSelectedDevices;

		// Token: 0x04000048 RID: 72
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRegister;

		// Token: 0x04000049 RID: 73
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnClose;

		// Token: 0x0400004A RID: 74
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMErrorBar errorBar;

		// Token: 0x0400004B RID: 75
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMWaitingIndicator roundProgressCtrl;

		// Token: 0x0400004C RID: 76
		private bool _contentLoaded;
	}
}
