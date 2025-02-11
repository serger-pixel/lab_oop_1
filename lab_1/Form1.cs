using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace lab_oop_1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        private InternerOperatorList _localList;

        private Dictionary<int, Panel> _panelDict;

        private Dictionary<String, bool> _boolDict;


        public Form1()
        {
            InitializeComponent();

            comboBox8.DataSource = new List<String>() { FormsConstans.TRUEKEY, FormsConstans.FALSEKEY };
            comboBox8.SelectedIndex = -1;

            comboBox6.DataSource = new List<String>() { FormsConstans.TRUEKEY, FormsConstans.FALSEKEY };
            comboBox6.SelectedIndex = -1;

            comboBox7.DataSource = new List<String>() { FormsConstans.TRUEKEY, FormsConstans.FALSEKEY };
            comboBox7.SelectedIndex = -1;


            comboBox10.DataSource = new List<String>() { FormsConstans.TRUEKEY, FormsConstans.FALSEKEY };
            comboBox10.SelectedIndex = -1;

            comboBox4.DataSource = new List<String>() { FormsConstans.TRUEKEY, FormsConstans.FALSEKEY };
            comboBox4.SelectedIndex = -1;

            comboBox9.DataSource = new List<String>() { FormsConstans.TRUEKEY, FormsConstans.FALSEKEY };
            comboBox9.SelectedIndex = -1;

            comboBox3.DataSource = new List<int>()
            {
                FormsConstans.VALUE0,
                FormsConstans.VALUE1,
                FormsConstans.VALUE2,
                FormsConstans.VALUE3,
                FormsConstans.VALUE4,
                FormsConstans.VALUE5,
                FormsConstans.VALUE6,
                FormsConstans.VALUE7,

            };

            comboBox1.DataSource = new List<String>()
            {
                IntOperConsts.KeyNameOperator,
                IntOperConsts.KeyPriceOfMonth,
                IntOperConsts.KeycntUsers,
                IntOperConsts.KeySpeedMb,
                IntOperConsts.KeySupport5g,
                IntOperConsts.KeyfamilySharing,
                IntOperConsts.KeyRoutArend
            };

            _localList = new InternerOperatorList();

            _panelDict = new Dictionary<int, Panel>()
            {
                [FormsConstans.VALUE1] = namePanel,
                [FormsConstans.VALUE2] = pricePanel,
                [FormsConstans.VALUE3] = usercntPanel,
                [FormsConstans.VALUE4] = speedPanel,
                [FormsConstans.VALUE5] = sup5gPanel,
                [FormsConstans.VALUE6] = familyPanel,
                [FormsConstans.VALUE7] = routerPanel

            };

            _boolDict = new Dictionary<String, bool>()
            {
                [FormsConstans.TRUEKEY] = FormsConstans.TRUEVALUE,
                [FormsConstans.FALSEKEY] = FormsConstans.FALSEVALUE
            };

            HideAllPanels();
        }

        private void checkValues(int cntParams) 
        {
            if (cntParams == FormsConstans.VALUE0) { return; }
            if (_localList.find(textBox2.Text)) { throw new ObjectExists(); }
            if (cntParams >= FormsConstans.VALUE1) 
            {
                Regex regex = new Regex(Regs._nameReg);
                if (!regex.Match(textBox2.Text).Success)
                {
                    throw new NameException();
                }
            }

            if (cntParams >= FormsConstans.VALUE2) 
            {
                Regex regex = new Regex(Regs._priceReg);
                if (!regex.Match(textBox4.Text).Success)
                {
                    throw new PriceException();
                }
            }

            if (cntParams >= FormsConstans.VALUE3) 
            {
                Regex regex = new Regex(Regs._cntUsersReg);
                if (numericUpDown1.Value == Regs.zeroUsers) 
                {
                    throw new CntZeroUsers();
                }

                if (!regex.Match(numericUpDown1.Value.ToString()).Success) 
                {
                    throw new CntUsersException();
                }
            }

            if (cntParams >= FormsConstans.VALUE4)
            {
                if (numericUpDown2.Value > Regs.maxSpeed || numericUpDown2.Value < Regs.minSpeed) 
                {
                    throw new SpeedException();
                }
            }

            if (cntParams >= FormsConstans.VALUE5) 
            {
                if (comboBox10.SelectedIndex == -1) { throw new FieldNotChosen(); }
            }
            if (cntParams >= FormsConstans.VALUE6)
            {
                if (comboBox4.SelectedIndex == -1) { throw new FieldNotChosen(); }
            }
            if (cntParams >= FormsConstans.VALUE7)
            {
                if (comboBox9.SelectedIndex == -1) { throw new FieldNotChosen(); }
            }



        }

        private InternetOperator createOperator(int cntParams)
        {
            checkValues(cntParams);
            switch (cntParams)
            {
                case FormsConstans.VALUE0:
                    return new InternetOperator();
                case FormsConstans.VALUE1:
                    return new InternetOperator(textBox2.Text);
                case FormsConstans.VALUE2:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text));
                case FormsConstans.VALUE3:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value);
                case FormsConstans.VALUE4:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value, (int)numericUpDown2.Value);
                case FormsConstans.VALUE5:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value, (int)numericUpDown2.Value, _boolDict[comboBox10.Text]);
                case FormsConstans.VALUE6:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value, (int)numericUpDown2.Value, _boolDict[comboBox10.Text],
                        _boolDict[comboBox4.Text]);
                case FormsConstans.VALUE7:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value, (int)numericUpDown2.Value, _boolDict[comboBox10.Text],
                        _boolDict[comboBox4.Text], _boolDict[comboBox9.Text]);
                default:
                    return null;
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllPanels();
            int value = comboBox3.SelectedIndex;
            for (int i = FormsConstans.VALUE1; i <= FormsConstans.VALUE7; i++)
            {
                if (value >= i)
                {
                    _panelDict[i].Visible = true;
                    _panelDict[i].Controls[0].Visible = true;
                    _panelDict[i].Controls[1].Visible = true;
                    if (value == i)
                    {
                        break;
                    }
                }
            }

        }

        private void HideAllPanels()
        {
            foreach (var pair in _panelDict)
            {
                pair.Value.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            try
            {
                if (comboBox5.SelectedIndex == -1) { throw new ObjWasntChosen(); }
                InternetOperator localOperator = _localList.getByName(comboBox5.SelectedItem.ToString());
                Regex regex = new Regex(Regs._nameReg);
                if (!regex.Match(textBox3.Text).Success)
                {
                    throw new NameException();
                }
                regex = new Regex(Regs._priceReg);
                if (!regex.Match(textBox5.Text).Success)
                {
                    throw new PriceException();
                }
                regex = new Regex(Regs._cntUsersReg);
                if (numericUpDown3.Value == Regs.zeroUsers)
                {
                    throw new CntZeroUsers();
                }
                if (!regex.Match(numericUpDown3.Value.ToString()).Success)
                {
                    throw new CntUsersException();
                }
                if (numericUpDown3.Value > Regs.maxSpeed || numericUpDown4.Value < Regs.minSpeed)
                {
                    throw new SpeedException();
                }

                localOperator.setNameOperator(textBox3.Text);
                localOperator.setPriceOfMonth(decimal.Parse(textBox5.Text));
                localOperator.setCntUsers((int)numericUpDown3.Value);
                localOperator.setSpeedMb((int)numericUpDown4.Value);
                localOperator.setSupport5g(_boolDict[comboBox8.Text]);
                localOperator.setFamilySharing(_boolDict[comboBox6.Text]);
                localOperator.setRoutArend(_boolDict[comboBox7.Text]);

            }
            catch (Exception ex)
            {
                MessageBox(this.Handle, ex.Message, "Îøèáêà", 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                InternetOperator localOperator = createOperator(int.Parse(comboBox3.SelectedItem.ToString()));
                _localList.add(localOperator);
                comboBox2.Items.Add(localOperator.getNameOperator());
                comboBox5.Items.Add(localOperator.getNameOperator());
            }
            catch (Exception ex)
            {
                MessageBox(this.Handle, ex.Message, "Îøèáêà", 0);
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {
                if (comboBox2.SelectedIndex == -1) { throw new ObjWasntChosen(); }

                InternetOperator localOperator = _localList.getByName(comboBox2.SelectedItem.ToString());
                switch (comboBox1.SelectedItem.ToString()) 
                {
                    case IntOperConsts.KeyNameOperator:
                        richTextBox1.Text = localOperator.getNameOperator();
                        break;

                    case IntOperConsts.KeyPriceOfMonth:
                        richTextBox1.Text = localOperator.getPriceOfMonth().ToString();
                        break;

                    case IntOperConsts.KeycntUsers:
                        richTextBox1.Text = localOperator.getCntUsers().ToString();
                        break;

                    case IntOperConsts.KeySpeedMb:
                        richTextBox1.Text = localOperator.getSpeedMb().ToString();
                        break;

                    case IntOperConsts.KeySupport5g:
                        richTextBox1.Text = localOperator.getSupport5g().ToString();
                        break;

                    case IntOperConsts.KeyfamilySharing:
                        richTextBox1.Text = localOperator.getFamilySharing().ToString();
                        break;

                    case IntOperConsts.KeyRoutArend:
                        richTextBox1.Text = localOperator.getRoutArend().ToString();
                        break;

                    case IntOperConsts.KeyAll:
                        richTextBox1.Text = localOperator.ToString();
                        break;

                    default:
                        break;
                }

            }
            catch (ObjWasntChosen ex)
            {
                MessageBox(this.Handle, ex.Message, "Îøèáêà", 0);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1)
            {

                InternetOperator localOperator = _localList.getByName(comboBox5.SelectedItem.ToString());
                textBox3.Text = localOperator.getNameOperator();
                textBox5.Text = localOperator.getPriceOfMonth().ToString();
                numericUpDown3.Value = localOperator.getCntUsers();
                numericUpDown4.Value = localOperator.getSpeedMb();
                comboBox8.Text = localOperator.getSupport5g().ToString();
                comboBox6.Text = localOperator.getFamilySharing().ToString();
                comboBox7.Text = localOperator.getRoutArend().ToString();
            }
 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public static class FormsConstans
    {
        public const int VALUE0 = 0;
        public const int VALUE1 = 1;
        public const int VALUE2 = 2;
        public const int VALUE3 = 3;
        public const int VALUE4 = 4;
        public const int VALUE5 = 5;
        public const int VALUE6 = 6;
        public const int VALUE7 = 7;

        public const String TRUEKEY = "true";
        public const String FALSEKEY = "false";
        public const bool TRUEVALUE = true;
        public const bool FALSEVALUE = false;

    }
}
