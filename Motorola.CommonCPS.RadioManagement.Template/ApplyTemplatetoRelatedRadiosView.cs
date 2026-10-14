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

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x0200000D RID: 13
	public class ApplyTemplatetoRelatedRadiosView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00008A8C File Offset: 0x00006C8C
		public ApplyTemplatetoRelatedRadiosView()
		{
			this.InitializeComponent();
			this.dgrRadios.Records.CollectionChanged += this.a;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00008AC4 File Offset: 0x00006CC4
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00008B80 File Offset: 0x00006D80
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)1029414857;
				short num2 = num;
				num = (short)589930441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)520355840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2098790401;
				if (num != 0)
				{
				}
				num = (short)1309016064;
				if (num != 0)
				{
				}
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)331595854;
				short num2 = num;
				num = (short)1386725454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977483264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)526319617;
				if (num != 0)
				{
				}
				num = (short)336527360;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008C38 File Offset: 0x00006E38
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			short num;
			int num2;
			bool? isChecked;
			for (;;)
			{
				IL_13:
				num = (short)1252524033;
				if (num != 0)
				{
				}
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
				bool flag2;
				switch (num2)
				{
				case 0:
					num = (short)1160183811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					flag = isChecked.GetValueOrDefault();
					goto IL_29D;
				case 2:
					try
					{
						num = (short)517603332;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1050935297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("圃挅搇漉漋稍甏瘑", a_)], flag2);
								num = (short)1540489219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)295829506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1A7;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_10A;
								}
								continue;
							}
							IL_10C:
							num = (short)802357248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_10A:
							goto IL_10C;
						}
						IL_1A7:
						return;
					}
					finally
					{
						num = (short)1606746114;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_25E;
							case 1:
								goto IL_240;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1DC;
								}
								continue;
							}
							IL_1DC:
							num = (short)1905144168;
							short num3 = num;
							num = (short)576401768;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_240:
								enumerator.Dispose();
								num = (short)1982070784;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1249378304;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									goto IL_260;
								}
								num = (short)670760961;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_25E:
						IL_260:;
					}
					goto IL_261;
				case 3:
					flag = true;
					goto IL_29D;
				case 4:
					if (isChecked == null)
					{
						num = (short)656146432;
						short num4 = num;
						num = (short)659161088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				}
				goto IL_54;
				IL_261:
				num = (short)322830337;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_29D:
				flag2 = flag;
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
				num = (short)2062811138;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_54:
			this.dgrRadios.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			num = (short)38928388;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008F24 File Offset: 0x00007124
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 0;
			this.dgrRadios.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges);
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
			short num;
			try
			{
				num = (short)2074345476;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1234239491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
						dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("ꟳ鏵铷鿹鿻諽旿昁", a_)], false);
						num = (short)464191488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_100;
					case 3:
						num = (short)1464139778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					}
					IL_B2:
					num = (short)205914113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65:
					goto IL_B2;
				}
				IL_100:;
			}
			finally
			{
				num = (short)853671938;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1B7;
					case 1:
						goto IL_19A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_135;
						}
						continue;
					}
					IL_135:
					num = (short)1903030245;
					short num3 = num;
					num = (short)649195493;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_19A:
						enumerator.Dispose();
						num = (short)821755904;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1509621760;
						if (num != 0)
						{
						}
						if (enumerator == null)
						{
							goto IL_1B9;
						}
						num = (short)918814721;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1B7:
				IL_1B9:;
			}
			num = (short)447873025;
			if (num != 0)
			{
			}
			num = (short)1405550592;
			short num4 = num;
			this.IsSelectAll = new bool?(false);
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosViewModel).SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00009178 File Offset: 0x00007378
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 15;
			short num = (short)1456734209;
			if (num != 0)
			{
			}
			num = (short)1799880704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				bool? flag3;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
				for (;;)
				{
					IL_58:
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2104295430;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1445658629;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									num = (short)666107914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									bool flag = bool.Parse(dataRecord.GetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("倂怄欆氈栊礌樎甐", a_)]).ToString());
									bool? flag2 = flag3;
									bool flag4 = flag;
									goto IL_2A1;
								}
								case 2:
									flag3 = null;
									num = (short)1672675331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_19E;
								case 4:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (dataRecord != dataRecord2)
									{
										num = (short)128909314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1099890696;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_137;
									}
									continue;
								case 7:
								{
									num = (short)1600020908;
									short num3 = num;
									num = (short)39346604;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2A1;
									default:
										num = (short)817037312;
										if (num != 0)
										{
										}
										num = (short)784007172;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_308;
								case 9:
								{
									bool? flag2;
									bool flag4;
									if (!(flag2.GetValueOrDefault() == flag4 & flag2 != null))
									{
										num = (short)576782343;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (!(dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord))
									{
										num = (short)80084993;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1A3:
								num = (short)1494286336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_137:
								goto IL_1A3;
								IL_2A1:
								num = (short)1098711049;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_19E:
							IL_308:
							goto IL_3BF;
						}
						finally
						{
							num = (short)349765633;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)92405762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_33F;
									}
									continue;
								case 2:
									goto IL_375;
								}
								IL_33F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1655570432;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_375:;
						}
						goto IL_378;
					case 1:
						return;
					case 2:
					{
						num = (short)142999552;
						short num4 = num;
						if (!dataRecord2.IsActive)
						{
							num = (short)1411645441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_378;
					}
					}
					goto IL_6B;
					IL_378:
					flag3 = new bool?(bool.Parse(A_1.NewValue.ToString()));
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
					num = (short)1100677120;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3BF:
				this.IsSelectAll = flag3;
				return;
				IL_6B:
				dataRecord2 = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)1297547266;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00009568 File Offset: 0x00007768
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 0;
			while (this._contentLoaded)
			{
				short num = (short)919668938;
				short num2 = num;
				num = (short)1118767306;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)889913344;
					short num3 = num;
					break;
				}
				}
				num = (short)165937152;
				if (num != 0)
				{
				}
				num = (short)1823604737;
				if (num != 0)
				{
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("\udbf3믵韷軹鏻賽濿渁攃⠅䬇攉愋挍缏簑圓䘕䬗㐙丛缝䐟䬡䬣欥䤧䐩䴫䤭唯弱儳堵䰷ᐹ栻嬽ⴿ㉁⡃❅㱇⽉睋ⵍ㽏㽑⑓㥕㙗㽙㉛⩝佟͡ᑣᙥѧ፩ᡫ୭ᵯɱᡳ᝵౷όࡻᅽﲇﲍﶓ秊ﮝ힟趡얣횥\ud8a7용햫\udaad햯\udfb1쒳\udab5\ud9b7캹\ud9bb쪽꾿냁ꇃ꫅꧇뻉꧋꫍ꋏ돑냓뿕럗꧙ꫛ럝藟闡쫣黥觧蟩胫", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000964C File Offset: 0x0000784C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1733361665;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1339555840;
					short num3 = num;
					num = (short)227606530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)1881538561;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					goto IL_138;
				}
				IL_58:
				num = (short)1710215895;
				short num4 = num;
				num = (short)2073088727;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_113;
				default:
					num = (short)1330184192;
					if (num != 0)
					{
					}
					switch (connectionId)
					{
					case 1:
						goto IL_147;
					case 2:
						goto IL_113;
					case 3:
					case 4:
						goto IL_154;
					case 5:
						goto IL_106;
					case 6:
						goto IL_13A;
					default:
						num = (short)1950220288;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_106:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_113:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_138:
			goto IL_154;
			IL_13A:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_147:
			this.RadioView = (global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosView)target;
			return;
			IL_154:
			this._contentLoaded = true;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000097B4 File Offset: 0x000079B4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)378732545;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 4)
					{
						num = (short)1394147331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
				{
					num = (short)651689984;
					short num3 = num;
					num = (short)1609302016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_15A;
				}
				IL_35:
				num = (short)1878793838;
				short num4 = num;
				num = (short)621551214;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1535377409;
					if (num != 0)
					{
					}
					num = (short)1927151616;
					if (num != 0)
					{
					}
					if (connectionId == 3)
					{
						goto IL_F0;
					}
					num = (short)341508098;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F0:
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_15A:
			return;
			IL_15C:
			((global::System.Windows.Controls.CheckBox)target).Click += this.a;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00009934 File Offset: 0x00007B34
		// Note: this type is marked as 'beforefieldinit'.
		static ApplyTemplatetoRelatedRadiosView()
		{
			int a_ = 0;
			short num = (short)1049100288;
			short num2 = num;
			num = (short)1913885323;
			short num3 = num;
			num = (short)1143444107;
			switch (num3 == num)
			{
			}
			num = (short)915800065;
			if (num != 0)
			{
			}
			num = (short)1102249984;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("뷳藵꯷鿹郻鯽揿瘁䔃樅搇", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosView), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x04000031 RID: 49
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x04000032 RID: 50
		internal global::Motorola.CommonCPS.RadioManagement.Template.ApplyTemplatetoRelatedRadiosView RadioView;

		// Token: 0x04000033 RID: 51
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x04000034 RID: 52
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000035 RID: 53
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x04000036 RID: 54
		private bool _contentLoaded;
	}
}
