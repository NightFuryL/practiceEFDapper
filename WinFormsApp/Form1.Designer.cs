namespace WinFormsApp
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
            txtId = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonSearch = new Button();
            buttonDelete = new Button();
            buttonShowAll = new Button();
            BookBox = new ListBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(73, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(715, 27);
            txtId.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(73, 35);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(715, 27);
            txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(73, 69);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(715, 27);
            txtAuthor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 3;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Author";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 102);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(776, 29);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(12, 172);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(776, 29);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(12, 207);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(776, 29);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 242);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(776, 29);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(12, 137);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(776, 29);
            buttonShowAll.TabIndex = 10;
            buttonShowAll.Text = "ShowAll";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // BookBox
            // 
            BookBox.FormattingEnabled = true;
            BookBox.Location = new Point(12, 277);
            BookBox.Name = "BookBox";
            BookBox.Size = new Size(776, 164);
            BookBox.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookBox);
            Controls.Add(buttonShowAll);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonSearch;
        private Button buttonDelete;
        private Button buttonShowAll;
        private ListBox BookBox;
    }
}
