using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quicksort
{
    public partial class formQuickSort : Form
    {
        public formQuickSort()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            tbSorted.Clear();
            List<int> arrayToSort = tbUnsorted.Lines.Select(num => Int32.Parse(num)).ToList();
            Sorting.Quicksort(arrayToSort, 0, arrayToSort.Count - 1);
            arrayToSort.ForEach(num => tbSorted.AppendText($"{num}\n"));
        }
    }
}
