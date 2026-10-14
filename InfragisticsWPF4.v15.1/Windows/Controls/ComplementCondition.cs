using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Markup;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000163 RID: 355
	[global::System.Windows.Markup.ContentProperty("SourceCondition")]
	[global::System.ComponentModel.DefaultProperty("SourceCondition")]
	public class ComplementCondition : global::Infragistics.Windows.Controls.ICondition, global::System.ICloneable
	{
		// Token: 0x06000C22 RID: 3106 RVA: 0x000285B8 File Offset: 0x000267B8
		public ComplementCondition()
		{
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000285C0 File Offset: 0x000267C0
		public ComplementCondition(global::Infragistics.Windows.Controls.ICondition sourceCondition)
		{
			this._sourceCondition = sourceCondition;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x000285D0 File Offset: 0x000267D0
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Controls.ComplementCondition complementCondition = obj as global::Infragistics.Windows.Controls.ComplementCondition;
			return complementCondition != null && object.Equals(complementCondition._sourceCondition, this._sourceCondition);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000285FA File Offset: 0x000267FA
		public override int GetHashCode()
		{
			if (this._sourceCondition == null)
			{
				return 100;
			}
			return this._sourceCondition.GetHashCode();
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00028614 File Offset: 0x00026814
		public override string ToString()
		{
			return global::SR.GetString("ComplementCondition", new object[]
			{
				this.SourceCondition
			});
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0002863C File Offset: 0x0002683C
		object global::System.ICloneable.Clone()
		{
			return new global::Infragistics.Windows.Controls.ComplementCondition((global::Infragistics.Windows.Controls.ICondition)this._sourceCondition.Clone());
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00028653 File Offset: 0x00026853
		public bool IsMatch(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			return this._sourceCondition == null || !this._sourceCondition.IsMatch(value, context);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0002866F File Offset: 0x0002686F
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00028677 File Offset: 0x00026877
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

		// Token: 0x040005D4 RID: 1492
		private global::Infragistics.Windows.Controls.ICondition _sourceCondition;

		// Token: 0x02000164 RID: 356
		internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
		{
			// Token: 0x17000217 RID: 535
			// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00028680 File Offset: 0x00026880
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

			// Token: 0x06000C2C RID: 3116 RVA: 0x000286C0 File Offset: 0x000268C0
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

			// Token: 0x06000C2D RID: 3117 RVA: 0x00028700 File Offset: 0x00026900
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

			// Token: 0x040005D5 RID: 1493
			private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
		}
	}
}
