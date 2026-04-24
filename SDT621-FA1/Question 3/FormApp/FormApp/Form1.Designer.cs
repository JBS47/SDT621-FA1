namespace FormApp
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Heading = new Label();
            lstLanguages = new ListBox();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblDateTime = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Heading.Location = new Point(125, 74);
            Heading.Name = "Heading";
            Heading.Size = new Size(564, 41);
            Heading.TabIndex = 2;
            Heading.Text = "My Favourite Programming Languages";
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(53, 133);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(708, 164);
            lstLanguages.TabIndex = 3;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(53, 305);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(708, 27);
            txtLanguage.TabIndex = 4;
            txtLanguage.Tag = "";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkBlue;
            btnAdd.Font = new Font("Verdana Pro Cond", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(53, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkRed;
            btnRemove.Font = new Font("Verdana Pro Cond", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = SystemColors.ButtonHighlight;
            btnRemove.Location = new Point(219, 350);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(141, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblDateTime.ForeColor = Color.DimGray;
            lblDateTime.Location = new Point(56, 399);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(13, 20);
            lblDateTime.TabIndex = 7;
            lblDateTime.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDateTime);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtLanguage);
            Controls.Add(lstLanguages);
            Controls.Add(Heading);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label Heading;
        private ListBox lstLanguages;
        private TextBox txtLanguage;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblDateTime;
    }
}
