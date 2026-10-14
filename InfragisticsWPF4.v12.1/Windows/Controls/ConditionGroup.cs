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
	// Token: 0x02000143 RID: 323
	public class ConditionGroup : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Controls.ICondition>, global::Infragistics.Windows.Controls.ICondition, global::System.ICloneable
	{
		// Token: 0x06000B10 RID: 2832 RVA: 0x000244A4 File Offset: 0x000226A4
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

		// Token: 0x06000B11 RID: 2833 RVA: 0x00024504 File Offset: 0x00022704
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

		// Token: 0x06000B12 RID: 2834 RVA: 0x0002454A File Offset: 0x0002274A
		public override string ToString()
		{
			return global::SR.GetString("ConditionGroup_Description");
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00024556 File Offset: 0x00022756
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x0002456D File Offset: 0x0002276D
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00024581 File Offset: 0x00022781
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00024589 File Offset: 0x00022789
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

		// Token: 0x06000B17 RID: 2839 RVA: 0x000245B8 File Offset: 0x000227B8
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

		// Token: 0x06000B18 RID: 2840 RVA: 0x00024620 File Offset: 0x00022820
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

		// Token: 0x06000B19 RID: 2841 RVA: 0x00024670 File Offset: 0x00022870
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

		// Token: 0x06000B1A RID: 2842 RVA: 0x000248B0 File Offset: 0x00022AB0
		private void RaisePropertyChanged(string propName)
		{
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs("LogicalOperator"));
		}

		// Token: 0x04000519 RID: 1305
		private global::Infragistics.Windows.Controls.LogicalOperator _logicalOperator;

		// Token: 0x0400051A RID: 1306
		private object _tooltip;

		// Token: 0x02000144 RID: 324
		internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
		{
			// Token: 0x170001FB RID: 507
			// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000248C4 File Offset: 0x00022AC4
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

			// Token: 0x06000B1C RID: 2844 RVA: 0x0002491C File Offset: 0x00022B1C
			public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
			{
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = (global::Infragistics.Windows.Controls.ConditionGroup)obj;
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				dictionary["LogicalOperator"] = conditionGroup.LogicalOperator;
				dictionary["[]"] = conditionGroup;
				return dictionary;
			}

			// Token: 0x06000B1D RID: 2845 RVA: 0x0002495C File Offset: 0x00022B5C
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

			// Token: 0x0400051B RID: 1307
			private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
		}
	}
}
