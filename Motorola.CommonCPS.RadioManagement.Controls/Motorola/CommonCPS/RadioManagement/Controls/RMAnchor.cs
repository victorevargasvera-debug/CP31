using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200005F RID: 95
	public class RMAnchor : global::System.Windows.Controls.Expander
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x000205B0 File Offset: 0x0001E7B0
		static RMAnchor()
		{
			int a_ = 10;
			short num = (short)817986784;
			short num2 = num;
			num = (short)1628863712;
			switch (num2 == num)
			{
			}
			num = (short)1940520961;
			if (num != 0)
			{
			}
			num = (short)153681920;
			short num3 = num;
			num = (short)44040192;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor.CaptionProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얣횥\udca7쎩쎫삭", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor.a)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor)));
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000206C8 File Offset: 0x0001E8C8
		public RMAnchor()
		{
			base.Initialized += this.RMAnchor_Initialized;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000206F0 File Offset: 0x0001E8F0
		private void RMAnchor_Initialized(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.Windows.Controls.ItemsControl itemsControl;
			global::System.Windows.Data.Binding binding;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)759097877;
					short num3 = num2;
					num2 = (short)376957461;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)891224064;
						if (num2 != 0)
						{
						}
						num2 = (short)259457025;
						if (num2 != 0)
						{
						}
						if (itemsControl != null)
						{
							num2 = (short)1671102465;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					num2 = (short)294191107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (binding != null)
					{
						num2 = (short)303562757;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					itemsControl = (base.Content as global::System.Windows.Controls.ItemsControl);
					num2 = (short)68681728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (itemsControl.Items.Count == 0)
					{
						num2 = (short)811401216;
						short num4 = num2;
						num2 = (short)355467268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18A;
				case 4:
					return;
				case 5:
					return;
				}
				goto IL_28;
			}
			return;
			IL_18A:
			global::System.Windows.FrameworkElement frameworkElement = new global::System.Windows.Controls.Label();
			frameworkElement.Height = 0.01;
			frameworkElement.Loaded += this.lastControl_Loaded;
			itemsControl.Items.Add(frameworkElement);
			return;
			IL_28:
			binding = global::System.Windows.Data.BindingOperations.GetBinding(this, global::System.Windows.UIElement.VisibilityProperty);
			num2 = (short)1313406978;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000208BC File Offset: 0x0001EABC
		private void lastControl_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1424293888;
			short num2 = num;
			num = (short)770048000;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)130482177;
				if (num != 0)
				{
				}
				global::System.Windows.Data.MultiBinding binding = new global::System.Windows.Data.MultiBinding
				{
					Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsIsVisibleConverter()
				};
				global::System.Windows.Controls.ItemCollection items = ((global::System.Windows.Controls.ItemsControl)base.Content).Items;
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)items).GetEnumerator();
				try
				{
					num = (short)369754113;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1100414978;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D6;
							}
							continue;
						case 2:
							goto IL_153;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)393216;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							this.a((global::System.Windows.FrameworkElement)obj, ref binding);
							num = (short)254541828;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_105:
						num = (short)1561460739;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D6:
						goto IL_105;
					}
					IL_153:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_175;
					}
					for (;;)
					{
						IL_162:
						switch (num3)
						{
						case 0:
							goto IL_1C9;
						case 1:
						{
							global::System.IDisposable disposable;
							disposable.Dispose();
							num = (short)1266024448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.IDisposable disposable;
							if (disposable != null)
							{
								num = (short)1135607809;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CB;
						}
						}
						goto IL_175;
					}
					IL_1C9:
					IL_1CB:
					num = (short)189962534;
					short num4 = num;
					num = (short)38639910;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_175:
						global::System.IDisposable disposable = enumerator as global::System.IDisposable;
						num = (short)1437597698;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_162;
					}
					default:
						num = (short)2080899072;
						if (num != 0)
						{
						}
						break;
					}
				}
				base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
				return;
			}
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00020AFC File Offset: 0x0001ECFC
		private void a(global::System.Windows.FrameworkElement A_0, ref global::System.Windows.Data.MultiBinding A_1)
		{
			int a_ = 4;
			short num = (short)422576133;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerator;
				switch (num2)
				{
				case 0:
					if (!A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader)))
					{
						num = (short)1052180486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73;
				case 1:
					goto IL_488;
				case 2:
					if (!A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields)))
					{
						num = (short)1727332353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73;
				case 3:
				{
					num = (short)1830354944;
					short num3 = num;
					num = (short)1487470599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)33947648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 6:
					goto IL_43F;
				case 7:
					if (!A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor)))
					{
						num = (short)124059652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73;
				case 8:
					try
					{
						num = (short)1300430854;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
							switch (num2)
							{
							case 0:
								goto IL_3AA;
							case 1:
								if (!rmfieldEditor.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor)))
								{
									num = (short)1583153161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F0;
							case 3:
								if (rmfieldEditor.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields)))
								{
									num = (short)473366535;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								A_1.Bindings.Add(new global::System.Windows.Data.Binding
								{
									Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda9b얟캡삣향톩鲫펭鲱ﶳ억펹쾻ힽꊿ껁ꇃ", a_), rmfieldEditor.Name), global::System.Array.Empty<object>())
								});
								num = (short)744292354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								num = (short)276868184;
								short num4 = num;
								num = (short)590130264;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2E3;
								default:
									num = (short)828112896;
									if (num != 0)
									{
									}
									if (!enumerator.MoveNext())
									{
										num = (short)207355912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									rmfieldEditor = enumerator.Current;
									num = (short)2008088577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_1EE;
								}
								continue;
							case 7:
								goto IL_1F0;
							case 8:
								goto IL_2E3;
							case 9:
								num = (short)1845231619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EE;
							IL_1F0:
							this.a(rmfieldEditor, ref A_1);
							num = (short)782237700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_25E:
							num = (short)928972805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1EE:
							goto IL_25E;
							IL_2E3:
							num = (short)398000128;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3AA:
						return;
					}
					finally
					{
						num = (short)1546452994;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_43C;
							case 1:
								enumerator.Dispose();
								num = (short)842465280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)957808641;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_409;
								}
								continue;
							}
							IL_409:
							if (enumerator == null)
							{
								break;
							}
							num = (short)31653889;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_43C:;
					}
					goto IL_43F;
				}
				IL_51:
				if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor)
				{
					num = (short)1899888643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_73:
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerable = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.d<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(A_0);
				enumerator = enumerable.GetEnumerator();
				num = (short)431882248;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43F:
				num = (short)746323970;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_488:
			A_1.Bindings.Add(new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\uda9b얟캡삣향톩鲫펭鲱ﶳ억펹쾻ힽꊿ껁ꇃ", a_), A_0.Name), global::System.Array.Empty<object>())
			});
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00020FB4 File Offset: 0x0001F1B4
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor rmanchor;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					rmanchor.SetValue(global::System.Windows.Automation.AutomationProperties.AutomationIdProperty, A_1.NewValue);
					num2 = (short)794689536;
					short num3 = num2;
					num2 = (short)791385156;
					short num4 = num2;
					num2 = (short)318608452;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5D;
					default:
						num2 = (short)1675952128;
						if (num2 != 0)
						{
						}
						num2 = (short)384761858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_5D;
				case 2:
					return;
				}
				goto IL_1C;
				IL_5D:
				if (rmanchor == null)
				{
					break;
				}
				num2 = (short)1143734272;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			rmanchor = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor);
			num2 = (short)295960577;
			if (num2 != 0)
			{
			}
			num2 = (short)1634664449;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000210D8 File Offset: 0x0001F2D8
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00021194 File Offset: 0x0001F394
		public string Caption
		{
			get
			{
				short num = (short)1121682799;
				short num2 = num;
				num = (short)1410415;
				switch (num2 == num)
				{
				}
				num = (short)1726087168;
				if (num != 0)
				{
				}
				num = (short)983826433;
				if (num != 0)
				{
				}
				num = (short)312541184;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor.CaptionProperty);
			}
			set
			{
				short num = (short)289572214;
				short num2 = num;
				num = (short)279938422;
				switch (num2 == num)
				{
				}
				num = (short)1486880769;
				if (num != 0)
				{
				}
				num = (short)1239220224;
				if (num != 0)
				{
				}
				num = (short)1305411584;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMAnchor.CaptionProperty, value);
				base.SetValue(global::System.Windows.Automation.AutomationProperties.AutomationIdProperty, value);
			}
		}

		// Token: 0x0400008C RID: 140
		public static readonly global::System.Windows.DependencyProperty CaptionProperty;
	}
}
