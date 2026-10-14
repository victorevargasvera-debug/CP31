using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000084 RID: 132
	[global::System.Windows.TemplatePart(Name = "Panel", Type = typeof(global::System.Windows.Controls.Panel))]
	public abstract class SelectionControl : global::System.Windows.Controls.Control, global::Infragistics.ICommandTarget, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0001548C File Offset: 0x0001368C
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00015494 File Offset: 0x00013694
		protected global::System.Windows.Controls.Panel Panel { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0001549D File Offset: 0x0001369D
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x000154AF File Offset: 0x000136AF
		public global::Infragistics.Controls.Grids.CellBase Cell
		{
			get
			{
				return (global::Infragistics.Controls.Grids.CellBase)base.GetValue(global::Infragistics.Controls.Grids.Primitives.SelectionControl.CellProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.SelectionControl.CellProperty, value);
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000154C0 File Offset: 0x000136C0
		private static void CellChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.SelectionControl selectionControl = (global::Infragistics.Controls.Grids.Primitives.SelectionControl)obj;
			selectionControl.OnCellAssigned();
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000154DA File Offset: 0x000136DA
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x000154EC File Offset: 0x000136EC
		public global::System.Windows.Style CheckBoxStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.Primitives.SelectionControl.CheckBoxStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.SelectionControl.CheckBoxStyleProperty, value);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000154FC File Offset: 0x000136FC
		private static void CheckBoxStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.SelectionControl selectionControl = (global::Infragistics.Controls.Grids.Primitives.SelectionControl)obj;
			selectionControl.SetupSelectionBox();
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00015516 File Offset: 0x00013716
		public override void OnApplyTemplate()
		{
			this.Panel = (base.GetTemplateChild("Panel") as global::System.Windows.Controls.Panel);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001552E File Offset: 0x0001372E
		protected virtual void SetupSelectionBox()
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00015530 File Offset: 0x00013730
		protected internal virtual void AcceptChanges()
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00015532 File Offset: 0x00013732
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.AcceptChangesCommand;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0001553D File Offset: 0x0001373D
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00015540 File Offset: 0x00013740
		protected virtual void OnCellAssigned()
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00015542 File Offset: 0x00013742
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0001554B File Offset: 0x0001374B
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060004A4 RID: 1188 RVA: 0x00015554 File Offset: 0x00013754
		// (remove) Token: 0x060004A5 RID: 1189 RVA: 0x0001558C File Offset: 0x0001378C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060004A6 RID: 1190 RVA: 0x000155C1 File Offset: 0x000137C1
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x04000139 RID: 313
		public static readonly global::System.Windows.DependencyProperty CellProperty = global::System.Windows.DependencyProperty.Register("Cell", typeof(global::Infragistics.Controls.Grids.CellBase), typeof(global::Infragistics.Controls.Grids.Primitives.SelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.SelectionControl.CellChanged)));

		// Token: 0x0400013A RID: 314
		public static readonly global::System.Windows.DependencyProperty CheckBoxStyleProperty = global::System.Windows.DependencyProperty.Register("CheckBoxStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.Primitives.SelectionControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.SelectionControl.CheckBoxStyleChanged)));
	}
}
