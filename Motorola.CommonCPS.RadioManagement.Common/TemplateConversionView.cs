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
	// Token: 0x02000020 RID: 32
	public class TemplateConversionView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000F3E0 File Offset: 0x0000D5E0
		public TemplateConversionView()
		{
			this.InitializeComponent();
			this.dgrTemplates.Records.CollectionChanged += this.a;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000F418 File Offset: 0x0000D618
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)2076061047;
				short num2 = num;
				num = (short)298528119;
				switch (num2 == num)
				{
				}
				num = (short)1021313025;
				if (num != 0)
				{
				}
				num = (short)1744699392;
				short num3 = num;
				num = (short)1958739968;
				if (num != 0)
				{
				}
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)1424490497;
				if (num != 0)
				{
				}
				num = (short)1858677721;
				short num2 = num;
				num = (short)321465305;
				switch (num2 == num)
				{
				}
				num = (short)843710464;
				short num3 = num;
				num = (short)1701117952;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000F590 File Offset: 0x0000D790
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 18;
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
					flag = true;
					goto IL_29C;
				case 1:
					try
					{
						num2 = (short)1988624388;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							num2 = (short)378994689;
							if (num2 != 0)
							{
							}
							switch (num)
							{
							case 1:
								goto IL_1A7;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)107610115;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("럣菥蓧迩迫髭闯雱", a_)], flag2);
								num2 = (short)465502208;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								num2 = (short)934346753;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_108;
								}
								continue;
							}
							IL_10A:
							num2 = (short)1625554946;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_108:
							goto IL_10A;
						}
						IL_1A7:
						return;
					}
					finally
					{
						num2 = (short)254345218;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_25F;
							case 1:
							{
								num2 = (short)783640834;
								short num3 = num2;
								num2 = (short)1642227970;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1E2;
								default:
									num2 = (short)42205184;
									if (num2 != 0)
									{
									}
									enumerator.Dispose();
									num2 = (short)360841216;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1DC;
								}
								continue;
							}
							goto IL_1DC;
							IL_1E2:
							num2 = (short)1908736001;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_1DC:
							if (enumerator != null)
							{
								goto IL_1E2;
							}
							break;
						}
						IL_25F:;
					}
					goto IL_262;
				case 2:
				{
					num2 = (short)1149501440;
					short num4 = num2;
					num2 = (short)2012741632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					flag = isChecked.GetValueOrDefault();
					goto IL_29C;
				case 4:
					if (isChecked == null)
					{
						num2 = (short)1488781314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_262;
				}
				goto IL_2D;
				IL_262:
				num2 = (short)747831299;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_29C:
				flag2 = flag;
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrTemplates.Records).GetEnumerator();
				num2 = (short)442433537;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2D:
			this.dgrTemplates.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			num2 = (short)1172963332;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000F884 File Offset: 0x0000DA84
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 5;
			short num = (short)1014235137;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrTemplates.Records).GetEnumerator();
			try
			{
				num = (short)860094468;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)356057089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_119;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1535705088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
						dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("蓖볘럚룜볞闠蛢臤", a_)], false);
						num = (short)819331074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					IL_C9:
					num = (short)412418051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7D:
					goto IL_C9;
				}
				IL_119:;
			}
			finally
			{
				num = (short)1720713218;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1D2;
					case 1:
					{
						num = (short)582138974;
						short num3 = num;
						num = (short)1766702174;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_155;
						default:
							num = (short)324403200;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)960102400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_14F;
						}
						continue;
					}
					goto IL_14F;
					IL_155:
					num = (short)1499332609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14F:
					if (enumerator != null)
					{
						goto IL_155;
					}
					break;
				}
				IL_1D2:;
			}
			num = (short)698351616;
			short num4 = num;
			this.IsSelectAll = new bool?(false);
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionViewMode).SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000FACC File Offset: 0x0000DCCC
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 7;
			short num = (short)1747582976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				bool? flag4;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
				for (;;)
				{
					IL_32:
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)521142276;
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
										num = (short)1458962433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1238499335;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									bool flag3 = bool.Parse(dataRecord.GetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("諘뻚뇜뫞苠韢胤菦", a_)]).ToString());
									bool? flag = flag4;
									bool flag2 = flag3;
									num = (short)1324941312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									flag4 = null;
									num = (short)1227358218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E3;
									}
									continue;
								case 5:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (!(dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord))
									{
										num = (short)1261174786;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)444792840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									num = (short)761266181;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (dataRecord != dataRecord2)
									{
										num = (short)308477955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)417005577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_263;
								case 10:
									goto IL_14B;
								}
								IL_150:
								num = (short)1523974150;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E3:
								goto IL_150;
							}
							IL_14B:
							IL_263:
							goto IL_3BB;
						}
						finally
						{
							num = (short)138149889;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1250678266;
								short num3 = num;
								num = (short)1913181690;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1855782912;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_31F;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2E5;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)378404864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2E5:
									if (enumerator == null)
									{
										goto IL_321;
									}
									break;
								}
								num = (short)1002635266;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_31F:
							IL_321:;
						}
						goto IL_322;
					case 1:
						if (!dataRecord2.IsActive)
						{
							num = (short)1486946306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_322;
					case 2:
						goto IL_8C;
					}
					goto IL_45;
					IL_322:
					flag4 = new bool?(bool.Parse(A_1.NewValue.ToString()));
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrTemplates.Records).GetEnumerator();
					num = (short)286916608;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8C:
				num = (short)1752760320;
				short num4 = num;
				num = (short)692912129;
				if (num != 0)
				{
				}
				return;
				IL_3BB:
				this.IsSelectAll = flag4;
				return;
				IL_45:
				dataRecord2 = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)1795489793;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			short num = (short)1343079715;
			short num2 = num;
			num = (short)568444195;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1898512384;
				short num3 = num;
				break;
			}
			}
			num = (short)937099265;
			if (num != 0)
			{
			}
			num = (short)1817772032;
			if (num != 0)
			{
			}
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("고賢釤裦鯨蓪臬軮\udff0냲髴髶铸铺鏼볾儀倂⬄唆栈漊搌怎尐爒笔瘖縘縚瀜稞传圢ତ搦䘨䘪䀬䀮弰࠲嘴堶吸䬺刼儾⑀ⵂㅄ框㭈⩊⥌♎㹐げ㩔㥖⽘㹚⽜ⱞࡠౢ୤ᅦh๪ᩬ䁮հᙲᡴݶᕸ᩺ॼ᩾力ﺌﺐﶒﺖﲘ뎜삠캢즤", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000FF98 File Offset: 0x0000E198
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2065367041;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_95;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					num = (short)1297154048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_CE;
				case 2:
					goto IL_74;
				case 3:
				case 4:
					goto IL_14F;
				case 5:
					goto IL_67;
				case 6:
					goto IL_9A;
				default:
					num = (short)522649602;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_67:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_74:
			this.dgrTemplates = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_95:
			goto IL_14F;
			IL_9A:
			num = (short)1050214401;
			if (num != 0)
			{
			}
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_CE:
			num = (short)443154432;
			short num3 = num;
			num = (short)102188854;
			short num4 = num;
			num = (short)1570654006;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1149173760;
				if (num != 0)
				{
				}
				this.TemplateView = (global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionView)target;
				return;
			}
			IL_14F:
			this._contentLoaded = true;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000100FC File Offset: 0x0000E2FC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1510080512;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					goto IL_9A;
				case 2:
				{
					num = (short)1460666369;
					if (num != 0)
					{
					}
					num = (short)854589440;
					short num3 = num;
					num = (short)762182718;
					short num4 = num;
					num = (short)1067252798;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
						goto IL_13F;
					}
					break;
				}
				case 3:
					num = (short)87949313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				if (connectionId != 3)
				{
					num = (short)588316675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9A:
				if (connectionId == 4)
				{
					goto IL_15A;
				}
				num = (short)212140034;
				num2 = (int)((global::System.IntPtr)num);
			}
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_13F:
			num = (short)185073664;
			if (num != 0)
			{
			}
			return;
			IL_15A:
			((global::System.Windows.Controls.CheckBox)target).Click += this.a;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0001027C File Offset: 0x0000E47C
		// Note: this type is marked as 'beforefieldinit'.
		static TemplateConversionView()
		{
			int a_ = 11;
			short num = (short)1342242816;
			short num2 = num;
			num = (short)151321709;
			short num3 = num;
			num = (short)432733293;
			switch (num3 == num)
			{
			}
			num = (short)809304065;
			if (num != 0)
			{
			}
			num = (short)483721216;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Common.ModuleCommon.b("铜곞닠蛢觤苦諨鿪곬菮鷰", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionView), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x040000AA RID: 170
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x040000AB RID: 171
		internal global::Motorola.CommonCPS.RadioManagement.Common.TemplateConversionView TemplateView;

		// Token: 0x040000AC RID: 172
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrTemplates;

		// Token: 0x040000AD RID: 173
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000AE RID: 174
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000AF RID: 175
		private bool _contentLoaded;
	}
}
