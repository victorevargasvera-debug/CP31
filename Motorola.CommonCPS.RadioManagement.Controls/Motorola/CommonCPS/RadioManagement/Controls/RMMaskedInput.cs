using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Controls.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200006C RID: 108
	public class RMMaskedInput : global::Infragistics.Controls.Editors.XamMaskedInput
	{
		// Token: 0x0600022D RID: 557 RVA: 0x00024AF4 File Offset: 0x00022CF4
		static RMMaskedInput()
		{
			int a_ = 9;
			short num = (short)73770871;
			short num2 = num;
			num = (short)327919479;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1807286272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1372520448;
			if (num != 0)
			{
			}
			num = (short)1096679425;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput.TextWrappingProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욢\udda4펦ﺨ\ud9aa첬\udfae솰\udab2\udbb4킶", a_), typeof(global::System.Windows.TextWrapping), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.TextWrapping.NoWrap));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)));
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00024C04 File Offset: 0x00022E04
		public RMMaskedInput()
		{
			base.PreviewKeyDown += this.RMMaskedInput_PreviewKeyDown;
			base.PreviewKeyUp += this.RMMaskedInput_PreviewKeyUp;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00024C3C File Offset: 0x00022E3C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00024CF4 File Offset: 0x00022EF4
		public global::System.Windows.TextWrapping TextWrapping
		{
			get
			{
				short num = (short)455789301;
				short num2 = num;
				num = (short)526043893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)486670336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1902575617;
				if (num != 0)
				{
				}
				num = (short)992673792;
				if (num != 0)
				{
				}
				return (global::System.Windows.TextWrapping)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput.TextWrappingProperty);
			}
			set
			{
				short num = (short)868190484;
				short num2 = num;
				num = (short)1020299540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50397184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)312475648;
				if (num != 0)
				{
				}
				num = (short)1650196481;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput.TextWrappingProperty, value);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00024DB4 File Offset: 0x00022FB4
		private void RMMaskedInput_PreviewKeyUp(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)1912340481;
			if (num != 0)
			{
			}
			num = (short)1029963783;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Data.BindingExpression bindingExpression2;
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Data.BindingExpression bindingExpression;
					bindingExpression.UpdateSource();
					num = (short)130613254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::System.Windows.Data.BindingExpression bindingExpression;
					if (bindingExpression != null)
					{
						num = (short)1321926656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_106;
				}
				case 2:
					bindingExpression2.UpdateSource();
					goto IL_1B1;
				case 3:
					if (bindingExpression2 != null)
					{
						num = (short)734855170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					num = (short)2061863304;
					short num3 = num;
					num = (short)529303944;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B1;
					default:
					{
						num = (short)1491009536;
						if (num != 0)
						{
						}
						global::System.Windows.Data.BindingExpression bindingExpression = base.GetBindingExpression(global::Infragistics.Controls.Editors.ValueInput.ValueProperty);
						num = (short)1998127105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					return;
				case 6:
					goto IL_106;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				}
				IL_6C:
				if (A_1.Key == global::System.Windows.Input.Key.Return)
				{
					num = (short)451739648;
					short num4 = num;
					num = (short)1487208452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_106:
				bindingExpression2 = base.GetBindingExpression(global::Infragistics.Controls.Editors.ValueInput.TextProperty);
				num = (short)1423572995;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B1:
				num = (short)1237909509;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00024F8C File Offset: 0x0002318C
		private void RMMaskedInput_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			short num = (short)954073098;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_17F;
				case 1:
					if (A_1.Key != global::System.Windows.Input.Key.V)
					{
						num = (short)1043070984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17F;
				case 2:
					num = (short)1992818689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					num = (short)645005313;
					if (num != 0)
					{
					}
					num = (short)819789833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)237305856;
					short num3 = num;
					num = (short)1855455239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					if (A_1.Key != global::System.Windows.Input.Key.X)
					{
						num = (short)755761157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17F;
				case 7:
					if (A_1.Key == global::System.Windows.Input.Key.Z)
					{
						num = (short)931856384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					num = (short)1502658781;
					short num4 = num;
					num = (short)1968816349;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)453836800;
						if (num != 0)
						{
						}
						num = (short)1943928838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
					if (global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Control)
					{
						num = (short)407633922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				}
				IL_50:
				if (base.IsReadOnly)
				{
					num = (short)1284177924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_17F:
				A_1.Handled = true;
				num = (short)1725235203;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000233 RID: 563 RVA: 0x000251C8 File Offset: 0x000233C8
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0002527C File Offset: 0x0002347C
		public global::System.Func<object, bool> ValidateFun
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)65667073;
				if (num != 0)
				{
				}
				num = (short)839188480;
				short num2 = num;
				num = (short)1303187922;
				short num3 = num;
				num = (short)909382098;
				switch (num3 == num)
				{
				}
				num = (short)1578565632;
				if (num != 0)
				{
				}
				return this.<ValidateFun>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2108689035;
				short num2 = num;
				num = (short)408554123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)144769024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1997275136;
				if (num != 0)
				{
				}
				num = (short)1496186881;
				if (num != 0)
				{
				}
				this.<ValidateFun>k__BackingField = value;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0002532C File Offset: 0x0002352C
		protected override bool ValidateCurrentValue(out global::System.Exception error)
		{
			short num = (short)251723777;
			if (num != 0)
			{
			}
			num = (short)1266483203;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_CE;
				case 1:
					goto IL_144;
				case 2:
					if (this.ValidateFun != null)
					{
						num = (short)1260257281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				}
				IL_5C:
				if (!base.ValidateCurrentValue(out error))
				{
					num = (short)1481017573;
					short num3 = num;
					num = (short)1902545125;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FA;
					default:
						num = (short)1175781376;
						if (num != 0)
						{
						}
						num = (short)2134573056;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)72941570;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_CE:
			num = (short)428146688;
			short num4 = num;
			return false;
			IL_FA:
			return this.ValidateFun(base.Value);
			IL_144:
			goto IL_FA;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00025484 File Offset: 0x00023684
		public override void OnApplyTemplate()
		{
			int a_ = 8;
			short num = (short)441250192;
			short num2 = num;
			num = (short)355266960;
			switch (num2 == num)
			{
			default:
			{
				num = (short)420675584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1595736064;
			if (num != 0)
			{
			}
			num = (short)1580204033;
			if (num != 0)
			{
			}
			base.OnApplyTemplate();
			this.PART_InputTextBox = (base.GetTemplateChild(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슫\udead얯욱펵삷캹ﺻ톽뢿", a_)) as global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInputTextBox);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00025560 File Offset: 0x00023760
		public new void Focus()
		{
			short num = (short)1200947202;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1225991303;
					short num3 = num;
					num = (short)1760371847;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						goto IL_AC;
					}
					break;
				}
				case 1:
					this.PART_InputTextBox.Focus();
					num = (short)1943732224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_16;
				}
				goto IL_32;
				IL_16:
				switch (0)
				{
				case 0:
					IL_32:
					if (this.PART_InputTextBox == null)
					{
						return;
					}
					num = (short)160694273;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_AC:
			num = (short)1749155840;
			short num4 = num;
			num = (short)842596353;
			if (num != 0)
			{
			}
			num = (short)1727660032;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty TextWrappingProperty;

		// Token: 0x0400009F RID: 159
		private global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInputTextBox PART_InputTextBox;
	}
}
