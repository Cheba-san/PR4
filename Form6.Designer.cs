
namespace work
{
    partial class Form6
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
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.button_add6 = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.fio = new System.Windows.Forms.TextBox();
            this.numb = new System.Windows.Forms.TextBox();
            this.pos = new System.Windows.Forms.TextBox();
            this.dep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(0, 292);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(338, 148);
            this.dataGridView6.TabIndex = 0;
            this.dataGridView6.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView6_CellMouseClick);
            // 
            // button_add6
            // 
            this.button_add6.Location = new System.Drawing.Point(209, 36);
            this.button_add6.Name = "button_add6";
            this.button_add6.Size = new System.Drawing.Size(117, 33);
            this.button_add6.TabIndex = 1;
            this.button_add6.Text = "Добавить";
            this.button_add6.UseVisualStyleBackColor = true;
            this.button_add6.Click += new System.EventHandler(this.button_add6_Click);
            // 
            // btn_upd
            // 
            this.btn_upd.Location = new System.Drawing.Point(209, 97);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(117, 35);
            this.btn_upd.TabIndex = 2;
            this.btn_upd.Text = "Обновить";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(209, 159);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(117, 34);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(8, 36);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(139, 20);
            this.fio.TabIndex = 4;
            // 
            // numb
            // 
            this.numb.Location = new System.Drawing.Point(8, 79);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(139, 20);
            this.numb.TabIndex = 5;
            // 
            // pos
            // 
            this.pos.Location = new System.Drawing.Point(8, 122);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(139, 20);
            this.pos.TabIndex = 6;
            // 
            // dep
            // 
            this.dep.Location = new System.Drawing.Point(8, 159);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(139, 20);
            this.dep.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "id должности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "id отделения";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 439);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.numb);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_upd);
            this.Controls.Add(this.button_add6);
            this.Controls.Add(this.dataGridView6);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button button_add6;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.TextBox numb;
        private System.Windows.Forms.TextBox pos;
        private System.Windows.Forms.TextBox dep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}