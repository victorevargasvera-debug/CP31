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
using Motorola.CommonCPS.RadioManagement.ConfigurationEditor;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.LanguagePack
{
	// Token: 0x02000003 RID: 3
	public class ImportLanguagePackView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public ImportLanguagePackView()
		{
			this.InitializeComponent();
			this.dgrImportLanguagePack.Records.CollectionChanged += this.a;
			this.dgrImportLanguagePack.Sorting += this.a;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002168 File Offset: 0x00000368
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002220 File Offset: 0x00000420
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)1475215360;
				short num2 = num;
				num = (short)214760550;
				short num3 = num;
				num = (short)1593900134;
				switch (num3 == num)
				{
				}
				num = (short)423886848;
				if (num != 0)
				{
				}
				num = (short)1896480769;
				if (num != 0)
				{
				}
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)729808896;
				short num2 = num;
				num = (short)1328957047;
				short num3 = num;
				num = (short)615859831;
				switch (num3 == num)
				{
				}
				num = (short)799997953;
				if (num != 0)
				{
				}
				num = (short)1947402240;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022DC File Offset: 0x000004DC
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 4;
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
					if (isChecked == null)
					{
						num2 = (short)2062811139;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20C;
				case 1:
					flag = isChecked.GetValueOrDefault();
					goto IL_246;
				case 2:
					num2 = (short)643497985;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)1311113216;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_B6;
								}
								continue;
							case 1:
								num2 = (short)877527042;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_1A1;
							case 3:
							{
								if (enumerator.MoveNext())
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ཛ㭝౟ݡݣብ൧๩", a_)], flag2);
									num2 = (short)1960509444;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)48242221;
								short num3 = num2;
								num2 = (short)941432365;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)6553600;
									if (num2 != 0)
									{
									}
									num2 = (short)473300993;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							}
							IL_B8:
							num2 = (short)612696067;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_B6:
							goto IL_B8;
						}
						IL_1A1:
						return;
					}
					finally
					{
						num2 = (short)1178730497;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)461111298;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1D6;
								}
								continue;
							case 2:
								goto IL_209;
							}
							IL_1D6:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)161939456;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_209:;
					}
					goto IL_20C;
				case 3:
					num2 = (short)566689796;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					flag = true;
					goto IL_246;
				}
				goto IL_2D;
				IL_20C:
				num2 = (short)1301807105;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_246:
				flag2 = flag;
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrImportLanguagePack.Records).GetEnumerator();
				num2 = (short)1895956480;
				short num4 = num2;
				num2 = (short)274333698;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2D:
			this.dgrImportLanguagePack.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			num2 = (short)1649606656;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000025CC File Offset: 0x000007CC
		private void a(object A_0, global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs A_1)
		{
			short num = (short)1559625728;
			short num2 = num;
			num = (short)180748289;
			if (num != 0)
			{
			}
			num = (short)188903910;
			short num3 = num;
			num = (short)744452582;
			switch (num3 == num)
			{
			}
			num = (short)1526726656;
			if (num != 0)
			{
			}
			this.isSorting = true;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002680 File Offset: 0x00000880
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 16;
			short num = (short)1974599681;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_59;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					try
					{
						num = (short)1138163712;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_BF;
								}
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)275578884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("㭧ཀྵk୭፯ٱᅳት", a_)], false);
								num = (short)1615527939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_1B1;
							case 3:
							{
								num = (short)25652153;
								short num3 = num;
								num = (short)434138041;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1841233920;
									if (num != 0)
									{
									}
									break;
								}
								break;
							}
							case 4:
								num = (short)445120514;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_15C:
							num = (short)328269825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BF:
							goto IL_15C;
						}
						IL_1B1:
						goto IL_28D;
					}
					finally
					{
						num = (short)1383006209;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)354091010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1E8;
								}
								continue;
							case 2:
								goto IL_21C;
							}
							IL_1E8:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1181876224;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_21C:;
					}
					goto IL_21F;
				}
				IL_3A:
				if (this.isSorting)
				{
					num = (short)4849664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_21F:
				this.dgrImportLanguagePack.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges);
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrImportLanguagePack.Records).GetEnumerator();
				num = (short)727318530;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_59:
			num = (short)1440612352;
			short num4 = num;
			num = (short)970522625;
			if (num != 0)
			{
			}
			this.isSorting = false;
			return;
			IL_28D:
			this.IsSelectAll = new bool?(false);
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackViewModel).SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002964 File Offset: 0x00000B64
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 16;
			short num = (short)440926208;
			short num2 = num;
			num = (short)207495404;
			short num3 = num;
			num = (short)2025464044;
			switch (num3 == num)
			{
			}
			num = (short)1346830337;
			if (num != 0)
			{
			}
			num = (short)1135738880;
			if (num != 0)
			{
			}
			this.dgrImportLanguagePack.HideColumn(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("⑧୩ɫ७կ፱፳፵㹷᭹ᅻ᝽ﮁ", a_));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002A30 File Offset: 0x00000C30
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 4;
			short num = (short)1956380672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1593180161;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
				bool? flag3;
				for (;;)
				{
					IL_58:
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (!dataRecord.IsActive)
						{
							num = (short)34734080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34B;
					case 2:
						try
						{
							num = (short)1973813251;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								bool? flag2;
								bool flag4;
								switch (num2)
								{
								case 0:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									if (dataRecord2 != dataRecord)
									{
										num = (short)1765277706;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1962278912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_172;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_10B;
									}
									continue;
								case 4:
									goto IL_2D9;
								case 5:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									if (!(dataRecord2 is global::Infragistics.Windows.DataPresenter.HeaderRecord))
									{
										num = (short)469237766;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
									bool flag = bool.Parse(dataRecord2.GetCellValue(dataRecord2.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ཛ㭝౟ݡݣብ൧๩", a_)]).ToString());
									flag2 = flag3;
									flag4 = flag;
									num = (short)1669005319;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_28C;
								case 8:
									num = (short)179765252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									if (enumerator.MoveNext())
									{
										global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
										num = (short)1467547653;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1254877884;
									short num3 = num;
									num = (short)925035196;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_28C;
									default:
										num = (short)1397948416;
										if (num != 0)
										{
										}
										num = (short)1769472008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									flag3 = null;
									num = (short)798294018;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_177:
								num = (short)1637613577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_28C:
								if (!(flag2.GetValueOrDefault() == flag4 & flag2 != null))
								{
									num = (short)2035154945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_10B:
								goto IL_177;
							}
							IL_172:
							IL_2D9:
							goto IL_3BD;
						}
						finally
						{
							num = (short)1218248705;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1021378562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_310;
									}
									continue;
								case 2:
									goto IL_348;
								}
								IL_310:
								if (enumerator == null)
								{
									break;
								}
								num = (short)941359104;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_348:;
						}
						goto IL_34B;
					}
					goto IL_6B;
					IL_34B:
					flag3 = new bool?(bool.Parse(A_1.NewValue.ToString()));
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrImportLanguagePack.Records).GetEnumerator();
					num = (short)1800404992;
					short num4 = num;
					num = (short)1607860226;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3BD:
				this.IsSelectAll = flag3;
				return;
				IL_6B:
				dataRecord = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)793116673;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002E20 File Offset: 0x00001020
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 7;
			short num = (short)359795477;
			short num2 = num;
			num = (short)1860635413;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)321257472;
				if (num != 0)
				{
				}
				if (this._contentLoaded)
				{
					num = (short)765788161;
					if (num != 0)
					{
					}
					num = (short)155123712;
					short num3 = num;
					return;
				}
				break;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("灞Ⱡౢᅤࡦ᭨ѪŬ๮彰ひᩴ᩶ᑸᑺ፼㱾톀킂ꮄ햆\udc90ﮔﺘﺚ爵쾠힢认좨얪쪬\udaae킰풲킴\ud8b8\ud8ba횼蒾ꋀ곂꣄럆ꛈꗊ꣌ꇎꗐﳒ볔뫖꧘듚꿜ꯞ跠苢诤胦鳨諪諬諮臰鋲雴鳶迸鋺飼裾⸀樂栄眆昈礊礌挎瀐紒爔或砘簚砜漞䀠䀢两儦䀨个娬Į䤰刲場嬶", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002F00 File Offset: 0x00001100
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1129578498;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)253296640;
					short num3 = num;
					num = (short)196345857;
					if (num != 0)
					{
					}
					num = (short)397982923;
					short num4 = num;
					num = (short)1718664395;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_137;
					default:
						num = (short)84082688;
						if (num != 0)
						{
						}
						num = (short)1808531457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_135;
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
					goto IL_144;
				case 2:
					goto IL_C5;
				case 3:
				case 4:
					goto IL_168;
				case 5:
					goto IL_B8;
				case 6:
					goto IL_137;
				default:
					num = (short)1302134784;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_B8:
			this.btnImport = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_C5:
			this.dgrImportLanguagePack = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_135:
			goto IL_168;
			IL_137:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_144:
			this.LanguagePackView = (global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackView)target;
			this.LanguagePackView.Loaded += this.a;
			return;
			IL_168:
			this._contentLoaded = true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000307C File Offset: 0x0000127C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)560726019;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 4)
					{
						goto IL_13C;
					}
					goto IL_156;
				case 1:
				{
					num = (short)1057030144;
					short num3 = num;
					num = (short)645005313;
					if (num != 0)
					{
					}
					num = (short)1938961154;
					short num4 = num;
					num = (short)97465090;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13C;
					default:
						num = (short)1615593472;
						if (num != 0)
						{
						}
						num = (short)380502016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				if (connectionId != 3)
				{
					num = (short)79233025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13C:
				num = (short)516030466;
				num2 = (int)((global::System.IntPtr)num);
			}
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_156:
			((global::System.Windows.Controls.CheckBox)target).Click += this.b;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000031F8 File Offset: 0x000013F8
		// Note: this type is marked as 'beforefieldinit'.
		static ImportLanguagePackView()
		{
			int a_ = 7;
			short num = (short)1898132991;
			short num2 = num;
			num = (short)633812479;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1013121024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)350289921;
			if (num != 0)
			{
			}
			num = (short)1576271872;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.ConfigurationEditor.Styles.d("ᙞበぢd୦౨ࡪᥬ⹮ᵰὲ", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackView), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x04000003 RID: 3
		private bool isSorting;

		// Token: 0x04000004 RID: 4
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x04000005 RID: 5
		internal global::Motorola.CommonCPS.RadioManagement.LanguagePack.ImportLanguagePackView LanguagePackView;

		// Token: 0x04000006 RID: 6
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrImportLanguagePack;

		// Token: 0x04000007 RID: 7
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnImport;

		// Token: 0x04000008 RID: 8
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000009 RID: 9
		private bool _contentLoaded;
	}
}
