using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000161 RID: 353
	public class ConditionGroup : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Controls.ICondition>, global::Infragistics.Windows.Controls.ICondition, global::System.ICloneable
	{
		// Token: 0x06000C13 RID: 3091 RVA: 0x00028068 File Offset: 0x00026268
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = obj as global::Infragistics.Windows.Controls.ConditionGroup;
			if (conditionGroup == null || conditionGroup._logicalOperator != this._logicalOperator || conditionGroup.Count != base.Count)
			{
				return false;
			}
			int i = 0;
			int count = base.Count;
			while (i < count)
			{
				if (!object.Equals(base[i], conditionGroup[i]))
				{
					return false;
				}
				i++;
			}
			return true;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000280C8 File Offset: 0x000262C8
		public override int GetHashCode()
		{
			int num = this._logicalOperator.GetHashCode();
			int i = 0;
			int count = base.Count;
			while (i < count)
			{
				global::Infragistics.Windows.Controls.ICondition condition = base[i];
				if (condition != null)
				{
					num |= condition.GetHashCode();
				}
				i++;
			}
			return num;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0002810E File Offset: 0x0002630E
		public override string ToString()
		{
			return global::SR.GetString("ConditionGroup_Description");
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0002811A File Offset: 0x0002631A
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00028131 File Offset: 0x00026331
		public object ToolTip
		{
			get
			{
				if (this._tooltip != null)
				{
					return this._tooltip;
				}
				return this.FormatToolTipText();
			}
			set
			{
				this._tooltip = value;
				this.RaisePropertyChanged("ToolTip");
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x00028145 File Offset: 0x00026345
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x0002814D File Offset: 0x0002634D
		public global::Infragistics.Windows.Controls.LogicalOperator LogicalOperator
		{
			get
			{
				return this._logicalOperator;
			}
			set
			{
				if (this._logicalOperator != value)
				{
					global::Infragistics.Windows.Utilities.ThrowIfInvalidEnum(value, "LogicalOperator");
					this._logicalOperator = value;
					this.RaisePropertyChanged("LogicalOperator");
				}
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0002817C File Offset: 0x0002637C
		object global::System.ICloneable.Clone()
		{
			global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = new global::Infragistics.Windows.Controls.ConditionGroup();
			conditionGroup._logicalOperator = this._logicalOperator;
			foreach (global::Infragistics.Windows.Controls.ICondition condition in this)
			{
				conditionGroup.Add((global::Infragistics.Windows.Controls.ICondition)condition.Clone());
			}
			return conditionGroup;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000281E4 File Offset: 0x000263E4
		public bool IsMatch(object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
		{
			global::Infragistics.Windows.Controls.LogicalOperator logicalOperator = this.LogicalOperator;
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Controls.ICondition condition = base[i];
				if (condition.IsMatch(value, context))
				{
					if (global::Infragistics.Windows.Controls.LogicalOperator.Or == logicalOperator)
					{
						return true;
					}
				}
				else if (logicalOperator == global::Infragistics.Windows.Controls.LogicalOperator.And)
				{
					return false;
				}
			}
			return count == 0 || global::Infragistics.Windows.Controls.LogicalOperator.And == logicalOperator;
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00028234 File Offset: 0x00026434
		private string FormatToolTipText()
		{
			int count = base.Count;
			if (count == 0)
			{
				return string.Empty;
			}
			if (count == 1)
			{
				return base[0].ToString();
			}
			if (count > 2 && this._logicalOperator == global::Infragistics.Windows.Controls.LogicalOperator.Or)
			{
				global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = base[0] as global::Infragistics.Windows.Controls.ComparisonCondition;
				if (comparisonCondition != null)
				{
					global::Infragistics.Windows.Controls.ComparisonOperator? comparisonOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(comparisonCondition.Operator);
					if (comparisonOperator == global::Infragistics.Windows.Controls.ComparisonOperator.Equals)
					{
						for (int i = 1; i < count; i++)
						{
							comparisonCondition = (base[i] as global::Infragistics.Windows.Controls.ComparisonCondition);
							if (comparisonCondition == null || comparisonCondition.Operator != comparisonOperator)
							{
								comparisonOperator = null;
								break;
							}
						}
						if (comparisonOperator != null)
						{
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							string text = global::System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
							if (string.IsNullOrEmpty(text))
							{
								text = " ";
							}
							else if (text.Length == 1 && !char.IsWhiteSpace(text[0]))
							{
								text += " ";
							}
							for (int j = 0; j < count; j++)
							{
								if (j > 0)
								{
									stringBuilder.Append(text);
								}
								stringBuilder.Append(((global::Infragistics.Windows.Controls.ComparisonCondition)base[j]).Value);
							}
							return global::SR.GetString("ConditionGroup_Equals", new object[]
							{
								stringBuilder.ToString()
							});
						}
					}
				}
			}
			string text2 = null;
			string @string;
			if (this.LogicalOperator == global::Infragistics.Windows.Controls.LogicalOperator.And)
			{
				@string = global::SR.GetString("ConditionGroup_Logical_AND");
			}
			else
			{
				@string = global::SR.GetString("ConditionGroup_Logical_OR");
			}
			for (int k = 0; k < count; k++)
			{
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = base[k] as global::Infragistics.Windows.Controls.ConditionGroup;
				string text3;
				if (conditionGroup != null)
				{
					text3 = conditionGroup.FormatToolTipText();
					text3 = global::SR.GetString("ConditionGroup_Group", new object[]
					{
						text3
					});
				}
				else
				{
					text3 = base[k].ToString();
				}
				if (text2 == null)
				{
					text2 = text3;
				}
				else
				{
					try
					{
						text2 = string.Format(@string, new object[]
						{
							text2,
							text3
						});
					}
					catch
					{
					}
				}
			}
			return text2;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00028474 File Offset: 0x00026674
		private void RaisePropertyChanged(string propName)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("LogicalOperator"));
		}

		// Token: 0x040005D1 RID: 1489
		private global::Infragistics.Windows.Controls.LogicalOperator _logicalOperator;

		// Token: 0x040005D2 RID: 1490
		private object _tooltip;

		// Token: 0x02000162 RID: 354
		internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
		{
			// Token: 0x17000215 RID: 533
			// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00028488 File Offset: 0x00026688
			public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
			{
				get
				{
					if (this._props == null)
					{
						this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
						{
							new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(global::Infragistics.Windows.Controls.LogicalOperator), "LogicalOperator"),
							new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(global::Infragistics.Windows.Controls.ICondition), "[]")
						};
					}
					return this._props;
				}
			}

			// Token: 0x06000C1F RID: 3103 RVA: 0x000284E0 File Offset: 0x000266E0
			public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
			{
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = (global::Infragistics.Windows.Controls.ConditionGroup)obj;
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				dictionary["LogicalOperator"] = conditionGroup.LogicalOperator;
				dictionary["[]"] = conditionGroup;
				return dictionary;
			}

			// Token: 0x06000C20 RID: 3104 RVA: 0x00028520 File Offset: 0x00026720
			public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
			{
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = new global::Infragistics.Windows.Controls.ConditionGroup();
				object obj;
				if (values.TryGetValue("LogicalOperator", out obj))
				{
					conditionGroup.LogicalOperator = (global::Infragistics.Windows.Controls.LogicalOperator)obj;
				}
				if (values.TryGetValue("[]", out obj))
				{
					foreach (object obj2 in ((global::System.Collections.IEnumerable)obj))
					{
						global::Infragistics.Windows.Controls.ICondition item = (global::Infragistics.Windows.Controls.ICondition)obj2;
						conditionGroup.Add(item);
					}
				}
				return conditionGroup;
			}

			// Token: 0x040005D3 RID: 1491
			private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
		}
	}
}
