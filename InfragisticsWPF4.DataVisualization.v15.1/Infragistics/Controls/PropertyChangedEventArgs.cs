using System;
using System.ComponentModel;

namespace Infragistics.Controls
{
	// Token: 0x02000058 RID: 88
	public class PropertyChangedEventArgs<T> : global::System.ComponentModel.PropertyChangedEventArgs
	{
		// Token: 0x0600046F RID: 1135 RVA: 0x0001165D File Offset: 0x0000F85D
		public PropertyChangedEventArgs(string propertyName, T oldValue, T newValue) : base(propertyName)
		{
			this.OldValue = oldValue;
			this.NewValue = newValue;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00011674 File Offset: 0x0000F874
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0001167C File Offset: 0x0000F87C
		public T OldValue { get; private set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00011685 File Offset: 0x0000F885
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0001168D File Offset: 0x0000F88D
		public T NewValue { get; private set; }
	}
}
