using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x0200007A RID: 122
	[global::System.Obsolete("This class has been obsoleted. To handle property changes for nested objects you should use a Binding with a nested path.", true)]
	public class NestedPropertyChangedEventArgs : global::System.ComponentModel.PropertyChangedEventArgs
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x00013AC3 File Offset: 0x00011CC3
		[global::System.Obsolete("This class has been obsoleted. To handle property changes for nested objects you should use a Binding with a nested path.", true)]
		public NestedPropertyChangedEventArgs(string propertyName, object nestedSender, global::System.ComponentModel.PropertyChangedEventArgs nestedArgs) : base(propertyName)
		{
			this._nestedSender = nestedSender;
			this._nestedArgs = nestedArgs;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00013ADA File Offset: 0x00011CDA
		public object NestedSender
		{
			get
			{
				return this._nestedSender;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00013AE2 File Offset: 0x00011CE2
		public global::System.ComponentModel.PropertyChangedEventArgs NestedArgs
		{
			get
			{
				return this._nestedArgs;
			}
		}

		// Token: 0x040001C3 RID: 451
		private object _nestedSender;

		// Token: 0x040001C4 RID: 452
		private global::System.ComponentModel.PropertyChangedEventArgs _nestedArgs;
	}
}
