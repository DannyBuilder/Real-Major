namespace Real_Major
{
    partial class GridView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            searchBox = new TextBox();
            searchButton = new Button();
            filterBox = new ComboBox();
            refreshButton = new Button();
            filterBox2 = new ComboBox();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(39, 98);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(949, 624);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(464, 65);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(125, 27);
            searchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(595, 65);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // filterBox
            // 
            filterBox.FormattingEnabled = true;
            filterBox.Items.AddRange(new object[] { "Color", "Town" });
            filterBox.Location = new Point(39, 64);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(151, 28);
            filterBox.TabIndex = 3;
            filterBox.SelectedIndexChanged += filterBox_SelectedIndexChanged;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(716, 64);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(94, 29);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // filterBox2
            // 
            filterBox2.FormattingEnabled = true;
            filterBox2.Location = new Point(212, 66);
            filterBox2.Name = "filterBox2";
            filterBox2.Size = new Size(151, 28);
            filterBox2.TabIndex = 5;
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 733);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 6;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // GridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 774);
            Controls.Add(backButton);
            Controls.Add(filterBox2);
            Controls.Add(refreshButton);
            Controls.Add(filterBox);
            Controls.Add(searchButton);
            Controls.Add(searchBox);
            Controls.Add(dataGridView);
            Name = "GridView";
            Text = "GridView";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox searchBox;
        private Button searchButton;
        private ComboBox filterBox;
        private Button refreshButton;
        private ComboBox filterBox2;
        private Button backButton;
    }
}