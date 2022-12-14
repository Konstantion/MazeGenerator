
using MazeGenerator.core.algorithms;
using System;
using System.Collections.Generic;


namespace MazeGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelMazeWidth = new System.Windows.Forms.Label();
            this.numericUpDownMazeSize = new System.Windows.Forms.NumericUpDown();
            this.labelAlgorithmName = new System.Windows.Forms.Label();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.pictureBoxMaze = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.ButtonNextStep = new System.Windows.Forms.Button();
            this.buttonBFS = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelIsRunning = new System.Windows.Forms.Label();
            this.numericUpDownWalls = new System.Windows.Forms.NumericUpDown();
            this.labelWalls = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelOpen = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxOpen = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMazeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWalls)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelSpeed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMazeWidth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownMazeSize, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAlgorithmName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxAlgorithm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxMaze, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStop, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonFinish, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonReset, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonNextStep, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonBFS, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBarSpeed, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelIsRunning, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownWalls, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelWalls, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxName, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelOpen, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonOpen, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxOpen, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1203, 1148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelSpeed
            // 
            this.labelSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(403, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(194, 50);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "Speed";
            this.labelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMazeWidth
            // 
            this.labelMazeWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMazeWidth.AutoSize = true;
            this.labelMazeWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMazeWidth.Location = new System.Drawing.Point(3, 0);
            this.labelMazeWidth.Name = "labelMazeWidth";
            this.labelMazeWidth.Size = new System.Drawing.Size(194, 50);
            this.labelMazeWidth.TabIndex = 2;
            this.labelMazeWidth.Text = "Imput size ";
            this.labelMazeWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMazeSize
            // 
            this.numericUpDownMazeSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMazeSize.AutoSize = true;
            this.numericUpDownMazeSize.Location = new System.Drawing.Point(3, 65);
            this.numericUpDownMazeSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownMazeSize.Name = "numericUpDownMazeSize";
            this.numericUpDownMazeSize.Size = new System.Drawing.Size(194, 20);
            this.numericUpDownMazeSize.TabIndex = 3;
            this.numericUpDownMazeSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMazeSize.ValueChanged += new System.EventHandler(this.numericUpDownMazeSize_ValueChanged);
            // 
            // labelAlgorithmName
            // 
            this.labelAlgorithmName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlgorithmName.AutoSize = true;
            this.labelAlgorithmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlgorithmName.Location = new System.Drawing.Point(203, 0);
            this.labelAlgorithmName.Name = "labelAlgorithmName";
            this.labelAlgorithmName.Size = new System.Drawing.Size(194, 50);
            this.labelAlgorithmName.TabIndex = 4;
            this.labelAlgorithmName.Text = "Algorithm name";
            this.labelAlgorithmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlgorithm.DisplayMember = "Name";
            this.comboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(203, 61);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(194, 28);
            this.comboBoxAlgorithm.TabIndex = 1;
            this.comboBoxAlgorithm.ValueMember = "Id";
            this.comboBoxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgorithm_SelectedIndexChanged);
            // 
            // pictureBoxMaze
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxMaze, 4);
            this.pictureBoxMaze.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaze.Image")));
            this.pictureBoxMaze.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaze.InitialImage")));
            this.pictureBoxMaze.Location = new System.Drawing.Point(203, 203);
            this.pictureBoxMaze.Name = "pictureBoxMaze";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxMaze, 4);
            this.pictureBoxMaze.Size = new System.Drawing.Size(794, 794);
            this.pictureBoxMaze.TabIndex = 0;
            this.pictureBoxMaze.TabStop = false;
            this.pictureBoxMaze.Click += new System.EventHandler(this.pictureBoxMaze_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(603, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(194, 44);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(803, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(194, 44);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinish.Location = new System.Drawing.Point(603, 53);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(194, 44);
            this.buttonFinish.TabIndex = 8;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(1003, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(194, 44);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ButtonNextStep
            // 
            this.ButtonNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNextStep.Location = new System.Drawing.Point(803, 53);
            this.ButtonNextStep.Name = "ButtonNextStep";
            this.ButtonNextStep.Size = new System.Drawing.Size(194, 44);
            this.ButtonNextStep.TabIndex = 8;
            this.ButtonNextStep.Text = "Next";
            this.ButtonNextStep.UseVisualStyleBackColor = true;
            this.ButtonNextStep.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBFS
            // 
            this.buttonBFS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBFS.Location = new System.Drawing.Point(1003, 53);
            this.buttonBFS.Name = "buttonBFS";
            this.buttonBFS.Size = new System.Drawing.Size(194, 44);
            this.buttonBFS.TabIndex = 8;
            this.buttonBFS.Text = "BFS";
            this.buttonBFS.UseVisualStyleBackColor = true;
            this.buttonBFS.Click += new System.EventHandler(this.buttonBFS_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSpeed.LargeChange = 10;
            this.trackBarSpeed.Location = new System.Drawing.Point(403, 53);
            this.trackBarSpeed.Maximum = 100;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(194, 44);
            this.trackBarSpeed.TabIndex = 9;
            this.trackBarSpeed.TickFrequency = 10;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelIsRunning
            // 
            this.labelIsRunning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIsRunning.AutoSize = true;
            this.labelIsRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIsRunning.Location = new System.Drawing.Point(3, 200);
            this.labelIsRunning.Name = "labelIsRunning";
            this.labelIsRunning.Size = new System.Drawing.Size(194, 200);
            this.labelIsRunning.TabIndex = 10;
            this.labelIsRunning.Text = "Execution is stoped";
            this.labelIsRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownWalls
            // 
            this.numericUpDownWalls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownWalls.AutoSize = true;
            this.numericUpDownWalls.Location = new System.Drawing.Point(3, 165);
            this.numericUpDownWalls.Maximum = new decimal(new int[] {
            81,
            0,
            0,
            0});
            this.numericUpDownWalls.Name = "numericUpDownWalls";
            this.numericUpDownWalls.Size = new System.Drawing.Size(194, 20);
            this.numericUpDownWalls.TabIndex = 3;
            this.numericUpDownWalls.ValueChanged += new System.EventHandler(this.numericUpDownMazeSize_ValueChanged);
            // 
            // labelWalls
            // 
            this.labelWalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWalls.AutoSize = true;
            this.labelWalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWalls.Location = new System.Drawing.Point(3, 100);
            this.labelWalls.Name = "labelWalls";
            this.labelWalls.Size = new System.Drawing.Size(194, 50);
            this.labelWalls.TabIndex = 2;
            this.labelWalls.Text = "Delete walls";
            this.labelWalls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(603, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(194, 50);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Input name for saving";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxName.Location = new System.Drawing.Point(803, 103);
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(194, 44);
            this.richTextBoxName.TabIndex = 12;
            this.richTextBoxName.Text = "Лабіринт";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(1003, 103);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(194, 44);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelOpen
            // 
            this.labelOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOpen.AutoSize = true;
            this.labelOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpen.Location = new System.Drawing.Point(603, 150);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(194, 50);
            this.labelOpen.TabIndex = 5;
            this.labelOpen.Text = "Choose file to open";
            this.labelOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(1003, 153);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(194, 44);
            this.buttonOpen.TabIndex = 8;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxOpen
            // 
            this.comboBoxOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOpen.DisplayMember = "Name";
            this.comboBoxOpen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxOpen.FormattingEnabled = true;
            this.comboBoxOpen.Location = new System.Drawing.Point(803, 161);
            this.comboBoxOpen.Name = "comboBoxOpen";
            this.comboBoxOpen.Size = new System.Drawing.Size(194, 28);
            this.comboBoxOpen.TabIndex = 1;
            this.comboBoxOpen.ValueMember = "Id";
            this.comboBoxOpen.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgorithm_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 1061);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMazeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxMaze;
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.Label labelMazeWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownMazeSize;
        private System.Windows.Forms.Label labelAlgorithmName;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ButtonNextStep;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonBFS;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelIsRunning;
        private System.Windows.Forms.NumericUpDown numericUpDownWalls;
        private System.Windows.Forms.Label labelWalls;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox richTextBoxName;
        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxOpen;
    }
}

