namespace Pomaris_StudentGradeAnalyzer
{
    partial class frmStudentGradeAnalyzer
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
            this.tblpnDesBar = new System.Windows.Forms.TableLayoutPanel();
            this.pnBlkBar = new System.Windows.Forms.Panel();
            this.lbStudentGradeAnlyzer = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.tblpnCredentials = new System.Windows.Forms.TableLayoutPanel();
            this.tbxStNo = new System.Windows.Forms.TextBox();
            this.lbStudentNm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxStName = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tblpnInputBody = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbResDesc = new System.Windows.Forms.Label();
            this.lbPassFail = new System.Windows.Forms.Label();
            this.tblpnGradeParam = new System.Windows.Forms.TableLayoutPanel();
            this.lbPrelims = new System.Windows.Forms.Label();
            this.lbMidterms = new System.Windows.Forms.Label();
            this.lbFinals = new System.Windows.Forms.Label();
            this.tbxPrelims = new System.Windows.Forms.TextBox();
            this.tbxMidterms = new System.Windows.Forms.TextBox();
            this.tbxFinals = new System.Windows.Forms.TextBox();
            this.lsbStParam = new System.Windows.Forms.ListBox();
            this.tblpnDesBar.SuspendLayout();
            this.pnBlkBar.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.tblpnCredentials.SuspendLayout();
            this.tblpnInputBody.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblpnGradeParam.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnDesBar
            // 
            this.tblpnDesBar.BackColor = System.Drawing.Color.Transparent;
            this.tblpnDesBar.ColumnCount = 1;
            this.tblpnDesBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnDesBar.Controls.Add(this.pnBlkBar, 0, 0);
            this.tblpnDesBar.Controls.Add(this.pnBody, 0, 1);
            this.tblpnDesBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnDesBar.Location = new System.Drawing.Point(0, 0);
            this.tblpnDesBar.Name = "tblpnDesBar";
            this.tblpnDesBar.RowCount = 2;
            this.tblpnDesBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.77778F));
            this.tblpnDesBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.22222F));
            this.tblpnDesBar.Size = new System.Drawing.Size(800, 461);
            this.tblpnDesBar.TabIndex = 0;
            // 
            // pnBlkBar
            // 
            this.pnBlkBar.BackColor = System.Drawing.Color.Black;
            this.pnBlkBar.Controls.Add(this.lbStudentGradeAnlyzer);
            this.pnBlkBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBlkBar.Location = new System.Drawing.Point(3, 3);
            this.pnBlkBar.Name = "pnBlkBar";
            this.pnBlkBar.Size = new System.Drawing.Size(794, 66);
            this.pnBlkBar.TabIndex = 0;
            // 
            // lbStudentGradeAnlyzer
            // 
            this.lbStudentGradeAnlyzer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbStudentGradeAnlyzer.AutoSize = true;
            this.lbStudentGradeAnlyzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentGradeAnlyzer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStudentGradeAnlyzer.Location = new System.Drawing.Point(3, 1);
            this.lbStudentGradeAnlyzer.Name = "lbStudentGradeAnlyzer";
            this.lbStudentGradeAnlyzer.Padding = new System.Windows.Forms.Padding(20, 15, 0, 15);
            this.lbStudentGradeAnlyzer.Size = new System.Drawing.Size(345, 61);
            this.lbStudentGradeAnlyzer.TabIndex = 0;
            this.lbStudentGradeAnlyzer.Text = "Student Grade Analyzer";
            this.lbStudentGradeAnlyzer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.DimGray;
            this.pnBody.Controls.Add(this.tblpnCredentials);
            this.pnBody.Controls.Add(this.btnCalculate);
            this.pnBody.Controls.Add(this.btnClear);
            this.pnBody.Controls.Add(this.tblpnInputBody);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(3, 75);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(794, 383);
            this.pnBody.TabIndex = 1;
            // 
            // tblpnCredentials
            // 
            this.tblpnCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnCredentials.ColumnCount = 2;
            this.tblpnCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.7732F));
            this.tblpnCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.22681F));
            this.tblpnCredentials.Controls.Add(this.tbxStNo, 1, 1);
            this.tblpnCredentials.Controls.Add(this.lbStudentNm, 0, 0);
            this.tblpnCredentials.Controls.Add(this.label1, 0, 1);
            this.tblpnCredentials.Controls.Add(this.tbxStName, 1, 0);
            this.tblpnCredentials.Location = new System.Drawing.Point(9, 3);
            this.tblpnCredentials.Name = "tblpnCredentials";
            this.tblpnCredentials.RowCount = 2;
            this.tblpnCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnCredentials.Size = new System.Drawing.Size(776, 60);
            this.tblpnCredentials.TabIndex = 0;
            // 
            // tbxStNo
            // 
            this.tbxStNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStNo.Location = new System.Drawing.Point(203, 33);
            this.tbxStNo.Name = "tbxStNo";
            this.tbxStNo.Size = new System.Drawing.Size(570, 22);
            this.tbxStNo.TabIndex = 3;
            // 
            // lbStudentNm
            // 
            this.lbStudentNm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbStudentNm.AutoSize = true;
            this.lbStudentNm.BackColor = System.Drawing.Color.Transparent;
            this.lbStudentNm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentNm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStudentNm.Location = new System.Drawing.Point(43, 0);
            this.lbStudentNm.Name = "lbStudentNm";
            this.lbStudentNm.Size = new System.Drawing.Size(114, 30);
            this.lbStudentNm.TabIndex = 0;
            this.lbStudentNm.Text = "Student Name";
            this.lbStudentNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxStName
            // 
            this.tbxStName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxStName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStName.Location = new System.Drawing.Point(203, 3);
            this.tbxStName.Name = "tbxStName";
            this.tbxStName.Size = new System.Drawing.Size(570, 22);
            this.tbxStName.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(140, 321);
            this.btnCalculate.MinimumSize = new System.Drawing.Size(150, 0);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(285, 37);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(36, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 37);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tblpnInputBody
            // 
            this.tblpnInputBody.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnInputBody.AutoSize = true;
            this.tblpnInputBody.ColumnCount = 2;
            this.tblpnInputBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.75679F));
            this.tblpnInputBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.24321F));
            this.tblpnInputBody.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tblpnInputBody.Controls.Add(this.tblpnGradeParam, 0, 0);
            this.tblpnInputBody.Location = new System.Drawing.Point(9, 80);
            this.tblpnInputBody.Name = "tblpnInputBody";
            this.tblpnInputBody.RowCount = 1;
            this.tblpnInputBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnInputBody.Size = new System.Drawing.Size(773, 218);
            this.tblpnInputBody.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbResDesc, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbPassFail, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lsbStParam, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(434, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.2233F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.7767F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 212);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbResDesc
            // 
            this.lbResDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResDesc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbResDesc.Location = new System.Drawing.Point(3, 82);
            this.lbResDesc.Name = "lbResDesc";
            this.lbResDesc.Size = new System.Drawing.Size(330, 56);
            this.lbResDesc.TabIndex = 1;
            this.lbResDesc.Text = "Your average grade is: 00.00";
            this.lbResDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResDesc.Visible = false;
            // 
            // lbPassFail
            // 
            this.lbPassFail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPassFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassFail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPassFail.Location = new System.Drawing.Point(3, 0);
            this.lbPassFail.Name = "lbPassFail";
            this.lbPassFail.Size = new System.Drawing.Size(330, 82);
            this.lbPassFail.TabIndex = 0;
            this.lbPassFail.Text = "Result";
            this.lbPassFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPassFail.Visible = false;
            // 
            // tblpnGradeParam
            // 
            this.tblpnGradeParam.ColumnCount = 3;
            this.tblpnGradeParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.62005F));
            this.tblpnGradeParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.37994F));
            this.tblpnGradeParam.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblpnGradeParam.Controls.Add(this.lbPrelims, 0, 1);
            this.tblpnGradeParam.Controls.Add(this.lbMidterms, 0, 2);
            this.tblpnGradeParam.Controls.Add(this.lbFinals, 0, 3);
            this.tblpnGradeParam.Controls.Add(this.tbxPrelims, 1, 1);
            this.tblpnGradeParam.Controls.Add(this.tbxMidterms, 1, 2);
            this.tblpnGradeParam.Controls.Add(this.tbxFinals, 1, 3);
            this.tblpnGradeParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnGradeParam.Location = new System.Drawing.Point(3, 3);
            this.tblpnGradeParam.Name = "tblpnGradeParam";
            this.tblpnGradeParam.RowCount = 5;
            this.tblpnGradeParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblpnGradeParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.43903F));
            this.tblpnGradeParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.56097F));
            this.tblpnGradeParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblpnGradeParam.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblpnGradeParam.Size = new System.Drawing.Size(425, 212);
            this.tblpnGradeParam.TabIndex = 1;
            // 
            // lbPrelims
            // 
            this.lbPrelims.AutoSize = true;
            this.lbPrelims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrelims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrelims.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrelims.Location = new System.Drawing.Point(3, 39);
            this.lbPrelims.Name = "lbPrelims";
            this.lbPrelims.Size = new System.Drawing.Size(129, 45);
            this.lbPrelims.TabIndex = 0;
            this.lbPrelims.Text = "Prelims";
            this.lbPrelims.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMidterms
            // 
            this.lbMidterms.AutoSize = true;
            this.lbMidterms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMidterms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMidterms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMidterms.Location = new System.Drawing.Point(3, 84);
            this.lbMidterms.Name = "lbMidterms";
            this.lbMidterms.Size = new System.Drawing.Size(129, 41);
            this.lbMidterms.TabIndex = 1;
            this.lbMidterms.Text = "Midterms";
            this.lbMidterms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFinals
            // 
            this.lbFinals.AutoSize = true;
            this.lbFinals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFinals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFinals.Location = new System.Drawing.Point(3, 125);
            this.lbFinals.Name = "lbFinals";
            this.lbFinals.Size = new System.Drawing.Size(129, 48);
            this.lbFinals.TabIndex = 2;
            this.lbFinals.Text = "Finals";
            this.lbFinals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPrelims
            // 
            this.tbxPrelims.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPrelims.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrelims.Location = new System.Drawing.Point(138, 50);
            this.tbxPrelims.Name = "tbxPrelims";
            this.tbxPrelims.Size = new System.Drawing.Size(238, 22);
            this.tbxPrelims.TabIndex = 3;
            // 
            // tbxMidterms
            // 
            this.tbxMidterms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMidterms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMidterms.Location = new System.Drawing.Point(138, 93);
            this.tbxMidterms.Name = "tbxMidterms";
            this.tbxMidterms.Size = new System.Drawing.Size(238, 22);
            this.tbxMidterms.TabIndex = 4;
            // 
            // tbxFinals
            // 
            this.tbxFinals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFinals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFinals.Location = new System.Drawing.Point(138, 138);
            this.tbxFinals.Name = "tbxFinals";
            this.tbxFinals.Size = new System.Drawing.Size(238, 22);
            this.tbxFinals.TabIndex = 5;
            // 
            // lsbStParam
            // 
            this.lsbStParam.BackColor = System.Drawing.Color.DimGray;
            this.lsbStParam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbStParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbStParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbStParam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lsbStParam.FormattingEnabled = true;
            this.lsbStParam.ItemHeight = 20;
            this.lsbStParam.Items.AddRange(new object[] {
            "Test",
            "test2"});
            this.lsbStParam.Location = new System.Drawing.Point(3, 166);
            this.lsbStParam.Name = "lsbStParam";
            this.lsbStParam.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbStParam.Size = new System.Drawing.Size(330, 43);
            this.lsbStParam.TabIndex = 2;
            this.lsbStParam.Visible = false;
            // 
            // frmStudentGradeAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.tblpnDesBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "frmStudentGradeAnalyzer";
            this.Text = "Student Grade Analyzer";
            this.tblpnDesBar.ResumeLayout(false);
            this.pnBlkBar.ResumeLayout(false);
            this.pnBlkBar.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.tblpnCredentials.ResumeLayout(false);
            this.tblpnCredentials.PerformLayout();
            this.tblpnInputBody.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tblpnGradeParam.ResumeLayout(false);
            this.tblpnGradeParam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnDesBar;
        private System.Windows.Forms.Panel pnBlkBar;
        private System.Windows.Forms.Label lbStudentGradeAnlyzer;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.TableLayoutPanel tblpnCredentials;
        private System.Windows.Forms.Label lbStudentNm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStName;
        private System.Windows.Forms.TextBox tbxStNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TableLayoutPanel tblpnInputBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbResDesc;
        private System.Windows.Forms.Label lbPassFail;
        private System.Windows.Forms.TableLayoutPanel tblpnGradeParam;
        private System.Windows.Forms.Label lbPrelims;
        private System.Windows.Forms.Label lbMidterms;
        private System.Windows.Forms.Label lbFinals;
        private System.Windows.Forms.TextBox tbxPrelims;
        private System.Windows.Forms.TextBox tbxMidterms;
        private System.Windows.Forms.TextBox tbxFinals;
        private System.Windows.Forms.ListBox lsbStParam;
    }
}

