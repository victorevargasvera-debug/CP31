using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000089 RID: 137
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DisplayCharacterPresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x000255A8 File Offset: 0x000237A8
		static DisplayCharacterPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00025675 File Offset: 0x00023875
		public void Initialize(global::Infragistics.Windows.Editors.DisplayCharBase displayCharacter)
		{
			base.SetValue(global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DisplayCharacterPropertyKey, displayCharacter);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00025683 File Offset: 0x00023883
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.DisplayCharBase DisplayCharacter
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DisplayCharBase)base.GetValue(global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DisplayCharacterProperty);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00025695 File Offset: 0x00023895
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool DrawAsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DrawAsSelectedProperty);
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000256A7 File Offset: 0x000238A7
		internal void SyncDrawAsSelected()
		{
			base.SetValue(global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DrawAsSelectedPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.DisplayCharacter.DrawSelected));
		}

		// Token: 0x040002B7 RID: 695
		private static readonly global::System.Windows.DependencyPropertyKey DisplayCharacterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DisplayCharacter", typeof(global::Infragistics.Windows.Editors.DisplayCharBase), typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040002B8 RID: 696
		public static readonly global::System.Windows.DependencyProperty DisplayCharacterProperty = global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DisplayCharacterPropertyKey.DependencyProperty;

		// Token: 0x040002B9 RID: 697
		private static readonly global::System.Windows.DependencyPropertyKey DrawAsSelectedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DrawAsSelected", typeof(bool), typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, null));

		// Token: 0x040002BA RID: 698
		public static readonly global::System.Windows.DependencyProperty DrawAsSelectedProperty = global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DrawAsSelectedPropertyKey.DependencyProperty;
	}
}
