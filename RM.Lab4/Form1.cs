namespace RM.Lab4
{
    public partial class Form1 : Form
    {
        private readonly List<double> initCosts = new() { 1430.0, 350.0, 240.0, 260.0 };

        public Form1()
        {
            InitializeComponent();

            #region Технічні

            techDataGrid.Rows.Add("t(r)1", "затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ", 1); // 1
            techDataGrid.Rows.Add("t(r)2", "затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ", 1); // 2
            techDataGrid.Rows.Add("t(r)3", "небажання команди виконавців ПЗ використовувати інструментальні засоби для підтримки процесу розроблення ПЗ", 1); // 3
            techDataGrid.Rows.Add("t(r)4", "відмова команди виконавців від CASE-засобів розроблення ПЗ", 1); // 4
            techDataGrid.Rows.Add("t(r)5", "формування запитів на більш потужні інструментальні засоби розроблення ПЗ", 1); // 5
            techDataGrid.Rows.Add("t(r)6", "недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ", 1); // 6
            techDataGrid.Rows.Add("t(r)7", "програмні компоненти, які використовують повторно в ПЗ, мають дефекти та обмежені функціональні можливості", 1); // 7
            techDataGrid.Rows.Add("t(r)8", "неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ", 1); // 8
            techDataGrid.Rows.Add("t(r)9", "неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ", 1); // 9
            techDataGrid.Rows.Add("t(r)10", "швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів", 1); // 10
            techDataGrid.Rows.Add("t(r)11", "поява дефектних системних компонент, які використовують для розроблення ПЗ", 1); // 11

            #endregion

            #region Вартісні

            costDataGrid.Rows.Add("c(r)1", "недооцінювання витрат на реалізацію програмного проекту (надмірно низька вартість)", 1); // 1
            costDataGrid.Rows.Add("c(r)2", "переоцінювання витрат на реалізацію програмного проекту (надмірно висока вартість)", 1); // 2
            costDataGrid.Rows.Add("c(r)3", "фінансові ускладнення у компанії-замовника ПЗ", 1); // 3
            costDataGrid.Rows.Add("c(r)4", "фінансові ускладнення у компанії-розробника ПЗ", 1); // 4
            costDataGrid.Rows.Add("c(r)5", "збільшення бюджету програмного проекта з ініціативи компанії-розробника ПЗ під час його реалізації", 1); // 5
            costDataGrid.Rows.Add("c(r)6", "збільшення бюджету програмного проекта з ініціативи компанії-розробника ПЗ під час його реалізації", 1); // 6
            costDataGrid.Rows.Add("c(r)7", "висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ", 1); // 7
            costDataGrid.Rows.Add("c(r)8", "реорганізація структурних підрозділів у компанії-замовника ПЗ", 1); // 8
            costDataGrid.Rows.Add("c(r)9", "реорганізація команди виконавців у компанії-розробника ПЗ", 1); // 9

            #endregion

            #region Планові

            planDataGrid.Rows.Add("p(r)1", "зміни графіка виконання робіт з боку замовника чи виконавця", 1); // 1
            planDataGrid.Rows.Add("p(r)2", "порушення графіка виконання робіт у компанії-розробника ПЗ", 1); // 2
            planDataGrid.Rows.Add("p(r)3", "потреба зміни користувацьких вимог до ПЗ з боку компанії-замовника ПЗ", 1); // 3
            planDataGrid.Rows.Add("p(r)4", "потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ", 1); // 4
            planDataGrid.Rows.Add("p(r)5", "потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ", 1); // 5
            planDataGrid.Rows.Add("p(r)6", "недооцінювання тривалості етапів реалізації програмного проекту з боку компанії - розробника ПЗ", 1); // 6
            planDataGrid.Rows.Add("p(r)7", "переоцінювання тривалості етапів реалізації програмного проекту", 1); // 7
            planDataGrid.Rows.Add("p(r)8", "остаточний розмір ПЗ перевищує заплановані його характеристики", 1); // 8
            planDataGrid.Rows.Add("p(r)9", "остаточний розмір ПЗ значно менший за планові його характеристики", 1); // 9
            planDataGrid.Rows.Add("p(r)10", "поява на ринку аналогічного ПЗ до виходу замовленого", 1); // 10
            planDataGrid.Rows.Add("p(r)11", "поява на ринку більш конкурентоздатного ПЗ", 1); // 11

            #endregion

            #region Реалізації

            managDataGrid.Rows.Add("m(r)1", "низький моральний стан персоналу команди виконавців ПЗ", 1); // 1
            managDataGrid.Rows.Add("m(r)2", "низька взаємодія між членами команди виконавців ПЗ", 1); // 2
            managDataGrid.Rows.Add("m(r)3", "пасивність керівника (менеджера) програмного проекту", 1); // 3
            managDataGrid.Rows.Add("m(r)4", "недостатня компетентність керівника (менеджера) програмного проекту", 1); // 4
            managDataGrid.Rows.Add("m(r)5", "незадоволеність замовника результатами етапів реалізації програмного проекту", 1); // 5
            managDataGrid.Rows.Add("m(r)6", "недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем", 1); // 6
            managDataGrid.Rows.Add("m(r)7", "хвороба провідного виконавця в найкритичніший момент розроблення ПЗ", 1); // 7
            managDataGrid.Rows.Add("m(r)8", "одночасна хвороба декількох виконавців підчас розроблення ПЗ", 1); // 8
            managDataGrid.Rows.Add("m(r)9", "неможливість організації необхідного навчання персоналу команди виконавців ПЗ", 1); // 9
            managDataGrid.Rows.Add("m(r)10", "зміна пріоритетів у процесі управління програмним проектом", 1); // 10
            managDataGrid.Rows.Add("m(r)11", "недооцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ", 1); // 11
            managDataGrid.Rows.Add("m(r)12", "переоцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ", 1); // 12
            managDataGrid.Rows.Add("m(r)13", "надмірне документування результатів на етапах реалізації програмного проекту", 1); // 13
            managDataGrid.Rows.Add("m(r)14", "недостатнє документування результатів на етапах реалізації програмного проекту", 1); // 14
            managDataGrid.Rows.Add("m(r)15", "нереалістичне прогнозування результатів на етапах реалізації програмного проекту", 1); // 15
            managDataGrid.Rows.Add("m(r)16", "недостатній професійний рівень представників від компанії-замовника ПЗ", 1); // 16

            #endregion

            #region Коефіцієнти

            probabilityDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "col1",
                HeaderText = "Множина подій",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            probabilityDataGrid.Columns.Add("col2", "Кількість");
            probabilityDataGrid.Columns.AddRange(Enumerable.Range(1, 10).Select(x => new DataGridViewTextBoxColumn() { Name = $"col{x + 2}", HeaderText = x.ToString(), Width = 40 }).ToArray());
            probabilityDataGrid.Rows.Add("Множина настання технічних ризикових подій", CountRiskSet(techDataGrid), 10, 6, 6, 6, 10, 8, 8, 8, 7, 10);
            probabilityDataGrid.Rows.Add("Множина настання вартісних ризикових подій", CountRiskSet(costDataGrid), 9, 5, 8, 9, 10, 5, 6, 8, 7, 9);
            probabilityDataGrid.Rows.Add("Множина настання планових ризикових подій", CountRiskSet(planDataGrid), 8, 9, 8, 6, 10, 7, 6, 9, 8, 6);
            probabilityDataGrid.Rows.Add("Множина настання ризикових подій реалізації процесу управління програмним проектом", CountRiskSet(managDataGrid), 10, 6, 6, 8, 10, 9, 6, 8, 6, 10);

            damageDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "col1",
                HeaderText = "Множина подій",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            damageDataGrid.Columns.Add("col2", "Кількість");
            damageDataGrid.Columns.AddRange(Enumerable.Range(1, 10).Select(x => new DataGridViewTextBoxColumn() { Name = $"col{x + 2}", HeaderText = x.ToString(), Width = 40 }).ToArray());
            damageDataGrid.Rows.Add("Множина настання технічних ризикових подій", CountRiskSet(techDataGrid), 7, 6, 6, 6, 8, 8, 9, 8, 7, 10);
            damageDataGrid.Rows.Add("Множина настання вартісних ризикових подій", CountRiskSet(costDataGrid), 9, 5, 8, 10, 8, 5, 5, 8, 7, 9);
            damageDataGrid.Rows.Add("Множина настання планових ризикових подій", CountRiskSet(planDataGrid), 8, 9, 8, 6, 4, 7, 6, 10, 8, 6);
            damageDataGrid.Rows.Add("Множина настання ризикових подій реалізації процесу управління програмним проектом", CountRiskSet(managDataGrid), 10, 6, 6, 4, 6, 9, 6, 10, 6, 10);

            #endregion

            #region Розподіли

            costDistributionDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "col1",
                HeaderText = "",
                Width = 300
            });
            costDistributionDataGrid.Columns.Add("col2", "");
            costDistributionDataGrid.Columns.Add("col3", "1");
            costDistributionDataGrid.Columns.Add("col4", "2");
            costDistributionDataGrid.Columns.Add("col5", "3");
            costDistributionDataGrid.Columns.Add("col6", "4");

            initCosts.Add(initCosts[0] - initCosts.Skip(1).Sum());
            costDistributionDataGrid.Rows.Add("Початкова вартість реалізації проекту", initCosts[0], initCosts[1], initCosts[2], initCosts[3], initCosts[4]);

            #endregion

            Helpers.ChangeEditModeToOnPropertyChanged(techDataGrid);
            Helpers.ChangeEditModeToOnPropertyChanged(costDataGrid);
            Helpers.ChangeEditModeToOnPropertyChanged(planDataGrid);
            Helpers.ChangeEditModeToOnPropertyChanged(managDataGrid);
        }

        private void RecalcCounts(DataGridView dataGridView)
        {
            var rows = dataGridView.Rows.Cast<DataGridViewRow>();

            if (!rows.Any() || rows.Any(r => r.Cells.Count < 2))
            {
                return;
            }

            dataGridView.Rows[0].Cells[1].Value = CountRiskSet(techDataGrid);
            dataGridView.Rows[1].Cells[1].Value = CountRiskSet(costDataGrid);
            dataGridView.Rows[2].Cells[1].Value = CountRiskSet(planDataGrid);
            dataGridView.Rows[3].Cells[1].Value = CountRiskSet(managDataGrid);
        }

        private void CalcProb_Click(object sender, EventArgs e)
        {
            var form = new Out1(probabilityDataGrid, techDataGrid, costDataGrid, planDataGrid, managDataGrid);

            form.ShowDialog(this);
        }

        private void CalcCoef_Click(object sender, EventArgs e)
        {
            var form = new Out2(damageDataGrid, techDataGrid, costDataGrid, planDataGrid, managDataGrid, initCosts);

            form.ShowDialog(this);
        }

        private static int CountRiskSet(DataGridView table)
        {
            return table.Rows.Cast<DataGridViewRow>().Count(r => Convert.ToInt32(r.Cells[2].Value) != 0);
        }

        private void techDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RecalcCounts(probabilityDataGrid);
            RecalcCounts(damageDataGrid);
        }

        private void managDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RecalcCounts(probabilityDataGrid);
            RecalcCounts(damageDataGrid);
        }

        private void planDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RecalcCounts(probabilityDataGrid);
            RecalcCounts(damageDataGrid);
        }

        private void costDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RecalcCounts(probabilityDataGrid);
            RecalcCounts(damageDataGrid);
        }
    }
}
