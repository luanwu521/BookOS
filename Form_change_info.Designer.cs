
namespace BookOS
{
    partial class Form_change_info
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
            this.dataGridView_book_list = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_book_list
            // 
            this.dataGridView_book_list.AllowUserToAddRows = false;
            this.dataGridView_book_list.AllowUserToDeleteRows = false;
            this.dataGridView_book_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_book_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.book_id,
            this.book_name,
            this.book_author,
            this.book_count});
            this.dataGridView_book_list.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_book_list.MultiSelect = false;
            this.dataGridView_book_list.Name = "dataGridView_book_list";
            this.dataGridView_book_list.RowHeadersWidth = 51;
            this.dataGridView_book_list.RowTemplate.Height = 27;
            this.dataGridView_book_list.Size = new System.Drawing.Size(685, 520);
            this.dataGridView_book_list.TabIndex = 2;
            this.dataGridView_book_list.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_book_list_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "序号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 75;
            // 
            // book_id
            // 
            this.book_id.HeaderText = "图书id";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Width = 125;
            // 
            // book_name
            // 
            this.book_name.HeaderText = "图书名称";
            this.book_name.MinimumWidth = 6;
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Width = 150;
            // 
            // book_author
            // 
            this.book_author.HeaderText = "图书作者";
            this.book_author.MinimumWidth = 6;
            this.book_author.Name = "book_author";
            this.book_author.ReadOnly = true;
            this.book_author.Width = 150;
            // 
            // book_count
            // 
            this.book_count.HeaderText = "图书库存";
            this.book_count.MinimumWidth = 6;
            this.book_count.Name = "book_count";
            this.book_count.ReadOnly = true;
            this.book_count.Width = 125;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_save.Location = new System.Drawing.Point(762, 247);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(142, 61);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "保存修改数据";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(720, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 135);
            this.label1.TabIndex = 4;
            this.label1.Text = "双击单元格即可修改\r\n修改完后点击下方按钮\r\n库存请输入整数\r\n\r\n\r\n";
            // 
            // Form_change_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 537);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView_book_list);
            this.Controls.Add(this.label1);
            this.Name = "Form_change_info";
            this.Text = "更改图书信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_book_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_count;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
    }
}