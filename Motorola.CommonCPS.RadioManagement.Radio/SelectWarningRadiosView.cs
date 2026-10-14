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
	// Token: 0x0200001D RID: 29
	public class SelectWarningRadiosView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0001A2EC File Offset: 0x000184EC
		public SelectWarningRadiosView()
		{
			this.InitializeComponent();
			this.dgrWarningRadios.Records.CollectionChanged += this.a;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0001A324 File Offset: 0x00018524
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0001A3DC File Offset: 0x000185DC
		public bool? IsSelectAll
		{
			get
			{
				short num = (short)1584791553;
				if (num != 0)
				{
				}
				num = (short)1292836372;
				short num2 = num;
				num = (short)1040915988;
				switch (num2 == num)
				{
				}
				num = (short)1146355712;
				if (num != 0)
				{
				}
				num = (short)1147994112;
				short num3 = num;
				return (bool?)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosView.IsSelectAllProperty);
			}
			set
			{
				short num = (short)491727105;
				short num2 = num;
				num = (short)9644289;
				switch (num2 == num)
				{
				}
				num = (short)1647706113;
				if (num != 0)
				{
				}
				num = (short)455802880;
				if (num != 0)
				{
				}
				num = (short)285802496;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosView.IsSelectAllProperty, value);
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0001A494 File Offset: 0x00018694
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
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
						num2 = (short)1049165825;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_152;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_B9;
								}
								continue;
							case 3:
								num2 = (short)594673664;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)639631363;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
								dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꖿ껁ꇃꗅ볇꿉꣋", a_)], flag);
								num2 = (short)1368522754;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_BB:
							num2 = (short)1546059780;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_B9:
							goto IL_BB;
						}
						IL_152:
						return;
					}
					finally
					{
						for (;;)
						{
							IL_157:
							num2 = (short)1077805058;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_20C;
								case 1:
									enumerator.Dispose();
									num2 = (short)1360330752;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_189;
									}
									continue;
								}
								IL_189:
								if (enumerator == null)
								{
									goto IL_20E;
								}
								num2 = (short)263911588;
								short num3 = num2;
								num2 = (short)1110440100;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_157;
								default:
									num2 = (short)181993472;
									if (num2 != 0)
									{
									}
									num2 = (short)540540929;
									num = (int)((global::System.IntPtr)num2);
									break;
								}
							}
						}
						IL_20C:
						IL_20E:;
					}
					goto IL_20F;
				case 1:
					if (isChecked == null)
					{
						num2 = (short)558759940;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20F;
				case 2:
					flag2 = true;
					goto IL_29C;
				case 3:
				{
					num2 = (short)215613440;
					short num4 = num2;
					num2 = (short)1205403649;
					if (num2 != 0)
					{
					}
					flag2 = isChecked.GetValueOrDefault();
					goto IL_29C;
				}
				case 4:
					num2 = (short)464912386;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2D;
				IL_20F:
				num2 = (short)218890243;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_29C:
				flag = flag2;
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrWarningRadios.Records).GetEnumerator();
				num2 = (short)1898315776;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2D:
			this.dgrWarningRadios.ActiveRecord = null;
			isChecked = (A_0 as global::System.Windows.Controls.CheckBox).IsChecked;
			num2 = (short)2120351745;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0001A77C File Offset: 0x0001897C
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)1078722561;
			if (num != 0)
			{
			}
			this.dgrWarningRadios.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges);
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrWarningRadios.Records).GetEnumerator();
			try
			{
				num = (short)1926627329;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_126;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 2:
						num = (short)788463616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)957153282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
						dataRecord.SetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("\udfb9킻\udbbdꎿ뛁ꇃꋅ", a_)], false);
						num = (short)142606340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_D8:
					num = (short)1231945731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C:
					goto IL_D8;
				}
				IL_126:;
			}
			finally
			{
				for (;;)
				{
					IL_12B:
					num = (short)661716994;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1E1;
						case 1:
							enumerator.Dispose();
							num = (short)899153920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_15B;
							}
							continue;
						}
						IL_15B:
						if (enumerator == null)
						{
							goto IL_1E3;
						}
						num = (short)1176399925;
						short num3 = num;
						num = (short)1997369397;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12B;
						default:
							num = (short)981729280;
							if (num != 0)
							{
							}
							num = (short)1874788353;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				IL_1E1:
				IL_1E3:;
			}
			num = (short)302645248;
			short num4 = num;
			this.IsSelectAll = new bool?(false);
			(base.DataContext as global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosViewModel).SelectedAllCheckChangedCommand.Execute(this.IsSelectAll);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001A9D4 File Offset: 0x00018BD4
		private void a(object A_0, global::System.Windows.RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 10;
			short num = (short)1033240576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1474232320;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2;
				bool? flag3;
				for (;;)
				{
					IL_5C:
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1654915074;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (!(dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord))
									{
										num = (short)23068677;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)150142980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_139;
									}
									continue;
								case 3:
									num = (short)1452212231;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									if (dataRecord != dataRecord2)
									{
										num = (short)685178889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
									bool flag = bool.Parse(dataRecord.GetCellValue(dataRecord.FieldLayout.Fields[global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("ꖿ껁ꇃꗅ볇꿉꣋", a_)]).ToString());
									bool? flag2 = flag3;
									bool flag4 = flag;
									num = (short)1555365896;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2125463555;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = enumerator.Current as global::Infragistics.Windows.DataPresenter.DataRecord;
									num = (short)1335361536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_2B8;
								case 8:
								{
									bool? flag2;
									bool flag4;
									if (!(flag2.GetValueOrDefault() == flag4 & flag2 != null))
									{
										num = (short)1798176769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									flag3 = null;
									num = (short)1522401290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_19F;
								}
								IL_1A4:
								num = (short)1136525318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_139:
								goto IL_1A4;
							}
							IL_19F:
							IL_2B8:
							goto IL_3C5;
						}
						finally
						{
							for (;;)
							{
								IL_2BD:
								num = (short)36372482;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_37B;
									case 1:
										enumerator.Dispose();
										num = (short)1942487040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2F1;
										}
										continue;
									}
									IL_2F1:
									if (enumerator == null)
									{
										goto IL_37D;
									}
									num = (short)1975298552;
									short num4 = num;
									num = (short)1841080824;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2BD;
									default:
										num = (short)1779826688;
										if (num != 0)
										{
										}
										num = (short)1252065281;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
							}
							IL_37B:
							IL_37D:;
						}
						goto IL_37E;
					case 1:
						return;
					case 2:
						num = (short)1605697537;
						if (num != 0)
						{
						}
						if (!dataRecord2.IsActive)
						{
							num = (short)127270913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37E;
					}
					goto IL_6F;
					IL_37E:
					flag3 = new bool?(bool.Parse(A_1.NewValue.ToString()));
					enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrWarningRadios.Records).GetEnumerator();
					num = (short)684392448;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3C5:
				this.IsSelectAll = flag3;
				return;
				IL_6F:
				dataRecord2 = ((A_0 as global::Infragistics.Windows.Editors.XamCheckEditor).DataContext as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)91160578;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5C;
			}
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0001ADCC File Offset: 0x00018FCC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			short num = (short)2134310912;
			short num2 = num;
			num = (short)342978989;
			short num3 = num;
			num = (short)1211330989;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2039480320;
				if (num != 0)
				{
				}
				num = (short)1253703681;
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
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("鮳﮵ힷ캹펻첽꾿껁ꗃ诇ꗉꇋꏍ뿏병韓蛕诗軛뿝蓟诡诣ꯥ觧蓩跫觭闯鿱釳飵賷퓹껻鿽擿欁欃㴅欇攉愋縍缏簑焓砕気㔙漛紝䠟䜡䀣匥䐧伩䘫䄭刯䐱崳匵伷ᔹ伻嬽ⰿ❁❃㉅㽇⭉㹋⁍㥏㱑㍓⑕㥗㹙㕛ㅝ፟ᑡൣͥὧ䑩ᑫ཭ᵯṱ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001AEAC File Offset: 0x000190AC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)342491138;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)647114129;
				short num3 = num;
				num = (short)2058759569;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_136;
				default:
				{
					num = (short)1056374784;
					if (num != 0)
					{
					}
					num = (short)252575744;
					short num4 = num;
					switch (num2)
					{
					case 0:
						goto IL_136;
					case 1:
						num = (short)1581711361;
						if (num != 0)
						{
						}
						num = (short)340000768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					IL_A1:
					switch (connectionId)
					{
					case 1:
						goto IL_145;
					case 2:
						goto IL_E7;
					case 3:
					case 4:
						goto IL_152;
					case 5:
						goto IL_DA;
					case 6:
						goto IL_138;
					default:
						num = (short)134676481;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_DA:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_E7:
			this.dgrWarningRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_136:
			goto IL_152;
			IL_138:
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_145:
			this.usc_SelectWarningRadios = (global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosView)target;
			return;
			IL_152:
			this._contentLoaded = true;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0001B014 File Offset: 0x00019214
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1917386753;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)575838961;
				short num3 = num;
				num = (short)770939633;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)761856000;
					if (num != 0)
					{
					}
					num = (short)1832517632;
					short num4 = num;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 2:
						num = (short)1599799299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_116;
					}
					IL_AB:
					if (connectionId != 3)
					{
						num = (short)529465346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C8;
				}
				}
				IL_116:
				num = (short)1777926145;
				if (num != 0)
				{
				}
				if (connectionId == 4)
				{
					goto IL_15D;
				}
				num = (short)1707671552;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C8:
			global::System.Windows.EventSetter eventSetter = new global::System.Windows.EventSetter();
			eventSetter.Event = global::Infragistics.Windows.Editors.ValueEditor.ValueChangedEvent;
			eventSetter.Handler = new global::System.Windows.RoutedPropertyChangedEventHandler<object>(this.a);
			((global::System.Windows.Style)target).Setters.Add(eventSetter);
			return;
			IL_15D:
			((global::System.Windows.Controls.CheckBox)target).Click += this.a;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0001B198 File Offset: 0x00019398
		// Note: this type is marked as 'beforefieldinit'.
		static SelectWarningRadiosView()
		{
			int a_ = 14;
			short num = (short)1364994227;
			short num2 = num;
			num = (short)1324099763;
			switch (num2 == num)
			{
			}
			num = (short)729088000;
			short num3 = num;
			num = (short)460783617;
			if (num != 0)
			{
			}
			num = (short)1319763968;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosView.IsSelectAllProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Radio.WiFiPasswordValidationViewModel.c("证럃闅귇ꛉ꧋귍꓏鏑룓뫕", a_), typeof(bool?), typeof(global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosView), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x040000A3 RID: 163
		public static readonly global::System.Windows.DependencyProperty IsSelectAllProperty;

		// Token: 0x040000A4 RID: 164
		internal global::Motorola.CommonCPS.RadioManagement.Radio.SelectWarningRadiosView usc_SelectWarningRadios;

		// Token: 0x040000A5 RID: 165
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrWarningRadios;

		// Token: 0x040000A6 RID: 166
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x040000A7 RID: 167
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x040000A8 RID: 168
		private bool _contentLoaded;
	}
}
