using System.Text;

namespace INFO_BEZ__1laba
{
    public partial class Form1 : Form
    {
        private Dictionary<char, string[]>? keyValues;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stringValue = encodeValueTextBox.Text.Replace(" ", "");


            keyValues = GenerationKey(stringValue)
                .ToDictionary(p => p.Key, x => x.Value.ToArray());

            SetKeyInTable(keyDataGrid, keyValues);

            var result = Encrypt(stringValue);

            encodeResultTextBox.Text = result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = Decrypt(decodeValueTextBox.Text);

            decodeResultTextBox.Text = result;
        }

        private string Encrypt(string value)
        {

            if (keyValues is null)
            {
                throw new Exception("Пустой ключ");
            }


            var encrypted = new StringBuilder();

            foreach (char c in value.ToLower())
            {
                if (keyValues.ContainsKey(c))
                {
                    int index = new Random().Next(keyValues[c].Length); // pick a random substitution
                    encrypted.Append(keyValues[c][index]);
                    encrypted.Append(" ");// add the substitution to the result
                }
                else
                {
                    encrypted.Append(c); // leave the character as-is
                }
            }

            return encrypted.ToString();
        }

        private string Decrypt(string value)
        {

            if (keyValues is null)
            {
                throw new Exception("Пустой ключ");
            }

            var massivValues = value.Split(" ");

            var result = "";

            foreach (var item in massivValues)
            {
                var work = keyValues.Where(p => p.Value.Contains(item))
                     .Select(p => p.Key).FirstOrDefault();

                result += work;
            }

            return result;
        }

        private Dictionary<char, List<string>> GenerationKey(string value)
        {
            var result = value.ToArray().Distinct().ToDictionary(p => p, x => new List<string>());

            var random = new Random();

            var countWorker = value.Select(p => new
            {
                Key = p,
                Count = value.Count(x => x == p)
            }).Distinct().ToList();

            foreach (var item in result)
            {
                var countVarible = countWorker.FirstOrDefault(p => p.Key == item.Key)?.Count;

                var variable = "-1";

                while (true)
                {
                    variable = random.Next(1, 99).ToString();

                    var isCheckValue = result.Values
                        .FirstOrDefault(p => p.Contains(variable)) is null;

                    if (isCheckValue)
                    {
                        if (result[item.Key].Count == countVarible)
                        {
                            break;
                        }

                        result[item.Key].Add(variable);
                    }
                }
            }

            return result;
        }

        private void SetKeyInTable(DataGridView table, Dictionary<char, string[]> value)
        {
            table.ColumnCount = value.Count;
            table.RowCount = value.Select(p => p.Value.Count()).Max() + 1;
            table.Rows.Add();

            for (int i = 0; i < value.Count; i++)
            {
                table[i, 0].Value = value.Select(p => p.Key).ToArray()[i];
            }

            for (int i = 0; i < table.ColumnCount; i++)
            {
                var valueItem = value.ToArray()[i];

                for (int j = 0; j < table.RowCount; j++)
                {
                    if (valueItem.Value.Count() - 1 >= j)
                    {
                        table[i, j + 1].Value = valueItem.Value[j];
                    }
                }
            }
        }



    }
}