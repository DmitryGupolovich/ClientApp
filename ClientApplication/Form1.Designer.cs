﻿namespace ClientApplication
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
            this.components = new System.ComponentModel.Container();
            this.send_url_button = new System.Windows.Forms.Button();
            this.text_url = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.EntityText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerArticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlArticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // send_url_button
            // 
            this.send_url_button.Location = new System.Drawing.Point(1166, 14);
            this.send_url_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.send_url_button.Name = "send_url_button";
            this.send_url_button.Size = new System.Drawing.Size(237, 36);
            this.send_url_button.TabIndex = 0;
            this.send_url_button.Text = "Send";
            this.send_url_button.UseVisualStyleBackColor = true;
            this.send_url_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // text_url
            // 
            this.text_url.Location = new System.Drawing.Point(63, 14);
            this.text_url.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_url.Multiline = true;
            this.text_url.Name = "text_url";
            this.text_url.Size = new System.Drawing.Size(388, 35);
            this.text_url.TabIndex = 1;
            this.text_url.Text = "Input Url here";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.headerArticleDataGridViewTextBoxColumn,
            this.urlArticleDataGridViewTextBoxColumn,
            this.fullTextDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.EntityText});
            this.dataGridView1.DataSource = this.articleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1442, 437);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1029, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 27);
            this.textBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1166, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "GetListById";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1166, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "GetFullList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // EntityText
            // 
            this.EntityText.DataPropertyName = "EntityText";
            this.EntityText.HeaderText = "EntityText";
            this.EntityText.MinimumWidth = 6;
            this.EntityText.Name = "EntityText";
            this.EntityText.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // headerArticleDataGridViewTextBoxColumn
            // 
            this.headerArticleDataGridViewTextBoxColumn.DataPropertyName = "HeaderArticle";
            this.headerArticleDataGridViewTextBoxColumn.HeaderText = "HeaderArticle";
            this.headerArticleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.headerArticleDataGridViewTextBoxColumn.Name = "headerArticleDataGridViewTextBoxColumn";
            this.headerArticleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlArticleDataGridViewTextBoxColumn
            // 
            this.urlArticleDataGridViewTextBoxColumn.DataPropertyName = "UrlArticle";
            this.urlArticleDataGridViewTextBoxColumn.HeaderText = "UrlArticle";
            this.urlArticleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urlArticleDataGridViewTextBoxColumn.Name = "urlArticleDataGridViewTextBoxColumn";
            this.urlArticleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullTextDataGridViewTextBoxColumn
            // 
            this.fullTextDataGridViewTextBoxColumn.DataPropertyName = "FullText";
            this.fullTextDataGridViewTextBoxColumn.HeaderText = "FullText";
            this.fullTextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullTextDataGridViewTextBoxColumn.Name = "fullTextDataGridViewTextBoxColumn";
            this.fullTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(WebApplication.ServiceModel.Article);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 670);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_url);
            this.Controls.Add(this.send_url_button);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_url_button;
        private System.Windows.Forms.TextBox text_url;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerArticleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlArticleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityText;
    }
}

