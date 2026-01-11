using CFNReader;

namespace CFN2CSV;

public partial class Form1 : Form
{
    private string? _loadedFilePath;
    private CFNReader.FileInfo? _fileInfo;

    public Form1()
    {
        InitializeComponent();
    }

    private async void btnOpenCFN_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _loadedFilePath = openFileDialog.FileName;
            btnSaveCSV.Enabled = false;
            lblStatus.Text = "Loading file...";
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;

            try
            {
                await using var stream = File.OpenRead(_loadedFilePath);
                var reader = new CFNStreamReader(stream);
                _fileInfo = await reader.ReadFileInfoAsync();

                var channelNames = string.Join(", ", _fileInfo.Value.Channels.Keys.Select(c => c.ToString()));
                lblFileInfo.Text = $"File: {Path.GetFileName(_loadedFilePath)}\n" +
                                   $"Sample Rate: {_fileInfo.Value.SampleRate}\n" +
                                   $"Data Points: {_fileInfo.Value.Datapoints}\n" +
                                   $"Channels: {channelNames}";

                btnSaveCSV.Enabled = true;
                lblStatus.Text = "File loaded successfully. Click 'Save as CSV...' to export.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblFileInfo.Text = "No file loaded";
                lblStatus.Text = "";
                _loadedFilePath = null;
                _fileInfo = null;
            }
            finally
            {
                progressBar.Visible = false;
            }
        }
    }

    private async void btnSaveCSV_Click(object sender, EventArgs e)
    {
        if (_loadedFilePath == null) return;

        saveFileDialog.FileName = Path.GetFileNameWithoutExtension(_loadedFilePath) + ".csv";

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            btnOpenCFN.Enabled = false;
            btnSaveCSV.Enabled = false;
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            lblStatus.Text = "Converting to CSV...";

            try
            {
                await using var inputStream = File.OpenRead(_loadedFilePath);
                await using var outputStream = File.Create(saveFileDialog.FileName);

                var options = new CFNCSVConverterOptions
                {
                    Channels = [Channel.VBusVoltage, Channel.VBusCurrent, Channel.DPlusVoltage, Channel.DMinusVoltage, Channel.Power, Channel.AccumulatedCapacity, Channel.AccumulatedEnergy],
                    Predicate = _ => true,
                    Separator = ",",
                    IncludeHeader = true,
                    IncludeTime = true,
                    IncludeUnit = true
                };
                var converter = new CFNCSVConverter(options);
                await converter.ConvertToCSVAsync(inputStream, outputStream);

                lblStatus.Text = $"CSV saved successfully to {Path.GetFileName(saveFileDialog.FileName)}";
                MessageBox.Show("Conversion completed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting file: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Conversion failed.";
            }
            finally
            {
                btnOpenCFN.Enabled = true;
                btnSaveCSV.Enabled = true;
                progressBar.Visible = false;
            }
        }
    }
}
