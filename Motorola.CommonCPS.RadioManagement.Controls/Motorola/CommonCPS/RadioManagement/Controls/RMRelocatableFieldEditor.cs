using System;
using System.Globalization;
using System.Windows;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000094 RID: 148
	public class RMRelocatableFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0003B28C File Offset: 0x0003948C
		public RMRelocatableFieldEditor()
		{
			base.SetDefaultBindings();
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600038F RID: 911 RVA: 0x0003B2A8 File Offset: 0x000394A8
		// (remove) Token: 0x06000390 RID: 912 RVA: 0x0003B35C File Offset: 0x0003955C
		public event global::System.Windows.RoutedEventHandler RelocateRequested
		{
			add
			{
				short num = (short)1282444059;
				short num2 = num;
				num = (short)1245874971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1680277504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)718405633;
				if (num != 0)
				{
				}
				num = (short)549191680;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor.RelocateRequestedEvent, value);
			}
			remove
			{
				short num = (short)412409894;
				short num2 = num;
				num = (short)1197269030;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1079443456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1341784065;
				if (num != 0)
				{
				}
				num = (short)44367872;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor.RelocateRequestedEvent, value);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0003B414 File Offset: 0x00039614
		protected void RaiseEnterField()
		{
			int a_ = 5;
			global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase;
			if (fieldBase == null)
			{
				short num = (short)656211968;
				short num2 = num;
				num = (short)1199003755;
				short num3 = num;
				num = (short)1259952235;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)362020865;
					if (num != 0)
					{
					}
					num = (short)1813118976;
					if (num != 0)
					{
					}
					return;
				}
			}
			string source = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("꾞\udca0貢\udea4隦풨", a_), (fieldBase.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set).SetType, fieldBase.Name);
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor.RelocateRequestedEvent, source));
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0003B51C File Offset: 0x0003971C
		protected void RaiseLeaveField()
		{
			short num = (short)1823089251;
			short num2 = num;
			num = (short)942350947;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2137915392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)992346113;
			if (num != 0)
			{
			}
			num = (short)947912704;
			if (num != 0)
			{
			}
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor.RelocateRequestedEvent, string.Empty));
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0003B5DC File Offset: 0x000397DC
		// Note: this type is marked as 'beforefieldinit'.
		static RMRelocatableFieldEditor()
		{
			int a_ = 5;
			short num = (short)1060965305;
			short num2 = num;
			num = (short)1444678585;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1513816064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1372717057;
			if (num != 0)
			{
			}
			num = (short)1829961728;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor.RelocateRequestedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾜爵춠첢욤욦\udda8캪ﾬ쪮산욲킴쒶춸\udeba\ud9bc", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMRelocatableFieldEditor));
		}
	}
}
