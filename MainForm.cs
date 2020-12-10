using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomNameGenerator
{
    public partial class MainForm : Form
    {
        System.Random random = new System.Random();

        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        char[] strangeconsonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z', 'ñ', '\'' };
        char[] strangevowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'á', 'ä', 'å', 'æ', 'é', 'ë', 'í', 'ï', 'ö', 'ô', 'ø', 'û', 'ü', 'ý', 'ÿ' };
        String[] pairs = {"ab", "ad", "ag", "aj", "al", "am", "an", "ap", "ar", "as", "at", "av", "aw", "ax", "ay", "az", "ba", "be", "bi", "bo", "bu", "by",
			"ca", "cy", "da", "de", "di", "do", "du", "eb", "ed", "ef", "eg", "ei", "ek", "el", "em", "en", "ep", "er", "es", "et", "ev", "ew", "ex",
			"ey", "fa", "fe", "fi", "fo", "fu", "fy", "ga", "ge", "gi", "go", "gu", "gy", "ha", "he", "hi", "ho", "hu", "hy", "ib", "id", "ig", "ik",
			"il", "im", "in", "ip", "ir", "is", "it", "ix", "ja", "je", "ji", "jo", "ju", "jy", "ka", "ke", "ki", "ko", "ku", "ky", "la", "le", "li",
			"lo", "lu", "ly", "ma", "me", "mi", "mo", "mu", "my", "na", "ne", "ni", "no", "nu", "ny", "ob", "od", "of", "og", "op", "or", "os", "ot",
			"ow", "ox", "oz", "pa", "pe", "pi", "po", "pu", "py", "qa", "qi", "qu", "ra", "re", "ri", "ro", "ru", "ry", "sa", "se", "si", "so", "su",
			"sy", "ta", "te", "ti", "to", "tu", "ty", "ub", "ud", "ug", "uk", "ul", "um", "un", "up", "ur", "us", "ux", "uz", "va", "ve", "vi", "vo",
			"vu", "vy", "xa", "xi", "xo", "xu", "xy", "za", "zi", "zo", "zu", "zy"};

        public MainForm()
        {
            InitializeComponent();
        }


        // Random names are just normal randomness.
        public void generateRandom()
        {
            String message = GeneratePairName();
            name1.Text = message;
            message = GeneratePairName();
            name2.Text = message;
            message = GeneratePairName();
            name3.Text = message;
            message = GeneratePairName();
            name4.Text = message;
            message = GeneratePairName();
            name5.Text = message;
            Refresh();
        }

        // Odd names have umlauts and such.
        public void generateOdd()
        {
            String message = GenerateName();
            name1.Text = message;
            message = GenerateName();
            name2.Text = message;
            message = GenerateName();
            name3.Text = message;
            message = GenerateName();
            name4.Text = message;
            message = GenerateName();
            name5.Text = message;
            Refresh();
        }

        // Strange names have all manner of weird accent characters.
        public void generateStrange()
        {
            String message = GenerateStrangeName();
            name1.Text = message;
            message = GenerateStrangeName();
            name2.Text = message;
            message = GenerateStrangeName();
            name3.Text = message;
            message = GenerateStrangeName();
            name4.Text = message;
            message = GenerateStrangeName();
            name5.Text = message;
            Refresh();
        }

        private String GeneratePairName()
        {
            String name = "";
            while (true)
            {
                int val = random.Next(6);
                switch (val)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        name += pairs[(random.Next(pairs.Length))];
                        break;
                    case 4:
                    case 5:
                        if (name.Length > 2)
                            return Char.ToUpper(name[0]) + name.Substring(1);
                        break;
                }
                if (name.Length > 9)
                    return Char.ToUpper(name[0]) + name.Substring(1);
            }
        }

        private String GenerateName()
        {
            String name = "";
            int consonantsinrow = 0;
            while (true)
            {
                int val = random.Next(6);
                switch (val)
                {
                    case 0:
                    case 1:
                    case 2:
                        if (name.Length == 2 && consonantsinrow == 2)
                        {
                            name += vowels[random.Next(5)];
                            consonantsinrow = 0;
                        }
                        else
                        {
                            name += consonants[random.Next(20)];
                            consonantsinrow++;
                        }
                        break;
                    case 3:
                    case 4:
                        name += vowels[random.Next(5)];
                        consonantsinrow = 0;
                        break;
                    case 5:
                        if (name.Length > 2)
                            return Char.ToUpper(name[0]) + name.Substring(1);
                        break;
                }
                if (consonantsinrow > 2)
                    return Char.ToUpper(name[0]) + name.Substring(1);
            }
        }

        private String GenerateStrangeName()
        {
            String name = "";
            int consonantsinrow = 0;
            while (true)
            {
                int val = random.Next(6);
                switch (val)
                {
                    case 0:
                    case 1:
                    case 2:
                        if (name.Length == 2 && consonantsinrow == 2)
                        {
                            name += strangevowels[random.Next(5)];
                            consonantsinrow = 0;
                        }
                        else
                        {
                            name += strangeconsonants[random.Next(22)];
                            consonantsinrow++;
                        }
                        break;
                    case 3:
                        name += vowels[random.Next(5)];
                        consonantsinrow = 0;
                        break;
                    case 4:
                        name += strangevowels[random.Next(21)];
                        consonantsinrow = 0;
                        break;
                    case 5:
                        if (name.Length > 2)
                            return Char.ToUpper(name[0]) + name.Substring(1);
                        break;
                }
                if (consonantsinrow > 2)
                    return Char.ToUpper(name[0]) + name.Substring(1);
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            generateRandom();
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            generateOdd();
        }

        private void btnStrange_Click(object sender, EventArgs e)
        {
            generateStrange();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Random Name Generator 1.01\n\nThe Random Name Generator is copyright 2011-2020 Lambda Centauri.\nhttps://lambdacentauri.com\n\nThe Random Name Generator is freeware and may be distributed freely.", "About the Random Name Generator");
        }
    }
}
