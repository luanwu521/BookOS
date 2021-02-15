
namespace BookOS
{
    partial class Form_borrow
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
            this.button_renew_list = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.book_name});
            this.dataGridView_book_list.Location = new System.Drawing.Point(-5, 1);
            this.dataGridView_book_list.Name = "dataGridView_book_list";
            this.dataGridView_book_list.ReadOnly = true;
            this.dataGridView_book_list.RowHeadersWidth = 51;
            this.dataGridView_book_list.RowTemplate.Height = 27;
            this.dataGridView_book_list.Size = new System.Drawing.Size(452, 570);
            this.dataGridView_book_list.TabIndex = 1;
            // 
            // button_renew_list
            // 
            this.button_renew_list.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_renew_list.Location = new System.Drawing.Point(478, 182);
            this.button_renew_list.Name = "button_renew_list";
            this.button_renew_list.Size = new System.Drawing.Size(140, 60);
            this.button_renew_list.TabIndex = 2;
            this.button_renew_list.Text = "更新借阅列表";
            this.button_renew_list.UseVisualStyleBackColor = true;
            this.button_renew_list.Click += new System.EventHandler(this.button_renew_list_Click);
            // 
            // button_return
            // 
            this.button_return.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_return.Location = new System.Drawing.Point(478, 298);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(140, 60);
            this.button_return.TabIndex = 3;
            this.button_return.Text = "归还选中图书";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // id
            // 
            this.id.HeaderText = "标识";
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
            // Form_borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 583);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_renew_list);
            this.Controls.Add(this.dataGridView_book_list);
            this.Name = "Form_borrow";
            this.Text = "查看当前借阅";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_book_list;
        private System.Windows.Forms.Button button_renew_list;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
    }
}