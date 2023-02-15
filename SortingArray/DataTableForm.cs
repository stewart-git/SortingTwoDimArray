namespace SortingArray
{
    public partial class DataTableForm : Form
    {
        // Author : jack
        // Date : 01/02/2023
        // Search and sort a data table
        public DataTableForm()
        {
            InitializeComponent();
            ButtonSort.Enabled = false;
        }
        static int rows = 12;
        static int columns = 5;
        string[,] DataTable = new string[rows,columns];

         
        private void DisplayTable()
        {
            ListViewDisplay.Items.Clear();
            for (int x = 0; x < rows; x++)
            {
                ListViewItem lvi = new ListViewItem(DataTable[x, 0]);
                lvi.SubItems.Add(DataTable[x, 1]);
                lvi.SubItems.Add(DataTable[x, 2]);
                lvi.SubItems.Add(DataTable[x, 3]);
                lvi.SubItems.Add(DataTable[x, 4]);
                ListViewDisplay.Items.Add(lvi);
            }
        }

        private void ButtonFill_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    DataTable[x, y] = random.Next(10, 99).ToString();
                }
            }
            DisplayTable();
            ButtonSort.Enabled = true;
        }

        private void SortTable()
        {
            for (int x = 0; x < rows; x++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    if (string.Compare(DataTable[i, 0], DataTable[i + 1, 0]) == 1)
                    {
                        Swap(i);
                    }
                }
            }
            DisplayTable();
        }

        private void Swap(int indx)
        {
            string temp;
            for (int z = 0; z < columns; z++)
            {
                temp = DataTable[indx, z];
                DataTable[indx, z] = DataTable[indx + 1, z];
                DataTable[indx + 1, z] = temp;
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            SortTable();
            DisplayTable();
        }
    }
}