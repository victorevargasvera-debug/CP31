using System;
using System.Windows.Input;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000088 RID: 136
	internal static class KeyboardHelper
	{
		// Token: 0x060009C4 RID: 2500 RVA: 0x0002AC69 File Offset: 0x00028E69
		public static void GetMetaKeyState(out bool ctrl, out bool shift)
		{
			ctrl = ((global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control);
			shift = ((global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift);
		}
	}
}
