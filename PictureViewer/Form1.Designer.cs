namespace PictureViewer;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        checkBox1 = new System.Windows.Forms.CheckBox();
        flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        showButton = new System.Windows.Forms.Button();
        clearButton = new System.Windows.Forms.Button();
        backgroundButton = new System.Windows.Forms.Button();
        closeButton = new System.Windows.Forms.Button();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        colorDialog1 = new System.Windows.Forms.ColorDialog();
        tableLayoutPanel1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.463709F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.53629F));
        tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
        tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.15956F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.8404403F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1523, 806);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(2, 745);
        checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(177, 49);
        checkBox1.TabIndex = 1;
        checkBox1.Text = "Stretch";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(showButton);
        flowLayoutPanel1.Controls.Add(clearButton);
        flowLayoutPanel1.Controls.Add(backgroundButton);
        flowLayoutPanel1.Controls.Add(closeButton);
        flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
        flowLayoutPanel1.Location = new System.Drawing.Point(313, 745);
        flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new System.Drawing.Size(1208, 58);
        flowLayoutPanel1.TabIndex = 2;
        // 
        // showButton
        // 
        showButton.AutoSize = true;
        showButton.Location = new System.Drawing.Point(982, 3);
        showButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        showButton.Name = "showButton";
        showButton.Size = new System.Drawing.Size(224, 51);
        showButton.TabIndex = 0;
        showButton.Text = "Show a picture";
        showButton.UseVisualStyleBackColor = true;
        showButton.Click += new System.EventHandler(this.showButton_Click);
        // 
        // clearButton
        // 
        clearButton.AutoSize = true;
        clearButton.Location = new System.Drawing.Point(732, 3);
        clearButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        clearButton.Name = "clearButton";
        clearButton.Size = new System.Drawing.Size(246, 51);
        clearButton.TabIndex = 1;
        clearButton.Text = "Clear the picture";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
        // 
        // backgroundButton
        // 
        backgroundButton.AutoSize = true;
        backgroundButton.Location = new System.Drawing.Point(364, 3);
        backgroundButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        backgroundButton.Name = "backgroundButton";
        backgroundButton.Size = new System.Drawing.Size(364, 51);
        backgroundButton.TabIndex = 2;
        backgroundButton.Text = "Set the background color";
        backgroundButton.UseVisualStyleBackColor = true;
        backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
        // 
        // closeButton
        // 
        closeButton.AutoSize = true;
        closeButton.Location = new System.Drawing.Point(259, 3);
        closeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        closeButton.Name = "closeButton";
        closeButton.Size = new System.Drawing.Size(101, 51);
        closeButton.TabIndex = 3;
        closeButton.Text = "Close";
        closeButton.UseVisualStyleBackColor = true;
        closeButton.Click += new System.EventHandler(this.closeButton_Click);
        // 
        // pictureBox1
        // 
        tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
        pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        pictureBox1.Location = new System.Drawing.Point(3, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(1517, 736);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // openFileDialog1
        // 
        openFileDialog1.Filter = ("JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" + "s (*.*)|*.*");
        openFileDialog1.Title = "Select a picture file";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1523, 806);
        Controls.Add(tableLayoutPanel1);
        Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
        Text = "Picture Viewer";
        tableLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ColorDialog colorDialog1;

    private System.Windows.Forms.Button showButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Button backgroundButton;
    private System.Windows.Forms.Button closeButton;

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}