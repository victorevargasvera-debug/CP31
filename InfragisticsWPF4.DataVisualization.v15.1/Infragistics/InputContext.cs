using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics
{
	// Token: 0x02000019 RID: 25
	public class InputContext
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000861F File Offset: 0x0000681F
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00008627 File Offset: 0x00006827
		public global::System.Windows.Point ViewMousePosition
		{
			get
			{
				return this._viewMousePosition;
			}
			set
			{
				this._viewMousePosition = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00008630 File Offset: 0x00006830
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00008638 File Offset: 0x00006838
		public global::System.Windows.Point DocMousePosition
		{
			get
			{
				return this._docMousePosition;
			}
			set
			{
				this._docMousePosition = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00008641 File Offset: 0x00006841
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00008649 File Offset: 0x00006849
		public global::System.Windows.Input.Key Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Point _viewMousePosition;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Point _docMousePosition;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Input.Key _key;
	}
}
