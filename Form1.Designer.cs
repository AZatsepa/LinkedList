
namespace RList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputNumber = new System.Windows.Forms.TextBox();
            this.buildListButton = new System.Windows.Forms.Button();
            this.rlistValues = new System.Windows.Forms.Label();
            this.RListValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.copyListButton = new System.Windows.Forms.Button();
            this.copyOfRList = new System.Windows.Forms.Label();
            this.deleteEvensButton = new System.Windows.Forms.Button();
            this.addFirstButton = new System.Windows.Forms.Button();
            this.addFirstTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addLastTextBox = new System.Windows.Forms.TextBox();
            this.addLastButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.removeElementsTextBox = new System.Windows.Forms.TextBox();
            this.removeElementsByValueButton = new System.Windows.Forms.Button();
            this.printToColumnButton = new System.Windows.Forms.Button();
            this.printToColumnLabel = new System.Windows.Forms.Label();
            this.sortByAscButton = new System.Windows.Forms.Button();
            this.calculateSumButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.firstIndexTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lastIndexTextBox = new System.Windows.Forms.TextBox();
            this.clearListButton = new System.Windows.Forms.Button();
            this.clearCopyButton = new System.Windows.Forms.Button();
            this.copyOfListLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputNumber
            // 
            this.InputNumber.Location = new System.Drawing.Point(319, 13);
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(190, 23);
            this.InputNumber.TabIndex = 1;
            this.InputNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputNumber_KeyPress);
            // 
            // buildListButton
            // 
            this.buildListButton.Location = new System.Drawing.Point(548, 13);
            this.buildListButton.Name = "buildListButton";
            this.buildListButton.Size = new System.Drawing.Size(190, 23);
            this.buildListButton.TabIndex = 2;
            this.buildListButton.Text = "Побудувати список";
            this.buildListButton.UseVisualStyleBackColor = true;
            this.buildListButton.Click += new System.EventHandler(this.AddElement_Click);
            // 
            // rlistValues
            // 
            this.rlistValues.AutoSize = true;
            this.rlistValues.Location = new System.Drawing.Point(82, 41);
            this.rlistValues.Name = "rlistValues";
            this.rlistValues.Size = new System.Drawing.Size(0, 15);
            this.rlistValues.TabIndex = 3;
            // 
            // RListValue
            // 
            this.RListValue.AutoSize = true;
            this.RListValue.Location = new System.Drawing.Point(13, 41);
            this.RListValue.Name = "RListValue";
            this.RListValue.Size = new System.Drawing.Size(51, 15);
            this.RListValue.TabIndex = 4;
            this.RListValue.Text = "Список:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Копія списку:";
            // 
            // copyListButton
            // 
            this.copyListButton.Location = new System.Drawing.Point(548, 55);
            this.copyListButton.Name = "copyListButton";
            this.copyListButton.Size = new System.Drawing.Size(190, 23);
            this.copyListButton.TabIndex = 6;
            this.copyListButton.Text = "Копіювати список";
            this.copyListButton.UseVisualStyleBackColor = true;
            this.copyListButton.Click += new System.EventHandler(this.CopyListButton_Click);
            // 
            // copyOfRList
            // 
            this.copyOfRList.AutoSize = true;
            this.copyOfRList.Location = new System.Drawing.Point(284, 233);
            this.copyOfRList.Name = "copyOfRList";
            this.copyOfRList.Size = new System.Drawing.Size(0, 15);
            this.copyOfRList.TabIndex = 7;
            // 
            // deleteEvensButton
            // 
            this.deleteEvensButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteEvensButton.Location = new System.Drawing.Point(548, 265);
            this.deleteEvensButton.Name = "deleteEvensButton";
            this.deleteEvensButton.Size = new System.Drawing.Size(190, 25);
            this.deleteEvensButton.TabIndex = 8;
            this.deleteEvensButton.Text = "Видалити парні за порядком";
            this.deleteEvensButton.UseVisualStyleBackColor = true;
            this.deleteEvensButton.Click += new System.EventHandler(this.DeleteEvensButton_Click);
            // 
            // addFirstButton
            // 
            this.addFirstButton.Location = new System.Drawing.Point(548, 132);
            this.addFirstButton.Name = "addFirstButton";
            this.addFirstButton.Size = new System.Drawing.Size(190, 23);
            this.addFirstButton.TabIndex = 9;
            this.addFirstButton.Text = "Додати елемент";
            this.addFirstButton.UseVisualStyleBackColor = true;
            this.addFirstButton.Click += new System.EventHandler(this.AddFirstButton_Click);
            // 
            // addFirstTextBox
            // 
            this.addFirstTextBox.Location = new System.Drawing.Point(319, 132);
            this.addFirstTextBox.Name = "addFirstTextBox";
            this.addFirstTextBox.Size = new System.Drawing.Size(190, 23);
            this.addFirstTextBox.TabIndex = 10;
            this.addFirstTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddFirstTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введіть елементи списку через кому без пробілів:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Додати елемент у початок списку:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Додати елемент у кінець списку:";
            // 
            // addLastTextBox
            // 
            this.addLastTextBox.Location = new System.Drawing.Point(319, 186);
            this.addLastTextBox.Name = "addLastTextBox";
            this.addLastTextBox.Size = new System.Drawing.Size(190, 23);
            this.addLastTextBox.TabIndex = 14;
            // 
            // addLastButton
            // 
            this.addLastButton.Location = new System.Drawing.Point(548, 186);
            this.addLastButton.Name = "addLastButton";
            this.addLastButton.Size = new System.Drawing.Size(190, 23);
            this.addLastButton.TabIndex = 15;
            this.addLastButton.Text = "Додати елемент";
            this.addLastButton.UseVisualStyleBackColor = true;
            this.addLastButton.Click += new System.EventHandler(this.AddLastButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Видалити всі елементи зі значенням:";
            // 
            // removeElementsTextBox
            // 
            this.removeElementsTextBox.Location = new System.Drawing.Point(319, 225);
            this.removeElementsTextBox.Name = "removeElementsTextBox";
            this.removeElementsTextBox.Size = new System.Drawing.Size(190, 23);
            this.removeElementsTextBox.TabIndex = 17;
            this.removeElementsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RemoveElementsTextBox_KeyPress);
            // 
            // removeElementsByValueButton
            // 
            this.removeElementsByValueButton.Location = new System.Drawing.Point(548, 225);
            this.removeElementsByValueButton.Name = "removeElementsByValueButton";
            this.removeElementsByValueButton.Size = new System.Drawing.Size(190, 23);
            this.removeElementsByValueButton.TabIndex = 18;
            this.removeElementsByValueButton.Text = "Видалити елементи";
            this.removeElementsByValueButton.UseVisualStyleBackColor = true;
            this.removeElementsByValueButton.Click += new System.EventHandler(this.RemoveElementsByValueButton_Click);
            // 
            // printToColumnButton
            // 
            this.printToColumnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printToColumnButton.Location = new System.Drawing.Point(548, 476);
            this.printToColumnButton.Name = "printToColumnButton";
            this.printToColumnButton.Size = new System.Drawing.Size(190, 25);
            this.printToColumnButton.TabIndex = 19;
            this.printToColumnButton.Text = "Роздрукувати у стовпчик";
            this.printToColumnButton.UseVisualStyleBackColor = true;
            this.printToColumnButton.Click += new System.EventHandler(this.PrintToColumnButton_Click);
            // 
            // printToColumnLabel
            // 
            this.printToColumnLabel.AutoSize = true;
            this.printToColumnLabel.Location = new System.Drawing.Point(331, 397);
            this.printToColumnLabel.Name = "printToColumnLabel";
            this.printToColumnLabel.Size = new System.Drawing.Size(0, 15);
            this.printToColumnLabel.TabIndex = 20;
            // 
            // sortByAscButton
            // 
            this.sortByAscButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sortByAscButton.Location = new System.Drawing.Point(548, 306);
            this.sortByAscButton.Name = "sortByAscButton";
            this.sortByAscButton.Size = new System.Drawing.Size(190, 25);
            this.sortByAscButton.TabIndex = 21;
            this.sortByAscButton.Text = "Сортувати за зростанням";
            this.sortByAscButton.UseVisualStyleBackColor = true;
            this.sortByAscButton.Click += new System.EventHandler(this.SortByAscButton_Click);
            // 
            // calculateSumButton
            // 
            this.calculateSumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calculateSumButton.Location = new System.Drawing.Point(548, 337);
            this.calculateSumButton.Name = "calculateSumButton";
            this.calculateSumButton.Size = new System.Drawing.Size(190, 25);
            this.calculateSumButton.TabIndex = 22;
            this.calculateSumButton.Text = "Знайти суму";
            this.calculateSumButton.UseVisualStyleBackColor = true;
            this.calculateSumButton.Click += new System.EventHandler(this.CalculateSumButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Знайти суму елементів між елементами з номером ";
            // 
            // firstIndexTextBox
            // 
            this.firstIndexTextBox.Location = new System.Drawing.Point(331, 337);
            this.firstIndexTextBox.Name = "firstIndexTextBox";
            this.firstIndexTextBox.Size = new System.Drawing.Size(37, 23);
            this.firstIndexTextBox.TabIndex = 24;
            this.firstIndexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstIndexTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "та";
            // 
            // lastIndexTextBox
            // 
            this.lastIndexTextBox.Location = new System.Drawing.Point(443, 337);
            this.lastIndexTextBox.Name = "lastIndexTextBox";
            this.lastIndexTextBox.Size = new System.Drawing.Size(37, 23);
            this.lastIndexTextBox.TabIndex = 26;
            this.lastIndexTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastIndexTextBox_KeyPress);
            // 
            // clearListButton
            // 
            this.clearListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearListButton.Location = new System.Drawing.Point(757, 13);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(96, 25);
            this.clearListButton.TabIndex = 27;
            this.clearListButton.Text = "Очистити";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // clearCopyButton
            // 
            this.clearCopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearCopyButton.Location = new System.Drawing.Point(757, 55);
            this.clearCopyButton.Name = "clearCopyButton";
            this.clearCopyButton.Size = new System.Drawing.Size(96, 25);
            this.clearCopyButton.TabIndex = 28;
            this.clearCopyButton.Text = "Очистити";
            this.clearCopyButton.UseVisualStyleBackColor = true;
            this.clearCopyButton.Click += new System.EventHandler(this.ClearCopyButton_Click);
            // 
            // copyOfListLabel
            // 
            this.copyOfListLabel.AutoSize = true;
            this.copyOfListLabel.Location = new System.Drawing.Point(112, 94);
            this.copyOfListLabel.Name = "copyOfListLabel";
            this.copyOfListLabel.Size = new System.Drawing.Size(0, 15);
            this.copyOfListLabel.TabIndex = 29;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(548, 374);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(39, 15);
            this.sumLabel.TabIndex = 30;
            this.sumLabel.Text = "Сума:";
            // 
            // sumResultLabel
            // 
            this.sumResultLabel.AutoSize = true;
            this.sumResultLabel.Location = new System.Drawing.Point(602, 374);
            this.sumResultLabel.Name = "sumResultLabel";
            this.sumResultLabel.Size = new System.Drawing.Size(0, 15);
            this.sumResultLabel.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 615);
            this.Controls.Add(this.sumResultLabel);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.copyOfListLabel);
            this.Controls.Add(this.clearCopyButton);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.lastIndexTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.firstIndexTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculateSumButton);
            this.Controls.Add(this.sortByAscButton);
            this.Controls.Add(this.printToColumnLabel);
            this.Controls.Add(this.printToColumnButton);
            this.Controls.Add(this.removeElementsByValueButton);
            this.Controls.Add(this.removeElementsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addLastButton);
            this.Controls.Add(this.addLastTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addFirstTextBox);
            this.Controls.Add(this.addFirstButton);
            this.Controls.Add(this.deleteEvensButton);
            this.Controls.Add(this.copyOfRList);
            this.Controls.Add(this.copyListButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RListValue);
            this.Controls.Add(this.rlistValues);
            this.Controls.Add(this.buildListButton);
            this.Controls.Add(this.InputNumber);
            this.Name = "Form1";
            this.Text = "Список:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNumber;
        private System.Windows.Forms.Button buildListButton;
        private System.Windows.Forms.Label rlistValues;
        private System.Windows.Forms.Label RListValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button copyListButton;
        private System.Windows.Forms.Label copyOfRList;
        private System.Windows.Forms.Button deleteEvensButton;
        private System.Windows.Forms.Button addFirstButton;
        private System.Windows.Forms.TextBox addFirstTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addLastTextBox;
        private System.Windows.Forms.Button addLastButton;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.TextBox removeElementsTextBox;
        private System.Windows.Forms.Button removeElementsByValueButton;
        private System.Windows.Forms.Button printToColumnButton;
        private System.Windows.Forms.Label printToColumnLabel;
        private System.Windows.Forms.Button sortByAscButton;
        private System.Windows.Forms.Button calculateSumButton;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.TextBox firstIndexTextBox;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.TextBox lastIndexTextBox;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.Button clearCopyButton;
        private System.Windows.Forms.Label copyOfListLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label sumResultLabel;
    }
}

