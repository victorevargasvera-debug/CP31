using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000FC RID: 252
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class XCommentWrapper : global::Newtonsoft.Json.Converters.XObjectWrapper
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00033313 File Offset: 0x00031513
		[global::System.Runtime.CompilerServices.Nullable(1)]
		private global::System.Xml.Linq.XComment Text
		{
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				return (global::System.Xml.Linq.XComment)base.WrappedNode;
			}
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00033320 File Offset: 0x00031520
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public XCommentWrapper(global::System.Xml.Linq.XComment text) : base(text)
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00033329 File Offset: 0x00031529
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00033336 File Offset: 0x00031536
		public override string Value
		{
			get
			{
				return this.Text.Value;
			}
			set
			{
				this.Text.Value = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00033344 File Offset: 0x00031544
		public override global::Newtonsoft.Json.Converters.IXmlNode ParentNode
		{
			get
			{
				if (this.Text.Parent == null)
				{
					return null;
				}
				return global::Newtonsoft.Json.Converters.XContainerWrapper.WrapNode(this.Text.Parent);
			}
		}
	}
}
