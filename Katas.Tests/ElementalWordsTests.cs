﻿//namespace Katas.Tests;

//public class ElementalWordsTests
//{
//	[Test]
//	public void Simple()
//	{
//		var combinations = ElementalWords.ElementalForms("yes");
//		Assert.That(combinations, Is.EqualTo(new[] { new[] { "Yttrium (Y)", "Einsteinium (Es)" } }));
//	}
//}

//public class ElementalWords
//{
//	public static string[][] ElementalForms(string word)
//	{
//		var characters = word.ToCharArray();
//		var combinations = new List<string>();
//		{

//		}
//		return new string[0][];
//	}

//	private readonly Dictionary<string, string> ELEMENTS = new()
//	{
//		{ "H", "Hydrogen" },
//		{ "He", "Helium" },
//		{ "Li", "Lithium" },
//		{ "Be", "Beryllium" },
//		{ "B", "Boron" },
//		{ "C", "Carbon" },
//		{ "N", "Nitrogen" },
//		{ "O", "Oxygen" },
//		{ "F", "Fluorine" },
//		{ "Ne", "Neon" },
//		{ "Na", "Sodium" },
//		{ "Mg", "Magnesium" },
//		{ "Al", "Aluminium" },
//		{ "Si", "Silicon" },
//		{ "P", "Phosphorus" },
//		{ "S", "Sulfur" },
//		{ "Cl", "Chlorine" },
//		{ "Ar", "Argon" },
//		{ "K", "Potassium" },
//		{ "Ca", "Calcium" },
//		{ "Sc", "Scandium" },
//		{ "Ti", "Titanium" },
//		{ "V", "Vanadium" },
//		{ "Cr", "Chromium" },
//		{ "Mn", "Manganese" },
//		{ "Fe", "Iron" },
//		{ "Co", "Cobalt" },
//		{ "Ni", "Nickel" },
//		{ "Cu", "Copper" },
//		{ "Zn", "Zinc" },
//		{ "Ga", "Gallium" },
//		{ "Ge", "Germanium" },
//		{ "As", "Arsenic" },
//		{ "Se", "Selenium" },
//		{ "Br", "Bromine" },
//		{ "Kr", "Krypton" },
//		{ "Rb", "Rubidium" },
//		{ "Sr", "Strontium" },
//		{ "Y", "Yttrium" },
//		{ "Zr", "Zirconium" },
//		{ "Nb", "Niobium" },
//		{ "Mo", "Molybdenum" },
//		{ "Tc", "Technetium" },
//		{ "Ru", "Ruthenium" },
//		{ "Rh", "Rhodium" },
//		{ "Pd", "Palladium" },
//		{ "Ag", "Silver" },
//		{ "Cd", "Cadmium" },
//		{ "In", "Indium" },
//		{ "Sn", "Tin" },
//		{ "Sb", "Antimony" },
//		{ "Te", "Tellurium" },
//		{ "I", "Iodine" },
//		{ "Xe", "Xenon" },
//		{ "Cs", "Caesium" },
//		{ "Ba", "Barium" },
//		{ "La", "Lanthanum" },
//		{ "Ce", "Cerium" },
//		{ "Pr", "Praseodymium" },
//		{ "Nd", "Neodymium" },
//		{ "Pm", "Promethium" },
//		{ "Sm", "Samarium" },
//		{ "Eu", "Europium" },
//		{ "Gd", "Gadolinium" },
//		{ "Tb", "Terbium" },
//		{ "Dy", "Dysprosium" },
//		{ "Ho", "Holmium" },
//		{ "Er", "Erbium" },
//		{ "Tm", "Thulium" },
//		{ "Yb", "Ytterbium" },
//		{ "Lu", "Lutetium" },
//		{ "Hf", "Hafnium" },
//		{ "Ta", "Tantalum" },
//		{ "W", "Tungsten" },
//		{ "Re", "Rhenium" },
//		{ "Os", "Osmium" },
//		{ "Ir", "Iridium" },
//		{ "Pt", "Platinum" },
//		{ "Au", "Gold" },
//		{ "Hg", "Mercury" },
//		{ "Tl", "Thallium" },
//		{ "Pb", "Lead" },
//		{ "Bi", "Bismuth" },
//		{ "Po", "Polonium" },
//		{ "At", "Astatine" },
//		{ "Rn", "Radon" },
//		{ "Fr", "Francium" },
//		{ "Ra", "Radium" },
//		{ "Ac", "Actinium" },
//		{ "Th", "Thorium" },
//		{ "Pa", "Protactinium" },
//		{ "U", "Uranium" },
//		{ "Np", "Neptunium" },
//		{ "Pu", "Plutonium" },
//		{ "Am", "Americium" },
//		{ "Cm", "Curium" },
//		{ "Bk", "Berkelium" },
//		{ "Cf", "Californium" },
//		{ "Es", "Einsteinium" },
//		{ "Fm", "Fermium" },
//		{ "Md", "Mendelevium" },
//		{ "No", "Nobelium" },
//		{ "Lr", "Lawrencium" },
//		{ "Rf", "Rutherfordium" },
//		{ "Db", "Dubnium" },
//		{ "Sg", "Seaborgium" },
//		{ "Bh", "Bohrium" },
//		{ "Hs", "Hassium" },
//		{ "Mt", "Meitnerium" },
//		{ "Ds", "Darmstadtium" },
//		{ "Rg", "Roentgenium" },
//		{ "Cn", "Copernicium" },
//		{ "Uut", "Ununtrium" },
//		{ "Fl", "Flerovium" },
//		{ "Uup", "Ununpentium" },
//		{ "Lv", "Livermorium" },
//		{ "Uus", "Ununseptium" },
//		{ "Uuo", "Ununoctium" },
//		{ "H", "Hydrogen" },
//		{ "He", "Helium" },
//		{ "Li", "Lithium" },
//		{ "Be", "Beryllium" },
//		{ "B", "Boron" },
//		{ "C", "Carbon" },
//		{ "N", "Nitrogen" },
//		{ "O", "Oxygen" },
//		{ "F", "Fluorine" },
//		{ "Ne", "Neon" },
//		{ "Na", "Sodium" },
//		{ "Mg", "Magnesium" },
//		{ "Al", "Aluminium" },
//		{ "Si", "Silicon" },
//		{ "P", "Phosphorus" },
//		{ "S", "Sulfur" },
//		{ "Cl", "Chlorine" },
//		{ "Ar", "Argon" },
//		{ "K", "Potassium" },
//		{ "Ca", "Calcium" },
//		{ "Sc", "Scandium" },
//		{ "Ti", "Titanium" },
//		{ "V", "Vanadium" },
//		{ "Cr", "Chromium" },
//		{ "Mn", "Manganese" },
//		{ "Fe", "Iron" },
//		{ "Co", "Cobalt" },
//		{ "Ni", "Nickel" },
//		{ "Cu", "Copper" },
//		{ "Zn", "Zinc" },
//		{ "Ga", "Gallium" },
//		{ "Ge", "Germanium" },
//		{ "As", "Arsenic" },
//		{ "Se", "Selenium" },
//		{ "Br", "Bromine" },
//		{ "Kr", "Krypton" },
//		{ "Rb", "Rubidium" },
//		{ "Sr", "Strontium" },
//		{ "Y", "Yttrium" },
//		{ "Zr", "Zirconium" },
//		{ "Nb", "Niobium" },
//		{ "Mo", "Molybdenum" },
//		{ "Tc", "Technetium" },
//		{ "Ru", "Ruthenium" },
//		{ "Rh", "Rhodium" },
//		{ "Pd", "Palladium" },
//		{ "Ag", "Silver" },
//		{ "Cd", "Cadmium" },
//		{ "In", "Indium" },
//		{ "Sn", "Tin" },
//		{ "Sb", "Antimony" },
//		{ "Te", "Tellurium" },
//		{ "I", "Iodine" },
//		{ "Xe", "Xenon" },
//		{ "Cs", "Caesium" },
//		{ "Ba", "Barium" },
//		{ "La", "Lanthanum" },
//		{ "Ce", "Cerium" },
//		{ "Pr", "Praseodymium" },
//		{ "Nd", "Neodymium" },
//		{ "Pm", "Promethium" },
//		{ "Sm", "Samarium" },
//		{ "Eu", "Europium" },
//		{ "Gd", "Gadolinium" },
//		{ "Tb", "Terbium" },
//		{ "Dy", "Dysprosium" },
//		{ "Ho", "Holmium" },
//		{ "Er", "Erbium" },
//		{ "Tm", "Thulium" },
//		{ "Yb", "Ytterbium" },
//		{ "Lu", "Lutetium" },
//		{ "Hf", "Hafnium" },
//		{ "Ta", "Tantalum" },
//		{ "W", "Tungsten" },
//		{ "Re", "Rhenium" },
//		{ "Os", "Osmium" },
//		{ "Ir", "Iridium" },
//		{ "Pt", "Platinum" },
//		{ "Au", "Gold" },
//		{ "Hg", "Mercury" },
//		{ "Tl", "Thallium" },
//		{ "Pb", "Lead" },
//		{ "Bi", "Bismuth" },
//		{ "Po", "Polonium" },
//		{ "At", "Astatine" },
//		{ "Rn", "Radon" },
//		{ "Fr", "Francium" },
//		{ "Ra", "Radium" },
//		{ "Ac", "Actinium" },
//		{ "Th", "Thorium" },
//		{ "Pa", "Protactinium" },
//		{ "U", "Uranium" },
//		{ "Np", "Neptunium" },
//		{ "Pu", "Plutonium" },
//		{ "Am", "Americium" },
//		{ "Cm", "Curium" },
//		{ "Bk", "Berkelium" },
//		{ "Cf", "Californium" },
//		{ "Es", "Einsteinium" },
//		{ "Fm", "Fermium" },
//		{ "Md", "Mendelevium" },
//		{ "No", "Nobelium" },
//		{ "Lr", "Lawrencium" },
//		{ "Rf", "Rutherfordium" },
//		{ "Db", "Dubnium" },
//		{ "Sg", "Seaborgium" },
//		{ "Bh", "Bohrium" },
//		{ "Hs", "Hassium" },
//		{ "Mt", "Meitnerium" },
//		{ "Ds", "Darmstadtium" },
//		{ "Rg", "Roentgenium" },
//		{ "Cn", "Copernicium" },
//		{ "Uut", "Ununtrium" },
//		{ "Fl", "Flerovium" },
//		{ "Uup", "Ununpentium" },
//		{ "Lv", "Livermorium" },
//		{ "Uus", "Ununseptium" },
//		{ "Uuo", "Ununoctium" }
//	};

//}