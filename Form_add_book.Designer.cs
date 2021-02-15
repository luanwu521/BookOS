
namespace BookOS
{
    partial class Form_add_book
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
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_book_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_book_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_book_author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_book_count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_add.Location = new System.Drawing.Point(173, 277);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(101, 50);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_book_id
            // 
            this.textBox_book_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_book_id.Location = new System.Drawing.Point(173, 30);
            this.textBox_book_id.Name = "textBox_book_id";
            this.textBox_book_id.Size = new System.Drawing.Size(152, 30);
            this.textBox_book_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(84, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "图书id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(64, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "图书名称";
            // 
            // textBox_book_name
            // 
            this.textBox_book_name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_book_name.Location = new System.Drawing.Point(173, 91);
            this.textBox_book_name.Name = "textBox_book_name";
            this.textBox_book_name.Size = new System.Drawing.Size(152, 30);
            this.textBox_book_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(64, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "图书作者";
            // 
            // textBox_book_author
            // 
            this.textBox_book_author.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_book_author.Location = new System.Drawing.Point(173, 156);
            this.textBox_book_author.Name = "textBox_book_author";
            this.textBox_book_author.Size = new System.Drawing.Size(152, 30);
            this.textBox_book_author.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(64, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "图书数量";
            // 
            // textBox_book_count
            // 
            this.textBox_book_count.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_book_count.Location = new System.Drawing.Point(173, 215);
            this.textBox_book_count.Name = "textBox_book_count";
            this.textBox_book_count.Size = new System.Drawing.Size(152, 30);
            this.textBox_book_count.TabIndex = 7;
            this.textBox_book_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_book_count_KeyPress);
            // 
            // Form_add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_book_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_book_author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_book_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_book_id);
            this.Controls.Add(this.button_add);
            this.Name = "Form_add_book";
            this.Text = "添加图书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_book_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_book_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_book_author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_book_count;
    }
}