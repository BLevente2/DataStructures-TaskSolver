using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructures___Task_Solver
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }
        #region Coppy_button
        private void Coppy_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Solution_box.Text);
        }
        #endregion
        #region Task_Selector
        private void Tasks_box_SelectedItemChanged(object sender, EventArgs e)
        {
            Solution_box.Text = string.Empty;
            switch (Tasks_box.SelectedIndex)
            {
                case 0:
                    Task2_group.Visible = false;
                    Task1_grop.Visible = true;
                    Conv_Num_box.Text = string.Empty;
                    Conv_Float_box.Text = string.Empty;
                    Task1_Mode_Check.Checked = false;
                    break;
                case 1:
                    Task2_group.Visible = true;
                    Task1_grop.Visible = false;
                    Task3_group_box.Visible = false;
                    Euc_d_box.Text = string.Empty;
                    Euc_p_box.Text = string.Empty;
                    Euc_q_box.Text = string.Empty;
                    Euc_x_box.Text = string.Empty;
                    Euc_y_box.Text = string.Empty;
                    break;
                case 2:
                    Task2_group.Visible = false;
                    Task4_group_box.Visible = false;
                    Task3_group_box.Visible = true;
                    Hash_linear.Checked = true;
                    Hash_Num_box.Text = string.Empty;
                    Hash_Op_box.Text = string.Empty;
                    Hash_Size.Text = string.Empty;
                    break;

                case 3:
                    Task5_group.Visible = false;
                    Task3_group_box.Visible = false;
                    Task4_group_box.Visible = true;
                    Quick_input_box.Text = string.Empty;
                    Quick_Output_box.Text = string.Empty;
                    break;
                case 4:
                    Task4_group_box.Visible = false;
                    Task5_group.Visible = true;
                    Task6_group_box.Visible = false;
                    Count_input_box.Text = string.Empty;
                    Count_output_box.Text = string.Empty;
                    break;
                case 5:
                    Task5_group.Visible = false;
                    Task6_group_box.Visible = true;
                    Huffman_input_box.Text = string.Empty;
                    Huffman_output_box.Text = string.Empty;
                    break;
            }
        }
        #endregion
        #region Calculate
        private void Calculate_button_Click(object sender, EventArgs e)
        {
            Solution_box.Text = string.Empty;
            switch (Tasks_box.SelectedIndex)
            {
                case -1:
                    Solution_box.Text = "Error!\nThere's no selected task!";
                    break;
                case 0:
                    Task1();
                    break;
                case 1:
                    Task2();
                    break;
                case 2:
                    Task3();
                    break;
                case 3:
                    Task4();
                    break;
                case 4:
                    Task5();
                    break;
                case 5:
                    Task6();
                    break;
            }
        }
        #endregion
        #region Task1
        void Task1()
        {
            string result = string.Empty;
            if (Task1_Mode_Check.Checked)
            {
                Conv_Num_box.Text = string.Empty;
                result = FloatToNumber();
            }
            else
            {
                Conv_Float_box.Text = string.Empty;
                result = NumberToFloat();
            }
            if (result != string.Empty)
            {
                Solution_box.Text = result;
            }
        }
        string NumberToFloat()
        {
            string result = string.Empty;
            bool sucess = true;
            double inputNum = 0;
            try
            {
                inputNum = double.Parse(Conv_Num_box.Text);
            }
            catch (FormatException ex)
            {
                sucess = false;
                Solution_box.Text += ex.Message;
            }
            if (!sucess)
            {
                return result;
            }
            result += Conv_Num_box.Text + " = ?Float32 Bytes\n\n";
            if (Conv_Num_box.Text == "0")
            {
                Conv_Float_box.Text = "00-00-00-00";
                result += Conv_Num_box.Text + " = " + Conv_Float_box.Text + " FloatBytes";
                return result;
            }
            else if (Conv_Num_box.Text == "-0")
            {
                Conv_Float_box.Text = "80-00-00-00";
                result += Conv_Num_box.Text + " = " + Conv_Float_box.Text + " FloatBytes";
                return result;
            }

            bool negative = false;
            if (inputNum < 0)
            {
                negative = true;
                inputNum = inputNum * -1;
            }
            int wholePart = (int)inputNum;
            double fractionalPart = inputNum - wholePart;
            List<char> Whole = new List<char>();
            List<char> Fraction = new List<char>();
            List<char> Bits = new List<char>();

            result += wholePart + " = ";
            while (wholePart > 0)
            {
                if (wholePart % 2 == 0)
                {
                    Whole.Add('0');
                    result += "0";
                }
                else
                {
                    Whole.Add('1');
                    result += "1";
                }
                wholePart = wholePart / 2;
            }
            wholePart = (int)inputNum;

            bool runFrectionPart = true;
            while (runFrectionPart)
            {
                fractionalPart = fractionalPart * 2;
                if (fractionalPart >= 1)
                {
                    Fraction.Add('1');
                    fractionalPart--;
                }
                else
                {
                    Fraction.Add('0');
                }
                if (fractionalPart == 0)
                {
                    runFrectionPart = false;
                }
                if (Fraction.Count + Whole.Count >= 23)
                {
                    runFrectionPart = false;
                }
            }

            Whole.Reverse();
            if (Whole.Count == 0)
            {
                result += "0";
            }
            result += "\n";
            foreach (char c in Whole)
            {
                result += c.ToString();
            }
            if (Whole.Count == 0)
            {
                result += "0";
            }
            result += " = " + wholePart + "\n" + (inputNum - wholePart) + " = ";
            foreach (char c in Fraction)
            {
                result += c.ToString();
            }
            if (Fraction.Count == 0)
            {
                result += "0";
            }
            result += "\n\n" + inputNum + " = ";
            foreach (char c in Whole)
            {
                result += c.ToString();
            }
            if (Whole.Count == 0)
            {
                result += "0";
            }
            result += ",";
            foreach (char c in Fraction)
            {
                result += c.ToString();
            }
            if (Fraction.Count == 0)
            {
                result += "0";
            }
            result += "\n";
            int FractionalShift = 0;
            if (Whole.Count == 0)
            {
                bool found = false;
                foreach (char c in Fraction)
                {
                    if (found)
                    {
                        Bits.Add(c);
                    }
                    else
                    {
                        FractionalShift--;
                    }
                    if (c == '1')
                    {
                        found = true;
                    }
                }
            }
            else if (Whole.Count == 1)
            {
                foreach (char c in Fraction)
                {
                    Bits.Add(c);
                }
            }
            else
            {
                FractionalShift = Whole.Count - 1;
                for (int i = 1; i < Whole.Count; i++)
                {
                    Bits.Add(Whole.ElementAt(i));
                }
                foreach (char c in Fraction)
                {
                    Bits.Add(c);
                }
            }
            result += "Shift: " + FractionalShift + "\n" + FractionalShift + " + 127 = ";
            List<char> Shift = new List<char>();
            FractionalShift += 127;
            result += FractionalShift + "\n" + FractionalShift + " = ";
            while (FractionalShift > 0)
            {
                if (FractionalShift % 2 == 0)
                {
                    Shift.Add('0');
                    result += "0";
                }
                else
                {
                    Shift.Add('1');
                    result += "1";
                }
                FractionalShift = FractionalShift / 2;
            }
            if (Shift.Count == 0)
            {
                result += "0";
            }
            while (Shift.Count < 8)
            {
                Shift.Add('0');
            }
            Shift.Reverse();
            result += "\n\nShift bits: ";
            foreach (char c in Shift)
            {
                result += c.ToString();
            }
            result += "\nSign bit: ";
            if (negative)
            {
                result += "1";
            }
            else
            {
                result += "0";
            }
            result += "\nMantisa: ";
            foreach (char c in Bits)
            {
                result += c.ToString();
            }
            List<char> CompleteBits = new List<char>();
            if (negative)
            {
                CompleteBits.Add('1');
            }
            else
            {
                CompleteBits.Add('0');
            }
            foreach (char c in Shift)
            {
                CompleteBits.Add(c);
            }
            foreach (char c in Bits)
            {
                CompleteBits.Add(c);
            }
            while (CompleteBits.Count < 32)
            {
                CompleteBits.Add('0');
            }
            result += "\n\nBits:\n";
            int counter = 0;
            for (int i = 0; i < CompleteBits.Count; i++)
            {
                result += CompleteBits.ElementAt(i).ToString();
                counter++;
                if (counter == 4 && i < CompleteBits.Count - 1)
                {
                    counter = 0;
                    result += "-";
                }
            }
            List<char> Bytes = new List<char>();
            char[] PossibleBytes = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            string[] PossibleBits = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            List<string> BitsAll = PossibleBits.ToList();
            for (int i = 0; i < CompleteBits.Count; i += 4)
            {
                string SearchBits = CompleteBits.ElementAt(i).ToString() + CompleteBits.ElementAt(i + 1).ToString() + CompleteBits.ElementAt(i + 2).ToString() + CompleteBits.ElementAt(i + 3).ToString();
                Bytes.Add(PossibleBytes[BitsAll.IndexOf(SearchBits)]);
            }
            string FinalResult = "";
            for (int i = 0; i < Bytes.Count; i++)
            {
                FinalResult += Bytes.ElementAt(i).ToString();
                if (i % 2 == 1 && i < Bytes.Count - 1)
                {
                    FinalResult += "-";
                }
            }
            Conv_Float_box.Text = FinalResult;
            result += "\n\n" + Conv_Num_box.Text + " = " + FinalResult + " FloatBytes";
            return result;
        }
        string FloatToNumber()
        {
            string result = string.Empty;
            string[] PossibleBits = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            char[] PossibleBytes = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            List<char> PossibleBytesList = PossibleBytes.ToList();
            string ImputBytes = string.Empty;
            if (Conv_Float_box.Text.Length == 11 && Conv_Float_box.Text.Contains('-'))
            {
                foreach (char c in Conv_Float_box.Text)
                {
                    if (c != '-')
                    {
                        ImputBytes += PossibleBits[PossibleBytesList.IndexOf(c)];
                    }
                }
            }
            else if (Conv_Float_box.Text.Length == 8 && Conv_Float_box.Text.Contains('-') == false)
            {
                foreach (char c in Conv_Float_box.Text)
                {
                    ImputBytes += PossibleBits[PossibleBytesList.IndexOf(c)];
                }
            }
            else
            {
                return "Incorrect format: " + Conv_Float_box.Text + " are not valid bytes.";
            }
            List<char> Bits = ImputBytes.ToList();
            bool negative = false;
            if (Bits.ElementAt(0) == '1')
            {
                negative = true;
            }
            bool IsZero = true;
            for (int i = 1; i < Bits.Count; i++)
            {
                if (Bits.ElementAt(i) == '1')
                {
                    IsZero = false;
                    break;
                }
            }
            result += Conv_Float_box.Text + " FloatBytes=?\n";
            if (IsZero)
            {
                if (negative)
                {
                    Conv_Num_box.Text = "-0";
                    result += Conv_Float_box.Text + " = -0";
                }
                else
                {
                    Conv_Num_box.Text = "0";
                    result += Conv_Float_box.Text + " = 0";
                }
                return result;
            }
            List<char> Shift = new List<char>();
            result += "Sign bit: ";
            if (negative)
            {
                result += "1\n";
            }
            else
            {
                result += "0\n";
            }
            result += "Shift bits: ";
            for (int i = 1; i <= 8; i++)
            {
                Shift.Add(Bits.ElementAt(i));
                result += Bits.ElementAt(i).ToString();
            }
            int fractionalShift = 0;
            Shift.Reverse();
            for (int i = 0; i < Shift.Count; i++)
            {
                if (Shift.ElementAt(i) == '1')
                {
                    fractionalShift += (int)Math.Pow(2, i);
                }
            }
            result += " = " + fractionalShift + "\n" + fractionalShift + " - 127 = ";
            fractionalShift -= 127;
            result += fractionalShift + "\n";
            List<char> Whole = new List<char>();
            List<char> Fraction = new List<char>();
            if (fractionalShift > 0)
            {
                Whole.Add('1');
                for (int i = 9; i < Bits.Count; i++)
                {
                    if (i < 9 + fractionalShift)
                    {
                        Whole.Add(Bits.ElementAt(i));
                    }
                    else
                    {
                        Fraction.Add(Bits.ElementAt(i));
                    }
                }
            }
            else if (fractionalShift == 0)
            {
                Whole.Add('1');
                for (int i = 9; i < Bits.Count; i++)
                {
                    Fraction.Add(Bits.ElementAt(i));
                }
            }
            else
            {
                fractionalShift = (fractionalShift * -1) - 1;
                while (fractionalShift != 0)
                {
                    Fraction.Add('0');
                    fractionalShift--;
                }
                Fraction.Add('1');
                for (int i = 9; i < Bits.Count; i++)
                {
                    Fraction.Add(Bits.ElementAt(i));
                }
            }
            result += "Whole Part: ";
            foreach (char c in Whole)
            {
                result += c.ToString();
            }
            result += "\nFractional Part: ";
            foreach (char c in Fraction)
            {
                result += c.ToString();
            }
            result += "\n";
            int wholePart = 0;
            double fractionalPart = 0;
            Whole.Reverse();
            for (int i = 0; i < Whole.Count; i++)
            {
                if (Whole.ElementAt(i) == '1')
                {
                    wholePart += (int)Math.Pow(2, i);
                }
            }
            for (int i = 0; i < Fraction.Count; i++)
            {
                if (Fraction.ElementAt(i) == '1')
                {
                    fractionalPart += Math.Pow(2, (i + 1) * -1);
                }
            }
            double FinalResult = wholePart + fractionalPart;
            result += "Wholeee Number = " + wholePart + "\nFractional Number = " + fractionalPart + "\n" + wholePart + " + " + fractionalPart + " = " + FinalResult + "\n";
            if (negative)
            {
                result += "-1 * " + FinalResult + " = ";
                FinalResult = FinalResult * -1;
                result += FinalResult + "\n";
            }
            Conv_Num_box.Text = FinalResult.ToString();
            result += "\n" + Conv_Float_box.Text + " FloatBytes = " + FinalResult;
            return result;
        }
        private void Task1_Mode_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Task1_Mode_Check.Checked)
            {
                Conv_Float_box.ReadOnly = false;
                Conv_Num_box.ReadOnly = true;
            }
            else
            {
                Conv_Float_box.ReadOnly = true;
                Conv_Num_box.ReadOnly = false;
            }
            Conv_Num_box.Text = string.Empty;
            Conv_Float_box.Text = string.Empty;
            Solution_box.Text = string.Empty;
        }
        #endregion
        #region Task2
        void Task2()
        {
            Euc_d_box.Text = string.Empty;
            Euc_x_box.Text = string.Empty;
            Euc_y_box.Text = string.Empty;
            int p = 0;
            int q = 0;
            bool sucess = true;
            try
            {
                p = int.Parse(Euc_p_box.Text);
                q = int.Parse(Euc_q_box.Text);
            }
            catch (FormatException ex)
            {
                sucess = false;
                Solution_box.Text += ex.Message;
            }
            if (sucess)
            {
                int d = ExtendedEuclid(p, q, out int x, out int y, out string first, out string second);
                Euc_d_box.Text = d.ToString();
                Euc_x_box.Text = x.ToString();
                Euc_y_box.Text = y.ToString();
                Solution_box.Text = "p = " + p + "\nq= " + q + "\nd*, x*, y* = ?\n\n" + first + "\n" + second + "\nd*=" + d + ", x*=" + x + ", y*=" + y;
            }
        }
        int ExtendedEuclid(int p, int q, out int x, out int y, out string first, out string second)
        {
            if (q == 0)
            {
                x = 1;
                y = 0;
                first = p + " mod " + q + " = " + p + "\n";
                second = x + " * " + p + " + " + y + " * " + q + "\n";
                return p;
            }

            else
            {
                int gcd = ExtendedEuclid(q, p % q, out int x1, out int y1, out string first1, out string second1);
                x = y1;
                y = x1 - (p / q) * y1;
                first = p + " mod " + q + " = " + (p % q) + "\n" + first1;
                second = second1 + x + " * " + p + " + " + y + " * " + q + "\n";
                return gcd;
            }
        }
        #endregion
        #region Task3
        void Task3()
        {
            bool sucess = true;
            int[] inputInts = new int[0];
            char[] inputChars = new char[0];
            char SplitHere = ' ';
            int HashTableSize = 0;
            try
            {
               inputInts = Array.ConvertAll(Hash_Num_box.Text.Split(SplitHere), int.Parse);
                inputChars = Array.ConvertAll(Hash_Op_box.Text.Split(SplitHere), char.Parse);
                HashTableSize = int.Parse(Hash_Size.Text);
                if (inputInts.Length != inputChars.Length)
                {
                    throw new FormatException(Hash_Op_box.Text);
                }
                foreach (char c in inputChars)
                {
                    if (c != 'A' && c != 'R' && c != 'S')
                    {
                        throw new FormatException(c.ToString());
                    }
                }
            }
            catch (FormatException ex)
            {
                sucess = false;
                Solution_box.Text = ex.Message;
            }
            if (sucess)
            {
                List<List<int>> ints = new List<List<int>>();
                List<List<char>> chars = new List<List<char>>();
                InitializeLists(ints, chars, HashTableSize);
                Solution_box.Text = MakeHashTable(inputInts, inputChars, HashTableSize, ints, chars);
            }
        }
        void InitializeLists(List<List<int>> ints, List<List<char>> chars, int HashTableSize)
        {
            for (int i = 0; i < HashTableSize; i++)
            {
                ints.Add(new List<int>());
                chars.Add(new List<char> ());
                for (int j = 0; j < HashTableSize; j++)
                {
                    ints[i].Add(0);
                    chars[i].Add('F'); 
                }
            }
        }

        string HashTableToString(List<List<int>> ints, List<List<char>> chars)
        {
            string result = string.Empty;
            for (int i = 0; i < ints.Count; i++)
            {
                if (chars[i].Contains('O') || chars[i].Contains('R'))
                {
                    result += i + ": ";
                    for (int j = 0; j < ints[i].Count; j++)
                    {
                        if (chars[i][j] != 'F')
                        {
                            result += ints[i][j].ToString() + " - " + chars[i][j].ToString();
                            if (j < ints[i].Count - 1)
                            {
                                result += ", ";
                            }
                        }
                    }
                    result += "\n";
                }
            }
            return result + "------------------------------\n";
        }

        string MakeHashTable(int[] inputInts, char[] inputChars, int HashTableSize, List<List<int>> ints, List<List<char>> chars)
        {
            int k1 = 0;
            int k2 = 0;
            int h = 0;
            string result = string.Empty;
            for (int j = 0; j < inputChars.Length; j++)
            {
                bool found = false;
                result += "HashTableOperation: " + inputChars[j] + "(" + inputInts[j] + ")\n";
                for (int i = 0; i < HashTableSize; i++)
                    {
                    if (Hash_linear.Checked)
                    {
                        k1 = inputInts[j] % HashTableSize;
                        h = (k1 + i) % HashTableSize;
                    }
                    else if (Hash_square.Checked)
                    {
                        k1 = inputInts[j] % HashTableSize;
                        h = (k1 + (i * (i + 1))) % HashTableSize;
                    }
                    else if (Hash_double.Checked)
                    {
                        k1 = inputInts[j] % HashTableSize;
                        k2 = (1 + inputInts[j]) % (HashTableSize - 1);
                        h = (k1 + (i * k2)) % HashTableSize;
                    }
                    switch (inputChars[j])
                    {
                        case 'A':
                            if ((chars[h][i] == 'F') || (chars[h][i] == 'R'))
                            {
                                chars[h][i] = 'O';
                                ints[h][i] = inputInts[j];
                                found = true;
                            }
                            break;
                        case 'R':
                            if (chars[h][i] == 'O' && ints[h][i] == inputInts[j])
                            {
                                chars[h][i] = 'R';
                                found = true;
                            }
                            break;
                        case 'S':
                            if (chars[h][i] == 'O' && ints[h][i] == inputInts[j])
                            {
                                result += inputInts[j] + " is at (" + h + ", " + i + ")\n";
                                found = true;
                            }
                            break;
                    }
                    if (found)
                    {
                        break;
                    }
                }
                result += HashTableToString(ints, chars);
            }
            return result;
        }


        private void Hash_linear_CheckedChanged(object sender, EventArgs e)
        {
            if (Hash_linear.Checked)
            {
                Hash_square.Checked = false;
                Hash_double.Checked = false;
            }
        }
        private void Hash_square_CheckedChanged(object sender, EventArgs e)
        {
            if (Hash_square.Checked)
            {
                Hash_linear.Checked = false;
                Hash_double.Checked = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Hash_double.Checked)
            {
                Hash_linear.Checked = false;
                Hash_square.Checked = false;
            }
        }
        #endregion
        #region Task4
        void Task4()
        {
            Quick_Output_box.Text = string.Empty;
            bool sucess = true;
            char SplitHere = ' ';
            int[] ints = new int[0];
            try
            {
                ints = Array.ConvertAll(Quick_input_box.Text.Split(SplitHere), int.Parse);
            }
            catch (FormatException ex)
            {
                sucess = false;
                Solution_box.Text = ex.Message;
            }
            if (sucess)
            {
                Solution_box.Text = "A={" + ArrayToString(ints) + "}\nQuickSort(A) = ?\n";
                NumOfPartitions = 0;
                QuickSort(ints, 0, ints.Length - 1, out string solution);
                Quick_Output_box.Text = ArrayToString(ints);
                Solution_box.Text += solution + "\nQuickSort(A)={" + Quick_Output_box.Text + "}";
            }
        }
        int NumOfPartitions = 0;
        void QuickSort(int[] array, int low, int high, out string solution)
        {
            solution = string.Empty;
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high, out string solution1);
                QuickSort(array, low, pivotIndex - 1, out string solution2);  // Before pivot
                solution += solution1 + solution2;
                QuickSort(array, pivotIndex + 1, high, out string solution3); // After pivot
                solution += solution3;
            }
        }

        int Partition(int[] array, int low, int high, out string solution)
        {
            int pivot = array[high];
            int i = (low - 1);
            NumOfPartitions++;
            solution = "\nPartition" + NumOfPartitions + ".(" + ArrayToString(array) + "), low: " + low + ", high: " + high + "\n";

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return i + 1;
        }

        void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        string ArrayToString(int[] ints)
        {
            string result = "";
            foreach (int i in ints)
            {
                result += i + " ";
            }
            return result.Remove(result.Length - 1);
        }
        #endregion
        #region Task5
        //Tassk5 uses  the string ArrayToString(array) method from region Task4
        void Task5()
        {
            bool sucess = true;
            char SplitHere = ' ';
            int[] ints = new int[0];
            try
            {
                ints = Array.ConvertAll(Count_input_box.Text.Split(SplitHere), int.Parse);
            }
            catch (FormatException ex)
            {
                sucess = false;
                Solution_box.Text = ex.Message;
            }
            if (sucess)
            {
                Solution_box.Text = "A={" + ArrayToString(ints) + "}\nCountingSort(A) = ?\n\n";
                int[] B = CountingSort(ints, out string solution);
                Count_output_box.Text = ArrayToString(B);
                Solution_box.Text += solution + "\nCountingSort(A)={" + Count_output_box.Text + "}";
            }
        }
        int[] CountingSort(int[] A, out string solution)
        {
            solution = string.Empty;
            int max = int.MinValue;
            foreach (int number in A)
            {
                if (number > max) max = number;
            }
            solution += "k (range) = " + max + "\n";
            int[] C = new int[max];
            foreach (int number in A)
            {
                C[number - 1]++;
            }
            solution += "C={" + ArrayToString(C) + "}\n";
            for (int i = 1; i < C.Length; i++)
            {
                C[i] = C[i - 1] + C[i];
            }
            solution += "C={" + ArrayToString(C) + "}\n\n";
            int[] B = new int[A.Length];

            for (int j = A.Length - 1; j >= 0; j--)
            {
                B[C[A[j] - 1] - 1] = A[j];
                C[A[j] - 1]--;
                solution += "B={" + ArrayToString(B) + "}\nC={" + ArrayToString(C) + "}\n";
            }
            return B;
        }
        #endregion
        #region Task6
        void Task6()
        {
            string solution = Huffman_input_box.Text + " = ? HuffmanCode\n\n";
            char[] inputCharacters = Huffman_input_box.Text.ToCharArray();
            List<char> ABC = new List<char>();
            List<int> CharFrequency = new List<int>();
            foreach (char c in inputCharacters)
            {
                if (ABC.Contains(c))
                {
                    CharFrequency[ABC.IndexOf(c)]++;
                }
                else
                {
                    ABC.Add(c);
                    CharFrequency.Add(1);
                }
            }
            List<string> TreeHelp = new List<string>();
            foreach (char c in ABC)
            {
                TreeHelp.Add(c.ToString());
            }
            solution += "ABC Count: " + ABC.Count + "\n" + FrequecyToString(TreeHelp, CharFrequency) + "\n\n";

            string[] CodesBinary = new string[ABC.Count];
            for (int i = 1; i < CodesBinary.Length; i++)
            {
                MinSort(TreeHelp, CharFrequency);
                AdjustBinaryCodes(TreeHelp.ElementAt(0), ABC, CodesBinary, false);
                AdjustBinaryCodes(TreeHelp.ElementAt(1), ABC, CodesBinary, true);
                SumAndRemoveFirstElement(TreeHelp, CharFrequency);
                solution += FrequecyToString(TreeHelp, CharFrequency) + "\n";
            }

            List<string> CodedText = new List<string>();
            foreach (char c in inputCharacters)
            {
                CodedText.Add(CodesBinary.ElementAt(ABC.IndexOf(c)));
            }
            string HuffmanCode = string.Empty;
            int characterCounter = 0;
            for (int i = 0; i < CodedText.Count; i++)
            {
                HuffmanCode += CodedText.ElementAt(i);
                characterCounter += CodedText.ElementAt(i).Length;
                if (i < (CodedText.Count - 1))
                {
                    HuffmanCode += "-";
                }
            }
            solution += "\nCharacter codes:\n";
            for (int i = 0; i < ABC.Count; i++)
            {
                solution += ABC.ElementAt(i).ToString() + ": " + CodesBinary.ElementAt(i) + "\n";
            }
            solution += "\nHuffmanCoded Text: " + HuffmanCode + "\nCodeLength: " + characterCounter + " bits\n";
            int fixedLength = inputCharacters.Length * (int)Math.Ceiling(Math.Log2(ABC.Count));
            solution += "Fixed BitLength: " + fixedLength + ", so it's " + (fixedLength - characterCounter) + " bit less with HuffmanCoding.";
            Huffman_output_box.Text = HuffmanCode;
            Solution_box.Text = solution;
        }

        string FrequecyToString(List<string> TreeHelp, List<int> CharFrequecy)
        {
            string result = string.Empty;
            for (int i = 0; i < TreeHelp.Count; i++)
            {
                result += TreeHelp[i] + ": " + CharFrequecy[i];
                if (i < (TreeHelp.Count - 1))
                {
                    result += ", ";
                }
            }
            return result;
        }
        void SumAndRemoveFirstElement(List<string> TreeHelp, List<int> CharFrequency)
        {
            if (TreeHelp.Count <= 1)
            {
                return;
            }
            CharFrequency[1] += CharFrequency[0];
            TreeHelp[1] += TreeHelp[0];
            CharFrequency.Remove(CharFrequency[0]);
            TreeHelp.Remove(TreeHelp[0]);
        }

        void AdjustBinaryCodes(string input, List<char> ABC, string[] Binary, bool right)
        {
            char[] inputChars = input.ToCharArray();
            foreach (char c in inputChars)
            {
                if (right)
                {
                    Binary[ABC.IndexOf(c)] = "1" + Binary[ABC.IndexOf(c)];
                }
                else
                {
                    Binary[ABC.IndexOf(c)] = "0" + Binary[ABC.IndexOf(c)];
                }
            }
        }

        void MinSort(List<string> strings, List<int> ints)
        {
            int tempInt = 0;
            string tempString = string.Empty;
            int min = int.MaxValue;
            for (int i = 0; i < ints.Count; i++)
            {
                min = int.MaxValue;
                for (int j = i; j < ints.Count; j++)
                {
                    if (min > ints.ElementAt(j))
                    {
                        min = ints.ElementAt(j);
                        tempInt = ints.ElementAt(i);
                        tempString = strings.ElementAt(i);
                        ints[i] = ints[j];
                        strings[i] = strings[j];
                        ints[j] = tempInt;
                        strings[j] = tempString;
                    }
                }
            }
        }
        #endregion
    }
}

// This code was written by Levente Baba (HLFA5R) for the Data Structures and Algorithms course in University of Miskolc (2024)