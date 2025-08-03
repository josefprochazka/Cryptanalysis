using System;
using System.Collections.Generic;
using System.Linq;

namespace Cryptanalysis
{
	public static class CommonSettings
	{
		#region Fields

		public static CurrentAlphabet currentalphabetAsEnum = CurrentAlphabet.eng;
		public static List<char> currentAlphabet = CommonConstants.englishAlphabet.ToList();

		public static string startingText = "APLIKACE KRYPTOANALÝZA" + Environment.NewLine + Environment.NewLine +
			"Obsah tohoto textového okna je vytvořen pro vysvětlení základních funkcí v aplikaci. Na horní liště se nachází několik menu obsahující funkce pro textová okna. Aplikace je určena předně pro texty anglického jazyka, což " +
			"znamená, že většina funkcí ignoruje písmena nepatřící do anglické abecedy a pro správnou funkčnost kryptoanalytických metod je potřeba, aby otevřený text obsahoval pouze anglická slova. Textové okno v pozadí obsahuje anglický " +
			"text, který lze použít k testování." + Environment.NewLine + Environment.NewLine +
			"1) Menu \"Soubor\" zajišťuje otevírání/zavírání textových oken a ukládání/načítání jejich obsahu do souborů." + Environment.NewLine + Environment.NewLine +
			"2) \"Šifrování/Dešifrování\" obsahuje základní šifry, nastavení klíčů a dalších parametrů. Výstupní otevřený/šifrový text se objeví v novém okně." + Environment.NewLine + Environment.NewLine +
			"3) \"Analýza\" nabízí zjištění kryptoanalytických informací o analyzovaném textu." + Environment.NewLine + Environment.NewLine +
			"4) V menu \"Kryptoanalýza\" se nachází kryptoanalytické funkce k rozluštění šifrových textů. Také je zde \"Manuální kryptoanalýza\" pro Substituční šifru.";

		public static string longEnglishText = "Wrote water woman of heart it total other. By in entirely securing suitable graceful at families improved. Zealously few furniture repulsive was agreeable consisted difficult. Collected breakfast estimable " +
			"questions in to favourite it. Known he place worth words it as to. Spoke now noise off smart her ready. Up branch to easily missed by do. Admiration considered acceptance too led one melancholy expression. Are will took form the nor" +
			" true. Winding enjoyed minuter her the letters evident use eat colonel. He attacks observe mr cottage inquiry am examine gravity. Are dear but near left was. Year kept on over so as this of. She steepest doubtful betrayed formerly him." +
			" Active one called uneasy our seeing see cousin tastes its. Ye am it formed indeed agreed relied piqued. It prepare is ye nothing blushes up brought theme. Or as gravity pasture limited evening on. Wicket around beauty say she. Frankness" +
			" resembled say not new smallness you discovery. Noisier ferrars yet shyness weather ten colonel. Too him himself engaged husband pursuit musical. Man age but him determine consisted therefore. Dinner to beyond regret wished an branch " +
			"he. Remain bed but expect suffer little them repair. Am of mr friendly by strongly peculiar juvenile. Unpleasant it sufficient simplicity am by friendship no inhabiting. Goodness there doubtful material has denoting suitable she two. Dear mean " + 
			"she way and poor bred they come. He otherwise me incommode explained so in remaining. Polite barton in it warmly do county length an.";

		#endregion

		#region Properties

		public static char CurrentLetterQ => (currentalphabetAsEnum == CurrentAlphabet.ENG) ? 'Q' : 'q';

		public static char CurrentLetterX => (currentalphabetAsEnum == CurrentAlphabet.ENG) ? 'X' : 'x';

		public static char CurrentLetterY => (currentalphabetAsEnum == CurrentAlphabet.ENG) ? 'Y' : 'y';

		public static char CurrentLetterJ => (currentalphabetAsEnum == CurrentAlphabet.ENG) ? 'J' : 'j';

		public static char CurrentLetterI => (currentalphabetAsEnum == CurrentAlphabet.ENG) ? 'I' : 'i';

		public static int CurrentAplhabetLettersCount => currentAlphabet.Count;

		#endregion
	}
}