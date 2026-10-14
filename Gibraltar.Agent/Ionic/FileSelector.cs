using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace Ionic
{
	// Token: 0x02000422 RID: 1058
	internal class FileSelector
	{
		// Token: 0x06002DCE RID: 11726 RVA: 0x0009A10C File Offset: 0x0009830C
		public FileSelector(string selectionCriteria) : this(selectionCriteria, true)
		{
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x0009A118 File Offset: 0x00098318
		public FileSelector(string selectionCriteria, bool traverseDirectoryReparsePoints)
		{
			if (!string.IsNullOrEmpty(selectionCriteria))
			{
				this._Criterion = global::Ionic.FileSelector._ParseCriterion(selectionCriteria);
			}
			this.TraverseReparsePoints = traverseDirectoryReparsePoints;
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x0009A140 File Offset: 0x00098340
		// (set) Token: 0x06002DD1 RID: 11729 RVA: 0x0009A15C File Offset: 0x0009835C
		public string SelectionCriteria
		{
			get
			{
				if (this._Criterion == null)
				{
					return null;
				}
				return this._Criterion.ToString();
			}
			set
			{
				if (value == null)
				{
					this._Criterion = null;
					return;
				}
				if (value.Trim() == "")
				{
					this._Criterion = null;
					return;
				}
				this._Criterion = global::Ionic.FileSelector._ParseCriterion(value);
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x0009A198 File Offset: 0x00098398
		// (set) Token: 0x06002DD3 RID: 11731 RVA: 0x0009A1A0 File Offset: 0x000983A0
		public bool TraverseReparsePoints { get; set; }

		// Token: 0x06002DD4 RID: 11732 RVA: 0x0009A1AC File Offset: 0x000983AC
		private static string NormalizeCriteriaExpression(string source)
		{
			string[][] array = new string[][]
			{
				new string[]
				{
					"([^']*)\\(\\(([^']+)",
					"$1( ($2"
				},
				new string[]
				{
					"(.)\\)\\)",
					"$1) )"
				},
				new string[]
				{
					"\\((\\S)",
					"( $1"
				},
				new string[]
				{
					"(\\S)\\)",
					"$1 )"
				},
				new string[]
				{
					"^\\)",
					" )"
				},
				new string[]
				{
					"(\\S)\\(",
					"$1 ("
				},
				new string[]
				{
					"\\)(\\S)",
					") $1"
				},
				new string[]
				{
					"(=)('[^']*')",
					"$1 $2"
				},
				new string[]
				{
					"([^ !><])(>|<|!=|=)",
					"$1 $2"
				},
				new string[]
				{
					"(>|<|!=|=)([^ =])",
					"$1 $2"
				},
				new string[]
				{
					"/",
					"\\"
				}
			};
			string input = source;
			for (int i = 0; i < array.Length; i++)
			{
				string pattern = global::Ionic.FileSelector.RegexAssertions.PrecededByEvenNumberOfSingleQuotes + array[i][0] + global::Ionic.FileSelector.RegexAssertions.FollowedByEvenNumberOfSingleQuotesAndLineEnd;
				input = global::System.Text.RegularExpressions.Regex.Replace(input, pattern, array[i][1]);
			}
			string pattern2 = "/" + global::Ionic.FileSelector.RegexAssertions.FollowedByOddNumberOfSingleQuotesAndLineEnd;
			input = global::System.Text.RegularExpressions.Regex.Replace(input, pattern2, "\\");
			pattern2 = " " + global::Ionic.FileSelector.RegexAssertions.FollowedByOddNumberOfSingleQuotesAndLineEnd;
			return global::System.Text.RegularExpressions.Regex.Replace(input, pattern2, "\u0006");
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x0009A35C File Offset: 0x0009855C
		private static global::Ionic.SelectionCriterion _ParseCriterion(string s)
		{
			if (s == null)
			{
				return null;
			}
			s = global::Ionic.FileSelector.NormalizeCriteriaExpression(s);
			if (s.IndexOf(" ") == -1)
			{
				s = "name = " + s;
			}
			string[] array = s.Trim().Split(new char[]
			{
				' ',
				'\t'
			});
			if (array.Length < 3)
			{
				throw new global::System.ArgumentException(s);
			}
			global::Ionic.SelectionCriterion selectionCriterion = null;
			global::System.Collections.Generic.Stack<global::Ionic.FileSelector.ParseState> stack = new global::System.Collections.Generic.Stack<global::Ionic.FileSelector.ParseState>();
			global::System.Collections.Generic.Stack<global::Ionic.SelectionCriterion> stack2 = new global::System.Collections.Generic.Stack<global::Ionic.SelectionCriterion>();
			stack.Push(global::Ionic.FileSelector.ParseState.Start);
			int i = 0;
			while (i < array.Length)
			{
				string text = array[i].ToLower();
				uint num = global::Ionic.Zip.Reduced.<PrivateImplementationDetails>.ComputeStringHash(text);
				global::Ionic.FileSelector.ParseState parseState;
				if (num <= 1563699588U)
				{
					if (num <= 739023492U)
					{
						if (num <= 329706515U)
						{
							if (num != 254395046U)
							{
								if (num != 329706515U)
								{
									goto IL_993;
								}
								if (!(text == "ctime"))
								{
									goto IL_993;
								}
								goto IL_481;
							}
							else
							{
								if (!(text == "and"))
								{
									goto IL_993;
								}
								goto IL_330;
							}
						}
						else if (num != 597743964U)
						{
							if (num != 739023492U)
							{
								goto IL_993;
							}
							if (!(text == ")"))
							{
								goto IL_993;
							}
							parseState = stack.Pop();
							if (stack.Peek() != global::Ionic.FileSelector.ParseState.OpenParen)
							{
								throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							stack.Pop();
							stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
						}
						else
						{
							if (!(text == "size"))
							{
								goto IL_993;
							}
							goto IL_5C0;
						}
					}
					else if (num <= 1058081160U)
					{
						if (num != 755801111U)
						{
							if (num != 1058081160U)
							{
								goto IL_993;
							}
							if (!(text == "filename"))
							{
								goto IL_993;
							}
							goto IL_7D0;
						}
						else
						{
							if (!(text == "("))
							{
								goto IL_993;
							}
							parseState = stack.Peek();
							if (parseState != global::Ionic.FileSelector.ParseState.Start && parseState != global::Ionic.FileSelector.ParseState.ConjunctionPending && parseState != global::Ionic.FileSelector.ParseState.OpenParen)
							{
								throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							if (array.Length <= i + 4)
							{
								throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
							}
							stack.Push(global::Ionic.FileSelector.ParseState.OpenParen);
						}
					}
					else if (num != 1361572173U)
					{
						if (num != 1563699588U)
						{
							goto IL_993;
						}
						if (!(text == "or"))
						{
							goto IL_993;
						}
						goto IL_330;
					}
					else
					{
						if (!(text == "type"))
						{
							goto IL_993;
						}
						goto IL_8B6;
					}
				}
				else if (num <= 2746858573U)
				{
					if (num <= 2211460629U)
					{
						if (num != 2166136261U)
						{
							if (num != 2211460629U)
							{
								goto IL_993;
							}
							if (!(text == "length"))
							{
								goto IL_993;
							}
							goto IL_5C0;
						}
						else
						{
							if (text == null)
							{
								goto IL_993;
							}
							if (text.Length != 0)
							{
								goto IL_993;
							}
							stack.Push(global::Ionic.FileSelector.ParseState.Whitespace);
						}
					}
					else if (num != 2369371622U)
					{
						if (num != 2746858573U)
						{
							goto IL_993;
						}
						if (!(text == "atime"))
						{
							goto IL_993;
						}
						goto IL_481;
					}
					else
					{
						if (!(text == "name"))
						{
							goto IL_993;
						}
						goto IL_7D0;
					}
				}
				else if (num <= 3429620606U)
				{
					if (num != 2888110417U)
					{
						if (num != 3429620606U)
						{
							goto IL_993;
						}
						if (!(text == "xor"))
						{
							goto IL_993;
						}
						goto IL_330;
					}
					else
					{
						if (!(text == "mtime"))
						{
							goto IL_993;
						}
						goto IL_481;
					}
				}
				else if (num != 3791641492U)
				{
					if (num != 4191246291U)
					{
						goto IL_993;
					}
					if (!(text == "attrs"))
					{
						goto IL_993;
					}
					goto IL_8B6;
				}
				else
				{
					if (!(text == "attributes"))
					{
						goto IL_993;
					}
					goto IL_8B6;
				}
				IL_9B0:
				parseState = stack.Peek();
				if (parseState == global::Ionic.FileSelector.ParseState.CriterionDone)
				{
					stack.Pop();
					if (stack.Peek() == global::Ionic.FileSelector.ParseState.ConjunctionPending)
					{
						while (stack.Peek() == global::Ionic.FileSelector.ParseState.ConjunctionPending)
						{
							global::Ionic.CompoundCriterion compoundCriterion = stack2.Pop() as global::Ionic.CompoundCriterion;
							compoundCriterion.Right = selectionCriterion;
							selectionCriterion = compoundCriterion;
							stack.Pop();
							parseState = stack.Pop();
							if (parseState != global::Ionic.FileSelector.ParseState.CriterionDone)
							{
								throw new global::System.ArgumentException("??");
							}
						}
					}
					else
					{
						stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
					}
				}
				if (parseState == global::Ionic.FileSelector.ParseState.Whitespace)
				{
					stack.Pop();
				}
				i++;
				continue;
				IL_330:
				parseState = stack.Peek();
				if (parseState != global::Ionic.FileSelector.ParseState.CriterionDone)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				if (array.Length <= i + 3)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::Ionic.LogicalConjunction conjunction = (global::Ionic.LogicalConjunction)global::System.Enum.Parse(typeof(global::Ionic.LogicalConjunction), array[i].ToUpper(), true);
				selectionCriterion = new global::Ionic.CompoundCriterion
				{
					Left = selectionCriterion,
					Right = null,
					Conjunction = conjunction
				};
				stack.Push(parseState);
				stack.Push(global::Ionic.FileSelector.ParseState.ConjunctionPending);
				stack2.Push(selectionCriterion);
				goto IL_9B0;
				IL_481:
				if (array.Length <= i + 2)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::System.DateTime dateTime;
				try
				{
					dateTime = global::System.DateTime.ParseExact(array[i + 2], "yyyy-MM-dd-HH:mm:ss", null);
				}
				catch (global::System.FormatException)
				{
					try
					{
						dateTime = global::System.DateTime.ParseExact(array[i + 2], "yyyy/MM/dd-HH:mm:ss", null);
					}
					catch (global::System.FormatException)
					{
						try
						{
							dateTime = global::System.DateTime.ParseExact(array[i + 2], "yyyy/MM/dd", null);
						}
						catch (global::System.FormatException)
						{
							try
							{
								dateTime = global::System.DateTime.ParseExact(array[i + 2], "MM/dd/yyyy", null);
							}
							catch (global::System.FormatException)
							{
								dateTime = global::System.DateTime.ParseExact(array[i + 2], "yyyy-MM-dd", null);
							}
						}
					}
				}
				dateTime = global::System.DateTime.SpecifyKind(dateTime, global::System.DateTimeKind.Local).ToUniversalTime();
				selectionCriterion = new global::Ionic.TimeCriterion
				{
					Which = (global::Ionic.WhichTime)global::System.Enum.Parse(typeof(global::Ionic.WhichTime), array[i], true),
					Operator = (global::Ionic.ComparisonOperator)global::Ionic.EnumUtil.Parse(typeof(global::Ionic.ComparisonOperator), array[i + 1]),
					Time = dateTime
				};
				i += 2;
				stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
				goto IL_9B0;
				IL_5C0:
				if (array.Length <= i + 2)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				string text2 = array[i + 2];
				long size;
				if (text2.ToUpper().EndsWith("K"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L;
				}
				else if (text2.ToUpper().EndsWith("KB"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L;
				}
				else if (text2.ToUpper().EndsWith("M"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L * 1024L;
				}
				else if (text2.ToUpper().EndsWith("MB"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L * 1024L;
				}
				else if (text2.ToUpper().EndsWith("G"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 1)) * 1024L * 1024L * 1024L;
				}
				else if (text2.ToUpper().EndsWith("GB"))
				{
					size = long.Parse(text2.Substring(0, text2.Length - 2)) * 1024L * 1024L * 1024L;
				}
				else
				{
					size = long.Parse(array[i + 2]);
				}
				selectionCriterion = new global::Ionic.SizeCriterion
				{
					Size = size,
					Operator = (global::Ionic.ComparisonOperator)global::Ionic.EnumUtil.Parse(typeof(global::Ionic.ComparisonOperator), array[i + 1])
				};
				i += 2;
				stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
				goto IL_9B0;
				IL_7D0:
				if (array.Length <= i + 2)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::Ionic.ComparisonOperator comparisonOperator = (global::Ionic.ComparisonOperator)global::Ionic.EnumUtil.Parse(typeof(global::Ionic.ComparisonOperator), array[i + 1]);
				if (comparisonOperator != global::Ionic.ComparisonOperator.NotEqualTo && comparisonOperator != global::Ionic.ComparisonOperator.EqualTo)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				string text3 = array[i + 2];
				if (text3.StartsWith("'") && text3.EndsWith("'"))
				{
					text3 = text3.Substring(1, text3.Length - 2).Replace("\u0006", " ");
				}
				selectionCriterion = new global::Ionic.NameCriterion
				{
					MatchingFileSpec = text3,
					Operator = comparisonOperator
				};
				i += 2;
				stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
				goto IL_9B0;
				IL_8B6:
				if (array.Length <= i + 2)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::Ionic.ComparisonOperator comparisonOperator2 = (global::Ionic.ComparisonOperator)global::Ionic.EnumUtil.Parse(typeof(global::Ionic.ComparisonOperator), array[i + 1]);
				if (comparisonOperator2 != global::Ionic.ComparisonOperator.NotEqualTo && comparisonOperator2 != global::Ionic.ComparisonOperator.EqualTo)
				{
					throw new global::System.ArgumentException(string.Join(" ", array, i, array.Length - i));
				}
				global::Ionic.SelectionCriterion selectionCriterion2;
				if (!(text == "type"))
				{
					global::Ionic.AttributesCriterion attributesCriterion = new global::Ionic.AttributesCriterion();
					attributesCriterion.AttributeString = array[i + 2];
					selectionCriterion2 = attributesCriterion;
					attributesCriterion.Operator = comparisonOperator2;
				}
				else
				{
					global::Ionic.TypeCriterion typeCriterion = new global::Ionic.TypeCriterion();
					typeCriterion.AttributeString = array[i + 2];
					selectionCriterion2 = typeCriterion;
					typeCriterion.Operator = comparisonOperator2;
				}
				selectionCriterion = selectionCriterion2;
				i += 2;
				stack.Push(global::Ionic.FileSelector.ParseState.CriterionDone);
				goto IL_9B0;
				IL_993:
				throw new global::System.ArgumentException("'" + array[i] + "'");
			}
			return selectionCriterion;
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x0009ADE0 File Offset: 0x00098FE0
		public override string ToString()
		{
			return "FileSelector(" + this._Criterion.ToString() + ")";
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x0009ADFC File Offset: 0x00098FFC
		private bool Evaluate(string filename)
		{
			return this._Criterion.Evaluate(filename);
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x0009AE0C File Offset: 0x0009900C
		[global::System.Diagnostics.Conditional("SelectorTrace")]
		private void SelectorTrace(string format, params object[] args)
		{
			if (this._Criterion != null && this._Criterion.Verbose)
			{
				global::System.Console.WriteLine(format, args);
			}
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x0009AE30 File Offset: 0x00099030
		public global::System.Collections.Generic.ICollection<string> SelectFiles(string directory)
		{
			return this.SelectFiles(directory, false);
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x0009AE3C File Offset: 0x0009903C
		public global::System.Collections.ObjectModel.ReadOnlyCollection<string> SelectFiles(string directory, bool recurseDirectories)
		{
			if (this._Criterion == null)
			{
				throw new global::System.ArgumentException("SelectionCriteria has not been set");
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			try
			{
				if (global::System.IO.Directory.Exists(directory))
				{
					foreach (string text in global::System.IO.Directory.GetFiles(directory))
					{
						if (this.Evaluate(text))
						{
							list.Add(text);
						}
					}
					if (recurseDirectories)
					{
						foreach (string text2 in global::System.IO.Directory.GetDirectories(directory))
						{
							if (this.TraverseReparsePoints || (global::System.IO.File.GetAttributes(text2) & global::System.IO.FileAttributes.ReparsePoint) == (global::System.IO.FileAttributes)0)
							{
								if (this.Evaluate(text2))
								{
									list.Add(text2);
								}
								list.AddRange(this.SelectFiles(text2, recurseDirectories));
							}
						}
					}
				}
			}
			catch (global::System.UnauthorizedAccessException)
			{
			}
			catch (global::System.IO.IOException)
			{
			}
			return list.AsReadOnly();
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x0009AF40 File Offset: 0x00099140
		private bool Evaluate(global::Ionic.Zip.ZipEntry entry)
		{
			return this._Criterion.Evaluate(entry);
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x0009AF50 File Offset: 0x00099150
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> SelectEntries(global::Ionic.Zip.ZipFile zip)
		{
			if (zip == null)
			{
				throw new global::System.ArgumentNullException("zip");
			}
			global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> list = new global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry>();
			foreach (global::Ionic.Zip.ZipEntry zipEntry in zip)
			{
				if (this.Evaluate(zipEntry))
				{
					list.Add(zipEntry);
				}
			}
			return list;
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x0009AFC8 File Offset: 0x000991C8
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> SelectEntries(global::Ionic.Zip.ZipFile zip, string directoryPathInArchive)
		{
			if (zip == null)
			{
				throw new global::System.ArgumentNullException("zip");
			}
			global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> list = new global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry>();
			string text = (directoryPathInArchive == null) ? null : directoryPathInArchive.Replace("/", "\\");
			if (text != null)
			{
				while (text.EndsWith("\\"))
				{
					text = text.Substring(0, text.Length - 1);
				}
			}
			foreach (global::Ionic.Zip.ZipEntry zipEntry in zip)
			{
				if ((directoryPathInArchive == null || global::System.IO.Path.GetDirectoryName(zipEntry.FileName) == directoryPathInArchive || global::System.IO.Path.GetDirectoryName(zipEntry.FileName) == text) && this.Evaluate(zipEntry))
				{
					list.Add(zipEntry);
				}
			}
			return list;
		}

		// Token: 0x04000F8D RID: 3981
		internal global::Ionic.SelectionCriterion _Criterion;

		// Token: 0x020004D9 RID: 1241
		private enum ParseState
		{
			// Token: 0x040013E3 RID: 5091
			Start,
			// Token: 0x040013E4 RID: 5092
			OpenParen,
			// Token: 0x040013E5 RID: 5093
			CriterionDone,
			// Token: 0x040013E6 RID: 5094
			ConjunctionPending,
			// Token: 0x040013E7 RID: 5095
			Whitespace
		}

		// Token: 0x020004DA RID: 1242
		private static class RegexAssertions
		{
			// Token: 0x040013E8 RID: 5096
			public static readonly string PrecededByOddNumberOfSingleQuotes = "(?<=(?:[^']*'[^']*')*'[^']*)";

			// Token: 0x040013E9 RID: 5097
			public static readonly string FollowedByOddNumberOfSingleQuotesAndLineEnd = "(?=[^']*'(?:[^']*'[^']*')*[^']*$)";

			// Token: 0x040013EA RID: 5098
			public static readonly string PrecededByEvenNumberOfSingleQuotes = "(?<=(?:[^']*'[^']*')*[^']*)";

			// Token: 0x040013EB RID: 5099
			public static readonly string FollowedByEvenNumberOfSingleQuotesAndLineEnd = "(?=(?:[^']*'[^']*')*[^']*$)";
		}
	}
}
