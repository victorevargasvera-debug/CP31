using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows;
using Infragistics.Windows.DataPresenter;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.Infrastructure.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.UI.CellRangeFill;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x0200001A RID: 26
	[global::Motorola.CommonCPS.RadioManagement.Infrastructure.ViewExport(RegionName = "RadioMainRegion")]
	public class RadiosView : global::System.Windows.Controls.UserControl, global::System.IDisposable, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00016E00 File Offset: 0x00015000
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadiosView(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			this.InitializeComponent();
			this.c();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.RadioColumnInfo = this.b();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.RadioColumnOnUIInfo = this.a();
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.GetDataGridInfoForRadiosRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo>>(this.a));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintViewRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext>(this.b));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PrintViewPreviewRequestedEvent>().Subscribe(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext>(this.a));
		}

		// Token: 0x17000045 RID: 69
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00016E80 File Offset: 0x00015080
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel ViewModel
		{
			set
			{
				short num = (short)1617169317;
				short num2 = num;
				num = (short)486017957;
				switch (num2 == num)
				{
				}
				num = (short)1599733761;
				if (num != 0)
				{
				}
				num = (short)1036189696;
				short num3 = num;
				num = (short)344064000;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00016F30 File Offset: 0x00015130
		private void a(global::Motorola.CommonCPS.RadioManagement.Events.ResultPayload<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo> A_0)
		{
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid = this.dgrASTRORadios;
			if (rmdataGrid == null)
			{
				short num = (short)2127164372;
				short num2 = num;
				num = (short)132576212;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A9;
				case 1:
					break;
				default:
				{
					num = (short)740425728;
					short num3 = num;
					break;
				}
				}
				num = (short)453443585;
				if (num != 0)
				{
				}
				num = (short)27066368;
				if (num != 0)
				{
				}
				return;
			}
			IL_A9:
			A_0.Result = rmdataGrid.GetGridInfo();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00016FF4 File Offset: 0x000151F4
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext A_0)
		{
			int a_ = 19;
			short num = (short)1808531456;
			switch (num)
			{
			default:
			{
				num = (short)78249990;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> fieldNeedSpecialConverter;
				global::System.Collections.Generic.List<string> fieldNeedCollapsed;
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation dataGridOperation;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView != global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("闆꣈꿊꓌ꃎꋐ藒볔닖께", a_)))
						{
							num = (short)491782144;
							short num3 = num;
							num = (short)1780285445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_2CC;
					case 2:
					{
						if (A_0 == null)
						{
							num = (short)1118109699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fieldNeedSpecialConverter = A_0.FieldNeedSpecialConverter;
						fieldNeedCollapsed = A_0.FieldNeedCollapsed;
						dataGridOperation = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation(this.dgrASTRORadios);
						global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dataGrid = this.dgrASTRORadios;
						A_0.SelectedDataItems = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator enumerator = dataGridOperation.GetPrintRecords(dataGrid).GetEnumerator();
						num = (short)554893313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_275;
					case 4:
						num = (short)2091843584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)86638594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					}
					IL_69:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("闆꣈꿊꓌ꃎ", a_))
					{
						break;
					}
					num = (short)40763396;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_275:
				return;
				IL_2CC:
				num = (short)2006515713;
				if (num != 0)
				{
				}
				try
				{
					num = (short)90505220;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1397882883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current;
							A_0.SelectedDataItems.Add((global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase)dataRecord.DataItem);
							num = (short)714594919;
							short num4 = num;
							num = (short)465885799;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)699400192;
								if (num != 0)
								{
								}
								num = (short)673841152;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_1B5;
						case 3:
							num = (short)881590274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_DA;
							}
							continue;
						}
						IL_DC:
						num = (short)720371713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DA:
						goto IL_DC;
					}
					IL_1B5:
					goto IL_2FA;
				}
				finally
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
				IL_2FA:
				dataGridOperation.DevicesPrint(A_0.SelectedDataItems, fieldNeedSpecialConverter, fieldNeedCollapsed);
				return;
			}
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00017328 File Offset: 0x00015528
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.PrintViewContext A_0)
		{
			int a_ = 12;
			short num = (short)1011548160;
			switch (num)
			{
			default:
			{
				num = (short)449576966;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<global::System.Windows.Data.IValueConverter, global::System.Type>> fieldNeedSpecialConverter;
				global::System.Collections.Generic.List<string> fieldNeedCollapsed;
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation dataGridOperation;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView != global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("銿ꏁꃃ꿅Ꟈ막髋ꟍ뗏ꗑ", a_)))
						{
							num = (short)665714688;
							short num3 = num;
							num = (short)1185742853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_2CB;
					case 2:
					{
						if (A_0 == null)
						{
							num = (short)523632643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fieldNeedSpecialConverter = A_0.FieldNeedSpecialConverter;
						fieldNeedCollapsed = A_0.FieldNeedCollapsed;
						global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dataGrid = this.dgrASTRORadios;
						dataGridOperation = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.Utility.DataGridOperation(this.dgrASTRORadios);
						A_0.SelectedDataItems = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator enumerator = dataGridOperation.GetPrintRecords(dataGrid).GetEnumerator();
						num = (short)315031553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_274;
					case 4:
						num = (short)1386086400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)741998594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					}
					IL_6A:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainModule != global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("銿ꏁꃃ꿅Ꟈ", a_))
					{
						break;
					}
					num = (short)348782596;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_274:
				return;
				IL_2CB:
				num = (short)1959264257;
				if (num != 0)
				{
				}
				try
				{
					num = (short)595329028;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1916207107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current;
							A_0.SelectedDataItems.Add((global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase)dataRecord.DataItem);
							num = (short)1063485994;
							short num4 = num;
							num = (short)1111589418;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1600323584;
								if (num != 0)
								{
								}
								num = (short)514260992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_1B6;
						case 3:
							num = (short)214827010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_DB;
							}
							continue;
						}
						IL_DD:
						num = (short)1258946561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DB:
						goto IL_DD;
					}
					IL_1B6:
					goto IL_2F6;
				}
				finally
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>.Enumerator enumerator;
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
				IL_2F6:
				dataGridOperation.DevicesPrintView(A_0.SelectedDataItems, fieldNeedSpecialConverter, fieldNeedCollapsed);
				return;
			}
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00017658 File Offset: 0x00015858
		private void e(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1575333874;
			short num2 = num;
			num = (short)961851378;
			switch (num2 == num)
			{
			}
			num = (short)1961033729;
			if (num != 0)
			{
			}
			num = (short)182059008;
			short num3 = num;
			num = (short)1824129024;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel radiosViewModel = base.DataContext as global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0001770C File Offset: 0x0001590C
		private void c()
		{
			int a_ = 11;
			short num = (short)1658585092;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)902857843;
					short num3 = num;
					num = (short)2099676275;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5E;
					default:
						num = (short)2111897600;
						if (num != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX)
						{
							num = (short)745275394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					goto IL_5E;
				case 2:
					goto IL_21A;
				case 3:
					goto IL_12F;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
				{
					num = (short)2059927553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.dgrASTRORadios.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﲾ껀귂ꏄ껆껈뻊뿌껎ꗐ뫒뫔맖韘뫚냜뫞", a_));
				this.dgrASTRORadios.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("胀藂계ꯆ곈룊", a_));
				this.dgrASTRORadios.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("돀곂도껆뫈ꋊꋌꇎ듐럒", a_));
				this.dgrASTRORadios.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꃀ냂뇄蓆ꛈꗊ만껎닐꟒臔뻖듘뻚", a_));
				num = (short)431357955;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5E:
				num = (short)2132082689;
				if (num != 0)
				{
				}
				num = (short)1872560128;
				short num4 = num;
				this.dgrASTRORadios.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("꓀껂뗄ꯆ꣈뿊꣌臎냐뻒냔", a_));
				this.dgrASTRORadios.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("듀귂계꧆껈鷊꣌뷎ꋐ뫒뫔맖", a_));
				num = (short)1644363776;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12F:
			return;
			IL_21A:
			this.dgrASTRORadios.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("돀곂도껆뫈ꋊꋌꇎ듐럒", a_));
			this.dgrASTRORadios.RemoveColumn(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꃀ냂뇄蓆ꛈꗊ만껎닐꟒臔뻖듘뻚", a_));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00017938 File Offset: 0x00015B38
		private void d(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 8;
			short num = (short)1915682816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_E7;
					case 1:
					{
						num = (short)1494315542;
						short num3 = num;
						num = (short)1373860374;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F4;
						default:
							goto IL_158;
						}
						break;
					}
					case 2:
						if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROVRIDEntryFormat.ToUpperInvariant() == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("", a_))
						{
							num = (short)959971332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.dgrASTRORadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("覿蛁", a_)].Converter = null;
						global::Motorola.CommonCPS.RadioManagement.Radio.RadiosView.a(global::System.Windows.LogicalTreeHelper.FindLogicalNode(base.Resources[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udfbb펽莿귁꫃냅귇룉룋ꯍꋏ", a_)] as global::System.Windows.Controls.ContextMenu, global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbbdꎿꯁ꧃Ʂ꓇賉ꏋ볍뷏돑ꃓ", a_)));
						num = (short)1929904131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_E7;
					case 4:
						goto IL_1F4;
					case 5:
						if (this._fillManager != null)
						{
							num = (short)1710292993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CD;
					}
					goto IL_4F;
					IL_E7:
					num = (short)1513095173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F4:
					this.dgrASTRORadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("覿蛁", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.VRIDEntryFormatConverter();
					global::Motorola.CommonCPS.RadioManagement.Radio.RadiosView.a(global::System.Windows.LogicalTreeHelper.FindLogicalNode(base.Resources[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udfbb펽莿귁꫃냅귇룉룋ꯍꋏ", a_)] as global::System.Windows.Controls.ContextMenu, global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbbd뢿蓁ꯃ듅ꗇꯉ룋", a_)));
					num = (short)711983105;
					if (num != 0)
					{
					}
					num = (short)408682496;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_158:
				num = (short)1021116416;
				if (num != 0)
				{
				}
				num = (short)2075852800;
				short num4 = num;
				return;
				IL_2CD:
				this._fillManager = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager(new global::Motorola.CommonCPS.RadioManagement.Infrastructure.GridSorting<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>(this.dgrASTRORadios), typeof(global::Motorola.CommonCPS.RadioManagement.Radio.a), new global::Motorola.CommonCPS.RadioManagement.Infrastructure.PostFillActionResolver());
				global::System.Windows.Input.ICommand command = global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.GetCommand(this.dgrASTRORadios);
				global::System.Windows.Input.ICommand command2 = global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.GetCommand(this.dgrASTRORadios);
				global::Motorola.CommonCPS.UI.CellRangeFill.ICellEditabilityResolver editabilityResolver = new global::Motorola.CommonCPS.RadioManagement.Radio.AstroCellEditabilityResolver();
				global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter valueSetter = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandCellValueSetter(command, command2, editabilityResolver);
				global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter valueSetter2 = new global::Motorola.CommonCPS.RadioManagement.Radio.GroupFieldCellValueSetter<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>(command, command2, editabilityResolver, (global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel)base.DataContext);
				global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter valueSetter3 = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.IPAddressFieldSetter(command, command2, editabilityResolver);
				global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeCopyFiller(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_CopyCells);
				global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler2 = new global::Motorola.CommonCPS.UI.CellRangeFill.Int32CellRangeSeriesFiller(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_FillSeries, false);
				global::Motorola.CommonCPS.UI.CellRangeFill.ICellRangeFiller filler3 = new global::Motorola.CommonCPS.UI.CellRangeFill.IPAddressCellRangeSeriesFiller(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_FillOperation_FillSeries, false);
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = this.dgrASTRORadios.FieldLayouts[0].Fields;
				string name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udfbd꒿ꯁꯃ蟅꓇ꏉ귋뷍", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("﮻첽꾿럁듃装꧇Ꟊ꧋", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter2));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("쪽ꆿ냁跃苅", a_)].Name;
				global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.Int32CellValueRangeConstraint constraint = new global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.Int32CellValueRangeConstraint(0, 9999999);
				this._fillManager.CellValueConstraintBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueConstraintBinding(name, constraint));
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler2));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler2));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("請톽늿ꟁ귃ꇅꛇ菉鳋", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("쮽ꊿ뇁ꟃ듅ꇇ꣉꧋볍駏苑", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udbbdꖿ냁跃雅", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﺻ튽떿ꟁ냃꧅Ꟈ뻉꓋諍藏鳑蟓ꏕ뫗꧙뿛곝觟胡臣铥ꇧ뫩", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﺻ튽떿ꟁ냃꧅Ꟈ뻉꓋諍藏鳑蓓돕뷗꣙闛軝", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler3));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﺻ튽떿ꟁ냃꧅Ꟈ뻉꓋裍ꋏ믑뇓룕볗뛙ꗛ郝臟迡臣", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﾻ톽궿꿁ꇃꣅ볇막", a_)].Name;
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				name = fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("覿蛁", a_)].Name;
				global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.Int32CellValueRangeConstraint constraint2 = new global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.Int32CellValueRangeConstraint(0, 16777215);
				this._fillManager.CellValueConstraintBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.CellValueConstraintBinding(name, constraint2));
				this._fillManager.CellValueSetterBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellValueSetterBinding(name, valueSetter));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler2));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler2));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Mouse, filler));
				this._fillManager.CellRangeFillerBindings.Add(new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding(name, global::System.Windows.Input.InputType.Keyboard, filler));
				this._fillManager.ProcessFieldLayout(this.dgrASTRORadios.DefaultFieldLayout);
				return;
				IL_4F:
				this.dgrASTRORadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("覿蛁", a_)].Settings.EditAsType = typeof(string);
				num = (short)108199938;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000182C4 File Offset: 0x000164C4
		private static void a(object A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::System.Windows.Controls.MenuItem menuItem2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::System.Windows.Controls.MenuItem> enumerator;
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)649789443;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								goto IL_165;
							case 2:
							{
								global::System.Windows.Controls.MenuItem menuItem;
								menuItem.IsChecked = false;
								num2 = (short)1596522496;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_BC;
								}
								continue;
							case 4:
								num2 = (short)501284865;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)938344452;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::System.Windows.Controls.MenuItem menuItem = enumerator.Current;
								num2 = (short)1557331974;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 6:
							{
								global::System.Windows.Controls.MenuItem menuItem;
								if (menuItem != menuItem2)
								{
									num2 = (short)1536819202;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							}
							IL_BE:
							num2 = (short)1794375685;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_BC:
							goto IL_BE;
						}
						IL_165:
						return;
					}
					finally
					{
						num2 = (short)733478913;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1CF;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_19A;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num2 = (short)1219428352;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_19A:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1465909250;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1CF:
						num2 = (short)1538256416;
						short num3 = num2;
						num2 = (short)519712;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CF;
						default:
							num2 = (short)110952448;
							if (num2 != 0)
							{
							}
							break;
						}
					}
					goto IL_21C;
				case 1:
					if (menuItem2 != null)
					{
						num2 = (short)1506279426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					num2 = (short)1174667265;
					if (num2 != 0)
					{
					}
					goto IL_21C;
				}
				goto IL_1C;
				IL_21C:
				global::System.Collections.Generic.IEnumerable<global::System.Windows.Controls.MenuItem> enumerable = ((global::System.Windows.Controls.ContextMenu)menuItem2.Parent).Items.OfType<global::System.Windows.Controls.MenuItem>();
				menuItem2.IsChecked = true;
				enumerator = enumerable.GetEnumerator();
				num2 = (short)1151467520;
				short num4 = num2;
				num2 = (short)939655168;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			menuItem2 = (A_0 as global::System.Windows.Controls.MenuItem);
			num2 = (short)1472790529;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00018564 File Offset: 0x00016764
		private void c(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 0;
			short num = (short)2079916033;
			if (num != 0)
			{
			}
			num = (short)279696507;
			short num2 = num;
			num = (short)1057281147;
			switch (num2 == num)
			{
			}
			num = (short)758448128;
			if (num != 0)
			{
			}
			num = (short)2686976;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Radio.RadiosView.a(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("", a_));
			this.dgrASTRORadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ﺹ", a_)].Converter = null;
			global::Motorola.CommonCPS.RadioManagement.Radio.RadiosView.a(A_0);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00018660 File Offset: 0x00016860
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 5;
			short num = (short)1343541312;
			short num2 = num;
			num = (short)1201852480;
			switch (num2 == num)
			{
			}
			num = (short)1076428801;
			if (num != 0)
			{
			}
			num = (short)1872625664;
			if (num != 0)
			{
			}
			num = (short)1518010368;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Radio.RadiosView.a(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("", a_));
			this.dgrASTRORadios.FieldLayouts[0].Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("﮾", a_)].Converter = new global::Motorola.CommonCPS.RadioManagement.Converters.VRIDEntryFormatConverter();
			global::Motorola.CommonCPS.RadioManagement.Radio.RadiosView.a(A_0);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00018760 File Offset: 0x00016960
		private static void a(string A_0)
		{
			short num = (short)21731808;
			short num2 = num;
			num = (short)1496488416;
			switch (num2 == num)
			{
			}
			num = (short)1297285120;
			if (num != 0)
			{
			}
			num = (short)1645871105;
			if (num != 0)
			{
			}
			num = (short)1229914112;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ASTROVRIDEntryFormat = A_0;
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00018820 File Offset: 0x00016A20
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1062020040;
					short num3 = num2;
					num2 = (short)1743856584;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)557449216;
						if (num2 != 0)
						{
						}
						break;
					}
					global::System.Windows.Controls.ContextMenu contextMenu = base.FindResource(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udebc튾苀곂ꯄ뇆곈맊만꫎ꏐ", a_)) as global::System.Windows.Controls.ContextMenu;
					labelPresenter.ContextMenu = contextMenu;
					labelPresenter.ContextMenu.IsOpen = true;
					A_1.Handled = true;
					num2 = (short)695795716;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (labelPresenter != null)
					{
						num2 = (short)514850819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (labelPresenter.Field.Name == global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("裀蟂", a_))
					{
						num2 = (short)86441984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					num2 = (short)981073921;
					if (num2 != 0)
					{
					}
					num2 = (short)1244987394;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return;
				}
				goto IL_2D;
			}
			return;
			IL_2D:
			num2 = (short)1863974912;
			short num4 = num2;
			labelPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(A_1.OriginalSource as global::System.Windows.DependencyObject, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true) as global::Infragistics.Windows.DataPresenter.LabelPresenter);
			num2 = (short)687865857;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000189F0 File Offset: 0x00016BF0
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1806654120;
			short num2 = num;
			num = (short)1773558440;
			switch (num2 == num)
			{
			}
			num = (short)427098113;
			if (num != 0)
			{
			}
			num = (short)1274478592;
			if (num != 0)
			{
			}
			num = (short)1535115264;
			short num3 = num;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00018A9C File Offset: 0x00016C9C
		private void a(object A_0, global::System.Windows.Controls.ContextMenuEventArgs A_1)
		{
			short num = (short)966262785;
			if (num != 0)
			{
			}
			num = (short)1234198972;
			short num2 = num;
			num = (short)35938748;
			switch (num2 == num)
			{
			}
			num = (short)1117192192;
			if (num != 0)
			{
			}
			num = (short)822673408;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel radiosViewModel = base.DataContext as global::Motorola.CommonCPS.RadioManagement.Radio.RadiosViewModel;
			if (radiosViewModel == null)
			{
				return;
			}
			radiosViewModel.EndEditGroupTree();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00018B60 File Offset: 0x00016D60
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> b()
		{
			short num = (short)724697088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				global::Infragistics.Windows.DataPresenter.FieldCollection fieldCollection;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> list;
				global::System.Reflection.PropertyInfo[] array3;
				for (;;)
				{
					IL_28:
					int num4;
					global::System.Reflection.PropertyInfo propertyInfo;
					global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[] array;
					global::System.Reflection.PropertyInfo propertyInfo2;
					switch (num2)
					{
					case 0:
						goto IL_1D6;
					case 1:
						goto IL_195;
					case 2:
					{
						num = (short)1215188338;
						short num3 = num;
						num = (short)1499811186;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3ED;
						default:
						{
							num = (short)579796992;
							if (num != 0)
							{
							}
							num = (short)1595080705;
							if (num != 0)
							{
							}
							if (num4 >= fieldCollection.Count)
							{
								num = (short)1032781835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.Field field = fieldCollection[num4];
							num = (short)1353908241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						global::System.Type propertyType = propertyInfo.PropertyType;
						string uiLable;
						global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo item = new global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo(array[0].EntiytMemberName, uiLable, null, propertyType);
						list.Add(item);
						num = (short)667353097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num5;
						global::System.Reflection.PropertyInfo[] array2;
						if (num5 >= array2.Length)
						{
							num = (short)123142145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						propertyInfo2 = array2[num5];
						num = (short)2121990152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_3ED;
					case 6:
						goto IL_213;
					case 7:
						if (fieldCollection != null)
						{
							num = (short)1014038540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F2;
					case 8:
					{
						string name;
						if (propertyInfo2.Name == name)
						{
							num = (short)1308360709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5;
						num5++;
						num = (short)148373504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_195;
					case 10:
						num = (short)624558095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_2C4;
					case 12:
						num4 = 0;
						num = (short)813170706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_1D6;
					case 14:
						if (array != null)
						{
							num = (short)1635909642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_195;
					case 15:
						if (array.Length == 1)
						{
							num = (short)192217091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_195;
					case 16:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						string uiLable = field.Label as string;
						string name = field.Name;
						global::System.Reflection.PropertyInfo[] array2 = array3;
						int num5 = 0;
						num = (short)1570177037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::Infragistics.Windows.DataPresenter.Field field;
						if (field.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1332871184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_195;
					}
					case 18:
						goto IL_213;
					}
					goto IL_7B;
					IL_195:
					num4++;
					num = (short)588840966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D6:
					num = (short)1384579076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_213:
					num = (short)454688770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3ED:
					propertyInfo = propertyInfo2;
					array = (propertyInfo.GetCustomAttributes(typeof(global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute), false) as global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberNameAttribute[]);
					num = (short)239468558;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2C4:
				IL_3F2:
				num = (short)360054784;
				short num6 = num;
				return list;
				IL_7B:
				fieldCollection = null;
				array3 = null;
				fieldCollection = this.dgrASTRORadios.FieldLayouts[0].Fields;
				array3 = typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo>();
				num = (short)418578439;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00018F8C File Offset: 0x0001718C
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.Global.UIFieldInfo> a()
		{
			short num = (short)637791681;
			short num2 = num;
			num = (short)1413803457;
			switch (num2 == num)
			{
			}
			num = (short)570818561;
			if (num != 0)
			{
			}
			num = (short)355401728;
			if (num != 0)
			{
			}
			num = (short)1600585728;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.Controls.Utility.GetColumOnUI(this.dgrASTRORadios);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00019040 File Offset: 0x00017240
		public void Dispose()
		{
			short num = (short)1890397753;
			short num2 = num;
			num = (short)2103717433;
			switch (num2 == num)
			{
			}
			num = (short)958529536;
			if (num != 0)
			{
			}
			num = (short)579076097;
			if (num != 0)
			{
			}
			num = (short)1074331648;
			short num3 = num;
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000190F8 File Offset: 0x000172F8
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1102577664;
			short num2 = num;
			num = (short)2020883296;
			short num3 = num;
			num = (short)2027371360;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_168:
				this._convergeFillManager.Dispose();
				this._convergeFillManager = null;
				num = (short)1270153222;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)894697472;
				if (num != 0)
				{
				}
				num = (short)1355677696;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_B9;
					}
					continue;
				case 1:
					goto IL_10F;
				case 2:
					return;
				case 3:
					num = (short)1518206977;
					if (num != 0)
					{
					}
					goto IL_DA;
				case 4:
					this._fillManager.Dispose();
					this._fillManager = null;
					num = (short)168493059;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this._fillManager != null)
					{
						num = (short)1076953092;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DA;
				case 6:
					return;
				case 7:
					if (this._convergeFillManager != null)
					{
						num = (short)2067005441;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_B9:
				if (!disposing)
				{
					num = (short)1800273922;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)317718533;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_DA:
				num = (short)1716453383;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_10F:
			goto IL_168;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000192D8 File Offset: 0x000174D8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num = (short)1865678848;
			short num2 = num;
			num = (short)1048912512;
			short num3 = num;
			num = (short)1451238016;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1204682752;
				if (num != 0)
				{
				}
				num = (short)2121203713;
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
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鞷펻쪽꾿냁ꯃ꫅꧇迋ꇍ뷏뿑믓룕鯗諙进닟菡胣迥蟧꟩跫胭釯闱釳鯵鷷铹裻탽勿持怃漅朇ㄉ漋愍紏我笓砕紗琙栛ㄝ刟䌡䀣伥䜧天娫䜭唯䔱ᬳ䐵夷帹唻儽㌿㑁ⵃ⍅㽇摉㑋⽍㵏㹑", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000193C0 File Offset: 0x000175C0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1343291392;
			short num2 = num;
			num = (short)1567173586;
			short num3 = num;
			num = (short)354298834;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D0:
				num = (short)1276379137;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)867827712;
				if (num != 0)
				{
				}
				num = (short)1257963522;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_132;
				case 1:
					num = (short)1998127104;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A4;
					}
					continue;
				}
				break;
			}
			IL_A4:
			switch (connectionId)
			{
			case 1:
				this.uscRadios = (global::Motorola.CommonCPS.RadioManagement.Radio.RadiosView)target;
				return;
			case 2:
				((global::System.Windows.Controls.MenuItem)target).Click += this.c;
				return;
			case 3:
				((global::System.Windows.Controls.MenuItem)target).Click += this.b;
				return;
			case 4:
				num = (short)1212153857;
				if (num != 0)
				{
				}
				((global::System.Windows.Controls.ContextMenu)target).Opened += this.e;
				return;
			case 5:
				this.btnShowDetails = (global::System.Windows.Controls.Button)target;
				return;
			case 6:
				this.btnEditConfiguration = (global::System.Windows.Controls.Button)target;
				return;
			case 7:
				this.btnSpellCheck = (global::System.Windows.Controls.Button)target;
				return;
			case 8:
				this.btnScheduleJob = (global::System.Windows.Controls.Button)target;
				return;
			case 9:
				this.dgrASTRORadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
				this.dgrASTRORadios.Loaded += this.d;
				this.dgrASTRORadios.ContextMenuOpening += this.a;
				this.dgrASTRORadios.PreviewMouseRightButtonDown += this.a;
				return;
			}
			goto IL_D0;
			IL_132:
			this._contentLoaded = true;
		}

		// Token: 0x04000090 RID: 144
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager _fillManager;

		// Token: 0x04000091 RID: 145
		private global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillManager _convergeFillManager;

		// Token: 0x04000092 RID: 146
		internal global::Motorola.CommonCPS.RadioManagement.Radio.RadiosView uscRadios;

		// Token: 0x04000093 RID: 147
		internal global::System.Windows.Controls.Button btnShowDetails;

		// Token: 0x04000094 RID: 148
		internal global::System.Windows.Controls.Button btnEditConfiguration;

		// Token: 0x04000095 RID: 149
		internal global::System.Windows.Controls.Button btnSpellCheck;

		// Token: 0x04000096 RID: 150
		internal global::System.Windows.Controls.Button btnScheduleJob;

		// Token: 0x04000097 RID: 151
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrASTRORadios;

		// Token: 0x04000098 RID: 152
		private bool _contentLoaded;
	}
}
