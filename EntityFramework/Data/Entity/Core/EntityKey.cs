using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D0 RID: 720
	[global::System.Diagnostics.DebuggerDisplay("{ConcatKeyValue()}")]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public sealed class EntityKey : global::System.IEquatable<global::System.Data.Entity.Core.EntityKey>
	{
		// Token: 0x060022BA RID: 8890 RVA: 0x0006111E File Offset: 0x0005F31E
		public EntityKey()
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00061126 File Offset: 0x0005F326
		public EntityKey(string qualifiedEntitySetName, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> entityKeyValues)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(qualifiedEntitySetName, "qualifiedEntitySetName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(entityKeyValues, "entityKeyValues");
			this.InitializeEntitySetName(qualifiedEntitySetName);
			this.InitializeKeyValues(entityKeyValues, false, false);
			this._isLocked = true;
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0006115E File Offset: 0x0005F35E
		public EntityKey(string qualifiedEntitySetName, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.EntityKeyMember> entityKeyValues)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(qualifiedEntitySetName, "qualifiedEntitySetName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.EntityKeyMember>>(entityKeyValues, "entityKeyValues");
			this.InitializeEntitySetName(qualifiedEntitySetName);
			this.InitializeKeyValues(new global::System.Data.Entity.Core.EntityKey.KeyValueReader(entityKeyValues), false, false);
			this._isLocked = true;
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0006119C File Offset: 0x0005F39C
		public EntityKey(string qualifiedEntitySetName, string keyName, object keyValue)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(qualifiedEntitySetName, "qualifiedEntitySetName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(keyName, "keyName");
			global::System.Data.Entity.Utilities.Check.NotNull<object>(keyValue, "keyValue");
			this.InitializeEntitySetName(qualifiedEntitySetName);
			global::System.Data.Entity.Core.EntityKey.ValidateName(keyName);
			this._keyNames = new string[]
			{
				keyName
			};
			this._singletonKeyValue = keyValue;
			this._isLocked = true;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000611FE File Offset: 0x0005F3FE
		internal EntityKey(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.IExtendedDataRecord record)
		{
			this._entitySetName = entitySet.Name;
			this._entityContainerName = entitySet.EntityContainer.Name;
			this.InitializeKeyValues(entitySet, record);
			this._isLocked = true;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00061232 File Offset: 0x0005F432
		internal EntityKey(string qualifiedEntitySetName)
		{
			this.InitializeEntitySetName(qualifiedEntitySetName);
			this._isLocked = true;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00061248 File Offset: 0x0005F448
		internal EntityKey(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			this._entitySetName = entitySet.Name;
			this._entityContainerName = entitySet.EntityContainer.Name;
			this._isLocked = true;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00061274 File Offset: 0x0005F474
		internal EntityKey(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, object singletonKeyValue)
		{
			this._singletonKeyValue = singletonKeyValue;
			this._entitySetName = entitySet.Name;
			this._entityContainerName = entitySet.EntityContainer.Name;
			this._keyNames = entitySet.ElementType.KeyMemberNames;
			this._isLocked = true;
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000612C4 File Offset: 0x0005F4C4
		internal EntityKey(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, object[] compositeKeyValues)
		{
			this._compositeKeyValues = compositeKeyValues;
			this._entitySetName = entitySet.Name;
			this._entityContainerName = entitySet.EntityContainer.Name;
			this._keyNames = entitySet.ElementType.KeyMemberNames;
			this._isLocked = true;
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00061313 File Offset: 0x0005F513
		public static global::System.Data.Entity.Core.EntityKey NoEntitySetKey
		{
			get
			{
				return global::System.Data.Entity.Core.EntityKey._noEntitySetKey;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x0006131A File Offset: 0x0005F51A
		public static global::System.Data.Entity.Core.EntityKey EntityNotValidKey
		{
			get
			{
				return global::System.Data.Entity.Core.EntityKey._entityNotValidKey;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00061321 File Offset: 0x0005F521
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00061329 File Offset: 0x0005F529
		[global::System.Runtime.Serialization.DataMember]
		public string EntitySetName
		{
			get
			{
				return this._entitySetName;
			}
			set
			{
				this.ValidateWritable(this._entitySetName);
				this._entitySetName = global::System.Data.Entity.Core.EntityKey.LookupSingletonName(value);
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x00061343 File Offset: 0x0005F543
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x0006134B File Offset: 0x0005F54B
		[global::System.Runtime.Serialization.DataMember]
		public string EntityContainerName
		{
			get
			{
				return this._entityContainerName;
			}
			set
			{
				this.ValidateWritable(this._entityContainerName);
				this._entityContainerName = global::System.Data.Entity.Core.EntityKey.LookupSingletonName(value);
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x00061368 File Offset: 0x0005F568
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x000613E0 File Offset: 0x0005F5E0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Data.Entity.Core.EntityKeyMember[] EntityKeyValues
		{
			get
			{
				if (!this.IsTemporary)
				{
					global::System.Data.Entity.Core.EntityKeyMember[] array;
					if (this._singletonKeyValue != null)
					{
						array = new global::System.Data.Entity.Core.EntityKeyMember[]
						{
							new global::System.Data.Entity.Core.EntityKeyMember(this._keyNames[0], this._singletonKeyValue)
						};
					}
					else
					{
						array = new global::System.Data.Entity.Core.EntityKeyMember[this._compositeKeyValues.Length];
						for (int i = 0; i < this._compositeKeyValues.Length; i++)
						{
							array[i] = new global::System.Data.Entity.Core.EntityKeyMember(this._keyNames[i], this._compositeKeyValues[i]);
						}
					}
					return array;
				}
				return null;
			}
			set
			{
				this.ValidateWritable(this._keyNames);
				if (value != null && !this.InitializeKeyValues(new global::System.Data.Entity.Core.EntityKey.KeyValueReader(value), true, true))
				{
					this._deserializedMembers = value;
				}
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x00061408 File Offset: 0x0005F608
		public bool IsTemporary
		{
			get
			{
				return this.SingletonKeyValue == null && this.CompositeKeyValues == null;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x0006141D File Offset: 0x0005F61D
		private object SingletonKeyValue
		{
			get
			{
				if (this.RequiresDeserialization)
				{
					this.DeserializeMembers();
				}
				return this._singletonKeyValue;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x00061433 File Offset: 0x0005F633
		private object[] CompositeKeyValues
		{
			get
			{
				if (this.RequiresDeserialization)
				{
					this.DeserializeMembers();
				}
				return this._compositeKeyValues;
			}
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0006144C File Offset: 0x0005F64C
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySet(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace>(metadataWorkspace, "metadataWorkspace");
			if (string.IsNullOrEmpty(this._entityContainerName) || string.IsNullOrEmpty(this._entitySetName))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_MissingEntitySetName);
			}
			return metadataWorkspace.GetEntityContainer(this._entityContainerName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace).GetEntitySetByName(this._entitySetName, false);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000614A3 File Offset: 0x0005F6A3
		public override bool Equals(object obj)
		{
			return global::System.Data.Entity.Core.EntityKey.InternalEquals(this, obj as global::System.Data.Entity.Core.EntityKey, true);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x000614B2 File Offset: 0x0005F6B2
		public bool Equals(global::System.Data.Entity.Core.EntityKey other)
		{
			return global::System.Data.Entity.Core.EntityKey.InternalEquals(this, other, true);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x000614BC File Offset: 0x0005F6BC
		public override int GetHashCode()
		{
			int num = this._hashCode;
			if (num == 0)
			{
				this._containsByteArray = false;
				if (this.RequiresDeserialization)
				{
					this.DeserializeMembers();
				}
				if (this._entitySetName != null)
				{
					num = this._entitySetName.GetHashCode();
				}
				if (this._entityContainerName != null)
				{
					num ^= this._entityContainerName.GetHashCode();
				}
				if (this._singletonKeyValue != null)
				{
					num = this.AddHashValue(num, this._singletonKeyValue);
				}
				else if (this._compositeKeyValues != null)
				{
					int i = 0;
					int num2 = this._compositeKeyValues.Length;
					while (i < num2)
					{
						num = this.AddHashValue(num, this._compositeKeyValues[i]);
						i++;
					}
				}
				else
				{
					num = base.GetHashCode();
				}
				if (this._isLocked || (!string.IsNullOrEmpty(this._entitySetName) && !string.IsNullOrEmpty(this._entityContainerName) && (this._singletonKeyValue != null || this._compositeKeyValues != null)))
				{
					this._hashCode = num;
				}
			}
			return num;
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x000615A0 File Offset: 0x0005F7A0
		private int AddHashValue(int hashCode, object keyValue)
		{
			byte[] array = keyValue as byte[];
			if (array != null)
			{
				hashCode ^= global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.ComputeBinaryHashCode(array);
				this._containsByteArray = true;
				return hashCode;
			}
			return hashCode ^ keyValue.GetHashCode();
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x000615D2 File Offset: 0x0005F7D2
		public static bool operator ==(global::System.Data.Entity.Core.EntityKey key1, global::System.Data.Entity.Core.EntityKey key2)
		{
			return global::System.Data.Entity.Core.EntityKey.InternalEquals(key1, key2, true);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000615DC File Offset: 0x0005F7DC
		public static bool operator !=(global::System.Data.Entity.Core.EntityKey key1, global::System.Data.Entity.Core.EntityKey key2)
		{
			return !global::System.Data.Entity.Core.EntityKey.InternalEquals(key1, key2, true);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x000615EC File Offset: 0x0005F7EC
		internal static bool InternalEquals(global::System.Data.Entity.Core.EntityKey key1, global::System.Data.Entity.Core.EntityKey key2, bool compareEntitySets)
		{
			if (key1 == key2)
			{
				return true;
			}
			if (key1 == null || key2 == null)
			{
				return false;
			}
			if (global::System.Data.Entity.Core.EntityKey.NoEntitySetKey == key1 || global::System.Data.Entity.Core.EntityKey.EntityNotValidKey == key1 || global::System.Data.Entity.Core.EntityKey.NoEntitySetKey == key2 || global::System.Data.Entity.Core.EntityKey.EntityNotValidKey == key2)
			{
				return false;
			}
			if ((key1.GetHashCode() != key2.GetHashCode() && compareEntitySets) || key1._containsByteArray != key2._containsByteArray)
			{
				return false;
			}
			if (key1._singletonKeyValue != null)
			{
				if (key1._containsByteArray)
				{
					if (key2._singletonKeyValue == null)
					{
						return false;
					}
					if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.CompareBinaryValues((byte[])key1._singletonKeyValue, (byte[])key2._singletonKeyValue))
					{
						return false;
					}
				}
				else if (!key1._singletonKeyValue.Equals(key2._singletonKeyValue))
				{
					return false;
				}
				if (!string.Equals(key1._keyNames[0], key2._keyNames[0]))
				{
					return false;
				}
			}
			else
			{
				if (key1._compositeKeyValues == null || key2._compositeKeyValues == null || key1._compositeKeyValues.Length != key2._compositeKeyValues.Length)
				{
					return false;
				}
				if (key1._containsByteArray)
				{
					if (!global::System.Data.Entity.Core.EntityKey.CompositeValuesWithBinaryEqual(key1, key2))
					{
						return false;
					}
				}
				else if (!global::System.Data.Entity.Core.EntityKey.CompositeValuesEqual(key1, key2))
				{
					return false;
				}
			}
			return !compareEntitySets || (string.Equals(key1._entitySetName, key2._entitySetName) && string.Equals(key1._entityContainerName, key2._entityContainerName));
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00061724 File Offset: 0x0005F924
		internal static bool CompositeValuesWithBinaryEqual(global::System.Data.Entity.Core.EntityKey key1, global::System.Data.Entity.Core.EntityKey key2)
		{
			for (int i = 0; i < key1._compositeKeyValues.Length; i++)
			{
				if (key1._keyNames[i].Equals(key2._keyNames[i]))
				{
					if (!global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(key1._compositeKeyValues[i], key2._compositeKeyValues[i]))
					{
						return false;
					}
				}
				else if (!global::System.Data.Entity.Core.EntityKey.ValuesWithBinaryEqual(key1._keyNames[i], key1._compositeKeyValues[i], key2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00061794 File Offset: 0x0005F994
		private static bool ValuesWithBinaryEqual(string keyName, object keyValue, global::System.Data.Entity.Core.EntityKey key2)
		{
			for (int i = 0; i < key2._keyNames.Length; i++)
			{
				if (string.Equals(keyName, key2._keyNames[i]))
				{
					return global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals(keyValue, key2._compositeKeyValues[i]);
				}
			}
			return false;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x000617DC File Offset: 0x0005F9DC
		private static bool CompositeValuesEqual(global::System.Data.Entity.Core.EntityKey key1, global::System.Data.Entity.Core.EntityKey key2)
		{
			for (int i = 0; i < key1._compositeKeyValues.Length; i++)
			{
				if (key1._keyNames[i].Equals(key2._keyNames[i]))
				{
					if (!object.Equals(key1._compositeKeyValues[i], key2._compositeKeyValues[i]))
					{
						return false;
					}
				}
				else if (!global::System.Data.Entity.Core.EntityKey.ValuesEqual(key1._keyNames[i], key1._compositeKeyValues[i], key2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00061848 File Offset: 0x0005FA48
		private static bool ValuesEqual(string keyName, object keyValue, global::System.Data.Entity.Core.EntityKey key2)
		{
			for (int i = 0; i < key2._keyNames.Length; i++)
			{
				if (string.Equals(keyName, key2._keyNames[i]))
				{
					return object.Equals(keyValue, key2._compositeKeyValues[i]);
				}
			}
			return false;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00061888 File Offset: 0x0005FA88
		internal global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>[] GetKeyValueExpressions(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			int num = 0;
			if (!this.IsTemporary)
			{
				if (this._singletonKeyValue != null)
				{
					num = 1;
				}
				else
				{
					num = this._compositeKeyValues.Length;
				}
			}
			if (entitySet.ElementType.KeyMembers.Count != num)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_EntitySetDoesNotMatch(global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(entitySet.EntityContainer.Name, entitySet.Name)), "entitySet");
			}
			global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>[] array;
			if (this._singletonKeyValue != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = entitySet.ElementType.KeyMembers[0];
				array = new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>[]
				{
					global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember).Constant(this._singletonKeyValue).As(edmMember.Name)
				};
			}
			else
			{
				array = new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>[this._compositeKeyValues.Length];
				for (int i = 0; i < this._compositeKeyValues.Length; i++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2 = entitySet.ElementType.KeyMembers[i];
					array[i] = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember2).Constant(this._compositeKeyValues[i]).As(edmMember2.Name);
				}
			}
			return array;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00061990 File Offset: 0x0005FB90
		internal string ConcatKeyValue()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("EntitySet=").Append(this._entitySetName);
			if (!this.IsTemporary)
			{
				foreach (global::System.Data.Entity.Core.EntityKeyMember entityKeyMember in this.EntityKeyValues)
				{
					stringBuilder.Append(';');
					stringBuilder.Append(entityKeyMember.Key).Append("=").Append(entityKeyMember.Value);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00061A0C File Offset: 0x0005FC0C
		internal object FindValueByName(string keyName)
		{
			if (this.SingletonKeyValue != null)
			{
				return this._singletonKeyValue;
			}
			object[] compositeKeyValues = this.CompositeKeyValues;
			for (int i = 0; i < compositeKeyValues.Length; i++)
			{
				if (keyName == this._keyNames[i])
				{
					return compositeKeyValues[i];
				}
			}
			throw new global::System.ArgumentOutOfRangeException("keyName");
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00061A5C File Offset: 0x0005FC5C
		internal void InitializeEntitySetName(string qualifiedEntitySetName)
		{
			string[] array = qualifiedEntitySetName.Split(new char[]
			{
				'.'
			});
			if (array.Length != 2 || string.IsNullOrWhiteSpace(array[0]) || string.IsNullOrWhiteSpace(array[1]))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_InvalidQualifiedEntitySetName, "qualifiedEntitySetName");
			}
			this._entityContainerName = array[0];
			this._entitySetName = array[1];
			global::System.Data.Entity.Core.EntityKey.ValidateName(this._entityContainerName);
			global::System.Data.Entity.Core.EntityKey.ValidateName(this._entitySetName);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00061ACD File Offset: 0x0005FCCD
		private static void ValidateName(string name)
		{
			if (!name.IsValidUndottedName())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_InvalidName(name));
			}
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00061AE4 File Offset: 0x0005FCE4
		internal bool InitializeKeyValues(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> entityKeyValues, bool allowNullKeys = false, bool tokenizeStrings = false)
		{
			int num = entityKeyValues.Count<global::System.Collections.Generic.KeyValuePair<string, object>>();
			if (num == 1)
			{
				this._keyNames = new string[1];
				global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair = entityKeyValues.Single<global::System.Collections.Generic.KeyValuePair<string, object>>();
				this.InitializeKeyValue(keyValuePair, 0, tokenizeStrings);
				this._singletonKeyValue = keyValuePair.Value;
			}
			else
			{
				if (num > 1)
				{
					this._keyNames = new string[num];
					this._compositeKeyValues = new object[num];
					int num2 = 0;
					using (global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> enumerator = entityKeyValues.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair2 = enumerator.Current;
							this.InitializeKeyValue(keyValuePair2, num2, tokenizeStrings);
							this._compositeKeyValues[num2] = keyValuePair2.Value;
							num2++;
						}
						goto IL_A9;
					}
				}
				if (!allowNullKeys)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_EntityKeyMustHaveValues, "entityKeyValues");
				}
			}
			IL_A9:
			return num > 0;
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00061BB0 File Offset: 0x0005FDB0
		private void InitializeKeyValue(global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair, int i, bool tokenizeStrings)
		{
			if (global::System.Data.Entity.Core.EntityUtil.IsNull(keyValuePair.Value) || string.IsNullOrWhiteSpace(keyValuePair.Key))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_NoNullsAllowedInKeyValuePairs, "entityKeyValues");
			}
			global::System.Data.Entity.Core.EntityKey.ValidateName(keyValuePair.Key);
			this._keyNames[i] = (tokenizeStrings ? global::System.Data.Entity.Core.EntityKey.LookupSingletonName(keyValuePair.Key) : keyValuePair.Key);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00061C18 File Offset: 0x0005FE18
		private void InitializeKeyValues(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.IExtendedDataRecord record)
		{
			int count = entitySet.ElementType.KeyMembers.Count;
			this._keyNames = entitySet.ElementType.KeyMemberNames;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)record.DataRecordInfo.RecordType.EdmType;
			if (count == 1)
			{
				this._singletonKeyValue = record[entityType.KeyMembers[0].Name];
				if (global::System.Data.Entity.Core.EntityUtil.IsNull(this._singletonKeyValue))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_NoNullsAllowedInKeyValuePairs, "record");
				}
			}
			else
			{
				this._compositeKeyValues = new object[count];
				for (int i = 0; i < count; i++)
				{
					this._compositeKeyValues[i] = record[entityType.KeyMembers[i].Name];
					if (global::System.Data.Entity.Core.EntityUtil.IsNull(this._compositeKeyValues[i]))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_NoNullsAllowedInKeyValuePairs, "record");
					}
				}
			}
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00061CF1 File Offset: 0x0005FEF1
		internal void ValidateEntityKey(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			this.ValidateEntityKey(workspace, entitySet, false, null);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00061D00 File Offset: 0x0005FF00
		internal void ValidateEntityKey(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, bool isArgumentException, string argumentName)
		{
			if (entitySet != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = entitySet.ElementType.KeyMembers;
				if (this._singletonKeyValue != null)
				{
					if (keyMembers.Count != 1)
					{
						if (isArgumentException)
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_IncorrectNumberOfKeyValuePairs(entitySet.ElementType.FullName, keyMembers.Count, 1), argumentName);
						}
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_IncorrectNumberOfKeyValuePairs(entitySet.ElementType.FullName, keyMembers.Count, 1));
					}
					else
					{
						global::System.Data.Entity.Core.EntityKey.ValidateTypeOfKeyValue(workspace, keyMembers[0], this._singletonKeyValue, isArgumentException, argumentName);
						if (this._keyNames[0] != keyMembers[0].Name)
						{
							if (isArgumentException)
							{
								throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_MissingKeyValue(keyMembers[0].Name, entitySet.ElementType.FullName), argumentName);
							}
							throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_MissingKeyValue(keyMembers[0].Name, entitySet.ElementType.FullName));
						}
					}
				}
				else if (this._compositeKeyValues != null)
				{
					if (keyMembers.Count != this._compositeKeyValues.Length)
					{
						if (isArgumentException)
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_IncorrectNumberOfKeyValuePairs(entitySet.ElementType.FullName, keyMembers.Count, this._compositeKeyValues.Length), argumentName);
						}
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_IncorrectNumberOfKeyValuePairs(entitySet.ElementType.FullName, keyMembers.Count, this._compositeKeyValues.Length));
					}
					else
					{
						int i = 0;
						while (i < this._compositeKeyValues.Length)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = entitySet.ElementType.KeyMembers[i];
							bool flag = false;
							for (int j = 0; j < this._compositeKeyValues.Length; j++)
							{
								if (edmMember.Name == this._keyNames[j])
								{
									global::System.Data.Entity.Core.EntityKey.ValidateTypeOfKeyValue(workspace, edmMember, this._compositeKeyValues[j], isArgumentException, argumentName);
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								if (isArgumentException)
								{
									throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_MissingKeyValue(edmMember.Name, entitySet.ElementType.FullName), argumentName);
								}
								throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_MissingKeyValue(edmMember.Name, entitySet.ElementType.FullName));
							}
							else
							{
								i++;
							}
						}
					}
				}
			}
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00061F30 File Offset: 0x00060130
		private static void ValidateTypeOfKeyValue(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Metadata.Edm.EdmMember keyMember, object keyValue, bool isArgumentException, string argumentName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = keyMember.TypeUsage.EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType))
			{
				global::System.Type clrEquivalentType = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType).ClrEquivalentType;
				if (clrEquivalentType != keyValue.GetType())
				{
					if (isArgumentException)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_IncorrectValueType(keyMember.Name, clrEquivalentType.FullName, keyValue.GetType().FullName), argumentName);
					}
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_IncorrectValueType(keyMember.Name, clrEquivalentType.FullName, keyValue.GetType().FullName));
				}
			}
			else if (workspace.TryGetObjectSpaceType((global::System.Data.Entity.Core.Metadata.Edm.EnumType)edmType, out enumType))
			{
				global::System.Type clrType = enumType.ClrType;
				if (clrType != keyValue.GetType())
				{
					if (isArgumentException)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_IncorrectValueType(keyMember.Name, clrType.FullName, keyValue.GetType().FullName), argumentName);
					}
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_IncorrectValueType(keyMember.Name, clrType.FullName, keyValue.GetType().FullName));
				}
			}
			else
			{
				if (isArgumentException)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityKey_NoCorrespondingOSpaceTypeForEnumKeyMember(keyMember.Name, edmType.FullName), argumentName);
				}
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_NoCorrespondingOSpaceTypeForEnumKeyMember(keyMember.Name, edmType.FullName));
			}
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00062058 File Offset: 0x00060258
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void AssertCorrectState(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase, bool isTemporary)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entitySetBase;
			if (this._singletonKeyValue != null)
			{
				return;
			}
			if (this._compositeKeyValues != null)
			{
				for (int i = 0; i < this._compositeKeyValues.Length; i++)
				{
				}
				return;
			}
			bool isTemporary2 = this.IsTemporary;
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0006209C File Offset: 0x0006029C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Runtime.Serialization.OnDeserializing]
		public void OnDeserializing(global::System.Runtime.Serialization.StreamingContext context)
		{
			if (this.RequiresDeserialization)
			{
				this.DeserializeMembers();
			}
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x000620AC File Offset: 0x000602AC
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public void OnDeserialized(global::System.Runtime.Serialization.StreamingContext context)
		{
			this._entitySetName = global::System.Data.Entity.Core.EntityKey.LookupSingletonName(this._entitySetName);
			this._entityContainerName = global::System.Data.Entity.Core.EntityKey.LookupSingletonName(this._entityContainerName);
			if (this._keyNames != null)
			{
				for (int i = 0; i < this._keyNames.Length; i++)
				{
					this._keyNames[i] = global::System.Data.Entity.Core.EntityKey.LookupSingletonName(this._keyNames[i]);
				}
			}
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x0006210B File Offset: 0x0006030B
		internal static string LookupSingletonName(string name)
		{
			if (!string.IsNullOrEmpty(name))
			{
				return global::System.Data.Entity.Core.EntityKey.NameLookup.GetOrAdd(name, (string n) => n);
			}
			return null;
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00062141 File Offset: 0x00060341
		private void ValidateWritable(object instance)
		{
			if (this._isLocked || instance != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityKey_CannotChangeKey);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x00062159 File Offset: 0x00060359
		private bool RequiresDeserialization
		{
			get
			{
				return this._deserializedMembers != null;
			}
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00062164 File Offset: 0x00060364
		private void DeserializeMembers()
		{
			if (this.InitializeKeyValues(new global::System.Data.Entity.Core.EntityKey.KeyValueReader(this._deserializedMembers), true, true))
			{
				this._deserializedMembers = null;
			}
		}

		// Token: 0x04000BF7 RID: 3063
		private string _entitySetName;

		// Token: 0x04000BF8 RID: 3064
		private string _entityContainerName;

		// Token: 0x04000BF9 RID: 3065
		private object _singletonKeyValue;

		// Token: 0x04000BFA RID: 3066
		private object[] _compositeKeyValues;

		// Token: 0x04000BFB RID: 3067
		private string[] _keyNames;

		// Token: 0x04000BFC RID: 3068
		private readonly bool _isLocked;

		// Token: 0x04000BFD RID: 3069
		[global::System.NonSerialized]
		private bool _containsByteArray;

		// Token: 0x04000BFE RID: 3070
		[global::System.NonSerialized]
		private global::System.Data.Entity.Core.EntityKeyMember[] _deserializedMembers;

		// Token: 0x04000BFF RID: 3071
		[global::System.NonSerialized]
		private int _hashCode;

		// Token: 0x04000C00 RID: 3072
		private static readonly global::System.Data.Entity.Core.EntityKey _noEntitySetKey = new global::System.Data.Entity.Core.EntityKey("NoEntitySetKey.NoEntitySetKey");

		// Token: 0x04000C01 RID: 3073
		private static readonly global::System.Data.Entity.Core.EntityKey _entityNotValidKey = new global::System.Data.Entity.Core.EntityKey("EntityNotValidKey.EntityNotValidKey");

		// Token: 0x04000C02 RID: 3074
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<string, string> NameLookup = new global::System.Collections.Concurrent.ConcurrentDictionary<string, string>();

		// Token: 0x020009B1 RID: 2481
		private class KeyValueReader : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x06005F3C RID: 24380 RVA: 0x00146C93 File Offset: 0x00144E93
			public KeyValueReader(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.EntityKeyMember> enumerator)
			{
				this._enumerator = enumerator;
			}

			// Token: 0x06005F3D RID: 24381 RVA: 0x00146CA2 File Offset: 0x00144EA2
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				foreach (global::System.Data.Entity.Core.EntityKeyMember entityKeyMember in this._enumerator)
				{
					if (entityKeyMember != null)
					{
						yield return new global::System.Collections.Generic.KeyValuePair<string, object>(entityKeyMember.Key, entityKeyMember.Value);
					}
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.EntityKeyMember> enumerator = null;
				yield break;
				yield break;
			}

			// Token: 0x06005F3E RID: 24382 RVA: 0x00146CB1 File Offset: 0x00144EB1
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040027F6 RID: 10230
			private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.EntityKeyMember> _enumerator;
		}
	}
}
