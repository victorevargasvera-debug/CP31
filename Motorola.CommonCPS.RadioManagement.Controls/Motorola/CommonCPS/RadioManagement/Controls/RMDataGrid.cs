using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interactivity;
using Infragistics.Windows;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Selection;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using Motorola.CommonCPS.Common.CommonUtility.ExcelFile;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200005A RID: 90
	public class RMDataGrid : global::Infragistics.Windows.DataPresenter.XamDataGrid, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000177 RID: 375 RVA: 0x00016AC0 File Offset: 0x00014CC0
		static RMDataGrid()
		{
			int a_ = 10;
			short num = (short)1733640050;
			short num2 = num;
			num = (short)1846361970;
			switch (num2 == num)
			{
			}
			num = (short)593952768;
			if (num != 0)
			{
			}
			num = (short)693829632;
			short num3 = num;
			num = (short)104660993;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AutoSaveCustomizationsCountProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톣튥잧囹춫\ud8ad햯솳억첷햹톻ힽ몿ꏁ냃꿅Ꟈ꓉뿋", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CustomizedSelectedCountProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톣향\udca7얩솫잭쪯ힱ킳\uddb7횹\ud9bb\uddbd뒿ꟁꃃ藅Ꟈ뿉ꋋ뫍", a_), typeof(int), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(-1));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CustomizedTotalCountProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톣향\udca7얩솫잭쪯ힱ킳ힷ캹\uddbb튽莿귁뇃ꣅ볇", a_), typeof(int), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(-1));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ToolbarVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮣즥쒧좩춫\udcad\udbb1잳\udfb5\udab7펹킻ힽ뒿믁", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.StatusbarVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킣장\udca7\udfa9\udfab청톯삱\udfb5쮷펹\udebbힽ겿ꯁ냃뿅", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.IsBindingViewCacheProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힣솧쒩좫잭\udeaf햱\udfb5\uddb7춹ﾻ\udfbdꎿ꫁ꇃ", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.e)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.GridToFileButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횣쾥첧ﺩ쎫\ud9af\udeb1톳춷캹좻톽꺿铁귃뗅ꇇ꣉ꗋꋍ맏ꛑ귓", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.USBButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udfa9\ud8ab\udaad\udfaf\udcb1\udfb5쮷펹\udebbힽ겿ꯁ냃뿅", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.FileToGridButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춣쪥춧ﺩ쎫슯\udbb1킳춷캹좻톽꺿铁귃뗅ꇇ꣉ꗋꋍ맏ꛑ귓", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CRUDToolBarVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺩ쎫솭\udcaf햳쒵펹쾻ힽꊿꯁꣃ꿅볇돉", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AdditionalButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삣슥솧\udea9얫솭\udeaf펱\ud8b3춷캹좻톽꺿铁귃뗅ꇇ꣉ꗋꋍ맏ꛑ귓", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.SearchVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("솣장\udaa7즩쒫\ud9af솱\uddb3풵톷횹햻쪽릿", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ProgressBarVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횣즥쾧\ud8a9즫\uddad쎯햳쒵펹쾻ힽꊿꯁꣃ꿅볇돉", a_), typeof(global::System.Windows.Visibility), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Hidden));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AddCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삣슥얩솫쎭톯\udcb1킳", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.d)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.DeleteCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("솣쪥춧\udea9즫\udfaf\udfb1\ud9b3ힵ횷\udeb9", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.c)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.EditCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삣쾥\udca7쎫쎭\uddaf펱\udab3튵", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.NewCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("솣톥얩솫쎭톯\udcb1킳", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ExportCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udca3횥잧\ud8a9\ud8ab\udfaf\udfb1\ud9b3ힵ횷\udeb9", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ImportCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즣횥잧\ud8a9\ud8ab\udfaf\udfb1\ud9b3ힵ횷\udeb9", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.FileToGridCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춣쪥춧ﺩ쎫슯\udbb1킳ힷힹ톻\udfbd꺿ꛁ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.GridToFileCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횣쾥첧ﺩ쎫\ud9af\udeb1톳ힷힹ톻\udfbd꺿ꛁ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AddConnectedDevicesCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삣슥얩슫삭햯톱삳펵\udcb7ﺹ\ud9bb좽ꦿꇁꇃ뗅诇ꗉꇋꏍ뇏병냓", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.SearchCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("솣장\udaa7즩쒫\udfaf\udfb1\ud9b3ힵ횷\udeb9", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CopyCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮣횥톧쎫쎭\uddaf펱\udab3튵", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.PreviewCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횣쎥\udea7쎩즫\ud9ad\uddb1\ud9b3\udbb5\ud9b7풹\ud8bb", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ChangeIdCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첣장욧충즫풯\udbb3\udbb5햷\udbb9튻\udabd", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ChangeValueCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첣장욧충즫톯\udeb1솳펵﮷햹톻펽ꆿ곁ꃃ", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.IsLoadingItemsFromViewCacheProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힣잧쮩좫잭\udeaf햱ﶳ습\uddb7ힹ쾻늿귁꧃郅ꇇ꿉믋跍뇏뇑볓돕", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), global::System.Windows.Controls.Control.MouseDoubleClickEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.OnRecordSelectorMouseDoubleClick));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), global::System.Windows.Controls.Control.MouseDoubleClickEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.OnDataRecordPresenterMouseDoubleClick));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000171B8 File Offset: 0x000153B8
		public RMDataGrid()
		{
			int a_ = 6;
			this._behaviors = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid>>();
			this.fieldLayoutPath = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.ApplicationData), global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펝쾟횡쮣풥잧용춫", a_), global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첝쪥솧쾩슫\udaad", a_), global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf9d", a_));
			base..ctor();
			new global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.b(this);
			this._addedRowSelector = new global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a(this);
			this._eventAggregator = new global::System.Lazy<global::Microsoft.Practices.Prism.Events.IEventAggregator>(new global::System.Func<global::Microsoft.Practices.Prism.Events.IEventAggregator>(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c.<>9.a));
			this.GridToFileCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.f), new global::System.Func<bool>(this.e));
			base.PreviewMouseWheel += this.ScrollViewer_PreviewMouseWheel;
			base.FieldChooserOpening += this.RMDataGrid_FieldChooserOpening;
			base.ExecutingCommand += this.RMDataGrid_ExecutingCommand;
			base.Loaded += this.RMDataGrid_Loaded;
			global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.RmDataGridBehavior value = new global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.RmDataGridBehavior();
			global::System.Windows.Interactivity.Interaction.GetBehaviors(this).Add(value);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000172DC File Offset: 0x000154DC
		private void DataGrid_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1823259047;
			short num2 = num;
			num = (short)901691815;
			string value;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1BD:
				value = null;
				goto IL_1C0;
			default:
				num = (short)1173946368;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				break;
			}
			int num3;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c__DisplayClass8_0 CS$<>8__locals1;
			global::Infragistics.Windows.DataPresenter.Record record2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox rmsearchBox;
			for (;;)
			{
				IL_55:
				global::Infragistics.Windows.DataPresenter.Record record;
				switch (num3)
				{
				case 0:
					this.a();
					num = (short)628228097;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					record = null;
					goto IL_1E5;
				case 3:
					goto IL_1BD;
				case 4:
					if (CS$<>8__locals1.a.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
					{
						num = (short)587857920;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
				{
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase records = base.Records;
					if (records == null)
					{
						num = (short)1966800898;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					record = records.FirstOrDefault(new global::System.Func<global::Infragistics.Windows.DataPresenter.Record, bool>(CS$<>8__locals1.b));
					goto IL_1E5;
				}
				case 6:
					goto IL_242;
				case 7:
					num = (short)1880555525;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return;
				case 9:
				{
					num = (short)1591083008;
					short num4 = num;
					if (record2 != null)
					{
						num = (short)1212219398;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 10:
					rmsearchBox = this.rmSearchBox;
					if (rmsearchBox == null)
					{
						num = (short)1670512643;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19E;
				case 11:
					if (CS$<>8__locals1.a.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						num = (short)7471111;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1591410692;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_8B;
				IL_1E5:
				record2 = record;
				num = (short)576978953;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_19E:
			value = rmsearchBox.Text;
			goto IL_1C0;
			IL_242:
			num = (short)1271070721;
			if (num != 0)
			{
			}
			this.a((global::Infragistics.Windows.DataPresenter.DataRecord)record2);
			return;
			IL_8B:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c__DisplayClass8_0();
			CS$<>8__locals1.a = A_1;
			base.UpdateLayout();
			num = (short)52690954;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
			IL_1C0:
			if (string.IsNullOrWhiteSpace(value))
			{
				num = (short)1657667592;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			num = (short)350486539;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00017580 File Offset: 0x00015780
		private void RMDataGrid_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)524025859;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_45;
				case 1:
					goto IL_C4;
				case 2:
					goto IL_45;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				global::Infragistics.Windows.Selection.ISelectionHost selectionHost = A_2 as global::Infragistics.Windows.Selection.ISelectionHost;
				if (selectionHost == null)
				{
					num = (short)1414201346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				selectionHost.ClearSnapshot();
				num = (short)127533056;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45:
				num = (short)453330554;
				short num3 = num;
				num = (short)1146963578;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)674103296;
					if (num != 0)
					{
					}
					base.UpdateLayout();
					base.Records.CollectionChanged += delegate(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
					{
						short num5 = (short)809828353;
						if (num5 != 0)
						{
						}
						num5 = (short)657043125;
						short num6 = num5;
						num5 = (short)317042357;
						switch (num6 == num5)
						{
						}
						num5 = (short)1965162496;
						short num7 = num5;
						num5 = (short)88670208;
						if (num5 != 0)
						{
						}
						global::Microsoft.Practices.Prism.Commands.DelegateCommand gridToFileCommand2 = this.GridToFileCommand;
						if (gridToFileCommand2 == null)
						{
							return;
						}
						gridToFileCommand2.RaiseCanExecuteChanged();
					};
					break;
				}
				num = (short)1252065281;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C4:
			num = (short)1089994753;
			if (num != 0)
			{
			}
			num = (short)822476800;
			short num4 = num;
			global::Microsoft.Practices.Prism.Commands.DelegateCommand gridToFileCommand = this.GridToFileCommand;
			if (gridToFileCommand == null)
			{
				return;
			}
			gridToFileCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000176F8 File Offset: 0x000158F8
		private void RMDataGrid_ExecutingCommand(object A_0, global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs A_1)
		{
			short num = (short)2092105735;
			int num2 = (int)((global::System.IntPtr)num);
			global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (xamDataGrid.SelectedItems.Fields.Count > 0)
					{
						num = (short)950796290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)1450471501;
					short num3 = num;
					num = (short)189296717;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_216;
					default:
						num = (short)461570048;
						if (num != 0)
						{
						}
						if (xamDataGrid.SelectedItems.Records.Count > 0)
						{
							num = (short)117702661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)704577536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a(xamDataGrid);
					num = (short)1936523268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1F5;
				case 4:
					goto IL_214;
				case 5:
					goto IL_1A0;
				case 6:
				{
					if (xamDataGrid.SelectedItems.Cells.Count > 0)
					{
						num = (short)1330839555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1426259969;
					if (num != 0)
					{
					}
					num = (short)1988624384;
					short num4 = num;
					num = (short)32374785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 8:
					A_1.Cancel = true;
					xamDataGrid = (A_0 as global::Infragistics.Windows.DataPresenter.XamDataGrid);
					num = (short)2043281414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (A_1.Command != global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Copy)
				{
					return;
				}
				num = (short)1535311880;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A0:
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.b(xamDataGrid);
			return;
			IL_1F5:
			goto IL_216;
			IL_214:
			return;
			IL_216:
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.c(xamDataGrid);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0001792C File Offset: 0x00015B2C
		private void RMDataGrid_FieldChooserOpening(object A_0, global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs A_1)
		{
			int a_ = 5;
			short num = (short)70451200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				for (;;)
				{
					IL_31:
					global::System.Predicate<global::Infragistics.Windows.DataPresenter.Field> predicate;
					global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser;
					switch (num2)
					{
					case 0:
						predicate = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c.<>9__11_0 = new global::System.Predicate<global::Infragistics.Windows.DataPresenter.Field>(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c.<>9.a));
						goto IL_1D0;
					case 1:
						goto IL_230;
					case 2:
					{
						num = (short)295487560;
						short num3 = num;
						num = (short)1556334664;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F9;
						default:
							num = (short)144113665;
							if (num != 0)
							{
							}
							num = (short)1733951488;
							if (num != 0)
							{
							}
							num = (short)1017315331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if ((predicate = global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c.<>9__11_0) == null)
						{
							num = (short)1007681536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D0;
					case 4:
					{
						A_1.ToolWindow.FlowDirection = (global::System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft ? global::System.Windows.FlowDirection.RightToLeft : global::System.Windows.FlowDirection.LeftToRight);
						global::System.Windows.Point point = ((global::Infragistics.Windows.DataPresenter.XamDataGrid)A_1.Source).PointToScreen(global::System.Windows.Input.Mouse.GetPosition(A_0 as global::Infragistics.Windows.DataPresenter.XamDataGrid));
						fieldChooser = A_1.FieldChooser;
						A_1.ToolWindow.Top = point.Y + 15.0;
						A_1.ToolWindow.Left = point.X + 5.0;
						goto IL_F9;
					}
					case 5:
						if (fieldChooser.FieldFilters.Count == 0)
						{
							num = (short)1920860162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					}
					goto IL_50;
					IL_F9:
					num = (short)818741253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D0:
					global::System.Predicate<global::Infragistics.Windows.DataPresenter.Field> filter = predicate;
					global::Infragistics.Windows.DataPresenter.FieldChooserFilter item = new global::Infragistics.Windows.DataPresenter.FieldChooserFilter(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf9c풠춢솤슦춨讪캬삮\uddb0욲\ud8b4\ud9b6쪸", a_), filter, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udf9c풠춢솤슦춨讪캬삮\uddb0욲\ud8b4\ud9b6쪸", a_));
					fieldChooser.FieldFilters.Add(item);
					fieldChooser.CurrentFieldGroup = A_1.FieldChooser.FieldGroups[1];
					num = (short)1488060417;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_230:
				IL_267:
				num = (short)1956511744;
				short num4 = num;
				return;
				IL_50:
				A_1.ToolWindow.Title = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_FieldChooser;
				num = (short)1753677828;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00017BC8 File Offset: 0x00015DC8
		private static void c(global::Infragistics.Windows.DataPresenter.XamDataGrid A_0)
		{
			int a_ = 12;
			short num = (short)1273167872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				string text;
				int num4;
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						num = (short)152418574;
						short num3 = num;
						num = (short)1873983758;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_47B;
						default:
							num = (short)852426752;
							if (num != 0)
							{
							}
							if (text != null)
							{
								num = (short)814284803;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
						try
						{
							num = (short)1650655239;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string text2;
									text = text2;
									num = (short)1211564048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Infragistics.Windows.DataPresenter.Cell cell;
									num4 = cell.Record.DataItemIndex;
									string text2;
									flag = global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a(cell, out text2);
									num = (short)487325710;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (flag)
									{
										num = (short)1299382282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
								{
									string text2;
									text = text + global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("궣", a_) + text2;
									num = (short)763232258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)649920521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_198;
									}
									continue;
								case 8:
								{
									string text2;
									global::Infragistics.Windows.DataPresenter.Cell cell;
									flag = global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a(cell, out text2);
									num = (short)996212748;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_3E9;
								case 10:
								{
									string text2;
									text = text + global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꦣ겥", a_) + text2;
									num = (short)571932673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Infragistics.Windows.DataPresenter.Cell cell;
									if (cell.Record.DataItemIndex == num4)
									{
										num = (short)423493640;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num4 = cell.Record.DataItemIndex;
									string text2;
									flag = global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a(cell, out text2);
									num = (short)1094254596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									if (flag)
									{
										num = (short)168558597;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 13:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)662372358;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.Cell cell = enumerator.Current;
									num = (short)14811151;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									if (flag)
									{
										num = (short)1457979392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 15:
									if (text == null)
									{
										num = (short)1722810371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)131727371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_23B:
								num = (short)630128653;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_198:
								goto IL_23B;
							}
							IL_3E9:
							goto IL_A7;
						}
						finally
						{
							num = (short)1005584384;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_420;
									}
									continue;
								case 1:
									goto IL_458;
								case 2:
									enumerator.Dispose();
									num = (short)1069744129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_420:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1346699266;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_458:;
						}
						goto IL_45B;
						IL_A7:
						num = (short)420085760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_494;
					case 3:
						goto IL_45B;
					}
					goto IL_47;
					IL_47B:
					num = (short)1424490498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45B:
					text += global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꦣ겥", a_);
					global::System.Windows.Clipboard.Clear();
					global::System.Windows.Clipboard.SetDataObject(text);
					goto IL_47B;
				}
				IL_494:
				num = (short)646512641;
				if (num != 0)
				{
				}
				return;
				IL_47:
				num = (short)1470955520;
				short num5 = num;
				text = null;
				num4 = 0;
				global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells = A_0.SelectedItems.Cells;
				flag = true;
				enumerator = cells.GetEnumerator();
				num = (short)1269432321;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000180B0 File Offset: 0x000162B0
		private static void b(global::Infragistics.Windows.DataPresenter.XamDataGrid A_0)
		{
			int a_ = 8;
			short num = (short)1367605248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				string text;
				bool flag;
				bool flag2;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (text != null)
						{
							num = (short)658046979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_561;
					case 1:
						try
						{
							num = (short)1552351235;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_43D;
								case 2:
									try
									{
										num = (short)174850057;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Infragistics.Windows.DataPresenter.Cell a_2;
											string text2;
											switch (num2)
											{
											case 0:
												if (flag)
												{
													num = (short)721616899;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 1:
												goto IL_3CC;
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)884342792;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												a_2 = enumerator.Current;
												num = (short)1668743178;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												text = text + global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꦟ", a_) + text2;
												num = (short)1152516108;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_26F;
											case 6:
												text += text2;
												num = (short)1872363533;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												num = (short)605487118;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												num = (short)756350977;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												switch (0)
												{
												case 0:
													goto IL_1FE;
												}
												continue;
											case 10:
												if (text != null)
												{
													num = (short)1534918663;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_26F;
											case 11:
												if (flag)
												{
													num = (short)243924998;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_34D;
											case 13:
												goto IL_34D;
											case 14:
												if (flag2)
												{
													num = (short)92733445;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												flag = global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a(a_2, out text2);
												num = (short)1940389888;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_22F:
											num = (short)1977548802;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1FE:
											goto IL_22F;
											IL_26F:
											flag = global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a(a_2, out text2);
											num = (short)177405963;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_34D:
											flag2 = false;
											num = (short)1775304708;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3CC:
										goto IL_126;
									}
									finally
									{
										num = (short)818479104;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_403;
												}
												continue;
											case 1:
												goto IL_43A;
											case 2:
												enumerator.Dispose();
												num = (short)791019521;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_403:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1946812418;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_43A:;
									}
									goto IL_43D;
									IL_126:
									flag2 = true;
									text += global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("궟ꢡ", a_);
									num = (short)104726529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_EE;
									}
									continue;
								case 4:
								{
									num = (short)572710245;
									short num3 = num;
									num = (short)209378661;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_48D;
									}
									break;
								}
								case 5:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1681260544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)enumerator2.Current;
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>)dataRecord.Cells).GetEnumerator();
									num = (short)184942594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_159:
								num = (short)1690828805;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EE:
								goto IL_159;
								IL_43D:
								num = (short)234160132;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_48D:
							num = (short)626262016;
							if (num != 0)
							{
							}
							goto IL_79;
						}
						finally
						{
							num = (short)1560018944;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4DA;
									}
									continue;
								case 1:
									goto IL_511;
								case 2:
									enumerator2.Dispose();
									num = (short)1108738049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4DA:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1465712642;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_511:;
						}
						goto IL_514;
						IL_79:
						num = (short)281280512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_537;
					case 3:
						goto IL_514;
					}
					goto IL_47;
					IL_514:
					global::System.Windows.Clipboard.Clear();
					global::System.Windows.Clipboard.SetDataObject(text);
					num = (short)593952770;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_537:
				num = (short)724238336;
				short num4 = num;
				IL_561:
				num = (short)1152253953;
				if (num != 0)
				{
				}
				return;
				IL_47:
				text = null;
				flag2 = true;
				global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records = A_0.SelectedItems.Records;
				flag = true;
				enumerator2 = records.GetEnumerator();
				num = (short)1598357505;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0001867C File Offset: 0x0001687C
		private static void a(global::Infragistics.Windows.DataPresenter.XamDataGrid A_0)
		{
			int a_ = 11;
			short num = (short)811794432;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				string text;
				bool flag;
				bool flag2;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator2;
				global::Infragistics.Windows.DataPresenter.SelectedFieldCollection fields;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (text != null)
						{
							num = (short)677838851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						num = (short)727711745;
						if (num != 0)
						{
						}
						try
						{
							num = (short)267321347;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_480;
								case 2:
									try
									{
										num = (short)1338638345;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Infragistics.Windows.DataPresenter.Field field;
											string text2;
											global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
											switch (num2)
											{
											case 0:
												if (flag)
												{
													num = (short)311885827;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 1:
												goto IL_40D;
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1531052040;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												field = enumerator.Current;
												num = (short)1171259402;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												text = text + global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꪢ", a_) + text2.ToString();
												num = (short)1155596300;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_298;
											case 6:
												text += text2;
												num = (short)905117709;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
												num = (short)462422030;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												num = (short)368246785;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												switch (0)
												{
												case 0:
													goto IL_223;
												}
												continue;
											case 10:
												if (text != null)
												{
													num = (short)1341456391;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_298;
											case 11:
												if (flag)
												{
													num = (short)852885510;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_382;
											case 13:
												goto IL_382;
											case 14:
												if (flag2)
												{
													num = (short)24772613;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												flag = global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a(dataRecord.Cells[field], out text2);
												num = (short)40173568;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_258:
											num = (short)2140602370;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_223:
											goto IL_258;
											IL_298:
											flag = global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.a(dataRecord.Cells[field], out text2);
											num = (short)1710096395;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_382:
											flag2 = false;
											num = (short)178651140;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_40D:
										goto IL_151;
									}
									finally
									{
										num = (short)1342111744;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_446;
												}
												continue;
											case 1:
												goto IL_47D;
											case 2:
												enumerator.Dispose();
												num = (short)1868365825;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_446:
											if (enumerator == null)
											{
												break;
											}
											num = (short)843186178;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_47D:;
									}
									goto IL_480;
									IL_151:
									flag2 = true;
									text += global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("꺢꾤", a_);
									num = (short)2022047745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_11F;
									}
									continue;
								case 4:
								{
									num = (short)246686651;
									short num3 = num;
									num = (short)1099703227;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_4CF;
									}
									break;
								}
								case 5:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1335558144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)enumerator2.Current;
									global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator = fields.GetEnumerator();
									num = (short)964820994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_17F:
								num = (short)1791623173;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11F:
								goto IL_17F;
								IL_480:
								num = (short)457506820;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4CF:
							num = (short)1925251072;
							if (num != 0)
							{
							}
							goto IL_A6;
						}
						finally
						{
							num = (short)1328939008;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_51B;
									}
									continue;
								case 1:
									goto IL_554;
								case 2:
									enumerator2.Dispose();
									num = (short)2085617665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_51B:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)409206786;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_554:;
						}
						goto IL_557;
						IL_A6:
						num = (short)564133888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						goto IL_557;
					}
					goto IL_48;
					IL_557:
					global::System.Windows.Clipboard.Clear();
					global::System.Windows.Clipboard.SetDataObject(text);
					num = (short)34144256;
					short num4 = num;
					num = (short)1874395138;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_48:
				text = null;
				flag2 = true;
				fields = A_0.SelectedItems.Fields;
				flag = true;
				enumerator2 = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)A_0.Records).GetEnumerator();
				num = (short)1759641601;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00018C64 File Offset: 0x00016E64
		private static bool a(global::Infragistics.Windows.DataPresenter.Cell A_0, out string A_1)
		{
			short num = (short)1378025472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (cellValuePresenter != null)
						{
							num = (short)1414660108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33C;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						return result;
					case 4:
						if (cellValuePresenter.Editor != null)
						{
							num = (short)526581766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33C;
					case 5:
						return result;
					case 6:
					{
						global::Infragistics.Windows.Editors.ValueEditor editor = cellValuePresenter.Editor;
						num = (short)215154703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Infragistics.Windows.Editors.ValueEditor editor;
						global::Infragistics.Windows.Editors.TextEditorBase textEditorBase = editor as global::Infragistics.Windows.Editors.TextEditorBase;
						num = (short)1258094603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Infragistics.Windows.Editors.TextEditorBase textEditorBase;
						object value = textEditorBase.Value;
						A_1 = ((value != null) ? value.ToString() : null);
						num = (short)403439617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return result;
					case 10:
					{
						num = (short)1163591680;
						short num3 = num;
						global::Infragistics.Windows.Editors.TextEditorBase textEditorBase;
						if (!(textEditorBase.ValueToDisplayTextConverter is global::Motorola.CommonCPS.RadioManagement.Controls.PasswordToTextConverter))
						{
							num = (short)2047475726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)1305673731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::Infragistics.Windows.Editors.TextEditorBase textEditorBase;
						if (textEditorBase.ValueToDisplayTextConverter is global::Motorola.CommonCPS.RadioManagement.Controls.PasswordWithCopyToTextConverter)
						{
							num = (short)9961488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1577713674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						num = (short)1695110784;
						short num4 = num;
						num = (short)1131697792;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
							num = (short)1801912320;
							if (num != 0)
							{
							}
							num = (short)675282948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
					{
						object value2 = A_0.Value;
						A_1 = ((value2 != null) ? value2.ToString() : null);
						num = (short)1376190469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Infragistics.Windows.Editors.TextEditorBase textEditorBase;
						A_1 = textEditorBase.DisplayText;
						num = (short)1977352194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						num = (short)1800339457;
						if (num != 0)
						{
						}
						global::Infragistics.Windows.Editors.ValueEditor editor;
						if (editor is global::Infragistics.Windows.Editors.TextEditorBase)
						{
							num = (short)1188167687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)88080397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)401080328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						object value3 = A_0.Value;
						A_1 = ((value3 != null) ? value3.ToString() : null);
						num = (short)2044788745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_77;
					IL_33C:
					num = (short)1260978193;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_77:
				result = true;
				A_1 = null;
				cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(A_0);
				num = (short)1597308928;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00018FFC File Offset: 0x000171FC
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int a_ = 10;
			short num = (short)1417740288;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Data.CollectionView collectionView;
				global::System.Windows.Data.CollectionView collectionView2;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 1:
					if (e.Property.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얣튥즧囹쎫\udbad슯톱톳ﾵ횷캹\ud9bb첽꺿ꏁꣃ", a_))
					{
						num = (short)1688010768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_458;
				case 2:
					return;
				case 3:
					((global::System.Windows.Data.ListCollectionView)e.OldValue).CommitEdit();
					((global::System.Windows.Data.ListCollectionView)e.OldValue).Filter = null;
					num = (short)498597893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_413;
				case 5:
					goto IL_1D2;
				case 6:
					goto IL_458;
				case 7:
					if (collectionView != null)
					{
						num = (short)1175978001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)1407123465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (e.OldValue is global::System.Windows.Data.ListCollectionView)
					{
						num = (short)229244931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D2;
				case 10:
					goto IL_155;
				case 11:
					num = (short)1102774296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_286;
				case 13:
					if (collectionView2 != null)
					{
						num = (short)489553930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_413;
				case 14:
					goto IL_458;
				case 15:
					if (e.OldValue != null)
					{
						num = (short)1767243784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D2;
				case 16:
					num = (short)2127233046;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					((global::System.Collections.Specialized.INotifyCollectionChanged)collectionView).CollectionChanged += this.DataGrid_CollectionChanged;
					num = (short)309854210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					this.rmSearchBox.Text = string.Empty;
					num = (short)136708111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1227292695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (e.Property.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얣튥즧囹쎫\udbad슯톱톳", a_))
					{
						num = (short)1053949963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
				{
					num = (short)2140594968;
					short num3 = num;
					num = (short)1610998552;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_155;
					default:
						num = (short)1928134656;
						if (num != 0)
						{
						}
						goto IL_286;
					}
					break;
				}
				case 22:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a addedRowSelector = this._addedRowSelector;
					if (addedRowSelector == null)
					{
						num = (short)1597177870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					addedRowSelector.e();
					num = (short)1421344774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 23:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a addedRowSelector2 = this._addedRowSelector;
					if (addedRowSelector2 == null)
					{
						num = (short)1940389889;
						if (num != 0)
						{
						}
						num = (short)1179713557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					addedRowSelector2.d();
					num = (short)469565452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 24:
					if (this.rmSearchBox != null)
					{
						num = (short)1426980882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D2;
				}
				IL_91:
				if (e.Property.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얣튥즧囹쎫\udbad슯톱톳ﾵ횷캹\ud9bb첽꺿ꏁꣃ", a_))
				{
					num = (short)1857749011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_286;
				IL_155:
				((global::System.Collections.Specialized.INotifyCollectionChanged)collectionView2).CollectionChanged -= this.DataGrid_CollectionChanged;
				num = (short)1151270912;
				short num4 = num;
				num = (short)1670578180;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D2:
				collectionView2 = (e.OldValue as global::System.Windows.Data.CollectionView);
				num = (short)54198285;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_286:
				base.OnPropertyChanged(e);
				num = (short)1640103937;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_413:
				collectionView = (e.NewValue as global::System.Windows.Data.CollectionView);
				num = (short)467664903;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_458:
				num = (short)1731592212;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000194F4 File Offset: 0x000176F4
		protected override void OnEditModeEnded(global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs args)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (!string.IsNullOrWhiteSpace(this.rmSearchBox.Text))
					{
						num2 = (short)1070268420;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					num2 = (short)2051342337;
					if (num2 != 0)
					{
					}
					if (this.rmSearchBox != null)
					{
						num2 = (short)1380909059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					num2 = (short)1369298395;
					short num3 = num2;
					num2 = (short)1494078939;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)121896960;
						if (num2 != 0)
						{
						}
						num2 = (short)1991704576;
						short num4 = num2;
						num2 = (short)604897281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 4:
					base.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CommitChangesToActiveRecord);
					this.a(args.Cell.Record);
					num2 = (short)1297154048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return;
			IL_24:
			base.OnEditModeEnded(args);
			num2 = (short)2072117250;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00019684 File Offset: 0x00017884
		private void ScrollViewer_PreviewMouseWheel(object A_0, global::System.Windows.Input.MouseWheelEventArgs A_1)
		{
			short num = (short)613548032;
			short num2 = num;
			num = (short)1503133697;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2074266918;
				short num4 = num;
				num = (short)2132528422;
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter rmsetPresenter;
				global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1543700480;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
						{
							num = (short)1773404162;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					case 2:
						goto IL_17B;
					case 3:
						return;
					case 4:
						num = (short)807534592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)757530625;
						if (num != 0)
						{
						}
						if (rmsetPresenter != null)
						{
							num = (short)509345795;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.Utility.a(rmdataGrid, (double)A_1.Delta);
						num = (short)1377107974;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_B3:
					if (!global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
					{
						num = (short)522059780;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_D8:
				rmdataGrid = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid);
				rmsetPresenter = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.FindVisualParent<global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter>(rmdataGrid);
				num = (short)1224802309;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_17B:
				goto IL_D8;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001983C File Offset: 0x00017A3C
		private void DeleteCommandCanExecuteRequested(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1135542273;
			if (num != 0)
			{
			}
			num = (short)1523328180;
			short num2 = num;
			num = (short)1338188980;
			switch (num2 == num)
			{
			default:
			{
				num = (short)479461376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)607125504;
			if (num != 0)
			{
			}
			global::System.Windows.Input.ICommand deleteCommand = this.DeleteCommand;
			A_1.CanExecute = (deleteCommand != null && deleteCommand.CanExecute(A_1.Parameter));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00019908 File Offset: 0x00017B08
		private void DeleteCommandExecuted(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)943991808;
			short num2 = num;
			num = (short)1845832704;
			switch (num2 == num)
			{
			}
			num = (short)604897280;
			short num3 = num;
			num = (short)1236926465;
			if (num != 0)
			{
			}
			num = (short)161087488;
			if (num != 0)
			{
			}
			global::System.Windows.Input.ICommand deleteCommand = this.DeleteCommand;
			if (deleteCommand == null)
			{
				return;
			}
			deleteCommand.Execute(A_1.Parameter);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000199CC File Offset: 0x00017BCC
		private void g()
		{
			int a_ = 14;
			short num = (short)2022782781;
			short num2 = num;
			num = (short)814692157;
			switch (num2 == num)
			{
			}
			num = (short)2140078080;
			short num3 = num;
			num = (short)985137153;
			if (num != 0)
			{
			}
			num = (short)1499332608;
			if (num != 0)
			{
			}
			this.OnPropertyChanged(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잧\udea9춫슭\udbb1잳\udfb5\udab7횹\ud9bbﶽ꾿럁꫃닅", a_));
			this.OnPropertyChanged(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춧쮩\udeab춭\ud8af\udbb3캵즹僚펽낿뛁뷃", a_));
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00019AA8 File Offset: 0x00017CA8
		public bool SearchBoxIsEmpty
		{
			get
			{
				short num = (short)1138576457;
				short num2 = num;
				num = (short)136727625;
				switch (num2 == num)
				{
				}
				num = (short)421920768;
				short num3 = num;
				num = (short)495058945;
				if (num != 0)
				{
				}
				num = (short)342622208;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox rmsearchBox = this.rmSearchBox;
				return string.IsNullOrEmpty((rmsearchBox != null) ? rmsearchBox.Text : null);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00019B6C File Offset: 0x00017D6C
		public int TotalVisibleCount
		{
			get
			{
				short num = (short)1928416111;
				short num2 = num;
				num = (short)660818799;
				switch (num2 == num)
				{
				}
				num = (short)431685632;
				short num3 = num;
				num = (short)2000289793;
				if (num != 0)
				{
				}
				num = (short)1116667904;
				if (num != 0)
				{
				}
				return base.Records.Count(new global::System.Func<global::Infragistics.Windows.DataPresenter.Record, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c.<>9.a));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00019C44 File Offset: 0x00017E44
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00019CFC File Offset: 0x00017EFC
		public bool AutoSaveCustomizations
		{
			get
			{
				short num = (short)1612143456;
				short num2 = num;
				num = (short)1887066976;
				switch (num2 == num)
				{
				}
				num = (short)1296236544;
				short num3 = num;
				num = (short)1622343681;
				if (num != 0)
				{
				}
				num = (short)1990656000;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AutoSaveCustomizationsCountProperty);
			}
			set
			{
				short num = (short)331455768;
				short num2 = num;
				num = (short)932289816;
				switch (num2 == num)
				{
				}
				num = (short)674562048;
				short num3 = num;
				num = (short)1672806401;
				if (num != 0)
				{
				}
				num = (short)1322647552;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AutoSaveCustomizationsCountProperty, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00019DB4 File Offset: 0x00017FB4
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00019E6C File Offset: 0x0001806C
		public int CustomizedSelectedCount
		{
			get
			{
				short num = (short)313590279;
				short num2 = num;
				num = (short)291832327;
				switch (num2 == num)
				{
				}
				num = (short)1729822720;
				short num3 = num;
				num = (short)1671692288;
				if (num != 0)
				{
				}
				num = (short)730136577;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CustomizedSelectedCountProperty);
			}
			set
			{
				short num = (short)705579435;
				short num2 = num;
				num = (short)735398315;
				switch (num2 == num)
				{
				}
				num = (short)463994880;
				short num3 = num;
				num = (short)601751553;
				if (num != 0)
				{
				}
				num = (short)538640384;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CustomizedSelectedCountProperty, value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00019F28 File Offset: 0x00018128
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00019FE0 File Offset: 0x000181E0
		public int CustomizedTotalCount
		{
			get
			{
				short num = (short)521891558;
				short num2 = num;
				num = (short)175206118;
				switch (num2 == num)
				{
				}
				num = (short)225443840;
				short num3 = num;
				num = (short)1809121281;
				if (num != 0)
				{
				}
				num = (short)89980928;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CustomizedTotalCountProperty);
			}
			set
			{
				short num = (short)1978918604;
				short num2 = num;
				num = (short)1653991116;
				switch (num2 == num)
				{
				}
				num = (short)549847040;
				short num3 = num;
				num = (short)1716322304;
				if (num != 0)
				{
				}
				num = (short)1034682369;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CustomizedTotalCountProperty, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0001A09C File Offset: 0x0001829C
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0001A158 File Offset: 0x00018358
		public global::System.Windows.Visibility ToolbarVisibility
		{
			get
			{
				short num = (short)133725143;
				short num2 = num;
				num = (short)1321368535;
				switch (num2 == num)
				{
				}
				num = (short)428474368;
				short num3 = num;
				num = (short)831389697;
				if (num != 0)
				{
				}
				num = (short)315752448;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ToolbarVisibilityProperty);
			}
			set
			{
				short num = (short)880541653;
				short num2 = num;
				num = (short)1709440981;
				switch (num2 == num)
				{
				}
				num = (short)819593216;
				short num3 = num;
				num = (short)2031943681;
				if (num != 0)
				{
				}
				num = (short)553713664;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ToolbarVisibilityProperty, value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0001A214 File Offset: 0x00018414
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0001A2D0 File Offset: 0x000184D0
		public global::System.Windows.Visibility StatusbarVisibility
		{
			get
			{
				short num = (short)520010248;
				short num2 = num;
				num = (short)277068296;
				switch (num2 == num)
				{
				}
				num = (short)659881984;
				short num3 = num;
				num = (short)161546241;
				if (num != 0)
				{
				}
				num = (short)1326120960;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.StatusbarVisibilityProperty);
			}
			set
			{
				short num = (short)308346881;
				if (num != 0)
				{
				}
				num = (short)1944866714;
				short num2 = num;
				num = (short)1343377306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803157504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)19791872;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.StatusbarVisibilityProperty, value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0001A388 File Offset: 0x00018588
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0001A444 File Offset: 0x00018644
		public bool IsBindingViewCache
		{
			get
			{
				short num = (short)402803795;
				short num2 = num;
				num = (short)817908819;
				switch (num2 == num)
				{
				}
				num = (short)1894645760;
				short num3 = num;
				num = (short)935788545;
				if (num != 0)
				{
				}
				num = (short)1160773632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.IsBindingViewCacheProperty);
			}
			set
			{
				short num = (short)1230616805;
				short num2 = num;
				num = (short)1779153125;
				switch (num2 == num)
				{
				}
				num = (short)156565504;
				short num3 = num;
				num = (short)2014380033;
				if (num != 0)
				{
				}
				num = (short)99549184;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.IsBindingViewCacheProperty, value);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001A500 File Offset: 0x00018700
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)805765121;
					if (num2 != 0)
					{
					}
					num2 = (short)1009622909;
					short num3 = num2;
					num2 = (short)1615241085;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)688390144;
						if (num2 != 0)
						{
						}
						rmdataGrid.Style = (global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("햚쒠첤슦\udea8첬첮\ud9b0횲횶춸\udaba\udabc춾ꣀꟂ雄돆냈ꟊ꣌", a_)] as global::System.Windows.Style);
						num2 = (short)1406533632;
						short num4 = num2;
						num2 = (short)840564738;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (!(bool)A_1.NewValue)
					{
						num2 = (short)884277248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_25;
			}
			return;
			IL_25:
			rmdataGrid = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)A_0;
			num2 = (short)1318518785;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0001A654 File Offset: 0x00018854
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0001A70C File Offset: 0x0001890C
		public global::System.Windows.Visibility GridToFileButtonVisibility
		{
			get
			{
				short num = (short)1904803840;
				short num2 = num;
				num = (short)439732723;
				short num3 = num;
				num = (short)1616562675;
				switch (num3 == num)
				{
				}
				num = (short)182452225;
				if (num != 0)
				{
				}
				num = (short)646316032;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.GridToFileButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1583349760;
				short num2 = num;
				num = (short)1144957619;
				short num3 = num;
				num = (short)1997646515;
				switch (num3 == num)
				{
				}
				num = (short)477364225;
				if (num != 0)
				{
				}
				num = (short)630784000;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.GridToFileButtonVisibilityProperty, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0001A7C4 File Offset: 0x000189C4
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0001A87C File Offset: 0x00018A7C
		public global::System.Windows.Visibility USBButtonVisibility
		{
			get
			{
				short num = (short)2132213760;
				short num2 = num;
				num = (short)1142980019;
				short num3 = num;
				num = (short)26770867;
				switch (num3 == num)
				{
				}
				num = (short)35520512;
				if (num != 0)
				{
				}
				num = (short)782630913;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.USBButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1421410304;
				short num2 = num;
				num = (short)1632108545;
				if (num != 0)
				{
				}
				num = (short)808953756;
				short num3 = num;
				num = (short)1857333148;
				switch (num3 == num)
				{
				}
				num = (short)1862270976;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.USBButtonVisibilityProperty, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0001A938 File Offset: 0x00018B38
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0001A9F4 File Offset: 0x00018BF4
		public global::System.Windows.Visibility FileToGridButtonVisibility
		{
			get
			{
				short num = (short)1458896896;
				short num2 = num;
				num = (short)570669963;
				short num3 = num;
				num = (short)1610791819;
				switch (num3 == num)
				{
				}
				num = (short)2059141121;
				if (num != 0)
				{
				}
				num = (short)1997668352;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.FileToGridButtonVisibilityProperty);
			}
			set
			{
				short num = (short)567541760;
				short num2 = num;
				num = (short)1350949711;
				short num3 = num;
				num = (short)1224072015;
				switch (num3 == num)
				{
				}
				num = (short)625737729;
				if (num != 0)
				{
				}
				num = (short)1657733120;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.FileToGridButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0001AAAC File Offset: 0x00018CAC
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0001AB68 File Offset: 0x00018D68
		public global::System.Windows.Visibility CRUDToolBarVisibility
		{
			get
			{
				short num = (short)908656640;
				short num2 = num;
				num = (short)467460757;
				short num3 = num;
				num = (short)1910301333;
				switch (num3 == num)
				{
				}
				num = (short)445710337;
				if (num != 0)
				{
				}
				num = (short)973602816;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CRUDToolBarVisibilityProperty);
			}
			set
			{
				short num = (short)1905917952;
				short num2 = num;
				num = (short)987449224;
				short num3 = num;
				num = (short)1987266440;
				switch (num3 == num)
				{
				}
				num = (short)1988558849;
				if (num != 0)
				{
				}
				num = (short)686555136;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CRUDToolBarVisibilityProperty, value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0001AC24 File Offset: 0x00018E24
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0001ACDC File Offset: 0x00018EDC
		public global::System.Windows.Visibility AdditionalButtonVisibility
		{
			get
			{
				short num = (short)967114752;
				short num2 = num;
				num = (short)1122943008;
				short num3 = num;
				num = (short)139575328;
				switch (num3 == num)
				{
				}
				num = (short)466419713;
				if (num != 0)
				{
				}
				num = (short)845479936;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AdditionalButtonVisibilityProperty);
			}
			set
			{
				short num = (short)546177024;
				short num2 = num;
				num = (short)1645240253;
				short num3 = num;
				num = (short)1811374013;
				switch (num3 == num)
				{
				}
				num = (short)234487808;
				if (num != 0)
				{
				}
				num = (short)1985544193;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AdditionalButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001AD94 File Offset: 0x00018F94
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0001AE4C File Offset: 0x0001904C
		public global::System.Windows.Visibility SearchVisibility
		{
			get
			{
				short num = (short)680919040;
				short num2 = num;
				num = (short)1004724016;
				short num3 = num;
				num = (short)1986846512;
				switch (num3 == num)
				{
				}
				num = (short)2000224257;
				if (num != 0)
				{
				}
				num = (short)1219821568;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.SearchVisibilityProperty);
			}
			set
			{
				short num = (short)1221722112;
				short num2 = num;
				num = (short)1465188353;
				if (num != 0)
				{
				}
				num = (short)236668868;
				short num3 = num;
				num = (short)350701508;
				switch (num3 == num)
				{
				}
				num = (short)1921581056;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.SearchVisibilityProperty, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001AF0C File Offset: 0x0001910C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0001AFC4 File Offset: 0x000191C4
		public global::System.Windows.Visibility ProgressBarVisibility
		{
			get
			{
				short num = (short)1234501632;
				short num2 = num;
				num = (short)1349261806;
				short num3 = num;
				num = (short)1048779246;
				switch (num3 == num)
				{
				}
				num = (short)1803419648;
				if (num != 0)
				{
				}
				num = (short)1331429377;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ProgressBarVisibilityProperty);
			}
			set
			{
				short num = (short)1235943424;
				short num2 = num;
				num = (short)1089073557;
				short num3 = num;
				num = (short)1914237333;
				switch (num3 == num)
				{
				}
				num = (short)1831337985;
				if (num != 0)
				{
				}
				num = (short)962592768;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ProgressBarVisibilityProperty, value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0001B080 File Offset: 0x00019280
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0001B138 File Offset: 0x00019338
		public global::System.Windows.Input.ICommand AddCommand
		{
			get
			{
				short num = (short)1712783360;
				short num2 = num;
				num = (short)1140444674;
				short num3 = num;
				num = (short)556060162;
				switch (num3 == num)
				{
				}
				num = (short)1478426625;
				if (num != 0)
				{
				}
				num = (short)100204544;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AddCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1950744576;
				short num2 = num;
				num = (short)1779737360;
				short num3 = num;
				num = (short)1640276752;
				switch (num3 == num)
				{
				}
				num = (short)952041472;
				if (num != 0)
				{
				}
				num = (short)724631553;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AddCommandProperty, value);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001B1EC File Offset: 0x000193EC
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1193869312;
			short num2 = num;
			num = (short)143467503;
			short num3 = num;
			num = (short)1066410991;
			switch (num3 == num)
			{
			}
			num = (short)935395329;
			if (num != 0)
			{
			}
			num = (short)70320128;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid;
			rmdataGrid.InputBindings.Add(new global::System.Windows.Input.KeyBinding((global::System.Windows.Input.ICommand)A_1.NewValue, global::System.Windows.Input.Key.N, global::System.Windows.Input.ModifierKeys.Control));
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0001B2BC File Offset: 0x000194BC
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0001B37C File Offset: 0x0001957C
		public global::System.Windows.Input.ICommand DeleteCommand
		{
			get
			{
				short num = (short)1864171520;
				short num2 = num;
				num = (short)991769239;
				short num3 = num;
				num = (short)1004679831;
				switch (num3 == num)
				{
				}
				num = (short)265093121;
				if (num != 0)
				{
				}
				num = (short)2031878144;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.DeleteCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1230635008;
				short num2 = num;
				num = (short)945827161;
				short num3 = num;
				num = (short)1751199065;
				switch (num3 == num)
				{
				}
				num = (short)858914817;
				if (num != 0)
				{
				}
				num = (short)708182016;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.DeleteCommandProperty, value);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001B430 File Offset: 0x00019630
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1337786368;
			short num2 = num;
			num = (short)1761266415;
			short num3 = num;
			num = (short)1132317423;
			switch (num3 == num)
			{
			}
			num = (short)1479475201;
			if (num != 0)
			{
			}
			num = (short)150142976;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid;
			rmdataGrid.InputBindings.Add(new global::System.Windows.Input.KeyBinding((global::System.Windows.Input.ICommand)A_1.NewValue, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Delete)));
			rmdataGrid.CommandBindings.Add(new global::System.Windows.Input.CommandBinding(global::System.Windows.Input.ApplicationCommands.Delete, new global::System.Windows.Input.ExecutedRoutedEventHandler(rmdataGrid.DeleteCommandExecuted), new global::System.Windows.Input.CanExecuteRoutedEventHandler(rmdataGrid.DeleteCommandCanExecuteRequested)));
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0001B534 File Offset: 0x00019734
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0001B5F0 File Offset: 0x000197F0
		public global::System.Windows.Input.ICommand EditCommand
		{
			get
			{
				short num = (short)1699676160;
				short num2 = num;
				num = (short)993776271;
				short num3 = num;
				num = (short)1781518991;
				switch (num3 == num)
				{
				}
				num = (short)380960769;
				if (num != 0)
				{
				}
				num = (short)2068709376;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.EditCommandProperty) as global::System.Windows.Input.ICommand;
			}
			set
			{
				short num = (short)1804140544;
				short num2 = num;
				num = (short)196299253;
				short num3 = num;
				num = (short)61295093;
				switch (num3 == num)
				{
				}
				num = (short)1238761472;
				if (num != 0)
				{
				}
				num = (short)251265025;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.EditCommandProperty, value);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001B6A4 File Offset: 0x000198A4
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)529203200;
			short num2 = num;
			num = (short)426060770;
			short num3 = num;
			num = (short)108735458;
			switch (num3 == num)
			{
			}
			num = (short)2017591296;
			if (num != 0)
			{
			}
			num = (short)789381121;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid;
			rmdataGrid.InputBindings.Add(new global::System.Windows.Input.KeyBinding((global::System.Windows.Input.ICommand)A_1.NewValue, global::System.Windows.Input.Key.E, global::System.Windows.Input.ModifierKeys.Control));
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0001B774 File Offset: 0x00019974
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0001B82C File Offset: 0x00019A2C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand NewCommand
		{
			get
			{
				short num = (short)1546518528;
				short num2 = num;
				num = (short)423936645;
				short num3 = num;
				num = (short)384811653;
				switch (num3 == num)
				{
				}
				num = (short)110624769;
				if (num != 0)
				{
				}
				num = (short)555220992;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.NewCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)298778624;
				short num2 = num;
				num = (short)2011017203;
				short num3 = num;
				num = (short)275886067;
				switch (num3 == num)
				{
				}
				num = (short)682164224;
				if (num != 0)
				{
				}
				num = (short)881655809;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.NewCommandProperty, value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0001B8E0 File Offset: 0x00019AE0
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0001B99C File Offset: 0x00019B9C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportCommand
		{
			get
			{
				short num = (short)1711603712;
				short num2 = num;
				num = (short)945803404;
				short num3 = num;
				num = (short)277598348;
				switch (num3 == num)
				{
				}
				num = (short)311361537;
				if (num != 0)
				{
				}
				num = (short)258670592;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ExportCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)1181155328;
				short num2 = num;
				num = (short)216662017;
				if (num != 0)
				{
				}
				num = (short)814142170;
				short num3 = num;
				num = (short)94819034;
				switch (num3 == num)
				{
				}
				num = (short)1308098560;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ExportCommandProperty, value);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001BA4C File Offset: 0x00019C4C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1745341090;
			short num2 = num;
			num = (short)936757922;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1202716672;
				short num3 = num;
				break;
			}
			}
			num = (short)625213441;
			if (num != 0)
			{
			}
			num = (short)852688896;
			if (num != 0)
			{
			}
			if (A_1.NewValue != null)
			{
				global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid;
				rmdataGrid.InputBindings.Add(new global::System.Windows.Input.KeyBinding((global::System.Windows.Input.ICommand)A_1.NewValue, global::System.Windows.Input.Key.X, global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Shift));
				return;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0001BB28 File Offset: 0x00019D28
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0001BBE0 File Offset: 0x00019DE0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ImportCommand
		{
			get
			{
				short num = (short)92143616;
				short num2 = num;
				num = (short)1896181880;
				short num3 = num;
				num = (short)464154744;
				switch (num3 == num)
				{
				}
				num = (short)441647105;
				if (num != 0)
				{
				}
				num = (short)6619136;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ImportCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)303104000;
				short num2 = num;
				num = (short)66391616;
				short num3 = num;
				num = (short)454168128;
				switch (num3 == num)
				{
				}
				num = (short)1366360065;
				if (num != 0)
				{
				}
				num = (short)628228096;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ImportCommandProperty, value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0001BC94 File Offset: 0x00019E94
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0001BD4C File Offset: 0x00019F4C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand FileToGridCommand
		{
			get
			{
				short num = (short)1347092480;
				short num2 = num;
				num = (short)1591241075;
				short num3 = num;
				num = (short)248408435;
				switch (num3 == num)
				{
				}
				num = (short)1772748800;
				if (num != 0)
				{
				}
				num = (short)1764950017;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.FileToGridCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)2146500608;
				short num2 = num;
				num = (short)1893962001;
				short num3 = num;
				num = (short)1457754385;
				switch (num3 == num)
				{
				}
				num = (short)1846083584;
				if (num != 0)
				{
				}
				num = (short)1070465025;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.FileToGridCommandProperty, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0001BE00 File Offset: 0x0001A000
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand GridToFileCommand
		{
			get
			{
				short num = (short)181338112;
				short num2 = num;
				num = (short)115736577;
				if (num != 0)
				{
				}
				num = (short)643066582;
				short num3 = num;
				num = (short)1874815702;
				switch (num3 == num)
				{
				}
				num = (short)1410203648;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.GridToFileCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)543293440;
				short num2 = num;
				num = (short)158578435;
				short num3 = num;
				num = (short)1337177859;
				switch (num3 == num)
				{
				}
				num = (short)707330048;
				if (num != 0)
				{
				}
				num = (short)844365825;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.GridToFileCommandProperty, value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0001BF6C File Offset: 0x0001A16C
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0001C028 File Offset: 0x0001A228
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AddConnectedDevicesCommand
		{
			get
			{
				short num = (short)1658781696;
				short num2 = num;
				num = (short)65994753;
				if (num != 0)
				{
				}
				num = (short)1413355812;
				short num3 = num;
				num = (short)1411193124;
				switch (num3 == num)
				{
				}
				num = (short)1326776320;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AddConnectedDevicesCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)1530462208;
				short num2 = num;
				num = (short)1997941544;
				short num3 = num;
				num = (short)1208691496;
				switch (num3 == num)
				{
				}
				num = (short)1789132801;
				if (num != 0)
				{
				}
				num = (short)376766464;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.AddConnectedDevicesCommandProperty, value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0001C19C File Offset: 0x0001A39C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> SearchCommand
		{
			get
			{
				short num = (short)1856372736;
				short num2 = num;
				num = (short)1831882611;
				short num3 = num;
				num = (short)1764380531;
				switch (num3 == num)
				{
				}
				num = (short)1817903105;
				if (num != 0)
				{
				}
				num = (short)1068761088;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.SearchCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>;
			}
			set
			{
				short num = (short)907739136;
				short num2 = num;
				num = (short)508329240;
				short num3 = num;
				num = (short)1402436888;
				switch (num3 == num)
				{
				}
				num = (short)1363869696;
				if (num != 0)
				{
				}
				num = (short)108199937;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.SearchCommandProperty, value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0001C250 File Offset: 0x0001A450
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0001C308 File Offset: 0x0001A508
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CopyCommand
		{
			get
			{
				short num = (short)1083441152;
				short num2 = num;
				num = (short)196767861;
				short num3 = num;
				num = (short)1674211445;
				switch (num3 == num)
				{
				}
				num = (short)780140544;
				if (num != 0)
				{
				}
				num = (short)378863617;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CopyCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)85327872;
				short num2 = num;
				num = (short)1572494318;
				short num3 = num;
				num = (short)383343598;
				switch (num3 == num)
				{
				}
				num = (short)112197633;
				if (num != 0)
				{
				}
				num = (short)1219756032;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.CopyCommandProperty, value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0001C3BC File Offset: 0x0001A5BC
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0001C478 File Offset: 0x0001A678
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand PreviewCommand
		{
			get
			{
				short num = (short)892469248;
				short num2 = num;
				num = (short)619669939;
				short num3 = num;
				num = (short)1882941875;
				switch (num3 == num)
				{
				}
				num = (short)215547905;
				if (num != 0)
				{
				}
				num = (short)1749680128;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.PreviewCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)831586304;
				short num2 = num;
				num = (short)1980433383;
				short num3 = num;
				num = (short)1843332071;
				switch (num3 == num)
				{
				}
				num = (short)53673985;
				if (num != 0)
				{
				}
				num = (short)578027520;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.PreviewCommandProperty, value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0001C52C File Offset: 0x0001A72C
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ChangeIdCommand
		{
			get
			{
				short num = (short)347249471;
				short num2 = num;
				num = (short)953129791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1728774144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968097793;
				if (num != 0)
				{
				}
				num = (short)961019904;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ChangeIdCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)1979202906;
				short num2 = num;
				num = (short)1924742490;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628817920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)793247744;
				if (num != 0)
				{
				}
				num = (short)1875836929;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ChangeIdCommandProperty, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0001C698 File Offset: 0x0001A898
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0001C754 File Offset: 0x0001A954
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ChangeValueCommand
		{
			get
			{
				short num = (short)436347606;
				short num2 = num;
				num = (short)342041302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72482816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1298726913;
				if (num != 0)
				{
				}
				num = (short)1835466752;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ChangeValueCommandProperty) as global::Microsoft.Practices.Prism.Commands.DelegateCommand;
			}
			set
			{
				short num = (short)1758921190;
				short num2 = num;
				num = (short)755040742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)32309248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)437256193;
				if (num != 0)
				{
				}
				num = (short)113442816;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.ChangeValueCommandProperty, value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0001C808 File Offset: 0x0001AA08
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		public bool IsLoadingItemsFromViewCache
		{
			get
			{
				short num = (short)903566583;
				short num2 = num;
				num = (short)21452023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)993460224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1130561537;
				if (num != 0)
				{
				}
				num = (short)651624448;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.IsLoadingItemsFromViewCacheProperty);
			}
			set
			{
				short num = (short)1512240439;
				short num2 = num;
				num = (short)968029495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)865665024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)117964801;
				if (num != 0)
				{
				}
				num = (short)1918566400;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.IsLoadingItemsFromViewCacheProperty, value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060001C6 RID: 454 RVA: 0x0001C97C File Offset: 0x0001AB7C
		// (remove) Token: 0x060001C7 RID: 455 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
		public event global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> DataRecordPresenterMouseDoubleClicked
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
						{
							num2 = (short)424193493;
							short num3 = num2;
							num2 = (short)2037296597;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)871038976;
								if (num2 != 0)
								{
								}
								num2 = (short)1207173121;
								if (num2 != 0)
								{
								}
								if (eventHandler == eventHandler2)
								{
									num2 = (short)448659456;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_3A;
							}
							break;
						}
						case 2:
							goto IL_3A;
						}
						break;
						IL_3A:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> value2 = (global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs>>(ref this.DataRecordPresenterMouseDoubleClicked, value2, eventHandler2);
						num2 = (short)1521090560;
						short num4 = num2;
						num2 = (short)2003173377;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.DataRecordPresenterMouseDoubleClicked;
					num2 = (short)1442250754;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
							goto IL_100;
						case 1:
						{
							num2 = (short)1069571269;
							short num3 = num2;
							num2 = (short)1030053061;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)2128936960;
								if (num2 != 0)
								{
								}
								if (eventHandler == eventHandler2)
								{
									num2 = (short)41484288;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_3A;
							}
							break;
						}
						case 2:
							goto IL_3A;
						}
						break;
						IL_3A:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> value2 = (global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs>>(ref this.DataRecordPresenterMouseDoubleClicked, value2, eventHandler2);
						num2 = (short)506331136;
						short num4 = num2;
						num2 = (short)156958721;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.DataRecordPresenterMouseDoubleClicked;
					num2 = (short)221380610;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_100:
				num2 = (short)1389101057;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001CBEC File Offset: 0x0001ADEC
		private void f()
		{
			int a_ = 17;
			short num = (short)2106654720;
			short num2 = num;
			num = (short)1272578048;
			switch (num)
			{
			default:
			{
				num = (short)416874498;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_814;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					}
					IL_83:
					if (base.Records.Count == 0)
					{
						num = (short)1553858561;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						string text = string.Empty;
						num = (short)1175977984;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_814:
				num = (short)1169031169;
				if (num != 0)
				{
				}
				try
				{
					switch (0)
					{
					case 0:
						goto IL_14E;
					}
					int num4;
					global::System.Collections.Generic.List<string> list3;
					for (;;)
					{
						IL_B7:
						int num6;
						switch (num3)
						{
						case 0:
							num = (short)49741859;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_233;
						case 2:
							num = (short)8912901;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Infragistics.Windows.DataPresenter.Field field;
							if (!string.IsNullOrEmpty(field.Label.ToString()))
							{
								num = (short)36634637;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19C;
						}
						case 4:
							num = (short)831520802;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (!string.IsNullOrEmpty(base.DefaultFieldLayout.Fields[num4].Label.ToString()))
							{
								num = (short)791674911;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BF;
						case 6:
							goto IL_36B;
						case 7:
							if (base.DefaultFieldLayout.Fields[num4].Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)208797722;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BF;
						case 8:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMSaveFileDialog rmsaveFileDialog;
							string text = rmsaveFileDialog.FileName;
							num = (short)2062286870;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::Infragistics.Windows.DataPresenter.Field field;
							if (field.Visibility == global::System.Windows.Visibility.Visible)
							{
								goto IL_2BD;
							}
							goto IL_19C;
						}
						case 10:
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>();
							int num5 = 0;
							num = (short)1215561756;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_424;
						case 12:
							goto IL_786;
						case 13:
						{
							global::Infragistics.Windows.DataPresenter.Field field;
							int num5;
							global::Infragistics.Windows.DataPresenter.Cell a_2 = (base.Records[num5] as global::Infragistics.Windows.DataPresenter.DataRecord).Cells[field];
							string item = this.a(field, a_2);
							global::System.Collections.Generic.List<string> list2;
							list2.Add(item);
							num = (short)516096020;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							goto IL_673;
						case 15:
							goto IL_1BF;
						case 16:
							goto IL_673;
						case 17:
							num = (short)1744961539;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_76C;
						case 19:
							goto IL_233;
						case 20:
							goto IL_19C;
						case 21:
						{
							if (num6 >= base.DefaultFieldLayout.Fields.Count)
							{
								num = (short)230031393;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.Field field = base.DefaultFieldLayout.Fields[num6];
							num = (short)676593673;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							string text;
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)926351360;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_76C;
						}
						case 23:
							goto IL_36B;
						case 24:
						{
							string text;
							global::Motorola.CommonCPS.RadioManagement.Controls.RMSaveFileDialog rmsaveFileDialog = new global::Motorola.CommonCPS.RadioManagement.Controls.RMSaveFileDialog
							{
								FileName = text,
								Filter = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Filter_CSV_Excel,
								Title = global::Motorola.CommonCPS.ResourceRepository.Resources.ActionBar_Classical_Tooltip_Export
							};
							num = (short)443482141;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							if (base.DefaultFieldLayout.Fields[num4].Label != null)
							{
								num = (short)1954676738;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BF;
						case 26:
							num = (short)1244200985;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
						{
							int num5;
							if (num5 >= base.Records.Count)
							{
								num = (short)338952216;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
							num6 = 0;
							num = (short)600244240;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
							goto IL_424;
						case 29:
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMSaveFileDialog rmsaveFileDialog;
							if (rmsaveFileDialog.ShowDialog())
							{
								num = (short)1897529352;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_76C;
						}
						case 30:
						{
							string text;
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list;
							this.b(text, list3, list);
							num = (short)1070661633;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 31:
							list3.Add(base.DefaultFieldLayout.Fields[num4].Label.ToString());
							num = (short)77922319;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							if (num4 >= base.DefaultFieldLayout.Fields.Count)
							{
								num = (short)1888681994;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1595211783;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
						{
							num = (short)170497560;
							short num7 = num;
							num = (short)2085852696;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2BD;
							default:
							{
								num = (short)1956708352;
								if (num != 0)
								{
								}
								global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list;
								global::System.Collections.Generic.List<string> list2;
								list.Add(list2);
								int num5;
								num5++;
								num = (short)64159755;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 34:
						{
							global::Infragistics.Windows.DataPresenter.Field field;
							if (field.Label != null)
							{
								num = (short)1118175249;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_19C;
						}
						case 35:
						{
							string text;
							if (text.EndsWith(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("螨좪\udeac\ud9ae", a_), global::System.StringComparison.CurrentCulture))
							{
								num = (short)864813086;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list;
							this.a(text, list3, list);
							num = (short)1374093331;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_14E;
						IL_19C:
						num6++;
						num = (short)794689550;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BF:
						num4++;
						num = (short)752877574;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_233:
						global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification payload = new global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification
						{
							Content = global::Motorola.CommonCPS.ResourceRepository.Resources.Message_Export_successful,
							Title = global::Motorola.CommonCPS.ResourceRepository.Resources.ExportDevicesAction_Title
						};
						this._eventAggregator.Value.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ShowNotificationDialogRequestedEvent>().Publish(payload);
						num = (short)1181941778;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2BD:
						num = (short)1840644100;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_36B:
						num = (short)1319960608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_424:
						num = (short)186646555;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_673:
						num = (short)974323733;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_76C:
						num = (short)901447692;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_786:
					return;
					IL_14E:
					list3 = new global::System.Collections.Generic.List<string>();
					num4 = 0;
					num = (short)409862167;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_B7;
				}
				catch (global::System.IO.IOException)
				{
					string text;
					string messageBoxText = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.The_Process_Cannot_Access_File, text);
					global::System.Windows.MessageBox.Show(messageBoxText, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Error, global::System.Windows.MessageBoxButton.OK);
					return;
				}
				catch (global::System.UnauthorizedAccessException)
				{
					string text;
					string messageBoxText2 = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportFile_Access_Error, text);
					global::System.Windows.MessageBox.Show(messageBoxText2, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Error, global::System.Windows.MessageBoxButton.OK);
					return;
				}
				catch (global::System.Exception ex)
				{
					global::System.Windows.MessageBox.Show(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportGrid_Fail + ex.Message, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Error, global::System.Windows.MessageBoxButton.OK);
					return;
				}
				return;
			}
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001D488 File Offset: 0x0001B688
		private bool e()
		{
			short num = (short)1852906754;
			short num2 = num;
			num = (short)730012930;
			switch (num2 == num)
			{
			default:
			{
				num = (short)560791552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2050424832;
			if (num != 0)
			{
			}
			num = (short)1417609217;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001D534 File Offset: 0x0001B734
		protected override void OnInitialized(global::System.EventArgs e)
		{
			int a_ = 12;
			short num = (short)33423360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				for (;;)
				{
					IL_30:
					int num3;
					switch (num2)
					{
					case 0:
					{
						string[] array;
						global::System.Version v;
						bool flag = global::System.Version.TryParse(array[1], out v);
						num = (short)2133065734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Text.RegularExpressions.Match match;
						string[] array = match.Groups[1].Value.Split(new char[]
						{
							':'
						});
						num = (short)510001161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1780744193;
						if (num != 0)
						{
						}
						if (num3 >= base.FieldLayouts[0].Fields.Count)
						{
							num = (short)257228822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.Field field = base.FieldLayouts[0].Fields[num3];
						goto IL_458;
					}
					case 3:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						if (field.Tag != null)
						{
							num = (short)773652496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 4:
						this.customizationsFile = global::System.IO.Path.Combine(this.fieldLayoutPath, base.Name + global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("誣\udea5얧용", a_));
						this.c();
						base.FieldPositionChanged += delegate(object A_0, global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs A_1)
						{
							short num6 = (short)1945890440;
							short num7 = num6;
							num6 = (short)1682370184;
							switch (num7 == num6)
							{
							}
							num6 = (short)531890176;
							if (num6 != 0)
							{
							}
							num6 = (short)886308864;
							short num8 = num6;
							num6 = (short)378273793;
							if (num6 != 0)
							{
							}
							this.d();
						};
						num = (short)1933639701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						if (!(field.Tag.ToString() == string.Empty))
						{
							num = (short)1651769362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 6:
					{
						bool flag;
						if (flag)
						{
							num = (short)422314007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 7:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						base.FieldLayouts[0].Fields.Remove(field);
						num3--;
						num = (short)2079588365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Text.RegularExpressions.Match match;
						if (match.Success)
						{
							num = (short)1987313665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 9:
					{
						string[] array;
						if (array.Length == 2)
						{
							num = (short)761528334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 10:
					{
						string[] array;
						if (array[0].ToUpperInvariant() == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺧﺫﶭ羚ﶱ荒", a_))
						{
							num = (short)739442688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 11:
						if (this.AutoSaveCustomizations)
						{
							num = (short)774832132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					case 12:
						goto IL_25E;
					case 13:
						goto IL_354;
					case 14:
						num = (short)1442381834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::System.Version v;
						global::System.Version version;
						if (version < v)
						{
							num = (short)734986247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_354;
					}
					case 16:
						num = (short)857145349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (base.FieldLayouts.Count == 0)
						{
							num = (short)1995505684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = 0;
						num = (short)513212428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						global::System.Text.RegularExpressions.Match match = global::System.Text.RegularExpressions.Regex.Match(field.Tag.ToString(), global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﶥ肧銷鎹", a_));
						num = (short)640811016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_25E;
					case 20:
						return;
					case 21:
						goto IL_1C4;
					case 22:
						goto IL_2D1;
					case 23:
					{
						global::System.Version version = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
						num = (short)472317967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_97;
					IL_1C4:
					num = (short)1846345745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25E:
					num = (short)399441922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_354:
					num3++;
					num = (short)2106269434;
					short num4 = num;
					num = (short)850992890;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_458:
						num = (short)1956184067;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)221446144;
						if (num != 0)
						{
						}
						num = (short)1378484224;
						short num5 = num;
						num = (short)572850195;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_2D1:
				base.MouseRightButtonUp += global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.OnMouseRightButtonUp;
				return;
				IL_97:
				base.OnInitialized(e);
				num = (short)1004339211;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001DA9C File Offset: 0x0001BC9C
		public void HideColumn(string colName)
		{
			short num;
			try
			{
				num = (short)1411837429;
				short num2 = num;
				num = (short)700182005;
				switch (num2 == num)
				{
				}
				num = (short)2032926720;
				if (num != 0)
				{
				}
				global::Infragistics.Windows.DataPresenter.Field field = base.FieldLayouts[0].Fields[colName];
				field.Visibility = global::System.Windows.Visibility.Collapsed;
			}
			catch (global::System.Exception ex)
			{
			}
			num = (short)2012151809;
			if (num != 0)
			{
			}
			num = (short)178651136;
			short num3 = num;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001DB7C File Offset: 0x0001BD7C
		public void RemoveColumn(string colName)
		{
			short num;
			try
			{
				num = (short)471780589;
				short num2 = num;
				num = (short)1179700461;
				switch (num2 == num)
				{
				}
				num = (short)1420165121;
				if (num != 0)
				{
				}
				num = (short)368705536;
				if (num != 0)
				{
				}
				global::Infragistics.Windows.DataPresenter.Field item = base.FieldLayouts[0].Fields[colName];
				base.FieldLayouts[0].Fields.Remove(item);
			}
			catch (global::System.Exception ex)
			{
			}
			num = (short)1084882944;
			short num3 = num;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		public void ShowColumn(string colName)
		{
			short num;
			try
			{
				num = (short)576684030;
				short num2 = num;
				num = (short)364871678;
				switch (num2 == num)
				{
				}
				num = (short)1795358720;
				if (num != 0)
				{
				}
				global::Infragistics.Windows.DataPresenter.Field field = base.FieldLayouts[0].Fields[colName];
				field.Visibility = global::System.Windows.Visibility.Visible;
			}
			catch (global::System.Exception ex)
			{
			}
			num = (short)1205141505;
			if (num != 0)
			{
			}
			num = (short)2144468992;
			short num3 = num;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001DD4C File Offset: 0x0001BF4C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetGridInfo()
		{
			short num = (short)1583284224;
			switch (num)
			{
			default:
			{
				num = (short)208797697;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo rmdataGridInfo = new global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo();
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> enumerator = base.FieldLayouts[0].Fields.GetEnumerator();
				try
				{
					num = (short)1044119556;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_136;
						case 2:
							num = (short)2063466497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1166540802;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.Field field = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo info = new global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo(field.Name, field.Label.ToString(), field.Visibility == global::System.Windows.Visibility.Visible);
							rmdataGridInfo.AddColumnInfo(info);
							num = (short)367788032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_9F;
							}
							continue;
						}
						IL_E6:
						num = (short)1133772803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9F:
						goto IL_E6;
					}
					IL_136:;
				}
				finally
				{
					num = (short)289734658;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1F1;
						case 1:
						{
							num = (short)2014871248;
							short num3 = num;
							num = (short)1657503440;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)528613376;
								if (num != 0)
								{
								}
								break;
							}
							enumerator.Dispose();
							num = (short)1631256576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_16D;
							}
							continue;
						}
						IL_16D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1966866433;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1F1:;
				}
				num = (short)42270720;
				short num4 = num;
				return rmdataGridInfo;
			}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001DF88 File Offset: 0x0001C188
		public global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid> GetBehavior(global::System.Type behaviorType)
		{
			short num = (short)854589440;
			short num2 = num;
			num = (short)1125515265;
			if (num != 0)
			{
			}
			num = (short)237550382;
			short num3 = num;
			num = (short)410237742;
			switch (num3 == num)
			{
			}
			num = (short)388890624;
			if (num != 0)
			{
			}
			global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid> result;
			this._behaviors.TryGetValue(behaviorType, out result);
			return result;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001E044 File Offset: 0x0001C244
		public void RegisterBehavior(global::System.Type behaviorType, global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid> behaviorInstance)
		{
			short num = (short)831782912;
			short num2 = num;
			num = (short)1875703720;
			short num3 = num;
			num = (short)1300559784;
			switch (num3 == num)
			{
			}
			num = (short)301924352;
			if (num != 0)
			{
			}
			num = (short)2143420417;
			if (num != 0)
			{
			}
			this._behaviors[behaviorType] = behaviorInstance;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		private void d()
		{
			short num = (short)2081554432;
			short num2 = num;
			num = (short)1315760894;
			short num3 = num;
			num = (short)1573579518;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2045771777;
				if (num != 0)
				{
				}
				num = (short)1646067712;
				if (num != 0)
				{
				}
				global::System.IO.FileStream fileStream = null;
				try
				{
					try
					{
						fileStream = new global::System.IO.FileStream(this.customizationsFile, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
						goto IL_14E;
					}
					catch (global::System.Exception)
					{
						if (fileStream != null)
						{
							fileStream.Close();
						}
						if (!global::System.IO.Directory.Exists(this.fieldLayoutPath))
						{
							global::System.IO.Directory.CreateDirectory(this.fieldLayoutPath);
						}
						if (global::System.IO.File.Exists(this.customizationsFile))
						{
							global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(this.customizationsFile);
							fileInfo.IsReadOnly = false;
						}
						fileStream = new global::System.IO.FileStream(this.customizationsFile, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
						goto IL_14E;
					}
					goto IL_112;
					int num4;
					for (;;)
					{
						IL_11C:
						switch (num4)
						{
						case 0:
							if (fileStream != null)
							{
								num = (short)2136080386;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_182;
						case 1:
							goto IL_182;
						case 2:
							goto IL_180;
						case 3:
							goto IL_198;
						}
						goto IL_132;
						IL_182:
						num = (short)1185939459;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_180:
					goto IL_112;
					IL_198:
					break;
					IL_112:
					switch (0)
					{
					case 0:
						goto IL_132;
					}
					goto IL_11C;
					IL_132:
					fileStream.Close();
					num = (short)1033764865;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_11C;
					IL_14E:
					base.SaveCustomizations(fileStream);
					num = (short)732233728;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_11C;
				}
				catch (global::System.Exception)
				{
				}
				break;
			}
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001E2C4 File Offset: 0x0001C4C4
		private void c()
		{
			short num = (short)552861696;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					goto IL_7D;
				case 2:
					return;
				}
				IL_32:
				num = (short)125763584;
				short num3 = num;
				if (global::System.IO.File.Exists(this.customizationsFile))
				{
					num = (short)922419201;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)700385397;
					short num4 = num;
					num = (short)1806108789;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1771110401;
						if (num != 0)
						{
						}
						num = (short)1362690048;
						if (num != 0)
						{
						}
						this.d();
						num = (short)1481506818;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_7D:
			try
			{
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(this.customizationsFile, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					base.LoadCustomizations(fileStream);
				}
				finally
				{
					num = (short)794689536;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_160;
							}
							continue;
						case 1:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)1020723202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_193;
						}
						IL_160:
						if (fileStream == null)
						{
							break;
						}
						num = (short)1059979265;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_193:;
				}
			}
			catch
			{
				global::System.IO.File.Delete(this.customizationsFile);
				this.d();
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001E49C File Offset: 0x0001C69C
		private string a(global::Infragistics.Windows.DataPresenter.Field A_0, global::Infragistics.Windows.DataPresenter.Cell A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			string result;
			string text;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (A_0.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseAlternateBinding)
					{
						num2 = (short)1815347204;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)983826442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					result = A_1.Value.ToString();
					num2 = (short)813301767;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (A_1.Value != null)
					{
						num2 = (short)2140012545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					result = this.b(A_1);
					num2 = (short)927006728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (text == null)
					{
						num2 = (short)1543372806;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = text;
					num2 = (short)387842051;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)1027604480;
					short num3 = num2;
					num2 = (short)2117074944;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					return result;
				case 8:
					return result;
				case 9:
					return result;
				case 10:
					if (A_1.ConvertedValue != null)
					{
						num2 = (short)908656651;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)736428034;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					num2 = (short)857276417;
					if (num2 != 0)
					{
					}
					result = A_1.ConvertedValue.ToString();
					num2 = (short)336402419;
					short num4 = num2;
					num2 = (short)577443827;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)683409408;
						if (num2 != 0)
						{
						}
						num2 = (short)947060745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_40;
			}
			return result;
			IL_40:
			result = string.Empty;
			text = this.a(A_1);
			num2 = (short)1526398981;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0001E714 File Offset: 0x0001C914
		private string b(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				string text;
				string text2;
				switch (num)
				{
				case 0:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
					if (fieldBase != null)
					{
						num2 = (short)1012793347;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					num2 = (short)143785991;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
					if (!fieldBase.IsVisible)
					{
						num2 = (short)667353101;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1655242753;
					if (num2 != 0)
					{
					}
					num2 = (short)463208454;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1111621634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1788018688;
					short num3 = num2;
					text = string.Empty;
					goto IL_24C;
				}
				case 5:
					num2 = (short)248119300;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
					text2 = fieldBase.ToString();
					goto IL_2D0;
				}
				case 7:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2;
					if (!fieldBase2.IsVisible)
					{
						num2 = (short)1165295621;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1980563468;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
				{
					if (A_0.ConvertedValue != null)
					{
						num2 = (short)1758199817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2 = A_0.Value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase;
					goto IL_E1;
				}
				case 9:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = A_0.ConvertedValue as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase;
					num2 = (short)1672806400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2;
					if (fieldBase2 != null)
					{
						num2 = (short)769458177;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 11:
					return result;
				case 12:
				{
					num2 = (short)727963408;
					short num4 = num2;
					num2 = (short)9230096;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
					{
						num2 = (short)679411712;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase2;
						text = fieldBase2.ToString();
						goto IL_24C;
					}
					}
					break;
				}
				case 13:
					num2 = (short)1519452174;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					text2 = string.Empty;
					goto IL_2D0;
				case 15:
					return result;
				}
				goto IL_50;
				IL_E1:
				num2 = (short)154402826;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_24C:
				result = text;
				num2 = (short)1580662795;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2D0:
				result = text2;
				num2 = (short)609288207;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_50:
			result = string.Empty;
			num2 = (short)1318125576;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001EA10 File Offset: 0x0001CC10
		private void b()
		{
			short num;
			for (;;)
			{
				this.rmSearchBox = global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.UiHelper.FindChild<global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox>(this);
				if (this.rmSearchBox != null)
				{
					goto IL_8B;
				}
				num = (short)484966400;
				short num2 = num;
				num = (short)821080544;
				short num3 = num;
				num = (short)1304474080;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_72;
				}
			}
			IL_72:
			num = (short)1573322752;
			if (num != 0)
			{
			}
			return;
			IL_8B:
			num = (short)1761607681;
			if (num != 0)
			{
			}
			this.rmSearchBox.SearchTriggered += delegate(object A_0, global::System.EventArgs A_1)
			{
				short num4 = (short)223911854;
				short num5 = num4;
				num4 = (short)502308782;
				switch (num5 == num4)
				{
				}
				num4 = (short)1853816832;
				if (num4 != 0)
				{
				}
				num4 = (short)1071382528;
				short num6 = num4;
				num4 = (short)1228406785;
				if (num4 != 0)
				{
				}
				this.a();
			};
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001EAE8 File Offset: 0x0001CCE8
		private void a()
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c__DisplayClass160_0 CS$<>8__locals1;
			for (;;)
			{
				IL_13:
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer;
				switch (num)
				{
				case 0:
					if (this.SearchCommand != null)
					{
						num2 = (short)1840906241;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_183;
				case 2:
					try
					{
						base.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CommitChangesToActiveRecord);
						CS$<>8__locals1.b = new object[]
						{
							this.rmSearchBox.Text,
							base.Records
						};
						base.Dispatcher.Invoke(new global::System.Action(CS$<>8__locals1.c));
						this.g();
						base.SelectedItems.Cells.Clear();
						return;
					}
					finally
					{
						num2 = (short)83230720;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_123;
								}
								continue;
							case 1:
								automaticPerformanceMeasurer.Dispose();
								num2 = (short)899350530;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_159;
							}
							IL_123:
							if (automaticPerformanceMeasurer == null)
							{
								break;
							}
							num2 = (short)226295809;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_159:
						num2 = (short)894631937;
						if (num2 != 0)
						{
						}
					}
					goto IL_183;
				}
				goto IL_25;
				IL_183:
				automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.Gui, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쮗ﾙﶛ쎟쪡", a_)).AddOrUpdateParameter(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첗ﾙ", a_), this.rmSearchBox.Text), null);
				num2 = (short)1919481417;
				short num3 = num2;
				num2 = (short)838465097;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_25;
				default:
					num2 = (short)2089943040;
					if (num2 != 0)
					{
					}
					num2 = (short)1281556482;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return;
			IL_25:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c__DisplayClass160_0();
			CS$<>8__locals1.a = this;
			num2 = (short)1518862336;
			short num4 = num2;
			num2 = (short)2121203712;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001ED2C File Offset: 0x0001CF2C
		private void a(global::Infragistics.Windows.DataPresenter.DataRecord A_0)
		{
			short num = (short)2009071616;
			short num2 = num;
			num = (short)1503002625;
			if (num != 0)
			{
			}
			num = (short)2003062302;
			short num3 = num;
			num = (short)431050270;
			switch (num3 == num)
			{
			}
			num = (short)862715904;
			if (num != 0)
			{
			}
			object[] parameter = new object[]
			{
				this.rmSearchBox.Text,
				A_0
			};
			this.SearchCommand.Execute(parameter);
			this.g();
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001EE00 File Offset: 0x0001D000
		private string a(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			int a_ = 7;
			short num = (short)1010696193;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C2;
				case 1:
					num = (short)787152897;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 2:
				{
					num = (short)339214336;
					short num3 = num;
					num = (short)1813241070;
					short num4 = num;
					num = (short)502455534;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1634074624;
						if (num != 0)
						{
						}
						if (A_0.Value != null)
						{
							num = (short)425525251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_174;
					}
					break;
				}
				case 3:
					try
					{
						int changeIndicator = (int)A_0.Value;
						return global::Motorola.CommonCPS.RadioManagement.Converters.ChangeIndivatorConverter.ConvertChangeIndicatorToString(changeIndicator);
					}
					catch (global::System.Exception)
					{
						return string.Empty;
					}
					goto IL_C2;
				}
				IL_64:
				if (A_0.Field.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪞춤욦잨첪좬\udfb0ힲ\udcb4풶\ud8b8쾺튼춾", a_))
				{
					num = (short)486342656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C2:
				num = (short)181665794;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_174:
			return null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001EF94 File Offset: 0x0001D194
		private void b(string A_0, global::System.Collections.Generic.List<string> A_1, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> A_2)
		{
			short num = (short)374276097;
			if (num != 0)
			{
			}
			num = (short)82338539;
			short num2 = num;
			num = (short)1295147755;
			switch (num2 == num)
			{
			}
			num = (short)1948516352;
			short num3 = num;
			num = (short)419299328;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile();
			csvFile.ExportToCSV(A_0, A_1, A_2, null, null);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001F04C File Offset: 0x0001D24C
		private void a(string A_0, global::System.Collections.Generic.List<string> A_1, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> A_2)
		{
			short num = (short)2065956865;
			if (num != 0)
			{
			}
			num = (short)1630853233;
			short num2 = num;
			num = (short)650434673;
			switch (num2 == num)
			{
			}
			num = (short)1457651712;
			short num3 = num;
			num = (short)783155200;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile excelFile = new global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile();
			excelFile.ExportToExcel(A_0, A_1, A_2, null);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0001F108 File Offset: 0x0001D308
		private static void OnMouseRightButtonUp(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			int num;
			short num2;
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase;
			for (;;)
			{
				IL_0A:
				global::System.Windows.DependencyObject dependencyObject;
				global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox rmsearchBox;
				switch (num)
				{
				case 0:
					num2 = (short)994639874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1577320449;
					if (num2 != 0)
					{
					}
					if (!cellValuePresenter.Record.IsSelected)
					{
						num2 = (short)898170886;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4A2;
				case 2:
				{
					global::System.Windows.UIElement uielement = global::System.Windows.Input.Mouse.DirectlyOver as global::System.Windows.UIElement;
					if (uielement == null)
					{
						num2 = (short)1919549447;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					dependencyObject = uielement.GetSelfAndAncestors().FirstOrDefault(new global::System.Func<global::System.Windows.DependencyObject, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid.<>c.<>9.a));
					goto IL_39D;
				}
				case 3:
					rmsearchBox.Focus();
					num2 = (short)1014824971;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_2DD;
				case 5:
					if (!cellValuePresenter.IsSelected)
					{
						num2 = (short)548208658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4A2;
				case 6:
					dataPresenterBase.SelectedItems.Records.Clear();
					cellValuePresenter.Record.IsSelected = true;
					num2 = (short)1287323670;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					dependencyObject = null;
					goto IL_39D;
				case 8:
					goto IL_431;
				case 9:
					num2 = (short)391905303;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!cellValuePresenter.Record.IsSelected)
					{
						num2 = (short)1461911556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4A2;
				case 11:
					return;
				case 12:
					if (cellValuePresenter.Field.CellClickActionResolved == global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord)
					{
						num2 = (short)2146893839;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1332281349;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (cellValuePresenter.IsInEditMode)
					{
						num2 = (short)1968308233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)526974988;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (cellValuePresenter.Field.CellClickActionResolved == global::Infragistics.Windows.DataPresenter.CellClickAction.SelectCell)
					{
						num2 = (short)1749418005;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4A2;
				case 15:
					num2 = (short)1091174401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					return;
				case 17:
					if (cellValuePresenter == null)
					{
						num2 = (short)1319895040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1675165709;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)630718474;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (rmsearchBox != null)
					{
						num2 = (short)921501699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_396;
				case 20:
				{
					if (dataPresenterBase != null)
					{
						cellValuePresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(A_1.OriginalSource as global::System.Windows.DependencyObject, typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), false) as global::Infragistics.Windows.DataPresenter.CellValuePresenter);
						num2 = (short)1430192145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2034475738;
					short num3 = num2;
					num2 = (short)1791206106;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2DD;
					default:
					{
						num2 = (short)1258356736;
						if (num2 != 0)
						{
						}
						num2 = (short)1316290560;
						short num4 = num2;
						num2 = (short)2037579792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 21:
					cellValuePresenter.IsSelected = true;
					num2 = (short)1276510216;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_374;
				case 23:
					return;
				}
				goto IL_70;
				IL_2DD:
				dataPresenterBase.SelectedItems.Cells.Clear();
				dataPresenterBase.SelectedItems.Records.Clear();
				num2 = (short)1988362254;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_39D:
				rmsearchBox = (dependencyObject as global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox);
				num2 = (short)1171324947;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_374:
			goto IL_4A2;
			IL_396:
			dataPresenterBase.FocusActiveItem();
			return;
			IL_431:
			IL_4A2:
			cellValuePresenter.Focus();
			return;
			IL_70:
			dataPresenterBase = (A_0 as global::Infragistics.Windows.DataPresenter.DataPresenterBase);
			num2 = (short)1460928532;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
		private static void OnRecordSelectorMouseDoubleClick(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1119354884;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				object obj;
				global::System.Windows.Input.ICommand command;
				switch (num2)
				{
				case 0:
					obj = null;
					goto IL_73;
				case 1:
					return;
				case 2:
				{
					num = (short)279073693;
					short num3 = num;
					num = (short)819418013;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E6;
					default:
						num = (short)1197473792;
						if (num != 0)
						{
						}
						command.Execute(null);
						num = (short)807469057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					if (command.CanExecute(null))
					{
						num = (short)1551761410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
					if (command != null)
					{
						num = (short)570097670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)263389187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_E6;
				}
				IL_44:
				global::Infragistics.Windows.DataPresenter.Record record = ((global::Infragistics.Windows.DataPresenter.RecordSelector)A_0).Record;
				if (record == null)
				{
					num = (short)2018705408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				obj = record.DataPresenter;
				IL_73:
				global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = obj as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid;
				if (rmdataGrid == null)
				{
					num = (short)204275712;
					short num4 = num;
					num = (short)8257537;
					if (num != 0)
					{
					}
					num = (short)12124167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::System.Windows.Input.ICommand command2 = rmdataGrid.EditCommand;
				IL_F0:
				command = command2;
				num = (short)1997340677;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E6:
				command2 = null;
				goto IL_F0;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		private static void OnDataRecordPresenterMouseDoubleClick(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1965686790;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = ((global::Infragistics.Windows.DataPresenter.DataRecordPresenter)A_0).DataPresenter as global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid;
					if (rmdataGrid == null)
					{
						num2 = (short)337903620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.EventHandler<global::System.Windows.Input.MouseButtonEventArgs> dataRecordPresenterMouseDoubleClicked = rmdataGrid.DataRecordPresenterMouseDoubleClicked;
					if (dataRecordPresenterMouseDoubleClicked == null)
					{
						return;
					}
					dataRecordPresenterMouseDoubleClicked(A_0, A_1);
					num2 = (short)1571815426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_13B;
				case 3:
					if (dataRecordPresenter != null)
					{
						num2 = (short)1474428928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				case 4:
					return;
				case 5:
					num2 = (short)993984513;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)960495617;
					if (num2 != 0)
					{
					}
					if (!(dataRecordPresenter.DataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord))
					{
						num2 = (short)1164443653;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13B;
				}
				goto IL_2C;
				IL_13B:
				num2 = (short)1096132311;
				short num3 = num2;
				num2 = (short)1091282647;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_170;
				}
			}
			return;
			IL_170:
			num2 = (short)266862592;
			short num4 = num2;
			num2 = (short)1351680000;
			if (num2 != 0)
			{
			}
			return;
			IL_2C:
			dataRecordPresenter = (A_0 as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
			num2 = (short)2007236611;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060001DE RID: 478 RVA: 0x0001F95C File Offset: 0x0001DB5C
		// (remove) Token: 0x060001DF RID: 479 RVA: 0x0001FA90 File Offset: 0x0001DC90
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_D8;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)2136342528;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_60;
					case 2:
						goto IL_60;
					}
					goto IL_1C;
					IL_60:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)740491264;
					short num3 = num2;
					num2 = (short)624754689;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_D8:
				num2 = (short)12239393;
				short num4 = num2;
				num2 = (short)603439649;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1C:
					num2 = (short)1104084993;
					if (num2 != 0)
					{
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
					num2 = (short)543424514;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
					num2 = (short)1551106048;
					if (num2 != 0)
					{
					}
					return;
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
						goto IL_D8;
					case 1:
					{
						num2 = (short)1842610176;
						short num3 = num2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1144520705;
							if (num2 != 0)
							{
							}
							num2 = (short)1288372224;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1319895041;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_D8:
				num2 = (short)2056966507;
				short num4 = num2;
				num2 = (short)1528025451;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1C:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
					num2 = (short)426835970;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
					num2 = (short)1900544;
					if (num2 != 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0001FBC4 File Offset: 0x0001DDC4
		protected virtual void OnPropertyChanged([global::System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			short num = (short)1565720577;
			if (num != 0)
			{
			}
			num = (short)582705468;
			short num2 = num;
			num = (short)654205244;
			switch (num2 == num)
			{
			}
			num = (short)182190080;
			short num3 = num;
			num = (short)1504706560;
			if (num != 0)
			{
			}
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001FC84 File Offset: 0x0001DE84
		public override void OnApplyTemplate()
		{
			short num = (short)1924976296;
			short num2 = num;
			num = (short)1679806120;
			switch (num2 == num)
			{
			}
			num = (short)1822818304;
			if (num != 0)
			{
			}
			num = (short)1731985408;
			short num3 = num;
			num = (short)2055012353;
			if (num != 0)
			{
			}
			base.OnApplyTemplate();
			this.b();
		}

		// Token: 0x04000060 RID: 96
		private global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox rmSearchBox;

		// Token: 0x04000061 RID: 97
		private readonly global::System.Lazy<global::Microsoft.Practices.Prism.Events.IEventAggregator> _eventAggregator;

		// Token: 0x04000062 RID: 98
		private string customizationsFile;

		// Token: 0x04000063 RID: 99
		private readonly global::Motorola.CommonCPS.RadioManagement.Controls.CustomControls.XamGridHelpers.a _addedRowSelector;

		// Token: 0x04000064 RID: 100
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid>> _behaviors;

		// Token: 0x04000065 RID: 101
		private readonly string fieldLayoutPath;

		// Token: 0x04000066 RID: 102
		public static readonly global::System.Windows.DependencyProperty AutoSaveCustomizationsCountProperty;

		// Token: 0x04000067 RID: 103
		public static readonly global::System.Windows.DependencyProperty CustomizedSelectedCountProperty;

		// Token: 0x04000068 RID: 104
		public static readonly global::System.Windows.DependencyProperty CustomizedTotalCountProperty;

		// Token: 0x04000069 RID: 105
		public static readonly global::System.Windows.DependencyProperty ToolbarVisibilityProperty;

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty StatusbarVisibilityProperty;

		// Token: 0x0400006B RID: 107
		public static readonly global::System.Windows.DependencyProperty IsBindingViewCacheProperty;

		// Token: 0x0400006C RID: 108
		public static readonly global::System.Windows.DependencyProperty GridToFileButtonVisibilityProperty;

		// Token: 0x0400006D RID: 109
		public static readonly global::System.Windows.DependencyProperty USBButtonVisibilityProperty;

		// Token: 0x0400006E RID: 110
		public static readonly global::System.Windows.DependencyProperty FileToGridButtonVisibilityProperty;

		// Token: 0x0400006F RID: 111
		public static readonly global::System.Windows.DependencyProperty CRUDToolBarVisibilityProperty;

		// Token: 0x04000070 RID: 112
		public static readonly global::System.Windows.DependencyProperty AdditionalButtonVisibilityProperty;

		// Token: 0x04000071 RID: 113
		public static readonly global::System.Windows.DependencyProperty SearchVisibilityProperty;

		// Token: 0x04000072 RID: 114
		public static readonly global::System.Windows.DependencyProperty ProgressBarVisibilityProperty;

		// Token: 0x04000073 RID: 115
		public static readonly global::System.Windows.DependencyProperty AddCommandProperty;

		// Token: 0x04000074 RID: 116
		public static readonly global::System.Windows.DependencyProperty DeleteCommandProperty;

		// Token: 0x04000075 RID: 117
		public static readonly global::System.Windows.DependencyProperty EditCommandProperty;

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty NewCommandProperty;

		// Token: 0x04000077 RID: 119
		public static readonly global::System.Windows.DependencyProperty ExportCommandProperty;

		// Token: 0x04000078 RID: 120
		public static readonly global::System.Windows.DependencyProperty ImportCommandProperty;

		// Token: 0x04000079 RID: 121
		public static readonly global::System.Windows.DependencyProperty FileToGridCommandProperty;

		// Token: 0x0400007A RID: 122
		public static readonly global::System.Windows.DependencyProperty GridToFileCommandProperty;

		// Token: 0x0400007B RID: 123
		public static readonly global::System.Windows.DependencyProperty AddConnectedDevicesCommandProperty;

		// Token: 0x0400007C RID: 124
		public static readonly global::System.Windows.DependencyProperty SearchCommandProperty;

		// Token: 0x0400007D RID: 125
		public static readonly global::System.Windows.DependencyProperty CopyCommandProperty;

		// Token: 0x0400007E RID: 126
		public static readonly global::System.Windows.DependencyProperty PreviewCommandProperty;

		// Token: 0x0400007F RID: 127
		public static readonly global::System.Windows.DependencyProperty ChangeIdCommandProperty;

		// Token: 0x04000080 RID: 128
		public static readonly global::System.Windows.DependencyProperty ChangeValueCommandProperty;

		// Token: 0x04000081 RID: 129
		public static readonly global::System.Windows.DependencyProperty IsLoadingItemsFromViewCacheProperty;
	}
}
