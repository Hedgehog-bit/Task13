namespace _11_12_WF
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.matrix1_table = new System.Windows.Forms.DataGridView();
			this.matrix2_table = new System.Windows.Forms.DataGridView();
			this.rezult_table = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.inc_button = new System.Windows.Forms.Button();
			this.dec_button = new System.Windows.Forms.Button();
			this.prod_button = new System.Windows.Forms.Button();
			this.sort_button = new System.Windows.Forms.Button();
			this.condition_label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.matrix1_table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.matrix2_table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rezult_table)).BeginInit();
			this.SuspendLayout();
			// 
			// matrix1_table
			// 
			this.matrix1_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.matrix1_table.Location = new System.Drawing.Point(12, 32);
			this.matrix1_table.Name = "matrix1_table";
			this.matrix1_table.RowTemplate.Height = 24;
			this.matrix1_table.Size = new System.Drawing.Size(240, 150);
			this.matrix1_table.TabIndex = 0;
			// 
			// matrix2_table
			// 
			this.matrix2_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.matrix2_table.Location = new System.Drawing.Point(12, 240);
			this.matrix2_table.Name = "matrix2_table";
			this.matrix2_table.RowTemplate.Height = 24;
			this.matrix2_table.Size = new System.Drawing.Size(240, 150);
			this.matrix2_table.TabIndex = 1;
			// 
			// rezult_table
			// 
			this.rezult_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rezult_table.Location = new System.Drawing.Point(281, 147);
			this.rezult_table.Name = "rezult_table";
			this.rezult_table.Size = new System.Drawing.Size(240, 150);
			this.rezult_table.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "matrix1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 220);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "matrix2";
			// 
			// inc_button
			// 
			this.inc_button.Location = new System.Drawing.Point(12, 188);
			this.inc_button.Name = "inc_button";
			this.inc_button.Size = new System.Drawing.Size(47, 29);
			this.inc_button.TabIndex = 5;
			this.inc_button.Text = "++";
			this.inc_button.UseVisualStyleBackColor = true;
			this.inc_button.Click += new System.EventHandler(this.inc_button_Click);
			// 
			// dec_button
			// 
			this.dec_button.Location = new System.Drawing.Point(65, 188);
			this.dec_button.Name = "dec_button";
			this.dec_button.Size = new System.Drawing.Size(47, 29);
			this.dec_button.TabIndex = 6;
			this.dec_button.Text = "--";
			this.dec_button.UseVisualStyleBackColor = true;
			this.dec_button.Click += new System.EventHandler(this.dec_button_Click);
			// 
			// prod_button
			// 
			this.prod_button.Location = new System.Drawing.Point(118, 188);
			this.prod_button.Name = "prod_button";
			this.prod_button.Size = new System.Drawing.Size(47, 29);
			this.prod_button.TabIndex = 7;
			this.prod_button.Text = "*";
			this.prod_button.UseVisualStyleBackColor = true;
			this.prod_button.Click += new System.EventHandler(this.prod_button_Click);
			// 
			// sort_button
			// 
			this.sort_button.Location = new System.Drawing.Point(171, 188);
			this.sort_button.Name = "sort_button";
			this.sort_button.Size = new System.Drawing.Size(81, 29);
			this.sort_button.TabIndex = 8;
			this.sort_button.Text = "sort";
			this.sort_button.UseVisualStyleBackColor = true;
			this.sort_button.Click += new System.EventHandler(this.sort_button_Click);
			// 
			// condition_label
			// 
			this.condition_label.AutoSize = true;
			this.condition_label.Location = new System.Drawing.Point(12, 403);
			this.condition_label.Name = "condition_label";
			this.condition_label.Size = new System.Drawing.Size(46, 17);
			this.condition_label.TabIndex = 9;
			this.condition_label.Text = "label3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 450);
			this.Controls.Add(this.condition_label);
			this.Controls.Add(this.sort_button);
			this.Controls.Add(this.prod_button);
			this.Controls.Add(this.dec_button);
			this.Controls.Add(this.inc_button);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rezult_table);
			this.Controls.Add(this.matrix2_table);
			this.Controls.Add(this.matrix1_table);
			this.Name = "Form1";
			this.Text = "Задание 11-12";
			((System.ComponentModel.ISupportInitialize)(this.matrix1_table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.matrix2_table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rezult_table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView matrix1_table;
		private System.Windows.Forms.DataGridView matrix2_table;
		private System.Windows.Forms.DataGridView rezult_table;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button inc_button;
		private System.Windows.Forms.Button dec_button;
		private System.Windows.Forms.Button prod_button;
		private System.Windows.Forms.Button sort_button;
		private System.Windows.Forms.Label condition_label;
	}
}

