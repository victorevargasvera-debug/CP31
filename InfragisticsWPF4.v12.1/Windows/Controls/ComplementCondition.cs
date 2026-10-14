using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Markup;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000145 RID: 325
	[global::System.Windows.Markup.ContentProperty("SourceCondition")]
	[global::System.ComponentModel.DefaultProperty("SourceCondition")]
	public class ComplementCondition : global::Infragistics.Windows.Controls.ICondition, global::System.ICloneable
	{
		// Token: 0x06000B1F RID: 2847 RVA: 0x000249F4 File Offset: 0x00022BF4
		public ComplementCondition()
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000249FC File Offset: 0x00022BFC
		public ComplementCondition(global::Infragistics.Windows.Controls.ICondition sourceCondition)
		{
			this._sourceCondition = sourceCondition;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00024A0C File Offset: 0x00022C0C
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Controls.ComplementCondition complementCondition = obj as global::Infragistics.Windows.Controls.ComplementCondition;
			return complementCondition != null && object.Equals(complementCondition._sourceCondition, this._sourceCondition);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00024A36 File Offset: 0x00022C36
		public override int GetHashCode()
		{
			if (this._sourceCondition == null)
			{
				return 100;
			}
			return this._sourceCondition.GetHashCode();
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00024A50 File Offset: 0x00022C50
		public override string ToString()
		{
			return global::SR.GetString("ComplementCondition", new object[]
			{
				this.SourceCondition
			});
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00024A78 File Offset: 0x00022C78
		object global::System.ICloneable.Clone()
		{
			return new global::Infragistics.Windows.Controls.ComplementCondition((global::Infragistics.Windows.Controls.ICondition)this._sourceCondition.Clone());
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00024A8F File Offset: 0x00022C8F
		public bool IsMatch(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			return this._sourceCondition == null || !this._sourceCondition.IsMatch(value, context);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00024AAB File Offset: 0x00022CAB
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00024AB3 File Offset: 0x00022CB3
		public global::Infragistics.Windows.Controls.ICondition SourceCondition
		{
			get
			{
				return this._sourceCondition;
			}
			set
			{
				this._sourceCondition = value;
			}
		}

		// Token: 0x0400051C RID: 1308
		private global::Infragistics.Windows.Controls.ICondition _sourceCondition;

		// Token: 0x02000146 RID: 326
		internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
		{
			// Token: 0x170001FD RID: 509
			// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00024ABC File Offset: 0x00022CBC
			public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
			{
				get
				{
					if (this._props == null)
					{
						this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
						{
							new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(global::Infragistics.Windows.Controls.ICondition), "[]")
						};
					}
					return this._props;
				}
			}

			// Token: 0x06000B29 RID: 2857 RVA: 0x00024AFC File Offset: 0x00022CFC
			public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
			{
				global::Infragistics.Windows.Controls.ComplementCondition complementCondition = (global::Infragistics.Windows.Controls.ComplementCondition)obj;
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				if (complementCondition.SourceCondition != null)
				{
					dictionary["[]"] = new global::Infragistics.Windows.Controls.ICondition[]
					{
						complementCondition.SourceCondition
					};
				}
				return dictionary;
			}

			// Token: 0x06000B2A RID: 2858 RVA: 0x00024B3C File Offset: 0x00022D3C
			public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
			{
				object obj;
				if (values.TryGetValue("[]", out obj))
				{
					using (global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)obj).GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							global::Infragistics.Windows.Controls.ICondition sourceCondition = (global::Infragistics.Windows.Controls.ICondition)enumerator.Current;
							return new global::Infragistics.Windows.Controls.ComplementCondition(sourceCondition);
						}
					}
				}
				return null;
			}

			// Token: 0x0400051D RID: 1309
			private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
		}
	}
}
