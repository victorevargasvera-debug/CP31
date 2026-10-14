using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200004E RID: 78
	public class IconConditionalFormatRule : global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0000DF24 File Offset: 0x0000C124
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.ConditionalFormatIcon> Rules
		{
			get
			{
				if (this._rules == null)
				{
					this._rules = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.ConditionalFormatIcon>();
					this._rules.CollectionChanged += this.Rules_CollectionChanged;
				}
				return this._rules;
			}
			set
			{
				if (this._rules != null)
				{
					this._rules.CollectionChanged -= this.Rules_CollectionChanged;
					foreach (global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon in this._rules)
					{
						conditionalFormatIcon.PropertyChanged -= this.Icon_PropertyChanged;
						conditionalFormatIcon.Parent = null;
					}
				}
				this._rules = value;
				if (this._rules != null)
				{
					foreach (global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon2 in this._rules)
					{
						conditionalFormatIcon2.Parent = this;
						conditionalFormatIcon2.PropertyChanged += this.Icon_PropertyChanged;
					}
					this._rules.CollectionChanged += this.Rules_CollectionChanged;
				}
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000E018 File Offset: 0x0000C218
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.IconConditionalFormatRuleProxy();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000E020 File Offset: 0x0000C220
		private void Rules_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				if (e.NewItems == null)
				{
					goto IL_20C;
				}
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj;
						conditionalFormatIcon.Parent = this;
						conditionalFormatIcon.PropertyChanged += this.Icon_PropertyChanged;
					}
					goto IL_20C;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
			{
				if (e.OldItems == null)
				{
					goto IL_20C;
				}
				using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon2 = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj2;
						conditionalFormatIcon2.Parent = null;
						conditionalFormatIcon2.PropertyChanged -= this.Icon_PropertyChanged;
					}
					goto IL_20C;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				if (e.OldItems == null)
				{
					goto IL_20C;
				}
				using (global::System.Collections.IEnumerator enumerator3 = e.OldItems.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						object obj3 = enumerator3.Current;
						global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon3 = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj3;
						conditionalFormatIcon3.Parent = null;
						conditionalFormatIcon3.PropertyChanged -= this.Icon_PropertyChanged;
					}
					goto IL_20C;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
			{
				if (e.OldItems != null)
				{
					foreach (object obj4 in e.OldItems)
					{
						global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon4 = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj4;
						conditionalFormatIcon4.Parent = null;
						conditionalFormatIcon4.PropertyChanged -= this.Icon_PropertyChanged;
					}
				}
				if (e.NewItems != null)
				{
					foreach (object obj5 in e.NewItems)
					{
						global::Infragistics.Controls.Grids.ConditionalFormatIcon conditionalFormatIcon5 = (global::Infragistics.Controls.Grids.ConditionalFormatIcon)obj5;
						conditionalFormatIcon5.Parent = this;
						conditionalFormatIcon5.PropertyChanged += this.Icon_PropertyChanged;
					}
				}
			}
			IL_20C:
			this.OnPropertyChanged("Rules");
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000E284 File Offset: 0x0000C484
		private void Icon_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x040000BB RID: 187
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Controls.Grids.ConditionalFormatIcon> _rules;
	}
}
