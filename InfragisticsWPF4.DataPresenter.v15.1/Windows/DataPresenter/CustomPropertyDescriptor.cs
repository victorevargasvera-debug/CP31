using System;
using System.ComponentModel;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000152 RID: 338
	internal class CustomPropertyDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x06001455 RID: 5205 RVA: 0x0005B375 File Offset: 0x00059575
		internal CustomPropertyDescriptor(string name) : base(name, null)
		{
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0005B37F File Offset: 0x0005957F
		public override bool CanResetValue(object component)
		{
			return true;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x0005B384 File Offset: 0x00059584
		public override object GetValue(object component)
		{
			string name;
			if ((name = this.Name) != null)
			{
				if (name == "ComparisonOperator")
				{
					return ((global::Infragistics.Windows.DataPresenter.ConditionInfo)component).ComparisonOperator;
				}
				if (name == "Group")
				{
					return ((global::Infragistics.Windows.DataPresenter.ConditionInfo)component).Group;
				}
				if (name == "Value")
				{
					return ((global::Infragistics.Windows.DataPresenter.ConditionInfo)component).Value;
				}
				if (name == "ErrorDescription")
				{
					return ((global::Infragistics.Windows.DataPresenter.ConditionInfo)component).ErrorDescription;
				}
			}
			return null;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x0005B407 File Offset: 0x00059607
		public override void ResetValue(object component)
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0005B40C File Offset: 0x0005960C
		public override void SetValue(object component, object value)
		{
			string name;
			if ((name = this.Name) != null)
			{
				if (name == "ComparisonOperator")
				{
					((global::Infragistics.Windows.DataPresenter.ConditionInfo)component).ComparisonOperator = (global::Infragistics.Windows.Controls.ComparisonOperator)value;
					return;
				}
				if (name == "Group")
				{
					((global::Infragistics.Windows.DataPresenter.ConditionInfo)component).Group = (global::Infragistics.Windows.DataPresenter.ConditionInfoGroup)value;
					return;
				}
				if (!(name == "Value"))
				{
					return;
				}
				((global::Infragistics.Windows.DataPresenter.ConditionInfo)component).Value = value;
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0005B47B File Offset: 0x0005967B
		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0005B47E File Offset: 0x0005967E
		public override global::System.Type ComponentType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.ConditionInfo);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0005B48C File Offset: 0x0005968C
		public override bool IsReadOnly
		{
			get
			{
				string name;
				if ((name = this.Name) != null)
				{
					if (name == "ComparisonOperator" || name == "Group" || name == "Value")
					{
						return false;
					}
					if (name == "ErrorDescription")
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0005B4E0 File Offset: 0x000596E0
		public override global::System.Type PropertyType
		{
			get
			{
				string name;
				if ((name = this.Name) != null)
				{
					if (name == "ComparisonOperator")
					{
						return typeof(global::Infragistics.Windows.Controls.ComparisonOperator);
					}
					if (name == "Group")
					{
						return typeof(global::Infragistics.Windows.DataPresenter.ConditionInfoGroup);
					}
					if (name == "Value")
					{
						return typeof(object);
					}
					if (name == "ErrorDescription")
					{
						return typeof(string);
					}
				}
				return typeof(object);
			}
		}
	}
}
