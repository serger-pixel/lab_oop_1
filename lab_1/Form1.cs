using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static lab_1.InternerOperatorList;

namespace lab_1
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        private InternerOperatorList _localList;

        private Dictionary<int, Panel> _panelDict;

        private Dictionary<String, bool> _boolDict;

        private delegate int Editing(IntPtr hWnd, String text, String caption, uint type);

        private event Editing _editing;


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

            _editing += MessageBox;

            HideAllPanels();
        }

        private void checkValues(int cntParams)
        {
            if (comboBox3.SelectedItem.ToString().Equals(FormsConstans.VALUE0.ToString()) &&
                _localList.find(InternetOperator.NAME)) { throw new ObjectExists(); }
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
                        (int)numericUpDown1.Value, ((int)numericUpDown2.Value).ToString("X"));
                case FormsConstans.VALUE5:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value, ((int)numericUpDown2.Value).ToString("X"), _boolDict[comboBox10.Text]);
                case FormsConstans.VALUE6:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value, ((int)numericUpDown2.Value).ToString("X"), _boolDict[comboBox10.Text],
                        _boolDict[comboBox4.Text]);
                case FormsConstans.VALUE7:
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value, ((int)numericUpDown2.Value).ToString("X"), _boolDict[comboBox10.Text],
                        _boolDict[comboBox4.Text], _boolDict[comboBox9.Text]);
                default:
                    return null;
            }
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

                localOperator.NameOperator = textBox3.Text;
                localOperator.PriceOfMonth = decimal.Parse(textBox5.Text);
                localOperator.CntUsers = (int)numericUpDown3.Value;
                localOperator.SpeedMb = ((int)numericUpDown4.Value).ToString("X");
                localOperator.Support5g = _boolDict[comboBox8.Text];
                localOperator.FamilySharing = _boolDict[comboBox6.Text];
                localOperator.RoutArend = _boolDict[comboBox7.Text];
                _editing?.Invoke(this.Handle, IntOperConsts.EDITING + localOperator.NameOperator, IntOperConsts.TITLE, 0);

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
                _localList.add(localOperator, this.Handle);
                comboBox5.Items.Add(localOperator.NameOperator);
                textBox1.Text = InternetOperator.cntObj.ToString();
                _editing?.Invoke(this.Handle, IntOperConsts.ADDING + localOperator.NameOperator, IntOperConsts.TITLE, 0);
            }
            catch (Exception ex)
            {
                MessageBox(this.Handle, ex.Message, "Îøèáêà", 0);
            }
        }


        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != -1)
            {
                InternetOperator localOperator = _localList.getByName(comboBox5.SelectedItem.ToString());
                textBox3.Text = localOperator.NameOperator;
                textBox5.Text = localOperator.PriceOfMonth.ToString();
                numericUpDown3.Value = localOperator.CntUsers;
                numericUpDown4.Value = Convert.ToInt32(localOperator.SpeedMb, 16);
                comboBox8.Text = localOperator.Support5g.ToString();
                comboBox6.Text = localOperator.FamilySharing.ToString();
                comboBox7.Text = localOperator.RoutArend.ToString();
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
