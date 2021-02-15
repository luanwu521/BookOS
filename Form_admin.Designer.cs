
namespace BookOS
{
    partial class Form_admin
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
            this.button_renew_book_list = new System.Windows.Forms.Button();
            this.button_add_book = new System.Windows.Forms.Button();
            this.button_remove_book = new System.Windows.Forms.Button();
            this.button_user_op = new System.Windows.Forms.Button();
            this.button_change_book_information = new System.Windows.Forms.Button();
            this.button_exit_system = new System.Windows.Forms.Button();
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
            this.dataGridView_book_list.Name = "dataGridView_book_list";
            this.dataGridView_book_list.ReadOnly = true;
            this.dataGridView_book_list.RowHeadersWidth = 51;
            this.dataGridView_book_list.RowTemplate.Height = 27;
            this.dataGridView_book_list.Size = new System.Drawing.Size(712, 565);
            this.dataGridView_book_list.TabIndex = 1;
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
            // button_renew_book_list
            // 
            this.button_renew_book_list.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_renew_book_list.Location = new System.Drawing.Point(781, 33);
            this.button_renew_book_list.Name = "button_renew_book_list";
            this.button_renew_book_list.Size = new System.Drawing.Size(124, 57);
            this.button_renew_book_list.TabIndex = 4;
            this.button_renew_book_list.Text = "更新图书列表";
            this.button_renew_book_list.UseVisualStyleBackColor = true;
            this.button_renew_book_list.Click += new System.EventHandler(this.button_renew_book_list_Click);
            // 
            // button_add_book
            // 
            this.button_add_book.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add_book.Location = new System.Drawing.Point(781, 312);
            this.button_add_book.Name = "button_add_book";
            this.button_add_book.Size = new System.Drawing.Size(124, 57);
            this.button_add_book.TabIndex = 5;
            this.button_add_book.Text = "添加图书";
            this.button_add_book.UseVisualStyleBackColor = true;
            this.button_add_book.Click += new System.EventHandler(this.button_add_book_Click);
            // 
            // button_remove_book
            // 
            this.button_remove_book.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_remove_book.Location = new System.Drawing.Point(781, 120);
            this.button_remove_book.Name = "button_remove_book";
            this.button_remove_book.Size = new System.Drawing.Size(124, 57);
            this.button_remove_book.TabIndex = 6;
            this.button_remove_book.Text = "删除选中图书";
            this.button_remove_book.UseVisualStyleBackColor = true;
            this.button_remove_book.Click += new System.EventHandler(this.button_remove_book_Click);
            // 
            // button_user_op
            // 
            this.button_user_op.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_user_op.Location = new System.Drawing.Point(781, 409);
            this.button_user_op.Name = "button_user_op";
            this.button_user_op.Size = new System.Drawing.Size(124, 57);
            this.button_user_op.TabIndex = 7;
            this.button_user_op.Text = "用户管理";
            this.button_user_op.UseVisualStyleBackColor = true;
            // 
            // button_change_book_information
            // 
            this.button_change_book_information.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_change_book_information.Location = new System.Drawing.Point(781, 215);
            this.button_change_book_information.Name = "button_change_book_information";
            this.button_change_book_information.Size = new System.Drawing.Size(124, 57);
            this.button_change_book_information.TabIndex = 8;
            this.button_change_book_information.Text = "修改选中图书";
            this.button_change_book_information.UseVisualStyleBackColor = true;
            this.button_change_book_information.Click += new System.EventHandler(this.button_change_book_information_Click);
            // 
            // button_exit_system
            // 
            this.button_exit_system.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit_system.Location = new System.Drawing.Point(781, 507);
            this.button_exit_system.Name = "button_exit_system";
            this.button_exit_system.Size = new System.Drawing.Size(124, 57);
            this.button_exit_system.TabIndex = 9;
            this.button_exit_system.Text = "退出系统";
            this.button_exit_system.UseVisualStyleBackColor = true;
            this.button_exit_system.Click += new System.EventHandler(this.button_exit_system_Click);
            // 
            // Form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 585);
            this.Controls.Add(this.button_exit_system);
            this.Controls.Add(this.button_change_book_information);
            this.Controls.Add(this.button_user_op);
            this.Controls.Add(this.button_remove_book);
            this.Controls.Add(this.button_add_book);
            this.Controls.Add(this.button_renew_book_list);
            this.Controls.Add(this.dataGridView_book_list);
            this.Name = "Form_admin";
            this.Text = "管理员操作";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_book_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_book_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_count;
        private System.Windows.Forms.Button button_renew_book_list;
        private System.Windows.Forms.Button button_add_book;
        private System.Windows.Forms.Button button_remove_book;
        private System.Windows.Forms.Button button_user_op;
        private System.Windows.Forms.Button button_change_book_information;
        private System.Windows.Forms.Button button_exit_system;
    }
}