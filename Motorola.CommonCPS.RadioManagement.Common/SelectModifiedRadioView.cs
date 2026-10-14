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

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200001E RID: 30
	public class SelectModifiedRadioView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x0000D72C File Offset: 0x0000B92C
		public SelectModifiedRadioView()
		{
			this.InitializeComponent();
			this.dgrRadios.Records.CollectionChanged += this.a;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000D764 File Offset: 0x0000B964
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000D81C File Offset: 0x0000BA1C
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)973037249;
				short num2 = num;
				num = (short)1650613953;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1465581568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)999096321;
				if (num != 0)
				{
				}
				num = (short)345899008;
				if (num != 0)
				{
				}
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Common.SelectModifiedRadioView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)1257258987;
				short num2 = num;
				num = (short)1145651179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)548470784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)921174016;
				if (num != 0)
				{
				}
				num = (short)1329528833;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Common.SelectModifiedRadioView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000D8DC File Offset: 0x0000BADC
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
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
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
				bool flag2;
				switch (num)
				{
				case 0:
					num2 = (short)1909587972;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)675545088;
					short num3 = num2;
					flag = isChecked.GetValueOrDefault();
					goto IL_24F;
				}
				case 2:
					if (isChecked == null)
					{
						num2 = (short)1048510465;
						if (num2 != 0)
						{
						}
						num2 = (short)560005120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EB;
				case 3:
					try
					{
						num2 = (short)115998722;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)1317208065;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("诗뿙냛믝菟雡臣若", a_)], flag2);
								num2 = (short)1293090820;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 1:
								num2 = (short)1477705731;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_E2;
								}
								continue;
							case 3:
								goto IL_17F;
							}
							IL_E4:
							num2 = (short)408354816;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_E2:
							goto IL_E4;
						}
						IL_17F:
						return;
					}
					finally
					{
						num2 = (short)968818688;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1B4;
								}
								continue;
							case 1:
								goto IL_1E8;
							case 2:
								enumerator.Dispose();
								num2 = (short)1839333377;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_1B4:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1498873858;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1E8:;
					}
					goto IL_1EB;
				case 4:
					flag = true;
					goto IL_24F;
				}
				goto IL_2D;
				IL_1EB:
				num2 = (short)1100480513;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_24F:
				flag2 = flag;
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
				num2 = (short)746239845;
				short num4 = num2;
				num2 = (short)1760933733;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1EB;
				default:
					num2 = (short)1268645888;
					if (num2 != 0)
					{
					}
					num2 = (short)441647107;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return;
			IL_2D:
			this.dgrRadios.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			num2 = (short)73990146;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)80204462;
			short num2 = num;
			num = (short)1028313774;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)401342465;
				if (num != 0)
				{
				}
				num = (short)237895680;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
				try
				{
					num = (short)1857617922;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2013659140;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
							dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("뛤苦藨軪軬鯮铰韲", a_)], false);
							num = (short)208601088;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C7;
							}
							continue;
						case 3:
							goto IL_160;
						case 4:
							num = (short)219348995;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_114:
						num = (short)1121058817;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C7:
						goto IL_114;
					}
					IL_160:;
				}
				finally
				{
					num = (short)892862464;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_192;
							}
							continue;
						case 1:
							goto IL_1C7;
						case 2:
							enumerator.Dispose();
							num = (short)245825537;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_192:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2144993282;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1C7:;
				}
				break;
			}
			}
			num = (short)214040576;
			short num4 = num;
			this.IsSelectAll = new bool?(false);
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.SeletcMofiiedRadioViewMode).SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000DE00 File Offset: 0x0000C000
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 13;
			short num = (short)745340928;
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
						if (!dataRecord.IsActive)
						{
							goto IL_75;
						}
						goto IL_2D1;
					case 1:
					{
						try
						{
							num = (short)1462894599;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)755433473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									num = (short)556597254;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1103429635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									bool? flag;
									bool flag2;
									if (!(flag.GetValueOrDefault() == flag2 & flag != null))
									{
										num = (short)280035337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_25F;
								case 4:
									goto IL_148;
								case 5:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									if (dataRecord2 != dataRecord)
									{
										num = (short)745668618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									if (!(dataRecord2 is global::Infragistics.Windows.DataPresenter.HeaderRecord))
									{
										num = (short)2080047112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_E1;
									}
									continue;
								case 8:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									bool flag3 = bool.Parse(dataRecord2.GetCellValue(dataRecord2.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("賞蓠迢胤蓦鷨軪觬", a_)]).ToString());
									bool? flag = flag4;
									bool flag2 = flag3;
									num = (short)267976706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1227751429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									flag4 = null;
									num = (short)984481796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_14D:
								num = (short)926744576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E1:
								goto IL_14D;
							}
							IL_148:
							IL_25F:
							goto IL_340;
						}
						finally
						{
							num = (short)2091253760;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_297;
									}
									continue;
								case 1:
									goto IL_2CE;
								case 2:
									enumerator.Dispose();
									num = (short)1501233153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_297:
								if (enumerator == null)
								{
									break;
								}
								num = (short)792854530;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2CE:;
						}
						goto IL_2D1;
						IL_340:
						num = (short)2066612225;
						if (num != 0)
						{
						}
						num = (short)103480800;
						short num3 = num;
						num = (short)4783584;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_75;
						default:
							goto IL_39D;
						}
						break;
					}
					case 2:
						goto IL_8A;
					}
					goto IL_43;
					IL_75:
					num = (short)56885250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D1:
					flag4 = new bool?(bool.Parse(A_1.NewValue.ToString()));
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
					num = (short)1645805569;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8A:
				num = (short)2108227584;
				short num4 = num;
				return;
				IL_39D:
				num = (short)737542144;
				if (num != 0)
				{
				}
				this.IsSelectAll = flag4;
				return;
				IL_43:
				dataRecord = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)1540882432;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000E1E4 File Offset: 0x0000C3E4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 1;
			if (this._contentLoaded)
			{
				short num = (short)1005550431;
				short num2 = num;
				num = (short)1008827231;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)324337665;
					if (num != 0)
					{
					}
					num = (short)1978138624;
					if (num != 0)
					{
					}
					num = (short)323026944;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("ﳒ飔룖귘듚꿜냞跠苢쯤ꓦ蛨蛪胬胮鿰냲ꗴꓶퟸꧺ鳼鯾栀氂䠄昆月樊樌樎簐瘒笔挖㜘堚爜爞䰠䰢䬤ᰦ䨨䐪䀬弮帰崲倴夶䴸ᐺ似帾╀⩂⩄⑆♈╊㭌⩎⍐⁒㱔㡖㝘ⵚ㑜㩞ᙠ䱢ᙤɦը๪๬᭮ᱰᱲᅴṶὸቺ᡼᭾ﶊ붒", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1279852548;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 4)
					{
						num = (short)308871169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FD;
				case 1:
					goto IL_D3;
				case 2:
				{
					num = (short)2037252096;
					short num3 = num;
					num = (short)707133440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)592330523;
					short num4 = num;
					num = (short)578109211;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
						goto IL_13F;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (connectionId != 1)
				{
					num = (short)1545142274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D3:
				num = (short)1818624001;
				if (num != 0)
				{
				}
				num = (short)1120927747;
				num2 = (int)((global::System.IntPtr)num);
			}
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_FD:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_13F:
			num = (short)1397817344;
			if (num != 0)
			{
			}
			this._contentLoaded = true;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000E430 File Offset: 0x0000C630
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1854341123;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1809656707;
					short num3 = num;
					num = (short)105917315;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num = (short)287375360;
						if (num != 0)
						{
						}
						num = (short)997392386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					goto IL_135;
				case 3:
					num = (short)1035993089;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				}
				IL_5C:
				num = (short)246939648;
				short num4 = num;
				if (connectionId != 2)
				{
					num = (short)1743388672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_135:
				if (connectionId == 3)
				{
					goto IL_152;
				}
				num = (short)1529741313;
				num2 = (int)((global::System.IntPtr)num);
			}
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_152:
			((global::System.Windows.Controls.CheckBox)target).Click += this.a;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
		// Note: this type is marked as 'beforefieldinit'.
		static SelectModifiedRadioView()
		{
			int a_ = 1;
			short num = (short)611276920;
			short num2 = num;
			num = (short)1289967736;
			switch (num2 == num)
			{
			}
			num = (short)280756225;
			if (num != 0)
			{
			}
			num = (short)737345536;
			short num3 = num;
			num = (short)75890688;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.SelectModifiedRadioView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("髒ꛔ蓖볘럚룜볞闠ꋢ觤详", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Common.SelectModifiedRadioView), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x040000A2 RID: 162
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x040000A3 RID: 163
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x040000A4 RID: 164
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000A5 RID: 165
		private bool _contentLoaded;
	}
}
