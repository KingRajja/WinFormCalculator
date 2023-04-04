namespace Calculator {
    partial class Viewer {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infixFormula = new System.Windows.Forms.RichTextBox();
            this.postfixFormula = new System.Windows.Forms.RichTextBox();
            this.solution = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.solutionBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.powBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.multiBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.closeBracketBtn = new System.Windows.Forms.Button();
            this.openBracketBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.percentBtn = new System.Windows.Forms.Button();
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.calcTab = new System.Windows.Forms.TabPage();
            this.calcLogTab = new System.Windows.Forms.TabPage();
            this.calcLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabs.SuspendLayout();
            this.calcTab.SuspendLayout();
            this.calcLogTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.infixFormula, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.postfixFormula, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.solution, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.270677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.270677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.270677F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.18797F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // infixFormula
            // 
            this.infixFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infixFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infixFormula.Location = new System.Drawing.Point(3, 3);
            this.infixFormula.Name = "infixFormula";
            this.infixFormula.Size = new System.Drawing.Size(559, 39);
            this.infixFormula.TabIndex = 0;
            this.infixFormula.Text = "";
            // 
            // postfixFormula
            // 
            this.postfixFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postfixFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.postfixFormula.Location = new System.Drawing.Point(3, 48);
            this.postfixFormula.Name = "postfixFormula";
            this.postfixFormula.Size = new System.Drawing.Size(559, 39);
            this.postfixFormula.TabIndex = 1;
            this.postfixFormula.Text = "";
            // 
            // solution
            // 
            this.solution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solution.Location = new System.Drawing.Point(3, 93);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(559, 39);
            this.solution.TabIndex = 2;
            this.solution.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.solutionBtn, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.dotBtn, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.zeroBtn, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.clearBtn, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.powBtn, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.threeBtn, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.twoBtn, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.oneBtn, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.minusBtn, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.sixBtn, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.fiveBtn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.fourBtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.plusBtn, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.nineBtn, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.eightBtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.sevenBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.multiBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.divisionBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.closeBracketBtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.openBracketBtn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.exitBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.deleteBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.percentBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sqrtBtn, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 138);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(559, 404);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // solutionBtn
            // 
            this.solutionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.solutionBtn.Location = new System.Drawing.Point(420, 338);
            this.solutionBtn.Name = "solutionBtn";
            this.solutionBtn.Size = new System.Drawing.Size(136, 63);
            this.solutionBtn.TabIndex = 23;
            this.solutionBtn.Text = "=";
            this.solutionBtn.UseVisualStyleBackColor = true;
            this.solutionBtn.Click += new System.EventHandler(this.solutionBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dotBtn.Location = new System.Drawing.Point(281, 338);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(133, 63);
            this.dotBtn.TabIndex = 22;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            // 
            // zeroBtn
            // 
            this.zeroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zeroBtn.Location = new System.Drawing.Point(142, 338);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(133, 63);
            this.zeroBtn.TabIndex = 21;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(3, 338);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(133, 63);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // powBtn
            // 
            this.powBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powBtn.Location = new System.Drawing.Point(420, 271);
            this.powBtn.Name = "powBtn";
            this.powBtn.Size = new System.Drawing.Size(136, 61);
            this.powBtn.TabIndex = 19;
            this.powBtn.Text = "^";
            this.powBtn.UseVisualStyleBackColor = true;
            // 
            // threeBtn
            // 
            this.threeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeBtn.Location = new System.Drawing.Point(281, 271);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(133, 61);
            this.threeBtn.TabIndex = 18;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            // 
            // twoBtn
            // 
            this.twoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twoBtn.Location = new System.Drawing.Point(142, 271);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(133, 61);
            this.twoBtn.TabIndex = 17;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            // 
            // oneBtn
            // 
            this.oneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneBtn.Location = new System.Drawing.Point(3, 271);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(133, 61);
            this.oneBtn.TabIndex = 16;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            // 
            // minusBtn
            // 
            this.minusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minusBtn.Location = new System.Drawing.Point(420, 204);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(136, 61);
            this.minusBtn.TabIndex = 15;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            // 
            // sixBtn
            // 
            this.sixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sixBtn.Location = new System.Drawing.Point(281, 204);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(133, 61);
            this.sixBtn.TabIndex = 14;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            // 
            // fiveBtn
            // 
            this.fiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fiveBtn.Location = new System.Drawing.Point(142, 204);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(133, 61);
            this.fiveBtn.TabIndex = 13;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            // 
            // fourBtn
            // 
            this.fourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourBtn.Location = new System.Drawing.Point(3, 204);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(133, 61);
            this.fourBtn.TabIndex = 12;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            // 
            // plusBtn
            // 
            this.plusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plusBtn.Location = new System.Drawing.Point(420, 137);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(136, 61);
            this.plusBtn.TabIndex = 11;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            // 
            // nineBtn
            // 
            this.nineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nineBtn.Location = new System.Drawing.Point(281, 137);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(133, 61);
            this.nineBtn.TabIndex = 10;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            // 
            // eightBtn
            // 
            this.eightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eightBtn.Location = new System.Drawing.Point(142, 137);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(133, 61);
            this.eightBtn.TabIndex = 9;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            // 
            // sevenBtn
            // 
            this.sevenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenBtn.Location = new System.Drawing.Point(3, 137);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(133, 61);
            this.sevenBtn.TabIndex = 8;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            // 
            // multiBtn
            // 
            this.multiBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiBtn.Location = new System.Drawing.Point(420, 70);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(136, 61);
            this.multiBtn.TabIndex = 7;
            this.multiBtn.Text = "*";
            this.multiBtn.UseVisualStyleBackColor = true;
            // 
            // divisionBtn
            // 
            this.divisionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divisionBtn.Location = new System.Drawing.Point(281, 70);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(133, 61);
            this.divisionBtn.TabIndex = 6;
            this.divisionBtn.Text = "/";
            this.divisionBtn.UseVisualStyleBackColor = true;
            // 
            // closeBracketBtn
            // 
            this.closeBracketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBracketBtn.Location = new System.Drawing.Point(142, 70);
            this.closeBracketBtn.Name = "closeBracketBtn";
            this.closeBracketBtn.Size = new System.Drawing.Size(133, 61);
            this.closeBracketBtn.TabIndex = 5;
            this.closeBracketBtn.Text = ")";
            this.closeBracketBtn.UseVisualStyleBackColor = true;
            // 
            // openBracketBtn
            // 
            this.openBracketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openBracketBtn.Location = new System.Drawing.Point(3, 70);
            this.openBracketBtn.Name = "openBracketBtn";
            this.openBracketBtn.Size = new System.Drawing.Size(133, 61);
            this.openBracketBtn.TabIndex = 4;
            this.openBracketBtn.Text = "(";
            this.openBracketBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Location = new System.Drawing.Point(420, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(136, 61);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "EXT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(281, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 61);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "DEL";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.percentBtn.Location = new System.Drawing.Point(142, 3);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(133, 61);
            this.percentBtn.TabIndex = 1;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = true;
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqrtBtn.Location = new System.Drawing.Point(3, 3);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(133, 61);
            this.sqrtBtn.TabIndex = 0;
            this.sqrtBtn.Text = "√";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.calcTab);
            this.tabs.Controls.Add(this.calcLogTab);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(585, 583);
            this.tabs.TabIndex = 1;
            // 
            // calcTab
            // 
            this.calcTab.Controls.Add(this.tableLayoutPanel1);
            this.calcTab.Location = new System.Drawing.Point(4, 22);
            this.calcTab.Name = "calcTab";
            this.calcTab.Padding = new System.Windows.Forms.Padding(3);
            this.calcTab.Size = new System.Drawing.Size(577, 557);
            this.calcTab.TabIndex = 0;
            this.calcTab.Text = "Calculator";
            this.calcTab.UseVisualStyleBackColor = true;
            // 
            // calcLogTab
            // 
            this.calcLogTab.Controls.Add(this.calcLog);
            this.calcLogTab.Location = new System.Drawing.Point(4, 22);
            this.calcLogTab.Name = "calcLogTab";
            this.calcLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.calcLogTab.Size = new System.Drawing.Size(577, 557);
            this.calcLogTab.TabIndex = 1;
            this.calcLogTab.Text = "CalculatorLog";
            this.calcLogTab.UseVisualStyleBackColor = true;
            // 
            // calcLog
            // 
            this.calcLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcLog.Location = new System.Drawing.Point(6, 6);
            this.calcLog.Name = "calcLog";
            this.calcLog.Size = new System.Drawing.Size(565, 545);
            this.calcLog.TabIndex = 0;
            this.calcLog.Text = "";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 607);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Viewer";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.calcTab.ResumeLayout(false);
            this.calcLogTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox infixFormula;
        private System.Windows.Forms.RichTextBox postfixFormula;
        private System.Windows.Forms.RichTextBox solution;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button solutionBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button powBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button multiBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button closeBracketBtn;
        private System.Windows.Forms.Button openBracketBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button percentBtn;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage calcTab;
        private System.Windows.Forms.TabPage calcLogTab;
        private System.Windows.Forms.RichTextBox calcLog;
    }
}

