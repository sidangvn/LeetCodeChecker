namespace LeetCode_Checker
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbWelcome = new System.Windows.Forms.Label();
            this.btAddQuestions = new System.Windows.Forms.Button();
            this.btGoQuestion = new System.Windows.Forms.Button();
            this.tbQuestionNumber = new System.Windows.Forms.TextBox();
            this.tbQuestionName = new System.Windows.Forms.TextBox();
            this.cbSolved = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDeleteQuestion = new System.Windows.Forms.Button();
            this.btGotoDocument = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btDelAll = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbQuestionBox = new System.Windows.Forms.ListBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btGetBackQuestions = new System.Windows.Forms.Button();
            this.btSolved = new System.Windows.Forms.Button();
            this.btUnSolved = new System.Windows.Forms.Button();
            this.lbNoti = new System.Windows.Forms.Label();
            this.btPickRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Tekton Pro Ext", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(140, 9);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(666, 59);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Chau\'s LeetCode Checker";
            this.lbWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // btAddQuestions
            // 
            this.btAddQuestions.BackColor = System.Drawing.Color.White;
            this.btAddQuestions.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddQuestions.Location = new System.Drawing.Point(759, 165);
            this.btAddQuestions.Name = "btAddQuestions";
            this.btAddQuestions.Size = new System.Drawing.Size(147, 64);
            this.btAddQuestions.TabIndex = 8;
            this.btAddQuestions.Text = "Add Problem(s)";
            this.btAddQuestions.UseVisualStyleBackColor = false;
            this.btAddQuestions.Click += new System.EventHandler(this.btAddQuestions_Click);
            // 
            // btGoQuestion
            // 
            this.btGoQuestion.BackColor = System.Drawing.Color.White;
            this.btGoQuestion.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGoQuestion.Location = new System.Drawing.Point(506, 386);
            this.btGoQuestion.Name = "btGoQuestion";
            this.btGoQuestion.Size = new System.Drawing.Size(132, 46);
            this.btGoQuestion.TabIndex = 9;
            this.btGoQuestion.Text = "Goto This Question Online";
            this.btGoQuestion.UseVisualStyleBackColor = false;
            this.btGoQuestion.Click += new System.EventHandler(this.btGoQuestion_Click);
            // 
            // tbQuestionNumber
            // 
            this.tbQuestionNumber.Location = new System.Drawing.Point(506, 98);
            this.tbQuestionNumber.Name = "tbQuestionNumber";
            this.tbQuestionNumber.Size = new System.Drawing.Size(45, 20);
            this.tbQuestionNumber.TabIndex = 4;
            this.tbQuestionNumber.TextChanged += new System.EventHandler(this.tbQuestionNumber_TextChanged);
            this.tbQuestionNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // tbQuestionName
            // 
            this.tbQuestionName.Location = new System.Drawing.Point(568, 98);
            this.tbQuestionName.Name = "tbQuestionName";
            this.tbQuestionName.Size = new System.Drawing.Size(248, 20);
            this.tbQuestionName.TabIndex = 5;
            // 
            // cbSolved
            // 
            this.cbSolved.AutoSize = true;
            this.cbSolved.Location = new System.Drawing.Point(837, 101);
            this.cbSolved.Name = "cbSolved";
            this.cbSolved.Size = new System.Drawing.Size(65, 17);
            this.cbSolved.TabIndex = 6;
            this.cbSolved.Text = "Solved?";
            this.cbSolved.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "# (Numeric Only)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Question Name";
            // 
            // btDeleteQuestion
            // 
            this.btDeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDeleteQuestion.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteQuestion.Location = new System.Drawing.Point(506, 215);
            this.btDeleteQuestion.Name = "btDeleteQuestion";
            this.btDeleteQuestion.Size = new System.Drawing.Size(106, 51);
            this.btDeleteQuestion.TabIndex = 10;
            this.btDeleteQuestion.Text = "Delete This Question";
            this.btDeleteQuestion.UseVisualStyleBackColor = false;
            this.btDeleteQuestion.Click += new System.EventHandler(this.btDeleteQuestion_Click);
            // 
            // btGotoDocument
            // 
            this.btGotoDocument.BackColor = System.Drawing.Color.White;
            this.btGotoDocument.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGotoDocument.Location = new System.Drawing.Point(661, 386);
            this.btGotoDocument.Name = "btGotoDocument";
            this.btGotoDocument.Size = new System.Drawing.Size(111, 46);
            this.btGotoDocument.TabIndex = 11;
            this.btGotoDocument.Text = "Goto Document";
            this.btGotoDocument.UseVisualStyleBackColor = false;
            this.btGotoDocument.Click += new System.EventHandler(this.btGotoDocument_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Solved        #                                                        Name ";
            // 
            // btDelAll
            // 
            this.btDelAll.BackColor = System.Drawing.Color.MediumPurple;
            this.btDelAll.Location = new System.Drawing.Point(844, 386);
            this.btDelAll.Name = "btDelAll";
            this.btDelAll.Size = new System.Drawing.Size(75, 25);
            this.btDelAll.TabIndex = 12;
            this.btDelAll.Text = "Delete All";
            this.btDelAll.UseVisualStyleBackColor = false;
            this.btDelAll.Click += new System.EventHandler(this.btDelAll_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(506, 139);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(396, 20);
            this.tbLink.TabIndex = 7;
            this.tbLink.TextChanged += new System.EventHandler(this.tbLink_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "LeetCode\'s URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(821, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Press Spacebar ";
            // 
            // lbQuestionBox
            // 
            this.lbQuestionBox.FormattingEnabled = true;
            this.lbQuestionBox.Location = new System.Drawing.Point(12, 101);
            this.lbQuestionBox.Name = "lbQuestionBox";
            this.lbQuestionBox.Size = new System.Drawing.Size(447, 316);
            this.lbQuestionBox.TabIndex = 16;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.White;
            this.btEdit.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(630, 214);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(106, 51);
            this.btEdit.TabIndex = 17;
            this.btEdit.Text = "Edit This Question";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.White;
            this.btFind.Location = new System.Drawing.Point(787, 298);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(119, 27);
            this.btFind.TabIndex = 18;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(821, 272);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(45, 20);
            this.tbFind.TabIndex = 19;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(807, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "# (Numeric Only)";
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.White;
            this.btClear.Location = new System.Drawing.Point(534, 164);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(78, 45);
            this.btClear.TabIndex = 21;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(630, 165);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(85, 44);
            this.btOK.TabIndex = 22;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btGetBackQuestions
            // 
            this.btGetBackQuestions.BackColor = System.Drawing.Color.MediumPurple;
            this.btGetBackQuestions.Location = new System.Drawing.Point(844, 355);
            this.btGetBackQuestions.Name = "btGetBackQuestions";
            this.btGetBackQuestions.Size = new System.Drawing.Size(75, 25);
            this.btGetBackQuestions.TabIndex = 23;
            this.btGetBackQuestions.Text = "Restore";
            this.btGetBackQuestions.UseVisualStyleBackColor = false;
            this.btGetBackQuestions.Click += new System.EventHandler(this.btGetBackQuestions_Click);
            // 
            // btSolved
            // 
            this.btSolved.BackColor = System.Drawing.Color.White;
            this.btSolved.Location = new System.Drawing.Point(506, 324);
            this.btSolved.Name = "btSolved";
            this.btSolved.Size = new System.Drawing.Size(132, 47);
            this.btSolved.TabIndex = 24;
            this.btSolved.Text = "Select Solved Questions";
            this.btSolved.UseVisualStyleBackColor = false;
            this.btSolved.Click += new System.EventHandler(this.btSolved_Click);
            // 
            // btUnSolved
            // 
            this.btUnSolved.BackColor = System.Drawing.Color.White;
            this.btUnSolved.Location = new System.Drawing.Point(663, 324);
            this.btUnSolved.Name = "btUnSolved";
            this.btUnSolved.Size = new System.Drawing.Size(109, 47);
            this.btUnSolved.TabIndex = 25;
            this.btUnSolved.Text = "Select Unsolved Questions";
            this.btUnSolved.UseVisualStyleBackColor = false;
            this.btUnSolved.Click += new System.EventHandler(this.btUnSolved_Click);
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Location = new System.Drawing.Point(62, 424);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(0, 13);
            this.lbNoti.TabIndex = 26;
            // 
            // btPickRandom
            // 
            this.btPickRandom.BackColor = System.Drawing.Color.White;
            this.btPickRandom.Location = new System.Drawing.Point(568, 274);
            this.btPickRandom.Name = "btPickRandom";
            this.btPickRandom.Size = new System.Drawing.Size(114, 40);
            this.btPickRandom.TabIndex = 27;
            this.btPickRandom.Text = "Pick A Random Unsolved Question";
            this.btPickRandom.UseVisualStyleBackColor = false;
            this.btPickRandom.Click += new System.EventHandler(this.btPickRandom_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.btPickRandom);
            this.Controls.Add(this.lbNoti);
            this.Controls.Add(this.btUnSolved);
            this.Controls.Add(this.btSolved);
            this.Controls.Add(this.btGetBackQuestions);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.lbQuestionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.btDelAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGotoDocument);
            this.Controls.Add(this.btDeleteQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSolved);
            this.Controls.Add(this.tbQuestionName);
            this.Controls.Add(this.tbQuestionNumber);
            this.Controls.Add(this.btGoQuestion);
            this.Controls.Add(this.btAddQuestions);
            this.Controls.Add(this.lbWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chau\'s LeetCode Checker";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btAddQuestions;
        private System.Windows.Forms.Button btGoQuestion;
        private System.Windows.Forms.TextBox tbQuestionNumber;
        private System.Windows.Forms.TextBox tbQuestionName;
        private System.Windows.Forms.CheckBox cbSolved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDeleteQuestion;
        private System.Windows.Forms.Button btGotoDocument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDelAll;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbQuestionBox;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btGetBackQuestions;
        private System.Windows.Forms.Button btSolved;
        private System.Windows.Forms.Button btUnSolved;
        private System.Windows.Forms.Label lbNoti;
        private System.Windows.Forms.Button btPickRandom;
    }
}

