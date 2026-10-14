using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.Update.Internal
{
	// Token: 0x020005D2 RID: 1490
	internal class TableChangeProcessor
	{
		// Token: 0x060047EF RID: 18415 RVA: 0x000FE06E File Offset: 0x000FC26E
		internal TableChangeProcessor(global::System.Data.Entity.Core.Metadata.Edm.EntitySet table)
		{
			this.m_table = table;
			this.m_keyOrdinals = global::System.Data.Entity.Core.Mapping.Update.Internal.TableChangeProcessor.InitializeKeyOrdinals(table);
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x000FE089 File Offset: 0x000FC289
		protected TableChangeProcessor()
		{
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x000FE091 File Offset: 0x000FC291
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet Table
		{
			get
			{
				return this.m_table;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x060047F2 RID: 18418 RVA: 0x000FE099 File Offset: 0x000FC299
		internal int[] KeyOrdinals
		{
			get
			{
				return this.m_keyOrdinals;
			}
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x000FE0A4 File Offset: 0x000FC2A4
		internal bool IsKeyProperty(int propertyOrdinal)
		{
			foreach (int num in this.m_keyOrdinals)
			{
				if (propertyOrdinal == num)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x000FE0D4 File Offset: 0x000FC2D4
		private static int[] InitializeKeyOrdinals(global::System.Data.Entity.Core.Metadata.Edm.EntitySet table)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType elementType = table.ElementType;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = elementType.KeyMembers;
			global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(elementType);
			int[] array = new int[keyMembers.Count];
			for (int i = 0; i < keyMembers.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember item = keyMembers[i];
				array[i] = allStructuralMembers.IndexOf(item);
			}
			return array;
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x000FE128 File Offset: 0x000FC328
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> CompileCommands(global::System.Data.Entity.Core.Mapping.Update.Internal.ChangeNode changeNode, global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler compiler)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey>(compiler.m_translator.KeyComparer);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> dictionary = this.ProcessKeys(compiler, changeNode.Deleted, set);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> dictionary2 = this.ProcessKeys(compiler, changeNode.Inserted, set);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand>(dictionary.Count + dictionary2.Count);
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey key in set)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult;
				bool flag = dictionary.TryGetValue(key, out propagatorResult);
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2;
				bool flag2 = dictionary2.TryGetValue(key, out propagatorResult2);
				try
				{
					if (!flag)
					{
						list.Add(compiler.BuildInsertCommand(propagatorResult2, this));
					}
					else if (!flag2)
					{
						list.Add(compiler.BuildDeleteCommand(propagatorResult, this));
					}
					else
					{
						global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCommand updateCommand = compiler.BuildUpdateCommand(propagatorResult, propagatorResult2, this);
						if (updateCommand != null)
						{
							list.Add(updateCommand);
						}
					}
				}
				catch (global::System.Exception ex)
				{
					if (ex.RequiresContext())
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry>();
						if (propagatorResult != null)
						{
							list2.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(propagatorResult, compiler.m_translator, this.m_table));
						}
						if (propagatorResult2 != null)
						{
							list2.AddRange(global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(propagatorResult2, compiler.m_translator, this.m_table));
						}
						throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_GeneralExecutionException, ex, list2.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
					}
					throw;
				}
			}
			return list;
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x000FE28C File Offset: 0x000FC48C
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> ProcessKeys(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler compiler, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> changes, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey> keys)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult>(compiler.m_translator.KeyComparer);
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult in changes)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2 = propagatorResult;
				global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey compositeKey = new global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey(this.GetKeyConstants(propagatorResult2));
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult other;
				if (dictionary.TryGetValue(compositeKey, out other))
				{
					this.DiagnoseKeyCollision(compiler, propagatorResult, compositeKey, other);
				}
				dictionary.Add(compositeKey, propagatorResult2);
				keys.Add(compositeKey);
			}
			return dictionary;
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x000FE320 File Offset: 0x000FC520
		private void DiagnoseKeyCollision(global::System.Data.Entity.Core.Mapping.Update.Internal.UpdateCompiler compiler, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult change, global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey key, global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult other)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.KeyManager keyManager = compiler.m_translator.KeyManager;
			global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey compositeKey = new global::System.Data.Entity.Core.Mapping.Update.Internal.CompositeKey(this.GetKeyConstants(other));
			bool flag = true;
			int num = 0;
			while (flag && num < key.KeyComponents.Length)
			{
				int identifier = key.KeyComponents[num].Identifier;
				int identifier2 = compositeKey.KeyComponents[num].Identifier;
				if (!keyManager.GetPrincipals(identifier).Intersect(keyManager.GetPrincipals(identifier2)).Any<int>())
				{
					flag = false;
				}
				num++;
			}
			if (flag)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> source = global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(change, compiler.m_translator, this.m_table).Concat(global::System.Data.Entity.Core.Mapping.Update.Internal.SourceInterpreter.GetAllStateEntries(other, compiler.m_translator, this.m_table));
				throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_DuplicateKeys, null, source.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
			}
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry> hashSet = null;
			foreach (global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult in key.KeyComponents.Concat(compositeKey.KeyComponents))
			{
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry> hashSet2 = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry>();
				foreach (int identifier3 in keyManager.GetDependents(propagatorResult.Identifier))
				{
					global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult propagatorResult2;
					if (keyManager.TryGetIdentifierOwner(identifier3, out propagatorResult2) && propagatorResult2.StateEntry != null)
					{
						hashSet2.Add(propagatorResult2.StateEntry);
					}
				}
				if (hashSet == null)
				{
					hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.IEntityStateEntry>(hashSet2);
				}
				else
				{
					hashSet.IntersectWith(hashSet2);
				}
			}
			throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_GeneralExecutionException, new global::System.Data.ConstraintException(global::System.Data.Entity.Resources.Strings.Update_ReferentialConstraintIntegrityViolation), hashSet.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x000FE4DC File Offset: 0x000FC6DC
		private global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] GetKeyConstants(global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult row)
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[] array = new global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult[this.m_keyOrdinals.Length];
			for (int i = 0; i < this.m_keyOrdinals.Length; i++)
			{
				global::System.Data.Entity.Core.Mapping.Update.Internal.PropagatorResult memberValue = row.GetMemberValue(this.m_keyOrdinals[i]);
				array[i] = memberValue;
			}
			return array;
		}

		// Token: 0x04001993 RID: 6547
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_table;

		// Token: 0x04001994 RID: 6548
		private readonly int[] m_keyOrdinals;
	}
}
