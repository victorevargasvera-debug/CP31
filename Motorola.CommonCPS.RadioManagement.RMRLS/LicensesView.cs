using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Infragistics.Windows.DataPresenter;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.Infrastructure.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x0200000A RID: 10
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "RadioLicenseMainRegion")]
	public class LicensesView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000035 RID: 53 RVA: 0x0000467C File Offset: 0x0000287C
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public LicensesView(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			this.InitializeComponent();
			this.a();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintViewRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintViewPreviewRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext>(this.a));
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000046CC File Offset: 0x000028CC
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.RadioLicense.LicensesViewModel ViewModel
		{
			set
			{
				short num = (short)1597702144;
				short num2 = num;
				num = (short)1953941300;
				short num3 = num;
				num = (short)1260898100;
				switch (num3 == num)
				{
				}
				num = (short)24313857;
				if (num != 0)
				{
				}
				num = (short)1914109952;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000477C File Offset: 0x0000297C
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext A_0)
		{
			int a_ = 1;
			short num = (short)866582528;
			switch (num)
			{
			default:
			{
				num = (short)386859011;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator enumerator;
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation dataGridOperation;
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> fieldNeedSpecialConverter;
					global::System.Collections.Generic.List<string> fieldNeedCollapsed;
					switch (num2)
					{
					case 0:
						num = (short)1024065544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1677983748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)518716660;
						short num3 = num;
						num = (short)743242996;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_243;
						default:
							goto IL_2E3;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_75;
						}
						continue;
					case 4:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("眤欦瘨未䐬䰮吰崲䘴制䨸洺吼娾㙀", a_))
						{
							goto IL_243;
						}
						return;
					case 5:
						goto IL_1B2;
					case 6:
						num = (short)1386086409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						try
						{
							num = (short)330891264;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_112;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)839974915;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current;
									A_0.SelectedDataItems.Add((global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase)dataRecord.DataItem);
									num = (short)1906180097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)536084484;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_19F;
								}
								IL_114:
								num = (short)517079042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_112:
								goto IL_114;
							}
							IL_19F:
							goto IL_260;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1B2;
						IL_260:
						num = (short)479789056;
						short num4 = num;
						dataGridOperation.DevicesPrint(A_0.SelectedDataItems, fieldNeedSpecialConverter, fieldNeedCollapsed);
						num = (short)187301890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("眤䘦䴨䈪䈬挮堰倲倴夶䨸帺", a_))
						{
							num = (short)1547698177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						if (A_0 != null)
						{
							num = (short)1868234757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_75:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("眤䘦䴨䈪䈬挮堰倲倴夶䨸帺", a_))
					{
						num = (short)1624702977;
						if (num != 0)
						{
						}
						num = (short)1354432512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_1B2:
					fieldNeedSpecialConverter = A_0.FieldNeedSpecialConverter;
					fieldNeedCollapsed = A_0.FieldNeedCollapsed;
					dataGridOperation = null;
					dataGridOperation = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation(this.dgrASTRORadioLicenses);
					global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dataGrid = this.dgrASTRORadioLicenses;
					A_0.SelectedDataItems = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
					enumerator = dataGridOperation.GetPrintRecords(dataGrid).GetEnumerator();
					num = (short)501415943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_243:
					num = (short)1427243014;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2E3:
				num = (short)1333788672;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004B28 File Offset: 0x00002D28
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext A_0)
		{
			int a_ = 7;
			short num = (short)108199936;
			switch (num)
			{
			default:
			{
				num = (short)62455811;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)695861248;
					short num3 = num;
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator enumerator;
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation dataGridOperation;
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> fieldNeedSpecialConverter;
					global::System.Collections.Generic.List<string> fieldNeedCollapsed;
					switch (num2)
					{
					case 0:
						num = (short)429981704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1431175172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2CC;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_9C;
						}
						continue;
					case 4:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("礪愬瀮細娲嘴制圸䠺堼䰾ᝀ⩂⁄う", a_))
						{
							num = (short)866975750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35F;
					case 5:
						goto IL_1FB;
					case 6:
						num = (short)254148617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)925892608;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_111;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										goto IL_131;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current;
									A_0.SelectedDataItems.Add((global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase)dataRecord.DataItem);
									num = (short)594935809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)2024341508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									num = (short)572589518;
									short num4 = num;
									num = (short)1176896974;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_131;
									default:
										goto IL_1D2;
									}
									break;
								}
								}
								IL_113:
								num = (short)897318914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_111:
								goto IL_113;
								IL_131:
								num = (short)46202883;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1D2:
							num = (short)1658585088;
							if (num != 0)
							{
							}
							goto IL_2A6;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1FB;
						IL_2A6:
						dataGridOperation.DevicesPrintView(A_0.SelectedDataItems, fieldNeedSpecialConverter, fieldNeedCollapsed);
						num = (short)1639841794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("礪䰬䬮堰尲礴帶娸帺匼䰾⑀", a_))
						{
							num = (short)1043464193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35F;
					case 9:
						if (A_0 != null)
						{
							num = (short)1227685893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35F;
					}
					IL_9C:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("礪䰬䬮堰尲礴帶娸帺匼䰾⑀", a_))
					{
						num = (short)905510912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1FB:
					fieldNeedSpecialConverter = A_0.FieldNeedSpecialConverter;
					fieldNeedCollapsed = A_0.FieldNeedCollapsed;
					dataGridOperation = null;
					dataGridOperation = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation(this.dgrASTRORadioLicenses);
					global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dataGrid = this.dgrASTRORadioLicenses;
					A_0.SelectedDataItems = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
					enumerator = dataGridOperation.GetPrintRecords(dataGrid).GetEnumerator();
					num = (short)687407111;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2CC:
				IL_35F:
				num = (short)1859846145;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004ED8 File Offset: 0x000030D8
		private void a()
		{
			short num = (short)1498133605;
			short num2 = num;
			num = (short)1266201701;
			switch (num2 == num)
			{
			}
			num = (short)233570304;
			short num3 = num;
			num = (short)1837563905;
			if (num != 0)
			{
			}
			num = (short)209453056;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004F84 File Offset: 0x00003184
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 11;
			if (!this._contentLoaded)
			{
				short num = (short)1394475735;
				short num2 = num;
				num = (short)1695482583;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1308360705;
					if (num != 0)
					{
					}
					num = (short)135725056;
					short num3 = num;
					num = (short)419561472;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d(".簰尲䄴堶䬸吺儼帾潀B⩄⩆⑈⑊⍌౎ŐR答Ֆ㡘㽚㑜ぞⱠɢ୤٦๨๪l੮ὰݲ孴╶㑸⥺ㅼⱾ몀麗ﾐ몔ﮖ튠욢횤톦삨캪\udaac肮\uddb0\udab2횴튶ힸ좺\ud8bc첾럀ꫂꃄ냆돊곌ꋎ뷐", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005068 File Offset: 0x00003268
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1188626433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					if (connectionId != 2)
					{
						num = (short)1723465731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_149;
				case 3:
					num = (short)1997668352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)443285504;
					short num3 = num;
					num = (short)415629314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_38:
				if (connectionId == 1)
				{
					break;
				}
				num = (short)1827012609;
				if (num != 0)
				{
				}
				num = (short)467664900;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.dgrASTRORadioLicenses = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_9A:
			num = (short)1146633365;
			short num4 = num;
			num = (short)429931669;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_149:
				this.dgrPCRRadioLicenses = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
				return;
			default:
				num = (short)77004800;
				if (num != 0)
				{
				}
				this._contentLoaded = true;
				return;
			}
		}

		// Token: 0x04000015 RID: 21
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrASTRORadioLicenses;

		// Token: 0x04000016 RID: 22
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrPCRRadioLicenses;

		// Token: 0x04000017 RID: 23
		private bool _contentLoaded;
	}
}
