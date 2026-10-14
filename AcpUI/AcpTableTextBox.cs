using System;
using System.Windows;
using System.Windows.Media;
using Infragistics.Windows.Editors;

namespace AcpUI
{
	// Token: 0x0200002D RID: 45
	public class AcpTableTextBox : global::AcpUI.AcpTableTextBoxBase
	{
		// Token: 0x0600028A RID: 650 RVA: 0x0002F254 File Offset: 0x0002D454
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_A0;
				case 1:
				{
					num2 = (short)747703061;
					short num3 = num2;
					num2 = (short)1534069525;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)595329025;
						if (num2 != 0)
						{
						}
						num2 = (short)1830223872;
						if (num2 != 0)
						{
						}
						xamMaskedEditor.IsInEditMode = false;
						break;
					}
					num2 = (short)541786115;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (xamMaskedEditor != null)
					{
						num2 = (short)1191116800;
						short num4 = num2;
						num2 = (short)21626881;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.CaretBrush = global::System.Windows.Media.Brushes.Transparent;
					num2 = (short)34406400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_136;
				}
				goto IL_20;
			}
			IL_A0:
			IL_136:
			base.OnGotFocus(e);
			return;
			IL_20:
			xamMaskedEditor = base.FindVisualChild<global::Infragistics.Windows.Editors.XamMaskedEditor>(this);
			num2 = (short)1266155522;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
