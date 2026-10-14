using System;
using System.ComponentModel;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter.Calculations
{
	// Token: 0x02000040 RID: 64
	public abstract class DataPresenterCalculationSettingsBase : global::Infragistics.PropertyChangeNotifierExtended
	{
		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000BB00 File Offset: 0x00009D00
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000BB08 File Offset: 0x00009D08
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000BB2A File Offset: 0x00009D2A
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000BB32 File Offset: 0x00009D32
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000BB54 File Offset: 0x00009D54
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000BB5C File Offset: 0x00009D5C
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
					this.TreatAsTypeResolved = global::Infragistics.TypeResolverUtilities.ResolveType(this, this._treatAsType, this._treatAsTypeName, null, "TreatAsTypeName");
					base.RaisePropertyChangedEvent("TreatAsType");
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000BB9C File Offset: 0x00009D9C
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000BBA4 File Offset: 0x00009DA4
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
					this.TreatAsTypeResolved = global::Infragistics.TypeResolverUtilities.ResolveType(this, this._treatAsType, this._treatAsTypeName, null, "TreatAsTypeName");
					base.RaisePropertyChangedEvent("TreatAsTypeName");
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000BBEC File Offset: 0x00009DEC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000BC0E File Offset: 0x00009E0E
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000BC16 File Offset: 0x00009E16
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

		// Token: 0x040000BF RID: 191
		private string _referenceId;

		// Token: 0x040000C0 RID: 192
		private string _treatAsTypeName;

		// Token: 0x040000C1 RID: 193
		private global::System.Type _treatAsType;

		// Token: 0x040000C2 RID: 194
		private global::System.Type _treatAsTypeResolved;

		// Token: 0x040000C3 RID: 195
		private string _formula;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Data.IValueConverter _valueConverter;
	}
}
