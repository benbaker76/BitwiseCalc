using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexCalc
{
    public partial class frmMain : Form
    {
        private enum ValueType
        {
            ValueA,
            ValueB,
            ValueC
        };

        private int m_bitCount = 64;
        private UInt64[] m_valueArray = { 0, 0, 0 };
        private SizeF m_bitSize = SizeF.Empty;
        private Button[] m_bitButtons = new Button[64];
        private TextBox[] m_bitTextBoxes = new TextBox[64];

        private ValueType m_valueSelected = ValueType.ValueA;

        private char[] m_decimalChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private char[] m_hexChars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        private char[] m_binaryChars = new char[] { '0', '1' };

        private ToolTip m_toolTip = new ToolTip();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            m_toolTip.SetToolTip(rdoAdd, "Add");
            m_toolTip.SetToolTip(rdoSubtract, "Subtract");
            m_toolTip.SetToolTip(rdoDivide, "Divide");
            m_toolTip.SetToolTip(rdoMultiply, "Multiply");
            m_toolTip.SetToolTip(rdoAnd, "And");
            m_toolTip.SetToolTip(rdoOr, "Or");
            m_toolTip.SetToolTip(rdoXor, "Xor");

            m_toolTip.SetToolTip(butLeftShiftA, "Left Shift");
            m_toolTip.SetToolTip(butLeftShiftB, "Left Shift");

            m_toolTip.SetToolTip(butRightShiftA, "Right Shift");
            m_toolTip.SetToolTip(butRightShiftB, "Right Shift");

            m_toolTip.SetToolTip(butNotA, "Not");
            m_toolTip.SetToolTip(butNotB, "Not");

            m_bitSize = new SizeF(pnlBits.Width / m_bitCount, pnlBits.Width / m_bitCount);

            CreateBitButtons();
        }

        private void pnlBits_Paint(object sender, PaintEventArgs e)
        {
            Font bitFont = new Font(new FontFamily("Lucida Console"), 10, FontStyle.Regular, GraphicsUnit.Pixel);
            UInt64 value = m_valueArray[(int)m_valueSelected];

            e.Graphics.DrawLine(Pens.LightGray, new Point((int)(pnlBits.ClientSize.Width - m_bitCount * m_bitSize.Width), pnlBits.ClientSize.Height - 58), new Point(pnlBits.ClientSize.Width, pnlBits.ClientSize.Height - 58));

            for (int i = 0; i < m_bitCount + 1; i++)
            {
                UInt64 bitValue = (UInt64)1 << i;
                string bitString = String.Format("{0:00} {1:X}", i, bitValue);

                e.Graphics.TranslateTransform(pnlBits.ClientSize.Width - m_bitSize.Width * i - m_bitSize.Height, pnlBits.Height - m_bitSize.Width - 28);
                e.Graphics.RotateTransform(-90);

                if (i < m_bitCount)
                {
                    using (SolidBrush solidBrush = new SolidBrush(Color.Black))
                        e.Graphics.DrawString(bitString, bitFont, solidBrush, Point.Empty);
                }

                if (i % 8 == 0 || i == 0)
                {
                    using (Pen pen = new Pen(Brushes.LightGray, 2))
                        e.Graphics.DrawLine(pen, new Point(-24, (int)m_bitSize.Width - 1), new Point(pnlBits.ClientSize.Width, (int)m_bitSize.Width - 1));
                }
                else if (i % 4 == 0)
                {
                    e.Graphics.DrawLine(Pens.LightGray, new Point(-24,(int)m_bitSize.Width - 1), new Point(pnlBits.ClientSize.Width, (int)m_bitSize.Width - 1));
                }

                e.Graphics.ResetTransform();
            }
        }

        private void CreateBitButtons()
        {
            pnlBits.SuspendLayout();

            pnlBits.Controls.Clear();

            Font bitFont = new Font(new FontFamily("Lucida Console"), 8, FontStyle.Regular, GraphicsUnit.Pixel);
            UInt64 value = m_valueArray[(int)m_valueSelected];

            for (int i = 0; i < m_bitCount; i++)
            {
                UInt64 bitValue = (UInt64)1 << i;
                int index = 0;

                if ((i + 1) % 4 == 0)
                {
                    index = i / 4;

                    m_bitTextBoxes[index] = new TextBox();
                    m_bitTextBoxes[index].Tag = index;
                    m_bitTextBoxes[index].Location = new Point(pnlBits.ClientSize.Width - i * (int)m_bitSize.Width - (int)m_bitSize.Width - 1, pnlBits.ClientSize.Height - (int)m_bitSize.Height - 7);
                    m_bitTextBoxes[index].Size = new Size((int)m_bitSize.Width * 4, (int)m_bitSize.Height);
                    m_bitTextBoxes[index].TextAlign = HorizontalAlignment.Center;
                    m_bitTextBoxes[index].MaxLength = 1;
                    m_bitTextBoxes[index].TextChanged += OnBitTextChanged;
                    m_bitTextBoxes[index].TabIndex = m_bitCount + (m_bitCount - 1) / 4 - index;

                    pnlBits.Controls.Add(m_bitTextBoxes[index]);
                }

                index = i;

                m_bitButtons[index] = new Button();
                m_bitButtons[index].Tag = index;
                m_bitButtons[index].Location = new Point(pnlBits.ClientSize.Width - i * (int)m_bitSize.Width - (int)m_bitSize.Width - 1, pnlBits.ClientSize.Height - (int)m_bitSize.Height - 28);
                m_bitButtons[index].Size = new Size((int)m_bitSize.Width, (int)m_bitSize.Height + 4);
                m_bitButtons[index].FlatStyle = FlatStyle.Standard;
                m_bitButtons[index].Text = ((value & bitValue) != 0 ? "1" : "0");
                m_bitButtons[index].TextAlign = ContentAlignment.MiddleCenter;
                m_bitButtons[index].Font = bitFont;
                m_bitButtons[index].TabIndex = m_bitCount - 1 - index;
                m_bitButtons[index].Click += OnBitButtonClick;

                m_toolTip.SetToolTip(m_bitButtons[index], index.ToString());

                pnlBits.Controls.Add(m_bitButtons[index]);
            }

            pnlBits.ResumeLayout(false);
        }

        private void OnBitButtonClick(object sender, EventArgs e)
        {
            Button bitButton = (Button)sender;
            int index = (int)bitButton.Tag;
            UInt64 value = m_valueArray[(int)m_valueSelected];
            UInt64 bitValue = (UInt64)1 << index;

            value ^= bitValue;

            m_valueArray[(int)m_valueSelected] = value;

            UpdateAll();
        }

        private void UpdateAll()
        {
            lock (this)
            {
                if (rdoAdd.Checked)
                {
                    m_valueArray[(int)ValueType.ValueC] = m_valueArray[(int)ValueType.ValueA] + m_valueArray[(int)ValueType.ValueB];
                }
                else if (rdoSubtract.Checked)
                {
                    m_valueArray[(int)ValueType.ValueC] = m_valueArray[(int)ValueType.ValueA] - m_valueArray[(int)ValueType.ValueB];
                }
                else if (rdoDivide.Checked)
                {
                    m_valueArray[(int)ValueType.ValueC] = (m_valueArray[(int)ValueType.ValueB] != 0 ? m_valueArray[(int)ValueType.ValueA] / m_valueArray[(int)ValueType.ValueB] : 0);
                }
                else if (rdoMultiply.Checked)
                {
                    m_valueArray[(int)ValueType.ValueC] = m_valueArray[(int)ValueType.ValueA] * m_valueArray[(int)ValueType.ValueB];
                }
                else if (rdoAnd.Checked)
                {
                    m_valueArray[(int)ValueType.ValueC] = m_valueArray[(int)ValueType.ValueA] & m_valueArray[(int)ValueType.ValueB];
                }
                else if (rdoOr.Checked)
                {
                    m_valueArray[(int)ValueType.ValueC] = m_valueArray[(int)ValueType.ValueA] | m_valueArray[(int)ValueType.ValueB];
                }
                else if (rdoXor.Checked)
                {
                    m_valueArray[(int)ValueType.ValueC] = m_valueArray[(int)ValueType.ValueA] ^ m_valueArray[(int)ValueType.ValueB];
                }

                if (rdo8.Checked)
                {
                    m_valueArray[(int)ValueType.ValueA] &= 0xFF;
                    m_valueArray[(int)ValueType.ValueB] &= 0xFF;
                    m_valueArray[(int)ValueType.ValueC] &= 0xFF;
                }
                else if (rdo16.Checked)
                {
                    m_valueArray[(int)ValueType.ValueA] &= 0xFFFF;
                    m_valueArray[(int)ValueType.ValueB] &= 0xFFFF;
                    m_valueArray[(int)ValueType.ValueC] &= 0xFFFF;
                }
                else if (rdo32.Checked)
                {
                    m_valueArray[(int)ValueType.ValueA] &= 0xFFFFFFFF;
                    m_valueArray[(int)ValueType.ValueB] &= 0xFFFFFFFF;
                    m_valueArray[(int)ValueType.ValueC] &= 0xFFFFFFFF;
                }
                else if (rdo64.Checked)
                {
                    m_valueArray[(int)ValueType.ValueA] &= 0xFFFFFFFFFFFFFFFF;
                    m_valueArray[(int)ValueType.ValueB] &= 0xFFFFFFFFFFFFFFFF;
                    m_valueArray[(int)ValueType.ValueC] &= 0xFFFFFFFFFFFFFFFF;
                }

                txtDecimalInputA.Text = m_valueArray[(int)ValueType.ValueA].ToString();
                txtBinaryInputA.Text = Convert.ToString((long)m_valueArray[(int)ValueType.ValueA], 2);
                txtHexInputA.Text = m_valueArray[(int)ValueType.ValueA].ToString("X");

                txtDecimalInputB.Text = m_valueArray[(int)ValueType.ValueB].ToString();
                txtBinaryInputB.Text = Convert.ToString((long)m_valueArray[(int)ValueType.ValueB], 2);
                txtHexInputB.Text = m_valueArray[(int)ValueType.ValueB].ToString("X");

                txtDecimalResult.Text = m_valueArray[(int)ValueType.ValueC].ToString();
                txtBinaryResult.Text = Convert.ToString((long)m_valueArray[(int)ValueType.ValueC], 2);
                txtHexResult.Text = m_valueArray[(int)ValueType.ValueC].ToString("X");

                UInt64 value = m_valueArray[(int)m_valueSelected];

                for (int i = 0; i < m_bitCount; i++)
                {
                    UInt64 bitValue = (UInt64)1 << i;

                    if (i % 4 == 0)
                    {
                        int index = (i >> 2);
                        byte nibble = (byte)((value >> (index << 2)) & 0xF);
                        m_bitTextBoxes[index].Text = nibble.ToString("X");
                    }

                    m_bitButtons[i].Text = ((value & bitValue) != 0 ? "1" : "0");
                }
            }
        }

        private void OnBitTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int index = (int)textBox.Tag;
            byte nibble = 0;

            if (!Byte.TryParse(textBox.Text, NumberStyles.HexNumber, null, out nibble))
                return;

            m_valueArray[(int)m_valueSelected] &= ~((UInt64)0xF << index * 4);
            m_valueArray[(int)m_valueSelected] |= (UInt64)nibble << index * 4;

            UpdateAll();
        }

        private void OnAEnter(object sender, EventArgs e)
        {
            m_valueSelected = ValueType.ValueA;

            UpdateAll();
        }

        private void OnBEnter(object sender, EventArgs e)
        {
            m_valueSelected = ValueType.ValueB;

            UpdateAll();
        }

        private void OnOperationCheckChanged(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void OnBitCheckChanged(object sender, EventArgs e)
        {
            if (rdo8.Checked)
            {
                m_bitCount = 8;
            }
            else if (rdo16.Checked)
            {
                m_bitCount = 16;
            }
            else if (rdo32.Checked)
            {
                m_bitCount = 32;
            }
            else if (rdo64.Checked)
            {
                m_bitCount = 64;
            }

            CreateBitButtons();

            pnlBits.Invalidate();

            UpdateAll();
        }

        private void OnDecimalTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ulong value = 0;

            if (UInt64.TryParse(textBox.Text, NumberStyles.Integer, null, out value))
                m_valueArray[(int)m_valueSelected] = value;

            UpdateAll();
        }

        private void OnBinaryTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                m_valueArray[(int)m_valueSelected] = Convert.ToUInt64(textBox.Text, 2);
            }
            catch
            {
            }

            UpdateAll();
        }

        private void OnHexTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ulong value = 0;

            if (UInt64.TryParse(textBox.Text, NumberStyles.HexNumber, null, out value))
                m_valueArray[(int)m_valueSelected] = value;

            UpdateAll();
        }

        private void OnDecimalKeypress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (Char.IsNumber(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                if (!m_decimalChars.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void OnBinaryKeypress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (Char.IsNumber(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                if (!m_binaryChars.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void OnHexKeypress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (Char.IsNumber(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);

                if (!m_hexChars.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void butLeftShiftA_Click(object sender, EventArgs e)
        {
            Int32 value = 0;

            if (Int32.TryParse(txtShiftAmount.Text, NumberStyles.Integer, null, out value))
                m_valueArray[(int)ValueType.ValueA] <<= value;

            UpdateAll();
        }

        private void butRightShiftA_Click(object sender, EventArgs e)
        {
            Int32 value = 0;

            if (Int32.TryParse(txtShiftAmount.Text, NumberStyles.Integer, null, out value))
                m_valueArray[(int)ValueType.ValueA] >>= value;

            UpdateAll();
        }

        private void butNotA_Click(object sender, EventArgs e)
        {
            m_valueArray[(int)ValueType.ValueA] = ~m_valueArray[(int)ValueType.ValueA];

            UpdateAll();
        }

        private void butLeftShiftB_Click(object sender, EventArgs e)
        {
            Int32 value = 0;

            if (Int32.TryParse(txtShiftAmount.Text, NumberStyles.Integer, null, out value))
                m_valueArray[(int)ValueType.ValueB] <<= value;

            UpdateAll();
        }

        private void butRightShiftB_Click(object sender, EventArgs e)
        {
            Int32 value = 0;

            if (Int32.TryParse(txtShiftAmount.Text, NumberStyles.Integer, null, out value))
                m_valueArray[(int)ValueType.ValueB] >>= value;

            UpdateAll();
        }

        private void butNotB_Click(object sender, EventArgs e)
        {
            m_valueArray[(int)ValueType.ValueB] = ~m_valueArray[(int)ValueType.ValueB];

            UpdateAll();
        }
    }
}
