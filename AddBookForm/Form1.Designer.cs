namespace AddBookForm
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
            txtTitle = new TextBox();
            label1 = new Label();
            txtAuthor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(332, 123);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(211, 27);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 126);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(332, 180);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(211, 27);
            txtAuthor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 183);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 238);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(332, 235);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(211, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(332, 298);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(211, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAuthor);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private TextBox txtAuthor;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private Button btnAdd;
    }
}
