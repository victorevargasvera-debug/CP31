using System;
using System.ComponentModel;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter.Calculations
{
	// Token: 0x02000040 RID: 64
	public abstract class DataPresenterCalculationSettingsBase : global::Infragistics.PropertyChangeNotifierExtended
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000B0EC File Offset: 0x000092EC
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000B0F4 File Offset: 0x000092F4
		public string Formula
		{
			get
			{
				return this._formula;
			}
			set
			{
				if (this._formula != value)
				{
					this._formula = value;
					base.RaisePropertyChangedEvent("Formula");
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000B116 File Offset: 0x00009316
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000B11E File Offset: 0x0000931E
		public string ReferenceId
		{
			get
			{
				return this._referenceId;
			}
			set
			{
				if (this._referenceId != value)
				{
					this._referenceId = value;
					base.RaisePropertyChangedEvent("ReferenceId");
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000B140 File Offset: 0x00009340
		// (set) Token: 0x06000291 RID: 657 RVA: 0x0000B148 File Offset: 0x00009348
		public global::System.Type TreatAsType
		{
			get
			{
				return this._treatAsType;
			}
			set
			{
				if (this._treatAsType != value)
				{
					this._treatAsType = value;
					this.TreatAsTypeResolved = global::Infragistics.TypeResolverUtilities.ResolveType(this, this._treatAsType, this._treatAsTypeName, null, "UnknownTypeName");
					base.RaisePropertyChangedEvent("TreatAsType");
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000B188 File Offset: 0x00009388
		// (set) Token: 0x06000293 RID: 659 RVA: 0x0000B190 File Offset: 0x00009390
		public string TreatAsTypeName
		{
			get
			{
				return this._treatAsTypeName;
			}
			set
			{
				if (this._treatAsTypeName != value)
				{
					this._treatAsTypeName = value;
					this.TreatAsTypeResolved = global::Infragistics.TypeResolverUtilities.ResolveType(this, this._treatAsType, this._treatAsTypeName, null, "UnknownTypeName");
					base.RaisePropertyChangedEvent("TreatAsTypeName");
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000B1D0 File Offset: 0x000093D0
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Type TreatAsTypeResolved
		{
			get
			{
				return this._treatAsTypeResolved;
			}
			private set
			{
				if (this._treatAsTypeResolved != value)
				{
					this._treatAsTypeResolved = value;
					base.RaisePropertyChangedEvent("TreatAsTypeResolved");
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000B1FA File Offset: 0x000093FA
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000B202 File Offset: 0x00009402
		public global::System.Windows.Data.IValueConverter ValueConverter
		{
			get
			{
				return this._valueConverter;
			}
			set
			{
				if (this._valueConverter != value)
				{
					this._valueConverter = value;
					base.RaisePropertyChangedEvent("ValueConverter");
				}
			}
		}

		// Token: 0x040000AD RID: 173
		private string _referenceId;

		// Token: 0x040000AE RID: 174
		private string _treatAsTypeName;

		// Token: 0x040000AF RID: 175
		private global::System.Type _treatAsType;

		// Token: 0x040000B0 RID: 176
		private global::System.Type _treatAsTypeResolved;

		// Token: 0x040000B1 RID: 177
		private string _formula;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Data.IValueConverter _valueConverter;
	}
}
