using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000E3 RID: 227
	public class ValueConstraint : global::System.Windows.DependencyObject, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0002E8BB File Offset: 0x0002CABB
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0002E8CD File Offset: 0x0002CACD
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.IEnumerable Enumeration
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.EnumerationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.EnumerationProperty, value);
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0002E8DB File Offset: 0x0002CADB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeEnumeration()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.EnumerationProperty, this);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0002E8E8 File Offset: 0x0002CAE8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetEnumeration()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.EnumerationProperty);
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0002E8F5 File Offset: 0x0002CAF5
		public bool HasEnumeration
		{
			get
			{
				return this.Enumeration != null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0002E903 File Offset: 0x0002CB03
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x0002E910 File Offset: 0x0002CB10
		[global::System.ComponentModel.Bindable(true)]
		public object FixedValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.FixedValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.FixedValueProperty, value);
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0002E91E File Offset: 0x0002CB1E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFixedValue()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.FixedValueProperty, this);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0002E92B File Offset: 0x0002CB2B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFixedValue()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.FixedValueProperty);
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002E938 File Offset: 0x0002CB38
		public bool HasFixedValue
		{
			get
			{
				return this.FixedValue != null;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0002E946 File Offset: 0x0002CB46
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x0002E953 File Offset: 0x0002CB53
		[global::System.ComponentModel.Bindable(true)]
		public object MaxExclusive
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxExclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxExclusiveProperty, value);
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0002E961 File Offset: 0x0002CB61
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxExclusive()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MaxExclusiveProperty, this);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0002E96E File Offset: 0x0002CB6E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxExclusive()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxExclusiveProperty);
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0002E97B File Offset: 0x0002CB7B
		public bool HasMaxExclusive
		{
			get
			{
				return this.MaxExclusive != null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0002E989 File Offset: 0x0002CB89
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0002E996 File Offset: 0x0002CB96
		[global::System.ComponentModel.Bindable(true)]
		public object MaxInclusive
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxInclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxInclusiveProperty, value);
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0002E9A4 File Offset: 0x0002CBA4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxInclusive()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MaxInclusiveProperty, this);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0002E9B1 File Offset: 0x0002CBB1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxInclusive()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxInclusiveProperty);
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002E9BE File Offset: 0x0002CBBE
		public bool HasMaxInclusive
		{
			get
			{
				return this.MaxInclusive != null;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0002E9CC File Offset: 0x0002CBCC
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0002E9DE File Offset: 0x0002CBDE
		[global::System.ComponentModel.Bindable(true)]
		public int MaxLength
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxLengthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxLengthProperty, value);
			}
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
		private static bool ValidateMaxLength(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0002EA0F File Offset: 0x0002CC0F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxLength()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MaxLengthProperty, this);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0002EA1C File Offset: 0x0002CC1C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxLength()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxLengthProperty);
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0002EA29 File Offset: 0x0002CC29
		public bool HasMaxLength
		{
			get
			{
				return this.MaxLength != 0;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0002EA37 File Offset: 0x0002CC37
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0002EA44 File Offset: 0x0002CC44
		[global::System.ComponentModel.Bindable(true)]
		public object MinExclusive
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.MinExclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.MinExclusiveProperty, value);
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0002EA52 File Offset: 0x0002CC52
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinExclusive()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MinExclusiveProperty, this);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0002EA5F File Offset: 0x0002CC5F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinExclusive()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MinExclusiveProperty);
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		public bool HasMinExclusive
		{
			get
			{
				return this.MinExclusive != null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0002EA7A File Offset: 0x0002CC7A
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x0002EA87 File Offset: 0x0002CC87
		[global::System.ComponentModel.Bindable(true)]
		public object MinInclusive
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.MinInclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.MinInclusiveProperty, value);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0002EA95 File Offset: 0x0002CC95
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinInclusive()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MinInclusiveProperty, this);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002EAA2 File Offset: 0x0002CCA2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinInclusive()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MinInclusiveProperty);
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x0002EAAF File Offset: 0x0002CCAF
		public bool HasMinInclusive
		{
			get
			{
				return this.MinInclusive != null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0002EABD File Offset: 0x0002CCBD
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x0002EACF File Offset: 0x0002CCCF
		[global::System.ComponentModel.Bindable(true)]
		public int MinLength
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.MinLengthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.MinLengthProperty, value);
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0002EAE4 File Offset: 0x0002CCE4
		private static bool ValidateMinLength(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0002EAFF File Offset: 0x0002CCFF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinLength()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MinLengthProperty, this);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0002EB0C File Offset: 0x0002CD0C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinLength()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MinLengthProperty);
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x0002EB19 File Offset: 0x0002CD19
		public bool HasMinLength
		{
			get
			{
				return this.MinLength > 0;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0002EB24 File Offset: 0x0002CD24
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0002EB36 File Offset: 0x0002CD36
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? Nullable
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.NullableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.NullableProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0002EB49 File Offset: 0x0002CD49
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeNullable()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.NullableProperty, this);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0002EB56 File Offset: 0x0002CD56
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetNullable()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.NullableProperty);
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0002EB64 File Offset: 0x0002CD64
		public bool HasNullable
		{
			get
			{
				return this.Nullable != null;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0002EB7F File Offset: 0x0002CD7F
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x0002EB91 File Offset: 0x0002CD91
		[global::System.ComponentModel.Bindable(true)]
		public string RegexPattern
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.RegexPatternProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.RegexPatternProperty, value);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0002EBA0 File Offset: 0x0002CDA0
		private static bool ValidateRegexPattern(object objVal)
		{
			string text = (string)objVal;
			if (text != null && text.Length > 0)
			{
				try
				{
					new global::System.Text.RegularExpressions.Regex(text);
				}
				catch
				{
					return false;
				}
				return true;
			}
			return true;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0002EBE4 File Offset: 0x0002CDE4
		private static void OnRegexPatternChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = (global::Infragistics.Windows.Editors.ValueConstraint)dependencyObject;
			valueConstraint._regex = null;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0002EBFF File Offset: 0x0002CDFF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRegexPattern()
		{
			return this.RegexPattern != null && this.RegexPattern.Length > 0;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0002EC19 File Offset: 0x0002CE19
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRegexPattern()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.RegexPatternProperty);
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0002EC26 File Offset: 0x0002CE26
		public bool HasRegexPattern
		{
			get
			{
				return this.RegexPattern != null;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0002EC34 File Offset: 0x0002CE34
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x0002EC46 File Offset: 0x0002CE46
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.ValidateAsType ValidateAsType
		{
			get
			{
				return (global::Infragistics.Windows.Editors.ValidateAsType)base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.ValidateAsTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.ValidateAsTypeProperty, value);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0002EC59 File Offset: 0x0002CE59
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValidateAsType()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.ValidateAsTypeProperty, this);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002EC66 File Offset: 0x0002CE66
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValidateAsType()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.ValidateAsTypeProperty);
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0002EC73 File Offset: 0x0002CE73
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.Controls.ValidationRule> ValidationRules
		{
			get
			{
				if (this._validationRules == null)
				{
					this._validationRules = new global::Infragistics.Windows.Editors.ValidatedObservableCollection<global::System.Windows.Controls.ValidationRule>(false, null);
					this._validationRules.CollectionChanged += this.OnValidationRules_CollectionChanged;
				}
				return this._validationRules;
			}
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0002ECA7 File Offset: 0x0002CEA7
		private void OnValidationRules_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.RaisePropertyChanged("ValidationRules");
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0002ECB4 File Offset: 0x0002CEB4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValidationRules()
		{
			return this.HasValidationRules;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002ECBC File Offset: 0x0002CEBC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValidationRules()
		{
			if (this._validationRules != null)
			{
				this._validationRules.Clear();
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0002ECD1 File Offset: 0x0002CED1
		public bool HasValidationRules
		{
			get
			{
				return this._validationRules != null && this._validationRules.Count > 0;
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		public static global::System.Type GetTypeFromValidateAsType(global::Infragistics.Windows.Editors.ValidateAsType validateAsType)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Editors.ValidateAsType), validateAsType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException("value", (int)validateAsType, typeof(global::Infragistics.Windows.Editors.ValidateAsType));
			}
			global::System.Type result = null;
			switch (validateAsType)
			{
			case global::Infragistics.Windows.Editors.ValidateAsType.Unknown:
				result = typeof(object);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Boolean:
				result = typeof(bool);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Byte:
				result = typeof(sbyte);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.DateTime:
				result = typeof(global::System.DateTime);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Decimal:
				result = typeof(decimal);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Double:
				result = typeof(double);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Float:
				result = typeof(float);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Integer16:
				result = typeof(short);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Integer32:
				result = typeof(int);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Integer64:
			case global::Infragistics.Windows.Editors.ValidateAsType.NegativeInteger64:
			case global::Infragistics.Windows.Editors.ValidateAsType.NonNegativeInteger64:
			case global::Infragistics.Windows.Editors.ValidateAsType.NonPositiveInteger64:
			case global::Infragistics.Windows.Editors.ValidateAsType.PositiveInteger64:
				result = typeof(long);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Text:
				result = typeof(string);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.TimeSpan:
				result = typeof(global::System.TimeSpan);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.UnsignedByte:
				result = typeof(byte);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.UnsignedInteger16:
				result = typeof(ushort);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.UnsignedInteger32:
				result = typeof(uint);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.UnsignedInteger64:
				result = typeof(ulong);
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.Uri:
				result = typeof(global::System.Uri);
				break;
			}
			return result;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002EE7C File Offset: 0x0002D07C
		public static global::Infragistics.Windows.Editors.ValidateAsType GetValidateAsTypeFromType(global::System.Type type)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			string fullName;
			switch (fullName = type.FullName)
			{
			case "System.Boolean":
				return global::Infragistics.Windows.Editors.ValidateAsType.Boolean;
			case "System.Byte":
				return global::Infragistics.Windows.Editors.ValidateAsType.UnsignedByte;
			case "System.DateTime":
				return global::Infragistics.Windows.Editors.ValidateAsType.DateTime;
			case "System.Decimal":
				return global::Infragistics.Windows.Editors.ValidateAsType.Decimal;
			case "System.Double":
				return global::Infragistics.Windows.Editors.ValidateAsType.Double;
			case "System.Int16":
				return global::Infragistics.Windows.Editors.ValidateAsType.Integer16;
			case "System.Int32":
				return global::Infragistics.Windows.Editors.ValidateAsType.Integer32;
			case "System.Int64":
				return global::Infragistics.Windows.Editors.ValidateAsType.Integer64;
			case "System.SByte":
				return global::Infragistics.Windows.Editors.ValidateAsType.Byte;
			case "System.Single":
				return global::Infragistics.Windows.Editors.ValidateAsType.Float;
			case "System.String":
				return global::Infragistics.Windows.Editors.ValidateAsType.Text;
			case "System.TimeSpan":
				return global::Infragistics.Windows.Editors.ValidateAsType.TimeSpan;
			case "System.UInt16":
				return global::Infragistics.Windows.Editors.ValidateAsType.UnsignedInteger16;
			case "System.UInt32":
				return global::Infragistics.Windows.Editors.ValidateAsType.UnsignedInteger32;
			case "System.UInt64":
				return global::Infragistics.Windows.Editors.ValidateAsType.UnsignedInteger64;
			case "System.Uri":
				return global::Infragistics.Windows.Editors.ValidateAsType.Uri;
			}
			return global::Infragistics.Windows.Editors.ValidateAsType.Unknown;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0002F034 File Offset: 0x0002D234
		public bool HasAnyConstraints
		{
			get
			{
				return this.HasEnumeration || this.HasFixedValue || this.HasMaxExclusive || this.HasMaxInclusive || this.HasMaxLength || this.HasMinExclusive || this.HasMinInclusive || this.HasMinLength || this.HasNullable || this.HasRegexPattern || this.ValidateAsType != global::Infragistics.Windows.Editors.ValidateAsType.Unknown;
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0002F0A0 File Offset: 0x0002D2A0
		public void InitializeFrom(global::Infragistics.Windows.Editors.ValueConstraint source, bool copyEnumeration)
		{
			if (copyEnumeration)
			{
				this.Enumeration = source.Enumeration;
			}
			this.FixedValue = source.FixedValue;
			this.FractionDigits = source.FractionDigits;
			this.MaxExclusive = source.MaxExclusive;
			this.MaxInclusive = source.MaxInclusive;
			this.MaxLength = source.MaxLength;
			this.MinExclusive = source.MinExclusive;
			this.MinInclusive = source.MinInclusive;
			this.MinLength = source.MinLength;
			this.Nullable = source.Nullable;
			this._regex = source._regex;
			this.RegexPattern = source.RegexPattern;
			this.TotalDigits = source.TotalDigits;
			this.ValidateAsType = source.ValidateAsType;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0002F158 File Offset: 0x0002D358
		public void InitializeFrom(global::Infragistics.Windows.Editors.ValueConstraint source)
		{
			this.InitializeFrom(source, true);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0002F162 File Offset: 0x0002D362
		public void Merge(global::Infragistics.Windows.Editors.ValueConstraint source, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags)
		{
			this.MergeHelper(source, constraintFlags);
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0002F16C File Offset: 0x0002D36C
		public void Merge(global::Infragistics.Windows.Editors.ValueConstraint source)
		{
			this.MergeHelper(source, global::Infragistics.Windows.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0002F17C File Offset: 0x0002D37C
		public void Reset(global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags)
		{
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.Enumeration & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetEnumeration();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.FixedValue & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetFixedValue();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxExclusive & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetMaxExclusive();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxInclusive & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetMaxInclusive();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxLength & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetMaxLength();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.MinExclusive & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetMinExclusive();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.MinInclusive & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetMinInclusive();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.MinLength & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetMinLength();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.Nullable & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetNullable();
			}
			if ((global::Infragistics.Windows.Editors.ValueConstraintFlags.RegexPattern & constraintFlags) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				this.ResetRegexPattern();
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0002F20E File Offset: 0x0002D40E
		public void Reset()
		{
			this.Reset(global::Infragistics.Windows.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0002F21C File Offset: 0x0002D41C
		public bool Validate(object dataValue, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags, global::System.IFormatProvider formatProvider, string format, ref string errorMessage)
		{
			if (targetType == null)
			{
				throw new global::System.ArgumentNullException("targetType");
			}
			bool flag = dataValue == null || dataValue == global::System.DBNull.Value;
			bool flag2 = !flag && dataValue is string && ((string)dataValue).Length == 0;
			if (flag || flag2)
			{
				bool flag3 = this.Nullable ?? true;
				if (!flag3)
				{
					errorMessage = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_Nullable");
				}
				return flag3;
			}
			if ((constraintFlags & global::Infragistics.Windows.Editors.ValueConstraintFlags.ImplicitTypeParameterConstraints) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				global::Infragistics.Windows.Editors.ValidateAsType validateAsTypeFromType = global::Infragistics.Windows.Editors.ValueConstraint.GetValidateAsTypeFromType(targetType);
				if (!this.ValidateImplicitConstraints(dataValue, validateAsTypeFromType, formatProvider, format, ref errorMessage))
				{
					return false;
				}
			}
			if ((constraintFlags & global::Infragistics.Windows.Editors.ValueConstraintFlags.ImplicitValueAsTypeConstraints) != (global::Infragistics.Windows.Editors.ValueConstraintFlags)0 && !this.ValidateImplicitConstraints(dataValue, this.ValidateAsType, formatProvider, format, ref errorMessage))
			{
				return false;
			}
			if (!this.ValidateExplicitConstraints(dataValue, targetType, constraintFlags, formatProvider, format, ref errorMessage))
			{
				return false;
			}
			global::System.Type typeFromValidateAsType = global::Infragistics.Windows.Editors.ValueConstraint.GetTypeFromValidateAsType(this.ValidateAsType);
			return this.ValidateExplicitConstraints(dataValue, typeFromValidateAsType, constraintFlags, formatProvider, format, ref errorMessage);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0002F30C File Offset: 0x0002D50C
		public bool Validate(object dataValue, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags)
		{
			string text = null;
			return this.Validate(dataValue, targetType, constraintFlags, null, null, ref text);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0002F328 File Offset: 0x0002D528
		public bool Validate(object dataValue, global::System.Type targetType)
		{
			return this.Validate(dataValue, targetType, global::Infragistics.Windows.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0002F338 File Offset: 0x0002D538
		private void MergeHelper(global::Infragistics.Windows.Editors.ValueConstraint source, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags)
		{
			if (source == null || constraintFlags == (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				return;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.Enumeration, constraintFlags, source))
			{
				this.Enumeration = source.Enumeration;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.FixedValue, constraintFlags, source))
			{
				this.FixedValue = source.FixedValue;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxExclusive, constraintFlags, source))
			{
				this.MaxExclusive = source.MaxExclusive;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxInclusive, constraintFlags, source))
			{
				this.MaxInclusive = source.MaxInclusive;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxLength, constraintFlags, source))
			{
				this.MaxLength = source.MaxLength;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MinExclusive, constraintFlags, source))
			{
				this.MinExclusive = source.MinExclusive;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MinInclusive, constraintFlags, source))
			{
				this.MinInclusive = source.MinInclusive;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MinLength, constraintFlags, source))
			{
				this.MinLength = source.MinLength;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.Nullable, constraintFlags, source))
			{
				this.Nullable = source.Nullable;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.RegexPattern, constraintFlags, source))
			{
				this.RegexPattern = source.RegexPattern;
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0002F44C File Offset: 0x0002D64C
		private bool ShouldMergeConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags targetConstraint, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags, global::Infragistics.Windows.Editors.ValueConstraint source)
		{
			if ((constraintFlags & targetConstraint) == (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				return false;
			}
			if (targetConstraint <= global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxLength)
			{
				if (targetConstraint <= global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxExclusive)
				{
					switch (targetConstraint)
					{
					case global::Infragistics.Windows.Editors.ValueConstraintFlags.Enumeration:
						return !this.HasEnumeration && source.HasEnumeration;
					case global::Infragistics.Windows.Editors.ValueConstraintFlags.FixedValue:
						return !this.HasFixedValue && source.HasFixedValue;
					default:
						if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxExclusive)
						{
							return !this.HasMaxExclusive && source.HasMaxExclusive;
						}
						break;
					}
				}
				else
				{
					if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxInclusive)
					{
						return !this.HasMaxInclusive && source.HasMaxInclusive;
					}
					if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxLength)
					{
						return !this.HasMaxLength && source.HasMaxLength;
					}
				}
			}
			else if (targetConstraint <= global::Infragistics.Windows.Editors.ValueConstraintFlags.MinInclusive)
			{
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MinExclusive)
				{
					return !this.HasMinExclusive && source.HasMinExclusive;
				}
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MinInclusive)
				{
					return !this.HasMinInclusive && source.HasMinInclusive;
				}
			}
			else
			{
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MinLength)
				{
					return !this.HasMinLength && source.HasMinLength;
				}
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.Nullable)
				{
					return !this.HasNullable && source.HasNullable;
				}
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.RegexPattern)
				{
					return !this.HasRegexPattern && source.HasRegexPattern;
				}
			}
			return false;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002F5C4 File Offset: 0x0002D7C4
		private object EnsureNumericValueIsWithinBoundsOfDecimal(object constraintValue)
		{
			if ((constraintValue is double && (double)constraintValue < -7.922816251426434E+28) || (constraintValue is float && (float)constraintValue < -7.9228163E+28f))
			{
				constraintValue = decimal.MinValue;
			}
			else if ((constraintValue is double && (double)constraintValue > 7.922816251426434E+28) || (constraintValue is float && (float)constraintValue > 7.9228163E+28f))
			{
				constraintValue = decimal.MaxValue;
			}
			return constraintValue;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0002F658 File Offset: 0x0002D858
		private global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult PerformComparison(object dataValue, object constraintValue, global::System.Type targetType, global::System.IFormatProvider formatProvider, string formatString)
		{
			global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult result;
			try
			{
				object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, targetType, formatProvider, formatString);
				object obj2 = global::Infragistics.CoreUtilities.ConvertDataValue(constraintValue, targetType, formatProvider, formatString);
				if (obj == null || obj2 == null)
				{
					result = global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.Invalid;
				}
				else
				{
					global::System.IComparable comparable = obj as global::System.IComparable;
					if (comparable != null)
					{
						int num = comparable.CompareTo(obj2);
						if (num == 0)
						{
							result = global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.Equal;
						}
						else if (num < 0)
						{
							result = global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.LessThan;
						}
						else
						{
							result = global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.GreaterThan;
						}
					}
					else
					{
						result = global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.Invalid;
					}
				}
			}
			catch (global::System.Exception)
			{
				result = global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.Invalid;
			}
			return result;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0002F6CC File Offset: 0x0002D8CC
		private global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult PerformTypeSensitiveComparison(object convertedDataValue, object constraintValue, global::System.Type targetType, global::System.IFormatProvider formatProvider, string formatString)
		{
			global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult result;
			if (global::Infragistics.Windows.Utilities.IsNumericType(convertedDataValue.GetType()) || global::Infragistics.Windows.Utilities.IsNumericType(constraintValue.GetType()))
			{
				constraintValue = this.EnsureNumericValueIsWithinBoundsOfDecimal(constraintValue);
				result = this.PerformComparison(convertedDataValue, constraintValue, typeof(decimal), formatProvider, formatString);
			}
			else if (convertedDataValue is global::System.DateTime || constraintValue is global::System.DateTime)
			{
				result = this.PerformComparison(convertedDataValue, constraintValue, typeof(global::System.DateTime), formatProvider, formatString);
			}
			else if (convertedDataValue is bool || constraintValue is bool)
			{
				result = this.PerformComparison(convertedDataValue, constraintValue, typeof(bool), formatProvider, formatString);
			}
			else
			{
				result = this.PerformComparison(convertedDataValue, constraintValue, targetType, formatProvider, formatString);
			}
			return result;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002F778 File Offset: 0x0002D978
		private bool ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags targetConstraint, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags)
		{
			if ((constraintFlags & targetConstraint) == (global::Infragistics.Windows.Editors.ValueConstraintFlags)0)
			{
				return false;
			}
			if (targetConstraint <= global::Infragistics.Windows.Editors.ValueConstraintFlags.MinExclusive)
			{
				if (targetConstraint <= global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxExclusive)
				{
					switch (targetConstraint)
					{
					case global::Infragistics.Windows.Editors.ValueConstraintFlags.Enumeration:
						return this.HasEnumeration;
					case global::Infragistics.Windows.Editors.ValueConstraintFlags.FixedValue:
						return this.HasFixedValue;
					default:
						if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxExclusive)
						{
							return this.HasMaxExclusive;
						}
						break;
					}
				}
				else
				{
					if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxInclusive)
					{
						return this.HasMaxInclusive;
					}
					if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxLength)
					{
						return this.HasMaxLength;
					}
					if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MinExclusive)
					{
						return this.HasMinExclusive;
					}
				}
			}
			else if (targetConstraint <= global::Infragistics.Windows.Editors.ValueConstraintFlags.MinLength)
			{
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MinInclusive)
				{
					return this.HasMinInclusive;
				}
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.MinLength)
				{
					return this.HasMinLength;
				}
			}
			else
			{
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.Nullable)
				{
					return this.HasNullable;
				}
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.RegexPattern)
				{
					return this.HasRegexPattern;
				}
				if (targetConstraint == global::Infragistics.Windows.Editors.ValueConstraintFlags.ValidationRules)
				{
					return this.HasValidationRules;
				}
			}
			return false;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0002F870 File Offset: 0x0002DA70
		private bool ValidateImplicitConstraints(object dataValue, global::Infragistics.Windows.Editors.ValidateAsType validateAsType, global::System.IFormatProvider formatProvider, string formatString, ref string errorMsg)
		{
			global::System.Type typeFromValidateAsType = global::Infragistics.Windows.Editors.ValueConstraint.GetTypeFromValidateAsType(validateAsType);
			object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, typeFromValidateAsType, formatProvider, formatString);
			if (obj == null)
			{
				errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_CannotConvert", new object[]
				{
					typeFromValidateAsType.FullName
				});
				return false;
			}
			global::System.IComparable comparable = obj as global::System.IComparable;
			bool flag = true;
			switch (validateAsType)
			{
			case global::Infragistics.Windows.Editors.ValidateAsType.NegativeInteger64:
				if (comparable != null)
				{
					bool flag2 = comparable.CompareTo(0L) < 0;
					flag = (flag && flag2);
					if (!flag)
					{
						errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_OutOfRange", new object[]
						{
							long.MinValue.ToString(formatString, formatProvider),
							"-1"
						});
					}
				}
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.NonNegativeInteger64:
				if (comparable != null)
				{
					bool flag3 = comparable.CompareTo(-1L) > 0;
					flag = (flag && flag3);
					if (!flag)
					{
						errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_OutOfRange", new object[]
						{
							"0",
							long.MaxValue.ToString(formatString, formatProvider)
						});
					}
				}
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.NonPositiveInteger64:
				if (comparable != null)
				{
					bool flag4 = comparable.CompareTo(1L) < 0;
					flag = (flag && flag4);
					if (!flag)
					{
						errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_OutOfRange", new object[]
						{
							long.MinValue.ToString(formatString, formatProvider),
							"0"
						});
					}
				}
				break;
			case global::Infragistics.Windows.Editors.ValidateAsType.PositiveInteger64:
				if (comparable != null)
				{
					bool flag5 = comparable.CompareTo(0L) > 0;
					flag = (flag && flag5);
					if (!flag)
					{
						errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_OutOfRange", new object[]
						{
							"1",
							long.MaxValue.ToString(formatString, formatProvider)
						});
					}
				}
				break;
			}
			return flag;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		private bool ValidateExplicitConstraints(object dataValue, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags, global::System.IFormatProvider formatProvider, string formatString, ref string errorMsg)
		{
			object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, targetType, formatProvider, formatString);
			if (obj == null)
			{
				errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_CannotConvert", new object[]
				{
					targetType.FullName
				});
				return false;
			}
			string text = obj.ToString();
			bool flag = true;
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.Enumeration, constraintFlags) && !global::Infragistics.Windows.Editors.Utils.Exists(this.Enumeration, obj))
			{
				flag = false;
				errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_Enumeration");
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.FixedValue, constraintFlags))
			{
				global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult comparisonResult = this.PerformTypeSensitiveComparison(obj, this.FixedValue, targetType, formatProvider, formatString);
				if (comparisonResult != global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.Equal)
				{
					flag = false;
					errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_FixedValue", new object[]
					{
						this.FixedValue
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxExclusive, constraintFlags))
			{
				global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult comparisonResult2 = this.PerformTypeSensitiveComparison(obj, this.MaxExclusive, targetType, formatProvider, formatString);
				if (comparisonResult2 != global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.LessThan)
				{
					flag = false;
					errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_MaxExclusive", new object[]
					{
						this.MaxExclusive
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxInclusive, constraintFlags))
			{
				global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult comparisonResult3 = this.PerformTypeSensitiveComparison(obj, this.MaxInclusive, targetType, formatProvider, formatString);
				if (comparisonResult3 != global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.LessThan && comparisonResult3 != global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.Equal)
				{
					flag = false;
					errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_MaxInclusive", new object[]
					{
						this.MaxInclusive
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MaxLength, constraintFlags) && this.MaxLength < text.Length)
			{
				flag = false;
				errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_MaxLength", new object[]
				{
					this.MaxLength.ToString(formatString, formatProvider)
				});
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MinExclusive, constraintFlags))
			{
				global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult comparisonResult4 = this.PerformTypeSensitiveComparison(obj, this.MinExclusive, targetType, formatProvider, formatString);
				if (comparisonResult4 != global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.GreaterThan)
				{
					flag = false;
					errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_MinExclusive", new object[]
					{
						this.MinExclusive
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MinInclusive, constraintFlags))
			{
				global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult comparisonResult5 = this.PerformTypeSensitiveComparison(obj, this.MinInclusive, targetType, formatProvider, formatString);
				if (comparisonResult5 != global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.GreaterThan && comparisonResult5 != global::Infragistics.Windows.Editors.ValueConstraint.ComparisonResult.Equal)
				{
					flag = false;
					errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_MinInclusive", new object[]
					{
						this.MinInclusive
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.MinLength, constraintFlags) && text.Length < this.MinLength)
			{
				flag = false;
				errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_MinLength", new object[]
				{
					this.MinLength.ToString(formatString, formatProvider)
				});
			}
			if (flag)
			{
				this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.Nullable, constraintFlags);
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.RegexPattern, constraintFlags))
			{
				if (this._regex == null)
				{
					string text2 = this.RegexPattern;
					if (!text2.StartsWith("^") && !text2.EndsWith("$"))
					{
						text2 = "^(" + text2 + ")$";
					}
					try
					{
						this._regex = new global::System.Text.RegularExpressions.Regex(text2);
					}
					catch
					{
						return true;
					}
				}
				global::System.Text.RegularExpressions.Match match = this._regex.Match(text);
				if (!match.Success || match.Index != 0 || match.Length != text.Length)
				{
					flag = false;
					errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_RegexPattern");
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Windows.Editors.ValueConstraintFlags.ValidationRules, constraintFlags))
			{
				global::System.Collections.Generic.IEnumerable<global::System.Windows.Controls.ValidationRule> validationRules = this.ValidationRules;
				foreach (global::System.Windows.Controls.ValidationRule validationRule in validationRules)
				{
					global::System.Windows.Controls.ValidationResult validationResult = validationRule.Validate(dataValue, formatProvider as global::System.Globalization.CultureInfo);
					if (global::System.Windows.Controls.ValidationResult.ValidResult != validationResult)
					{
						flag = false;
						object errorContent = validationResult.ErrorContent;
						errorMsg = ((errorContent != null) ? errorContent.ToString() : global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_ValidationRule"));
					}
				}
			}
			return flag;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0002FEA8 File Offset: 0x0002E0A8
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x0002FEBA File Offset: 0x0002E0BA
		[global::System.ComponentModel.Bindable(true)]
		private int? FractionDigits
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.FractionDigitsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.FractionDigitsProperty, value);
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0002FECD File Offset: 0x0002E0CD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private bool ShouldSerializeFractionDigits()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.FractionDigitsProperty, this);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0002FEDA File Offset: 0x0002E0DA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private void ResetFractionDigits()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.FractionDigitsProperty);
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0002FEE8 File Offset: 0x0002E0E8
		private bool HasFractionDigits
		{
			get
			{
				return this.FractionDigits >= 0;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0002FF0F File Offset: 0x0002E10F
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x0002FF21 File Offset: 0x0002E121
		[global::System.ComponentModel.Bindable(true)]
		private int? TotalDigits
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Windows.Editors.ValueConstraint.TotalDigitsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.ValueConstraint.TotalDigitsProperty, value);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0002FF34 File Offset: 0x0002E134
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private bool ShouldSerializeTotalDigits()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.TotalDigitsProperty, this);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0002FF41 File Offset: 0x0002E141
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private void ResetTotalDigits()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.TotalDigitsProperty);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0002FF50 File Offset: 0x0002E150
		private bool HasTotalDigits
		{
			get
			{
				return this.TotalDigits >= 0;
			}
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0002FF77 File Offset: 0x0002E177
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			this.RaisePropertyChanged(e.Property.Name);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0002FF92 File Offset: 0x0002E192
		private void RaisePropertyChanged(string propName)
		{
			if (this._propertyChangedDelegate != null)
			{
				this._propertyChangedDelegate(this, new global::System.ComponentModel.PropertyChangedEventArgs(propName));
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000B28 RID: 2856 RVA: 0x0002FFAE File Offset: 0x0002E1AE
		// (remove) Token: 0x06000B29 RID: 2857 RVA: 0x0002FFD7 File Offset: 0x0002E1D7
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				if (this._propertyChangedDelegate == null)
				{
					this._propertyChangedDelegate = value;
					return;
				}
				this._propertyChangedDelegate = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(this._propertyChangedDelegate, value);
			}
			remove
			{
				if (this._propertyChangedDelegate != null)
				{
					this._propertyChangedDelegate = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(this._propertyChangedDelegate, value);
				}
			}
		}

		// Token: 0x040003E8 RID: 1000
		private const int NOTSET = -1;

		// Token: 0x040003E9 RID: 1001
		private const int DEFAULT_LENGTH = 0;

		// Token: 0x040003EA RID: 1002
		private global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.Controls.ValidationRule> _validationRules;

		// Token: 0x040003EB RID: 1003
		private global::System.Text.RegularExpressions.Regex _regex;

		// Token: 0x040003EC RID: 1004
		public static readonly global::System.Windows.DependencyProperty EnumerationProperty = global::System.Windows.DependencyProperty.Register("Enumeration", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003ED RID: 1005
		public static readonly global::System.Windows.DependencyProperty FixedValueProperty = global::System.Windows.DependencyProperty.Register("FixedValue", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003EE RID: 1006
		public static readonly global::System.Windows.DependencyProperty MaxExclusiveProperty = global::System.Windows.DependencyProperty.Register("MaxExclusive", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003EF RID: 1007
		public static readonly global::System.Windows.DependencyProperty MaxInclusiveProperty = global::System.Windows.DependencyProperty.Register("MaxInclusive", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003F0 RID: 1008
		public static readonly global::System.Windows.DependencyProperty MaxLengthProperty = global::System.Windows.DependencyProperty.Register("MaxLength", typeof(int), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.ValueConstraint.ValidateMaxLength));

		// Token: 0x040003F1 RID: 1009
		public static readonly global::System.Windows.DependencyProperty MinExclusiveProperty = global::System.Windows.DependencyProperty.Register("MinExclusive", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003F2 RID: 1010
		public static readonly global::System.Windows.DependencyProperty MinInclusiveProperty = global::System.Windows.DependencyProperty.Register("MinInclusive", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003F3 RID: 1011
		public static readonly global::System.Windows.DependencyProperty MinLengthProperty = global::System.Windows.DependencyProperty.Register("MinLength", typeof(int), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None, null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.ValueConstraint.ValidateMinLength));

		// Token: 0x040003F4 RID: 1012
		public static readonly global::System.Windows.DependencyProperty NullableProperty = global::System.Windows.DependencyProperty.Register("Nullable", typeof(bool?), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003F5 RID: 1013
		public static readonly global::System.Windows.DependencyProperty RegexPatternProperty = global::System.Windows.DependencyProperty.Register("RegexPattern", typeof(string), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueConstraint.OnRegexPatternChanged), null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.ValueConstraint.ValidateRegexPattern));

		// Token: 0x040003F6 RID: 1014
		public static readonly global::System.Windows.DependencyProperty ValidateAsTypeProperty = global::System.Windows.DependencyProperty.Register("ValidateAsType", typeof(global::Infragistics.Windows.Editors.ValidateAsType), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.ValidateAsType.Unknown, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040003F7 RID: 1015
		private static readonly global::System.Windows.DependencyProperty FractionDigitsProperty = global::System.Windows.DependencyProperty.Register("FractionDigits", typeof(int?), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003F8 RID: 1016
		private static readonly global::System.Windows.DependencyProperty TotalDigitsProperty = global::System.Windows.DependencyProperty.Register("TotalDigits", typeof(int?), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x040003F9 RID: 1017
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedDelegate;

		// Token: 0x020000E4 RID: 228
		private enum ComparisonResult
		{
			// Token: 0x040003FB RID: 1019
			Invalid,
			// Token: 0x040003FC RID: 1020
			Equal,
			// Token: 0x040003FD RID: 1021
			LessThan,
			// Token: 0x040003FE RID: 1022
			GreaterThan
		}
	}
}
