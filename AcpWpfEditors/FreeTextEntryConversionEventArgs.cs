using System;
using System.Windows;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000028 RID: 40
	public class FreeTextEntryConversionEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600020D RID: 525 RVA: 0x00028638 File Offset: 0x00026838
		public FreeTextEntryConversionEventArgs(global::System.Windows.RoutedEvent routedEvent, string valueEntered) : base(routedEvent)
		{
			this.ValueEntered = valueEntered;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00028654 File Offset: 0x00026854
		public FreeTextEntryConversionEventArgs(global::System.Windows.RoutedEvent routedEvent, object source, string valueEntered) : base(routedEvent, source)
		{
			this.ValueEntered = valueEntered;
		}

		// Token: 0x04000147 RID: 327
		public readonly string ValueEntered;

		// Token: 0x04000148 RID: 328
		public object ControlValue;

		// Token: 0x04000149 RID: 329
		public bool IsValueConverted;
	}
}
