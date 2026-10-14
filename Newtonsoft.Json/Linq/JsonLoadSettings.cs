using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C2 RID: 194
	public class JsonLoadSettings
	{
		// Token: 0x06000AAF RID: 2735 RVA: 0x0002AB88 File Offset: 0x00028D88
		public JsonLoadSettings()
		{
			this._lineInfoHandling = global::Newtonsoft.Json.Linq.LineInfoHandling.Load;
			this._commentHandling = global::Newtonsoft.Json.Linq.CommentHandling.Ignore;
			this._duplicatePropertyNameHandling = global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling.Replace;
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002ABA5 File Offset: 0x00028DA5
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x0002ABAD File Offset: 0x00028DAD
		public global::Newtonsoft.Json.Linq.CommentHandling CommentHandling
		{
			get
			{
				return this._commentHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.Linq.CommentHandling.Ignore || value > global::Newtonsoft.Json.Linq.CommentHandling.Load)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._commentHandling = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0002ABC9 File Offset: 0x00028DC9
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x0002ABD1 File Offset: 0x00028DD1
		public global::Newtonsoft.Json.Linq.LineInfoHandling LineInfoHandling
		{
			get
			{
				return this._lineInfoHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.Linq.LineInfoHandling.Ignore || value > global::Newtonsoft.Json.Linq.LineInfoHandling.Load)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._lineInfoHandling = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002ABED File Offset: 0x00028DED
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x0002ABF5 File Offset: 0x00028DF5
		public global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling DuplicatePropertyNameHandling
		{
			get
			{
				return this._duplicatePropertyNameHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling.Replace || value > global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling.Error)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._duplicatePropertyNameHandling = value;
			}
		}

		// Token: 0x0400036F RID: 879
		private global::Newtonsoft.Json.Linq.CommentHandling _commentHandling;

		// Token: 0x04000370 RID: 880
		private global::Newtonsoft.Json.Linq.LineInfoHandling _lineInfoHandling;

		// Token: 0x04000371 RID: 881
		private global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling _duplicatePropertyNameHandling;
	}
}
