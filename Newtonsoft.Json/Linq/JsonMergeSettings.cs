using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C3 RID: 195
	public class JsonMergeSettings
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002AC11 File Offset: 0x00028E11
		public JsonMergeSettings()
		{
			this._propertyNameComparison = global::System.StringComparison.Ordinal;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0002AC20 File Offset: 0x00028E20
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0002AC28 File Offset: 0x00028E28
		public global::Newtonsoft.Json.Linq.MergeArrayHandling MergeArrayHandling
		{
			get
			{
				return this._mergeArrayHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.Linq.MergeArrayHandling.Concat || value > global::Newtonsoft.Json.Linq.MergeArrayHandling.Merge)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._mergeArrayHandling = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002AC44 File Offset: 0x00028E44
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0002AC4C File Offset: 0x00028E4C
		public global::Newtonsoft.Json.Linq.MergeNullValueHandling MergeNullValueHandling
		{
			get
			{
				return this._mergeNullValueHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.Linq.MergeNullValueHandling.Ignore || value > global::Newtonsoft.Json.Linq.MergeNullValueHandling.Merge)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._mergeNullValueHandling = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002AC68 File Offset: 0x00028E68
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0002AC70 File Offset: 0x00028E70
		public global::System.StringComparison PropertyNameComparison
		{
			get
			{
				return this._propertyNameComparison;
			}
			set
			{
				if (value < global::System.StringComparison.CurrentCulture || value > global::System.StringComparison.OrdinalIgnoreCase)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._propertyNameComparison = value;
			}
		}

		// Token: 0x04000372 RID: 882
		private global::Newtonsoft.Json.Linq.MergeArrayHandling _mergeArrayHandling;

		// Token: 0x04000373 RID: 883
		private global::Newtonsoft.Json.Linq.MergeNullValueHandling _mergeNullValueHandling;

		// Token: 0x04000374 RID: 884
		private global::System.StringComparison _propertyNameComparison;
	}
}
