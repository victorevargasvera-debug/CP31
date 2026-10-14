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
	// Token: 0x020000EF RID: 239
	public class ValueConstraint : global::System.Windows.DependencyObject, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x000309FF File Offset: 0x0002EBFF
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x00030A11 File Offset: 0x0002EC11
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

		// Token: 0x06000B4E RID: 2894 RVA: 0x00030A1F File Offset: 0x0002EC1F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeEnumeration()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.EnumerationProperty, this);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00030A2C File Offset: 0x0002EC2C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetEnumeration()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.EnumerationProperty);
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00030A39 File Offset: 0x0002EC39
		public bool HasEnumeration
		{
			get
			{
				return this.Enumeration != null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00030A47 File Offset: 0x0002EC47
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00030A54 File Offset: 0x0002EC54
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

		// Token: 0x06000B53 RID: 2899 RVA: 0x00030A62 File Offset: 0x0002EC62
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFixedValue()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.FixedValueProperty, this);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00030A6F File Offset: 0x0002EC6F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFixedValue()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.FixedValueProperty);
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00030A7C File Offset: 0x0002EC7C
		public bool HasFixedValue
		{
			get
			{
				return this.FixedValue != null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00030A8A File Offset: 0x0002EC8A
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00030A97 File Offset: 0x0002EC97
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

		// Token: 0x06000B58 RID: 2904 RVA: 0x00030AA5 File Offset: 0x0002ECA5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxExclusive()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MaxExclusiveProperty, this);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00030AB2 File Offset: 0x0002ECB2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxExclusive()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxExclusiveProperty);
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00030ABF File Offset: 0x0002ECBF
		public bool HasMaxExclusive
		{
			get
			{
				return this.MaxExclusive != null;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00030ACD File Offset: 0x0002ECCD
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00030ADA File Offset: 0x0002ECDA
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

		// Token: 0x06000B5D RID: 2909 RVA: 0x00030AE8 File Offset: 0x0002ECE8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxInclusive()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MaxInclusiveProperty, this);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00030AF5 File Offset: 0x0002ECF5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxInclusive()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxInclusiveProperty);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00030B02 File Offset: 0x0002ED02
		public bool HasMaxInclusive
		{
			get
			{
				return this.MaxInclusive != null;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00030B10 File Offset: 0x0002ED10
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00030B22 File Offset: 0x0002ED22
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

		// Token: 0x06000B62 RID: 2914 RVA: 0x00030B38 File Offset: 0x0002ED38
		private static bool ValidateMaxLength(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00030B53 File Offset: 0x0002ED53
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxLength()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MaxLengthProperty, this);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00030B60 File Offset: 0x0002ED60
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxLength()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MaxLengthProperty);
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00030B6D File Offset: 0x0002ED6D
		public bool HasMaxLength
		{
			get
			{
				return this.MaxLength != 0;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00030B7B File Offset: 0x0002ED7B
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00030B88 File Offset: 0x0002ED88
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

		// Token: 0x06000B68 RID: 2920 RVA: 0x00030B96 File Offset: 0x0002ED96
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinExclusive()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MinExclusiveProperty, this);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00030BA3 File Offset: 0x0002EDA3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinExclusive()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MinExclusiveProperty);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		public bool HasMinExclusive
		{
			get
			{
				return this.MinExclusive != null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00030BBE File Offset: 0x0002EDBE
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00030BCB File Offset: 0x0002EDCB
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

		// Token: 0x06000B6D RID: 2925 RVA: 0x00030BD9 File Offset: 0x0002EDD9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinInclusive()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MinInclusiveProperty, this);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00030BE6 File Offset: 0x0002EDE6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinInclusive()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MinInclusiveProperty);
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00030BF3 File Offset: 0x0002EDF3
		public bool HasMinInclusive
		{
			get
			{
				return this.MinInclusive != null;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00030C01 File Offset: 0x0002EE01
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00030C13 File Offset: 0x0002EE13
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

		// Token: 0x06000B72 RID: 2930 RVA: 0x00030C28 File Offset: 0x0002EE28
		private static bool ValidateMinLength(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00030C43 File Offset: 0x0002EE43
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinLength()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.MinLengthProperty, this);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00030C50 File Offset: 0x0002EE50
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinLength()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.MinLengthProperty);
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00030C5D File Offset: 0x0002EE5D
		public bool HasMinLength
		{
			get
			{
				return this.MinLength > 0;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00030C68 File Offset: 0x0002EE68
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00030C7A File Offset: 0x0002EE7A
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

		// Token: 0x06000B78 RID: 2936 RVA: 0x00030C8D File Offset: 0x0002EE8D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeNullable()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.NullableProperty, this);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00030C9A File Offset: 0x0002EE9A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetNullable()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.NullableProperty);
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00030CA8 File Offset: 0x0002EEA8
		public bool HasNullable
		{
			get
			{
				return this.Nullable != null;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00030CC3 File Offset: 0x0002EEC3
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00030CD5 File Offset: 0x0002EED5
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

		// Token: 0x06000B7D RID: 2941 RVA: 0x00030CE4 File Offset: 0x0002EEE4
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

		// Token: 0x06000B7E RID: 2942 RVA: 0x00030D28 File Offset: 0x0002EF28
		private static void OnRegexPatternChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.ValueConstraint valueConstraint = (global::Infragistics.Windows.Editors.ValueConstraint)dependencyObject;
			valueConstraint._regex = null;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00030D43 File Offset: 0x0002EF43
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRegexPattern()
		{
			return this.RegexPattern != null && this.RegexPattern.Length > 0;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00030D5D File Offset: 0x0002EF5D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRegexPattern()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.RegexPatternProperty);
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00030D6A File Offset: 0x0002EF6A
		public bool HasRegexPattern
		{
			get
			{
				return this.RegexPattern != null;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00030D78 File Offset: 0x0002EF78
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00030D8A File Offset: 0x0002EF8A
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

		// Token: 0x06000B84 RID: 2948 RVA: 0x00030D9D File Offset: 0x0002EF9D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValidateAsType()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.ValidateAsTypeProperty, this);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00030DAA File Offset: 0x0002EFAA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValidateAsType()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.ValidateAsTypeProperty);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x00030DB7 File Offset: 0x0002EFB7
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

		// Token: 0x06000B87 RID: 2951 RVA: 0x00030DEB File Offset: 0x0002EFEB
		private void OnValidationRules_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.RaisePropertyChanged("ValidationRules");
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00030DF8 File Offset: 0x0002EFF8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValidationRules()
		{
			return this.HasValidationRules;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00030E00 File Offset: 0x0002F000
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValidationRules()
		{
			if (this._validationRules != null)
			{
				this._validationRules.Clear();
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00030E15 File Offset: 0x0002F015
		public bool HasValidationRules
		{
			get
			{
				return this._validationRules != null && this._validationRules.Count > 0;
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00030E30 File Offset: 0x0002F030
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

		// Token: 0x06000B8C RID: 2956 RVA: 0x00030FC0 File Offset: 0x0002F1C0
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

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00031178 File Offset: 0x0002F378
		public bool HasAnyConstraints
		{
			get
			{
				return this.HasEnumeration || this.HasFixedValue || this.HasMaxExclusive || this.HasMaxInclusive || this.HasMaxLength || this.HasMinExclusive || this.HasMinInclusive || this.HasMinLength || this.HasNullable || this.HasRegexPattern || this.ValidateAsType != global::Infragistics.Windows.Editors.ValidateAsType.Unknown;
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000311E4 File Offset: 0x0002F3E4
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

		// Token: 0x06000B8F RID: 2959 RVA: 0x0003129C File Offset: 0x0002F49C
		public void InitializeFrom(global::Infragistics.Windows.Editors.ValueConstraint source)
		{
			this.InitializeFrom(source, true);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000312A6 File Offset: 0x0002F4A6
		public void Merge(global::Infragistics.Windows.Editors.ValueConstraint source, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags)
		{
			this.MergeHelper(source, constraintFlags);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000312B0 File Offset: 0x0002F4B0
		public void Merge(global::Infragistics.Windows.Editors.ValueConstraint source)
		{
			this.MergeHelper(source, global::Infragistics.Windows.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000312C0 File Offset: 0x0002F4C0
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

		// Token: 0x06000B93 RID: 2963 RVA: 0x00031352 File Offset: 0x0002F552
		public void Reset()
		{
			this.Reset(global::Infragistics.Windows.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00031360 File Offset: 0x0002F560
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

		// Token: 0x06000B95 RID: 2965 RVA: 0x00031450 File Offset: 0x0002F650
		public bool Validate(object dataValue, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags)
		{
			string text = null;
			return this.Validate(dataValue, targetType, constraintFlags, null, null, ref text);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0003146C File Offset: 0x0002F66C
		public bool Validate(object dataValue, global::System.Type targetType)
		{
			return this.Validate(dataValue, targetType, global::Infragistics.Windows.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0003147C File Offset: 0x0002F67C
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

		// Token: 0x06000B98 RID: 2968 RVA: 0x00031590 File Offset: 0x0002F790
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

		// Token: 0x06000B99 RID: 2969 RVA: 0x00031708 File Offset: 0x0002F908
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

		// Token: 0x06000B9A RID: 2970 RVA: 0x0003179C File Offset: 0x0002F99C
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

		// Token: 0x06000B9B RID: 2971 RVA: 0x00031810 File Offset: 0x0002FA10
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

		// Token: 0x06000B9C RID: 2972 RVA: 0x000318BC File Offset: 0x0002FABC
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

		// Token: 0x06000B9D RID: 2973 RVA: 0x000319B4 File Offset: 0x0002FBB4
		private bool ValidateImplicitConstraints(object dataValue, global::Infragistics.Windows.Editors.ValidateAsType validateAsType, global::System.IFormatProvider formatProvider, string formatString, ref string errorMsg)
		{
			global::System.Type typeFromValidateAsType = global::Infragistics.Windows.Editors.ValueConstraint.GetTypeFromValidateAsType(validateAsType);
			object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, typeFromValidateAsType, formatProvider, formatString);
			if (obj == null)
			{
				errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_CannotConvert", new object[]
				{
					global::Infragistics.CoreUtilities.GetUnderlyingType(typeFromValidateAsType).FullName
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

		// Token: 0x06000B9E RID: 2974 RVA: 0x00031BF4 File Offset: 0x0002FDF4
		private bool ValidateExplicitConstraints(object dataValue, global::System.Type targetType, global::Infragistics.Windows.Editors.ValueConstraintFlags constraintFlags, global::System.IFormatProvider formatProvider, string formatString, ref string errorMsg)
		{
			object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, targetType, formatProvider, formatString);
			if (obj == null)
			{
				errorMsg = global::Infragistics.Windows.Editors.ValueEditor.GetString("LMSG_ValueConstraint_CannotConvert", new object[]
				{
					global::Infragistics.CoreUtilities.GetUnderlyingType(targetType).FullName
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

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00031FFC File Offset: 0x000301FC
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x0003200E File Offset: 0x0003020E
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

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00032021 File Offset: 0x00030221
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private bool ShouldSerializeFractionDigits()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.FractionDigitsProperty, this);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0003202E File Offset: 0x0003022E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private void ResetFractionDigits()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.FractionDigitsProperty);
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0003203C File Offset: 0x0003023C
		private bool HasFractionDigits
		{
			get
			{
				return this.FractionDigits >= 0;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00032063 File Offset: 0x00030263
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00032075 File Offset: 0x00030275
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

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00032088 File Offset: 0x00030288
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private bool ShouldSerializeTotalDigits()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.ValueConstraint.TotalDigitsProperty, this);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00032095 File Offset: 0x00030295
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private void ResetTotalDigits()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.ValueConstraint.TotalDigitsProperty);
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x000320A4 File Offset: 0x000302A4
		private bool HasTotalDigits
		{
			get
			{
				return this.TotalDigits >= 0;
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000320CB File Offset: 0x000302CB
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			this.RaisePropertyChanged(e.Property.Name);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000320E6 File Offset: 0x000302E6
		private void RaisePropertyChanged(string propName)
		{
			if (this._propertyChangedDelegate != null)
			{
				this._propertyChangedDelegate(this, new global::System.ComponentModel.PropertyChangedEventArgs(propName));
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000BAB RID: 2987 RVA: 0x00032102 File Offset: 0x00030302
		// (remove) Token: 0x06000BAC RID: 2988 RVA: 0x0003212B File Offset: 0x0003032B
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

		// Token: 0x04000422 RID: 1058
		private const int NOTSET = -1;

		// Token: 0x04000423 RID: 1059
		private const int DEFAULT_LENGTH = 0;

		// Token: 0x04000424 RID: 1060
		private global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.Controls.ValidationRule> _validationRules;

		// Token: 0x04000425 RID: 1061
		private global::System.Text.RegularExpressions.Regex _regex;

		// Token: 0x04000426 RID: 1062
		public static readonly global::System.Windows.DependencyProperty EnumerationProperty = global::System.Windows.DependencyProperty.Register("Enumeration", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x04000427 RID: 1063
		public static readonly global::System.Windows.DependencyProperty FixedValueProperty = global::System.Windows.DependencyProperty.Register("FixedValue", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x04000428 RID: 1064
		public static readonly global::System.Windows.DependencyProperty MaxExclusiveProperty = global::System.Windows.DependencyProperty.Register("MaxExclusive", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x04000429 RID: 1065
		public static readonly global::System.Windows.DependencyProperty MaxInclusiveProperty = global::System.Windows.DependencyProperty.Register("MaxInclusive", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x0400042A RID: 1066
		public static readonly global::System.Windows.DependencyProperty MaxLengthProperty = global::System.Windows.DependencyProperty.Register("MaxLength", typeof(int), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.ValueConstraint.ValidateMaxLength));

		// Token: 0x0400042B RID: 1067
		public static readonly global::System.Windows.DependencyProperty MinExclusiveProperty = global::System.Windows.DependencyProperty.Register("MinExclusive", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x0400042C RID: 1068
		public static readonly global::System.Windows.DependencyProperty MinInclusiveProperty = global::System.Windows.DependencyProperty.Register("MinInclusive", typeof(object), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x0400042D RID: 1069
		public static readonly global::System.Windows.DependencyProperty MinLengthProperty = global::System.Windows.DependencyProperty.Register("MinLength", typeof(int), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None, null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.ValueConstraint.ValidateMinLength));

		// Token: 0x0400042E RID: 1070
		public static readonly global::System.Windows.DependencyProperty NullableProperty = global::System.Windows.DependencyProperty.Register("Nullable", typeof(bool?), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x0400042F RID: 1071
		public static readonly global::System.Windows.DependencyProperty RegexPatternProperty = global::System.Windows.DependencyProperty.Register("RegexPattern", typeof(string), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.ValueConstraint.OnRegexPatternChanged), null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.ValueConstraint.ValidateRegexPattern));

		// Token: 0x04000430 RID: 1072
		public static readonly global::System.Windows.DependencyProperty ValidateAsTypeProperty = global::System.Windows.DependencyProperty.Register("ValidateAsType", typeof(global::Infragistics.Windows.Editors.ValidateAsType), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.ValidateAsType.Unknown, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000431 RID: 1073
		private static readonly global::System.Windows.DependencyProperty FractionDigitsProperty = global::System.Windows.DependencyProperty.Register("FractionDigits", typeof(int?), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x04000432 RID: 1074
		private static readonly global::System.Windows.DependencyProperty TotalDigitsProperty = global::System.Windows.DependencyProperty.Register("TotalDigits", typeof(int?), typeof(global::Infragistics.Windows.Editors.ValueConstraint), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x04000433 RID: 1075
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedDelegate;

		// Token: 0x020000F0 RID: 240
		private enum ComparisonResult
		{
			// Token: 0x04000435 RID: 1077
			Invalid,
			// Token: 0x04000436 RID: 1078
			Equal,
			// Token: 0x04000437 RID: 1079
			LessThan,
			// Token: 0x04000438 RID: 1080
			GreaterThan
		}
	}
}
