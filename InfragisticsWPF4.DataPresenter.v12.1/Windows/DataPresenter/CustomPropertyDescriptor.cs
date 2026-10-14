using System;
using System.ComponentModel;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000136 RID: 310
	internal class CustomPropertyDescriptor : global::System.ComponentModel.PropertyDescriptor
	{
		// Token: 0x060010EC RID: 4332 RVA: 0x0004A079 File Offset: 0x00048279
		internal CustomPropertyDescriptor(string name) : base(name, null)
		{
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0004A083 File Offset: 0x00048283
		public override bool CanResetValue(object component)
		{
			return true;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0004A088 File Offset: 0x00048288
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

		// Token: 0x060010EF RID: 4335 RVA: 0x0004A10B File Offset: 0x0004830B
		public override void ResetValue(object component)
		{
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0004A110 File Offset: 0x00048310
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

		// Token: 0x060010F1 RID: 4337 RVA: 0x0004A17F File Offset: 0x0004837F
		public override bool ShouldSerializeValue(object component)
		{
			return true;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x0004A182 File Offset: 0x00048382
		public override global::System.Type ComponentType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.ConditionInfo);
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0004A190 File Offset: 0x00048390
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

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x0004A1E4 File Offset: 0x000483E4
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
