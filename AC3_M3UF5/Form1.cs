using System.Windows.Forms;
using AC3_M3UF5.CodeAC2;

namespace AC3_M3UF5
{
    public partial class managementForm : Form
    {
        public managementForm()
        {
            InitializeComponent();

            List<CodeAC2.Region> regionsCSV = new List<CodeAC2.Region>();
            Dictionary<int, string> regionsKeyValue = new Dictionary<int, string>();

            InitializeVariables(ref regionsCSV, ref regionsKeyValue);

            //comboYear:
            comboYear.Items.AddRange(QueryMethods.ListOfYears(regionsCSV));

            //comboRegion:
            comboRegion.DataSource = new BindingSource(regionsKeyValue, null);
            comboRegion.DisplayMember = "Value";
            comboRegion.ValueMember = "Key";
            comboRegion.SelectedIndex = -1;

            //dataGridRegions:
            InitializateDataGrid();

        }

        private void InitializateDataGrid()
        {
            string pathCSV = "../../../Files/ConsumAiguesComarca.csv";
            List<CodeAC2.Region> regionsCSV = FileHelper.ReadCSVFile(pathCSV);

            dataGridRegions.DataSource = regionsCSV;
            dataGridRegions.Columns[0].HeaderText = "Year";
            dataGridRegions.Columns[1].Visible = false;
            dataGridRegions.Columns[2].HeaderText = "Region";
            dataGridRegions.Columns[3].HeaderText = "Population";
            dataGridRegions.Columns[4].HeaderText = "Domestic network";
            dataGridRegions.Columns[5].HeaderText = "Economic activities and own sources";
            dataGridRegions.Columns[6].HeaderText = "Total";
            dataGridRegions.Columns[7].HeaderText = "Domestic consumption per capita";
        }

        private void InitializeVariables(ref List<CodeAC2.Region> regionsCSV, ref Dictionary<int, string> regionsKeyValue)
        {
            //
            // Execute CSV file
            // 
            string pathCSV = "../../../Files/ConsumAiguesComarca.csv";
            regionsCSV = FileHelper.ReadCSVFile(pathCSV);
            //
            // Save XML File
            //
            string pathXML = "../../../Files/ConsumAiguesComarca_KeyValue.xml";
            if (!File.Exists(pathXML))
            {
                foreach (var region in regionsCSV)
                {
                    if (File.Exists(pathXML))
                    {
                        FileHelper.AddKeyValueXML(region, pathXML);
                    }
                    else
                    {
                        FileHelper.CreateKeyValueXML(region, pathXML);
                    }
                }
            }
            //
            // Execute XML file
            //
            regionsKeyValue = FileHelper.ReadKeyValueXML(pathXML);
        }

        private void CleanInputs()
        {
            comboYear.Text = "";
            comboRegion.Text = "";
            textPopulation.Text = "";
            textDomesticConsum.Text = "";
            textEconomyConsum.Text = "";
            textTotalConsum.Text = "";
            textConsumCapita.Text = "";
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            CleanInputs();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string pathCSV = "../../../Files/ConsumAiguesComarca.csv";

            CodeAC2.Region region = new CodeAC2.Region
            {
                Year = int.Parse(comboYear.Text),
                Code = (int)comboRegion.SelectedValue,
                Name = comboRegion.Text,
                Population = int.Parse(textPopulation.Text),
                DomesticConsum = int.Parse(textDomesticConsum.Text),
                EconomyConsum = int.Parse(textEconomyConsum.Text),
                TotalConsum = int.Parse(textTotalConsum.Text),
                ConsumCapita = float.Parse(textConsumCapita.Text)
            };

            FileHelper.AddRegionToCSV(region, pathCSV);
            CleanInputs();
            InitializateDataGrid();
        }

        private void dataGridRegions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentCode = (int)dataGridRegions.CurrentRow.Cells[1].Value;
            int currentPopulation = (int)dataGridRegions.CurrentRow.Cells[3].Value;
            int currentDomesticConsum = (int)dataGridRegions.CurrentRow.Cells[4].Value;
            float currentConsumCapita = (float)dataGridRegions.CurrentRow.Cells[7].Value;

            string pathCSV = "../../../Files/ConsumAiguesComarca.csv";
            List<CodeAC2.Region> allRegions = FileHelper.ReadCSVFile(pathCSV);
            List<CodeAC2.Region> specificRegion = QueryMethods.GroupRegionByCode(allRegions, currentCode);

            labelResStatOne.Text = QueryMethods.IsPopulationHigherThan20000(currentPopulation) ? "YES" : "NO";
            labelResStatTwo.Text = QueryMethods.AverageDomesticConsum(currentPopulation, currentDomesticConsum).ToString();
            labelResStatThree.Text = QueryMethods.IsHighestConsumCapita(specificRegion, currentConsumCapita) ? "YES" : "NO";
            labelResStatFour.Text = QueryMethods.IsLowestConsumCapita(specificRegion, currentConsumCapita) ? "YES" : "NO";
        }
    }
}
