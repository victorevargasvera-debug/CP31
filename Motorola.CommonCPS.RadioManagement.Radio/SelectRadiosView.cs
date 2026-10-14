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
	// Token: 0x02000021 RID: 33
	public class SelectRadiosView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000191 RID: 401 RVA: 0x0001CE94 File Offset: 0x0001B094
		public SelectRadiosView()
		{
			this.InitializeComponent();
			this.dgrRadios.Records.CollectionChanged += this.a;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0001CECC File Offset: 0x0001B0CC
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0001CF84 File Offset: 0x0001B184
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)893371584;
				short num2 = num;
				num = (short)189842624;
				switch (num2 == num)
				{
				}
				num = (short)1449525248;
				if (num != 0)
				{
				}
				num = (short)1630339073;
				if (num != 0)
				{
				}
				num = (short)883163136;
				short num3 = num;
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)207762837;
				short num2 = num;
				num = (short)846214549;
				switch (num2 == num)
				{
				}
				num = (short)1286864897;
				if (num != 0)
				{
				}
				num = (short)122028032;
				if (num != 0)
				{
				}
				num = (short)806879232;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001D03C File Offset: 0x0001B23C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			bool? isChecked;
			for (;;)
			{
				IL_13:
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
				bool flag;
				bool flag2;
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)187432964;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1A0;
							case 2:
							{
								num2 = (short)862243626;
								short num3 = num2;
								num2 = (short)1733610282;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_16C;
								default:
									num2 = (short)862060544;
									if (num2 != 0)
									{
									}
									num2 = (short)37158912;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1965228034;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("펵풷\udfb9\udfbb쪽ꖿꛁ", a_)], flag);
								goto IL_16C;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_B7;
								}
								continue;
							}
							IL_B9:
							num2 = (short)1052049411;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_B7:
							goto IL_B9;
							IL_16C:
							num2 = (short)1566179329;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1A0:
						return;
					}
					finally
					{
						num2 = (short)1188560898;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)2040070145;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_20C;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1D7;
								}
								continue;
							}
							IL_1D7:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1243873280;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_20C:;
					}
					goto IL_20F;
				case 1:
					flag2 = true;
					goto IL_274;
				case 2:
				{
					num2 = (short)1419313152;
					short num4 = num2;
					flag2 = isChecked.GetValueOrDefault();
					goto IL_274;
				}
				case 3:
					num2 = (short)1787428865;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (isChecked == null)
					{
						num2 = (short)1606746115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20F;
				}
				goto IL_2D;
				IL_20F:
				num2 = (short)783679490;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_274:
				flag = flag2;
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
				num2 = (short)705101825;
				if (num2 != 0)
				{
				}
				num2 = (short)1031143424;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2D:
			this.dgrRadios.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			num2 = (short)2053111812;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001D330 File Offset: 0x0001B530
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 9;
			short num = (short)1918238721;
			if (num != 0)
			{
			}
			num = (short)883752960;
			short num2 = num;
			this.dgrRadios.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges);
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
			try
			{
				num = (short)2050555908;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1A4;
					case 1:
						num = (short)1503723520;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							goto IL_172;
						}
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
						dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udabe귀ꛂꛄ돆곈꿊", a_)], false);
						num = (short)797442051;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_B8;
						}
						continue;
					}
					IL_104:
					num = (short)1629190279;
					short num4 = num;
					num = (short)1146321031;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_172:
						num = (short)55967745;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)917438464;
						if (num != 0)
						{
						}
						num = (short)1398407170;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B8:
					goto IL_104;
				}
				IL_1A4:;
			}
			finally
			{
				num = (short)74579970;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1542455297;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_20A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1D6;
						}
						continue;
					}
					IL_1D6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)396689408;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_20A:;
			}
			this.IsSelectAll = new bool?(false);
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosViewModel).SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001D594 File Offset: 0x0001B794
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 15;
			short num = (short)146931712;
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
				bool? flag3;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						num = (short)902037505;
						if (num != 0)
						{
						}
						try
						{
							num = (short)622067718;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1BB;
								case 1:
								{
									num = (short)1581955621;
									short num3 = num;
									num = (short)1072937509;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1BB;
									default:
										goto IL_2C4;
									}
									break;
								}
								case 2:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									bool flag = bool.Parse(dataRecord.GetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("郂ꃄꯆ곈꣊만꫎뗐", a_)]).ToString());
									bool? flag2 = flag3;
									bool flag4 = flag;
									num = (short)34603016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									flag3 = null;
									num = (short)137822217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (dataRecord != dataRecord2)
									{
										num = (short)733085699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)872742919;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									num = (short)1851129866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_10F;
									}
									continue;
								case 7:
									num = (short)1116602369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									bool? flag2;
									bool flag4;
									if (!(flag2.GetValueOrDefault() == flag4 & flag2 != null))
									{
										num = (short)1538457600;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_176;
								case 10:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (!(dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord))
									{
										num = (short)1453981698;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_17B:
								num = (short)780730373;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10F:
								goto IL_17B;
								IL_1BB:
								num = (short)108527620;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_176:
							goto IL_3BA;
							IL_2C4:
							num = (short)522190848;
							if (num != 0)
							{
							}
							goto IL_3BA;
						}
						finally
						{
							num = (short)835584002;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1769734145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_349;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_313;
									}
									continue;
								}
								IL_313:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1666187264;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_349:;
						}
						goto IL_34C;
					case 2:
						if (!dataRecord2.IsActive)
						{
							num = (short)67436544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34C;
					}
					goto IL_43;
					IL_34C:
					flag3 = new bool?(bool.Parse(A_1.NewValue.ToString()));
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
					num = (short)396820481;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3BA:
				this.IsSelectAll = flag3;
				return;
				IL_43:
				dataRecord2 = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)831127552;
				short num4 = num;
				num = (short)627834882;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001D980 File Offset: 0x0001BB80
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 2;
			if (this._contentLoaded)
			{
				short num = (short)1284374528;
				short num2 = num;
				num = (short)1824063489;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)443333164;
				short num3 = num;
				num = (short)1148893740;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)206569472;
					if (num != 0)
					{
					}
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("馵햹좻톽늿귁ꣃꟅ觉ꏋꏍ뷏뷑뫓闕裗觙賝臟蛡跣觥ꗧ诩苫迭韯韱駳鏵雷軹틻곽懿昁洃椅㌇椉挋挍怏紑稓猕瘗渙㌛洝䔟両䄣䔥尧堩䴫䨭夯崱䜳䀵儷弹䬻ᄽ㌿❁⡃⍅⭇㹉㹋⽍㑏㭑㭓╕⹗㍙㥛⥝也ᩡգ୥ѧ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001DA60 File Offset: 0x0001BC60
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)564264962;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2124480513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_110;
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
					goto IL_147;
				case 2:
					goto IL_76;
				case 3:
				case 4:
					goto IL_154;
				case 5:
					goto IL_69;
				case 6:
					goto IL_13A;
				default:
					num = (short)2074607616;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_69:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_76:
			num = (short)93911505;
			short num3 = num;
			num = (short)1953298897;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_110:
				num = (short)1268580353;
				if (num != 0)
				{
				}
				goto IL_154;
			default:
			{
				num = (short)983564288;
				if (num != 0)
				{
				}
				num = (short)88604672;
				short num4 = num;
				this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
				return;
			}
			}
			IL_13A:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_147:
			this.usc_SelectRadios = (global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosView)target;
			return;
			IL_154:
			this._contentLoaded = true;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1521745923;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1150797810;
					short num3 = num;
					num = (short)1412679666;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13D;
					default:
						goto IL_BE;
					}
					break;
				}
				case 1:
					goto IL_13D;
				case 2:
					num = (short)2039021569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (connectionId != 3)
				{
					num = (short)615514114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13D:
				if (connectionId == 4)
				{
					goto IL_15E;
				}
				num = (short)719519744;
				num2 = (int)((global::System.IntPtr)num);
			}
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_BE:
			num = (short)416088065;
			if (num != 0)
			{
			}
			num = (short)2123825152;
			short num4 = num;
			num = (short)1980301312;
			if (num != 0)
			{
			}
			return;
			IL_15E:
			((global::System.Windows.Controls.CheckBox)target).Click += this.a;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001DD4C File Offset: 0x0001BF4C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectRadiosView()
		{
			int a_ = 11;
			short num = (short)1520996895;
			short num2 = num;
			num = (short)295670303;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1070989312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)383713281;
			if (num != 0)
			{
			}
			num = (short)1705443328;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("닀郂ꃄꯆ곈꣊만軎뷐뿒", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosView), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x040000B4 RID: 180
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x040000B5 RID: 181
		internal global::Motorola.CommonCPS.RadioManagement.Radio.SelectRadiosView usc_SelectRadios;

		// Token: 0x040000B6 RID: 182
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x040000B7 RID: 183
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000B8 RID: 184
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000B9 RID: 185
		private bool _contentLoaded;
	}
}
