using System;
using System.Windows;
using System.Windows.Data;
using Infragistics.Controls.Grids;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200007A RID: 122
	public class RMContactList : global::Motorola.CommonCPS.RadioManagement.Controls.XamGridContainer
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter SetPresenter
		{
			get
			{
				short num = (short)813338946;
				short num2 = num;
				num = (short)2059637058;
				switch (num2 == num)
				{
				}
				num = (short)1756430337;
				if (num != 0)
				{
				}
				num = (short)1248854016;
				short num3 = num;
				num = (short)1762721792;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList.SetPresenterProperty);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase ActiveField
		{
			get
			{
				short num = (short)1358659495;
				short num2 = num;
				num = (short)2055045031;
				switch (num2 == num)
				{
				}
				num = (short)917505;
				if (num != 0)
				{
				}
				num = (short)1849556992;
				short num3 = num;
				num = (short)568524800;
				if (num != 0)
				{
				}
				return (global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList.ActiveFieldProperty);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0002E658 File Offset: 0x0002C858
		protected virtual string ContactAliasName
		{
			get
			{
				int a_ = 12;
				short num = (short)1403220360;
				short num2 = num;
				num = (short)2084729224;
				switch (num2 == num)
				{
				}
				num = (short)1096941568;
				if (num != 0)
				{
				}
				num = (short)1421213696;
				short num3 = num;
				num = (short)1049559041;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즥욧\udea9춫춭쒯ﲱ햳\udbb5\uddb7", a_);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0002E718 File Offset: 0x0002C918
		protected void HandleActiveCellChanged(object sender)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::Infragistics.Controls.Grids.XamGrid xamGrid;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1737947881;
					short num3 = num2;
					num2 = (short)1209268969;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FC;
					default:
						goto IL_21F;
					}
					break;
				}
				case 1:
					if (((xamGrid.ActiveCell.Value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set).Parent != null)
					{
						num2 = (short)361103370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17E;
				case 2:
					if (xamGrid.ActiveCell.Value is global::Motorola.CommonCPS.RadioManagement.UIModels.NullField)
					{
						num2 = (short)1539309572;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1186988039;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)860946434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_156;
				case 5:
					goto IL_FC;
				case 6:
					if (xamGrid.ActiveCell != null)
					{
						num2 = (short)846725123;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_156;
				case 7:
					if (xamGrid.ActiveCell.Value is global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase)
					{
						num2 = (short)776470533;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17E;
				case 8:
					goto IL_368;
				case 9:
					if (xamGrid.ActiveCell.Row.Data is global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet)
					{
						num2 = (short)1981153281;
						if (num2 != 0)
						{
						}
						num2 = (short)7012364;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17E;
				case 10:
					num2 = (short)723910665;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_179;
				case 12:
				{
					num2 = (short)533463040;
					short num4 = num2;
					this.setCategory.SelectedSets.Clear();
					this.setCategory.SelectedSets.Add((xamGrid.ActiveCell.Row.Data as global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet).ParentSet);
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = ((xamGrid.ActiveCell.Value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
					setCategory.SelectedSets.Clear();
					setCategory.SelectedSets.Add((xamGrid.ActiveCell.Value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase).Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
					base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList.ActiveFieldProperty, xamGrid.ActiveCell.Value);
					num2 = (short)589168648;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_44;
				IL_FC:
				num2 = (short)2100428801;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_156:
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList.ActiveFieldProperty, null);
				num2 = (short)429916171;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17E:
				global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = xamGrid.ActiveCell.Row.Data as global::Motorola.CommonCPS.RadioManagement.UIModels.Set;
				this.setCategory.SelectedSets.Clear();
				this.setCategory.SelectedSets.Add(set);
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList.ActiveFieldProperty, set.Fields[this.ContactAliasName]);
				num2 = (short)1478033408;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_179:
			goto IL_3B3;
			IL_21F:
			num2 = (short)686817280;
			if (num2 != 0)
			{
			}
			IL_368:
			IL_3B3:
			this.SetPresenter.DeleteEmbeddedSetsCommand.RaiseCanExecuteChanged();
			this.SetPresenter.EditEmbeddedSetCommand.RaiseCanExecuteChanged();
			this.SetPresenter.MoveEmbeddedSetDownCommand.RaiseCanExecuteChanged();
			this.SetPresenter.MoveEmbeddedSetUpCommand.RaiseCanExecuteChanged();
			this.SetPresenter.PrepareCopyEmbeddedSetCommand.RaiseCanExecuteChanged();
			this.SetPresenter.PrepareShowEmbeddedSetRelatedSetsCommand.RaiseCanExecuteChanged();
			this.SetPresenter.PrepareShowEmbeddedSetRelatedConfigurationsCommand.RaiseCanExecuteChanged();
			return;
			IL_44:
			xamGrid = (sender as global::Infragistics.Controls.Grids.XamGrid);
			num2 = (short)1779826694;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0002EB48 File Offset: 0x0002CD48
		public virtual void ReBindingItemsSource(global::System.Windows.Data.IValueConverter datasrouceConverter, global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory activeSetCategory)
		{
			short num = (short)581089039;
			short num2 = num;
			num = (short)423540495;
			switch (num2 == num)
			{
			}
			num = (short)551682048;
			if (num != 0)
			{
			}
			num = (short)9437184;
			short num3 = num;
			num = (short)1685585921;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0002EC04 File Offset: 0x0002CE04
		// Note: this type is marked as 'beforefieldinit'.
		static RMContactList()
		{
			int a_ = 18;
			short num = (short)1276901627;
			short num2 = num;
			num = (short)1820588283;
			switch (num2 == num)
			{
			}
			num = (short)717488129;
			if (num != 0)
			{
			}
			num = (short)575864832;
			short num3 = num;
			num = (short)1672216576;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList.SetPresenterProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("囹즫\udaad삱톳억\uddb7풹좻\udbbd늿", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList.ActiveFieldProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾫\udaad\ud9af쒱톳톷\udfb9킻\udabd", a_), typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMContactList), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x040000DC RID: 220
		protected global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;

		// Token: 0x040000DD RID: 221
		public static readonly global::System.Windows.DependencyProperty SetPresenterProperty;

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty ActiveFieldProperty;
	}
}
