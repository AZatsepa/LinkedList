using System;
using System.Windows.Forms;

namespace RList
{
    public partial class Form1 : Form
    {
        private LinkedList linkedList = new LinkedList();
        private LinkedList copyOfLinkedList = null;
        public Form1()
        {
            InitializeComponent();
        }


        private void AddElement_Click(object sender, EventArgs e)
        {
            BuildList();
            PrintList();
        }

        private void PrintList()
        {
            rlistValues.Text = linkedList.Print();
        }

        private void PrintCopyOfList()
        {
            if (copyOfLinkedList != null)
                copyOfListLabel.Text = copyOfLinkedList.Print();
        }

        private void BuildList()
        {
            string[] elements = InputNumber.Text.Split(',');

            for (int i = 0; i < elements.Length; i++)
            {
                int n = Convert.ToInt32(elements[i]);
                linkedList.Push(n);
            }
            InputNumber.Text = "";
        }

        private void CopyListButton_Click(object sender, EventArgs e)
        {
            copyOfLinkedList = new LinkedList(linkedList);
            PrintCopyOfList();
        }

        private void AddFirstButton_Click(object sender, EventArgs e)
        {
            int newValue = Convert.ToInt32(addFirstTextBox.Text);
            linkedList.AddFirst(newValue);
            PrintList();
        }

        private void AddLastButton_Click(object sender, EventArgs e)
        {
            int newValue = Convert.ToInt32(addLastTextBox.Text);
            linkedList.Push(newValue);
            PrintList();
        }

        private void RemoveElementsByValueButton_Click(object sender, EventArgs e)
        {
            int valueForDelete = Convert.ToInt32(removeElementsTextBox.Text);
            linkedList.DeleteByValue(valueForDelete);
            PrintList();
        }

        private void DeleteEvensButton_Click(object sender, EventArgs e)
        {
            linkedList.DeleteEvens();
            PrintList();
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            linkedList.Clear();
            PrintList();
            ClearListInputs();
        }

        private void ClearCopyButton_Click(object sender, EventArgs e)
        {
            if (copyOfLinkedList == null)
                return;

                copyOfLinkedList.Clear();
                PrintCopyOfList();
        }

        private void SortByAscButton_Click(object sender, EventArgs e)
        {
            linkedList.SortByAsc();
            PrintList();
        }

        private void CalculateSumButton_Click(object sender, EventArgs e)
        {
            int firstIndex = Convert.ToInt32(firstIndexTextBox.Text);
            int lastIndex = Convert.ToInt32(lastIndexTextBox.Text);
            sumResultLabel.Text =  linkedList.Sum(firstIndex, lastIndex).ToString();
        }

        private void PrintToColumnButton_Click(object sender, EventArgs e)
        {
            printToColumnLabel.Text = linkedList.PrintColumn();
        }

        private void ClearListInputs()
        {
            sumResultLabel.Text = "";
            rlistValues.Text = "";
            sumResultLabel.Text = "";
            firstIndexTextBox.Text = "";
            lastIndexTextBox.Text = "";
            addFirstTextBox.Text = "";
            addLastTextBox.Text = "";
            removeElementsTextBox.Text = "";
        }

        private void AddFirstTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumbersAndBackSpaceOnly(e);
        }

        private void FirstIndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumbersAndBackSpaceOnly(e);
        }

        private void AllowNumbersAndBackSpaceOnly(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != '-')
                e.Handled = true;
        }

        private void AllowNumbersCommaAndBackSpaceOnly(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number <= 47 || number >= 58) && number != 8 && number != 44 && number != '-')
                e.Handled = true;
        }

        private void LastIndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumbersAndBackSpaceOnly(e);
        }

        private void RemoveElementsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumbersAndBackSpaceOnly(e);
        }

        private void InputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumbersCommaAndBackSpaceOnly(e);
        }
    }
}
