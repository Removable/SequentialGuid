//-----------------------------------------------------------------------
// <copyright file="SequentialGuidDemoForm.Designer.cs" company="Jeremy H. Todd">
//     Copyright © Jeremy H. Todd 2011
// </copyright>
//-----------------------------------------------------------------------
namespace SequentialGuid.Demo 
{
  /// <summary>
  /// The demonstration form for sequential GUIDs.
  /// </summary>
  public partial class SequentialGuidDemoForm 
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>The button that begins GUID generation.</summary>
    private System.Windows.Forms.Button generateButton;
    
    /// <summary>The ComboBox specifying the GUID generation method.</summary>
    private System.Windows.Forms.ComboBox methodComboBox;
    
    /// <summary>The TextBox that contains the comments.</summary>
    private System.Windows.Forms.TextBox commentsTextBox;
    
    /// <summary>The label for the method ComboBox.</summary>
    private System.Windows.Forms.Label methodLabel;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) 
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
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
            this.generateButton = new System.Windows.Forms.Button();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(18, 94);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(141, 30);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(18, 42);
            this.methodComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(140, 25);
            this.methodComboBox.TabIndex = 1;
            this.methodComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodComboBox_SelectedIndexChanged);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentsTextBox.BackColor = System.Drawing.Color.White;
            this.commentsTextBox.ForeColor = System.Drawing.Color.Black;
            this.commentsTextBox.Location = new System.Drawing.Point(177, 412);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(636, 156);
            this.commentsTextBox.TabIndex = 4;
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(14, 21);
            this.methodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(95, 17);
            this.methodLabel.TabIndex = 0;
            this.methodLabel.Text = "Select Method:";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(177, 13);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(636, 392);
            this.resultsTextBox.TabIndex = 5;
            this.resultsTextBox.Text = "";
            // 
            // SequentialGuidDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 585);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.generateButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SequentialGuidDemoForm";
            this.Text = "SequentialGuid Demonstration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.RichTextBox resultsTextBox;
    }
}