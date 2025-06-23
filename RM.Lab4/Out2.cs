namespace RM.Lab4
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class Out2 : Form
    {
        public double techLossesCoef = 0.11;
        public double costLossesCoef = 0.07;
        public double planLossesCoef = 0.09;
        public double managLossesCoef = 0.14;
        public double[] eLossesRandCoef = new[] { 0.47, 0.39, 0.28, 0.23, 0.39, 0.20, 0.59, 0.64, 0.58, 0.57 };

        private readonly DataGridView damageDataGrid;
        private readonly DataGridView techDataGrid;
        private readonly DataGridView costDataGrid;
        private readonly DataGridView planDataGrid;
        private readonly DataGridView managDataGrid;
        private readonly List<double> initCosts;

        public Out2(
            DataGridView damageDataGrid,
            DataGridView techDataGrid,
            DataGridView costDataGrid,
            DataGridView planDataGrid,
            DataGridView managDataGrid,
            List<double> initCosts)
        {
            InitializeComponent();

            this.damageDataGrid = damageDataGrid;
            this.techDataGrid = techDataGrid;
            this.costDataGrid = costDataGrid;
            this.planDataGrid = planDataGrid;
            this.managDataGrid = managDataGrid;
            this.initCosts = initCosts;
        }

        private void Out2_Load(object sender, EventArgs e)
        {
            FillLossesGrid();
        }

        private void FillLossesGrid()
        {
            lossesResDataGrid.Columns.AddRange(
                new DataGridViewTextBoxColumn() { Name = "i", HeaderText = "", Width = 30 },
                new DataGridViewTextBoxColumn()
                {
                    Name = "name",
                    HeaderText = "Множина подій",
                    Width = 500,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                },
                new DataGridViewTextBoxColumn() { Name = "count", HeaderText = "", Width = 30 },
                new DataGridViewTextBoxColumn() { Name = "initCost", HeaderText = "Вартість", Width = 100 },
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
                new DataGridViewTextBoxColumn() { Name = "addCost", HeaderText = "Додаткова вартість", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "endCost", HeaderText = "Кінцева вартість", Width = 100 },
                new DataGridViewTextBoxColumn() { Name = "costLvl", HeaderText = "Рівень" }
                );

            foreach (DataGridViewColumn col in lossesResDataGrid.Columns)
            {
                col.HeaderCell.Style.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            lossesResDataGrid.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            lossesResDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lossesResDataGrid.AllowUserToAddRows = false;
            lossesResDataGrid.AllowUserToDeleteRows = false;
            lossesResDataGrid.AllowUserToOrderColumns = false;

            var techEArr = damageDataGrid.Rows[0].Cells.Cast<DataGridViewTextBoxCell>().Skip(2).Select(x => Convert.ToInt32(x.Value)).ToArray();
            var costEArr = damageDataGrid.Rows[1].Cells.Cast<DataGridViewTextBoxCell>().Skip(2).Select(x => Convert.ToInt32(x.Value)).ToArray();
            var planEArr = damageDataGrid.Rows[2].Cells.Cast<DataGridViewTextBoxCell>().Skip(2).Select(x => Convert.ToInt32(x.Value)).ToArray();
            var managEArr = damageDataGrid.Rows[3].Cells.Cast<DataGridViewTextBoxCell>().Skip(2).Select(x => Convert.ToInt32(x.Value)).ToArray();

            // TECH
            var techArr = new List<object> { "", "Множина настання технічних ризикових подій", Helpers.CountRiskSet(techDataGrid), initCosts[1] };
            techArr.AddRange(techEArr.Cast<object>());
            techArr.Add(techEArr.Sum());

            var techRowIndex = lossesResDataGrid.Rows.Add(techArr.ToArray());

            (double techMin, double techMax) = CalcLosses(lossesResDataGrid, techDataGrid, techEArr, techLossesCoef, techRowIndex, initCosts[1]);

            // COST
            var costArr = new List<object> { "", "Множина настання вартісних ризикових подій", Helpers.CountRiskSet(costDataGrid), initCosts[2] };
            costArr.AddRange(costEArr.Cast<object>());
            costArr.Add(costEArr.Sum());

            var costRowIndex = lossesResDataGrid.Rows.Add(costArr.ToArray());

            (double costMin, double costMax) = CalcLosses(lossesResDataGrid, costDataGrid, costEArr, costLossesCoef, costRowIndex, initCosts[2]);

            // PLAN
            var planArr = new List<object> { "", "Множина настання планових ризикових подій", Helpers.CountRiskSet(planDataGrid), initCosts[3] };
            planArr.AddRange(planEArr.Cast<object>());
            planArr.Add(planEArr.Sum());

            var planRowIndex = lossesResDataGrid.Rows.Add(planArr.ToArray());

            (double planMin, double planMax) = CalcLosses(lossesResDataGrid, planDataGrid, planEArr, planLossesCoef, planRowIndex, initCosts[3]);

            // MANAG
            var managArr = new List<object> { "", "Множина настання планових ризикових подій", Helpers.CountRiskSet(managDataGrid), initCosts[4] };
            managArr.AddRange(managEArr.Cast<object>());
            managArr.Add(managEArr.Sum());

            var managRowIndex = lossesResDataGrid.Rows.Add(managArr.ToArray());

            (double managMin, double managMax) = CalcLosses(lossesResDataGrid, managDataGrid, managEArr, managLossesCoef, managRowIndex, initCosts[4]);

            double minAddCost = new[] { techMin, costMin, planMin, managMin }.Min();
            double maxAddCost = new[] { techMax, costMax, planMax, managMax }.Max();
            double mpr = (maxAddCost - minAddCost) / 3.0;

            (double start1, double end1) = (minAddCost, minAddCost + mpr);
            (double start2, double end2) = (end1, end1 + mpr);
            (double start3, double end3) = (end2, maxAddCost);

            string calculatePriorityLvl(double x)
            {
                if (x <= 0)
                {
                    return "";
                }
                else if (x >= start1 - 0.001 && x < end1)
                {
                    return "НИЗЬКИЙ";
                }
                else if (x >= start2 && x < end2)
                {
                    return "СЕРЕДНІЙ";
                }
                else if (x >= start3 && x <= end3 + 0.001)
                {
                    return "ВИСОКИЙ";
                }

                return "";
            }

            for (int i = 0; i < lossesResDataGrid.Rows.Count; i++)
            {
                var lvl = calculatePriorityLvl(Convert.ToDouble(lossesResDataGrid[lossesResDataGrid.Columns.Count - 3, i].Value));
                lossesResDataGrid[lossesResDataGrid.Columns.Count - 1, i].Value = lvl;
                var color = GetColorForLevel(lvl);
                lossesResDataGrid[lossesResDataGrid.Columns.Count - 1, i].Style.BackColor = color;

                if (color == Color.DarkRed)
                {
                    lossesResDataGrid[lossesResDataGrid.Columns.Count - 1, i].Style.ForeColor = Color.White;
                }
            }

            Helpers.FillHeaderRowColor(lossesResDataGrid, new[] { techRowIndex, costRowIndex, planRowIndex, managRowIndex });
        }

        private (double min, double max) CalcLosses(DataGridView lossesResDataGrid, DataGridView inputDataGrid, int[] ocinkaEArr, double techCoef, int setRowIndex, double initCost)
        {
            var rand = new Random();

            var rows = inputDataGrid.Rows.Cast<DataGridViewRow>().Where(r => Convert.ToInt32(r.Cells[2].Value) != 0).ToList();

            if (!rows.Any())
            {
                return (0, 0);
            }

            var randLeftCoefs = rows.Select(_ => techCoef + rand.NextDouble() * techCoef).ToArray();

            var temp = rows.Select((r, i) =>
            {
                var cost = initCost * (randLeftCoefs[i] / randLeftCoefs.Sum());
                var eArr = eLossesRandCoef.Select(x => randLeftCoefs[i] + rand.NextDouble() * x).ToArray();
                var eArrAvg = eArr.Average() * cost;

                var eCoefArr = eArr.Select((x, i) => x * ocinkaEArr[i]);
                var addCost = eCoefArr.Sum() / ocinkaEArr.Sum() * cost;
                var endCost = addCost + cost;

                var row = new List<object>();
                row.Add(i + 1);
                row.Add(r.Cells[1].Value);
                row.Add(r.Cells[2].Value);
                row.Add(cost);
                row.AddRange(eArr.Cast<object>());
                row.Add(eArrAvg);
                row.AddRange(eCoefArr.Cast<object>());
                row.Add(addCost);
                row.Add(endCost);

                lossesResDataGrid.Rows.Add(Helpers.ConvertG(row));

                return new List<double>(eCoefArr) { addCost, endCost };
            }).ToList();

            var resses = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                var sum = 0.0;
                for (int j = 0; j < temp.Count; j++)
                {
                    sum += temp[j][i];
                    if (i == 10)
                    {
                        resses.Add(temp[j][i]);
                    }
                }

                var res = i < 10 ? sum / temp[0].Count : sum;

                lossesResDataGrid[i + 15, setRowIndex].Value = res.ToString("0.000");
            }

            return (resses.Min(), resses.Max());
        }

        private static Color GetColorForLevel(string level)
        {
            return level switch
            {
                "ВИСОКИЙ" => Color.DarkRed,
                "СЕРЕДНІЙ" => Color.Orange,
                "НИЗЬКИЙ" => Color.Yellow,
                _ => Color.White,
            };
        }
    }
}
