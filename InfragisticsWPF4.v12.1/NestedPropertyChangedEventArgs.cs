using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x02000063 RID: 99
	[global::System.Obsolete("This class has been obsoleted. To handle property changes for nested objects you should use a Binding with a nested path.", true)]
	public class NestedPropertyChangedEventArgs : global::System.ComponentModel.PropertyChangedEventArgs
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x00011314 File Offset: 0x0000F514
		[global::System.Obsolete("This class has been obsoleted. To handle property changes for nested objects you should use a Binding with a nested path.", true)]
		public NestedPropertyChangedEventArgs(string propertyName, object nestedSender, global::System.ComponentModel.PropertyChangedEventArgs nestedArgs) : base(propertyName)
		{
			this._nestedSender = nestedSender;
			this._nestedArgs = nestedArgs;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0001132B File Offset: 0x0000F52B
		public object NestedSender
		{
			get
			{
				return this._nestedSender;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00011333 File Offset: 0x0000F533
		public global::System.ComponentModel.PropertyChangedEventArgs NestedArgs
		{
			get
			{
				return this._nestedArgs;
			}
		}

		// Token: 0x04000154 RID: 340
		private object _nestedSender;

		// Token: 0x04000155 RID: 341
		private global::System.ComponentModel.PropertyChangedEventArgs _nestedArgs;
	}
}
