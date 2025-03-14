using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static lab_1.InternerOperatorList;

namespace lab_1
{
    enum indexComboBox: int
    {
        COMBOBOX1,
        COMBOBOX2,
    }

    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        private InternerOperatorList _localList;

        private Dictionary<int, Panel> _panelDict;

        private Dictionary<String, bool> _boolDict;

        private delegate void OnListChange(String mess, InternetOperator local);

        private delegate void UpdateTable();


        private event OnListChange _onEditing;

        private event OnListChange _onAdd;

        private event OnListChange _onDelete;

        private event UpdateTable _onUpdateTable;

        private int _cntTests = 1;



        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = new List<Specification>()
            {
                Specification.ADSL,
                Specification.DOCSIS,
                Specification.MOBILE,
                Specification.SATELLITE
            };
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = -1;

            comboBox2.DataSource = new List<Specification>()
            {
                Specification.ADSL,
                Specification.DOCSIS,
                Specification.MOBILE,
                Specification.SATELLITE
            };
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.SelectedIndex = -1;

            comboBox4.DataSource = new List<bool>()
            {
                true,
                false
            };
            comboBox4.SelectedIndex = -1;

            comboBox6.DataSource = new List<bool>()
            {
                true,
                false
            };
            comboBox6.SelectedIndex = -1;


            comboBox3.DataSource = new List<int>()
            {
                FormsConstans.VALUE0,
                FormsConstans.VALUE1,
                FormsConstans.VALUE2,
                FormsConstans.VALUE3,
                FormsConstans.VALUE4,
            };

            _localList = new InternerOperatorList();

            _panelDict = new Dictionary<int, Panel>()
            {
                [FormsConstans.VALUE1] = namePanel,
                [FormsConstans.VALUE2] = pricePanel,
                [FormsConstans.VALUE3] = usercntPanel,
                [FormsConstans.VALUE4] = typePanel
            };
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;

            _onUpdateTable = displayOperators;

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

            if (cntParams == FormsConstans.VALUE4)
            {
                if (comboBox1.SelectedIndex == -1 || comboBox4.SelectedIndex == -1) { throw new FieldNotChosen(); }
            }

        }

        private IFabric chooseFabric(bool choosen)
        {
            switch (choosen)
            {
                case true:
                    return new FabricVpnSup();
                case false:
                    return new FabricVpnNoSup();
                default:
                    return null;
            }
        }

        private Connection chooseObj(ComboBox comboBox, IFabric fabric)
        {
            switch (comboBox.SelectedItem)
            {
                case Specification.ADSL:
                    return fabric.createADSL();
                case Specification.DOCSIS:
                    return fabric.createDOCSIS();
                case Specification.MOBILE:
                    return fabric.createMobile();
                case Specification.SATELLITE:
                    return fabric.createSatellite();
                default:
                    return null;
            }
        }

        private InternetOperator chooseConstructor(int cntParams)
        {
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
                    IFabric fabric = chooseFabric(Convert.ToBoolean(comboBox4.SelectedItem));
                    Connection connetction = chooseObj(comboBox1, fabric);
                    return new InternetOperator(textBox2.Text, decimal.Parse(textBox4.Text),
                        (int)numericUpDown1.Value, connetction);
                default:
                    return null;
            }
        }

        private InternetOperator createOperator(int cntParams)
        {
            checkValues(cntParams);
            return chooseConstructor(cntParams);
        }

        private TextBox[] chooseTextBox(indexComboBox index)
        {
            switch (index)
            {
                case indexComboBox.COMBOBOX1:
                    return new TextBox[] { textBox9, textBox10 };
                case indexComboBox.COMBOBOX2:
                    return new TextBox[] { textBox7, textBox8 };
                default:
                    return null;
            }
        }

        private String[] chooseSpecific(ComboBox comboBox)
        {
            switch (comboBox.SelectedItem)
            {
                case Specification.ADSL:
                    return new String[] { ConnectionType.WIRED.ToString(), Speed.ADSL };
                case Specification.MOBILE:
                    return new String[] { ConnectionType.WIRELESS.ToString(), Speed.MOBILE };
                case Specification.DOCSIS:
                    return new String[] { ConnectionType.WIRED.ToString(), Speed.DOCSIS };
                case Specification.SATELLITE:
                    return new String[] { ConnectionType.WIRELESS.ToString(), Speed.SATELLITE };
                default:
                    return null;
            }
        }

        private void inputSpecific(TextBox[] textBoxes, String[] parametrs)
        {
            if (parametrs == null) return;
            textBoxes[0].Text = parametrs[0];
            textBoxes[1].Text = parametrs[1];
        }

        private void displayTypeParams(ComboBox comboBox, indexComboBox index)
        {
            TextBox[] textBoxes = chooseTextBox(index);
            String[] parametrs = chooseSpecific(comboBox);
            inputSpecific(textBoxes, parametrs);


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayTypeParams(comboBox1, indexComboBox.COMBOBOX1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayTypeParams(comboBox2, indexComboBox.COMBOBOX2);
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

        private void clearInput(TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4,
            NumericUpDown numericUp, ComboBox comboBox1, ComboBox comboBox2)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            numericUp.Value = 0;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
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

                if (!localOperator.NameOperator.Equals(textBox3.Text) ||
                    localOperator.PriceOfMonth != decimal.Parse(textBox5.Text) ||
                    localOperator.CntUsers != (int)numericUpDown3.Value ||
                    localOperator.Connection.Specification != (Specification)comboBox2.SelectedItem ||
                    localOperator.Connection.Vpn != (bool)comboBox6.SelectedItem)
                {
                    localOperator.NameOperator = textBox3.Text;
                    localOperator.PriceOfMonth = decimal.Parse(textBox5.Text);
                    localOperator.CntUsers = (int)numericUpDown3.Value;
                    IFabric fabric = chooseFabric(Convert.ToBoolean(comboBox6.SelectedItem));
                    Connection connetction = chooseObj(comboBox2, fabric);
                    localOperator.Connection = connetction;
                    _onEditing = edit;
                    _onEditing?.Invoke(IntOperConsts.EDITING, localOperator);
                }


            }
            catch (Exception ex)
            {
                MessageBox(this.Handle, ex.Message, "Œ¯Ë·Í‡", 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                InternetOperator localOperator = createOperator(int.Parse(comboBox3.SelectedItem.ToString()));
                _localList.Add(localOperator);
                comboBox5.Items.Add(localOperator.NameOperator);
                InternetOperator.cntObj++;
                textBox1.Text = InternetOperator.cntObj.ToString();

                clearInput(textBox2, textBox4, textBox9, textBox10, numericUpDown1, comboBox1, comboBox4);

                _onAdd = add;
                _onAdd?.Invoke(IntOperConsts.ADDING, localOperator);
                _onUpdateTable?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox(this.Handle, ex.Message, "Œ¯Ë·Í‡", 0);
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
                comboBox2.SelectedItem = localOperator.Connection.Specification;
                comboBox6.SelectedItem = localOperator.Connection.Vpn;

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "")
                {
                    InternetOperator localOperator = _localList.getByName(textBox3.Text);
                    _localList.del(textBox3.Text);
                    InternetOperator.cntObj--;
                    textBox1.Text = InternetOperator.cntObj.ToString();
                    comboBox5.Items.Remove(textBox3.Text);
                    String deletedName = textBox3.Text;

                    clearInput(textBox3, textBox5, textBox7, textBox8, numericUpDown3, comboBox2, comboBox6);

                    _onDelete = delete;
                    _onDelete?.Invoke(IntOperConsts.DELETING, localOperator);
                    _onUpdateTable?.Invoke();
                }
                else
                {
                    throw new ObjWasntChosen();
                }
            }
            catch (Exception ex)
            {
                MessageBox(this.Handle, ex.Message, "Œ¯Ë·Í‡", 0);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] result;
            String type;
            if (radioButton2.Checked)
            {
                result = _localList.test(IntOperLstConsts.SEQUENCESELECT);
                type = IntOperLstConsts.SEQUENCESELECT;
            }
            else
            {
                result = _localList.test(IntOperLstConsts.RANDOMSELECT);
                type = IntOperLstConsts.RANDOMSELECT;
            }
            listView1.Items.Add(new ListViewItem());
            ListViewItem item = new ListViewItem();
            item.SubItems.Clear();
            item.SubItems[0].Text = (_cntTests.ToString());
            item.SubItems.Add(result[0].ToString());
            item.SubItems.Add(result[1].ToString());
            item.SubItems.Add(type);
            listView1.Items.Add(item);
            _cntTests++;

        }

        private void displayOperators()
        {
            listView2.Items.Clear();
            foreach (var oper in _localList)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = oper.NameOperator;
                listView2.Items.Add(item);
            }
        }

        private void edit(String mess, InternetOperator local)
        {
            MessageBox(this.Handle, mess + local.NameOperator, IntOperConsts.TITLE, 0);
        }

        private void add(String mess, InternetOperator local)
        {
            MessageBox(this.Handle, mess + local.NameOperator, IntOperConsts.TITLE, 0);
        }

        private void delete(String mess, InternetOperator local)
        {
            MessageBox(this.Handle, mess + local.NameOperator, IntOperConsts.TITLE, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
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
