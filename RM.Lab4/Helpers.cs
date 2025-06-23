namespace RM.Lab4
{
    public static class Helpers
    {
        public static object[] ConvertG(List<object> arr)
        {
            return arr.Select((x, i) =>
            {
                if (i < 3)
                {
                    return x;
                }

                return double.TryParse(x.ToString(), out var d) ? d.ToString("0.000") : x;
            }).ToArray();
        }

        public static int CountRiskSet(DataGridView table)
        {
            return table.Rows.Cast<DataGridViewRow>().Count(r =>
            {
                return Convert.ToInt32(r.Cells[2].Value) != 0;
            });
        }

        public static void FillHeaderRowColor(DataGridView dataGridView, int[] rowIds)
        {
            foreach (var rowId in rowIds)
            {
                dataGridView.Rows[rowId].DefaultCellStyle.BackColor = Color.DarkGray;
            }
        }

        public static void ChangeEditModeToOnPropertyChanged(DataGridView gv)
        {
            gv.CurrentCellDirtyStateChanged += (sender, args) =>
            {
                gv.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (gv.CurrentCell == null)
                    return;
                if (gv.CurrentCell.EditType != typeof(DataGridViewTextBoxEditingControl))
                    return;
                gv.BeginEdit(false);
                var textBox = (TextBox)gv.EditingControl;
                textBox.SelectionStart = textBox.Text.Length;
            };
        }
    }
}
