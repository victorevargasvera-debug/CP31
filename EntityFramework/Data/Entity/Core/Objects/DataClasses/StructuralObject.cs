using System;
using System.ComponentModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core.Objects.DataClasses
{
	// Token: 0x02000485 RID: 1157
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public abstract class StructuralObject : global::System.ComponentModel.INotifyPropertyChanging, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06003943 RID: 14659 RVA: 0x000BC980 File Offset: 0x000BAB80
		// (remove) Token: 0x06003944 RID: 14660 RVA: 0x000BC9B8 File Offset: 0x000BABB8
		[global::System.NonSerialized]
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06003945 RID: 14661 RVA: 0x000BC9F0 File Offset: 0x000BABF0
		// (remove) Token: 0x06003946 RID: 14662 RVA: 0x000BCA28 File Offset: 0x000BAC28
		[global::System.NonSerialized]
		public event global::System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

		// Token: 0x06003947 RID: 14663 RVA: 0x000BCA5D File Offset: 0x000BAC5D
		protected virtual void OnPropertyChanged(string property)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
			}
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x000BCA79 File Offset: 0x000BAC79
		protected virtual void OnPropertyChanging(string property)
		{
			if (this.PropertyChanging != null)
			{
				this.PropertyChanging(this, new global::System.ComponentModel.PropertyChangingEventArgs(property));
			}
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x000BCA95 File Offset: 0x000BAC95
		protected static global::System.DateTime DefaultDateTimeValue()
		{
			return global::System.DateTime.Now;
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x000BCA9C File Offset: 0x000BAC9C
		protected virtual void ReportPropertyChanging(string property)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(property, "property");
			this.OnPropertyChanging(property);
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x000BCAB1 File Offset: 0x000BACB1
		protected virtual void ReportPropertyChanged(string property)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(property, "property");
			this.OnPropertyChanged(property);
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x000BCAC6 File Offset: 0x000BACC6
		protected internal T GetValidValue<T>(T currentValue, string property, bool isNullable, bool isInitialized) where T : global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject, new()
		{
			if (!isNullable && !isInitialized)
			{
				currentValue = this.SetValidValue<T>(currentValue, global::System.Activator.CreateInstance<T>(), property);
			}
			return currentValue;
		}

		// Token: 0x0600394D RID: 14669
		internal abstract void ReportComplexPropertyChanging(string entityMemberName, global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject complexObject, string complexMemberName);

		// Token: 0x0600394E RID: 14670
		internal abstract void ReportComplexPropertyChanged(string entityMemberName, global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject complexObject, string complexMemberName);

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600394F RID: 14671
		internal abstract bool IsChangeTracked { get; }

		// Token: 0x06003950 RID: 14672 RVA: 0x000BCADF File Offset: 0x000BACDF
		protected internal static bool BinaryEquals(byte[] first, byte[] second)
		{
			return first == second || (first != null && second != null && global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.CompareBinaryValues(first, second));
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x000BCAF6 File Offset: 0x000BACF6
		protected internal static byte[] GetValidValue(byte[] currentValue)
		{
			if (currentValue == null)
			{
				return null;
			}
			return (byte[])currentValue.Clone();
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x000BCB08 File Offset: 0x000BAD08
		protected internal static byte[] SetValidValue(byte[] value, bool isNullable, string propertyName)
		{
			if (value == null)
			{
				if (!isNullable)
				{
					global::System.Data.Entity.Core.EntityUtil.ThrowPropertyIsNotNullable(propertyName);
				}
				return value;
			}
			return (byte[])value.Clone();
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x000BCB23 File Offset: 0x000BAD23
		protected internal static byte[] SetValidValue(byte[] value, bool isNullable)
		{
			return global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject.SetValidValue(value, isNullable, null);
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x000BCB2D File Offset: 0x000BAD2D
		protected internal static bool SetValidValue(bool value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x000BCB30 File Offset: 0x000BAD30
		protected internal static bool SetValidValue(bool value)
		{
			return value;
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x000BCB33 File Offset: 0x000BAD33
		protected internal static bool? SetValidValue(bool? value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x000BCB36 File Offset: 0x000BAD36
		protected internal static bool? SetValidValue(bool? value)
		{
			return value;
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x000BCB39 File Offset: 0x000BAD39
		protected internal static byte SetValidValue(byte value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x000BCB3C File Offset: 0x000BAD3C
		protected internal static byte SetValidValue(byte value)
		{
			return value;
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x000BCB3F File Offset: 0x000BAD3F
		protected internal static byte? SetValidValue(byte? value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x000BCB42 File Offset: 0x000BAD42
		protected internal static byte? SetValidValue(byte? value)
		{
			return value;
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x000BCB45 File Offset: 0x000BAD45
		[global::System.CLSCompliant(false)]
		protected internal static sbyte SetValidValue(sbyte value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x000BCB48 File Offset: 0x000BAD48
		[global::System.CLSCompliant(false)]
		protected internal static sbyte SetValidValue(sbyte value)
		{
			return value;
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x000BCB4B File Offset: 0x000BAD4B
		[global::System.CLSCompliant(false)]
		protected internal static sbyte? SetValidValue(sbyte? value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x000BCB4E File Offset: 0x000BAD4E
		[global::System.CLSCompliant(false)]
		protected internal static sbyte? SetValidValue(sbyte? value)
		{
			return value;
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x000BCB51 File Offset: 0x000BAD51
		protected internal static global::System.DateTime SetValidValue(global::System.DateTime value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x000BCB54 File Offset: 0x000BAD54
		protected internal static global::System.DateTime SetValidValue(global::System.DateTime value)
		{
			return value;
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x000BCB57 File Offset: 0x000BAD57
		protected internal static global::System.DateTime? SetValidValue(global::System.DateTime? value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x000BCB5A File Offset: 0x000BAD5A
		protected internal static global::System.DateTime? SetValidValue(global::System.DateTime? value)
		{
			return value;
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x000BCB5D File Offset: 0x000BAD5D
		protected internal static global::System.TimeSpan SetValidValue(global::System.TimeSpan value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x000BCB60 File Offset: 0x000BAD60
		protected internal static global::System.TimeSpan SetValidValue(global::System.TimeSpan value)
		{
			return value;
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x000BCB63 File Offset: 0x000BAD63
		protected internal static global::System.TimeSpan? SetValidValue(global::System.TimeSpan? value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x000BCB66 File Offset: 0x000BAD66
		protected internal static global::System.TimeSpan? SetValidValue(global::System.TimeSpan? value)
		{
			return value;
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x000BCB69 File Offset: 0x000BAD69
		protected internal static global::System.DateTimeOffset SetValidValue(global::System.DateTimeOffset value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x000BCB6C File Offset: 0x000BAD6C
		protected internal static global::System.DateTimeOffset SetValidValue(global::System.DateTimeOffset value)
		{
			return value;
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x000BCB6F File Offset: 0x000BAD6F
		protected internal static global::System.DateTimeOffset? SetValidValue(global::System.DateTimeOffset? value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x000BCB72 File Offset: 0x000BAD72
		protected internal static global::System.DateTimeOffset? SetValidValue(global::System.DateTimeOffset? value)
		{
			return value;
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x000BCB75 File Offset: 0x000BAD75
		protected internal static decimal SetValidValue(decimal value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x000BCB78 File Offset: 0x000BAD78
		protected internal static decimal SetValidValue(decimal value)
		{
			return value;
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x000BCB7B File Offset: 0x000BAD7B
		protected internal static decimal? SetValidValue(decimal? value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x000BCB7E File Offset: 0x000BAD7E
		protected internal static decimal? SetValidValue(decimal? value)
		{
			return value;
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x000BCB81 File Offset: 0x000BAD81
		protected internal static double SetValidValue(double value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x000BCB84 File Offset: 0x000BAD84
		protected internal static double SetValidValue(double value)
		{
			return value;
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x000BCB87 File Offset: 0x000BAD87
		protected internal static double? SetValidValue(double? value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x000BCB8A File Offset: 0x000BAD8A
		protected internal static double? SetValidValue(double? value)
		{
			return value;
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x000BCB8D File Offset: 0x000BAD8D
		protected internal static float SetValidValue(float value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x000BCB90 File Offset: 0x000BAD90
		protected internal static float SetValidValue(float value)
		{
			return value;
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x000BCB93 File Offset: 0x000BAD93
		protected internal static float? SetValidValue(float? value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x000BCB96 File Offset: 0x000BAD96
		protected internal static float? SetValidValue(float? value)
		{
			return value;
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x000BCB99 File Offset: 0x000BAD99
		protected internal static global::System.Guid SetValidValue(global::System.Guid value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x000BCB9C File Offset: 0x000BAD9C
		protected internal static global::System.Guid SetValidValue(global::System.Guid value)
		{
			return value;
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x000BCB9F File Offset: 0x000BAD9F
		protected internal static global::System.Guid? SetValidValue(global::System.Guid? value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x000BCBA2 File Offset: 0x000BADA2
		protected internal static global::System.Guid? SetValidValue(global::System.Guid? value)
		{
			return value;
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x000BCBA5 File Offset: 0x000BADA5
		protected internal static short SetValidValue(short value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x000BCBA8 File Offset: 0x000BADA8
		protected internal static short SetValidValue(short value)
		{
			return value;
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x000BCBAB File Offset: 0x000BADAB
		protected internal static short? SetValidValue(short? value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x000BCBAE File Offset: 0x000BADAE
		protected internal static short? SetValidValue(short? value)
		{
			return value;
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x000BCBB1 File Offset: 0x000BADB1
		protected internal static int SetValidValue(int value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x000BCBB4 File Offset: 0x000BADB4
		protected internal static int SetValidValue(int value)
		{
			return value;
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x000BCBB7 File Offset: 0x000BADB7
		protected internal static int? SetValidValue(int? value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x000BCBBA File Offset: 0x000BADBA
		protected internal static int? SetValidValue(int? value)
		{
			return value;
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x000BCBBD File Offset: 0x000BADBD
		protected internal static long SetValidValue(long value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x000BCBC0 File Offset: 0x000BADC0
		protected internal static long SetValidValue(long value)
		{
			return value;
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x000BCBC3 File Offset: 0x000BADC3
		protected internal static long? SetValidValue(long? value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x000BCBC6 File Offset: 0x000BADC6
		protected internal static long? SetValidValue(long? value)
		{
			return value;
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x000BCBC9 File Offset: 0x000BADC9
		[global::System.CLSCompliant(false)]
		protected internal static ushort SetValidValue(ushort value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x000BCBCC File Offset: 0x000BADCC
		[global::System.CLSCompliant(false)]
		protected internal static ushort SetValidValue(ushort value)
		{
			return value;
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x000BCBCF File Offset: 0x000BADCF
		[global::System.CLSCompliant(false)]
		protected internal static ushort? SetValidValue(ushort? value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x000BCBD2 File Offset: 0x000BADD2
		[global::System.CLSCompliant(false)]
		protected internal static ushort? SetValidValue(ushort? value)
		{
			return value;
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x000BCBD5 File Offset: 0x000BADD5
		[global::System.CLSCompliant(false)]
		protected internal static uint SetValidValue(uint value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x000BCBD8 File Offset: 0x000BADD8
		[global::System.CLSCompliant(false)]
		protected internal static uint SetValidValue(uint value)
		{
			return value;
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x000BCBDB File Offset: 0x000BADDB
		[global::System.CLSCompliant(false)]
		protected internal static uint? SetValidValue(uint? value, string propertyName)
		{
			return value;
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x000BCBDE File Offset: 0x000BADDE
		[global::System.CLSCompliant(false)]
		protected internal static uint? SetValidValue(uint? value)
		{
			return value;
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x000BCBE1 File Offset: 0x000BADE1
		[global::System.CLSCompliant(false)]
		protected internal static ulong SetValidValue(ulong value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x000BCBE4 File Offset: 0x000BADE4
		[global::System.CLSCompliant(false)]
		protected internal static ulong SetValidValue(ulong value)
		{
			return value;
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x000BCBE7 File Offset: 0x000BADE7
		[global::System.CLSCompliant(false)]
		protected internal static ulong? SetValidValue(ulong? value, string propertyName)
		{
			return value;
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x000BCBEA File Offset: 0x000BADEA
		[global::System.CLSCompliant(false)]
		protected internal static ulong? SetValidValue(ulong? value)
		{
			return value;
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x000BCBED File Offset: 0x000BADED
		protected internal static string SetValidValue(string value, bool isNullable, string propertyName)
		{
			if (value == null && !isNullable)
			{
				global::System.Data.Entity.Core.EntityUtil.ThrowPropertyIsNotNullable(propertyName);
			}
			return value;
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x000BCBFC File Offset: 0x000BADFC
		protected internal static string SetValidValue(string value, bool isNullable)
		{
			return global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject.SetValidValue(value, isNullable, null);
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x000BCC06 File Offset: 0x000BAE06
		protected internal static global::System.Data.Entity.Spatial.DbGeography SetValidValue(global::System.Data.Entity.Spatial.DbGeography value, bool isNullable, string propertyName)
		{
			if (value == null && !isNullable)
			{
				global::System.Data.Entity.Core.EntityUtil.ThrowPropertyIsNotNullable(propertyName);
			}
			return value;
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x000BCC15 File Offset: 0x000BAE15
		protected internal static global::System.Data.Entity.Spatial.DbGeography SetValidValue(global::System.Data.Entity.Spatial.DbGeography value, bool isNullable)
		{
			return global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject.SetValidValue(value, isNullable, null);
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x000BCC1F File Offset: 0x000BAE1F
		protected internal static global::System.Data.Entity.Spatial.DbGeometry SetValidValue(global::System.Data.Entity.Spatial.DbGeometry value, bool isNullable, string propertyName)
		{
			if (value == null && !isNullable)
			{
				global::System.Data.Entity.Core.EntityUtil.ThrowPropertyIsNotNullable(propertyName);
			}
			return value;
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x000BCC2E File Offset: 0x000BAE2E
		protected internal static global::System.Data.Entity.Spatial.DbGeometry SetValidValue(global::System.Data.Entity.Spatial.DbGeometry value, bool isNullable)
		{
			return global::System.Data.Entity.Core.Objects.DataClasses.StructuralObject.SetValidValue(value, isNullable, null);
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x000BCC38 File Offset: 0x000BAE38
		protected internal T SetValidValue<T>(T oldValue, T newValue, string property) where T : global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject
		{
			if (newValue == null && this.IsChangeTracked)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ComplexObject_NullableComplexTypesNotSupported(property));
			}
			if (oldValue != null)
			{
				oldValue.DetachFromParent();
			}
			if (newValue != null)
			{
				newValue.AttachToParent(this, property);
			}
			return newValue;
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x000BCC8A File Offset: 0x000BAE8A
		protected internal static TComplex VerifyComplexObjectIsNotNull<TComplex>(TComplex complexObject, string propertyName) where TComplex : global::System.Data.Entity.Core.Objects.DataClasses.ComplexObject
		{
			if (complexObject == null)
			{
				global::System.Data.Entity.Core.EntityUtil.ThrowPropertyIsNotNullable(propertyName);
			}
			return complexObject;
		}

		// Token: 0x04001311 RID: 4881
		public const string EntityKeyPropertyName = "-EntityKey-";
	}
}
