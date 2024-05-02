namespace DataStructures___Task_Solver
{
    partial class Main_Window
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
            Solution_box = new RichTextBox();
            solution_label = new Label();
            Task2_group = new GroupBox();
            Euc_y_box = new TextBox();
            Euc_d_box = new TextBox();
            Euc_x_box = new TextBox();
            Euc_q_box = new TextBox();
            Euc_p_box = new TextBox();
            Calculate_button = new Button();
            Coppy_button = new Button();
            Tasks_box = new DomainUpDown();
            Task4_group_box = new GroupBox();
            Quick_Output_box = new TextBox();
            Quick_input_box = new TextBox();
            Task_Selector_label = new Label();
            Task1_grop = new GroupBox();
            Conv_Eq_box = new Label();
            Conv_Float_box = new TextBox();
            Conv_Num_box = new TextBox();
            Task1_Mode_Check = new CheckBox();
            Task5_group = new GroupBox();
            Count_output_box = new TextBox();
            Count_input_box = new TextBox();
            Task6_group_box = new GroupBox();
            Huffman_output_box = new TextBox();
            Huffman_input_box = new TextBox();
            Task3_group_box = new GroupBox();
            Hash_label2 = new Label();
            Hash_Size = new TextBox();
            Hash_label = new Label();
            Hash_Op_box = new TextBox();
            Hash_Num_box = new TextBox();
            Hash_double = new RadioButton();
            Hash_square = new RadioButton();
            Hash_linear = new RadioButton();
            Task2_group.SuspendLayout();
            Task4_group_box.SuspendLayout();
            Task1_grop.SuspendLayout();
            Task5_group.SuspendLayout();
            Task6_group_box.SuspendLayout();
            Task3_group_box.SuspendLayout();
            SuspendLayout();
            // 
            // Solution_box
            // 
            Solution_box.BackColor = SystemColors.Window;
            Solution_box.Location = new Point(734, 44);
            Solution_box.Name = "Solution_box";
            Solution_box.ReadOnly = true;
            Solution_box.Size = new Size(502, 393);
            Solution_box.TabIndex = 3;
            Solution_box.Text = "";
            // 
            // solution_label
            // 
            solution_label.AutoSize = true;
            solution_label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            solution_label.ForeColor = SystemColors.WindowText;
            solution_label.Location = new Point(739, 11);
            solution_label.Name = "solution_label";
            solution_label.Size = new Size(144, 30);
            solution_label.TabIndex = 5;
            solution_label.Text = "Task Solution:";
            // 
            // Task2_group
            // 
            Task2_group.Controls.Add(Euc_y_box);
            Task2_group.Controls.Add(Euc_d_box);
            Task2_group.Controls.Add(Euc_x_box);
            Task2_group.Controls.Add(Euc_q_box);
            Task2_group.Controls.Add(Euc_p_box);
            Task2_group.ForeColor = SystemColors.WindowText;
            Task2_group.Location = new Point(12, 164);
            Task2_group.Name = "Task2_group";
            Task2_group.Size = new Size(686, 273);
            Task2_group.TabIndex = 4;
            Task2_group.TabStop = false;
            Task2_group.Text = "Task2 - Extended Euclidean Algorithm";
            Task2_group.Visible = false;
            // 
            // Euc_y_box
            // 
            Euc_y_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Euc_y_box.Location = new Point(508, 163);
            Euc_y_box.Name = "Euc_y_box";
            Euc_y_box.PlaceholderText = "y*";
            Euc_y_box.ReadOnly = true;
            Euc_y_box.Size = new Size(121, 39);
            Euc_y_box.TabIndex = 4;
            Euc_y_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Euc_d_box
            // 
            Euc_d_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Euc_d_box.Location = new Point(49, 163);
            Euc_d_box.Name = "Euc_d_box";
            Euc_d_box.PlaceholderText = "d*";
            Euc_d_box.ReadOnly = true;
            Euc_d_box.Size = new Size(121, 39);
            Euc_d_box.TabIndex = 3;
            Euc_d_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Euc_x_box
            // 
            Euc_x_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Euc_x_box.Location = new Point(276, 163);
            Euc_x_box.Name = "Euc_x_box";
            Euc_x_box.PlaceholderText = "x*";
            Euc_x_box.ReadOnly = true;
            Euc_x_box.Size = new Size(121, 39);
            Euc_x_box.TabIndex = 2;
            Euc_x_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Euc_q_box
            // 
            Euc_q_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Euc_q_box.Location = new Point(276, 57);
            Euc_q_box.Name = "Euc_q_box";
            Euc_q_box.PlaceholderText = "q";
            Euc_q_box.Size = new Size(121, 39);
            Euc_q_box.TabIndex = 1;
            Euc_q_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Euc_p_box
            // 
            Euc_p_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Euc_p_box.Location = new Point(49, 57);
            Euc_p_box.Name = "Euc_p_box";
            Euc_p_box.PlaceholderText = "p";
            Euc_p_box.Size = new Size(121, 39);
            Euc_p_box.TabIndex = 0;
            Euc_p_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Calculate_button
            // 
            Calculate_button.Cursor = Cursors.Hand;
            Calculate_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Calculate_button.ForeColor = SystemColors.WindowText;
            Calculate_button.Location = new Point(538, 11);
            Calculate_button.Name = "Calculate_button";
            Calculate_button.Size = new Size(160, 74);
            Calculate_button.TabIndex = 1;
            Calculate_button.Text = "Calculate";
            Calculate_button.UseVisualStyleBackColor = true;
            Calculate_button.Click += Calculate_button_Click;
            // 
            // Coppy_button
            // 
            Coppy_button.Cursor = Cursors.Hand;
            Coppy_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Coppy_button.ForeColor = SystemColors.WindowText;
            Coppy_button.Location = new Point(538, 93);
            Coppy_button.Name = "Coppy_button";
            Coppy_button.Size = new Size(160, 74);
            Coppy_button.TabIndex = 2;
            Coppy_button.Text = "Coppy";
            Coppy_button.UseVisualStyleBackColor = true;
            Coppy_button.Click += Coppy_button_Click;
            // 
            // Tasks_box
            // 
            Tasks_box.BackColor = SystemColors.Window;
            Tasks_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tasks_box.Items.Add("Task1 - Float Conversion");
            Tasks_box.Items.Add("Task2 - Extended Euclidean Algorithm");
            Tasks_box.Items.Add("Task3 - Hash table");
            Tasks_box.Items.Add("Task4 - Quick Sort");
            Tasks_box.Items.Add("Task5 - Counting Sort");
            Tasks_box.Items.Add("Task6 - Huffman Code");
            Tasks_box.Location = new Point(12, 74);
            Tasks_box.Name = "Tasks_box";
            Tasks_box.ReadOnly = true;
            Tasks_box.Size = new Size(503, 39);
            Tasks_box.TabIndex = 0;
            Tasks_box.Text = "Choose a Task";
            Tasks_box.SelectedItemChanged += Tasks_box_SelectedItemChanged;
            // 
            // Task4_group_box
            // 
            Task4_group_box.Controls.Add(Quick_Output_box);
            Task4_group_box.Controls.Add(Quick_input_box);
            Task4_group_box.ForeColor = SystemColors.WindowText;
            Task4_group_box.Location = new Point(12, 164);
            Task4_group_box.Name = "Task4_group_box";
            Task4_group_box.Size = new Size(686, 273);
            Task4_group_box.TabIndex = 6;
            Task4_group_box.TabStop = false;
            Task4_group_box.Text = "Task4 - Quick Sort";
            Task4_group_box.Visible = false;
            // 
            // Quick_Output_box
            // 
            Quick_Output_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Quick_Output_box.Location = new Point(44, 174);
            Quick_Output_box.Name = "Quick_Output_box";
            Quick_Output_box.PlaceholderText = "Sorted int array";
            Quick_Output_box.ReadOnly = true;
            Quick_Output_box.Size = new Size(613, 39);
            Quick_Output_box.TabIndex = 1;
            Quick_Output_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Quick_input_box
            // 
            Quick_input_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Quick_input_box.Location = new Point(44, 82);
            Quick_input_box.Name = "Quick_input_box";
            Quick_input_box.PlaceholderText = "Please enter your int array here, separated by spaces!";
            Quick_input_box.Size = new Size(613, 39);
            Quick_input_box.TabIndex = 0;
            Quick_input_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Task_Selector_label
            // 
            Task_Selector_label.AutoSize = true;
            Task_Selector_label.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Task_Selector_label.ForeColor = SystemColors.WindowText;
            Task_Selector_label.Location = new Point(12, 29);
            Task_Selector_label.Name = "Task_Selector_label";
            Task_Selector_label.Size = new Size(144, 30);
            Task_Selector_label.TabIndex = 7;
            Task_Selector_label.Text = "Task Selector:";
            // 
            // Task1_grop
            // 
            Task1_grop.Controls.Add(Conv_Eq_box);
            Task1_grop.Controls.Add(Conv_Float_box);
            Task1_grop.Controls.Add(Conv_Num_box);
            Task1_grop.Controls.Add(Task1_Mode_Check);
            Task1_grop.ForeColor = SystemColors.WindowText;
            Task1_grop.Location = new Point(12, 164);
            Task1_grop.Name = "Task1_grop";
            Task1_grop.Size = new Size(686, 274);
            Task1_grop.TabIndex = 8;
            Task1_grop.TabStop = false;
            Task1_grop.Text = "Task1 - Float Conversion";
            Task1_grop.Visible = false;
            // 
            // Conv_Eq_box
            // 
            Conv_Eq_box.AutoSize = true;
            Conv_Eq_box.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Conv_Eq_box.Location = new Point(314, 85);
            Conv_Eq_box.Name = "Conv_Eq_box";
            Conv_Eq_box.Size = new Size(36, 38);
            Conv_Eq_box.TabIndex = 3;
            Conv_Eq_box.Text = "=";
            Conv_Eq_box.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Conv_Float_box
            // 
            Conv_Float_box.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Conv_Float_box.Location = new Point(374, 82);
            Conv_Float_box.Name = "Conv_Float_box";
            Conv_Float_box.PlaceholderText = "Float Bytes";
            Conv_Float_box.ReadOnly = true;
            Conv_Float_box.Size = new Size(234, 45);
            Conv_Float_box.TabIndex = 2;
            Conv_Float_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Conv_Num_box
            // 
            Conv_Num_box.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Conv_Num_box.Location = new Point(44, 82);
            Conv_Num_box.Name = "Conv_Num_box";
            Conv_Num_box.PlaceholderText = "Number";
            Conv_Num_box.Size = new Size(234, 45);
            Conv_Num_box.TabIndex = 1;
            Conv_Num_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Task1_Mode_Check
            // 
            Task1_Mode_Check.AutoSize = true;
            Task1_Mode_Check.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Task1_Mode_Check.Location = new Point(34, 198);
            Task1_Mode_Check.Name = "Task1_Mode_Check";
            Task1_Mode_Check.Size = new Size(574, 42);
            Task1_Mode_Check.TabIndex = 0;
            Task1_Mode_Check.Text = "Reverse Calculation: Float Bytes to Number";
            Task1_Mode_Check.UseVisualStyleBackColor = true;
            Task1_Mode_Check.CheckedChanged += Task1_Mode_Check_CheckedChanged;
            // 
            // Task5_group
            // 
            Task5_group.Controls.Add(Count_output_box);
            Task5_group.Controls.Add(Count_input_box);
            Task5_group.ForeColor = SystemColors.WindowText;
            Task5_group.Location = new Point(12, 164);
            Task5_group.Name = "Task5_group";
            Task5_group.Size = new Size(686, 274);
            Task5_group.TabIndex = 9;
            Task5_group.TabStop = false;
            Task5_group.Text = "Task5 - Counting Sort";
            Task5_group.Visible = false;
            // 
            // Count_output_box
            // 
            Count_output_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Count_output_box.Location = new Point(44, 174);
            Count_output_box.Name = "Count_output_box";
            Count_output_box.PlaceholderText = "Sorted int array";
            Count_output_box.ReadOnly = true;
            Count_output_box.Size = new Size(613, 39);
            Count_output_box.TabIndex = 2;
            Count_output_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Count_input_box
            // 
            Count_input_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Count_input_box.Location = new Point(44, 82);
            Count_input_box.Name = "Count_input_box";
            Count_input_box.PlaceholderText = "Please enter your int array here, separated by spaces!";
            Count_input_box.Size = new Size(613, 39);
            Count_input_box.TabIndex = 2;
            Count_input_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Task6_group_box
            // 
            Task6_group_box.Controls.Add(Huffman_output_box);
            Task6_group_box.Controls.Add(Huffman_input_box);
            Task6_group_box.ForeColor = SystemColors.WindowText;
            Task6_group_box.Location = new Point(12, 164);
            Task6_group_box.Name = "Task6_group_box";
            Task6_group_box.Size = new Size(686, 274);
            Task6_group_box.TabIndex = 10;
            Task6_group_box.TabStop = false;
            Task6_group_box.Text = "Task6 - Huffman Code";
            Task6_group_box.Visible = false;
            // 
            // Huffman_output_box
            // 
            Huffman_output_box.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Huffman_output_box.Location = new Point(49, 168);
            Huffman_output_box.Name = "Huffman_output_box";
            Huffman_output_box.PlaceholderText = "Huffman Code";
            Huffman_output_box.ReadOnly = true;
            Huffman_output_box.Size = new Size(585, 45);
            Huffman_output_box.TabIndex = 1;
            Huffman_output_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Huffman_input_box
            // 
            Huffman_input_box.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Huffman_input_box.Location = new Point(49, 72);
            Huffman_input_box.Name = "Huffman_input_box";
            Huffman_input_box.PlaceholderText = "Your Text";
            Huffman_input_box.Size = new Size(585, 45);
            Huffman_input_box.TabIndex = 0;
            Huffman_input_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Task3_group_box
            // 
            Task3_group_box.Controls.Add(Hash_label2);
            Task3_group_box.Controls.Add(Hash_Size);
            Task3_group_box.Controls.Add(Hash_label);
            Task3_group_box.Controls.Add(Hash_Op_box);
            Task3_group_box.Controls.Add(Hash_Num_box);
            Task3_group_box.Controls.Add(Hash_double);
            Task3_group_box.Controls.Add(Hash_square);
            Task3_group_box.Controls.Add(Hash_linear);
            Task3_group_box.ForeColor = SystemColors.WindowText;
            Task3_group_box.Location = new Point(12, 164);
            Task3_group_box.Name = "Task3_group_box";
            Task3_group_box.Size = new Size(686, 273);
            Task3_group_box.TabIndex = 11;
            Task3_group_box.TabStop = false;
            Task3_group_box.Text = "Task3 - Hash table";
            Task3_group_box.Visible = false;
            // 
            // Hash_label2
            // 
            Hash_label2.AutoSize = true;
            Hash_label2.Location = new Point(266, 177);
            Hash_label2.Name = "Hash_label2";
            Hash_label2.Size = new Size(368, 25);
            Hash_label2.TabIndex = 16;
            Hash_label2.Text = "* O means Occupied and R means Removed.";
            // 
            // Hash_Size
            // 
            Hash_Size.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Hash_Size.Location = new Point(21, 170);
            Hash_Size.Name = "Hash_Size";
            Hash_Size.PlaceholderText = "HashTable Size (int)";
            Hash_Size.Size = new Size(211, 39);
            Hash_Size.TabIndex = 15;
            Hash_Size.TextAlign = HorizontalAlignment.Center;
            // 
            // Hash_label
            // 
            Hash_label.AutoSize = true;
            Hash_label.Location = new Point(21, 128);
            Hash_label.Name = "Hash_label";
            Hash_label.Size = new Size(454, 25);
            Hash_label.TabIndex = 14;
            Hash_label.Text = "A: Add, R: Remove, S: Search,   (Separate it with spaces!)";
            // 
            // Hash_Op_box
            // 
            Hash_Op_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Hash_Op_box.Location = new Point(21, 85);
            Hash_Op_box.Name = "Hash_Op_box";
            Hash_Op_box.PlaceholderText = "Enter what you wish to do with the ints in the array!";
            Hash_Op_box.Size = new Size(613, 39);
            Hash_Op_box.TabIndex = 13;
            Hash_Op_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Hash_Num_box
            // 
            Hash_Num_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Hash_Num_box.Location = new Point(21, 35);
            Hash_Num_box.Name = "Hash_Num_box";
            Hash_Num_box.PlaceholderText = "Please enter your int array here, separated by spaces!";
            Hash_Num_box.Size = new Size(613, 39);
            Hash_Num_box.TabIndex = 12;
            Hash_Num_box.TextAlign = HorizontalAlignment.Center;
            // 
            // Hash_double
            // 
            Hash_double.AutoSize = true;
            Hash_double.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Hash_double.Location = new Point(431, 216);
            Hash_double.Name = "Hash_double";
            Hash_double.Size = new Size(117, 36);
            Hash_double.TabIndex = 2;
            Hash_double.Text = "Double";
            Hash_double.UseVisualStyleBackColor = true;
            Hash_double.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Hash_square
            // 
            Hash_square.AutoSize = true;
            Hash_square.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Hash_square.Location = new Point(258, 216);
            Hash_square.Name = "Hash_square";
            Hash_square.Size = new Size(113, 36);
            Hash_square.TabIndex = 1;
            Hash_square.Text = "Square";
            Hash_square.UseVisualStyleBackColor = true;
            Hash_square.CheckedChanged += Hash_square_CheckedChanged;
            // 
            // Hash_linear
            // 
            Hash_linear.AutoSize = true;
            Hash_linear.Checked = true;
            Hash_linear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Hash_linear.Location = new Point(106, 216);
            Hash_linear.Name = "Hash_linear";
            Hash_linear.Size = new Size(103, 36);
            Hash_linear.TabIndex = 0;
            Hash_linear.TabStop = true;
            Hash_linear.Text = "Linear";
            Hash_linear.UseVisualStyleBackColor = true;
            Hash_linear.CheckedChanged += Hash_linear_CheckedChanged;
            // 
            // Main_Window
            // 
            AccessibleName = "DataStructuresTaskSolver";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1244, 450);
            Controls.Add(Coppy_button);
            Controls.Add(Task_Selector_label);
            Controls.Add(Tasks_box);
            Controls.Add(Calculate_button);
            Controls.Add(solution_label);
            Controls.Add(Solution_box);
            Controls.Add(Task3_group_box);
            Controls.Add(Task6_group_box);
            Controls.Add(Task5_group);
            Controls.Add(Task1_grop);
            Controls.Add(Task4_group_box);
            Controls.Add(Task2_group);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main_Window";
            ShowIcon = false;
            Text = "DataStructures - Task Solver  by Levente Baba";
            Task2_group.ResumeLayout(false);
            Task2_group.PerformLayout();
            Task4_group_box.ResumeLayout(false);
            Task4_group_box.PerformLayout();
            Task1_grop.ResumeLayout(false);
            Task1_grop.PerformLayout();
            Task5_group.ResumeLayout(false);
            Task5_group.PerformLayout();
            Task6_group_box.ResumeLayout(false);
            Task6_group_box.PerformLayout();
            Task3_group_box.ResumeLayout(false);
            Task3_group_box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Solution_box;
        private Label solution_label;
        private GroupBox Task2_group;
        private Button Calculate_button;
        private Button Coppy_button;
        private DomainUpDown Tasks_box;
        private TextBox Euc_p_box;
        private TextBox Euc_d_box;
        private TextBox Euc_x_box;
        private TextBox Euc_q_box;
        private TextBox Euc_y_box;
        private GroupBox Task4_group_box;
        private TextBox Quick_input_box;
        private TextBox Quick_Output_box;
        private Label Task_Selector_label;
        private GroupBox Task1_grop;
        private CheckBox Task1_Mode_Check;
        private Label Conv_Eq_box;
        private TextBox Conv_Float_box;
        private TextBox Conv_Num_box;
        private GroupBox Task5_group;
        private TextBox Count_input_box;
        private TextBox Count_output_box;
        private GroupBox Task6_group_box;
        private TextBox Huffman_input_box;
        private TextBox Huffman_output_box;
        private GroupBox Task3_group_box;
        private RadioButton Hash_linear;
        private RadioButton Hash_double;
        private RadioButton Hash_square;
        private Label Hash_label;
        private TextBox Hash_Op_box;
        private TextBox Hash_Num_box;
        private TextBox Hash_Size;
        private Label Hash_label2;
    }
}
