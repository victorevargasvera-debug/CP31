using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Radio
{
	// Token: 0x02000029 RID: 41
	public class SelectRunningRadiosView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060001D0 RID: 464 RVA: 0x00020E3C File Offset: 0x0001F03C
		public SelectRunningRadiosView()
		{
			int a_ = 9;
			base..ctor();
			this.InitializeComponent();
			this.dgrRadios.Records.CollectionChanged += this.a;
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records))
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udabe귀ꛂꛄ돆곈꿊", a_)], true);
			}
			this.IsSelectAll = new bool?(true);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00020EFC File Offset: 0x0001F0FC
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)1433665537;
				if (num != 0)
				{
				}
				num = (short)1515518547;
				short num2 = num;
				num = (short)1069808211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2079064064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1177157632;
				if (num != 0)
				{
				}
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)629993336;
				short num2 = num;
				num = (short)1279717240;
				switch (num2 == num)
				{
				}
				num = (short)355401728;
				short num3 = num;
				num = (short)401801217;
				if (num != 0)
				{
				}
				num = (short)73138176;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00021074 File Offset: 0x0001F274
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			bool? isChecked;
			short num2;
			for (;;)
			{
				IL_13:
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
				bool flag2;
				switch (num)
				{
				case 0:
					flag = isChecked.GetValueOrDefault();
					goto IL_278;
				case 1:
				{
					num2 = (short)1929183232;
					short num3 = num2;
					if (isChecked == null)
					{
						num2 = (short)475332612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23E;
				}
				case 2:
					flag = true;
					goto IL_278;
				case 3:
					try
					{
						num2 = (short)801832961;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)1250230275;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_E5;
								}
								continue;
							case 2:
							{
								num2 = (short)1651330638;
								short num4 = num2;
								num2 = (short)1219776078;
								switch ((num4 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_151;
								default:
									num2 = (short)24444928;
									if (num2 != 0)
									{
									}
									break;
								}
								break;
							}
							case 3:
								goto IL_1D2;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)732758016;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("闅귇ꛉ꧋귍꓏럑냓", a_)], flag2);
								goto IL_151;
							}
							}
							IL_E7:
							num2 = (short)1969815556;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_E5:
							goto IL_E7;
							IL_151:
							num2 = (short)790167554;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1D2:
						return;
					}
					finally
					{
						num2 = (short)1198981122;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1414463489;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_23B;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_207;
								}
								continue;
							}
							IL_207:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1299972096;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_23B:;
					}
					goto IL_23E;
				case 4:
					num2 = (short)1889009666;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2D;
				IL_23E:
				num2 = (short)2098266112;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_278:
				flag2 = flag;
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
				num2 = (short)1731592193;
				if (num2 != 0)
				{
				}
				num2 = (short)1311637507;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2D:
			this.dgrRadios.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			num2 = (short)639565825;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0002136C File Offset: 0x0001F56C
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)1781465089;
			if (num != 0)
			{
			}
			num = (short)295305216;
			short num2 = num;
			this.dgrRadios.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges);
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
			try
			{
				num = (short)1987510275;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_19C;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							goto IL_120;
						}
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
						dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("雄ꋆꗈ껊껌믎듐럒", a_)], false);
						num = (short)1462042625;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_B5;
						}
						continue;
					case 4:
					{
						num = (short)595141477;
						short num4 = num;
						num = (short)1107239781;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_120;
						default:
							num = (short)1018363904;
							if (num != 0)
							{
							}
							num = (short)1938489344;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_103:
					num = (short)1352728578;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_B5:
					goto IL_103;
					IL_120:
					num = (short)1184038916;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_19C:;
			}
			finally
			{
				num = (short)835321857;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)2097348610;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1CF;
						}
						continue;
					case 2:
						goto IL_203;
					}
					IL_1CF:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1473445888;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_203:;
			}
			this.IsSelectAll = new bool?(false);
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosViewModel).SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000215C8 File Offset: 0x0001F7C8
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 15;
			short num = (short)2066677760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
				bool? flag4;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (!dataRecord.IsActive)
						{
							num = (short)1028063232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 2:
					{
						num = (short)906887168;
						short num3 = num;
						try
						{
							num = (short)1706491908;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									bool? flag;
									bool flag2;
									if (!(flag.GetValueOrDefault() == flag2 & flag != null))
									{
										num = (short)1474822150;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									if (dataRecord2 != dataRecord)
									{
										num = (short)324468746;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									bool flag3 = bool.Parse(dataRecord2.GetCellValue(dataRecord2.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("郂ꃄꯆ곈꣊만꫎뗐", a_)]).ToString());
									bool? flag = flag4;
									bool flag2 = flag3;
									num = (short)685637632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_147;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E2;
									}
									continue;
								case 5:
								{
									num = (short)908328961;
									if (num != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num = (short)478216199;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									num = (short)1101398025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1466630145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1376518152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_2DA;
								case 9:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									if (!(dataRecord2 is global::Infragistics.Windows.DataPresenter.HeaderRecord))
									{
										num = (short)1234305026;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									flag4 = null;
									goto IL_12F;
								}
								goto IL_E2;
								IL_12F:
								num = (short)162136067;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14C:
								num = (short)602572319;
								short num4 = num;
								num = (short)1137608223;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_12F;
								default:
									num = (short)733020160;
									if (num != 0)
									{
									}
									num = (short)2011955205;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E2:
								goto IL_14C;
							}
							IL_147:
							IL_2DA:
							goto IL_3B9;
						}
						finally
						{
							num = (short)923795457;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)76939266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_311;
									}
									continue;
								case 2:
									goto IL_346;
								}
								IL_311:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1717633024;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_346:;
						}
						goto IL_349;
					}
					}
					goto IL_43;
					IL_349:
					flag4 = new bool?(bool.Parse(A_1.NewValue.ToString()));
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
					num = (short)1710948354;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3B9:
				this.IsSelectAll = flag4;
				return;
				IL_43:
				dataRecord = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)673775617;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000219B4 File Offset: 0x0001FBB4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			if (!this._contentLoaded)
			{
				short num = (short)1332612372;
				short num2 = num;
				num = (short)55053588;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2104819712;
					if (num != 0)
					{
					}
					num = (short)1537146880;
					short num3 = num;
					num = (short)948895745;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("閹톽뒿귁뛃꧅꓇ꯉ跍뿏뿑맓맕뛗駙賛距컟냡藣若臧藩ꇫ迭黯鏱鏳鏵闷鿹鋻諽⻿倁攃戅愇攉㜋洍缏缑搓礕瘗缙爛樝༟儡䄣䨥䴧䤩堫尭䔯就娳張嘷崹主弽␿⭁⭃㕅㹇⍉⥋㥍罏⅑ㅓ㩕㵗㥙⡛ⱝᕟౡ੣ཥ٧൩ṫ཭ᑯ᭱᭳յ๷፹᥻ॽ깿嬨", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00021A94 File Offset: 0x0001FC94
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)258801665;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)139329538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1734279169;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 2:
					goto IL_E9;
				}
				IL_57:
				num = (short)926744576;
				short num3 = num;
				switch (connectionId)
				{
				case 1:
					goto IL_143;
				case 2:
					goto IL_C5;
				case 3:
				case 4:
					goto IL_150;
				case 5:
					goto IL_B8;
				case 6:
					goto IL_EB;
				default:
					num = (short)1853423616;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_B8:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_C5:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_E9:
			goto IL_150;
			IL_EB:
			num = (short)1521867102;
			short num4 = num;
			num = (short)331077982;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_E9;
			default:
				num = (short)1050214400;
				if (num != 0)
				{
				}
				this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
				return;
			}
			IL_143:
			this.RadioView = (global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosView)target;
			return;
			IL_150:
			this._contentLoaded = true;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00021BF8 File Offset: 0x0001FDF8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1162477570;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1E:
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)390135811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					while (connectionId != 4)
					{
						num = (short)1515522463;
						short num3 = num;
						num = (short)628165023;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1841037312;
							if (num != 0)
							{
							}
							num = (short)1357447168;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					goto IL_15D;
				}
				IL_34:
				num = (short)444923905;
				if (num != 0)
				{
				}
				num = (short)1372323840;
				short num4 = num;
				if (connectionId == 3)
				{
					break;
				}
				num = (short)239009793;
				num2 = (int)((global::System.IntPtr)num);
			}
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_15D:
			((global::System.Windows.Controls.CheckBox)target).Click += this.a;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00021D7C File Offset: 0x0001FF7C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectRunningRadiosView()
		{
			int a_ = 4;
			short num = (short)356762290;
			short num2 = num;
			num = (short)1399636658;
			switch (num2 == num)
			{
			}
			num = (short)391118849;
			if (num != 0)
			{
			}
			num = (short)1185087488;
			if (num != 0)
			{
			}
			num = (short)1211039744;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("즹\udbbd겿ꟁꟃ닅觇ꛉꃋ", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosView), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x040000D4 RID: 212
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x040000D5 RID: 213
		internal global::Motorola.CommonCPS.RadioManagement.Radio.SelectRunningRadiosView RadioView;

		// Token: 0x040000D6 RID: 214
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x040000D7 RID: 215
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000D8 RID: 216
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000D9 RID: 217
		private bool _contentLoaded;
	}
}
