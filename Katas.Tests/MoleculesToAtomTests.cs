//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Katas.Tests
//{
//		public class MoleculesToAtomTests
//		{
//			[Test]
//			public void Simple()
//			{
//				var result = MoleculesToAtom.ParseMolecule("H2O");
//				CollectionAssert.AreEquivalent(new Dictionary<string, int> { { "H", 2 }, { "O", 1 } }, result);
//		}

//			[Test]
//			public void OneBracket()
//			{
//				var result = MoleculesToAtom.ParseMolecule("Mg(OH)2");
//				CollectionAssert.AreEquivalent(new Dictionary<string, int> { { "Mg", 1 }, { "O", 2 }, { "H", 2 } }, result);
//			}
//	}

//		public class MoleculesToAtom
//		{
//			public static Dictionary<string, int> ParseMolecule(string formula)
//			{
//				var result = new Dictionary<string, int>();
//				var characters = formula.ToCharArray();
//				foreach (var character in characters)
//				{
//					if (!char.IsDigit(character))
//					{
//						if (char.IsLower(character))
//						{
//							var newKey = result.Last().Key+ character.ToString();
//							var value= result.Last().Value;
//							result.Remove(result.Last().Key);
//							result.Add(newKey, value);
//						}
//						if (char.IsUpper(character))
//							result[character.ToString()] = 1;
//					}
						
//					else if (char.IsDigit(character))
//						result[result.Last().Key] += int.Parse(character.ToString()) - 1;
//				}
//				return result;
//			}
//		}
//}
