
namespace HexCalc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlBits = new System.Windows.Forms.Panel();
            this.txtDecimalInputA = new System.Windows.Forms.TextBox();
            this.txtDecimalInputB = new System.Windows.Forms.TextBox();
            this.txtDecimalResult = new System.Windows.Forms.TextBox();
            this.txtBinaryInputA = new System.Windows.Forms.TextBox();
            this.txtBinaryInputB = new System.Windows.Forms.TextBox();
            this.txtBinaryResult = new System.Windows.Forms.TextBox();
            this.txtHexInputA = new System.Windows.Forms.TextBox();
            this.txtHexResult = new System.Windows.Forms.TextBox();
            this.txtHexInputB = new System.Windows.Forms.TextBox();
            this.butLeftShiftA = new System.Windows.Forms.Button();
            this.butLeftShiftB = new System.Windows.Forms.Button();
            this.butRightShiftA = new System.Windows.Forms.Button();
            this.butRightShiftB = new System.Windows.Forms.Button();
            this.rdo64 = new System.Windows.Forms.RadioButton();
            this.rdo32 = new System.Windows.Forms.RadioButton();
            this.rdo16 = new System.Windows.Forms.RadioButton();
            this.rdo8 = new System.Windows.Forms.RadioButton();
            this.txtShiftAmount = new System.Windows.Forms.TextBox();
            this.lblDecimalInput = new System.Windows.Forms.Label();
            this.lblDecimalResult = new System.Windows.Forms.Label();
            this.lblBinaryInput = new System.Windows.Forms.Label();
            this.lblBinaryResult = new System.Windows.Forms.Label();
            this.lblHexInput = new System.Windows.Forms.Label();
            this.lblHexResult = new System.Windows.Forms.Label();
            this.lblShiftAmount = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblCEquals = new System.Windows.Forms.Label();
            this.butNotA = new System.Windows.Forms.Button();
            this.butNotB = new System.Windows.Forms.Button();
            this.grpBits = new System.Windows.Forms.GroupBox();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.rdoDivide = new System.Windows.Forms.RadioButton();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSubtract = new System.Windows.Forms.RadioButton();
            this.rdoMultiply = new System.Windows.Forms.RadioButton();
            this.rdoXor = new System.Windows.Forms.RadioButton();
            this.rdoOr = new System.Windows.Forms.RadioButton();
            this.rdoAnd = new System.Windows.Forms.RadioButton();
            this.grpBits.SuspendLayout();
            this.grpOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBits
            // 
            this.pnlBits.Location = new System.Drawing.Point(12, 12);
            this.pnlBits.Name = "pnlBits";
            this.pnlBits.Size = new System.Drawing.Size(864, 160);
            this.pnlBits.TabIndex = 29;
            this.pnlBits.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBits_Paint);
            // 
            // txtDecimalInputA
            // 
            this.txtDecimalInputA.Location = new System.Drawing.Point(38, 198);
            this.txtDecimalInputA.Name = "txtDecimalInputA";
            this.txtDecimalInputA.Size = new System.Drawing.Size(169, 20);
            this.txtDecimalInputA.TabIndex = 4;
            this.txtDecimalInputA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDecimalInputA.TextChanged += new System.EventHandler(this.OnDecimalTextChanged);
            this.txtDecimalInputA.Enter += new System.EventHandler(this.OnAEnter);
            this.txtDecimalInputA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnDecimalKeypress);
            // 
            // txtDecimalInputB
            // 
            this.txtDecimalInputB.Location = new System.Drawing.Point(38, 224);
            this.txtDecimalInputB.Name = "txtDecimalInputB";
            this.txtDecimalInputB.Size = new System.Drawing.Size(169, 20);
            this.txtDecimalInputB.TabIndex = 11;
            this.txtDecimalInputB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDecimalInputB.TextChanged += new System.EventHandler(this.OnDecimalTextChanged);
            this.txtDecimalInputB.Enter += new System.EventHandler(this.OnBEnter);
            this.txtDecimalInputB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnDecimalKeypress);
            // 
            // txtDecimalResult
            // 
            this.txtDecimalResult.Location = new System.Drawing.Point(38, 273);
            this.txtDecimalResult.Name = "txtDecimalResult";
            this.txtDecimalResult.ReadOnly = true;
            this.txtDecimalResult.Size = new System.Drawing.Size(169, 20);
            this.txtDecimalResult.TabIndex = 21;
            this.txtDecimalResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBinaryInputA
            // 
            this.txtBinaryInputA.Location = new System.Drawing.Point(251, 198);
            this.txtBinaryInputA.Name = "txtBinaryInputA";
            this.txtBinaryInputA.Size = new System.Drawing.Size(428, 20);
            this.txtBinaryInputA.TabIndex = 6;
            this.txtBinaryInputA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBinaryInputA.TextChanged += new System.EventHandler(this.OnBinaryTextChanged);
            this.txtBinaryInputA.Enter += new System.EventHandler(this.OnAEnter);
            this.txtBinaryInputA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnBinaryKeypress);
            // 
            // txtBinaryInputB
            // 
            this.txtBinaryInputB.Location = new System.Drawing.Point(251, 224);
            this.txtBinaryInputB.Name = "txtBinaryInputB";
            this.txtBinaryInputB.Size = new System.Drawing.Size(428, 20);
            this.txtBinaryInputB.TabIndex = 13;
            this.txtBinaryInputB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBinaryInputB.TextChanged += new System.EventHandler(this.OnBinaryTextChanged);
            this.txtBinaryInputB.Enter += new System.EventHandler(this.OnBEnter);
            this.txtBinaryInputB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnBinaryKeypress);
            // 
            // txtBinaryResult
            // 
            this.txtBinaryResult.Location = new System.Drawing.Point(251, 273);
            this.txtBinaryResult.Name = "txtBinaryResult";
            this.txtBinaryResult.ReadOnly = true;
            this.txtBinaryResult.Size = new System.Drawing.Size(428, 20);
            this.txtBinaryResult.TabIndex = 22;
            this.txtBinaryResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHexInputA
            // 
            this.txtHexInputA.Location = new System.Drawing.Point(723, 198);
            this.txtHexInputA.Name = "txtHexInputA";
            this.txtHexInputA.Size = new System.Drawing.Size(115, 20);
            this.txtHexInputA.TabIndex = 8;
            this.txtHexInputA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHexInputA.TextChanged += new System.EventHandler(this.OnHexTextChanged);
            this.txtHexInputA.Enter += new System.EventHandler(this.OnAEnter);
            this.txtHexInputA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnHexKeypress);
            // 
            // txtHexResult
            // 
            this.txtHexResult.Location = new System.Drawing.Point(723, 273);
            this.txtHexResult.Name = "txtHexResult";
            this.txtHexResult.ReadOnly = true;
            this.txtHexResult.Size = new System.Drawing.Size(115, 20);
            this.txtHexResult.TabIndex = 23;
            this.txtHexResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHexInputB
            // 
            this.txtHexInputB.Location = new System.Drawing.Point(723, 224);
            this.txtHexInputB.Name = "txtHexInputB";
            this.txtHexInputB.Size = new System.Drawing.Size(115, 20);
            this.txtHexInputB.TabIndex = 15;
            this.txtHexInputB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHexInputB.TextChanged += new System.EventHandler(this.OnHexTextChanged);
            this.txtHexInputB.Enter += new System.EventHandler(this.OnBEnter);
            this.txtHexInputB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnHexKeypress);
            // 
            // butLeftShiftA
            // 
            this.butLeftShiftA.Location = new System.Drawing.Point(213, 195);
            this.butLeftShiftA.Name = "butLeftShiftA";
            this.butLeftShiftA.Size = new System.Drawing.Size(32, 23);
            this.butLeftShiftA.TabIndex = 5;
            this.butLeftShiftA.Text = "<<";
            this.butLeftShiftA.UseVisualStyleBackColor = true;
            this.butLeftShiftA.Click += new System.EventHandler(this.butLeftShiftA_Click);
            this.butLeftShiftA.Enter += new System.EventHandler(this.OnAEnter);
            // 
            // butLeftShiftB
            // 
            this.butLeftShiftB.Location = new System.Drawing.Point(213, 221);
            this.butLeftShiftB.Name = "butLeftShiftB";
            this.butLeftShiftB.Size = new System.Drawing.Size(32, 23);
            this.butLeftShiftB.TabIndex = 12;
            this.butLeftShiftB.Text = "<<";
            this.butLeftShiftB.UseVisualStyleBackColor = true;
            this.butLeftShiftB.Click += new System.EventHandler(this.butLeftShiftB_Click);
            this.butLeftShiftB.Enter += new System.EventHandler(this.OnBEnter);
            // 
            // butRightShiftA
            // 
            this.butRightShiftA.Location = new System.Drawing.Point(685, 196);
            this.butRightShiftA.Name = "butRightShiftA";
            this.butRightShiftA.Size = new System.Drawing.Size(32, 23);
            this.butRightShiftA.TabIndex = 7;
            this.butRightShiftA.Text = ">>";
            this.butRightShiftA.UseVisualStyleBackColor = true;
            this.butRightShiftA.Click += new System.EventHandler(this.butRightShiftA_Click);
            this.butRightShiftA.Enter += new System.EventHandler(this.OnAEnter);
            // 
            // butRightShiftB
            // 
            this.butRightShiftB.Location = new System.Drawing.Point(685, 221);
            this.butRightShiftB.Name = "butRightShiftB";
            this.butRightShiftB.Size = new System.Drawing.Size(32, 23);
            this.butRightShiftB.TabIndex = 14;
            this.butRightShiftB.Text = ">>";
            this.butRightShiftB.UseVisualStyleBackColor = true;
            this.butRightShiftB.Click += new System.EventHandler(this.butRightShiftB_Click);
            this.butRightShiftB.Enter += new System.EventHandler(this.OnBEnter);
            // 
            // rdo64
            // 
            this.rdo64.AutoSize = true;
            this.rdo64.Checked = true;
            this.rdo64.Location = new System.Drawing.Point(142, 19);
            this.rdo64.Name = "rdo64";
            this.rdo64.Size = new System.Drawing.Size(37, 17);
            this.rdo64.TabIndex = 3;
            this.rdo64.TabStop = true;
            this.rdo64.Text = "64";
            this.rdo64.UseVisualStyleBackColor = true;
            this.rdo64.CheckedChanged += new System.EventHandler(this.OnBitCheckChanged);
            // 
            // rdo32
            // 
            this.rdo32.AutoSize = true;
            this.rdo32.Location = new System.Drawing.Point(99, 19);
            this.rdo32.Name = "rdo32";
            this.rdo32.Size = new System.Drawing.Size(37, 17);
            this.rdo32.TabIndex = 2;
            this.rdo32.Text = "32";
            this.rdo32.UseVisualStyleBackColor = true;
            this.rdo32.CheckedChanged += new System.EventHandler(this.OnBitCheckChanged);
            // 
            // rdo16
            // 
            this.rdo16.AutoSize = true;
            this.rdo16.Location = new System.Drawing.Point(56, 19);
            this.rdo16.Name = "rdo16";
            this.rdo16.Size = new System.Drawing.Size(37, 17);
            this.rdo16.TabIndex = 1;
            this.rdo16.Text = "16";
            this.rdo16.UseVisualStyleBackColor = true;
            this.rdo16.CheckedChanged += new System.EventHandler(this.OnBitCheckChanged);
            // 
            // rdo8
            // 
            this.rdo8.AutoSize = true;
            this.rdo8.Location = new System.Drawing.Point(19, 19);
            this.rdo8.Name = "rdo8";
            this.rdo8.Size = new System.Drawing.Size(31, 17);
            this.rdo8.TabIndex = 0;
            this.rdo8.Text = "8";
            this.rdo8.UseVisualStyleBackColor = true;
            this.rdo8.CheckedChanged += new System.EventHandler(this.OnBitCheckChanged);
            // 
            // txtShiftAmount
            // 
            this.txtShiftAmount.Location = new System.Drawing.Point(618, 319);
            this.txtShiftAmount.Name = "txtShiftAmount";
            this.txtShiftAmount.Size = new System.Drawing.Size(43, 20);
            this.txtShiftAmount.TabIndex = 28;
            this.txtShiftAmount.Text = "1";
            this.txtShiftAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShiftAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnDecimalKeypress);
            // 
            // lblDecimalInput
            // 
            this.lblDecimalInput.AutoSize = true;
            this.lblDecimalInput.Location = new System.Drawing.Point(35, 182);
            this.lblDecimalInput.Name = "lblDecimalInput";
            this.lblDecimalInput.Size = new System.Drawing.Size(75, 13);
            this.lblDecimalInput.TabIndex = 0;
            this.lblDecimalInput.Text = "Decimal Input:";
            // 
            // lblDecimalResult
            // 
            this.lblDecimalResult.AutoSize = true;
            this.lblDecimalResult.Location = new System.Drawing.Point(35, 257);
            this.lblDecimalResult.Name = "lblDecimalResult";
            this.lblDecimalResult.Size = new System.Drawing.Size(81, 13);
            this.lblDecimalResult.TabIndex = 17;
            this.lblDecimalResult.Text = "Decimal Result:";
            // 
            // lblBinaryInput
            // 
            this.lblBinaryInput.AutoSize = true;
            this.lblBinaryInput.Location = new System.Drawing.Point(248, 182);
            this.lblBinaryInput.Name = "lblBinaryInput";
            this.lblBinaryInput.Size = new System.Drawing.Size(66, 13);
            this.lblBinaryInput.TabIndex = 1;
            this.lblBinaryInput.Text = "Binary Input:";
            // 
            // lblBinaryResult
            // 
            this.lblBinaryResult.AutoSize = true;
            this.lblBinaryResult.Location = new System.Drawing.Point(248, 257);
            this.lblBinaryResult.Name = "lblBinaryResult";
            this.lblBinaryResult.Size = new System.Drawing.Size(72, 13);
            this.lblBinaryResult.TabIndex = 18;
            this.lblBinaryResult.Text = "Binary Result:";
            // 
            // lblHexInput
            // 
            this.lblHexInput.AutoSize = true;
            this.lblHexInput.Location = new System.Drawing.Point(720, 182);
            this.lblHexInput.Name = "lblHexInput";
            this.lblHexInput.Size = new System.Drawing.Size(56, 13);
            this.lblHexInput.TabIndex = 2;
            this.lblHexInput.Text = "Hex Input:";
            // 
            // lblHexResult
            // 
            this.lblHexResult.AutoSize = true;
            this.lblHexResult.Location = new System.Drawing.Point(720, 257);
            this.lblHexResult.Name = "lblHexResult";
            this.lblHexResult.Size = new System.Drawing.Size(62, 13);
            this.lblHexResult.TabIndex = 19;
            this.lblHexResult.Text = "Hex Result:";
            // 
            // lblShiftAmount
            // 
            this.lblShiftAmount.AutoSize = true;
            this.lblShiftAmount.Location = new System.Drawing.Point(542, 321);
            this.lblShiftAmount.Name = "lblShiftAmount";
            this.lblShiftAmount.Size = new System.Drawing.Size(70, 13);
            this.lblShiftAmount.TabIndex = 27;
            this.lblShiftAmount.Text = "Shift Amount:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 201);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 227);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 10;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(12, 276);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 20;
            this.lblC.Text = "C";
            // 
            // lblCEquals
            // 
            this.lblCEquals.AutoSize = true;
            this.lblCEquals.Location = new System.Drawing.Point(12, 319);
            this.lblCEquals.Name = "lblCEquals";
            this.lblCEquals.Size = new System.Drawing.Size(20, 13);
            this.lblCEquals.TabIndex = 26;
            this.lblCEquals.Text = "C=";
            // 
            // butNotA
            // 
            this.butNotA.Location = new System.Drawing.Point(844, 195);
            this.butNotA.Name = "butNotA";
            this.butNotA.Size = new System.Drawing.Size(32, 23);
            this.butNotA.TabIndex = 9;
            this.butNotA.Text = "~";
            this.butNotA.UseVisualStyleBackColor = true;
            this.butNotA.Click += new System.EventHandler(this.butNotA_Click);
            this.butNotA.Enter += new System.EventHandler(this.OnAEnter);
            // 
            // butNotB
            // 
            this.butNotB.Location = new System.Drawing.Point(844, 222);
            this.butNotB.Name = "butNotB";
            this.butNotB.Size = new System.Drawing.Size(32, 23);
            this.butNotB.TabIndex = 16;
            this.butNotB.Text = "~";
            this.butNotB.UseVisualStyleBackColor = true;
            this.butNotB.Click += new System.EventHandler(this.butNotB_Click);
            this.butNotB.Enter += new System.EventHandler(this.OnBEnter);
            // 
            // grpBits
            // 
            this.grpBits.Controls.Add(this.rdo8);
            this.grpBits.Controls.Add(this.rdo16);
            this.grpBits.Controls.Add(this.rdo32);
            this.grpBits.Controls.Add(this.rdo64);
            this.grpBits.Location = new System.Drawing.Point(685, 300);
            this.grpBits.Name = "grpBits";
            this.grpBits.Size = new System.Drawing.Size(190, 48);
            this.grpBits.TabIndex = 25;
            this.grpBits.TabStop = false;
            this.grpBits.Text = "Bits";
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.rdoDivide);
            this.grpOperation.Controls.Add(this.rdoAdd);
            this.grpOperation.Controls.Add(this.rdoSubtract);
            this.grpOperation.Controls.Add(this.rdoMultiply);
            this.grpOperation.Controls.Add(this.rdoXor);
            this.grpOperation.Controls.Add(this.rdoOr);
            this.grpOperation.Controls.Add(this.rdoAnd);
            this.grpOperation.Location = new System.Drawing.Point(38, 300);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(408, 48);
            this.grpOperation.TabIndex = 24;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Operation";
            // 
            // rdoDivide
            // 
            this.rdoDivide.AutoSize = true;
            this.rdoDivide.Location = new System.Drawing.Point(181, 19);
            this.rdoDivide.Name = "rdoDivide";
            this.rdoDivide.Size = new System.Drawing.Size(50, 17);
            this.rdoDivide.TabIndex = 8;
            this.rdoDivide.Text = "A / B";
            this.rdoDivide.UseVisualStyleBackColor = true;
            this.rdoDivide.CheckedChanged += new System.EventHandler(this.OnOperationCheckChanged);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.Location = new System.Drawing.Point(15, 19);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(51, 17);
            this.rdoAdd.TabIndex = 7;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "A + B";
            this.rdoAdd.UseVisualStyleBackColor = true;
            this.rdoAdd.CheckedChanged += new System.EventHandler(this.OnOperationCheckChanged);
            // 
            // rdoSubtract
            // 
            this.rdoSubtract.AutoSize = true;
            this.rdoSubtract.Location = new System.Drawing.Point(72, 19);
            this.rdoSubtract.Name = "rdoSubtract";
            this.rdoSubtract.Size = new System.Drawing.Size(48, 17);
            this.rdoSubtract.TabIndex = 6;
            this.rdoSubtract.Text = "A - B";
            this.rdoSubtract.UseVisualStyleBackColor = true;
            this.rdoSubtract.CheckedChanged += new System.EventHandler(this.OnOperationCheckChanged);
            // 
            // rdoMultiply
            // 
            this.rdoMultiply.AutoSize = true;
            this.rdoMultiply.Location = new System.Drawing.Point(126, 19);
            this.rdoMultiply.Name = "rdoMultiply";
            this.rdoMultiply.Size = new System.Drawing.Size(49, 17);
            this.rdoMultiply.TabIndex = 5;
            this.rdoMultiply.Text = "A * B";
            this.rdoMultiply.UseVisualStyleBackColor = true;
            this.rdoMultiply.CheckedChanged += new System.EventHandler(this.OnOperationCheckChanged);
            // 
            // rdoXor
            // 
            this.rdoXor.AutoSize = true;
            this.rdoXor.Location = new System.Drawing.Point(347, 19);
            this.rdoXor.Name = "rdoXor";
            this.rdoXor.Size = new System.Drawing.Size(51, 17);
            this.rdoXor.TabIndex = 2;
            this.rdoXor.Text = "A ^ B";
            this.rdoXor.UseVisualStyleBackColor = true;
            this.rdoXor.CheckedChanged += new System.EventHandler(this.OnOperationCheckChanged);
            // 
            // rdoOr
            // 
            this.rdoOr.AutoSize = true;
            this.rdoOr.Location = new System.Drawing.Point(294, 19);
            this.rdoOr.Name = "rdoOr";
            this.rdoOr.Size = new System.Drawing.Size(47, 17);
            this.rdoOr.TabIndex = 1;
            this.rdoOr.Text = "A | B";
            this.rdoOr.UseVisualStyleBackColor = true;
            this.rdoOr.CheckedChanged += new System.EventHandler(this.OnOperationCheckChanged);
            // 
            // rdoAnd
            // 
            this.rdoAnd.AutoSize = true;
            this.rdoAnd.Location = new System.Drawing.Point(237, 19);
            this.rdoAnd.Name = "rdoAnd";
            this.rdoAnd.Size = new System.Drawing.Size(51, 17);
            this.rdoAnd.TabIndex = 0;
            this.rdoAnd.Text = "A && B";
            this.rdoAnd.UseVisualStyleBackColor = true;
            this.rdoAnd.CheckedChanged += new System.EventHandler(this.OnOperationCheckChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 362);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.grpBits);
            this.Controls.Add(this.butNotB);
            this.Controls.Add(this.butNotA);
            this.Controls.Add(this.lblCEquals);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblShiftAmount);
            this.Controls.Add(this.lblHexResult);
            this.Controls.Add(this.lblHexInput);
            this.Controls.Add(this.lblBinaryResult);
            this.Controls.Add(this.lblBinaryInput);
            this.Controls.Add(this.lblDecimalResult);
            this.Controls.Add(this.lblDecimalInput);
            this.Controls.Add(this.txtShiftAmount);
            this.Controls.Add(this.butRightShiftB);
            this.Controls.Add(this.butRightShiftA);
            this.Controls.Add(this.butLeftShiftB);
            this.Controls.Add(this.butLeftShiftA);
            this.Controls.Add(this.txtHexInputB);
            this.Controls.Add(this.txtHexResult);
            this.Controls.Add(this.txtHexInputA);
            this.Controls.Add(this.txtBinaryResult);
            this.Controls.Add(this.txtBinaryInputB);
            this.Controls.Add(this.txtBinaryInputA);
            this.Controls.Add(this.txtDecimalResult);
            this.Controls.Add(this.txtDecimalInputB);
            this.Controls.Add(this.txtDecimalInputA);
            this.Controls.Add(this.pnlBits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitwise Calculator v1.0 - by Ben Baker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBits.ResumeLayout(false);
            this.grpBits.PerformLayout();
            this.grpOperation.ResumeLayout(false);
            this.grpOperation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBits;
        private System.Windows.Forms.TextBox txtDecimalInputA;
        private System.Windows.Forms.TextBox txtDecimalInputB;
        private System.Windows.Forms.TextBox txtDecimalResult;
        private System.Windows.Forms.TextBox txtBinaryInputA;
        private System.Windows.Forms.TextBox txtBinaryInputB;
        private System.Windows.Forms.TextBox txtBinaryResult;
        private System.Windows.Forms.TextBox txtHexInputA;
        private System.Windows.Forms.TextBox txtHexResult;
        private System.Windows.Forms.TextBox txtHexInputB;
        private System.Windows.Forms.Button butLeftShiftA;
        private System.Windows.Forms.Button butLeftShiftB;
        private System.Windows.Forms.Button butRightShiftA;
        private System.Windows.Forms.Button butRightShiftB;
        private System.Windows.Forms.RadioButton rdo64;
        private System.Windows.Forms.RadioButton rdo32;
        private System.Windows.Forms.RadioButton rdo16;
        private System.Windows.Forms.RadioButton rdo8;
        private System.Windows.Forms.TextBox txtShiftAmount;
        private System.Windows.Forms.Label lblDecimalInput;
        private System.Windows.Forms.Label lblDecimalResult;
        private System.Windows.Forms.Label lblBinaryInput;
        private System.Windows.Forms.Label lblBinaryResult;
        private System.Windows.Forms.Label lblHexInput;
        private System.Windows.Forms.Label lblHexResult;
        private System.Windows.Forms.Label lblShiftAmount;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblCEquals;
        private System.Windows.Forms.Button butNotA;
        private System.Windows.Forms.Button butNotB;
        private System.Windows.Forms.GroupBox grpBits;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.RadioButton rdoXor;
        private System.Windows.Forms.RadioButton rdoOr;
        private System.Windows.Forms.RadioButton rdoAnd;
        private System.Windows.Forms.RadioButton rdoDivide;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSubtract;
        private System.Windows.Forms.RadioButton rdoMultiply;
    }
}

