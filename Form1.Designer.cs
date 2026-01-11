namespace CFN2CSV;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.btnOpenCFN = new System.Windows.Forms.Button();
        this.btnSaveCSV = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.lblFileInfo = new System.Windows.Forms.Label();
        this.progressBar = new System.Windows.Forms.ProgressBar();
        this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
        this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        this.SuspendLayout();
        //
        // btnOpenCFN
        //
        this.btnOpenCFN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnOpenCFN.Location = new System.Drawing.Point(50, 50);
        this.btnOpenCFN.Name = "btnOpenCFN";
        this.btnOpenCFN.Size = new System.Drawing.Size(200, 50);
        this.btnOpenCFN.TabIndex = 0;
        this.btnOpenCFN.Text = "Open CFN File...";
        this.btnOpenCFN.UseVisualStyleBackColor = true;
        this.btnOpenCFN.Click += new System.EventHandler(this.btnOpenCFN_Click);
        //
        // btnSaveCSV
        //
        this.btnSaveCSV.Enabled = false;
        this.btnSaveCSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnSaveCSV.Location = new System.Drawing.Point(270, 50);
        this.btnSaveCSV.Name = "btnSaveCSV";
        this.btnSaveCSV.Size = new System.Drawing.Size(200, 50);
        this.btnSaveCSV.TabIndex = 1;
        this.btnSaveCSV.Text = "Save as CSV...";
        this.btnSaveCSV.UseVisualStyleBackColor = true;
        this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
        //
        // lblFileInfo
        //
        this.lblFileInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblFileInfo.Location = new System.Drawing.Point(50, 120);
        this.lblFileInfo.Name = "lblFileInfo";
        this.lblFileInfo.Size = new System.Drawing.Size(420, 80);
        this.lblFileInfo.TabIndex = 2;
        this.lblFileInfo.Text = "No file loaded";
        //
        // progressBar
        //
        this.progressBar.Location = new System.Drawing.Point(50, 210);
        this.progressBar.Name = "progressBar";
        this.progressBar.Size = new System.Drawing.Size(420, 23);
        this.progressBar.TabIndex = 3;
        this.progressBar.Visible = false;
        //
        // lblStatus
        //
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblStatus.Location = new System.Drawing.Point(50, 245);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(420, 23);
        this.lblStatus.TabIndex = 4;
        this.lblStatus.Text = "";
        //
        // openFileDialog
        //
        this.openFileDialog.Filter = "CFN Files (*.cfn)|*.cfn|All Files (*.*)|*.*";
        this.openFileDialog.Title = "Open CFN File";
        //
        // saveFileDialog
        //
        this.saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
        this.saveFileDialog.Title = "Save as CSV";
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(520, 290);
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.progressBar);
        this.Controls.Add(this.lblFileInfo);
        this.Controls.Add(this.btnSaveCSV);
        this.Controls.Add(this.btnOpenCFN);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "CFN to CSV Converter";
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Button btnOpenCFN;
    private System.Windows.Forms.Button btnSaveCSV;
    private System.Windows.Forms.Label lblFileInfo;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
}
