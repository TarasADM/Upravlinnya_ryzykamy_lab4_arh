namespace RM.Lab4
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Out1 : Form
    {
        private static readonly string[] Zahids = new[]
        {
            "Попереднє навчання членів проектного колективу",
            "Узгодження детального переліку вимог до ПЗ із замовником",
            "Внесення узгодженого переліку вимог до ПЗ замовника в договір",
            "Точне слідування вимогам замовника з узгодженого переліку вимог до ПЗ",
            "Попередні дослідження ринку",
            "Експертна оцінка програмного проекту досвідченим стороннім консультантом",
            "Консультації досвідченого стороннього консультанта",
            "Тренінг з вивчення необхідних інструментів розроблення ПЗ",
            "Укладання договору страхування",
            "Використання \"шаблонних\" рішень з вдалих попередніх проектів при управлінні програмним проектом",
            "Підготовка документів, які показують важливість даного проекту для досягнення фінансових цілей компанії-розробника",
            "Реорганізація роботи проектного колективу так, щоб обов'язки та робота членів колективу перекривали один одного",
            "Придбання (замовлення) частини компонент розроблюваного ПЗ",
            "Заміна потенційно дефектних компонент розроблюваного ПЗ придбаними компонентами, які гарантують якість виконання роботи",
            "Придбання більш продуктивної бази даних",
            "Використання генератора програмного коду",
            "Реорганізація роботи проектного колективу залежно від рівня труднощі виконання завдань та професійних рівнів розробників",
            "Повторне використання придатних компонент ПЗ, які були розроблені для інших програмних проектів",
            "Аналіз доцільності розроблення даного ПЗ",
        };


        public double techProbCoef = 0.1;
        public double costProbCoef = 0.05;
        public double planProbCoef = 0.12;
        public double managProbCoef = 0.08;
        public double[] eRandCoef = new[] { 0.45, 0.64, 0.40, 0.10, 0.74, 0.13, 0.15, 0.13, 0.68, 0.31 };

        private readonly DataGridView probabilityDataGrid;
        private readonly DataGridView techDataGrid;
        private readonly DataGridView costDataGrid;
        private readonly DataGridView planDataGrid;
        private readonly DataGridView managDataGrid;

        public Out1(
            DataGridView probabilityDataGrid,
            DataGridView techDataGrid,
            DataGridView costDataGrid,
            DataGridView planDataGrid,
            DataGridView managDataGrid)
        {
            InitializeComponent();
            this.probabilityDataGrid = probabilityDataGrid;
            this.techDataGrid = techDataGrid;
            this.costDataGrid = costDataGrid;
            this.planDataGrid = planDataGrid;
            this.managDataGrid = managDataGrid;

            Helpers.ChangeEditModeToOnPropertyChanged(stage4);
        }

        private void Out1_Load(object sender, EventArgs e)
        {
            FillProbabilityGrid();

            var list = Zahids.Select(i => new
            {
                name = i
            }).ToList();

            stage4.Columns[0].Width = 500;

            if (stage4.Columns[2] is DataGridViewComboBoxColumn col)
            {
                col.DataSource = list;
                col.ValueMember = "name";
                col.DataPropertyName = "name";
                col.Width = 500;
            }
        }

        private void FillProbabilityGrid()
        {
            probabilityResDataGrid.Columns.AddRange(
                new DataGridViewTextBoxColumn() { Name = "i", HeaderText = "", Width = 30 },
                new DataGridViewTextBoxColumn()
                {
                    Name = "name",
                    HeaderText = "Множина подій",
                    Width = 500,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                },
                new DataGridViewTextBoxColumn() { Name = "count", HeaderText = "", Width = 30 },
                new DataGridViewTextBoxColumn() { Name = "e1", HeaderText = "1", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e2", HeaderText = "2", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e3", HeaderText = "3", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e4", HeaderText = "4", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e5", HeaderText = "5", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e6", HeaderText = "6", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e7", HeaderText = "7", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e8", HeaderText = "8", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e9", HeaderText = "9", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "e10", HeaderText = "10", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "sume", HeaderText = "Σ", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe1", HeaderText = "1", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe2", HeaderText = "2", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe3", HeaderText = "3", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe4", HeaderText = "4", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe5", HeaderText = "5", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe6", HeaderText = "6", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe7", HeaderText = "7", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe8", HeaderText = "8", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe9", HeaderText = "9", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "cfe10", HeaderText = "10", Width = 50 },
                new DataGridViewTextBoxColumn() { Name = "probab", HeaderText = "Ймовірність", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "probabLvl", HeaderText = "Рівень" }
                );

            foreach (DataGridViewColumn col in probabilityResDataGrid.Columns)
            {
                col.HeaderCell.Style.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            probabilityResDataGrid.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            probabilityResDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            probabilityResDataGrid.AllowUserToAddRows = false;
            probabilityResDataGrid.AllowUserToDeleteRows = false;
            probabilityResDataGrid.AllowUserToOrderColumns = false;

            var techEArr = probabilityDataGrid.Rows[0].Cells.Cast<DataGridViewTextBoxCell>().Skip(2).Select(x => Convert.ToInt32(x.Value)).ToArray();
            var costEArr = probabilityDataGrid.Rows[1].Cells.Cast<DataGridViewTextBoxCell>().Skip(2).Select(x => Convert.ToInt32(x.Value)).ToArray();
            var planEArr = probabilityDataGrid.Rows[2].Cells.Cast<DataGridViewTextBoxCell>().Skip(2).Select(x => Convert.ToInt32(x.Value)).ToArray();
            var managEArr = probabilityDataGrid.Rows[3].Cells.Cast<DataGridViewTextBoxCell>().Skip(2).Select(x => Convert.ToInt32(x.Value)).ToArray();

            // TECH
            var techArr = new List<object> { "", "Множина настання технічних ризикових подій", Helpers.CountRiskSet(techDataGrid) };
            techArr.AddRange(techEArr.Cast<object>());
            techArr.Add(techEArr.Sum());

            var techRowIndex = probabilityResDataGrid.Rows.Add(techArr.ToArray());

            CalcProbability(probabilityResDataGrid, techDataGrid, techEArr, techProbCoef, techRowIndex);

            // COST
            var costArr = new List<object> { "", "Множина настання вартісних ризикових подій", Helpers.CountRiskSet(costDataGrid) };
            costArr.AddRange(costEArr.Cast<object>());
            costArr.Add(costEArr.Sum());

            var costRowIndex = probabilityResDataGrid.Rows.Add(costArr.ToArray());

            CalcProbability(probabilityResDataGrid, costDataGrid, costEArr, costProbCoef, costRowIndex);

            // PLAN
            var planArr = new List<object> { "", "Множина настання планових ризикових подій", Helpers.CountRiskSet(planDataGrid) };
            planArr.AddRange(planEArr.Cast<object>());
            planArr.Add(planEArr.Sum());

            var planRowIndex = probabilityResDataGrid.Rows.Add(planArr.ToArray());

            CalcProbability(probabilityResDataGrid, planDataGrid, planEArr, planProbCoef, planRowIndex);

            // MANAG
            var managArr = new List<object> { "", "Множина настання планових ризикових подій", Helpers.CountRiskSet(managDataGrid) };
            managArr.AddRange(managEArr.Cast<object>());
            managArr.Add(managEArr.Sum());

            var managRowIndex = probabilityResDataGrid.Rows.Add(managArr.ToArray());

            CalcProbability(probabilityResDataGrid, managDataGrid, managEArr, managProbCoef, managRowIndex);

            var headerRowsIds = new[] { techRowIndex, costRowIndex, planRowIndex, managRowIndex };

            Helpers.FillHeaderRowColor(probabilityResDataGrid, headerRowsIds);

            var rand = new Random();

            var list = probabilityResDataGrid.Rows
                .Cast<DataGridViewRow>()
                .Where((r, i) => !headerRowsIds.Contains(i))
                .Select(r =>
                {
                    var prob = rand.NextDouble();
                    var loss = rand.NextDouble();

                    return new
                    {
                        risk = r.Cells[1].Value,
                        p = r.Cells[r.Cells.Count - 2].Value,
                        newProbEst = $"{prob:0.000}",
                        newLossEst = $"{loss:0.000}",
                        val = $"{prob * loss:0.000}",
                    };
                });

            foreach (var item in list)
            {
                stage4.Rows.Add(item.risk, item.p, null, item.newProbEst, item.newLossEst, item.val);
            }
        }

        private void CalcProbability(DataGridView probabilityResDataGrid, DataGridView inputDataGrid, int[] ocinkaEArr, double techCoef, int setRowIndex)
        {
            var temp = inputDataGrid.Rows.Cast<DataGridViewRow>().Where(r => Convert.ToInt32(r.Cells[2].Value) != 0).Select((r, i) =>
            {
                var rand = new Random();
                var randRowCoef = techCoef + rand.NextDouble() * techCoef;
                var eArr = eRandCoef.Select(x => randRowCoef + rand.NextDouble() * x).ToArray();
                var eArrAvg = eArr.Average();

                var eCoefArr = eArr.Select((x, i) => x * ocinkaEArr[i]);
                var probability = eCoefArr.Sum() / ocinkaEArr.Sum();

                var probLvl = CalcProbabilityLvl(probability);

                var row = new List<object>();
                row.Add(i + 1);
                row.Add(r.Cells[1].Value);
                row.Add(r.Cells[2].Value);
                row.AddRange(eArr.Cast<object>());
                row.Add(eArrAvg);
                row.AddRange(eCoefArr.Cast<object>());
                row.Add(probability);
                row.Add(probLvl);

                var rowId = probabilityResDataGrid.Rows.Add(Helpers.ConvertG(row));

                probabilityResDataGrid.Rows[rowId].Cells[probabilityResDataGrid.Columns.Count - 1].Style.BackColor = GetColorForLevel(probLvl);

                return new List<double>(eCoefArr) { probability };
            }).ToList();

            if (!temp.Any())
            {
                return;
            }

            for (int i = 0; i < 11; i++)
            {
                var sum = 0.0;
                for (int j = 0; j < temp.Count; j++)
                {
                    sum += temp[j][i];
                }

                var res = sum / temp[0].Count;
                probabilityResDataGrid[i + 14, setRowIndex].Value = res.ToString("0.000");

                if (i == 10)
                {
                    var lvl = CalcProbabilityLvl(res);
                    probabilityResDataGrid[i + 15, setRowIndex].Value = lvl;

                    probabilityResDataGrid.Rows[setRowIndex].Cells[probabilityResDataGrid.Columns.Count - 1].Style.BackColor = GetColorForLevel(lvl);
                }
            }
        }

        private static string CalcProbabilityLvl(double probability)
        {
            if (probability <= 0)
            {
                return "";
            }
            else if (probability <= 0.1)
            {
                return "ДУЖЕ НИЗЬКА";
            }
            else if (probability <= 0.25)
            {
                return "НИЗЬКА";
            }
            else if (probability <= 0.5)
            {
                return "СЕРЕДНЯ";
            }
            else if (probability <= 0.75)
            {
                return "ВИСОКА";
            }

            return "ДУЖЕ ВИСОКА";
        }

        private static Color GetColorForLevel(string level)
        {
            return level switch
            {
                "ДУЖЕ ВИСОКА" => Color.DarkRed,
                "ВИСОКА" => Color.OrangeRed,
                "СЕРЕДНЯ" => Color.Orange,
                "НИЗЬКА" => Color.Yellow,
                _ => Color.White,
            };
        }

        private void stage4_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < stage4.Rows.Count; i++)
            {
                var row = stage4.Rows[i];

                bool success = true;

                double p = 0;
                double loss = 0;

                success = success && double.TryParse(row.Cells[3].Value.ToString(), out p);
                success = success && double.TryParse(row.Cells[4].Value.ToString(), out loss);

                if (success)
                {
                    row.Cells[5].Value = (p * loss).ToString("0.000");
                }
                else
                {
                    row.Cells[5].Value = "0.000";
                }
            }
        }
    }
}
