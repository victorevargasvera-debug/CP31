using System;
using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000053 RID: 83
	public class ValueConstraint : global::System.Windows.Freezable, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600038B RID: 907 RVA: 0x00012C00 File Offset: 0x00010E00
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			return new global::Infragistics.Controls.Editors.ValueConstraint();
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00012C07 File Offset: 0x00010E07
		protected override bool FreezeCore(bool isChecking)
		{
			if (!isChecking)
			{
				this._propertyChangedDelegate = null;
			}
			return base.FreezeCore(isChecking);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00012C1A File Offset: 0x00010E1A
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00012C2C File Offset: 0x00010E2C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.IEnumerable Enumeration
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.EnumerationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.EnumerationProperty, value);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00012C3A File Offset: 0x00010E3A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeEnumeration()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.EnumerationProperty);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00012C47 File Offset: 0x00010E47
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetEnumeration()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.EnumerationProperty);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00012C54 File Offset: 0x00010E54
		public bool HasEnumeration
		{
			get
			{
				return this.Enumeration != null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00012C62 File Offset: 0x00010E62
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00012C6F File Offset: 0x00010E6F
		[global::System.ComponentModel.Bindable(true)]
		public object FixedValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.FixedValueProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.FixedValueProperty, value);
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00012C7D File Offset: 0x00010E7D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFixedValue()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.FixedValueProperty);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00012C8A File Offset: 0x00010E8A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFixedValue()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.FixedValueProperty);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00012C97 File Offset: 0x00010E97
		public bool HasFixedValue
		{
			get
			{
				return this.FixedValue != null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00012CA5 File Offset: 0x00010EA5
		// (set) Token: 0x06000398 RID: 920 RVA: 0x00012CB2 File Offset: 0x00010EB2
		[global::System.ComponentModel.Bindable(true)]
		public object MaxExclusive
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxExclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxExclusiveProperty, value);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00012CC0 File Offset: 0x00010EC0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxExclusive()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MaxExclusiveProperty);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00012CCD File Offset: 0x00010ECD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxExclusive()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxExclusiveProperty);
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00012CDA File Offset: 0x00010EDA
		public bool HasMaxExclusive
		{
			get
			{
				return this.MaxExclusive != null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00012CE8 File Offset: 0x00010EE8
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00012CF5 File Offset: 0x00010EF5
		[global::System.ComponentModel.Bindable(true)]
		public object MaxInclusive
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxInclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxInclusiveProperty, value);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00012D03 File Offset: 0x00010F03
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxInclusive()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MaxInclusiveProperty);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00012D10 File Offset: 0x00010F10
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxInclusive()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxInclusiveProperty);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00012D1D File Offset: 0x00010F1D
		public bool HasMaxInclusive
		{
			get
			{
				return this.MaxInclusive != null;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00012D2B File Offset: 0x00010F2B
		private static void OnMaxLengthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueConstraint.ValidateMaxLength(e.NewValue);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00012D3A File Offset: 0x00010F3A
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00012D4C File Offset: 0x00010F4C
		[global::System.ComponentModel.Bindable(true)]
		public int MaxLength
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxLengthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxLengthProperty, value);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00012D60 File Offset: 0x00010F60
		private static bool ValidateMaxLength(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00012D7B File Offset: 0x00010F7B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxLength()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MaxLengthProperty);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00012D88 File Offset: 0x00010F88
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxLength()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxLengthProperty);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00012D95 File Offset: 0x00010F95
		public bool HasMaxLength
		{
			get
			{
				return this.MaxLength != 0;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00012DA3 File Offset: 0x00010FA3
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[global::System.ComponentModel.Bindable(true)]
		public object MinExclusive
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.MinExclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.MinExclusiveProperty, value);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00012DBE File Offset: 0x00010FBE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinExclusive()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MinExclusiveProperty);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00012DCB File Offset: 0x00010FCB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinExclusive()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MinExclusiveProperty);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00012DD8 File Offset: 0x00010FD8
		public bool HasMinExclusive
		{
			get
			{
				return this.MinExclusive != null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00012DE6 File Offset: 0x00010FE6
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00012DF3 File Offset: 0x00010FF3
		[global::System.ComponentModel.Bindable(true)]
		public object MinInclusive
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.MinInclusiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.MinInclusiveProperty, value);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00012E01 File Offset: 0x00011001
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinInclusive()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MinInclusiveProperty);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00012E0E File Offset: 0x0001100E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinInclusive()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MinInclusiveProperty);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00012E1B File Offset: 0x0001101B
		public bool HasMinInclusive
		{
			get
			{
				return this.MinInclusive != null;
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00012E29 File Offset: 0x00011029
		private static void OnMinLengthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueConstraint.ValidateMinLength(e.NewValue);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00012E38 File Offset: 0x00011038
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00012E4A File Offset: 0x0001104A
		[global::System.ComponentModel.Bindable(true)]
		public int MinLength
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.MinLengthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.MinLengthProperty, value);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00012E60 File Offset: 0x00011060
		private static bool ValidateMinLength(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00012E7B File Offset: 0x0001107B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinLength()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MinLengthProperty);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00012E88 File Offset: 0x00011088
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinLength()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MinLengthProperty);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00012E95 File Offset: 0x00011095
		public bool HasMinLength
		{
			get
			{
				return this.MinLength > 0;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00012EA0 File Offset: 0x000110A0
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00012EB2 File Offset: 0x000110B2
		[global::System.ComponentModel.Bindable(true)]
		public bool? Nullable
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.NullableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.NullableProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00012EC5 File Offset: 0x000110C5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeNullable()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.NullableProperty);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00012ED2 File Offset: 0x000110D2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetNullable()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.NullableProperty);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00012EE0 File Offset: 0x000110E0
		public bool HasNullable
		{
			get
			{
				return this.Nullable != null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00012EFB File Offset: 0x000110FB
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00012F0D File Offset: 0x0001110D
		[global::System.ComponentModel.Bindable(true)]
		public string RegexPattern
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.RegexPatternProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.RegexPatternProperty, value);
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00012F1C File Offset: 0x0001111C
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

		// Token: 0x060003C1 RID: 961 RVA: 0x00012F60 File Offset: 0x00011160
		private static void OnRegexPatternChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = (global::Infragistics.Controls.Editors.ValueConstraint)dependencyObject;
			valueConstraint._regex = null;
			global::Infragistics.Controls.Editors.ValueConstraint.ValidateRegexPattern(e.NewValue);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00012F88 File Offset: 0x00011188
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRegexPattern()
		{
			return this.RegexPattern != null && this.RegexPattern.Length > 0;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00012FA2 File Offset: 0x000111A2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRegexPattern()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.RegexPatternProperty);
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00012FAF File Offset: 0x000111AF
		public bool HasRegexPattern
		{
			get
			{
				return this.RegexPattern != null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00012FBD File Offset: 0x000111BD
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00012FCF File Offset: 0x000111CF
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.ValidateAsType ValidateAsType
		{
			get
			{
				return (global::Infragistics.Controls.Editors.ValidateAsType)base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.ValidateAsTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.ValidateAsTypeProperty, value);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00012FE2 File Offset: 0x000111E2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValidateAsType()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.ValidateAsTypeProperty);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00012FEF File Offset: 0x000111EF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValidateAsType()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.ValidateAsTypeProperty);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00012FFC File Offset: 0x000111FC
		public static global::System.Type GetTypeFromValidateAsType(global::Infragistics.Controls.Editors.ValidateAsType validateAsType)
		{
			global::Infragistics.Controls.Editors.Primitives.Utils.ValidateEnum("validateAsType", typeof(global::Infragistics.Controls.Editors.ValidateAsType), validateAsType);
			global::System.Type result = null;
			switch (validateAsType)
			{
			case global::Infragistics.Controls.Editors.ValidateAsType.Unknown:
				result = typeof(object);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Boolean:
				result = typeof(bool);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Byte:
				result = typeof(sbyte);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.DateTime:
				result = typeof(global::System.DateTime);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Decimal:
				result = typeof(decimal);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Double:
				result = typeof(double);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Float:
				result = typeof(float);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Integer16:
				result = typeof(short);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Integer32:
				result = typeof(int);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Integer64:
			case global::Infragistics.Controls.Editors.ValidateAsType.NegativeInteger64:
			case global::Infragistics.Controls.Editors.ValidateAsType.NonNegativeInteger64:
			case global::Infragistics.Controls.Editors.ValidateAsType.NonPositiveInteger64:
			case global::Infragistics.Controls.Editors.ValidateAsType.PositiveInteger64:
				result = typeof(long);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Text:
				result = typeof(string);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.TimeSpan:
				result = typeof(global::System.TimeSpan);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.UnsignedByte:
				result = typeof(byte);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.UnsignedInteger16:
				result = typeof(ushort);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.UnsignedInteger32:
				result = typeof(uint);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.UnsignedInteger64:
				result = typeof(ulong);
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.Uri:
				result = typeof(global::System.Uri);
				break;
			}
			return result;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00013178 File Offset: 0x00011378
		public static global::Infragistics.Controls.Editors.ValidateAsType GetValidateAsTypeFromType(global::System.Type type)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			string fullName;
			switch (fullName = type.FullName)
			{
			case "System.Boolean":
				return global::Infragistics.Controls.Editors.ValidateAsType.Boolean;
			case "System.Byte":
				return global::Infragistics.Controls.Editors.ValidateAsType.UnsignedByte;
			case "System.DateTime":
				return global::Infragistics.Controls.Editors.ValidateAsType.DateTime;
			case "System.Decimal":
				return global::Infragistics.Controls.Editors.ValidateAsType.Decimal;
			case "System.Double":
				return global::Infragistics.Controls.Editors.ValidateAsType.Double;
			case "System.Int16":
				return global::Infragistics.Controls.Editors.ValidateAsType.Integer16;
			case "System.Int32":
				return global::Infragistics.Controls.Editors.ValidateAsType.Integer32;
			case "System.Int64":
				return global::Infragistics.Controls.Editors.ValidateAsType.Integer64;
			case "System.SByte":
				return global::Infragistics.Controls.Editors.ValidateAsType.Byte;
			case "System.Single":
				return global::Infragistics.Controls.Editors.ValidateAsType.Float;
			case "System.String":
				return global::Infragistics.Controls.Editors.ValidateAsType.Text;
			case "System.TimeSpan":
				return global::Infragistics.Controls.Editors.ValidateAsType.TimeSpan;
			case "System.UInt16":
				return global::Infragistics.Controls.Editors.ValidateAsType.UnsignedInteger16;
			case "System.UInt32":
				return global::Infragistics.Controls.Editors.ValidateAsType.UnsignedInteger32;
			case "System.UInt64":
				return global::Infragistics.Controls.Editors.ValidateAsType.UnsignedInteger64;
			case "System.Uri":
				return global::Infragistics.Controls.Editors.ValidateAsType.Uri;
			}
			return global::Infragistics.Controls.Editors.ValidateAsType.Unknown;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00013330 File Offset: 0x00011530
		public bool HasAnyConstraints
		{
			get
			{
				return this.HasEnumeration || this.HasFixedValue || this.HasMaxExclusive || this.HasMaxInclusive || this.HasMaxLength || this.HasMinExclusive || this.HasMinInclusive || this.HasMinLength || this.HasNullable || this.HasRegexPattern || this.ValidateAsType != global::Infragistics.Controls.Editors.ValidateAsType.Unknown;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001339C File Offset: 0x0001159C
		public void InitializeFrom(global::Infragistics.Controls.Editors.ValueConstraint source, bool copyEnumeration)
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

		// Token: 0x060003CD RID: 973 RVA: 0x00013454 File Offset: 0x00011654
		public void InitializeFrom(global::Infragistics.Controls.Editors.ValueConstraint source)
		{
			this.InitializeFrom(source, true);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001345E File Offset: 0x0001165E
		public void Merge(global::Infragistics.Controls.Editors.ValueConstraint source, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags)
		{
			this.MergeHelper(source, constraintFlags);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00013468 File Offset: 0x00011668
		public void Merge(global::Infragistics.Controls.Editors.ValueConstraint source)
		{
			this.MergeHelper(source, global::Infragistics.Controls.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00013478 File Offset: 0x00011678
		public void Reset(global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags)
		{
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.Enumeration & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetEnumeration();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.FixedValue & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetFixedValue();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxExclusive & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetMaxExclusive();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxInclusive & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetMaxInclusive();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxLength & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetMaxLength();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.MinExclusive & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetMinExclusive();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.MinInclusive & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetMinInclusive();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.MinLength & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetMinLength();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.Nullable & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetNullable();
			}
			if ((global::Infragistics.Controls.Editors.ValueConstraintFlags.RegexPattern & constraintFlags) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				this.ResetRegexPattern();
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0001350A File Offset: 0x0001170A
		public void Reset()
		{
			this.Reset(global::Infragistics.Controls.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00013518 File Offset: 0x00011718
		public bool Validate(object dataValue, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags, global::System.IFormatProvider formatProvider, string format, ref string errorMessage)
		{
			if (targetType == null)
			{
				throw new global::System.ArgumentNullException("targetType");
			}
			bool flag = global::Infragistics.CoreUtilities.IsNull(dataValue);
			bool flag2 = !flag && dataValue is string && ((string)dataValue).Length == 0;
			if (flag || flag2)
			{
				bool flag3 = this.Nullable ?? true;
				if (!flag3)
				{
					errorMessage = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_Nullable");
				}
				return flag3;
			}
			if ((constraintFlags & global::Infragistics.Controls.Editors.ValueConstraintFlags.ImplicitTypeParameterConstraints) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				global::Infragistics.Controls.Editors.ValidateAsType validateAsTypeFromType = global::Infragistics.Controls.Editors.ValueConstraint.GetValidateAsTypeFromType(targetType);
				if (!this.ValidateImplicitConstraints(dataValue, validateAsTypeFromType, formatProvider, format, ref errorMessage))
				{
					return false;
				}
			}
			if ((constraintFlags & global::Infragistics.Controls.Editors.ValueConstraintFlags.ImplicitValueAsTypeConstraints) != (global::Infragistics.Controls.Editors.ValueConstraintFlags)0 && !this.ValidateImplicitConstraints(dataValue, this.ValidateAsType, formatProvider, format, ref errorMessage))
			{
				return false;
			}
			if (!this.ValidateExplicitConstraints(dataValue, targetType, constraintFlags, formatProvider, format, ref errorMessage))
			{
				return false;
			}
			global::System.Type typeFromValidateAsType = global::Infragistics.Controls.Editors.ValueConstraint.GetTypeFromValidateAsType(this.ValidateAsType);
			return this.ValidateExplicitConstraints(dataValue, typeFromValidateAsType, constraintFlags, formatProvider, format, ref errorMessage);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00013600 File Offset: 0x00011800
		public bool Validate(object dataValue, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags)
		{
			string text = null;
			return this.Validate(dataValue, targetType, constraintFlags, null, null, ref text);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0001361C File Offset: 0x0001181C
		public bool Validate(object dataValue, global::System.Type targetType)
		{
			return this.Validate(dataValue, targetType, global::Infragistics.Controls.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0001362C File Offset: 0x0001182C
		private void MergeHelper(global::Infragistics.Controls.Editors.ValueConstraint source, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags)
		{
			if (source == null || constraintFlags == (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				return;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.Enumeration, constraintFlags, source))
			{
				this.Enumeration = source.Enumeration;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.FixedValue, constraintFlags, source))
			{
				this.FixedValue = source.FixedValue;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxExclusive, constraintFlags, source))
			{
				this.MaxExclusive = source.MaxExclusive;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxInclusive, constraintFlags, source))
			{
				this.MaxInclusive = source.MaxInclusive;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxLength, constraintFlags, source))
			{
				this.MaxLength = source.MaxLength;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MinExclusive, constraintFlags, source))
			{
				this.MinExclusive = source.MinExclusive;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MinInclusive, constraintFlags, source))
			{
				this.MinInclusive = source.MinInclusive;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MinLength, constraintFlags, source))
			{
				this.MinLength = source.MinLength;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.Nullable, constraintFlags, source))
			{
				this.Nullable = source.Nullable;
			}
			if (this.ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.RegexPattern, constraintFlags, source))
			{
				this.RegexPattern = source.RegexPattern;
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00013740 File Offset: 0x00011940
		private bool ShouldMergeConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags targetConstraint, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags, global::Infragistics.Controls.Editors.ValueConstraint source)
		{
			if ((constraintFlags & targetConstraint) == (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				return false;
			}
			if (targetConstraint <= global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxLength)
			{
				if (targetConstraint <= global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxExclusive)
				{
					switch (targetConstraint)
					{
					case global::Infragistics.Controls.Editors.ValueConstraintFlags.Enumeration:
						return !this.HasEnumeration && source.HasEnumeration;
					case global::Infragistics.Controls.Editors.ValueConstraintFlags.FixedValue:
						return !this.HasFixedValue && source.HasFixedValue;
					default:
						if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxExclusive)
						{
							return !this.HasMaxExclusive && source.HasMaxExclusive;
						}
						break;
					}
				}
				else
				{
					if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxInclusive)
					{
						return !this.HasMaxInclusive && source.HasMaxInclusive;
					}
					if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxLength)
					{
						return !this.HasMaxLength && source.HasMaxLength;
					}
				}
			}
			else if (targetConstraint <= global::Infragistics.Controls.Editors.ValueConstraintFlags.MinInclusive)
			{
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MinExclusive)
				{
					return !this.HasMinExclusive && source.HasMinExclusive;
				}
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MinInclusive)
				{
					return !this.HasMinInclusive && source.HasMinInclusive;
				}
			}
			else
			{
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MinLength)
				{
					return !this.HasMinLength && source.HasMinLength;
				}
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.Nullable)
				{
					return !this.HasNullable && source.HasNullable;
				}
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.RegexPattern)
				{
					return !this.HasRegexPattern && source.HasRegexPattern;
				}
			}
			return false;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000138B8 File Offset: 0x00011AB8
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

		// Token: 0x060003D8 RID: 984 RVA: 0x0001394C File Offset: 0x00011B4C
		private global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult PerformComparison(object dataValue, object constraintValue, global::System.Type targetType, global::System.IFormatProvider formatProvider, string formatString)
		{
			global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult result;
			try
			{
				object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, targetType, formatProvider, formatString);
				object obj2 = global::Infragistics.CoreUtilities.ConvertDataValue(constraintValue, targetType, formatProvider, formatString);
				if (obj == null || obj2 == null)
				{
					result = global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.Invalid;
				}
				else
				{
					global::System.IComparable comparable = obj as global::System.IComparable;
					if (comparable != null)
					{
						int num = comparable.CompareTo(obj2);
						if (num == 0)
						{
							result = global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.Equal;
						}
						else if (num < 0)
						{
							result = global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.LessThan;
						}
						else
						{
							result = global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.GreaterThan;
						}
					}
					else
					{
						result = global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.Invalid;
					}
				}
			}
			catch (global::System.Exception)
			{
				result = global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.Invalid;
			}
			return result;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000139C0 File Offset: 0x00011BC0
		private global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult PerformTypeSensitiveComparison(object convertedDataValue, object constraintValue, global::System.Type targetType, global::System.IFormatProvider formatProvider, string formatString)
		{
			global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult result;
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsNumericType(convertedDataValue.GetType()) || global::Infragistics.Controls.Editors.Primitives.Utils.IsNumericType(constraintValue.GetType()))
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

		// Token: 0x060003DA RID: 986 RVA: 0x00013A6C File Offset: 0x00011C6C
		private bool ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags targetConstraint, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags)
		{
			if ((constraintFlags & targetConstraint) == (global::Infragistics.Controls.Editors.ValueConstraintFlags)0)
			{
				return false;
			}
			if (targetConstraint <= global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxLength)
			{
				if (targetConstraint <= global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxExclusive)
				{
					switch (targetConstraint)
					{
					case global::Infragistics.Controls.Editors.ValueConstraintFlags.Enumeration:
						return this.HasEnumeration;
					case global::Infragistics.Controls.Editors.ValueConstraintFlags.FixedValue:
						return this.HasFixedValue;
					default:
						if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxExclusive)
						{
							return this.HasMaxExclusive;
						}
						break;
					}
				}
				else
				{
					if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxInclusive)
					{
						return this.HasMaxInclusive;
					}
					if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxLength)
					{
						return this.HasMaxLength;
					}
				}
			}
			else if (targetConstraint <= global::Infragistics.Controls.Editors.ValueConstraintFlags.MinInclusive)
			{
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MinExclusive)
				{
					return this.HasMinExclusive;
				}
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MinInclusive)
				{
					return this.HasMinInclusive;
				}
			}
			else
			{
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.MinLength)
				{
					return this.HasMinLength;
				}
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.Nullable)
				{
					return this.HasNullable;
				}
				if (targetConstraint == global::Infragistics.Controls.Editors.ValueConstraintFlags.RegexPattern)
				{
					return this.HasRegexPattern;
				}
			}
			return false;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00013B50 File Offset: 0x00011D50
		private bool ValidateImplicitConstraints(object dataValue, global::Infragistics.Controls.Editors.ValidateAsType validateAsType, global::System.IFormatProvider formatProvider, string formatString, ref string errorMsg)
		{
			global::System.Type typeFromValidateAsType = global::Infragistics.Controls.Editors.ValueConstraint.GetTypeFromValidateAsType(validateAsType);
			object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, typeFromValidateAsType, formatProvider, formatString);
			if (obj == null)
			{
				errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_CannotConvert", new object[]
				{
					global::Infragistics.CoreUtilities.GetUnderlyingType(typeFromValidateAsType).FullName
				});
				return false;
			}
			global::System.IComparable comparable = obj as global::System.IComparable;
			bool flag = true;
			switch (validateAsType)
			{
			case global::Infragistics.Controls.Editors.ValidateAsType.NegativeInteger64:
				if (comparable != null)
				{
					bool flag2 = comparable.CompareTo(0L) < 0;
					flag = (flag && flag2);
					if (!flag)
					{
						errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_OutOfRange", new object[]
						{
							long.MinValue.ToString(formatString, formatProvider),
							"-1"
						});
					}
				}
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.NonNegativeInteger64:
				if (comparable != null)
				{
					bool flag3 = comparable.CompareTo(-1L) > 0;
					flag = (flag && flag3);
					if (!flag)
					{
						errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_OutOfRange", new object[]
						{
							"0",
							long.MaxValue.ToString(formatString, formatProvider)
						});
					}
				}
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.NonPositiveInteger64:
				if (comparable != null)
				{
					bool flag4 = comparable.CompareTo(1L) < 0;
					flag = (flag && flag4);
					if (!flag)
					{
						errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_OutOfRange", new object[]
						{
							long.MinValue.ToString(formatString, formatProvider),
							"0"
						});
					}
				}
				break;
			case global::Infragistics.Controls.Editors.ValidateAsType.PositiveInteger64:
				if (comparable != null)
				{
					bool flag5 = comparable.CompareTo(0L) > 0;
					flag = (flag && flag5);
					if (!flag)
					{
						errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_OutOfRange", new object[]
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

		// Token: 0x060003DC RID: 988 RVA: 0x00013D90 File Offset: 0x00011F90
		private bool ValidateExplicitConstraints(object dataValue, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags, global::System.IFormatProvider formatProvider, string formatString, ref string errorMsg)
		{
			object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, targetType, formatProvider, formatString);
			if (obj == null)
			{
				errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_CannotConvert", new object[]
				{
					global::Infragistics.CoreUtilities.GetUnderlyingType(targetType).FullName
				});
				return false;
			}
			string text = obj.ToString();
			bool flag = true;
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.Enumeration, constraintFlags) && !global::Infragistics.Controls.Editors.Primitives.Utils.Exists(this.Enumeration, obj))
			{
				flag = false;
				errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_Enumeration");
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.FixedValue, constraintFlags))
			{
				global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult comparisonResult = this.PerformTypeSensitiveComparison(obj, this.FixedValue, targetType, formatProvider, formatString);
				if (comparisonResult != global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.Equal)
				{
					flag = false;
					errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_FixedValue", new object[]
					{
						this.FixedValue
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxExclusive, constraintFlags))
			{
				global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult comparisonResult2 = this.PerformTypeSensitiveComparison(obj, this.MaxExclusive, targetType, formatProvider, formatString);
				if (comparisonResult2 != global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.LessThan)
				{
					flag = false;
					errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_MaxExclusive", new object[]
					{
						this.MaxExclusive
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxInclusive, constraintFlags))
			{
				global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult comparisonResult3 = this.PerformTypeSensitiveComparison(obj, this.MaxInclusive, targetType, formatProvider, formatString);
				if (comparisonResult3 != global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.LessThan && comparisonResult3 != global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.Equal)
				{
					flag = false;
					errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_MaxInclusive", new object[]
					{
						this.MaxInclusive
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MaxLength, constraintFlags) && this.MaxLength < text.Length)
			{
				flag = false;
				errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_MaxLength", new object[]
				{
					this.MaxLength.ToString(formatString, formatProvider)
				});
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MinExclusive, constraintFlags))
			{
				global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult comparisonResult4 = this.PerformTypeSensitiveComparison(obj, this.MinExclusive, targetType, formatProvider, formatString);
				if (comparisonResult4 != global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.GreaterThan)
				{
					flag = false;
					errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_MinExclusive", new object[]
					{
						this.MinExclusive
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MinInclusive, constraintFlags))
			{
				global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult comparisonResult5 = this.PerformTypeSensitiveComparison(obj, this.MinInclusive, targetType, formatProvider, formatString);
				if (comparisonResult5 != global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.GreaterThan && comparisonResult5 != global::Infragistics.Controls.Editors.ValueConstraint.ComparisonResult.Equal)
				{
					flag = false;
					errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_MinInclusive", new object[]
					{
						this.MinInclusive
					});
				}
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.MinLength, constraintFlags) && text.Length < this.MinLength)
			{
				flag = false;
				errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_MinLength", new object[]
				{
					this.MinLength.ToString(formatString, formatProvider)
				});
			}
			if (flag)
			{
				this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.Nullable, constraintFlags);
			}
			if (flag && this.ShouldTestConstraint(global::Infragistics.Controls.Editors.ValueConstraintFlags.RegexPattern, constraintFlags))
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
					errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_RegexPattern");
				}
			}
			return flag;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003DD RID: 989 RVA: 0x000140FC File Offset: 0x000122FC
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0001410E File Offset: 0x0001230E
		[global::System.ComponentModel.Bindable(true)]
		private int? FractionDigits
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.FractionDigitsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.FractionDigitsProperty, value);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00014121 File Offset: 0x00012321
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private bool ShouldSerializeFractionDigits()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.FractionDigitsProperty);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001412E File Offset: 0x0001232E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private void ResetFractionDigits()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.FractionDigitsProperty);
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0001413C File Offset: 0x0001233C
		private bool HasFractionDigits
		{
			get
			{
				return this.FractionDigits >= 0;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00014163 File Offset: 0x00012363
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00014175 File Offset: 0x00012375
		[global::System.ComponentModel.Bindable(true)]
		private int? TotalDigits
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Controls.Editors.ValueConstraint.TotalDigitsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.ValueConstraint.TotalDigitsProperty, value);
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00014188 File Offset: 0x00012388
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private bool ShouldSerializeTotalDigits()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.TotalDigitsProperty);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00014195 File Offset: 0x00012395
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private void ResetTotalDigits()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.TotalDigitsProperty);
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x000141A4 File Offset: 0x000123A4
		private bool HasTotalDigits
		{
			get
			{
				return this.TotalDigits >= 0;
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000141CC File Offset: 0x000123CC
		private static void OnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = (global::Infragistics.Controls.Editors.ValueConstraint)d;
			global::System.Windows.DependencyProperty property = e.Property;
			object newValue = e.NewValue;
			if (global::Infragistics.Controls.Editors.ValueConstraint.MaxLengthProperty == property)
			{
				global::Infragistics.Controls.Editors.ValueConstraint.ValidateMaxLength(newValue);
			}
			else if (global::Infragistics.Controls.Editors.ValueConstraint.MinLengthProperty == property)
			{
				global::Infragistics.Controls.Editors.ValueConstraint.ValidateMinLength(newValue);
			}
			else if (global::Infragistics.Controls.Editors.ValueConstraint.RegexPatternProperty == property)
			{
				global::Infragistics.Controls.Editors.ValueConstraint.ValidateRegexPattern(newValue);
			}
			valueConstraint.RaisePropertyChanged(global::Infragistics.DependencyPropertyUtilities.GetName(property));
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0001422D File Offset: 0x0001242D
		private void RaisePropertyChanged(string propName)
		{
			if (this._propertyChangedDelegate != null)
			{
				this._propertyChangedDelegate(this, new global::System.ComponentModel.PropertyChangedEventArgs(propName));
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060003E9 RID: 1001 RVA: 0x00014249 File Offset: 0x00012449
		// (remove) Token: 0x060003EA RID: 1002 RVA: 0x00014278 File Offset: 0x00012478
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				base.WritePreamble();
				if (this._propertyChangedDelegate == null)
				{
					this._propertyChangedDelegate = value;
					return;
				}
				this._propertyChangedDelegate = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(this._propertyChangedDelegate, value);
			}
			remove
			{
				if (this._propertyChangedDelegate == null)
				{
					return;
				}
				base.WritePreamble();
				if (this._propertyChangedDelegate != null)
				{
					this._propertyChangedDelegate = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(this._propertyChangedDelegate, value);
				}
			}
		}

		// Token: 0x04000167 RID: 359
		private const int NOTSET = -1;

		// Token: 0x04000168 RID: 360
		private const int DEFAULT_LENGTH = 0;

		// Token: 0x04000169 RID: 361
		private global::System.Text.RegularExpressions.Regex _regex;

		// Token: 0x0400016A RID: 362
		public static readonly global::System.Windows.DependencyProperty EnumerationProperty = global::Infragistics.DependencyPropertyUtilities.Register("Enumeration", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016B RID: 363
		public static readonly global::System.Windows.DependencyProperty FixedValueProperty = global::Infragistics.DependencyPropertyUtilities.Register("FixedValue", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016C RID: 364
		public static readonly global::System.Windows.DependencyProperty MaxExclusiveProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxExclusive", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016D RID: 365
		public static readonly global::System.Windows.DependencyProperty MaxInclusiveProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxInclusive", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016E RID: 366
		public static readonly global::System.Windows.DependencyProperty MaxLengthProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxLength", typeof(int), typeof(global::Infragistics.Controls.Editors.ValueConstraint), 0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016F RID: 367
		public static readonly global::System.Windows.DependencyProperty MinExclusiveProperty = global::Infragistics.DependencyPropertyUtilities.Register("MinExclusive", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000170 RID: 368
		public static readonly global::System.Windows.DependencyProperty MinInclusiveProperty = global::Infragistics.DependencyPropertyUtilities.Register("MinInclusive", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000171 RID: 369
		public static readonly global::System.Windows.DependencyProperty MinLengthProperty = global::Infragistics.DependencyPropertyUtilities.Register("MinLength", typeof(int), typeof(global::Infragistics.Controls.Editors.ValueConstraint), 0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnMinLengthChanged));

		// Token: 0x04000172 RID: 370
		public static readonly global::System.Windows.DependencyProperty NullableProperty = global::Infragistics.DependencyPropertyUtilities.Register("Nullable", typeof(bool?), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000173 RID: 371
		public static readonly global::System.Windows.DependencyProperty RegexPatternProperty = global::Infragistics.DependencyPropertyUtilities.Register("RegexPattern", typeof(string), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnRegexPatternChanged));

		// Token: 0x04000174 RID: 372
		public static readonly global::System.Windows.DependencyProperty ValidateAsTypeProperty = global::Infragistics.DependencyPropertyUtilities.Register("ValidateAsType", typeof(global::Infragistics.Controls.Editors.ValidateAsType), typeof(global::Infragistics.Controls.Editors.ValueConstraint), global::Infragistics.Controls.Editors.ValidateAsType.Unknown, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000175 RID: 373
		private static readonly global::System.Windows.DependencyProperty FractionDigitsProperty = global::Infragistics.DependencyPropertyUtilities.Register("FractionDigits", typeof(int?), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000176 RID: 374
		private static readonly global::System.Windows.DependencyProperty TotalDigitsProperty = global::Infragistics.DependencyPropertyUtilities.Register("TotalDigits", typeof(int?), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000177 RID: 375
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedDelegate;

		// Token: 0x02000054 RID: 84
		private enum ComparisonResult
		{
			// Token: 0x04000179 RID: 377
			Invalid,
			// Token: 0x0400017A RID: 378
			Equal,
			// Token: 0x0400017B RID: 379
			LessThan,
			// Token: 0x0400017C RID: 380
			GreaterThan
		}
	}
}
