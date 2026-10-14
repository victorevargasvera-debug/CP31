using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000090 RID: 144
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DisplayCharacterPresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x060008A8 RID: 2216 RVA: 0x00027344 File Offset: 0x00025544
		static DisplayCharacterPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00027411 File Offset: 0x00025611
		public void Initialize(global::Infragistics.Windows.Editors.DisplayCharBase displayCharacter)
		{
			base.SetValue(global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DisplayCharacterPropertyKey, displayCharacter);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0002741F File Offset: 0x0002561F
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Editors.DisplayCharBase DisplayCharacter
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DisplayCharBase)base.GetValue(global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DisplayCharacterProperty);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00027431 File Offset: 0x00025631
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool DrawAsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DrawAsSelectedProperty);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00027443 File Offset: 0x00025643
		internal void SyncDrawAsSelected()
		{
			base.SetValue(global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DrawAsSelectedPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.DisplayCharacter.DrawSelected));
		}

		// Token: 0x040002ED RID: 749
		private static readonly global::System.Windows.DependencyPropertyKey DisplayCharacterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DisplayCharacter", typeof(global::Infragistics.Windows.Editors.DisplayCharBase), typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040002EE RID: 750
		public static readonly global::System.Windows.DependencyProperty DisplayCharacterProperty = global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DisplayCharacterPropertyKey.DependencyProperty;

		// Token: 0x040002EF RID: 751
		private static readonly global::System.Windows.DependencyPropertyKey DrawAsSelectedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DrawAsSelected", typeof(bool), typeof(global::Infragistics.Windows.Editors.DisplayCharacterPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange, null));

		// Token: 0x040002F0 RID: 752
		public static readonly global::System.Windows.DependencyProperty DrawAsSelectedProperty = global::Infragistics.Windows.Editors.DisplayCharacterPresenter.DrawAsSelectedPropertyKey.DependencyProperty;
	}
}
