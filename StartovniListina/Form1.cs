using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace StartovniListina
{
    public partial class Form1 : Form
    {
        string pathToNamesList = string.Empty;
        string pathToNewList = string.Empty;
        readonly string separator = Environment.NewLine;
        TimeSpan startTime;
        TimeSpan timeDifference;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_prochazet_Click(object sender, EventArgs e)
        {
            string filePath;
            OpenFileDialog openFileDialog = new() { 
                Filter = "Textové soubory (*.txt)|*.txt",
                Title = "Zvolte soubor jmen.",
                CheckFileExists = true,
                InitialDirectory = "C:Users",
                Multiselect = false
            };
            openFileDialog.ShowDialog();
            filePath = openFileDialog.FileName;
            textBox1.Text = filePath;
            pathToNamesList = filePath;
        }
        private void button_prochazet_novySoubor_Click(object sender, EventArgs e)
        {
            string filePath;
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Textové soubory (*.txt)|*.txt",
                Title = "Zvolte soubor jmen.",
                FileName = "seznam_startovaci.txt",
                InitialDirectory = "C:Users"
            };
            saveFileDialog.ShowDialog();
            filePath = saveFileDialog.FileName;
            textBox2.Text = filePath;
            pathToNewList = filePath;
        }
        private bool TryParseNamesList(out string[]? parsedContents)
        {
            FileStream fileStream = new(pathToNamesList, FileMode.Open);
            StreamReader streamReader = new(fileStream);
            string fileContents = streamReader.ReadToEnd();
            streamReader.Close();
            fileStream.Close();
            try
            {
                parsedContents = fileContents.Split(separator);
            }
            catch (Exception)
            {
                MessageBox.Show("Pøi zpracování souboru nastala chyba, pravdìpodobnì je v neplatném tvaru.",
                    "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                parsedContents = null;
                return false;
            }
            return true;
        }
        private bool TryUpdateStartingTime()
        {
            if (!int.TryParse(textBox_hodinaSelect.Text, out int hour))
            {
                MessageBox.Show("Nezadali jste èas ve správném formátu", "Neplatný èas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(textBox_minutaSelect.Text, out int minute))
            {
                MessageBox.Show("Nezadali jste èas ve správném formátu", "Neplatný èas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            startTime = new TimeSpan(hour, minute, 0);
            return true;
        }
        private void UpdateTimeDifference(int minutes)
        {
            timeDifference = new TimeSpan(0, minutes, 0);
        }
        private void textBox_hodinaSelect_Enter(object sender, EventArgs e) { }
        private void textBox_hodinaSelect_Leave(object sender, EventArgs e) { }
        private void textBox_interval_Enter(object sender, EventArgs e) { }
        private void textBox_interval_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox_interval.Text, out int minutes))
            {
                MessageBox.Show("Nezadali jste èas ve správném formátu", "Neplatný èas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateTimeDifference(minutes);
        }
        private void button_vytvorit_Click(object sender, EventArgs e)
        {
            if (!File.Exists(pathToNamesList))
            {
                MessageBox.Show("Soubor se jmény nebyl zvolen, nebo byl smazán.", "Soubor Neexistuje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrEmpty(pathToNewList))
            {
                MessageBox.Show("Nebylo zvoleno umístìní pro nový soubor.", "Soubor nezvolen",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!TryUpdateStartingTime())
            {
                return;
            }


            if (timeDifference.Minutes == 0 && timeDifference.Hours == 0)
            {
                MessageBox.Show("Èasový rozdíl mezi závodníky je nulový, takže vybìhnou všichni najednou",
                    "Upozornìní", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            string[] names;
            if(TryParseNamesList(out string[]? parsedContents))
            {
                names = parsedContents;
            }
            else
            {
                return;
            }
            names = ShuffleArrayRandomly(names);
            SaveContestantOrderList(names);

            MessageBox.Show("Seznam úspìšnì vytvoøen.", "Úspìšnì vytvoøeno",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenSavedFile();
        }
        private void OpenSavedFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(pathToNewList)
            {
                Verb = "open",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
        private void SaveContestantOrderList(string[] names)
        {
            FileStream fileStream = new FileStream(pathToNewList, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            TimeSpan contestantStartTime = startTime;
            string format = @"hh\:mm\:ss";
            foreach (string name in names)
            {
                streamWriter.WriteLine($"{contestantStartTime.ToString(format)} : {name}");
                contestantStartTime += timeDifference;
            }
            streamWriter.Close();
            fileStream.Close();
            textBox_hodinaSelect_Leave(false, new EventArgs());
        }
        public static T[] ShuffleArrayRandomly<T>(T[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                SwapReference(ref array[i], ref array[random.Next(array.Length)]);
            }
            return array;
        }
        public static void SwapReference<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Closing closing = new Form_Closing();
            DialogResult result = closing.ShowDialog();
            e.Cancel = result == DialogResult.No;
        }
    }
}