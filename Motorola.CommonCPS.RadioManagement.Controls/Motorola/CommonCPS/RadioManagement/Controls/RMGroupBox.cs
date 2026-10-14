using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200006B RID: 107
	public class RMGroupBox : global::System.Windows.Controls.GroupBox
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00024194 File Offset: 0x00022394
		static RMGroupBox()
		{
			short num = (short)834502130;
			short num2 = num;
			num = (short)1868266994;
			switch (num2 == num)
			{
			}
			num = (short)596180992;
			if (num != 0)
			{
			}
			num = (short)728170496;
			short num3 = num;
			num = (short)267845633;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMGroupBox)));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00024260 File Offset: 0x00022460
		public RMGroupBox()
		{
			base.Initialized += this.RMGroupBox_Initialized;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00024288 File Offset: 0x00022488
		private void RMGroupBox_Initialized(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Windows.Controls.ItemsControl itemsControl;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1820721152;
					short num3 = num2;
					num2 = (short)2053636097;
					if (num2 != 0)
					{
					}
					num2 = (short)136577027;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					if (itemsControl == null)
					{
						return;
					}
					num2 = (short)778833789;
					short num4 = num2;
					num2 = (short)1966477181;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_136;
					default:
						num2 = (short)1087700992;
						if (num2 != 0)
						{
						}
						num2 = (short)1830354944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_136;
				case 3:
					if (itemsControl.Items.Count == 0)
					{
						num2 = (short)28966914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				}
				goto IL_20;
			}
			return;
			IL_136:
			return;
			IL_138:
			global::System.Windows.FrameworkElement frameworkElement = new global::System.Windows.Controls.Label();
			frameworkElement.Height = 0.01;
			frameworkElement.Loaded += this.lastControl_Loaded;
			itemsControl.Items.Add(frameworkElement);
			return;
			IL_20:
			itemsControl = (base.Content as global::System.Windows.Controls.ItemsControl);
			num2 = (short)1166475265;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00024404 File Offset: 0x00022604
		private void lastControl_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1696178640;
			short num2 = num;
			num = (short)662544848;
			global::System.Windows.Data.MultiBinding binding;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1034878976;
				if (num != 0)
				{
				}
				num = (short)1100283904;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)813563905;
					if (num != 0)
					{
					}
					num = (short)1003356160;
					short num4 = num;
					binding = new global::System.Windows.Data.MultiBinding
					{
						Converter = new global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsIsVisibleConverter()
					};
					global::System.Windows.Controls.ItemCollection items = ((global::System.Windows.Controls.ItemsControl)base.Content).Items;
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)items).GetEnumerator();
					try
					{
						num = (short)1863712770;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								num = (short)640548867;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_121;
								}
								continue;
							case 3:
								goto IL_19E;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1682571264;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								this.a((global::System.Windows.FrameworkElement)obj, ref binding);
								num = (short)2078932993;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_151:
							num = (short)1770782724;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_121:
							goto IL_151;
						}
						IL_19E:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1BD;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1AA:
							switch (num3)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)770572290;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_215;
							case 1:
								goto IL_213;
							case 2:
								disposable.Dispose();
								num = (short)307298305;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BD;
						}
						IL_213:
						IL_215:
						break;
						IL_1BD:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)985333760;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_1AA;
					}
					break;
				}
				}
				break;
			}
			}
			base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00024644 File Offset: 0x00022844
		private void a(global::System.Windows.FrameworkElement A_0, ref global::System.Windows.Data.MultiBinding A_1)
		{
			int a_ = 17;
			for (;;)
			{
				IL_09:
				short num = (short)1712455682;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1572995077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields)))
						{
							num = (short)1072627712;
							short num3 = num;
							num = (short)1695416324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_53;
						}
						continue;
					case 3:
						num = (short)1411907591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_482;
					case 5:
						num = (short)1606680577;
						if (num != 0)
						{
						}
						if (!A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorHeader)))
						{
							num = (short)419168264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74;
					case 6:
					{
						num = (short)83477846;
						short num4 = num;
						num = (short)1743701334;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)2143485952;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1216086019;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor rmfieldEditor;
									switch (num2)
									{
									case 0:
										if (rmfieldEditor.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditorFor2Fields)))
										{
											num = (short)2059730949;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										A_1.Bindings.Add(new global::System.Windows.Data.Binding
										{
											Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슪좬쎮햰삲첶覸욺醾裀냂鏄껆뫈ꋊ꿌ꏎ듐", a_), rmfieldEditor.Name), global::System.Array.Empty<object>())
										});
										num = (short)48037896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										num = (short)1070465024;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_3A4;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_234;
										}
										continue;
									case 5:
										goto IL_236;
									case 6:
										if (!enumerator.MoveNext())
										{
											num = (short)493944841;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										rmfieldEditor = enumerator.Current;
										num = (short)282394631;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										if (!rmfieldEditor.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor)))
										{
											num = (short)1123549185;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_236;
									case 9:
										num = (short)5570562;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_234;
									IL_236:
									this.a(rmfieldEditor, ref A_1);
									num = (short)1881407492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2A6:
									num = (short)1722089478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_234:
									goto IL_2A6;
								}
								IL_3A4:
								return;
							}
							finally
							{
								num = (short)1315176448;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_3DB;
										}
										continue;
									case 1:
										goto IL_40F;
									case 2:
										enumerator.Dispose();
										num = (short)739770369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_3DB:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1711210498;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_40F:;
							}
							goto IL_412;
						}
						break;
					}
					case 7:
						if (!A_0.GetType().IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialEditor)))
						{
							num = (short)1929641984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74;
					case 8:
						goto IL_412;
					}
					IL_53:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor)
					{
						num = (short)1204027395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_74:
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor> enumerable = global::Motorola.CommonCPS.RadioManagement.Controls.Utility.d<global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor>(A_0);
					enumerator = enumerable.GetEnumerator();
					num = (short)200146950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_412:
					num = (short)1515520001;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_482:
			A_1.Bindings.Add(new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슪좬쎮햰삲첶覸욺醾裀냂鏄껆뫈ꋊ꿌ꏎ듐", a_), A_0.Name), global::System.Array.Empty<object>())
			});
		}
	}
}
