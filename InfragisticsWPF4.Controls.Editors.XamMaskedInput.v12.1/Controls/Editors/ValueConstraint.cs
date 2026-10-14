using System;
using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000054 RID: 84
	public class ValueConstraint : global::System.Windows.DependencyObject, global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.ISupportPropertyChangeNotifications, global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00012CBC File Offset: 0x00010EBC
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00012CCE File Offset: 0x00010ECE
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

		// Token: 0x06000388 RID: 904 RVA: 0x00012CDC File Offset: 0x00010EDC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeEnumeration()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.EnumerationProperty);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00012CE9 File Offset: 0x00010EE9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetEnumeration()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.EnumerationProperty);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00012CF6 File Offset: 0x00010EF6
		public bool HasEnumeration
		{
			get
			{
				return this.Enumeration != null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00012D04 File Offset: 0x00010F04
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00012D11 File Offset: 0x00010F11
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

		// Token: 0x0600038D RID: 909 RVA: 0x00012D1F File Offset: 0x00010F1F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFixedValue()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.FixedValueProperty);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00012D2C File Offset: 0x00010F2C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFixedValue()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.FixedValueProperty);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00012D39 File Offset: 0x00010F39
		public bool HasFixedValue
		{
			get
			{
				return this.FixedValue != null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00012D47 File Offset: 0x00010F47
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00012D54 File Offset: 0x00010F54
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

		// Token: 0x06000392 RID: 914 RVA: 0x00012D62 File Offset: 0x00010F62
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxExclusive()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MaxExclusiveProperty);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00012D6F File Offset: 0x00010F6F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxExclusive()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxExclusiveProperty);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00012D7C File Offset: 0x00010F7C
		public bool HasMaxExclusive
		{
			get
			{
				return this.MaxExclusive != null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00012D8A File Offset: 0x00010F8A
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00012D97 File Offset: 0x00010F97
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

		// Token: 0x06000397 RID: 919 RVA: 0x00012DA5 File Offset: 0x00010FA5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxInclusive()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MaxInclusiveProperty);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00012DB2 File Offset: 0x00010FB2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxInclusive()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxInclusiveProperty);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00012DBF File Offset: 0x00010FBF
		public bool HasMaxInclusive
		{
			get
			{
				return this.MaxInclusive != null;
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00012DCD File Offset: 0x00010FCD
		private static void OnMaxLengthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueConstraint.ValidateMaxLength(e.NewValue);
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00012DDC File Offset: 0x00010FDC
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00012DEE File Offset: 0x00010FEE
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

		// Token: 0x0600039D RID: 925 RVA: 0x00012E04 File Offset: 0x00011004
		private static bool ValidateMaxLength(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00012E1F File Offset: 0x0001101F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxLength()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MaxLengthProperty);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00012E2C File Offset: 0x0001102C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxLength()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MaxLengthProperty);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00012E39 File Offset: 0x00011039
		public bool HasMaxLength
		{
			get
			{
				return this.MaxLength != 0;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00012E47 File Offset: 0x00011047
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00012E54 File Offset: 0x00011054
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

		// Token: 0x060003A3 RID: 931 RVA: 0x00012E62 File Offset: 0x00011062
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinExclusive()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MinExclusiveProperty);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00012E6F File Offset: 0x0001106F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinExclusive()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MinExclusiveProperty);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00012E7C File Offset: 0x0001107C
		public bool HasMinExclusive
		{
			get
			{
				return this.MinExclusive != null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00012E8A File Offset: 0x0001108A
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00012E97 File Offset: 0x00011097
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

		// Token: 0x060003A8 RID: 936 RVA: 0x00012EA5 File Offset: 0x000110A5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinInclusive()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MinInclusiveProperty);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00012EB2 File Offset: 0x000110B2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinInclusive()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MinInclusiveProperty);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00012EBF File Offset: 0x000110BF
		public bool HasMinInclusive
		{
			get
			{
				return this.MinInclusive != null;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00012ECD File Offset: 0x000110CD
		private static void OnMinLengthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueConstraint.ValidateMinLength(e.NewValue);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00012EDC File Offset: 0x000110DC
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00012EEE File Offset: 0x000110EE
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

		// Token: 0x060003AE RID: 942 RVA: 0x00012F04 File Offset: 0x00011104
		private static bool ValidateMinLength(object objVal)
		{
			int num = (int)objVal;
			return num >= 0;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00012F1F File Offset: 0x0001111F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMinLength()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.MinLengthProperty);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00012F2C File Offset: 0x0001112C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMinLength()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.MinLengthProperty);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00012F39 File Offset: 0x00011139
		public bool HasMinLength
		{
			get
			{
				return this.MinLength > 0;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00012F44 File Offset: 0x00011144
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00012F56 File Offset: 0x00011156
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

		// Token: 0x060003B4 RID: 948 RVA: 0x00012F69 File Offset: 0x00011169
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeNullable()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.NullableProperty);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00012F76 File Offset: 0x00011176
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetNullable()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.NullableProperty);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00012F84 File Offset: 0x00011184
		public bool HasNullable
		{
			get
			{
				return this.Nullable != null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00012F9F File Offset: 0x0001119F
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00012FB1 File Offset: 0x000111B1
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

		// Token: 0x060003B9 RID: 953 RVA: 0x00012FC0 File Offset: 0x000111C0
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

		// Token: 0x060003BA RID: 954 RVA: 0x00013004 File Offset: 0x00011204
		private static void OnRegexPatternChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.ValueConstraint valueConstraint = (global::Infragistics.Controls.Editors.ValueConstraint)dependencyObject;
			valueConstraint._regex = null;
			global::Infragistics.Controls.Editors.ValueConstraint.ValidateRegexPattern(e.NewValue);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001302C File Offset: 0x0001122C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRegexPattern()
		{
			return this.RegexPattern != null && this.RegexPattern.Length > 0;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00013046 File Offset: 0x00011246
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRegexPattern()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.RegexPatternProperty);
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00013053 File Offset: 0x00011253
		public bool HasRegexPattern
		{
			get
			{
				return this.RegexPattern != null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00013061 File Offset: 0x00011261
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00013073 File Offset: 0x00011273
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

		// Token: 0x060003C0 RID: 960 RVA: 0x00013086 File Offset: 0x00011286
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeValidateAsType()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.ValidateAsTypeProperty);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00013093 File Offset: 0x00011293
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetValidateAsType()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.ValidateAsTypeProperty);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000130A0 File Offset: 0x000112A0
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

		// Token: 0x060003C3 RID: 963 RVA: 0x0001321C File Offset: 0x0001141C
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

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000133D4 File Offset: 0x000115D4
		public bool HasAnyConstraints
		{
			get
			{
				return this.HasEnumeration || this.HasFixedValue || this.HasMaxExclusive || this.HasMaxInclusive || this.HasMaxLength || this.HasMinExclusive || this.HasMinInclusive || this.HasMinLength || this.HasNullable || this.HasRegexPattern || this.ValidateAsType != global::Infragistics.Controls.Editors.ValidateAsType.Unknown;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00013440 File Offset: 0x00011640
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

		// Token: 0x060003C6 RID: 966 RVA: 0x000134F8 File Offset: 0x000116F8
		public void InitializeFrom(global::Infragistics.Controls.Editors.ValueConstraint source)
		{
			this.InitializeFrom(source, true);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00013502 File Offset: 0x00011702
		public void Merge(global::Infragistics.Controls.Editors.ValueConstraint source, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags)
		{
			this.MergeHelper(source, constraintFlags);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0001350C File Offset: 0x0001170C
		public void Merge(global::Infragistics.Controls.Editors.ValueConstraint source)
		{
			this.MergeHelper(source, global::Infragistics.Controls.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001351C File Offset: 0x0001171C
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

		// Token: 0x060003CA RID: 970 RVA: 0x000135AE File Offset: 0x000117AE
		public void Reset()
		{
			this.Reset(global::Infragistics.Controls.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000135BC File Offset: 0x000117BC
		public bool Validate(object dataValue, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags, global::System.IFormatProvider formatProvider, string format, ref string errorMessage)
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

		// Token: 0x060003CC RID: 972 RVA: 0x000136AC File Offset: 0x000118AC
		public bool Validate(object dataValue, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags)
		{
			string text = null;
			return this.Validate(dataValue, targetType, constraintFlags, null, null, ref text);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000136C8 File Offset: 0x000118C8
		public bool Validate(object dataValue, global::System.Type targetType)
		{
			return this.Validate(dataValue, targetType, global::Infragistics.Controls.Editors.ValueConstraintFlags.All);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000136D8 File Offset: 0x000118D8
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

		// Token: 0x060003CF RID: 975 RVA: 0x000137EC File Offset: 0x000119EC
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

		// Token: 0x060003D0 RID: 976 RVA: 0x00013964 File Offset: 0x00011B64
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

		// Token: 0x060003D1 RID: 977 RVA: 0x000139F8 File Offset: 0x00011BF8
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

		// Token: 0x060003D2 RID: 978 RVA: 0x00013A6C File Offset: 0x00011C6C
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

		// Token: 0x060003D3 RID: 979 RVA: 0x00013B18 File Offset: 0x00011D18
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

		// Token: 0x060003D4 RID: 980 RVA: 0x00013BFC File Offset: 0x00011DFC
		private bool ValidateImplicitConstraints(object dataValue, global::Infragistics.Controls.Editors.ValidateAsType validateAsType, global::System.IFormatProvider formatProvider, string formatString, ref string errorMsg)
		{
			global::System.Type typeFromValidateAsType = global::Infragistics.Controls.Editors.ValueConstraint.GetTypeFromValidateAsType(validateAsType);
			object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, typeFromValidateAsType, formatProvider, formatString);
			if (obj == null)
			{
				errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_CannotConvert", new object[]
				{
					typeFromValidateAsType.FullName
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

		// Token: 0x060003D5 RID: 981 RVA: 0x00013E34 File Offset: 0x00012034
		private bool ValidateExplicitConstraints(object dataValue, global::System.Type targetType, global::Infragistics.Controls.Editors.ValueConstraintFlags constraintFlags, global::System.IFormatProvider formatProvider, string formatString, ref string errorMsg)
		{
			object obj = global::Infragistics.CoreUtilities.ConvertDataValue(dataValue, targetType, formatProvider, formatString);
			if (obj == null)
			{
				errorMsg = global::Infragistics.Controls.Editors.ValueInput.GetString("LMSG_ValueConstraint_CannotConvert", new object[]
				{
					targetType.FullName
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001419C File Offset: 0x0001239C
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000141AE File Offset: 0x000123AE
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

		// Token: 0x060003D8 RID: 984 RVA: 0x000141C1 File Offset: 0x000123C1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private bool ShouldSerializeFractionDigits()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.FractionDigitsProperty);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000141CE File Offset: 0x000123CE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private void ResetFractionDigits()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.FractionDigitsProperty);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000141DC File Offset: 0x000123DC
		private bool HasFractionDigits
		{
			get
			{
				return this.FractionDigits >= 0;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00014203 File Offset: 0x00012403
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00014215 File Offset: 0x00012415
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

		// Token: 0x060003DD RID: 989 RVA: 0x00014228 File Offset: 0x00012428
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private bool ShouldSerializeTotalDigits()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.ValueConstraint.TotalDigitsProperty);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00014235 File Offset: 0x00012435
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private void ResetTotalDigits()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.ValueConstraint.TotalDigitsProperty);
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00014244 File Offset: 0x00012444
		private bool HasTotalDigits
		{
			get
			{
				return this.TotalDigits >= 0;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001426C File Offset: 0x0001246C
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

		// Token: 0x060003E1 RID: 993 RVA: 0x000142CD File Offset: 0x000124CD
		private void RaisePropertyChanged(string propName)
		{
			if (this._propertyChangedDelegate != null)
			{
				this._propertyChangedDelegate(this, new global::System.ComponentModel.PropertyChangedEventArgs(propName));
			}
			if (this._listeners != null)
			{
				this._listeners.OnPropertyValueChanged(this, propName, null);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060003E2 RID: 994 RVA: 0x000142FF File Offset: 0x000124FF
		// (remove) Token: 0x060003E3 RID: 995 RVA: 0x00014328 File Offset: 0x00012528
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

		// Token: 0x060003E4 RID: 996 RVA: 0x00014349 File Offset: 0x00012549
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.AddListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener, bool useWeakReference)
		{
			if (this._listeners == null)
			{
				this._listeners = new global::Infragistics.PropertyChangeListenerList();
			}
			this._listeners.Add(listener, useWeakReference);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0001436B File Offset: 0x0001256B
		void global::Infragistics.ITypedSupportPropertyChangeNotifications<object, string>.RemoveListener(global::Infragistics.ITypedPropertyChangeListener<object, string> listener)
		{
			if (this._listeners != null)
			{
				this._listeners.Remove(listener);
			}
		}

		// Token: 0x04000162 RID: 354
		private const int NOTSET = -1;

		// Token: 0x04000163 RID: 355
		private const int DEFAULT_LENGTH = 0;

		// Token: 0x04000164 RID: 356
		private global::System.Text.RegularExpressions.Regex _regex;

		// Token: 0x04000165 RID: 357
		private global::Infragistics.PropertyChangeListenerList _listeners;

		// Token: 0x04000166 RID: 358
		public static readonly global::System.Windows.DependencyProperty EnumerationProperty = global::Infragistics.DependencyPropertyUtilities.Register("Enumeration", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000167 RID: 359
		public static readonly global::System.Windows.DependencyProperty FixedValueProperty = global::Infragistics.DependencyPropertyUtilities.Register("FixedValue", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000168 RID: 360
		public static readonly global::System.Windows.DependencyProperty MaxExclusiveProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxExclusive", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000169 RID: 361
		public static readonly global::System.Windows.DependencyProperty MaxInclusiveProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxInclusive", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016A RID: 362
		public static readonly global::System.Windows.DependencyProperty MaxLengthProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxLength", typeof(int), typeof(global::Infragistics.Controls.Editors.ValueConstraint), 0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016B RID: 363
		public static readonly global::System.Windows.DependencyProperty MinExclusiveProperty = global::Infragistics.DependencyPropertyUtilities.Register("MinExclusive", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016C RID: 364
		public static readonly global::System.Windows.DependencyProperty MinInclusiveProperty = global::Infragistics.DependencyPropertyUtilities.Register("MinInclusive", typeof(object), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016D RID: 365
		public static readonly global::System.Windows.DependencyProperty MinLengthProperty = global::Infragistics.DependencyPropertyUtilities.Register("MinLength", typeof(int), typeof(global::Infragistics.Controls.Editors.ValueConstraint), 0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnMinLengthChanged));

		// Token: 0x0400016E RID: 366
		public static readonly global::System.Windows.DependencyProperty NullableProperty = global::Infragistics.DependencyPropertyUtilities.Register("Nullable", typeof(bool?), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x0400016F RID: 367
		public static readonly global::System.Windows.DependencyProperty RegexPatternProperty = global::Infragistics.DependencyPropertyUtilities.Register("RegexPattern", typeof(string), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnRegexPatternChanged));

		// Token: 0x04000170 RID: 368
		public static readonly global::System.Windows.DependencyProperty ValidateAsTypeProperty = global::Infragistics.DependencyPropertyUtilities.Register("ValidateAsType", typeof(global::Infragistics.Controls.Editors.ValidateAsType), typeof(global::Infragistics.Controls.Editors.ValueConstraint), global::Infragistics.Controls.Editors.ValidateAsType.Unknown, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000171 RID: 369
		private static readonly global::System.Windows.DependencyProperty FractionDigitsProperty = global::Infragistics.DependencyPropertyUtilities.Register("FractionDigits", typeof(int?), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000172 RID: 370
		private static readonly global::System.Windows.DependencyProperty TotalDigitsProperty = global::Infragistics.DependencyPropertyUtilities.Register("TotalDigits", typeof(int?), typeof(global::Infragistics.Controls.Editors.ValueConstraint), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueConstraint.OnPropertyChanged));

		// Token: 0x04000173 RID: 371
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedDelegate;

		// Token: 0x02000055 RID: 85
		private enum ComparisonResult
		{
			// Token: 0x04000175 RID: 373
			Invalid,
			// Token: 0x04000176 RID: 374
			Equal,
			// Token: 0x04000177 RID: 375
			LessThan,
			// Token: 0x04000178 RID: 376
			GreaterThan
		}
	}
}
