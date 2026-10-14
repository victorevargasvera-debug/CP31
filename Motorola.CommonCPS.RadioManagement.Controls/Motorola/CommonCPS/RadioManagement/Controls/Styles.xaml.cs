using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000BB RID: 187
	public partial class Styles : ResourceDictionary, IStyleConnector
	{
		// Token: 0x060004D1 RID: 1233 RVA: 0x0004E840 File Offset: 0x0004CA40
		private void grdContainer_MouseLeftButtonUp(object A_0, MouseButtonEventArgs A_1)
		{
			short num = (short)127577743;
			short num2 = num;
			num = (short)246066831;
			switch (num2 == num)
			{
			}
			num = (short)1790181377;
			if (num != 0)
			{
			}
			num = (short)900005888;
			if (num != 0)
			{
			}
			num = (short)272564224;
			short num3 = num;
			((Grid)A_0).Children[1].Focus();
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0004E900 File Offset: 0x0004CB00
		private void msiPassword_ExecutingCommand(object A_0, ExecutingCommandEventArgs A_1)
		{
			int a_ = 14;
			short num = (short)1537081344;
			short num2 = num;
			num = (short)426721245;
			short num3 = num;
			num = (short)1022574557;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_ED:
				num = (short)126025729;
				if (num != 0)
				{
				}
				num = (short)2144206852;
				num4 = (int)((IntPtr)num);
				break;
			default:
				num = (short)1499004928;
				if (num != 0)
				{
				}
				num = (short)1185939459;
				num4 = (int)((IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_115;
				case 1:
					return;
				case 2:
					goto IL_ED;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_B9;
					}
					continue;
				case 4:
					if (A_1.Command.Name == CustomRightMouseDownBehaviour.c("\udda7\udea9", a_))
					{
						num = (short)178388992;
						num4 = (int)((IntPtr)num);
						continue;
					}
					return;
				}
				IL_B9:
				if (!(A_1.Command.Name == CustomRightMouseDownBehaviour.c("잧\udaa9햫", a_)))
				{
					num = (short)928186370;
					num4 = (int)((IntPtr)num);
					continue;
				}
				IL_115:
				A_1.Cancel = true;
				num = (short)828637185;
				num4 = (int)((IntPtr)num);
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0004EA98 File Offset: 0x0004CC98
		private void XamIPMaskedEditor_ValueChanged(object A_0, RoutedPropertyChangedEventArgs<object> A_1)
		{
			int a_ = 15;
			short num = (short)526974976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				XamMaskedEditor xamMaskedEditor;
				for (;;)
				{
					IL_30:
					StringBuilder stringBuilder;
					string value;
					int num3;
					switch (num2)
					{
					case 0:
					{
						string[] array;
						if (array != null)
						{
							num = (short)2078933002;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_22C;
					}
					case 1:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1449590801;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_306;
					}
					case 2:
					{
						string text;
						if (text.Contains(CustomRightMouseDownBehaviour.c("覦", a_)))
						{
							num = (short)541523973;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_306;
					}
					case 3:
					{
						string text2;
						stringBuilder.Append(int.Parse(text2, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture));
						stringBuilder.Append(CustomRightMouseDownBehaviour.c("覦", a_));
						num = (short)278921225;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 4:
						goto IL_113;
					case 5:
					{
						num = (short)760938497;
						if (num != 0)
						{
						}
						string text;
						string[] array = text.Split(new char[]
						{
							'.'
						});
						num = (short)365494272;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 6:
					{
						string text = A_1.NewValue.ToString();
						value = A_1.NewValue.ToString();
						stringBuilder = new StringBuilder();
						num = (short)313393153;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 7:
					{
						string[] array2;
						if (num3 >= array2.Length)
						{
							num = (short)1555300368;
							num2 = (int)((IntPtr)num);
							continue;
						}
						string text2 = array2[num3];
						num = (short)939786254;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 8:
						goto IL_306;
					case 9:
					{
						num = (short)1672478720;
						short num4 = num;
						goto IL_113;
					}
					case 10:
					{
						string[] array;
						string[] array2 = array;
						num3 = 0;
						num = (short)838008845;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 11:
						if (A_1.NewValue != null)
						{
							num = (short)781123590;
							num2 = (int)((IntPtr)num);
							continue;
						}
						return;
					case 12:
						goto IL_325;
					case 13:
						goto IL_2C7;
					case 14:
					{
						string text2;
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)303890435;
							num2 = (int)((IntPtr)num);
							continue;
						}
						stringBuilder.Append(text2);
						stringBuilder.Append(CustomRightMouseDownBehaviour.c("覦", a_));
						num = (short)178651140;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 15:
						goto IL_2C7;
					case 16:
						goto IL_22C;
					case 17:
						num = (short)870121474;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
					IL_113:
					num3++;
					num = (short)1792213007;
					num2 = (int)((IntPtr)num);
					continue;
					IL_22C:
					int startIndex = stringBuilder.ToString().LastIndexOf('.');
					value = stringBuilder.ToString().Remove(startIndex);
					num = (short)1403191304;
					num2 = (int)((IntPtr)num);
					continue;
					IL_2C7:
					num = (short)1758461959;
					num2 = (int)((IntPtr)num);
					continue;
					IL_306:
					xamMaskedEditor.Value = value;
					num = (short)1133641740;
					num2 = (int)((IntPtr)num);
				}
				IL_7F:
				xamMaskedEditor = (A_0 as XamMaskedEditor);
				num = (short)1016676760;
				short num5 = num;
				num = (short)348471704;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_325:
					break;
				default:
					num = (short)2080571392;
					if (num != 0)
					{
					}
					num = (short)1365639179;
					num2 = (int)((IntPtr)num);
					goto IL_30;
				}
				return;
			}
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0004EFA8 File Offset: 0x0004D1A8
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)1780752640;
			short num2 = num;
			num = (short)214769920;
			switch (num2 == num)
			{
			}
			num = (short)764936192;
			if (num != 0)
			{
			}
			num = (short)1554841600;
			short num3 = num;
			num = (short)1975975937;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0004F108 File Offset: 0x0004D308
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			EventSetter eventSetter;
			switch (connectionId)
			{
			case 1:
				((Grid)target).MouseLeftButtonUp += this.grdContainer_MouseLeftButtonUp;
				return;
			case 2:
				((Grid)target).MouseLeftButtonUp += this.grdContainer_MouseLeftButtonUp;
				return;
			case 3:
				((Grid)target).MouseLeftButtonUp += this.grdContainer_MouseLeftButtonUp;
				return;
			case 4:
				break;
			case 5:
				eventSetter = new EventSetter();
				eventSetter.Event = ValueEditor.ValueChangedEvent;
				eventSetter.Handler = new RoutedPropertyChangedEventHandler<object>(this.XamIPMaskedEditor_ValueChanged);
				((Style)target).Setters.Add(eventSetter);
				return;
			default:
			{
				short num = (short)1893400577;
				if (num != 0)
				{
				}
				num = (short)2065810799;
				short num2 = num;
				num = (short)1943455087;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_ED;
				case 1:
					break;
				default:
				{
					num = (short)1442512896;
					short num3 = num;
					break;
				}
				}
				num = (short)1693581312;
				if (num != 0)
				{
				}
				return;
			}
			}
			IL_ED:
			eventSetter = new EventSetter();
			eventSetter.Event = XamMaskedEditor.ExecutingCommandEvent;
			eventSetter.Handler = new EventHandler<ExecutingCommandEventArgs>(this.msiPassword_ExecutingCommand);
			((Style)target).Setters.Add(eventSetter);
		}
	}
}
