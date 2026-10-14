using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x0200006D RID: 109
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class LockUpdateCheckBox : global::System.Windows.Controls.CheckBox
	{
		// Token: 0x06000732 RID: 1842 RVA: 0x00096E48 File Offset: 0x00095048
		static LockUpdateCheckBox()
		{
			short num = (short)285852166;
			short num2 = num;
			num = (short)1782366726;
			switch (num2 == num)
			{
			}
			num = (short)1953103872;
			if (num != 0)
			{
			}
			num = (short)515899393;
			if (num != 0)
			{
			}
			num = (short)1869348864;
			short num3 = num;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.LockUpdateCheckBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.Primitives.LockUpdateCheckBox)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.LockUpdateCheckBox), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.LockUpdateCheckBox), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00096F54 File Offset: 0x00095154
		protected override void OnChecked(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)593518352;
			short num2 = num;
			num = (short)1376542480;
			switch (num2 == num)
			{
			}
			num = (short)808583169;
			if (num != 0)
			{
			}
			num = (short)608698368;
			if (num != 0)
			{
			}
			num = (short)387252224;
			short num3 = num;
			this.UpdateLockState();
			base.OnChecked(e);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0009700C File Offset: 0x0009520C
		protected override void OnUnchecked(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1893660955;
			short num2 = num;
			num = (short)449575195;
			switch (num2 == num)
			{
			}
			num = (short)821755905;
			if (num != 0)
			{
			}
			num = (short)1091698688;
			if (num != 0)
			{
			}
			num = (short)2089746432;
			short num3 = num;
			this.UpdateLockState();
			base.OnUnchecked(e);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000970C8 File Offset: 0x000952C8
		protected virtual void UpdateLockState()
		{
			short num = (short)630652928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				global::DevComponents.WpfEditors.Primitives.EditorGroup editorGroup;
				for (;;)
				{
					IL_29:
					global::System.Collections.IEnumerator enumerator;
					bool value;
					bool flag2;
					switch (num2)
					{
					case 0:
						num = (short)946864129;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1918894081;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								bool flag;
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)874577928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1365311498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_FF;
									}
									continue;
								case 2:
									goto IL_262;
								case 3:
									flag = false;
									goto IL_205;
								case 4:
								{
									global::System.Windows.UIElement uielement;
									uielement.IsEnabled = value;
									num = (short)2121465867;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Windows.UIElement uielement;
									flag = uielement.Focusable;
									goto IL_205;
								}
								case 7:
								{
									global::System.Windows.UIElement uielement;
									uielement.Focus();
									flag2 = false;
									num = (short)1328349189;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)2061631490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1516699654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::System.Windows.UIElement uielement;
									if (uielement != this)
									{
										num = (short)512294916;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									if (value)
									{
										num = (short)559349769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1033895939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_16A:
								num = (short)548601856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_205:
								if (flag && flag2)
								{
									num = (short)50659335;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FF:
								goto IL_16A;
							}
							IL_262:
							return;
						}
						finally
						{
							for (;;)
							{
								IL_267:
								switch (0)
								{
								case 0:
									goto IL_284;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_271:
									switch (num2)
									{
									case 0:
										goto IL_32A;
									case 1:
										if (disposable != null)
										{
											num = (short)1279852546;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_32C;
									case 2:
									{
										num = (short)2055417985;
										short num3 = num;
										num = (short)563359873;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_267;
										default:
											num = (short)911802368;
											if (num != 0)
											{
											}
											disposable.Dispose();
											num = (short)1245642752;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								IL_284:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)2059927553;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_271;
							}
							IL_32A:
							IL_32C:;
						}
						goto IL_32D;
					case 1:
						if (editorGroup == null)
						{
							num = (short)239861762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32D;
					case 2:
						goto IL_79;
					}
					goto IL_3C;
					IL_32D:
					value = base.IsChecked.Value;
					flag2 = true;
					enumerator = editorGroup.Items.GetEnumerator();
					num = (short)1683881984;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_79:
				num = (short)656146432;
				short num4 = num;
				return;
				IL_3C:
				editorGroup = (base.Parent as global::DevComponents.WpfEditors.Primitives.EditorGroup);
				num = (short)982777857;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}
	}
}
