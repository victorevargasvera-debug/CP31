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
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Template
{
	// Token: 0x02000003 RID: 3
	public class SaveTemplateAsView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public SaveTemplateAsView()
		{
			int a_ = 12;
			base..ctor();
			this.InitializeComponent();
			this.dgrRadios.Records.CollectionChanged += this.a;
			base.SetBinding(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView.SelectedAllCheckChangedCommandProperty, global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("叿朁栃挅欇縉椋樍儏縑砓唕瀗缙缛甝挟䨡䔣䠥伧伩䠫洭弯弱夳圵嘷帹", a_));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002174 File Offset: 0x00000374
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002230 File Offset: 0x00000430
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)156856280;
				short num2 = num;
				num = (short)1364160472;
				switch (num2 == num)
				{
				}
				num = (short)1079115776;
				short num3 = num;
				num = (short)1770848257;
				if (num != 0)
				{
				}
				num = (short)1128267776;
				if (num != 0)
				{
				}
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)569144681;
				short num2 = num;
				num = (short)943617385;
				switch (num2 == num)
				{
				}
				num = (short)238157824;
				short num3 = num;
				num = (short)1247346689;
				if (num != 0)
				{
				}
				num = (short)2077163520;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022EC File Offset: 0x000004EC
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000023A8 File Offset: 0x000005A8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			get
			{
				short num = (short)342937831;
				short num2 = num;
				num = (short)1590350055;
				switch (num2 == num)
				{
				}
				num = (short)2131558400;
				short num3 = num;
				num = (short)751828992;
				if (num != 0)
				{
				}
				num = (short)2083717121;
				if (num != 0)
				{
				}
				return (global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView.SelectedAllCheckChangedCommandProperty);
			}
			set
			{
				short num = (short)639288563;
				short num2 = num;
				num = (short)466863347;
				switch (num2 == num)
				{
				}
				num = (short)1284374528;
				short num3 = num;
				num = (short)415891457;
				if (num != 0)
				{
				}
				num = (short)1081147392;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView.SelectedAllCheckChangedCommandProperty, value);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002460 File Offset: 0x00000660
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 14;
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
					goto IL_26D;
				case 1:
					flag = true;
					goto IL_26D;
				case 2:
					goto IL_A7;
					try
					{
						for (;;)
						{
							IL_A7:
							num2 = (short)1392640004;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									num2 = (short)245760002;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 2:
									goto IL_1C6;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num2 = (short)1439432704;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("䴁球爅愇攉戋", a_)], flag2);
									num2 = (short)968032257;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_DF;
									}
									continue;
								}
								IL_E1:
								num2 = (short)1759385470;
								short num3 = num2;
								num2 = (short)676861822;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_A7;
								default:
									num2 = (short)845021184;
									if (num2 != 0)
									{
									}
									num2 = (short)1642987523;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_DF:
								goto IL_E1;
							}
						}
						IL_1C6:
						return;
					}
					finally
					{
						num2 = (short)1680211970;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)947650561;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_22F;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1FB;
								}
								continue;
							}
							IL_1FB:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)90374144;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_22F:;
					}
					goto IL_232;
				case 3:
					num2 = (short)1275592705;
					if (num2 != 0)
					{
					}
					num2 = (short)1723006977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (isChecked == null)
					{
						num2 = (short)700973059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_232;
				}
				goto IL_2D;
				IL_232:
				num2 = (short)375848960;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_26D:
				flag2 = flag;
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
				num2 = (short)906625024;
				short num4 = num2;
				num2 = (short)2140536834;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2D:
			this.dgrRadios.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			num2 = (short)759037956;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002750 File Offset: 0x00000950
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 14;
			this.dgrRadios.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges);
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
			goto IL_2D;
			short num;
			try
			{
				for (;;)
				{
					IL_2D:
					num = (short)83951620;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1220739073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)708594085;
							short num3 = num;
							num = (short)850282917;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2D;
							default:
							{
								num = (short)858587136;
								if (num != 0)
								{
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("䴁球爅愇攉戋", a_)], false);
								num = (short)1976500227;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 1:
							num = (short)2060124162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_156;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_65;
							}
							continue;
						}
						IL_101:
						num = (short)2115698688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_65:
						goto IL_101;
					}
				}
				IL_156:;
			}
			finally
			{
				num = (short)1809580034;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)969801729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1E5;
					case 2:
						num = (short)1764294657;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_1B2;
						}
						continue;
					}
					IL_1B2:
					if (enumerator == null)
					{
						break;
					}
					num = (short)485031936;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E5:;
			}
			num = (short)1306984448;
			short num4 = num;
			this.IsSelectAll = new bool?(false);
			this.SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000029AC File Offset: 0x00000BAC
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 17;
			short num = (short)2087911424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1838415873;
				if (num != 0)
				{
				}
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
							num = (short)446038025;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)315621381;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									num = (short)1534525447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_170;
								case 2:
								{
									bool? flag;
									bool flag2;
									if (!(flag.GetValueOrDefault() == flag2 & flag != null))
									{
										num = (short)1339949060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									flag3 = null;
									num = (short)2098069505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1064960010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1187840006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_28A;
								case 7:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (!(dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord))
									{
										num = (short)1278214152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									bool flag4 = bool.Parse(dataRecord.GetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("䨄眆紈戊戌愎", a_)]).ToString());
									bool? flag = flag3;
									bool flag2 = flag4;
									num = (short)186843138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_10A;
									}
									continue;
								case 10:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (dataRecord != dataRecord2)
									{
										num = (short)949551107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_175:
								num = (short)24379392;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10A:
								goto IL_175;
							}
							IL_170:
							IL_28A:
							goto IL_3BB;
						}
						finally
						{
							num = (short)1538719745;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_349;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2C1;
									}
									continue;
								case 2:
									for (;;)
									{
										enumerator.Dispose();
										num = (short)412454054;
										short num3 = num;
										num = (short)37522598;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_319;
										}
									}
									IL_319:
									num = (short)2019622912;
									if (num != 0)
									{
									}
									num = (short)874971136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2C1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1192361986;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_349:;
						}
						goto IL_34C;
					case 1:
						if (!dataRecord2.IsActive)
						{
							num = (short)33095682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34C;
					case 2:
						return;
					}
					goto IL_6B;
					IL_34C:
					num = (short)1489960960;
					short num4 = num;
					flag3 = new bool?(bool.Parse(A_1.NewValue.ToString()));
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
					num = (short)1197539328;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3BB:
				this.IsSelectAll = flag3;
				return;
				IL_6B:
				dataRecord2 = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)246480897;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002D98 File Offset: 0x00000F98
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			if (this._contentLoaded)
			{
				short num = (short)764979571;
				short num2 = num;
				num = (short)1741269363;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)405536769;
					if (num != 0)
					{
					}
					num = (short)874250240;
					if (num != 0)
					{
					}
					num = (short)486342656;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("\udbf3믵韷軹鏻賽濿渁攃⠅䬇攉愋挍缏簑圓䘕䬗㐙丛缝䐟䬡䬣欥䤧䐩䴫䤭唯弱儳堵䰷ᐹ栻嬽ⴿ㉁⡃❅㱇⽉睋ⵍ㽏㽑⑓㥕㙗㽙㉛⩝佟ᅡգၥ൧ṩ५ͭoṱᕳɵᵷ᭹ཻࡽꦅﮇ懲煉ﮙﮝ솟톡튣쾥춧\udda9芫횭톯\udfb1\ud8b3", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002E7C File Offset: 0x0000107C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1287716865;
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
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)848429056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_141;
				case 2:
					goto IL_78;
				case 3:
					goto IL_14E;
				case 4:
				case 5:
					goto IL_15B;
				case 6:
					goto IL_6B;
				case 7:
					goto IL_E6;
				default:
					num = (short)1215823874;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_6B:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_78:
			this.msiName = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_9A:
			num = (short)490412237;
			short num3 = num;
			num = (short)822089933;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_6B;
			default:
				num = (short)1485963264;
				if (num != 0)
				{
				}
				goto IL_15B;
			}
			IL_E6:
			num = (short)2113142784;
			short num4 = num;
			num = (short)1782382593;
			if (num != 0)
			{
			}
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_141:
			this.SaveTemplateView = (global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView)target;
			return;
			IL_14E:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_15B:
			this._contentLoaded = true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002FEC File Offset: 0x000011EC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1182793730;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)158715029;
					short num3 = num;
					num = (short)478399637;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					default:
						num = (short)1169489920;
						if (num != 0)
						{
						}
						num = (short)1708785667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_12D;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
				{
					num = (short)1017708544;
					short num4 = num;
					if (connectionId != 5)
					{
						num = (short)1058799617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_158;
				}
				}
				goto IL_34;
				IL_38:
				num = (short)1623654400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34:
				if (connectionId != 4)
				{
					goto IL_38;
				}
				break;
			}
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_12D:
			num = (short)1043464193;
			if (num != 0)
			{
			}
			return;
			IL_158:
			((global::System.Windows.Controls.CheckBox)target).Click += this.a;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003168 File Offset: 0x00001368
		// Note: this type is marked as 'beforefieldinit'.
		static SaveTemplateAsView()
		{
			int a_ = 16;
			short num = (short)843812560;
			short num2 = num;
			num = (short)609259216;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1709441024;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)626196480;
			if (num != 0)
			{
			}
			num = (short)1850146817;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("䴃甅嬇漉怋欍猏昑唓稕琗", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView.SelectedAllCheckChangedCommandProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Template.ShowVAPacksViewModel.b("圃挅搇漉漋稍甏瘑唓稕琗夙琛笝䌟䤡朣严䤧䐩䬫䬭启焱嬳嬵唷嬹刻娽", a_), typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>), typeof(global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x04000003 RID: 3
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x04000004 RID: 4
		public static readonly global::System.Windows.DependencyProperty SelectedAllCheckChangedCommandProperty;

		// Token: 0x04000005 RID: 5
		internal global::Motorola.CommonCPS.RadioManagement.Template.SaveTemplateAsView SaveTemplateView;

		// Token: 0x04000006 RID: 6
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox msiName;

		// Token: 0x04000007 RID: 7
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x04000008 RID: 8
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x04000009 RID: 9
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400000A RID: 10
		private bool _contentLoaded;
	}
}
