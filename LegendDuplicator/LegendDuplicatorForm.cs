using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GrimshawRibbon.Utilities;

namespace LegendDuplicator
{
    public partial class LegendDuplicatorForm : Form
    {
        InputData inputData;
        DataGridViewSelectedRowCollection selected;

        public LegendDuplicatorForm(InputData inputData)
        {
            this.inputData = inputData;

            InitializeComponent();

            // populate data grid view with sheets
            SortableBindingList<SheetWrapper> sheetBindingList = new SortableBindingList<SheetWrapper>();
            foreach (SheetWrapper sw in inputData.Sheets)
            {
                sheetBindingList.Add(sw);
            }
            dgvSheets.AutoGenerateColumns = false;
            dgvSheets.DataSource = sheetBindingList;

        }

        private void dgvSheets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSheets_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected = dgvSheets.SelectedRows;
        }

        private void dgvSheets_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewCell cell = dgv.CurrentCell;

            if (cell.RowIndex >= 0 && cell.ColumnIndex == 2) // ColumnIndex is checkbox column
            {
                // if checkbox value changed, copy its value to all selected rows
                bool checkValue = false;
                if (dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].EditedFormattedValue != null 
                    && dgv.Rows[cell.RowIndex].Cells[cell.ColumnIndex].EditedFormattedValue.Equals(true))
                    checkValue = true;

                for (int i = 0; i < selected.Count; i++)
                    dgv.Rows[selected[i].Index].Cells[2].Value = checkValue; // checkbox column index
            }
            dgvSheets.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            inputData.ProcessSelection();
            this.Close();
        }
    }
}
