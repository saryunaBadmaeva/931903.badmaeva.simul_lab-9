
namespace Simulation_lab_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.lb_trials = new System.Windows.Forms.Label();
            this.lb_prob5 = new System.Windows.Forms.Label();
            this.lb_prob4 = new System.Windows.Forms.Label();
            this.lb_prob2 = new System.Windows.Forms.Label();
            this.lb_prob3 = new System.Windows.Forms.Label();
            this.lb_prob1 = new System.Windows.Forms.Label();
            this.trials = new System.Windows.Forms.NumericUpDown();
            this.lbProb5 = new System.Windows.Forms.Label();
            this.nUD4 = new System.Windows.Forms.NumericUpDown();
            this.nUD3 = new System.Windows.Forms.NumericUpDown();
            this.nUD2 = new System.Windows.Forms.NumericUpDown();
            this.nUD1 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTF = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbZnac = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbHi = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbErVar = new System.Windows.Forms.Label();
            this.lbErMean = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbStatVar = new System.Windows.Forms.Label();
            this.lbTerVar = new System.Windows.Forms.Label();
            this.lbStatMean = new System.Windows.Forms.Label();
            this.lbTerMean = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 639);
            this.panel1.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.btStart);
            this.panel5.Controls.Add(this.lb_trials);
            this.panel5.Controls.Add(this.lb_prob5);
            this.panel5.Controls.Add(this.lb_prob4);
            this.panel5.Controls.Add(this.lb_prob2);
            this.panel5.Controls.Add(this.lb_prob3);
            this.panel5.Controls.Add(this.lb_prob1);
            this.panel5.Controls.Add(this.trials);
            this.panel5.Controls.Add(this.lbProb5);
            this.panel5.Controls.Add(this.nUD4);
            this.panel5.Controls.Add(this.nUD3);
            this.panel5.Controls.Add(this.nUD2);
            this.panel5.Controls.Add(this.nUD1);
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(263, 326);
            this.panel5.TabIndex = 1;
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btStart.Location = new System.Drawing.Point(62, 272);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(89, 38);
            this.btStart.TabIndex = 11;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lb_trials
            // 
            this.lb_trials.AutoSize = true;
            this.lb_trials.Location = new System.Drawing.Point(12, 237);
            this.lb_trials.Name = "lb_trials";
            this.lb_trials.Size = new System.Drawing.Size(120, 20);
            this.lb_trials.TabIndex = 10;
            this.lb_trials.Text = "Number of trials";
            // 
            // lb_prob5
            // 
            this.lb_prob5.AutoSize = true;
            this.lb_prob5.Location = new System.Drawing.Point(12, 197);
            this.lb_prob5.Name = "lb_prob5";
            this.lb_prob5.Size = new System.Drawing.Size(54, 20);
            this.lb_prob5.TabIndex = 9;
            this.lb_prob5.Text = "prob 5";
            // 
            // lb_prob4
            // 
            this.lb_prob4.AutoSize = true;
            this.lb_prob4.Location = new System.Drawing.Point(12, 162);
            this.lb_prob4.Name = "lb_prob4";
            this.lb_prob4.Size = new System.Drawing.Size(54, 20);
            this.lb_prob4.TabIndex = 8;
            this.lb_prob4.Text = "prob 4";
            // 
            // lb_prob2
            // 
            this.lb_prob2.AutoSize = true;
            this.lb_prob2.Location = new System.Drawing.Point(12, 75);
            this.lb_prob2.Name = "lb_prob2";
            this.lb_prob2.Size = new System.Drawing.Size(54, 20);
            this.lb_prob2.TabIndex = 7;
            this.lb_prob2.Text = "prob 2";
            // 
            // lb_prob3
            // 
            this.lb_prob3.AutoSize = true;
            this.lb_prob3.Location = new System.Drawing.Point(12, 117);
            this.lb_prob3.Name = "lb_prob3";
            this.lb_prob3.Size = new System.Drawing.Size(54, 20);
            this.lb_prob3.TabIndex = 7;
            this.lb_prob3.Text = "prob 3";
            // 
            // lb_prob1
            // 
            this.lb_prob1.AutoSize = true;
            this.lb_prob1.Location = new System.Drawing.Point(12, 27);
            this.lb_prob1.Name = "lb_prob1";
            this.lb_prob1.Size = new System.Drawing.Size(54, 20);
            this.lb_prob1.TabIndex = 6;
            this.lb_prob1.Text = "prob 1";
            // 
            // trials
            // 
            this.trials.Location = new System.Drawing.Point(138, 235);
            this.trials.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.trials.Name = "trials";
            this.trials.Size = new System.Drawing.Size(73, 26);
            this.trials.TabIndex = 5;
            // 
            // lbProb5
            // 
            this.lbProb5.AutoSize = true;
            this.lbProb5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbProb5.Location = new System.Drawing.Point(86, 197);
            this.lbProb5.Name = "lbProb5";
            this.lbProb5.Size = new System.Drawing.Size(18, 20);
            this.lbProb5.TabIndex = 11;
            this.lbProb5.Text = "1";
            // 
            // nUD4
            // 
            this.nUD4.DecimalPlaces = 3;
            this.nUD4.Location = new System.Drawing.Point(90, 156);
            this.nUD4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUD4.Name = "nUD4";
            this.nUD4.Size = new System.Drawing.Size(73, 26);
            this.nUD4.TabIndex = 3;
            this.nUD4.ValueChanged += new System.EventHandler(this.nUD4_ValueChanged);
            // 
            // nUD3
            // 
            this.nUD3.DecimalPlaces = 3;
            this.nUD3.Location = new System.Drawing.Point(90, 115);
            this.nUD3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD3.Name = "nUD3";
            this.nUD3.Size = new System.Drawing.Size(73, 26);
            this.nUD3.TabIndex = 2;
            this.nUD3.ValueChanged += new System.EventHandler(this.nUD3_ValueChanged);
            // 
            // nUD2
            // 
            this.nUD2.DecimalPlaces = 3;
            this.nUD2.Location = new System.Drawing.Point(90, 69);
            this.nUD2.Name = "nUD2";
            this.nUD2.Size = new System.Drawing.Size(73, 26);
            this.nUD2.TabIndex = 1;
            this.nUD2.ValueChanged += new System.EventHandler(this.nUD2_ValueChanged);
            // 
            // nUD1
            // 
            this.nUD1.DecimalPlaces = 3;
            this.nUD1.Location = new System.Drawing.Point(90, 25);
            this.nUD1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD1.Name = "nUD1";
            this.nUD1.Size = new System.Drawing.Size(73, 26);
            this.nUD1.TabIndex = 0;
            this.nUD1.ValueChanged += new System.EventHandler(this.nUD1_ValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(321, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(609, 316);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // lbTF
            // 
            this.lbTF.AutoSize = true;
            this.lbTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTF.ForeColor = System.Drawing.Color.Red;
            this.lbTF.Location = new System.Drawing.Point(866, 143);
            this.lbTF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTF.Name = "lbTF";
            this.lbTF.Size = new System.Drawing.Size(54, 29);
            this.lbTF.TabIndex = 55;
            this.lbTF.Text = "true";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(756, 143);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 29);
            this.label16.TabIndex = 54;
            this.label16.Text = "9.488";
            // 
            // lbZnac
            // 
            this.lbZnac.AutoSize = true;
            this.lbZnac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbZnac.Location = new System.Drawing.Point(735, 143);
            this.lbZnac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbZnac.Name = "lbZnac";
            this.lbZnac.Size = new System.Drawing.Size(25, 29);
            this.lbZnac.TabIndex = 53;
            this.lbZnac.Text = "?";
            this.lbZnac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(831, 143);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 29);
            this.label15.TabIndex = 52;
            this.label15.Text = "is";
            // 
            // lbHi
            // 
            this.lbHi.AutoSize = true;
            this.lbHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHi.Location = new System.Drawing.Point(682, 143);
            this.lbHi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHi.Name = "lbHi";
            this.lbHi.Size = new System.Drawing.Size(26, 29);
            this.lbHi.TabIndex = 51;
            this.lbHi.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(538, 143);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 29);
            this.label19.TabIndex = 50;
            this.label19.Text = "Chi-squared:";
            // 
            // lbErVar
            // 
            this.lbErVar.AutoSize = true;
            this.lbErVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErVar.Location = new System.Drawing.Point(735, 81);
            this.lbErVar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbErVar.Name = "lbErVar";
            this.lbErVar.Size = new System.Drawing.Size(26, 29);
            this.lbErVar.TabIndex = 49;
            this.lbErVar.Text = "0";
            // 
            // lbErMean
            // 
            this.lbErMean.AutoSize = true;
            this.lbErMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErMean.Location = new System.Drawing.Point(735, 50);
            this.lbErMean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbErMean.Name = "lbErMean";
            this.lbErMean.Size = new System.Drawing.Size(26, 29);
            this.lbErMean.TabIndex = 48;
            this.lbErMean.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(538, 81);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 29);
            this.label17.TabIndex = 47;
            this.label17.Text = "Variance:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(538, 50);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 29);
            this.label18.TabIndex = 46;
            this.label18.Text = "Math expectation:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(538, 15);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 29);
            this.label14.TabIndex = 45;
            this.label14.Text = "Relative errors";
            // 
            // lbStatVar
            // 
            this.lbStatVar.AutoSize = true;
            this.lbStatVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatVar.Location = new System.Drawing.Point(461, 83);
            this.lbStatVar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatVar.Name = "lbStatVar";
            this.lbStatVar.Size = new System.Drawing.Size(26, 29);
            this.lbStatVar.TabIndex = 44;
            this.lbStatVar.Text = "0";
            // 
            // lbTerVar
            // 
            this.lbTerVar.AutoSize = true;
            this.lbTerVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTerVar.Location = new System.Drawing.Point(209, 83);
            this.lbTerVar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTerVar.Name = "lbTerVar";
            this.lbTerVar.Size = new System.Drawing.Size(26, 29);
            this.lbTerVar.TabIndex = 43;
            this.lbTerVar.Text = "0";
            // 
            // lbStatMean
            // 
            this.lbStatMean.AutoSize = true;
            this.lbStatMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatMean.Location = new System.Drawing.Point(461, 51);
            this.lbStatMean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatMean.Name = "lbStatMean";
            this.lbStatMean.Size = new System.Drawing.Size(26, 29);
            this.lbStatMean.TabIndex = 42;
            this.lbStatMean.Text = "0";
            // 
            // lbTerMean
            // 
            this.lbTerMean.AutoSize = true;
            this.lbTerMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTerMean.Location = new System.Drawing.Point(209, 51);
            this.lbTerMean.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTerMean.Name = "lbTerMean";
            this.lbTerMean.Size = new System.Drawing.Size(26, 29);
            this.lbTerMean.TabIndex = 41;
            this.lbTerMean.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(264, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Variance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(264, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Math expectation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Variance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Math expectation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(262, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Statistical";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 35;
            this.label2.Text = "Theoretical";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbTF);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbZnac);
            this.panel2.Controls.Add(this.lbTerMean);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbTerVar);
            this.panel2.Controls.Add(this.lbHi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbErVar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbErMean);
            this.panel2.Controls.Add(this.lbStatMean);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.lbStatVar);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(10, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 213);
            this.panel2.TabIndex = 56;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 653);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbZnac;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbHi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbErVar;
        private System.Windows.Forms.Label lbErMean;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbStatVar;
        private System.Windows.Forms.Label lbTerVar;
        private System.Windows.Forms.Label lbStatMean;
        private System.Windows.Forms.Label lbTerMean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lb_trials;
        private System.Windows.Forms.Label lb_prob5;
        private System.Windows.Forms.Label lb_prob4;
        private System.Windows.Forms.Label lb_prob2;
        private System.Windows.Forms.Label lb_prob3;
        private System.Windows.Forms.Label lb_prob1;
        private System.Windows.Forms.NumericUpDown trials;
        private System.Windows.Forms.Label lbProb5;
        private System.Windows.Forms.NumericUpDown nUD4;
        private System.Windows.Forms.NumericUpDown nUD3;
        private System.Windows.Forms.NumericUpDown nUD2;
        private System.Windows.Forms.NumericUpDown nUD1;
        private System.Windows.Forms.Panel panel2;
    }
}

