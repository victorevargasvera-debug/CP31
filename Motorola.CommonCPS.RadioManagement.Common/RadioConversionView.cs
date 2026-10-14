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
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200001C RID: 28
	public class RadioConversionView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000099 RID: 153 RVA: 0x0000B828 File Offset: 0x00009A28
		public RadioConversionView()
		{
			this.InitializeComponent();
			this.dgrRadios.Records.CollectionChanged += this.a;
			this.dgrRadios.Sorting += this.a;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000B874 File Offset: 0x00009A74
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000B92C File Offset: 0x00009B2C
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)1197015040;
				short num2 = num;
				num = (short)41420404;
				short num3 = num;
				num = (short)955844212;
				switch (num3 == num)
				{
				}
				num = (short)1389166592;
				if (num != 0)
				{
				}
				num = (short)1597046785;
				if (num != 0)
				{
				}
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)1916403712;
				short num2 = num;
				num = (short)463998559;
				short num3 = num;
				num = (short)1512640095;
				switch (num3 == num)
				{
				}
				num = (short)311820289;
				if (num != 0)
				{
				}
				num = (short)494469120;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 14;
			int num;
			bool? isChecked;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
					bool flag2;
					switch (num)
					{
					case 0:
						if (isChecked == null)
						{
							num2 = (short)566493185;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1C4;
					case 1:
						num2 = (short)403963906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						num2 = (short)574029824;
						short num3 = num2;
						num2 = (short)1164469930;
						short num4 = num2;
						num2 = (short)1220306602;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_45;
						default:
							num2 = (short)1765998592;
							if (num2 != 0)
							{
							}
							flag = true;
							goto IL_273;
						}
						break;
					}
					case 3:
						flag = isChecked.GetValueOrDefault();
						goto IL_273;
					case 4:
						try
						{
							num2 = (short)1068171264;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_B9;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num2 = (short)788529155;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("돟蟡裣菥诧黩觫諭", a_)], flag2);
									num2 = (short)1127743490;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 3:
									num2 = (short)668991492;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 4:
									goto IL_157;
								}
								IL_BB:
								num2 = (short)1606025217;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_B9:
								goto IL_BB;
							}
							IL_157:
							return;
						}
						finally
						{
							num2 = (short)1043005440;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_18D;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num2 = (short)1163853826;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 2:
									goto IL_1C1;
								}
								IL_18D:
								if (enumerator == null)
								{
									break;
								}
								num2 = (short)1816592385;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_1C1:;
						}
						goto IL_1C4;
					}
					goto IL_2D;
					IL_1C4:
					num2 = (short)1467351043;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_273:
					flag2 = flag;
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
					num2 = (short)619708417;
					if (num2 != 0)
					{
					}
					num2 = (short)830799876;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
			}
			IL_2D:
			this.dgrRadios.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			IL_45:
			num2 = (short)2077949952;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs A_1)
		{
			short num = (short)1694629888;
			short num2 = num;
			num = (short)1370561813;
			short num3 = num;
			num = (short)467672341;
			switch (num3 == num)
			{
			}
			num = (short)1277558784;
			if (num != 0)
			{
			}
			num = (short)1175650305;
			if (num != 0)
			{
			}
			this.isSorting = true;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000BD84 File Offset: 0x00009F84
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)1127546880;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)49019806;
					short num3 = num;
					num = (short)677772190;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27D;
					case 1:
						break;
					default:
					{
						num = (short)1802174464;
						short num4 = num;
						break;
					}
					}
					num = (short)137232384;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B2;
					}
					continue;
				}
				case 1:
					goto IL_D2;
				case 2:
					try
					{
						num = (short)2019033088;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_137;
								}
								continue;
							case 2:
								num = (short)292356100;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)861995010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("藕뷗뛙맛뷝铟蟡胣", a_)], false);
								num = (short)1815740417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_1D1;
							}
							IL_185:
							num = (short)398065667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_137:
							goto IL_185;
						}
						IL_1D1:
						goto IL_285;
					}
					finally
					{
						num = (short)333053952;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_206;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)450101250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_23C;
							}
							IL_206:
							if (enumerator == null)
							{
								break;
							}
							num = (short)321323009;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_23C:;
					}
					goto IL_23F;
				}
				IL_B2:
				if (this.isSorting)
				{
					num = (short)2086404097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_23F:
				this.dgrRadios.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges);
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
				num = (short)400031746;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D2:
			num = (short)1750663169;
			if (num != 0)
			{
			}
			IL_27D:
			this.isSorting = false;
			return;
			IL_285:
			this.IsSelectAll = new bool?(false);
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionViewModel).SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000C054 File Offset: 0x0000A254
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 17;
			short num = (short)2044198912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
				bool? flag3;
				for (;;)
				{
					IL_30:
					num = (short)585350044;
					short num3 = num;
					num = (short)1091877788;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)508428288;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
						switch (num2)
						{
						case 0:
							if (!dataRecord.IsActive)
							{
								num = (short)1279787009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34E;
						case 1:
							return;
						case 2:
							num = (short)1535770625;
							if (num != 0)
							{
							}
							try
							{
								num = (short)712769541;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
										if (!(dataRecord2 is global::Infragistics.Windows.DataPresenter.HeaderRecord))
										{
											num = (short)1191444483;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										num = (short)1559691271;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_2DE;
									case 3:
									{
										global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
										bool flag = bool.Parse(dataRecord2.GetCellValue(dataRecord2.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("냢胤详賨裪駬諮闰", a_)]).ToString());
										bool? flag2 = flag3;
										bool flag4 = flag;
										num = (short)1671954442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1926889481;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
										num = (short)366936064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_15D;
										}
										continue;
									case 6:
										goto IL_1C3;
									case 7:
									{
										global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
										if (dataRecord2 != dataRecord)
										{
											num = (short)1604386824;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										flag3 = null;
										num = (short)1558511622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										num = (short)84541442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										bool? flag2;
										bool flag4;
										if (!(flag2.GetValueOrDefault() == flag4 & flag2 != null))
										{
											num = (short)1107623937;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_1C8:
									num = (short)1990459396;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_15D:
									goto IL_1C8;
								}
								IL_1C3:
								IL_2DE:
								goto IL_3BA;
							}
							finally
							{
								num = (short)1600192512;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_315;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)859897858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_34B;
									}
									IL_315:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1529806849;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_34B:;
							}
							goto IL_34E;
						}
						goto IL_8F;
						IL_34E:
						flag3 = new bool?(bool.Parse(A_1.NewValue.ToString()));
						enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
						break;
					}
					}
					num = (short)1099038722;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3BA:
				this.IsSelectAll = flag3;
				return;
				IL_8F:
				num = (short)1128398848;
				short num4 = num;
				dataRecord = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)1669595136;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000C440 File Offset: 0x0000A640
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 5;
			short num = (short)1700598208;
			short num2 = num;
			num = (short)1954156992;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)248512512;
				short num3 = num;
				num = (short)868286464;
				if (num != 0)
				{
				}
				num = (short)165543937;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铘듚꧜냞鏠賢觤蛦쟨꣪苬苮鳰鳲鯴듶꧸꣺폼귾怀朂氄栆䐈樊挌渎瘐瘒研爖眘漚㌜尞丠丢䠤䠦䜨ဪ丬䀮尰䌲娴夶尸唺䤼ှ㍀≂⅄⹆♈⡊≌ⅎ❐㙒❔⑖じ㑚㍜⥞ࡠ٢ቤ䡦᭨੪६ٮṰၲᩴ᥶ླྀṺོ౾戴ꆎﮖ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000C524 File Offset: 0x0000A724
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2031026176;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1540698389;
				short num3 = num;
				num = (short)395653397;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_13A;
				default:
				{
					num = (short)953024512;
					if (num != 0)
					{
					}
					num = (short)1743781888;
					short num4 = num;
					switch (num2)
					{
					case 0:
						num = (short)1801584641;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D0;
						}
						continue;
					case 1:
						num = (short)64421890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_13A;
					}
					IL_D0:
					switch (connectionId)
					{
					case 1:
						goto IL_149;
					case 2:
						goto IL_116;
					case 3:
					case 4:
						goto IL_156;
					case 5:
						goto IL_109;
					case 6:
						goto IL_13C;
					default:
						num = (short)348389377;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_109:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_116:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_13A:
			goto IL_156;
			IL_13C:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_149:
			this.RadioView = (global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionView)target;
			return;
			IL_156:
			this._contentLoaded = true;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000C690 File Offset: 0x0000A890
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)932052992;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)344214623;
				short num3 = num;
				num = (short)1455574111;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1975320576;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					case 1:
						goto IL_13C;
					case 2:
						num = (short)1228144641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					}
					IL_82:
					num = (short)1926823936;
					short num4 = num;
					if (connectionId != 3)
					{
						num = (short)1912995842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7;
				}
				}
				IL_13C:
				if (connectionId == 4)
				{
					goto IL_159;
				}
				num = (short)1415315459;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C7:
			num = (short)816971777;
			if (num != 0)
			{
			}
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_159:
			((global::System.Windows.Controls.CheckBox)target).Click += this.a;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000C810 File Offset: 0x0000AA10
		// Note: this type is marked as 'beforefieldinit'.
		static RadioConversionView()
		{
			int a_ = 7;
			short num = (short)1857969334;
			short num2 = num;
			num = (short)858217654;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2043609088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1578696705;
			if (num != 0)
			{
			}
			num = (short)1516830720;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("郘꣚軜뫞跠蛢蛤鏦꣨蟪臬", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionView), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x04000097 RID: 151
		private bool isSorting;

		// Token: 0x04000098 RID: 152
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x04000099 RID: 153
		internal global::Motorola.CommonCPS.RadioManagement.Common.RadioConversionView RadioView;

		// Token: 0x0400009A RID: 154
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x0400009B RID: 155
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400009C RID: 156
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400009D RID: 157
		private bool _contentLoaded;
	}
}
